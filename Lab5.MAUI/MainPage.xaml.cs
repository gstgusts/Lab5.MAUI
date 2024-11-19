using Lab5.MAUI.Dto;
using Newtonsoft.Json;
using RestSharp;

namespace Lab5.MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public List<Student> Students { get; set; } = new List<Student>();

        public static string BaseAddress =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5205" : "http://localhost:5205";

        public MainPage()
        {
            InitializeComponent();

            Students.Add(new Student
            {
                Id = 1,
                Name = "Gusts",
                Surname = "Link"
            });

            Students.Add(new Student
            {
                Id = 2,
                Name = "Gusts2",
                Surname = "Link2"
            });

            C1.ItemsSource = Students;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            LblProgress.Text = "Loading...";
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);


        //var options = new RestClientOptions(BaseAddress)
        //    {
        //        MaxTimeout = -1,
        //    };
        //    var client = new RestClient(options);
        //    var request = new RestRequest("/api/Student/"+Entry1.Text, Method.Get);
        //    RestResponse response = await client.ExecuteAsync(request);


        //    var json = response.Content;

        //    var student = JsonConvert.DeserializeObject<Student>(response.Content);

        //    LblName.Text = student.Name;

        //    LblProgress.Text = string.Empty;

        }

        private void Entry1_OnTextChanged(object? sender, TextChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }

}
