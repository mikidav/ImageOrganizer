using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DuplicateFilesOrginaizer
{
    public partial class Form1 : Form
    {
        private int _counter;
        private int _failCounter;
        private int _fileHandeledCounter;
        private int _total;

        public Form1()
        {
            _settings = new ApplicationSettings();
            InitializeComponent();
        }

        private ApplicationSettings _settings { get; set; }

        // Private Methods (15) 

        private void _destinationButton_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialogEx())
            {
                if (folder.ShowDialog() == DialogResult.OK) _destinationTextBox.Text = folder.SelectedPath;
            }
        }

        private void _fileExtensionComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var ext = _settings.Extensions.Where(item => item.Group == _fileExtensionComboBox.Text)
                .Select(item => item.Pattern).ToList();
            var s = string.Join(Environment.NewLine, ext);
            _fileExtensionTextBox.Text = s;
        }

        private void _resetButton_Click(object sender, EventArgs e)
        {
            _settings.Reset();
        }

        private void _sourceButton_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialogEx())
            {
                if (folder.ShowDialog() == DialogResult.OK)
                    _sourceTextBox.Text = folder.SelectedPath;
            }
        }

        private void _startButton_Click(object sender, EventArgs e)
        {
            ReadGuiSettings();
            _fileHandeledCounter = 0;
            _failCounter = 0;
            _total = 0;
            _counter = 0;
            CleanGui();
            var organizer = new Organizer();
            organizer.ProgressChanged += ReceiveOrganizerProgressChangedEvent;
            organizer.RetrieveAllFilesFinished += ReceiveRetrieveAllFilesFinished;
            organizer.OrganizedFile += ReceiveOrganizerOrganizedFileEvent;
            organizer.OrganizedFileFailed += ReceiveOrganizedFileFailedEvent;
            organizer.DuplicateOrganizedFile += ReceiveDuplicateOrganizedFileEvent;
            organizer.Finished += ReceiveOrganizerFinish;
            organizer.RunAnsync(_settings);
        }

        private void CleanGui()
        {
            _mainTabInfoTextBox.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            _fileHandeledTextBox.Text = "";
        }

        private void ReceiveOrganizerFinish(object sender, EventArgs e)
        {
            _mainTabStatusTextBox.Text = "Finish";
            _progressBar.Value = 100;
        }

        private void ReceiveRetrieveAllFilesFinished(object sender, StringEventArgs e)
        {
            int.TryParse(e.Message, out _total);
            ApplyGuiAction(() =>
            {
                _mainTabStatusTextBox.Text = @"Retrieve Search files";
                _mainTabTotalTabTextBox.Text = e.Message;
            });
        }

        private void _updateExtensionButton_Click(object sender, EventArgs e)
        {
            var extensions = new List<FileExtension>();
            foreach (var extension in _settings.Extensions)
                if (extension.Group != _fileExtensionComboBox.Text)
                    extensions.Add(extension);
            var newExtensions = _fileExtensionComboBox.Text.Split(Environment.NewLine.ToCharArray());
            foreach (var newExtension in newExtensions)
                extensions.Add(new FileExtension(_fileExtensionComboBox.Text, newExtension));

            _settings.Extensions = extensions.ToArray();
        }

        private void ApplyGuiAction(MethodInvoker md)
        {
            if (InvokeRequired)
                BeginInvoke(md);
            else
                md.Invoke();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _fileExtensionComboBox.SelectedIndex = 0;
            _settings = _settings.Load();
            _destinationTextBox.Text = _settings.Destination;
            _sourceTextBox.Text = _settings.SearchFolder;
            _mainTabIncludeSubFolderCheckBox.Checked = _settings.SearchOption == SearchOption.AllDirectories;
            _mainTabDeleteDuplicateFiles.Checked = _settings.DeleteDuplicateFiles;
            _mainTabDeleteEmptyFolders.Checked = _settings.DeleteEmptyFolder;

            _excludeFolderCheckBox.Checked = _settings.ExcludeProgramFilesFolder;
            _useFileDateCheckBox.Checked = _settings.UseExifDate;
            _renameDuplicateFileCheckBox.Checked = _settings.RenameAndRemoveDuplicate;
            _splitByGroupsCheckBox.Checked = _settings.SplitByGroups;
            _makeYearFolderCheckBox.Checked = _settings.MakeYearFolder;
            _makeMonthFolderCheckBox.Checked = _settings.MakeMonthFolder;
            _makeMonthFolderNameCheckBox.Checked = _settings.MakeMonthFolderName;
            _imagesCheckBox.Checked = _settings.SearchImages;
            _videosCheckBox.Checked = _settings.SearchVideos;
            _documentsCheckBox.Checked = _settings.SearchDocuments;
            _musicCheckBox.Checked = _settings.SearchMusic;
            _generalCheckBox.Checked = _settings.SearchGeneral;

            switch (_settings.CopyAction)
            {
                case CopyAction.Test:
                    _testRadioButton.Checked = true;
                    break;
                case CopyAction.Move:
                    _moveRadioButton.Checked = true;
                    break;
                case CopyAction.Copy:
                    _copyRadioButton.Checked = true;
                    break;
                default:
                    _testRadioButton.Checked = true;
                    break;
            }
        }

        private void ReadGuiSettings()
        {
            _settings.SearchFolder = _sourceTextBox.Text;
            _settings.Destination = _destinationTextBox.Text;
            _settings.SearchOption = _mainTabIncludeSubFolderCheckBox.Checked
                ? SearchOption.AllDirectories
                : SearchOption.TopDirectoryOnly;
            _settings.DeleteDuplicateFiles = _mainTabDeleteEmptyFolders.Checked;
            _settings.DeleteEmptyFolder = _mainTabDeleteEmptyFolders.Checked;
            _settings.ExcludeProgramFilesFolder = _excludeFolderCheckBox.Checked;
            _settings.UseExifDate = _useFileDateCheckBox.Checked;
            _settings.RenameAndRemoveDuplicate = _renameDuplicateFileCheckBox.Checked;
            _settings.SplitByGroups = _splitByGroupsCheckBox.Checked;
            _settings.MakeYearFolder = _makeYearFolderCheckBox.Checked;
            _settings.MakeMonthFolder = _makeMonthFolderCheckBox.Checked;
            _settings.MakeMonthFolderName = _makeMonthFolderNameCheckBox.Checked;
            _settings.SearchImages = _imagesCheckBox.Checked;
            _settings.SearchVideos = _videosCheckBox.Checked;
            _settings.SearchDocuments = _documentsCheckBox.Checked;
            _settings.SearchMusic = _musicCheckBox.Checked;
            _settings.SearchGeneral = _generalCheckBox.Checked;

            if (_testRadioButton.Checked) _settings.CopyAction = CopyAction.Test;
            if (_copyRadioButton.Checked) _settings.CopyAction = CopyAction.Copy;
            if (_moveRadioButton.Checked) _settings.CopyAction = CopyAction.Move;
        }

        private void ReceiveDuplicateOrganizedFileEvent(object sender, DuplicateEventArgs e)
        {
            ApplyGuiAction(() =>
            {
                richTextBox3.AppendText(e.Message + Environment.NewLine);
                _failCounter++;
                _fileWithErrorTextBox.Text = _failCounter.ToString();
            });
        }

        private void ReceiveOrganizedFileFailedEvent(object sender, StringEventArgs e)
        {
            ApplyGuiAction(() =>
            {
                richTextBox2.AppendText(e.Message + Environment.NewLine);
                _failCounter++;
                _fileWithErrorTextBox.Text = _failCounter.ToString();
            });
        }


        private void ReceiveOrganizerOrganizedFileEvent(object sender, StringEventArgs e)
        {
            ApplyGuiAction(() =>
                {
                    _mainTabInfoTextBox.AppendText(e.Message + Environment.NewLine);
                    _fileHandeledCounter++;
                    _fileHandeledTextBox.Text = _fileHandeledCounter.ToString();
                }
            );
        }

        private void ReceiveOrganizerProgressChangedEvent(object sender, ProgressChangedEventArgs e)
        {
            _counter++;
            ApplyGuiAction(() =>
            {
                if (_total > 0)
                {
                    var i = 100 * (int)((double)_counter / _total);
                    if (i <= _progressBar.Maximum)
                        _progressBar.Value = i;
                }
            });
        }

        private void SaveClick(object sender, EventArgs e)
        {
            ReadGuiSettings();
            _settings.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            processDirectory(_sourceTextBox.Text);
        }


        private static void processDirectory(string startLocation)
        {
            foreach (var directory in Directory.GetDirectories(startLocation))
            {
                processDirectory(directory);
                if (Directory.GetFiles(directory).Length == 0 &&
                    Directory.GetDirectories(directory).Length == 0)
                    Directory.Delete(directory, false);
            }
        }
    }
}