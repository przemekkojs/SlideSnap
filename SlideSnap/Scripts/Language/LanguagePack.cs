using System.Runtime.CompilerServices;

namespace SlideSnap.Scripts.Language
{
    public abstract class LanguagePack
    {
        public string this[string index] { get => Dictionary[index]; }

        public abstract Dictionary<string, string> Dictionary { get; }

        public const string ENGLISH = "en";
        public const string POLISH = "pl";

        public const string TITLE = "SlideSnap";
    }
}
