using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MessageDialog message;
        public MainPage()
        {
            this.InitializeComponent();
        }

        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MediaElement mediaElement = new MediaElement();
        //    var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
        //    Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Hello, World!");
        //    mediaElement.SetSource(stream, stream.ContentType);
        //    mediaElement.Play();
        //    this.button.Content = "Clicked";


        //}        

        private void Surname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private async void submit_clicked(object sender, RoutedEventArgs e)
        {
            if (this.Name.Text.Equals("") || this.Surname.Text.Equals("") || this.Salary.Text.Equals("") ||
                this.Bonus.Text.Equals("") || this.Category.Text.Equals(""))
            {
                message = new MessageDialog("Please Fill in all the fields");
                await message.ShowAsync();
            }
            else
            {
                message = new MessageDialog("The data is saved");
                await message.ShowAsync();
            }
        }
        


    }
}
