using int20h_two.Views;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace int20h_two
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Register_1 page = new Register_1();
            await Navigation.PushAsync(page);

        }
    }

    public class DataUserProcessing
    {
        private int TypeOfTrainigWithoutYourProblem;
        public string TotalTraining;
        private void ProcessingBodyInformation(int weightBody, int ageOfPerson, ref int OurTypeOfTrainnig)
        {
            if (weightBody <= 0 || ageOfPerson <= 0)
            {
                //Write alert: Please write all information about your body
            }
            else if (ageOfPerson <= 18 & (weightBody >=40 && weightBody <= 85))
            {
                OurTypeOfTrainnig = 1;
            }else if( ageOfPerson <= 35 && (weightBody >50 && weightBody <=100))
            {
                OurTypeOfTrainnig = 2;
            }else if(ageOfPerson <= 50 && (weightBody >=60 && weightBody <= 120))
            {
                OurTypeOfTrainnig = 3;
            }else if(ageOfPerson >50 &&(weightBody>=60 && weightBody <= 120))
            {
                OurTypeOfTrainnig = 4;
            }
            else
            {
                // You have weight problems. You need medica advice!
            }
        }
        DataUserProcessing(int weightBody, int ageOfPerson, string PersonProblem)
        {
            ProcessingBodyInformation(weightBody, ageOfPerson, ref TypeOfTrainigWithoutYourProblem);
            switch (PersonProblem) { 
                case "back" when TypeOfTrainigWithoutYourProblem == 1:
                case "back" when TypeOfTrainigWithoutYourProblem == 2:
                case "back" when TypeOfTrainigWithoutYourProblem == 3:
                case "back" when TypeOfTrainigWithoutYourProblem == 4:
                    TotalTraining = "1";
                    break;

                case "legs" when TypeOfTrainigWithoutYourProblem == 1:
                case "legs" when TypeOfTrainigWithoutYourProblem == 2:
                case "legs" when TypeOfTrainigWithoutYourProblem == 3:
                case "legs" when TypeOfTrainigWithoutYourProblem == 4:
                    TotalTraining = "2";
                    break;

                case "neck" when TypeOfTrainigWithoutYourProblem == 1:
                case "neck" when TypeOfTrainigWithoutYourProblem == 2:
                case "neck" when TypeOfTrainigWithoutYourProblem == 3:
                case "neck" when TypeOfTrainigWithoutYourProblem == 4:
                    TotalTraining = "3";
                    break;

                case "eyes" when TypeOfTrainigWithoutYourProblem == 1:
                case "eyes" when TypeOfTrainigWithoutYourProblem == 2:
                case "eyes" when TypeOfTrainigWithoutYourProblem == 3:
                case "eyes" when TypeOfTrainigWithoutYourProblem == 4:
                    TotalTraining = "4";
                    break;

                case "full" when TypeOfTrainigWithoutYourProblem == 1:
                case "full" when TypeOfTrainigWithoutYourProblem == 2:
                case "full" when TypeOfTrainigWithoutYourProblem == 3:
                case "full" when TypeOfTrainigWithoutYourProblem == 4:
                    TotalTraining = "5";
                    break;
                default:
                    //Please choose your problem at the moment
                    break;
            }
        }
    }
}
