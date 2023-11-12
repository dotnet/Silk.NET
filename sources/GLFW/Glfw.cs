using Silk.NET.Core.Loader;

namespace Silk.NET.GLFW;

public partial class Glfw
{
    static Glfw()
    {
        if (OperatingSystem.IsWindows())
        {
            LoaderInterface.RegisterAlternativeName("glfw", "glfw3.dll");
        }

        if (OperatingSystem.IsLinux())
        {
            LoaderInterface.RegisterAlternativeName("glfw", "libglfw.so.3");
        }

        if (OperatingSystem.IsMacOS())
        {
            LoaderInterface.RegisterAlternativeName("glfw", "libglfw.3.dylib");
        }
    }
}
