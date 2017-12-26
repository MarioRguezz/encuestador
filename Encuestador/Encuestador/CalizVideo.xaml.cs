using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Encuestador
{
	public partial class CalizVideo : ContentPage
	{
		public static readonly Regex YoutubeVideoRegex = new Regex(@"youtu(?:\.be|be\.com)/(?:(.*)v(/|=)|(.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase);


		public CalizVideo()
		{
			InitializeComponent();

			var youtubeID = ParseURL("https://www.youtube.com/watch?v=-EZzXmFbZ98");

			_webView.Source = "https://www.youtube.com/embed/" + youtubeID;
		}

		string ParseURL(string v)
		{

			var youtubeMatch =
			new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)")
			.Match(v);

			if (youtubeMatch.Success)
			{
				return youtubeMatch.Groups[1].Value;
			}
			else {
				return string.Empty;
			}

		}
	}
}
