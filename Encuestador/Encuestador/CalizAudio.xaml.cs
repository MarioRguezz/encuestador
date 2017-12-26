using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Encuestador
{
	public partial class CalizAudio : ContentPage
	{
		public CalizAudio()
		{
			InitializeComponent();


			var htmlSource = new HtmlWebViewSource();
			htmlSource.Html = @"<!DOCTYPE html>
			<html>
				<head>
   				 <title>html5 audio player on iPhone</title>
				    <meta name='viewport' content='width=device-width, initial-scale=1'>
				<style>
				audio::-internal-media-controls-download-button {
				    display:none;
				}
				audio::-webkit-media-controls-enclosure {
				    overflow:hidden;
				}
				audio::-webkit-media-controls-panel {
				    width: calc(100% + 33px);
				}  
				</style>
				</head>
				<body>
					<audio controls style='width:100%;'>
						<source src='http://www.stephaniequinn.com/Music/Allegro%20from%20Duet%20in%20C%20Major.mp3' type='audio/mpeg'>
							Your browser does not support the audio element.
					</audio>
				</body>
			</html>";

			_webView.Source = htmlSource;
		}
	}
}
