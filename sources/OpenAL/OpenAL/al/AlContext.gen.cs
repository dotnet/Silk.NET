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

public unsafe partial class AlContext : IAlContext, IAlContext.Static
{
    public partial class DllImport : IAlContext.Static
    {
        [NativeName("alcCaptureCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        public static MaybeBool<sbyte> CaptureCloseDevice(
            [NativeName("device")] DeviceHandle device
        ) => (MaybeBool<sbyte>)(sbyte)CaptureCloseDeviceRaw(device);

        [NativeName("alcCaptureCloseDevice")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        public static extern sbyte CaptureCloseDeviceRaw(
            [NativeName("device")] DeviceHandle device
        );

        [NativeName("alcCaptureOpenDevice")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        public static extern DeviceHandle CaptureOpenDevice(
            [NativeName("devicename")] sbyte* devicename,
            [NativeName("frequency")] uint frequency,
            [NativeName("format")] int format,
            [NativeName("buffersize")] int buffersize
        );

        [NativeName("alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle CaptureOpenDevice(
            [NativeName("devicename")] Ref<sbyte> devicename,
            [NativeName("frequency")] uint frequency,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("buffersize")] int buffersize
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

        [NativeName("alcCaptureSamples")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureSamples")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        public static extern void CaptureSamples(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] void* buffer,
            [NativeName("samples")] int samples
        );

        [NativeName("alcCaptureSamples")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureSamples(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] Ref buffer,
            [NativeName("samples")] int samples
        )
        {
            fixed (void* __dsl_buffer = buffer)
            {
                CaptureSamples(device, __dsl_buffer, samples);
            }
        }

        [NativeName("alcCaptureStart")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureStart")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        public static extern void CaptureStart([NativeName("device")] DeviceHandle device);

        [NativeName("alcCaptureStop")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureStop")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        public static extern void CaptureStop([NativeName("device")] DeviceHandle device);

        [NativeName("alcCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        public static MaybeBool<sbyte> CloseDevice([NativeName("device")] DeviceHandle device) =>
            (MaybeBool<sbyte>)(sbyte)CloseDeviceRaw(device);

        [NativeName("alcCloseDevice")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte CloseDeviceRaw([NativeName("device")] DeviceHandle device);

        [NativeName("alcCreateContext")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern ContextHandle CreateContext(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attrlist")] int* attrlist
        );

        [NativeName("alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle CreateContext(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attrlist")] Ref<int> attrlist
        )
        {
            fixed (int* __dsl_attrlist = attrlist)
            {
                return (ContextHandle)CreateContext(device, __dsl_attrlist);
            }
        }

        [NativeName("alcDestroyContext")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcDestroyContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void DestroyContext([NativeName("context")] ContextHandle context);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcDevicePauseSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcDevicePauseSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        public static extern void DevicePauseSOFT([NativeName("device")] DeviceHandle device);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcDeviceResumeSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcDeviceResumeSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        public static extern void DeviceResumeSOFT([NativeName("device")] DeviceHandle device);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventCallbackSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcEventCallbackSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        public static extern void EventCallbackSOFT(
            [NativeName("callback")] ContextEventProcSOFT callback,
            [NativeName("userParam")] void* userParam
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventCallbackSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void EventCallbackSOFT(
            [NativeName("callback")] ContextEventProcSOFT callback,
            [NativeName("userParam")] Ref userParam
        )
        {
            fixed (void* __dsl_userParam = userParam)
            {
                EventCallbackSOFT(callback, __dsl_userParam);
            }
        }

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventControlSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcEventControlSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        public static extern sbyte EventControlSOFT(
            [NativeName("count")] int count,
            [NativeName("events")] int* events,
            [NativeName("enable")] sbyte enable
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventControlSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> EventControlSOFT(
            [NativeName("count")] int count,
            [NativeName("events")] Ref<int> events,
            [NativeName("enable")] MaybeBool<sbyte> enable
        )
        {
            fixed (int* __dsl_events = events)
            {
                return (MaybeBool<sbyte>)
                    (sbyte)EventControlSOFT(count, __dsl_events, (sbyte)enable);
            }
        }

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventIsSupportedSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcEventIsSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        public static extern int EventIsSupportedSOFT(
            [NativeName("eventType")] int eventType,
            [NativeName("deviceType")] int deviceType
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventIsSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        public static Constant<int, AlcEnum, EventSupportSOFT> EventIsSupportedSOFT(
            [NativeName("eventType")] Constant<int, EventTypeSOFT> eventType,
            [NativeName("deviceType")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
        ) =>
            (Constant<int, AlcEnum, EventSupportSOFT>)
                (int)EventIsSupportedSOFT((int)eventType, (int)deviceType);

        [NativeName("alcGetContextsDevice")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetContextsDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern DeviceHandle GetContextsDevice(
            [NativeName("context")] ContextHandle context
        );

        [NativeName("alcGetCurrentContext")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetCurrentContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern ContextHandle GetCurrentContext();

        [NativeName("alcGetEnumValue")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetEnumValue")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern int GetEnumValue(
            [NativeName("device")] DeviceHandle device,
            [NativeName("enumname")] sbyte* enumname
        );

        [NativeName("alcGetEnumValue")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue(
            [NativeName("device")] DeviceHandle device,
            [NativeName("enumname")] Ref<sbyte> enumname
        )
        {
            fixed (sbyte* __dsl_enumname = enumname)
            {
                return (int)GetEnumValue(device, __dsl_enumname);
            }
        }

        [NativeName("alcGetError")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        public static Constant<int, ErrorCode> GetError(
            [NativeName("device")] DeviceHandle device
        ) => (Constant<int, ErrorCode>)(int)GetErrorRaw(device);

        [NativeName("alcGetError")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetError")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern int GetErrorRaw([NativeName("device")] DeviceHandle device);

        [NameAffix("Suffix", "v", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetInteger64vSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        public static extern void GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname,
            [NativeName("size")] int size,
            [NativeName("values")] nint* values
        );

        [NameAffix("Suffix", "v", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname,
            [NativeName("size")] int size,
            [NativeName("values")] Ref<nint> values
        )
        {
            fixed (nint* __dsl_values = values)
            {
                GetInteger64SOFT(device, pname, size, __dsl_values);
            }
        }

        [NameAffix("Suffix", "v", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        public static nint GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname
        )
        {
            nint values = default;
            GetInteger64SOFT(device, pname, 1, (nint*)&values);
            return values;
        }

        [NameAffix("Suffix", "v", 0, 0)]
        [NativeName("alcGetIntegerv")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1,
            [NativeName("size")] int size,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "v", 0, 0)]
        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1,
            [NativeName("size")] int size,
            [NativeName("values")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetInteger(device, param1, size, __dsl_values);
            }
        }

        [NameAffix("Suffix", "v", 0, 0)]
        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        public static int GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1
        )
        {
            int values = default;
            GetInteger(device, param1, 1, (int*)&values);
            return values;
        }

        [NativeName("alcGetProcAddress")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetProcAddress")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void* GetProcAddress(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcname")] sbyte* funcname
        );

        [NativeName("alcGetProcAddress")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetProcAddress(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcname")] Ref<sbyte> funcname
        )
        {
            fixed (sbyte* __dsl_funcname = funcname)
            {
                return (void*)GetProcAddress(device, __dsl_funcname);
            }
        }

        [NativeName("alcGetProcAddress2")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetProcAddress2")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        public static extern void* GetProcAddress2(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcName")] sbyte* funcName
        );

        [NativeName("alcGetProcAddress2")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetProcAddress2(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcName")] Ref<sbyte> funcName
        )
        {
            fixed (sbyte* __dsl_funcName = funcName)
            {
                return (void*)GetProcAddress2(device, __dsl_funcName);
            }
        }

        [NativeName("alcGetString")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetString")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte* GetString(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1
        );

        [NativeName("alcGetString")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetString(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] Constant<int, AlcEnum, ContextString> param1
        ) => (sbyte*)GetString(device, (int)param1);

        [NameAffix("Suffix", "i", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetStringiSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetStringiSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        public static extern sbyte* GetStringSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("paramName")] int paramName,
            [NativeName("index")] int index
        );

        [NameAffix("Suffix", "i", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetStringiSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetStringSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("paramName")] Constant<int, AlcEnum, ContextString> paramName,
            [NativeName("index")] int index
        ) => (sbyte*)GetStringSOFT(device, (int)paramName, index);

        [NativeName("alcGetThreadContext")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        public static extern ContextHandle GetThreadContext();

        [NativeName("alcIsExtensionPresent")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcIsExtensionPresent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte IsExtensionPresent(
            [NativeName("device")] DeviceHandle device,
            [NativeName("extname")] sbyte* extname
        );

        [NativeName("alcIsExtensionPresent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsExtensionPresent(
            [NativeName("device")] DeviceHandle device,
            [NativeName("extname")] Ref<sbyte> extname
        )
        {
            fixed (sbyte* __dsl_extname = extname)
            {
                return (MaybeBool<sbyte>)(sbyte)IsExtensionPresent(device, __dsl_extname);
            }
        }

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcIsRenderFormatSupportedSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        public static extern sbyte IsRenderFormatSupportedSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("freq")] int freq,
            [NativeName("channels")] int channels,
            [NativeName("type")] int type
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcIsRenderFormatSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        public static MaybeBool<sbyte> IsRenderFormatSupportedSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("freq")] int freq,
            [NativeName("channels")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
            [NativeName("type")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
        ) =>
            (MaybeBool<sbyte>)
                (sbyte)IsRenderFormatSupportedSOFT(device, freq, (int)channels, (int)type);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcLoopbackOpenDeviceSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        public static extern DeviceHandle LoopbackOpenDeviceSOFT(
            [NativeName("deviceName")] sbyte* deviceName
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcLoopbackOpenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle LoopbackOpenDeviceSOFT(
            [NativeName("deviceName")] Ref<sbyte> deviceName
        )
        {
            fixed (sbyte* __dsl_deviceName = deviceName)
            {
                return (DeviceHandle)LoopbackOpenDeviceSOFT(__dsl_deviceName);
            }
        }

        [NativeName("alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        public static MaybeBool<sbyte> MakeContextCurrent(
            [NativeName("context")] ContextHandle context
        ) => (MaybeBool<sbyte>)(sbyte)MakeContextCurrentRaw(context);

        [NativeName("alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        private static MaybeBool<sbyte> MakeContextCurrentInternal(
            [NativeName("context")] ContextHandle context
        ) => (MaybeBool<sbyte>)(sbyte)MakeContextCurrentInternalRaw(context);

        [NativeName("alcMakeContextCurrent")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        private static extern sbyte MakeContextCurrentInternalRaw(
            [NativeName("context")] ContextHandle context
        );

        [NativeName("alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        public static partial sbyte MakeContextCurrentRaw(
            [NativeName("context")] ContextHandle context
        );

        [NativeName("alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        public static partial DeviceHandle OpenDevice([NativeName("devicename")] sbyte* devicename);

        [NativeName("alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle OpenDevice([NativeName("devicename")] Ref<sbyte> devicename)
        {
            fixed (sbyte* __dsl_devicename = devicename)
            {
                return (DeviceHandle)OpenDevice(__dsl_devicename);
            }
        }

        [NativeName("alcOpenDevice")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        private static extern DeviceHandle OpenDeviceInternal(
            [NativeName("devicename")] sbyte* devicename
        );

        [NativeName("alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        private static DeviceHandle OpenDeviceInternal(
            [NativeName("devicename")] Ref<sbyte> devicename
        )
        {
            fixed (sbyte* __dsl_devicename = devicename)
            {
                return (DeviceHandle)OpenDeviceInternal(__dsl_devicename);
            }
        }

        [NativeName("alcProcessContext")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcProcessContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void ProcessContext([NativeName("context")] ContextHandle context);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcRenderSamplesSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcRenderSamplesSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        public static extern void RenderSamplesSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] void* buffer,
            [NativeName("samples")] int samples
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcRenderSamplesSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void RenderSamplesSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] Ref buffer,
            [NativeName("samples")] int samples
        )
        {
            fixed (void* __dsl_buffer = buffer)
            {
                RenderSamplesSOFT(device, __dsl_buffer, samples);
            }
        }

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcReopenDeviceSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcReopenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        public static extern sbyte ReopenDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("deviceName")] sbyte* deviceName,
            [NativeName("attribs")] int* attribs
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcReopenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> ReopenDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("deviceName")] Ref<sbyte> deviceName,
            [NativeName("attribs")] Ref<int> attribs
        )
        {
            fixed (int* __dsl_attribs = attribs)
            fixed (sbyte* __dsl_deviceName = deviceName)
            {
                return (MaybeBool<sbyte>)
                    (sbyte)ReopenDeviceSOFT(device, __dsl_deviceName, __dsl_attribs);
            }
        }

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcResetDeviceSOFT")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcResetDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        public static extern sbyte ResetDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attribs")] int* attribs
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcResetDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> ResetDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attribs")] Ref<int> attribs
        )
        {
            fixed (int* __dsl_attribs = attribs)
            {
                return (MaybeBool<sbyte>)(sbyte)ResetDeviceSOFT(device, __dsl_attribs);
            }
        }

        [NativeName("alcSetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        public static MaybeBool<sbyte> SetThreadContext(
            [NativeName("context")] ContextHandle context
        ) => (MaybeBool<sbyte>)(sbyte)SetThreadContextRaw(context);

        [NativeName("alcSetThreadContext")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcSetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        public static extern sbyte SetThreadContextRaw(
            [NativeName("context")] ContextHandle context
        );

        [NativeName("alcSuspendContext")]
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcSuspendContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SuspendContext([NativeName("context")] ContextHandle context);
    }

    public partial class StaticWrapper<T> : IAlContext
        where T : IAlContext.Static
    {
        [NativeName("alcCaptureCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> CaptureCloseDevice([NativeName("device")] DeviceHandle device) =>
            T.CaptureCloseDevice(device);

        [NativeName("alcCaptureCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte CaptureCloseDeviceRaw([NativeName("device")] DeviceHandle device) =>
            T.CaptureCloseDeviceRaw(device);

        [NativeName("alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle CaptureOpenDevice(
            [NativeName("devicename")] sbyte* devicename,
            [NativeName("frequency")] uint frequency,
            [NativeName("format")] int format,
            [NativeName("buffersize")] int buffersize
        ) => T.CaptureOpenDevice(devicename, frequency, format, buffersize);

        [NativeName("alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle CaptureOpenDevice(
            [NativeName("devicename")] Ref<sbyte> devicename,
            [NativeName("frequency")] uint frequency,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("buffersize")] int buffersize
        ) => T.CaptureOpenDevice(devicename, frequency, format, buffersize);

        [NativeName("alcCaptureSamples")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureSamples(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] void* buffer,
            [NativeName("samples")] int samples
        ) => T.CaptureSamples(device, buffer, samples);

        [NativeName("alcCaptureSamples")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureSamples(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] Ref buffer,
            [NativeName("samples")] int samples
        ) => T.CaptureSamples(device, buffer, samples);

        [NativeName("alcCaptureStart")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureStart([NativeName("device")] DeviceHandle device) =>
            T.CaptureStart(device);

        [NativeName("alcCaptureStop")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureStop([NativeName("device")] DeviceHandle device) =>
            T.CaptureStop(device);

        [NativeName("alcCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> CloseDevice([NativeName("device")] DeviceHandle device) =>
            T.CloseDevice(device);

        [NativeName("alcCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte CloseDeviceRaw([NativeName("device")] DeviceHandle device) =>
            T.CloseDeviceRaw(device);

        [NativeName("alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle CreateContext(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attrlist")] int* attrlist
        ) => T.CreateContext(device, attrlist);

        [NativeName("alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle CreateContext(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attrlist")] Ref<int> attrlist
        ) => T.CreateContext(device, attrlist);

        [NativeName("alcDestroyContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DestroyContext([NativeName("context")] ContextHandle context) =>
            T.DestroyContext(context);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcDevicePauseSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DevicePauseSOFT([NativeName("device")] DeviceHandle device) =>
            T.DevicePauseSOFT(device);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcDeviceResumeSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeviceResumeSOFT([NativeName("device")] DeviceHandle device) =>
            T.DeviceResumeSOFT(device);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventCallbackSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void EventCallbackSOFT(
            [NativeName("callback")] ContextEventProcSOFT callback,
            [NativeName("userParam")] void* userParam
        ) => T.EventCallbackSOFT(callback, userParam);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventCallbackSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void EventCallbackSOFT(
            [NativeName("callback")] ContextEventProcSOFT callback,
            [NativeName("userParam")] Ref userParam
        ) => T.EventCallbackSOFT(callback, userParam);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventControlSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte EventControlSOFT(
            [NativeName("count")] int count,
            [NativeName("events")] int* events,
            [NativeName("enable")] sbyte enable
        ) => T.EventControlSOFT(count, events, enable);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventControlSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> EventControlSOFT(
            [NativeName("count")] int count,
            [NativeName("events")] Ref<int> events,
            [NativeName("enable")] MaybeBool<sbyte> enable
        ) => T.EventControlSOFT(count, events, enable);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventIsSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int EventIsSupportedSOFT(
            [NativeName("eventType")] int eventType,
            [NativeName("deviceType")] int deviceType
        ) => T.EventIsSupportedSOFT(eventType, deviceType);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventIsSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Constant<int, AlcEnum, EventSupportSOFT> EventIsSupportedSOFT(
            [NativeName("eventType")] Constant<int, EventTypeSOFT> eventType,
            [NativeName("deviceType")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
        ) => T.EventIsSupportedSOFT(eventType, deviceType);

        [NativeName("alcGetContextsDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle GetContextsDevice([NativeName("context")] ContextHandle context) =>
            T.GetContextsDevice(context);

        [NativeName("alcGetCurrentContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle GetCurrentContext() => T.GetCurrentContext();

        [NativeName("alcGetEnumValue")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetEnumValue(
            [NativeName("device")] DeviceHandle device,
            [NativeName("enumname")] sbyte* enumname
        ) => T.GetEnumValue(device, enumname);

        [NativeName("alcGetEnumValue")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetEnumValue(
            [NativeName("device")] DeviceHandle device,
            [NativeName("enumname")] Ref<sbyte> enumname
        ) => T.GetEnumValue(device, enumname);

        [NativeName("alcGetError")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Constant<int, ErrorCode> GetError([NativeName("device")] DeviceHandle device) =>
            T.GetError(device);

        [NativeName("alcGetError")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetErrorRaw([NativeName("device")] DeviceHandle device) => T.GetErrorRaw(device);

        [NameAffix("Suffix", "v", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname,
            [NativeName("size")] int size,
            [NativeName("values")] nint* values
        ) => T.GetInteger64SOFT(device, pname, size, values);

        [NameAffix("Suffix", "v", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname,
            [NativeName("size")] int size,
            [NativeName("values")] Ref<nint> values
        ) => T.GetInteger64SOFT(device, pname, size, values);

        [NameAffix("Suffix", "v", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public nint GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname
        ) => T.GetInteger64SOFT(device, pname);

        [NameAffix("Suffix", "v", 0, 0)]
        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1,
            [NativeName("size")] int size,
            [NativeName("values")] int* values
        ) => T.GetInteger(device, param1, size, values);

        [NameAffix("Suffix", "v", 0, 0)]
        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1,
            [NativeName("size")] int size,
            [NativeName("values")] Ref<int> values
        ) => T.GetInteger(device, param1, size, values);

        [NameAffix("Suffix", "v", 0, 0)]
        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1
        ) => T.GetInteger(device, param1);

        [NativeName("alcGetProcAddress")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void* GetProcAddress(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcname")] sbyte* funcname
        ) => T.GetProcAddress(device, funcname);

        [NativeName("alcGetProcAddress")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr GetProcAddress(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcname")] Ref<sbyte> funcname
        ) => T.GetProcAddress(device, funcname);

        [NativeName("alcGetProcAddress2")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void* GetProcAddress2(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcName")] sbyte* funcName
        ) => T.GetProcAddress2(device, funcName);

        [NativeName("alcGetProcAddress2")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr GetProcAddress2(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcName")] Ref<sbyte> funcName
        ) => T.GetProcAddress2(device, funcName);

        [NativeName("alcGetString")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte* GetString(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1
        ) => T.GetString(device, param1);

        [NativeName("alcGetString")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<sbyte> GetString(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] Constant<int, AlcEnum, ContextString> param1
        ) => T.GetString(device, param1);

        [NameAffix("Suffix", "i", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetStringiSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte* GetStringSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("paramName")] int paramName,
            [NativeName("index")] int index
        ) => T.GetStringSOFT(device, paramName, index);

        [NameAffix("Suffix", "i", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetStringiSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<sbyte> GetStringSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("paramName")] Constant<int, AlcEnum, ContextString> paramName,
            [NativeName("index")] int index
        ) => T.GetStringSOFT(device, paramName, index);

        [NativeName("alcGetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle GetThreadContext() => T.GetThreadContext();

        [NativeName("alcIsExtensionPresent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsExtensionPresent(
            [NativeName("device")] DeviceHandle device,
            [NativeName("extname")] sbyte* extname
        ) => T.IsExtensionPresent(device, extname);

        [NativeName("alcIsExtensionPresent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsExtensionPresent(
            [NativeName("device")] DeviceHandle device,
            [NativeName("extname")] Ref<sbyte> extname
        ) => T.IsExtensionPresent(device, extname);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcIsRenderFormatSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsRenderFormatSupportedSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("freq")] int freq,
            [NativeName("channels")] int channels,
            [NativeName("type")] int type
        ) => T.IsRenderFormatSupportedSOFT(device, freq, channels, type);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcIsRenderFormatSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsRenderFormatSupportedSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("freq")] int freq,
            [NativeName("channels")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
            [NativeName("type")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
        ) => T.IsRenderFormatSupportedSOFT(device, freq, channels, type);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcLoopbackOpenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle LoopbackOpenDeviceSOFT([NativeName("deviceName")] sbyte* deviceName) =>
            T.LoopbackOpenDeviceSOFT(deviceName);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcLoopbackOpenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle LoopbackOpenDeviceSOFT(
            [NativeName("deviceName")] Ref<sbyte> deviceName
        ) => T.LoopbackOpenDeviceSOFT(deviceName);

        [NativeName("alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> MakeContextCurrent([NativeName("context")] ContextHandle context) =>
            T.MakeContextCurrent(context);

        [NativeName("alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte MakeContextCurrentRaw([NativeName("context")] ContextHandle context) =>
            T.MakeContextCurrentRaw(context);

        [NativeName("alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle OpenDevice([NativeName("devicename")] sbyte* devicename) =>
            T.OpenDevice(devicename);

        [NativeName("alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle OpenDevice([NativeName("devicename")] Ref<sbyte> devicename) =>
            T.OpenDevice(devicename);

        [NativeName("alcProcessContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void ProcessContext([NativeName("context")] ContextHandle context) =>
            T.ProcessContext(context);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcRenderSamplesSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void RenderSamplesSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] void* buffer,
            [NativeName("samples")] int samples
        ) => T.RenderSamplesSOFT(device, buffer, samples);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcRenderSamplesSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void RenderSamplesSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] Ref buffer,
            [NativeName("samples")] int samples
        ) => T.RenderSamplesSOFT(device, buffer, samples);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcReopenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte ReopenDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("deviceName")] sbyte* deviceName,
            [NativeName("attribs")] int* attribs
        ) => T.ReopenDeviceSOFT(device, deviceName, attribs);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcReopenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> ReopenDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("deviceName")] Ref<sbyte> deviceName,
            [NativeName("attribs")] Ref<int> attribs
        ) => T.ReopenDeviceSOFT(device, deviceName, attribs);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcResetDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte ResetDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attribs")] int* attribs
        ) => T.ResetDeviceSOFT(device, attribs);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcResetDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> ResetDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attribs")] Ref<int> attribs
        ) => T.ResetDeviceSOFT(device, attribs);

        [NativeName("alcSetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> SetThreadContext([NativeName("context")] ContextHandle context) =>
            T.SetThreadContext(context);

        [NativeName("alcSetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte SetThreadContextRaw([NativeName("context")] ContextHandle context) =>
            T.SetThreadContextRaw(context);

        [NativeName("alcSuspendContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SuspendContext([NativeName("context")] ContextHandle context) =>
            T.SuspendContext(context);
    }

    public partial class ThisThread
    {
        [NativeName("alcCaptureCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> CaptureCloseDevice(
            [NativeName("device")] DeviceHandle device
        ) => Underlying.Value!.CaptureCloseDevice(device);

        [NativeName("alcCaptureCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte CaptureCloseDeviceRaw([NativeName("device")] DeviceHandle device) =>
            Underlying.Value!.CaptureCloseDeviceRaw(device);

        [NativeName("alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle CaptureOpenDevice(
            [NativeName("devicename")] sbyte* devicename,
            [NativeName("frequency")] uint frequency,
            [NativeName("format")] int format,
            [NativeName("buffersize")] int buffersize
        ) => Underlying.Value!.CaptureOpenDevice(devicename, frequency, format, buffersize);

        [NativeName("alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle CaptureOpenDevice(
            [NativeName("devicename")] Ref<sbyte> devicename,
            [NativeName("frequency")] uint frequency,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("buffersize")] int buffersize
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

        [NativeName("alcCaptureSamples")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureSamples(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] void* buffer,
            [NativeName("samples")] int samples
        ) => Underlying.Value!.CaptureSamples(device, buffer, samples);

        [NativeName("alcCaptureSamples")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureSamples(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] Ref buffer,
            [NativeName("samples")] int samples
        )
        {
            fixed (void* __dsl_buffer = buffer)
            {
                CaptureSamples(device, __dsl_buffer, samples);
            }
        }

        [NativeName("alcCaptureStart")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureStart([NativeName("device")] DeviceHandle device) =>
            Underlying.Value!.CaptureStart(device);

        [NativeName("alcCaptureStop")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureStop([NativeName("device")] DeviceHandle device) =>
            Underlying.Value!.CaptureStop(device);

        [NativeName("alcCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> CloseDevice([NativeName("device")] DeviceHandle device) =>
            Underlying.Value!.CloseDevice(device);

        [NativeName("alcCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte CloseDeviceRaw([NativeName("device")] DeviceHandle device) =>
            Underlying.Value!.CloseDeviceRaw(device);

        [NativeName("alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle CreateContext(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attrlist")] int* attrlist
        ) => Underlying.Value!.CreateContext(device, attrlist);

        [NativeName("alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle CreateContext(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attrlist")] Ref<int> attrlist
        )
        {
            fixed (int* __dsl_attrlist = attrlist)
            {
                return (ContextHandle)CreateContext(device, __dsl_attrlist);
            }
        }

        [NativeName("alcDestroyContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DestroyContext([NativeName("context")] ContextHandle context) =>
            Underlying.Value!.DestroyContext(context);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcDevicePauseSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DevicePauseSOFT([NativeName("device")] DeviceHandle device) =>
            Underlying.Value!.DevicePauseSOFT(device);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcDeviceResumeSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeviceResumeSOFT([NativeName("device")] DeviceHandle device) =>
            Underlying.Value!.DeviceResumeSOFT(device);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventCallbackSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void EventCallbackSOFT(
            [NativeName("callback")] ContextEventProcSOFT callback,
            [NativeName("userParam")] void* userParam
        ) => Underlying.Value!.EventCallbackSOFT(callback, userParam);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventCallbackSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void EventCallbackSOFT(
            [NativeName("callback")] ContextEventProcSOFT callback,
            [NativeName("userParam")] Ref userParam
        )
        {
            fixed (void* __dsl_userParam = userParam)
            {
                EventCallbackSOFT(callback, __dsl_userParam);
            }
        }

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventControlSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte EventControlSOFT(
            [NativeName("count")] int count,
            [NativeName("events")] int* events,
            [NativeName("enable")] sbyte enable
        ) => Underlying.Value!.EventControlSOFT(count, events, enable);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventControlSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> EventControlSOFT(
            [NativeName("count")] int count,
            [NativeName("events")] Ref<int> events,
            [NativeName("enable")] MaybeBool<sbyte> enable
        )
        {
            fixed (int* __dsl_events = events)
            {
                return (MaybeBool<sbyte>)
                    (sbyte)EventControlSOFT(count, __dsl_events, (sbyte)enable);
            }
        }

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventIsSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int EventIsSupportedSOFT(
            [NativeName("eventType")] int eventType,
            [NativeName("deviceType")] int deviceType
        ) => Underlying.Value!.EventIsSupportedSOFT(eventType, deviceType);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcEventIsSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Constant<int, AlcEnum, EventSupportSOFT> EventIsSupportedSOFT(
            [NativeName("eventType")] Constant<int, EventTypeSOFT> eventType,
            [NativeName("deviceType")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
        ) => Underlying.Value!.EventIsSupportedSOFT(eventType, deviceType);

        [NativeName("alcGetContextsDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle GetContextsDevice(
            [NativeName("context")] ContextHandle context
        ) => Underlying.Value!.GetContextsDevice(context);

        [NativeName("alcGetCurrentContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle GetCurrentContext() => Underlying.Value!.GetCurrentContext();

        [NativeName("alcGetEnumValue")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue(
            [NativeName("device")] DeviceHandle device,
            [NativeName("enumname")] sbyte* enumname
        ) => Underlying.Value!.GetEnumValue(device, enumname);

        [NativeName("alcGetEnumValue")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue(
            [NativeName("device")] DeviceHandle device,
            [NativeName("enumname")] Ref<sbyte> enumname
        )
        {
            fixed (sbyte* __dsl_enumname = enumname)
            {
                return (int)GetEnumValue(device, __dsl_enumname);
            }
        }

        [NativeName("alcGetError")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Constant<int, ErrorCode> GetError(
            [NativeName("device")] DeviceHandle device
        ) => Underlying.Value!.GetError(device);

        [NativeName("alcGetError")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetErrorRaw([NativeName("device")] DeviceHandle device) =>
            Underlying.Value!.GetErrorRaw(device);

        [NameAffix("Suffix", "v", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname,
            [NativeName("size")] int size,
            [NativeName("values")] nint* values
        ) => Underlying.Value!.GetInteger64SOFT(device, pname, size, values);

        [NameAffix("Suffix", "v", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname,
            [NativeName("size")] int size,
            [NativeName("values")] Ref<nint> values
        )
        {
            fixed (nint* __dsl_values = values)
            {
                GetInteger64SOFT(device, pname, size, __dsl_values);
            }
        }

        [NameAffix("Suffix", "v", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static nint GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname
        )
        {
            nint values = default;
            GetInteger64SOFT(device, pname, 1, (nint*)&values);
            return values;
        }

        [NameAffix("Suffix", "v", 0, 0)]
        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1,
            [NativeName("size")] int size,
            [NativeName("values")] int* values
        ) => Underlying.Value!.GetInteger(device, param1, size, values);

        [NameAffix("Suffix", "v", 0, 0)]
        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1,
            [NativeName("size")] int size,
            [NativeName("values")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetInteger(device, param1, size, __dsl_values);
            }
        }

        [NameAffix("Suffix", "v", 0, 0)]
        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1
        )
        {
            int values = default;
            GetInteger(device, param1, 1, (int*)&values);
            return values;
        }

        [NativeName("alcGetProcAddress")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void* GetProcAddress(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcname")] sbyte* funcname
        ) => Underlying.Value!.GetProcAddress(device, funcname);

        [NativeName("alcGetProcAddress")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetProcAddress(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcname")] Ref<sbyte> funcname
        )
        {
            fixed (sbyte* __dsl_funcname = funcname)
            {
                return (void*)GetProcAddress(device, __dsl_funcname);
            }
        }

        [NativeName("alcGetProcAddress2")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void* GetProcAddress2(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcName")] sbyte* funcName
        ) => Underlying.Value!.GetProcAddress2(device, funcName);

        [NativeName("alcGetProcAddress2")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetProcAddress2(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcName")] Ref<sbyte> funcName
        )
        {
            fixed (sbyte* __dsl_funcName = funcName)
            {
                return (void*)GetProcAddress2(device, __dsl_funcName);
            }
        }

        [NativeName("alcGetString")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte* GetString(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1
        ) => Underlying.Value!.GetString(device, param1);

        [NativeName("alcGetString")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetString(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] Constant<int, AlcEnum, ContextString> param1
        ) => Underlying.Value!.GetString(device, param1);

        [NameAffix("Suffix", "i", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetStringiSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte* GetStringSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("paramName")] int paramName,
            [NativeName("index")] int index
        ) => Underlying.Value!.GetStringSOFT(device, paramName, index);

        [NameAffix("Suffix", "i", 0, 0)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcGetStringiSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetStringSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("paramName")] Constant<int, AlcEnum, ContextString> paramName,
            [NativeName("index")] int index
        ) => Underlying.Value!.GetStringSOFT(device, paramName, index);

        [NativeName("alcGetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle GetThreadContext() => Underlying.Value!.GetThreadContext();

        [NativeName("alcIsExtensionPresent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsExtensionPresent(
            [NativeName("device")] DeviceHandle device,
            [NativeName("extname")] sbyte* extname
        ) => Underlying.Value!.IsExtensionPresent(device, extname);

        [NativeName("alcIsExtensionPresent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsExtensionPresent(
            [NativeName("device")] DeviceHandle device,
            [NativeName("extname")] Ref<sbyte> extname
        )
        {
            fixed (sbyte* __dsl_extname = extname)
            {
                return (MaybeBool<sbyte>)(sbyte)IsExtensionPresent(device, __dsl_extname);
            }
        }

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcIsRenderFormatSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsRenderFormatSupportedSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("freq")] int freq,
            [NativeName("channels")] int channels,
            [NativeName("type")] int type
        ) => Underlying.Value!.IsRenderFormatSupportedSOFT(device, freq, channels, type);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcIsRenderFormatSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsRenderFormatSupportedSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("freq")] int freq,
            [NativeName("channels")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
            [NativeName("type")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
        ) => Underlying.Value!.IsRenderFormatSupportedSOFT(device, freq, channels, type);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcLoopbackOpenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle LoopbackOpenDeviceSOFT(
            [NativeName("deviceName")] sbyte* deviceName
        ) => Underlying.Value!.LoopbackOpenDeviceSOFT(deviceName);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcLoopbackOpenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle LoopbackOpenDeviceSOFT(
            [NativeName("deviceName")] Ref<sbyte> deviceName
        )
        {
            fixed (sbyte* __dsl_deviceName = deviceName)
            {
                return (DeviceHandle)LoopbackOpenDeviceSOFT(__dsl_deviceName);
            }
        }

        [NativeName("alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> MakeContextCurrent(
            [NativeName("context")] ContextHandle context
        ) => Underlying.Value!.MakeContextCurrent(context);

        [NativeName("alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte MakeContextCurrentRaw([NativeName("context")] ContextHandle context) =>
            Underlying.Value!.MakeContextCurrentRaw(context);

        [NativeName("alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle OpenDevice([NativeName("devicename")] sbyte* devicename) =>
            Underlying.Value!.OpenDevice(devicename);

        [NativeName("alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle OpenDevice([NativeName("devicename")] Ref<sbyte> devicename)
        {
            fixed (sbyte* __dsl_devicename = devicename)
            {
                return (DeviceHandle)OpenDevice(__dsl_devicename);
            }
        }

        [NativeName("alcProcessContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void ProcessContext([NativeName("context")] ContextHandle context) =>
            Underlying.Value!.ProcessContext(context);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcRenderSamplesSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void RenderSamplesSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] void* buffer,
            [NativeName("samples")] int samples
        ) => Underlying.Value!.RenderSamplesSOFT(device, buffer, samples);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcRenderSamplesSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void RenderSamplesSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] Ref buffer,
            [NativeName("samples")] int samples
        )
        {
            fixed (void* __dsl_buffer = buffer)
            {
                RenderSamplesSOFT(device, __dsl_buffer, samples);
            }
        }

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcReopenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte ReopenDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("deviceName")] sbyte* deviceName,
            [NativeName("attribs")] int* attribs
        ) => Underlying.Value!.ReopenDeviceSOFT(device, deviceName, attribs);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcReopenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> ReopenDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("deviceName")] Ref<sbyte> deviceName,
            [NativeName("attribs")] Ref<int> attribs
        )
        {
            fixed (int* __dsl_attribs = attribs)
            fixed (sbyte* __dsl_deviceName = deviceName)
            {
                return (MaybeBool<sbyte>)
                    (sbyte)ReopenDeviceSOFT(device, __dsl_deviceName, __dsl_attribs);
            }
        }

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcResetDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte ResetDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attribs")] int* attribs
        ) => Underlying.Value!.ResetDeviceSOFT(device, attribs);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alcResetDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> ResetDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attribs")] Ref<int> attribs
        )
        {
            fixed (int* __dsl_attribs = attribs)
            {
                return (MaybeBool<sbyte>)(sbyte)ResetDeviceSOFT(device, __dsl_attribs);
            }
        }

        [NativeName("alcSetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> SetThreadContext(
            [NativeName("context")] ContextHandle context
        ) => Underlying.Value!.SetThreadContext(context);

        [NativeName("alcSetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte SetThreadContextRaw([NativeName("context")] ContextHandle context) =>
            Underlying.Value!.SetThreadContextRaw(context);

        [NativeName("alcSuspendContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SuspendContext([NativeName("context")] ContextHandle context) =>
            Underlying.Value!.SuspendContext(context);
    }

    [NativeName("ALC_CPLUSPLUS")]
    public const nint Cplusplus = 201703;

    [NativeName("ALC_VERSION_0_1")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    public const int Version0X1 = 1;

    [NativeName("ALC_EXT_CAPTURE")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    public const int ExtCapture = 1;

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("ALC_ENUMERATE_ALL_EXT")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    public const int EnumerateAllEXT = 1;

    [NativeName("ALC_EXT_EFX_NAME")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    public static ReadOnlySpan<byte> ExtEfxName => "ALC_EXT_EFX"u8;

    [NativeName("alcCaptureCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.CaptureCloseDevice([NativeName("device")] DeviceHandle device) =>
        (MaybeBool<sbyte>)(sbyte)((IAlContext)this).CaptureCloseDeviceRaw(device);

    [NativeName("alcCaptureCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> CaptureCloseDevice([NativeName("device")] DeviceHandle device) =>
        ThisThread.CaptureCloseDevice(device);

    [NativeName("alcCaptureCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.CaptureCloseDeviceRaw([NativeName("device")] DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte>)(
                _slots[0] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[0] = nativeContext.LoadFunction("alcCaptureCloseDevice", "openal")
            )
        )(device);

    [NativeName("alcCaptureCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte CaptureCloseDeviceRaw([NativeName("device")] DeviceHandle device) =>
        ThisThread.CaptureCloseDeviceRaw(device);

    [NativeName("alcCaptureOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.CaptureOpenDevice(
        [NativeName("devicename")] sbyte* devicename,
        [NativeName("frequency")] uint frequency,
        [NativeName("format")] int format,
        [NativeName("buffersize")] int buffersize
    ) =>
        (
            (delegate* unmanaged<sbyte*, uint, int, int, DeviceHandle>)(
                _slots[1] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[1] = nativeContext.LoadFunction("alcCaptureOpenDevice", "openal")
            )
        )(devicename, frequency, format, buffersize);

    [NativeName("alcCaptureOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle CaptureOpenDevice(
        [NativeName("devicename")] sbyte* devicename,
        [NativeName("frequency")] uint frequency,
        [NativeName("format")] int format,
        [NativeName("buffersize")] int buffersize
    ) => ThisThread.CaptureOpenDevice(devicename, frequency, format, buffersize);

    [NativeName("alcCaptureOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.CaptureOpenDevice(
        [NativeName("devicename")] Ref<sbyte> devicename,
        [NativeName("frequency")] uint frequency,
        [NativeName("format")] Constant<int, AlEnum, Format> format,
        [NativeName("buffersize")] int buffersize
    )
    {
        fixed (sbyte* __dsl_devicename = devicename)
        {
            return (DeviceHandle)
                ((IAlContext)this).CaptureOpenDevice(
                    __dsl_devicename,
                    frequency,
                    (int)format,
                    buffersize
                );
        }
    }

    [NativeName("alcCaptureOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle CaptureOpenDevice(
        [NativeName("devicename")] Ref<sbyte> devicename,
        [NativeName("frequency")] uint frequency,
        [NativeName("format")] Constant<int, AlEnum, Format> format,
        [NativeName("buffersize")] int buffersize
    ) => ThisThread.CaptureOpenDevice(devicename, frequency, format, buffersize);

    [NativeName("alcCaptureSamples")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.CaptureSamples(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] void* buffer,
        [NativeName("samples")] int samples
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, void*, int, void>)(
                _slots[2] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[2] = nativeContext.LoadFunction("alcCaptureSamples", "openal")
            )
        )(device, buffer, samples);

    [NativeName("alcCaptureSamples")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureSamples(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] void* buffer,
        [NativeName("samples")] int samples
    ) => ThisThread.CaptureSamples(device, buffer, samples);

    [NativeName("alcCaptureSamples")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.CaptureSamples(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] Ref buffer,
        [NativeName("samples")] int samples
    )
    {
        fixed (void* __dsl_buffer = buffer)
        {
            ((IAlContext)this).CaptureSamples(device, __dsl_buffer, samples);
        }
    }

    [NativeName("alcCaptureSamples")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureSamples(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] Ref buffer,
        [NativeName("samples")] int samples
    ) => ThisThread.CaptureSamples(device, buffer, samples);

    [NativeName("alcCaptureStart")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.CaptureStart([NativeName("device")] DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, void>)(
                _slots[3] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[3] = nativeContext.LoadFunction("alcCaptureStart", "openal")
            )
        )(device);

    [NativeName("alcCaptureStart")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureStart([NativeName("device")] DeviceHandle device) =>
        ThisThread.CaptureStart(device);

    [NativeName("alcCaptureStop")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.CaptureStop([NativeName("device")] DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, void>)(
                _slots[4] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[4] = nativeContext.LoadFunction("alcCaptureStop", "openal")
            )
        )(device);

    [NativeName("alcCaptureStop")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureStop([NativeName("device")] DeviceHandle device) =>
        ThisThread.CaptureStop(device);

    [NativeName("alcCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.CloseDevice([NativeName("device")] DeviceHandle device) =>
        (MaybeBool<sbyte>)(sbyte)((IAlContext)this).CloseDeviceRaw(device);

    [NativeName("alcCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> CloseDevice([NativeName("device")] DeviceHandle device) =>
        ThisThread.CloseDevice(device);

    [NativeName("alcCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.CloseDeviceRaw([NativeName("device")] DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte>)(
                _slots[5] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[5] = nativeContext.LoadFunction("alcCloseDevice", "openal")
            )
        )(device);

    [NativeName("alcCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte CloseDeviceRaw([NativeName("device")] DeviceHandle device) =>
        ThisThread.CloseDeviceRaw(device);

    [NativeName("alcCreateContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ContextHandle IAlContext.CreateContext(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attrlist")] int* attrlist
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int*, ContextHandle>)(
                _slots[6] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[6] = nativeContext.LoadFunction("alcCreateContext", "openal")
            )
        )(device, attrlist);

    [NativeName("alcCreateContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ContextHandle CreateContext(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attrlist")] int* attrlist
    ) => ThisThread.CreateContext(device, attrlist);

    [NativeName("alcCreateContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ContextHandle IAlContext.CreateContext(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attrlist")] Ref<int> attrlist
    )
    {
        fixed (int* __dsl_attrlist = attrlist)
        {
            return (ContextHandle)((IAlContext)this).CreateContext(device, __dsl_attrlist);
        }
    }

    [NativeName("alcCreateContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ContextHandle CreateContext(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attrlist")] Ref<int> attrlist
    ) => ThisThread.CreateContext(device, attrlist);

    [NativeName("alcDestroyContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.DestroyContext([NativeName("context")] ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, void>)(
                _slots[7] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[7] = nativeContext.LoadFunction("alcDestroyContext", "openal")
            )
        )(context);

    [NativeName("alcDestroyContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DestroyContext([NativeName("context")] ContextHandle context) =>
        ThisThread.DestroyContext(context);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcDevicePauseSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.DevicePauseSOFT([NativeName("device")] DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, void>)(
                _slots[8] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[8] = nativeContext.LoadFunction("alcDevicePauseSOFT", "openal")
            )
        )(device);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcDevicePauseSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DevicePauseSOFT([NativeName("device")] DeviceHandle device) =>
        ThisThread.DevicePauseSOFT(device);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcDeviceResumeSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.DeviceResumeSOFT([NativeName("device")] DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, void>)(
                _slots[9] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[9] = nativeContext.LoadFunction("alcDeviceResumeSOFT", "openal")
            )
        )(device);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcDeviceResumeSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DeviceResumeSOFT([NativeName("device")] DeviceHandle device) =>
        ThisThread.DeviceResumeSOFT(device);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventCallbackSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.EventCallbackSOFT(
        [NativeName("callback")] ContextEventProcSOFT callback,
        [NativeName("userParam")] void* userParam
    ) =>
        (
            (delegate* unmanaged<ContextEventProcSOFT, void*, void>)(
                _slots[10] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[10] = nativeContext.LoadFunction("alcEventCallbackSOFT", "openal")
            )
        )(callback, userParam);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventCallbackSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void EventCallbackSOFT(
        [NativeName("callback")] ContextEventProcSOFT callback,
        [NativeName("userParam")] void* userParam
    ) => ThisThread.EventCallbackSOFT(callback, userParam);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventCallbackSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.EventCallbackSOFT(
        [NativeName("callback")] ContextEventProcSOFT callback,
        [NativeName("userParam")] Ref userParam
    )
    {
        fixed (void* __dsl_userParam = userParam)
        {
            ((IAlContext)this).EventCallbackSOFT(callback, __dsl_userParam);
        }
    }

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventCallbackSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void EventCallbackSOFT(
        [NativeName("callback")] ContextEventProcSOFT callback,
        [NativeName("userParam")] Ref userParam
    ) => ThisThread.EventCallbackSOFT(callback, userParam);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventControlSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.EventControlSOFT(
        [NativeName("count")] int count,
        [NativeName("events")] int* events,
        [NativeName("enable")] sbyte enable
    ) =>
        (
            (delegate* unmanaged<int, int*, sbyte, sbyte>)(
                _slots[11] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[11] = nativeContext.LoadFunction("alcEventControlSOFT", "openal")
            )
        )(count, events, enable);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventControlSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte EventControlSOFT(
        [NativeName("count")] int count,
        [NativeName("events")] int* events,
        [NativeName("enable")] sbyte enable
    ) => ThisThread.EventControlSOFT(count, events, enable);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventControlSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.EventControlSOFT(
        [NativeName("count")] int count,
        [NativeName("events")] Ref<int> events,
        [NativeName("enable")] MaybeBool<sbyte> enable
    )
    {
        fixed (int* __dsl_events = events)
        {
            return (MaybeBool<sbyte>)
                (sbyte)((IAlContext)this).EventControlSOFT(count, __dsl_events, (sbyte)enable);
        }
    }

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventControlSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> EventControlSOFT(
        [NativeName("count")] int count,
        [NativeName("events")] Ref<int> events,
        [NativeName("enable")] MaybeBool<sbyte> enable
    ) => ThisThread.EventControlSOFT(count, events, enable);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventIsSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAlContext.EventIsSupportedSOFT(
        [NativeName("eventType")] int eventType,
        [NativeName("deviceType")] int deviceType
    ) =>
        (
            (delegate* unmanaged<int, int, int>)(
                _slots[12] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[12] = nativeContext.LoadFunction("alcEventIsSupportedSOFT", "openal")
            )
        )(eventType, deviceType);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventIsSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int EventIsSupportedSOFT(
        [NativeName("eventType")] int eventType,
        [NativeName("deviceType")] int deviceType
    ) => ThisThread.EventIsSupportedSOFT(eventType, deviceType);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventIsSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Constant<int, AlcEnum, EventSupportSOFT> IAlContext.EventIsSupportedSOFT(
        [NativeName("eventType")] Constant<int, EventTypeSOFT> eventType,
        [NativeName("deviceType")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
    ) =>
        (Constant<int, AlcEnum, EventSupportSOFT>)
            (int)((IAlContext)this).EventIsSupportedSOFT((int)eventType, (int)deviceType);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcEventIsSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Constant<int, AlcEnum, EventSupportSOFT> EventIsSupportedSOFT(
        [NativeName("eventType")] Constant<int, EventTypeSOFT> eventType,
        [NativeName("deviceType")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
    ) => ThisThread.EventIsSupportedSOFT(eventType, deviceType);

    [NativeName("alcGetContextsDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.GetContextsDevice([NativeName("context")] ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, DeviceHandle>)(
                _slots[13] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[13] = nativeContext.LoadFunction("alcGetContextsDevice", "openal")
            )
        )(context);

    [NativeName("alcGetContextsDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle GetContextsDevice([NativeName("context")] ContextHandle context) =>
        ThisThread.GetContextsDevice(context);

    [NativeName("alcGetCurrentContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ContextHandle IAlContext.GetCurrentContext() =>
        (
            (delegate* unmanaged<ContextHandle>)(
                _slots[14] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[14] = nativeContext.LoadFunction("alcGetCurrentContext", "openal")
            )
        )();

    [NativeName("alcGetCurrentContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ContextHandle GetCurrentContext() => ThisThread.GetCurrentContext();

    [NativeName("alcGetEnumValue")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAlContext.GetEnumValue(
        [NativeName("device")] DeviceHandle device,
        [NativeName("enumname")] sbyte* enumname
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, int>)(
                _slots[15] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[15] = nativeContext.LoadFunction("alcGetEnumValue", "openal")
            )
        )(device, enumname);

    [NativeName("alcGetEnumValue")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetEnumValue(
        [NativeName("device")] DeviceHandle device,
        [NativeName("enumname")] sbyte* enumname
    ) => ThisThread.GetEnumValue(device, enumname);

    [NativeName("alcGetEnumValue")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAlContext.GetEnumValue(
        [NativeName("device")] DeviceHandle device,
        [NativeName("enumname")] Ref<sbyte> enumname
    )
    {
        fixed (sbyte* __dsl_enumname = enumname)
        {
            return (int)((IAlContext)this).GetEnumValue(device, __dsl_enumname);
        }
    }

    [NativeName("alcGetEnumValue")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetEnumValue(
        [NativeName("device")] DeviceHandle device,
        [NativeName("enumname")] Ref<sbyte> enumname
    ) => ThisThread.GetEnumValue(device, enumname);

    [NativeName("alcGetError")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Constant<int, ErrorCode> IAlContext.GetError([NativeName("device")] DeviceHandle device) =>
        (Constant<int, ErrorCode>)(int)((IAlContext)this).GetErrorRaw(device);

    [NativeName("alcGetError")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Constant<int, ErrorCode> GetError([NativeName("device")] DeviceHandle device) =>
        ThisThread.GetError(device);

    [NativeName("alcGetError")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAlContext.GetErrorRaw([NativeName("device")] DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, int>)(
                _slots[16] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[16] = nativeContext.LoadFunction("alcGetError", "openal")
            )
        )(device);

    [NativeName("alcGetError")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetErrorRaw([NativeName("device")] DeviceHandle device) =>
        ThisThread.GetErrorRaw(device);

    [NameAffix("Suffix", "v", 0, 0)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.GetInteger64SOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("pname")] int pname,
        [NativeName("size")] int size,
        [NativeName("values")] nint* values
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int, int, nint*, void>)(
                _slots[17] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[17] = nativeContext.LoadFunction("alcGetInteger64vSOFT", "openal")
            )
        )(device, pname, size, values);

    [NameAffix("Suffix", "v", 0, 0)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger64SOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("pname")] int pname,
        [NativeName("size")] int size,
        [NativeName("values")] nint* values
    ) => ThisThread.GetInteger64SOFT(device, pname, size, values);

    [NameAffix("Suffix", "v", 0, 0)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.GetInteger64SOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("pname")] int pname,
        [NativeName("size")] int size,
        [NativeName("values")] Ref<nint> values
    )
    {
        fixed (nint* __dsl_values = values)
        {
            ((IAlContext)this).GetInteger64SOFT(device, pname, size, __dsl_values);
        }
    }

    [NameAffix("Suffix", "v", 0, 0)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger64SOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("pname")] int pname,
        [NativeName("size")] int size,
        [NativeName("values")] Ref<nint> values
    ) => ThisThread.GetInteger64SOFT(device, pname, size, values);

    [NameAffix("Suffix", "v", 0, 0)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    nint IAlContext.GetInteger64SOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("pname")] int pname
    )
    {
        nint values = default;
        ((IAlContext)this).GetInteger64SOFT(device, pname, 1, (nint*)&values);
        return values;
    }

    [NameAffix("Suffix", "v", 0, 0)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static nint GetInteger64SOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("pname")] int pname
    ) => ThisThread.GetInteger64SOFT(device, pname);

    [NameAffix("Suffix", "v", 0, 0)]
    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.GetInteger(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] int param1,
        [NativeName("size")] int size,
        [NativeName("values")] int* values
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int, int, int*, void>)(
                _slots[18] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[18] = nativeContext.LoadFunction("alcGetIntegerv", "openal")
            )
        )(device, param1, size, values);

    [NameAffix("Suffix", "v", 0, 0)]
    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] int param1,
        [NativeName("size")] int size,
        [NativeName("values")] int* values
    ) => ThisThread.GetInteger(device, param1, size, values);

    [NameAffix("Suffix", "v", 0, 0)]
    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.GetInteger(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] int param1,
        [NativeName("size")] int size,
        [NativeName("values")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAlContext)this).GetInteger(device, param1, size, __dsl_values);
        }
    }

    [NameAffix("Suffix", "v", 0, 0)]
    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] int param1,
        [NativeName("size")] int size,
        [NativeName("values")] Ref<int> values
    ) => ThisThread.GetInteger(device, param1, size, values);

    [NameAffix("Suffix", "v", 0, 0)]
    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAlContext.GetInteger(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] int param1
    )
    {
        int values = default;
        ((IAlContext)this).GetInteger(device, param1, 1, (int*)&values);
        return values;
    }

    [NameAffix("Suffix", "v", 0, 0)]
    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetInteger(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] int param1
    ) => ThisThread.GetInteger(device, param1);

    [NativeName("alcGetProcAddress")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void* IAlContext.GetProcAddress(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcname")] sbyte* funcname
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, void*>)(
                _slots[19] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[19] = nativeContext.LoadFunction("alcGetProcAddress", "openal")
            )
        )(device, funcname);

    [NativeName("alcGetProcAddress")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void* GetProcAddress(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcname")] sbyte* funcname
    ) => ThisThread.GetProcAddress(device, funcname);

    [NativeName("alcGetProcAddress")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr IAlContext.GetProcAddress(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcname")] Ref<sbyte> funcname
    )
    {
        fixed (sbyte* __dsl_funcname = funcname)
        {
            return (void*)((IAlContext)this).GetProcAddress(device, __dsl_funcname);
        }
    }

    [NativeName("alcGetProcAddress")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr GetProcAddress(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcname")] Ref<sbyte> funcname
    ) => ThisThread.GetProcAddress(device, funcname);

    [NativeName("alcGetProcAddress2")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void* IAlContext.GetProcAddress2(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcName")] sbyte* funcName
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, void*>)(
                _slots[20] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[20] = nativeContext.LoadFunction("alcGetProcAddress2", "openal")
            )
        )(device, funcName);

    [NativeName("alcGetProcAddress2")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void* GetProcAddress2(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcName")] sbyte* funcName
    ) => ThisThread.GetProcAddress2(device, funcName);

    [NativeName("alcGetProcAddress2")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr IAlContext.GetProcAddress2(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcName")] Ref<sbyte> funcName
    )
    {
        fixed (sbyte* __dsl_funcName = funcName)
        {
            return (void*)((IAlContext)this).GetProcAddress2(device, __dsl_funcName);
        }
    }

    [NativeName("alcGetProcAddress2")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr GetProcAddress2(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcName")] Ref<sbyte> funcName
    ) => ThisThread.GetProcAddress2(device, funcName);

    [NativeName("alcGetString")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte* IAlContext.GetString(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] int param1
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int, sbyte*>)(
                _slots[21] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[21] = nativeContext.LoadFunction("alcGetString", "openal")
            )
        )(device, param1);

    [NativeName("alcGetString")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte* GetString(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] int param1
    ) => ThisThread.GetString(device, param1);

    [NativeName("alcGetString")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr<sbyte> IAlContext.GetString(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] Constant<int, AlcEnum, ContextString> param1
    ) => (sbyte*)((IAlContext)this).GetString(device, (int)param1);

    [NativeName("alcGetString")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<sbyte> GetString(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] Constant<int, AlcEnum, ContextString> param1
    ) => ThisThread.GetString(device, param1);

    [NameAffix("Suffix", "i", 0, 0)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcGetStringiSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte* IAlContext.GetStringSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("paramName")] int paramName,
        [NativeName("index")] int index
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int, int, sbyte*>)(
                _slots[22] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[22] = nativeContext.LoadFunction("alcGetStringiSOFT", "openal")
            )
        )(device, paramName, index);

    [NameAffix("Suffix", "i", 0, 0)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcGetStringiSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte* GetStringSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("paramName")] int paramName,
        [NativeName("index")] int index
    ) => ThisThread.GetStringSOFT(device, paramName, index);

    [NameAffix("Suffix", "i", 0, 0)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcGetStringiSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr<sbyte> IAlContext.GetStringSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("paramName")] Constant<int, AlcEnum, ContextString> paramName,
        [NativeName("index")] int index
    ) => (sbyte*)((IAlContext)this).GetStringSOFT(device, (int)paramName, index);

    [NameAffix("Suffix", "i", 0, 0)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcGetStringiSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<sbyte> GetStringSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("paramName")] Constant<int, AlcEnum, ContextString> paramName,
        [NativeName("index")] int index
    ) => ThisThread.GetStringSOFT(device, paramName, index);

    [NativeName("alcGetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ContextHandle IAlContext.GetThreadContext() =>
        (
            (delegate* unmanaged<ContextHandle>)(
                _slots[23] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[23] = nativeContext.LoadFunction("alcGetThreadContext", "openal")
            )
        )();

    [NativeName("alcGetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ContextHandle GetThreadContext() => ThisThread.GetThreadContext();

    [NativeName("alcIsExtensionPresent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.IsExtensionPresent(
        [NativeName("device")] DeviceHandle device,
        [NativeName("extname")] sbyte* extname
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, sbyte>)(
                _slots[24] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[24] = nativeContext.LoadFunction("alcIsExtensionPresent", "openal")
            )
        )(device, extname);

    [NativeName("alcIsExtensionPresent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsExtensionPresent(
        [NativeName("device")] DeviceHandle device,
        [NativeName("extname")] sbyte* extname
    ) => ThisThread.IsExtensionPresent(device, extname);

    [NativeName("alcIsExtensionPresent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.IsExtensionPresent(
        [NativeName("device")] DeviceHandle device,
        [NativeName("extname")] Ref<sbyte> extname
    )
    {
        fixed (sbyte* __dsl_extname = extname)
        {
            return (MaybeBool<sbyte>)
                (sbyte)((IAlContext)this).IsExtensionPresent(device, __dsl_extname);
        }
    }

    [NativeName("alcIsExtensionPresent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> IsExtensionPresent(
        [NativeName("device")] DeviceHandle device,
        [NativeName("extname")] Ref<sbyte> extname
    ) => ThisThread.IsExtensionPresent(device, extname);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcIsRenderFormatSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.IsRenderFormatSupportedSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("freq")] int freq,
        [NativeName("channels")] int channels,
        [NativeName("type")] int type
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int, int, int, sbyte>)(
                _slots[25] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[25] = nativeContext.LoadFunction(
                        "alcIsRenderFormatSupportedSOFT",
                        "openal"
                    )
            )
        )(device, freq, channels, type);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcIsRenderFormatSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsRenderFormatSupportedSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("freq")] int freq,
        [NativeName("channels")] int channels,
        [NativeName("type")] int type
    ) => ThisThread.IsRenderFormatSupportedSOFT(device, freq, channels, type);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcIsRenderFormatSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.IsRenderFormatSupportedSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("freq")] int freq,
        [NativeName("channels")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
        [NativeName("type")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
    ) =>
        (MaybeBool<sbyte>)
            (sbyte)
                ((IAlContext)this).IsRenderFormatSupportedSOFT(
                    device,
                    freq,
                    (int)channels,
                    (int)type
                );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcIsRenderFormatSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> IsRenderFormatSupportedSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("freq")] int freq,
        [NativeName("channels")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
        [NativeName("type")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
    ) => ThisThread.IsRenderFormatSupportedSOFT(device, freq, channels, type);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcLoopbackOpenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.LoopbackOpenDeviceSOFT([NativeName("deviceName")] sbyte* deviceName) =>
        (
            (delegate* unmanaged<sbyte*, DeviceHandle>)(
                _slots[26] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[26] = nativeContext.LoadFunction("alcLoopbackOpenDeviceSOFT", "openal")
            )
        )(deviceName);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcLoopbackOpenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle LoopbackOpenDeviceSOFT(
        [NativeName("deviceName")] sbyte* deviceName
    ) => ThisThread.LoopbackOpenDeviceSOFT(deviceName);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcLoopbackOpenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.LoopbackOpenDeviceSOFT([NativeName("deviceName")] Ref<sbyte> deviceName)
    {
        fixed (sbyte* __dsl_deviceName = deviceName)
        {
            return (DeviceHandle)((IAlContext)this).LoopbackOpenDeviceSOFT(__dsl_deviceName);
        }
    }

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcLoopbackOpenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle LoopbackOpenDeviceSOFT(
        [NativeName("deviceName")] Ref<sbyte> deviceName
    ) => ThisThread.LoopbackOpenDeviceSOFT(deviceName);

    [NativeName("alcMakeContextCurrent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.MakeContextCurrent([NativeName("context")] ContextHandle context) =>
        (MaybeBool<sbyte>)(sbyte)((IAlContext)this).MakeContextCurrentRaw(context);

    [NativeName("alcMakeContextCurrent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> MakeContextCurrent(
        [NativeName("context")] ContextHandle context
    ) => ThisThread.MakeContextCurrent(context);

    [NativeName("alcMakeContextCurrent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private MaybeBool<sbyte> MakeContextCurrentInternal(
        [NativeName("context")] ContextHandle context
    ) => (MaybeBool<sbyte>)(sbyte)MakeContextCurrentInternalRaw(context);

    [NativeName("alcMakeContextCurrent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private sbyte MakeContextCurrentInternalRaw([NativeName("context")] ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, sbyte>)(
                _slots[27] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[27] = nativeContext.LoadFunction("alcMakeContextCurrent", "openal")
            )
        )(context);

    [NativeName("alcMakeContextCurrent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte MakeContextCurrentRaw([NativeName("context")] ContextHandle context) =>
        ThisThread.MakeContextCurrentRaw(context);

    [NativeName("alcOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle OpenDevice([NativeName("devicename")] sbyte* devicename) =>
        ThisThread.OpenDevice(devicename);

    [NativeName("alcOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.OpenDevice([NativeName("devicename")] Ref<sbyte> devicename)
    {
        fixed (sbyte* __dsl_devicename = devicename)
        {
            return (DeviceHandle)((IAlContext)this).OpenDevice(__dsl_devicename);
        }
    }

    [NativeName("alcOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle OpenDevice([NativeName("devicename")] Ref<sbyte> devicename) =>
        ThisThread.OpenDevice(devicename);

    [NativeName("alcOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private DeviceHandle OpenDeviceInternal([NativeName("devicename")] sbyte* devicename) =>
        (
            (delegate* unmanaged<sbyte*, DeviceHandle>)(
                _slots[28] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[28] = nativeContext.LoadFunction("alcOpenDevice", "openal")
            )
        )(devicename);

    [NativeName("alcOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private DeviceHandle OpenDeviceInternal([NativeName("devicename")] Ref<sbyte> devicename)
    {
        fixed (sbyte* __dsl_devicename = devicename)
        {
            return (DeviceHandle)OpenDeviceInternal(__dsl_devicename);
        }
    }

    [NativeName("alcProcessContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcProcessContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.ProcessContext([NativeName("context")] ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, void>)(
                _slots[29] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[29] = nativeContext.LoadFunction("alcProcessContext", "openal")
            )
        )(context);

    [NativeName("alcProcessContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcProcessContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ProcessContext([NativeName("context")] ContextHandle context) =>
        ThisThread.ProcessContext(context);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcRenderSamplesSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.RenderSamplesSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] void* buffer,
        [NativeName("samples")] int samples
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, void*, int, void>)(
                _slots[30] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[30] = nativeContext.LoadFunction("alcRenderSamplesSOFT", "openal")
            )
        )(device, buffer, samples);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcRenderSamplesSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void RenderSamplesSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] void* buffer,
        [NativeName("samples")] int samples
    ) => ThisThread.RenderSamplesSOFT(device, buffer, samples);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcRenderSamplesSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.RenderSamplesSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] Ref buffer,
        [NativeName("samples")] int samples
    )
    {
        fixed (void* __dsl_buffer = buffer)
        {
            ((IAlContext)this).RenderSamplesSOFT(device, __dsl_buffer, samples);
        }
    }

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcRenderSamplesSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void RenderSamplesSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] Ref buffer,
        [NativeName("samples")] int samples
    ) => ThisThread.RenderSamplesSOFT(device, buffer, samples);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcReopenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.ReopenDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("deviceName")] sbyte* deviceName,
        [NativeName("attribs")] int* attribs
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, int*, sbyte>)(
                _slots[31] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[31] = nativeContext.LoadFunction("alcReopenDeviceSOFT", "openal")
            )
        )(device, deviceName, attribs);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcReopenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte ReopenDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("deviceName")] sbyte* deviceName,
        [NativeName("attribs")] int* attribs
    ) => ThisThread.ReopenDeviceSOFT(device, deviceName, attribs);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcReopenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.ReopenDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("deviceName")] Ref<sbyte> deviceName,
        [NativeName("attribs")] Ref<int> attribs
    )
    {
        fixed (int* __dsl_attribs = attribs)
        fixed (sbyte* __dsl_deviceName = deviceName)
        {
            return (MaybeBool<sbyte>)
                (sbyte)((IAlContext)this).ReopenDeviceSOFT(device, __dsl_deviceName, __dsl_attribs);
        }
    }

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcReopenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> ReopenDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("deviceName")] Ref<sbyte> deviceName,
        [NativeName("attribs")] Ref<int> attribs
    ) => ThisThread.ReopenDeviceSOFT(device, deviceName, attribs);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcResetDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.ResetDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attribs")] int* attribs
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int*, sbyte>)(
                _slots[32] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[32] = nativeContext.LoadFunction("alcResetDeviceSOFT", "openal")
            )
        )(device, attribs);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcResetDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte ResetDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attribs")] int* attribs
    ) => ThisThread.ResetDeviceSOFT(device, attribs);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcResetDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.ResetDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attribs")] Ref<int> attribs
    )
    {
        fixed (int* __dsl_attribs = attribs)
        {
            return (MaybeBool<sbyte>)
                (sbyte)((IAlContext)this).ResetDeviceSOFT(device, __dsl_attribs);
        }
    }

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alcResetDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> ResetDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attribs")] Ref<int> attribs
    ) => ThisThread.ResetDeviceSOFT(device, attribs);

    [NativeName("alcSetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.SetThreadContext([NativeName("context")] ContextHandle context) =>
        (MaybeBool<sbyte>)(sbyte)((IAlContext)this).SetThreadContextRaw(context);

    [NativeName("alcSetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> SetThreadContext(
        [NativeName("context")] ContextHandle context
    ) => ThisThread.SetThreadContext(context);

    [NativeName("alcSetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.SetThreadContextRaw([NativeName("context")] ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, sbyte>)(
                _slots[33] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[33] = nativeContext.LoadFunction("alcSetThreadContext", "openal")
            )
        )(context);

    [NativeName("alcSetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte SetThreadContextRaw([NativeName("context")] ContextHandle context) =>
        ThisThread.SetThreadContextRaw(context);

    [NativeName("alcSuspendContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.SuspendContext([NativeName("context")] ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, void>)(
                _slots[34] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[34] = nativeContext.LoadFunction("alcSuspendContext", "openal")
            )
        )(context);

    [NativeName("alcSuspendContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SuspendContext([NativeName("context")] ContextHandle context) =>
        ThisThread.SuspendContext(context);
}
