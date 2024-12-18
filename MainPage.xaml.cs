namespace FontRepo
{
    public partial class MainPage : ContentPage
    {
        public List<DateTime> Dates { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Dates =
            [
                new DateTime(2024,12,19,0,0,0,DateTimeKind.Local),
                new DateTime(2024,12,26,0,0,0,DateTimeKind.Local),
                new DateTime(2025,01,02,0,0,0,DateTimeKind.Local)
            ];

            BindingContext = this;
        }
    }
}
