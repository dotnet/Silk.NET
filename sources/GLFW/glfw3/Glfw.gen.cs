// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Silk.NET.GLFW;

public unsafe partial class Glfw : IGlfw, IGlfw.Static
{
    public partial class DllImport : IGlfw.Static
    {
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
        public static Mut<Cursor> CreateCursor(
            [NativeTypeName("const GLFWimage *")] Ptr<Image> image,
            int xhot,
            int yhot
        )
        {
            fixed (Image* __dsl_image = image)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateCursor")]
                static extern Cursor* __DSL_glfwCreateCursor(
                    [NativeTypeName("const GLFWimage *")] Image* image,
                    int xhot,
                    int yhot
                );
                return __DSL_glfwCreateCursor(__dsl_image, xhot, yhot);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
        public static Mut<Cursor> CreateStandardCursor(int shape)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateStandardCursor")]
            static extern Cursor* __DSL_glfwCreateStandardCursor(int shape);
            return __DSL_glfwCreateStandardCursor(shape);
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
        public static Mut<Window> CreateWindow(
            int width,
            int height,
            [NativeTypeName("const char *")] Ptr<sbyte> title,
            Mut<Monitor> monitor,
            Mut<Window> share
        )
        {
            fixed (Window* __dsl_share = share)
            fixed (Monitor* __dsl_monitor = monitor)
            fixed (sbyte* __dsl_title = title)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateWindow")]
                static extern Window* __DSL_glfwCreateWindow(
                    int width,
                    int height,
                    [NativeTypeName("const char *")] sbyte* title,
                    Monitor* monitor,
                    Window* share
                );
                return __DSL_glfwCreateWindow(
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

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
        public static void DestroyCursor(Mut<Cursor> cursor)
        {
            fixed (Cursor* __dsl_cursor = cursor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyCursor")]
                static extern void __DSL_glfwDestroyCursor(Cursor* cursor);
                __DSL_glfwDestroyCursor(__dsl_cursor);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
        public static void DestroyWindow(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyWindow")]
                static extern void __DSL_glfwDestroyWindow(Window* window);
                __DSL_glfwDestroyWindow(__dsl_window);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
        public static int ExtensionSupported([NativeTypeName("const char *")] Ptr<sbyte> extension)
        {
            fixed (sbyte* __dsl_extension = extension)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwExtensionSupported")]
                static extern int __DSL_glfwExtensionSupported(
                    [NativeTypeName("const char *")] sbyte* extension
                );
                return __DSL_glfwExtensionSupported(__dsl_extension);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
        public static void FocusWindow(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwFocusWindow")]
                static extern void __DSL_glfwFocusWindow(Window* window);
                __DSL_glfwFocusWindow(__dsl_window);
            }
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
        public static Ptr<sbyte> GetClipboardString(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetClipboardString")]
                [return: NativeTypeName("const char *")]
                static extern sbyte* __DSL_glfwGetClipboardString(Window* window);
                return __DSL_glfwGetClipboardString(__dsl_window);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
        public static Mut<Window> GetCurrentContext()
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCurrentContext")]
            static extern Window* __DSL_glfwGetCurrentContext();
            return __DSL_glfwGetCurrentContext();
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
        public static void GetCursorPos(Mut<Window> window, Mut<double> xpos, Mut<double> ypos)
        {
            fixed (double* __dsl_ypos = ypos)
            fixed (double* __dsl_xpos = xpos)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCursorPos")]
                static extern void __DSL_glfwGetCursorPos(
                    Window* window,
                    double* xpos,
                    double* ypos
                );
                __DSL_glfwGetCursorPos(__dsl_window, __dsl_xpos, __dsl_ypos);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetError")]
        public static int GetError([NativeTypeName("const char **")] PtrPtr<sbyte> description)
        {
            fixed (sbyte** __dsl_description = description)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetError")]
                static extern int __DSL_glfwGetError(
                    [NativeTypeName("const char **")] sbyte** description
                );
                return __DSL_glfwGetError(__dsl_description);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
        public static void GetFramebufferSize(Mut<Window> window, Mut<int> width, Mut<int> height)
        {
            fixed (int* __dsl_height = height)
            fixed (int* __dsl_width = width)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetFramebufferSize")]
                static extern void __DSL_glfwGetFramebufferSize(
                    Window* window,
                    int* width,
                    int* height
                );
                __DSL_glfwGetFramebufferSize(__dsl_window, __dsl_width, __dsl_height);
            }
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
        public static Ptr<sbyte> GetGamepadName(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadName")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetGamepadName(int jid);
            return __DSL_glfwGetGamepadName(jid);
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
        public static int GetGamepadState(int jid, Mut<Gamepadstate> state)
        {
            fixed (Gamepadstate* __dsl_state = state)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadState")]
                static extern int __DSL_glfwGetGamepadState(int jid, Gamepadstate* state);
                return __DSL_glfwGetGamepadState(jid, __dsl_state);
            }
        }

        [return: NativeTypeName("const GLFWgammaramp *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
        public static Ptr<Gammaramp> GetGammaRamp(Mut<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGammaRamp")]
                [return: NativeTypeName("const GLFWgammaramp *")]
                static extern Gammaramp* __DSL_glfwGetGammaRamp(Monitor* monitor);
                return __DSL_glfwGetGammaRamp(__dsl_monitor);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
        public static int GetInputMode(Mut<Window> window, int mode)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetInputMode")]
                static extern int __DSL_glfwGetInputMode(Window* window, int mode);
                return __DSL_glfwGetInputMode(__dsl_window, mode);
            }
        }

        [return: NativeTypeName("const float *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
        public static Ptr<float> GetJoystickAxes(int jid, Mut<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickAxes")]
                [return: NativeTypeName("const float *")]
                static extern float* __DSL_glfwGetJoystickAxes(int jid, int* count);
                return __DSL_glfwGetJoystickAxes(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const unsigned char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
        public static Ptr<byte> GetJoystickButtons(int jid, Mut<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickButtons")]
                [return: NativeTypeName("const unsigned char *")]
                static extern byte* __DSL_glfwGetJoystickButtons(int jid, int* count);
                return __DSL_glfwGetJoystickButtons(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
        public static Ptr<sbyte> GetJoystickGuid(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickGUID")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetJoystickGUID(int jid);
            return __DSL_glfwGetJoystickGUID(jid);
        }

        [return: NativeTypeName("const unsigned char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
        public static Ptr<byte> GetJoystickHats(int jid, Mut<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickHats")]
                [return: NativeTypeName("const unsigned char *")]
                static extern byte* __DSL_glfwGetJoystickHats(int jid, int* count);
                return __DSL_glfwGetJoystickHats(jid, __dsl_count);
            }
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
        public static Ptr<sbyte> GetJoystickName(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickName")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetJoystickName(int jid);
            return __DSL_glfwGetJoystickName(jid);
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
        public static Mut GetJoystickUserPointer(int jid)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickUserPointer")]
            static extern void* __DSL_glfwGetJoystickUserPointer(int jid);
            return __DSL_glfwGetJoystickUserPointer(jid);
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
        public static int GetKey(Mut<Window> window, int key)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKey")]
                static extern int __DSL_glfwGetKey(Window* window, int key);
                return __DSL_glfwGetKey(__dsl_window, key);
            }
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
        public static Ptr<sbyte> GetKeyName(int key, int scancode)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKeyName")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetKeyName(int key, int scancode);
            return __DSL_glfwGetKeyName(key, scancode);
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKeyScancode")]
        public static extern int GetKeyScancode(int key);

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
        public static void GetMonitorContentScale(
            Mut<Monitor> monitor,
            Mut<float> xscale,
            Mut<float> yscale
        )
        {
            fixed (float* __dsl_yscale = yscale)
            fixed (float* __dsl_xscale = xscale)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorContentScale")]
                static extern void __DSL_glfwGetMonitorContentScale(
                    Monitor* monitor,
                    float* xscale,
                    float* yscale
                );
                __DSL_glfwGetMonitorContentScale(__dsl_monitor, __dsl_xscale, __dsl_yscale);
            }
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
        public static Ptr<sbyte> GetMonitorName(Mut<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorName")]
                [return: NativeTypeName("const char *")]
                static extern sbyte* __DSL_glfwGetMonitorName(Monitor* monitor);
                return __DSL_glfwGetMonitorName(__dsl_monitor);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
        public static void GetMonitorPhysicalSize(
            Mut<Monitor> monitor,
            Mut<int> widthMM,
            Mut<int> heightMM
        )
        {
            fixed (int* __dsl_heightMM = heightMM)
            fixed (int* __dsl_widthMM = widthMM)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPhysicalSize")]
                static extern void __DSL_glfwGetMonitorPhysicalSize(
                    Monitor* monitor,
                    int* widthMM,
                    int* heightMM
                );
                __DSL_glfwGetMonitorPhysicalSize(__dsl_monitor, __dsl_widthMM, __dsl_heightMM);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
        public static void GetMonitorPos(Mut<Monitor> monitor, Mut<int> xpos, Mut<int> ypos)
        {
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPos")]
                static extern void __DSL_glfwGetMonitorPos(Monitor* monitor, int* xpos, int* ypos);
                __DSL_glfwGetMonitorPos(__dsl_monitor, __dsl_xpos, __dsl_ypos);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
        public static MutMut<Monitor> GetMonitors(Mut<int> count)
        {
            fixed (int* __dsl_count = count)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitors")]
                static extern Monitor** __DSL_glfwGetMonitors(int* count);
                return __DSL_glfwGetMonitors(__dsl_count);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
        public static Mut GetMonitorUserPointer(Mut<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorUserPointer")]
                static extern void* __DSL_glfwGetMonitorUserPointer(Monitor* monitor);
                return __DSL_glfwGetMonitorUserPointer(__dsl_monitor);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
        public static void GetMonitorWorkarea(
            Mut<Monitor> monitor,
            Mut<int> xpos,
            Mut<int> ypos,
            Mut<int> width,
            Mut<int> height
        )
        {
            fixed (int* __dsl_height = height)
            fixed (int* __dsl_width = width)
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorWorkarea")]
                static extern void __DSL_glfwGetMonitorWorkarea(
                    Monitor* monitor,
                    int* xpos,
                    int* ypos,
                    int* width,
                    int* height
                );
                __DSL_glfwGetMonitorWorkarea(
                    __dsl_monitor,
                    __dsl_xpos,
                    __dsl_ypos,
                    __dsl_width,
                    __dsl_height
                );
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
        public static int GetMouseButton(Mut<Window> window, int button)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMouseButton")]
                static extern int __DSL_glfwGetMouseButton(Window* window, int button);
                return __DSL_glfwGetMouseButton(__dsl_window, button);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetPlatform")]
        public static extern int GetPlatform();

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
        public static Mut<Monitor> GetPrimaryMonitor()
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetPrimaryMonitor")]
            static extern Monitor* __DSL_glfwGetPrimaryMonitor();
            return __DSL_glfwGetPrimaryMonitor();
        }

        [return: NativeTypeName("GLFWglproc")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
        public static delegate* unmanaged<void> GetProcAddress(
            [NativeTypeName("const char *")] Ptr<sbyte> procname
        )
        {
            fixed (sbyte* __dsl_procname = procname)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetProcAddress")]
                [return: NativeTypeName("GLFWglproc")]
                static extern delegate* unmanaged<void> __DSL_glfwGetProcAddress(
                    [NativeTypeName("const char *")] sbyte* procname
                );
                return __DSL_glfwGetProcAddress(__dsl_procname);
            }
        }

        [return: NativeTypeName("const char **")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
        public static PtrPtr<sbyte> GetRequiredInstanceExtensions(
            [NativeTypeName("uint32_t *")] Mut<uint> count
        )
        {
            fixed (uint* __dsl_count = count)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwGetRequiredInstanceExtensions"
                )]
                [return: NativeTypeName("const char **")]
                static extern sbyte** __DSL_glfwGetRequiredInstanceExtensions(
                    [NativeTypeName("uint32_t *")] uint* count
                );
                return __DSL_glfwGetRequiredInstanceExtensions(__dsl_count);
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

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
        public static void GetVersion(Mut<int> major, Mut<int> minor, Mut<int> rev)
        {
            fixed (int* __dsl_rev = rev)
            fixed (int* __dsl_minor = minor)
            fixed (int* __dsl_major = major)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersion")]
                static extern void __DSL_glfwGetVersion(int* major, int* minor, int* rev);
                __DSL_glfwGetVersion(__dsl_major, __dsl_minor, __dsl_rev);
            }
        }

        [return: NativeTypeName("const char *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
        public static Ptr<sbyte> GetVersionString()
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersionString")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetVersionString();
            return __DSL_glfwGetVersionString();
        }

        [return: NativeTypeName("const GLFWvidmode *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
        public static Ptr<Vidmode> GetVideoMode(Mut<Monitor> monitor)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoMode")]
                [return: NativeTypeName("const GLFWvidmode *")]
                static extern Vidmode* __DSL_glfwGetVideoMode(Monitor* monitor);
                return __DSL_glfwGetVideoMode(__dsl_monitor);
            }
        }

        [return: NativeTypeName("const GLFWvidmode *")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
        public static Ptr<Vidmode> GetVideoModes(Mut<Monitor> monitor, Mut<int> count)
        {
            fixed (int* __dsl_count = count)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoModes")]
                [return: NativeTypeName("const GLFWvidmode *")]
                static extern Vidmode* __DSL_glfwGetVideoModes(Monitor* monitor, int* count);
                return __DSL_glfwGetVideoModes(__dsl_monitor, __dsl_count);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
        public static int GetWindowAttrib(Mut<Window> window, int attrib)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowAttrib")]
                static extern int __DSL_glfwGetWindowAttrib(Window* window, int attrib);
                return __DSL_glfwGetWindowAttrib(__dsl_window, attrib);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
        public static void GetWindowContentScale(
            Mut<Window> window,
            Mut<float> xscale,
            Mut<float> yscale
        )
        {
            fixed (float* __dsl_yscale = yscale)
            fixed (float* __dsl_xscale = xscale)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowContentScale")]
                static extern void __DSL_glfwGetWindowContentScale(
                    Window* window,
                    float* xscale,
                    float* yscale
                );
                __DSL_glfwGetWindowContentScale(__dsl_window, __dsl_xscale, __dsl_yscale);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
        public static void GetWindowFrameSize(
            Mut<Window> window,
            Mut<int> left,
            Mut<int> top,
            Mut<int> right,
            Mut<int> bottom
        )
        {
            fixed (int* __dsl_bottom = bottom)
            fixed (int* __dsl_right = right)
            fixed (int* __dsl_top = top)
            fixed (int* __dsl_left = left)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowFrameSize")]
                static extern void __DSL_glfwGetWindowFrameSize(
                    Window* window,
                    int* left,
                    int* top,
                    int* right,
                    int* bottom
                );
                __DSL_glfwGetWindowFrameSize(
                    __dsl_window,
                    __dsl_left,
                    __dsl_top,
                    __dsl_right,
                    __dsl_bottom
                );
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
        public static Mut<Monitor> GetWindowMonitor(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowMonitor")]
                static extern Monitor* __DSL_glfwGetWindowMonitor(Window* window);
                return __DSL_glfwGetWindowMonitor(__dsl_window);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
        public static float GetWindowOpacity(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowOpacity")]
                static extern float __DSL_glfwGetWindowOpacity(Window* window);
                return __DSL_glfwGetWindowOpacity(__dsl_window);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
        public static void GetWindowPos(Mut<Window> window, Mut<int> xpos, Mut<int> ypos)
        {
            fixed (int* __dsl_ypos = ypos)
            fixed (int* __dsl_xpos = xpos)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowPos")]
                static extern void __DSL_glfwGetWindowPos(Window* window, int* xpos, int* ypos);
                __DSL_glfwGetWindowPos(__dsl_window, __dsl_xpos, __dsl_ypos);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
        public static void GetWindowSize(Mut<Window> window, Mut<int> width, Mut<int> height)
        {
            fixed (int* __dsl_height = height)
            fixed (int* __dsl_width = width)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowSize")]
                static extern void __DSL_glfwGetWindowSize(Window* window, int* width, int* height);
                __DSL_glfwGetWindowSize(__dsl_window, __dsl_width, __dsl_height);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
        public static Mut GetWindowUserPointer(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowUserPointer")]
                static extern void* __DSL_glfwGetWindowUserPointer(Window* window);
                return __DSL_glfwGetWindowUserPointer(__dsl_window);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
        public static void HideWindow(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwHideWindow")]
                static extern void __DSL_glfwHideWindow(Window* window);
                __DSL_glfwHideWindow(__dsl_window);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
        public static void IconifyWindow(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwIconifyWindow")]
                static extern void __DSL_glfwIconifyWindow(Window* window);
                __DSL_glfwIconifyWindow(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInit")]
        public static extern int Init();

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
        public static void InitAllocator(
            [NativeTypeName("const GLFWallocator *")] Ptr<Allocator> allocator
        )
        {
            fixed (Allocator* __dsl_allocator = allocator)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInitAllocator")]
                static extern void __DSL_glfwInitAllocator(
                    [NativeTypeName("const GLFWallocator *")] Allocator* allocator
                );
                __DSL_glfwInitAllocator(__dsl_allocator);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInitHint")]
        public static extern void InitHint(int hint, int value);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwJoystickIsGamepad")]
        public static extern int JoystickIsGamepad(int jid);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwJoystickPresent")]
        public static extern int JoystickPresent(int jid);

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
        public static void MakeContextCurrent(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMakeContextCurrent")]
                static extern void __DSL_glfwMakeContextCurrent(Window* window);
                __DSL_glfwMakeContextCurrent(__dsl_window);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
        public static void MaximizeWindow(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMaximizeWindow")]
                static extern void __DSL_glfwMaximizeWindow(Window* window);
                __DSL_glfwMaximizeWindow(__dsl_window);
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

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
        public static void RequestWindowAttention(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRequestWindowAttention")]
                static extern void __DSL_glfwRequestWindowAttention(Window* window);
                __DSL_glfwRequestWindowAttention(__dsl_window);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
        public static void RestoreWindow(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRestoreWindow")]
                static extern void __DSL_glfwRestoreWindow(Window* window);
                __DSL_glfwRestoreWindow(__dsl_window);
            }
        }

        [return: NativeTypeName("GLFWcharfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
        public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharCallback")]
                [return: NativeTypeName("GLFWcharfun")]
                static extern delegate* unmanaged<Window*, uint, void> __DSL_glfwSetCharCallback(
                    Window* window,
                    [NativeTypeName("GLFWcharfun")]
                        delegate* unmanaged<Window*, uint, void> callback
                );
                return __DSL_glfwSetCharCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWcharmodsfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
        public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWcharmodsfun")]
                delegate* unmanaged<Window*, uint, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharModsCallback")]
                [return: NativeTypeName("GLFWcharmodsfun")]
                static extern delegate* unmanaged<
                    Window*,
                    uint,
                    int,
                    void> __DSL_glfwSetCharModsCallback(
                    Window* window,
                    [NativeTypeName("GLFWcharmodsfun")]
                        delegate* unmanaged<Window*, uint, int, void> callback
                );
                return __DSL_glfwSetCharModsCallback(__dsl_window, callback);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
        public static void SetClipboardString(
            Mut<Window> window,
            [NativeTypeName("const char *")] Ptr<sbyte> @string
        )
        {
            fixed (sbyte* __dsl_string = @string)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetClipboardString")]
                static extern void __DSL_glfwSetClipboardString(
                    Window* window,
                    [NativeTypeName("const char *")] sbyte* @string
                );
                __DSL_glfwSetClipboardString(__dsl_window, __dsl_string);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
        public static void SetCursor(Mut<Window> window, Mut<Cursor> cursor)
        {
            fixed (Cursor* __dsl_cursor = cursor)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursor")]
                static extern void __DSL_glfwSetCursor(Window* window, Cursor* cursor);
                __DSL_glfwSetCursor(__dsl_window, __dsl_cursor);
            }
        }

        [return: NativeTypeName("GLFWcursorenterfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
        public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorEnterCallback")]
                [return: NativeTypeName("GLFWcursorenterfun")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    void> __DSL_glfwSetCursorEnterCallback(
                    Window* window,
                    [NativeTypeName("GLFWcursorenterfun")]
                        delegate* unmanaged<Window*, int, void> callback
                );
                return __DSL_glfwSetCursorEnterCallback(__dsl_window, callback);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
        public static void SetCursorPos(Mut<Window> window, double xpos, double ypos)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPos")]
                static extern void __DSL_glfwSetCursorPos(Window* window, double xpos, double ypos);
                __DSL_glfwSetCursorPos(__dsl_window, xpos, ypos);
            }
        }

        [return: NativeTypeName("GLFWcursorposfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
        public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWcursorposfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPosCallback")]
                [return: NativeTypeName("GLFWcursorposfun")]
                static extern delegate* unmanaged<
                    Window*,
                    double,
                    double,
                    void> __DSL_glfwSetCursorPosCallback(
                    Window* window,
                    [NativeTypeName("GLFWcursorposfun")]
                        delegate* unmanaged<Window*, double, double, void> callback
                );
                return __DSL_glfwSetCursorPosCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWdropfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
        public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWdropfun")]
                delegate* unmanaged<Window*, int, sbyte**, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetDropCallback")]
                [return: NativeTypeName("GLFWdropfun")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    sbyte**,
                    void> __DSL_glfwSetDropCallback(
                    Window* window,
                    [NativeTypeName("GLFWdropfun")]
                        delegate* unmanaged<Window*, int, sbyte**, void> callback
                );
                return __DSL_glfwSetDropCallback(__dsl_window, callback);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetErrorCallback")]
        [return: NativeTypeName("GLFWerrorfun")]
        public static extern delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
            [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
        );

        [return: NativeTypeName("GLFWframebuffersizefun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWframebuffersizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwSetFramebufferSizeCallback"
                )]
                [return: NativeTypeName("GLFWframebuffersizefun")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    int,
                    void> __DSL_glfwSetFramebufferSizeCallback(
                    Window* window,
                    [NativeTypeName("GLFWframebuffersizefun")]
                        delegate* unmanaged<Window*, int, int, void> callback
                );
                return __DSL_glfwSetFramebufferSizeCallback(__dsl_window, callback);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
        public static void SetGamma(Mut<Monitor> monitor, float gamma)
        {
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGamma")]
                static extern void __DSL_glfwSetGamma(Monitor* monitor, float gamma);
                __DSL_glfwSetGamma(__dsl_monitor, gamma);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
        public static void SetGammaRamp(
            Mut<Monitor> monitor,
            [NativeTypeName("const GLFWgammaramp *")] Ptr<Gammaramp> ramp
        )
        {
            fixed (Gammaramp* __dsl_ramp = ramp)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGammaRamp")]
                static extern void __DSL_glfwSetGammaRamp(
                    Monitor* monitor,
                    [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
                );
                __DSL_glfwSetGammaRamp(__dsl_monitor, __dsl_ramp);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
        public static void SetInputMode(Mut<Window> window, int mode, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetInputMode")]
                static extern void __DSL_glfwSetInputMode(Window* window, int mode, int value);
                __DSL_glfwSetInputMode(__dsl_window, mode, value);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetJoystickCallback")]
        [return: NativeTypeName("GLFWjoystickfun")]
        public static extern delegate* unmanaged<int, int, void> SetJoystickCallback(
            [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
        );

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
        public static void SetJoystickUserPointer(int jid, Mut pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetJoystickUserPointer")]
                static extern void __DSL_glfwSetJoystickUserPointer(int jid, void* pointer);
                __DSL_glfwSetJoystickUserPointer(jid, __dsl_pointer);
            }
        }

        [return: NativeTypeName("GLFWkeyfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
        public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWkeyfun")]
                delegate* unmanaged<Window*, int, int, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetKeyCallback")]
                [return: NativeTypeName("GLFWkeyfun")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    int,
                    int,
                    int,
                    void> __DSL_glfwSetKeyCallback(
                    Window* window,
                    [NativeTypeName("GLFWkeyfun")]
                        delegate* unmanaged<Window*, int, int, int, int, void> callback
                );
                return __DSL_glfwSetKeyCallback(__dsl_window, callback);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMonitorCallback")]
        [return: NativeTypeName("GLFWmonitorfun")]
        public static extern delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
            [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
        );

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
        public static void SetMonitorUserPointer(Mut<Monitor> monitor, Mut pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            fixed (Monitor* __dsl_monitor = monitor)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMonitorUserPointer")]
                static extern void __DSL_glfwSetMonitorUserPointer(Monitor* monitor, void* pointer);
                __DSL_glfwSetMonitorUserPointer(__dsl_monitor, __dsl_pointer);
            }
        }

        [return: NativeTypeName("GLFWmousebuttonfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
        public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWmousebuttonfun")]
                delegate* unmanaged<Window*, int, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMouseButtonCallback")]
                [return: NativeTypeName("GLFWmousebuttonfun")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    int,
                    int,
                    void> __DSL_glfwSetMouseButtonCallback(
                    Window* window,
                    [NativeTypeName("GLFWmousebuttonfun")]
                        delegate* unmanaged<Window*, int, int, int, void> callback
                );
                return __DSL_glfwSetMouseButtonCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWscrollfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
        public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWscrollfun")]
                delegate* unmanaged<Window*, double, double, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetScrollCallback")]
                [return: NativeTypeName("GLFWscrollfun")]
                static extern delegate* unmanaged<
                    Window*,
                    double,
                    double,
                    void> __DSL_glfwSetScrollCallback(
                    Window* window,
                    [NativeTypeName("GLFWscrollfun")]
                        delegate* unmanaged<Window*, double, double, void> callback
                );
                return __DSL_glfwSetScrollCallback(__dsl_window, callback);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetTime")]
        public static extern void SetTime(double time);

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
        public static void SetWindowAspectRatio(Mut<Window> window, int numer, int denom)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAspectRatio")]
                static extern void __DSL_glfwSetWindowAspectRatio(
                    Window* window,
                    int numer,
                    int denom
                );
                __DSL_glfwSetWindowAspectRatio(__dsl_window, numer, denom);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
        public static void SetWindowAttrib(Mut<Window> window, int attrib, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAttrib")]
                static extern void __DSL_glfwSetWindowAttrib(Window* window, int attrib, int value);
                __DSL_glfwSetWindowAttrib(__dsl_window, attrib, value);
            }
        }

        [return: NativeTypeName("GLFWwindowclosefun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
        public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowCloseCallback")]
                [return: NativeTypeName("GLFWwindowclosefun")]
                static extern delegate* unmanaged<Window*, void> __DSL_glfwSetWindowCloseCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowclosefun")]
                        delegate* unmanaged<Window*, void> callback
                );
                return __DSL_glfwSetWindowCloseCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowcontentscalefun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
        public static delegate* unmanaged<
            Window*,
            float,
            float,
            void> SetWindowContentScaleCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowcontentscalefun")]
                delegate* unmanaged<Window*, float, float, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwSetWindowContentScaleCallback"
                )]
                [return: NativeTypeName("GLFWwindowcontentscalefun")]
                static extern delegate* unmanaged<
                    Window*,
                    float,
                    float,
                    void> __DSL_glfwSetWindowContentScaleCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowcontentscalefun")]
                        delegate* unmanaged<Window*, float, float, void> callback
                );
                return __DSL_glfwSetWindowContentScaleCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowfocusfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowFocusCallback")]
                [return: NativeTypeName("GLFWwindowfocusfun")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    void> __DSL_glfwSetWindowFocusCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowfocusfun")]
                        delegate* unmanaged<Window*, int, void> callback
                );
                return __DSL_glfwSetWindowFocusCallback(__dsl_window, callback);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
        public static void SetWindowIcon(
            Mut<Window> window,
            int count,
            [NativeTypeName("const GLFWimage *")] Ptr<Image> images
        )
        {
            fixed (Image* __dsl_images = images)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowIcon")]
                static extern void __DSL_glfwSetWindowIcon(
                    Window* window,
                    int count,
                    [NativeTypeName("const GLFWimage *")] Image* images
                );
                __DSL_glfwSetWindowIcon(__dsl_window, count, __dsl_images);
            }
        }

        [return: NativeTypeName("GLFWwindowiconifyfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowiconifyfun")]
                delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwSetWindowIconifyCallback"
                )]
                [return: NativeTypeName("GLFWwindowiconifyfun")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    void> __DSL_glfwSetWindowIconifyCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowiconifyfun")]
                        delegate* unmanaged<Window*, int, void> callback
                );
                return __DSL_glfwSetWindowIconifyCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowmaximizefun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
        public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowmaximizefun")]
                delegate* unmanaged<Window*, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwSetWindowMaximizeCallback"
                )]
                [return: NativeTypeName("GLFWwindowmaximizefun")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    void> __DSL_glfwSetWindowMaximizeCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowmaximizefun")]
                        delegate* unmanaged<Window*, int, void> callback
                );
                return __DSL_glfwSetWindowMaximizeCallback(__dsl_window, callback);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
        public static void SetWindowMonitor(
            Mut<Window> window,
            Mut<Monitor> monitor,
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
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowMonitor")]
                static extern void __DSL_glfwSetWindowMonitor(
                    Window* window,
                    Monitor* monitor,
                    int xpos,
                    int ypos,
                    int width,
                    int height,
                    int refreshRate
                );
                __DSL_glfwSetWindowMonitor(
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

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
        public static void SetWindowOpacity(Mut<Window> window, float opacity)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowOpacity")]
                static extern void __DSL_glfwSetWindowOpacity(Window* window, float opacity);
                __DSL_glfwSetWindowOpacity(__dsl_window, opacity);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
        public static void SetWindowPos(Mut<Window> window, int xpos, int ypos)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPos")]
                static extern void __DSL_glfwSetWindowPos(Window* window, int xpos, int ypos);
                __DSL_glfwSetWindowPos(__dsl_window, xpos, ypos);
            }
        }

        [return: NativeTypeName("GLFWwindowposfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowposfun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPosCallback")]
                [return: NativeTypeName("GLFWwindowposfun")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    int,
                    void> __DSL_glfwSetWindowPosCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowposfun")]
                        delegate* unmanaged<Window*, int, int, void> callback
                );
                return __DSL_glfwSetWindowPosCallback(__dsl_window, callback);
            }
        }

        [return: NativeTypeName("GLFWwindowrefreshfun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
        public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport(
                    "glfw",
                    ExactSpelling = true,
                    EntryPoint = "glfwSetWindowRefreshCallback"
                )]
                [return: NativeTypeName("GLFWwindowrefreshfun")]
                static extern delegate* unmanaged<Window*, void> __DSL_glfwSetWindowRefreshCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowrefreshfun")]
                        delegate* unmanaged<Window*, void> callback
                );
                return __DSL_glfwSetWindowRefreshCallback(__dsl_window, callback);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
        public static void SetWindowShouldClose(Mut<Window> window, int value)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowShouldClose")]
                static extern void __DSL_glfwSetWindowShouldClose(Window* window, int value);
                __DSL_glfwSetWindowShouldClose(__dsl_window, value);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
        public static void SetWindowSize(Mut<Window> window, int width, int height)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSize")]
                static extern void __DSL_glfwSetWindowSize(Window* window, int width, int height);
                __DSL_glfwSetWindowSize(__dsl_window, width, height);
            }
        }

        [return: NativeTypeName("GLFWwindowsizefun")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
        public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
            Mut<Window> window,
            [NativeTypeName("GLFWwindowsizefun")]
                delegate* unmanaged<Window*, int, int, void> callback
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeCallback")]
                [return: NativeTypeName("GLFWwindowsizefun")]
                static extern delegate* unmanaged<
                    Window*,
                    int,
                    int,
                    void> __DSL_glfwSetWindowSizeCallback(
                    Window* window,
                    [NativeTypeName("GLFWwindowsizefun")]
                        delegate* unmanaged<Window*, int, int, void> callback
                );
                return __DSL_glfwSetWindowSizeCallback(__dsl_window, callback);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
        public static void SetWindowSizeLimits(
            Mut<Window> window,
            int minwidth,
            int minheight,
            int maxwidth,
            int maxheight
        )
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeLimits")]
                static extern void __DSL_glfwSetWindowSizeLimits(
                    Window* window,
                    int minwidth,
                    int minheight,
                    int maxwidth,
                    int maxheight
                );
                __DSL_glfwSetWindowSizeLimits(
                    __dsl_window,
                    minwidth,
                    minheight,
                    maxwidth,
                    maxheight
                );
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
        public static void SetWindowTitle(
            Mut<Window> window,
            [NativeTypeName("const char *")] Ptr<sbyte> title
        )
        {
            fixed (sbyte* __dsl_title = title)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowTitle")]
                static extern void __DSL_glfwSetWindowTitle(
                    Window* window,
                    [NativeTypeName("const char *")] sbyte* title
                );
                __DSL_glfwSetWindowTitle(__dsl_window, __dsl_title);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
        public static void SetWindowUserPointer(Mut<Window> window, Mut pointer)
        {
            fixed (void* __dsl_pointer = pointer)
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowUserPointer")]
                static extern void __DSL_glfwSetWindowUserPointer(Window* window, void* pointer);
                __DSL_glfwSetWindowUserPointer(__dsl_window, __dsl_pointer);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
        public static void ShowWindow(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwShowWindow")]
                static extern void __DSL_glfwShowWindow(Window* window);
                __DSL_glfwShowWindow(__dsl_window);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
        public static void SwapBuffers(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSwapBuffers")]
                static extern void __DSL_glfwSwapBuffers(Window* window);
                __DSL_glfwSwapBuffers(__dsl_window);
            }
        }

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSwapInterval")]
        public static extern void SwapInterval(int interval);

        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwTerminate")]
        public static extern void Terminate();

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
        public static int UpdateGamepadMappings([NativeTypeName("const char *")] Ptr<sbyte> @string)
        {
            fixed (sbyte* __dsl_string = @string)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwUpdateGamepadMappings")]
                static extern int __DSL_glfwUpdateGamepadMappings(
                    [NativeTypeName("const char *")] sbyte* @string
                );
                return __DSL_glfwUpdateGamepadMappings(__dsl_string);
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

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
        public static void WindowHintString(
            int hint,
            [NativeTypeName("const char *")] Ptr<sbyte> value
        )
        {
            fixed (sbyte* __dsl_value = value)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowHintString")]
                static extern void __DSL_glfwWindowHintString(
                    int hint,
                    [NativeTypeName("const char *")] sbyte* value
                );
                __DSL_glfwWindowHintString(hint, __dsl_value);
            }
        }

        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
        public static int WindowShouldClose(Mut<Window> window)
        {
            fixed (Window* __dsl_window = window)
            {
                [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowShouldClose")]
                static extern int __DSL_glfwWindowShouldClose(Window* window);
                return __DSL_glfwWindowShouldClose(__dsl_window);
            }
        }
    }

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
    public const int AnglePlatformTypeD3d9 = 0x00037004;

    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_D3D11 0x00037005")]
    public const int AnglePlatformTypeD3d11 = 0x00037005;

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

    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    Mut<Cursor> IGlfw.CreateCursor(
        [NativeTypeName("const GLFWimage *")] Ptr<Image> image,
        int xhot,
        int yhot
    )
    {
        fixed (Image* __dsl_image = image)
        {
            Cursor* __DSL_glfwCreateCursor(
                [NativeTypeName("const GLFWimage *")] Image* image,
                int xhot,
                int yhot
            ) =>
                (
                    (delegate* unmanaged<Image*, int, int, Cursor*>)
                        nativeContext.LoadFunction("glfwCreateCursor", "glfw")
                )(image, xhot, yhot);
            return __DSL_glfwCreateCursor(__dsl_image, xhot, yhot);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwCreateCursor")]
    public static Mut<Cursor> CreateCursor(
        [NativeTypeName("const GLFWimage *")] Ptr<Image> image,
        int xhot,
        int yhot
    )
    {
        fixed (Image* __dsl_image = image)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateCursor")]
            static extern Cursor* __DSL_glfwCreateCursor(
                [NativeTypeName("const GLFWimage *")] Image* image,
                int xhot,
                int yhot
            );
            return __DSL_glfwCreateCursor(__dsl_image, xhot, yhot);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    Mut<Cursor> IGlfw.CreateStandardCursor(int shape)
    {
        Cursor* __DSL_glfwCreateStandardCursor(int shape) =>
            (
                (delegate* unmanaged<int, Cursor*>)
                    nativeContext.LoadFunction("glfwCreateStandardCursor", "glfw")
            )(shape);
        return __DSL_glfwCreateStandardCursor(shape);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwCreateStandardCursor")]
    public static Mut<Cursor> CreateStandardCursor(int shape)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateStandardCursor")]
        static extern Cursor* __DSL_glfwCreateStandardCursor(int shape);
        return __DSL_glfwCreateStandardCursor(shape);
    }

    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    Mut<Window> IGlfw.CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] Ptr<sbyte> title,
        Mut<Monitor> monitor,
        Mut<Window> share
    )
    {
        fixed (Window* __dsl_share = share)
        fixed (Monitor* __dsl_monitor = monitor)
        fixed (sbyte* __dsl_title = title)
        {
            Window* __DSL_glfwCreateWindow(
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
            return __DSL_glfwCreateWindow(width, height, __dsl_title, __dsl_monitor, __dsl_share);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwCreateWindow")]
    public static Mut<Window> CreateWindow(
        int width,
        int height,
        [NativeTypeName("const char *")] Ptr<sbyte> title,
        Mut<Monitor> monitor,
        Mut<Window> share
    )
    {
        fixed (Window* __dsl_share = share)
        fixed (Monitor* __dsl_monitor = monitor)
        fixed (sbyte* __dsl_title = title)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwCreateWindow")]
            static extern Window* __DSL_glfwCreateWindow(
                int width,
                int height,
                [NativeTypeName("const char *")] sbyte* title,
                Monitor* monitor,
                Window* share
            );
            return __DSL_glfwCreateWindow(width, height, __dsl_title, __dsl_monitor, __dsl_share);
        }
    }

    void IGlfw.DefaultWindowHints() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwDefaultWindowHints", "glfw"))();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDefaultWindowHints")]
    public static extern void DefaultWindowHints();

    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    void IGlfw.DestroyCursor(Mut<Cursor> cursor)
    {
        fixed (Cursor* __dsl_cursor = cursor)
        {
            void __DSL_glfwDestroyCursor(Cursor* cursor) =>
                (
                    (delegate* unmanaged<Cursor*, void>)
                        nativeContext.LoadFunction("glfwDestroyCursor", "glfw")
                )(cursor);
            __DSL_glfwDestroyCursor(__dsl_cursor);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyCursor")]
    public static void DestroyCursor(Mut<Cursor> cursor)
    {
        fixed (Cursor* __dsl_cursor = cursor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyCursor")]
            static extern void __DSL_glfwDestroyCursor(Cursor* cursor);
            __DSL_glfwDestroyCursor(__dsl_cursor);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    void IGlfw.DestroyWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwDestroyWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwDestroyWindow", "glfw")
                )(window);
            __DSL_glfwDestroyWindow(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwDestroyWindow")]
    public static void DestroyWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwDestroyWindow")]
            static extern void __DSL_glfwDestroyWindow(Window* window);
            __DSL_glfwDestroyWindow(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    int IGlfw.ExtensionSupported([NativeTypeName("const char *")] Ptr<sbyte> extension)
    {
        fixed (sbyte* __dsl_extension = extension)
        {
            int __DSL_glfwExtensionSupported([NativeTypeName("const char *")] sbyte* extension) =>
                (
                    (delegate* unmanaged<sbyte*, int>)
                        nativeContext.LoadFunction("glfwExtensionSupported", "glfw")
                )(extension);
            return __DSL_glfwExtensionSupported(__dsl_extension);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwExtensionSupported")]
    public static int ExtensionSupported([NativeTypeName("const char *")] Ptr<sbyte> extension)
    {
        fixed (sbyte* __dsl_extension = extension)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwExtensionSupported")]
            static extern int __DSL_glfwExtensionSupported(
                [NativeTypeName("const char *")] sbyte* extension
            );
            return __DSL_glfwExtensionSupported(__dsl_extension);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    void IGlfw.FocusWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwFocusWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwFocusWindow", "glfw")
                )(window);
            __DSL_glfwFocusWindow(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwFocusWindow")]
    public static void FocusWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwFocusWindow")]
            static extern void __DSL_glfwFocusWindow(Window* window);
            __DSL_glfwFocusWindow(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    Ptr<sbyte> IGlfw.GetClipboardString(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            sbyte* __DSL_glfwGetClipboardString(Window* window) =>
                (
                    (delegate* unmanaged<Window*, sbyte*>)
                        nativeContext.LoadFunction("glfwGetClipboardString", "glfw")
                )(window);
            return __DSL_glfwGetClipboardString(__dsl_window);
        }
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetClipboardString")]
    public static Ptr<sbyte> GetClipboardString(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetClipboardString")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetClipboardString(Window* window);
            return __DSL_glfwGetClipboardString(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    Mut<Window> IGlfw.GetCurrentContext()
    {
        Window* __DSL_glfwGetCurrentContext() =>
            (
                (delegate* unmanaged<Window*>)
                    nativeContext.LoadFunction("glfwGetCurrentContext", "glfw")
            )();
        return __DSL_glfwGetCurrentContext();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetCurrentContext")]
    public static Mut<Window> GetCurrentContext()
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCurrentContext")]
        static extern Window* __DSL_glfwGetCurrentContext();
        return __DSL_glfwGetCurrentContext();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    void IGlfw.GetCursorPos(Mut<Window> window, Mut<double> xpos, Mut<double> ypos)
    {
        fixed (double* __dsl_ypos = ypos)
        fixed (double* __dsl_xpos = xpos)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwGetCursorPos(Window* window, double* xpos, double* ypos) =>
                (
                    (delegate* unmanaged<Window*, double*, double*, void>)
                        nativeContext.LoadFunction("glfwGetCursorPos", "glfw")
                )(window, xpos, ypos);
            __DSL_glfwGetCursorPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetCursorPos")]
    public static void GetCursorPos(Mut<Window> window, Mut<double> xpos, Mut<double> ypos)
    {
        fixed (double* __dsl_ypos = ypos)
        fixed (double* __dsl_xpos = xpos)
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetCursorPos")]
            static extern void __DSL_glfwGetCursorPos(Window* window, double* xpos, double* ypos);
            __DSL_glfwGetCursorPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    int IGlfw.GetError([NativeTypeName("const char **")] PtrPtr<sbyte> description)
    {
        fixed (sbyte** __dsl_description = description)
        {
            int __DSL_glfwGetError([NativeTypeName("const char **")] sbyte** description) =>
                (
                    (delegate* unmanaged<sbyte**, int>)
                        nativeContext.LoadFunction("glfwGetError", "glfw")
                )(description);
            return __DSL_glfwGetError(__dsl_description);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetError")]
    public static int GetError([NativeTypeName("const char **")] PtrPtr<sbyte> description)
    {
        fixed (sbyte** __dsl_description = description)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetError")]
            static extern int __DSL_glfwGetError(
                [NativeTypeName("const char **")] sbyte** description
            );
            return __DSL_glfwGetError(__dsl_description);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    void IGlfw.GetFramebufferSize(Mut<Window> window, Mut<int> width, Mut<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwGetFramebufferSize(Window* window, int* width, int* height) =>
                (
                    (delegate* unmanaged<Window*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetFramebufferSize", "glfw")
                )(window, width, height);
            __DSL_glfwGetFramebufferSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetFramebufferSize")]
    public static void GetFramebufferSize(Mut<Window> window, Mut<int> width, Mut<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetFramebufferSize")]
            static extern void __DSL_glfwGetFramebufferSize(
                Window* window,
                int* width,
                int* height
            );
            __DSL_glfwGetFramebufferSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    Ptr<sbyte> IGlfw.GetGamepadName(int jid)
    {
        sbyte* __DSL_glfwGetGamepadName(int jid) =>
            (
                (delegate* unmanaged<int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetGamepadName", "glfw")
            )(jid);
        return __DSL_glfwGetGamepadName(jid);
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadName")]
    public static Ptr<sbyte> GetGamepadName(int jid)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadName")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetGamepadName(int jid);
        return __DSL_glfwGetGamepadName(jid);
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    int IGlfw.GetGamepadState(int jid, Mut<Gamepadstate> state)
    {
        fixed (Gamepadstate* __dsl_state = state)
        {
            int __DSL_glfwGetGamepadState(int jid, Gamepadstate* state) =>
                (
                    (delegate* unmanaged<int, Gamepadstate*, int>)
                        nativeContext.LoadFunction("glfwGetGamepadState", "glfw")
                )(jid, state);
            return __DSL_glfwGetGamepadState(jid, __dsl_state);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetGamepadState")]
    public static int GetGamepadState(int jid, Mut<Gamepadstate> state)
    {
        fixed (Gamepadstate* __dsl_state = state)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGamepadState")]
            static extern int __DSL_glfwGetGamepadState(int jid, Gamepadstate* state);
            return __DSL_glfwGetGamepadState(jid, __dsl_state);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    Ptr<Gammaramp> IGlfw.GetGammaRamp(Mut<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            Gammaramp* __DSL_glfwGetGammaRamp(Monitor* monitor) =>
                (
                    (delegate* unmanaged<Monitor*, Gammaramp*>)
                        nativeContext.LoadFunction("glfwGetGammaRamp", "glfw")
                )(monitor);
            return __DSL_glfwGetGammaRamp(__dsl_monitor);
        }
    }

    [return: NativeTypeName("const GLFWgammaramp *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetGammaRamp")]
    public static Ptr<Gammaramp> GetGammaRamp(Mut<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetGammaRamp")]
            [return: NativeTypeName("const GLFWgammaramp *")]
            static extern Gammaramp* __DSL_glfwGetGammaRamp(Monitor* monitor);
            return __DSL_glfwGetGammaRamp(__dsl_monitor);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    int IGlfw.GetInputMode(Mut<Window> window, int mode)
    {
        fixed (Window* __dsl_window = window)
        {
            int __DSL_glfwGetInputMode(Window* window, int mode) =>
                (
                    (delegate* unmanaged<Window*, int, int>)
                        nativeContext.LoadFunction("glfwGetInputMode", "glfw")
                )(window, mode);
            return __DSL_glfwGetInputMode(__dsl_window, mode);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetInputMode")]
    public static int GetInputMode(Mut<Window> window, int mode)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetInputMode")]
            static extern int __DSL_glfwGetInputMode(Window* window, int mode);
            return __DSL_glfwGetInputMode(__dsl_window, mode);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    Ptr<float> IGlfw.GetJoystickAxes(int jid, Mut<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            float* __DSL_glfwGetJoystickAxes(int jid, int* count) =>
                (
                    (delegate* unmanaged<int, int*, float*>)
                        nativeContext.LoadFunction("glfwGetJoystickAxes", "glfw")
                )(jid, count);
            return __DSL_glfwGetJoystickAxes(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const float *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickAxes")]
    public static Ptr<float> GetJoystickAxes(int jid, Mut<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickAxes")]
            [return: NativeTypeName("const float *")]
            static extern float* __DSL_glfwGetJoystickAxes(int jid, int* count);
            return __DSL_glfwGetJoystickAxes(jid, __dsl_count);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    Ptr<byte> IGlfw.GetJoystickButtons(int jid, Mut<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            byte* __DSL_glfwGetJoystickButtons(int jid, int* count) =>
                (
                    (delegate* unmanaged<int, int*, byte*>)
                        nativeContext.LoadFunction("glfwGetJoystickButtons", "glfw")
                )(jid, count);
            return __DSL_glfwGetJoystickButtons(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const unsigned char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickButtons")]
    public static Ptr<byte> GetJoystickButtons(int jid, Mut<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickButtons")]
            [return: NativeTypeName("const unsigned char *")]
            static extern byte* __DSL_glfwGetJoystickButtons(int jid, int* count);
            return __DSL_glfwGetJoystickButtons(jid, __dsl_count);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    Ptr<sbyte> IGlfw.GetJoystickGuid(int jid)
    {
        sbyte* __DSL_glfwGetJoystickGUID(int jid) =>
            (
                (delegate* unmanaged<int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetJoystickGUID", "glfw")
            )(jid);
        return __DSL_glfwGetJoystickGUID(jid);
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickGUID")]
    public static Ptr<sbyte> GetJoystickGuid(int jid)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickGUID")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetJoystickGUID(int jid);
        return __DSL_glfwGetJoystickGUID(jid);
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    Ptr<byte> IGlfw.GetJoystickHats(int jid, Mut<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            byte* __DSL_glfwGetJoystickHats(int jid, int* count) =>
                (
                    (delegate* unmanaged<int, int*, byte*>)
                        nativeContext.LoadFunction("glfwGetJoystickHats", "glfw")
                )(jid, count);
            return __DSL_glfwGetJoystickHats(jid, __dsl_count);
        }
    }

    [return: NativeTypeName("const unsigned char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickHats")]
    public static Ptr<byte> GetJoystickHats(int jid, Mut<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickHats")]
            [return: NativeTypeName("const unsigned char *")]
            static extern byte* __DSL_glfwGetJoystickHats(int jid, int* count);
            return __DSL_glfwGetJoystickHats(jid, __dsl_count);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    Ptr<sbyte> IGlfw.GetJoystickName(int jid)
    {
        sbyte* __DSL_glfwGetJoystickName(int jid) =>
            (
                (delegate* unmanaged<int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetJoystickName", "glfw")
            )(jid);
        return __DSL_glfwGetJoystickName(jid);
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickName")]
    public static Ptr<sbyte> GetJoystickName(int jid)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickName")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetJoystickName(int jid);
        return __DSL_glfwGetJoystickName(jid);
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    Mut IGlfw.GetJoystickUserPointer(int jid)
    {
        void* __DSL_glfwGetJoystickUserPointer(int jid) =>
            (
                (delegate* unmanaged<int, void*>)
                    nativeContext.LoadFunction("glfwGetJoystickUserPointer", "glfw")
            )(jid);
        return __DSL_glfwGetJoystickUserPointer(jid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetJoystickUserPointer")]
    public static Mut GetJoystickUserPointer(int jid)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetJoystickUserPointer")]
        static extern void* __DSL_glfwGetJoystickUserPointer(int jid);
        return __DSL_glfwGetJoystickUserPointer(jid);
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    int IGlfw.GetKey(Mut<Window> window, int key)
    {
        fixed (Window* __dsl_window = window)
        {
            int __DSL_glfwGetKey(Window* window, int key) =>
                (
                    (delegate* unmanaged<Window*, int, int>)
                        nativeContext.LoadFunction("glfwGetKey", "glfw")
                )(window, key);
            return __DSL_glfwGetKey(__dsl_window, key);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetKey")]
    public static int GetKey(Mut<Window> window, int key)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKey")]
            static extern int __DSL_glfwGetKey(Window* window, int key);
            return __DSL_glfwGetKey(__dsl_window, key);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    Ptr<sbyte> IGlfw.GetKeyName(int key, int scancode)
    {
        sbyte* __DSL_glfwGetKeyName(int key, int scancode) =>
            (
                (delegate* unmanaged<int, int, sbyte*>)
                    nativeContext.LoadFunction("glfwGetKeyName", "glfw")
            )(key, scancode);
        return __DSL_glfwGetKeyName(key, scancode);
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetKeyName")]
    public static Ptr<sbyte> GetKeyName(int key, int scancode)
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKeyName")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetKeyName(int key, int scancode);
        return __DSL_glfwGetKeyName(key, scancode);
    }

    int IGlfw.GetKeyScancode(int key) =>
        ((delegate* unmanaged<int, int>)nativeContext.LoadFunction("glfwGetKeyScancode", "glfw"))(
            key
        );

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetKeyScancode")]
    public static extern int GetKeyScancode(int key);

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    void IGlfw.GetMonitorContentScale(Mut<Monitor> monitor, Mut<float> xscale, Mut<float> yscale)
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwGetMonitorContentScale(Monitor* monitor, float* xscale, float* yscale) =>
                (
                    (delegate* unmanaged<Monitor*, float*, float*, void>)
                        nativeContext.LoadFunction("glfwGetMonitorContentScale", "glfw")
                )(monitor, xscale, yscale);
            __DSL_glfwGetMonitorContentScale(__dsl_monitor, __dsl_xscale, __dsl_yscale);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorContentScale")]
    public static void GetMonitorContentScale(
        Mut<Monitor> monitor,
        Mut<float> xscale,
        Mut<float> yscale
    )
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorContentScale")]
            static extern void __DSL_glfwGetMonitorContentScale(
                Monitor* monitor,
                float* xscale,
                float* yscale
            );
            __DSL_glfwGetMonitorContentScale(__dsl_monitor, __dsl_xscale, __dsl_yscale);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    Ptr<sbyte> IGlfw.GetMonitorName(Mut<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            sbyte* __DSL_glfwGetMonitorName(Monitor* monitor) =>
                (
                    (delegate* unmanaged<Monitor*, sbyte*>)
                        nativeContext.LoadFunction("glfwGetMonitorName", "glfw")
                )(monitor);
            return __DSL_glfwGetMonitorName(__dsl_monitor);
        }
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorName")]
    public static Ptr<sbyte> GetMonitorName(Mut<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorName")]
            [return: NativeTypeName("const char *")]
            static extern sbyte* __DSL_glfwGetMonitorName(Monitor* monitor);
            return __DSL_glfwGetMonitorName(__dsl_monitor);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    void IGlfw.GetMonitorPhysicalSize(Mut<Monitor> monitor, Mut<int> widthMM, Mut<int> heightMM)
    {
        fixed (int* __dsl_heightMM = heightMM)
        fixed (int* __dsl_widthMM = widthMM)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwGetMonitorPhysicalSize(Monitor* monitor, int* widthMM, int* heightMM) =>
                (
                    (delegate* unmanaged<Monitor*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetMonitorPhysicalSize", "glfw")
                )(monitor, widthMM, heightMM);
            __DSL_glfwGetMonitorPhysicalSize(__dsl_monitor, __dsl_widthMM, __dsl_heightMM);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPhysicalSize")]
    public static void GetMonitorPhysicalSize(
        Mut<Monitor> monitor,
        Mut<int> widthMM,
        Mut<int> heightMM
    )
    {
        fixed (int* __dsl_heightMM = heightMM)
        fixed (int* __dsl_widthMM = widthMM)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPhysicalSize")]
            static extern void __DSL_glfwGetMonitorPhysicalSize(
                Monitor* monitor,
                int* widthMM,
                int* heightMM
            );
            __DSL_glfwGetMonitorPhysicalSize(__dsl_monitor, __dsl_widthMM, __dsl_heightMM);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    void IGlfw.GetMonitorPos(Mut<Monitor> monitor, Mut<int> xpos, Mut<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwGetMonitorPos(Monitor* monitor, int* xpos, int* ypos) =>
                (
                    (delegate* unmanaged<Monitor*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetMonitorPos", "glfw")
                )(monitor, xpos, ypos);
            __DSL_glfwGetMonitorPos(__dsl_monitor, __dsl_xpos, __dsl_ypos);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorPos")]
    public static void GetMonitorPos(Mut<Monitor> monitor, Mut<int> xpos, Mut<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorPos")]
            static extern void __DSL_glfwGetMonitorPos(Monitor* monitor, int* xpos, int* ypos);
            __DSL_glfwGetMonitorPos(__dsl_monitor, __dsl_xpos, __dsl_ypos);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    MutMut<Monitor> IGlfw.GetMonitors(Mut<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            Monitor** __DSL_glfwGetMonitors(int* count) =>
                (
                    (delegate* unmanaged<int*, Monitor**>)
                        nativeContext.LoadFunction("glfwGetMonitors", "glfw")
                )(count);
            return __DSL_glfwGetMonitors(__dsl_count);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitors")]
    public static MutMut<Monitor> GetMonitors(Mut<int> count)
    {
        fixed (int* __dsl_count = count)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitors")]
            static extern Monitor** __DSL_glfwGetMonitors(int* count);
            return __DSL_glfwGetMonitors(__dsl_count);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    Mut IGlfw.GetMonitorUserPointer(Mut<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void* __DSL_glfwGetMonitorUserPointer(Monitor* monitor) =>
                (
                    (delegate* unmanaged<Monitor*, void*>)
                        nativeContext.LoadFunction("glfwGetMonitorUserPointer", "glfw")
                )(monitor);
            return __DSL_glfwGetMonitorUserPointer(__dsl_monitor);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorUserPointer")]
    public static Mut GetMonitorUserPointer(Mut<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorUserPointer")]
            static extern void* __DSL_glfwGetMonitorUserPointer(Monitor* monitor);
            return __DSL_glfwGetMonitorUserPointer(__dsl_monitor);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    void IGlfw.GetMonitorWorkarea(
        Mut<Monitor> monitor,
        Mut<int> xpos,
        Mut<int> ypos,
        Mut<int> width,
        Mut<int> height
    )
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwGetMonitorWorkarea(
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
            __DSL_glfwGetMonitorWorkarea(
                __dsl_monitor,
                __dsl_xpos,
                __dsl_ypos,
                __dsl_width,
                __dsl_height
            );
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMonitorWorkarea")]
    public static void GetMonitorWorkarea(
        Mut<Monitor> monitor,
        Mut<int> xpos,
        Mut<int> ypos,
        Mut<int> width,
        Mut<int> height
    )
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMonitorWorkarea")]
            static extern void __DSL_glfwGetMonitorWorkarea(
                Monitor* monitor,
                int* xpos,
                int* ypos,
                int* width,
                int* height
            );
            __DSL_glfwGetMonitorWorkarea(
                __dsl_monitor,
                __dsl_xpos,
                __dsl_ypos,
                __dsl_width,
                __dsl_height
            );
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    int IGlfw.GetMouseButton(Mut<Window> window, int button)
    {
        fixed (Window* __dsl_window = window)
        {
            int __DSL_glfwGetMouseButton(Window* window, int button) =>
                (
                    (delegate* unmanaged<Window*, int, int>)
                        nativeContext.LoadFunction("glfwGetMouseButton", "glfw")
                )(window, button);
            return __DSL_glfwGetMouseButton(__dsl_window, button);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetMouseButton")]
    public static int GetMouseButton(Mut<Window> window, int button)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetMouseButton")]
            static extern int __DSL_glfwGetMouseButton(Window* window, int button);
            return __DSL_glfwGetMouseButton(__dsl_window, button);
        }
    }

    int IGlfw.GetPlatform() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("glfwGetPlatform", "glfw"))();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetPlatform")]
    public static extern int GetPlatform();

    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    Mut<Monitor> IGlfw.GetPrimaryMonitor()
    {
        Monitor* __DSL_glfwGetPrimaryMonitor() =>
            (
                (delegate* unmanaged<Monitor*>)
                    nativeContext.LoadFunction("glfwGetPrimaryMonitor", "glfw")
            )();
        return __DSL_glfwGetPrimaryMonitor();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetPrimaryMonitor")]
    public static Mut<Monitor> GetPrimaryMonitor()
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetPrimaryMonitor")]
        static extern Monitor* __DSL_glfwGetPrimaryMonitor();
        return __DSL_glfwGetPrimaryMonitor();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    delegate* unmanaged<void> IGlfw.GetProcAddress(
        [NativeTypeName("const char *")] Ptr<sbyte> procname
    )
    {
        fixed (sbyte* __dsl_procname = procname)
        {
            delegate* unmanaged<void> __DSL_glfwGetProcAddress(
                [NativeTypeName("const char *")] sbyte* procname
            ) =>
                (
                    (delegate* unmanaged<sbyte*, delegate* unmanaged<void>>)
                        nativeContext.LoadFunction("glfwGetProcAddress", "glfw")
                )(procname);
            return __DSL_glfwGetProcAddress(__dsl_procname);
        }
    }

    [return: NativeTypeName("GLFWglproc")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetProcAddress")]
    public static delegate* unmanaged<void> GetProcAddress(
        [NativeTypeName("const char *")] Ptr<sbyte> procname
    )
    {
        fixed (sbyte* __dsl_procname = procname)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetProcAddress")]
            [return: NativeTypeName("GLFWglproc")]
            static extern delegate* unmanaged<void> __DSL_glfwGetProcAddress(
                [NativeTypeName("const char *")] sbyte* procname
            );
            return __DSL_glfwGetProcAddress(__dsl_procname);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    PtrPtr<sbyte> IGlfw.GetRequiredInstanceExtensions(
        [NativeTypeName("uint32_t *")] Mut<uint> count
    )
    {
        fixed (uint* __dsl_count = count)
        {
            sbyte** __DSL_glfwGetRequiredInstanceExtensions(
                [NativeTypeName("uint32_t *")] uint* count
            ) =>
                (
                    (delegate* unmanaged<uint*, sbyte**>)
                        nativeContext.LoadFunction("glfwGetRequiredInstanceExtensions", "glfw")
                )(count);
            return __DSL_glfwGetRequiredInstanceExtensions(__dsl_count);
        }
    }

    [return: NativeTypeName("const char **")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetRequiredInstanceExtensions")]
    public static PtrPtr<sbyte> GetRequiredInstanceExtensions(
        [NativeTypeName("uint32_t *")] Mut<uint> count
    )
    {
        fixed (uint* __dsl_count = count)
        {
            [DllImport(
                "glfw",
                ExactSpelling = true,
                EntryPoint = "glfwGetRequiredInstanceExtensions"
            )]
            [return: NativeTypeName("const char **")]
            static extern sbyte** __DSL_glfwGetRequiredInstanceExtensions(
                [NativeTypeName("uint32_t *")] uint* count
            );
            return __DSL_glfwGetRequiredInstanceExtensions(__dsl_count);
        }
    }

    double IGlfw.GetTime() =>
        ((delegate* unmanaged<double>)nativeContext.LoadFunction("glfwGetTime", "glfw"))();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetTime")]
    public static extern double GetTime();

    ulong IGlfw.GetTimerFrequency() =>
        ((delegate* unmanaged<ulong>)nativeContext.LoadFunction("glfwGetTimerFrequency", "glfw"))();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetTimerFrequency")]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetTimerFrequency();

    ulong IGlfw.GetTimerValue() =>
        ((delegate* unmanaged<ulong>)nativeContext.LoadFunction("glfwGetTimerValue", "glfw"))();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetTimerValue")]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong GetTimerValue();

    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    void IGlfw.GetVersion(Mut<int> major, Mut<int> minor, Mut<int> rev)
    {
        fixed (int* __dsl_rev = rev)
        fixed (int* __dsl_minor = minor)
        fixed (int* __dsl_major = major)
        {
            void __DSL_glfwGetVersion(int* major, int* minor, int* rev) =>
                (
                    (delegate* unmanaged<int*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetVersion", "glfw")
                )(major, minor, rev);
            __DSL_glfwGetVersion(__dsl_major, __dsl_minor, __dsl_rev);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersion")]
    public static void GetVersion(Mut<int> major, Mut<int> minor, Mut<int> rev)
    {
        fixed (int* __dsl_rev = rev)
        fixed (int* __dsl_minor = minor)
        fixed (int* __dsl_major = major)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersion")]
            static extern void __DSL_glfwGetVersion(int* major, int* minor, int* rev);
            __DSL_glfwGetVersion(__dsl_major, __dsl_minor, __dsl_rev);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    Ptr<sbyte> IGlfw.GetVersionString()
    {
        sbyte* __DSL_glfwGetVersionString() =>
            (
                (delegate* unmanaged<sbyte*>)
                    nativeContext.LoadFunction("glfwGetVersionString", "glfw")
            )();
        return __DSL_glfwGetVersionString();
    }

    [return: NativeTypeName("const char *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetVersionString")]
    public static Ptr<sbyte> GetVersionString()
    {
        [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVersionString")]
        [return: NativeTypeName("const char *")]
        static extern sbyte* __DSL_glfwGetVersionString();
        return __DSL_glfwGetVersionString();
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    Ptr<Vidmode> IGlfw.GetVideoMode(Mut<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            Vidmode* __DSL_glfwGetVideoMode(Monitor* monitor) =>
                (
                    (delegate* unmanaged<Monitor*, Vidmode*>)
                        nativeContext.LoadFunction("glfwGetVideoMode", "glfw")
                )(monitor);
            return __DSL_glfwGetVideoMode(__dsl_monitor);
        }
    }

    [return: NativeTypeName("const GLFWvidmode *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoMode")]
    public static Ptr<Vidmode> GetVideoMode(Mut<Monitor> monitor)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoMode")]
            [return: NativeTypeName("const GLFWvidmode *")]
            static extern Vidmode* __DSL_glfwGetVideoMode(Monitor* monitor);
            return __DSL_glfwGetVideoMode(__dsl_monitor);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    Ptr<Vidmode> IGlfw.GetVideoModes(Mut<Monitor> monitor, Mut<int> count)
    {
        fixed (int* __dsl_count = count)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            Vidmode* __DSL_glfwGetVideoModes(Monitor* monitor, int* count) =>
                (
                    (delegate* unmanaged<Monitor*, int*, Vidmode*>)
                        nativeContext.LoadFunction("glfwGetVideoModes", "glfw")
                )(monitor, count);
            return __DSL_glfwGetVideoModes(__dsl_monitor, __dsl_count);
        }
    }

    [return: NativeTypeName("const GLFWvidmode *")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetVideoModes")]
    public static Ptr<Vidmode> GetVideoModes(Mut<Monitor> monitor, Mut<int> count)
    {
        fixed (int* __dsl_count = count)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetVideoModes")]
            [return: NativeTypeName("const GLFWvidmode *")]
            static extern Vidmode* __DSL_glfwGetVideoModes(Monitor* monitor, int* count);
            return __DSL_glfwGetVideoModes(__dsl_monitor, __dsl_count);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    int IGlfw.GetWindowAttrib(Mut<Window> window, int attrib)
    {
        fixed (Window* __dsl_window = window)
        {
            int __DSL_glfwGetWindowAttrib(Window* window, int attrib) =>
                (
                    (delegate* unmanaged<Window*, int, int>)
                        nativeContext.LoadFunction("glfwGetWindowAttrib", "glfw")
                )(window, attrib);
            return __DSL_glfwGetWindowAttrib(__dsl_window, attrib);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowAttrib")]
    public static int GetWindowAttrib(Mut<Window> window, int attrib)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowAttrib")]
            static extern int __DSL_glfwGetWindowAttrib(Window* window, int attrib);
            return __DSL_glfwGetWindowAttrib(__dsl_window, attrib);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    void IGlfw.GetWindowContentScale(Mut<Window> window, Mut<float> xscale, Mut<float> yscale)
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwGetWindowContentScale(Window* window, float* xscale, float* yscale) =>
                (
                    (delegate* unmanaged<Window*, float*, float*, void>)
                        nativeContext.LoadFunction("glfwGetWindowContentScale", "glfw")
                )(window, xscale, yscale);
            __DSL_glfwGetWindowContentScale(__dsl_window, __dsl_xscale, __dsl_yscale);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowContentScale")]
    public static void GetWindowContentScale(
        Mut<Window> window,
        Mut<float> xscale,
        Mut<float> yscale
    )
    {
        fixed (float* __dsl_yscale = yscale)
        fixed (float* __dsl_xscale = xscale)
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowContentScale")]
            static extern void __DSL_glfwGetWindowContentScale(
                Window* window,
                float* xscale,
                float* yscale
            );
            __DSL_glfwGetWindowContentScale(__dsl_window, __dsl_xscale, __dsl_yscale);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    void IGlfw.GetWindowFrameSize(
        Mut<Window> window,
        Mut<int> left,
        Mut<int> top,
        Mut<int> right,
        Mut<int> bottom
    )
    {
        fixed (int* __dsl_bottom = bottom)
        fixed (int* __dsl_right = right)
        fixed (int* __dsl_top = top)
        fixed (int* __dsl_left = left)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwGetWindowFrameSize(
                Window* window,
                int* left,
                int* top,
                int* right,
                int* bottom
            ) =>
                (
                    (delegate* unmanaged<Window*, int*, int*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetWindowFrameSize", "glfw")
                )(window, left, top, right, bottom);
            __DSL_glfwGetWindowFrameSize(
                __dsl_window,
                __dsl_left,
                __dsl_top,
                __dsl_right,
                __dsl_bottom
            );
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowFrameSize")]
    public static void GetWindowFrameSize(
        Mut<Window> window,
        Mut<int> left,
        Mut<int> top,
        Mut<int> right,
        Mut<int> bottom
    )
    {
        fixed (int* __dsl_bottom = bottom)
        fixed (int* __dsl_right = right)
        fixed (int* __dsl_top = top)
        fixed (int* __dsl_left = left)
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowFrameSize")]
            static extern void __DSL_glfwGetWindowFrameSize(
                Window* window,
                int* left,
                int* top,
                int* right,
                int* bottom
            );
            __DSL_glfwGetWindowFrameSize(
                __dsl_window,
                __dsl_left,
                __dsl_top,
                __dsl_right,
                __dsl_bottom
            );
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    Mut<Monitor> IGlfw.GetWindowMonitor(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            Monitor* __DSL_glfwGetWindowMonitor(Window* window) =>
                (
                    (delegate* unmanaged<Window*, Monitor*>)
                        nativeContext.LoadFunction("glfwGetWindowMonitor", "glfw")
                )(window);
            return __DSL_glfwGetWindowMonitor(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowMonitor")]
    public static Mut<Monitor> GetWindowMonitor(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowMonitor")]
            static extern Monitor* __DSL_glfwGetWindowMonitor(Window* window);
            return __DSL_glfwGetWindowMonitor(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    float IGlfw.GetWindowOpacity(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            float __DSL_glfwGetWindowOpacity(Window* window) =>
                (
                    (delegate* unmanaged<Window*, float>)
                        nativeContext.LoadFunction("glfwGetWindowOpacity", "glfw")
                )(window);
            return __DSL_glfwGetWindowOpacity(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowOpacity")]
    public static float GetWindowOpacity(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowOpacity")]
            static extern float __DSL_glfwGetWindowOpacity(Window* window);
            return __DSL_glfwGetWindowOpacity(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    void IGlfw.GetWindowPos(Mut<Window> window, Mut<int> xpos, Mut<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwGetWindowPos(Window* window, int* xpos, int* ypos) =>
                (
                    (delegate* unmanaged<Window*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetWindowPos", "glfw")
                )(window, xpos, ypos);
            __DSL_glfwGetWindowPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowPos")]
    public static void GetWindowPos(Mut<Window> window, Mut<int> xpos, Mut<int> ypos)
    {
        fixed (int* __dsl_ypos = ypos)
        fixed (int* __dsl_xpos = xpos)
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowPos")]
            static extern void __DSL_glfwGetWindowPos(Window* window, int* xpos, int* ypos);
            __DSL_glfwGetWindowPos(__dsl_window, __dsl_xpos, __dsl_ypos);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    void IGlfw.GetWindowSize(Mut<Window> window, Mut<int> width, Mut<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwGetWindowSize(Window* window, int* width, int* height) =>
                (
                    (delegate* unmanaged<Window*, int*, int*, void>)
                        nativeContext.LoadFunction("glfwGetWindowSize", "glfw")
                )(window, width, height);
            __DSL_glfwGetWindowSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowSize")]
    public static void GetWindowSize(Mut<Window> window, Mut<int> width, Mut<int> height)
    {
        fixed (int* __dsl_height = height)
        fixed (int* __dsl_width = width)
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowSize")]
            static extern void __DSL_glfwGetWindowSize(Window* window, int* width, int* height);
            __DSL_glfwGetWindowSize(__dsl_window, __dsl_width, __dsl_height);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    Mut IGlfw.GetWindowUserPointer(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void* __DSL_glfwGetWindowUserPointer(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void*>)
                        nativeContext.LoadFunction("glfwGetWindowUserPointer", "glfw")
                )(window);
            return __DSL_glfwGetWindowUserPointer(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwGetWindowUserPointer")]
    public static Mut GetWindowUserPointer(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwGetWindowUserPointer")]
            static extern void* __DSL_glfwGetWindowUserPointer(Window* window);
            return __DSL_glfwGetWindowUserPointer(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    void IGlfw.HideWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwHideWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwHideWindow", "glfw")
                )(window);
            __DSL_glfwHideWindow(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwHideWindow")]
    public static void HideWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwHideWindow")]
            static extern void __DSL_glfwHideWindow(Window* window);
            __DSL_glfwHideWindow(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    void IGlfw.IconifyWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwIconifyWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwIconifyWindow", "glfw")
                )(window);
            __DSL_glfwIconifyWindow(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwIconifyWindow")]
    public static void IconifyWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwIconifyWindow")]
            static extern void __DSL_glfwIconifyWindow(Window* window);
            __DSL_glfwIconifyWindow(__dsl_window);
        }
    }

    int IGlfw.Init() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("glfwInit", "glfw"))();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInit")]
    public static extern int Init();

    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    void IGlfw.InitAllocator([NativeTypeName("const GLFWallocator *")] Ptr<Allocator> allocator)
    {
        fixed (Allocator* __dsl_allocator = allocator)
        {
            void __DSL_glfwInitAllocator(
                [NativeTypeName("const GLFWallocator *")] Allocator* allocator
            ) =>
                (
                    (delegate* unmanaged<Allocator*, void>)
                        nativeContext.LoadFunction("glfwInitAllocator", "glfw")
                )(allocator);
            __DSL_glfwInitAllocator(__dsl_allocator);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwInitAllocator")]
    public static void InitAllocator(
        [NativeTypeName("const GLFWallocator *")] Ptr<Allocator> allocator
    )
    {
        fixed (Allocator* __dsl_allocator = allocator)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInitAllocator")]
            static extern void __DSL_glfwInitAllocator(
                [NativeTypeName("const GLFWallocator *")] Allocator* allocator
            );
            __DSL_glfwInitAllocator(__dsl_allocator);
        }
    }

    void IGlfw.InitHint(int hint, int value) =>
        ((delegate* unmanaged<int, int, void>)nativeContext.LoadFunction("glfwInitHint", "glfw"))(
            hint,
            value
        );

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwInitHint")]
    public static extern void InitHint(int hint, int value);

    int IGlfw.JoystickIsGamepad(int jid) =>
        (
            (delegate* unmanaged<int, int>)
                nativeContext.LoadFunction("glfwJoystickIsGamepad", "glfw")
        )(jid);

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwJoystickIsGamepad")]
    public static extern int JoystickIsGamepad(int jid);

    int IGlfw.JoystickPresent(int jid) =>
        ((delegate* unmanaged<int, int>)nativeContext.LoadFunction("glfwJoystickPresent", "glfw"))(
            jid
        );

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwJoystickPresent")]
    public static extern int JoystickPresent(int jid);

    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    void IGlfw.MakeContextCurrent(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwMakeContextCurrent(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwMakeContextCurrent", "glfw")
                )(window);
            __DSL_glfwMakeContextCurrent(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwMakeContextCurrent")]
    public static void MakeContextCurrent(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMakeContextCurrent")]
            static extern void __DSL_glfwMakeContextCurrent(Window* window);
            __DSL_glfwMakeContextCurrent(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    void IGlfw.MaximizeWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwMaximizeWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwMaximizeWindow", "glfw")
                )(window);
            __DSL_glfwMaximizeWindow(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwMaximizeWindow")]
    public static void MaximizeWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwMaximizeWindow")]
            static extern void __DSL_glfwMaximizeWindow(Window* window);
            __DSL_glfwMaximizeWindow(__dsl_window);
        }
    }

    int IGlfw.PlatformSupported(int platform) =>
        (
            (delegate* unmanaged<int, int>)
                nativeContext.LoadFunction("glfwPlatformSupported", "glfw")
        )(platform);

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwPlatformSupported")]
    public static extern int PlatformSupported(int platform);

    void IGlfw.PollEvents() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwPollEvents", "glfw"))();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwPollEvents")]
    public static extern void PollEvents();

    void IGlfw.PostEmptyEvent() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwPostEmptyEvent", "glfw"))();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwPostEmptyEvent")]
    public static extern void PostEmptyEvent();

    int IGlfw.RawMouseMotionSupported() =>
        (
            (delegate* unmanaged<int>)
                nativeContext.LoadFunction("glfwRawMouseMotionSupported", "glfw")
        )();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRawMouseMotionSupported")]
    public static extern int RawMouseMotionSupported();

    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    void IGlfw.RequestWindowAttention(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwRequestWindowAttention(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwRequestWindowAttention", "glfw")
                )(window);
            __DSL_glfwRequestWindowAttention(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwRequestWindowAttention")]
    public static void RequestWindowAttention(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRequestWindowAttention")]
            static extern void __DSL_glfwRequestWindowAttention(Window* window);
            __DSL_glfwRequestWindowAttention(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    void IGlfw.RestoreWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwRestoreWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwRestoreWindow", "glfw")
                )(window);
            __DSL_glfwRestoreWindow(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwRestoreWindow")]
    public static void RestoreWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwRestoreWindow")]
            static extern void __DSL_glfwRestoreWindow(Window* window);
            __DSL_glfwRestoreWindow(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    delegate* unmanaged<Window*, uint, void> IGlfw.SetCharCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, uint, void> __DSL_glfwSetCharCallback(
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
            return __DSL_glfwSetCharCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcharfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharCallback")]
    public static delegate* unmanaged<Window*, uint, void> SetCharCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharCallback")]
            [return: NativeTypeName("GLFWcharfun")]
            static extern delegate* unmanaged<Window*, uint, void> __DSL_glfwSetCharCallback(
                Window* window,
                [NativeTypeName("GLFWcharfun")] delegate* unmanaged<Window*, uint, void> callback
            );
            return __DSL_glfwSetCharCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    delegate* unmanaged<Window*, uint, int, void> IGlfw.SetCharModsCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, uint, int, void> __DSL_glfwSetCharModsCallback(
                Window* window,
                [NativeTypeName("GLFWcharmodsfun")]
                    delegate* unmanaged<Window*, uint, int, void> callback
            ) =>
                (
                    (delegate* unmanaged<
                        Window*,
                        delegate* unmanaged<Window*, uint, int, void>,
                        delegate* unmanaged<Window*, uint, int, void>>)
                        nativeContext.LoadFunction("glfwSetCharModsCallback", "glfw")
                )(window, callback);
            return __DSL_glfwSetCharModsCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcharmodsfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCharModsCallback")]
    public static delegate* unmanaged<Window*, uint, int, void> SetCharModsCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<Window*, uint, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCharModsCallback")]
            [return: NativeTypeName("GLFWcharmodsfun")]
            static extern delegate* unmanaged<
                Window*,
                uint,
                int,
                void> __DSL_glfwSetCharModsCallback(
                Window* window,
                [NativeTypeName("GLFWcharmodsfun")]
                    delegate* unmanaged<Window*, uint, int, void> callback
            );
            return __DSL_glfwSetCharModsCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    void IGlfw.SetClipboardString(
        Mut<Window> window,
        [NativeTypeName("const char *")] Ptr<sbyte> @string
    )
    {
        fixed (sbyte* __dsl_string = @string)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetClipboardString(
                Window* window,
                [NativeTypeName("const char *")] sbyte* @string
            ) =>
                (
                    (delegate* unmanaged<Window*, sbyte*, void>)
                        nativeContext.LoadFunction("glfwSetClipboardString", "glfw")
                )(window, @string);
            __DSL_glfwSetClipboardString(__dsl_window, __dsl_string);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetClipboardString")]
    public static void SetClipboardString(
        Mut<Window> window,
        [NativeTypeName("const char *")] Ptr<sbyte> @string
    )
    {
        fixed (sbyte* __dsl_string = @string)
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetClipboardString")]
            static extern void __DSL_glfwSetClipboardString(
                Window* window,
                [NativeTypeName("const char *")] sbyte* @string
            );
            __DSL_glfwSetClipboardString(__dsl_window, __dsl_string);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    void IGlfw.SetCursor(Mut<Window> window, Mut<Cursor> cursor)
    {
        fixed (Cursor* __dsl_cursor = cursor)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetCursor(Window* window, Cursor* cursor) =>
                (
                    (delegate* unmanaged<Window*, Cursor*, void>)
                        nativeContext.LoadFunction("glfwSetCursor", "glfw")
                )(window, cursor);
            __DSL_glfwSetCursor(__dsl_window, __dsl_cursor);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursor")]
    public static void SetCursor(Mut<Window> window, Mut<Cursor> cursor)
    {
        fixed (Cursor* __dsl_cursor = cursor)
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursor")]
            static extern void __DSL_glfwSetCursor(Window* window, Cursor* cursor);
            __DSL_glfwSetCursor(__dsl_window, __dsl_cursor);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetCursorEnterCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, void> __DSL_glfwSetCursorEnterCallback(
                Window* window,
                [NativeTypeName("GLFWcursorenterfun")]
                    delegate* unmanaged<Window*, int, void> callback
            ) =>
                (
                    (delegate* unmanaged<
                        Window*,
                        delegate* unmanaged<Window*, int, void>,
                        delegate* unmanaged<Window*, int, void>>)
                        nativeContext.LoadFunction("glfwSetCursorEnterCallback", "glfw")
                )(window, callback);
            return __DSL_glfwSetCursorEnterCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcursorenterfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorEnterCallback")]
    public static delegate* unmanaged<Window*, int, void> SetCursorEnterCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorEnterCallback")]
            [return: NativeTypeName("GLFWcursorenterfun")]
            static extern delegate* unmanaged<Window*, int, void> __DSL_glfwSetCursorEnterCallback(
                Window* window,
                [NativeTypeName("GLFWcursorenterfun")]
                    delegate* unmanaged<Window*, int, void> callback
            );
            return __DSL_glfwSetCursorEnterCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    void IGlfw.SetCursorPos(Mut<Window> window, double xpos, double ypos)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetCursorPos(Window* window, double xpos, double ypos) =>
                (
                    (delegate* unmanaged<Window*, double, double, void>)
                        nativeContext.LoadFunction("glfwSetCursorPos", "glfw")
                )(window, xpos, ypos);
            __DSL_glfwSetCursorPos(__dsl_window, xpos, ypos);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPos")]
    public static void SetCursorPos(Mut<Window> window, double xpos, double ypos)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPos")]
            static extern void __DSL_glfwSetCursorPos(Window* window, double xpos, double ypos);
            __DSL_glfwSetCursorPos(__dsl_window, xpos, ypos);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    delegate* unmanaged<Window*, double, double, void> IGlfw.SetCursorPosCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, double, double, void> __DSL_glfwSetCursorPosCallback(
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
            return __DSL_glfwSetCursorPosCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWcursorposfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetCursorPosCallback")]
    public static delegate* unmanaged<Window*, double, double, void> SetCursorPosCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWcursorposfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetCursorPosCallback")]
            [return: NativeTypeName("GLFWcursorposfun")]
            static extern delegate* unmanaged<
                Window*,
                double,
                double,
                void> __DSL_glfwSetCursorPosCallback(
                Window* window,
                [NativeTypeName("GLFWcursorposfun")]
                    delegate* unmanaged<Window*, double, double, void> callback
            );
            return __DSL_glfwSetCursorPosCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    delegate* unmanaged<Window*, int, sbyte**, void> IGlfw.SetDropCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, sbyte**, void> __DSL_glfwSetDropCallback(
                Window* window,
                [NativeTypeName("GLFWdropfun")]
                    delegate* unmanaged<Window*, int, sbyte**, void> callback
            ) =>
                (
                    (delegate* unmanaged<
                        Window*,
                        delegate* unmanaged<Window*, int, sbyte**, void>,
                        delegate* unmanaged<Window*, int, sbyte**, void>>)
                        nativeContext.LoadFunction("glfwSetDropCallback", "glfw")
                )(window, callback);
            return __DSL_glfwSetDropCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWdropfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetDropCallback")]
    public static delegate* unmanaged<Window*, int, sbyte**, void> SetDropCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWdropfun")] delegate* unmanaged<Window*, int, sbyte**, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetDropCallback")]
            [return: NativeTypeName("GLFWdropfun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                sbyte**,
                void> __DSL_glfwSetDropCallback(
                Window* window,
                [NativeTypeName("GLFWdropfun")]
                    delegate* unmanaged<Window*, int, sbyte**, void> callback
            );
            return __DSL_glfwSetDropCallback(__dsl_window, callback);
        }
    }

    delegate* unmanaged<int, sbyte*, void> IGlfw.SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<int, sbyte*, void>,
                delegate* unmanaged<int, sbyte*, void>>)
                nativeContext.LoadFunction("glfwSetErrorCallback", "glfw")
        )(callback);

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetErrorCallback")]
    [return: NativeTypeName("GLFWerrorfun")]
    public static extern delegate* unmanaged<int, sbyte*, void> SetErrorCallback(
        [NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> IGlfw.SetFramebufferSizeCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, int, void> __DSL_glfwSetFramebufferSizeCallback(
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
            return __DSL_glfwSetFramebufferSizeCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWframebuffersizefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetFramebufferSizeCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetFramebufferSizeCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWframebuffersizefun")]
            delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetFramebufferSizeCallback")]
            [return: NativeTypeName("GLFWframebuffersizefun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                int,
                void> __DSL_glfwSetFramebufferSizeCallback(
                Window* window,
                [NativeTypeName("GLFWframebuffersizefun")]
                    delegate* unmanaged<Window*, int, int, void> callback
            );
            return __DSL_glfwSetFramebufferSizeCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    void IGlfw.SetGamma(Mut<Monitor> monitor, float gamma)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwSetGamma(Monitor* monitor, float gamma) =>
                (
                    (delegate* unmanaged<Monitor*, float, void>)
                        nativeContext.LoadFunction("glfwSetGamma", "glfw")
                )(monitor, gamma);
            __DSL_glfwSetGamma(__dsl_monitor, gamma);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetGamma")]
    public static void SetGamma(Mut<Monitor> monitor, float gamma)
    {
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGamma")]
            static extern void __DSL_glfwSetGamma(Monitor* monitor, float gamma);
            __DSL_glfwSetGamma(__dsl_monitor, gamma);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    void IGlfw.SetGammaRamp(
        Mut<Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] Ptr<Gammaramp> ramp
    )
    {
        fixed (Gammaramp* __dsl_ramp = ramp)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwSetGammaRamp(
                Monitor* monitor,
                [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
            ) =>
                (
                    (delegate* unmanaged<Monitor*, Gammaramp*, void>)
                        nativeContext.LoadFunction("glfwSetGammaRamp", "glfw")
                )(monitor, ramp);
            __DSL_glfwSetGammaRamp(__dsl_monitor, __dsl_ramp);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetGammaRamp")]
    public static void SetGammaRamp(
        Mut<Monitor> monitor,
        [NativeTypeName("const GLFWgammaramp *")] Ptr<Gammaramp> ramp
    )
    {
        fixed (Gammaramp* __dsl_ramp = ramp)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetGammaRamp")]
            static extern void __DSL_glfwSetGammaRamp(
                Monitor* monitor,
                [NativeTypeName("const GLFWgammaramp *")] Gammaramp* ramp
            );
            __DSL_glfwSetGammaRamp(__dsl_monitor, __dsl_ramp);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    void IGlfw.SetInputMode(Mut<Window> window, int mode, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetInputMode(Window* window, int mode, int value) =>
                (
                    (delegate* unmanaged<Window*, int, int, void>)
                        nativeContext.LoadFunction("glfwSetInputMode", "glfw")
                )(window, mode, value);
            __DSL_glfwSetInputMode(__dsl_window, mode, value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetInputMode")]
    public static void SetInputMode(Mut<Window> window, int mode, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetInputMode")]
            static extern void __DSL_glfwSetInputMode(Window* window, int mode, int value);
            __DSL_glfwSetInputMode(__dsl_window, mode, value);
        }
    }

    delegate* unmanaged<int, int, void> IGlfw.SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<int, int, void>,
                delegate* unmanaged<int, int, void>>)
                nativeContext.LoadFunction("glfwSetJoystickCallback", "glfw")
        )(callback);

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetJoystickCallback")]
    [return: NativeTypeName("GLFWjoystickfun")]
    public static extern delegate* unmanaged<int, int, void> SetJoystickCallback(
        [NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    void IGlfw.SetJoystickUserPointer(int jid, Mut pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        {
            void __DSL_glfwSetJoystickUserPointer(int jid, void* pointer) =>
                (
                    (delegate* unmanaged<int, void*, void>)
                        nativeContext.LoadFunction("glfwSetJoystickUserPointer", "glfw")
                )(jid, pointer);
            __DSL_glfwSetJoystickUserPointer(jid, __dsl_pointer);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetJoystickUserPointer")]
    public static void SetJoystickUserPointer(int jid, Mut pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetJoystickUserPointer")]
            static extern void __DSL_glfwSetJoystickUserPointer(int jid, void* pointer);
            __DSL_glfwSetJoystickUserPointer(jid, __dsl_pointer);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    delegate* unmanaged<Window*, int, int, int, int, void> IGlfw.SetKeyCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, int, int, int, void> __DSL_glfwSetKeyCallback(
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
            return __DSL_glfwSetKeyCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWkeyfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetKeyCallback")]
    public static delegate* unmanaged<Window*, int, int, int, int, void> SetKeyCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWkeyfun")]
            delegate* unmanaged<Window*, int, int, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetKeyCallback")]
            [return: NativeTypeName("GLFWkeyfun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                int,
                int,
                int,
                void> __DSL_glfwSetKeyCallback(
                Window* window,
                [NativeTypeName("GLFWkeyfun")]
                    delegate* unmanaged<Window*, int, int, int, int, void> callback
            );
            return __DSL_glfwSetKeyCallback(__dsl_window, callback);
        }
    }

    delegate* unmanaged<Monitor*, int, void> IGlfw.SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    ) =>
        (
            (delegate* unmanaged<
                delegate* unmanaged<Monitor*, int, void>,
                delegate* unmanaged<Monitor*, int, void>>)
                nativeContext.LoadFunction("glfwSetMonitorCallback", "glfw")
        )(callback);

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMonitorCallback")]
    [return: NativeTypeName("GLFWmonitorfun")]
    public static extern delegate* unmanaged<Monitor*, int, void> SetMonitorCallback(
        [NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<Monitor*, int, void> callback
    );

    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    void IGlfw.SetMonitorUserPointer(Mut<Monitor> monitor, Mut pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            void __DSL_glfwSetMonitorUserPointer(Monitor* monitor, void* pointer) =>
                (
                    (delegate* unmanaged<Monitor*, void*, void>)
                        nativeContext.LoadFunction("glfwSetMonitorUserPointer", "glfw")
                )(monitor, pointer);
            __DSL_glfwSetMonitorUserPointer(__dsl_monitor, __dsl_pointer);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetMonitorUserPointer")]
    public static void SetMonitorUserPointer(Mut<Monitor> monitor, Mut pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (Monitor* __dsl_monitor = monitor)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMonitorUserPointer")]
            static extern void __DSL_glfwSetMonitorUserPointer(Monitor* monitor, void* pointer);
            __DSL_glfwSetMonitorUserPointer(__dsl_monitor, __dsl_pointer);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    delegate* unmanaged<Window*, int, int, int, void> IGlfw.SetMouseButtonCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, int, int, void> __DSL_glfwSetMouseButtonCallback(
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
            return __DSL_glfwSetMouseButtonCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWmousebuttonfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetMouseButtonCallback")]
    public static delegate* unmanaged<Window*, int, int, int, void> SetMouseButtonCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWmousebuttonfun")]
            delegate* unmanaged<Window*, int, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetMouseButtonCallback")]
            [return: NativeTypeName("GLFWmousebuttonfun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                int,
                int,
                void> __DSL_glfwSetMouseButtonCallback(
                Window* window,
                [NativeTypeName("GLFWmousebuttonfun")]
                    delegate* unmanaged<Window*, int, int, int, void> callback
            );
            return __DSL_glfwSetMouseButtonCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    delegate* unmanaged<Window*, double, double, void> IGlfw.SetScrollCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, double, double, void> __DSL_glfwSetScrollCallback(
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
            return __DSL_glfwSetScrollCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWscrollfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetScrollCallback")]
    public static delegate* unmanaged<Window*, double, double, void> SetScrollCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWscrollfun")]
            delegate* unmanaged<Window*, double, double, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetScrollCallback")]
            [return: NativeTypeName("GLFWscrollfun")]
            static extern delegate* unmanaged<
                Window*,
                double,
                double,
                void> __DSL_glfwSetScrollCallback(
                Window* window,
                [NativeTypeName("GLFWscrollfun")]
                    delegate* unmanaged<Window*, double, double, void> callback
            );
            return __DSL_glfwSetScrollCallback(__dsl_window, callback);
        }
    }

    void IGlfw.SetTime(double time) =>
        ((delegate* unmanaged<double, void>)nativeContext.LoadFunction("glfwSetTime", "glfw"))(
            time
        );

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetTime")]
    public static extern void SetTime(double time);

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    void IGlfw.SetWindowAspectRatio(Mut<Window> window, int numer, int denom)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowAspectRatio(Window* window, int numer, int denom) =>
                (
                    (delegate* unmanaged<Window*, int, int, void>)
                        nativeContext.LoadFunction("glfwSetWindowAspectRatio", "glfw")
                )(window, numer, denom);
            __DSL_glfwSetWindowAspectRatio(__dsl_window, numer, denom);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAspectRatio")]
    public static void SetWindowAspectRatio(Mut<Window> window, int numer, int denom)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAspectRatio")]
            static extern void __DSL_glfwSetWindowAspectRatio(Window* window, int numer, int denom);
            __DSL_glfwSetWindowAspectRatio(__dsl_window, numer, denom);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    void IGlfw.SetWindowAttrib(Mut<Window> window, int attrib, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowAttrib(Window* window, int attrib, int value) =>
                (
                    (delegate* unmanaged<Window*, int, int, void>)
                        nativeContext.LoadFunction("glfwSetWindowAttrib", "glfw")
                )(window, attrib, value);
            __DSL_glfwSetWindowAttrib(__dsl_window, attrib, value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowAttrib")]
    public static void SetWindowAttrib(Mut<Window> window, int attrib, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowAttrib")]
            static extern void __DSL_glfwSetWindowAttrib(Window* window, int attrib, int value);
            __DSL_glfwSetWindowAttrib(__dsl_window, attrib, value);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    delegate* unmanaged<Window*, void> IGlfw.SetWindowCloseCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, void> __DSL_glfwSetWindowCloseCallback(
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
            return __DSL_glfwSetWindowCloseCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowclosefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowCloseCallback")]
    public static delegate* unmanaged<Window*, void> SetWindowCloseCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowCloseCallback")]
            [return: NativeTypeName("GLFWwindowclosefun")]
            static extern delegate* unmanaged<Window*, void> __DSL_glfwSetWindowCloseCallback(
                Window* window,
                [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<Window*, void> callback
            );
            return __DSL_glfwSetWindowCloseCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    delegate* unmanaged<Window*, float, float, void> IGlfw.SetWindowContentScaleCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<
                Window*,
                float,
                float,
                void> __DSL_glfwSetWindowContentScaleCallback(
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
            return __DSL_glfwSetWindowContentScaleCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowContentScaleCallback")]
    public static delegate* unmanaged<Window*, float, float, void> SetWindowContentScaleCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowcontentscalefun")]
            delegate* unmanaged<Window*, float, float, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport(
                "glfw",
                ExactSpelling = true,
                EntryPoint = "glfwSetWindowContentScaleCallback"
            )]
            [return: NativeTypeName("GLFWwindowcontentscalefun")]
            static extern delegate* unmanaged<
                Window*,
                float,
                float,
                void> __DSL_glfwSetWindowContentScaleCallback(
                Window* window,
                [NativeTypeName("GLFWwindowcontentscalefun")]
                    delegate* unmanaged<Window*, float, float, void> callback
            );
            return __DSL_glfwSetWindowContentScaleCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowFocusCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowFocusCallback(
                Window* window,
                [NativeTypeName("GLFWwindowfocusfun")]
                    delegate* unmanaged<Window*, int, void> callback
            ) =>
                (
                    (delegate* unmanaged<
                        Window*,
                        delegate* unmanaged<Window*, int, void>,
                        delegate* unmanaged<Window*, int, void>>)
                        nativeContext.LoadFunction("glfwSetWindowFocusCallback", "glfw")
                )(window, callback);
            return __DSL_glfwSetWindowFocusCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowfocusfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowFocusCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowFocusCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowFocusCallback")]
            [return: NativeTypeName("GLFWwindowfocusfun")]
            static extern delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowFocusCallback(
                Window* window,
                [NativeTypeName("GLFWwindowfocusfun")]
                    delegate* unmanaged<Window*, int, void> callback
            );
            return __DSL_glfwSetWindowFocusCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    void IGlfw.SetWindowIcon(
        Mut<Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] Ptr<Image> images
    )
    {
        fixed (Image* __dsl_images = images)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowIcon(
                Window* window,
                int count,
                [NativeTypeName("const GLFWimage *")] Image* images
            ) =>
                (
                    (delegate* unmanaged<Window*, int, Image*, void>)
                        nativeContext.LoadFunction("glfwSetWindowIcon", "glfw")
                )(window, count, images);
            __DSL_glfwSetWindowIcon(__dsl_window, count, __dsl_images);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIcon")]
    public static void SetWindowIcon(
        Mut<Window> window,
        int count,
        [NativeTypeName("const GLFWimage *")] Ptr<Image> images
    )
    {
        fixed (Image* __dsl_images = images)
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowIcon")]
            static extern void __DSL_glfwSetWindowIcon(
                Window* window,
                int count,
                [NativeTypeName("const GLFWimage *")] Image* images
            );
            __DSL_glfwSetWindowIcon(__dsl_window, count, __dsl_images);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowIconifyCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowIconifyCallback(
                Window* window,
                [NativeTypeName("GLFWwindowiconifyfun")]
                    delegate* unmanaged<Window*, int, void> callback
            ) =>
                (
                    (delegate* unmanaged<
                        Window*,
                        delegate* unmanaged<Window*, int, void>,
                        delegate* unmanaged<Window*, int, void>>)
                        nativeContext.LoadFunction("glfwSetWindowIconifyCallback", "glfw")
                )(window, callback);
            return __DSL_glfwSetWindowIconifyCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowiconifyfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowIconifyCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowIconifyCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowIconifyCallback")]
            [return: NativeTypeName("GLFWwindowiconifyfun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                void> __DSL_glfwSetWindowIconifyCallback(
                Window* window,
                [NativeTypeName("GLFWwindowiconifyfun")]
                    delegate* unmanaged<Window*, int, void> callback
            );
            return __DSL_glfwSetWindowIconifyCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    delegate* unmanaged<Window*, int, void> IGlfw.SetWindowMaximizeCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, void> __DSL_glfwSetWindowMaximizeCallback(
                Window* window,
                [NativeTypeName("GLFWwindowmaximizefun")]
                    delegate* unmanaged<Window*, int, void> callback
            ) =>
                (
                    (delegate* unmanaged<
                        Window*,
                        delegate* unmanaged<Window*, int, void>,
                        delegate* unmanaged<Window*, int, void>>)
                        nativeContext.LoadFunction("glfwSetWindowMaximizeCallback", "glfw")
                )(window, callback);
            return __DSL_glfwSetWindowMaximizeCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowmaximizefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMaximizeCallback")]
    public static delegate* unmanaged<Window*, int, void> SetWindowMaximizeCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<Window*, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowMaximizeCallback")]
            [return: NativeTypeName("GLFWwindowmaximizefun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                void> __DSL_glfwSetWindowMaximizeCallback(
                Window* window,
                [NativeTypeName("GLFWwindowmaximizefun")]
                    delegate* unmanaged<Window*, int, void> callback
            );
            return __DSL_glfwSetWindowMaximizeCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    void IGlfw.SetWindowMonitor(
        Mut<Window> window,
        Mut<Monitor> monitor,
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
            void __DSL_glfwSetWindowMonitor(
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
            __DSL_glfwSetWindowMonitor(
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

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowMonitor")]
    public static void SetWindowMonitor(
        Mut<Window> window,
        Mut<Monitor> monitor,
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
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowMonitor")]
            static extern void __DSL_glfwSetWindowMonitor(
                Window* window,
                Monitor* monitor,
                int xpos,
                int ypos,
                int width,
                int height,
                int refreshRate
            );
            __DSL_glfwSetWindowMonitor(
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
    void IGlfw.SetWindowOpacity(Mut<Window> window, float opacity)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowOpacity(Window* window, float opacity) =>
                (
                    (delegate* unmanaged<Window*, float, void>)
                        nativeContext.LoadFunction("glfwSetWindowOpacity", "glfw")
                )(window, opacity);
            __DSL_glfwSetWindowOpacity(__dsl_window, opacity);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowOpacity")]
    public static void SetWindowOpacity(Mut<Window> window, float opacity)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowOpacity")]
            static extern void __DSL_glfwSetWindowOpacity(Window* window, float opacity);
            __DSL_glfwSetWindowOpacity(__dsl_window, opacity);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    void IGlfw.SetWindowPos(Mut<Window> window, int xpos, int ypos)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowPos(Window* window, int xpos, int ypos) =>
                (
                    (delegate* unmanaged<Window*, int, int, void>)
                        nativeContext.LoadFunction("glfwSetWindowPos", "glfw")
                )(window, xpos, ypos);
            __DSL_glfwSetWindowPos(__dsl_window, xpos, ypos);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPos")]
    public static void SetWindowPos(Mut<Window> window, int xpos, int ypos)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPos")]
            static extern void __DSL_glfwSetWindowPos(Window* window, int xpos, int ypos);
            __DSL_glfwSetWindowPos(__dsl_window, xpos, ypos);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    delegate* unmanaged<Window*, int, int, void> IGlfw.SetWindowPosCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, int, void> __DSL_glfwSetWindowPosCallback(
                Window* window,
                [NativeTypeName("GLFWwindowposfun")]
                    delegate* unmanaged<Window*, int, int, void> callback
            ) =>
                (
                    (delegate* unmanaged<
                        Window*,
                        delegate* unmanaged<Window*, int, int, void>,
                        delegate* unmanaged<Window*, int, int, void>>)
                        nativeContext.LoadFunction("glfwSetWindowPosCallback", "glfw")
                )(window, callback);
            return __DSL_glfwSetWindowPosCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowposfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowPosCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetWindowPosCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowPosCallback")]
            [return: NativeTypeName("GLFWwindowposfun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                int,
                void> __DSL_glfwSetWindowPosCallback(
                Window* window,
                [NativeTypeName("GLFWwindowposfun")]
                    delegate* unmanaged<Window*, int, int, void> callback
            );
            return __DSL_glfwSetWindowPosCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    delegate* unmanaged<Window*, void> IGlfw.SetWindowRefreshCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, void> __DSL_glfwSetWindowRefreshCallback(
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
            return __DSL_glfwSetWindowRefreshCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowrefreshfun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowRefreshCallback")]
    public static delegate* unmanaged<Window*, void> SetWindowRefreshCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowRefreshCallback")]
            [return: NativeTypeName("GLFWwindowrefreshfun")]
            static extern delegate* unmanaged<Window*, void> __DSL_glfwSetWindowRefreshCallback(
                Window* window,
                [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<Window*, void> callback
            );
            return __DSL_glfwSetWindowRefreshCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    void IGlfw.SetWindowShouldClose(Mut<Window> window, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowShouldClose(Window* window, int value) =>
                (
                    (delegate* unmanaged<Window*, int, void>)
                        nativeContext.LoadFunction("glfwSetWindowShouldClose", "glfw")
                )(window, value);
            __DSL_glfwSetWindowShouldClose(__dsl_window, value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowShouldClose")]
    public static void SetWindowShouldClose(Mut<Window> window, int value)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowShouldClose")]
            static extern void __DSL_glfwSetWindowShouldClose(Window* window, int value);
            __DSL_glfwSetWindowShouldClose(__dsl_window, value);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    void IGlfw.SetWindowSize(Mut<Window> window, int width, int height)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowSize(Window* window, int width, int height) =>
                (
                    (delegate* unmanaged<Window*, int, int, void>)
                        nativeContext.LoadFunction("glfwSetWindowSize", "glfw")
                )(window, width, height);
            __DSL_glfwSetWindowSize(__dsl_window, width, height);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSize")]
    public static void SetWindowSize(Mut<Window> window, int width, int height)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSize")]
            static extern void __DSL_glfwSetWindowSize(Window* window, int width, int height);
            __DSL_glfwSetWindowSize(__dsl_window, width, height);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    delegate* unmanaged<Window*, int, int, void> IGlfw.SetWindowSizeCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            delegate* unmanaged<Window*, int, int, void> __DSL_glfwSetWindowSizeCallback(
                Window* window,
                [NativeTypeName("GLFWwindowsizefun")]
                    delegate* unmanaged<Window*, int, int, void> callback
            ) =>
                (
                    (delegate* unmanaged<
                        Window*,
                        delegate* unmanaged<Window*, int, int, void>,
                        delegate* unmanaged<Window*, int, int, void>>)
                        nativeContext.LoadFunction("glfwSetWindowSizeCallback", "glfw")
                )(window, callback);
            return __DSL_glfwSetWindowSizeCallback(__dsl_window, callback);
        }
    }

    [return: NativeTypeName("GLFWwindowsizefun")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeCallback")]
    public static delegate* unmanaged<Window*, int, int, void> SetWindowSizeCallback(
        Mut<Window> window,
        [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<Window*, int, int, void> callback
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeCallback")]
            [return: NativeTypeName("GLFWwindowsizefun")]
            static extern delegate* unmanaged<
                Window*,
                int,
                int,
                void> __DSL_glfwSetWindowSizeCallback(
                Window* window,
                [NativeTypeName("GLFWwindowsizefun")]
                    delegate* unmanaged<Window*, int, int, void> callback
            );
            return __DSL_glfwSetWindowSizeCallback(__dsl_window, callback);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    void IGlfw.SetWindowSizeLimits(
        Mut<Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    )
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowSizeLimits(
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
            __DSL_glfwSetWindowSizeLimits(__dsl_window, minwidth, minheight, maxwidth, maxheight);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowSizeLimits")]
    public static void SetWindowSizeLimits(
        Mut<Window> window,
        int minwidth,
        int minheight,
        int maxwidth,
        int maxheight
    )
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowSizeLimits")]
            static extern void __DSL_glfwSetWindowSizeLimits(
                Window* window,
                int minwidth,
                int minheight,
                int maxwidth,
                int maxheight
            );
            __DSL_glfwSetWindowSizeLimits(__dsl_window, minwidth, minheight, maxwidth, maxheight);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    void IGlfw.SetWindowTitle(Mut<Window> window, [NativeTypeName("const char *")] Ptr<sbyte> title)
    {
        fixed (sbyte* __dsl_title = title)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowTitle(
                Window* window,
                [NativeTypeName("const char *")] sbyte* title
            ) =>
                (
                    (delegate* unmanaged<Window*, sbyte*, void>)
                        nativeContext.LoadFunction("glfwSetWindowTitle", "glfw")
                )(window, title);
            __DSL_glfwSetWindowTitle(__dsl_window, __dsl_title);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowTitle")]
    public static void SetWindowTitle(
        Mut<Window> window,
        [NativeTypeName("const char *")] Ptr<sbyte> title
    )
    {
        fixed (sbyte* __dsl_title = title)
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowTitle")]
            static extern void __DSL_glfwSetWindowTitle(
                Window* window,
                [NativeTypeName("const char *")] sbyte* title
            );
            __DSL_glfwSetWindowTitle(__dsl_window, __dsl_title);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    void IGlfw.SetWindowUserPointer(Mut<Window> window, Mut pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSetWindowUserPointer(Window* window, void* pointer) =>
                (
                    (delegate* unmanaged<Window*, void*, void>)
                        nativeContext.LoadFunction("glfwSetWindowUserPointer", "glfw")
                )(window, pointer);
            __DSL_glfwSetWindowUserPointer(__dsl_window, __dsl_pointer);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSetWindowUserPointer")]
    public static void SetWindowUserPointer(Mut<Window> window, Mut pointer)
    {
        fixed (void* __dsl_pointer = pointer)
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSetWindowUserPointer")]
            static extern void __DSL_glfwSetWindowUserPointer(Window* window, void* pointer);
            __DSL_glfwSetWindowUserPointer(__dsl_window, __dsl_pointer);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    void IGlfw.ShowWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwShowWindow(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwShowWindow", "glfw")
                )(window);
            __DSL_glfwShowWindow(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwShowWindow")]
    public static void ShowWindow(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwShowWindow")]
            static extern void __DSL_glfwShowWindow(Window* window);
            __DSL_glfwShowWindow(__dsl_window);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    void IGlfw.SwapBuffers(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            void __DSL_glfwSwapBuffers(Window* window) =>
                (
                    (delegate* unmanaged<Window*, void>)
                        nativeContext.LoadFunction("glfwSwapBuffers", "glfw")
                )(window);
            __DSL_glfwSwapBuffers(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwSwapBuffers")]
    public static void SwapBuffers(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSwapBuffers")]
            static extern void __DSL_glfwSwapBuffers(Window* window);
            __DSL_glfwSwapBuffers(__dsl_window);
        }
    }

    void IGlfw.SwapInterval(int interval) =>
        ((delegate* unmanaged<int, void>)nativeContext.LoadFunction("glfwSwapInterval", "glfw"))(
            interval
        );

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwSwapInterval")]
    public static extern void SwapInterval(int interval);

    void IGlfw.Terminate() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwTerminate", "glfw"))();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwTerminate")]
    public static extern void Terminate();

    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    int IGlfw.UpdateGamepadMappings([NativeTypeName("const char *")] Ptr<sbyte> @string)
    {
        fixed (sbyte* __dsl_string = @string)
        {
            int __DSL_glfwUpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string) =>
                (
                    (delegate* unmanaged<sbyte*, int>)
                        nativeContext.LoadFunction("glfwUpdateGamepadMappings", "glfw")
                )(@string);
            return __DSL_glfwUpdateGamepadMappings(__dsl_string);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwUpdateGamepadMappings")]
    public static int UpdateGamepadMappings([NativeTypeName("const char *")] Ptr<sbyte> @string)
    {
        fixed (sbyte* __dsl_string = @string)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwUpdateGamepadMappings")]
            static extern int __DSL_glfwUpdateGamepadMappings(
                [NativeTypeName("const char *")] sbyte* @string
            );
            return __DSL_glfwUpdateGamepadMappings(__dsl_string);
        }
    }

    int IGlfw.VulkanSupported() =>
        ((delegate* unmanaged<int>)nativeContext.LoadFunction("glfwVulkanSupported", "glfw"))();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwVulkanSupported")]
    public static extern int VulkanSupported();

    void IGlfw.WaitEvents() =>
        ((delegate* unmanaged<void>)nativeContext.LoadFunction("glfwWaitEvents", "glfw"))();

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWaitEvents")]
    public static extern void WaitEvents();

    void IGlfw.WaitEventsTimeout(double timeout) =>
        (
            (delegate* unmanaged<double, void>)
                nativeContext.LoadFunction("glfwWaitEventsTimeout", "glfw")
        )(timeout);

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWaitEventsTimeout")]
    public static extern void WaitEventsTimeout(double timeout);

    void IGlfw.WindowHint(int hint, int value) =>
        ((delegate* unmanaged<int, int, void>)nativeContext.LoadFunction("glfwWindowHint", "glfw"))(
            hint,
            value
        );

    [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowHint")]
    public static extern void WindowHint(int hint, int value);

    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    void IGlfw.WindowHintString(int hint, [NativeTypeName("const char *")] Ptr<sbyte> value)
    {
        fixed (sbyte* __dsl_value = value)
        {
            void __DSL_glfwWindowHintString(
                int hint,
                [NativeTypeName("const char *")] sbyte* value
            ) =>
                (
                    (delegate* unmanaged<int, sbyte*, void>)
                        nativeContext.LoadFunction("glfwWindowHintString", "glfw")
                )(hint, value);
            __DSL_glfwWindowHintString(hint, __dsl_value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwWindowHintString")]
    public static void WindowHintString(int hint, [NativeTypeName("const char *")] Ptr<sbyte> value)
    {
        fixed (sbyte* __dsl_value = value)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowHintString")]
            static extern void __DSL_glfwWindowHintString(
                int hint,
                [NativeTypeName("const char *")] sbyte* value
            );
            __DSL_glfwWindowHintString(hint, __dsl_value);
        }
    }

    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    int IGlfw.WindowShouldClose(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            int __DSL_glfwWindowShouldClose(Window* window) =>
                (
                    (delegate* unmanaged<Window*, int>)
                        nativeContext.LoadFunction("glfwWindowShouldClose", "glfw")
                )(window);
            return __DSL_glfwWindowShouldClose(__dsl_window);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    [NativeFunction("glfw", EntryPoint = "glfwWindowShouldClose")]
    public static int WindowShouldClose(Mut<Window> window)
    {
        fixed (Window* __dsl_window = window)
        {
            [DllImport("glfw", ExactSpelling = true, EntryPoint = "glfwWindowShouldClose")]
            static extern int __DSL_glfwWindowShouldClose(Window* window);
            return __DSL_glfwWindowShouldClose(__dsl_window);
        }
    }
}
