// File preserved for documentation purposes.
#if false
// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
namespace Silk.NET.GLFW
{
    // TODO: Enums for GLFW keys/mouse buttons

    /// <summary>
    /// Defines the public interface of the GLFW library.
    /// </summary>
    [NativeSymbols(Prefix = "glfw")]
    public interface IGlfw
    {
        // XML-documentation is from https://www.glfw.org/docs/latest/
        // Still missing in documentation


        bool Init();


        void Terminate();


        void InitHint(InitHint hint, bool value);


        void GetVersion(out int major, out int minor, out int revision);


        string GetVersionString();


        unsafe ErrorCode GetError(out char* description);


        unsafe Monitor** GetMonitors(out int count);


        unsafe void GetMonitorPos(Monitor* monitor, out int x, out int y);

 
        unsafe void GetMonitorPhysicalSize(Monitor* monitor, out int width, out int height);


        unsafe void GetMonitorContentScale(Monitor* monitor, out float xscale, out float yscale);


        unsafe string GetMonitorName(Monitor* monitor);


        unsafe void SetMonitorUserPointer(Monitor* monitor, IntPtr pointer);


        unsafe IntPtr GetMonitorUserPointer(Monitor* monitor);


        unsafe VideoMode* GetVideoModes(Monitor* monitor, out int count);


        unsafe void SetGamma(Monitor* monitor, float gamma);


        unsafe GammaRamp* GetGammaRamp(Monitor* monitor);

        
        unsafe void SetGammaRamp(Monitor* monitor, ref GammaRamp ramp);

        
        void DefaultWindowHints();

        
        void WindowHintString(int hint, string value);

        
        unsafe void SetWindowSizeLimits(WindowHandle* window, int minwidth, int minheight, int maxwidth, int maxheight);

        
        unsafe void SetWindowAspectRatio(WindowHandle* window, int numer, int denom);

        
        unsafe void GetWindowFrameSize(WindowHandle* window, out int left, out int top, out int right, out int bottom);

        
        unsafe float GetWindowOpacity(WindowHandle* window);

        
        unsafe void SetWindowOpacity(WindowHandle* window, float opacity);

        
        unsafe void RequestWindowAttention(WindowHandle* window);

        
        unsafe void SetWindowAttrib(WindowHandle* window, WindowAttributeSetter attribute, bool value);

        
        bool RawMouseMotionSupported();

        
        string GetKeyName(int key, int scancode);

        
        int GetKeyScancode(int key);

        
        unsafe int GetKey(WindowHandle* window, Keys key);

        
        unsafe int GetMouseButton(WindowHandle* window, int button);

        
        unsafe void GetCursorPos(WindowHandle* window, out double xpos, out double ypos);

        
        unsafe void SetCursorPos(WindowHandle* window, double xpos, double ypos);

        
        unsafe Cursor* CreateCursor(Image* image, int xhot, int yhot);

        
        unsafe Cursor* CreateStandardCursor(CursorShape shape);

        
        unsafe void DestroyCursor(Cursor* cursor);

        
        unsafe void SetCursor(WindowHandle* window, Cursor* cursor);

        
        bool JoystickPresent(int jid);

        
        unsafe float* GetJoystickAxes(int jid, out int count);

        
        unsafe byte* GetJoystickButtons(int jid, out int count);

        
        unsafe JoystickHats* GetJoystickHats(int jid, out int count);

       
        string GetJoystickName(int jid);

        
        string GetJoystickGUID(int jid);

        
        void SetJoystickUserPointer(int jid, IntPtr ptr);

        
        IntPtr GetJoystickUserPointer(int jid);

        
        bool JoystickIsGamepad(int jid);

        
        bool UpdateGamepadMappings(string newMapping);

        
        string GetGamepadName(int jid);

        
        bool GetGamepadState(int jid, out GamepadState state);

        
        double GetTime();

        
        void SetTime(double time);

        
        long GetTimerValue();

        
        long GetTimerFrequency();

        
        unsafe WindowHandle* GetCurrentContext();

        
        unsafe void SwapBuffers(WindowHandle* window);

        
        bool ExtensionSupported(string extensionName);

        
        unsafe WindowHandle* CreateWindow(int width, int height, string title, Monitor* monitor, WindowHandle* share);

        
        unsafe void DestroyWindow(WindowHandle* window);

        
        unsafe void FocusWindow(WindowHandle* window);

        
        unsafe string GetClipboardString(WindowHandle* window);

        
        unsafe void GetFramebufferSize(WindowHandle* window, out int width, out int height);

        
        unsafe bool GetInputMode(WindowHandle* window, StickyAttributes mode);

        
        unsafe CursorModeValue GetInputMode(WindowHandle* window, CursorStateAttribute mode);

        
        unsafe Monitor* GetPrimaryMonitor();

        
        unsafe VideoMode* GetVideoMode(Monitor* monitor);

        
        unsafe bool GetWindowAttrib(WindowHandle* window, WindowAttributeGetter attribute);

        
        unsafe void GetWindowSize(WindowHandle* window, out int width, out int height);

        
        unsafe void GetWindowPos(WindowHandle* window, out int x, out int y);

        
        unsafe Monitor* GetWindowMonitor(WindowHandle* window);

       
        unsafe void HideWindow(WindowHandle* window);

        
        unsafe void IconifyWindow(WindowHandle* window);

       
        unsafe void MakeContextCurrent(WindowHandle* window);

       
        unsafe void MaximizeWindow(WindowHandle* window);

       
        void PollEvents();

      
        void PostEmptyEvent();

        
        unsafe void RestoreWindow(WindowHandle* window);

        
        unsafe GlfwCallbacks.CharCallback SetCharCallback(WindowHandle* window, [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.CharCallback callback);

        
        unsafe GlfwCallbacks.CharModsCallback SetCharModsCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.CharModsCallback callback);

        /// <summary>
        /// <para>
        /// This function sets the system clipboard to the specified, UTF-8 encoded string.
        /// </para>
        /// </summary>
        /// <param name="window">The window that will own the clipboard contents. </param>
        /// <param name="data">A UTF-8 encoded string.</param>
        /// <remarks>
        /// <para>
        /// The specified string is copied before this function returns.
        /// </para>
        /// <para>
        /// This function must only be called from the main thread.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        /// </para>
        /// </remarks>
        /// <seealso cref="GetClipboardString" />
        unsafe void SetClipboardString(WindowHandle* window, string data);

        
        unsafe GlfwCallbacks.CursorEnterCallback SetCursorEnterCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.CursorEnterCallback callback);

        
        unsafe GlfwCallbacks.CursorPosCallback SetCursorPosCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.CursorPosCallback callback);

        
        unsafe GlfwCallbacks.DropCallback SetDropCallback(WindowHandle* window, [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.DropCallback callback);

        
        GlfwCallbacks.ErrorCallback SetErrorCallback([DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.ErrorCallback callback);

        
        unsafe void SetInputMode(WindowHandle* window, CursorStateAttribute mode, CursorModeValue value);

        
        unsafe void SetInputMode(WindowHandle* window, StickyAttributes mode, bool value);

        
        GlfwCallbacks.JoystickCallback SetJoystickCallback([DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.JoystickCallback callback);

        
        unsafe GlfwCallbacks.KeyCallback SetKeyCallback(WindowHandle* window, [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.KeyCallback callback);

        
        unsafe GlfwCallbacks.ScrollCallback SetScrollCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.ScrollCallback callback);

        
        GlfwCallbacks.MonitorCallback SetMonitorCallback([DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.MonitorCallback callback);

        
        unsafe GlfwCallbacks.MouseButtonCallback SetMouseButtonCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.MouseButtonCallback callback);

        
        unsafe GlfwCallbacks.WindowCloseCallback SetWindowCloseCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.WindowCloseCallback callback);

        
        unsafe GlfwCallbacks.WindowFocusCallback SetWindowFocusCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.WindowFocusCallback callback);

        
        unsafe void SetWindowIcon(WindowHandle* window, int count, Image* images);

        
        unsafe GlfwCallbacks.WindowIconifyCallback SetWindowIconifyCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.WindowIconifyCallback callback);

        
        unsafe GlfwCallbacks.WindowMaximizeCallback SetWindowMaximizeCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.WindowMaximizeCallback callback);

        
        unsafe void SetWindowMonitor(WindowHandle* window, Monitor* monitor, int x, int y, int width, int height,
            int refreshRate);

        /// <summary>
        /// <para>
        /// This function sets the position, in screen coordinates,
        /// of the upper-left corner of the client area of the specified windowed mode window.
        /// </para>
        /// <para>
        /// If the window is a full screen window, this function does nothing.
        /// </para>
        /// <para>
        /// Do not use this function to move an already visible window
        /// unless you have very good reasons for doing so, as it will confuse and annoy the user.
        /// </para>
        /// <para>
        /// The window manager may put limits on what positions are allowed.
        /// GLFW cannot and should not override these limits.
        /// </para>
        /// </summary>
        /// <param name="window">The window to query.</param>
        /// <param name="x">The x-coordinate of the upper-left corner of the client area.</param>
        /// <param name="y">The y-coordinate of the upper-left corner of the client area.</param>
        /// <remarks>
        /// <para>
        /// This function must only be called from the main thread.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        /// </para>
        /// </remarks>
        /// <seealso cref="GetWindowPos" />
        unsafe void SetWindowPos(WindowHandle* window, int x, int y);

        /// <summary>
        /// <para>
        /// This function sets the position callback of the specified window, which is called when the window is moved.
        /// </para>
        /// <para>
        /// The callback is provided with the screen position of the upper-left corner of the client area of the window.
        /// </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        /// The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        /// <para>
        /// This function must only be called from the main thread.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" />.
        /// </para>
        /// </remarks>
        unsafe GlfwCallbacks.WindowPosCallback SetWindowPosCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.WindowPosCallback callback);

        /// <summary>
        /// <para>
        /// Sets the refresh callback for the specified window.
        /// </para>
        /// <para>
        /// This function sets the refresh callback of the specified window, which is
        /// called when the content area of the window needs to be redrawn, for example
        /// if the window has been exposed after having been covered by another window.
        /// </para>
        /// <para>
        /// On compositing window systems such as Aero, Compiz, Aqua or Wayland, where
        /// the window contents are saved off-screen, this callback may be called only
        /// very infrequently or never at all.
        /// </para>
        /// </summary>
        /// <param name="window">The window whose callback to set.</param>
        /// <param name="callback">The new callback, or <c>null</c> to remove the currently set callback.</param>
        /// <returns>
        /// The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.
        /// </returns>
        /// <remarks>
        /// <para>
        /// This function must only be called from the main thread.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" />.
        /// </para>
        /// </remarks>
        unsafe GlfwCallbacks.WindowRefreshCallback SetWindowRefreshCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.WindowRefreshCallback callback);

        
        unsafe void SetWindowSize(WindowHandle* window, int width, int height);

        
        unsafe GlfwCallbacks.WindowSizeCallback SetWindowSizeCallback(WindowHandle* window,
            [DelegateLifetime(DelegateLifetime.Persistent)]GlfwCallbacks.WindowSizeCallback callback);

        /// <summary>
        /// <para>
        /// This function sets the value of the close flag of the specified window.
        /// </para>
        /// <para>
        /// This can be used to override the user's attempt to close the window, or to signal that it should be closed.
        /// </para>
        /// </summary>
        /// <param name="window">The window whose flag to change.</param>
        /// <param name="value">The new value.</param>
        /// <remarks>
        /// <para>
        /// This function may be called from any thread. Access is not synchronized.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" />.
        /// </para>
        /// </remarks>
        unsafe void SetWindowShouldClose(WindowHandle* window, bool value);

        
        unsafe void SetWindowTitle(WindowHandle* window, string title);

        
        unsafe void ShowWindow(WindowHandle* window);

        /// <summary>
        /// <para>
        /// This function sets the swap interval for the current OpenGL or OpenGL ES context,
        /// i.e. the number of screen updates to wait from the time <see cref="SwapBuffers" /> was called
        /// before swapping the buffers and returning.
        /// This is sometimes called vertical synchronization, vertical retrace synchronization or just vsync.
        /// </para>
        /// <para>
        /// A context that supports either of the <c>WGL_EXT_swap_control_tear</c>
        /// and <c>GLX_EXT_swap_control_tear</c> extensions also accepts negative swap intervals,
        /// which allows the driver to swap immediately even if a frame arrives a little bit late.
        /// You can check for these extensions with <see cref="ExtensionSupported" />.
        /// </para>
        /// <para>
        /// A context must be current on the calling thread.
        /// Calling this function without a current context will cause a <see cref="ErrorCode.NoContext" /> error.
        /// </para>
        /// </summary>
        /// <param name="interval">
        /// The minimum number of screen updates to wait for until the buffers are swapped by <see cref="SwapBuffers" />.
        /// </param>
        /// <remarks>
        /// <para>
        /// This function is not called during context creation,
        /// leaving the swap interval set to whatever is the default on that platform.
        /// This is done because some swap interval extensions used by GLFW
        /// do not allow the swap interval to be reset to zero once it has been set to a non-zero value.
        /// </para>
        /// <para>
        /// Some GPU drivers do not honor the requested swap interval,
        /// either because of a user setting that overrides the application's request or due to bugs in the driver.
        /// </para>
        /// <para>
        /// This function may be called from any thread.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.NoContext" /> and
        /// <see cref="ErrorCode.PlatformError" />.
        /// </para>
        /// </remarks>
        /// <seealso cref="SwapBuffers" />
        void SwapInterval(int interval);

        /// <summary>
        /// <para>
        /// This function puts the calling thread to sleep until at least one event is available in the event queue.
        /// </para>
        /// <para>
        /// Once one or more events are available, it behaves exactly like <see cref="PollEvents" />,
        /// i.e. the events in the queue are processed and the function then returns immediately.
        /// </para>
        /// <para>
        /// Processing events will cause the window and input callbacks associated with those events to be called.
        /// </para>
        /// <para>
        /// Since not all events are associated with callbacks,
        /// this function may return without a callback having been called even if you are monitoring all callbacks.
        /// </para>
        /// <para>
        /// On some platforms, a window move, resize or menu operation will cause event processing to block.
        /// This is due to how event processing is designed on those platforms.
        /// You can use the window refresh callback (<see cref="SetWindowRefreshCallback" />)
        /// to redraw the contents of your window when necessary during such operations.
        /// </para>
        /// <para>
        /// On some platforms,
        /// certain callbacks may be called outside of a call to one of the event processing functions.
        /// </para>
        /// <para>
        /// If no windows exist, this function returns immediately.
        /// For synchronization of threads in applications that do not create windows,
        /// use your threading library of choice.
        /// </para>
        /// <para>
        /// Event processing is not required for joystick input to work.
        /// </para>
        /// </summary>
        /// <remarks>
        /// This function must only be called from the main thread.
        /// This function must not be called from a callback.
        /// Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.PlatformError" />.
        /// </remarks>
        /// <seealso cref="PollEvents" />
        /// <seealso cref="WaitEventsTimeout" />
        void WaitEvents();

        /// <summary>
        /// <para>
        /// This function puts the calling thread to sleep until at least one event is available in the event queue,
        /// or until the specified timeout is reached.
        /// </para>
        /// <para>
        /// If one or more events are available, it behaves exactly like <see cref="PollEvents" />,
        /// i.e. the events in the queue are processed and the function then returns immediately.
        /// </para>
        /// <para>
        /// Processing events will cause the window and input callbacks associated with those events to be called.
        /// </para>
        /// <para>
        /// The timeout value must be a positive finite number.
        /// </para>
        /// <para>
        /// Since not all events are associated with callbacks,
        /// this function may return without a callback having been called even if you are monitoring all callbacks.
        /// </para>
        /// <para>
        /// On some platforms, a window move, resize or menu operation will cause event processing to block.
        /// This is due to how event processing is designed on those platforms.
        /// </para>
        /// <para>
        /// You can use the window refresh callback (<see cref="SetWindowRefreshCallback" />)
        /// to redraw the contents of your window when necessary during such operations.
        /// </para>
        /// <para>
        /// On some platforms,
        /// certain callbacks may be called outside of a call to one of the event processing functions.
        /// </para>
        /// <para>
        /// If no windows exist, this function returns immediately.
        /// </para>
        /// <para>
        /// For synchronization of threads in applications that do not create windows,
        /// use your threading library of choice.
        /// </para>
        /// <para>
        /// Event processing is not required for joystick input to work.
        /// </para>
        /// </summary>
        /// <param name="timeout">The maximum amount of time, in seconds, to wait.</param>
        /// <remarks>
        /// <para>
        /// This function must only be called from the main thread.
        /// </para>
        /// <para>
        /// This function must not be called from a callback.
        /// </para>
        /// </remarks>
        /// <seealso cref="PollEvents" />
        /// <seealso cref="WaitEvents" />
        void WaitEventsTimeout(double timeout);

        
        void WindowHint(WindowHintInt hint, int value);

        
        void WindowHint(WindowHintBool hint, bool value);

        
        void WindowHint(WindowHintClientApi hint, ClientApi value);

        
        void WindowHint(WindowHintReleaseBehavior hint, ReleaseBehavior value);

        
        void WindowHint(WindowHintContextApi hint, ContextApi value);

        
        void WindowHint(WindowHintRobustness hint, Robustness value);

        
        void WindowHint(WindowHintOpenGlProfile hint, OpenGlProfile value);

        /
        unsafe bool WindowShouldClose(WindowHandle* window);

        /// <summary>
        /// Returns whether the Vulkan loader and an ICD have been found.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This function returns whether the Vulkan loader and any minimally functional ICD have been found.
        /// </para>
        /// <para>
        /// The availability of a Vulkan loader and even an ICD does not by itself
        /// guarantee that surface creation or even instance creation is possible.
        /// For example, on Fermi systems Nvidia will install an ICD that provides no actual Vulkan support.
        /// Call <see cref="GetRequiredInstanceExtensions" /> to check whether the extensions necessary
        /// for Vulkan surface creation are available and <see cref="GetPhysicalDevicePresentationSupport" />
        /// to check whether a queue family of a physical device supports image presentation.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" />.
        /// </para>
        /// <para>
        /// This function may be called from any thread.
        /// </para>
        /// </remarks>
        /// <returns>
        /// <c>true</c> if Vulkan is minimally available, or <c>false</c> otherwise.
        /// </returns>
        bool VulkanSupported();

        /// <summary>
        /// Returns the Vulkan instance extensions required by GLFW.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This function returns an array of names of Vulkan instance extensions required by GLFW for
        /// creating Vulkan surfaces for GLFW windows. If successful, the list will always contains
        /// <c>VK_KHR_surface</c>, so if you don't require any additional extensions you can
        /// pass this list directly to the <c>VkInstanceCreateInfo</c> struct.
        /// </para>
        /// <para>
        /// If Vulkan is not available on the machine, this function returns <c>null</c> and generates
        /// a <see cref="ErrorCode.NotInitialized" /> error. Call <see cref="VulkanSupported" /> to check
        /// whether Vulkan is at least minimally available.
        /// </para>
        /// <para>
        /// If Vulkan is available but no set of extensions allowing window surface creation was found,
        /// this function returns <c>null</c>. You may still use Vulkan for off-screen rendering and compute work.
        /// </para>
        /// <para>
        /// Additional extensions may be required by future versions of GLFW.
        /// You should check if any extensions you wish to enable are already in the returned array,
        /// as it is an error to specify an extension more than once in the <c>VkInstanceCreateInfo</c> struct.
        /// </para>
        /// <para>
        /// macOS: This function currently only supports the <c>VK_MVK_macos_surface</c> extension from MoltenVK.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.ApiUnavailable" />.
        /// </para>
        /// <para>
        /// The returned array is allocated and freed by GLFW. You should not free it yourself.
        /// It is guaranteed to be valid only until the library is terminated.
        /// </para>
        /// <para>
        /// This function may be called from any thread.
        /// </para>
        /// </remarks>
        /// <param name="count">
        /// Where to store the number of extensions in the returned array.
        /// This is set to zero if an error occurred.
        /// </param>
        /// <returns>
        /// An array of ASCII encoded extension names, or <c>null</c> if an error occurred.
        /// </returns>
        unsafe byte** GetRequiredInstanceExtensions(out uint count);

        /// <summary>
        /// Returns the address of the specified Vulkan instance function.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This function returns the address of the specified Vulkan core or extension function for
        /// the specified instance. If instance is set to <c>null</c> it can return any function exported
        /// from the Vulkan loader, including at least the following functions:
        /// </para>
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>vkEnumerateInstanceExtensionProperties</c>
        /// </description>
        /// <description>
        /// <c>vkEnumerateInstanceLayerProperties</c>
        /// </description>
        /// <description>
        /// <c>vkCreateInstance</c>
        /// </description>
        /// <description>
        /// <c>vkGetInstanceProcAddr</c>
        /// </description>
        /// </item>
        /// </list>
        /// <para>
        /// If Vulkan is not available on the machine, this function returns <c>null</c> and generates
        /// a <see cref="ErrorCode.NotInitialized" /> error. Call <see cref="VulkanSupported" /> to check
        /// whether Vulkan is at least minimally available.
        /// </para>
        /// <para>
        /// This function is equivalent to calling <c>vkGetInstanceProcAddr</c> with a platform-specific
        /// query of the Vulkan loader as a fallback.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.ApiUnavailable" />.
        /// </para>
        /// <para>
        /// The returned function pointer is valid until the library is terminated.
        /// </para>
        /// </remarks>
        /// <param name="instance">
        /// The Vulkan instance to query, or <c>null</c> to retrieve functions related to instance creation.
        /// </param>
        /// <param name="procName">The ASCII encoded name of the function.</param>
        /// <returns>The address of the function, or <c>null</c> if an error occurred.</returns>
        unsafe IntPtr GetInstanceProcAddress(VkHandle instance, byte* procName);

        /// <summary>
        /// Returns whether the specified queue family can present images.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This function returns whether the specified queue family of the specified physical device
        /// supports presentation to the platform GLFW was built for.
        /// </para>
        /// <para>
        /// If Vulkan or the required window surface creation instance extensions are not available
        /// on the machine, or if the specified instance was not created with the required extensions,
        /// this function returns <c>false</c> and generates a <see cref="ErrorCode.ApiUnavailable" /> error.
        /// Call <see cref="VulkanSupported" /> to check whether Vulkan is at least minimally available and
        /// <see cref="GetRequiredInstanceExtensions" /> to check what instance extensions are required.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" /> and <see cref="ErrorCode.ApiUnavailable" />.
        /// </para>
        /// <para>
        /// macOS: This function currently always returns <c>true</c>, as the <c>VK_MVK_macos_surface</c>
        /// extension does not provide a <c>vkGetPhysicalDevice*PresentationSupport</c> type function.
        /// </para>
        /// <para>
        /// This function may be called from any thread.
        /// For synchronization details of Vulkan objects, see the Vulkan specification.
        /// </para>
        /// </remarks>
        /// <param name="instance">The instance that the physical device belongs to.</param>
        /// <param name="device">The physical device that the queue family belongs to.</param>
        /// <param name="queueFamily">The index of the queue family to query.</param>
        /// <returns><c>true</c> if the queue family supports presentation, or <c>false</c> otherwise.</returns>
        bool GetPhysicalDevicePresentationSupport(VkHandle instance, VkHandle device, int queueFamily);

        /// <summary>
        /// Creates a Vulkan surface for the specified window.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This function creates a Vulkan surface for the specified window.
        /// </para>
        /// <para>
        /// If the Vulkan loader or at least one minimally functional ICD were not found,
        /// this function returns <c>VK_ERROR_INITIALIZATION_FAILED</c> and generates a
        /// <see cref="ErrorCode.ApiUnavailable" /> error.
        /// Call <see cref="VulkanSupported" /> to check whether Vulkan is at least minimally available.
        /// </para>
        /// <para>
        /// If the required window surface creation instance extensions are not available or
        /// if the specified instance was not created with these extensions enabled,
        /// this function returns <c>VK_ERROR_EXTENSION_NOT_PRESENT</c> and generates a
        /// <see cref="ErrorCode.ApiUnavailable" /> error.
        /// Call <see cref="GetRequiredInstanceExtensions" /> to check what instance extensions are required.
        /// </para>
        /// <para>
        /// The window surface cannot be shared with another API so the window must have been created with
        /// the client api hint set to <see cref="ClientApi.NoApi" /> otherwise it generates a
        /// <see cref="ErrorCode.InvalidValue" /> error and returns <c>VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</c>.
        /// </para>
        /// <para>
        /// The window surface must be destroyed before the specified Vulkan instance.
        /// It is the responsibility of the caller to destroy the window surface.
        /// GLFW does not destroy it for you. Call <c>vkDestroySurfaceKHR</c> to destroy the surface.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.ApiUnavailable" />,
        /// <see cref="ErrorCode.PlatformError" /> and <see cref="ErrorCode.InvalidValue" />.
        /// </para>
        /// <para>
        /// If an error occurs before the creation call is made, GLFW returns the Vulkan error code most
        /// appropriate for the error. Appropriate use of <see cref="VulkanSupported" /> and
        /// <see cref="GetRequiredInstanceExtensions" /> should eliminate almost all occurrences of these errors.
        /// </para>
        /// <para>
        /// macOS: This function currently only supports the <c>VK_MVK_macos_surface</c> extension from MoltenVK.
        /// </para>
        /// <para>
        /// macOS: This function creates and sets a <c>CAMetalLayer</c> instance for the window content view,
        /// which is required for MoltenVK to function.
        /// </para>
        /// <para>
        /// This function may be called from any thread.
        /// For synchronization details of Vulkan objects, see the Vulkan specification.
        /// </para>
        /// </remarks>
        /// <param name="instance">The Vulkan instance to create the surface in.</param>
        /// <param name="window">The window to create the surface for.</param>
        /// <param name="allocator">The allocator to use, or <c>null</c> to use the default allocator.</param>
        /// <param name="surface">
        /// Where to store the handle of the surface.
        /// This is set to <c>VK_NULL_HANDLE</c> if an error occurred.
        /// </param>
        /// <returns>
        /// <c>VK_SUCCESS</c> if successful, or a Vulkan error code if an error occurred.
        /// </returns>
        unsafe int CreateWindowSurface(VkHandle instance, WindowHandle* window, void* allocator, VkHandle* surface);

        /// <summary>
        /// <para>
        /// Returns the address of the specified function for the current context.
        /// </para>
        /// <para>
        /// This function returns the address of the specified OpenGL or OpenGL ES core
        /// or extension function, if it is supported by the current context.
        /// </para>
        /// <para>
        /// A context must be current on the calling thread.  Calling this function without a current context will
        /// cause a <see cref="ErrorCode.NoContext" /> error. This function does not apply to Vulkan.  If you are rendering
        /// with Vulkan, see <see cref="GetInstanceProcAddress" />, <see cref="GetInstanceProcAddr" /> and
        /// <see cref="GetDeviceProcAddr" /> instead.
        /// </para>
        /// <para>
        /// Possible errors include <see cref="ErrorCode.NotInitialized" />, <see cref="ErrorCode.NoContext" /> and
        /// <see cref="ErrorCode.PlatformError" />.
        /// </para>
        /// <remarks>
        /// <para>
        /// The address of a given function is not guaranteed to be the same between contexts.
        /// </para>
        /// <para>
        /// This function may return a non-<see cref="IntPtr.Zero" /> address despite the associated version or extension not being
        /// available.  Always check the context version or extension string first.
        /// </para>
        /// <para>
        /// The returned function pointer is valid until the context is destroyed or the library is terminated.
        /// </para>
        /// <para>
        /// This function may be called from any thread.
        /// </para>
        /// </remarks>
        /// </summary>
        /// <param name="name">The ASCII encoded name of the function.</param>
        /// <returns>The address of the function, or IntPtr.Zero if an error occurred.</returns>
        IntPtr GetProcAddress(string name);

        
        /// <summary>Retrieves the work area of the monitor.</summary>
        /// <remarks>
        /// <para>
        /// This function returns the position, in screen coordinates, of the upper-left
        /// corner of the work area of the specified monitor along with the work area
        /// size in screen coordinates. The work area is defined as the area of the
        /// monitor not occluded by the operating system task bar where present. If no
        /// task bar exists then the work area is the monitor resolution in screen
        /// coordinates.
        /// </para>
        /// <para>
        /// Any or all of the position and size arguments may be <code>null</code>.  If an error
        /// occurs, all non-<code>null</code> position and size arguments will be set to zero.
        /// </para>
        /// </remarks>
        /// <param name="monitor">The monitor to query.</param>
        /// <param name="xpos">Where to store the monitor x-coordinate, or <code>null</code>.</param>
        /// <param name="ypos">Where to store the monitor y-coordinate, or <code>null</code>.</param>
        /// <param name="width">Where to store the monitor width, or <code>null</code>.</param>
        /// <param name="height">Where to store the monitor height, or <code>null</code>.</param>
        unsafe void GetMonitorWorkarea(Monitor* monitor, out int x, out int y, out int width, out int height);
    }
}
#endif