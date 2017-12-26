using System;

using Xamarin.Forms;

namespace Encuestador
{
	public class App : Application
	{
		public App ()
		{

			//MainPage = new NavigationPage(new EncuestaPage2()); //ENCUESTA
			//MainPage = new NavigationPage(new CalizVideo()); //VIDEO
			//MainPage = new NavigationPage(new CalizPDF()); //PDF
			MainPage = new NavigationPage(new CalizAudio()); //AUDIO
		}

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

