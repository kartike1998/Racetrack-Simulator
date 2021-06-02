using System.Windows.Forms;

namespace Racetrack_Simulator
{
    public class Bet
    {
        public Guy bettor;
        public byte dogNumber;
        public int amount;

        public void UpdateLabel(Label myLabel)
        {
            myLabel.Text = bettor.name + " bets $" + amount + " on dog number " + dogNumber;
        }
    }
}
