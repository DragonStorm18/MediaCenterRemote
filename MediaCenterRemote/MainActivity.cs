using Android.App;
using Android.Widget;
using Android.OS;
using Org.Apache.Http.Client;
using System.Json;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using ModernHttpClient;


namespace MediaCenterRemote
{
    [Activity(Label = "MediaCenterRemote", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button Browser = FindViewById<Button>(Resource.Id.internet);
            Button MC = FindViewById<Button>(Resource.Id.btnMEDIA);
            Button UP = FindViewById<Button>(Resource.Id.btnUP);
            Button DOWN = FindViewById<Button>(Resource.Id.btnDOWN);
            Button LEFT = FindViewById<Button>(Resource.Id.btnLEFT);
            Button RIGHT = FindViewById<Button>(Resource.Id.btnRIGHT);
            Button ENTER = FindViewById<Button>(Resource.Id.btnENTER);
            Button INFO = FindViewById<Button>(Resource.Id.btnINFO);
            Button BACK = FindViewById<Button>(Resource.Id.btnBACK);
            Button VOLUP = FindViewById<Button>(Resource.Id.VOLUP);
            Button VOLDOWN = FindViewById<Button>(Resource.Id.VOLDOWN);
            Button SEND = FindViewById<Button>(Resource.Id.btnSend);
            EditText TXT = FindViewById<EditText>(Resource.Id.TexttoSend);
            EditText IP = FindViewById<EditText>(Resource.Id.ipaddress);
            EditText PORT = FindViewById<EditText>(Resource.Id.portNumber);
            Button SAVE = FindViewById<Button>(Resource.Id.btnSave);
            Button TAB = FindViewById<Button>(Resource.Id.btnTAB);


            SAVE.Click += (sender, e) =>
            {
                IP.Enabled = false;
                PORT.Enabled = false;

            };

            TAB.Click += (sender, e) =>
            {


                string url = "http://" + IP.Text + ":" + PORT.Text;
                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "TAB", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            Browser.Click += (sender, e) =>
            {
               

                string url = "http://" + IP.Text + ":" + PORT.Text;
                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "fire", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            MC.Click += (sender, e) =>
            {

                string url = "http://" + IP.Text + ":" + PORT.Text;
                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "media", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            UP.Click += (sender, e) =>
            {


                string url = "http://" + IP.Text + ":" + PORT.Text;
                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "UP", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            DOWN.Click += (sender, e) =>
            {


                string url = "http://" + IP.Text + ":" + PORT.Text;
                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "DOWN", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            LEFT.Click += (sender, e) =>
            {

                string url = "http://" + IP.Text + ":" + PORT.Text;

                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "LEFT", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            RIGHT.Click += (sender, e) =>
            {

                string url = "http://" + IP.Text + ":" + PORT.Text;

                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "RIGHT", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            ENTER.Click += (sender, e) =>
            {

                string url = "http://" + IP.Text + ":" + PORT.Text;

                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "ENTER", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            INFO.Click += (sender, e) =>
            {

                string url = "http://" + IP.Text + ":" + PORT.Text;

                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "INFO", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            BACK.Click += (sender, e) =>
            {

                string url = "http://" + IP.Text + ":" + PORT.Text;

                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "BACK", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            VOLUP.Click += (sender, e) =>
            {

                string url = "http://" + IP.Text + ":" + PORT.Text;

                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "VOLUP", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            VOLDOWN.Click += (sender, e) =>
            {
                string url = "http://" + IP.Text + ":" + PORT.Text;

                var client = new HttpClient(new NativeMessageHandler());
                var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "VOLDOWN", Mute = "true" }));
                var result = client.PostAsync(url, content).ConfigureAwait(true);

            };

            SEND.Click += (sender, e) =>
            {

                string url = "http://" + IP.Text + ":" + PORT.Text;
                string grabtext = TXT.Text;

                if (grabtext == "")
                {
                    grabtext = "nothing";
                }
                else
                {
                    var client = new HttpClient(new NativeMessageHandler());
                    var content = new StringContent(JsonConvert.SerializeObject(new { Volume = "SEND", Mute = grabtext }));
                    var result = client.PostAsync(url, content).ConfigureAwait(true);
                }
            };

        }        
    }
}

