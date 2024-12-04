namespace SlideSnap.Scripts
{
    public class Capturer
    {
        public bool Capturing { get; private set; }
        public int Captured { get; private set; }

        public Capturer()
        {
            Capturing = false;
            Captured = 0;
        }

        public void Reset()
        {
            Captured = 0;
            Capturing = false;
        }

        public void Switch()
        {
            if (Capturing)
                StopCapturing();
            else
                StartCapturing();
        }

        public void StartCapturing()
        {
            Capturing = true;
        }

        public void StopCapturing()
        {
            Capturing = false;
        }
    }
}
