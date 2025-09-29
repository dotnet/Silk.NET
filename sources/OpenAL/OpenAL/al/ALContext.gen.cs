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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        public static extern sbyte CaptureCloseDevice(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        public static extern DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] int format,
            [NativeTypeName("ALCsizei")] int buffersize
        );

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] Constant<int, ALEnum, Format> format,
            [NativeTypeName("ALCsizei")] int buffersize
        )
        {
            fixed (sbyte* __dsl_devicename = devicename)
            {
                return (DeviceHandle)CaptureOpenDevice(
                    __dsl_devicename,
                    frequency,
                    (int)format,
                    buffersize
                );
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureSamples")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        public static extern void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        );

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        public static extern void CaptureStart(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureStop")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        public static extern void CaptureStop(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCloseDevice")]
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern sbyte CloseDevice(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attrlist
        );

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern void DestroyContext(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetContextsDevice")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern DeviceHandle GetContextsDevice(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetCurrentContext")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern ContextHandle GetCurrentContext();

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetEnumValue")]
        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* enumname
        );

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        public static Constant<int, ErrorCode> GetError(DeviceHandle device) =>
            (Constant<int, ErrorCode>)(int)GetErrorRaw(device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetError")]
        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern int GetErrorRaw(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern void GetInteger(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] int* values
        );

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetInteger(device, param1, size, __dsl_values);
            }
        }

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        public static int GetInteger(DeviceHandle device, [NativeTypeName("ALCenum")] int param1)
        {
            int values = default;
            GetInteger(device, param1, 1, (int*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetProcAddress")]
        [return: NativeTypeName("ALCvoid *")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern void* GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcname
        );

        [return: NativeTypeName("ALCvoid *")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern sbyte* GetStringRaw(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcIsExtensionPresent")]
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* extname
        );

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern sbyte MakeContextCurrent(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename
        );

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern void ProcessContext(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcSuspendContext")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        public static extern void SuspendContext(ContextHandle context);
    }

    public partial class StaticWrapper<T> : IALContext
        where T : IALContext.Static
    {
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte CaptureCloseDevice(DeviceHandle device) => T.CaptureCloseDevice(device);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
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

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] Constant<int, ALEnum, Format> format,
            [NativeTypeName("ALCsizei")] int buffersize
        ) => T.CaptureOpenDevice(devicename, frequency, format, buffersize);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        ) => T.CaptureSamples(device, buffer, samples);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
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

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureStart(DeviceHandle device) => T.CaptureStart(device);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureStop(DeviceHandle device) => T.CaptureStop(device);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte CloseDevice(DeviceHandle device) => T.CloseDevice(device);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attrlist
        ) => T.CreateContext(device, attrlist);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] Ref<int> attrlist
        ) => T.CreateContext(device, attrlist);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DestroyContext(ContextHandle context) => T.DestroyContext(context);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle GetContextsDevice(ContextHandle context) =>
            T.GetContextsDevice(context);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle GetCurrentContext() => T.GetCurrentContext();

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* enumname
        ) => T.GetEnumValue(device, enumname);

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Constant<int, ErrorCode> GetError(DeviceHandle device) => T.GetError(device);

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetErrorRaw(DeviceHandle device) => T.GetErrorRaw(device);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetInteger(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] int* values
        ) => T.GetInteger(device, param1, size, values);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetInteger(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] Ref<int> values
        ) => T.GetInteger(device, param1, size, values);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetInteger(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
            T.GetInteger(device, param1);

        [return: NativeTypeName("ALCvoid *")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void* GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcname
        ) => T.GetProcAddress(device, funcname);

        [return: NativeTypeName("ALCvoid *")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<sbyte> GetString(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
            T.GetString(device, param1);

        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte* GetStringRaw(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
            T.GetStringRaw(device, param1);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* extname
        ) => T.IsExtensionPresent(device, extname);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte MakeContextCurrent(ContextHandle context) => T.MakeContextCurrent(context);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] sbyte* devicename) =>
            T.OpenDevice(devicename);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] Ref<sbyte> devicename) =>
            T.OpenDevice(devicename);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void ProcessContext(ContextHandle context) => T.ProcessContext(context);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SuspendContext(ContextHandle context) => T.SuspendContext(context);
    }

    public partial class ThisThread
    {
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte CaptureCloseDevice(DeviceHandle device) =>
            Underlying.Value!.CaptureCloseDevice(device);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
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

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] Constant<int, ALEnum, Format> format,
            [NativeTypeName("ALCsizei")] int buffersize
        )
        {
            fixed (sbyte* __dsl_devicename = devicename)
            {
                return (DeviceHandle)CaptureOpenDevice(
                    __dsl_devicename,
                    frequency,
                    (int)format,
                    buffersize
                );
            }
        }

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        ) => Underlying.Value!.CaptureSamples(device, buffer, samples);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
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

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureStart(DeviceHandle device) =>
            Underlying.Value!.CaptureStart(device);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureStop(DeviceHandle device) =>
            Underlying.Value!.CaptureStop(device);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte CloseDevice(DeviceHandle device) =>
            Underlying.Value!.CloseDevice(device);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attrlist
        ) => Underlying.Value!.CreateContext(device, attrlist);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DestroyContext(ContextHandle context) =>
            Underlying.Value!.DestroyContext(context);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle GetContextsDevice(ContextHandle context) =>
            Underlying.Value!.GetContextsDevice(context);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle GetCurrentContext() => Underlying.Value!.GetCurrentContext();

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* enumname
        ) => Underlying.Value!.GetEnumValue(device, enumname);

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Constant<int, ErrorCode> GetError(DeviceHandle device) =>
            Underlying.Value!.GetError(device);

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetErrorRaw(DeviceHandle device) => Underlying.Value!.GetErrorRaw(device);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] int* values
        ) => Underlying.Value!.GetInteger(device, param1, size, values);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetInteger(device, param1, size, __dsl_values);
            }
        }

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetInteger(DeviceHandle device, [NativeTypeName("ALCenum")] int param1)
        {
            int values = default;
            GetInteger(device, param1, 1, (int*)&values);
            return values;
        }

        [return: NativeTypeName("ALCvoid *")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void* GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcname
        ) => Underlying.Value!.GetProcAddress(device, funcname);

        [return: NativeTypeName("ALCvoid *")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte* GetStringRaw(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1
        ) => Underlying.Value!.GetStringRaw(device, param1);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* extname
        ) => Underlying.Value!.IsExtensionPresent(device, extname);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte MakeContextCurrent(ContextHandle context) =>
            Underlying.Value!.MakeContextCurrent(context);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename
        ) => Underlying.Value!.OpenDevice(devicename);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void ProcessContext(ContextHandle context) =>
            Underlying.Value!.ProcessContext(context);

        [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
    public const int Invalid = 0;

    [NativeTypeName("#define ALC_VERSION_0_1 1")]
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
    public const int Version0X1 = 1;

    [NativeTypeName("#define ALC_EXT_CAPTURE 1")]
    [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
    public const int ExtCapture = 1;

    [NativeTypeName("#define ALC_ENUMERATE_ALL_EXT 1")]
    [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
    public const int EnumerateAllEXT = 1;

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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
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
        [NativeTypeName("ALCenum")] Constant<int, ALEnum, Format> format,
        [NativeTypeName("ALCsizei")] int buffersize
    )
    {
        fixed (sbyte* __dsl_devicename = devicename)
        {
            return (DeviceHandle)
                ((IALContext)this).CaptureOpenDevice(
                    __dsl_devicename,
                    frequency,
                    (int)format,
                    buffersize
                );
        }
    }

    [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] Constant<int, ALEnum, Format> format,
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_1"], MinVersion = "1.1")]
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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetEnumValue(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname
    ) => ThisThread.GetEnumValue(device, enumname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Constant<int, ErrorCode> IALContext.GetError(DeviceHandle device) =>
        (Constant<int, ErrorCode>)(int)((IALContext)this).GetErrorRaw(device);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Constant<int, ErrorCode> GetError(DeviceHandle device) =>
        ThisThread.GetError(device);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IALContext.GetErrorRaw(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, int>)(
                _slots[11] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[11] = nativeContext.LoadFunction("alcGetError", "openal")
            )
        )(device);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetErrorRaw(DeviceHandle device) => ThisThread.GetErrorRaw(device);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IALContext.GetInteger(
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] int* values
    ) => ThisThread.GetInteger(device, param1, size, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IALContext.GetInteger(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IALContext)this).GetInteger(device, param1, size, __dsl_values);
        }
    }

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] Ref<int> values
    ) => ThisThread.GetInteger(device, param1, size, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IALContext.GetInteger(DeviceHandle device, [NativeTypeName("ALCenum")] int param1)
    {
        int values = default;
        ((IALContext)this).GetInteger(device, param1, 1, (int*)&values);
        return values;
    }

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetInteger(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
        ThisThread.GetInteger(device, param1);

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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("alc", ["ALC_VERISON_1_0", "ALC_VERISON_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SuspendContext(ContextHandle context) => ThisThread.SuspendContext(context);
}
