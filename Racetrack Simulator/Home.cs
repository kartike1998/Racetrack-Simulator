using System;
using System.Windows.Forms;

namespace Racetrack_Simulator
{
    public partial class Home : Form
    {
        public Bet[] bets = new Bet[3];
        public Guy[] guys = new Guy[3];
        public Dog[] dogs = new Dog[4];
        public byte currentGuy;
        public Race newRace = new Race();

        public Home()
        {
            InitializeComponent();
            guys[0] = new Guy() { name = "Joe", cash = 50, myRadioButton = joeRadioButton };
            guys[1] = new Guy() { name = "Bob", cash = 75, myRadioButton = bobRadioButton };
            guys[2] = new Guy() { name = "Al", cash = 45, myRadioButton = alRadioButton };
            dogs[0] = new Dog() { number = 1, myPictureBox = dogPicture1 };
            dogs[1] = new Dog() { number = 2, myPictureBox = dogPicture2 };
            dogs[2] = new Dog() { number = 3, myPictureBox = dogPicture3 };
            dogs[3] = new Dog() { number = 4, myPictureBox = dogPicture4 };
        }

        private void PlaceBetButton_Click(object sender, EventArgs e)
        {
            bets[currentGuy] = new Bet();
            bool done = guys[currentGuy].PlaceBet((int)amountBox.Value, (byte)dogBox.Value, bets[currentGuy]);
            if (done)
            {
                switch (currentGuy)
                {
                    case 0:
                        bets[currentGuy].UpdateLabel(joeBetLabel);
                        break;
                    case 1:
                        bets[currentGuy].UpdateLabel(bobBetLabel);
                        break;
                    case 2:
                        bets[currentGuy].UpdateLabel(alBetLabel);
                        break;
                }
                guys[currentGuy].UpdateRadioButton();
            }
            else
                bets[currentGuy] = null;
        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe bets $";
            currentGuy = 0;
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob bets $";
            currentGuy = 1;
        }

        private void AlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al bets $";
            currentGuy = 2;
        }

        private void RaceButton_Click(object sender, EventArgs e)
        {
            bettingParlor.Enabled = false;
            newRace.GoToStart(dogs);
            newRace.StartRace(raceTimer);
        }

        public void Distribute(Dog raceWinner)
        {
            string betWinners = "";
            for (int i = 0; i < 3; i++)
                if (bets[i].dogNumber == raceWinner.number)
                {
                    bets[i].bettor.ReceivePrize();
                    betWinners = bets[i].bettor.name + '\n';
                }
            MessageBox.Show("Bets won:\n" + betWinners, "Bet winners");
        }

        public void Reset()
        {
            bets = new Bet[3];
            joeBetLabel.Text = "Joe hasn't placed a bet";
            bobBetLabel.Text = "Bob hasn't placed a bet";
            alBetLabel.Text = "Al hasn't placed a bet";
            amountBox.Value = 5;
            dogBox.Value = 1;
            bettingParlor.Enabled = true;
        }

        private void RaceTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                newRace.location[i] += dogs[i].Run(newRace.random);
                if (newRace.location[i] >= newRace.tracklength)
                {
                    newRace.winner = dogs[i];
                    raceTimer.Stop();
                    MessageBox.Show("Dog number " + newRace.winner.number + " won the race!", "We have a winner");
                    Distribute(newRace.winner);
                    Reset();
                    break;
                }
            }
        }
    }
}
