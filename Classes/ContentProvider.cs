using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace XnbExtractor.Classes
{
    public class ContentProvider : Game
    {
        #region Constructor
        public ContentProvider(Action<IServiceProvider> contentReady)
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
        private event Action<IServiceProvider> ContentReady;
        protected virtual void OnContentReady()
        {
            var handler = ContentReady;
            if (handler != null)
            {
                handler.Invoke(this.Services);
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
