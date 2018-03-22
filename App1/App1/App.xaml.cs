using System;

using App1.Views;
using Xamarin.Forms;
using XamlCSS;
using XamlCSS.XamarinForms;

namespace App1
{
	public partial class App : Application
	{

		public App ()
		{
            Console.WriteLine("=====> " + typeof(App).Assembly.ToString());
            Css.Initialize(this, new[] { typeof(App).Assembly });

            InitializeComponent();

            //this.Resources.Add("appStyleSheet", new StyleSheet { Content = "Button { FontAttributes: Italic;}" });
            this.Resources.Add("appStyleSheet", new StyleSheet { Content = @"@import ""Resources/baseStyle.scss"";" });
            //this.Resources.Add("appVariables", "$base-color: #00ff00;");

            MainPage = new MainPage();
        }

        public string cssStyle = @"
@import ""Resources/baseStyle.scss"";
";

        public string cssStyle2 = @"
$base-color: #00ff00;

Button {
    BackgroundColor: Red;
    TextColor: White;
}
";

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
