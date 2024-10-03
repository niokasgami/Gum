using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Avalonia;

#if !__IOS__
using Microsoft.Xna.Framework.Media;
#endif

namespace MonoGameRenderer
{
    public class RendererGame : Microsoft.Xna.Framework.Game
    {
        public static RendererGame Instance { get; private set; }
        public static Viewport Viewport { get { return Instance.GraphicsDevice.Viewport; } }
        public static Vector2 ScreenSize { get { return new Vector2(Viewport.Width, Viewport.Height); } }
        public static GameTime GameTime { get; private set; }

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private AvaloniaGameRenderer _avaloniaRenderer;
        private Point _previousResolution;

        bool paused = false;
        public RendererGame()
        {
            Instance = this;

            _graphics = new GraphicsDeviceManager(this);
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Content.RootDirectory = "Content";

            _avaloniaRenderer = new(GraphicsDevice);
            _avaloniaRenderer.Resolution = _previousResolution;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

#if !__IOS__
            //Known issue that you get exceptions if you use Media PLayer while connected to your PC
            //See http://social.msdn.microsoft.com/Forums/en/windowsphone7series/thread/c8a243d2-d360-46b1-96bd-62b1ef268c66
            //Which means its impossible to test this from VS.
            //So we have to catch the exception and throw it away
            try
            {
                MediaPlayer.IsRepeating = true;
                //MediaPlayer.Play(Sound.Music);
            }
            catch { }
#endif
        }

        protected override void Update(GameTime gameTime)
        {
            UpdateAvalonia();
            GameTime = gameTime;

#if !__IOS__
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
#endif

            if (!paused)
            {
                // TODO: Add your update logic here
            }

            Console.WriteLine("Update");

            base.Update(gameTime);
        }

        private void UpdateAvalonia()
        {
            if (_previousResolution != GraphicsDevice.Viewport.Bounds.Size)
            {
                _previousResolution = GraphicsDevice.Viewport.Bounds.Size;
                _avaloniaRenderer.Resolution = _previousResolution;
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            _avaloniaRenderer.Begin();

            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);

            _avaloniaRenderer.End();
        }
    }
}
