namespace BallApp {
    public partial class Form1 : Form {
        SoccerBall soccerBall;
        PictureBox pb;
        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();

        }

        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void timer1_Tick(object sender, EventArgs e) {

            soccerBall.Move();
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {

            pb = new PictureBox();   //�摜��\������R���g���[��
            pb.Size = new Size(50, 50);

           soccerBall = new SoccerBall(e.X,e.Y);

            pb.Image = soccerBall.Image;
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;

            timer1.Start();
        }
    }
}
