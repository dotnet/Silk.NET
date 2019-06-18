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
    public abstract class GLFW : NativeAPI, IGLFW
    {
        /// <summary>
        /// Gets an integer equal to GLFW_DONT_CARE. This can be used for several window hints to use the platform default.
        /// </summary>
        public const int DontCare = -1;

        /// <inheritdoc cref="NativeLibraryBase" />
        protected GLFW(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <summary>
        /// Gets the default callback which gets called when a GLFW-Error occurs.
        /// </summary>
        /// <seealso cref="SetErrorCallback" />
        public static GLFWCallbacks.ErrorCallback ErrorCallback { get; } = (errorCode, description) =>
            throw new GLFWException(description) {ErrorCode = errorCode};

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
        public abstract unsafe void SetWindowSizeLimits(Window* window, int minwidth, int minheight, int maxwidth,
            int maxheight);

        /// <inheritdoc />
        public abstract unsafe void SetWindowAspectRatio(Window* window, int numer, int denom);

        /// <inheritdoc />
        public abstract unsafe void GetWindowFrameSize(Window* window, out int left, out int top, out int right,
            out int bottom);

        /// <inheritdoc />
        public abstract unsafe float GetWindowOpacity(Window* window);

        /// <inheritdoc />
        public abstract unsafe void SetWindowOpacity(Window* window, float opacity);

        /// <inheritdoc />
        public abstract unsafe void RequestWindowAttention(Window* window);

        /// <inheritdoc />
        public abstract unsafe void SetWindowAttrib(Window* window, WindowAttributeSetter attrib, bool value);

        /// <inheritdoc />
        public abstract bool RawMouseMotionSupported();

        /// <inheritdoc />
        public abstract string GetKeyName(int key, int scancode);

        /// <inheritdoc />
        public abstract int GetKeyScancode(int key);

        /// <inheritdoc />
        public abstract unsafe int GetKey(Window* window, int key);

        /// <inheritdoc />
        public abstract unsafe int GetMouseButton(Window* window, int button);

        /// <inheritdoc />
        public abstract unsafe void GetCursorPos(Window* window, out double xpos, out double ypos);

        /// <inheritdoc />
        public abstract unsafe void SetCursorPos(Window* window, double xpos, double ypos);

        /// <inheritdoc />
        public abstract unsafe Cursor* CreateCursor(Image* image, int xhot, int yhot);

        /// <inheritdoc />
        public abstract unsafe Cursor* CreateStandardCursor(CursorShape shape);

        /// <inheritdoc />
        public abstract unsafe void DestroyCursor(Cursor* cursor);

        /// <inheritdoc />
        public abstract unsafe void SetCursor(Window* window, Cursor* cursor);

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
        public abstract unsafe Window* GetCurrentContext();

        /// <inheritdoc />
        public abstract unsafe void SwapBuffers(Window* window);

        /// <inheritdoc />
        public abstract bool ExtensionSupported(string extensionName);

        /// <inheritdoc />
        public abstract unsafe Window* CreateWindow(int width, int height, string title, Monitor* monitor,
            Window* share);

        /// <inheritdoc />
        public abstract unsafe Monitor* GetPrimaryMonitor();

        /// <inheritdoc />
        public abstract unsafe void DestroyWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe void FocusWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe void GetFramebufferSize(Window* window, out int width, out int height);

        /// <inheritdoc />
        public abstract unsafe CursorModeValue GetInputMode(Window* window, CursorStateAttribute mode);

        /// <inheritdoc />
        public abstract unsafe bool GetInputMode(Window* window, StickyAttributes mode);

        /// <inheritdoc />
        public abstract unsafe void RestoreWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe VideoMode* GetVideoMode(Monitor* monitor);

        /// <inheritdoc />
        public abstract unsafe bool GetWindowAttrib(Window* window, WindowAttributeGetter attribute);

        /// <inheritdoc />
        public abstract unsafe void GetWindowSize(Window* window, out int width, out int height);

        /// <inheritdoc />
        public abstract unsafe void GetWindowPos(Window* window, out int x, out int y);

        /// <inheritdoc />
        public abstract unsafe Monitor* GetWindowMonitor(Window* window);

        /// <inheritdoc />
        public abstract unsafe void HideWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe void IconifyWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe void MakeContextCurrent(Window* window);

        /// <inheritdoc />
        public abstract unsafe void MaximizeWindow(Window* window);

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
        public abstract unsafe bool WindowShouldClose(Window* window);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.CharCallback SetCharCallback(Window* window,
            GLFWCallbacks.CharCallback callback);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.CharModsCallback SetCharModsCallback(Window* window,
            GLFWCallbacks.CharModsCallback callback);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.CursorEnterCallback SetCursorEnterCallback(Window* window,
            GLFWCallbacks.CursorEnterCallback callback);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.CursorPosCallback SetCursorPosCallback(Window* window,
            GLFWCallbacks.CursorPosCallback callback);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.DropCallback SetDropCallback(Window* window,
            GLFWCallbacks.DropCallback callback);

        /// <inheritdoc />
        public abstract GLFWCallbacks.ErrorCallback SetErrorCallback(GLFWCallbacks.ErrorCallback callback);

        /// <inheritdoc />
        public abstract unsafe void SetInputMode(Window* window, CursorStateAttribute mode, CursorModeValue value);

        /// <inheritdoc />
        public abstract unsafe void SetInputMode(Window* window, StickyAttributes mode, bool value);

        /// <inheritdoc />
        public abstract GLFWCallbacks.JoystickCallback SetJoystickCallback(GLFWCallbacks.JoystickCallback callback);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.KeyCallback SetKeyCallback(Window* window,
            GLFWCallbacks.KeyCallback callback);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.ScrollCallback SetScrollCallback(Window* window,
            GLFWCallbacks.ScrollCallback callback);

        /// <inheritdoc />
        public abstract GLFWCallbacks.MonitorCallback SetMonitorCallback(GLFWCallbacks.MonitorCallback callback);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.MouseButtonCallback SetMouseButtonCallback(Window* window,
            GLFWCallbacks.MouseButtonCallback callback);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.WindowCloseCallback SetWindowCloseCallback(Window* window,
            GLFWCallbacks.WindowCloseCallback callback);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.WindowFocusCallback SetWindowFocusCallback(Window* window,
            GLFWCallbacks.WindowFocusCallback callback);

        /// <inheritdoc />
        public abstract unsafe void SetWindowIcon(Window* window, int count, Image* images);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.WindowIconifyCallback SetWindowIconifyCallback(Window* window,
            GLFWCallbacks.WindowIconifyCallback callback);

        /// <inheritdoc />
        public abstract unsafe void SetWindowTitle(Window* window, string title);

        /// <inheritdoc />
        public abstract unsafe void ShowWindow(Window* window);

        /// <inheritdoc />
        public abstract unsafe void SetWindowSize(Window* window, int width, int height);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.WindowSizeCallback SetWindowSizeCallback(Window* window,
            GLFWCallbacks.WindowSizeCallback callback);

        /// <inheritdoc />
        public abstract unsafe void SetWindowShouldClose(Window* window, bool value);

        /// <inheritdoc />
        public abstract unsafe void SetWindowMonitor(Window* window, Monitor* monitor, int x, int y, int width,
            int height, int refreshRate);

        /// <inheritdoc />
        public abstract unsafe void SetWindowPos(Window* window, int x, int y);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.WindowPosCallback SetWindowPosCallback(Window* window,
            GLFWCallbacks.WindowPosCallback callback);

        /// <inheritdoc />
        public abstract unsafe GLFWCallbacks.WindowRefreshCallback SetWindowRefreshCallback(Window* window,
            GLFWCallbacks.WindowRefreshCallback callback);

        /// <inheritdoc />
        public abstract void SwapInterval(int interval);

        /// <inheritdoc />
        public abstract void WaitEvents();

        /// <inheritdoc />
        public abstract void WaitEventsTimeout(double timeout);

        /// <inheritdoc />
        public abstract unsafe string GetClipboardString(Window* window);

        /// <inheritdoc />
        public abstract unsafe void SetClipboardString(Window* window, string data);

        /// <inheritdoc />
        public abstract bool VulkanSupported();

        /// <inheritdoc />
        public abstract unsafe byte** GetRequiredInstanceExtensions(out uint count);

        /// <inheritdoc />
        public abstract unsafe IntPtr GetInstanceProcAddress(VkHandle instance, byte* procName);

        /// <inheritdoc />
        public abstract bool GetPhysicalDevicePresentationSupport(VkHandle instance, VkHandle device, int queueFamily);

        /// <inheritdoc />
        public abstract unsafe int CreateWindowSurface(VkHandle instance, Window* window, void* allocator,
            VkHandle surface);

        /// <summary>
        /// Gets an instance of the API.
        /// </summary>
        /// <returns>The instance.</returns>
        public static GLFW GetAPI()
        {
            return LibraryLoader.Load<GLFW>(new GLFWLibraryNameContainer());
        }
    }
}