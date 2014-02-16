using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace XnbExtractor.Classes
{
    public class ContentManagerProvider : Game
    {
        #region Constructor
        public ContentManagerProvider(Action<ContentManager> contentReady)
        {
            var graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 1,
                PreferredBackBufferHeight = 1
            };
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
        #endregion


        #region Overrides of Game
        protected override void BeginRun()
        {
            Window.Hide();
            OnContentReady();
        }
        #endregion
    }
}
