using System;
using System.Windows.Forms;

namespace Racetrack_Simulator
{
    public class Race
    {
        public int tracklength = 519, startingPosition;
        public int[] location = new int[4];
        public Random random = new Random();
        public Dog winner;
        public Dog[] dogs;

        public void GoToStart(Dog[] doglist)
        {
            dogs = doglist;
            for (int i = 0; i < 4; i++)
            {
                dogs[i].myPictureBox.Left = 14;
                location[i] = 0;
            }
        }

        public void StartRace(Timer timer)
        {
            timer.Start();
        }

        public Dog ReturnWinner()
        {
            return winner;
        }
    }
}
