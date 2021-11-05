using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Lesson_1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D salTexture;
        Texture2D theBob;
        Texture2D thePit;
        Texture2D scorpionTexture;
        Texture2D getOverHere;
        Texture2D icecube;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //Make Window 800x500

            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();
            this.Window.Title = "My First Monogame Project";


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            salTexture = Content.Load<Texture2D>("SalsBestMoment");
            theBob = Content.Load<Texture2D>("58bf1d11e443f41d77c734a5");
            thePit = Content.Load<Texture2D>("maxresdefault");
            scorpionTexture = Content.Load<Texture2D>("Scorpion");
            getOverHere = Content.Load<Texture2D>("getoverhere");
            icecube = Content.Load<Texture2D>("icecube (1)");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Crimson);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(thePit, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(scorpionTexture, new Vector2(50, 400), Color.White);
            _spriteBatch.Draw(icecube, new Vector2(900, 400), Color.White);
            _spriteBatch.Draw(getOverHere, new Vector2(200, 400), Color.White);




            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
