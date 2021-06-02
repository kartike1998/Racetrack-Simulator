using System.Windows.Forms;

namespace Racetrack_Simulator
{
    public class Guy
    {
        public string name;
        public int cash;
        public Bet myBet = null;
        public RadioButton myRadioButton;

        public bool PlaceBet(int betAmount, byte dogNo, Bet emptyBet)
        {
            if (cash > betAmount)
            {
                cash -= betAmount;
                myBet = emptyBet;
                myBet.bettor = this;
                myBet.amount = betAmount;
                myBet.dogNumber = dogNo;
                return true;
            }
            else
                MessageBox.Show("I don't have enough cash to place that bet.", name + " says...");
                return false;
        }

        public void UpdateRadioButton()
        {
            myRadioButton.Text = name + " has $" + cash;
        }

        public void ReceivePrize()
        {
            cash += myBet.amount;
            UpdateRadioButton();
        }
    }
}
