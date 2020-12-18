using System;
using System.Windows.Forms;

namespace CarRacingGame
{
    class CarAI : Game
    {
        Random rand = new Random();

        // Inehrit base class constructor parameters
        public CarAI(PictureBox player, PictureBox aiCar1, PictureBox aiCar2, PictureBox aiCar3) : base(player, aiCar1, aiCar2, aiCar3)
        {

        }

        // Default image size
        private void ResetSize(PictureBox aiCar)
        {
            aiCar.Width = 41;
            aiCar.Height = 85;
        }

        //Randomize images for aiCars
        private void ChangeImage(PictureBox aiCar)
        {
            int num = rand.Next(1, 7);

            switch (num)
            {
                case 1:
                    aiCar.Image = Properties.Resources.brownCar1;
                    ResetSize(aiCar); // Restore image to default size
                    break;

                case 2:
                    aiCar.Image = Properties.Resources.greenCar1;
                    ResetSize(aiCar);
                    break;

                case 3:
                    aiCar.Image = Properties.Resources.greenTruck;
                    // Custom image size for truck
                    aiCar.Width = 45;
                    aiCar.Height = 106;
                    break;

                case 4:
                    aiCar.Image = Properties.Resources.redTruck;
                    // Custom image size for truck
                    aiCar.Width = 45;
                    aiCar.Height = 106;
                    break;

                case 5:
                    aiCar.Image = Properties.Resources.policeCar;
                    ResetSize(aiCar);
                    break;

                case 6:
                    aiCar.Image = Properties.Resources.orangeCar1;
                    ResetSize(aiCar);
                    break;

                default:
                    break;
            }
        }

        //Move aiCars down track
        public void Run()
        {
            //How fast to move ai cars
            aiCar1.Top += AISpeed;
            aiCar2.Top += AISpeed;
            aiCar3.Top += AISpeed;

            //Once the top of the car reaches the boundary bring to top and randomize position
            if (aiCar1.Top > Boundary)
            {
                aiCar1.Top = BackToTop;
                aiCar1.Left = rand.Next(15, 100);
                ChangeImage(aiCar1); //Once car passes boundary change image
            }
            if (aiCar2.Top > Boundary)
            {
                aiCar2.Top = BackToTop;
                aiCar2.Left = rand.Next(100, 250);
                ChangeImage(aiCar2);
            }
            if (aiCar3.Top > Boundary)
            {
                aiCar3.Top = BackToTop;
                aiCar3.Left = rand.Next(250, 325);
                ChangeImage(aiCar3);
            }
        }

        public bool Collide()
        {
            // If playerCar collides with aiCar return true
            if (playerCar.Bounds.IntersectsWith(aiCar1.Bounds) || playerCar.Bounds.IntersectsWith(aiCar2.Bounds) || playerCar.Bounds.IntersectsWith(aiCar3.Bounds))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
