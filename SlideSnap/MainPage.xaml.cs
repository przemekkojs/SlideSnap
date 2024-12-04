using SlideSnap.Scripts;
using SlideSnap.Scripts.Language;

namespace SlideSnap
{
    public partial class MainPage : ContentPage
    {
        private readonly Capturer _capturer;
        private LanguagePack language;

        public MainPage()
        {
            InitializeComponent();
            _capturer = new Capturer();
            language = new Polish();

            Title = string.Empty;
            TitleLabel.Text = LanguagePack.TITLE;

            RefreshElements();
        }

        private void RefreshElements()
        {
            DescriptionLabel.Text = language["App description"];
            StartStopButton.Text = language["Capture start"];

            RefreshCapturedCount();
            ChangeButtonText();
        }

        private void RefreshCapturedCount() =>
            CapturedCount.Text = $"{language["Captured"]}: {_capturer.Captured}";

        private void ChangeButtonText()
        {
            var capturing = _capturer.Capturing;

            if (capturing)
                StartStopButton.Text = language["Capture stop"];
            else
                StartStopButton.Text = language["Capture start"];
        }

        private void StartStopButton_Clicked(object sender, EventArgs e)
        {
            _capturer.Switch();
            ChangeButtonText();
        }

        private void ChangeLanguage(string name)
        {
            language = name switch
            {
                LanguagePack.ENGLISH => new English(),
                LanguagePack.POLISH => new Polish(),
                _ => throw new ArgumentException("Language cannot be empty")
            };

            RefreshElements();
        }

        private void SetEnglishLanguage(object sender, EventArgs e) =>
            ChangeLanguage(LanguagePack.ENGLISH);

        private void SetPolishLanguage(object sender, EventArgs e) =>
            ChangeLanguage(LanguagePack.POLISH);
    }
}
