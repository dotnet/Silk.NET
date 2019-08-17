using Silk.NET.Input.Common;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;

namespace Silk.NET.Input.Desktop
{
    public class GlfwInputPlatform : IInputPlatform
    {
        public bool IsApplicable(IWindow window)
        {
            return window is GlfwWindow;
        }

        public IInputContext GetInput(IWindow window)
        {
            // the cast isn't needed, but is used to make sure that what we've got is actually a GlfwWindow
            return new GlfwInputContext((GlfwWindow)window);
        }
    }
}
