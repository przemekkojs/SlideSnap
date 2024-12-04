namespace SlideSnap.Scripts.Language
{
    internal class Polish : LanguagePack
    {
        public override Dictionary<string, string> Dictionary => new()
        {
            { "Capture start", "Rozpocznij przechwytywanie" },
            { "Capture stop", "Zatrzymaj przechwytywanie" },
            { "App description", "Automatyczne przechwytywanie slajdów + konwersja do PDF!" },
            { "Captured", "Przechwycone slajdy" }
        };
    }
}
