using AVFoundation;
using Xamarin.Forms;
using Todo;

[assembly: Dependency(typeof(TextToSpeech_iOS))]
namespace Todo
{
	public class TextToSpeech_iOS : ITextToSpeech
	{
		float volume = 0.5f;
		float pitch = 1.0f;

		/// <summary>
		/// Speak example from: 
		/// http://blog.xamarin.com/make-your-ios-7-app-speak/
		/// </summary>
		public void Speak(string text)
		{
			if (!string.IsNullOrWhiteSpace(text))
			{
				var speechSynthesizer = new AVSpeechSynthesizer();
				var speechUtterance = new AVSpeechUtterance(text)
				{
					Rate = AVSpeechUtterance.MaximumSpeechRate / 3,
					Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
					Volume = volume,
					PitchMultiplier = pitch
				};

				speechSynthesizer.SpeakUtterance(speechUtterance);
			}
		}
	}
}
