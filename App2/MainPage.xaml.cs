using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Hello, World!");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
            this.button.Content = "Clicked";
            
           
        }
        private void clk_clicked(object sender,RoutedEventArgs e)
        {
            this.clk.Content = "Clicked";            
        }       

        private void clk_holded(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.clk.Content = "Double clicked";
        }

        private void Holder(object sender, HoldingRoutedEventArgs e)
        {
            this.clk.Content = "Holded";
        }

        private void Enter(object sender, KeyRoutedEventArgs e)
        {
            this.clk.Content = e.DeviceId;
        }

        //private void getName(UIElement sender, CharacterReceivedRoutedEventArgs args)
        //{
        //    if (this.Name.Text.Equals("")) {
        //        this.clk.Content="Please Fill in the from";
        //        return;
        //    }


        //}


    }
}
