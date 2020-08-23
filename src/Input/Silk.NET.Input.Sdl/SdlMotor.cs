namespace Silk.NET.Input.Sdl
{
    internal class SdlMotor : IMotor
    {
        private readonly SdlGamepad _gp;
        private float _speedVal;

        public SdlMotor(int i, SdlGamepad gp)
        {
            _gp = gp;
            Index = i;
        }

        public int Index { get; }

        public float Speed
        {
            get => _speedVal;
            set
            {
                _gp.VibrationChanged = true;
                _speedVal = value;
            }
        }
    }
}
