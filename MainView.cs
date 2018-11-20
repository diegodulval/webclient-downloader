using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebClientDownload
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        //https://stackoverflow.com/questions/30199864/download-files-with-c-sharp-windows-forms-and-webclient
        private async void button_ClickAsync(object sender, EventArgs e)
        {
            //Retrieve the path from the input textbox
            string filepath = tbxFilepath.Text.ToString();
            string fileUri = tbxUri.Text.ToString();

            //Create a WebClient to use as our download proxy for the program.
            WebClient webClient = new WebClient();

            //Attach the DownloadFileCompleted event to your new AsyncCompletedEventHandler Completed
            //so when the event occurs the method is called.
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);

            //Attach the DownloadProgressChanged event to your DownloadProgressChangedEventHandler ProgressChanged,
            //so again when the event occurs the method is called.
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

            //Attempt to actually download the file, this is where the error that you
            //won't see is probably occurring, this is because it checks the url in 
            //the blocking function internally and won't execute the download itself 
            //until this clears.
            webClient.DownloadFileAsync(new Uri(fileUri), filepath);
        }

        //Method that just increments the progressBar every time the DownloadProgressChangedEvent from webClient fires.
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        //This is your method that will pop when the AsyncCompletedEvent is fired,
        //this doesn't mean that the download was successful though which is why
        //it's misleading, it just means that the Async process completed.
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download completed!");
        }
    }
}
