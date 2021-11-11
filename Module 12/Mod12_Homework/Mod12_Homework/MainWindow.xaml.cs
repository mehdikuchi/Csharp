﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO;

namespace Mod12_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnWriteFile_Click(object sender, RoutedEventArgs e)
        {
           WriteFile();
        }

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            ReadFile();
        }
        //Adding the async modifier to make the WriteFile method asynchronous
        public async void WriteFile()
        {
            string filePath = @"SampleFile.txt";
            string text = txtContents.Text;
            // Waiting for the file to be written by using await operator (Calling the WriteTextAsync()):
            await WriteTextAsync(filePath, text);
        }
        ///Renaming WriteText to WriteTextAsync and adding the async method modifier to make the method asynchronous
        ///The Task object is returned in order to use this method with the await operator: (Making asynchronous awaitable method)
        private async Task WriteTextAsync(string filePath, string text) 
        {
            byte[] encodedText =  Encoding.Unicode.GetBytes(text);
            //Specifying that the Async method will be used:
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096,useAsync:true))
            {
                //Making necessary changes sourceStream.Write to make it asynchronous:
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            };
        }
        //Making the ReadFile to be asynchronous by async modifier 
        public async void ReadFile()
        {
            string filePath = @"SampleFile.txt";

            if (File.Exists(filePath) == false)
            {
                MessageBox.Show(filePath + " not found", "File Error", MessageBoxButton.OK);
            }
            else
            {
                try
                {
                    //Waiting for the text to be read using await operator
                    string text =await ReadTextAsync(filePath);
                    txtContents.Text = text;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
        //Renaming ReadText to TeadTextAsync and make it asynchronous awaitable method:
        private async Task<string> ReadTextAsync(string filePath)
        {
            //Specifying that the Async method will be used:
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096,useAsync:true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                int numRead;
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.Unicode.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                return sb.ToString();
            }
        }
    }
}
