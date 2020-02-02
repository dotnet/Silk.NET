// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using AdvancedDLSupport;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Provides access to the GLFW API.
    /// </summary>
    public abstract class Glfw : NativeAPI, IGlfw
    {
        /// <summary>
        /// Gets an integer equal to GLFW_DONT_CARE. This can be used for several window hints to use the platform default.
        /// </summary>
        public const int DontCare = -1;

        /// <inheritdoc cref="NativeLibraryBase" />
        protected Glfw(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <summary>
        /// Gets the default callback which gets called when a GLFW-Error occurs.
        /// </summary>
        /// <seealso cref="SetErrorCallback" />
        public static GlfwCallbacks.ErrorCallback ErrorCallback { get; } = (errorCode, description) =>
            throw new GlfwException($"{errorCode}: {description}") {ErrorCode = errorCode};

        public override SearchPathContainer SearchPaths { get; } = new GlfwLibraryNameContainer();

        /// <inheritdoc />
        public abstract bool Init();

        /// <inheritdoc />
        public abstract void Terminate();

        /// <inheritdoc />
        public abstract void InitHint(InitHint hint, bool value);

        /// <inheritdoc />
        public abstract void GetVersion(out int major, out int minor, out int revision);

        /// <inheritdoc />
        public abstract string GetVersionString();

        /// <inheritdoc />
        public abstract unsafe ErrorCode GetError(out char* description);

        /// <inheritdoc />
        public abstract unsafe Monitor** GetMonitors(out int count);

        /// <inheritdoc />
        public abstract unsafe void GetMonitorPos(Monitor* monitor, out int x, out int y);

        /// <inheritdoc />
        public abstract unsafe void GetMonitorPhysicalSize(Monitor* monitor, out int width, out int height);

        /// <inheritdoc />
        public abstract unsafe void GetMonitorContentScale(Monitor* monitor, out float xscale, out float yscale);

        /// <inheritdoc />
        public abstract unsafe string GetMonitorName(Monitor* monitor);

        /// <inheritdoc />
        public abstract unsafe void SetMonitorUserPointer(Monitor* monitor, IntPtr pointer);

        /// <inheritdoc />
        public abstract unsafe IntPtr GetMonitorUserPointer(Monitor* monitor);

        /// <inheritdoc />
        public abstract unsafe VideoMode* GetVideoModes(Monitor* monitor, out int count);

        /// <inheritdoc />
        public abstract unsafe void SetGamma(Monitor* monitor, float gamma);

        /// <inheritdoc />
        public abstract unsafe GammaRamp* GetGammaRamp(Monitor* monitor);

        /// <inheritdoc />
        public abstract unsafe void SetGammaRamp(Monitor* monitor, ref GammaRamp ramp);

        /// <inheritdoc />
        public abstract void DefaultWindowHints();

        /// <inheritdoc />
        public abstract void WindowHintString(int hint, string value);

        /// <inheritdoc />
        public abstract unsafe void SetWindowSizeLimits(WindowHandle* window, int minwidth, int minheight, int maxwidth,
            int maxheight);

        /// <inheritdoc />
        public abstract unsafe void SetWindowAspectRatio(WindowHandle* window, int numer, int denom);

        /// <inheritdoc />
        public abstract unsafe void GetWindowFrameSize(WindowHandle* window, out int left, out int top, out int right,
            out int bottom);

        /// <inheritdoc />
        public abstract unsafe float GetWindowOpacity(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe void SetWindowOpacity(WindowHandle* window, float opacity);

        /// <inheritdoc />
        public abstract unsafe void RequestWindowAttention(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe void SetWindowAttrib(WindowHandle* window, WindowAttributeSetter attrib, bool value);

        /// <inheritdoc />
        public abstract bool RawMouseMotionSupported();

        /// <inheritdoc />
        public abstract string GetKeyName(int key, int scancode);

        /// <inheritdoc />
        public abstract int GetKeyScancode(int key);

        /// <inheritdoc />
        public abstract unsafe int GetKey(WindowHandle* window, Keys key);

        /// <inheritdoc />
        public abstract unsafe int GetMouseButton(WindowHandle* window, int button);

        /// <inheritdoc />
        public abstract unsafe void GetCursorPos(WindowHandle* window, out double xpos, out double ypos);

        /// <inheritdoc />
        public abstract unsafe void SetCursorPos(WindowHandle* window, double xpos, double ypos);

        /// <inheritdoc />
        public abstract unsafe Cursor* CreateCursor(Image* image, int xhot, int yhot);

        /// <inheritdoc />
        public abstract unsafe Cursor* CreateStandardCursor(CursorShape shape);

        /// <inheritdoc />
        public abstract unsafe void DestroyCursor(Cursor* cursor);

        /// <inheritdoc />
        public abstract unsafe void SetCursor(WindowHandle* window, Cursor* cursor);

        /// <inheritdoc />
        public abstract bool JoystickPresent(int jid);

        /// <inheritdoc />
        public abstract unsafe float* GetJoystickAxes(int jid, out int count);

        /// <inheritdoc />
        public abstract unsafe byte* GetJoystickButtons(int jid, out int count);

        /// <inheritdoc />
        public abstract unsafe JoystickHats* GetJoystickHats(int jid, out int count);

        /// <inheritdoc />
        public abstract string GetJoystickName(int jid);

        /// <inheritdoc />
        public abstract string GetJoystickGUID(int jid);

        /// <inheritdoc />
        public abstract void SetJoystickUserPointer(int jid, IntPtr ptr);

        /// <inheritdoc />
        public abstract IntPtr GetJoystickUserPointer(int jid);

        /// <inheritdoc />
        public abstract bool JoystickIsGamepad(int jid);

        /// <inheritdoc />
        public abstract bool UpdateGamepadMappings(string newMapping);

        /// <inheritdoc />
        public abstract string GetGamepadName(int jid);

        /// <inheritdoc />
        public abstract bool GetGamepadState(int jid, out GamepadState state);

        /// <inheritdoc />
        public abstract double GetTime();

        /// <inheritdoc />
        public abstract void SetTime(double time);

        /// <inheritdoc />
        public abstract long GetTimerValue();

        /// <inheritdoc />
        public abstract long GetTimerFrequency();

        /// <inheritdoc />
        public abstract unsafe WindowHandle* GetCurrentContext();

        /// <inheritdoc />
        public abstract unsafe void SwapBuffers(WindowHandle* window);

        /// <inheritdoc />
        public abstract bool ExtensionSupported(string extensionName);

        /// <inheritdoc />
        public abstract unsafe WindowHandle* CreateWindow(int width, int height, string title, Monitor* monitor,
            WindowHandle* share);

        /// <inheritdoc />
        public abstract unsafe Monitor* GetPrimaryMonitor();

        /// <inheritdoc />
        public abstract unsafe void DestroyWindow(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe void FocusWindow(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe void GetFramebufferSize(WindowHandle* window, out int width, out int height);

        /// <inheritdoc />
        public abstract unsafe CursorModeValue GetInputMode(WindowHandle* window, CursorStateAttribute mode);

        /// <inheritdoc />
        public abstract unsafe bool GetInputMode(WindowHandle* window, StickyAttributes mode);

        /// <inheritdoc />
        public abstract unsafe void RestoreWindow(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe VideoMode* GetVideoMode(Monitor* monitor);

        /// <inheritdoc />
        public abstract unsafe bool GetWindowAttrib(WindowHandle* window, WindowAttributeGetter attribute);

        /// <inheritdoc />
        public abstract unsafe void GetWindowSize(WindowHandle* window, out int width, out int height);

        /// <inheritdoc />
        public abstract unsafe void GetWindowPos(WindowHandle* window, out int x, out int y);

        /// <inheritdoc />
        public abstract unsafe Monitor* GetWindowMonitor(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe void HideWindow(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe void IconifyWindow(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe void MakeContextCurrent(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe void MaximizeWindow(WindowHandle* window);

        /// <inheritdoc />
        public abstract void PollEvents();

        /// <inheritdoc />
        public abstract void PostEmptyEvent();

        /// <inheritdoc />
        public abstract void WindowHint(WindowHintInt hint, int value);

        /// <inheritdoc />
        public abstract void WindowHint(WindowHintBool hint, bool value);

        /// <inheritdoc />
        public abstract void WindowHint(WindowHintClientApi hint, ClientApi value);

        /// <inheritdoc />
        public abstract void WindowHint(WindowHintReleaseBehavior hint, ReleaseBehavior value);

        /// <inheritdoc />
        public abstract void WindowHint(WindowHintContextApi hint, ContextApi value);

        /// <inheritdoc />
        public abstract void WindowHint(WindowHintRobustness hint, Robustness value);

        /// <inheritdoc />
        public abstract void WindowHint(WindowHintOpenGlProfile hint, OpenGlProfile value);

        /// <inheritdoc />
        public abstract unsafe bool WindowShouldClose(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.CharCallback SetCharCallback(WindowHandle* window,
            GlfwCallbacks.CharCallback callback);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.CharModsCallback SetCharModsCallback(WindowHandle* window,
            GlfwCallbacks.CharModsCallback callback);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.CursorEnterCallback SetCursorEnterCallback(WindowHandle* window,
            GlfwCallbacks.CursorEnterCallback callback);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.CursorPosCallback SetCursorPosCallback(WindowHandle* window,
            GlfwCallbacks.CursorPosCallback callback);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.DropCallback SetDropCallback(WindowHandle* window,
            GlfwCallbacks.DropCallback callback);

        /// <inheritdoc />
        public abstract GlfwCallbacks.ErrorCallback SetErrorCallback(GlfwCallbacks.ErrorCallback callback);

        /// <inheritdoc />
        public abstract unsafe void SetInputMode(WindowHandle* window, CursorStateAttribute mode,
            CursorModeValue value);

        /// <inheritdoc />
        public abstract unsafe void SetInputMode(WindowHandle* window, StickyAttributes mode, bool value);

        /// <inheritdoc />
        public abstract GlfwCallbacks.JoystickCallback SetJoystickCallback(GlfwCallbacks.JoystickCallback callback);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.KeyCallback SetKeyCallback(WindowHandle* window,
            GlfwCallbacks.KeyCallback callback);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.ScrollCallback SetScrollCallback(WindowHandle* window,
            GlfwCallbacks.ScrollCallback callback);

        /// <inheritdoc />
        public abstract GlfwCallbacks.MonitorCallback SetMonitorCallback(GlfwCallbacks.MonitorCallback callback);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.MouseButtonCallback SetMouseButtonCallback(WindowHandle* window,
            GlfwCallbacks.MouseButtonCallback callback);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.WindowCloseCallback SetWindowCloseCallback(WindowHandle* window,
            GlfwCallbacks.WindowCloseCallback callback);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.WindowFocusCallback SetWindowFocusCallback(WindowHandle* window,
            GlfwCallbacks.WindowFocusCallback callback);

        /// <inheritdoc />
        public abstract unsafe void SetWindowIcon(WindowHandle* window, int count, Image* images);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.WindowIconifyCallback SetWindowIconifyCallback(WindowHandle* window,
            GlfwCallbacks.WindowIconifyCallback callback);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.WindowMaximizeCallback SetWindowMaximizeCallback(WindowHandle* window,
            GlfwCallbacks.WindowMaximizeCallback callback);

        /// <inheritdoc />
        public abstract unsafe void SetWindowTitle(WindowHandle* window, string title);

        /// <inheritdoc />
        public abstract unsafe void ShowWindow(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe void SetWindowSize(WindowHandle* window, int width, int height);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.WindowSizeCallback SetWindowSizeCallback(WindowHandle* window,
            GlfwCallbacks.WindowSizeCallback callback);

        /// <inheritdoc />
        public abstract unsafe void SetWindowShouldClose(WindowHandle* window, bool value);

        /// <inheritdoc />
        public abstract unsafe void SetWindowMonitor(WindowHandle* window, Monitor* monitor, int x, int y, int width,
            int height, int refreshRate);

        /// <inheritdoc />
        public abstract unsafe void SetWindowPos(WindowHandle* window, int x, int y);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.WindowPosCallback SetWindowPosCallback(WindowHandle* window,
            GlfwCallbacks.WindowPosCallback callback);

        /// <inheritdoc />
        public abstract unsafe GlfwCallbacks.WindowRefreshCallback SetWindowRefreshCallback(WindowHandle* window,
            GlfwCallbacks.WindowRefreshCallback callback);

        /// <inheritdoc />
        public abstract void SwapInterval(int interval);

        /// <inheritdoc />
        public abstract void WaitEvents();

        /// <inheritdoc />
        public abstract void WaitEventsTimeout(double timeout);

        /// <inheritdoc />
        public abstract unsafe string GetClipboardString(WindowHandle* window);

        /// <inheritdoc />
        public abstract unsafe void SetClipboardString(WindowHandle* window, string data);

        /// <inheritdoc />
        public abstract bool VulkanSupported();

        /// <inheritdoc />
        public abstract unsafe byte** GetRequiredInstanceExtensions(out uint count);

        /// <inheritdoc />
        public abstract unsafe IntPtr GetInstanceProcAddress(VkHandle instance, byte* procName);

        /// <inheritdoc />
        public abstract bool GetPhysicalDevicePresentationSupport(VkHandle instance, VkHandle device, int queueFamily);

        /// <inheritdoc />
        public abstract unsafe int CreateWindowSurface(VkHandle instance, WindowHandle* window, void* allocator,
            VkHandle* surface);

        /// <inheritdoc />
        public abstract IntPtr GetProcAddress(string name);

        /// <inheritdoc />
        public abstract unsafe void GetMonitorWorkarea(Monitor* monitor, out int x, out int y, out int width, out int height);

        /// <summary>
        /// Gets an instance of the API.
        /// </summary>
        /// <returns>The instance.</returns>
        public static Glfw GetApi()
        {
            return LibraryLoader.Load<Glfw>(new GlfwLibraryNameContainer());
        }

        public override bool IsExtensionPresent(string name)
        {
            throw new NotSupportedException("Extensions are invalid for GLFW");
        }
    }
}