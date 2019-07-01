namespace Silk.NET.Windowing.Common
{
    public interface ISilkPlatform
    {
        bool IsApplicable { get; }

        IWindow GetWindow(WindowOptions options);
    }
}