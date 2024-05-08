namespace BallApp {
    public partial class Form1 : Form {
        private double posX; private double posY;
        private double moveX; private double moveY;
        public Form1() {
            InitializeComponent();
            moveX=moveY=10;
        }
        //フォームが最初にロードされるとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e) {
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e) { 

            PictureBox pictureBox = new PictureBox();
            pb.Size=new Size(50,50);
            Soccerball soccerBall=new Soccerball(0,0);

            pb
            pb.Location=new Point((int)posX, (int)posY);
        }
    }
}
