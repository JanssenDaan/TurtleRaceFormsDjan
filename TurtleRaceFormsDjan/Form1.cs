using TheDLL;
namespace TurtleRaceFormsDjan
{
    public partial class Form1 : Form
    {

        public Helpers Helpers = new Helpers();
        public Racer racerDjan = new Racer()
        {
            NameDjan = "Aapje",
        };
        public Random RandomNmbrDjan { get; set; }

        public int positionDjan;
        public int positionXDjan;
        public double timeElapsedDjan;
        public void ChangeRandomNumberDjan(int min, int max)
        {
            int r = Helpers.RandomNumber(1, 10);
            //Change racers random nmbr
            RandomNmbrDjan = new Random();
            racerDjan.RandomValueDjan = RandomNmbrDjan.Next(min, max);

            
        }

        public Form1()
        {
            InitializeComponent();
            //create the racer
            racerDjan = new Racer()
            {
                NameDjan = "Aapje",

            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Loading when forms loads
        }

        private void btnStartDjan_Click(object sender, EventArgs e)
        {
            //Changes random nmbr, Set speed, start timer en do buttons
            ChangeRandomNumberDjan(5,16);
            lblCurrentSpeedValueDjan.Text = racerDjan.RandomValueDjan.ToString();
            tmrDjan.Start();
            btnResetDjan.Enabled = false;
            btnStartDjan.Enabled = false;
            Helpers.ShowMessage("Help", "Title");
        }

        private void btnResetDjan_Click(object sender, EventArgs e)
        {
            racerDjan = new Racer()
            {
                NameDjan = "Aapje",
            };
            positionDjan = 12; 
            positionXDjan = 12; 
            timeElapsedDjan = 0;

            lblCurrentSpeedValueDjan.Text = "";
            lblLapsFinishedValueDjan.Text = "";
            lblRaceTimeValueDjan.Text = "";
    }

        private void tmrDjan_Tick(object sender, EventArgs e)
        {
            timeElapsedDjan = timeElapsedDjan + 0.01;

            Point pointDjan = new Point(12, 170);
            positionXDjan = pcbTurtleDjan.Location.X;
            positionDjan = positionDjan + racerDjan.RandomValueDjan + (racerDjan.LabcountDjan * 3);
            pcbTurtleDjan.Location = new Point(positionDjan, 170);
            lblCurrentSpeedValueDjan.Text = racerDjan.RandomValueDjan.ToString() ;

            if (positionXDjan >= 600)
            {
                racerDjan.LabcountDjan = racerDjan.LabcountDjan + 1 ;
                lblLapsFinishedValueDjan.Text = racerDjan.LabcountDjan.ToString();
                ChangeRandomNumberDjan(5, 16);
                lblRaceTimeValueDjan.Text = timeElapsedDjan.ToString().Substring(0,3);
                
                pcbTurtleDjan.Location = pointDjan;
                positionXDjan = 12;
                pcbTurtleDjan.Update();
                positionDjan = 12;
                timeElapsedDjan = 0;
                
                btnResetDjan.Enabled = true;
                btnStartDjan.Enabled = true;
            }
        }
    }
}