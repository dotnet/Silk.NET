using System;
using System.Linq;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    public partial class D3D9
    {
        [Obsolete("Use the GetApi(INativeWindow window, bool forceDxvk = false) overload!")]
        public static D3D9 GetApi(DXSwapchainProvider swapchainProvider = DXSwapchainProvider.Win32, bool forceDxvk = false)
        {
            switch (swapchainProvider)
            {
                case DXSwapchainProvider.Win32:
                    if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        throw new PlatformNotSupportedException("The Win32 swapchain provider is only supported on Windows! Use the GetApi(INativeWindow) overload, or specify this correctly per platform!");
                    }
                    
                    var names = new D3D9LibraryNameContainer().GetLibraryNames();

                    return new D3D9(CreateDefaultContext(names.Select(x => forceDxvk ? $"dxvk-{x}" : x).ToArray()));
                case DXSwapchainProvider.Glfw:
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        throw new PlatformNotSupportedException("The GLFW swapchain provider is not supported under Windows! This can only be used with non-windows builds of DXVK!");
                    }
                    
                    return new D3D9(CreateDefaultContext(new D3D9GLFWLibraryNameContainer().GetLibraryNames()));
                case DXSwapchainProvider.Sdl2:
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        throw new PlatformNotSupportedException("The SDL2 swapchain provider is not supported under Windows! This can only be used with non-windows builds of DXVK!");
                    }
                    
                    return new D3D9(CreateDefaultContext(new D3D9Sdl2LibraryNameContainer().GetLibraryNames()));
                default:
                    throw new ArgumentOutOfRangeException(nameof (swapchainProvider), swapchainProvider, null);
            }
        }

        public static D3D9 GetApi(INativeWindowSource window, bool forceDxvk = false)
        {
#pragma warning disable CS0618
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return GetApi(DXSwapchainProvider.Win32, forceDxvk);
            }

            if (window.Native.Glfw.HasValue)
            {
                return GetApi(DXSwapchainProvider.Glfw, forceDxvk);
            }
            
            if (window.Native.Sdl.HasValue)
            {
                return GetApi(DXSwapchainProvider.Sdl2, forceDxvk);
            }
#pragma warning restore CS0618

            throw new PlatformNotSupportedException("The passed window is not a GLFW or SDL2 window!");
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<D3D9>
        {
            throw new NotImplementedException();
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}

