using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Encuestador
{
	public partial class CalizPDF : ContentPage
	{
		public CalizPDF()
		{
			InitializeComponent();


			var urlPDF = "http://che.org.il/wp-content/uploads/2016/12/pdf-sample.pdf";

			if (Device.OS == TargetPlatform.Android)
			{
				urlPDF = "https://docs.google.com/viewer?url=" + urlPDF;
			}

			_webView.Source = urlPDF;
		}
	}
}