using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace XnbExtractor.Classes
{
    public class Extractor
    {
        #region Fields
        private readonly IServiceProvider _serviceProvider;
        private ContentManager _contentManager;
        private Dictionary<string, Texture2D> _textures;
        #endregion


        #region Constructor
        public Extractor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        #endregion


        #region Public Methods
        public List<string> GetValidTextureAssetsNames(string path)
        {
            var assetsNames = GetXnbAssetsNames(path);
            _textures = GetValidTextures(path, assetsNames);
            return _textures.Keys.ToList();
        }

        public void ConvertAssets(string outputPath, Action<string> errorAction = null)
        {
            if (_textures != null && _textures.Count > 0)
            {
                foreach (var texture in _textures)
                {
                    var path = Path.Combine(outputPath, texture.Key + ".png");
                    var data = texture.Value;
                    using (var fileStream = File.Open(path, FileMode.Create))
                    {
                        data.SaveAsPng(fileStream, data.Width, data.Height);
                    }
                }
                return;
            }
            if (errorAction != null)
            {
                errorAction.Invoke("Please Browse for Textures Folder Before Attempting Extraction");
            }
        }
        #endregion


        #region Internal Implementation
        private static IEnumerable<string> GetXnbAssetsNames(string path)
        {
            var filesList = Directory.EnumerateFiles(path, "*.xnb", SearchOption.TopDirectoryOnly);
            var assetsNames = filesList.Select(Path.GetFileNameWithoutExtension)
                                       .Where(fileName => !String.IsNullOrWhiteSpace(fileName));
            return assetsNames;
        }

        private Dictionary<string, Texture2D> GetValidTextures(string path, IEnumerable<string> assetsNames)
        {
            ChangeContentManager(_serviceProvider, path);
            var dict = new Dictionary<string, Texture2D>();
            foreach (var assetName in assetsNames)
            {
                var texture = LoadTextureOrNull(_contentManager, assetName);
                if (texture != null)
                {
                    dict.Add(assetName, texture);
                }
            }
            return dict;
        }

        private void ChangeContentManager(IServiceProvider serviceProvider, string path)
        {
            if (_contentManager != null)
            {
                _contentManager.Dispose();
            }
            _contentManager = new ContentManager(_serviceProvider, path);
        }

        private static Texture2D LoadTextureOrNull(ContentManager content, string assetName)
        {
            Texture2D texture = null;
            try
            {
                texture = content.Load<Texture2D>(assetName);
            }
            // ReSharper disable once EmptyGeneralCatchClause            
            catch { } // Not a Texture or Invalid Texture
            return texture;
        }
        #endregion
    }
}