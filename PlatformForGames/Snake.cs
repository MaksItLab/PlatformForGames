using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlatformForGames
{
    public partial class Snake : Form
    {

        private int fruitX, fruitY;
        private PictureBox fruit;
        private int _width = 900;
        private int _height = 800;
        private int _sizeOfOneBlock = 40;
        private int dirX, dirY;


        public Snake()
        {
            InitializeComponent();
            dirX = 1;
            dirY = 0;
            this.Width = _width;
            this.Height = _height;
            
            fruit = new PictureBox();
            fruit.BackColor = Color.Red;
            fruit.Size = new Size(_sizeOfOneBlock, _sizeOfOneBlock);
            timer1.Tick += new EventHandler(Update);
            timer1.Interval = 500;
            timer1.Start();
            this.KeyDown += new KeyEventHandler(Move);


            GenerateMap();
            GenerateFruit();
            
            
        }

        private void GenerateFruit()
        {
            Random r = new Random();
            fruitX = r.Next(0, _width - _sizeOfOneBlock -100);
            int tempX = fruitX % _sizeOfOneBlock;
            fruitX -= tempX;
            fruitY = r.Next(0, _height - _sizeOfOneBlock);
            int tempY = fruitY % _sizeOfOneBlock;
            fruitY -= tempY;
            fruit.Location = new Point(fruitX, fruitY);
            this.Controls.Add(fruit);
        }

        private void GenerateMap()
        {
            for (int i = 0; i < _width / _sizeOfOneBlock; i++)
            {
                PictureBox picBox = new PictureBox();
                picBox.BackColor = Color.Black;
                picBox.Size = new Size(_width - 100, 1);
                picBox.Location = new Point(0, i*_sizeOfOneBlock);
                this.Controls.Add(picBox);
            }

            for (int i = 0; i <= _height / _sizeOfOneBlock; i++)
            {
                PictureBox picBox = new PictureBox();
                picBox.BackColor = Color.Black;
                picBox.Size = new Size(1, _height);
                picBox.Location = new Point(i * _sizeOfOneBlock, 0);
                this.Controls.Add(picBox);
            }
        }


        private void Update (Object Object, EventArgs eventArgs)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + _sizeOfOneBlock*dirX, pictureBox1.Location.Y + _sizeOfOneBlock*dirY);
        }

        private void Move(object sender, KeyEventArgs e) 
        { 

            switch (e.KeyCode.ToString())
            {
                case "Up":
                    dirX = 0;
                    dirY = -1;
                    break;

                case "Down":
                    dirX = 0;
                    dirY = 1;
                    break;

                case "Right":
                    dirX = 1;
                    dirY = 0;
                    break;

                case "Left":
                    dirX = -1;
                    dirY = 0;
                    break;
            }

        }

        private void Snake_Load(object sender, EventArgs e)
        {

        }
    }
}
