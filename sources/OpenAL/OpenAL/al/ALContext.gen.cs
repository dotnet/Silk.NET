// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

public unsafe partial class ALContext : IALContext, IALContext.Static
{
    public partial class DllImport : IALContext.Static
    {
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureCloseDevice")]
        [return: NativeTypeName("ALCboolean")]
        public static extern sbyte CaptureCloseDevice(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureOpenDevice")]
        public static extern DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] int format,
            [NativeTypeName("ALCsizei")] int buffersize
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] int format,
            [NativeTypeName("ALCsizei")] int buffersize
        )
        {
            fixed (sbyte* __dsl_devicename = devicename)
            {
                return (DeviceHandle)CaptureOpenDevice(
                    __dsl_devicename,
                    frequency,
                    format,
                    buffersize
                );
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureSamples")]
        public static extern void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] Ref buffer,
            [NativeTypeName("ALCsizei")] int samples
        )
        {
            fixed (void* __dsl_buffer = buffer)
            {
                CaptureSamples(device, __dsl_buffer, samples);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureStart")]
        public static extern void CaptureStart(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureStop")]
        public static extern void CaptureStop(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCloseDevice")]
        [return: NativeTypeName("ALCboolean")]
        public static extern sbyte CloseDevice(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCreateContext")]
        public static extern ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attrlist
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] Ref<int> attrlist
        )
        {
            fixed (int* __dsl_attrlist = attrlist)
            {
                return (ContextHandle)CreateContext(device, __dsl_attrlist);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcDestroyContext")]
        public static extern void DestroyContext(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetContextsDevice")]
        public static extern DeviceHandle GetContextsDevice(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetCurrentContext")]
        public static extern ContextHandle GetCurrentContext();

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetEnumValue")]
        [return: NativeTypeName("ALCenum")]
        public static extern int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* enumname
        );

        [return: NativeTypeName("ALCenum")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname
        )
        {
            fixed (sbyte* __dsl_enumname = enumname)
            {
                return (int)GetEnumValue(device, __dsl_enumname);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetError")]
        [return: NativeTypeName("ALCenum")]
        public static extern int GetError(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetIntegerv")]
        public static extern void GetIntegerv(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetIntegerv(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetIntegerv(device, param1, size, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetProcAddress")]
        [return: NativeTypeName("ALCvoid *")]
        public static extern void* GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcname
        );

        [return: NativeTypeName("ALCvoid *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
        )
        {
            fixed (sbyte* __dsl_funcname = funcname)
            {
                return (void*)GetProcAddress(device, __dsl_funcname);
            }
        }

        [return: NativeTypeName("const ALCchar *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetString(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1
        ) => (sbyte*)GetStringRaw(device, param1);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetString")]
        [return: NativeTypeName("const ALCchar *")]
        public static extern sbyte* GetStringRaw(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcIsExtensionPresent")]
        [return: NativeTypeName("ALCboolean")]
        public static extern sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* extname
        );

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
        )
        {
            fixed (sbyte* __dsl_extname = extname)
            {
                return (sbyte)IsExtensionPresent(device, __dsl_extname);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcMakeContextCurrent")]
        [return: NativeTypeName("ALCboolean")]
        public static extern sbyte MakeContextCurrent(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcOpenDevice")]
        public static extern DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename
        )
        {
            fixed (sbyte* __dsl_devicename = devicename)
            {
                return (DeviceHandle)OpenDevice(__dsl_devicename);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcProcessContext")]
        public static extern void ProcessContext(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcSuspendContext")]
        public static extern void SuspendContext(ContextHandle context);
    }

    public partial class StaticWrapper<T> : IALContext
        where T : IALContext.Static
    {
        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte CaptureCloseDevice(DeviceHandle device) => T.CaptureCloseDevice(device);

        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] int format,
            [NativeTypeName("ALCsizei")] int buffersize
        ) => T.CaptureOpenDevice(devicename, frequency, format, buffersize);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] int format,
            [NativeTypeName("ALCsizei")] int buffersize
        ) => T.CaptureOpenDevice(devicename, frequency, format, buffersize);

        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        ) => T.CaptureSamples(device, buffer, samples);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] Ref buffer,
            [NativeTypeName("ALCsizei")] int samples
        ) => T.CaptureSamples(device, buffer, samples);

        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureStart(DeviceHandle device) => T.CaptureStart(device);

        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureStop(DeviceHandle device) => T.CaptureStop(device);

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte CloseDevice(DeviceHandle device) => T.CloseDevice(device);

        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attrlist
        ) => T.CreateContext(device, attrlist);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] Ref<int> attrlist
        ) => T.CreateContext(device, attrlist);

        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DestroyContext(ContextHandle context) => T.DestroyContext(context);

        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle GetContextsDevice(ContextHandle context) =>
            T.GetContextsDevice(context);

        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle GetCurrentContext() => T.GetCurrentContext();

        [return: NativeTypeName("ALCenum")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* enumname
        ) => T.GetEnumValue(device, enumname);

        [return: NativeTypeName("ALCenum")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname
        ) => T.GetEnumValue(device, enumname);

        [return: NativeTypeName("ALCenum")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetError(DeviceHandle device) => T.GetError(device);

        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetIntegerv(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] int* values
        ) => T.GetIntegerv(device, param1, size, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetIntegerv(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] Ref<int> values
        ) => T.GetIntegerv(device, param1, size, values);

        [return: NativeTypeName("ALCvoid *")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void* GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcname
        ) => T.GetProcAddress(device, funcname);

        [return: NativeTypeName("ALCvoid *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
        ) => T.GetProcAddress(device, funcname);

        [return: NativeTypeName("const ALCchar *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<sbyte> GetString(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
            T.GetString(device, param1);

        [return: NativeTypeName("const ALCchar *")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte* GetStringRaw(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
            T.GetStringRaw(device, param1);

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* extname
        ) => T.IsExtensionPresent(device, extname);

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
        ) => T.IsExtensionPresent(device, extname);

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte MakeContextCurrent(ContextHandle context) => T.MakeContextCurrent(context);

        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] sbyte* devicename) =>
            T.OpenDevice(devicename);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] Ref<sbyte> devicename) =>
            T.OpenDevice(devicename);

        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void ProcessContext(ContextHandle context) => T.ProcessContext(context);

        [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SuspendContext(ContextHandle context) => T.SuspendContext(context);
    }

    public partial class ThisThread
    {
        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte CaptureCloseDevice(DeviceHandle device) =>
            Underlying.Value!.CaptureCloseDevice(device);

        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] int format,
            [NativeTypeName("ALCsizei")] int buffersize
        ) => Underlying.Value!.CaptureOpenDevice(devicename, frequency, format, buffersize);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] int format,
            [NativeTypeName("ALCsizei")] int buffersize
        )
        {
            fixed (sbyte* __dsl_devicename = devicename)
            {
                return (DeviceHandle)CaptureOpenDevice(
                    __dsl_devicename,
                    frequency,
                    format,
                    buffersize
                );
            }
        }

        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        ) => Underlying.Value!.CaptureSamples(device, buffer, samples);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] Ref buffer,
            [NativeTypeName("ALCsizei")] int samples
        )
        {
            fixed (void* __dsl_buffer = buffer)
            {
                CaptureSamples(device, __dsl_buffer, samples);
            }
        }

        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureStart(DeviceHandle device) =>
            Underlying.Value!.CaptureStart(device);

        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureStop(DeviceHandle device) =>
            Underlying.Value!.CaptureStop(device);

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte CloseDevice(DeviceHandle device) =>
            Underlying.Value!.CloseDevice(device);

        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attrlist
        ) => Underlying.Value!.CreateContext(device, attrlist);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] Ref<int> attrlist
        )
        {
            fixed (int* __dsl_attrlist = attrlist)
            {
                return (ContextHandle)CreateContext(device, __dsl_attrlist);
            }
        }

        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DestroyContext(ContextHandle context) =>
            Underlying.Value!.DestroyContext(context);

        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle GetContextsDevice(ContextHandle context) =>
            Underlying.Value!.GetContextsDevice(context);

        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle GetCurrentContext() => Underlying.Value!.GetCurrentContext();

        [return: NativeTypeName("ALCenum")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* enumname
        ) => Underlying.Value!.GetEnumValue(device, enumname);

        [return: NativeTypeName("ALCenum")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname
        )
        {
            fixed (sbyte* __dsl_enumname = enumname)
            {
                return (int)GetEnumValue(device, __dsl_enumname);
            }
        }

        [return: NativeTypeName("ALCenum")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetError(DeviceHandle device) => Underlying.Value!.GetError(device);

        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetIntegerv(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] int* values
        ) => Underlying.Value!.GetIntegerv(device, param1, size, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetIntegerv(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetIntegerv(device, param1, size, __dsl_values);
            }
        }

        [return: NativeTypeName("ALCvoid *")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void* GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcname
        ) => Underlying.Value!.GetProcAddress(device, funcname);

        [return: NativeTypeName("ALCvoid *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
        )
        {
            fixed (sbyte* __dsl_funcname = funcname)
            {
                return (void*)GetProcAddress(device, __dsl_funcname);
            }
        }

        [return: NativeTypeName("const ALCchar *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetString(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1
        ) => Underlying.Value!.GetString(device, param1);

        [return: NativeTypeName("const ALCchar *")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte* GetStringRaw(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1
        ) => Underlying.Value!.GetStringRaw(device, param1);

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* extname
        ) => Underlying.Value!.IsExtensionPresent(device, extname);

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
        )
        {
            fixed (sbyte* __dsl_extname = extname)
            {
                return (sbyte)IsExtensionPresent(device, __dsl_extname);
            }
        }

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte MakeContextCurrent(ContextHandle context) =>
            Underlying.Value!.MakeContextCurrent(context);

        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename
        ) => Underlying.Value!.OpenDevice(devicename);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename
        )
        {
            fixed (sbyte* __dsl_devicename = devicename)
            {
                return (DeviceHandle)OpenDevice(__dsl_devicename);
            }
        }

        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void ProcessContext(ContextHandle context) =>
            Underlying.Value!.ProcessContext(context);

        [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SuspendContext(ContextHandle context) =>
            Underlying.Value!.SuspendContext(context);
    }

    [NativeTypeName("#define ALC_CPLUSPLUS __cplusplus")]
    public const nint Cplusplus = 201703;

    [NativeTypeName("#define ALC_INVALID 0")]
    public const int Invalid = 0;

    [NativeTypeName("#define ALC_VERSION_0_1 1")]
    public const int Version0X1 = 1;

    [NativeTypeName("#define ALC_FALSE 0")]
    public const int False = 0;

    [NativeTypeName("#define ALC_TRUE 1")]
    public const int True = 1;

    [NativeTypeName("#define ALC_FREQUENCY 0x1007")]
    public const int Frequency = 0x1007;

    [NativeTypeName("#define ALC_REFRESH 0x1008")]
    public const int Refresh = 0x1008;

    [NativeTypeName("#define ALC_SYNC 0x1009")]
    public const int Sync = 0x1009;

    [NativeTypeName("#define ALC_MONO_SOURCES 0x1010")]
    public const int MonoSources = 0x1010;

    [NativeTypeName("#define ALC_STEREO_SOURCES 0x1011")]
    public const int StereoSources = 0x1011;

    [NativeTypeName("#define ALC_NO_ERROR 0")]
    public const int NoError = 0;

    [NativeTypeName("#define ALC_INVALID_DEVICE 0xA001")]
    public const int InvalidDevice = 0xA001;

    [NativeTypeName("#define ALC_INVALID_CONTEXT 0xA002")]
    public const int InvalidContext = 0xA002;

    [NativeTypeName("#define ALC_INVALID_ENUM 0xA003")]
    public const int InvalidEnum = 0xA003;

    [NativeTypeName("#define ALC_INVALID_VALUE 0xA004")]
    public const int InvalidValue = 0xA004;

    [NativeTypeName("#define ALC_OUT_OF_MEMORY 0xA005")]
    public const int OutOfMemory = 0xA005;

    [NativeTypeName("#define ALC_MAJOR_VERSION 0x1000")]
    public const int MajorVersion = 0x1000;

    [NativeTypeName("#define ALC_MINOR_VERSION 0x1001")]
    public const int MinorVersion = 0x1001;

    [NativeTypeName("#define ALC_ATTRIBUTES_SIZE 0x1002")]
    public const int AttributesSize = 0x1002;

    [NativeTypeName("#define ALC_ALL_ATTRIBUTES 0x1003")]
    public const int AllAttributes = 0x1003;

    [NativeTypeName("#define ALC_DEFAULT_DEVICE_SPECIFIER 0x1004")]
    public const int DefaultDeviceSpecifier = 0x1004;

    [NativeTypeName("#define ALC_DEVICE_SPECIFIER 0x1005")]
    public const int DeviceSpecifier = 0x1005;

    [NativeTypeName("#define ALC_EXTENSIONS 0x1006")]
    public const int Extensions = 0x1006;

    [NativeTypeName("#define ALC_EXT_CAPTURE 1")]
    public const int ExtCapture = 1;

    [NativeTypeName("#define ALC_CAPTURE_DEVICE_SPECIFIER 0x310")]
    public const int CaptureDeviceSpecifier = 0x310;

    [NativeTypeName("#define ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER 0x311")]
    public const int CaptureDefaultDeviceSpecifier = 0x311;

    [NativeTypeName("#define ALC_CAPTURE_SAMPLES 0x312")]
    public const int CaptureSamplesValue = 0x312;

    [NativeTypeName("#define ALC_ENUMERATE_ALL_EXT 1")]
    public const int EnumerateAllExt = 1;

    [NativeTypeName("#define ALC_DEFAULT_ALL_DEVICES_SPECIFIER 0x1012")]
    public const int DefaultAllDevicesSpecifier = 0x1012;

    [NativeTypeName("#define ALC_ALL_DEVICES_SPECIFIER 0x1013")]
    public const int AllDevicesSpecifier = 0x1013;

    [NativeTypeName("#define ALC_LOKI_audio_channel 1")]
    public const int LOKIAudioChannel = 1;

    [NativeTypeName("#define ALC_CHAN_MAIN_LOKI 0x500001")]
    public const int ChanMainLoki = 0x500001;

    [NativeTypeName("#define ALC_CHAN_PCM_LOKI 0x500002")]
    public const int ChanPcmLoki = 0x500002;

    [NativeTypeName("#define ALC_CHAN_CD_LOKI 0x500003")]
    public const int ChanCdLoki = 0x500003;

    [NativeTypeName("#define ALC_EXT_EFX 1")]
    public const int ExtEfx = 1;

    [NativeTypeName("#define ALC_EXT_EFX_NAME \"ALC_EXT_EFX\"")]
    public static ReadOnlySpan<byte> ExtEfxName => "ALC_EXT_EFX"u8;

    [NativeTypeName("#define ALC_EFX_MAJOR_VERSION 0x20001")]
    public const int EfxMajorVersion = 0x20001;

    [NativeTypeName("#define ALC_EFX_MINOR_VERSION 0x20002")]
    public const int EfxMinorVersion = 0x20002;

    [NativeTypeName("#define ALC_MAX_AUXILIARY_SENDS 0x20003")]
    public const int MaxAuxiliarySends = 0x20003;

    [NativeTypeName("#define ALC_EXT_disconnect 1")]
    public const int EXTDisconnect = 1;

    [NativeTypeName("#define ALC_CONNECTED 0x313")]
    public const int Connected = 0x313;

    [NativeTypeName("#define ALC_EXT_thread_local_context 1")]
    public const int EXTThreadLocalContext = 1;

    [NativeTypeName("#define ALC_EXT_DEDICATED 1")]
    public const int ExtDedicated = 1;

    [NativeTypeName("#define ALC_SOFT_loopback 1")]
    public const int SOFTLoopback = 1;

    [NativeTypeName("#define ALC_FORMAT_CHANNELS_SOFT 0x1990")]
    public const int FormatChannelsSoft = 0x1990;

    [NativeTypeName("#define ALC_FORMAT_TYPE_SOFT 0x1991")]
    public const int FormatTypeSoft = 0x1991;

    [NativeTypeName("#define ALC_BYTE_SOFT 0x1400")]
    public const int ByteSoft = 0x1400;

    [NativeTypeName("#define ALC_UNSIGNED_BYTE_SOFT 0x1401")]
    public const int UnsignedByteSoft = 0x1401;

    [NativeTypeName("#define ALC_SHORT_SOFT 0x1402")]
    public const int ShortSoft = 0x1402;

    [NativeTypeName("#define ALC_UNSIGNED_SHORT_SOFT 0x1403")]
    public const int UnsignedShortSoft = 0x1403;

    [NativeTypeName("#define ALC_INT_SOFT 0x1404")]
    public const int IntSoft = 0x1404;

    [NativeTypeName("#define ALC_UNSIGNED_INT_SOFT 0x1405")]
    public const int UnsignedIntSoft = 0x1405;

    [NativeTypeName("#define ALC_FLOAT_SOFT 0x1406")]
    public const int FloatSoft = 0x1406;

    [NativeTypeName("#define ALC_MONO_SOFT 0x1500")]
    public const int MonoSoft = 0x1500;

    [NativeTypeName("#define ALC_STEREO_SOFT 0x1501")]
    public const int StereoSoft = 0x1501;

    [NativeTypeName("#define ALC_QUAD_SOFT 0x1503")]
    public const int QuadSoft = 0x1503;

    [NativeTypeName("#define ALC_5POINT1_SOFT 0x1504")]
    public const int X5Point1Soft = 0x1504;

    [NativeTypeName("#define ALC_6POINT1_SOFT 0x1505")]
    public const int X6Point1Soft = 0x1505;

    [NativeTypeName("#define ALC_7POINT1_SOFT 0x1506")]
    public const int X7Point1Soft = 0x1506;

    [NativeTypeName("#define ALC_EXT_DEFAULT_FILTER_ORDER 1")]
    public const int ExtDefaultFilterOrder = 1;

    [NativeTypeName("#define ALC_DEFAULT_FILTER_ORDER 0x1100")]
    public const int DefaultFilterOrder = 0x1100;

    [NativeTypeName("#define ALC_SOFT_pause_device 1")]
    public const int SOFTPauseDevice = 1;

    [NativeTypeName("#define ALC_SOFT_HRTF 1")]
    public const int SoftHrtf = 1;

    [NativeTypeName("#define ALC_HRTF_SOFT 0x1992")]
    public const int HrtfSoft = 0x1992;

    [NativeTypeName("#define ALC_DONT_CARE_SOFT 0x0002")]
    public const int DontCareSoft = 0x0002;

    [NativeTypeName("#define ALC_HRTF_STATUS_SOFT 0x1993")]
    public const int HrtfStatusSoft = 0x1993;

    [NativeTypeName("#define ALC_HRTF_DISABLED_SOFT 0x0000")]
    public const int HrtfDisabledSoft = 0x0000;

    [NativeTypeName("#define ALC_HRTF_ENABLED_SOFT 0x0001")]
    public const int HrtfEnabledSoft = 0x0001;

    [NativeTypeName("#define ALC_HRTF_DENIED_SOFT 0x0002")]
    public const int HrtfDeniedSoft = 0x0002;

    [NativeTypeName("#define ALC_HRTF_REQUIRED_SOFT 0x0003")]
    public const int HrtfRequiredSoft = 0x0003;

    [NativeTypeName("#define ALC_HRTF_HEADPHONES_DETECTED_SOFT 0x0004")]
    public const int HrtfHeadphonesDetectedSoft = 0x0004;

    [NativeTypeName("#define ALC_HRTF_UNSUPPORTED_FORMAT_SOFT 0x0005")]
    public const int HrtfUnsupportedFormatSoft = 0x0005;

    [NativeTypeName("#define ALC_NUM_HRTF_SPECIFIERS_SOFT 0x1994")]
    public const int NumHrtfSpecifiersSoft = 0x1994;

    [NativeTypeName("#define ALC_HRTF_SPECIFIER_SOFT 0x1995")]
    public const int HrtfSpecifierSoft = 0x1995;

    [NativeTypeName("#define ALC_HRTF_ID_SOFT 0x1996")]
    public const int HrtfIdSoft = 0x1996;

    [NativeTypeName("#define ALC_OUTPUT_LIMITER_SOFT 0x199A")]
    public const int OutputLimiterSoft = 0x199A;

    [NativeTypeName("#define ALC_SOFT_device_clock 1")]
    public const int SOFTDeviceClock = 1;

    [NativeTypeName("#define ALC_DEVICE_CLOCK_SOFT 0x1600")]
    public const int DeviceClockSoft = 0x1600;

    [NativeTypeName("#define ALC_DEVICE_LATENCY_SOFT 0x1601")]
    public const int DeviceLatencySoft = 0x1601;

    [NativeTypeName("#define ALC_DEVICE_CLOCK_LATENCY_SOFT 0x1602")]
    public const int DeviceClockLatencySoft = 0x1602;

    [NativeTypeName("#define ALC_SOFT_loopback_bformat 1")]
    public const int SOFTLoopbackBformat = 1;

    [NativeTypeName("#define ALC_AMBISONIC_LAYOUT_SOFT 0x1997")]
    public const int AmbisonicLayoutSoft = 0x1997;

    [NativeTypeName("#define ALC_AMBISONIC_SCALING_SOFT 0x1998")]
    public const int AmbisonicScalingSoft = 0x1998;

    [NativeTypeName("#define ALC_AMBISONIC_ORDER_SOFT 0x1999")]
    public const int AmbisonicOrderSoft = 0x1999;

    [NativeTypeName("#define ALC_MAX_AMBISONIC_ORDER_SOFT 0x199B")]
    public const int MaxAmbisonicOrderSoft = 0x199B;

    [NativeTypeName("#define ALC_BFORMAT3D_SOFT 0x1507")]
    public const int Bformat3DSoft = 0x1507;

    [NativeTypeName("#define ALC_FUMA_SOFT 0x0000")]
    public const int FumaSoft = 0x0000;

    [NativeTypeName("#define ALC_ACN_SOFT 0x0001")]
    public const int AcnSoft = 0x0001;

    [NativeTypeName("#define ALC_SN3D_SOFT 0x0001")]
    public const int Sn3DSoft = 0x0001;

    [NativeTypeName("#define ALC_N3D_SOFT 0x0002")]
    public const int N3DSoft = 0x0002;

    [NativeTypeName("#define ALC_OUTPUT_MODE_SOFT 0x19AC")]
    public const int OutputModeSoft = 0x19AC;

    [NativeTypeName("#define ALC_ANY_SOFT 0x19AD")]
    public const int AnySoft = 0x19AD;

    [NativeTypeName("#define ALC_STEREO_BASIC_SOFT 0x19AE")]
    public const int StereoBasicSoft = 0x19AE;

    [NativeTypeName("#define ALC_STEREO_UHJ_SOFT 0x19AF")]
    public const int StereoUhjSoft = 0x19AF;

    [NativeTypeName("#define ALC_STEREO_HRTF_SOFT 0x19B2")]
    public const int StereoHrtfSoft = 0x19B2;

    [NativeTypeName("#define ALC_SURROUND_5_1_SOFT 0x1504")]
    public const int Surround5X1Soft = 0x1504;

    [NativeTypeName("#define ALC_SURROUND_6_1_SOFT 0x1505")]
    public const int Surround6X1Soft = 0x1505;

    [NativeTypeName("#define ALC_SURROUND_7_1_SOFT 0x1506")]
    public const int Surround7X1Soft = 0x1506;

    [NativeTypeName("#define ALC_CONTEXT_FLAGS_EXT 0x19CF")]
    public const int ContextFlagsExt = 0x19CF;

    [NativeTypeName("#define ALC_CONTEXT_DEBUG_BIT_EXT 0x0001")]
    public const int ContextDebugBitExt = 0x0001;

    [NativeTypeName("#define ALC_PLAYBACK_DEVICE_SOFT 0x19D4")]
    public const int PlaybackDeviceSoft = 0x19D4;

    [NativeTypeName("#define ALC_CAPTURE_DEVICE_SOFT 0x19D5")]
    public const int CaptureDeviceSoft = 0x19D5;

    [NativeTypeName("#define ALC_EVENT_TYPE_DEFAULT_DEVICE_CHANGED_SOFT 0x19D6")]
    public const int EventTypeDefaultDeviceChangedSoft = 0x19D6;

    [NativeTypeName("#define ALC_EVENT_TYPE_DEVICE_ADDED_SOFT 0x19D7")]
    public const int EventTypeDeviceAddedSoft = 0x19D7;

    [NativeTypeName("#define ALC_EVENT_TYPE_DEVICE_REMOVED_SOFT 0x19D8")]
    public const int EventTypeDeviceRemovedSoft = 0x19D8;

    [NativeTypeName("#define ALC_EVENT_SUPPORTED_SOFT 0x19D9")]
    public const int EventSupportedSoft = 0x19D9;

    [NativeTypeName("#define ALC_EVENT_NOT_SUPPORTED_SOFT 0x19DA")]
    public const int EventNotSupportedSoft = 0x19DA;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IALContext.CaptureCloseDevice(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte>)(
                _slots[0] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[0] = nativeContext.LoadFunction("alcCaptureCloseDevice", "openal")
            )
        )(device);

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte CaptureCloseDevice(DeviceHandle device) =>
        ThisThread.CaptureCloseDevice(device);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IALContext.CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] sbyte* devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] int format,
        [NativeTypeName("ALCsizei")] int buffersize
    ) =>
        (
            (delegate* unmanaged<sbyte*, uint, int, int, DeviceHandle>)(
                _slots[1] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[1] = nativeContext.LoadFunction("alcCaptureOpenDevice", "openal")
            )
        )(devicename, frequency, format, buffersize);

    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] sbyte* devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] int format,
        [NativeTypeName("ALCsizei")] int buffersize
    ) => ThisThread.CaptureOpenDevice(devicename, frequency, format, buffersize);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IALContext.CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] int format,
        [NativeTypeName("ALCsizei")] int buffersize
    )
    {
        fixed (sbyte* __dsl_devicename = devicename)
        {
            return (DeviceHandle)
                ((IALContext)this).CaptureOpenDevice(
                    __dsl_devicename,
                    frequency,
                    format,
                    buffersize
                );
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] int format,
        [NativeTypeName("ALCsizei")] int buffersize
    ) => ThisThread.CaptureOpenDevice(devicename, frequency, format, buffersize);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IALContext.CaptureSamples(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] void* buffer,
        [NativeTypeName("ALCsizei")] int samples
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, void*, int, void>)(
                _slots[2] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[2] = nativeContext.LoadFunction("alcCaptureSamples", "openal")
            )
        )(device, buffer, samples);

    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureSamples(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] void* buffer,
        [NativeTypeName("ALCsizei")] int samples
    ) => ThisThread.CaptureSamples(device, buffer, samples);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IALContext.CaptureSamples(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] Ref buffer,
        [NativeTypeName("ALCsizei")] int samples
    )
    {
        fixed (void* __dsl_buffer = buffer)
        {
            ((IALContext)this).CaptureSamples(device, __dsl_buffer, samples);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureSamples(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] Ref buffer,
        [NativeTypeName("ALCsizei")] int samples
    ) => ThisThread.CaptureSamples(device, buffer, samples);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IALContext.CaptureStart(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, void>)(
                _slots[3] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[3] = nativeContext.LoadFunction("alcCaptureStart", "openal")
            )
        )(device);

    [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureStart(DeviceHandle device) => ThisThread.CaptureStart(device);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IALContext.CaptureStop(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, void>)(
                _slots[4] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[4] = nativeContext.LoadFunction("alcCaptureStop", "openal")
            )
        )(device);

    [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureStop(DeviceHandle device) => ThisThread.CaptureStop(device);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IALContext.CloseDevice(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte>)(
                _slots[5] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[5] = nativeContext.LoadFunction("alcCloseDevice", "openal")
            )
        )(device);

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte CloseDevice(DeviceHandle device) => ThisThread.CloseDevice(device);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ContextHandle IALContext.CreateContext(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] int* attrlist
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int*, ContextHandle>)(
                _slots[6] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[6] = nativeContext.LoadFunction("alcCreateContext", "openal")
            )
        )(device, attrlist);

    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ContextHandle CreateContext(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] int* attrlist
    ) => ThisThread.CreateContext(device, attrlist);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ContextHandle IALContext.CreateContext(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] Ref<int> attrlist
    )
    {
        fixed (int* __dsl_attrlist = attrlist)
        {
            return (ContextHandle)((IALContext)this).CreateContext(device, __dsl_attrlist);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ContextHandle CreateContext(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] Ref<int> attrlist
    ) => ThisThread.CreateContext(device, attrlist);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IALContext.DestroyContext(ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, void>)(
                _slots[7] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[7] = nativeContext.LoadFunction("alcDestroyContext", "openal")
            )
        )(context);

    [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DestroyContext(ContextHandle context) => ThisThread.DestroyContext(context);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IALContext.GetContextsDevice(ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, DeviceHandle>)(
                _slots[8] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[8] = nativeContext.LoadFunction("alcGetContextsDevice", "openal")
            )
        )(context);

    [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle GetContextsDevice(ContextHandle context) =>
        ThisThread.GetContextsDevice(context);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ContextHandle IALContext.GetCurrentContext() =>
        (
            (delegate* unmanaged<ContextHandle>)(
                _slots[9] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[9] = nativeContext.LoadFunction("alcGetCurrentContext", "openal")
            )
        )();

    [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ContextHandle GetCurrentContext() => ThisThread.GetCurrentContext();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IALContext.GetEnumValue(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* enumname
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, int>)(
                _slots[10] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[10] = nativeContext.LoadFunction("alcGetEnumValue", "openal")
            )
        )(device, enumname);

    [return: NativeTypeName("ALCenum")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetEnumValue(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* enumname
    ) => ThisThread.GetEnumValue(device, enumname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IALContext.GetEnumValue(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname
    )
    {
        fixed (sbyte* __dsl_enumname = enumname)
        {
            return (int)((IALContext)this).GetEnumValue(device, __dsl_enumname);
        }
    }

    [return: NativeTypeName("ALCenum")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetEnumValue(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname
    ) => ThisThread.GetEnumValue(device, enumname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IALContext.GetError(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, int>)(
                _slots[11] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[11] = nativeContext.LoadFunction("alcGetError", "openal")
            )
        )(device);

    [return: NativeTypeName("ALCenum")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetError(DeviceHandle device) => ThisThread.GetError(device);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IALContext.GetIntegerv(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] int* values
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int, int, int*, void>)(
                _slots[12] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[12] = nativeContext.LoadFunction("alcGetIntegerv", "openal")
            )
        )(device, param1, size, values);

    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetIntegerv(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] int* values
    ) => ThisThread.GetIntegerv(device, param1, size, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IALContext.GetIntegerv(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IALContext)this).GetIntegerv(device, param1, size, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetIntegerv(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] Ref<int> values
    ) => ThisThread.GetIntegerv(device, param1, size, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void* IALContext.GetProcAddress(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* funcname
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, void*>)(
                _slots[13] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[13] = nativeContext.LoadFunction("alcGetProcAddress", "openal")
            )
        )(device, funcname);

    [return: NativeTypeName("ALCvoid *")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void* GetProcAddress(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* funcname
    ) => ThisThread.GetProcAddress(device, funcname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr IALContext.GetProcAddress(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
    )
    {
        fixed (sbyte* __dsl_funcname = funcname)
        {
            return (void*)((IALContext)this).GetProcAddress(device, __dsl_funcname);
        }
    }

    [return: NativeTypeName("ALCvoid *")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr GetProcAddress(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
    ) => ThisThread.GetProcAddress(device, funcname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr<sbyte> IALContext.GetString(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
        (sbyte*)((IALContext)this).GetStringRaw(device, param1);

    [return: NativeTypeName("const ALCchar *")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<sbyte> GetString(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1
    ) => ThisThread.GetString(device, param1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte* IALContext.GetStringRaw(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
        (
            (delegate* unmanaged<DeviceHandle, int, sbyte*>)(
                _slots[14] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[14] = nativeContext.LoadFunction("alcGetString", "openal")
            )
        )(device, param1);

    [return: NativeTypeName("const ALCchar *")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte* GetStringRaw(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1
    ) => ThisThread.GetStringRaw(device, param1);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IALContext.IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* extname
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, sbyte>)(
                _slots[15] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[15] = nativeContext.LoadFunction("alcIsExtensionPresent", "openal")
            )
        )(device, extname);

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* extname
    ) => ThisThread.IsExtensionPresent(device, extname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IALContext.IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
    )
    {
        fixed (sbyte* __dsl_extname = extname)
        {
            return (sbyte)((IALContext)this).IsExtensionPresent(device, __dsl_extname);
        }
    }

    [return: NativeTypeName("ALCboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
    ) => ThisThread.IsExtensionPresent(device, extname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IALContext.MakeContextCurrent(ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, sbyte>)(
                _slots[16] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[16] = nativeContext.LoadFunction("alcMakeContextCurrent", "openal")
            )
        )(context);

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte MakeContextCurrent(ContextHandle context) =>
        ThisThread.MakeContextCurrent(context);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IALContext.OpenDevice([NativeTypeName("const ALCchar *")] sbyte* devicename) =>
        (
            (delegate* unmanaged<sbyte*, DeviceHandle>)(
                _slots[17] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[17] = nativeContext.LoadFunction("alcOpenDevice", "openal")
            )
        )(devicename);

    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] sbyte* devicename) =>
        ThisThread.OpenDevice(devicename);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IALContext.OpenDevice([NativeTypeName("const ALCchar *")] Ref<sbyte> devicename)
    {
        fixed (sbyte* __dsl_devicename = devicename)
        {
            return (DeviceHandle)((IALContext)this).OpenDevice(__dsl_devicename);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle OpenDevice(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename
    ) => ThisThread.OpenDevice(devicename);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IALContext.ProcessContext(ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, void>)(
                _slots[18] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[18] = nativeContext.LoadFunction("alcProcessContext", "openal")
            )
        )(context);

    [NativeFunction("openal", EntryPoint = "alcProcessContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ProcessContext(ContextHandle context) => ThisThread.ProcessContext(context);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IALContext.SuspendContext(ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, void>)(
                _slots[19] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[19] = nativeContext.LoadFunction("alcSuspendContext", "openal")
            )
        )(context);

    [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SuspendContext(ContextHandle context) => ThisThread.SuspendContext(context);
}
