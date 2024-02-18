// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.GLFW;

public unsafe partial class Glfw : IGlfw, IGlfw.Static
{
    public partial class DllImport : IGlfw.Static
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateCursor")]
        public static extern Cursor* CreateCursor(
            [NativeTypeName("const GLFWimage *")] Image* image,
            int xhot,
            int yhot
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<Cursor> CreateCursor(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<Cursor> CreateStandardCursor(int shape) =>
            (Cursor*)CreateStandardCursorRaw(shape);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateStandardCursor")]
        public static extern Cursor* CreateStandardCursorRaw(int shape);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateWindow")]
        public static extern Window* CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] sbyte* title,
            Monitor* monitor,
            Window* share
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<Window> CreateWindow(
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
                return (Window*)CreateWindow(
                    width,
                    height,
                    __dsl_title,
                    __dsl_monitor,
                    __dsl_share
                );
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDefaultWindowHints")]
        public static extern void DefaultWindowHints();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyCursor")]
        public static extern void DestroyCursor(Cursor* cursor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DestroyCursor(Ref<Cursor> cursor)
        {
            fixed (Cursor* __dsl_cursor = cursor)
            {
                DestroyCursor(__dsl_cursor);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyWindow")]
        public static extern void DestroyWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DestroyWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                DestroyWindow(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwExtensionSupported")]
        public static extern int ExtensionSupported(
            [NativeTypeName("const char *")] sbyte* extension
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension)
        {
            fixed (sbyte* __dsl_extension = extension)
            {
                return (int)ExtensionSupported(__dsl_extension);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwFocusWindow")]
        public static extern void FocusWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void FocusWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                FocusWindow(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetClipboardString")]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetClipboardString(Window* window);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetClipboardString(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (sbyte*)GetClipboardString(__dsl_window);
            }
        }

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<Window> GetCurrentContext() => (Window*)GetCurrentContextRaw();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCurrentContext")]
        public static extern Window* GetCurrentContextRaw();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCursorPos")]
        public static extern void GetCursorPos(Window* window, double* xpos, double* ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos)
        {
            fixed (double* __dsl_ypos = ypos)
            fixed (double* __dsl_xpos = xpos)
            fixed (Window* __dsl_window = window)
            {
                GetCursorPos(__dsl_window, __dsl_xpos, __dsl_ypos);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetError")]
        public static extern int GetError([NativeTypeName("const char **")] sbyte** description);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description)
        {
            fixed (sbyte** __dsl_description = description)
            {
                return (int)GetError(__dsl_description);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetFramebufferSize")]
        public static extern void GetFramebufferSize(Window* window, int* width, int* height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height)
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetGamepadName(int jid) => (sbyte*)GetGamepadNameRaw(jid);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadName")]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetGamepadNameRaw(int jid);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadState")]
        public static extern int GetGamepadState(int jid, Gamepadstate* state);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetGamepadState(int jid, Ref<Gamepadstate> state)
        {
            fixed (Gamepadstate* __dsl_state = state)
            {
                return (int)GetGamepadState(jid, __dsl_state);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGammaRamp")]
        [return: NativeTypeName("const GLFWgammaramp *")]
        public static extern Gammaramp* GetGammaRamp(Monitor* monitor);

        [return: NativeTypeName("const GLFWgammaramp *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (Gammaramp*)GetGammaRamp(__dsl_monitor);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetInputMode")]
        public static extern int GetInputMode(Window* window, int mode);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetInputMode(Ref<Window> window, int mode)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)GetInputMode(__dsl_window, mode);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickAxes")]
        [return: NativeTypeName("const float *")]
        public static extern float* GetJoystickAxes(int jid, int* count);

        [return: NativeTypeName("const float *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<float> GetJoystickAxes(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (float*)GetJoystickAxes(jid, __dsl_count);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickButtons")]
        [return: NativeTypeName("const unsigned char *")]
        public static extern byte* GetJoystickButtons(int jid, int* count);

        [return: NativeTypeName("const unsigned char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<byte> GetJoystickButtons(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (byte*)GetJoystickButtons(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetJoystickGuid(int jid) => (sbyte*)GetJoystickGuidRaw(jid);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickGUID")]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetJoystickGuidRaw(int jid);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickHats")]
        [return: NativeTypeName("const unsigned char *")]
        public static extern byte* GetJoystickHats(int jid, int* count);

        [return: NativeTypeName("const unsigned char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<byte> GetJoystickHats(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (byte*)GetJoystickHats(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetJoystickName(int jid) => (sbyte*)GetJoystickNameRaw(jid);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickName")]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetJoystickNameRaw(int jid);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetJoystickUserPointer(int jid) => (void*)GetJoystickUserPointerRaw(jid);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickUserPointer")]
        public static extern void* GetJoystickUserPointerRaw(int jid);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKey")]
        public static extern int GetKey(Window* window, int key);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetKey(Ref<Window> window, int key)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)GetKey(__dsl_window, key);
            }
        }

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetKeyName(int key, int scancode) =>
            (sbyte*)GetKeyNameRaw(key, scancode);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKeyName")]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetKeyNameRaw(int key, int scancode);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKeyScancode")]
        public static extern int GetKeyScancode(int key);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorContentScale")]
        public static extern void GetMonitorContentScale(
            Monitor* monitor,
            float* xscale,
            float* yscale
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetMonitorContentScale(
            Ref<Monitor> monitor,
            Ref<float> xscale,
            Ref<float> yscale
        )
        {
            fixed (float* __dsl_yscale = yscale)
            fixed (float* __dsl_xscale = xscale)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                GetMonitorContentScale(__dsl_monitor, __dsl_xscale, __dsl_yscale);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorName")]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetMonitorName(Monitor* monitor);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (sbyte*)GetMonitorName(__dsl_monitor);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPhysicalSize")]
        public static extern void GetMonitorPhysicalSize(
            Monitor* monitor,
            int* widthMM,
            int* heightMM
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetMonitorPhysicalSize(
            Ref<Monitor> monitor,
            Ref<int> widthMM,
            Ref<int> heightMM
        )
        {
            fixed (int* __dsl_heightMM = heightMM)
            fixed (int* __dsl_widthMM = widthMM)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                GetMonitorPhysicalSize(__dsl_monitor, __dsl_widthMM, __dsl_heightMM);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPos")]
        public static extern void GetMonitorPos(Monitor* monitor, int* xpos, int* ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos)
        {
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                GetMonitorPos(__dsl_monitor, __dsl_xpos, __dsl_ypos);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitors")]
        public static extern Monitor** GetMonitors(int* count);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr2D<Monitor> GetMonitors(Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (Monitor**)GetMonitors(__dsl_count);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorUserPointer")]
        public static extern void* GetMonitorUserPointer(Monitor* monitor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetMonitorUserPointer(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (void*)GetMonitorUserPointer(__dsl_monitor);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorWorkarea")]
        public static extern void GetMonitorWorkarea(
            Monitor* monitor,
            int* xpos,
            int* ypos,
            int* width,
            int* height
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetMonitorWorkarea(
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
                GetMonitorWorkarea(
                    __dsl_monitor,
                    __dsl_xpos,
                    __dsl_ypos,
                    __dsl_width,
                    __dsl_height
                );
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMouseButton")]
        public static extern int GetMouseButton(Window* window, int button);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetMouseButton(Ref<Window> window, int button)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)GetMouseButton(__dsl_window, button);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetPlatform")]
        public static extern int GetPlatform();

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<Monitor> GetPrimaryMonitor() => (Monitor*)GetPrimaryMonitorRaw();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetPrimaryMonitor")]
        public static extern Monitor* GetPrimaryMonitorRaw();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetProcAddress")]
        [return: NativeTypeName("GLFWglproc")]
        public static extern delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] sbyte* procname
        );

        [return: NativeTypeName("GLFWglproc")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> procname
        )
        {
            fixed (sbyte* __dsl_procname = procname)
            {
                return (delegate* unmanaged<void>)GetProcAddress(__dsl_procname);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetRequiredInstanceExtensions")]
        [return: NativeTypeName("const char **")]
        public static extern sbyte** GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] uint* count
        );

        [return: NativeTypeName("const char **")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr2D<sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Ref<uint> count
        )
        {
            fixed (uint* __dsl_count = count)
            {
                return (sbyte**)GetRequiredInstanceExtensions(__dsl_count);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetTime")]
        public static extern double GetTime();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetTimerFrequency")]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong GetTimerFrequency();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetTimerValue")]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong GetTimerValue();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersion")]
        public static extern void GetVersion(int* major, int* minor, int* rev);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev)
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetVersionString() => (sbyte*)GetVersionStringRaw();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersionString")]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetVersionStringRaw();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoMode")]
        [return: NativeTypeName("const GLFWvidmode *")]
        public static extern Vidmode* GetVideoMode(Monitor* monitor);

        [return: NativeTypeName("const GLFWvidmode *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (Vidmode*)GetVideoMode(__dsl_monitor);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoModes")]
        [return: NativeTypeName("const GLFWvidmode *")]
        public static extern Vidmode* GetVideoModes(Monitor* monitor, int* count);

        [return: NativeTypeName("const GLFWvidmode *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (Vidmode*)GetVideoModes(__dsl_monitor, __dsl_count);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowAttrib")]
        public static extern int GetWindowAttrib(Window* window, int attrib);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetWindowAttrib(Ref<Window> window, int attrib)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)GetWindowAttrib(__dsl_window, attrib);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowContentScale")]
        public static extern void GetWindowContentScale(
            Window* window,
            float* xscale,
            float* yscale
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetWindowContentScale(
            Ref<Window> window,
            Ref<float> xscale,
            Ref<float> yscale
        )
        {
            fixed (float* __dsl_yscale = yscale)
            fixed (float* __dsl_xscale = xscale)
            fixed (Window* __dsl_window = window)
            {
                GetWindowContentScale(__dsl_window, __dsl_xscale, __dsl_yscale);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowFrameSize")]
        public static extern void GetWindowFrameSize(
            Window* window,
            int* left,
            int* top,
            int* right,
            int* bottom
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetWindowFrameSize(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowMonitor")]
        public static extern Monitor* GetWindowMonitor(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<Monitor> GetWindowMonitor(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (Monitor*)GetWindowMonitor(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowOpacity")]
        public static extern float GetWindowOpacity(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static float GetWindowOpacity(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (float)GetWindowOpacity(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowPos")]
        public static extern void GetWindowPos(Window* window, int* xpos, int* ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos)
        {
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Window* __dsl_window = window)
            {
                GetWindowPos(__dsl_window, __dsl_xpos, __dsl_ypos);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowSize")]
        public static extern void GetWindowSize(Window* window, int* width, int* height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height)
        {
            fixed (int* __dsl_height = height)
            fixed (int* __dsl_width = width)
            fixed (Window* __dsl_window = window)
            {
                GetWindowSize(__dsl_window, __dsl_width, __dsl_height);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowUserPointer")]
        public static extern void* GetWindowUserPointer(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetWindowUserPointer(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (void*)GetWindowUserPointer(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwHideWindow")]
        public static extern void HideWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void HideWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                HideWindow(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwIconifyWindow")]
        public static extern void IconifyWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void IconifyWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                IconifyWindow(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInit")]
        public static extern int Init();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInitAllocator")]
        public static extern void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Allocator* allocator
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator
        )
        {
            fixed (Allocator* __dsl_allocator = allocator)
            {
                InitAllocator(__dsl_allocator);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInitHint")]
        public static extern void InitHint(int hint, int value);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwJoystickIsGamepad")]
        public static extern int JoystickIsGamepad(int jid);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwJoystickPresent")]
        public static extern int JoystickPresent(int jid);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMakeContextCurrent")]
        public static extern void MakeContextCurrent(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void MakeContextCurrent(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                MakeContextCurrent(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMaximizeWindow")]
        public static extern void MaximizeWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void MaximizeWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                MaximizeWindow(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwPlatformSupported")]
        public static extern int PlatformSupported(int platform);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwPollEvents")]
        public static extern void PollEvents();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwPostEmptyEvent")]
        public static extern void PostEmptyEvent();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRawMouseMotionSupported")]
        public static extern int RawMouseMotionSupported();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRequestWindowAttention")]
        public static extern void RequestWindowAttention(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void RequestWindowAttention(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                RequestWindowAttention(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRestoreWindow")]
        public static extern void RestoreWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void RestoreWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                RestoreWindow(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharCallback")]
        [return: NativeTypeName("GLFWcharfun")]
        public static extern delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Window* window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        );

        [return: NativeTypeName("GLFWcharfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharModsCallback")]
        [return: NativeTypeName("GLFWcharmodsfun")]
        public static extern delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Window* window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        );

        [return: NativeTypeName("GLFWcharmodsfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetClipboardString")]
        public static extern void SetClipboardString(
            Window* window,
            [NativeTypeName("const char *")] sbyte* @string
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetClipboardString(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> @string
        )
        {
            fixed (sbyte* __dsl_string = @string)
            fixed (Window* __dsl_window = window)
            {
                SetClipboardString(__dsl_window, __dsl_string);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursor")]
        public static extern void SetCursor(Window* window, Cursor* cursor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetCursor(Ref<Window> window, Ref<Cursor> cursor)
        {
            fixed (Cursor* __dsl_cursor = cursor)
            fixed (Window* __dsl_window = window)
            {
                SetCursor(__dsl_window, __dsl_cursor);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorEnterCallback")]
        [return: NativeTypeName("GLFWcursorenterfun")]
        public static extern delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Window* window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [return: NativeTypeName("GLFWcursorenterfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPos")]
        public static extern void SetCursorPos(Window* window, double xpos, double ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetCursorPos(Ref<Window> window, double xpos, double ypos)
        {
            fixed (Window* __dsl_window = window)
            {
                SetCursorPos(__dsl_window, xpos, ypos);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPosCallback")]
        [return: NativeTypeName("GLFWcursorposfun")]
        public static extern delegate* unmanaged<
            Window*,
            double,
            double,
            void> SetCursorPosCallback(
            Window* window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [return: NativeTypeName("GLFWcursorposfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetDropCallback")]
        [return: NativeTypeName("GLFWdropfun")]
        public static extern delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Window* window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        );

        [return: NativeTypeName("GLFWdropfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetErrorCallback")]
        [return: NativeTypeName("GLFWerrorfun")]
        public static extern delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        );

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetFramebufferSizeCallback")]
        [return: NativeTypeName("GLFWframebuffersizefun")]
        public static extern delegate* unmanaged<
            Window*,
            int,
            int,
            void> SetFramebufferSizeCallback(
            Window* window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGamma")]
        public static extern void SetGamma(Monitor* monitor, float gamma);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetGamma(Ref<Monitor> monitor, float gamma)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                SetGamma(__dsl_monitor, gamma);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGammaRamp")]
        public static extern void SetGammaRamp(
            Monitor* monitor,
            [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetGammaRamp(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetInputMode")]
        public static extern void SetInputMode(Window* window, int mode, int value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetInputMode(Ref<Window> window, int mode, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                SetInputMode(__dsl_window, mode, value);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetJoystickCallback")]
        [return: NativeTypeName("GLFWjoystickfun")]
        public static extern delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        );

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetJoystickUserPointer")]
        public static extern void SetJoystickUserPointer(int jid, void* pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetJoystickUserPointer(int jid, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            {
                SetJoystickUserPointer(jid, __dsl_pointer);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetKeyCallback")]
        [return: NativeTypeName("GLFWkeyfun")]
        public static extern delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Window* window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        );

        [return: NativeTypeName("GLFWkeyfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMonitorCallback")]
        [return: NativeTypeName("GLFWmonitorfun")]
        public static extern delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        );

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMonitorUserPointer")]
        public static extern void SetMonitorUserPointer(Monitor* monitor, void* pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                SetMonitorUserPointer(__dsl_monitor, __dsl_pointer);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMouseButtonCallback")]
        [return: NativeTypeName("GLFWmousebuttonfun")]
        public static extern delegate* unmanaged<
            Window*,
            int,
            int,
            int,
            void> SetMouseButtonCallback(
            Window* window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        );

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetScrollCallback")]
        [return: NativeTypeName("GLFWscrollfun")]
        public static extern delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Window* window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        );

        [return: NativeTypeName("GLFWscrollfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetTime")]
        public static extern void SetTime(double time);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAspectRatio")]
        public static extern void SetWindowAspectRatio(Window* window, int numer, int denom);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetWindowAspectRatio(Ref<Window> window, int numer, int denom)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowAspectRatio(__dsl_window, numer, denom);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAttrib")]
        public static extern void SetWindowAttrib(Window* window, int attrib, int value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetWindowAttrib(Ref<Window> window, int attrib, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowAttrib(__dsl_window, attrib, value);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowCloseCallback")]
        [return: NativeTypeName("GLFWwindowclosefun")]
        public static extern delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Window* window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        );

        [return: NativeTypeName("GLFWwindowclosefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowContentScaleCallback")]
        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        public static extern delegate* unmanaged<
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<
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
                return (delegate* unmanaged<
                    Window*,
                    float,
                    float,
                    void>)SetWindowContentScaleCallback(__dsl_window, callback);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowFocusCallback")]
        [return: NativeTypeName("GLFWwindowfocusfun")]
        public static extern delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Window* window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowIcon")]
        public static extern void SetWindowIcon(
            Window* window,
            int count,
            [NativeTypeName("const GLFWimage *")] Image* images
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetWindowIcon(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowIconifyCallback")]
        [return: NativeTypeName("GLFWwindowiconifyfun")]
        public static extern delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Window* window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowMaximizeCallback")]
        [return: NativeTypeName("GLFWwindowmaximizefun")]
        public static extern delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowMonitor")]
        public static extern void SetWindowMonitor(
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
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetWindowMonitor(
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
                SetWindowMonitor(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowOpacity")]
        public static extern void SetWindowOpacity(Window* window, float opacity);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetWindowOpacity(Ref<Window> window, float opacity)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowOpacity(__dsl_window, opacity);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPos")]
        public static extern void SetWindowPos(Window* window, int xpos, int ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetWindowPos(Ref<Window> window, int xpos, int ypos)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowPos(__dsl_window, xpos, ypos);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPosCallback")]
        [return: NativeTypeName("GLFWwindowposfun")]
        public static extern delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Window* window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowposfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowRefreshCallback")]
        [return: NativeTypeName("GLFWwindowrefreshfun")]
        public static extern delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Window* window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        );

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowShouldClose")]
        public static extern void SetWindowShouldClose(Window* window, int value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetWindowShouldClose(Ref<Window> window, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowShouldClose(__dsl_window, value);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSize")]
        public static extern void SetWindowSize(Window* window, int width, int height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetWindowSize(Ref<Window> window, int width, int height)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowSize(__dsl_window, width, height);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeCallback")]
        [return: NativeTypeName("GLFWwindowsizefun")]
        public static extern delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        );

        [return: NativeTypeName("GLFWwindowsizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeLimits")]
        public static extern void SetWindowSizeLimits(
            Window* window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetWindowSizeLimits(
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

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowTitle")]
        public static extern void SetWindowTitle(
            Window* window,
            [NativeTypeName("const char *")] sbyte* title
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetWindowTitle(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> title
        )
        {
            fixed (sbyte* __dsl_title = title)
            fixed (Window* __dsl_window = window)
            {
                SetWindowTitle(__dsl_window, __dsl_title);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowUserPointer")]
        public static extern void SetWindowUserPointer(Window* window, void* pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SetWindowUserPointer(Ref<Window> window, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            fixed (Window* __dsl_window = window)
            {
                SetWindowUserPointer(__dsl_window, __dsl_pointer);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwShowWindow")]
        public static extern void ShowWindow(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void ShowWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                ShowWindow(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSwapBuffers")]
        public static extern void SwapBuffers(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SwapBuffers(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                SwapBuffers(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSwapInterval")]
        public static extern void SwapInterval(int interval);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwTerminate")]
        public static extern void Terminate();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwUpdateGamepadMappings")]
        public static extern int UpdateGamepadMappings(
            [NativeTypeName("const char *")] sbyte* @string
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int UpdateGamepadMappings([NativeTypeName("const char *")] Ref<sbyte> @string)
        {
            fixed (sbyte* __dsl_string = @string)
            {
                return (int)UpdateGamepadMappings(__dsl_string);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwVulkanSupported")]
        public static extern int VulkanSupported();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWaitEvents")]
        public static extern void WaitEvents();

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWaitEventsTimeout")]
        public static extern void WaitEventsTimeout(double timeout);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowHint")]
        public static extern void WindowHint(int hint, int value);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowHintString")]
        public static extern void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] sbyte* value
        );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] Ref<sbyte> value
        )
        {
            fixed (sbyte* __dsl_value = value)
            {
                WindowHintString(hint, __dsl_value);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowShouldClose")]
        public static extern int WindowShouldClose(Window* window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int WindowShouldClose(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)WindowShouldClose(__dsl_window);
            }
        }
    }

    public partial class StaticWrapper<T> : IGlfw
        where T : IGlfw.Static
    {
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        public Cursor* CreateCursor(
            [NativeTypeName("const GLFWimage *")] Image* image,
            int xhot,
            int yhot
        ) => T.CreateCursor(image, xhot, yhot);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        public Ptr<Cursor> CreateCursor(
            [NativeTypeName("const GLFWimage *")] Ref<Image> image,
            int xhot,
            int yhot
        ) => T.CreateCursor(image, xhot, yhot);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        public Ptr<Cursor> CreateStandardCursor(int shape) => T.CreateStandardCursor(shape);

        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        public Cursor* CreateStandardCursorRaw(int shape) => T.CreateStandardCursorRaw(shape);

        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        public Window* CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] sbyte* title,
            Monitor* monitor,
            Window* share
        ) => T.CreateWindow(width, height, title, monitor, share);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        public Ptr<Window> CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] Ref<sbyte> title,
            Ref<Monitor> monitor,
            Ref<Window> share
        ) => T.CreateWindow(width, height, title, monitor, share);

        [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
        public void DefaultWindowHints() => T.DefaultWindowHints();

        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        public void DestroyCursor(Cursor* cursor) => T.DestroyCursor(cursor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        public void DestroyCursor(Ref<Cursor> cursor) => T.DestroyCursor(cursor);

        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        public void DestroyWindow(Window* window) => T.DestroyWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        public void DestroyWindow(Ref<Window> window) => T.DestroyWindow(window);

        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        public int ExtensionSupported([NativeTypeName("const char *")] sbyte* extension) =>
            T.ExtensionSupported(extension);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        public int ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension) =>
            T.ExtensionSupported(extension);

        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        public void FocusWindow(Window* window) => T.FocusWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        public void FocusWindow(Ref<Window> window) => T.FocusWindow(window);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        public sbyte* GetClipboardString(Window* window) => T.GetClipboardString(window);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        public Ptr<sbyte> GetClipboardString(Ref<Window> window) => T.GetClipboardString(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        public Ptr<Window> GetCurrentContext() => T.GetCurrentContext();

        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        public Window* GetCurrentContextRaw() => T.GetCurrentContextRaw();

        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        public void GetCursorPos(Window* window, double* xpos, double* ypos) =>
            T.GetCursorPos(window, xpos, ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        public void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos) =>
            T.GetCursorPos(window, xpos, ypos);

        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        public int GetError([NativeTypeName("const char **")] sbyte** description) =>
            T.GetError(description);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        public int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description) =>
            T.GetError(description);

        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        public void GetFramebufferSize(Window* window, int* width, int* height) =>
            T.GetFramebufferSize(window, width, height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        public void GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height) =>
            T.GetFramebufferSize(window, width, height);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        public Ptr<sbyte> GetGamepadName(int jid) => T.GetGamepadName(jid);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        public sbyte* GetGamepadNameRaw(int jid) => T.GetGamepadNameRaw(jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        public int GetGamepadState(int jid, Gamepadstate* state) => T.GetGamepadState(jid, state);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        public int GetGamepadState(int jid, Ref<Gamepadstate> state) =>
            T.GetGamepadState(jid, state);

        [return: NativeTypeName("const GLFWgammaramp *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        public Gammaramp* GetGammaRamp(Monitor* monitor) => T.GetGammaRamp(monitor);

        [return: NativeTypeName("const GLFWgammaramp *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        public Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor) => T.GetGammaRamp(monitor);

        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        public int GetInputMode(Window* window, int mode) => T.GetInputMode(window, mode);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        public int GetInputMode(Ref<Window> window, int mode) => T.GetInputMode(window, mode);

        [return: NativeTypeName("const float *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        public float* GetJoystickAxes(int jid, int* count) => T.GetJoystickAxes(jid, count);

        [return: NativeTypeName("const float *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        public Ptr<float> GetJoystickAxes(int jid, Ref<int> count) => T.GetJoystickAxes(jid, count);

        [return: NativeTypeName("const unsigned char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        public byte* GetJoystickButtons(int jid, int* count) => T.GetJoystickButtons(jid, count);

        [return: NativeTypeName("const unsigned char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        public Ptr<byte> GetJoystickButtons(int jid, Ref<int> count) =>
            T.GetJoystickButtons(jid, count);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        public Ptr<sbyte> GetJoystickGuid(int jid) => T.GetJoystickGuid(jid);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        public sbyte* GetJoystickGuidRaw(int jid) => T.GetJoystickGuidRaw(jid);

        [return: NativeTypeName("const unsigned char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        public byte* GetJoystickHats(int jid, int* count) => T.GetJoystickHats(jid, count);

        [return: NativeTypeName("const unsigned char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        public Ptr<byte> GetJoystickHats(int jid, Ref<int> count) => T.GetJoystickHats(jid, count);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        public Ptr<sbyte> GetJoystickName(int jid) => T.GetJoystickName(jid);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        public sbyte* GetJoystickNameRaw(int jid) => T.GetJoystickNameRaw(jid);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        public Ptr GetJoystickUserPointer(int jid) => T.GetJoystickUserPointer(jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        public void* GetJoystickUserPointerRaw(int jid) => T.GetJoystickUserPointerRaw(jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        public int GetKey(Window* window, int key) => T.GetKey(window, key);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        public int GetKey(Ref<Window> window, int key) => T.GetKey(window, key);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        public Ptr<sbyte> GetKeyName(int key, int scancode) => T.GetKeyName(key, scancode);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        public sbyte* GetKeyNameRaw(int key, int scancode) => T.GetKeyNameRaw(key, scancode);

        [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
        public int GetKeyScancode(int key) => T.GetKeyScancode(key);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        public void GetMonitorContentScale(Monitor* monitor, float* xscale, float* yscale) =>
            T.GetMonitorContentScale(monitor, xscale, yscale);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        public void GetMonitorContentScale(
            Ref<Monitor> monitor,
            Ref<float> xscale,
            Ref<float> yscale
        ) => T.GetMonitorContentScale(monitor, xscale, yscale);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        public sbyte* GetMonitorName(Monitor* monitor) => T.GetMonitorName(monitor);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        public Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor) => T.GetMonitorName(monitor);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        public void GetMonitorPhysicalSize(Monitor* monitor, int* widthMM, int* heightMM) =>
            T.GetMonitorPhysicalSize(monitor, widthMM, heightMM);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        public void GetMonitorPhysicalSize(
            Ref<Monitor> monitor,
            Ref<int> widthMM,
            Ref<int> heightMM
        ) => T.GetMonitorPhysicalSize(monitor, widthMM, heightMM);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        public void GetMonitorPos(Monitor* monitor, int* xpos, int* ypos) =>
            T.GetMonitorPos(monitor, xpos, ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        public void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos) =>
            T.GetMonitorPos(monitor, xpos, ypos);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        public Monitor** GetMonitors(int* count) => T.GetMonitors(count);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        public Ptr2D<Monitor> GetMonitors(Ref<int> count) => T.GetMonitors(count);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        public void* GetMonitorUserPointer(Monitor* monitor) => T.GetMonitorUserPointer(monitor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        public Ptr GetMonitorUserPointer(Ref<Monitor> monitor) => T.GetMonitorUserPointer(monitor);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        public void GetMonitorWorkarea(
            Monitor* monitor,
            int* xpos,
            int* ypos,
            int* width,
            int* height
        ) => T.GetMonitorWorkarea(monitor, xpos, ypos, width, height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        public void GetMonitorWorkarea(
            Ref<Monitor> monitor,
            Ref<int> xpos,
            Ref<int> ypos,
            Ref<int> width,
            Ref<int> height
        ) => T.GetMonitorWorkarea(monitor, xpos, ypos, width, height);

        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        public int GetMouseButton(Window* window, int button) => T.GetMouseButton(window, button);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        public int GetMouseButton(Ref<Window> window, int button) =>
            T.GetMouseButton(window, button);

        [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
        public int GetPlatform() => T.GetPlatform();

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        public Ptr<Monitor> GetPrimaryMonitor() => T.GetPrimaryMonitor();

        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        public Monitor* GetPrimaryMonitorRaw() => T.GetPrimaryMonitorRaw();

        [return: NativeTypeName("GLFWglproc")]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        public delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] sbyte* procname
        ) => T.GetProcAddress(procname);

        [return: NativeTypeName("GLFWglproc")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        public delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> procname
        ) => T.GetProcAddress(procname);

        [return: NativeTypeName("const char **")]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        public sbyte** GetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] uint* count) =>
            T.GetRequiredInstanceExtensions(count);

        [return: NativeTypeName("const char **")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        public Ptr2D<sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Ref<uint> count
        ) => T.GetRequiredInstanceExtensions(count);

        [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
        public double GetTime() => T.GetTime();

        [return: NativeTypeName("uint64_t")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
        public ulong GetTimerFrequency() => T.GetTimerFrequency();

        [return: NativeTypeName("uint64_t")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
        public ulong GetTimerValue() => T.GetTimerValue();

        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        public void GetVersion(int* major, int* minor, int* rev) => T.GetVersion(major, minor, rev);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        public void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev) =>
            T.GetVersion(major, minor, rev);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        public Ptr<sbyte> GetVersionString() => T.GetVersionString();

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        public sbyte* GetVersionStringRaw() => T.GetVersionStringRaw();

        [return: NativeTypeName("const GLFWvidmode *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        public Vidmode* GetVideoMode(Monitor* monitor) => T.GetVideoMode(monitor);

        [return: NativeTypeName("const GLFWvidmode *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        public Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor) => T.GetVideoMode(monitor);

        [return: NativeTypeName("const GLFWvidmode *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        public Vidmode* GetVideoModes(Monitor* monitor, int* count) =>
            T.GetVideoModes(monitor, count);

        [return: NativeTypeName("const GLFWvidmode *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        public Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count) =>
            T.GetVideoModes(monitor, count);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        public int GetWindowAttrib(Window* window, int attrib) => T.GetWindowAttrib(window, attrib);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        public int GetWindowAttrib(Ref<Window> window, int attrib) =>
            T.GetWindowAttrib(window, attrib);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        public void GetWindowContentScale(Window* window, float* xscale, float* yscale) =>
            T.GetWindowContentScale(window, xscale, yscale);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        public void GetWindowContentScale(
            Ref<Window> window,
            Ref<float> xscale,
            Ref<float> yscale
        ) => T.GetWindowContentScale(window, xscale, yscale);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        public void GetWindowFrameSize(
            Window* window,
            int* left,
            int* top,
            int* right,
            int* bottom
        ) => T.GetWindowFrameSize(window, left, top, right, bottom);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        public void GetWindowFrameSize(
            Ref<Window> window,
            Ref<int> left,
            Ref<int> top,
            Ref<int> right,
            Ref<int> bottom
        ) => T.GetWindowFrameSize(window, left, top, right, bottom);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        public Monitor* GetWindowMonitor(Window* window) => T.GetWindowMonitor(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        public Ptr<Monitor> GetWindowMonitor(Ref<Window> window) => T.GetWindowMonitor(window);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        public float GetWindowOpacity(Window* window) => T.GetWindowOpacity(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        public float GetWindowOpacity(Ref<Window> window) => T.GetWindowOpacity(window);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        public void GetWindowPos(Window* window, int* xpos, int* ypos) =>
            T.GetWindowPos(window, xpos, ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        public void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos) =>
            T.GetWindowPos(window, xpos, ypos);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        public void GetWindowSize(Window* window, int* width, int* height) =>
            T.GetWindowSize(window, width, height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        public void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height) =>
            T.GetWindowSize(window, width, height);

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        public void* GetWindowUserPointer(Window* window) => T.GetWindowUserPointer(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        public Ptr GetWindowUserPointer(Ref<Window> window) => T.GetWindowUserPointer(window);

        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        public void HideWindow(Window* window) => T.HideWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        public void HideWindow(Ref<Window> window) => T.HideWindow(window);

        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        public void IconifyWindow(Window* window) => T.IconifyWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        public void IconifyWindow(Ref<Window> window) => T.IconifyWindow(window);

        [NativeFunction("glfw", EntryPoint = "glfwInit")]
        public int Init() => T.Init();

        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        public void InitAllocator([NativeTypeName("const GLFWallocator *")] Allocator* allocator) =>
            T.InitAllocator(allocator);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        public void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator
        ) => T.InitAllocator(allocator);

        [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
        public void InitHint(int hint, int value) => T.InitHint(hint, value);

        [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
        public int JoystickIsGamepad(int jid) => T.JoystickIsGamepad(jid);

        [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
        public int JoystickPresent(int jid) => T.JoystickPresent(jid);

        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        public void MakeContextCurrent(Window* window) => T.MakeContextCurrent(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        public void MakeContextCurrent(Ref<Window> window) => T.MakeContextCurrent(window);

        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        public void MaximizeWindow(Window* window) => T.MaximizeWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        public void MaximizeWindow(Ref<Window> window) => T.MaximizeWindow(window);

        [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
        public int PlatformSupported(int platform) => T.PlatformSupported(platform);

        [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
        public void PollEvents() => T.PollEvents();

        [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
        public void PostEmptyEvent() => T.PostEmptyEvent();

        [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
        public int RawMouseMotionSupported() => T.RawMouseMotionSupported();

        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        public void RequestWindowAttention(Window* window) => T.RequestWindowAttention(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        public void RequestWindowAttention(Ref<Window> window) => T.RequestWindowAttention(window);

        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        public void RestoreWindow(Window* window) => T.RestoreWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        public void RestoreWindow(Ref<Window> window) => T.RestoreWindow(window);

        [return: NativeTypeName("GLFWcharfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        public delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Window* window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        ) => T.SetCharCallback(window, callback);

        [return: NativeTypeName("GLFWcharfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        public delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        ) => T.SetCharCallback(window, callback);

        [return: NativeTypeName("GLFWcharmodsfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        public delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Window* window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        ) => T.SetCharModsCallback(window, callback);

        [return: NativeTypeName("GLFWcharmodsfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        public delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        ) => T.SetCharModsCallback(window, callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        public void SetClipboardString(
            Window* window,
            [NativeTypeName("const char *")] sbyte* @string
        ) => T.SetClipboardString(window, @string);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        public void SetClipboardString(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> @string
        ) => T.SetClipboardString(window, @string);

        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        public void SetCursor(Window* window, Cursor* cursor) => T.SetCursor(window, cursor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        public void SetCursor(Ref<Window> window, Ref<Cursor> cursor) =>
            T.SetCursor(window, cursor);

        [return: NativeTypeName("GLFWcursorenterfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        public delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Window* window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        ) => T.SetCursorEnterCallback(window, callback);

        [return: NativeTypeName("GLFWcursorenterfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        public delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        ) => T.SetCursorEnterCallback(window, callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        public void SetCursorPos(Window* window, double xpos, double ypos) =>
            T.SetCursorPos(window, xpos, ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        public void SetCursorPos(Ref<Window> window, double xpos, double ypos) =>
            T.SetCursorPos(window, xpos, ypos);

        [return: NativeTypeName("GLFWcursorposfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        public delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Window* window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) => T.SetCursorPosCallback(window, callback);

        [return: NativeTypeName("GLFWcursorposfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        public delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) => T.SetCursorPosCallback(window, callback);

        [return: NativeTypeName("GLFWdropfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        public delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Window* window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        ) => T.SetDropCallback(window, callback);

        [return: NativeTypeName("GLFWdropfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        public delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        ) => T.SetDropCallback(window, callback);

        [return: NativeTypeName("GLFWerrorfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
        public delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        ) => T.SetErrorCallback(callback);

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        public delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Window* window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => T.SetFramebufferSizeCallback(window, callback);

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        public delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => T.SetFramebufferSizeCallback(window, callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        public void SetGamma(Monitor* monitor, float gamma) => T.SetGamma(monitor, gamma);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        public void SetGamma(Ref<Monitor> monitor, float gamma) => T.SetGamma(monitor, gamma);

        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        public void SetGammaRamp(
            Monitor* monitor,
            [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
        ) => T.SetGammaRamp(monitor, ramp);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        public void SetGammaRamp(
            Ref<Monitor> monitor,
            [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
        ) => T.SetGammaRamp(monitor, ramp);

        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        public void SetInputMode(Window* window, int mode, int value) =>
            T.SetInputMode(window, mode, value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        public void SetInputMode(Ref<Window> window, int mode, int value) =>
            T.SetInputMode(window, mode, value);

        [return: NativeTypeName("GLFWjoystickfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
        public delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        ) => T.SetJoystickCallback(callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        public void SetJoystickUserPointer(int jid, void* pointer) =>
            T.SetJoystickUserPointer(jid, pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        public void SetJoystickUserPointer(int jid, Ref pointer) =>
            T.SetJoystickUserPointer(jid, pointer);

        [return: NativeTypeName("GLFWkeyfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        public delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Window* window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        ) => T.SetKeyCallback(window, callback);

        [return: NativeTypeName("GLFWkeyfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        public delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        ) => T.SetKeyCallback(window, callback);

        [return: NativeTypeName("GLFWmonitorfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
        public delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        ) => T.SetMonitorCallback(callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        public void SetMonitorUserPointer(Monitor* monitor, void* pointer) =>
            T.SetMonitorUserPointer(monitor, pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        public void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer) =>
            T.SetMonitorUserPointer(monitor, pointer);

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        public delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Window* window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        ) => T.SetMouseButtonCallback(window, callback);

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        public delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        ) => T.SetMouseButtonCallback(window, callback);

        [return: NativeTypeName("GLFWscrollfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        public delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Window* window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) => T.SetScrollCallback(window, callback);

        [return: NativeTypeName("GLFWscrollfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        public delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) => T.SetScrollCallback(window, callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
        public void SetTime(double time) => T.SetTime(time);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        public void SetWindowAspectRatio(Window* window, int numer, int denom) =>
            T.SetWindowAspectRatio(window, numer, denom);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        public void SetWindowAspectRatio(Ref<Window> window, int numer, int denom) =>
            T.SetWindowAspectRatio(window, numer, denom);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        public void SetWindowAttrib(Window* window, int attrib, int value) =>
            T.SetWindowAttrib(window, attrib, value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        public void SetWindowAttrib(Ref<Window> window, int attrib, int value) =>
            T.SetWindowAttrib(window, attrib, value);

        [return: NativeTypeName("GLFWwindowclosefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        public delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Window* window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        ) => T.SetWindowCloseCallback(window, callback);

        [return: NativeTypeName("GLFWwindowclosefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        public delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        ) => T.SetWindowCloseCallback(window, callback);

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        public delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
            Window* window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        ) => T.SetWindowContentScaleCallback(window, callback);

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        public delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        ) => T.SetWindowContentScaleCallback(window, callback);

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        public delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Window* window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        ) => T.SetWindowFocusCallback(window, callback);

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        public delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        ) => T.SetWindowFocusCallback(window, callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        public void SetWindowIcon(
            Window* window,
            int count,
            [NativeTypeName("const GLFWimage *")] Image* images
        ) => T.SetWindowIcon(window, count, images);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        public void SetWindowIcon(
            Ref<Window> window,
            int count,
            [NativeTypeName("const GLFWimage *")] Ref<Image> images
        ) => T.SetWindowIcon(window, count, images);

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        public delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Window* window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        ) => T.SetWindowIconifyCallback(window, callback);

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        public delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        ) => T.SetWindowIconifyCallback(window, callback);

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        public delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        ) => T.SetWindowMaximizeCallback(window, callback);

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        public delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        ) => T.SetWindowMaximizeCallback(window, callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        public void SetWindowMonitor(
            Window* window,
            Monitor* monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        ) => T.SetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        public void SetWindowMonitor(
            Ref<Window> window,
            Ref<Monitor> monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        ) => T.SetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        public void SetWindowOpacity(Window* window, float opacity) =>
            T.SetWindowOpacity(window, opacity);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        public void SetWindowOpacity(Ref<Window> window, float opacity) =>
            T.SetWindowOpacity(window, opacity);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        public void SetWindowPos(Window* window, int xpos, int ypos) =>
            T.SetWindowPos(window, xpos, ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        public void SetWindowPos(Ref<Window> window, int xpos, int ypos) =>
            T.SetWindowPos(window, xpos, ypos);

        [return: NativeTypeName("GLFWwindowposfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        public delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Window* window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => T.SetWindowPosCallback(window, callback);

        [return: NativeTypeName("GLFWwindowposfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        public delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => T.SetWindowPosCallback(window, callback);

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        public delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Window* window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        ) => T.SetWindowRefreshCallback(window, callback);

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        public delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        ) => T.SetWindowRefreshCallback(window, callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        public void SetWindowShouldClose(Window* window, int value) =>
            T.SetWindowShouldClose(window, value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        public void SetWindowShouldClose(Ref<Window> window, int value) =>
            T.SetWindowShouldClose(window, value);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        public void SetWindowSize(Window* window, int width, int height) =>
            T.SetWindowSize(window, width, height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        public void SetWindowSize(Ref<Window> window, int width, int height) =>
            T.SetWindowSize(window, width, height);

        [return: NativeTypeName("GLFWwindowsizefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        public delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => T.SetWindowSizeCallback(window, callback);

        [return: NativeTypeName("GLFWwindowsizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        public delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => T.SetWindowSizeCallback(window, callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        public void SetWindowSizeLimits(
            Window* window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        ) => T.SetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        public void SetWindowSizeLimits(
            Ref<Window> window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        ) => T.SetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        public void SetWindowTitle(Window* window, [NativeTypeName("const char *")] sbyte* title) =>
            T.SetWindowTitle(window, title);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        public void SetWindowTitle(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> title
        ) => T.SetWindowTitle(window, title);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        public void SetWindowUserPointer(Window* window, void* pointer) =>
            T.SetWindowUserPointer(window, pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        public void SetWindowUserPointer(Ref<Window> window, Ref pointer) =>
            T.SetWindowUserPointer(window, pointer);

        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        public void ShowWindow(Window* window) => T.ShowWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        public void ShowWindow(Ref<Window> window) => T.ShowWindow(window);

        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        public void SwapBuffers(Window* window) => T.SwapBuffers(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        public void SwapBuffers(Ref<Window> window) => T.SwapBuffers(window);

        [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
        public void SwapInterval(int interval) => T.SwapInterval(interval);

        [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
        public void Terminate() => T.Terminate();

        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        public int UpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string) =>
            T.UpdateGamepadMappings(@string);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        public int UpdateGamepadMappings([NativeTypeName("const char *")] Ref<sbyte> @string) =>
            T.UpdateGamepadMappings(@string);

        [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
        public int VulkanSupported() => T.VulkanSupported();

        [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
        public void WaitEvents() => T.WaitEvents();

        [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
        public void WaitEventsTimeout(double timeout) => T.WaitEventsTimeout(timeout);

        [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
        public void WindowHint(int hint, int value) => T.WindowHint(hint, value);

        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        public void WindowHintString(int hint, [NativeTypeName("const char *")] sbyte* value) =>
            T.WindowHintString(hint, value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        public void WindowHintString(int hint, [NativeTypeName("const char *")] Ref<sbyte> value) =>
            T.WindowHintString(hint, value);

        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        public int WindowShouldClose(Window* window) => T.WindowShouldClose(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        public int WindowShouldClose(Ref<Window> window) => T.WindowShouldClose(window);
    }

    public partial class ThisThread
    {
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        public static Cursor* CreateCursor(
            [NativeTypeName("const GLFWimage *")] Image* image,
            int xhot,
            int yhot
        ) => Underlying.Value!.CreateCursor(image, xhot, yhot);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        public static Ptr<Cursor> CreateCursor(
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
        public static Ptr<Cursor> CreateStandardCursor(int shape) =>
            Underlying.Value!.CreateStandardCursor(shape);

        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        public static Cursor* CreateStandardCursorRaw(int shape) =>
            Underlying.Value!.CreateStandardCursorRaw(shape);

        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        public static Window* CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] sbyte* title,
            Monitor* monitor,
            Window* share
        ) => Underlying.Value!.CreateWindow(width, height, title, monitor, share);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        public static Ptr<Window> CreateWindow(
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
                return (Window*)CreateWindow(
                    width,
                    height,
                    __dsl_title,
                    __dsl_monitor,
                    __dsl_share
                );
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
        public static void DefaultWindowHints() => Underlying.Value!.DefaultWindowHints();

        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        public static void DestroyCursor(Cursor* cursor) => Underlying.Value!.DestroyCursor(cursor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        public static void DestroyCursor(Ref<Cursor> cursor)
        {
            fixed (Cursor* __dsl_cursor = cursor)
            {
                DestroyCursor(__dsl_cursor);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        public static void DestroyWindow(Window* window) => Underlying.Value!.DestroyWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        public static void DestroyWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                DestroyWindow(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        public static int ExtensionSupported([NativeTypeName("const char *")] sbyte* extension) =>
            Underlying.Value!.ExtensionSupported(extension);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        public static int ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension)
        {
            fixed (sbyte* __dsl_extension = extension)
            {
                return (int)ExtensionSupported(__dsl_extension);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        public static void FocusWindow(Window* window) => Underlying.Value!.FocusWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        public static void FocusWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                FocusWindow(__dsl_window);
            }
        }

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        public static sbyte* GetClipboardString(Window* window) =>
            Underlying.Value!.GetClipboardString(window);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        public static Ptr<sbyte> GetClipboardString(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (sbyte*)GetClipboardString(__dsl_window);
            }
        }

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        public static Ptr<Window> GetCurrentContext() => Underlying.Value!.GetCurrentContext();

        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        public static Window* GetCurrentContextRaw() => Underlying.Value!.GetCurrentContextRaw();

        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        public static void GetCursorPos(Window* window, double* xpos, double* ypos) =>
            Underlying.Value!.GetCursorPos(window, xpos, ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        public static void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos)
        {
            fixed (double* __dsl_ypos = ypos)
            fixed (double* __dsl_xpos = xpos)
            fixed (Window* __dsl_window = window)
            {
                GetCursorPos(__dsl_window, __dsl_xpos, __dsl_ypos);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        public static int GetError([NativeTypeName("const char **")] sbyte** description) =>
            Underlying.Value!.GetError(description);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        public static int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description)
        {
            fixed (sbyte** __dsl_description = description)
            {
                return (int)GetError(__dsl_description);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        public static void GetFramebufferSize(Window* window, int* width, int* height) =>
            Underlying.Value!.GetFramebufferSize(window, width, height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        public static void GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height)
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
        public static Ptr<sbyte> GetGamepadName(int jid) => Underlying.Value!.GetGamepadName(jid);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        public static sbyte* GetGamepadNameRaw(int jid) => Underlying.Value!.GetGamepadNameRaw(jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        public static int GetGamepadState(int jid, Gamepadstate* state) =>
            Underlying.Value!.GetGamepadState(jid, state);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        public static int GetGamepadState(int jid, Ref<Gamepadstate> state)
        {
            fixed (Gamepadstate* __dsl_state = state)
            {
                return (int)GetGamepadState(jid, __dsl_state);
            }
        }

        [return: NativeTypeName("const GLFWgammaramp *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        public static Gammaramp* GetGammaRamp(Monitor* monitor) =>
            Underlying.Value!.GetGammaRamp(monitor);

        [return: NativeTypeName("const GLFWgammaramp *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        public static Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (Gammaramp*)GetGammaRamp(__dsl_monitor);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        public static int GetInputMode(Window* window, int mode) =>
            Underlying.Value!.GetInputMode(window, mode);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        public static int GetInputMode(Ref<Window> window, int mode)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)GetInputMode(__dsl_window, mode);
            }
        }

        [return: NativeTypeName("const float *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        public static float* GetJoystickAxes(int jid, int* count) =>
            Underlying.Value!.GetJoystickAxes(jid, count);

        [return: NativeTypeName("const float *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        public static Ptr<float> GetJoystickAxes(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (float*)GetJoystickAxes(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const unsigned char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        public static byte* GetJoystickButtons(int jid, int* count) =>
            Underlying.Value!.GetJoystickButtons(jid, count);

        [return: NativeTypeName("const unsigned char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        public static Ptr<byte> GetJoystickButtons(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (byte*)GetJoystickButtons(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        public static Ptr<sbyte> GetJoystickGuid(int jid) => Underlying.Value!.GetJoystickGuid(jid);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        public static sbyte* GetJoystickGuidRaw(int jid) =>
            Underlying.Value!.GetJoystickGuidRaw(jid);

        [return: NativeTypeName("const unsigned char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        public static byte* GetJoystickHats(int jid, int* count) =>
            Underlying.Value!.GetJoystickHats(jid, count);

        [return: NativeTypeName("const unsigned char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        public static Ptr<byte> GetJoystickHats(int jid, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (byte*)GetJoystickHats(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        public static Ptr<sbyte> GetJoystickName(int jid) => Underlying.Value!.GetJoystickName(jid);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        public static sbyte* GetJoystickNameRaw(int jid) =>
            Underlying.Value!.GetJoystickNameRaw(jid);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        public static Ptr GetJoystickUserPointer(int jid) =>
            Underlying.Value!.GetJoystickUserPointer(jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        public static void* GetJoystickUserPointerRaw(int jid) =>
            Underlying.Value!.GetJoystickUserPointerRaw(jid);

        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        public static int GetKey(Window* window, int key) => Underlying.Value!.GetKey(window, key);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        public static int GetKey(Ref<Window> window, int key)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)GetKey(__dsl_window, key);
            }
        }

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        public static Ptr<sbyte> GetKeyName(int key, int scancode) =>
            Underlying.Value!.GetKeyName(key, scancode);

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        public static sbyte* GetKeyNameRaw(int key, int scancode) =>
            Underlying.Value!.GetKeyNameRaw(key, scancode);

        [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
        public static int GetKeyScancode(int key) => Underlying.Value!.GetKeyScancode(key);

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        public static void GetMonitorContentScale(Monitor* monitor, float* xscale, float* yscale) =>
            Underlying.Value!.GetMonitorContentScale(monitor, xscale, yscale);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        public static void GetMonitorContentScale(
            Ref<Monitor> monitor,
            Ref<float> xscale,
            Ref<float> yscale
        )
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
        public static sbyte* GetMonitorName(Monitor* monitor) =>
            Underlying.Value!.GetMonitorName(monitor);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        public static Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (sbyte*)GetMonitorName(__dsl_monitor);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        public static void GetMonitorPhysicalSize(Monitor* monitor, int* widthMM, int* heightMM) =>
            Underlying.Value!.GetMonitorPhysicalSize(monitor, widthMM, heightMM);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        public static void GetMonitorPhysicalSize(
            Ref<Monitor> monitor,
            Ref<int> widthMM,
            Ref<int> heightMM
        )
        {
            fixed (int* __dsl_heightMM = heightMM)
            fixed (int* __dsl_widthMM = widthMM)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                GetMonitorPhysicalSize(__dsl_monitor, __dsl_widthMM, __dsl_heightMM);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        public static void GetMonitorPos(Monitor* monitor, int* xpos, int* ypos) =>
            Underlying.Value!.GetMonitorPos(monitor, xpos, ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        public static void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos)
        {
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                GetMonitorPos(__dsl_monitor, __dsl_xpos, __dsl_ypos);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        public static Monitor** GetMonitors(int* count) => Underlying.Value!.GetMonitors(count);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        public static Ptr2D<Monitor> GetMonitors(Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                return (Monitor**)GetMonitors(__dsl_count);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        public static void* GetMonitorUserPointer(Monitor* monitor) =>
            Underlying.Value!.GetMonitorUserPointer(monitor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        public static Ptr GetMonitorUserPointer(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (void*)GetMonitorUserPointer(__dsl_monitor);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        public static void GetMonitorWorkarea(
            Monitor* monitor,
            int* xpos,
            int* ypos,
            int* width,
            int* height
        ) => Underlying.Value!.GetMonitorWorkarea(monitor, xpos, ypos, width, height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        public static void GetMonitorWorkarea(
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
                GetMonitorWorkarea(
                    __dsl_monitor,
                    __dsl_xpos,
                    __dsl_ypos,
                    __dsl_width,
                    __dsl_height
                );
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        public static int GetMouseButton(Window* window, int button) =>
            Underlying.Value!.GetMouseButton(window, button);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        public static int GetMouseButton(Ref<Window> window, int button)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)GetMouseButton(__dsl_window, button);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
        public static int GetPlatform() => Underlying.Value!.GetPlatform();

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        public static Ptr<Monitor> GetPrimaryMonitor() => Underlying.Value!.GetPrimaryMonitor();

        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        public static Monitor* GetPrimaryMonitorRaw() => Underlying.Value!.GetPrimaryMonitorRaw();

        [return: NativeTypeName("GLFWglproc")]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        public static delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] sbyte* procname
        ) => Underlying.Value!.GetProcAddress(procname);

        [return: NativeTypeName("GLFWglproc")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        public static delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> procname
        )
        {
            fixed (sbyte* __dsl_procname = procname)
            {
                return (delegate* unmanaged<void>)GetProcAddress(__dsl_procname);
            }
        }

        [return: NativeTypeName("const char **")]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        public static sbyte** GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] uint* count
        ) => Underlying.Value!.GetRequiredInstanceExtensions(count);

        [return: NativeTypeName("const char **")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        public static Ptr2D<sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Ref<uint> count
        )
        {
            fixed (uint* __dsl_count = count)
            {
                return (sbyte**)GetRequiredInstanceExtensions(__dsl_count);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
        public static double GetTime() => Underlying.Value!.GetTime();

        [return: NativeTypeName("uint64_t")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
        public static ulong GetTimerFrequency() => Underlying.Value!.GetTimerFrequency();

        [return: NativeTypeName("uint64_t")]
        [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
        public static ulong GetTimerValue() => Underlying.Value!.GetTimerValue();

        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        public static void GetVersion(int* major, int* minor, int* rev) =>
            Underlying.Value!.GetVersion(major, minor, rev);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        public static void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev)
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
        public static Ptr<sbyte> GetVersionString() => Underlying.Value!.GetVersionString();

        [return: NativeTypeName("const char *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        public static sbyte* GetVersionStringRaw() => Underlying.Value!.GetVersionStringRaw();

        [return: NativeTypeName("const GLFWvidmode *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        public static Vidmode* GetVideoMode(Monitor* monitor) =>
            Underlying.Value!.GetVideoMode(monitor);

        [return: NativeTypeName("const GLFWvidmode *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        public static Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (Vidmode*)GetVideoMode(__dsl_monitor);
            }
        }

        [return: NativeTypeName("const GLFWvidmode *")]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        public static Vidmode* GetVideoModes(Monitor* monitor, int* count) =>
            Underlying.Value!.GetVideoModes(monitor, count);

        [return: NativeTypeName("const GLFWvidmode *")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        public static Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count)
        {
            fixed (int* __dsl_count = count)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                return (Vidmode*)GetVideoModes(__dsl_monitor, __dsl_count);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        public static int GetWindowAttrib(Window* window, int attrib) =>
            Underlying.Value!.GetWindowAttrib(window, attrib);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        public static int GetWindowAttrib(Ref<Window> window, int attrib)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)GetWindowAttrib(__dsl_window, attrib);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        public static void GetWindowContentScale(Window* window, float* xscale, float* yscale) =>
            Underlying.Value!.GetWindowContentScale(window, xscale, yscale);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        public static void GetWindowContentScale(
            Ref<Window> window,
            Ref<float> xscale,
            Ref<float> yscale
        )
        {
            fixed (float* __dsl_yscale = yscale)
            fixed (float* __dsl_xscale = xscale)
            fixed (Window* __dsl_window = window)
            {
                GetWindowContentScale(__dsl_window, __dsl_xscale, __dsl_yscale);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        public static void GetWindowFrameSize(
            Window* window,
            int* left,
            int* top,
            int* right,
            int* bottom
        ) => Underlying.Value!.GetWindowFrameSize(window, left, top, right, bottom);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        public static void GetWindowFrameSize(
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
        public static Monitor* GetWindowMonitor(Window* window) =>
            Underlying.Value!.GetWindowMonitor(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        public static Ptr<Monitor> GetWindowMonitor(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (Monitor*)GetWindowMonitor(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        public static float GetWindowOpacity(Window* window) =>
            Underlying.Value!.GetWindowOpacity(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        public static float GetWindowOpacity(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (float)GetWindowOpacity(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        public static void GetWindowPos(Window* window, int* xpos, int* ypos) =>
            Underlying.Value!.GetWindowPos(window, xpos, ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        public static void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos)
        {
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Window* __dsl_window = window)
            {
                GetWindowPos(__dsl_window, __dsl_xpos, __dsl_ypos);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        public static void GetWindowSize(Window* window, int* width, int* height) =>
            Underlying.Value!.GetWindowSize(window, width, height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        public static void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height)
        {
            fixed (int* __dsl_height = height)
            fixed (int* __dsl_width = width)
            fixed (Window* __dsl_window = window)
            {
                GetWindowSize(__dsl_window, __dsl_width, __dsl_height);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        public static void* GetWindowUserPointer(Window* window) =>
            Underlying.Value!.GetWindowUserPointer(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        public static Ptr GetWindowUserPointer(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (void*)GetWindowUserPointer(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        public static void HideWindow(Window* window) => Underlying.Value!.HideWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        public static void HideWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                HideWindow(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        public static void IconifyWindow(Window* window) => Underlying.Value!.IconifyWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        public static void IconifyWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                IconifyWindow(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwInit")]
        public static int Init() => Underlying.Value!.Init();

        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        public static void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Allocator* allocator
        ) => Underlying.Value!.InitAllocator(allocator);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        public static void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator
        )
        {
            fixed (Allocator* __dsl_allocator = allocator)
            {
                InitAllocator(__dsl_allocator);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
        public static void InitHint(int hint, int value) => Underlying.Value!.InitHint(hint, value);

        [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
        public static int JoystickIsGamepad(int jid) => Underlying.Value!.JoystickIsGamepad(jid);

        [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
        public static int JoystickPresent(int jid) => Underlying.Value!.JoystickPresent(jid);

        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        public static void MakeContextCurrent(Window* window) =>
            Underlying.Value!.MakeContextCurrent(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        public static void MakeContextCurrent(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                MakeContextCurrent(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        public static void MaximizeWindow(Window* window) =>
            Underlying.Value!.MaximizeWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        public static void MaximizeWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                MaximizeWindow(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
        public static int PlatformSupported(int platform) =>
            Underlying.Value!.PlatformSupported(platform);

        [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
        public static void PollEvents() => Underlying.Value!.PollEvents();

        [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
        public static void PostEmptyEvent() => Underlying.Value!.PostEmptyEvent();

        [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
        public static int RawMouseMotionSupported() => Underlying.Value!.RawMouseMotionSupported();

        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        public static void RequestWindowAttention(Window* window) =>
            Underlying.Value!.RequestWindowAttention(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        public static void RequestWindowAttention(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                RequestWindowAttention(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        public static void RestoreWindow(Window* window) => Underlying.Value!.RestoreWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        public static void RestoreWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                RestoreWindow(__dsl_window);
            }
        }

        [return: NativeTypeName("GLFWcharfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Window* window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        ) => Underlying.Value!.SetCharCallback(window, callback);

        [return: NativeTypeName("GLFWcharfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
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
        public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Window* window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        ) => Underlying.Value!.SetCharModsCallback(window, callback);

        [return: NativeTypeName("GLFWcharmodsfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
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
        public static void SetClipboardString(
            Window* window,
            [NativeTypeName("const char *")] sbyte* @string
        ) => Underlying.Value!.SetClipboardString(window, @string);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        public static void SetClipboardString(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> @string
        )
        {
            fixed (sbyte* __dsl_string = @string)
            fixed (Window* __dsl_window = window)
            {
                SetClipboardString(__dsl_window, __dsl_string);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        public static void SetCursor(Window* window, Cursor* cursor) =>
            Underlying.Value!.SetCursor(window, cursor);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        public static void SetCursor(Ref<Window> window, Ref<Cursor> cursor)
        {
            fixed (Cursor* __dsl_cursor = cursor)
            fixed (Window* __dsl_window = window)
            {
                SetCursor(__dsl_window, __dsl_cursor);
            }
        }

        [return: NativeTypeName("GLFWcursorenterfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Window* window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        ) => Underlying.Value!.SetCursorEnterCallback(window, callback);

        [return: NativeTypeName("GLFWcursorenterfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
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
        public static void SetCursorPos(Window* window, double xpos, double ypos) =>
            Underlying.Value!.SetCursorPos(window, xpos, ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        public static void SetCursorPos(Ref<Window> window, double xpos, double ypos)
        {
            fixed (Window* __dsl_window = window)
            {
                SetCursorPos(__dsl_window, xpos, ypos);
            }
        }

        [return: NativeTypeName("GLFWcursorposfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Window* window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) => Underlying.Value!.SetCursorPosCallback(window, callback);

        [return: NativeTypeName("GLFWcursorposfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
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
        public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Window* window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        ) => Underlying.Value!.SetDropCallback(window, callback);

        [return: NativeTypeName("GLFWdropfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
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
        public static delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        ) => Underlying.Value!.SetErrorCallback(callback);

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Window* window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => Underlying.Value!.SetFramebufferSizeCallback(window, callback);

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
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
        public static void SetGamma(Monitor* monitor, float gamma) =>
            Underlying.Value!.SetGamma(monitor, gamma);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        public static void SetGamma(Ref<Monitor> monitor, float gamma)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                SetGamma(__dsl_monitor, gamma);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        public static void SetGammaRamp(
            Monitor* monitor,
            [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
        ) => Underlying.Value!.SetGammaRamp(monitor, ramp);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        public static void SetGammaRamp(
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
        public static void SetInputMode(Window* window, int mode, int value) =>
            Underlying.Value!.SetInputMode(window, mode, value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        public static void SetInputMode(Ref<Window> window, int mode, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                SetInputMode(__dsl_window, mode, value);
            }
        }

        [return: NativeTypeName("GLFWjoystickfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
        public static delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        ) => Underlying.Value!.SetJoystickCallback(callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        public static void SetJoystickUserPointer(int jid, void* pointer) =>
            Underlying.Value!.SetJoystickUserPointer(jid, pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        public static void SetJoystickUserPointer(int jid, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            {
                SetJoystickUserPointer(jid, __dsl_pointer);
            }
        }

        [return: NativeTypeName("GLFWkeyfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Window* window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        ) => Underlying.Value!.SetKeyCallback(window, callback);

        [return: NativeTypeName("GLFWkeyfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
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
        public static delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        ) => Underlying.Value!.SetMonitorCallback(callback);

        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        public static void SetMonitorUserPointer(Monitor* monitor, void* pointer) =>
            Underlying.Value!.SetMonitorUserPointer(monitor, pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        public static void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                SetMonitorUserPointer(__dsl_monitor, __dsl_pointer);
            }
        }

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Window* window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        ) => Underlying.Value!.SetMouseButtonCallback(window, callback);

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
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
        public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Window* window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        ) => Underlying.Value!.SetScrollCallback(window, callback);

        [return: NativeTypeName("GLFWscrollfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
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
        public static void SetTime(double time) => Underlying.Value!.SetTime(time);

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        public static void SetWindowAspectRatio(Window* window, int numer, int denom) =>
            Underlying.Value!.SetWindowAspectRatio(window, numer, denom);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        public static void SetWindowAspectRatio(Ref<Window> window, int numer, int denom)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowAspectRatio(__dsl_window, numer, denom);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        public static void SetWindowAttrib(Window* window, int attrib, int value) =>
            Underlying.Value!.SetWindowAttrib(window, attrib, value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        public static void SetWindowAttrib(Ref<Window> window, int attrib, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowAttrib(__dsl_window, attrib, value);
            }
        }

        [return: NativeTypeName("GLFWwindowclosefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Window* window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        ) => Underlying.Value!.SetWindowCloseCallback(window, callback);

        [return: NativeTypeName("GLFWwindowclosefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
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
        public static delegate* unmanaged<
            Window*,
            float,
            float,
            void> SetWindowContentScaleCallback(
            Window* window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        ) => Underlying.Value!.SetWindowContentScaleCallback(window, callback);

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        public static delegate* unmanaged<
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
                return (delegate* unmanaged<
                    Window*,
                    float,
                    float,
                    void>)SetWindowContentScaleCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Window* window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        ) => Underlying.Value!.SetWindowFocusCallback(window, callback);

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
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
        public static void SetWindowIcon(
            Window* window,
            int count,
            [NativeTypeName("const GLFWimage *")] Image* images
        ) => Underlying.Value!.SetWindowIcon(window, count, images);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        public static void SetWindowIcon(
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
        public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Window* window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        ) => Underlying.Value!.SetWindowIconifyCallback(window, callback);

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
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
        public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        ) => Underlying.Value!.SetWindowMaximizeCallback(window, callback);

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
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
        public static void SetWindowMonitor(
            Window* window,
            Monitor* monitor,
            int xpos,
            int ypos,
            int width,
            int height,
            int refreshRate
        ) =>
            Underlying.Value!.SetWindowMonitor(
                window,
                monitor,
                xpos,
                ypos,
                width,
                height,
                refreshRate
            );

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        public static void SetWindowMonitor(
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
                SetWindowMonitor(
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
        public static void SetWindowOpacity(Window* window, float opacity) =>
            Underlying.Value!.SetWindowOpacity(window, opacity);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        public static void SetWindowOpacity(Ref<Window> window, float opacity)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowOpacity(__dsl_window, opacity);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        public static void SetWindowPos(Window* window, int xpos, int ypos) =>
            Underlying.Value!.SetWindowPos(window, xpos, ypos);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        public static void SetWindowPos(Ref<Window> window, int xpos, int ypos)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowPos(__dsl_window, xpos, ypos);
            }
        }

        [return: NativeTypeName("GLFWwindowposfun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Window* window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => Underlying.Value!.SetWindowPosCallback(window, callback);

        [return: NativeTypeName("GLFWwindowposfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
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
        public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Window* window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        ) => Underlying.Value!.SetWindowRefreshCallback(window, callback);

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
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
        public static void SetWindowShouldClose(Window* window, int value) =>
            Underlying.Value!.SetWindowShouldClose(window, value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        public static void SetWindowShouldClose(Ref<Window> window, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowShouldClose(__dsl_window, value);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        public static void SetWindowSize(Window* window, int width, int height) =>
            Underlying.Value!.SetWindowSize(window, width, height);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        public static void SetWindowSize(Ref<Window> window, int width, int height)
        {
            fixed (Window* __dsl_window = window)
            {
                SetWindowSize(__dsl_window, width, height);
            }
        }

        [return: NativeTypeName("GLFWwindowsizefun")]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Window* window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        ) => Underlying.Value!.SetWindowSizeCallback(window, callback);

        [return: NativeTypeName("GLFWwindowsizefun")]
        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Ref<Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
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
        public static void SetWindowSizeLimits(
            Window* window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        ) =>
            Underlying.Value!.SetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        public static void SetWindowSizeLimits(
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
        public static void SetWindowTitle(
            Window* window,
            [NativeTypeName("const char *")] sbyte* title
        ) => Underlying.Value!.SetWindowTitle(window, title);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        public static void SetWindowTitle(
            Ref<Window> window,
            [NativeTypeName("const char *")] Ref<sbyte> title
        )
        {
            fixed (sbyte* __dsl_title = title)
            fixed (Window* __dsl_window = window)
            {
                SetWindowTitle(__dsl_window, __dsl_title);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        public static void SetWindowUserPointer(Window* window, void* pointer) =>
            Underlying.Value!.SetWindowUserPointer(window, pointer);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        public static void SetWindowUserPointer(Ref<Window> window, Ref pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            fixed (Window* __dsl_window = window)
            {
                SetWindowUserPointer(__dsl_window, __dsl_pointer);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        public static void ShowWindow(Window* window) => Underlying.Value!.ShowWindow(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        public static void ShowWindow(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                ShowWindow(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        public static void SwapBuffers(Window* window) => Underlying.Value!.SwapBuffers(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        public static void SwapBuffers(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                SwapBuffers(__dsl_window);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
        public static void SwapInterval(int interval) => Underlying.Value!.SwapInterval(interval);

        [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
        public static void Terminate() => Underlying.Value!.Terminate();

        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        public static int UpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string) =>
            Underlying.Value!.UpdateGamepadMappings(@string);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        public static int UpdateGamepadMappings([NativeTypeName("const char *")] Ref<sbyte> @string)
        {
            fixed (sbyte* __dsl_string = @string)
            {
                return (int)UpdateGamepadMappings(__dsl_string);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
        public static int VulkanSupported() => Underlying.Value!.VulkanSupported();

        [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
        public static void WaitEvents() => Underlying.Value!.WaitEvents();

        [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
        public static void WaitEventsTimeout(double timeout) =>
            Underlying.Value!.WaitEventsTimeout(timeout);

        [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
        public static void WindowHint(int hint, int value) =>
            Underlying.Value!.WindowHint(hint, value);

        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        public static void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] sbyte* value
        ) => Underlying.Value!.WindowHintString(hint, value);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        public static void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] Ref<sbyte> value
        )
        {
            fixed (sbyte* __dsl_value = value)
            {
                WindowHintString(hint, __dsl_value);
            }
        }

        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        public static int WindowShouldClose(Window* window) =>
            Underlying.Value!.WindowShouldClose(window);

        [Transformed]
        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        public static int WindowShouldClose(Ref<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                return (int)WindowShouldClose(__dsl_window);
            }
        }
    };

    public static partial class Constants
    {
        [NativeTypeName("#define GLFW_VERSION_MAJOR 3")]
        public const int VersionMajor = 3;

        [NativeTypeName("#define GLFW_VERSION_MINOR 4")]
        public const int VersionMinor = 4;

        [NativeTypeName("#define GLFW_VERSION_REVISION 0")]
        public const int VersionRevision = 0;

        [NativeTypeName("#define GLFW_TRUE 1")]
        public const int True = 1;

        [NativeTypeName("#define GLFW_FALSE 0")]
        public const int False = 0;

        [NativeTypeName("#define GLFW_RELEASE 0")]
        public const int Release = 0;

        [NativeTypeName("#define GLFW_PRESS 1")]
        public const int Press = 1;

        [NativeTypeName("#define GLFW_REPEAT 2")]
        public const int Repeat = 2;

        [NativeTypeName("#define GLFW_HAT_CENTERED 0")]
        public const int HatCentered = 0;

        [NativeTypeName("#define GLFW_HAT_UP 1")]
        public const int HatUp = 1;

        [NativeTypeName("#define GLFW_HAT_RIGHT 2")]
        public const int HatRight = 2;

        [NativeTypeName("#define GLFW_HAT_DOWN 4")]
        public const int HatDown = 4;

        [NativeTypeName("#define GLFW_HAT_LEFT 8")]
        public const int HatLeft = 8;

        [NativeTypeName("#define GLFW_HAT_RIGHT_UP (GLFW_HAT_RIGHT | GLFW_HAT_UP)")]
        public const int HatRightUp = (2 | 1);

        [NativeTypeName("#define GLFW_HAT_RIGHT_DOWN (GLFW_HAT_RIGHT | GLFW_HAT_DOWN)")]
        public const int HatRightDown = (2 | 4);

        [NativeTypeName("#define GLFW_HAT_LEFT_UP (GLFW_HAT_LEFT  | GLFW_HAT_UP)")]
        public const int HatLeftUp = (8 | 1);

        [NativeTypeName("#define GLFW_HAT_LEFT_DOWN (GLFW_HAT_LEFT  | GLFW_HAT_DOWN)")]
        public const int HatLeftDown = (8 | 4);

        [NativeTypeName("#define GLFW_KEY_UNKNOWN -1")]
        public const int KeyUnknown = -1;

        [NativeTypeName("#define GLFW_KEY_SPACE 32")]
        public const int KeySpace = 32;

        [NativeTypeName("#define GLFW_KEY_APOSTROPHE 39")]
        public const int KeyApostrophe = 39;

        [NativeTypeName("#define GLFW_KEY_COMMA 44")]
        public const int KeyComma = 44;

        [NativeTypeName("#define GLFW_KEY_MINUS 45")]
        public const int KeyMinus = 45;

        [NativeTypeName("#define GLFW_KEY_PERIOD 46")]
        public const int KeyPeriod = 46;

        [NativeTypeName("#define GLFW_KEY_SLASH 47")]
        public const int KeySlash = 47;

        [NativeTypeName("#define GLFW_KEY_0 48")]
        public const int Key0 = 48;

        [NativeTypeName("#define GLFW_KEY_1 49")]
        public const int Key1 = 49;

        [NativeTypeName("#define GLFW_KEY_2 50")]
        public const int Key2 = 50;

        [NativeTypeName("#define GLFW_KEY_3 51")]
        public const int Key3 = 51;

        [NativeTypeName("#define GLFW_KEY_4 52")]
        public const int Key4 = 52;

        [NativeTypeName("#define GLFW_KEY_5 53")]
        public const int Key5 = 53;

        [NativeTypeName("#define GLFW_KEY_6 54")]
        public const int Key6 = 54;

        [NativeTypeName("#define GLFW_KEY_7 55")]
        public const int Key7 = 55;

        [NativeTypeName("#define GLFW_KEY_8 56")]
        public const int Key8 = 56;

        [NativeTypeName("#define GLFW_KEY_9 57")]
        public const int Key9 = 57;

        [NativeTypeName("#define GLFW_KEY_SEMICOLON 59")]
        public const int KeySemicolon = 59;

        [NativeTypeName("#define GLFW_KEY_EQUAL 61")]
        public const int KeyEqual = 61;

        [NativeTypeName("#define GLFW_KEY_A 65")]
        public const int KeyA = 65;

        [NativeTypeName("#define GLFW_KEY_B 66")]
        public const int KeyB = 66;

        [NativeTypeName("#define GLFW_KEY_C 67")]
        public const int KeyC = 67;

        [NativeTypeName("#define GLFW_KEY_D 68")]
        public const int KeyD = 68;

        [NativeTypeName("#define GLFW_KEY_E 69")]
        public const int KeyE = 69;

        [NativeTypeName("#define GLFW_KEY_F 70")]
        public const int KeyF = 70;

        [NativeTypeName("#define GLFW_KEY_G 71")]
        public const int KeyG = 71;

        [NativeTypeName("#define GLFW_KEY_H 72")]
        public const int KeyH = 72;

        [NativeTypeName("#define GLFW_KEY_I 73")]
        public const int KeyI = 73;

        [NativeTypeName("#define GLFW_KEY_J 74")]
        public const int KeyJ = 74;

        [NativeTypeName("#define GLFW_KEY_K 75")]
        public const int KeyK = 75;

        [NativeTypeName("#define GLFW_KEY_L 76")]
        public const int KeyL = 76;

        [NativeTypeName("#define GLFW_KEY_M 77")]
        public const int KeyM = 77;

        [NativeTypeName("#define GLFW_KEY_N 78")]
        public const int KeyN = 78;

        [NativeTypeName("#define GLFW_KEY_O 79")]
        public const int KeyO = 79;

        [NativeTypeName("#define GLFW_KEY_P 80")]
        public const int KeyP = 80;

        [NativeTypeName("#define GLFW_KEY_Q 81")]
        public const int KeyQ = 81;

        [NativeTypeName("#define GLFW_KEY_R 82")]
        public const int KeyR = 82;

        [NativeTypeName("#define GLFW_KEY_S 83")]
        public const int KeyS = 83;

        [NativeTypeName("#define GLFW_KEY_T 84")]
        public const int KeyT = 84;

        [NativeTypeName("#define GLFW_KEY_U 85")]
        public const int KeyU = 85;

        [NativeTypeName("#define GLFW_KEY_V 86")]
        public const int KeyV = 86;

        [NativeTypeName("#define GLFW_KEY_W 87")]
        public const int KeyW = 87;

        [NativeTypeName("#define GLFW_KEY_X 88")]
        public const int KeyX = 88;

        [NativeTypeName("#define GLFW_KEY_Y 89")]
        public const int KeyY = 89;

        [NativeTypeName("#define GLFW_KEY_Z 90")]
        public const int KeyZ = 90;

        [NativeTypeName("#define GLFW_KEY_LEFT_BRACKET 91")]
        public const int KeyLeftBracket = 91;

        [NativeTypeName("#define GLFW_KEY_BACKSLASH 92")]
        public const int KeyBackslash = 92;

        [NativeTypeName("#define GLFW_KEY_RIGHT_BRACKET 93")]
        public const int KeyRightBracket = 93;

        [NativeTypeName("#define GLFW_KEY_GRAVE_ACCENT 96")]
        public const int KeyGraveAccent = 96;

        [NativeTypeName("#define GLFW_KEY_WORLD_1 161")]
        public const int KeyWorld1 = 161;

        [NativeTypeName("#define GLFW_KEY_WORLD_2 162")]
        public const int KeyWorld2 = 162;

        [NativeTypeName("#define GLFW_KEY_ESCAPE 256")]
        public const int KeyEscape = 256;

        [NativeTypeName("#define GLFW_KEY_ENTER 257")]
        public const int KeyEnter = 257;

        [NativeTypeName("#define GLFW_KEY_TAB 258")]
        public const int KeyTab = 258;

        [NativeTypeName("#define GLFW_KEY_BACKSPACE 259")]
        public const int KeyBackspace = 259;

        [NativeTypeName("#define GLFW_KEY_INSERT 260")]
        public const int KeyInsert = 260;

        [NativeTypeName("#define GLFW_KEY_DELETE 261")]
        public const int KeyDelete = 261;

        [NativeTypeName("#define GLFW_KEY_RIGHT 262")]
        public const int KeyRight = 262;

        [NativeTypeName("#define GLFW_KEY_LEFT 263")]
        public const int KeyLeft = 263;

        [NativeTypeName("#define GLFW_KEY_DOWN 264")]
        public const int KeyDown = 264;

        [NativeTypeName("#define GLFW_KEY_UP 265")]
        public const int KeyUp = 265;

        [NativeTypeName("#define GLFW_KEY_PAGE_UP 266")]
        public const int KeyPageUp = 266;

        [NativeTypeName("#define GLFW_KEY_PAGE_DOWN 267")]
        public const int KeyPageDown = 267;

        [NativeTypeName("#define GLFW_KEY_HOME 268")]
        public const int KeyHome = 268;

        [NativeTypeName("#define GLFW_KEY_END 269")]
        public const int KeyEnd = 269;

        [NativeTypeName("#define GLFW_KEY_CAPS_LOCK 280")]
        public const int KeyCapsLock = 280;

        [NativeTypeName("#define GLFW_KEY_SCROLL_LOCK 281")]
        public const int KeyScrollLock = 281;

        [NativeTypeName("#define GLFW_KEY_NUM_LOCK 282")]
        public const int KeyNumLock = 282;

        [NativeTypeName("#define GLFW_KEY_PRINT_SCREEN 283")]
        public const int KeyPrintScreen = 283;

        [NativeTypeName("#define GLFW_KEY_PAUSE 284")]
        public const int KeyPause = 284;

        [NativeTypeName("#define GLFW_KEY_F1 290")]
        public const int KeyF1 = 290;

        [NativeTypeName("#define GLFW_KEY_F2 291")]
        public const int KeyF2 = 291;

        [NativeTypeName("#define GLFW_KEY_F3 292")]
        public const int KeyF3 = 292;

        [NativeTypeName("#define GLFW_KEY_F4 293")]
        public const int KeyF4 = 293;

        [NativeTypeName("#define GLFW_KEY_F5 294")]
        public const int KeyF5 = 294;

        [NativeTypeName("#define GLFW_KEY_F6 295")]
        public const int KeyF6 = 295;

        [NativeTypeName("#define GLFW_KEY_F7 296")]
        public const int KeyF7 = 296;

        [NativeTypeName("#define GLFW_KEY_F8 297")]
        public const int KeyF8 = 297;

        [NativeTypeName("#define GLFW_KEY_F9 298")]
        public const int KeyF9 = 298;

        [NativeTypeName("#define GLFW_KEY_F10 299")]
        public const int KeyF10 = 299;

        [NativeTypeName("#define GLFW_KEY_F11 300")]
        public const int KeyF11 = 300;

        [NativeTypeName("#define GLFW_KEY_F12 301")]
        public const int KeyF12 = 301;

        [NativeTypeName("#define GLFW_KEY_F13 302")]
        public const int KeyF13 = 302;

        [NativeTypeName("#define GLFW_KEY_F14 303")]
        public const int KeyF14 = 303;

        [NativeTypeName("#define GLFW_KEY_F15 304")]
        public const int KeyF15 = 304;

        [NativeTypeName("#define GLFW_KEY_F16 305")]
        public const int KeyF16 = 305;

        [NativeTypeName("#define GLFW_KEY_F17 306")]
        public const int KeyF17 = 306;

        [NativeTypeName("#define GLFW_KEY_F18 307")]
        public const int KeyF18 = 307;

        [NativeTypeName("#define GLFW_KEY_F19 308")]
        public const int KeyF19 = 308;

        [NativeTypeName("#define GLFW_KEY_F20 309")]
        public const int KeyF20 = 309;

        [NativeTypeName("#define GLFW_KEY_F21 310")]
        public const int KeyF21 = 310;

        [NativeTypeName("#define GLFW_KEY_F22 311")]
        public const int KeyF22 = 311;

        [NativeTypeName("#define GLFW_KEY_F23 312")]
        public const int KeyF23 = 312;

        [NativeTypeName("#define GLFW_KEY_F24 313")]
        public const int KeyF24 = 313;

        [NativeTypeName("#define GLFW_KEY_F25 314")]
        public const int KeyF25 = 314;

        [NativeTypeName("#define GLFW_KEY_KP_0 320")]
        public const int KeyKp0 = 320;

        [NativeTypeName("#define GLFW_KEY_KP_1 321")]
        public const int KeyKp1 = 321;

        [NativeTypeName("#define GLFW_KEY_KP_2 322")]
        public const int KeyKp2 = 322;

        [NativeTypeName("#define GLFW_KEY_KP_3 323")]
        public const int KeyKp3 = 323;

        [NativeTypeName("#define GLFW_KEY_KP_4 324")]
        public const int KeyKp4 = 324;

        [NativeTypeName("#define GLFW_KEY_KP_5 325")]
        public const int KeyKp5 = 325;

        [NativeTypeName("#define GLFW_KEY_KP_6 326")]
        public const int KeyKp6 = 326;

        [NativeTypeName("#define GLFW_KEY_KP_7 327")]
        public const int KeyKp7 = 327;

        [NativeTypeName("#define GLFW_KEY_KP_8 328")]
        public const int KeyKp8 = 328;

        [NativeTypeName("#define GLFW_KEY_KP_9 329")]
        public const int KeyKp9 = 329;

        [NativeTypeName("#define GLFW_KEY_KP_DECIMAL 330")]
        public const int KeyKpDecimal = 330;

        [NativeTypeName("#define GLFW_KEY_KP_DIVIDE 331")]
        public const int KeyKpDivide = 331;

        [NativeTypeName("#define GLFW_KEY_KP_MULTIPLY 332")]
        public const int KeyKpMultiply = 332;

        [NativeTypeName("#define GLFW_KEY_KP_SUBTRACT 333")]
        public const int KeyKpSubtract = 333;

        [NativeTypeName("#define GLFW_KEY_KP_ADD 334")]
        public const int KeyKpAdd = 334;

        [NativeTypeName("#define GLFW_KEY_KP_ENTER 335")]
        public const int KeyKpEnter = 335;

        [NativeTypeName("#define GLFW_KEY_KP_EQUAL 336")]
        public const int KeyKpEqual = 336;

        [NativeTypeName("#define GLFW_KEY_LEFT_SHIFT 340")]
        public const int KeyLeftShift = 340;

        [NativeTypeName("#define GLFW_KEY_LEFT_CONTROL 341")]
        public const int KeyLeftControl = 341;

        [NativeTypeName("#define GLFW_KEY_LEFT_ALT 342")]
        public const int KeyLeftAlt = 342;

        [NativeTypeName("#define GLFW_KEY_LEFT_SUPER 343")]
        public const int KeyLeftSuper = 343;

        [NativeTypeName("#define GLFW_KEY_RIGHT_SHIFT 344")]
        public const int KeyRightShift = 344;

        [NativeTypeName("#define GLFW_KEY_RIGHT_CONTROL 345")]
        public const int KeyRightControl = 345;

        [NativeTypeName("#define GLFW_KEY_RIGHT_ALT 346")]
        public const int KeyRightAlt = 346;

        [NativeTypeName("#define GLFW_KEY_RIGHT_SUPER 347")]
        public const int KeyRightSuper = 347;

        [NativeTypeName("#define GLFW_KEY_MENU 348")]
        public const int KeyMenu = 348;

        [NativeTypeName("#define GLFW_KEY_LAST GLFW_KEY_MENU")]
        public const int KeyLast = 348;

        [NativeTypeName("#define GLFW_MOD_SHIFT 0x0001")]
        public const int ModShift = 0x0001;

        [NativeTypeName("#define GLFW_MOD_CONTROL 0x0002")]
        public const int ModControl = 0x0002;

        [NativeTypeName("#define GLFW_MOD_ALT 0x0004")]
        public const int ModAlt = 0x0004;

        [NativeTypeName("#define GLFW_MOD_SUPER 0x0008")]
        public const int ModSuper = 0x0008;

        [NativeTypeName("#define GLFW_MOD_CAPS_LOCK 0x0010")]
        public const int ModCapsLock = 0x0010;

        [NativeTypeName("#define GLFW_MOD_NUM_LOCK 0x0020")]
        public const int ModNumLock = 0x0020;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_1 0")]
        public const int MouseButton1 = 0;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_2 1")]
        public const int MouseButton2 = 1;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_3 2")]
        public const int MouseButton3 = 2;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_4 3")]
        public const int MouseButton4 = 3;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_5 4")]
        public const int MouseButton5 = 4;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_6 5")]
        public const int MouseButton6 = 5;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_7 6")]
        public const int MouseButton7 = 6;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_8 7")]
        public const int MouseButton8 = 7;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_LAST GLFW_MOUSE_BUTTON_8")]
        public const int MouseButtonLast = 7;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_LEFT GLFW_MOUSE_BUTTON_1")]
        public const int MouseButtonLeft = 0;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_RIGHT GLFW_MOUSE_BUTTON_2")]
        public const int MouseButtonRight = 1;

        [NativeTypeName("#define GLFW_MOUSE_BUTTON_MIDDLE GLFW_MOUSE_BUTTON_3")]
        public const int MouseButtonMiddle = 2;

        [NativeTypeName("#define GLFW_JOYSTICK_1 0")]
        public const int Joystick1 = 0;

        [NativeTypeName("#define GLFW_JOYSTICK_2 1")]
        public const int Joystick2 = 1;

        [NativeTypeName("#define GLFW_JOYSTICK_3 2")]
        public const int Joystick3 = 2;

        [NativeTypeName("#define GLFW_JOYSTICK_4 3")]
        public const int Joystick4 = 3;

        [NativeTypeName("#define GLFW_JOYSTICK_5 4")]
        public const int Joystick5 = 4;

        [NativeTypeName("#define GLFW_JOYSTICK_6 5")]
        public const int Joystick6 = 5;

        [NativeTypeName("#define GLFW_JOYSTICK_7 6")]
        public const int Joystick7 = 6;

        [NativeTypeName("#define GLFW_JOYSTICK_8 7")]
        public const int Joystick8 = 7;

        [NativeTypeName("#define GLFW_JOYSTICK_9 8")]
        public const int Joystick9 = 8;

        [NativeTypeName("#define GLFW_JOYSTICK_10 9")]
        public const int Joystick10 = 9;

        [NativeTypeName("#define GLFW_JOYSTICK_11 10")]
        public const int Joystick11 = 10;

        [NativeTypeName("#define GLFW_JOYSTICK_12 11")]
        public const int Joystick12 = 11;

        [NativeTypeName("#define GLFW_JOYSTICK_13 12")]
        public const int Joystick13 = 12;

        [NativeTypeName("#define GLFW_JOYSTICK_14 13")]
        public const int Joystick14 = 13;

        [NativeTypeName("#define GLFW_JOYSTICK_15 14")]
        public const int Joystick15 = 14;

        [NativeTypeName("#define GLFW_JOYSTICK_16 15")]
        public const int Joystick16 = 15;

        [NativeTypeName("#define GLFW_JOYSTICK_LAST GLFW_JOYSTICK_16")]
        public const int JoystickLast = 15;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_A 0")]
        public const int GamepadButtonA = 0;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_B 1")]
        public const int GamepadButtonB = 1;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_X 2")]
        public const int GamepadButtonX = 2;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_Y 3")]
        public const int GamepadButtonY = 3;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LEFT_BUMPER 4")]
        public const int GamepadButtonLeftBumper = 4;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER 5")]
        public const int GamepadButtonRightBumper = 5;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_BACK 6")]
        public const int GamepadButtonBack = 6;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_START 7")]
        public const int GamepadButtonStart = 7;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_GUIDE 8")]
        public const int GamepadButtonGuide = 8;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LEFT_THUMB 9")]
        public const int GamepadButtonLeftThumb = 9;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_RIGHT_THUMB 10")]
        public const int GamepadButtonRightThumb = 10;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_UP 11")]
        public const int GamepadButtonDpadUp = 11;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_RIGHT 12")]
        public const int GamepadButtonDpadRight = 12;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_DOWN 13")]
        public const int GamepadButtonDpadDown = 13;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_LEFT 14")]
        public const int GamepadButtonDpadLeft = 14;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LAST GLFW_GAMEPAD_BUTTON_DPAD_LEFT")]
        public const int GamepadButtonLast = 14;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_CROSS GLFW_GAMEPAD_BUTTON_A")]
        public const int GamepadButtonCross = 0;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_CIRCLE GLFW_GAMEPAD_BUTTON_B")]
        public const int GamepadButtonCircle = 1;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_SQUARE GLFW_GAMEPAD_BUTTON_X")]
        public const int GamepadButtonSquare = 2;

        [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_TRIANGLE GLFW_GAMEPAD_BUTTON_Y")]
        public const int GamepadButtonTriangle = 3;

        [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_X 0")]
        public const int GamepadAxisLeftX = 0;

        [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_Y 1")]
        public const int GamepadAxisLeftY = 1;

        [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_X 2")]
        public const int GamepadAxisRightX = 2;

        [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_Y 3")]
        public const int GamepadAxisRightY = 3;

        [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_TRIGGER 4")]
        public const int GamepadAxisLeftTrigger = 4;

        [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER 5")]
        public const int GamepadAxisRightTrigger = 5;

        [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LAST GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER")]
        public const int GamepadAxisLast = 5;

        [NativeTypeName("#define GLFW_NO_ERROR 0")]
        public const int NoError = 0;

        [NativeTypeName("#define GLFW_NOT_INITIALIZED 0x00010001")]
        public const int NotInitialized = 0x00010001;

        [NativeTypeName("#define GLFW_NO_CURRENT_CONTEXT 0x00010002")]
        public const int NoCurrentContext = 0x00010002;

        [NativeTypeName("#define GLFW_INVALID_ENUM 0x00010003")]
        public const int InvalidEnum = 0x00010003;

        [NativeTypeName("#define GLFW_INVALID_VALUE 0x00010004")]
        public const int InvalidValue = 0x00010004;

        [NativeTypeName("#define GLFW_OUT_OF_MEMORY 0x00010005")]
        public const int OutOfMemory = 0x00010005;

        [NativeTypeName("#define GLFW_API_UNAVAILABLE 0x00010006")]
        public const int ApiUnavailable = 0x00010006;

        [NativeTypeName("#define GLFW_VERSION_UNAVAILABLE 0x00010007")]
        public const int VersionUnavailable = 0x00010007;

        [NativeTypeName("#define GLFW_PLATFORM_ERROR 0x00010008")]
        public const int PlatformError = 0x00010008;

        [NativeTypeName("#define GLFW_FORMAT_UNAVAILABLE 0x00010009")]
        public const int FormatUnavailable = 0x00010009;

        [NativeTypeName("#define GLFW_NO_WINDOW_CONTEXT 0x0001000A")]
        public const int NoWindowContext = 0x0001000A;

        [NativeTypeName("#define GLFW_CURSOR_UNAVAILABLE 0x0001000B")]
        public const int CursorUnavailable = 0x0001000B;

        [NativeTypeName("#define GLFW_FEATURE_UNAVAILABLE 0x0001000C")]
        public const int FeatureUnavailable = 0x0001000C;

        [NativeTypeName("#define GLFW_FEATURE_UNIMPLEMENTED 0x0001000D")]
        public const int FeatureUnimplemented = 0x0001000D;

        [NativeTypeName("#define GLFW_PLATFORM_UNAVAILABLE 0x0001000E")]
        public const int PlatformUnavailable = 0x0001000E;

        [NativeTypeName("#define GLFW_FOCUSED 0x00020001")]
        public const int Focused = 0x00020001;

        [NativeTypeName("#define GLFW_ICONIFIED 0x00020002")]
        public const int Iconified = 0x00020002;

        [NativeTypeName("#define GLFW_RESIZABLE 0x00020003")]
        public const int Resizable = 0x00020003;

        [NativeTypeName("#define GLFW_VISIBLE 0x00020004")]
        public const int Visible = 0x00020004;

        [NativeTypeName("#define GLFW_DECORATED 0x00020005")]
        public const int Decorated = 0x00020005;

        [NativeTypeName("#define GLFW_AUTO_ICONIFY 0x00020006")]
        public const int AutoIconify = 0x00020006;

        [NativeTypeName("#define GLFW_FLOATING 0x00020007")]
        public const int Floating = 0x00020007;

        [NativeTypeName("#define GLFW_MAXIMIZED 0x00020008")]
        public const int Maximized = 0x00020008;

        [NativeTypeName("#define GLFW_CENTER_CURSOR 0x00020009")]
        public const int CenterCursor = 0x00020009;

        [NativeTypeName("#define GLFW_TRANSPARENT_FRAMEBUFFER 0x0002000A")]
        public const int TransparentFramebuffer = 0x0002000A;

        [NativeTypeName("#define GLFW_HOVERED 0x0002000B")]
        public const int Hovered = 0x0002000B;

        [NativeTypeName("#define GLFW_FOCUS_ON_SHOW 0x0002000C")]
        public const int FocusOnShow = 0x0002000C;

        [NativeTypeName("#define GLFW_MOUSE_PASSTHROUGH 0x0002000D")]
        public const int MousePassthrough = 0x0002000D;

        [NativeTypeName("#define GLFW_POSITION_X 0x0002000E")]
        public const int PositionX = 0x0002000E;

        [NativeTypeName("#define GLFW_POSITION_Y 0x0002000F")]
        public const int PositionY = 0x0002000F;

        [NativeTypeName("#define GLFW_RED_BITS 0x00021001")]
        public const int RedBits = 0x00021001;

        [NativeTypeName("#define GLFW_GREEN_BITS 0x00021002")]
        public const int GreenBits = 0x00021002;

        [NativeTypeName("#define GLFW_BLUE_BITS 0x00021003")]
        public const int BlueBits = 0x00021003;

        [NativeTypeName("#define GLFW_ALPHA_BITS 0x00021004")]
        public const int AlphaBits = 0x00021004;

        [NativeTypeName("#define GLFW_DEPTH_BITS 0x00021005")]
        public const int DepthBits = 0x00021005;

        [NativeTypeName("#define GLFW_STENCIL_BITS 0x00021006")]
        public const int StencilBits = 0x00021006;

        [NativeTypeName("#define GLFW_ACCUM_RED_BITS 0x00021007")]
        public const int AccumRedBits = 0x00021007;

        [NativeTypeName("#define GLFW_ACCUM_GREEN_BITS 0x00021008")]
        public const int AccumGreenBits = 0x00021008;

        [NativeTypeName("#define GLFW_ACCUM_BLUE_BITS 0x00021009")]
        public const int AccumBlueBits = 0x00021009;

        [NativeTypeName("#define GLFW_ACCUM_ALPHA_BITS 0x0002100A")]
        public const int AccumAlphaBits = 0x0002100A;

        [NativeTypeName("#define GLFW_AUX_BUFFERS 0x0002100B")]
        public const int AuxBuffers = 0x0002100B;

        [NativeTypeName("#define GLFW_STEREO 0x0002100C")]
        public const int Stereo = 0x0002100C;

        [NativeTypeName("#define GLFW_SAMPLES 0x0002100D")]
        public const int Samples = 0x0002100D;

        [NativeTypeName("#define GLFW_SRGB_CAPABLE 0x0002100E")]
        public const int SrgbCapable = 0x0002100E;

        [NativeTypeName("#define GLFW_REFRESH_RATE 0x0002100F")]
        public const int RefreshRate = 0x0002100F;

        [NativeTypeName("#define GLFW_DOUBLEBUFFER 0x00021010")]
        public const int Doublebuffer = 0x00021010;

        [NativeTypeName("#define GLFW_CLIENT_API 0x00022001")]
        public const int ClientApi = 0x00022001;

        [NativeTypeName("#define GLFW_CONTEXT_VERSION_MAJOR 0x00022002")]
        public const int ContextVersionMajor = 0x00022002;

        [NativeTypeName("#define GLFW_CONTEXT_VERSION_MINOR 0x00022003")]
        public const int ContextVersionMinor = 0x00022003;

        [NativeTypeName("#define GLFW_CONTEXT_REVISION 0x00022004")]
        public const int ContextRevision = 0x00022004;

        [NativeTypeName("#define GLFW_CONTEXT_ROBUSTNESS 0x00022005")]
        public const int ContextRobustness = 0x00022005;

        [NativeTypeName("#define GLFW_OPENGL_FORWARD_COMPAT 0x00022006")]
        public const int OpenglForwardCompat = 0x00022006;

        [NativeTypeName("#define GLFW_CONTEXT_DEBUG 0x00022007")]
        public const int ContextDebug = 0x00022007;

        [NativeTypeName("#define GLFW_OPENGL_DEBUG_CONTEXT GLFW_CONTEXT_DEBUG")]
        public const int OpenglDebugContext = 0x00022007;

        [NativeTypeName("#define GLFW_OPENGL_PROFILE 0x00022008")]
        public const int OpenglProfile = 0x00022008;

        [NativeTypeName("#define GLFW_CONTEXT_RELEASE_BEHAVIOR 0x00022009")]
        public const int ContextReleaseBehavior = 0x00022009;

        [NativeTypeName("#define GLFW_CONTEXT_NO_ERROR 0x0002200A")]
        public const int ContextNoError = 0x0002200A;

        [NativeTypeName("#define GLFW_CONTEXT_CREATION_API 0x0002200B")]
        public const int ContextCreationApi = 0x0002200B;

        [NativeTypeName("#define GLFW_SCALE_TO_MONITOR 0x0002200C")]
        public const int ScaleToMonitor = 0x0002200C;

        [NativeTypeName("#define GLFW_COCOA_RETINA_FRAMEBUFFER 0x00023001")]
        public const int CocoaRetinaFramebuffer = 0x00023001;

        [NativeTypeName("#define GLFW_COCOA_FRAME_NAME 0x00023002")]
        public const int CocoaFrameName = 0x00023002;

        [NativeTypeName("#define GLFW_COCOA_GRAPHICS_SWITCHING 0x00023003")]
        public const int CocoaGraphicsSwitching = 0x00023003;

        [NativeTypeName("#define GLFW_X11_CLASS_NAME 0x00024001")]
        public const int X11ClassName = 0x00024001;

        [NativeTypeName("#define GLFW_X11_INSTANCE_NAME 0x00024002")]
        public const int X11InstanceName = 0x00024002;

        [NativeTypeName("#define GLFW_WIN32_KEYBOARD_MENU 0x00025001")]
        public const int Win32KeyboardMenu = 0x00025001;

        [NativeTypeName("#define GLFW_WAYLAND_APP_ID 0x00026001")]
        public const int WaylandAppId = 0x00026001;

        [NativeTypeName("#define GLFW_NO_API 0")]
        public const int NoApi = 0;

        [NativeTypeName("#define GLFW_OPENGL_API 0x00030001")]
        public const int OpenglApi = 0x00030001;

        [NativeTypeName("#define GLFW_OPENGL_ES_API 0x00030002")]
        public const int OpenglEsApi = 0x00030002;

        [NativeTypeName("#define GLFW_NO_ROBUSTNESS 0")]
        public const int NoRobustness = 0;

        [NativeTypeName("#define GLFW_NO_RESET_NOTIFICATION 0x00031001")]
        public const int NoResetNotification = 0x00031001;

        [NativeTypeName("#define GLFW_LOSE_CONTEXT_ON_RESET 0x00031002")]
        public const int LoseContextOnReset = 0x00031002;

        [NativeTypeName("#define GLFW_OPENGL_ANY_PROFILE 0")]
        public const int OpenglAnyProfile = 0;

        [NativeTypeName("#define GLFW_OPENGL_CORE_PROFILE 0x00032001")]
        public const int OpenglCoreProfile = 0x00032001;

        [NativeTypeName("#define GLFW_OPENGL_COMPAT_PROFILE 0x00032002")]
        public const int OpenglCompatProfile = 0x00032002;

        [NativeTypeName("#define GLFW_CURSOR 0x00033001")]
        public const int Cursor = 0x00033001;

        [NativeTypeName("#define GLFW_STICKY_KEYS 0x00033002")]
        public const int StickyKeys = 0x00033002;

        [NativeTypeName("#define GLFW_STICKY_MOUSE_BUTTONS 0x00033003")]
        public const int StickyMouseButtons = 0x00033003;

        [NativeTypeName("#define GLFW_LOCK_KEY_MODS 0x00033004")]
        public const int LockKeyMods = 0x00033004;

        [NativeTypeName("#define GLFW_RAW_MOUSE_MOTION 0x00033005")]
        public const int RawMouseMotion = 0x00033005;

        [NativeTypeName("#define GLFW_CURSOR_NORMAL 0x00034001")]
        public const int CursorNormal = 0x00034001;

        [NativeTypeName("#define GLFW_CURSOR_HIDDEN 0x00034002")]
        public const int CursorHidden = 0x00034002;

        [NativeTypeName("#define GLFW_CURSOR_DISABLED 0x00034003")]
        public const int CursorDisabled = 0x00034003;

        [NativeTypeName("#define GLFW_CURSOR_CAPTURED 0x00034004")]
        public const int CursorCaptured = 0x00034004;

        [NativeTypeName("#define GLFW_ANY_RELEASE_BEHAVIOR 0")]
        public const int AnyReleaseBehavior = 0;

        [NativeTypeName("#define GLFW_RELEASE_BEHAVIOR_FLUSH 0x00035001")]
        public const int ReleaseBehaviorFlush = 0x00035001;

        [NativeTypeName("#define GLFW_RELEASE_BEHAVIOR_NONE 0x00035002")]
        public const int ReleaseBehaviorNone = 0x00035002;

        [NativeTypeName("#define GLFW_NATIVE_CONTEXT_API 0x00036001")]
        public const int NativeContextApi = 0x00036001;

        [NativeTypeName("#define GLFW_EGL_CONTEXT_API 0x00036002")]
        public const int EglContextApi = 0x00036002;

        [NativeTypeName("#define GLFW_OSMESA_CONTEXT_API 0x00036003")]
        public const int OsmesaContextApi = 0x00036003;

        [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_NONE 0x00037001")]
        public const int AnglePlatformTypeNone = 0x00037001;

        [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_OPENGL 0x00037002")]
        public const int AnglePlatformTypeOpengl = 0x00037002;

        [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_OPENGLES 0x00037003")]
        public const int AnglePlatformTypeOpengles = 0x00037003;

        [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_D3D9 0x00037004")]
        public const int AnglePlatformTypeD3D9 = 0x00037004;

        [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_D3D11 0x00037005")]
        public const int AnglePlatformTypeD3D11 = 0x00037005;

        [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_VULKAN 0x00037007")]
        public const int AnglePlatformTypeVulkan = 0x00037007;

        [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_METAL 0x00037008")]
        public const int AnglePlatformTypeMetal = 0x00037008;

        [NativeTypeName("#define GLFW_WAYLAND_PREFER_LIBDECOR 0x00038001")]
        public const int WaylandPreferLibdecor = 0x00038001;

        [NativeTypeName("#define GLFW_WAYLAND_DISABLE_LIBDECOR 0x00038002")]
        public const int WaylandDisableLibdecor = 0x00038002;

        [NativeTypeName("#define GLFW_ANY_POSITION 0x80000000")]
        public const uint AnyPosition = 0x80000000;

        [NativeTypeName("#define GLFW_ARROW_CURSOR 0x00036001")]
        public const int ArrowCursor = 0x00036001;

        [NativeTypeName("#define GLFW_IBEAM_CURSOR 0x00036002")]
        public const int IbeamCursor = 0x00036002;

        [NativeTypeName("#define GLFW_CROSSHAIR_CURSOR 0x00036003")]
        public const int CrosshairCursor = 0x00036003;

        [NativeTypeName("#define GLFW_POINTING_HAND_CURSOR 0x00036004")]
        public const int PointingHandCursor = 0x00036004;

        [NativeTypeName("#define GLFW_RESIZE_EW_CURSOR 0x00036005")]
        public const int ResizeEwCursor = 0x00036005;

        [NativeTypeName("#define GLFW_RESIZE_NS_CURSOR 0x00036006")]
        public const int ResizeNsCursor = 0x00036006;

        [NativeTypeName("#define GLFW_RESIZE_NWSE_CURSOR 0x00036007")]
        public const int ResizeNwseCursor = 0x00036007;

        [NativeTypeName("#define GLFW_RESIZE_NESW_CURSOR 0x00036008")]
        public const int ResizeNeswCursor = 0x00036008;

        [NativeTypeName("#define GLFW_RESIZE_ALL_CURSOR 0x00036009")]
        public const int ResizeAllCursor = 0x00036009;

        [NativeTypeName("#define GLFW_NOT_ALLOWED_CURSOR 0x0003600A")]
        public const int NotAllowedCursor = 0x0003600A;

        [NativeTypeName("#define GLFW_HRESIZE_CURSOR GLFW_RESIZE_EW_CURSOR")]
        public const int HresizeCursor = 0x00036005;

        [NativeTypeName("#define GLFW_VRESIZE_CURSOR GLFW_RESIZE_NS_CURSOR")]
        public const int VresizeCursor = 0x00036006;

        [NativeTypeName("#define GLFW_HAND_CURSOR GLFW_POINTING_HAND_CURSOR")]
        public const int HandCursor = 0x00036004;

        [NativeTypeName("#define GLFW_CONNECTED 0x00040001")]
        public const int Connected = 0x00040001;

        [NativeTypeName("#define GLFW_DISCONNECTED 0x00040002")]
        public const int Disconnected = 0x00040002;

        [NativeTypeName("#define GLFW_JOYSTICK_HAT_BUTTONS 0x00050001")]
        public const int JoystickHatButtons = 0x00050001;

        [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE 0x00050002")]
        public const int AnglePlatformType = 0x00050002;

        [NativeTypeName("#define GLFW_PLATFORM 0x00050003")]
        public const int Platform = 0x00050003;

        [NativeTypeName("#define GLFW_COCOA_CHDIR_RESOURCES 0x00051001")]
        public const int CocoaChdirResources = 0x00051001;

        [NativeTypeName("#define GLFW_COCOA_MENUBAR 0x00051002")]
        public const int CocoaMenubar = 0x00051002;

        [NativeTypeName("#define GLFW_X11_XCB_VULKAN_SURFACE 0x00052001")]
        public const int X11XcbVulkanSurface = 0x00052001;

        [NativeTypeName("#define GLFW_WAYLAND_LIBDECOR 0x00053001")]
        public const int WaylandLibdecor = 0x00053001;

        [NativeTypeName("#define GLFW_ANY_PLATFORM 0x00060000")]
        public const int AnyPlatform = 0x00060000;

        [NativeTypeName("#define GLFW_PLATFORM_WIN32 0x00060001")]
        public const int PlatformWin32 = 0x00060001;

        [NativeTypeName("#define GLFW_PLATFORM_COCOA 0x00060002")]
        public const int PlatformCocoa = 0x00060002;

        [NativeTypeName("#define GLFW_PLATFORM_WAYLAND 0x00060003")]
        public const int PlatformWayland = 0x00060003;

        [NativeTypeName("#define GLFW_PLATFORM_X11 0x00060004")]
        public const int PlatformX11 = 0x00060004;

        [NativeTypeName("#define GLFW_PLATFORM_NULL 0x00060005")]
        public const int PlatformNull = 0x00060005;

        [NativeTypeName("#define GLFW_DONT_CARE -1")]
        public const int DontCare = -1;
    }

    Cursor* IGlfw.CreateCursor(
        [NativeTypeName("const GLFWimage *")] Image* image,
        int xhot,
        int yhot
    ) =>
        (
            (delegate* unmanaged<Image*, int, int, Cursor*>)
                nativeContext.LoadFunction("glfwCreateCursor", "glfw")
        )(image, xhot, yhot);

    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    public static Cursor* CreateCursor(
        [NativeTypeName("const GLFWimage *")] Image* image,
        int xhot,
        int yhot
    ) => DllImport.CreateCursor(image, xhot, yhot);

    Ptr<Cursor> IGlfw.CreateCursor(
        [NativeTypeName("const GLFWimage *")] Ref<Image> image,
        int xhot,
        int yhot
    )
    {
        fixed (Image* __dsl_image = image)
        {
            return (Cursor*)((IGlfw)this).CreateCursor(__dsl_image, xhot, yhot);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    public static Ptr<Cursor> CreateCursor(
        [NativeTypeName("const GLFWimage *")] Ref<Image> image,
        int xhot,
        int yhot
    ) => DllImport.CreateCursor(image, xhot, yhot);

    Ptr<Cursor> IGlfw.CreateStandardCursor(int shape) =>
        (Cursor*)((IGlfw)this).CreateStandardCursorRaw(shape);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    public static Ptr<Cursor> CreateStandardCursor(int shape) =>
        DllImport.CreateStandardCursor(shape);

    Cursor* IGlfw.CreateStandardCursorRaw(int shape) =>
        (
            (delegate* unmanaged<int, Cursor*>)
                nativeContext.LoadFunction("glfwCreateStandardCursor", "glfw")
        )(shape);

    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    public static Cursor* CreateStandardCursorRaw(int shape) =>
        DllImport.CreateStandardCursorRaw(shape);

    Window* IGlfw.CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] sbyte* title,
        Monitor* monitor,
        Window* share
    ) =>
        (
            (delegate* unmanaged<int, int, sbyte*, Monitor*, Window*, Window*>)
                nativeContext.LoadFunction("glfwCreateWindow", "glfw")
        )(width, height, title, monitor, share);

    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    public static Window* CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] sbyte* title,
        Monitor* monitor,
        Window* share
    ) => DllImport.CreateWindow(width, height, title, monitor, share);

    Ptr<Window> IGlfw.CreateWindow(
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
                ((IGlfw)this).CreateWindow(width, height, __dsl_title, __dsl_monitor, __dsl_share);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    public static Ptr<Window> CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] Ref<sbyte> title,
        Ref<Monitor> monitor,
        Ref<Window> share
    ) => DllImport.CreateWindow(width, height, title, monitor, share);

    void IGlfw.DefaultWindowHints() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwDefaultWindowHints", "glfw"))();

    [NativeFunction("glfw", EntryPoint = "glfwDefaultWindowHints")]
    public static void DefaultWindowHints() => DllImport.DefaultWindowHints();

    void IGlfw.DestroyCursor(Cursor* cursor) =>
        (
            (delegate* unmanaged<Cursor*, void>)
                nativeContext.LoadFunction("glfwDestroyCursor", "glfw")
        )(cursor);

    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    public static void DestroyCursor(Cursor* cursor) => DllImport.DestroyCursor(cursor);

    void IGlfw.DestroyCursor(Ref<Cursor> cursor)
    {
        fixed (Cursor* __dsl_cursor = cursor)
        {
            ((IGlfw)this).DestroyCursor(__dsl_cursor);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    public static void DestroyCursor(Ref<Cursor> cursor) => DllImport.DestroyCursor(cursor);

    void IGlfw.DestroyWindow(Window* window) =>
        (
            (delegate* unmanaged<Window*, void>)
                nativeContext.LoadFunction("glfwDestroyWindow", "glfw")
        )(window);

    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    public static void DestroyWindow(Window* window) => DllImport.DestroyWindow(window);

    void IGlfw.DestroyWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).DestroyWindow(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    public static void DestroyWindow(Ref<Window> window) => DllImport.DestroyWindow(window);

    int IGlfw.ExtensionSupported([NativeTypeName("const char *")] sbyte* extension) =>
        (
            (delegate* unmanaged<sbyte*, int>)
                nativeContext.LoadFunction("glfwExtensionSupported", "glfw")
        )(extension);

    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    public static int ExtensionSupported([NativeTypeName("const char *")] sbyte* extension) =>
        DllImport.ExtensionSupported(extension);

    int IGlfw.ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension)
    {
        fixed (sbyte* __dsl_extension = extension)
        {
            return (int)((IGlfw)this).ExtensionSupported(__dsl_extension);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    public static int ExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension) =>
        DllImport.ExtensionSupported(extension);

    void IGlfw.FocusWindow(Window* window) =>
        ((delegate* unmanaged<Window*, void>)nativeContext.LoadFunction("glfwFocusWindow", "glfw"))(
            window
        );

    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    public static void FocusWindow(Window* window) => DllImport.FocusWindow(window);

    void IGlfw.FocusWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).FocusWindow(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    public static void FocusWindow(Ref<Window> window) => DllImport.FocusWindow(window);

    sbyte* IGlfw.GetClipboardString(Window* window) =>
        (
            (delegate* unmanaged<Window*, sbyte*>)
                nativeContext.LoadFunction("glfwGetClipboardString", "glfw")
        )(window);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    public static sbyte* GetClipboardString(Window* window) => DllImport.GetClipboardString(window);

    Ptr<sbyte> IGlfw.GetClipboardString(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            return (sbyte*)((IGlfw)this).GetClipboardString(__dsl_window);
        }
    }

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    public static Ptr<sbyte> GetClipboardString(Ref<Window> window) =>
        DllImport.GetClipboardString(window);

    Ptr<Window> IGlfw.GetCurrentContext() => (Window*)((IGlfw)this).GetCurrentContextRaw();

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    public static Ptr<Window> GetCurrentContext() => DllImport.GetCurrentContext();

    Window* IGlfw.GetCurrentContextRaw() =>
        (
            (delegate* unmanaged<Window*>)
                nativeContext.LoadFunction("glfwGetCurrentContext", "glfw")
        )();

    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    public static Window* GetCurrentContextRaw() => DllImport.GetCurrentContextRaw();

    void IGlfw.GetCursorPos(Window* window, double* xpos, double* ypos) =>
        (
            (delegate* unmanaged<Window*, double*, double*, void>)
                nativeContext.LoadFunction("glfwGetCursorPos", "glfw")
        )(window, xpos, ypos);

    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    public static void GetCursorPos(Window* window, double* xpos, double* ypos) =>
        DllImport.GetCursorPos(window, xpos, ypos);

    void IGlfw.GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos)
    {
        fixed (double* __dsl_ypos = ypos)
        fixed (double* __dsl_xpos = xpos)
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).GetCursorPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    public static void GetCursorPos(Ref<Window> window, Ref<double> xpos, Ref<double> ypos) =>
        DllImport.GetCursorPos(window, xpos, ypos);

    int IGlfw.GetError([NativeTypeName("const char **")] sbyte** description) =>
        ((delegate* unmanaged<sbyte**, int>)nativeContext.LoadFunction("glfwGetError", "glfw"))(
            description
        );

    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    public static int GetError([NativeTypeName("const char **")] sbyte** description) =>
        DllImport.GetError(description);

    int IGlfw.GetError([NativeTypeName("const char **")] Ref2D<sbyte> description)
    {
        fixed (sbyte** __dsl_description = description)
        {
            return (int)((IGlfw)this).GetError(__dsl_description);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    public static int GetError([NativeTypeName("const char **")] Ref2D<sbyte> description) =>
        DllImport.GetError(description);

    void IGlfw.GetFramebufferSize(Window* window, int* width, int* height) =>
        (
            (delegate* unmanaged<Window*, int*, int*, void>)
                nativeContext.LoadFunction("glfwGetFramebufferSize", "glfw")
        )(window, width, height);

    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    public static void GetFramebufferSize(Window* window, int* width, int* height) =>
        DllImport.GetFramebufferSize(window, width, height);

    void IGlfw.GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).GetFramebufferSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    public static void GetFramebufferSize(Ref<Window> window, Ref<int> width, Ref<int> height) =>
        DllImport.GetFramebufferSize(window, width, height);

    Ptr<sbyte> IGlfw.GetGamepadName(int jid) => (sbyte*)((IGlfw)this).GetGamepadNameRaw(jid);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    public static Ptr<sbyte> GetGamepadName(int jid) => DllImport.GetGamepadName(jid);

    sbyte* IGlfw.GetGamepadNameRaw(int jid) =>
        (
            (delegate* unmanaged<int, sbyte*>)
                nativeContext.LoadFunction("glfwGetGamepadName", "glfw")
        )(jid);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    public static sbyte* GetGamepadNameRaw(int jid) => DllImport.GetGamepadNameRaw(jid);

    int IGlfw.GetGamepadState(int jid, Gamepadstate* state) =>
        (
            (delegate* unmanaged<int, Gamepadstate*, int>)
                nativeContext.LoadFunction("glfwGetGamepadState", "glfw")
        )(jid, state);

    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    public static int GetGamepadState(int jid, Gamepadstate* state) =>
        DllImport.GetGamepadState(jid, state);

    int IGlfw.GetGamepadState(int jid, Ref<Gamepadstate> state)
    {
        fixed (Gamepadstate* __dsl_state = state)
        {
            return (int)((IGlfw)this).GetGamepadState(jid, __dsl_state);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    public static int GetGamepadState(int jid, Ref<Gamepadstate> state) =>
        DllImport.GetGamepadState(jid, state);

    Gammaramp* IGlfw.GetGammaRamp(Monitor* monitor) =>
        (
            (delegate* unmanaged<Monitor*, Gammaramp*>)
                nativeContext.LoadFunction("glfwGetGammaRamp", "glfw")
        )(monitor);

    [return: NativeTypeName("const GLFWgammaramp *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    public static Gammaramp* GetGammaRamp(Monitor* monitor) => DllImport.GetGammaRamp(monitor);

    Ptr<Gammaramp> IGlfw.GetGammaRamp(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            return (Gammaramp*)((IGlfw)this).GetGammaRamp(__dsl_monitor);
        }
    }

    [return: NativeTypeName("const GLFWgammaramp *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    public static Ptr<Gammaramp> GetGammaRamp(Ref<Monitor> monitor) =>
        DllImport.GetGammaRamp(monitor);

    int IGlfw.GetInputMode(Window* window, int mode) =>
        (
            (delegate* unmanaged<Window*, int, int>)
                nativeContext.LoadFunction("glfwGetInputMode", "glfw")
        )(window, mode);

    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    public static int GetInputMode(Window* window, int mode) =>
        DllImport.GetInputMode(window, mode);

    int IGlfw.GetInputMode(Ref<Window> window, int mode)
    {
        fixed (Window* __dsl_window = window)
        {
            return (int)((IGlfw)this).GetInputMode(__dsl_window, mode);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    public static int GetInputMode(Ref<Window> window, int mode) =>
        DllImport.GetInputMode(window, mode);

    float* IGlfw.GetJoystickAxes(int jid, int* count) =>
        (
            (delegate* unmanaged<int, int*, float*>)
                nativeContext.LoadFunction("glfwGetJoystickAxes", "glfw")
        )(jid, count);

    [return: NativeTypeName("const float *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    public static float* GetJoystickAxes(int jid, int* count) =>
        DllImport.GetJoystickAxes(jid, count);

    Ptr<float> IGlfw.GetJoystickAxes(int jid, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            return (float*)((IGlfw)this).GetJoystickAxes(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const float *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    public static Ptr<float> GetJoystickAxes(int jid, Ref<int> count) =>
        DllImport.GetJoystickAxes(jid, count);

    byte* IGlfw.GetJoystickButtons(int jid, int* count) =>
        (
            (delegate* unmanaged<int, int*, byte*>)
                nativeContext.LoadFunction("glfwGetJoystickButtons", "glfw")
        )(jid, count);

    [return: NativeTypeName("const unsigned char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    public static byte* GetJoystickButtons(int jid, int* count) =>
        DllImport.GetJoystickButtons(jid, count);

    Ptr<byte> IGlfw.GetJoystickButtons(int jid, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            return (byte*)((IGlfw)this).GetJoystickButtons(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const unsigned char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    public static Ptr<byte> GetJoystickButtons(int jid, Ref<int> count) =>
        DllImport.GetJoystickButtons(jid, count);

    Ptr<sbyte> IGlfw.GetJoystickGuid(int jid) => (sbyte*)((IGlfw)this).GetJoystickGuidRaw(jid);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    public static Ptr<sbyte> GetJoystickGuid(int jid) => DllImport.GetJoystickGuid(jid);

    sbyte* IGlfw.GetJoystickGuidRaw(int jid) =>
        (
            (delegate* unmanaged<int, sbyte*>)
                nativeContext.LoadFunction("glfwGetJoystickGUID", "glfw")
        )(jid);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    public static sbyte* GetJoystickGuidRaw(int jid) => DllImport.GetJoystickGuidRaw(jid);

    byte* IGlfw.GetJoystickHats(int jid, int* count) =>
        (
            (delegate* unmanaged<int, int*, byte*>)
                nativeContext.LoadFunction("glfwGetJoystickHats", "glfw")
        )(jid, count);

    [return: NativeTypeName("const unsigned char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    public static byte* GetJoystickHats(int jid, int* count) =>
        DllImport.GetJoystickHats(jid, count);

    Ptr<byte> IGlfw.GetJoystickHats(int jid, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            return (byte*)((IGlfw)this).GetJoystickHats(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const unsigned char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    public static Ptr<byte> GetJoystickHats(int jid, Ref<int> count) =>
        DllImport.GetJoystickHats(jid, count);

    Ptr<sbyte> IGlfw.GetJoystickName(int jid) => (sbyte*)((IGlfw)this).GetJoystickNameRaw(jid);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    public static Ptr<sbyte> GetJoystickName(int jid) => DllImport.GetJoystickName(jid);

    sbyte* IGlfw.GetJoystickNameRaw(int jid) =>
        (
            (delegate* unmanaged<int, sbyte*>)
                nativeContext.LoadFunction("glfwGetJoystickName", "glfw")
        )(jid);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    public static sbyte* GetJoystickNameRaw(int jid) => DllImport.GetJoystickNameRaw(jid);

    Ptr IGlfw.GetJoystickUserPointer(int jid) =>
        (void*)((IGlfw)this).GetJoystickUserPointerRaw(jid);

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    public static Ptr GetJoystickUserPointer(int jid) => DllImport.GetJoystickUserPointer(jid);

    void* IGlfw.GetJoystickUserPointerRaw(int jid) =>
        (
            (delegate* unmanaged<int, void*>)
                nativeContext.LoadFunction("glfwGetJoystickUserPointer", "glfw")
        )(jid);

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    public static void* GetJoystickUserPointerRaw(int jid) =>
        DllImport.GetJoystickUserPointerRaw(jid);

    int IGlfw.GetKey(Window* window, int key) =>
        ((delegate* unmanaged<Window*, int, int>)nativeContext.LoadFunction("glfwGetKey", "glfw"))(
            window,
            key
        );

    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    public static int GetKey(Window* window, int key) => DllImport.GetKey(window, key);

    int IGlfw.GetKey(Ref<Window> window, int key)
    {
        fixed (Window* __dsl_window = window)
        {
            return (int)((IGlfw)this).GetKey(__dsl_window, key);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    public static int GetKey(Ref<Window> window, int key) => DllImport.GetKey(window, key);

    Ptr<sbyte> IGlfw.GetKeyName(int key, int scancode) =>
        (sbyte*)((IGlfw)this).GetKeyNameRaw(key, scancode);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    public static Ptr<sbyte> GetKeyName(int key, int scancode) =>
        DllImport.GetKeyName(key, scancode);

    sbyte* IGlfw.GetKeyNameRaw(int key, int scancode) =>
        (
            (delegate* unmanaged<int, int, sbyte*>)
                nativeContext.LoadFunction("glfwGetKeyName", "glfw")
        )(key, scancode);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    public static sbyte* GetKeyNameRaw(int key, int scancode) =>
        DllImport.GetKeyNameRaw(key, scancode);

    int IGlfw.GetKeyScancode(int key) =>
        ((delegate* unmanaged<int, int>)nativeContext.LoadFunction("glfwGetKeyScancode", "glfw"))(
            key
        );

    [NativeFunction("glfw", EntryPoint = "glfwGetKeyScancode")]
    public static int GetKeyScancode(int key) => DllImport.GetKeyScancode(key);

    void IGlfw.GetMonitorContentScale(Monitor* monitor, float* xscale, float* yscale) =>
        (
            (delegate* unmanaged<Monitor*, float*, float*, void>)
                nativeContext.LoadFunction("glfwGetMonitorContentScale", "glfw")
        )(monitor, xscale, yscale);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    public static void GetMonitorContentScale(Monitor* monitor, float* xscale, float* yscale) =>
        DllImport.GetMonitorContentScale(monitor, xscale, yscale);

    void IGlfw.GetMonitorContentScale(Ref<Monitor> monitor, Ref<float> xscale, Ref<float> yscale)
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            ((IGlfw)this).GetMonitorContentScale(__dsl_monitor, __dsl_xscale, __dsl_yscale);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    public static void GetMonitorContentScale(
        Ref<Monitor> monitor,
        Ref<float> xscale,
        Ref<float> yscale
    ) => DllImport.GetMonitorContentScale(monitor, xscale, yscale);

    sbyte* IGlfw.GetMonitorName(Monitor* monitor) =>
        (
            (delegate* unmanaged<Monitor*, sbyte*>)
                nativeContext.LoadFunction("glfwGetMonitorName", "glfw")
        )(monitor);

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    public static sbyte* GetMonitorName(Monitor* monitor) => DllImport.GetMonitorName(monitor);

    Ptr<sbyte> IGlfw.GetMonitorName(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            return (sbyte*)((IGlfw)this).GetMonitorName(__dsl_monitor);
        }
    }

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    public static Ptr<sbyte> GetMonitorName(Ref<Monitor> monitor) =>
        DllImport.GetMonitorName(monitor);

    void IGlfw.GetMonitorPhysicalSize(Monitor* monitor, int* widthMM, int* heightMM) =>
        (
            (delegate* unmanaged<Monitor*, int*, int*, void>)
                nativeContext.LoadFunction("glfwGetMonitorPhysicalSize", "glfw")
        )(monitor, widthMM, heightMM);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    public static void GetMonitorPhysicalSize(Monitor* monitor, int* widthMM, int* heightMM) =>
        DllImport.GetMonitorPhysicalSize(monitor, widthMM, heightMM);

    void IGlfw.GetMonitorPhysicalSize(Ref<Monitor> monitor, Ref<int> widthMM, Ref<int> heightMM)
    {
        fixed (int* __dsl_heightMM = heightMM)
        fixed (int* __dsl_widthMM = widthMM)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            ((IGlfw)this).GetMonitorPhysicalSize(__dsl_monitor, __dsl_widthMM, __dsl_heightMM);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    public static void GetMonitorPhysicalSize(
        Ref<Monitor> monitor,
        Ref<int> widthMM,
        Ref<int> heightMM
    ) => DllImport.GetMonitorPhysicalSize(monitor, widthMM, heightMM);

    void IGlfw.GetMonitorPos(Monitor* monitor, int* xpos, int* ypos) =>
        (
            (delegate* unmanaged<Monitor*, int*, int*, void>)
                nativeContext.LoadFunction("glfwGetMonitorPos", "glfw")
        )(monitor, xpos, ypos);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    public static void GetMonitorPos(Monitor* monitor, int* xpos, int* ypos) =>
        DllImport.GetMonitorPos(monitor, xpos, ypos);

    void IGlfw.GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            ((IGlfw)this).GetMonitorPos(__dsl_monitor, __dsl_xpos, __dsl_ypos);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    public static void GetMonitorPos(Ref<Monitor> monitor, Ref<int> xpos, Ref<int> ypos) =>
        DllImport.GetMonitorPos(monitor, xpos, ypos);

    Monitor** IGlfw.GetMonitors(int* count) =>
        (
            (delegate* unmanaged<int*, Monitor**>)
                nativeContext.LoadFunction("glfwGetMonitors", "glfw")
        )(count);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    public static Monitor** GetMonitors(int* count) => DllImport.GetMonitors(count);

    Ptr2D<Monitor> IGlfw.GetMonitors(Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            return (Monitor**)((IGlfw)this).GetMonitors(__dsl_count);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    public static Ptr2D<Monitor> GetMonitors(Ref<int> count) => DllImport.GetMonitors(count);

    void* IGlfw.GetMonitorUserPointer(Monitor* monitor) =>
        (
            (delegate* unmanaged<Monitor*, void*>)
                nativeContext.LoadFunction("glfwGetMonitorUserPointer", "glfw")
        )(monitor);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    public static void* GetMonitorUserPointer(Monitor* monitor) =>
        DllImport.GetMonitorUserPointer(monitor);

    Ptr IGlfw.GetMonitorUserPointer(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            return (void*)((IGlfw)this).GetMonitorUserPointer(__dsl_monitor);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    public static Ptr GetMonitorUserPointer(Ref<Monitor> monitor) =>
        DllImport.GetMonitorUserPointer(monitor);

    void IGlfw.GetMonitorWorkarea(
        Monitor* monitor,
        int* xpos,
        int* ypos,
        int* width,
        int* height
    ) =>
        (
            (delegate* unmanaged<Monitor*, int*, int*, int*, int*, void>)
                nativeContext.LoadFunction("glfwGetMonitorWorkarea", "glfw")
        )(monitor, xpos, ypos, width, height);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    public static void GetMonitorWorkarea(
        Monitor* monitor,
        int* xpos,
        int* ypos,
        int* width,
        int* height
    ) => DllImport.GetMonitorWorkarea(monitor, xpos, ypos, width, height);

    void IGlfw.GetMonitorWorkarea(
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
            ((IGlfw)this).GetMonitorWorkarea(
                __dsl_monitor,
                __dsl_xpos,
                __dsl_ypos,
                __dsl_width,
                __dsl_height
            );
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    public static void GetMonitorWorkarea(
        Ref<Monitor> monitor,
        Ref<int> xpos,
        Ref<int> ypos,
        Ref<int> width,
        Ref<int> height
    ) => DllImport.GetMonitorWorkarea(monitor, xpos, ypos, width, height);

    int IGlfw.GetMouseButton(Window* window, int button) =>
        (
            (delegate* unmanaged<Window*, int, int>)
                nativeContext.LoadFunction("glfwGetMouseButton", "glfw")
        )(window, button);

    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    public static int GetMouseButton(Window* window, int button) =>
        DllImport.GetMouseButton(window, button);

    int IGlfw.GetMouseButton(Ref<Window> window, int button)
    {
        fixed (Window* __dsl_window = window)
        {
            return (int)((IGlfw)this).GetMouseButton(__dsl_window, button);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    public static int GetMouseButton(Ref<Window> window, int button) =>
        DllImport.GetMouseButton(window, button);

    int IGlfw.GetPlatform() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("glfwGetPlatform", "glfw"))();

    [NativeFunction("glfw", EntryPoint = "glfwGetPlatform")]
    public static int GetPlatform() => DllImport.GetPlatform();

    Ptr<Monitor> IGlfw.GetPrimaryMonitor() => (Monitor*)((IGlfw)this).GetPrimaryMonitorRaw();

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    public static Ptr<Monitor> GetPrimaryMonitor() => DllImport.GetPrimaryMonitor();

    Monitor* IGlfw.GetPrimaryMonitorRaw() =>
        (
            (delegate* unmanaged<Monitor*>)
                nativeContext.LoadFunction("glfwGetPrimaryMonitor", "glfw")
        )();

    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    public static Monitor* GetPrimaryMonitorRaw() => DllImport.GetPrimaryMonitorRaw();

    delegate* unmanaged<void> IGlfw.GetProcAddress(
        [NativeTypeName("const char *")] sbyte* procname
    ) =>
        (
            (delegate* unmanaged<sbyte*, delegate* unmanaged<void>>)
                nativeContext.LoadFunction("glfwGetProcAddress", "glfw")
        )(procname);

    [return: NativeTypeName("GLFWglproc")]
    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    public static delegate* unmanaged<void> GetProcAddress(
        [NativeTypeName("const char *")] sbyte* procname
    ) => DllImport.GetProcAddress(procname);

    delegate* unmanaged<void> IGlfw.GetProcAddress(
        [NativeTypeName("const char *")] Ref<sbyte> procname
    )
    {
        fixed (sbyte* __dsl_procname = procname)
        {
            return (delegate* unmanaged<void>)((IGlfw)this).GetProcAddress(__dsl_procname);
        }
    }

    [return: NativeTypeName("GLFWglproc")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    public static delegate* unmanaged<void> GetProcAddress(
        [NativeTypeName("const char *")] Ref<sbyte> procname
    ) => DllImport.GetProcAddress(procname);

    sbyte** IGlfw.GetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] uint* count) =>
        (
            (delegate* unmanaged<uint*, sbyte**>)
                nativeContext.LoadFunction("glfwGetRequiredInstanceExtensions", "glfw")
        )(count);

    [return: NativeTypeName("const char **")]
    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    public static sbyte** GetRequiredInstanceExtensions(
        [NativeTypeName("uint32_t *")] uint* count
    ) => DllImport.GetRequiredInstanceExtensions(count);

    Ptr2D<sbyte> IGlfw.GetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] Ref<uint> count)
    {
        fixed (uint* __dsl_count = count)
        {
            return (sbyte**)((IGlfw)this).GetRequiredInstanceExtensions(__dsl_count);
        }
    }

    [return: NativeTypeName("const char **")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    public static Ptr2D<sbyte> GetRequiredInstanceExtensions(
        [NativeTypeName("uint32_t *")] Ref<uint> count
    ) => DllImport.GetRequiredInstanceExtensions(count);

    double IGlfw.GetTime() =>
        ((delegate* unmanaged<double>)nativeContext.LoadFunction("glfwGetTime", "glfw"))();

    [NativeFunction("glfw", EntryPoint = "glfwGetTime")]
    public static double GetTime() => DllImport.GetTime();

    ulong IGlfw.GetTimerFrequency() =>
        ((delegate* unmanaged<ulong>)nativeContext.LoadFunction("glfwGetTimerFrequency", "glfw"))();

    [return: NativeTypeName("uint64_t")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTimerFrequency")]
    public static ulong GetTimerFrequency() => DllImport.GetTimerFrequency();

    ulong IGlfw.GetTimerValue() =>
        ((delegate* unmanaged<ulong>)nativeContext.LoadFunction("glfwGetTimerValue", "glfw"))();

    [return: NativeTypeName("uint64_t")]
    [NativeFunction("glfw", EntryPoint = "glfwGetTimerValue")]
    public static ulong GetTimerValue() => DllImport.GetTimerValue();

    void IGlfw.GetVersion(int* major, int* minor, int* rev) =>
        (
            (delegate* unmanaged<int*, int*, int*, void>)
                nativeContext.LoadFunction("glfwGetVersion", "glfw")
        )(major, minor, rev);

    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    public static void GetVersion(int* major, int* minor, int* rev) =>
        DllImport.GetVersion(major, minor, rev);

    void IGlfw.GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev)
    {
        fixed (int* __dsl_rev = rev)
        fixed (int* __dsl_minor = minor)
        fixed (int* __dsl_major = major)
        {
            ((IGlfw)this).GetVersion(__dsl_major, __dsl_minor, __dsl_rev);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    public static void GetVersion(Ref<int> major, Ref<int> minor, Ref<int> rev) =>
        DllImport.GetVersion(major, minor, rev);

    Ptr<sbyte> IGlfw.GetVersionString() => (sbyte*)((IGlfw)this).GetVersionStringRaw();

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    public static Ptr<sbyte> GetVersionString() => DllImport.GetVersionString();

    sbyte* IGlfw.GetVersionStringRaw() =>
        ((delegate* unmanaged<sbyte*>)nativeContext.LoadFunction("glfwGetVersionString", "glfw"))();

    [return: NativeTypeName("const char *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    public static sbyte* GetVersionStringRaw() => DllImport.GetVersionStringRaw();

    Vidmode* IGlfw.GetVideoMode(Monitor* monitor) =>
        (
            (delegate* unmanaged<Monitor*, Vidmode*>)
                nativeContext.LoadFunction("glfwGetVideoMode", "glfw")
        )(monitor);

    [return: NativeTypeName("const GLFWvidmode *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    public static Vidmode* GetVideoMode(Monitor* monitor) => DllImport.GetVideoMode(monitor);

    Ptr<Vidmode> IGlfw.GetVideoMode(Ref<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            return (Vidmode*)((IGlfw)this).GetVideoMode(__dsl_monitor);
        }
    }

    [return: NativeTypeName("const GLFWvidmode *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    public static Ptr<Vidmode> GetVideoMode(Ref<Monitor> monitor) =>
        DllImport.GetVideoMode(monitor);

    Vidmode* IGlfw.GetVideoModes(Monitor* monitor, int* count) =>
        (
            (delegate* unmanaged<Monitor*, int*, Vidmode*>)
                nativeContext.LoadFunction("glfwGetVideoModes", "glfw")
        )(monitor, count);

    [return: NativeTypeName("const GLFWvidmode *")]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    public static Vidmode* GetVideoModes(Monitor* monitor, int* count) =>
        DllImport.GetVideoModes(monitor, count);

    Ptr<Vidmode> IGlfw.GetVideoModes(Ref<Monitor> monitor, Ref<int> count)
    {
        fixed (int* __dsl_count = count)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            return (Vidmode*)((IGlfw)this).GetVideoModes(__dsl_monitor, __dsl_count);
        }
    }

    [return: NativeTypeName("const GLFWvidmode *")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    public static Ptr<Vidmode> GetVideoModes(Ref<Monitor> monitor, Ref<int> count) =>
        DllImport.GetVideoModes(monitor, count);

    int IGlfw.GetWindowAttrib(Window* window, int attrib) =>
        (
            (delegate* unmanaged<Window*, int, int>)
                nativeContext.LoadFunction("glfwGetWindowAttrib", "glfw")
        )(window, attrib);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    public static int GetWindowAttrib(Window* window, int attrib) =>
        DllImport.GetWindowAttrib(window, attrib);

    int IGlfw.GetWindowAttrib(Ref<Window> window, int attrib)
    {
        fixed (Window* __dsl_window = window)
        {
            return (int)((IGlfw)this).GetWindowAttrib(__dsl_window, attrib);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    public static int GetWindowAttrib(Ref<Window> window, int attrib) =>
        DllImport.GetWindowAttrib(window, attrib);

    void IGlfw.GetWindowContentScale(Window* window, float* xscale, float* yscale) =>
        (
            (delegate* unmanaged<Window*, float*, float*, void>)
                nativeContext.LoadFunction("glfwGetWindowContentScale", "glfw")
        )(window, xscale, yscale);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    public static void GetWindowContentScale(Window* window, float* xscale, float* yscale) =>
        DllImport.GetWindowContentScale(window, xscale, yscale);

    void IGlfw.GetWindowContentScale(Ref<Window> window, Ref<float> xscale, Ref<float> yscale)
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).GetWindowContentScale(__dsl_window, __dsl_xscale, __dsl_yscale);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    public static void GetWindowContentScale(
        Ref<Window> window,
        Ref<float> xscale,
        Ref<float> yscale
    ) => DllImport.GetWindowContentScale(window, xscale, yscale);

    void IGlfw.GetWindowFrameSize(Window* window, int* left, int* top, int* right, int* bottom) =>
        (
            (delegate* unmanaged<Window*, int*, int*, int*, int*, void>)
                nativeContext.LoadFunction("glfwGetWindowFrameSize", "glfw")
        )(window, left, top, right, bottom);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    public static void GetWindowFrameSize(
        Window* window,
        int* left,
        int* top,
        int* right,
        int* bottom
    ) => DllImport.GetWindowFrameSize(window, left, top, right, bottom);

    void IGlfw.GetWindowFrameSize(
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
            ((IGlfw)this).GetWindowFrameSize(
                __dsl_window,
                __dsl_left,
                __dsl_top,
                __dsl_right,
                __dsl_bottom
            );
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    public static void GetWindowFrameSize(
        Ref<Window> window,
        Ref<int> left,
        Ref<int> top,
        Ref<int> right,
        Ref<int> bottom
    ) => DllImport.GetWindowFrameSize(window, left, top, right, bottom);

    Monitor* IGlfw.GetWindowMonitor(Window* window) =>
        (
            (delegate* unmanaged<Window*, Monitor*>)
                nativeContext.LoadFunction("glfwGetWindowMonitor", "glfw")
        )(window);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    public static Monitor* GetWindowMonitor(Window* window) => DllImport.GetWindowMonitor(window);

    Ptr<Monitor> IGlfw.GetWindowMonitor(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            return (Monitor*)((IGlfw)this).GetWindowMonitor(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    public static Ptr<Monitor> GetWindowMonitor(Ref<Window> window) =>
        DllImport.GetWindowMonitor(window);

    float IGlfw.GetWindowOpacity(Window* window) =>
        (
            (delegate* unmanaged<Window*, float>)
                nativeContext.LoadFunction("glfwGetWindowOpacity", "glfw")
        )(window);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    public static float GetWindowOpacity(Window* window) => DllImport.GetWindowOpacity(window);

    float IGlfw.GetWindowOpacity(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            return (float)((IGlfw)this).GetWindowOpacity(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    public static float GetWindowOpacity(Ref<Window> window) => DllImport.GetWindowOpacity(window);

    void IGlfw.GetWindowPos(Window* window, int* xpos, int* ypos) =>
        (
            (delegate* unmanaged<Window*, int*, int*, void>)
                nativeContext.LoadFunction("glfwGetWindowPos", "glfw")
        )(window, xpos, ypos);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    public static void GetWindowPos(Window* window, int* xpos, int* ypos) =>
        DllImport.GetWindowPos(window, xpos, ypos);

    void IGlfw.GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).GetWindowPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    public static void GetWindowPos(Ref<Window> window, Ref<int> xpos, Ref<int> ypos) =>
        DllImport.GetWindowPos(window, xpos, ypos);

    void IGlfw.GetWindowSize(Window* window, int* width, int* height) =>
        (
            (delegate* unmanaged<Window*, int*, int*, void>)
                nativeContext.LoadFunction("glfwGetWindowSize", "glfw")
        )(window, width, height);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    public static void GetWindowSize(Window* window, int* width, int* height) =>
        DllImport.GetWindowSize(window, width, height);

    void IGlfw.GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).GetWindowSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    public static void GetWindowSize(Ref<Window> window, Ref<int> width, Ref<int> height) =>
        DllImport.GetWindowSize(window, width, height);

    void* IGlfw.GetWindowUserPointer(Window* window) =>
        (
            (delegate* unmanaged<Window*, void*>)
                nativeContext.LoadFunction("glfwGetWindowUserPointer", "glfw")
        )(window);

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    public static void* GetWindowUserPointer(Window* window) =>
        DllImport.GetWindowUserPointer(window);

    Ptr IGlfw.GetWindowUserPointer(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            return (void*)((IGlfw)this).GetWindowUserPointer(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    public static Ptr GetWindowUserPointer(Ref<Window> window) =>
        DllImport.GetWindowUserPointer(window);

    void IGlfw.HideWindow(Window* window) =>
        ((delegate* unmanaged<Window*, void>)nativeContext.LoadFunction("glfwHideWindow", "glfw"))(
            window
        );

    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    public static void HideWindow(Window* window) => DllImport.HideWindow(window);

    void IGlfw.HideWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).HideWindow(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    public static void HideWindow(Ref<Window> window) => DllImport.HideWindow(window);

    void IGlfw.IconifyWindow(Window* window) =>
        (
            (delegate* unmanaged<Window*, void>)
                nativeContext.LoadFunction("glfwIconifyWindow", "glfw")
        )(window);

    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    public static void IconifyWindow(Window* window) => DllImport.IconifyWindow(window);

    void IGlfw.IconifyWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).IconifyWindow(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    public static void IconifyWindow(Ref<Window> window) => DllImport.IconifyWindow(window);

    int IGlfw.Init() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("glfwInit", "glfw"))();

    [NativeFunction("glfw", EntryPoint = "glfwInit")]
    public static int Init() => DllImport.Init();

    void IGlfw.InitAllocator([NativeTypeName("const GLFWallocator *")] Allocator* allocator) =>
        (
            (delegate* unmanaged<Allocator*, void>)
                nativeContext.LoadFunction("glfwInitAllocator", "glfw")
        )(allocator);

    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    public static void InitAllocator(
        [NativeTypeName("const GLFWallocator *")] Allocator* allocator
    ) => DllImport.InitAllocator(allocator);

    void IGlfw.InitAllocator([NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator)
    {
        fixed (Allocator* __dsl_allocator = allocator)
        {
            ((IGlfw)this).InitAllocator(__dsl_allocator);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    public static void InitAllocator(
        [NativeTypeName("const GLFWallocator *")] Ref<Allocator> allocator
    ) => DllImport.InitAllocator(allocator);

    void IGlfw.InitHint(int hint, int value) =>
        ((delegate* unmanaged<int, int, void>)nativeContext.LoadFunction("glfwInitHint", "glfw"))(
            hint,
            value
        );

    [NativeFunction("glfw", EntryPoint = "glfwInitHint")]
    public static void InitHint(int hint, int value) => DllImport.InitHint(hint, value);

    int IGlfw.JoystickIsGamepad(int jid) =>
        (
            (delegate* unmanaged<int, int>)
                nativeContext.LoadFunction("glfwJoystickIsGamepad", "glfw")
        )(jid);

    [NativeFunction("glfw", EntryPoint = "glfwJoystickIsGamepad")]
    public static int JoystickIsGamepad(int jid) => DllImport.JoystickIsGamepad(jid);

    int IGlfw.JoystickPresent(int jid) =>
        ((delegate* unmanaged<int, int>)nativeContext.LoadFunction("glfwJoystickPresent", "glfw"))(
            jid
        );

    [NativeFunction("glfw", EntryPoint = "glfwJoystickPresent")]
    public static int JoystickPresent(int jid) => DllImport.JoystickPresent(jid);

    void IGlfw.MakeContextCurrent(Window* window) =>
        (
            (delegate* unmanaged<Window*, void>)
                nativeContext.LoadFunction("glfwMakeContextCurrent", "glfw")
        )(window);

    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    public static void MakeContextCurrent(Window* window) => DllImport.MakeContextCurrent(window);

    void IGlfw.MakeContextCurrent(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).MakeContextCurrent(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    public static void MakeContextCurrent(Ref<Window> window) =>
        DllImport.MakeContextCurrent(window);

    void IGlfw.MaximizeWindow(Window* window) =>
        (
            (delegate* unmanaged<Window*, void>)
                nativeContext.LoadFunction("glfwMaximizeWindow", "glfw")
        )(window);

    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    public static void MaximizeWindow(Window* window) => DllImport.MaximizeWindow(window);

    void IGlfw.MaximizeWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).MaximizeWindow(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    public static void MaximizeWindow(Ref<Window> window) => DllImport.MaximizeWindow(window);

    int IGlfw.PlatformSupported(int platform) =>
        (
            (delegate* unmanaged<int, int>)
                nativeContext.LoadFunction("glfwPlatformSupported", "glfw")
        )(platform);

    [NativeFunction("glfw", EntryPoint = "glfwPlatformSupported")]
    public static int PlatformSupported(int platform) => DllImport.PlatformSupported(platform);

    void IGlfw.PollEvents() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwPollEvents", "glfw"))();

    [NativeFunction("glfw", EntryPoint = "glfwPollEvents")]
    public static void PollEvents() => DllImport.PollEvents();

    void IGlfw.PostEmptyEvent() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwPostEmptyEvent", "glfw"))();

    [NativeFunction("glfw", EntryPoint = "glfwPostEmptyEvent")]
    public static void PostEmptyEvent() => DllImport.PostEmptyEvent();

    int IGlfw.RawMouseMotionSupported() =>
        (
            (delegate* unmanaged<int>)
                nativeContext.LoadFunction("glfwRawMouseMotionSupported", "glfw")
        )();

    [NativeFunction("glfw", EntryPoint = "glfwRawMouseMotionSupported")]
    public static int RawMouseMotionSupported() => DllImport.RawMouseMotionSupported();

    void IGlfw.RequestWindowAttention(Window* window) =>
        (
            (delegate* unmanaged<Window*, void>)
                nativeContext.LoadFunction("glfwRequestWindowAttention", "glfw")
        )(window);

    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    public static void RequestWindowAttention(Window* window) =>
        DllImport.RequestWindowAttention(window);

    void IGlfw.RequestWindowAttention(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).RequestWindowAttention(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    public static void RequestWindowAttention(Ref<Window> window) =>
        DllImport.RequestWindowAttention(window);

    void IGlfw.RestoreWindow(Window* window) =>
        (
            (delegate* unmanaged<Window*, void>)
                nativeContext.LoadFunction("glfwRestoreWindow", "glfw")
        )(window);

    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    public static void RestoreWindow(Window* window) => DllImport.RestoreWindow(window);

    void IGlfw.RestoreWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).RestoreWindow(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    public static void RestoreWindow(Ref<Window> window) => DllImport.RestoreWindow(window);

    delegate* unmanaged<Window*, uint, void> IGlfw.SetCharCallback(
        Window* window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, uint, void>,
                delegate* unmanaged<Window*, uint, void>>)
                nativeContext.LoadFunction("glfwSetCharCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWcharfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
        Window* window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    ) => DllImport.SetCharCallback(window, callback);

    delegate* unmanaged<Window*, uint, void> IGlfw.SetCharCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, uint, void>)
                ((IGlfw)this).SetCharCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcharfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    ) => DllImport.SetCharCallback(window, callback);

    delegate* unmanaged<Window*, uint, int, void> IGlfw.SetCharModsCallback(
        Window* window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, uint, int, void>,
                delegate* unmanaged<Window*, uint, int, void>>)
                nativeContext.LoadFunction("glfwSetCharModsCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWcharmodsfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
        Window* window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    ) => DllImport.SetCharModsCallback(window, callback);

    delegate* unmanaged<Window*, uint, int, void> IGlfw.SetCharModsCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, uint, int, void>)
                ((IGlfw)this).SetCharModsCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcharmodsfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    ) => DllImport.SetCharModsCallback(window, callback);

    void IGlfw.SetClipboardString(
        Window* window,
        [NativeTypeName("const char *")] sbyte* @string
    ) =>
        (
            (delegate* unmanaged<Window*, sbyte*, void>)
                nativeContext.LoadFunction("glfwSetClipboardString", "glfw")
        )(window, @string);

    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    public static void SetClipboardString(
        Window* window,
        [NativeTypeName("const char *")] sbyte* @string
    ) => DllImport.SetClipboardString(window, @string);

    void IGlfw.SetClipboardString(
        Ref<Window> window,
        [NativeTypeName("const char *")] Ref<sbyte> @string
    )
    {
        fixed (sbyte* __dsl_string = @string)
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetClipboardString(__dsl_window, __dsl_string);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    public static void SetClipboardString(
        Ref<Window> window,
        [NativeTypeName("const char *")] Ref<sbyte> @string
    ) => DllImport.SetClipboardString(window, @string);

    void IGlfw.SetCursor(Window* window, Cursor* cursor) =>
        (
            (delegate* unmanaged<Window*, Cursor*, void>)
                nativeContext.LoadFunction("glfwSetCursor", "glfw")
        )(window, cursor);

    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    public static void SetCursor(Window* window, Cursor* cursor) =>
        DllImport.SetCursor(window, cursor);

    void IGlfw.SetCursor(Ref<Window> window, Ref<Cursor> cursor)
    {
        fixed (Cursor* __dsl_cursor = cursor)
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetCursor(__dsl_window, __dsl_cursor);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    public static void SetCursor(Ref<Window> window, Ref<Cursor> cursor) =>
        DllImport.SetCursor(window, cursor);

    delegate* unmanaged<Window*, int, void> IGlfw.SetCursorEnterCallback(
        Window* window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, int, void>,
                delegate* unmanaged<Window*, int, void>>)
                nativeContext.LoadFunction("glfwSetCursorEnterCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWcursorenterfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
        Window* window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetCursorEnterCallback(window, callback);

    delegate* unmanaged<Window*, int, void> IGlfw.SetCursorEnterCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, void>)
                ((IGlfw)this).SetCursorEnterCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcursorenterfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetCursorEnterCallback(window, callback);

    void IGlfw.SetCursorPos(Window* window, double xpos, double ypos) =>
        (
            (delegate* unmanaged<Window*, double, double, void>)
                nativeContext.LoadFunction("glfwSetCursorPos", "glfw")
        )(window, xpos, ypos);

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    public static void SetCursorPos(Window* window, double xpos, double ypos) =>
        DllImport.SetCursorPos(window, xpos, ypos);

    void IGlfw.SetCursorPos(Ref<Window> window, double xpos, double ypos)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetCursorPos(__dsl_window, xpos, ypos);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    public static void SetCursorPos(Ref<Window> window, double xpos, double ypos) =>
        DllImport.SetCursorPos(window, xpos, ypos);

    delegate* unmanaged<Window*, double, double, void> IGlfw.SetCursorPosCallback(
        Window* window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, double, double, void>,
                delegate* unmanaged<Window*, double, double, void>>)
                nativeContext.LoadFunction("glfwSetCursorPosCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWcursorposfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
        Window* window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    ) => DllImport.SetCursorPosCallback(window, callback);

    delegate* unmanaged<Window*, double, double, void> IGlfw.SetCursorPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, double, double, void>)
                ((IGlfw)this).SetCursorPosCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcursorposfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    ) => DllImport.SetCursorPosCallback(window, callback);

    delegate* unmanaged<Window*, int, sbyte**, void> IGlfw.SetDropCallback(
        Window* window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, int, sbyte**, void>,
                delegate* unmanaged<Window*, int, sbyte**, void>>)
                nativeContext.LoadFunction("glfwSetDropCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWdropfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
        Window* window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    ) => DllImport.SetDropCallback(window, callback);

    delegate* unmanaged<Window*, int, sbyte**, void> IGlfw.SetDropCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, sbyte**, void>)
                ((IGlfw)this).SetDropCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWdropfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    ) => DllImport.SetDropCallback(window, callback);

    delegate* unmanaged<int, sbyte*, void> IGlfw.SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<int, sbyte*, void>,
                delegate* unmanaged<int, sbyte*, void>>)
                nativeContext.LoadFunction("glfwSetErrorCallback", "glfw")
        )(callback);

    [return: NativeTypeName("GLFWerrorfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetErrorCallback")]
    public static delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    ) => DllImport.SetErrorCallback(callback);

    delegate* unmanaged<Window*, int, int, void> IGlfw.SetFramebufferSizeCallback(
        Window* window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, int, int, void>,
                delegate* unmanaged<Window*, int, int, void>>)
                nativeContext.LoadFunction("glfwSetFramebufferSizeCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWframebuffersizefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
        Window* window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    ) => DllImport.SetFramebufferSizeCallback(window, callback);

    delegate* unmanaged<Window*, int, int, void> IGlfw.SetFramebufferSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, int, void>)
                ((IGlfw)this).SetFramebufferSizeCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWframebuffersizefun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    ) => DllImport.SetFramebufferSizeCallback(window, callback);

    void IGlfw.SetGamma(Monitor* monitor, float gamma) =>
        (
            (delegate* unmanaged<Monitor*, float, void>)
                nativeContext.LoadFunction("glfwSetGamma", "glfw")
        )(monitor, gamma);

    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    public static void SetGamma(Monitor* monitor, float gamma) =>
        DllImport.SetGamma(monitor, gamma);

    void IGlfw.SetGamma(Ref<Monitor> monitor, float gamma)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            ((IGlfw)this).SetGamma(__dsl_monitor, gamma);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    public static void SetGamma(Ref<Monitor> monitor, float gamma) =>
        DllImport.SetGamma(monitor, gamma);

    void IGlfw.SetGammaRamp(
        Monitor* monitor,
        [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
    ) =>
        (
            (delegate* unmanaged<Monitor*, Gammaramp*, void>)
                nativeContext.LoadFunction("glfwSetGammaRamp", "glfw")
        )(monitor, ramp);

    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    public static void SetGammaRamp(
        Monitor* monitor,
        [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
    ) => DllImport.SetGammaRamp(monitor, ramp);

    void IGlfw.SetGammaRamp(
        Ref<Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
    )
    {
        fixed (Gammaramp* __dsl_ramp = ramp)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            ((IGlfw)this).SetGammaRamp(__dsl_monitor, __dsl_ramp);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    public static void SetGammaRamp(
        Ref<Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] Ref<Gammaramp> ramp
    ) => DllImport.SetGammaRamp(monitor, ramp);

    void IGlfw.SetInputMode(Window* window, int mode, int value) =>
        (
            (delegate* unmanaged<Window*, int, int, void>)
                nativeContext.LoadFunction("glfwSetInputMode", "glfw")
        )(window, mode, value);

    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    public static void SetInputMode(Window* window, int mode, int value) =>
        DllImport.SetInputMode(window, mode, value);

    void IGlfw.SetInputMode(Ref<Window> window, int mode, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetInputMode(__dsl_window, mode, value);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    public static void SetInputMode(Ref<Window> window, int mode, int value) =>
        DllImport.SetInputMode(window, mode, value);

    delegate* unmanaged<int, int, void> IGlfw.SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<int, int, void>,
                delegate* unmanaged<int, int, void>>)
                nativeContext.LoadFunction("glfwSetJoystickCallback", "glfw")
        )(callback);

    [return: NativeTypeName("GLFWjoystickfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickCallback")]
    public static delegate* unmanaged<int, int, void> SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    ) => DllImport.SetJoystickCallback(callback);

    void IGlfw.SetJoystickUserPointer(int jid, void* pointer) =>
        (
            (delegate* unmanaged<int, void*, void>)
                nativeContext.LoadFunction("glfwSetJoystickUserPointer", "glfw")
        )(jid, pointer);

    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    public static void SetJoystickUserPointer(int jid, void* pointer) =>
        DllImport.SetJoystickUserPointer(jid, pointer);

    void IGlfw.SetJoystickUserPointer(int jid, Ref pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        {
            ((IGlfw)this).SetJoystickUserPointer(jid, __dsl_pointer);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    public static void SetJoystickUserPointer(int jid, Ref pointer) =>
        DllImport.SetJoystickUserPointer(jid, pointer);

    delegate* unmanaged<Window*, int, int, int, int, void> IGlfw.SetKeyCallback(
        Window* window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, int, int, int, int, void>,
                delegate* unmanaged<Window*, int, int, int, int, void>>)
                nativeContext.LoadFunction("glfwSetKeyCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWkeyfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
        Window* window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    ) => DllImport.SetKeyCallback(window, callback);

    delegate* unmanaged<Window*, int, int, int, int, void> IGlfw.SetKeyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, int, int, int, void>)
                ((IGlfw)this).SetKeyCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWkeyfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    ) => DllImport.SetKeyCallback(window, callback);

    delegate* unmanaged<Monitor*, int, void> IGlfw.SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<Monitor*, int, void>,
                delegate* unmanaged<Monitor*, int, void>>)
                nativeContext.LoadFunction("glfwSetMonitorCallback", "glfw")
        )(callback);

    [return: NativeTypeName("GLFWmonitorfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorCallback")]
    public static delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    ) => DllImport.SetMonitorCallback(callback);

    void IGlfw.SetMonitorUserPointer(Monitor* monitor, void* pointer) =>
        (
            (delegate* unmanaged<Monitor*, void*, void>)
                nativeContext.LoadFunction("glfwSetMonitorUserPointer", "glfw")
        )(monitor, pointer);

    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    public static void SetMonitorUserPointer(Monitor* monitor, void* pointer) =>
        DllImport.SetMonitorUserPointer(monitor, pointer);

    void IGlfw.SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            ((IGlfw)this).SetMonitorUserPointer(__dsl_monitor, __dsl_pointer);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    public static void SetMonitorUserPointer(Ref<Monitor> monitor, Ref pointer) =>
        DllImport.SetMonitorUserPointer(monitor, pointer);

    delegate* unmanaged<Window*, int, int, int, void> IGlfw.SetMouseButtonCallback(
        Window* window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, int, int, int, void>,
                delegate* unmanaged<Window*, int, int, int, void>>)
                nativeContext.LoadFunction("glfwSetMouseButtonCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWmousebuttonfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
        Window* window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    ) => DllImport.SetMouseButtonCallback(window, callback);

    delegate* unmanaged<Window*, int, int, int, void> IGlfw.SetMouseButtonCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, int, int, void>)
                ((IGlfw)this).SetMouseButtonCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWmousebuttonfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    ) => DllImport.SetMouseButtonCallback(window, callback);

    delegate* unmanaged<Window*, double, double, void> IGlfw.SetScrollCallback(
        Window* window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, double, double, void>,
                delegate* unmanaged<Window*, double, double, void>>)
                nativeContext.LoadFunction("glfwSetScrollCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWscrollfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
        Window* window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    ) => DllImport.SetScrollCallback(window, callback);

    delegate* unmanaged<Window*, double, double, void> IGlfw.SetScrollCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, double, double, void>)
                ((IGlfw)this).SetScrollCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWscrollfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    ) => DllImport.SetScrollCallback(window, callback);

    void IGlfw.SetTime(double time) =>
        ((delegate* unmanaged<double, void>)nativeContext.LoadFunction("glfwSetTime", "glfw"))(
            time
        );

    [NativeFunction("glfw", EntryPoint = "glfwSetTime")]
    public static void SetTime(double time) => DllImport.SetTime(time);

    void IGlfw.SetWindowAspectRatio(Window* window, int numer, int denom) =>
        (
            (delegate* unmanaged<Window*, int, int, void>)
                nativeContext.LoadFunction("glfwSetWindowAspectRatio", "glfw")
        )(window, numer, denom);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    public static void SetWindowAspectRatio(Window* window, int numer, int denom) =>
        DllImport.SetWindowAspectRatio(window, numer, denom);

    void IGlfw.SetWindowAspectRatio(Ref<Window> window, int numer, int denom)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetWindowAspectRatio(__dsl_window, numer, denom);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    public static void SetWindowAspectRatio(Ref<Window> window, int numer, int denom) =>
        DllImport.SetWindowAspectRatio(window, numer, denom);

    void IGlfw.SetWindowAttrib(Window* window, int attrib, int value) =>
        (
            (delegate* unmanaged<Window*, int, int, void>)
                nativeContext.LoadFunction("glfwSetWindowAttrib", "glfw")
        )(window, attrib, value);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    public static void SetWindowAttrib(Window* window, int attrib, int value) =>
        DllImport.SetWindowAttrib(window, attrib, value);

    void IGlfw.SetWindowAttrib(Ref<Window> window, int attrib, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetWindowAttrib(__dsl_window, attrib, value);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    public static void SetWindowAttrib(Ref<Window> window, int attrib, int value) =>
        DllImport.SetWindowAttrib(window, attrib, value);

    delegate* unmanaged<Window*, void> IGlfw.SetWindowCloseCallback(
        Window* window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, void>,
                delegate* unmanaged<Window*, void>>)
                nativeContext.LoadFunction("glfwSetWindowCloseCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWwindowclosefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
        Window* window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    ) => DllImport.SetWindowCloseCallback(window, callback);

    delegate* unmanaged<Window*, void> IGlfw.SetWindowCloseCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, void>)
                ((IGlfw)this).SetWindowCloseCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowclosefun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    ) => DllImport.SetWindowCloseCallback(window, callback);

    delegate* unmanaged<Window*, float, float, void> IGlfw.SetWindowContentScaleCallback(
        Window* window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, float, float, void>,
                delegate* unmanaged<Window*, float, float, void>>)
                nativeContext.LoadFunction("glfwSetWindowContentScaleCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    public static delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
        Window* window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    ) => DllImport.SetWindowContentScaleCallback(window, callback);

    delegate* unmanaged<Window*, float, float, void> IGlfw.SetWindowContentScaleCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, float, float, void>)
                ((IGlfw)this).SetWindowContentScaleCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    public static delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    ) => DllImport.SetWindowContentScaleCallback(window, callback);

    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowFocusCallback(
        Window* window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, int, void>,
                delegate* unmanaged<Window*, int, void>>)
                nativeContext.LoadFunction("glfwSetWindowFocusCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWwindowfocusfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
        Window* window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetWindowFocusCallback(window, callback);

    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowFocusCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, void>)
                ((IGlfw)this).SetWindowFocusCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowfocusfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetWindowFocusCallback(window, callback);

    void IGlfw.SetWindowIcon(
        Window* window,
        int count,
        [NativeTypeName("const GLFWimage *")] Image* images
    ) =>
        (
            (delegate* unmanaged<Window*, int, Image*, void>)
                nativeContext.LoadFunction("glfwSetWindowIcon", "glfw")
        )(window, count, images);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    public static void SetWindowIcon(
        Window* window,
        int count,
        [NativeTypeName("const GLFWimage *")] Image* images
    ) => DllImport.SetWindowIcon(window, count, images);

    void IGlfw.SetWindowIcon(
        Ref<Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] Ref<Image> images
    )
    {
        fixed (Image* __dsl_images = images)
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetWindowIcon(__dsl_window, count, __dsl_images);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    public static void SetWindowIcon(
        Ref<Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] Ref<Image> images
    ) => DllImport.SetWindowIcon(window, count, images);

    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowIconifyCallback(
        Window* window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, int, void>,
                delegate* unmanaged<Window*, int, void>>)
                nativeContext.LoadFunction("glfwSetWindowIconifyCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWwindowiconifyfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
        Window* window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetWindowIconifyCallback(window, callback);

    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowIconifyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, void>)
                ((IGlfw)this).SetWindowIconifyCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowiconifyfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetWindowIconifyCallback(window, callback);

    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowMaximizeCallback(
        Window* window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, int, void>,
                delegate* unmanaged<Window*, int, void>>)
                nativeContext.LoadFunction("glfwSetWindowMaximizeCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWwindowmaximizefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
        Window* window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetWindowMaximizeCallback(window, callback);

    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowMaximizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, void>)
                ((IGlfw)this).SetWindowMaximizeCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowmaximizefun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    ) => DllImport.SetWindowMaximizeCallback(window, callback);

    void IGlfw.SetWindowMonitor(
        Window* window,
        Monitor* monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    ) =>
        (
            (delegate* unmanaged<Window*, Monitor*, int, int, int, int, int, void>)
                nativeContext.LoadFunction("glfwSetWindowMonitor", "glfw")
        )(window, monitor, xpos, ypos, width, height, refreshRate);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    public static void SetWindowMonitor(
        Window* window,
        Monitor* monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    ) => DllImport.SetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);

    void IGlfw.SetWindowMonitor(
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
            ((IGlfw)this).SetWindowMonitor(
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

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    public static void SetWindowMonitor(
        Ref<Window> window,
        Ref<Monitor> monitor,
        int xpos,
        int ypos,
        int width,
        int height,
        int refreshRate
    ) => DllImport.SetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);

    void IGlfw.SetWindowOpacity(Window* window, float opacity) =>
        (
            (delegate* unmanaged<Window*, float, void>)
                nativeContext.LoadFunction("glfwSetWindowOpacity", "glfw")
        )(window, opacity);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    public static void SetWindowOpacity(Window* window, float opacity) =>
        DllImport.SetWindowOpacity(window, opacity);

    void IGlfw.SetWindowOpacity(Ref<Window> window, float opacity)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetWindowOpacity(__dsl_window, opacity);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    public static void SetWindowOpacity(Ref<Window> window, float opacity) =>
        DllImport.SetWindowOpacity(window, opacity);

    void IGlfw.SetWindowPos(Window* window, int xpos, int ypos) =>
        (
            (delegate* unmanaged<Window*, int, int, void>)
                nativeContext.LoadFunction("glfwSetWindowPos", "glfw")
        )(window, xpos, ypos);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    public static void SetWindowPos(Window* window, int xpos, int ypos) =>
        DllImport.SetWindowPos(window, xpos, ypos);

    void IGlfw.SetWindowPos(Ref<Window> window, int xpos, int ypos)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetWindowPos(__dsl_window, xpos, ypos);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    public static void SetWindowPos(Ref<Window> window, int xpos, int ypos) =>
        DllImport.SetWindowPos(window, xpos, ypos);

    delegate* unmanaged<Window*, int, int, void> IGlfw.SetWindowPosCallback(
        Window* window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, int, int, void>,
                delegate* unmanaged<Window*, int, int, void>>)
                nativeContext.LoadFunction("glfwSetWindowPosCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWwindowposfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
        Window* window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    ) => DllImport.SetWindowPosCallback(window, callback);

    delegate* unmanaged<Window*, int, int, void> IGlfw.SetWindowPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, int, void>)
                ((IGlfw)this).SetWindowPosCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowposfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    ) => DllImport.SetWindowPosCallback(window, callback);

    delegate* unmanaged<Window*, void> IGlfw.SetWindowRefreshCallback(
        Window* window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, void>,
                delegate* unmanaged<Window*, void>>)
                nativeContext.LoadFunction("glfwSetWindowRefreshCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWwindowrefreshfun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
        Window* window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    ) => DllImport.SetWindowRefreshCallback(window, callback);

    delegate* unmanaged<Window*, void> IGlfw.SetWindowRefreshCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, void>)
                ((IGlfw)this).SetWindowRefreshCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowrefreshfun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    ) => DllImport.SetWindowRefreshCallback(window, callback);

    void IGlfw.SetWindowShouldClose(Window* window, int value) =>
        (
            (delegate* unmanaged<Window*, int, void>)
                nativeContext.LoadFunction("glfwSetWindowShouldClose", "glfw")
        )(window, value);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    public static void SetWindowShouldClose(Window* window, int value) =>
        DllImport.SetWindowShouldClose(window, value);

    void IGlfw.SetWindowShouldClose(Ref<Window> window, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetWindowShouldClose(__dsl_window, value);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    public static void SetWindowShouldClose(Ref<Window> window, int value) =>
        DllImport.SetWindowShouldClose(window, value);

    void IGlfw.SetWindowSize(Window* window, int width, int height) =>
        (
            (delegate* unmanaged<Window*, int, int, void>)
                nativeContext.LoadFunction("glfwSetWindowSize", "glfw")
        )(window, width, height);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    public static void SetWindowSize(Window* window, int width, int height) =>
        DllImport.SetWindowSize(window, width, height);

    void IGlfw.SetWindowSize(Ref<Window> window, int width, int height)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetWindowSize(__dsl_window, width, height);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    public static void SetWindowSize(Ref<Window> window, int width, int height) =>
        DllImport.SetWindowSize(window, width, height);

    delegate* unmanaged<Window*, int, int, void> IGlfw.SetWindowSizeCallback(
        Window* window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                Window*,
                delegate* unmanaged<Window*, int, int, void>,
                delegate* unmanaged<Window*, int, int, void>>)
                nativeContext.LoadFunction("glfwSetWindowSizeCallback", "glfw")
        )(window, callback);

    [return: NativeTypeName("GLFWwindowsizefun")]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
        Window* window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    ) => DllImport.SetWindowSizeCallback(window, callback);

    delegate* unmanaged<Window*, int, int, void> IGlfw.SetWindowSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            return (delegate* unmanaged<Window*, int, int, void>)
                ((IGlfw)this).SetWindowSizeCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowsizefun")]
    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
        Ref<Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    ) => DllImport.SetWindowSizeCallback(window, callback);

    void IGlfw.SetWindowSizeLimits(
        Window* window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    ) =>
        (
            (delegate* unmanaged<Window*, int, int, int, int, void>)
                nativeContext.LoadFunction("glfwSetWindowSizeLimits", "glfw")
        )(window, minwidth, minheight, maxwidth, maxheight);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    public static void SetWindowSizeLimits(
        Window* window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    ) => DllImport.SetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);

    void IGlfw.SetWindowSizeLimits(
        Ref<Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    )
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetWindowSizeLimits(
                __dsl_window,
                minwidth,
                minheight,
                maxwidth,
                maxheight
            );
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    public static void SetWindowSizeLimits(
        Ref<Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    ) => DllImport.SetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);

    void IGlfw.SetWindowTitle(Window* window, [NativeTypeName("const char *")] sbyte* title) =>
        (
            (delegate* unmanaged<Window*, sbyte*, void>)
                nativeContext.LoadFunction("glfwSetWindowTitle", "glfw")
        )(window, title);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    public static void SetWindowTitle(
        Window* window,
        [NativeTypeName("const char *")] sbyte* title
    ) => DllImport.SetWindowTitle(window, title);

    void IGlfw.SetWindowTitle(Ref<Window> window, [NativeTypeName("const char *")] Ref<sbyte> title)
    {
        fixed (sbyte* __dsl_title = title)
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetWindowTitle(__dsl_window, __dsl_title);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    public static void SetWindowTitle(
        Ref<Window> window,
        [NativeTypeName("const char *")] Ref<sbyte> title
    ) => DllImport.SetWindowTitle(window, title);

    void IGlfw.SetWindowUserPointer(Window* window, void* pointer) =>
        (
            (delegate* unmanaged<Window*, void*, void>)
                nativeContext.LoadFunction("glfwSetWindowUserPointer", "glfw")
        )(window, pointer);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    public static void SetWindowUserPointer(Window* window, void* pointer) =>
        DllImport.SetWindowUserPointer(window, pointer);

    void IGlfw.SetWindowUserPointer(Ref<Window> window, Ref pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SetWindowUserPointer(__dsl_window, __dsl_pointer);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    public static void SetWindowUserPointer(Ref<Window> window, Ref pointer) =>
        DllImport.SetWindowUserPointer(window, pointer);

    void IGlfw.ShowWindow(Window* window) =>
        ((delegate* unmanaged<Window*, void>)nativeContext.LoadFunction("glfwShowWindow", "glfw"))(
            window
        );

    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    public static void ShowWindow(Window* window) => DllImport.ShowWindow(window);

    void IGlfw.ShowWindow(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).ShowWindow(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    public static void ShowWindow(Ref<Window> window) => DllImport.ShowWindow(window);

    void IGlfw.SwapBuffers(Window* window) =>
        ((delegate* unmanaged<Window*, void>)nativeContext.LoadFunction("glfwSwapBuffers", "glfw"))(
            window
        );

    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    public static void SwapBuffers(Window* window) => DllImport.SwapBuffers(window);

    void IGlfw.SwapBuffers(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            ((IGlfw)this).SwapBuffers(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    public static void SwapBuffers(Ref<Window> window) => DllImport.SwapBuffers(window);

    void IGlfw.SwapInterval(int interval) =>
        ((delegate* unmanaged<int, void>)nativeContext.LoadFunction("glfwSwapInterval", "glfw"))(
            interval
        );

    [NativeFunction("glfw", EntryPoint = "glfwSwapInterval")]
    public static void SwapInterval(int interval) => DllImport.SwapInterval(interval);

    void IGlfw.Terminate() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwTerminate", "glfw"))();

    [NativeFunction("glfw", EntryPoint = "glfwTerminate")]
    public static void Terminate() => DllImport.Terminate();

    int IGlfw.UpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string) =>
        (
            (delegate* unmanaged<sbyte*, int>)
                nativeContext.LoadFunction("glfwUpdateGamepadMappings", "glfw")
        )(@string);

    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    public static int UpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string) =>
        DllImport.UpdateGamepadMappings(@string);

    int IGlfw.UpdateGamepadMappings([NativeTypeName("const char *")] Ref<sbyte> @string)
    {
        fixed (sbyte* __dsl_string = @string)
        {
            return (int)((IGlfw)this).UpdateGamepadMappings(__dsl_string);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    public static int UpdateGamepadMappings([NativeTypeName("const char *")] Ref<sbyte> @string) =>
        DllImport.UpdateGamepadMappings(@string);

    int IGlfw.VulkanSupported() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("glfwVulkanSupported", "glfw"))();

    [NativeFunction("glfw", EntryPoint = "glfwVulkanSupported")]
    public static int VulkanSupported() => DllImport.VulkanSupported();

    void IGlfw.WaitEvents() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwWaitEvents", "glfw"))();

    [NativeFunction("glfw", EntryPoint = "glfwWaitEvents")]
    public static void WaitEvents() => DllImport.WaitEvents();

    void IGlfw.WaitEventsTimeout(double timeout) =>
        (
            (delegate* unmanaged<double, void>)
                nativeContext.LoadFunction("glfwWaitEventsTimeout", "glfw")
        )(timeout);

    [NativeFunction("glfw", EntryPoint = "glfwWaitEventsTimeout")]
    public static void WaitEventsTimeout(double timeout) => DllImport.WaitEventsTimeout(timeout);

    void IGlfw.WindowHint(int hint, int value) =>
        ((delegate* unmanaged<int, int, void>)nativeContext.LoadFunction("glfwWindowHint", "glfw"))(
            hint,
            value
        );

    [NativeFunction("glfw", EntryPoint = "glfwWindowHint")]
    public static void WindowHint(int hint, int value) => DllImport.WindowHint(hint, value);

    void IGlfw.WindowHintString(int hint, [NativeTypeName("const char *")] sbyte* value) =>
        (
            (delegate* unmanaged<int, sbyte*, void>)
                nativeContext.LoadFunction("glfwWindowHintString", "glfw")
        )(hint, value);

    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    public static void WindowHintString(int hint, [NativeTypeName("const char *")] sbyte* value) =>
        DllImport.WindowHintString(hint, value);

    void IGlfw.WindowHintString(int hint, [NativeTypeName("const char *")] Ref<sbyte> value)
    {
        fixed (sbyte* __dsl_value = value)
        {
            ((IGlfw)this).WindowHintString(hint, __dsl_value);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    public static void WindowHintString(
        int hint,
        [NativeTypeName("const char *")] Ref<sbyte> value
    ) => DllImport.WindowHintString(hint, value);

    int IGlfw.WindowShouldClose(Window* window) =>
        (
            (delegate* unmanaged<Window*, int>)
                nativeContext.LoadFunction("glfwWindowShouldClose", "glfw")
        )(window);

    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    public static int WindowShouldClose(Window* window) => DllImport.WindowShouldClose(window);

    int IGlfw.WindowShouldClose(Ref<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            return (int)((IGlfw)this).WindowShouldClose(__dsl_window);
        }
    }

    [Transformed]
    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    public static int WindowShouldClose(Ref<Window> window) => DllImport.WindowShouldClose(window);
}
