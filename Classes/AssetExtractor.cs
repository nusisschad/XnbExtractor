#region Using Statements
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

#endregion

namespace XnbExtractor.Classes
{
    public class AssetExtractor : Game
    {
        #region Constructor
        public AssetExtractor(Action<ContentManager> contentReady)
        {
            var graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 1,
                PreferredBackBufferHeight = 1
            };
            Content.RootDirectory = "Content";
            ContentReady += contentReady;
        }
        #endregion


        #region Event Handlers
        private event Action<ContentManager> ContentReady;
        protected virtual void OnContentReady()
        {
            var handler = ContentReady;
            if (handler != null)
            {
                handler.Invoke(Content);
            }
        }


        #region Overrides of Game
        protected override void BeginRun()
        {
            Window.Hide();
            OnContentReady();
        }
        #endregion


        #endregion


        #region Game Overrides
        protected override void LoadContent()
        {
            //OnContentReady();
        }
        #endregion
    }
}
