namespace Silk.NET.Windowing
{
    public static class Surface
    {
        public static bool IsPlatformSupported { get => throw new NotImplementedException(); }

        public static ISurface GetOrCreate()
        {
            throw new NotImplementedException();
        }
        public static ISurface CreateNew()        
        {
            throw new NotImplementedException();
        }
        public static void ClearCurrentContexts()
        {
            throw new NotImplementedException();
        }
    }
}