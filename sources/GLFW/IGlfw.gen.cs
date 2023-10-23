// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Silk.NET.GLFW;

public unsafe partial interface IGlfw
{
    public partial interface Static
    {
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        static abstract Mut<Cursor> CreateCursor(
            [NativeTypeName("const GLFWimage *")] Ptr<Image> image,
            int xhot,
            int yhot
        );

        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        static abstract Mut<Cursor> CreateStandardCursor(int shape);

        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        static abstract Mut<Window> CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] Ptr<sbyte> title,
            Mut<Monitor> monitor,
            Mut<Window> share
        );

        [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
        static abstract void DefaultWindowHints();

        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        static abstract void DestroyCursor(Mut<Cursor> cursor);

        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        static abstract void DestroyWindow(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        static abstract int ExtensionSupported(
            [NativeTypeName("const char *")] Ptr<sbyte> extension
        );

        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        static abstract void FocusWindow(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        static abstract Ptr<sbyte> GetClipboardString(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        static abstract Mut<Window> GetCurrentContext();

        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        static abstract void GetCursorPos(Mut<Window> window, Mut<double> xpos, Mut<double> ypos);

        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        static abstract int GetError([NativeTypeName("const char **")] PtrPtr<sbyte> description);

        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        static abstract void GetFramebufferSize(
            Mut<Window> window,
            Mut<int> width,
            Mut<int> height
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        static abstract Ptr<sbyte> GetGamepadName(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        static abstract int GetGamepadState(int jid, Mut<Gamepadstate> state);

        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        static abstract Ptr<Gammaramp> GetGammaRamp(Mut<Monitor> monitor);

        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        static abstract int GetInputMode(Mut<Window> window, int mode);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        static abstract Ptr<float> GetJoystickAxes(int jid, Mut<int> count);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        static abstract Ptr<byte> GetJoystickButtons(int jid, Mut<int> count);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        static abstract Ptr<sbyte> GetJoystickGuid(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        static abstract Ptr<byte> GetJoystickHats(int jid, Mut<int> count);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        static abstract Ptr<sbyte> GetJoystickName(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        static abstract Mut GetJoystickUserPointer(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        static abstract int GetKey(Mut<Window> window, int key);

        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        static abstract Ptr<sbyte> GetKeyName(int key, int scancode);

        [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
        static abstract int GetKeyScancode(int key);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        static abstract void GetMonitorContentScale(
            Mut<Monitor> monitor,
            Mut<float> xscale,
            Mut<float> yscale
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        static abstract Ptr<sbyte> GetMonitorName(Mut<Monitor> monitor);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        static abstract void GetMonitorPhysicalSize(
            Mut<Monitor> monitor,
            Mut<int> widthMM,
            Mut<int> heightMM
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        static abstract void GetMonitorPos(Mut<Monitor> monitor, Mut<int> xpos, Mut<int> ypos);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        static abstract MutMut<Monitor> GetMonitors(Mut<int> count);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        static abstract Mut GetMonitorUserPointer(Mut<Monitor> monitor);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        static abstract void GetMonitorWorkarea(
            Mut<Monitor> monitor,
            Mut<int> xpos,
            Mut<int> ypos,
            Mut<int> width,
            Mut<int> height
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        static abstract int GetMouseButton(Mut<Window> window, int button);

        [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
        static abstract int GetPlatform();

        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        static abstract Mut<Monitor> GetPrimaryMonitor();

        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        static abstract delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] Ptr<sbyte> procname
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        static abstract PtrPtr<sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Mut<uint> count
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
        static abstract double GetTime();

        [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
        static abstract ulong GetTimerFrequency();

        [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
        static abstract ulong GetTimerValue();

        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        static abstract void GetVersion(Mut<int> major, Mut<int> minor, Mut<int> rev);

        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        static abstract Ptr<sbyte> GetVersionString();

        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        static abstract Ptr<Vidmode> GetVideoMode(Mut<Monitor> monitor);

        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        static abstract Ptr<Vidmode> GetVideoModes(Mut<Monitor> monitor, Mut<int> count);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        static abstract int GetWindowAttrib(Mut<Window> window, int attrib);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        static abstract void GetWindowContentScale(
            Mut<Window> window,
            Mut<float> xscale,
            Mut<float> yscale
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        static abstract void GetWindowFrameSize(
            Mut<Window> window,
            Mut<int> left,
            Mut<int> top,
            Mut<int> right,
            Mut<int> bottom
        );

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        static abstract Mut<Monitor> GetWindowMonitor(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        static abstract float GetWindowOpacity(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        static abstract void GetWindowPos(Mut<Window> window, Mut<int> xpos, Mut<int> ypos);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        static abstract void GetWindowSize(Mut<Window> window, Mut<int> width, Mut<int> height);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        static abstract Mut GetWindowUserPointer(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        static abstract void HideWindow(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        static abstract void IconifyWindow(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwInit")]
        static abstract int Init();

        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        static abstract void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Ptr<Allocator> allocator
        );

        [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
        static abstract void InitHint(int hint, int value);

        [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
        static abstract int JoystickIsGamepad(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
        static abstract int JoystickPresent(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        static abstract void MakeContextCurrent(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        static abstract void MaximizeWindow(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
        static abstract int PlatformSupported(int platform);

        [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
        static abstract void PollEvents();

        [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
        static abstract void PostEmptyEvent();

        [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
        static abstract int RawMouseMotionSupported();

        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        static abstract void RequestWindowAttention(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        static abstract void RestoreWindow(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        static abstract delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        static abstract delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        static abstract void SetClipboardString(
            Mut<Window> window,
            [NativeTypeName("const char *")] Ptr<sbyte> @string
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        static abstract void SetCursor(Mut<Window> window, Mut<Cursor> cursor);

        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        static abstract void SetCursorPos(Mut<Window> window, double xpos, double ypos);

        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        static abstract delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        static abstract delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
        static abstract delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        static abstract void SetGamma(Mut<Monitor> monitor, float gamma);

        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        static abstract void SetGammaRamp(
            Mut<Monitor> monitor,
            [NativeTypeName("const GLFWgammaramp *")] Ptr<Gammaramp> ramp
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        static abstract void SetInputMode(Mut<Window> window, int mode, int value);

        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
        static abstract delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        static abstract void SetJoystickUserPointer(int jid, Mut pointer);

        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        static abstract delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
        static abstract delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        static abstract void SetMonitorUserPointer(Mut<Monitor> monitor, Mut pointer);

        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        static abstract delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        static abstract delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
        static abstract void SetTime(double time);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        static abstract void SetWindowAspectRatio(Mut<Window> window, int numer, int denom);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        static abstract void SetWindowAttrib(Mut<Window> window, int attrib, int value);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        static abstract delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        static abstract delegate* unmanaged<
            Window*,
            float,
            float,
            void> SetWindowContentScaleCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        static abstract void SetWindowIcon(
            Mut<Window> window,
            int count,
            [NativeTypeName("const GLFWimage *")] Ptr<Image> images
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        static abstract void SetWindowMonitor(
            Mut<Window> window,
            Mut<Monitor> monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        static abstract void SetWindowOpacity(Mut<Window> window, float opacity);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        static abstract void SetWindowPos(Mut<Window> window, int xpos, int ypos);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        static abstract delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        static abstract void SetWindowShouldClose(Mut<Window> window, int value);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        static abstract void SetWindowSize(Mut<Window> window, int width, int height);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        static abstract void SetWindowSizeLimits(
            Mut<Window> window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        static abstract void SetWindowTitle(
            Mut<Window> window,
            [NativeTypeName("const char *")] Ptr<sbyte> title
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        static abstract void SetWindowUserPointer(Mut<Window> window, Mut pointer);

        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        static abstract void ShowWindow(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        static abstract void SwapBuffers(Mut<Window> window);

        [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
        static abstract void SwapInterval(int interval);

        [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
        static abstract void Terminate();

        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        static abstract int UpdateGamepadMappings(
            [NativeTypeName("const char *")] Ptr<sbyte> @string
        );

        [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
        static abstract int VulkanSupported();

        [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
        static abstract void WaitEvents();

        [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
        static abstract void WaitEventsTimeout(double timeout);

        [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
        static abstract void WindowHint(int hint, int value);

        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        static abstract void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] Ptr<sbyte> value
        );

        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        static abstract int WindowShouldClose(Mut<Window> window);
    }

    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    Mut<Cursor> CreateCursor(
        [NativeTypeName("const GLFWimage *")] Ptr<Image> image,
        int xhot,
        int yhot
    );

    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    Mut<Cursor> CreateStandardCursor(int shape);

    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    Mut<Window> CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] Ptr<sbyte> title,
        Mut<Monitor> monitor,
        Mut<Window> share
    );

    [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
    void DefaultWindowHints();

    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    void DestroyCursor(Mut<Cursor> cursor);

    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    void DestroyWindow(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    int ExtensionSupported([NativeTypeName("const char *")] Ptr<sbyte> extension);

    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    void FocusWindow(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    Ptr<sbyte> GetClipboardString(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    Mut<Window> GetCurrentContext();

    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    void GetCursorPos(Mut<Window> window, Mut<double> xpos, Mut<double> ypos);

    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    int GetError([NativeTypeName("const char **")] PtrPtr<sbyte> description);

    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    void GetFramebufferSize(Mut<Window> window, Mut<int> width, Mut<int> height);

    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    Ptr<sbyte> GetGamepadName(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    int GetGamepadState(int jid, Mut<Gamepadstate> state);

    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    Ptr<Gammaramp> GetGammaRamp(Mut<Monitor> monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    int GetInputMode(Mut<Window> window, int mode);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    Ptr<float> GetJoystickAxes(int jid, Mut<int> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    Ptr<byte> GetJoystickButtons(int jid, Mut<int> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    Ptr<sbyte> GetJoystickGuid(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    Ptr<byte> GetJoystickHats(int jid, Mut<int> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    Ptr<sbyte> GetJoystickName(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    Mut GetJoystickUserPointer(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    int GetKey(Mut<Window> window, int key);

    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    Ptr<sbyte> GetKeyName(int key, int scancode);

    [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
    int GetKeyScancode(int key);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    void GetMonitorContentScale(Mut<Monitor> monitor, Mut<float> xscale, Mut<float> yscale);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    Ptr<sbyte> GetMonitorName(Mut<Monitor> monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    void GetMonitorPhysicalSize(Mut<Monitor> monitor, Mut<int> widthMM, Mut<int> heightMM);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    void GetMonitorPos(Mut<Monitor> monitor, Mut<int> xpos, Mut<int> ypos);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    MutMut<Monitor> GetMonitors(Mut<int> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    Mut GetMonitorUserPointer(Mut<Monitor> monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    void GetMonitorWorkarea(
        Mut<Monitor> monitor,
        Mut<int> xpos,
        Mut<int> ypos,
        Mut<int> width,
        Mut<int> height
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    int GetMouseButton(Mut<Window> window, int button);

    [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
    int GetPlatform();

    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    Mut<Monitor> GetPrimaryMonitor();

    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    delegate* unmanaged<void> GetProcAddress([NativeTypeName("const char *")] Ptr<sbyte> procname);

    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    PtrPtr<sbyte> GetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] Mut<uint> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
    double GetTime();

    [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
    ulong GetTimerFrequency();

    [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
    ulong GetTimerValue();

    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    void GetVersion(Mut<int> major, Mut<int> minor, Mut<int> rev);

    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    Ptr<sbyte> GetVersionString();

    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    Ptr<Vidmode> GetVideoMode(Mut<Monitor> monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    Ptr<Vidmode> GetVideoModes(Mut<Monitor> monitor, Mut<int> count);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    int GetWindowAttrib(Mut<Window> window, int attrib);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    void GetWindowContentScale(Mut<Window> window, Mut<float> xscale, Mut<float> yscale);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    void GetWindowFrameSize(
        Mut<Window> window,
        Mut<int> left,
        Mut<int> top,
        Mut<int> right,
        Mut<int> bottom
    );

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    Mut<Monitor> GetWindowMonitor(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    float GetWindowOpacity(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    void GetWindowPos(Mut<Window> window, Mut<int> xpos, Mut<int> ypos);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    void GetWindowSize(Mut<Window> window, Mut<int> width, Mut<int> height);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    Mut GetWindowUserPointer(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    void HideWindow(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    void IconifyWindow(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwInit")]
    int Init();

    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    void InitAllocator([NativeTypeName("const GLFWallocator *")] Ptr<Allocator> allocator);

    [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
    void InitHint(int hint, int value);

    [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
    int JoystickIsGamepad(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
    int JoystickPresent(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    void MakeContextCurrent(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    void MaximizeWindow(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
    int PlatformSupported(int platform);

    [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
    void PollEvents();

    [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
    void PostEmptyEvent();

    [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
    int RawMouseMotionSupported();

    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    void RequestWindowAttention(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    void RestoreWindow(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    delegate* unmanaged<Window*, uint, void> SetCharCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    void SetClipboardString(
        Mut<Window> window,
        [NativeTypeName("const char *")] Ptr<sbyte> @string
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    void SetCursor(Mut<Window> window, Mut<Cursor> cursor);

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    void SetCursorPos(Mut<Window> window, double xpos, double ypos);

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
    delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    void SetGamma(Mut<Monitor> monitor, float gamma);

    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    void SetGammaRamp(
        Mut<Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] Ptr<Gammaramp> ramp
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    void SetInputMode(Mut<Window> window, int mode, int value);

    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
    delegate* unmanaged<int, int, void> SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    void SetJoystickUserPointer(int jid, Mut pointer);

    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
    delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    void SetMonitorUserPointer(Mut<Monitor> monitor, Mut pointer);

    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
    void SetTime(double time);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    void SetWindowAspectRatio(Mut<Window> window, int numer, int denom);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    void SetWindowAttrib(Mut<Window> window, int attrib, int value);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    delegate* unmanaged<Window*, void> SetWindowCloseCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    void SetWindowIcon(
        Mut<Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] Ptr<Image> images
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    void SetWindowMonitor(
        Mut<Window> window,
        Mut<Monitor> monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    void SetWindowOpacity(Mut<Window> window, float opacity);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    void SetWindowPos(Mut<Window> window, int xpos, int ypos);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    void SetWindowShouldClose(Mut<Window> window, int value);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    void SetWindowSize(Mut<Window> window, int width, int height);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    void SetWindowSizeLimits(
        Mut<Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    void SetWindowTitle(Mut<Window> window, [NativeTypeName("const char *")] Ptr<sbyte> title);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    void SetWindowUserPointer(Mut<Window> window, Mut pointer);

    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    void ShowWindow(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    void SwapBuffers(Mut<Window> window);

    [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
    void SwapInterval(int interval);

    [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
    void Terminate();

    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    int UpdateGamepadMappings([NativeTypeName("const char *")] Ptr<sbyte> @string);

    [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
    int VulkanSupported();

    [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
    void WaitEvents();

    [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
    void WaitEventsTimeout(double timeout);

    [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
    void WindowHint(int hint, int value);

    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    void WindowHintString(int hint, [NativeTypeName("const char *")] Ptr<sbyte> value);

    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    int WindowShouldClose(Mut<Window> window);
}
