// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.GLFW;

[NativeMemberContainer(typeof(IGlfw))]
public unsafe partial interface IGlfw
{
    [NativeMemberContainer(typeof(IGlfw.Static<>), Static = true)]
    public partial interface Static<TSelf>
        where TSelf : Static<TSelf>
    {
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        static abstract Cursor* CreateCursor(
            [NativeTypeName("const GLFWimage *")] Image* image,
            int xhot,
            int yhot
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        static virtual Ptr<Cursor> CreateCursor(
            [NativeTypeName("const GLFWimage *")] Ref<Image> image,
            int xhot,
            int yhot
        )
        {
            fixed (Image* __dsl_image = image)
            {
                return (Cursor*)TSelf.CreateCursor(__dsl_image, xhot, yhot);
            }
        }

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        static virtual Ptr<Cursor> CreateStandardCursor(int shape) =>
            (Cursor*)TSelf.CreateStandardCursorRaw(shape);

        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        static abstract Cursor* CreateStandardCursorRaw(int shape);

        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        static abstract Window* CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] sbyte* title,
            Monitor* monitor,
            Window* share
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        static virtual Ptr<Window> CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] Ref<sbyte> title,
            Ref<Monitor> monitor,
            Ref<Window> share
        )
        {
            fixed (Window* __dsl_share = share)
            fixed (Monitor* __dsl_monitor = monitor)
            fixed (sbyte* __dsl_title = title)
            {
                return (Window*)
                    TSelf.CreateWindow(width, height, __dsl_title, __dsl_monitor, __dsl_share);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
        static abstract void DefaultWindowHints();

        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        static abstract void DestroyCursor(Cursor* cursor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        static virtual void DestroyCursor(Ref<Cursor> cursor)
        {
            fixed (Cursor* __dsl_cursor = cursor)
            {
                TSelf.DestroyCursor(__dsl_cursor);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        static abstract void DestroyWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        static virtual void DestroyWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.DestroyWindow(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        static abstract int ExtensionSupported([NativeTypeName("const char *")] sbyte* extension);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        static virtual int ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension)
        {
            fixed (sbyte* __dsl_extension = extension)
            {
                return (int)TSelf.ExtensionSupported(__dsl_extension);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        static abstract void FocusWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        static virtual void FocusWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.FocusWindow(__dsl_window);
            }
        }

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        static abstract sbyte* GetClipboardString(Window* window);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        static virtual Ptr<sbyte> GetClipboardString(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (sbyte*)TSelf.GetClipboardString(__dsl_window);
            }
        }

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        static virtual Ptr<Window> GetCurrentContext() => (Window*)TSelf.GetCurrentContextRaw();

        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        static abstract Window* GetCurrentContextRaw();

        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        static abstract void GetCursorPos(Window* window, double* xpos, double* ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        static virtual void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos)
        {
            fixed (double* __dsl_ypos = ypos)
            fixed (double* __dsl_xpos = xpos)
            fixed (Window* __dsl_window = window)
            {
                TSelf.GetCursorPos(__dsl_window, __dsl_xpos, __dsl_ypos);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        static abstract int GetError([NativeTypeName("const char **")] sbyte** description);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        static virtual int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description)
        {
            fixed (sbyte** __dsl_description = description)
            {
                return (int)TSelf.GetError(__dsl_description);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        static abstract void GetFramebufferSize(Window* window, int* width, int* height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        static virtual void GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height)
        {
            fixed (int* __dsl_height = height)
            fixed (int* __dsl_width = width)
            fixed (Window* __dsl_window = window)
            {
                TSelf.GetFramebufferSize(__dsl_window, __dsl_width, __dsl_height);
            }
        }

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        static virtual Ptr<sbyte> GetGamepadName(int jid) => (sbyte*)TSelf.GetGamepadNameRaw(jid);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        static abstract sbyte* GetGamepadNameRaw(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        static abstract int GetGamepadState(int jid, Gamepadstate* state);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        static virtual int GetGamepadState(int jid, Ref<Gamepadstate> state)
        {
            fixed (Gamepadstate* __dsl_state = state)
            {
                return (int)TSelf.GetGamepadState(jid, __dsl_state);
            }
        }

        [return: NativeTypeName("const GLFWgammaramp *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        static abstract Gammaramp* GetGammaRamp(Monitor* monitor);

        [return: NativeTypeName("const GLFWgammaramp *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        static virtual Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (Gammaramp*)TSelf.GetGammaRamp(__dsl_monitor);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        static abstract int GetInputMode(Window* window, int mode);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        static virtual int GetInputMode(Ref<Window> window, int mode)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)TSelf.GetInputMode(__dsl_window, mode);
            }
        }

        [return: NativeTypeName("const float *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        static abstract float* GetJoystickAxes(int jid, int* count);

        [return: NativeTypeName("const float *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        static virtual Ptr<float> GetJoystickAxes(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (float*)TSelf.GetJoystickAxes(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const unsigned char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        static abstract byte* GetJoystickButtons(int jid, int* count);

        [return: NativeTypeName("const unsigned char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        static virtual Ptr<byte> GetJoystickButtons(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (byte*)TSelf.GetJoystickButtons(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        static virtual Ptr<sbyte> GetJoystickGuid(int jid) => (sbyte*)TSelf.GetJoystickGuidRaw(jid);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        static abstract sbyte* GetJoystickGuidRaw(int jid);

        [return: NativeTypeName("const unsigned char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        static abstract byte* GetJoystickHats(int jid, int* count);

        [return: NativeTypeName("const unsigned char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        static virtual Ptr<byte> GetJoystickHats(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (byte*)TSelf.GetJoystickHats(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        static virtual Ptr<sbyte> GetJoystickName(int jid) => (sbyte*)TSelf.GetJoystickNameRaw(jid);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        static abstract sbyte* GetJoystickNameRaw(int jid);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        static virtual Ptr GetJoystickUserPointer(int jid) =>
            (void*)TSelf.GetJoystickUserPointerRaw(jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        static abstract void* GetJoystickUserPointerRaw(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        static abstract int GetKey(Window* window, int key);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        static virtual int GetKey(Ref<Window> window, int key)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)TSelf.GetKey(__dsl_window, key);
            }
        }

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        static virtual Ptr<sbyte> GetKeyName(int key, int scancode) =>
            (sbyte*)TSelf.GetKeyNameRaw(key, scancode);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        static abstract sbyte* GetKeyNameRaw(int key, int scancode);

        [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
        static abstract int GetKeyScancode(int key);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        static abstract void GetMonitorContentScale(Monitor* monitor, float* xscale, float* yscale);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        static virtual void GetMonitorContentScale(
            Ref<Monitor> monitor,
            Ref<float> xscale,
            Ref<float> yscale
        )
        {
            fixed (float* __dsl_yscale = yscale)
            fixed (float* __dsl_xscale = xscale)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                TSelf.GetMonitorContentScale(__dsl_monitor, __dsl_xscale, __dsl_yscale);
            }
        }

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        static abstract sbyte* GetMonitorName(Monitor* monitor);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        static virtual Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (sbyte*)TSelf.GetMonitorName(__dsl_monitor);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        static abstract void GetMonitorPhysicalSize(Monitor* monitor, int* widthMM, int* heightMM);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        static virtual void GetMonitorPhysicalSize(
            Ref<Monitor> monitor,
            Ref<int> widthMM,
            Ref<int> heightMM
        )
        {
            fixed (int* __dsl_heightMM = heightMM)
            fixed (int* __dsl_widthMM = widthMM)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                TSelf.GetMonitorPhysicalSize(__dsl_monitor, __dsl_widthMM, __dsl_heightMM);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        static abstract void GetMonitorPos(Monitor* monitor, int* xpos, int* ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        static virtual void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos)
        {
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                TSelf.GetMonitorPos(__dsl_monitor, __dsl_xpos, __dsl_ypos);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        static abstract Monitor** GetMonitors(int* count);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        static virtual Ptr2D<Monitor> GetMonitors(Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (Monitor**)TSelf.GetMonitors(__dsl_count);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        static abstract void* GetMonitorUserPointer(Monitor* monitor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        static virtual Ptr GetMonitorUserPointer(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (void*)TSelf.GetMonitorUserPointer(__dsl_monitor);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        static abstract void GetMonitorWorkarea(
            Monitor* monitor,
            int* xpos,
            int* ypos,
            int* width,
            int* height
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        static virtual void GetMonitorWorkarea(
            Ref<Monitor> monitor,
            Ref<int> xpos,
            Ref<int> ypos,
            Ref<int> width,
            Ref<int> height
        )
        {
            fixed (int* __dsl_height = height)
            fixed (int* __dsl_width = width)
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                TSelf.GetMonitorWorkarea(
                    __dsl_monitor,
                    __dsl_xpos,
                    __dsl_ypos,
                    __dsl_width,
                    __dsl_height
                );
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        static abstract int GetMouseButton(Window* window, int button);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        static virtual int GetMouseButton(Ref<Window> window, int button)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)TSelf.GetMouseButton(__dsl_window, button);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
        static abstract int GetPlatform();

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        static virtual Ptr<Monitor> GetPrimaryMonitor() => (Monitor*)TSelf.GetPrimaryMonitorRaw();

        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        static abstract Monitor* GetPrimaryMonitorRaw();

        [return: NativeTypeName("GLFWglproc")]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        static abstract delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] sbyte* procname
        );

        [return: NativeTypeName("GLFWglproc")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        static virtual delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> procname
        )
        {
            fixed (sbyte* __dsl_procname = procname)
            {
                return (delegate* unmanaged<void>)TSelf.GetProcAddress(__dsl_procname);
            }
        }

        [return: NativeTypeName("const char **")]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        static abstract sbyte** GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] uint* count
        );

        [return: NativeTypeName("const char **")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        static virtual Ptr2D<sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Ref<uint> count
        )
        {
            fixed (uint* __dsl_count = count)
            {
                return (sbyte**)TSelf.GetRequiredInstanceExtensions(__dsl_count);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
        static abstract double GetTime();

        [return: NativeTypeName("uint64_t")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
        static abstract ulong GetTimerFrequency();

        [return: NativeTypeName("uint64_t")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
        static abstract ulong GetTimerValue();

        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        static abstract void GetVersion(int* major, int* minor, int* rev);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        static virtual void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev)
        {
            fixed (int* __dsl_rev = rev)
            fixed (int* __dsl_minor = minor)
            fixed (int* __dsl_major = major)
            {
                TSelf.GetVersion(__dsl_major, __dsl_minor, __dsl_rev);
            }
        }

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        static virtual Ptr<sbyte> GetVersionString() => (sbyte*)TSelf.GetVersionStringRaw();

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        static abstract sbyte* GetVersionStringRaw();

        [return: NativeTypeName("const GLFWvidmode *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        static abstract Vidmode* GetVideoMode(Monitor* monitor);

        [return: NativeTypeName("const GLFWvidmode *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        static virtual Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (Vidmode*)TSelf.GetVideoMode(__dsl_monitor);
            }
        }

        [return: NativeTypeName("const GLFWvidmode *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        static abstract Vidmode* GetVideoModes(Monitor* monitor, int* count);

        [return: NativeTypeName("const GLFWvidmode *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        static virtual Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (Vidmode*)TSelf.GetVideoModes(__dsl_monitor, __dsl_count);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        static abstract int GetWindowAttrib(Window* window, int attrib);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        static virtual int GetWindowAttrib(Ref<Window> window, int attrib)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)TSelf.GetWindowAttrib(__dsl_window, attrib);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        static abstract void GetWindowContentScale(Window* window, float* xscale, float* yscale);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        static virtual void GetWindowContentScale(
            Ref<Window> window,
            Ref<float> xscale,
            Ref<float> yscale
        )
        {
            fixed (float* __dsl_yscale = yscale)
            fixed (float* __dsl_xscale = xscale)
            fixed (Window* __dsl_window = window)
            {
                TSelf.GetWindowContentScale(__dsl_window, __dsl_xscale, __dsl_yscale);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        static abstract void GetWindowFrameSize(
            Window* window,
            int* left,
            int* top,
            int* right,
            int* bottom
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        static virtual void GetWindowFrameSize(
            Ref<Window> window,
            Ref<int> left,
            Ref<int> top,
            Ref<int> right,
            Ref<int> bottom
        )
        {
            fixed (int* __dsl_bottom = bottom)
            fixed (int* __dsl_right = right)
            fixed (int* __dsl_top = top)
            fixed (int* __dsl_left = left)
            fixed (Window* __dsl_window = window)
            {
                TSelf.GetWindowFrameSize(
                    __dsl_window,
                    __dsl_left,
                    __dsl_top,
                    __dsl_right,
                    __dsl_bottom
                );
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        static abstract Monitor* GetWindowMonitor(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        static virtual Ptr<Monitor> GetWindowMonitor(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (Monitor*)TSelf.GetWindowMonitor(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        static abstract float GetWindowOpacity(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        static virtual float GetWindowOpacity(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (float)TSelf.GetWindowOpacity(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        static abstract void GetWindowPos(Window* window, int* xpos, int* ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        static virtual void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos)
        {
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Window* __dsl_window = window)
            {
                TSelf.GetWindowPos(__dsl_window, __dsl_xpos, __dsl_ypos);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        static abstract void GetWindowSize(Window* window, int* width, int* height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        static virtual void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height)
        {
            fixed (int* __dsl_height = height)
            fixed (int* __dsl_width = width)
            fixed (Window* __dsl_window = window)
            {
                TSelf.GetWindowSize(__dsl_window, __dsl_width, __dsl_height);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        static abstract void* GetWindowUserPointer(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        static virtual Ptr GetWindowUserPointer(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (void*)TSelf.GetWindowUserPointer(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        static abstract void HideWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        static virtual void HideWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.HideWindow(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        static abstract void IconifyWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        static virtual void IconifyWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.IconifyWindow(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwInit")]
        static abstract int Init();

        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        static abstract void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Allocator* allocator
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        static virtual void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator
        )
        {
            fixed (Allocator* __dsl_allocator = allocator)
            {
                TSelf.InitAllocator(__dsl_allocator);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
        static abstract void InitHint(int hint, int value);

        [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
        static abstract int JoystickIsGamepad(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
        static abstract int JoystickPresent(int jid);

        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        static abstract void MakeContextCurrent(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        static virtual void MakeContextCurrent(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.MakeContextCurrent(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        static abstract void MaximizeWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        static virtual void MaximizeWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.MaximizeWindow(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
        static abstract int PlatformSupported(int platform);

        [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
        static abstract void PollEvents();

        [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
        static abstract void PostEmptyEvent();

        [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
        static abstract int RawMouseMotionSupported();

        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        static abstract void RequestWindowAttention(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        static virtual void RequestWindowAttention(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.RequestWindowAttention(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        static abstract void RestoreWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        static virtual void RestoreWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.RestoreWindow(__dsl_window);
            }
        }

        [return: NativeTypeName("GLFWcharfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        static abstract delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Window* window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        );

        [return: NativeTypeName("GLFWcharfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        static virtual delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, uint, void>)
                    TSelf.SetCharCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWcharmodsfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        static abstract delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Window* window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        );

        [return: NativeTypeName("GLFWcharmodsfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        static virtual delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, uint, int, void>)
                    TSelf.SetCharModsCallback(__dsl_window, callback);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        static abstract void SetClipboardString(
            Window* window,
            [NativeTypeName("const char *")] sbyte* @string
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        static virtual void SetClipboardString(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> @string
        )
        {
            fixed (sbyte* __dsl_string = @string)
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetClipboardString(__dsl_window, __dsl_string);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        static abstract void SetCursor(Window* window, Cursor* cursor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        static virtual void SetCursor(Ref<Window> window, Ref<Cursor> cursor)
        {
            fixed (Cursor* __dsl_cursor = cursor)
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetCursor(__dsl_window, __dsl_cursor);
            }
        }

        [return: NativeTypeName("GLFWcursorenterfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Window* window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [return: NativeTypeName("GLFWcursorenterfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        static virtual delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, int, void>)
                    TSelf.SetCursorEnterCallback(__dsl_window, callback);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        static abstract void SetCursorPos(Window* window, double xpos, double ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        static virtual void SetCursorPos(Ref<Window> window, double xpos, double ypos)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetCursorPos(__dsl_window, xpos, ypos);
            }
        }

        [return: NativeTypeName("GLFWcursorposfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        static abstract delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Window* window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [return: NativeTypeName("GLFWcursorposfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        static virtual delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, double, double, void>)
                    TSelf.SetCursorPosCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWdropfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        static abstract delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Window* window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        );

        [return: NativeTypeName("GLFWdropfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        static virtual delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, int, sbyte**, void>)
                    TSelf.SetDropCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWerrorfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
        static abstract delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        );

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Window* window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        static virtual delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, int, int, void>)
                    TSelf.SetFramebufferSizeCallback(__dsl_window, callback);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        static abstract void SetGamma(Monitor* monitor, float gamma);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        static virtual void SetGamma(Ref<Monitor> monitor, float gamma)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                TSelf.SetGamma(__dsl_monitor, gamma);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        static abstract void SetGammaRamp(
            Monitor* monitor,
            [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        static virtual void SetGammaRamp(
            Ref<Monitor> monitor,
            [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
        )
        {
            fixed (Gammaramp* __dsl_ramp = ramp)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                TSelf.SetGammaRamp(__dsl_monitor, __dsl_ramp);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        static abstract void SetInputMode(Window* window, int mode, int value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        static virtual void SetInputMode(Ref<Window> window, int mode, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetInputMode(__dsl_window, mode, value);
            }
        }

        [return: NativeTypeName("GLFWjoystickfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
        static abstract delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        static abstract void SetJoystickUserPointer(int jid, void* pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        static virtual void SetJoystickUserPointer(int jid, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            {
                TSelf.SetJoystickUserPointer(jid, __dsl_pointer);
            }
        }

        [return: NativeTypeName("GLFWkeyfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        static abstract delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Window* window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        );

        [return: NativeTypeName("GLFWkeyfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        static virtual delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, int, int, int, int, void>)
                    TSelf.SetKeyCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWmonitorfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
        static abstract delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        );

        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        static abstract void SetMonitorUserPointer(Monitor* monitor, void* pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        static virtual void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                TSelf.SetMonitorUserPointer(__dsl_monitor, __dsl_pointer);
            }
        }

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        static abstract delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Window* window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        );

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        static virtual delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, int, int, int, void>)
                    TSelf.SetMouseButtonCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWscrollfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        static abstract delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Window* window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [return: NativeTypeName("GLFWscrollfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        static virtual delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, double, double, void>)
                    TSelf.SetScrollCallback(__dsl_window, callback);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
        static abstract void SetTime(double time);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        static abstract void SetWindowAspectRatio(Window* window, int numer, int denom);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        static virtual void SetWindowAspectRatio(Ref<Window> window, int numer, int denom)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetWindowAspectRatio(__dsl_window, numer, denom);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        static abstract void SetWindowAttrib(Window* window, int attrib, int value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        static virtual void SetWindowAttrib(Ref<Window> window, int attrib, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetWindowAttrib(__dsl_window, attrib, value);
            }
        }

        [return: NativeTypeName("GLFWwindowclosefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        static abstract delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Window* window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        );

        [return: NativeTypeName("GLFWwindowclosefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        static virtual delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, void>)
                    TSelf.SetWindowCloseCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        static abstract delegate* unmanaged<
            Window*,
            float,
            float,
            void> SetWindowContentScaleCallback(
            Window* window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        );

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        static virtual delegate* unmanaged<
            Window*,
            float,
            float,
            void> SetWindowContentScaleCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, float, float, void>)
                    TSelf.SetWindowContentScaleCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Window* window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        static virtual delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, int, void>)
                    TSelf.SetWindowFocusCallback(__dsl_window, callback);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        static abstract void SetWindowIcon(
            Window* window,
            int count,
            [NativeTypeName("const GLFWimage *")] Image* images
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        static virtual void SetWindowIcon(
            Ref<Window> window,
            int count,
            [NativeTypeName("const GLFWimage *")] Ref<Image> images
        )
        {
            fixed (Image* __dsl_images = images)
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetWindowIcon(__dsl_window, count, __dsl_images);
            }
        }

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Window* window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        static virtual delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, int, void>)
                    TSelf.SetWindowIconifyCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        static abstract delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        static virtual delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, int, void>)
                    TSelf.SetWindowMaximizeCallback(__dsl_window, callback);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        static abstract void SetWindowMonitor(
            Window* window,
            Monitor* monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        static virtual void SetWindowMonitor(
            Ref<Window> window,
            Ref<Monitor> monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        )
        {
            fixed (Monitor* __dsl_monitor = monitor)
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetWindowMonitor(
                    __dsl_window,
                    __dsl_monitor,
                    xpos,
                    ypos,
                    width,
                    height,
                    refreshRate
                );
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        static abstract void SetWindowOpacity(Window* window, float opacity);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        static virtual void SetWindowOpacity(Ref<Window> window, float opacity)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetWindowOpacity(__dsl_window, opacity);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        static abstract void SetWindowPos(Window* window, int xpos, int ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        static virtual void SetWindowPos(Ref<Window> window, int xpos, int ypos)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetWindowPos(__dsl_window, xpos, ypos);
            }
        }

        [return: NativeTypeName("GLFWwindowposfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Window* window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowposfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        static virtual delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, int, int, void>)
                    TSelf.SetWindowPosCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        static abstract delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Window* window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        );

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        static virtual delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, void>)
                    TSelf.SetWindowRefreshCallback(__dsl_window, callback);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        static abstract void SetWindowShouldClose(Window* window, int value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        static virtual void SetWindowShouldClose(Ref<Window> window, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetWindowShouldClose(__dsl_window, value);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        static abstract void SetWindowSize(Window* window, int width, int height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        static virtual void SetWindowSize(Ref<Window> window, int width, int height)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetWindowSize(__dsl_window, width, height);
            }
        }

        [return: NativeTypeName("GLFWwindowsizefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        static abstract delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowsizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        static virtual delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                return (delegate* unmanaged<Window*, int, int, void>)
                    TSelf.SetWindowSizeCallback(__dsl_window, callback);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        static abstract void SetWindowSizeLimits(
            Window* window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        static virtual void SetWindowSizeLimits(
            Ref<Window> window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        )
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetWindowSizeLimits(__dsl_window, minwidth, minheight, maxwidth, maxheight);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        static abstract void SetWindowTitle(
            Window* window,
            [NativeTypeName("const char *")] sbyte* title
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        static virtual void SetWindowTitle(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> title
        )
        {
            fixed (sbyte* __dsl_title = title)
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetWindowTitle(__dsl_window, __dsl_title);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        static abstract void SetWindowUserPointer(Window* window, void* pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        static virtual void SetWindowUserPointer(Ref<Window> window, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            fixed (Window* __dsl_window = window)
            {
                TSelf.SetWindowUserPointer(__dsl_window, __dsl_pointer);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        static abstract void ShowWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        static virtual void ShowWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.ShowWindow(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        static abstract void SwapBuffers(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        static virtual void SwapBuffers(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                TSelf.SwapBuffers(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
        static abstract void SwapInterval(int interval);

        [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
        static abstract void Terminate();

        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        static abstract int UpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        static virtual int UpdateGamepadMappings(
            [NativeTypeName("const char *")] Ref<sbyte> @string
        )
        {
            fixed (sbyte* __dsl_string = @string)
            {
                return (int)TSelf.UpdateGamepadMappings(__dsl_string);
            }
        }

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
            [NativeTypeName("const char *")] sbyte* value
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        static virtual void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] Ref<sbyte> value
        )
        {
            fixed (sbyte* __dsl_value = value)
            {
                TSelf.WindowHintString(hint, __dsl_value);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        static abstract int WindowShouldClose(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        static virtual int WindowShouldClose(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)TSelf.WindowShouldClose(__dsl_window);
            }
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    Cursor* CreateCursor([NativeTypeName("const GLFWimage *")] Image* image, int xhot, int yhot);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    Ptr<Cursor> CreateCursor(
        [NativeTypeName("const GLFWimage *")] Ref<Image> image,
        int xhot,
        int yhot
    )
    {
        fixed (Image* __dsl_image = image)
        {
            return (Cursor*)CreateCursor(__dsl_image, xhot, yhot);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    Ptr<Cursor> CreateStandardCursor(int shape) => (Cursor*)CreateStandardCursorRaw(shape);

    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    Cursor* CreateStandardCursorRaw(int shape);

    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    Window* CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] sbyte* title,
        Monitor* monitor,
        Window* share
    );

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    Ptr<Window> CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] Ref<sbyte> title,
        Ref<Monitor> monitor,
        Ref<Window> share
    )
    {
        fixed (Window* __dsl_share = share)
        fixed (Monitor* __dsl_monitor = monitor)
        fixed (sbyte* __dsl_title = title)
        {
            return (Window*)CreateWindow(width, height, __dsl_title, __dsl_monitor, __dsl_share);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
    void DefaultWindowHints();

    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    void DestroyCursor(Cursor* cursor);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    void DestroyCursor(Ref<Cursor> cursor)
    {
        fixed (Cursor* __dsl_cursor = cursor)
        {
            DestroyCursor(__dsl_cursor);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    void DestroyWindow(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    void DestroyWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            DestroyWindow(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    int ExtensionSupported([NativeTypeName("const char *")] sbyte* extension);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    int ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension)
    {
        fixed (sbyte* __dsl_extension = extension)
        {
            return (int)ExtensionSupported(__dsl_extension);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    void FocusWindow(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    void FocusWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            FocusWindow(__dsl_window);
        }
    }

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    sbyte* GetClipboardString(Window* window);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    Ptr<sbyte> GetClipboardString(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            return (sbyte*)GetClipboardString(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    Ptr<Window> GetCurrentContext() => (Window*)GetCurrentContextRaw();

    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    Window* GetCurrentContextRaw();

    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    void GetCursorPos(Window* window, double* xpos, double* ypos);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos)
    {
        fixed (double* __dsl_ypos = ypos)
        fixed (double* __dsl_xpos = xpos)
        fixed (Window* __dsl_window = window)
        {
            GetCursorPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    int GetError([NativeTypeName("const char **")] sbyte** description);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description)
    {
        fixed (sbyte** __dsl_description = description)
        {
            return (int)GetError(__dsl_description);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    void GetFramebufferSize(Window* window, int* width, int* height);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    void GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (Window* __dsl_window = window)
        {
            GetFramebufferSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    Ptr<sbyte> GetGamepadName(int jid) => (sbyte*)GetGamepadNameRaw(jid);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    sbyte* GetGamepadNameRaw(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    int GetGamepadState(int jid, Gamepadstate* state);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    int GetGamepadState(int jid, Ref<Gamepadstate> state)
    {
        fixed (Gamepadstate* __dsl_state = state)
        {
            return (int)GetGamepadState(jid, __dsl_state);
        }
    }

    [return: NativeTypeName("const GLFWgammaramp *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    Gammaramp* GetGammaRamp(Monitor* monitor);

    [return: NativeTypeName("const GLFWgammaramp *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            return (Gammaramp*)GetGammaRamp(__dsl_monitor);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    int GetInputMode(Window* window, int mode);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    int GetInputMode(Ref<Window> window, int mode)
    {
        fixed (Window* __dsl_window = window)
        {
            return (int)GetInputMode(__dsl_window, mode);
        }
    }

    [return: NativeTypeName("const float *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    float* GetJoystickAxes(int jid, int* count);

    [return: NativeTypeName("const float *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    Ptr<float> GetJoystickAxes(int jid, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            return (float*)GetJoystickAxes(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const unsigned char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    byte* GetJoystickButtons(int jid, int* count);

    [return: NativeTypeName("const unsigned char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    Ptr<byte> GetJoystickButtons(int jid, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            return (byte*)GetJoystickButtons(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    Ptr<sbyte> GetJoystickGuid(int jid) => (sbyte*)GetJoystickGuidRaw(jid);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    sbyte* GetJoystickGuidRaw(int jid);

    [return: NativeTypeName("const unsigned char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    byte* GetJoystickHats(int jid, int* count);

    [return: NativeTypeName("const unsigned char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    Ptr<byte> GetJoystickHats(int jid, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            return (byte*)GetJoystickHats(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    Ptr<sbyte> GetJoystickName(int jid) => (sbyte*)GetJoystickNameRaw(jid);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    sbyte* GetJoystickNameRaw(int jid);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    Ptr GetJoystickUserPointer(int jid) => (void*)GetJoystickUserPointerRaw(jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    void* GetJoystickUserPointerRaw(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    int GetKey(Window* window, int key);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    int GetKey(Ref<Window> window, int key)
    {
        fixed (Window* __dsl_window = window)
        {
            return (int)GetKey(__dsl_window, key);
        }
    }

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    Ptr<sbyte> GetKeyName(int key, int scancode) => (sbyte*)GetKeyNameRaw(key, scancode);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    sbyte* GetKeyNameRaw(int key, int scancode);

    [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
    int GetKeyScancode(int key);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    void GetMonitorContentScale(Monitor* monitor, float* xscale, float* yscale);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    void GetMonitorContentScale(Ref<Monitor> monitor, Ref<float> xscale, Ref<float> yscale)
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            GetMonitorContentScale(__dsl_monitor, __dsl_xscale, __dsl_yscale);
        }
    }

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    sbyte* GetMonitorName(Monitor* monitor);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            return (sbyte*)GetMonitorName(__dsl_monitor);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    void GetMonitorPhysicalSize(Monitor* monitor, int* widthMM, int* heightMM);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    void GetMonitorPhysicalSize(Ref<Monitor> monitor, Ref<int> widthMM, Ref<int> heightMM)
    {
        fixed (int* __dsl_heightMM = heightMM)
        fixed (int* __dsl_widthMM = widthMM)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            GetMonitorPhysicalSize(__dsl_monitor, __dsl_widthMM, __dsl_heightMM);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    void GetMonitorPos(Monitor* monitor, int* xpos, int* ypos);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            GetMonitorPos(__dsl_monitor, __dsl_xpos, __dsl_ypos);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    Monitor** GetMonitors(int* count);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    Ptr2D<Monitor> GetMonitors(Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            return (Monitor**)GetMonitors(__dsl_count);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    void* GetMonitorUserPointer(Monitor* monitor);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    Ptr GetMonitorUserPointer(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            return (void*)GetMonitorUserPointer(__dsl_monitor);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    void GetMonitorWorkarea(Monitor* monitor, int* xpos, int* ypos, int* width, int* height);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    void GetMonitorWorkarea(
        Ref<Monitor> monitor,
        Ref<int> xpos,
        Ref<int> ypos,
        Ref<int> width,
        Ref<int> height
    )
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            GetMonitorWorkarea(__dsl_monitor, __dsl_xpos, __dsl_ypos, __dsl_width, __dsl_height);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    int GetMouseButton(Window* window, int button);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    int GetMouseButton(Ref<Window> window, int button)
    {
        fixed (Window* __dsl_window = window)
        {
            return (int)GetMouseButton(__dsl_window, button);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
    int GetPlatform();

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    Ptr<Monitor> GetPrimaryMonitor() => (Monitor*)GetPrimaryMonitorRaw();

    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    Monitor* GetPrimaryMonitorRaw();

    [return: NativeTypeName("GLFWglproc")]
    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    delegate* unmanaged<void> GetProcAddress([NativeTypeName("const char *")] sbyte* procname);

    [return: NativeTypeName("GLFWglproc")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    delegate* unmanaged<void> GetProcAddress([NativeTypeName("const char *")] Ref<sbyte> procname)
    {
        fixed (sbyte* __dsl_procname = procname)
        {
            return (delegate* unmanaged<void>)GetProcAddress(__dsl_procname);
        }
    }

    [return: NativeTypeName("const char **")]
    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    sbyte** GetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] uint* count);

    [return: NativeTypeName("const char **")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    Ptr2D<sbyte> GetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] Ref<uint> count)
    {
        fixed (uint* __dsl_count = count)
        {
            return (sbyte**)GetRequiredInstanceExtensions(__dsl_count);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
    double GetTime();

    [return: NativeTypeName("uint64_t")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
    ulong GetTimerFrequency();

    [return: NativeTypeName("uint64_t")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
    ulong GetTimerValue();

    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    void GetVersion(int* major, int* minor, int* rev);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev)
    {
        fixed (int* __dsl_rev = rev)
        fixed (int* __dsl_minor = minor)
        fixed (int* __dsl_major = major)
        {
            GetVersion(__dsl_major, __dsl_minor, __dsl_rev);
        }
    }

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    Ptr<sbyte> GetVersionString() => (sbyte*)GetVersionStringRaw();

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    sbyte* GetVersionStringRaw();

    [return: NativeTypeName("const GLFWvidmode *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    Vidmode* GetVideoMode(Monitor* monitor);

    [return: NativeTypeName("const GLFWvidmode *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            return (Vidmode*)GetVideoMode(__dsl_monitor);
        }
    }

    [return: NativeTypeName("const GLFWvidmode *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    Vidmode* GetVideoModes(Monitor* monitor, int* count);

    [return: NativeTypeName("const GLFWvidmode *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            return (Vidmode*)GetVideoModes(__dsl_monitor, __dsl_count);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    int GetWindowAttrib(Window* window, int attrib);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    int GetWindowAttrib(Ref<Window> window, int attrib)
    {
        fixed (Window* __dsl_window = window)
        {
            return (int)GetWindowAttrib(__dsl_window, attrib);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    void GetWindowContentScale(Window* window, float* xscale, float* yscale);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    void GetWindowContentScale(Ref<Window> window, Ref<float> xscale, Ref<float> yscale)
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (Window* __dsl_window = window)
        {
            GetWindowContentScale(__dsl_window, __dsl_xscale, __dsl_yscale);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    void GetWindowFrameSize(Window* window, int* left, int* top, int* right, int* bottom);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    void GetWindowFrameSize(
        Ref<Window> window,
        Ref<int> left,
        Ref<int> top,
        Ref<int> right,
        Ref<int> bottom
    )
    {
        fixed (int* __dsl_bottom = bottom)
        fixed (int* __dsl_right = right)
        fixed (int* __dsl_top = top)
        fixed (int* __dsl_left = left)
        fixed (Window* __dsl_window = window)
        {
            GetWindowFrameSize(__dsl_window, __dsl_left, __dsl_top, __dsl_right, __dsl_bottom);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    Monitor* GetWindowMonitor(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    Ptr<Monitor> GetWindowMonitor(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            return (Monitor*)GetWindowMonitor(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    float GetWindowOpacity(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    float GetWindowOpacity(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            return (float)GetWindowOpacity(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    void GetWindowPos(Window* window, int* xpos, int* ypos);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Window* __dsl_window = window)
        {
            GetWindowPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    void GetWindowSize(Window* window, int* width, int* height);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (Window* __dsl_window = window)
        {
            GetWindowSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    void* GetWindowUserPointer(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    Ptr GetWindowUserPointer(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            return (void*)GetWindowUserPointer(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    void HideWindow(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    void HideWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            HideWindow(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    void IconifyWindow(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    void IconifyWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            IconifyWindow(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwInit")]
    int Init();

    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    void InitAllocator([NativeTypeName("const GLFWallocator *")] Allocator* allocator);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    void InitAllocator([NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator)
    {
        fixed (Allocator* __dsl_allocator = allocator)
        {
            InitAllocator(__dsl_allocator);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
    void InitHint(int hint, int value);

    [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
    int JoystickIsGamepad(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
    int JoystickPresent(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    void MakeContextCurrent(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    void MakeContextCurrent(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            MakeContextCurrent(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    void MaximizeWindow(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    void MaximizeWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            MaximizeWindow(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
    int PlatformSupported(int platform);

    [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
    void PollEvents();

    [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
    void PostEmptyEvent();

    [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
    int RawMouseMotionSupported();

    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    void RequestWindowAttention(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    void RequestWindowAttention(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            RequestWindowAttention(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    void RestoreWindow(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    void RestoreWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            RestoreWindow(__dsl_window);
        }
    }

    [return: NativeTypeName("GLFWcharfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    delegate* unmanaged<Window*, uint, void> SetCharCallback(
        Window* window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    );

    [return: NativeTypeName("GLFWcharfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    delegate* unmanaged<Window*, uint, void> SetCharCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, uint, void>)SetCharCallback(
                __dsl_window,
                callback
            );
        }
    }

    [return: NativeTypeName("GLFWcharmodsfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
        Window* window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    );

    [return: NativeTypeName("GLFWcharmodsfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, uint, int, void>)SetCharModsCallback(
                __dsl_window,
                callback
            );
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    void SetClipboardString(Window* window, [NativeTypeName("const char *")] sbyte* @string);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    void SetClipboardString(Ref<Window> window, [NativeTypeName("const char *")] Ref<sbyte> @string)
    {
        fixed (sbyte* __dsl_string = @string)
        fixed (Window* __dsl_window = window)
        {
            SetClipboardString(__dsl_window, __dsl_string);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    void SetCursor(Window* window, Cursor* cursor);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    void SetCursor(Ref<Window> window, Ref<Cursor> cursor)
    {
        fixed (Cursor* __dsl_cursor = cursor)
        fixed (Window* __dsl_window = window)
        {
            SetCursor(__dsl_window, __dsl_cursor);
        }
    }

    [return: NativeTypeName("GLFWcursorenterfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
        Window* window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [return: NativeTypeName("GLFWcursorenterfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, void>)SetCursorEnterCallback(
                __dsl_window,
                callback
            );
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    void SetCursorPos(Window* window, double xpos, double ypos);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    void SetCursorPos(Ref<Window> window, double xpos, double ypos)
    {
        fixed (Window* __dsl_window = window)
        {
            SetCursorPos(__dsl_window, xpos, ypos);
        }
    }

    [return: NativeTypeName("GLFWcursorposfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
        Window* window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    );

    [return: NativeTypeName("GLFWcursorposfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, double, double, void>)SetCursorPosCallback(
                __dsl_window,
                callback
            );
        }
    }

    [return: NativeTypeName("GLFWdropfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
        Window* window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    );

    [return: NativeTypeName("GLFWdropfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, sbyte**, void>)SetDropCallback(
                __dsl_window,
                callback
            );
        }
    }

    [return: NativeTypeName("GLFWerrorfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
    delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    );

    [return: NativeTypeName("GLFWframebuffersizefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
        Window* window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    );

    [return: NativeTypeName("GLFWframebuffersizefun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, int, void>)SetFramebufferSizeCallback(
                __dsl_window,
                callback
            );
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    void SetGamma(Monitor* monitor, float gamma);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    void SetGamma(Ref<Monitor> monitor, float gamma)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            SetGamma(__dsl_monitor, gamma);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    void SetGammaRamp(Monitor* monitor, [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    void SetGammaRamp(
        Ref<Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
    )
    {
        fixed (Gammaramp* __dsl_ramp = ramp)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            SetGammaRamp(__dsl_monitor, __dsl_ramp);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    void SetInputMode(Window* window, int mode, int value);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    void SetInputMode(Ref<Window> window, int mode, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            SetInputMode(__dsl_window, mode, value);
        }
    }

    [return: NativeTypeName("GLFWjoystickfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
    delegate* unmanaged<int, int, void> SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    void SetJoystickUserPointer(int jid, void* pointer);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    void SetJoystickUserPointer(int jid, Ref pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        {
            SetJoystickUserPointer(jid, __dsl_pointer);
        }
    }

    [return: NativeTypeName("GLFWkeyfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
        Window* window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    );

    [return: NativeTypeName("GLFWkeyfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, int, int, int, void>)SetKeyCallback(
                __dsl_window,
                callback
            );
        }
    }

    [return: NativeTypeName("GLFWmonitorfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
    delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    void SetMonitorUserPointer(Monitor* monitor, void* pointer);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            SetMonitorUserPointer(__dsl_monitor, __dsl_pointer);
        }
    }

    [return: NativeTypeName("GLFWmousebuttonfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
        Window* window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    );

    [return: NativeTypeName("GLFWmousebuttonfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, int, int, void>)SetMouseButtonCallback(
                __dsl_window,
                callback
            );
        }
    }

    [return: NativeTypeName("GLFWscrollfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
        Window* window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    );

    [return: NativeTypeName("GLFWscrollfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, double, double, void>)SetScrollCallback(
                __dsl_window,
                callback
            );
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
    void SetTime(double time);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    void SetWindowAspectRatio(Window* window, int numer, int denom);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    void SetWindowAspectRatio(Ref<Window> window, int numer, int denom)
    {
        fixed (Window* __dsl_window = window)
        {
            SetWindowAspectRatio(__dsl_window, numer, denom);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    void SetWindowAttrib(Window* window, int attrib, int value);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    void SetWindowAttrib(Ref<Window> window, int attrib, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            SetWindowAttrib(__dsl_window, attrib, value);
        }
    }

    [return: NativeTypeName("GLFWwindowclosefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    delegate* unmanaged<Window*, void> SetWindowCloseCallback(
        Window* window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    );

    [return: NativeTypeName("GLFWwindowclosefun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    delegate* unmanaged<Window*, void> SetWindowCloseCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, void>)SetWindowCloseCallback(
                __dsl_window,
                callback
            );
        }
    }

    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
        Window* window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    );

    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, float, float, void>)SetWindowContentScaleCallback(
                __dsl_window,
                callback
            );
        }
    }

    [return: NativeTypeName("GLFWwindowfocusfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
        Window* window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [return: NativeTypeName("GLFWwindowfocusfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, void>)SetWindowFocusCallback(
                __dsl_window,
                callback
            );
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    void SetWindowIcon(
        Window* window,
        int count,
        [NativeTypeName("const GLFWimage *")] Image* images
    );

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    void SetWindowIcon(
        Ref<Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] Ref<Image> images
    )
    {
        fixed (Image* __dsl_images = images)
        fixed (Window* __dsl_window = window)
        {
            SetWindowIcon(__dsl_window, count, __dsl_images);
        }
    }

    [return: NativeTypeName("GLFWwindowiconifyfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
        Window* window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    );

    [return: NativeTypeName("GLFWwindowiconifyfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, void>)SetWindowIconifyCallback(
                __dsl_window,
                callback
            );
        }
    }

    [return: NativeTypeName("GLFWwindowmaximizefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
        Window* window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    );

    [return: NativeTypeName("GLFWwindowmaximizefun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, void>)SetWindowMaximizeCallback(
                __dsl_window,
                callback
            );
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    void SetWindowMonitor(
        Window* window,
        Monitor* monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    );

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    void SetWindowMonitor(
        Ref<Window> window,
        Ref<Monitor> monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    )
    {
        fixed (Monitor* __dsl_monitor = monitor)
        fixed (Window* __dsl_window = window)
        {
            SetWindowMonitor(__dsl_window, __dsl_monitor, xpos, ypos, width, height, refreshRate);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    void SetWindowOpacity(Window* window, float opacity);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    void SetWindowOpacity(Ref<Window> window, float opacity)
    {
        fixed (Window* __dsl_window = window)
        {
            SetWindowOpacity(__dsl_window, opacity);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    void SetWindowPos(Window* window, int xpos, int ypos);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    void SetWindowPos(Ref<Window> window, int xpos, int ypos)
    {
        fixed (Window* __dsl_window = window)
        {
            SetWindowPos(__dsl_window, xpos, ypos);
        }
    }

    [return: NativeTypeName("GLFWwindowposfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
        Window* window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    );

    [return: NativeTypeName("GLFWwindowposfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, int, void>)SetWindowPosCallback(
                __dsl_window,
                callback
            );
        }
    }

    [return: NativeTypeName("GLFWwindowrefreshfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
        Window* window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    );

    [return: NativeTypeName("GLFWwindowrefreshfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, void>)SetWindowRefreshCallback(
                __dsl_window,
                callback
            );
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    void SetWindowShouldClose(Window* window, int value);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    void SetWindowShouldClose(Ref<Window> window, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            SetWindowShouldClose(__dsl_window, value);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    void SetWindowSize(Window* window, int width, int height);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    void SetWindowSize(Ref<Window> window, int width, int height)
    {
        fixed (Window* __dsl_window = window)
        {
            SetWindowSize(__dsl_window, width, height);
        }
    }

    [return: NativeTypeName("GLFWwindowsizefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
        Window* window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    );

    [return: NativeTypeName("GLFWwindowsizefun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, int, void>)SetWindowSizeCallback(
                __dsl_window,
                callback
            );
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    void SetWindowSizeLimits(
        Window* window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    );

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    void SetWindowSizeLimits(
        Ref<Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    )
    {
        fixed (Window* __dsl_window = window)
        {
            SetWindowSizeLimits(__dsl_window, minwidth, minheight, maxwidth, maxheight);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    void SetWindowTitle(Window* window, [NativeTypeName("const char *")] sbyte* title);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    void SetWindowTitle(Ref<Window> window, [NativeTypeName("const char *")] Ref<sbyte> title)
    {
        fixed (sbyte* __dsl_title = title)
        fixed (Window* __dsl_window = window)
        {
            SetWindowTitle(__dsl_window, __dsl_title);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    void SetWindowUserPointer(Window* window, void* pointer);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    void SetWindowUserPointer(Ref<Window> window, Ref pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (Window* __dsl_window = window)
        {
            SetWindowUserPointer(__dsl_window, __dsl_pointer);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    void ShowWindow(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    void ShowWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            ShowWindow(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    void SwapBuffers(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    void SwapBuffers(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            SwapBuffers(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
    void SwapInterval(int interval);

    [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
    void Terminate();

    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    int UpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    int UpdateGamepadMappings([NativeTypeName("const char *")] Ref<sbyte> @string)
    {
        fixed (sbyte* __dsl_string = @string)
        {
            return (int)UpdateGamepadMappings(__dsl_string);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
    int VulkanSupported();

    [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
    void WaitEvents();

    [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
    void WaitEventsTimeout(double timeout);

    [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
    void WindowHint(int hint, int value);

    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    void WindowHintString(int hint, [NativeTypeName("const char *")] sbyte* value);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    void WindowHintString(int hint, [NativeTypeName("const char *")] Ref<sbyte> value)
    {
        fixed (sbyte* __dsl_value = value)
        {
            WindowHintString(hint, __dsl_value);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    int WindowShouldClose(Window* window);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    int WindowShouldClose(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            return (int)WindowShouldClose(__dsl_window);
        }
    }
}
