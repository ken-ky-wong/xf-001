using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamlCSS.CssParsing;
using XamlCSS.XamarinForms;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();

            /*
             * this is setting css programatically
             */
            //var app = Application.Current as App;
            //Css.SetStyleSheet(aboutPageTab, CssParser.Parse(app.cssStyle2));
        }
    }
}