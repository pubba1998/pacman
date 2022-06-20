

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool goup;
        bool godown;
        bool goleft;
        bool goright;


        int speed = 6;

        //ghost 1 and 2 variables. These guys are sane well sort of
        int ghost1 = 3;
        int ghost2 = 3;
        int ghost3 = 3;
        int ghost4 = 3;


        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }
        void stopPacman()
        {
            godown = false;
            goleft = false;
            goright = false;
            goup = false;
        }
        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void pictureBox1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pacman.Left -= speed;
                pacman.Image = Properties.Resources.left;
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                pacman.Left += speed;
                pacman.Image = Properties.Resources.pacman;
                goright = true;


            }
            if (e.KeyCode == Keys.Up)
            {
                pacman.Top -= speed;
                pacman.Image = Properties.Resources.up;
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                pacman.Top += speed;
                pacman.Image = Properties.Resources.down;
                godown = true;
            }
            else if (e.KeyCode == Keys.S)
                timer1.Enabled = true;
            if (e.KeyCode == Keys.P)
            {
                timer1.Enabled = false;
                MessageBox.Show("game stop");
            }
            else if (e.KeyCode == Keys.Escape)
                Close();
            {

            }

            checkWallHit();
        }
        void checkWallHit()
        {
            foreach (Control x in this.Controls)
            {
                if (goleft == true && (string)x.Tag == "wall")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                    {
                        pacman.Left += speed;
                    }
                }
                else if (goright == true && (string)x.Tag == "wall")
                {
                    if ((((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds)))
                    {
                        pacman.Left -= speed;
                    }
                }
                else if (goup == true && (string)x.Tag == "wall")
                {
                    if ((((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds)))
                    {
                        pacman.Top += speed;
                    }
                }
                else if (godown == true && (string)x.Tag == "wall")
                {
                    if ((((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds)))
                    {
                        pacman.Top -= speed;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            {
                stopPacman();

            }
        }

        private void Pacman_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox231_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                label1.Text = "Score: " + score; // show the score on the board


                //moving ghosts and bumping witht he walls
                redGhost.Left += ghost1;
                yellowGhost.Left += ghost2;
                blueGhost.Left += ghost3;
                pinkGhost.Top += ghost4;
                // if the red ghost hits the picture box 4 then we reverse the speed
                if (redGhost.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    ghost1 = -ghost1;
                }
                // if the red ghost hits the picture box 3 we reverse the speed
                else if (redGhost.Bounds.IntersectsWith(pictureBox6.Bounds))
                {
                    ghost1 = -ghost1;
                }
                // if the yellow ghost hits the picture box 1 then we reverse the speed
                if (yellowGhost.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    ghost2 = -ghost2;
                }
                // if the yellow chost hits the picture box 2 then we reverse the speed
                else if (yellowGhost.Bounds.IntersectsWith(pictureBox6.Bounds))
                {
                    ghost2 = -ghost2;
                }
                //moving ghosts and bumping with the walls end
                // if the yellow ghost hits the picture box 1 then we reverse the speed
                if (blueGhost.Bounds.IntersectsWith(pictureBox6.Bounds))
                {
                    ghost3 = -ghost3;
                }
                // if the yellow chost hits the picture box 2 then we reverse the speed
                else if (blueGhost.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    ghost3 = -ghost3;
                }
                if (pinkGhost.Bounds.IntersectsWith(pictureBox4.Bounds))
                {
                    ghost4 = -ghost4;
                }
                // if the yellow chost hits the picture box 2 then we reverse the speed
                else if (pinkGhost.Bounds.IntersectsWith(pictureBox5.Bounds))
                {
                    ghost4 = -ghost4;
                }
                //for loop to check walls, ghosts and points
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "ghost")
                        // checking if the player hits the wall or the ghost, then game is over
                        if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds) || score == 85)
                    {
                        pacman.Left = 0;
                        pacman.Top = 25;
                        label2.Text = "GAME OVER";
                        label2.Visible = true;
                        timer1.Stop();

                    }
                  
                    {

                    }
                    if (x is PictureBox && x.Tag == "coin")
                    {
                        //checking if the player hits the points picturebox then we can add to the score
                        if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                        {
                            this.Controls.Remove(x); //remove that point
                            score++; // add to the score
                        }
                    }
                }

            }
        }
    }
}