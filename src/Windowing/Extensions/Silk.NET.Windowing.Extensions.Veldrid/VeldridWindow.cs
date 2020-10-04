// This file is no-longer Ultz Confidential Information and is now deemed "Public Knowledge" as defined in section 1(j)
// of the Ultz Non-Disclosure Agreement (OmegaNDA) as of 01/05/2020.
//
// Signed-off by Dylan Perks, Chief Executive.
//
// Released under the MIT license for Silk.NET. This file may have been modified from the original.

using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;
using Ultz.SuperInvoke.Loader;
using Veldrid;
using Veldrid.OpenGL;
using Veldrid.Vk;
using Vulkan.Xlib;
using VideoMode = Silk.NET.Windowing.Common.VideoMode;
using XWindow = Vulkan.Xlib.Window;

namespace Silk.NET.Windowing.Extensions.Veldrid
{
    /// <summary>
    /// Contains classes for creating
    /// </summary>
    public static class VeldridWindow
    {
        // TODO view support

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex = -6);

        /// <summary>
        /// Creates a window and a graphics device with the given options.
        /// </summary>
        /// <param name="windowCI">The window options, used to create a window.</param>
        /// <param name="window">The new window.</param>
        /// <param name="gd">The new graphics device.</param>
        public static void CreateWindowAndGraphicsDevice(
            WindowOptions windowCI,
            out IWindow window,
            out GraphicsDevice gd)
            => CreateWindowAndGraphicsDevice(
                windowCI,
                new GraphicsDeviceOptions(),
                GetPlatformDefaultBackend(),
                out window,
                out gd);

        /// <summary>
        /// Creates a window and a graphics device with the given options.
        /// </summary>
        /// <param name="windowCI">The window options, used to create the window.</param>
        /// <param name="deviceOptions">The device options, used to create the graphics device.</param>
        /// <param name="window">The new window.</param>
        /// <param name="gd">The new graphics device.</param>
        public static void CreateWindowAndGraphicsDevice(
            WindowOptions windowCI,
            GraphicsDeviceOptions deviceOptions,
            out IWindow window,
            out GraphicsDevice gd)
            => CreateWindowAndGraphicsDevice(windowCI, deviceOptions, GetPlatformDefaultBackend(), out window, out gd);

        /// <summary>
        /// Creates a window and a graphics device with the given options.
        /// </summary>
        /// <param name="windowCI">The window options, used to create the window.</param>
        /// <param name="deviceOptions">The device options, used to create the graphics device.</param>
        /// <param name="preferredBackend">The preferred graphics backend for the graphics device.</param>
        /// <param name="window">The new window.</param>
        /// <param name="gd">The new graphics device.</param>
        public static void CreateWindowAndGraphicsDevice(
            WindowOptions windowCI,
            GraphicsDeviceOptions deviceOptions,
            GraphicsBackend preferredBackend,
            out IWindow window,
            out GraphicsDevice gd)
        {
            var opts = new WindowOptions
            (
                windowCI.IsVisible,
                true,
                windowCI.Position,
                windowCI.Size,
                -1,
                -1,
                new GraphicsAPI
                (
                    ContextAPI.None,
                    ContextProfile.Core,
                    ContextFlags.ForwardCompatible,
                    new APIVersion(1, 0)
                ),
                windowCI.Title,
                WindowState.Normal,
                WindowBorder.Resizable,
                deviceOptions.SyncToVerticalBlank ? VSyncMode.On : VSyncMode.Off,
                5,
                false,
                VideoMode.Default,
                null
            );

            if (preferredBackend == GraphicsBackend.OpenGL || preferredBackend == GraphicsBackend.OpenGLES)
            {
                SetGlContextAttributes(deviceOptions, preferredBackend, ref opts);
            }

            window = GlfwPlatform.Instance.CreateWindow(opts);
            window.Initialize();
            window.WindowState = windowCI.WindowState;
            gd = CreateGraphicsDevice(window, deviceOptions, preferredBackend);
        }

        /// <summary>
        /// Creates a graphics device from an existing window.
        /// </summary>
        /// <param name="window">The window to create a graphics device from.</param>
        /// <returns>The new graphics device.</returns>
        public static GraphicsDevice CreateGraphicsDevice(IWindow window)
            => CreateGraphicsDevice(window, new GraphicsDeviceOptions(), GetPlatformDefaultBackend());

        /// <summary>
        /// Creates a graphics device from an existing window.
        /// </summary>
        /// <param name="window">The window to create a graphics device from.</param>
        /// <param name="options">The graphics device options.</param>
        /// <returns>The new graphics device.</returns>
        public static GraphicsDevice CreateGraphicsDevice(IWindow window, GraphicsDeviceOptions options)
            => CreateGraphicsDevice(window, options, GetPlatformDefaultBackend());

        /// <summary>
        /// Creates a graphics device from an existing window.
        /// </summary>
        /// <param name="window">The window to create a graphics device from.</param>
        /// <param name="preferredBackend">The preferred graphics backend for the graphics device.</param>
        /// <returns>The new graphics device.</returns>
        public static GraphicsDevice CreateGraphicsDevice(IWindow window, GraphicsBackend preferredBackend)
            => CreateGraphicsDevice(window, new GraphicsDeviceOptions(), preferredBackend);

        /// <summary>
        /// Creates a graphics device from an existing window.
        /// </summary>
        /// <param name="window">The window to create a graphics device from.</param>
        /// <param name="options">The graphics device options.</param>
        /// <param name="preferredBackend">The preferred graphics backend for the graphics device.</param>
        /// <returns>The new graphics device.</returns>
        public static GraphicsDevice CreateGraphicsDevice(
            IWindow window,
            GraphicsDeviceOptions options,
            GraphicsBackend preferredBackend) =>
            preferredBackend switch
            {
                GraphicsBackend.Direct3D11 => CreateDefaultD3D11GraphicsDevice(options, window),
                GraphicsBackend.Vulkan => CreateVulkanGraphicsDevice(options, window),
                GraphicsBackend.OpenGL => CreateDefaultOpenGlGraphicsDevice(options, window, preferredBackend),
                GraphicsBackend.Metal => CreateMetalGraphicsDevice(options, window),
                GraphicsBackend.OpenGLES => CreateDefaultOpenGlGraphicsDevice(options, window, preferredBackend),
                _ => throw new VeldridException("Invalid GraphicsBackend: " + preferredBackend)
            };

        private unsafe delegate IntPtr GetWin32Window(WindowHandle* handle);

        private unsafe delegate IntPtr GetX11Display();

        private unsafe delegate IntPtr GetX11Window(WindowHandle* handle);

        private unsafe delegate IntPtr GetWaylandDisplay();

        private unsafe delegate IntPtr GetWaylandWindow(WindowHandle* handle);

        private unsafe delegate IntPtr GetCocoaWindow(WindowHandle* handle);

        private static unsafe SwapchainSource GetSwapchainSource(IView view)
        {
            if (view.GetType().FullName == "Silk.NET.Windowing.Desktop.GlfwWindow")
            {
                var handle = (WindowHandle*) view.Handle;
                var glfw = GlfwProvider.GLFW.Value;
                try
                {
                    var x11Window = glfw.Library.LoadFunction<GetX11Window>("glfwGetX11Window")(handle);
                    var x11Display = glfw.Library.LoadFunction<GetX11Display>("glfwGetX11Display")();
                    if (x11Display != IntPtr.Zero && x11Window != IntPtr.Zero)
                    {
                        return SwapchainSource.CreateXlib(x11Display, x11Window);
                    }
                }
                catch (GlfwException)
                {
                    // do nothing
                }
                catch (SymbolLoadingException)
                {
                    // do nothing
                }

                try
                {
                    var win32Window = glfw.Library.LoadFunction<GetWin32Window>("glfwGetWin32Window")(handle);
                    if (win32Window != IntPtr.Zero)
                    {
                        return SwapchainSource.CreateWin32(win32Window, GetWindowLongPtr(win32Window));
                    }
                }
                catch (GlfwException)
                {
                    // do nothing
                }
                catch (SymbolLoadingException)
                {
                    // do nothing
                }

                try
                {
                    var waylandWindow = glfw.Library.LoadFunction<GetWaylandWindow>("glfwGetWaylandWindow")(handle);
                    var waylandDisplay = glfw.Library.LoadFunction<GetWaylandDisplay>("glfwGetWaylandDisplay")();
                    if (waylandWindow != IntPtr.Zero && waylandDisplay != IntPtr.Zero)
                    {
                        return SwapchainSource.CreateWayland(waylandDisplay, waylandWindow);
                    }
                }
                catch (GlfwException)
                {
                    // do nothing
                }
                catch (SymbolLoadingException)
                {
                    // do nothing
                }

                try
                {
                    var cocoaWindow = glfw.Library.LoadFunction<GetCocoaWindow>("glfwGetCocoaWindow")(handle);
                    if (cocoaWindow != IntPtr.Zero)
                    {
                        return SwapchainSource.CreateNSWindow(cocoaWindow);
                    }
                }
                catch (GlfwException)
                {
                    // do nothing
                }
                catch (SymbolLoadingException)
                {
                    // do nothing
                }
            }

            throw new PlatformNotSupportedException();
        }

        private static unsafe VkSurfaceSource GetSurfaceSource(IView view)
        {
            if (view.GetType().FullName == "Silk.NET.Windowing.Desktop.GlfwWindow")
            {
                var handle = (WindowHandle*) view.Handle;
                var glfw = GlfwProvider.GLFW.Value;
                try
                {
                    var x11Window = glfw.Library.LoadFunction<GetX11Window>("glfwGetX11Window")(handle);
                    var x11Display = glfw.Library.LoadFunction<GetX11Display>("glfwGetX11Display")();
                    if (x11Display != IntPtr.Zero && x11Window != IntPtr.Zero)
                    {
                        return VkSurfaceSource.CreateXlib((Display*) x11Display, new XWindow { Value = x11Window });
                    }
                }
                catch (GlfwException)
                {
                    // do nothing
                }
                catch (SymbolLoadingException)
                {
                    // do nothing
                }

                try
                {
                    var win32Window = glfw.Library.LoadFunction<GetWin32Window>("glfwGetWin32Window")(handle);
                    if (win32Window != IntPtr.Zero)
                    {
                        return VkSurfaceSource.CreateWin32(GetWindowLongPtr(win32Window), win32Window);
                    }
                }
                catch (GlfwException)
                {
                    // do nothing
                }
                catch (SymbolLoadingException)
                {
                    // do nothing
                }
            }

            throw new PlatformNotSupportedException();
        }

        public static unsafe GraphicsDevice CreateVulkanGraphicsDevice(GraphicsDeviceOptions options, IView window)
            => CreateVulkanGraphicsDevice(options, window, false);
        public static unsafe GraphicsDevice CreateVulkanGraphicsDevice(
            GraphicsDeviceOptions options,
            IView window,
            bool colorSrgb)
        {
            SwapchainDescription scDesc = new SwapchainDescription(
                GetSwapchainSource(window),
                (uint) window.Size.Width,
                (uint) window.Size.Height,
                options.SwapchainDepthFormat,
                options.SyncToVerticalBlank,
                colorSrgb);
            GraphicsDevice gd = GraphicsDevice.CreateVulkan(options, scDesc);

            return gd;
        }

        private static unsafe GraphicsDevice CreateMetalGraphicsDevice(GraphicsDeviceOptions options, IWindow window)
            => CreateMetalGraphicsDevice(options, window, false);
        private static unsafe GraphicsDevice CreateMetalGraphicsDevice(
            GraphicsDeviceOptions options,
            IWindow window,
            bool colorSrgb)
        {
            SwapchainSource source = GetSwapchainSource(window);
            SwapchainDescription swapchainDesc = new SwapchainDescription(
                source,
                (uint) window.Size.Width, (uint) window.Size.Height,
                options.SwapchainDepthFormat,
                options.SyncToVerticalBlank,
                colorSrgb);

            return GraphicsDevice.CreateMetal(options, swapchainDesc);
        }

        /// <summary>
        /// Gets the default backend given the current runtime information.
        /// </summary>
        /// <returns>The default backend for this runtime/platform.</returns>
        public static GraphicsBackend GetPlatformDefaultBackend()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return GraphicsBackend.Direct3D11;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return GraphicsDevice.IsBackendSupported(GraphicsBackend.Metal)
                    ? GraphicsBackend.Metal
                    : GraphicsBackend.OpenGL;
            }

            return GraphicsDevice.IsBackendSupported(GraphicsBackend.Vulkan)
                ? GraphicsBackend.Vulkan
                : GraphicsBackend.OpenGL;
        }

        private static unsafe GraphicsDevice CreateDefaultOpenGlGraphicsDevice(
            GraphicsDeviceOptions options,
            IWindow window,
            GraphicsBackend backend)
        {
            OpenGLPlatformInfo platformInfo = new OpenGLPlatformInfo(
                window.Handle,
                x => GlfwProvider.GLFW.Value.GetProcAddress(x),
                context => GlfwProvider.GLFW.Value.MakeContextCurrent((WindowHandle*) context),
                () => (IntPtr) GlfwProvider.GLFW.Value.GetCurrentContext(),
                () => GlfwProvider.GLFW.Value.MakeContextCurrent(default),
                _ => { },
                () => GlfwProvider.GLFW.Value.SwapBuffers((WindowHandle*) window.Handle),
                sync => GlfwProvider.GLFW.Value.SwapInterval(sync ? 1 : 0));

            return GraphicsDevice.CreateOpenGL(
                options,
                platformInfo,
                (uint) window.Size.Width,
                (uint) window.Size.Height);
        }

        private static void SetGlContextAttributes(GraphicsDeviceOptions options, GraphicsBackend backend, ref WindowOptions opts)
        {
            if (backend != GraphicsBackend.OpenGL && backend != GraphicsBackend.OpenGLES)
            {
                throw new VeldridException(
                    $"{nameof(backend)} must be {nameof(GraphicsBackend.OpenGL)} or {nameof(GraphicsBackend.OpenGLES)}.");
            }

            var api = opts.API;
            var contextFlags = options.Debug
                ? ContextFlags.Debug | ContextFlags.ForwardCompatible
                : ContextFlags.ForwardCompatible;

            api.Flags = contextFlags;

            (int major, int minor) = GetMaxGLVersion(backend == GraphicsBackend.OpenGLES);

            if (backend == GraphicsBackend.OpenGL)
            {
                api.Profile = ContextProfile.Core;
                api.API = ContextAPI.OpenGL;
                api.Version = new APIVersion(major, minor);
            }
            else
            {
                api.Profile = ContextProfile.Core;
                api.API = ContextAPI.OpenGLES;
                api.Version = new APIVersion(major, minor);
            }

            int depthBits = 0;
            int stencilBits = 0;
            if (options.SwapchainDepthFormat.HasValue)
            {
                switch (options.SwapchainDepthFormat)
                {
                    case PixelFormat.R16_UNorm:
                        depthBits = 16;
                        break;
                    case PixelFormat.D24_UNorm_S8_UInt:
                        depthBits = 24;
                        stencilBits = 8;
                        break;
                    case PixelFormat.R32_Float:
                        depthBits = 32;
                        break;
                    case PixelFormat.D32_Float_S8_UInt:
                        depthBits = 32;
                        stencilBits = 8;
                        break;
                    default:
                        throw new VeldridException("Invalid depth format: " + options.SwapchainDepthFormat.Value);
                }
            }

            opts.PreferredDepthBufferBits = depthBits;
            // TODO stencil?

            opts.API = api;
        }

        private static GraphicsDevice CreateDefaultD3D11GraphicsDevice(
            GraphicsDeviceOptions options,
            IWindow window)
        {
            SwapchainSource source = GetSwapchainSource(window);
            SwapchainDescription swapchainDesc = new SwapchainDescription(
                source,
                (uint) window.Size.Width, (uint) window.Size.Height,
                options.SwapchainDepthFormat,
                options.SyncToVerticalBlank,
                options.SwapchainSrgbFormat);

            return GraphicsDevice.CreateD3D11(options, swapchainDesc);
        }

        private static unsafe string GetString(byte* stringStart)
        {
            int characters = 0;
            while (stringStart[characters] != 0)
            {
                characters++;
            }

            return Encoding.UTF8.GetString(stringStart, characters);
        }

        private static readonly object s_glVersionLock = new object();
        private static (int Major, int Minor)? s_maxSupportedGLVersion;
        private static (int Major, int Minor)? s_maxSupportedGLESVersion;

        private static (int Major, int Minor) GetMaxGLVersion(bool gles)
        {
            lock (s_glVersionLock)
            {
                (int Major, int Minor)? maxVer = gles ? s_maxSupportedGLESVersion : s_maxSupportedGLVersion;
                if (maxVer == null)
                {
                    maxVer = TestMaxVersion(gles);
                    if (gles) { s_maxSupportedGLESVersion = maxVer; }
                    else { s_maxSupportedGLVersion = maxVer; }
                }

                return maxVer.Value;
            }
        }

        private static (int Major, int Minor) TestMaxVersion(bool gles)
        {
            //(int, int)[] testVersions = gles
            //    ? new[] { (3, 2), (3, 0) }
            //    : new[] { (4, 6), (4, 3), (4, 0), (3, 3), (3, 0) };

            //foreach ((int major, int minor) in testVersions)
            //{
            //    if (TestIndividualGLVersion(gles, major, minor)) { return (major, minor); }
            //}

            //throw new PlatformNotSupportedException("OpenGL not supported.");
            return (4, 0); // BUG because of the cross-boundary exception issue, this has been temporarily disabled.
        }

        //private static unsafe bool TestIndividualGLVersion(bool gles, int major, int minor)
        //{
        //    var gl = gles ? "OpenGLES" : "OpenGL";
        //    try
        //    {
        //        var opts = WindowOptions.Default;
        //        opts.IsVisible = false;
        //        opts.Size = new Size(1, 1);
        //        opts.WindowBorder = WindowBorder.Hidden;
        //        opts.API = new GraphicsAPI(gles ? ContextAPI.OpenGLES : ContextAPI.OpenGL, ContextProfile.Core,
        //            ContextFlags.ForwardCompatible, new APIVersion(major, minor));
        //        var window = GlfwPlatform.Instance.CreateWindow(opts);
        //        window.Initialize();
        //        window.Reset();
        //        return true;
        //    }
        //    catch (GlfwException)
        //    {
        //        return false;
        //    }
        //}
    }
}
