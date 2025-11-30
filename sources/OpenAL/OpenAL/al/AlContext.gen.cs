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
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        public static MaybeBool<sbyte> CaptureCloseDevice(DeviceHandle device) =>
            (MaybeBool<sbyte>)(sbyte)CaptureCloseDeviceRaw(device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureCloseDevice")]
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        public static extern sbyte CaptureCloseDeviceRaw(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        public static extern DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] int format,
            [NativeTypeName("ALCsizei")] int buffersize
        );

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] Constant<int, AlEnum, Format> format,
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
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        public static extern void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        );

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
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
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        public static extern void CaptureStart(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCaptureStop")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        public static extern void CaptureStop(DeviceHandle device);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        public static MaybeBool<sbyte> CloseDevice(DeviceHandle device) =>
            (MaybeBool<sbyte>)(sbyte)CloseDeviceRaw(device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCloseDevice")]
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte CloseDeviceRaw(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcCreateContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attrlist
        );

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void DestroyContext(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcDevicePauseSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        public static extern void DevicePauseSoft(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcDeviceResumeSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        public static extern void DeviceResumeSoft(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcEventCallbackSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        public static extern void EventCallbackSoft(
            [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSoft callback,
            void* userParam
        );

        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void EventCallbackSoft(
            [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSoft callback,
            Ref userParam
        )
        {
            fixed (void* __dsl_userParam = userParam)
            {
                EventCallbackSoft(callback, __dsl_userParam);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcEventControlSOFT")]
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        public static extern sbyte EventControlSoft(
            [NativeTypeName("ALCsizei")] int count,
            [NativeTypeName("const ALCenum *")] int* events,
            [NativeTypeName("ALCboolean")] sbyte enable
        );

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> EventControlSoft(
            [NativeTypeName("ALCsizei")] int count,
            [NativeTypeName("const ALCenum *")] Ref<int> events,
            [NativeTypeName("ALCboolean")] MaybeBool<sbyte> enable
        )
        {
            fixed (int* __dsl_events = events)
            {
                return (MaybeBool<sbyte>)
                    (sbyte)EventControlSoft(count, __dsl_events, (sbyte)enable);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcEventIsSupportedSOFT")]
        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        public static extern int EventIsSupportedSoft(
            [NativeTypeName("ALCenum")] int eventType,
            [NativeTypeName("ALCenum")] int deviceType
        );

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        public static Constant<int, AlcEnum, EventSupportSOFT> EventIsSupportedSoft(
            [NativeTypeName("ALCenum")] Constant<int, EventTypeSOFT> eventType,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
        ) =>
            (Constant<int, AlcEnum, EventSupportSOFT>)
                (int)EventIsSupportedSoft((int)eventType, (int)deviceType);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetContextsDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern DeviceHandle GetContextsDevice(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetCurrentContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern ContextHandle GetCurrentContext();

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetEnumValue")]
        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* enumname
        );

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        public static Constant<int, ErrorCode> GetError(DeviceHandle device) =>
            (Constant<int, ErrorCode>)(int)GetErrorRaw(device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetError")]
        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern int GetErrorRaw(DeviceHandle device);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetInteger64vSOFT")]
        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        public static extern void GetInteger64Soft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int pname,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALCint64SOFT *")] nint* values
        );

        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger64Soft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int pname,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALCint64SOFT *")] Ref<nint> values
        )
        {
            fixed (nint* __dsl_values = values)
            {
                GetInteger64Soft(device, pname, size, __dsl_values);
            }
        }

        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        public static nint GetInteger64Soft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int pname
        )
        {
            nint values = default;
            GetInteger64Soft(device, pname, 1, (nint*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetIntegerv")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetInteger(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] int* values
        );

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void* GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcname
        );

        [return: NativeTypeName("ALCvoid *")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetProcAddress2")]
        [return: NativeTypeName("ALCvoid *")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        public static extern void* GetProcAddress2(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcName
        );

        [return: NativeTypeName("ALCvoid *")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetProcAddress2(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> funcName
        )
        {
            fixed (sbyte* __dsl_funcName = funcName)
            {
                return (void*)GetProcAddress2(device, __dsl_funcName);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetString")]
        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte* GetString(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1
        );

        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetString(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, ContextString> param1
        ) => (sbyte*)GetString(device, (int)param1);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetStringiSOFT")]
        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        public static extern sbyte* GetStringSoft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int paramName,
            [NativeTypeName("ALCsizei")] int index
        );

        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetStringSoft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, ContextString> paramName,
            [NativeTypeName("ALCsizei")] int index
        ) => (sbyte*)GetStringSoft(device, (int)paramName, index);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcGetThreadContext")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        public static extern ContextHandle GetThreadContext();

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcIsExtensionPresent")]
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* extname
        );

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
        )
        {
            fixed (sbyte* __dsl_extname = extname)
            {
                return (MaybeBool<sbyte>)(sbyte)IsExtensionPresent(device, __dsl_extname);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        public static extern sbyte IsRenderFormatSupportedSoft(
            DeviceHandle device,
            [NativeTypeName("ALCsizei")] int freq,
            [NativeTypeName("ALCenum")] int channels,
            [NativeTypeName("ALCenum")] int type
        );

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        public static MaybeBool<sbyte> IsRenderFormatSupportedSoft(
            DeviceHandle device,
            [NativeTypeName("ALCsizei")] int freq,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
        ) =>
            (MaybeBool<sbyte>)
                (sbyte)IsRenderFormatSupportedSoft(device, freq, (int)channels, (int)type);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        public static extern DeviceHandle LoopbackOpenDeviceSoft(
            [NativeTypeName("const ALCchar *")] sbyte* deviceName
        );

        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle LoopbackOpenDeviceSoft(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName
        )
        {
            fixed (sbyte* __dsl_deviceName = deviceName)
            {
                return (DeviceHandle)LoopbackOpenDeviceSoft(__dsl_deviceName);
            }
        }

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        public static MaybeBool<sbyte> MakeContextCurrent(ContextHandle context) =>
            (MaybeBool<sbyte>)(sbyte)MakeContextCurrentRaw(context);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        private static MaybeBool<sbyte> MakeContextCurrentInternal(ContextHandle context) =>
            (MaybeBool<sbyte>)(sbyte)MakeContextCurrentInternalRaw(context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcMakeContextCurrent")]
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        private static extern sbyte MakeContextCurrentInternalRaw(ContextHandle context);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        public static partial sbyte MakeContextCurrentRaw(ContextHandle context);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        public static partial DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename
        );

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcOpenDevice")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        private static extern DeviceHandle OpenDeviceInternal(
            [NativeTypeName("const ALCchar *")] sbyte* devicename
        );

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        private static DeviceHandle OpenDeviceInternal(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename
        )
        {
            fixed (sbyte* __dsl_devicename = devicename)
            {
                return (DeviceHandle)OpenDeviceInternal(__dsl_devicename);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcProcessContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void ProcessContext(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcRenderSamplesSOFT")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        public static extern void RenderSamplesSoft(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        );

        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void RenderSamplesSoft(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] Ref buffer,
            [NativeTypeName("ALCsizei")] int samples
        )
        {
            fixed (void* __dsl_buffer = buffer)
            {
                RenderSamplesSoft(device, __dsl_buffer, samples);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcReopenDeviceSOFT")]
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        public static extern sbyte ReopenDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* deviceName,
            [NativeTypeName("const ALCint *")] int* attribs
        );

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> ReopenDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName,
            [NativeTypeName("const ALCint *")] Ref<int> attribs
        )
        {
            fixed (int* __dsl_attribs = attribs)
            fixed (sbyte* __dsl_deviceName = deviceName)
            {
                return (MaybeBool<sbyte>)
                    (sbyte)ReopenDeviceSoft(device, __dsl_deviceName, __dsl_attribs);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcResetDeviceSOFT")]
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        public static extern sbyte ResetDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attribs
        );

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> ResetDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] Ref<int> attribs
        )
        {
            fixed (int* __dsl_attribs = attribs)
            {
                return (MaybeBool<sbyte>)(sbyte)ResetDeviceSoft(device, __dsl_attribs);
            }
        }

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        public static MaybeBool<sbyte> SetThreadContext(ContextHandle context) =>
            (MaybeBool<sbyte>)(sbyte)SetThreadContextRaw(context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcSetThreadContext")]
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        public static extern sbyte SetThreadContextRaw(ContextHandle context);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alcSuspendContext")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SuspendContext(ContextHandle context);
    }

    public partial class StaticWrapper<T> : IAlContext
        where T : IAlContext.Static
    {
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> CaptureCloseDevice(DeviceHandle device) =>
            T.CaptureCloseDevice(device);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte CaptureCloseDeviceRaw(DeviceHandle device) => T.CaptureCloseDeviceRaw(device);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] Constant<int, AlEnum, Format> format,
            [NativeTypeName("ALCsizei")] int buffersize
        ) => T.CaptureOpenDevice(devicename, frequency, format, buffersize);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        ) => T.CaptureSamples(device, buffer, samples);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureStart(DeviceHandle device) => T.CaptureStart(device);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void CaptureStop(DeviceHandle device) => T.CaptureStop(device);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> CloseDevice(DeviceHandle device) => T.CloseDevice(device);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte CloseDeviceRaw(DeviceHandle device) => T.CloseDeviceRaw(device);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attrlist
        ) => T.CreateContext(device, attrlist);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] Ref<int> attrlist
        ) => T.CreateContext(device, attrlist);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DestroyContext(ContextHandle context) => T.DestroyContext(context);

        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DevicePauseSoft(DeviceHandle device) => T.DevicePauseSoft(device);

        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeviceResumeSoft(DeviceHandle device) => T.DeviceResumeSoft(device);

        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void EventCallbackSoft(
            [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSoft callback,
            void* userParam
        ) => T.EventCallbackSoft(callback, userParam);

        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void EventCallbackSoft(
            [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSoft callback,
            Ref userParam
        ) => T.EventCallbackSoft(callback, userParam);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte EventControlSoft(
            [NativeTypeName("ALCsizei")] int count,
            [NativeTypeName("const ALCenum *")] int* events,
            [NativeTypeName("ALCboolean")] sbyte enable
        ) => T.EventControlSoft(count, events, enable);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> EventControlSoft(
            [NativeTypeName("ALCsizei")] int count,
            [NativeTypeName("const ALCenum *")] Ref<int> events,
            [NativeTypeName("ALCboolean")] MaybeBool<sbyte> enable
        ) => T.EventControlSoft(count, events, enable);

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int EventIsSupportedSoft(
            [NativeTypeName("ALCenum")] int eventType,
            [NativeTypeName("ALCenum")] int deviceType
        ) => T.EventIsSupportedSoft(eventType, deviceType);

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Constant<int, AlcEnum, EventSupportSOFT> EventIsSupportedSoft(
            [NativeTypeName("ALCenum")] Constant<int, EventTypeSOFT> eventType,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
        ) => T.EventIsSupportedSoft(eventType, deviceType);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle GetContextsDevice(ContextHandle context) =>
            T.GetContextsDevice(context);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle GetCurrentContext() => T.GetCurrentContext();

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* enumname
        ) => T.GetEnumValue(device, enumname);

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Constant<int, ErrorCode> GetError(DeviceHandle device) => T.GetError(device);

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetErrorRaw(DeviceHandle device) => T.GetErrorRaw(device);

        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetInteger64Soft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int pname,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALCint64SOFT *")] nint* values
        ) => T.GetInteger64Soft(device, pname, size, values);

        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetInteger64Soft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int pname,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALCint64SOFT *")] Ref<nint> values
        ) => T.GetInteger64Soft(device, pname, size, values);

        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public nint GetInteger64Soft(DeviceHandle device, [NativeTypeName("ALCenum")] int pname) =>
            T.GetInteger64Soft(device, pname);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetInteger(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
            T.GetInteger(device, param1);

        [return: NativeTypeName("ALCvoid *")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void* GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcname
        ) => T.GetProcAddress(device, funcname);

        [return: NativeTypeName("ALCvoid *")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
        ) => T.GetProcAddress(device, funcname);

        [return: NativeTypeName("ALCvoid *")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void* GetProcAddress2(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcName
        ) => T.GetProcAddress2(device, funcName);

        [return: NativeTypeName("ALCvoid *")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr GetProcAddress2(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> funcName
        ) => T.GetProcAddress2(device, funcName);

        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte* GetString(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
            T.GetString(device, param1);

        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<sbyte> GetString(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, ContextString> param1
        ) => T.GetString(device, param1);

        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte* GetStringSoft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int paramName,
            [NativeTypeName("ALCsizei")] int index
        ) => T.GetStringSoft(device, paramName, index);

        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<sbyte> GetStringSoft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, ContextString> paramName,
            [NativeTypeName("ALCsizei")] int index
        ) => T.GetStringSoft(device, paramName, index);

        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ContextHandle GetThreadContext() => T.GetThreadContext();

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* extname
        ) => T.IsExtensionPresent(device, extname);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
        ) => T.IsExtensionPresent(device, extname);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsRenderFormatSupportedSoft(
            DeviceHandle device,
            [NativeTypeName("ALCsizei")] int freq,
            [NativeTypeName("ALCenum")] int channels,
            [NativeTypeName("ALCenum")] int type
        ) => T.IsRenderFormatSupportedSoft(device, freq, channels, type);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsRenderFormatSupportedSoft(
            DeviceHandle device,
            [NativeTypeName("ALCsizei")] int freq,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
        ) => T.IsRenderFormatSupportedSoft(device, freq, channels, type);

        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle LoopbackOpenDeviceSoft(
            [NativeTypeName("const ALCchar *")] sbyte* deviceName
        ) => T.LoopbackOpenDeviceSoft(deviceName);

        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle LoopbackOpenDeviceSoft(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName
        ) => T.LoopbackOpenDeviceSoft(deviceName);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> MakeContextCurrent(ContextHandle context) =>
            T.MakeContextCurrent(context);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte MakeContextCurrentRaw(ContextHandle context) =>
            T.MakeContextCurrentRaw(context);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] sbyte* devicename) =>
            T.OpenDevice(devicename);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] Ref<sbyte> devicename) =>
            T.OpenDevice(devicename);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void ProcessContext(ContextHandle context) => T.ProcessContext(context);

        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void RenderSamplesSoft(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        ) => T.RenderSamplesSoft(device, buffer, samples);

        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void RenderSamplesSoft(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] Ref buffer,
            [NativeTypeName("ALCsizei")] int samples
        ) => T.RenderSamplesSoft(device, buffer, samples);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte ReopenDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* deviceName,
            [NativeTypeName("const ALCint *")] int* attribs
        ) => T.ReopenDeviceSoft(device, deviceName, attribs);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> ReopenDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName,
            [NativeTypeName("const ALCint *")] Ref<int> attribs
        ) => T.ReopenDeviceSoft(device, deviceName, attribs);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte ResetDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attribs
        ) => T.ResetDeviceSoft(device, attribs);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> ResetDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] Ref<int> attribs
        ) => T.ResetDeviceSoft(device, attribs);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> SetThreadContext(ContextHandle context) =>
            T.SetThreadContext(context);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte SetThreadContextRaw(ContextHandle context) => T.SetThreadContextRaw(context);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SuspendContext(ContextHandle context) => T.SuspendContext(context);
    }

    public partial class ThisThread
    {
        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> CaptureCloseDevice(DeviceHandle device) =>
            Underlying.Value!.CaptureCloseDevice(device);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte CaptureCloseDeviceRaw(DeviceHandle device) =>
            Underlying.Value!.CaptureCloseDeviceRaw(device);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] Constant<int, AlEnum, Format> format,
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        ) => Underlying.Value!.CaptureSamples(device, buffer, samples);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureStart(DeviceHandle device) =>
            Underlying.Value!.CaptureStart(device);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void CaptureStop(DeviceHandle device) =>
            Underlying.Value!.CaptureStop(device);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> CloseDevice(DeviceHandle device) =>
            Underlying.Value!.CloseDevice(device);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte CloseDeviceRaw(DeviceHandle device) =>
            Underlying.Value!.CloseDeviceRaw(device);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attrlist
        ) => Underlying.Value!.CreateContext(device, attrlist);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DestroyContext(ContextHandle context) =>
            Underlying.Value!.DestroyContext(context);

        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DevicePauseSoft(DeviceHandle device) =>
            Underlying.Value!.DevicePauseSoft(device);

        [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
        [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeviceResumeSoft(DeviceHandle device) =>
            Underlying.Value!.DeviceResumeSoft(device);

        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void EventCallbackSoft(
            [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSoft callback,
            void* userParam
        ) => Underlying.Value!.EventCallbackSoft(callback, userParam);

        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void EventCallbackSoft(
            [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSoft callback,
            Ref userParam
        )
        {
            fixed (void* __dsl_userParam = userParam)
            {
                EventCallbackSoft(callback, __dsl_userParam);
            }
        }

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte EventControlSoft(
            [NativeTypeName("ALCsizei")] int count,
            [NativeTypeName("const ALCenum *")] int* events,
            [NativeTypeName("ALCboolean")] sbyte enable
        ) => Underlying.Value!.EventControlSoft(count, events, enable);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> EventControlSoft(
            [NativeTypeName("ALCsizei")] int count,
            [NativeTypeName("const ALCenum *")] Ref<int> events,
            [NativeTypeName("ALCboolean")] MaybeBool<sbyte> enable
        )
        {
            fixed (int* __dsl_events = events)
            {
                return (MaybeBool<sbyte>)
                    (sbyte)EventControlSoft(count, __dsl_events, (sbyte)enable);
            }
        }

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int EventIsSupportedSoft(
            [NativeTypeName("ALCenum")] int eventType,
            [NativeTypeName("ALCenum")] int deviceType
        ) => Underlying.Value!.EventIsSupportedSoft(eventType, deviceType);

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Constant<int, AlcEnum, EventSupportSOFT> EventIsSupportedSoft(
            [NativeTypeName("ALCenum")] Constant<int, EventTypeSOFT> eventType,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
        ) => Underlying.Value!.EventIsSupportedSoft(eventType, deviceType);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle GetContextsDevice(ContextHandle context) =>
            Underlying.Value!.GetContextsDevice(context);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle GetCurrentContext() => Underlying.Value!.GetCurrentContext();

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* enumname
        ) => Underlying.Value!.GetEnumValue(device, enumname);

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Constant<int, ErrorCode> GetError(DeviceHandle device) =>
            Underlying.Value!.GetError(device);

        [return: NativeTypeName("ALCenum")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetErrorRaw(DeviceHandle device) => Underlying.Value!.GetErrorRaw(device);

        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger64Soft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int pname,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALCint64SOFT *")] nint* values
        ) => Underlying.Value!.GetInteger64Soft(device, pname, size, values);

        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger64Soft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int pname,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALCint64SOFT *")] Ref<nint> values
        )
        {
            fixed (nint* __dsl_values = values)
            {
                GetInteger64Soft(device, pname, size, __dsl_values);
            }
        }

        [
            SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
            SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static nint GetInteger64Soft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int pname
        )
        {
            nint values = default;
            GetInteger64Soft(device, pname, 1, (nint*)&values);
            return values;
        }

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void* GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcname
        ) => Underlying.Value!.GetProcAddress(device, funcname);

        [return: NativeTypeName("ALCvoid *")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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

        [return: NativeTypeName("ALCvoid *")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void* GetProcAddress2(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcName
        ) => Underlying.Value!.GetProcAddress2(device, funcName);

        [return: NativeTypeName("ALCvoid *")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetProcAddress2(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> funcName
        )
        {
            fixed (sbyte* __dsl_funcName = funcName)
            {
                return (void*)GetProcAddress2(device, __dsl_funcName);
            }
        }

        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte* GetString(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1
        ) => Underlying.Value!.GetString(device, param1);

        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetString(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, ContextString> param1
        ) => Underlying.Value!.GetString(device, param1);

        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte* GetStringSoft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int paramName,
            [NativeTypeName("ALCsizei")] int index
        ) => Underlying.Value!.GetStringSoft(device, paramName, index);

        [return: NativeTypeName("const ALCchar *")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetStringSoft(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, ContextString> paramName,
            [NativeTypeName("ALCsizei")] int index
        ) => Underlying.Value!.GetStringSoft(device, paramName, index);

        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static ContextHandle GetThreadContext() => Underlying.Value!.GetThreadContext();

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* extname
        ) => Underlying.Value!.IsExtensionPresent(device, extname);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
        )
        {
            fixed (sbyte* __dsl_extname = extname)
            {
                return (MaybeBool<sbyte>)(sbyte)IsExtensionPresent(device, __dsl_extname);
            }
        }

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsRenderFormatSupportedSoft(
            DeviceHandle device,
            [NativeTypeName("ALCsizei")] int freq,
            [NativeTypeName("ALCenum")] int channels,
            [NativeTypeName("ALCenum")] int type
        ) => Underlying.Value!.IsRenderFormatSupportedSoft(device, freq, channels, type);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsRenderFormatSupportedSoft(
            DeviceHandle device,
            [NativeTypeName("ALCsizei")] int freq,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
            [NativeTypeName("ALCenum")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
        ) => Underlying.Value!.IsRenderFormatSupportedSoft(device, freq, channels, type);

        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle LoopbackOpenDeviceSoft(
            [NativeTypeName("const ALCchar *")] sbyte* deviceName
        ) => Underlying.Value!.LoopbackOpenDeviceSoft(deviceName);

        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle LoopbackOpenDeviceSoft(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName
        )
        {
            fixed (sbyte* __dsl_deviceName = deviceName)
            {
                return (DeviceHandle)LoopbackOpenDeviceSoft(__dsl_deviceName);
            }
        }

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> MakeContextCurrent(ContextHandle context) =>
            Underlying.Value!.MakeContextCurrent(context);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte MakeContextCurrentRaw(ContextHandle context) =>
            Underlying.Value!.MakeContextCurrentRaw(context);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename
        ) => Underlying.Value!.OpenDevice(devicename);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void ProcessContext(ContextHandle context) =>
            Underlying.Value!.ProcessContext(context);

        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void RenderSamplesSoft(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        ) => Underlying.Value!.RenderSamplesSoft(device, buffer, samples);

        [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void RenderSamplesSoft(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] Ref buffer,
            [NativeTypeName("ALCsizei")] int samples
        )
        {
            fixed (void* __dsl_buffer = buffer)
            {
                RenderSamplesSoft(device, __dsl_buffer, samples);
            }
        }

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte ReopenDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* deviceName,
            [NativeTypeName("const ALCint *")] int* attribs
        ) => Underlying.Value!.ReopenDeviceSoft(device, deviceName, attribs);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> ReopenDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName,
            [NativeTypeName("const ALCint *")] Ref<int> attribs
        )
        {
            fixed (int* __dsl_attribs = attribs)
            fixed (sbyte* __dsl_deviceName = deviceName)
            {
                return (MaybeBool<sbyte>)
                    (sbyte)ReopenDeviceSoft(device, __dsl_deviceName, __dsl_attribs);
            }
        }

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte ResetDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attribs
        ) => Underlying.Value!.ResetDeviceSoft(device, attribs);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> ResetDeviceSoft(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] Ref<int> attribs
        )
        {
            fixed (int* __dsl_attribs = attribs)
            {
                return (MaybeBool<sbyte>)(sbyte)ResetDeviceSoft(device, __dsl_attribs);
            }
        }

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> SetThreadContext(ContextHandle context) =>
            Underlying.Value!.SetThreadContext(context);

        [return: NativeTypeName("ALCboolean")]
        [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
        [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte SetThreadContextRaw(ContextHandle context) =>
            Underlying.Value!.SetThreadContextRaw(context);

        [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SuspendContext(ContextHandle context) =>
            Underlying.Value!.SuspendContext(context);
    }

    [NativeTypeName("#define ALC_CPLUSPLUS __cplusplus")]
    public const nint Cplusplus = 201703;

    [NativeTypeName("#define ALC_VERSION_0_1 1")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    public const int Version0X1 = 1;

    [NativeTypeName("#define ALC_EXT_CAPTURE 1")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    public const int ExtCapture = 1;

    [NameAffix("Suffix", "EXT", 0)]
    [NativeTypeName("#define ALC_ENUMERATE_ALL_EXT 1")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    public const int EnumerateAllEXT = 1;

    [NativeTypeName("#define ALC_EXT_EFX_NAME \"ALC_EXT_EFX\"")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    public static ReadOnlySpan<byte> ExtEfxName => "ALC_EXT_EFX"u8;

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.CaptureCloseDevice(DeviceHandle device) =>
        (MaybeBool<sbyte>)(sbyte)((IAlContext)this).CaptureCloseDeviceRaw(device);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> CaptureCloseDevice(DeviceHandle device) =>
        ThisThread.CaptureCloseDevice(device);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.CaptureCloseDeviceRaw(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte>)(
                _slots[0] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[0] = nativeContext.LoadFunction("alcCaptureCloseDevice", "openal")
            )
        )(device);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte CaptureCloseDeviceRaw(DeviceHandle device) =>
        ThisThread.CaptureCloseDeviceRaw(device);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.CaptureOpenDevice(
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

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] sbyte* devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] int format,
        [NativeTypeName("ALCsizei")] int buffersize
    ) => ThisThread.CaptureOpenDevice(devicename, frequency, format, buffersize);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] Constant<int, AlEnum, Format> format,
        [NativeTypeName("ALCsizei")] int buffersize
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

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] Constant<int, AlEnum, Format> format,
        [NativeTypeName("ALCsizei")] int buffersize
    ) => ThisThread.CaptureOpenDevice(devicename, frequency, format, buffersize);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.CaptureSamples(
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

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureSamples(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] void* buffer,
        [NativeTypeName("ALCsizei")] int samples
    ) => ThisThread.CaptureSamples(device, buffer, samples);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.CaptureSamples(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] Ref buffer,
        [NativeTypeName("ALCsizei")] int samples
    )
    {
        fixed (void* __dsl_buffer = buffer)
        {
            ((IAlContext)this).CaptureSamples(device, __dsl_buffer, samples);
        }
    }

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureSamples(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] Ref buffer,
        [NativeTypeName("ALCsizei")] int samples
    ) => ThisThread.CaptureSamples(device, buffer, samples);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.CaptureStart(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, void>)(
                _slots[3] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[3] = nativeContext.LoadFunction("alcCaptureStart", "openal")
            )
        )(device);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureStart(DeviceHandle device) => ThisThread.CaptureStart(device);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.CaptureStop(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, void>)(
                _slots[4] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[4] = nativeContext.LoadFunction("alcCaptureStop", "openal")
            )
        )(device);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void CaptureStop(DeviceHandle device) => ThisThread.CaptureStop(device);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.CloseDevice(DeviceHandle device) =>
        (MaybeBool<sbyte>)(sbyte)((IAlContext)this).CloseDeviceRaw(device);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> CloseDevice(DeviceHandle device) =>
        ThisThread.CloseDevice(device);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.CloseDeviceRaw(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte>)(
                _slots[5] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[5] = nativeContext.LoadFunction("alcCloseDevice", "openal")
            )
        )(device);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte CloseDeviceRaw(DeviceHandle device) => ThisThread.CloseDeviceRaw(device);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ContextHandle IAlContext.CreateContext(
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

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ContextHandle CreateContext(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] int* attrlist
    ) => ThisThread.CreateContext(device, attrlist);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    ContextHandle IAlContext.CreateContext(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] Ref<int> attrlist
    )
    {
        fixed (int* __dsl_attrlist = attrlist)
        {
            return (ContextHandle)((IAlContext)this).CreateContext(device, __dsl_attrlist);
        }
    }

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ContextHandle CreateContext(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] Ref<int> attrlist
    ) => ThisThread.CreateContext(device, attrlist);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.DestroyContext(ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, void>)(
                _slots[7] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[7] = nativeContext.LoadFunction("alcDestroyContext", "openal")
            )
        )(context);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DestroyContext(ContextHandle context) => ThisThread.DestroyContext(context);

    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.DevicePauseSoft(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, void>)(
                _slots[8] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[8] = nativeContext.LoadFunction("alcDevicePauseSOFT", "openal")
            )
        )(device);

    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDevicePauseSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DevicePauseSoft(DeviceHandle device) => ThisThread.DevicePauseSoft(device);

    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.DeviceResumeSoft(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, void>)(
                _slots[9] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[9] = nativeContext.LoadFunction("alcDeviceResumeSOFT", "openal")
            )
        )(device);

    [SupportedApiProfile("alc", ["ALC_SOFT_pause_device"])]
    [NativeFunction("openal", EntryPoint = "alcDeviceResumeSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DeviceResumeSoft(DeviceHandle device) => ThisThread.DeviceResumeSoft(device);

    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.EventCallbackSoft(
        [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSoft callback,
        void* userParam
    ) =>
        (
            (delegate* unmanaged<ContextEventProcSoft, void*, void>)(
                _slots[10] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[10] = nativeContext.LoadFunction("alcEventCallbackSOFT", "openal")
            )
        )(callback, userParam);

    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void EventCallbackSoft(
        [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSoft callback,
        void* userParam
    ) => ThisThread.EventCallbackSoft(callback, userParam);

    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.EventCallbackSoft(
        [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSoft callback,
        Ref userParam
    )
    {
        fixed (void* __dsl_userParam = userParam)
        {
            ((IAlContext)this).EventCallbackSoft(callback, __dsl_userParam);
        }
    }

    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcEventCallbackSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void EventCallbackSoft(
        [NativeTypeName("ALCEVENTPROCTYPESOFT")] ContextEventProcSoft callback,
        Ref userParam
    ) => ThisThread.EventCallbackSoft(callback, userParam);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.EventControlSoft(
        [NativeTypeName("ALCsizei")] int count,
        [NativeTypeName("const ALCenum *")] int* events,
        [NativeTypeName("ALCboolean")] sbyte enable
    ) =>
        (
            (delegate* unmanaged<int, int*, sbyte, sbyte>)(
                _slots[11] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[11] = nativeContext.LoadFunction("alcEventControlSOFT", "openal")
            )
        )(count, events, enable);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte EventControlSoft(
        [NativeTypeName("ALCsizei")] int count,
        [NativeTypeName("const ALCenum *")] int* events,
        [NativeTypeName("ALCboolean")] sbyte enable
    ) => ThisThread.EventControlSoft(count, events, enable);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.EventControlSoft(
        [NativeTypeName("ALCsizei")] int count,
        [NativeTypeName("const ALCenum *")] Ref<int> events,
        [NativeTypeName("ALCboolean")] MaybeBool<sbyte> enable
    )
    {
        fixed (int* __dsl_events = events)
        {
            return (MaybeBool<sbyte>)
                (sbyte)((IAlContext)this).EventControlSoft(count, __dsl_events, (sbyte)enable);
        }
    }

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcEventControlSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> EventControlSoft(
        [NativeTypeName("ALCsizei")] int count,
        [NativeTypeName("const ALCenum *")] Ref<int> events,
        [NativeTypeName("ALCboolean")] MaybeBool<sbyte> enable
    ) => ThisThread.EventControlSoft(count, events, enable);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAlContext.EventIsSupportedSoft(
        [NativeTypeName("ALCenum")] int eventType,
        [NativeTypeName("ALCenum")] int deviceType
    ) =>
        (
            (delegate* unmanaged<int, int, int>)(
                _slots[12] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[12] = nativeContext.LoadFunction("alcEventIsSupportedSOFT", "openal")
            )
        )(eventType, deviceType);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int EventIsSupportedSoft(
        [NativeTypeName("ALCenum")] int eventType,
        [NativeTypeName("ALCenum")] int deviceType
    ) => ThisThread.EventIsSupportedSoft(eventType, deviceType);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Constant<int, AlcEnum, EventSupportSOFT> IAlContext.EventIsSupportedSoft(
        [NativeTypeName("ALCenum")] Constant<int, EventTypeSOFT> eventType,
        [NativeTypeName("ALCenum")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
    ) =>
        (Constant<int, AlcEnum, EventSupportSOFT>)
            (int)((IAlContext)this).EventIsSupportedSoft((int)eventType, (int)deviceType);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_SOFT_system_events"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcEventIsSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Constant<int, AlcEnum, EventSupportSOFT> EventIsSupportedSoft(
        [NativeTypeName("ALCenum")] Constant<int, EventTypeSOFT> eventType,
        [NativeTypeName("ALCenum")] Constant<int, AlcEnum, DeviceTypeSOFT> deviceType
    ) => ThisThread.EventIsSupportedSoft(eventType, deviceType);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.GetContextsDevice(ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, DeviceHandle>)(
                _slots[13] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[13] = nativeContext.LoadFunction("alcGetContextsDevice", "openal")
            )
        )(context);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle GetContextsDevice(ContextHandle context) =>
        ThisThread.GetContextsDevice(context);

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

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ContextHandle GetCurrentContext() => ThisThread.GetCurrentContext();

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAlContext.GetEnumValue(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* enumname
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, int>)(
                _slots[15] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[15] = nativeContext.LoadFunction("alcGetEnumValue", "openal")
            )
        )(device, enumname);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetEnumValue(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* enumname
    ) => ThisThread.GetEnumValue(device, enumname);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAlContext.GetEnumValue(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname
    )
    {
        fixed (sbyte* __dsl_enumname = enumname)
        {
            return (int)((IAlContext)this).GetEnumValue(device, __dsl_enumname);
        }
    }

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetEnumValue(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname
    ) => ThisThread.GetEnumValue(device, enumname);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Constant<int, ErrorCode> IAlContext.GetError(DeviceHandle device) =>
        (Constant<int, ErrorCode>)(int)((IAlContext)this).GetErrorRaw(device);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Constant<int, ErrorCode> GetError(DeviceHandle device) =>
        ThisThread.GetError(device);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAlContext.GetErrorRaw(DeviceHandle device) =>
        (
            (delegate* unmanaged<DeviceHandle, int>)(
                _slots[16] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[16] = nativeContext.LoadFunction("alcGetError", "openal")
            )
        )(device);

    [return: NativeTypeName("ALCenum")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetErrorRaw(DeviceHandle device) => ThisThread.GetErrorRaw(device);

    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.GetInteger64Soft(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int pname,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALCint64SOFT *")] nint* values
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int, int, nint*, void>)(
                _slots[17] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[17] = nativeContext.LoadFunction("alcGetInteger64vSOFT", "openal")
            )
        )(device, pname, size, values);

    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger64Soft(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int pname,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALCint64SOFT *")] nint* values
    ) => ThisThread.GetInteger64Soft(device, pname, size, values);

    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.GetInteger64Soft(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int pname,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALCint64SOFT *")] Ref<nint> values
    )
    {
        fixed (nint* __dsl_values = values)
        {
            ((IAlContext)this).GetInteger64Soft(device, pname, size, __dsl_values);
        }
    }

    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger64Soft(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int pname,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALCint64SOFT *")] Ref<nint> values
    ) => ThisThread.GetInteger64Soft(device, pname, size, values);

    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    nint IAlContext.GetInteger64Soft(DeviceHandle device, [NativeTypeName("ALCenum")] int pname)
    {
        nint values = default;
        ((IAlContext)this).GetInteger64Soft(device, pname, 1, (nint*)&values);
        return values;
    }

    [
        SupportedApiProfile("al", ["ALC_SOFT_device_clock"]),
        SupportedApiProfile("alc", ["ALC_SOFT_device_clock"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetInteger64vSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static nint GetInteger64Soft(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int pname
    ) => ThisThread.GetInteger64Soft(device, pname);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.GetInteger(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] int* values
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int, int, int*, void>)(
                _slots[18] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[18] = nativeContext.LoadFunction("alcGetIntegerv", "openal")
            )
        )(device, param1, size, values);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] int* values
    ) => ThisThread.GetInteger(device, param1, size, values);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.GetInteger(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAlContext)this).GetInteger(device, param1, size, __dsl_values);
        }
    }

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] Ref<int> values
    ) => ThisThread.GetInteger(device, param1, size, values);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAlContext.GetInteger(DeviceHandle device, [NativeTypeName("ALCenum")] int param1)
    {
        int values = default;
        ((IAlContext)this).GetInteger(device, param1, 1, (int*)&values);
        return values;
    }

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetInteger(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
        ThisThread.GetInteger(device, param1);

    [return: NativeTypeName("ALCvoid *")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void* IAlContext.GetProcAddress(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* funcname
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, void*>)(
                _slots[19] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[19] = nativeContext.LoadFunction("alcGetProcAddress", "openal")
            )
        )(device, funcname);

    [return: NativeTypeName("ALCvoid *")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void* GetProcAddress(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* funcname
    ) => ThisThread.GetProcAddress(device, funcname);

    [return: NativeTypeName("ALCvoid *")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr IAlContext.GetProcAddress(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
    )
    {
        fixed (sbyte* __dsl_funcname = funcname)
        {
            return (void*)((IAlContext)this).GetProcAddress(device, __dsl_funcname);
        }
    }

    [return: NativeTypeName("ALCvoid *")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr GetProcAddress(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
    ) => ThisThread.GetProcAddress(device, funcname);

    [return: NativeTypeName("ALCvoid *")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void* IAlContext.GetProcAddress2(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* funcName
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, void*>)(
                _slots[20] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[20] = nativeContext.LoadFunction("alcGetProcAddress2", "openal")
            )
        )(device, funcName);

    [return: NativeTypeName("ALCvoid *")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void* GetProcAddress2(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* funcName
    ) => ThisThread.GetProcAddress2(device, funcName);

    [return: NativeTypeName("ALCvoid *")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr IAlContext.GetProcAddress2(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> funcName
    )
    {
        fixed (sbyte* __dsl_funcName = funcName)
        {
            return (void*)((IAlContext)this).GetProcAddress2(device, __dsl_funcName);
        }
    }

    [return: NativeTypeName("ALCvoid *")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress2")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr GetProcAddress2(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> funcName
    ) => ThisThread.GetProcAddress2(device, funcName);

    [return: NativeTypeName("const ALCchar *")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte* IAlContext.GetString(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
        (
            (delegate* unmanaged<DeviceHandle, int, sbyte*>)(
                _slots[21] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[21] = nativeContext.LoadFunction("alcGetString", "openal")
            )
        )(device, param1);

    [return: NativeTypeName("const ALCchar *")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte* GetString(DeviceHandle device, [NativeTypeName("ALCenum")] int param1) =>
        ThisThread.GetString(device, param1);

    [return: NativeTypeName("const ALCchar *")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr<sbyte> IAlContext.GetString(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] Constant<int, AlcEnum, ContextString> param1
    ) => (sbyte*)((IAlContext)this).GetString(device, (int)param1);

    [return: NativeTypeName("const ALCchar *")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<sbyte> GetString(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] Constant<int, AlcEnum, ContextString> param1
    ) => ThisThread.GetString(device, param1);

    [return: NativeTypeName("const ALCchar *")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte* IAlContext.GetStringSoft(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int paramName,
        [NativeTypeName("ALCsizei")] int index
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int, int, sbyte*>)(
                _slots[22] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[22] = nativeContext.LoadFunction("alcGetStringiSOFT", "openal")
            )
        )(device, paramName, index);

    [return: NativeTypeName("const ALCchar *")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte* GetStringSoft(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int paramName,
        [NativeTypeName("ALCsizei")] int index
    ) => ThisThread.GetStringSoft(device, paramName, index);

    [return: NativeTypeName("const ALCchar *")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr<sbyte> IAlContext.GetStringSoft(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] Constant<int, AlcEnum, ContextString> paramName,
        [NativeTypeName("ALCsizei")] int index
    ) => (sbyte*)((IAlContext)this).GetStringSoft(device, (int)paramName, index);

    [return: NativeTypeName("const ALCchar *")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetStringiSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<sbyte> GetStringSoft(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] Constant<int, AlcEnum, ContextString> paramName,
        [NativeTypeName("ALCsizei")] int index
    ) => ThisThread.GetStringSoft(device, paramName, index);

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

    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcGetThreadContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ContextHandle GetThreadContext() => ThisThread.GetThreadContext();

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* extname
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, sbyte>)(
                _slots[24] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[24] = nativeContext.LoadFunction("alcIsExtensionPresent", "openal")
            )
        )(device, extname);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* extname
    ) => ThisThread.IsExtensionPresent(device, extname);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
    )
    {
        fixed (sbyte* __dsl_extname = extname)
        {
            return (MaybeBool<sbyte>)
                (sbyte)((IAlContext)this).IsExtensionPresent(device, __dsl_extname);
        }
    }

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
    ) => ThisThread.IsExtensionPresent(device, extname);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.IsRenderFormatSupportedSoft(
        DeviceHandle device,
        [NativeTypeName("ALCsizei")] int freq,
        [NativeTypeName("ALCenum")] int channels,
        [NativeTypeName("ALCenum")] int type
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

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsRenderFormatSupportedSoft(
        DeviceHandle device,
        [NativeTypeName("ALCsizei")] int freq,
        [NativeTypeName("ALCenum")] int channels,
        [NativeTypeName("ALCenum")] int type
    ) => ThisThread.IsRenderFormatSupportedSoft(device, freq, channels, type);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.IsRenderFormatSupportedSoft(
        DeviceHandle device,
        [NativeTypeName("ALCsizei")] int freq,
        [NativeTypeName("ALCenum")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
        [NativeTypeName("ALCenum")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
    ) =>
        (MaybeBool<sbyte>)
            (sbyte)
                ((IAlContext)this).IsRenderFormatSupportedSoft(
                    device,
                    freq,
                    (int)channels,
                    (int)type
                );

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcIsRenderFormatSupportedSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> IsRenderFormatSupportedSoft(
        DeviceHandle device,
        [NativeTypeName("ALCsizei")] int freq,
        [NativeTypeName("ALCenum")] Constant<int, AlcEnum, RenderFormatChannelSOFT> channels,
        [NativeTypeName("ALCenum")] Constant<int, AlcEnum, RenderFormatTypeSOFT> type
    ) => ThisThread.IsRenderFormatSupportedSoft(device, freq, channels, type);

    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.LoopbackOpenDeviceSoft(
        [NativeTypeName("const ALCchar *")] sbyte* deviceName
    ) =>
        (
            (delegate* unmanaged<sbyte*, DeviceHandle>)(
                _slots[26] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[26] = nativeContext.LoadFunction("alcLoopbackOpenDeviceSOFT", "openal")
            )
        )(deviceName);

    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle LoopbackOpenDeviceSoft(
        [NativeTypeName("const ALCchar *")] sbyte* deviceName
    ) => ThisThread.LoopbackOpenDeviceSoft(deviceName);

    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.LoopbackOpenDeviceSoft(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName
    )
    {
        fixed (sbyte* __dsl_deviceName = deviceName)
        {
            return (DeviceHandle)((IAlContext)this).LoopbackOpenDeviceSoft(__dsl_deviceName);
        }
    }

    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcLoopbackOpenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle LoopbackOpenDeviceSoft(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName
    ) => ThisThread.LoopbackOpenDeviceSoft(deviceName);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.MakeContextCurrent(ContextHandle context) =>
        (MaybeBool<sbyte>)(sbyte)((IAlContext)this).MakeContextCurrentRaw(context);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> MakeContextCurrent(ContextHandle context) =>
        ThisThread.MakeContextCurrent(context);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private MaybeBool<sbyte> MakeContextCurrentInternal(ContextHandle context) =>
        (MaybeBool<sbyte>)(sbyte)MakeContextCurrentInternalRaw(context);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private sbyte MakeContextCurrentInternalRaw(ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, sbyte>)(
                _slots[27] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[27] = nativeContext.LoadFunction("alcMakeContextCurrent", "openal")
            )
        )(context);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte MakeContextCurrentRaw(ContextHandle context) =>
        ThisThread.MakeContextCurrentRaw(context);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] sbyte* devicename) =>
        ThisThread.OpenDevice(devicename);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    DeviceHandle IAlContext.OpenDevice([NativeTypeName("const ALCchar *")] Ref<sbyte> devicename)
    {
        fixed (sbyte* __dsl_devicename = devicename)
        {
            return (DeviceHandle)((IAlContext)this).OpenDevice(__dsl_devicename);
        }
    }

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static DeviceHandle OpenDevice(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename
    ) => ThisThread.OpenDevice(devicename);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private DeviceHandle OpenDeviceInternal(
        [NativeTypeName("const ALCchar *")] sbyte* devicename
    ) =>
        (
            (delegate* unmanaged<sbyte*, DeviceHandle>)(
                _slots[28] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[28] = nativeContext.LoadFunction("alcOpenDevice", "openal")
            )
        )(devicename);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private DeviceHandle OpenDeviceInternal(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename
    )
    {
        fixed (sbyte* __dsl_devicename = devicename)
        {
            return (DeviceHandle)OpenDeviceInternal(__dsl_devicename);
        }
    }

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcProcessContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.ProcessContext(ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, void>)(
                _slots[29] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[29] = nativeContext.LoadFunction("alcProcessContext", "openal")
            )
        )(context);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcProcessContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ProcessContext(ContextHandle context) => ThisThread.ProcessContext(context);

    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.RenderSamplesSoft(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] void* buffer,
        [NativeTypeName("ALCsizei")] int samples
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, void*, int, void>)(
                _slots[30] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[30] = nativeContext.LoadFunction("alcRenderSamplesSOFT", "openal")
            )
        )(device, buffer, samples);

    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void RenderSamplesSoft(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] void* buffer,
        [NativeTypeName("ALCsizei")] int samples
    ) => ThisThread.RenderSamplesSoft(device, buffer, samples);

    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.RenderSamplesSoft(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] Ref buffer,
        [NativeTypeName("ALCsizei")] int samples
    )
    {
        fixed (void* __dsl_buffer = buffer)
        {
            ((IAlContext)this).RenderSamplesSoft(device, __dsl_buffer, samples);
        }
    }

    [SupportedApiProfile("alc", ["ALC_SOFT_loopback"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcRenderSamplesSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void RenderSamplesSoft(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] Ref buffer,
        [NativeTypeName("ALCsizei")] int samples
    ) => ThisThread.RenderSamplesSoft(device, buffer, samples);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.ReopenDeviceSoft(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* deviceName,
        [NativeTypeName("const ALCint *")] int* attribs
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, sbyte*, int*, sbyte>)(
                _slots[31] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[31] = nativeContext.LoadFunction("alcReopenDeviceSOFT", "openal")
            )
        )(device, deviceName, attribs);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte ReopenDeviceSoft(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* deviceName,
        [NativeTypeName("const ALCint *")] int* attribs
    ) => ThisThread.ReopenDeviceSoft(device, deviceName, attribs);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.ReopenDeviceSoft(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName,
        [NativeTypeName("const ALCint *")] Ref<int> attribs
    )
    {
        fixed (int* __dsl_attribs = attribs)
        fixed (sbyte* __dsl_deviceName = deviceName)
        {
            return (MaybeBool<sbyte>)
                (sbyte)((IAlContext)this).ReopenDeviceSoft(device, __dsl_deviceName, __dsl_attribs);
        }
    }

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_reopen_device"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcReopenDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> ReopenDeviceSoft(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> deviceName,
        [NativeTypeName("const ALCint *")] Ref<int> attribs
    ) => ThisThread.ReopenDeviceSoft(device, deviceName, attribs);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.ResetDeviceSoft(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] int* attribs
    ) =>
        (
            (delegate* unmanaged<DeviceHandle, int*, sbyte>)(
                _slots[32] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[32] = nativeContext.LoadFunction("alcResetDeviceSOFT", "openal")
            )
        )(device, attribs);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte ResetDeviceSoft(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] int* attribs
    ) => ThisThread.ResetDeviceSoft(device, attribs);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.ResetDeviceSoft(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] Ref<int> attribs
    )
    {
        fixed (int* __dsl_attribs = attribs)
        {
            return (MaybeBool<sbyte>)
                (sbyte)((IAlContext)this).ResetDeviceSoft(device, __dsl_attribs);
        }
    }

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_SOFT_HRTF"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcResetDeviceSOFT")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> ResetDeviceSoft(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] Ref<int> attribs
    ) => ThisThread.ResetDeviceSoft(device, attribs);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAlContext.SetThreadContext(ContextHandle context) =>
        (MaybeBool<sbyte>)(sbyte)((IAlContext)this).SetThreadContextRaw(context);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> SetThreadContext(ContextHandle context) =>
        ThisThread.SetThreadContext(context);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAlContext.SetThreadContextRaw(ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, sbyte>)(
                _slots[33] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[33] = nativeContext.LoadFunction("alcSetThreadContext", "openal")
            )
        )(context);

    [return: NativeTypeName("ALCboolean")]
    [SupportedApiProfile("alc", ["ALC_EXT_thread_local_context"])]
    [NativeFunction("openal", EntryPoint = "alcSetThreadContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte SetThreadContextRaw(ContextHandle context) =>
        ThisThread.SetThreadContextRaw(context);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAlContext.SuspendContext(ContextHandle context) =>
        (
            (delegate* unmanaged<ContextHandle, void>)(
                _slots[34] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[34] = nativeContext.LoadFunction("alcSuspendContext", "openal")
            )
        )(context);

    [SupportedApiProfile("alc", ["ALC_VERSION_1_0", "ALC_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SuspendContext(ContextHandle context) => ThisThread.SuspendContext(context);
}
