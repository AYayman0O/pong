using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        public bool GameStarted = false;
        public bool directionx = true;
        public bool directiony = true;
        public Point ballO = new Point(410, 175);

        Dictionary<Keys, (bool, int)> keys = new Dictionary<Keys, (bool, int)>()
        {
            {Keys.Up, (false, -14) },
            {Keys.Down, (false, 14)},
            {Keys.W, (false, -14)},
            {Keys.S,(false, 14) }
        };
        public int BallSpeed
        {
            get { return speedLv; }
            set
            {
                speedLv = value;
                time = time > 15? 50 - 5 * speedLv: 15;
                
            }

        }
        public int time = 50;
        public int speedLv = 0;
        public Form1()
        {
            InitializeComponent();
            Controls.SetChildIndex(ball, 0);
       
        
        }
        private async void Keypressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !GameStarted)
            {
                gameStart();
            }
            else if (keys.ContainsKey(e.KeyCode))
            {
                if (!keys[e.KeyCode].Item1) keepPressing(e.KeyCode);
            }
          
        }
        private async void keepPressing(Keys key)
        {
            keys[key] = (true, keys[key].Item2);
            while (keys[key].Item1)
            {
                if (key == Keys.Up || key == Keys.Down)
                    p1.Location = new Point(p1.Location.X, p1.Location.Y + keys[key].Item2);
                else if (key == Keys.W || key == Keys.S)
                    p2.Location = new Point(p2.Location.X, p2.Location.Y + keys[key].Item2);
                await Task.Delay(time);
            }



        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keys.ContainsKey(e.KeyCode)) keys[e.KeyCode] = (false, keys[e.KeyCode].Item2);
        }

        private async void gameStart()
        {
            GameStarted = true;
            BallSpeed = 0;
            while (GameStarted)
            {
                ball.Location = ballmovement(ball);

                await Task.Delay(time);
            }
        }
        private Point ballmovement(Label L)
        {
            bounce(p1, ball, 1);
            bounce(p2, ball, 0);
            int x = L.Location.X;
            int y = L.Location.Y;

            if (x >= this.Width - 10 || x <= 0)
            {
                gameEnd(x >= this.Width - 10 ? P1score : p2Score);
                return ballO;

            }

            if (y >= this.Height - 50 || y <= 0) directiony = directiony ? false : true;
            int XCh = directionx ? 10 : -10;
            int YCh = directiony ? 10 : -10;
            Point Apoint = new Point(x + XCh, y + YCh);
            return Apoint;
        }
        public void bounce(Label p, Label ball, int sign)
        {

            int Px = p.Location.X + (p.Width * sign);
     
            int Py_upper = p.Location.Y - (ball.Height);
            int Py_down = p.Location.Y + p.Height + (ball.Height);
            int Py_totalH = p.Height + 2 * ball.Height;

            int Bx = sign == 1? ball.Location.X : ball.Location.X + ball.Width;
            int By_upper = ball.Location.Y;
            int By_down = ball.Location.Y + ball.Height;
         
            if (Bx == Px && By_upper >= Py_upper && By_down <= Py_down) {
              
                directionx = directionx ? false : true;
                BallSpeed = speedLv + 1;

                if (By_upper >= Py_upper + 2*Py_totalH / 3 && By_upper <= Py_upper + Py_totalH) directiony = false;
                else if(By_upper >= Py_upper + Py_totalH/3 && By_upper < Py_upper + 2* Py_totalH / 3) directiony = true;
               
                
                 


            }
        }
       
        private void gameEnd(Label winner)
        {
            winner.Text = Convert.ToString(Convert.ToInt16(winner.Text) + 1);
            ball.Location = ballO;
            GameStarted = false;
            BallSpeed = 0;
        }
  
      


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

       
    }
}
