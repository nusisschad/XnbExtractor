using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace XnbExtractor.Classes
{
    public class ContentServicesProvider : Game
    {
        #region Constructor
        public ContentServicesProvider(Action<IServiceProvider> servicesReady)
        {
            var graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = 1,
                PreferredBackBufferHeight = 1
            };
            ServicesReady += servicesReady;
        }
        #endregion


        #region Event Handlers
        private event Action<IServiceProvider> ServicesReady;
        protected virtual void OnServicesReady()
        {
            var handler = ServicesReady;
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
            OnServicesReady();
        }
        #endregion
    }
}
