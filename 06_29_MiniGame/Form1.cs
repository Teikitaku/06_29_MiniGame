using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;
namespace _06_29_MiniGame
{
    public partial class FormTitle : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        //enum ó‘Ô
        enum State
        {
            None = -1,  //‰Šúó‘Ô
            Title,      //Žå‘è
            Game,       //ƒQ[ƒ€‚µ‚Ä‚¢‚é
            Gameover,   //ƒQ[ƒ€‚ªI‚í‚è
            Clear       //•Ð•t‚¯
        }
        //ó‘Ô‰Šú‰»
        State nextState = State.Title;
        State currentState = State.None;

        int score;
        int timer;
        int highScore = 100;
        int StareTimer => 200;



        public FormTitle()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void buttonTitle_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeState();
            UpdateState();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelGameover_Click(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void labelRecord_Click(object sender, EventArgs e)
        {

        }

        private void labelScore_Click(object sender, EventArgs e)
        {

        }

        private void labelCopyright_Click(object sender, EventArgs e)
        {

        }

        void ChangeState()
        {
            if (nextState == State.None)
                return;
            currentState = nextState;
            nextState = State.None;


            switch (currentState)
            {
                case State.Title:
                    labelTitle.Visible = true;
                    labelGameover.Visible = false;
                    labelCopyright.Visible = true;
                    labelRecord.Visible = true;
                    labelScore.Visible = false;
                    labelTime.Visible = false;
                    buttonStart.Visible = true;
                    buttonTitle.Visible = false;
                    break;
                case State.Game:
                    labelTitle.Visible = false;
                    labelGameover.Visible = false;
                    labelCopyright.Visible = false;
                    labelRecord.Visible = false;
                    labelScore.Visible = true;
                    labelTime.Visible = true;
                    buttonStart.Visible = false;
                    buttonTitle.Visible = false;
                    break;
                case State.Gameover:
                    labelTitle.Visible = false;
                    labelGameover.Visible = true;
                    labelCopyright.Visible = false;
                    labelRecord.Visible = false;
                    labelScore.Visible = true;
                    labelTime.Visible = false;
                    buttonStart.Visible = false;
                    buttonTitle.Visible = true;
                    break;
                case State.Clear:
                    break;
            }
        }

        void UpdateState()
        {
            switch (currentState)
            {
                case State Game:
                    UpdateGame();
                    break;
            }

        }

        void UpdateGame()
        {
            if (GetAsyncKeyState((int)Keys.O) > 0)
            {
                nextState = State.Gameover;
            }
            if (GetAsyncKeyState((int)Keys.C) > 0)
            {
                nextState = State.Clear;
            }
        }


    }
}