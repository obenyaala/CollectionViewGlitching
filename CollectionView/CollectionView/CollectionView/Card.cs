using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionView
{
    class Card
    {
        public CustomStackLayout FrontStack { get; set; }


        public ICommand FlipCard => new Command(FlipCardCmd);
        private async void FlipCardCmd()
        {
            await FrontStack.RotateYTo(FrontStack.RotationY + 180);
            if (FrontStack.BackgroundColor == Color.Red)
            {
                FrontStack.BackgroundColor = Color.Yellow;
            }
            else
            {
                FrontStack.BackgroundColor = Color.Red;
            }
        }
    }
}
