namespace BallApp {
    public partial class Form1 : Form {
        Obj Ball;
        PictureBox pb;
        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();

        }

        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void timer1_Tick(object sender, EventArgs e) {

            Ball.Move();
            pb.Location = new Point((int)Ball.PosX, (int)Ball.PosY);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {

            pb = new PictureBox();   //�摜��\������R���g���[��
            

            if (e.Button == MouseButtons.Left) {
                Ball = new SoccerBall(e.X-25, e.Y-25);
                pb.Size = new Size(50, 50);
                pb.Image = Ball.Image;
                pb.Location = new Point((int)Ball.PosX, (int)Ball.PosY);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Parent = this;

                timer1.Start();
            }else if(e.Button == MouseButtons.Right) {
                Ball = new TennisBall(e.X-12, e.Y-12);
                pb.Size = new Size(25, 25);
                pb.Image = Ball.Image;
                pb.Location = new Point((int)Ball.PosX, (int)Ball.PosY);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Parent = this;
            }

        }
    }
}
