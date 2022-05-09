using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
namespace AlgoritmForegraundPR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          // Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
        }

     /*   public float num1 = 0.8f;
        public float num2 = 0.9f;
        public float num3 = 0.2f;
        public float num4 = 0.1f;

        public float Aceler_dataX = 0.0f;
        public float Aceler_dataY = 0.0f;
        public float Aceler_dataZ = 0.0f;

        public bool c;
        public bool d;

        public int counter;
        public int result;


        void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            var data = e.Reading;
            result = counter / 2;
            Aceler_dataX = data.Acceleration.X;
            Aceler_dataY = data.Acceleration.Y;
            Aceler_dataZ = data.Acceleration.Z;
            Result_Condition();

            Rakaat_1.Text = Convert.ToString(result);

            if (counter / 2 == 3)
            {
                Vibtate_Controll(1);
            }

            else if (counter / 2 == 6)
            {
                Vibtate_Controll(2);
            }

            else if (counter / 2 == 9)
            {
                Vibtate_Controll(3);
            }

        }
     
        public bool ResultCounter_Y_1(bool condition) // checking the condition Y 1 - 0.8 to 0.9
        {
            if (Aceler_dataY >= num1 && Aceler_dataY <= num2)
            {
                condition = true;
            }
            else
            {
                condition = false;
            }
            return condition;
        }

        public bool ResultCounter_Y_2(bool condition) // checking the condition Y 2 - 0.2 to 0.1
        {
            if (Aceler_dataY <= num3 && Aceler_dataY >= num4)
            {
                condition = true;
            }
            else
            {
                condition = false;
            }
            return condition;
        }

        public void Result_Condition() //  Checking the fulfillment of conditions with Accelerometers and output counter +1 in the case of true true
        {

            if (ResultCounter_Y_1(false) == true) { c = true; }
            if (ResultCounter_Y_2(false) == true) { d = true; }

            if (c == true && d == true)
            {
                c = false;
                d = false;
                counter += 1;
            }
        }

        public  void Click_Start(object sender, System.EventArgs e) //Start button
        {
            Accelerometer.Start(SensorSpeed.UI);
            DependencyService.Get<IAndroidService>().StartService();
        }


        public void Click_Stop (object sender, System.EventArgs e) //Stop button
        {
            Accelerometer.Stop();
            DependencyService.Get<IAndroidService>().StopService();
            counter = 0;
            Rakaat_1.Text = "Start counter";

        }

        public async void Vibtate_Controll(int count_vibr) //Vibration control
        {
            var durition = TimeSpan.FromSeconds(0.3);

            for (int i = 0; i < count_vibr; i++)
            {
                Vibration.Vibrate(durition);
                await Task.Delay(700);
            }
        }


        
        */
    }
}
