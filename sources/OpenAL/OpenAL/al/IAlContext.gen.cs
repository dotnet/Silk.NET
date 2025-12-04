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

public unsafe partial interface IAlContext
{
    public partial interface Static
    {
        [NativeName("alcCaptureCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        static abstract MaybeBool<sbyte> CaptureCloseDevice(
            [NativeName("device")] DeviceHandle device
        );

        [NativeName("alcCaptureCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        static abstract sbyte CaptureCloseDeviceRaw([NativeName("device")] DeviceHandle device);

        [NativeName("alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        static abstract DeviceHandle CaptureOpenDevice(
            [NativeName("devicename")] sbyte* devicename,
            [NativeName("frequency")] uint frequency,
            [NativeName("format")] int format,
            [NativeName("buffersize")] int buffersize
        );

        [NativeName("alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        static abstract DeviceHandle CaptureOpenDevice(
            [NativeName("devicename")] Ref<sbyte> devicename,
            [NativeName("frequency")] uint frequency,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("buffersize")] int buffersize
        );

        [NativeName("alcCaptureSamples")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        static abstract void CaptureSamples(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] void* buffer,
            [NativeName("samples")] int samples
        );

        [NativeName("alcCaptureSamples")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        static abstract void CaptureSamples(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] Ref buffer,
            [NativeName("samples")] int samples
        );

        [NativeName("alcCaptureStart")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        static abstract void CaptureStart([NativeName("device")] DeviceHandle device);

        [NativeName("alcCaptureStop")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        static abstract void CaptureStop([NativeName("device")] DeviceHandle device);

        [NativeName("alcCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        static abstract MaybeBool<sbyte> CloseDevice([NativeName("device")] DeviceHandle device);

        [NativeName("alcCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        static abstract sbyte CloseDeviceRaw([NativeName("device")] DeviceHandle device);

        [NativeName("alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        static abstract ContextHandle CreateContext(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attrlist")] int* attrlist
        );

        [NativeName("alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        static abstract ContextHandle CreateContext(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attrlist")] Ref<int> attrlist
        );

        [NativeName("alcDestroyContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        static abstract void DestroyContext([NativeName("context")] ContextHandle context);

        [NativeName("alcDevicePauseSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
        static abstract void DevicePauseSOFT([NativeName("device")] DeviceHandle device);

        [NativeName("alcDeviceResumeSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
        static abstract void DeviceResumeSOFT([NativeName("device")] DeviceHandle device);

        [NativeName("alcEventCallbackSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        static abstract void EventCallbackSOFT(
            [NativeName("callback")] ContextEventProcSoft callback,
            [NativeName("userParam")] void* userParam
        );

        [NativeName("alcEventCallbackSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        static abstract void EventCallbackSOFT(
            [NativeName("callback")] ContextEventProcSoft callback,
            [NativeName("userParam")] Ref userParam
        );

        [NativeName("alcEventControlSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        static abstract sbyte EventControlSOFT(
            [NativeName("count")] int count,
            [NativeName("events")] int* events,
            [NativeName("enable")] sbyte enable
        );

        [NativeName("alcEventControlSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        static abstract MaybeBool<sbyte> EventControlSOFT(
            [NativeName("count")] int count,
            [NativeName("events")] Ref<int> events,
            [NativeName("enable")] MaybeBool<sbyte> enable
        );

        [NativeName("alcEventIsSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        static abstract int EventIsSupportedSOFT(
            [NativeName("eventType")] int eventType,
            [NativeName("deviceType")] int deviceType
        );

        [NativeName("alcEventIsSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        static abstract Constant<int, AlcEnum, EventSupportSOFT> EventIsSupportedSOFT(
            [NativeName("eventType")] Constant<int, EventTypeSOFT> eventType,
            [NativeName("deviceType")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
        );

        [NativeName("alcGetContextsDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        static abstract DeviceHandle GetContextsDevice(
            [NativeName("context")] ContextHandle context
        );

        [NativeName("alcGetCurrentContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        static abstract ContextHandle GetCurrentContext();

        [NativeName("alcGetEnumValue")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        static abstract int GetEnumValue(
            [NativeName("device")] DeviceHandle device,
            [NativeName("enumname")] sbyte* enumname
        );

        [NativeName("alcGetEnumValue")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        static abstract int GetEnumValue(
            [NativeName("device")] DeviceHandle device,
            [NativeName("enumname")] Ref<sbyte> enumname
        );

        [NativeName("alcGetError")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        static abstract Constant<int, ErrorCode> GetError(
            [NativeName("device")] DeviceHandle device
        );

        [NativeName("alcGetError")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        static abstract int GetErrorRaw([NativeName("device")] DeviceHandle device);

        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        static abstract void GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname,
            [NativeName("size")] int size,
            [NativeName("values")] nint* values
        );

        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        static abstract void GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname,
            [NativeName("size")] int size,
            [NativeName("values")] Ref<nint> values
        );

        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        static abstract nint GetInteger64SOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("pname")] int pname
        );

        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        static abstract void GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1,
            [NativeName("size")] int size,
            [NativeName("values")] int* values
        );

        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        static abstract void GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1,
            [NativeName("size")] int size,
            [NativeName("values")] Ref<int> values
        );

        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        static abstract int GetInteger(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1
        );

        [NativeName("alcGetProcAddress")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        static abstract void* GetProcAddress(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcname")] sbyte* funcname
        );

        [NativeName("alcGetProcAddress")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        static abstract Ptr GetProcAddress(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcname")] Ref<sbyte> funcname
        );

        [NativeName("alcGetProcAddress2")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        static abstract void* GetProcAddress2(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcName")] sbyte* funcName
        );

        [NativeName("alcGetProcAddress2")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        static abstract Ptr GetProcAddress2(
            [NativeName("device")] DeviceHandle device,
            [NativeName("funcName")] Ref<sbyte> funcName
        );

        [NativeName("alcGetString")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        static abstract sbyte* GetString(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] int param1
        );

        [NativeName("alcGetString")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        static abstract Ptr<sbyte> GetString(
            [NativeName("device")] DeviceHandle device,
            [NativeName("param1")] Constant<int, AlcEnum, ContextString> param1
        );

        [NativeName("alcGetStringiSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        static abstract sbyte* GetStringSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("paramName")] int paramName,
            [NativeName("index")] int index
        );

        [NativeName("alcGetStringiSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        static abstract Ptr<sbyte> GetStringSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("paramName")] Constant<int, AlcEnum, ContextString> paramName,
            [NativeName("index")] int index
        );

        [NativeName("alcGetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
        static abstract ContextHandle GetThreadContext();

        [NativeName("alcIsExtensionPresent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        static abstract sbyte IsExtensionPresent(
            [NativeName("device")] DeviceHandle device,
            [NativeName("extname")] sbyte* extname
        );

        [NativeName("alcIsExtensionPresent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        static abstract MaybeBool<sbyte> IsExtensionPresent(
            [NativeName("device")] DeviceHandle device,
            [NativeName("extname")] Ref<sbyte> extname
        );

        [NativeName("alcIsRenderFormatSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        static abstract sbyte IsRenderFormatSupportedSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("freq")] int freq,
            [NativeName("channels")] int channels,
            [NativeName("type")] int type
        );

        [NativeName("alcIsRenderFormatSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        static abstract MaybeBool<sbyte> IsRenderFormatSupportedSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("freq")] int freq,
            [NativeName("channels")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
            [NativeName("type")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
        );

        [NativeName("alcLoopbackOpenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        static abstract DeviceHandle LoopbackOpenDeviceSOFT(
            [NativeName("deviceName")] sbyte* deviceName
        );

        [NativeName("alcLoopbackOpenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        static abstract DeviceHandle LoopbackOpenDeviceSOFT(
            [NativeName("deviceName")] Ref<sbyte> deviceName
        );

        [NativeName("alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        static abstract MaybeBool<sbyte> MakeContextCurrent(
            [NativeName("context")] ContextHandle context
        );

        [NativeName("alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        static abstract sbyte MakeContextCurrentRaw([NativeName("context")] ContextHandle context);

        [NativeName("alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        static abstract DeviceHandle OpenDevice([NativeName("devicename")] sbyte* devicename);

        [NativeName("alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        static abstract DeviceHandle OpenDevice([NativeName("devicename")] Ref<sbyte> devicename);

        [NativeName("alcProcessContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        static abstract void ProcessContext([NativeName("context")] ContextHandle context);

        [NativeName("alcRenderSamplesSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        static abstract void RenderSamplesSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] void* buffer,
            [NativeName("samples")] int samples
        );

        [NativeName("alcRenderSamplesSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        static abstract void RenderSamplesSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("buffer")] Ref buffer,
            [NativeName("samples")] int samples
        );

        [NativeName("alcReopenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        static abstract sbyte ReopenDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("deviceName")] sbyte* deviceName,
            [NativeName("attribs")] int* attribs
        );

        [NativeName("alcReopenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        static abstract MaybeBool<sbyte> ReopenDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("deviceName")] Ref<sbyte> deviceName,
            [NativeName("attribs")] Ref<int> attribs
        );

        [NativeName("alcResetDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        static abstract sbyte ResetDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attribs")] int* attribs
        );

        [NativeName("alcResetDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        static abstract MaybeBool<sbyte> ResetDeviceSOFT(
            [NativeName("device")] DeviceHandle device,
            [NativeName("attribs")] Ref<int> attribs
        );

        [NativeName("alcSetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        static abstract MaybeBool<sbyte> SetThreadContext(
            [NativeName("context")] ContextHandle context
        );

        [NativeName("alcSetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        static abstract sbyte SetThreadContextRaw([NativeName("context")] ContextHandle context);

        [NativeName("alcSuspendContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
        static abstract void SuspendContext([NativeName("context")] ContextHandle context);
    }

    [NativeName("alcCaptureCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    MaybeBool<sbyte> CaptureCloseDevice([NativeName("device")] DeviceHandle device);

    [NativeName("alcCaptureCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    sbyte CaptureCloseDeviceRaw([NativeName("device")] DeviceHandle device);

    [NativeName("alcCaptureOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    DeviceHandle CaptureOpenDevice(
        [NativeName("devicename")] sbyte* devicename,
        [NativeName("frequency")] uint frequency,
        [NativeName("format")] int format,
        [NativeName("buffersize")] int buffersize
    );

    [NativeName("alcCaptureOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    DeviceHandle CaptureOpenDevice(
        [NativeName("devicename")] Ref<sbyte> devicename,
        [NativeName("frequency")] uint frequency,
        [NativeName("format")] Constant<int, AlEnum, Format> format,
        [NativeName("buffersize")] int buffersize
    );

    [NativeName("alcCaptureSamples")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    void CaptureSamples(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] void* buffer,
        [NativeName("samples")] int samples
    );

    [NativeName("alcCaptureSamples")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    void CaptureSamples(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] Ref buffer,
        [NativeName("samples")] int samples
    );

    [NativeName("alcCaptureStart")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
    void CaptureStart([NativeName("device")] DeviceHandle device);

    [NativeName("alcCaptureStop")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
    void CaptureStop([NativeName("device")] DeviceHandle device);

    [NativeName("alcCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    MaybeBool<sbyte> CloseDevice([NativeName("device")] DeviceHandle device);

    [NativeName("alcCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    sbyte CloseDeviceRaw([NativeName("device")] DeviceHandle device);

    [NativeName("alcCreateContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    ContextHandle CreateContext(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attrlist")] int* attrlist
    );

    [NativeName("alcCreateContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    ContextHandle CreateContext(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attrlist")] Ref<int> attrlist
    );

    [NativeName("alcDestroyContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
    void DestroyContext([NativeName("context")] ContextHandle context);

    [NativeName("alcDevicePauseSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
    void DevicePauseSOFT([NativeName("device")] DeviceHandle device);

    [NativeName("alcDeviceResumeSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
    void DeviceResumeSOFT([NativeName("device")] DeviceHandle device);

    [NativeName("alcEventCallbackSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    void EventCallbackSOFT(
        [NativeName("callback")] ContextEventProcSoft callback,
        [NativeName("userParam")] void* userParam
    );

    [NativeName("alcEventCallbackSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    void EventCallbackSOFT(
        [NativeName("callback")] ContextEventProcSoft callback,
        [NativeName("userParam")] Ref userParam
    );

    [NativeName("alcEventControlSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    sbyte EventControlSOFT(
        [NativeName("count")] int count,
        [NativeName("events")] int* events,
        [NativeName("enable")] sbyte enable
    );

    [NativeName("alcEventControlSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    MaybeBool<sbyte> EventControlSOFT(
        [NativeName("count")] int count,
        [NativeName("events")] Ref<int> events,
        [NativeName("enable")] MaybeBool<sbyte> enable
    );

    [NativeName("alcEventIsSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    int EventIsSupportedSOFT(
        [NativeName("eventType")] int eventType,
        [NativeName("deviceType")] int deviceType
    );

    [NativeName("alcEventIsSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    Constant<int, AlcEnum, EventSupportSOFT> EventIsSupportedSOFT(
        [NativeName("eventType")] Constant<int, EventTypeSOFT> eventType,
        [NativeName("deviceType")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
    );

    [NativeName("alcGetContextsDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
    DeviceHandle GetContextsDevice([NativeName("context")] ContextHandle context);

    [NativeName("alcGetCurrentContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
    ContextHandle GetCurrentContext();

    [NativeName("alcGetEnumValue")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    int GetEnumValue(
        [NativeName("device")] DeviceHandle device,
        [NativeName("enumname")] sbyte* enumname
    );

    [NativeName("alcGetEnumValue")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    int GetEnumValue(
        [NativeName("device")] DeviceHandle device,
        [NativeName("enumname")] Ref<sbyte> enumname
    );

    [NativeName("alcGetError")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    Constant<int, ErrorCode> GetError([NativeName("device")] DeviceHandle device);

    [NativeName("alcGetError")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    int GetErrorRaw([NativeName("device")] DeviceHandle device);

    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    void GetInteger64SOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("pname")] int pname,
        [NativeName("size")] int size,
        [NativeName("values")] nint* values
    );

    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    void GetInteger64SOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("pname")] int pname,
        [NativeName("size")] int size,
        [NativeName("values")] Ref<nint> values
    );

    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    nint GetInteger64SOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("pname")] int pname
    );

    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    void GetInteger(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] int param1,
        [NativeName("size")] int size,
        [NativeName("values")] int* values
    );

    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    void GetInteger(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] int param1,
        [NativeName("size")] int size,
        [NativeName("values")] Ref<int> values
    );

    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    int GetInteger([NativeName("device")] DeviceHandle device, [NativeName("param1")] int param1);

    [NativeName("alcGetProcAddress")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    void* GetProcAddress(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcname")] sbyte* funcname
    );

    [NativeName("alcGetProcAddress")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    Ptr GetProcAddress(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcname")] Ref<sbyte> funcname
    );

    [NativeName("alcGetProcAddress2")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    void* GetProcAddress2(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcName")] sbyte* funcName
    );

    [NativeName("alcGetProcAddress2")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    Ptr GetProcAddress2(
        [NativeName("device")] DeviceHandle device,
        [NativeName("funcName")] Ref<sbyte> funcName
    );

    [NativeName("alcGetString")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    sbyte* GetString([NativeName("device")] DeviceHandle device, [NativeName("param1")] int param1);

    [NativeName("alcGetString")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    Ptr<sbyte> GetString(
        [NativeName("device")] DeviceHandle device,
        [NativeName("param1")] Constant<int, AlcEnum, ContextString> param1
    );

    [NativeName("alcGetStringiSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    sbyte* GetStringSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("paramName")] int paramName,
        [NativeName("index")] int index
    );

    [NativeName("alcGetStringiSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    Ptr<sbyte> GetStringSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("paramName")] Constant<int, AlcEnum, ContextString> paramName,
        [NativeName("index")] int index
    );

    [NativeName("alcGetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
    ContextHandle GetThreadContext();

    [NativeName("alcIsExtensionPresent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    sbyte IsExtensionPresent(
        [NativeName("device")] DeviceHandle device,
        [NativeName("extname")] sbyte* extname
    );

    [NativeName("alcIsExtensionPresent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    MaybeBool<sbyte> IsExtensionPresent(
        [NativeName("device")] DeviceHandle device,
        [NativeName("extname")] Ref<sbyte> extname
    );

    [NativeName("alcIsRenderFormatSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    sbyte IsRenderFormatSupportedSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("freq")] int freq,
        [NativeName("channels")] int channels,
        [NativeName("type")] int type
    );

    [NativeName("alcIsRenderFormatSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    MaybeBool<sbyte> IsRenderFormatSupportedSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("freq")] int freq,
        [NativeName("channels")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
        [NativeName("type")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
    );

    [NativeName("alcLoopbackOpenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    DeviceHandle LoopbackOpenDeviceSOFT([NativeName("deviceName")] sbyte* deviceName);

    [NativeName("alcLoopbackOpenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    DeviceHandle LoopbackOpenDeviceSOFT([NativeName("deviceName")] Ref<sbyte> deviceName);

    [NativeName("alcMakeContextCurrent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    MaybeBool<sbyte> MakeContextCurrent([NativeName("context")] ContextHandle context);

    [NativeName("alcMakeContextCurrent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    sbyte MakeContextCurrentRaw([NativeName("context")] ContextHandle context);

    [NativeName("alcOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    DeviceHandle OpenDevice([NativeName("devicename")] sbyte* devicename);

    [NativeName("alcOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    DeviceHandle OpenDevice([NativeName("devicename")] Ref<sbyte> devicename);

    [NativeName("alcProcessContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcProcessContext")]
    void ProcessContext([NativeName("context")] ContextHandle context);

    [NativeName("alcRenderSamplesSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    void RenderSamplesSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] void* buffer,
        [NativeName("samples")] int samples
    );

    [NativeName("alcRenderSamplesSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    void RenderSamplesSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("buffer")] Ref buffer,
        [NativeName("samples")] int samples
    );

    [NativeName("alcReopenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    sbyte ReopenDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("deviceName")] sbyte* deviceName,
        [NativeName("attribs")] int* attribs
    );

    [NativeName("alcReopenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    MaybeBool<sbyte> ReopenDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("deviceName")] Ref<sbyte> deviceName,
        [NativeName("attribs")] Ref<int> attribs
    );

    [NativeName("alcResetDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    sbyte ResetDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attribs")] int* attribs
    );

    [NativeName("alcResetDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    MaybeBool<sbyte> ResetDeviceSOFT(
        [NativeName("device")] DeviceHandle device,
        [NativeName("attribs")] Ref<int> attribs
    );

    [NativeName("alcSetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    MaybeBool<sbyte> SetThreadContext([NativeName("context")] ContextHandle context);

    [NativeName("alcSetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    sbyte SetThreadContextRaw([NativeName("context")] ContextHandle context);

    [NativeName("alcSuspendContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
    void SuspendContext([NativeName("context")] ContextHandle context);
}
