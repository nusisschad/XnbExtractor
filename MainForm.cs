using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XnbExtractor.Classes;

namespace XnbExtractor
{
    public partial class MainForm : Form
    {
        #region Fields
        private ContentServicesProvider _contentServicesProvider;
        private readonly Task _contentProviderTask;
        private Extractor _extractor;
        #endregion


        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            _contentProviderTask = StartContentProviderTask();
            TextBoxTexturesPath.TextChanged += TextBoxTexturesPath_TextChanged;
        }
        #endregion


        #region Events Handlers
        protected override void OnLoad(EventArgs e)
        {
            SetDefaultTexturesPath();
            SetDefaultOutputPath();
            base.OnLoad(e);
        }

        void TextBoxTexturesPath_TextChanged(object sender, EventArgs e)
        {
            var path = GetSelectedTexturesPath();
            SearchForValidAssets(path);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            StopContentProvider();
            base.OnClosing(e);
        }

        private void ButtonBrowseTextures_Click(object sender, EventArgs e)
        {
            BrowseForPath(GetSelectedTexturesPath(), TextBoxTexturesPath);
            var path = GetSelectedTexturesPath();
            SearchForValidAssets(path);
        }

        private void ButtonBrowseOutput_Click(object sender, EventArgs e)
        {
            BrowseForPath(GetSelectedOutputPath(), TextBoxOutputPath);
        }

        private void ButtonExtract_Click(object sender, EventArgs e)
        {
            var outputPath = GetSelectedOutputPath();
            if (!Directory.Exists(outputPath))
            {
                MessageBox.Show(this, "Directory must Exist: \r\n" + outputPath);
                return;
            }
            _extractor.ConvertAssets(outputPath, OnConvertAssetsError);
        }

        protected void OnConvertAssetsError(string errorMessage)
        {
            MessageBox.Show(this, "ConvertAssets: " + errorMessage);
        }

        protected void OnContentServicesReady(IServiceProvider serviceProvider)
        {
            _extractor = new Extractor(serviceProvider);
        }
        #endregion


        #region Internal Implementation
        private void SetDefaultTexturesPath()
        {
            TextBoxTexturesPath.Text = @"C:\";
        }

        private void SetDefaultOutputPath()
        {
            TextBoxOutputPath.Text = @"C:\";
        }

        private void BrowseForPath(string path, Control textBoxPath)
        {
            if (Directory.Exists(path))
            {
                BrowserDialogFolder.SelectedPath = path;
            }
            if (BrowserDialogFolder.ShowDialog() == DialogResult.OK)
            {
                path = BrowserDialogFolder.SelectedPath;
            }
            textBoxPath.Text = path;
        }

        private void SearchForValidAssets(string path)
        {
            if (_extractor != null && Directory.Exists(path))
            {
                var validAssetsNames = _extractor.GetValidTextureAssetsNames(path);
                ListBoxTexturesFound.DataSource = validAssetsNames;
                return;
            }
            ListBoxTexturesFound.DataSource = new List<string>();
        }

        private string GetSelectedTexturesPath()
        {
            var path = TextBoxTexturesPath.Text.Trim();
            return path;
        }

        private string GetSelectedOutputPath()
        {
            var path = TextBoxOutputPath.Text.Trim();
            return path;
        }

        private Task StartContentProviderTask()
        {
            return Task.Factory.StartNew(() =>
            {
                _contentServicesProvider = new ContentServicesProvider(OnContentServicesReady);
                _contentServicesProvider.Run();
            });
        }

        private void StopContentProvider()
        {
            if (_contentServicesProvider != null)
            {
                _contentServicesProvider.Exit();
            }
            if (_contentProviderTask != null)
            {
                _contentProviderTask.Wait();
            }
        }
        #endregion
    }
}
