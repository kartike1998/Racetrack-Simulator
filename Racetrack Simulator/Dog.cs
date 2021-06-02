using System;
using System.Windows.Forms;

namespace Racetrack_Simulator
{
    public class Dog
    {
        public byte number;
        public PictureBox myPictureBox;

        public byte Run(Random random)
        {
            byte move = (byte)random.Next(1, 5);
            myPictureBox.Left += move;
            return move;
        }
    }
}
