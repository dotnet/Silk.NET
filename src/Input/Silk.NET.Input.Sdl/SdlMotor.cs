namespace Silk.NET.Input.Sdl
{
    internal class SdlMotor : IMotor
    {
        private readonly SdlGamepad _gp;

        public SdlMotor(int i, SdlGamepad gp)
        {
            _gp = gp;
            Index = i;
        }
        public int Index { get; }

        public float Speed
        {
            get => SpeedVal;
            set
            {
                _gp.VibrationChanged = true;
                SpeedVal = value;
            }
        }

        public float SpeedVal { get; private set; }
    }
}