namespace SlideSnap.Scripts.Language
{
    public class English : LanguagePack
    {
        public override Dictionary<string, string> Dictionary => new()
        {
            { "Capture start", "Start capturing" },
            { "Capture stop", "Stop capturing" },
            { "App description", "Automatic slides capture + PDF Conversion!" },
            { "Captured", "Captured slides" }
        };
    }
}
