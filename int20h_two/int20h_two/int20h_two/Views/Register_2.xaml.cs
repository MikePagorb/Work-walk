using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace int20h_two.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register_2 : ContentPage
    {
        private  int weight =0 ;
        private  int age = 0;
        public Register_2(string weight, string age)
        {
            InitializeComponent();
            this.weight = int.Parse( weight);
            this.age = int.Parse( age);
            

        }

        private async void prob_Done_button_Clicked(object sender, EventArgs e)
        {

            ExersizesList page = new ExersizesList(DataUserProcessing(this.weight, this.age, ChooseProblems()));
            await Navigation.PushAsync(page);

        }
        private int TypeOfTrainigWithoutYourProblem;
        private void ProcessingBodyInformation(int weightBody, int ageOfPerson, ref int OurTypeOfTrainnig)
        {
            if (weightBody <= 0 || ageOfPerson <= 0)
            {
                //Write alert: Please write all information about your body
            }
            else if (ageOfPerson <= 18 & (weightBody >= 40 && weightBody <= 85))
            {
                OurTypeOfTrainnig = 1;
            }
            else if (ageOfPerson <= 35 && (weightBody > 50 && weightBody <= 100))
            {
                OurTypeOfTrainnig = 2;
            }
            else if (ageOfPerson <= 50 && (weightBody >= 60 && weightBody <= 120))
            {
                OurTypeOfTrainnig = 3;
            }
            else if (ageOfPerson > 50 && (weightBody >= 60 && weightBody <= 120))
            {
                OurTypeOfTrainnig = 4;
            }
            else
            {
                // You have weight problems. You need medica advice!
            }
        }
        private string DataUserProcessing(int weightBody, int ageOfPerson, string PersonProblem)
        {
            string TotalTraining;
            ProcessingBodyInformation(weightBody, ageOfPerson, ref TypeOfTrainigWithoutYourProblem);
            switch (PersonProblem)
            {
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
                    TotalTraining = "0";
                    break;
            }
            return TotalTraining;
        }
        private string ChooseProblems()
        {
            string return1 = "";
            if (ch_1.IsChecked)
            {
                return1 = "Back";
            }
            else if(ch_2.IsChecked){
                return1 = "Legs";
            }
            else if (ch_3.IsChecked)
            {
                return1 = "Neck";
            }
            else if (ch_4.IsChecked)
            {
                return1 = "Eyes" ;
            }
            else if (ch_5.IsChecked)
            {
                return1 ="Full";
            }
            else
            {
                return1 = "Null";
            }

            return return1;
        }
    }
}