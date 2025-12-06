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

public unsafe partial interface IALContext
{
    public partial interface Static
    {
        [NativeName("alcCaptureCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        static abstract MaybeBool<sbyte> CaptureCloseDevice(DeviceHandle device);

        [NativeName("alcCaptureCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        static abstract sbyte CaptureCloseDeviceRaw(DeviceHandle device);

        [NativeName("alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        static abstract DeviceHandle CaptureOpenDevice(
            sbyte* devicename,
            uint frequency,
            int format,
            int buffersize
        );

        [NativeName("alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        static abstract DeviceHandle CaptureOpenDevice(
            Ref<sbyte> devicename,
            uint frequency,
            Constant<int, ALEnum, Format> format,
            int buffersize
        );

        [NativeName("alcCaptureSamples")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        static abstract void CaptureSamples(DeviceHandle device, void* buffer, int samples);

        [NativeName("alcCaptureSamples")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        static abstract void CaptureSamples(DeviceHandle device, Ref buffer, int samples);

        [NativeName("alcCaptureStart")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        static abstract void CaptureStart(DeviceHandle device);

        [NativeName("alcCaptureStop")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        static abstract void CaptureStop(DeviceHandle device);

        [NativeName("alcCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        static abstract MaybeBool<sbyte> CloseDevice(DeviceHandle device);

        [NativeName("alcCloseDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        static abstract sbyte CloseDeviceRaw(DeviceHandle device);

        [NativeName("alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        static abstract ContextHandle CreateContext(DeviceHandle device, int* attrlist);

        [NativeName("alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        static abstract ContextHandle CreateContext(DeviceHandle device, Ref<int> attrlist);

        [NativeName("alcDestroyContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        static abstract void DestroyContext(ContextHandle context);

        [NativeName("alcDevicePauseSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
        static abstract void DevicePauseSOFT(DeviceHandle device);

        [NativeName("alcDeviceResumeSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
        static abstract void DeviceResumeSOFT(DeviceHandle device);

        [NativeName("alcEventCallbackSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        static abstract void EventCallbackSOFT(ContextEventProcSOFT callback, void* userParam);

        [NativeName("alcEventCallbackSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        static abstract void EventCallbackSOFT(ContextEventProcSOFT callback, Ref userParam);

        [NativeName("alcEventControlSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        static abstract sbyte EventControlSOFT(int count, int* events, sbyte enable);

        [NativeName("alcEventControlSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        static abstract MaybeBool<sbyte> EventControlSOFT(
            int count,
            Ref<int> events,
            MaybeBool<sbyte> enable
        );

        [NativeName("alcEventIsSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        static abstract int EventIsSupportedSOFT(int eventType, int deviceType);

        [NativeName("alcEventIsSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        static abstract Constant<int, ALCEnum, EventSupportSOFT> EventIsSupportedSOFT(
            Constant<int, ALCEnum, SystemEventTypeSOFT> eventType,
            Constant<int, ALCEnum, DeviceTypeSOFT> deviceType
        );

        [NativeName("alcGetContextsDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        static abstract DeviceHandle GetContextsDevice(ContextHandle context);

        [NativeName("alcGetCurrentContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        static abstract ContextHandle GetCurrentContext();

        [NativeName("alcGetEnumValue")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        static abstract int GetEnumValue(DeviceHandle device, sbyte* enumname);

        [NativeName("alcGetEnumValue")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        static abstract int GetEnumValue(DeviceHandle device, Ref<sbyte> enumname);

        [NativeName("alcGetError")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        static abstract Constant<int, ALCEnum, ContextErrorCode> GetError(DeviceHandle device);

        [NativeName("alcGetError")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        static abstract int GetErrorRaw(DeviceHandle device);

        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        static abstract void GetInteger64SOFT(
            DeviceHandle device,
            int pname,
            int size,
            nint* values
        );

        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        static abstract void GetInteger64SOFT(
            DeviceHandle device,
            int pname,
            int size,
            Ref<nint> values
        );

        [NativeName("alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        static abstract nint GetInteger64SOFT(DeviceHandle device, int pname);

        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        static abstract void GetInteger(DeviceHandle device, int param1, int size, int* values);

        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        static abstract void GetInteger(DeviceHandle device, int param1, int size, Ref<int> values);

        [NativeName("alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        static abstract int GetInteger(DeviceHandle device, int param1);

        [NativeName("alcGetProcAddress")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        static abstract void* GetProcAddress(DeviceHandle device, sbyte* funcname);

        [NativeName("alcGetProcAddress")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        static abstract Ptr GetProcAddress(DeviceHandle device, Ref<sbyte> funcname);

        [NativeName("alcGetProcAddress2")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        static abstract void* GetProcAddress2(DeviceHandle device, sbyte* funcName);

        [NativeName("alcGetProcAddress2")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        static abstract Ptr GetProcAddress2(DeviceHandle device, Ref<sbyte> funcName);

        [NativeName("alcGetString")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        static abstract sbyte* GetString(DeviceHandle device, int param1);

        [NativeName("alcGetString")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        static abstract Ptr<sbyte> GetString(
            DeviceHandle device,
            Constant<int, ALCEnum, ContextString> param1
        );

        [NativeName("alcGetStringiSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        static abstract sbyte* GetStringSOFT(DeviceHandle device, int paramName, int index);

        [NativeName("alcGetStringiSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        static abstract Ptr<sbyte> GetStringSOFT(
            DeviceHandle device,
            Constant<int, ALCEnum, ContextString> paramName,
            int index
        );

        [NativeName("alcGetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
        static abstract ContextHandle GetThreadContext();

        [NativeName("alcIsExtensionPresent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        static abstract sbyte IsExtensionPresent(DeviceHandle device, sbyte* extname);

        [NativeName("alcIsExtensionPresent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        static abstract MaybeBool<sbyte> IsExtensionPresent(
            DeviceHandle device,
            Ref<sbyte> extname
        );

        [NativeName("alcIsRenderFormatSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        static abstract sbyte IsRenderFormatSupportedSOFT(
            DeviceHandle device,
            int freq,
            int channels,
            int type
        );

        [NativeName("alcIsRenderFormatSupportedSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        static abstract MaybeBool<sbyte> IsRenderFormatSupportedSOFT(
            DeviceHandle device,
            int freq,
            Constant<int, ALCEnum, RenderFormatChannelSOFT> channels,
            Constant<int, ALCEnum, RenderFormatTypeSOFT> type
        );

        [NativeName("alcLoopbackOpenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        static abstract DeviceHandle LoopbackOpenDeviceSOFT(sbyte* deviceName);

        [NativeName("alcLoopbackOpenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        static abstract DeviceHandle LoopbackOpenDeviceSOFT(Ref<sbyte> deviceName);

        [NativeName("alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        static abstract MaybeBool<sbyte> MakeContextCurrent(ContextHandle context);

        [NativeName("alcMakeContextCurrent")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        static abstract sbyte MakeContextCurrentRaw(ContextHandle context);

        [NativeName("alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        static abstract DeviceHandle OpenDevice(sbyte* devicename);

        [NativeName("alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        static abstract DeviceHandle OpenDevice(Ref<sbyte> devicename);

        [NativeName("alcProcessContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        static abstract void ProcessContext(ContextHandle context);

        [NativeName("alcRenderSamplesSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        static abstract void RenderSamplesSOFT(DeviceHandle device, void* buffer, int samples);

        [NativeName("alcRenderSamplesSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        static abstract void RenderSamplesSOFT(DeviceHandle device, Ref buffer, int samples);

        [NativeName("alcReopenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        static abstract sbyte ReopenDeviceSOFT(
            DeviceHandle device,
            sbyte* deviceName,
            int* attribs
        );

        [NativeName("alcReopenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        static abstract MaybeBool<sbyte> ReopenDeviceSOFT(
            DeviceHandle device,
            Ref<sbyte> deviceName,
            Ref<int> attribs
        );

        [NativeName("alcResetDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        static abstract sbyte ResetDeviceSOFT(DeviceHandle device, int* attribs);

        [NativeName("alcResetDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        static abstract MaybeBool<sbyte> ResetDeviceSOFT(DeviceHandle device, Ref<int> attribs);

        [NativeName("alcSetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        static abstract MaybeBool<sbyte> SetThreadContext(ContextHandle context);

        [NativeName("alcSetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        static abstract sbyte SetThreadContextRaw(ContextHandle context);

        [NativeName("alcSuspendContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
        static abstract void SuspendContext(ContextHandle context);
    }

    [NativeName("alcCaptureCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    MaybeBool<sbyte> CaptureCloseDevice(DeviceHandle device);

    [NativeName("alcCaptureCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    sbyte CaptureCloseDeviceRaw(DeviceHandle device);

    [NativeName("alcCaptureOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    DeviceHandle CaptureOpenDevice(sbyte* devicename, uint frequency, int format, int buffersize);

    [NativeName("alcCaptureOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    DeviceHandle CaptureOpenDevice(
        Ref<sbyte> devicename,
        uint frequency,
        Constant<int, ALEnum, Format> format,
        int buffersize
    );

    [NativeName("alcCaptureSamples")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    void CaptureSamples(DeviceHandle device, void* buffer, int samples);

    [NativeName("alcCaptureSamples")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    void CaptureSamples(DeviceHandle device, Ref buffer, int samples);

    [NativeName("alcCaptureStart")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
    void CaptureStart(DeviceHandle device);

    [NativeName("alcCaptureStop")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
    void CaptureStop(DeviceHandle device);

    [NativeName("alcCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    MaybeBool<sbyte> CloseDevice(DeviceHandle device);

    [NativeName("alcCloseDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    sbyte CloseDeviceRaw(DeviceHandle device);

    [NativeName("alcCreateContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    ContextHandle CreateContext(DeviceHandle device, int* attrlist);

    [NativeName("alcCreateContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    ContextHandle CreateContext(DeviceHandle device, Ref<int> attrlist);

    [NativeName("alcDestroyContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
    void DestroyContext(ContextHandle context);

    [NativeName("alcDevicePauseSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
    void DevicePauseSOFT(DeviceHandle device);

    [NativeName("alcDeviceResumeSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
    void DeviceResumeSOFT(DeviceHandle device);

    [NativeName("alcEventCallbackSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    void EventCallbackSOFT(ContextEventProcSOFT callback, void* userParam);

    [NativeName("alcEventCallbackSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    void EventCallbackSOFT(ContextEventProcSOFT callback, Ref userParam);

    [NativeName("alcEventControlSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    sbyte EventControlSOFT(int count, int* events, sbyte enable);

    [NativeName("alcEventControlSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    MaybeBool<sbyte> EventControlSOFT(int count, Ref<int> events, MaybeBool<sbyte> enable);

    [NativeName("alcEventIsSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    int EventIsSupportedSOFT(int eventType, int deviceType);

    [NativeName("alcEventIsSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    Constant<int, ALCEnum, EventSupportSOFT> EventIsSupportedSOFT(
        Constant<int, ALCEnum, SystemEventTypeSOFT> eventType,
        Constant<int, ALCEnum, DeviceTypeSOFT> deviceType
    );

    [NativeName("alcGetContextsDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
    DeviceHandle GetContextsDevice(ContextHandle context);

    [NativeName("alcGetCurrentContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
    ContextHandle GetCurrentContext();

    [NativeName("alcGetEnumValue")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    int GetEnumValue(DeviceHandle device, sbyte* enumname);

    [NativeName("alcGetEnumValue")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    int GetEnumValue(DeviceHandle device, Ref<sbyte> enumname);

    [NativeName("alcGetError")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    Constant<int, ALCEnum, ContextErrorCode> GetError(DeviceHandle device);

    [NativeName("alcGetError")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    int GetErrorRaw(DeviceHandle device);

    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    void GetInteger64SOFT(DeviceHandle device, int pname, int size, nint* values);

    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    void GetInteger64SOFT(DeviceHandle device, int pname, int size, Ref<nint> values);

    [NativeName("alcGetInteger64vSOFT")]
    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    nint GetInteger64SOFT(DeviceHandle device, int pname);

    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    void GetInteger(DeviceHandle device, int param1, int size, int* values);

    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    void GetInteger(DeviceHandle device, int param1, int size, Ref<int> values);

    [NativeName("alcGetIntegerv")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    int GetInteger(DeviceHandle device, int param1);

    [NativeName("alcGetProcAddress")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    void* GetProcAddress(DeviceHandle device, sbyte* funcname);

    [NativeName("alcGetProcAddress")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    Ptr GetProcAddress(DeviceHandle device, Ref<sbyte> funcname);

    [NativeName("alcGetProcAddress2")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    void* GetProcAddress2(DeviceHandle device, sbyte* funcName);

    [NativeName("alcGetProcAddress2")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    Ptr GetProcAddress2(DeviceHandle device, Ref<sbyte> funcName);

    [NativeName("alcGetString")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    sbyte* GetString(DeviceHandle device, int param1);

    [NativeName("alcGetString")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    Ptr<sbyte> GetString(DeviceHandle device, Constant<int, ALCEnum, ContextString> param1);

    [NativeName("alcGetStringiSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    sbyte* GetStringSOFT(DeviceHandle device, int paramName, int index);

    [NativeName("alcGetStringiSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    Ptr<sbyte> GetStringSOFT(
        DeviceHandle device,
        Constant<int, ALCEnum, ContextString> paramName,
        int index
    );

    [NativeName("alcGetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
    ContextHandle GetThreadContext();

    [NativeName("alcIsExtensionPresent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    sbyte IsExtensionPresent(DeviceHandle device, sbyte* extname);

    [NativeName("alcIsExtensionPresent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    MaybeBool<sbyte> IsExtensionPresent(DeviceHandle device, Ref<sbyte> extname);

    [NativeName("alcIsRenderFormatSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    sbyte IsRenderFormatSupportedSOFT(DeviceHandle device, int freq, int channels, int type);

    [NativeName("alcIsRenderFormatSupportedSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    MaybeBool<sbyte> IsRenderFormatSupportedSOFT(
        DeviceHandle device,
        int freq,
        Constant<int, ALCEnum, RenderFormatChannelSOFT> channels,
        Constant<int, ALCEnum, RenderFormatTypeSOFT> type
    );

    [NativeName("alcLoopbackOpenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    DeviceHandle LoopbackOpenDeviceSOFT(sbyte* deviceName);

    [NativeName("alcLoopbackOpenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    DeviceHandle LoopbackOpenDeviceSOFT(Ref<sbyte> deviceName);

    [NativeName("alcMakeContextCurrent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    MaybeBool<sbyte> MakeContextCurrent(ContextHandle context);

    [NativeName("alcMakeContextCurrent")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    sbyte MakeContextCurrentRaw(ContextHandle context);

    [NativeName("alcOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    DeviceHandle OpenDevice(sbyte* devicename);

    [NativeName("alcOpenDevice")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    DeviceHandle OpenDevice(Ref<sbyte> devicename);

    [NativeName("alcProcessContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcProcessContext")]
    void ProcessContext(ContextHandle context);

    [NativeName("alcRenderSamplesSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    void RenderSamplesSOFT(DeviceHandle device, void* buffer, int samples);

    [NativeName("alcRenderSamplesSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    void RenderSamplesSOFT(DeviceHandle device, Ref buffer, int samples);

    [NativeName("alcReopenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    sbyte ReopenDeviceSOFT(DeviceHandle device, sbyte* deviceName, int* attribs);

    [NativeName("alcReopenDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    MaybeBool<sbyte> ReopenDeviceSOFT(DeviceHandle device, Ref<sbyte> deviceName, Ref<int> attribs);

    [NativeName("alcResetDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    sbyte ResetDeviceSOFT(DeviceHandle device, int* attribs);

    [NativeName("alcResetDeviceSOFT")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    MaybeBool<sbyte> ResetDeviceSOFT(DeviceHandle device, Ref<int> attribs);

    [NativeName("alcSetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    MaybeBool<sbyte> SetThreadContext(ContextHandle context);

    [NativeName("alcSetThreadContext")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    sbyte SetThreadContextRaw(ContextHandle context);

    [NativeName("alcSuspendContext")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
    void SuspendContext(ContextHandle context);
}
