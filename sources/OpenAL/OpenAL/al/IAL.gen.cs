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

public unsafe partial interface IAL
{
    public partial interface Static
    {
        [NativeName("alAuxiliaryEffectSlotf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
        static abstract void AuxiliaryEffectSlot(uint effectslot, int param1, float flValue);

        [NativeName("alAuxiliaryEffectSlotf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
        static abstract void AuxiliaryEffectSlot(
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param1,
            float flValue
        );

        [NativeName("alAuxiliaryEffectSlotfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            uint effectslot,
            int param2,
            float flValue
        );

        [NativeName("alAuxiliaryEffectSlotfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param2,
            float flValue
        );

        [NativeName("alAuxiliaryEffectSlotfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
        static abstract void AuxiliaryEffectSlot(uint effectslot, int param1, float* pflValues);

        [NativeName("alAuxiliaryEffectSlotfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
        static abstract void AuxiliaryEffectSlot(
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param1,
            Ref<float> pflValues
        );

        [NativeName("alAuxiliaryEffectSlotfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            uint effectslot,
            int param2,
            float* pflValues
        );

        [NativeName("alAuxiliaryEffectSlotfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param2,
            Ref<float> pflValues
        );

        [NativeName("alAuxiliaryEffectSloti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
        static abstract void AuxiliaryEffectSlot(uint effectslot, int param1, int iValue);

        [NativeName("alAuxiliaryEffectSloti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
        static abstract void AuxiliaryEffectSlot(
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param1,
            int iValue
        );

        [NativeName("alAuxiliaryEffectSlotiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            uint effectslot,
            int param2,
            int iValue
        );

        [NativeName("alAuxiliaryEffectSlotiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param2,
            int iValue
        );

        [NativeName("alAuxiliaryEffectSlotiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
        static abstract void AuxiliaryEffectSlot(uint effectslot, int param1, int* piValues);

        [NativeName("alAuxiliaryEffectSlotiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
        static abstract void AuxiliaryEffectSlot(
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param1,
            Ref<int> piValues
        );

        [NativeName("alAuxiliaryEffectSlotivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            uint effectslot,
            int param2,
            int* piValues
        );

        [NativeName("alAuxiliaryEffectSlotivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param2,
            Ref<int> piValues
        );

        [NativeName("alBuffer3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBuffer3f")]
        static abstract void Buffer3(
            uint buffer,
            int param1,
            float value1,
            float value2,
            float value3
        );

        [NativeName("alBuffer3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBuffer3fDirect")]
        static abstract void Buffer3Direct(
            ContextHandle context,
            uint buffer,
            int param2,
            float value1,
            float value2,
            float value3
        );

        [NativeName("alBuffer3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBuffer3i")]
        static abstract void Buffer3(uint buffer, int param1, int value1, int value2, int value3);

        [NativeName("alBuffer3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBuffer3iDirect")]
        static abstract void Buffer3Direct(
            ContextHandle context,
            uint buffer,
            int param2,
            int value1,
            int value2,
            int value3
        );

        [NativeName("alBufferCallbackDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alBufferCallbackDirectSOFT")]
        static abstract void BufferCallbackDirectSOFT(
            ContextHandle context,
            uint buffer,
            int format,
            int freq,
            BufferCallbackSOFT callback,
            void* userptr
        );

        [NativeName("alBufferCallbackDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alBufferCallbackDirectSOFT")]
        static abstract void BufferCallbackDirectSOFT(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, Format> format,
            int freq,
            BufferCallbackSOFT callback,
            Ref userptr
        );

        [NativeName("alBufferCallbackSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
        static abstract void BufferCallbackSOFT(
            uint buffer,
            int format,
            int freq,
            BufferCallbackSOFT callback,
            void* userptr
        );

        [NativeName("alBufferCallbackSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
        static abstract void BufferCallbackSOFT(
            uint buffer,
            Constant<int, ALEnum, Format> format,
            int freq,
            BufferCallbackSOFT callback,
            Ref userptr
        );

        [NativeName("alBufferData")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        static abstract void BufferData(
            uint buffer,
            int format,
            void* data,
            int size,
            int samplerate
        );

        [NativeName("alBufferData")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        static abstract void BufferData(
            uint buffer,
            Constant<int, ALEnum, Format> format,
            Ref data,
            int size,
            int samplerate
        );

        [NativeName("alBufferDataDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
        static abstract void BufferDataDirect(
            ContextHandle context,
            uint buffer,
            int format,
            void* data,
            int size,
            int samplerate
        );

        [NativeName("alBufferDataDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
        static abstract void BufferDataDirect(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, Format> format,
            Ref data,
            int size,
            int samplerate
        );

        [NativeName("alBufferDataStatic")]
        [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
        [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
        static abstract void BufferDataStatic(
            uint buffer,
            int format,
            void* data,
            int size,
            int freq
        );

        [NativeName("alBufferDataStatic")]
        [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
        [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
        static abstract void BufferDataStatic(
            uint buffer,
            Constant<int, ALEnum, Format> format,
            Ref data,
            int size,
            int freq
        );

        [NativeName("alBufferDataStaticDirect")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_EXT_STATIC_BUFFER"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_EXT_STATIC_BUFFER"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alBufferDataStaticDirect")]
        static abstract void BufferDataStaticDirect(
            ContextHandle context,
            uint buffer,
            int format,
            void* data,
            int size,
            int freq
        );

        [NativeName("alBufferDataStaticDirect")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_EXT_STATIC_BUFFER"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_EXT_STATIC_BUFFER"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alBufferDataStaticDirect")]
        static abstract void BufferDataStaticDirect(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, Format> format,
            Ref data,
            int size,
            int freq
        );

        [NativeName("alBufferf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferf")]
        static abstract void Buffer(uint buffer, int param1, float value);

        [NativeName("alBufferf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferf")]
        static abstract void Buffer(
            uint buffer,
            Constant<int, ALEnum, BufferFloat> param1,
            float value
        );

        [NativeName("alBufferfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            uint buffer,
            int param2,
            float value
        );

        [NativeName("alBufferfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, BufferFloat> param2,
            float value
        );

        [NativeName("alBufferfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        static abstract void Buffer(uint buffer, int param1, float* values);

        [NativeName("alBufferfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        static abstract void Buffer(
            uint buffer,
            Constant<int, ALEnum, BufferFloat> param1,
            Ref<float> values
        );

        [NativeName("alBufferfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            uint buffer,
            int param2,
            float* values
        );

        [NativeName("alBufferfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, BufferFloat> param2,
            Ref<float> values
        );

        [NativeName("alBufferi")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferi")]
        static abstract void Buffer(uint buffer, int param1, int value);

        [NativeName("alBufferi")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferi")]
        static abstract void Buffer(
            uint buffer,
            Constant<int, ALEnum, BufferInteger> param1,
            int value
        );

        [NativeName("alBufferiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            uint buffer,
            int param2,
            int value
        );

        [NativeName("alBufferiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, BufferInteger> param2,
            int value
        );

        [NativeName("alBufferiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        static abstract void Buffer(uint buffer, int param1, int* values);

        [NativeName("alBufferiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        static abstract void Buffer(
            uint buffer,
            Constant<int, ALEnum, BufferInteger> param1,
            Ref<int> values
        );

        [NativeName("alBufferivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            uint buffer,
            int param2,
            int* values
        );

        [NativeName("alBufferivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, BufferInteger> param2,
            Ref<int> values
        );

        [NativeName("alBufferSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
        static abstract void BufferSamplesSOFT(
            uint buffer,
            uint samplerate,
            int internalformat,
            int samples,
            int channels,
            int type,
            void* data
        );

        [NativeName("alBufferSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
        static abstract void BufferSamplesSOFT(
            uint buffer,
            uint samplerate,
            int internalformat,
            int samples,
            Constant<int, ALEnum, BufferChannelsSOFT> channels,
            Constant<int, ALEnum, SampleTypeSOFT> type,
            Ref data
        );

        [NativeName("alBufferSubDataDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_buffer_sub_data"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_buffer_sub_data"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alBufferSubDataDirectSOFT")]
        static abstract void BufferSubDataDirectSOFT(
            ContextHandle context,
            uint buffer,
            int format,
            void* data,
            int offset,
            int length
        );

        [NativeName("alBufferSubDataDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_buffer_sub_data"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_buffer_sub_data"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alBufferSubDataDirectSOFT")]
        static abstract void BufferSubDataDirectSOFT(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, Format> format,
            Ref data,
            int offset,
            int length
        );

        [NativeName("alBufferSubDataSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
        [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
        static abstract void BufferSubDataSOFT(
            uint buffer,
            int format,
            void* data,
            int offset,
            int length
        );

        [NativeName("alBufferSubDataSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
        [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
        static abstract void BufferSubDataSOFT(
            uint buffer,
            Constant<int, ALEnum, Format> format,
            Ref data,
            int offset,
            int length
        );

        [NativeName("alBufferSubSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
        static abstract void BufferSubSamplesSOFT(
            uint buffer,
            int offset,
            int samples,
            int channels,
            int type,
            void* data
        );

        [NativeName("alBufferSubSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
        static abstract void BufferSubSamplesSOFT(
            uint buffer,
            int offset,
            int samples,
            Constant<int, ALEnum, BufferChannelsSOFT> channels,
            Constant<int, ALEnum, SampleTypeSOFT> type,
            Ref data
        );

        [NativeName("alDebugMessageCallbackDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
        static abstract void DebugMessageCallbackDirectEXT(
            ContextHandle context,
            DebugProcEXT callback,
            void* userParam
        );

        [NativeName("alDebugMessageCallbackDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
        static abstract void DebugMessageCallbackDirectEXT(
            ContextHandle context,
            DebugProcEXT callback,
            Ref userParam
        );

        [NativeName("alDebugMessageCallbackEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
        static abstract void DebugMessageCallbackEXT(DebugProcEXT callback, void* userParam);

        [NativeName("alDebugMessageCallbackEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
        static abstract void DebugMessageCallbackEXT(DebugProcEXT callback, Ref userParam);

        [NativeName("alDebugMessageControlDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
        static abstract void DebugMessageControlDirectEXT(
            ContextHandle context,
            int source,
            int type,
            int severity,
            int count,
            uint* ids,
            sbyte enable
        );

        [NativeName("alDebugMessageControlDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
        static abstract void DebugMessageControlDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, DebugSourceEXT> source,
            Constant<int, ALEnum, DebugTypeEXT> type,
            Constant<int, ALEnum, DebugSeverityEXT> severity,
            int count,
            Ref<uint> ids,
            MaybeBool<sbyte> enable
        );

        [NativeName("alDebugMessageControlDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
        static abstract void DebugMessageControlDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, DebugSourceEXT> source,
            Constant<int, ALEnum, DebugTypeEXT> type,
            Constant<int, ALEnum, DebugSeverityEXT> severity,
            uint ids,
            MaybeBool<sbyte> enable
        );

        [NativeName("alDebugMessageControlEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
        static abstract void DebugMessageControlEXT(
            int source,
            int type,
            int severity,
            int count,
            uint* ids,
            sbyte enable
        );

        [NativeName("alDebugMessageControlEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
        static abstract void DebugMessageControlEXT(
            Constant<int, ALEnum, DebugSourceEXT> source,
            Constant<int, ALEnum, DebugTypeEXT> type,
            Constant<int, ALEnum, DebugSeverityEXT> severity,
            int count,
            Ref<uint> ids,
            MaybeBool<sbyte> enable
        );

        [NativeName("alDebugMessageControlEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
        static abstract void DebugMessageControlEXT(
            Constant<int, ALEnum, DebugSourceEXT> source,
            Constant<int, ALEnum, DebugTypeEXT> type,
            Constant<int, ALEnum, DebugSeverityEXT> severity,
            uint ids,
            MaybeBool<sbyte> enable
        );

        [NativeName("alDebugMessageInsertDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
        static abstract void DebugMessageInsertDirectEXT(
            ContextHandle context,
            int source,
            int type,
            uint id,
            int severity,
            int length,
            sbyte* message
        );

        [NativeName("alDebugMessageInsertDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
        static abstract void DebugMessageInsertDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, DebugSourceEXT> source,
            Constant<int, ALEnum, DebugTypeEXT> type,
            uint id,
            Constant<int, ALEnum, DebugSeverityEXT> severity,
            int length,
            Ref<sbyte> message
        );

        [NativeName("alDebugMessageInsertDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
        static abstract void DebugMessageInsertDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, DebugSourceEXT> source,
            Constant<int, ALEnum, DebugTypeEXT> type,
            uint id,
            Constant<int, ALEnum, DebugSeverityEXT> severity,
            sbyte message
        );

        [NativeName("alDebugMessageInsertEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
        static abstract void DebugMessageInsertEXT(
            int source,
            int type,
            uint id,
            int severity,
            int length,
            sbyte* message
        );

        [NativeName("alDebugMessageInsertEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
        static abstract void DebugMessageInsertEXT(
            Constant<int, ALEnum, DebugSourceEXT> source,
            Constant<int, ALEnum, DebugTypeEXT> type,
            uint id,
            Constant<int, ALEnum, DebugSeverityEXT> severity,
            int length,
            Ref<sbyte> message
        );

        [NativeName("alDebugMessageInsertEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
        static abstract void DebugMessageInsertEXT(
            Constant<int, ALEnum, DebugSourceEXT> source,
            Constant<int, ALEnum, DebugTypeEXT> type,
            uint id,
            Constant<int, ALEnum, DebugSeverityEXT> severity,
            sbyte message
        );

        [NativeName("alDeferUpdatesDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_deferred_updates"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_deferred_updates"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alDeferUpdatesDirectSOFT")]
        static abstract void DeferUpdatesDirectSOFT(ContextHandle context);

        [NativeName("alDeferUpdatesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
        [NativeFunction("openal", EntryPoint = "alDeferUpdatesSOFT")]
        static abstract void DeferUpdatesSOFT();

        [NativeName("alDeleteAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
        static abstract void DeleteAuxiliaryEffectSlot(uint effectslots);

        [NativeName("alDeleteAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
        static abstract void DeleteAuxiliaryEffectSlots(int n, uint* effectslots);

        [NativeName("alDeleteAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
        static abstract void DeleteAuxiliaryEffectSlots(int n, Ref<uint> effectslots);

        [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
        static abstract void DeleteAuxiliaryEffectSlotsDirect(
            ContextHandle context,
            int n,
            uint* effectslots
        );

        [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
        static abstract void DeleteAuxiliaryEffectSlotsDirect(
            ContextHandle context,
            int n,
            Ref<uint> effectslots
        );

        [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
        static abstract void DeleteAuxiliaryEffectSlotsDirect(
            ContextHandle context,
            uint effectslots
        );

        [NativeName("alDeleteBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffer(uint buffers);

        [NativeName("alDeleteBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffers(int n, uint* buffers);

        [NativeName("alDeleteBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffers(int n, Ref<uint> buffers);

        [NativeName("alDeleteBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
        static abstract void DeleteBuffersDirect(ContextHandle context, int n, uint* buffers);

        [NativeName("alDeleteBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
        static abstract void DeleteBuffersDirect(ContextHandle context, int n, Ref<uint> buffers);

        [NativeName("alDeleteEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
        static abstract void DeleteEffect(uint effects);

        [NativeName("alDeleteEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
        static abstract void DeleteEffects(int n, uint* effects);

        [NativeName("alDeleteEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
        static abstract void DeleteEffects(int n, Ref<uint> effects);

        [NativeName("alDeleteEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
        static abstract void DeleteEffectsDirect(ContextHandle context, int n, uint* effects);

        [NativeName("alDeleteEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
        static abstract void DeleteEffectsDirect(ContextHandle context, int n, Ref<uint> effects);

        [NativeName("alDeleteEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
        static abstract void DeleteEffectsDirect(ContextHandle context, uint effects);

        [NativeName("alDeleteFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
        static abstract void DeleteFilter(uint filters);

        [NativeName("alDeleteFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
        static abstract void DeleteFilters(int n, uint* filters);

        [NativeName("alDeleteFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
        static abstract void DeleteFilters(int n, Ref<uint> filters);

        [NativeName("alDeleteFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
        static abstract void DeleteFiltersDirect(ContextHandle context, int n, uint* filters);

        [NativeName("alDeleteFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
        static abstract void DeleteFiltersDirect(ContextHandle context, int n, Ref<uint> filters);

        [NativeName("alDeleteFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
        static abstract void DeleteFiltersDirect(ContextHandle context, uint filters);

        [NativeName("alDeleteSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSource(uint sources);

        [NativeName("alDeleteSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSources(int n, uint* sources);

        [NativeName("alDeleteSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSources(int n, Ref<uint> sources);

        [NativeName("alDeleteSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
        static abstract void DeleteSourcesDirect(ContextHandle context, int n, uint* sources);

        [NativeName("alDeleteSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
        static abstract void DeleteSourcesDirect(ContextHandle context, int n, Ref<uint> sources);

        [NativeName("alDeleteSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
        static abstract void DeleteSourcesDirect(ContextHandle context, uint sources);

        [NativeName("alDisable")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        static abstract void Disable(int capability);

        [NativeName("alDisable")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        static abstract void Disable(Constant<int, ALEnum, EnableCap> capability);

        [NativeName("alDisableDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDisableDirect")]
        static abstract void DisableDirect(ContextHandle context, int capability);

        [NativeName("alDisableDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDisableDirect")]
        static abstract void DisableDirect(
            ContextHandle context,
            Constant<int, ALEnum, EnableCap> capability
        );

        [NativeName("alDistanceModel")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        static abstract void DistanceModel(int distanceModel);

        [NativeName("alDistanceModel")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        static abstract void DistanceModel(Constant<int, ALEnum, DistanceModel> distanceModel);

        [NativeName("alDistanceModelDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
        static abstract void DistanceModelDirect(ContextHandle context, int distanceModel);

        [NativeName("alDistanceModelDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
        static abstract void DistanceModelDirect(
            ContextHandle context,
            Constant<int, ALEnum, DistanceModel> distanceModel
        );

        [NativeName("alDopplerFactor")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
        static abstract void DopplerFactor(float value);

        [NativeName("alDopplerFactorDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDopplerFactorDirect")]
        static abstract void DopplerFactorDirect(ContextHandle context, float value);

        [NativeName("alDopplerVelocity")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
        static abstract void DopplerVelocity(float value);

        [NativeName("alEffectf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectf")]
        static abstract void Effect(uint effect, int param1, float flValue);

        [NativeName("alEffectf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectf")]
        static abstract void Effect(
            uint effect,
            Constant<int, ALEnum, EffectFloat> param1,
            float flValue
        );

        [NativeName("alEffectfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            uint effect,
            int param2,
            float flValue
        );

        [NativeName("alEffectfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            uint effect,
            Constant<int, ALEnum, EffectFloat> param2,
            float flValue
        );

        [NativeName("alEffectfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectfv")]
        static abstract void Effect(uint effect, int param1, float* pflValues);

        [NativeName("alEffectfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectfv")]
        static abstract void Effect(
            uint effect,
            Constant<int, ALEnum, EffectFloat> param1,
            Ref<float> pflValues
        );

        [NativeName("alEffectfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            uint effect,
            int param2,
            float* pflValues
        );

        [NativeName("alEffectfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            uint effect,
            Constant<int, ALEnum, EffectFloat> param2,
            Ref<float> pflValues
        );

        [NativeName("alEffecti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffecti")]
        static abstract void Effect(uint effect, int param1, int iValue);

        [NativeName("alEffecti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffecti")]
        static abstract void Effect(
            uint effect,
            Constant<int, ALEnum, EffectInteger> param1,
            int iValue
        );

        [NativeName("alEffectiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            uint effect,
            int param2,
            int iValue
        );

        [NativeName("alEffectiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            uint effect,
            Constant<int, ALEnum, EffectInteger> param2,
            int iValue
        );

        [NativeName("alEffectiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectiv")]
        static abstract void Effect(uint effect, int param1, int* piValues);

        [NativeName("alEffectiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectiv")]
        static abstract void Effect(
            uint effect,
            Constant<int, ALEnum, EffectInteger> param1,
            Ref<int> piValues
        );

        [NativeName("alEffectivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            uint effect,
            int param2,
            int* piValues
        );

        [NativeName("alEffectivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            uint effect,
            Constant<int, ALEnum, EffectInteger> param2,
            Ref<int> piValues
        );

        [NativeName("alEnable")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        static abstract void Enable(int capability);

        [NativeName("alEnable")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        static abstract void Enable(Constant<int, ALEnum, EnableCap> capability);

        [NativeName("alEnableDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alEnableDirect")]
        static abstract void EnableDirect(ContextHandle context, int capability);

        [NativeName("alEnableDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alEnableDirect")]
        static abstract void EnableDirect(
            ContextHandle context,
            Constant<int, ALEnum, EnableCap> capability
        );

        [NativeName("alEventCallbackDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alEventCallbackDirectSOFT")]
        static abstract void EventCallbackDirectSOFT(
            ContextHandle context,
            EventProcSOFT callback,
            void* userParam
        );

        [NativeName("alEventCallbackDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alEventCallbackDirectSOFT")]
        static abstract void EventCallbackDirectSOFT(
            ContextHandle context,
            EventProcSOFT callback,
            Ref userParam
        );

        [NativeName("alEventCallbackSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
        static abstract void EventCallbackSOFT(EventProcSOFT callback, void* userParam);

        [NativeName("alEventCallbackSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
        static abstract void EventCallbackSOFT(EventProcSOFT callback, Ref userParam);

        [NativeName("alEventControlDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
        static abstract void EventControlDirectSOFT(
            ContextHandle context,
            int count,
            int* types,
            sbyte enable
        );

        [NativeName("alEventControlDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
        static abstract void EventControlDirectSOFT(
            ContextHandle context,
            int count,
            Ref<int> types,
            MaybeBool<sbyte> enable
        );

        [NativeName("alEventControlDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
        static abstract void EventControlDirectSOFT(
            ContextHandle context,
            int types,
            MaybeBool<sbyte> enable
        );

        [NativeName("alEventControlSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
        static abstract void EventControlSOFT(int count, int* types, sbyte enable);

        [NativeName("alEventControlSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
        static abstract void EventControlSOFT(int count, Ref<int> types, MaybeBool<sbyte> enable);

        [NativeName("alEventControlSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
        static abstract void EventControlSOFT(int types, MaybeBool<sbyte> enable);

        [NativeName("alFilterf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilterf")]
        static abstract void Filter(uint filter, int param1, float flValue);

        [NativeName("alFilterf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilterf")]
        static abstract void Filter(
            uint filter,
            Constant<int, ALEnum, FilterFloat> param1,
            float flValue
        );

        [NativeName("alFilterfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            uint filter,
            int param2,
            float flValue
        );

        [NativeName("alFilterfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            uint filter,
            Constant<int, ALEnum, FilterFloat> param2,
            float flValue
        );

        [NativeName("alFilterfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilterfv")]
        static abstract void Filter(uint filter, int param1, float* pflValues);

        [NativeName("alFilterfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilterfv")]
        static abstract void Filter(
            uint filter,
            Constant<int, ALEnum, FilterFloat> param1,
            Ref<float> pflValues
        );

        [NativeName("alFilterfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            uint filter,
            int param2,
            float* pflValues
        );

        [NativeName("alFilterfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            uint filter,
            Constant<int, ALEnum, FilterFloat> param2,
            Ref<float> pflValues
        );

        [NativeName("alFilteri")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilteri")]
        static abstract void Filter(uint filter, int param1, int iValue);

        [NativeName("alFilteri")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilteri")]
        static abstract void Filter(
            uint filter,
            Constant<int, ALEnum, FilterInteger> param1,
            int iValue
        );

        [NativeName("alFilteriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            uint filter,
            int param2,
            int iValue
        );

        [NativeName("alFilteriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            uint filter,
            Constant<int, ALEnum, FilterInteger> param2,
            int iValue
        );

        [NativeName("alFilteriv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilteriv")]
        static abstract void Filter(uint filter, int param1, int* piValues);

        [NativeName("alFilteriv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilteriv")]
        static abstract void Filter(
            uint filter,
            Constant<int, ALEnum, FilterInteger> param1,
            Ref<int> piValues
        );

        [NativeName("alFilterivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            uint filter,
            int param2,
            int* piValues
        );

        [NativeName("alFilterivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            uint filter,
            Constant<int, ALEnum, FilterInteger> param2,
            Ref<int> piValues
        );

        [NativeName("alGenAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
        static abstract uint GenAuxiliaryEffectSlot();

        [NativeName("alGenAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
        static abstract void GenAuxiliaryEffectSlots(int n, uint* effectslots);

        [NativeName("alGenAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
        static abstract void GenAuxiliaryEffectSlots(int n, Ref<uint> effectslots);

        [NativeName("alGenAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
        static abstract void GenAuxiliaryEffectSlotsDirect(
            ContextHandle context,
            int n,
            uint* effectslots
        );

        [NativeName("alGenAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
        static abstract void GenAuxiliaryEffectSlotsDirect(
            ContextHandle context,
            int n,
            Ref<uint> effectslots
        );

        [NativeName("alGenAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
        static abstract uint GenAuxiliaryEffectSlotsDirect(ContextHandle context);

        [NativeName("alGenBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract uint GenBuffer();

        [NativeName("alGenBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract void GenBuffers(int n, uint* buffers);

        [NativeName("alGenBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract void GenBuffers(int n, Ref<uint> buffers);

        [NativeName("alGenBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
        static abstract void GenBuffersDirect(ContextHandle context, int n, uint* buffers);

        [NativeName("alGenBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
        static abstract void GenBuffersDirect(ContextHandle context, int n, Ref<uint> buffers);

        [NativeName("alGenEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenEffects")]
        static abstract uint GenEffect();

        [NativeName("alGenEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenEffects")]
        static abstract void GenEffects(int n, uint* effects);

        [NativeName("alGenEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenEffects")]
        static abstract void GenEffects(int n, Ref<uint> effects);

        [NativeName("alGenEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
        static abstract void GenEffectsDirect(ContextHandle context, int n, uint* effects);

        [NativeName("alGenEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
        static abstract void GenEffectsDirect(ContextHandle context, int n, Ref<uint> effects);

        [NativeName("alGenEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
        static abstract uint GenEffectsDirect(ContextHandle context);

        [NativeName("alGenFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenFilters")]
        static abstract uint GenFilter();

        [NativeName("alGenFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenFilters")]
        static abstract void GenFilters(int n, uint* filters);

        [NativeName("alGenFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenFilters")]
        static abstract void GenFilters(int n, Ref<uint> filters);

        [NativeName("alGenFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
        static abstract void GenFiltersDirect(ContextHandle context, int n, uint* filters);

        [NativeName("alGenFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
        static abstract void GenFiltersDirect(ContextHandle context, int n, Ref<uint> filters);

        [NativeName("alGenFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
        static abstract uint GenFiltersDirect(ContextHandle context);

        [NativeName("alGenSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract uint GenSource();

        [NativeName("alGenSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract void GenSources(int n, uint* sources);

        [NativeName("alGenSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract void GenSources(int n, Ref<uint> sources);

        [NativeName("alGenSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
        static abstract void GenSourcesDirect(ContextHandle context, int n, uint* sources);

        [NativeName("alGenSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
        static abstract void GenSourcesDirect(ContextHandle context, int n, Ref<uint> sources);

        [NativeName("alGenSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
        static abstract uint GenSourcesDirect(ContextHandle context);

        [NativeName("alGetAuxiliaryEffectSlotf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
        static abstract void GetAuxiliaryEffectSlotf(uint effectslot, int param1, float* flValue);

        [NativeName("alGetAuxiliaryEffectSlotf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
        static abstract void GetAuxiliaryEffectSlotf(
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param1,
            Ref<float> flValue
        );

        [NativeName("alGetAuxiliaryEffectSlotfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
        static abstract void GetAuxiliaryEffectSlotfDirect(
            ContextHandle context,
            uint effectslot,
            int param2,
            float* pflValue
        );

        [NativeName("alGetAuxiliaryEffectSlotfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
        static abstract void GetAuxiliaryEffectSlotfDirect(
            ContextHandle context,
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param2,
            Ref<float> pflValue
        );

        [NativeName("alGetAuxiliaryEffectSlotfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
        static abstract void GetAuxiliaryEffectSlotfv(
            uint effectslot,
            int param1,
            float* pflValues
        );

        [NativeName("alGetAuxiliaryEffectSlotfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
        static abstract void GetAuxiliaryEffectSlotfv(
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param1,
            Ref<float> pflValues
        );

        [NativeName("alGetAuxiliaryEffectSlotfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
        static abstract void GetAuxiliaryEffectSlotfvDirect(
            ContextHandle context,
            uint effectslot,
            int param2,
            float* pflValues
        );

        [NativeName("alGetAuxiliaryEffectSlotfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
        static abstract void GetAuxiliaryEffectSlotfvDirect(
            ContextHandle context,
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param2,
            Ref<float> pflValues
        );

        [NativeName("alGetAuxiliaryEffectSloti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
        static abstract void GetAuxiliaryEffectSloti(uint effectslot, int param1, int* iValue);

        [NativeName("alGetAuxiliaryEffectSloti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
        static abstract void GetAuxiliaryEffectSloti(
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param1,
            Ref<int> iValue
        );

        [NativeName("alGetAuxiliaryEffectSlotiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
        static abstract void GetAuxiliaryEffectSlotiDirect(
            ContextHandle context,
            uint effectslot,
            int param2,
            int* piValue
        );

        [NativeName("alGetAuxiliaryEffectSlotiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
        static abstract void GetAuxiliaryEffectSlotiDirect(
            ContextHandle context,
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param2,
            Ref<int> piValue
        );

        [NativeName("alGetAuxiliaryEffectSlotiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
        static abstract void GetAuxiliaryEffectSlotiv(uint effectslot, int param1, int* piValues);

        [NativeName("alGetAuxiliaryEffectSlotiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
        static abstract void GetAuxiliaryEffectSlotiv(
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param1,
            Ref<int> piValues
        );

        [NativeName("alGetAuxiliaryEffectSlotivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
        static abstract void GetAuxiliaryEffectSlotivDirect(
            ContextHandle context,
            uint effectslot,
            int param2,
            int* piValues
        );

        [NativeName("alGetAuxiliaryEffectSlotivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
        static abstract void GetAuxiliaryEffectSlotivDirect(
            ContextHandle context,
            uint effectslot,
            Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param2,
            Ref<int> piValues
        );

        [NativeName("alGetBoolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        static abstract sbyte GetBoolean(int param0);

        [NativeName("alGetBoolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        static abstract MaybeBool<sbyte> GetBoolean(Constant<int, ALEnum, BooleanPName> param0);

        [NativeName("alGetBooleanDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
        static abstract sbyte GetBooleanDirect(ContextHandle context, int param1);

        [NativeName("alGetBooleanDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
        static abstract MaybeBool<sbyte> GetBooleanDirect(
            ContextHandle context,
            Constant<int, ALEnum, BooleanPName> param1
        );

        [NativeName("alGetBooleanv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        static abstract void GetBoolean(int param0, sbyte* values);

        [NativeName("alGetBooleanv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        static abstract void GetBoolean(
            Constant<int, ALEnum, BooleanPName> param0,
            Ref<sbyte> values
        );

        [NativeName("alGetBooleanvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
        static abstract void GetBooleanDirect(ContextHandle context, int param1, sbyte* values);

        [NativeName("alGetBooleanvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
        static abstract void GetBooleanDirect(
            ContextHandle context,
            Constant<int, ALEnum, BooleanPName> param1,
            Ref<sbyte> values
        );

        [NativeName("alGetBuffer3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        static abstract void GetBuffer3(
            uint buffer,
            int param1,
            float* value1,
            float* value2,
            float* value3
        );

        [NativeName("alGetBuffer3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        static abstract void GetBuffer3(
            uint buffer,
            int param1,
            Ref<float> value1,
            Ref<float> value2,
            Ref<float> value3
        );

        [NativeName("alGetBuffer3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
        static abstract void GetBuffer3Direct(
            ContextHandle context,
            uint buffer,
            int param2,
            float* value1,
            float* value2,
            float* value3
        );

        [NativeName("alGetBuffer3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
        static abstract void GetBuffer3Direct(
            ContextHandle context,
            uint buffer,
            int param2,
            Ref<float> value1,
            Ref<float> value2,
            Ref<float> value3
        );

        [NativeName("alGetBuffer3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        static abstract void GetBuffer3(
            uint buffer,
            int param1,
            int* value1,
            int* value2,
            int* value3
        );

        [NativeName("alGetBuffer3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        static abstract void GetBuffer3(
            uint buffer,
            int param1,
            Ref<int> value1,
            Ref<int> value2,
            Ref<int> value3
        );

        [NativeName("alGetBuffer3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
        static abstract void GetBuffer3Direct(
            ContextHandle context,
            uint buffer,
            int param2,
            int* value1,
            int* value2,
            int* value3
        );

        [NativeName("alGetBuffer3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
        static abstract void GetBuffer3Direct(
            ContextHandle context,
            uint buffer,
            int param2,
            Ref<int> value1,
            Ref<int> value2,
            Ref<int> value3
        );

        [NativeName("alGetBuffer3PtrDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrDirectSOFT")]
        static abstract void GetBuffer3PtrDirectSOFT(
            ContextHandle context,
            uint buffer,
            int param2,
            void** ptr0,
            void** ptr1,
            void** ptr2
        );

        [NativeName("alGetBuffer3PtrDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrDirectSOFT")]
        static abstract void GetBuffer3PtrDirectSOFT(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, BufferPointerSOFT> param2,
            Ref2D ptr0,
            Ref2D ptr1,
            Ref2D ptr2
        );

        [NativeName("alGetBuffer3PtrSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
        static abstract void GetBuffer3PtrSOFT(
            uint buffer,
            int param1,
            void** ptr0,
            void** ptr1,
            void** ptr2
        );

        [NativeName("alGetBuffer3PtrSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
        static abstract void GetBuffer3PtrSOFT(
            uint buffer,
            Constant<int, ALEnum, BufferPointerSOFT> param1,
            Ref2D ptr0,
            Ref2D ptr1,
            Ref2D ptr2
        );

        [NativeName("alGetBufferf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        static abstract void GetBufferf(uint buffer, int param1, float* value);

        [NativeName("alGetBufferf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        static abstract void GetBufferf(
            uint buffer,
            Constant<int, ALEnum, BufferFloat> param1,
            Ref<float> value
        );

        [NativeName("alGetBufferfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
        static abstract void GetBufferfDirect(
            ContextHandle context,
            uint buffer,
            int param2,
            float* value
        );

        [NativeName("alGetBufferfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
        static abstract void GetBufferfDirect(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, BufferFloat> param2,
            Ref<float> value
        );

        [NativeName("alGetBufferfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        static abstract void GetBufferfv(uint buffer, int param1, float* values);

        [NativeName("alGetBufferfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        static abstract void GetBufferfv(
            uint buffer,
            Constant<int, ALEnum, BufferFloat> param1,
            Ref<float> values
        );

        [NativeName("alGetBufferfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
        static abstract void GetBufferfvDirect(
            ContextHandle context,
            uint buffer,
            int param2,
            float* values
        );

        [NativeName("alGetBufferfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
        static abstract void GetBufferfvDirect(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, BufferFloat> param2,
            Ref<float> values
        );

        [NativeName("alGetBufferi")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        static abstract void GetBufferi(uint buffer, int param1, int* value);

        [NativeName("alGetBufferi")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        static abstract void GetBufferi(
            uint buffer,
            Constant<int, ALEnum, BufferInteger> param1,
            Ref<int> value
        );

        [NativeName("alGetBufferiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
        static abstract void GetBufferiDirect(
            ContextHandle context,
            uint buffer,
            int param2,
            int* value
        );

        [NativeName("alGetBufferiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
        static abstract void GetBufferiDirect(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, BufferInteger> param2,
            Ref<int> value
        );

        [NativeName("alGetBufferiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        static abstract void GetBufferiv(uint buffer, int param1, int* values);

        [NativeName("alGetBufferiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        static abstract void GetBufferiv(
            uint buffer,
            Constant<int, ALEnum, BufferInteger> param1,
            Ref<int> values
        );

        [NativeName("alGetBufferivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
        static abstract void GetBufferivDirect(
            ContextHandle context,
            uint buffer,
            int param2,
            int* values
        );

        [NativeName("alGetBufferivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
        static abstract void GetBufferivDirect(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, BufferInteger> param2,
            Ref<int> values
        );

        [NativeName("alGetBufferPtrDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrDirectSOFT")]
        static abstract void GetBufferPtrDirectSOFT(
            ContextHandle context,
            uint buffer,
            int param2,
            void** ptr
        );

        [NativeName("alGetBufferPtrDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrDirectSOFT")]
        static abstract void GetBufferPtrDirectSOFT(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, BufferPointerSOFT> param2,
            Ref2D ptr
        );

        [NativeName("alGetBufferPtrSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
        static abstract void GetBufferPtrSOFT(uint buffer, int param1, void** ptr);

        [NativeName("alGetBufferPtrSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
        static abstract void GetBufferPtrSOFT(
            uint buffer,
            Constant<int, ALEnum, BufferPointerSOFT> param1,
            Ref2D ptr
        );

        [NativeName("alGetBufferPtrvDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrvDirectSOFT")]
        static abstract void GetBufferPtrvDirectSOFT(
            ContextHandle context,
            uint buffer,
            int param2,
            void** ptr
        );

        [NativeName("alGetBufferPtrvDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrvDirectSOFT")]
        static abstract void GetBufferPtrvDirectSOFT(
            ContextHandle context,
            uint buffer,
            Constant<int, ALEnum, BufferPointerSOFT> param2,
            Ref2D ptr
        );

        [NativeName("alGetBufferPtrvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
        static abstract void GetBufferPtrvSOFT(uint buffer, int param1, void** ptr);

        [NativeName("alGetBufferPtrvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
        static abstract void GetBufferPtrvSOFT(
            uint buffer,
            Constant<int, ALEnum, BufferPointerSOFT> param1,
            Ref2D ptr
        );

        [NativeName("alGetBufferSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
        static abstract void GetBufferSamplesSOFT(
            uint buffer,
            int offset,
            int samples,
            int channels,
            int type,
            void* data
        );

        [NativeName("alGetBufferSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
        static abstract void GetBufferSamplesSOFT(
            uint buffer,
            int offset,
            int samples,
            Constant<int, ALEnum, BufferChannelsSOFT> channels,
            Constant<int, ALEnum, SampleTypeSOFT> type,
            Ref data
        );

        [NativeName("alGetDebugMessageLogDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectEXT(
            ContextHandle context,
            uint count,
            int logBufSize,
            int* sources,
            int* types,
            uint* ids,
            int* severities,
            int* lengths,
            sbyte* logBuf
        );

        [NativeName("alGetDebugMessageLogDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectEXT(
            ContextHandle context,
            uint count,
            int logBufSize,
            Ref<int> sources,
            Ref<int> types,
            Ref<uint> ids,
            Ref<int> severities,
            Ref<int> lengths,
            Ref<sbyte> logBuf
        );

        [NativeName("alGetDebugMessageLogDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectEXT(
            ContextHandle context,
            uint count,
            int logBufSize,
            Ref<ALEnum> sources,
            Ref<ALEnum> types,
            Ref<uint> ids,
            Ref<ALEnum> severities,
            Ref<int> lengths,
            Ref<sbyte> logBuf
        );

        [NativeName("alGetDebugMessageLogDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectEXT(
            ContextHandle context,
            uint count,
            int logBufSize,
            Ref<DebugSourceEXT> sources,
            Ref<DebugTypeEXT> types,
            Ref<uint> ids,
            Ref<DebugSeverityEXT> severities,
            Ref<int> lengths,
            Ref<sbyte> logBuf
        );

        [NativeName("alGetDebugMessageLogEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogEXT(
            uint count,
            int logBufSize,
            int* sources,
            int* types,
            uint* ids,
            int* severities,
            int* lengths,
            sbyte* logBuf
        );

        [NativeName("alGetDebugMessageLogEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogEXT(
            uint count,
            int logBufSize,
            Ref<int> sources,
            Ref<int> types,
            Ref<uint> ids,
            Ref<int> severities,
            Ref<int> lengths,
            Ref<sbyte> logBuf
        );

        [NativeName("alGetDebugMessageLogEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogEXT(
            uint count,
            int logBufSize,
            Ref<ALEnum> sources,
            Ref<ALEnum> types,
            Ref<uint> ids,
            Ref<ALEnum> severities,
            Ref<int> lengths,
            Ref<sbyte> logBuf
        );

        [NativeName("alGetDebugMessageLogEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogEXT(
            uint count,
            int logBufSize,
            Ref<DebugSourceEXT> sources,
            Ref<DebugTypeEXT> types,
            Ref<uint> ids,
            Ref<DebugSeverityEXT> severities,
            Ref<int> lengths,
            Ref<sbyte> logBuf
        );

        [NativeName("alGetDouble")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        static abstract double GetDouble(int param0);

        [NativeName("alGetDouble")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        static abstract double GetDouble(Constant<int, ALEnum, GetPName> param0);

        [NativeName("alGetDoubleDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
        static abstract double GetDoubleDirect(ContextHandle context, int param1);

        [NativeName("alGetDoubleDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
        static abstract double GetDoubleDirect(
            ContextHandle context,
            Constant<int, ALEnum, GetPName> param1
        );

        [NativeName("alGetDoublev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        static abstract void GetDouble(int param0, double* values);

        [NativeName("alGetDoublev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        static abstract void GetDouble(Constant<int, ALEnum, GetPName> param0, Ref<double> values);

        [NativeName("alGetDoublevDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
        static abstract void GetDoubleDirect(ContextHandle context, int param1, double* values);

        [NativeName("alGetDoublevDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
        static abstract void GetDoubleDirect(
            ContextHandle context,
            Constant<int, ALEnum, GetPName> param1,
            Ref<double> values
        );

        [NativeName("alGetEffectf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectf")]
        static abstract void GetEffectf(uint effect, int param1, float* flValue);

        [NativeName("alGetEffectf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectf")]
        static abstract void GetEffectf(
            uint effect,
            Constant<int, ALEnum, EffectFloat> param1,
            Ref<float> flValue
        );

        [NativeName("alGetEffectfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
        static abstract void GetEffectfDirect(
            ContextHandle context,
            uint effect,
            int param2,
            float* pflValue
        );

        [NativeName("alGetEffectfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
        static abstract void GetEffectfDirect(
            ContextHandle context,
            uint effect,
            Constant<int, ALEnum, EffectFloat> param2,
            Ref<float> pflValue
        );

        [NativeName("alGetEffectfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
        static abstract void GetEffectfv(uint effect, int param1, float* pflValues);

        [NativeName("alGetEffectfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
        static abstract void GetEffectfv(
            uint effect,
            Constant<int, ALEnum, EffectFloat> param1,
            Ref<float> pflValues
        );

        [NativeName("alGetEffectfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
        static abstract void GetEffectfvDirect(
            ContextHandle context,
            uint effect,
            int param2,
            float* pflValues
        );

        [NativeName("alGetEffectfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
        static abstract void GetEffectfvDirect(
            ContextHandle context,
            uint effect,
            Constant<int, ALEnum, EffectFloat> param2,
            Ref<float> pflValues
        );

        [NativeName("alGetEffecti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffecti")]
        static abstract void GetEffecti(uint effect, int param1, int* iValue);

        [NativeName("alGetEffecti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffecti")]
        static abstract void GetEffecti(
            uint effect,
            Constant<int, ALEnum, EffectInteger> param1,
            Ref<int> iValue
        );

        [NativeName("alGetEffectiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
        static abstract void GetEffectiDirect(
            ContextHandle context,
            uint effect,
            int param2,
            int* piValue
        );

        [NativeName("alGetEffectiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
        static abstract void GetEffectiDirect(
            ContextHandle context,
            uint effect,
            Constant<int, ALEnum, EffectInteger> param2,
            Ref<int> piValue
        );

        [NativeName("alGetEffectiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
        static abstract void GetEffectiv(uint effect, int param1, int* piValues);

        [NativeName("alGetEffectiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
        static abstract void GetEffectiv(
            uint effect,
            Constant<int, ALEnum, EffectInteger> param1,
            Ref<int> piValues
        );

        [NativeName("alGetEffectivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
        static abstract void GetEffectivDirect(
            ContextHandle context,
            uint effect,
            int param2,
            int* piValues
        );

        [NativeName("alGetEffectivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
        static abstract void GetEffectivDirect(
            ContextHandle context,
            uint effect,
            Constant<int, ALEnum, EffectInteger> param2,
            Ref<int> piValues
        );

        [NativeName("alGetEnumValue")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        static abstract int GetEnumValue(sbyte* ename);

        [NativeName("alGetEnumValue")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        static abstract int GetEnumValue(Ref<sbyte> ename);

        [NativeName("alGetEnumValueDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
        static abstract int GetEnumValueDirect(ContextHandle context, sbyte* ename);

        [NativeName("alGetEnumValueDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
        static abstract int GetEnumValueDirect(ContextHandle context, Ref<sbyte> ename);

        [NativeName("alGetError")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        static abstract Constant<int, ErrorCode> GetError();

        [NativeName("alGetErrorDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
        static abstract Constant<int, ErrorCode> GetErrorDirect(ContextHandle context);

        [NativeName("alGetErrorDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
        static abstract int GetErrorDirectRawDirect(ContextHandle context);

        [NativeName("alGetError")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        static abstract int GetErrorRaw();

        [NativeName("alGetFilterf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilterf")]
        static abstract void GetFilterf(uint filter, int param1, float* flValue);

        [NativeName("alGetFilterf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilterf")]
        static abstract void GetFilterf(
            uint filter,
            Constant<int, ALEnum, FilterFloat> param1,
            Ref<float> flValue
        );

        [NativeName("alGetFilterfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
        static abstract void GetFilterfDirect(
            ContextHandle context,
            uint filter,
            int param2,
            float* pflValue
        );

        [NativeName("alGetFilterfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
        static abstract void GetFilterfDirect(
            ContextHandle context,
            uint filter,
            Constant<int, ALEnum, FilterFloat> param2,
            Ref<float> pflValue
        );

        [NativeName("alGetFilterfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
        static abstract void GetFilterfv(uint filter, int param1, float* pflValues);

        [NativeName("alGetFilterfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
        static abstract void GetFilterfv(
            uint filter,
            Constant<int, ALEnum, FilterFloat> param1,
            Ref<float> pflValues
        );

        [NativeName("alGetFilterfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
        static abstract void GetFilterfvDirect(
            ContextHandle context,
            uint filter,
            int param2,
            float* pflValues
        );

        [NativeName("alGetFilterfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
        static abstract void GetFilterfvDirect(
            ContextHandle context,
            uint filter,
            Constant<int, ALEnum, FilterFloat> param2,
            Ref<float> pflValues
        );

        [NativeName("alGetFilteri")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilteri")]
        static abstract void GetFilteri(uint filter, int param1, int* iValue);

        [NativeName("alGetFilteri")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilteri")]
        static abstract void GetFilteri(
            uint filter,
            Constant<int, ALEnum, FilterInteger> param1,
            Ref<int> iValue
        );

        [NativeName("alGetFilteriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
        static abstract void GetFilteriDirect(
            ContextHandle context,
            uint filter,
            int param2,
            int* piValue
        );

        [NativeName("alGetFilteriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
        static abstract void GetFilteriDirect(
            ContextHandle context,
            uint filter,
            Constant<int, ALEnum, FilterInteger> param2,
            Ref<int> piValue
        );

        [NativeName("alGetFilteriv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
        static abstract void GetFilteriv(uint filter, int param1, int* piValues);

        [NativeName("alGetFilteriv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
        static abstract void GetFilteriv(
            uint filter,
            Constant<int, ALEnum, FilterInteger> param1,
            Ref<int> piValues
        );

        [NativeName("alGetFilterivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
        static abstract void GetFilterivDirect(
            ContextHandle context,
            uint filter,
            int param2,
            int* piValues
        );

        [NativeName("alGetFilterivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
        static abstract void GetFilterivDirect(
            ContextHandle context,
            uint filter,
            Constant<int, ALEnum, FilterInteger> param2,
            Ref<int> piValues
        );

        [NativeName("alGetFloat")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        static abstract float GetFloat(int param0);

        [NativeName("alGetFloat")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        static abstract float GetFloat(Constant<int, ALEnum, FloatPName> param0);

        [NativeName("alGetFloatDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
        static abstract float GetFloatDirect(ContextHandle context, int param1);

        [NativeName("alGetFloatDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
        static abstract float GetFloatDirect(
            ContextHandle context,
            Constant<int, ALEnum, FloatPName> param1
        );

        [NativeName("alGetFloatv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        static abstract void GetFloat(int param0, float* values);

        [NativeName("alGetFloatv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        static abstract void GetFloat(Constant<int, ALEnum, GetPName> param0, Ref<float> values);

        [NativeName("alGetFloatvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
        static abstract void GetFloatDirect(ContextHandle context, int param1, float* values);

        [NativeName("alGetFloatvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
        static abstract void GetFloatDirect(
            ContextHandle context,
            Constant<int, ALEnum, GetPName> param1,
            Ref<float> values
        );

        [NativeName("alGetInteger")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        static abstract int GetInteger(int param0);

        [NativeName("alGetInteger")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        static abstract int GetInteger(Constant<int, ALEnum, IntegerPName> param0);

        [NativeName("alGetIntegerDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
        static abstract int GetIntegerDirect(ContextHandle context, int param1);

        [NativeName("alGetIntegerDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
        static abstract int GetIntegerDirect(
            ContextHandle context,
            Constant<int, ALEnum, IntegerPName> param1
        );

        [NativeName("alGetIntegerv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        static abstract void GetInteger(int param0, int* values);

        [NativeName("alGetIntegerv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        static abstract void GetInteger(
            Constant<int, ALEnum, IntegerPName> param0,
            Ref<int> values
        );

        [NativeName("alGetIntegervDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
        static abstract void GetIntegerDirect(ContextHandle context, int param1, int* values);

        [NativeName("alGetIntegervDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
        static abstract void GetIntegerDirect(
            ContextHandle context,
            Constant<int, ALEnum, IntegerPName> param1,
            Ref<int> values
        );

        [NativeName("alGetListener3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        static abstract void GetListener3(int param0, float* value1, float* value2, float* value3);

        [NativeName("alGetListener3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        static abstract void GetListener3(
            Constant<int, ALEnum, ListenerFloat3> param0,
            Ref<float> value1,
            Ref<float> value2,
            Ref<float> value3
        );

        [NativeName("alGetListener3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
        static abstract void GetListener3Direct(
            ContextHandle context,
            int param1,
            float* value1,
            float* value2,
            float* value3
        );

        [NativeName("alGetListener3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
        static abstract void GetListener3Direct(
            ContextHandle context,
            Constant<int, ALEnum, ListenerFloat3> param1,
            Ref<float> value1,
            Ref<float> value2,
            Ref<float> value3
        );

        [NativeName("alGetListener3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        static abstract void GetListener3(int param0, int* value1, int* value2, int* value3);

        [NativeName("alGetListener3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        static abstract void GetListener3(
            Constant<int, ALEnum, ListenerInteger3> param0,
            Ref<int> value1,
            Ref<int> value2,
            Ref<int> value3
        );

        [NativeName("alGetListener3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
        static abstract void GetListener3Direct(
            ContextHandle context,
            int param1,
            int* value1,
            int* value2,
            int* value3
        );

        [NativeName("alGetListener3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
        static abstract void GetListener3Direct(
            ContextHandle context,
            Constant<int, ALEnum, ListenerInteger3> param1,
            Ref<int> value1,
            Ref<int> value2,
            Ref<int> value3
        );

        [NativeName("alGetListenerf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        static abstract void GetListenerf(int param0, float* value);

        [NativeName("alGetListenerf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        static abstract void GetListenerf(
            Constant<int, ALEnum, ListenerFloat> param0,
            Ref<float> value
        );

        [NativeName("alGetListenerfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
        static abstract void GetListenerfDirect(ContextHandle context, int param1, float* value);

        [NativeName("alGetListenerfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
        static abstract void GetListenerfDirect(
            ContextHandle context,
            Constant<int, ALEnum, ListenerFloat> param1,
            Ref<float> value
        );

        [NativeName("alGetListenerfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        static abstract void GetListenerfv(int param0, float* values);

        [NativeName("alGetListenerfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        static abstract void GetListenerfv(
            Constant<int, ALEnum, ListenerFloat> param0,
            Ref<float> values
        );

        [NativeName("alGetListenerfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
        static abstract void GetListenerfvDirect(ContextHandle context, int param1, float* values);

        [NativeName("alGetListenerfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
        static abstract void GetListenerfvDirect(
            ContextHandle context,
            Constant<int, ALEnum, ListenerFloat> param1,
            Ref<float> values
        );

        [NativeName("alGetListeneri")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract void GetListeneri(int param0, int* value);

        [NativeName("alGetListeneri")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract void GetListeneri(int param0, Ref<int> value);

        [NativeName("alGetListeneri")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract int GetListeneri();

        [NativeName("alGetListeneriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
        static abstract void GetListeneriDirect(ContextHandle context, int param1, int* value);

        [NativeName("alGetListeneriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
        static abstract void GetListeneriDirect(ContextHandle context, int param1, Ref<int> value);

        [NativeName("alGetListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract void GetListeneriv(int param0, int* values);

        [NativeName("alGetListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract void GetListeneriv(int param0, Ref<int> values);

        [NativeName("alGetListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract int GetListeneriv();

        [NativeName("alGetListenerivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
        static abstract void GetListenerivDirect(ContextHandle context, int param1, int* values);

        [NativeName("alGetListenerivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
        static abstract void GetListenerivDirect(
            ContextHandle context,
            int param1,
            Ref<int> values
        );

        [NativeName("alGetObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
        static abstract void GetObjectLabelDirectEXT(
            ContextHandle context,
            int identifier,
            uint name,
            int bufSize,
            int* length,
            sbyte* label
        );

        [NativeName("alGetObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
        static abstract void GetObjectLabelDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, ObjectIdentifier> identifier,
            uint name,
            int bufSize,
            Ref<int> length,
            Ref<sbyte> label
        );

        [NativeName("alGetObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
        static abstract sbyte GetObjectLabelDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, ObjectIdentifier> identifier,
            uint name,
            Ref<int> length
        );

        [NativeName("alGetObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
        static abstract void GetObjectLabelEXT(
            int identifier,
            uint name,
            int bufSize,
            int* length,
            sbyte* label
        );

        [NativeName("alGetObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
        static abstract void GetObjectLabelEXT(
            Constant<int, ALEnum, ObjectIdentifier> identifier,
            uint name,
            int bufSize,
            Ref<int> length,
            Ref<sbyte> label
        );

        [NativeName("alGetObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
        static abstract sbyte GetObjectLabelEXT(
            Constant<int, ALEnum, ObjectIdentifier> identifier,
            uint name,
            Ref<int> length
        );

        [NativeName("alGetPointerDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
        static abstract void* GetPointerDirectEXT(ContextHandle context, int pname);

        [NativeName("alGetPointerDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
        static abstract Ptr GetPointerDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, PointerPName> pname
        );

        [NativeName("alGetPointerDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointerDirectSOFT")]
        static abstract void* GetPointerDirectSOFT(ContextHandle context, int pname);

        [NativeName("alGetPointerDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointerDirectSOFT")]
        static abstract Ptr GetPointerDirectSOFT(
            ContextHandle context,
            Constant<int, ALEnum, PointerPName> pname
        );

        [NativeName("alGetPointerEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
        static abstract void* GetPointerEXT(int pname);

        [NativeName("alGetPointerEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
        static abstract Ptr GetPointerEXT(Constant<int, ALEnum, PointerPName> pname);

        [NativeName("alGetPointerSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
        static abstract void* GetPointerSOFT(int pname);

        [NativeName("alGetPointerSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
        static abstract Ptr GetPointerSOFT(Constant<int, ALEnum, PointerPName> pname);

        [NativeName("alGetPointervDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
        static abstract void GetPointerDirectEXT(ContextHandle context, int pname, void** values);

        [NativeName("alGetPointervDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
        static abstract void GetPointerDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, PointerPName> pname,
            Ref2D values
        );

        [NativeName("alGetPointervDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointervDirectSOFT")]
        static abstract void GetPointerDirectSOFT(ContextHandle context, int pname, void** values);

        [NativeName("alGetPointervDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_events"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointervDirectSOFT")]
        static abstract void GetPointerDirectSOFT(
            ContextHandle context,
            Constant<int, ALEnum, PointerPName> pname,
            Ref2D values
        );

        [NativeName("alGetPointervEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
        static abstract void GetPointerEXT(int pname, void** values);

        [NativeName("alGetPointervEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
        static abstract void GetPointerEXT(Constant<int, ALEnum, PointerPName> pname, Ref2D values);

        [NativeName("alGetPointervSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
        static abstract void GetPointerSOFT(int pname, void** values);

        [NativeName("alGetPointervSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
        static abstract void GetPointerSOFT(
            Constant<int, ALEnum, PointerPName> pname,
            Ref2D values
        );

        [NativeName("alGetProcAddress")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        static abstract void* GetProcAddress(sbyte* fname);

        [NativeName("alGetProcAddress")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        static abstract Ptr GetProcAddress(Ref<sbyte> fname);

        [NativeName("alGetProcAddressDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
        static abstract void* GetProcAddressDirect(ContextHandle context, sbyte* fname);

        [NativeName("alGetProcAddressDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
        static abstract Ptr GetProcAddressDirect(ContextHandle context, Ref<sbyte> fname);

        [NativeName("alGetSource3dDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3dDirectSOFT")]
        static abstract void GetSource3DirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            double* value1,
            double* value2,
            double* value3
        );

        [NativeName("alGetSource3dDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3dDirectSOFT")]
        static abstract void GetSource3DirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            Ref<double> value1,
            Ref<double> value2,
            Ref<double> value3
        );

        [NativeName("alGetSource3dSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
        static abstract void GetSource3SOFT(
            uint source,
            int param1,
            double* value1,
            double* value2,
            double* value3
        );

        [NativeName("alGetSource3dSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
        static abstract void GetSource3SOFT(
            uint source,
            int param1,
            Ref<double> value1,
            Ref<double> value2,
            Ref<double> value3
        );

        [NativeName("alGetSource3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        static abstract void GetSource3(
            uint source,
            int param1,
            float* value1,
            float* value2,
            float* value3
        );

        [NativeName("alGetSource3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        static abstract void GetSource3(
            uint source,
            Constant<int, ALEnum, SourceFloat3> param1,
            Ref<float> value1,
            Ref<float> value2,
            Ref<float> value3
        );

        [NativeName("alGetSource3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
        static abstract void GetSource3Direct(
            ContextHandle context,
            uint source,
            int param2,
            float* value1,
            float* value2,
            float* value3
        );

        [NativeName("alGetSource3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
        static abstract void GetSource3Direct(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceFloat3> param2,
            Ref<float> value1,
            Ref<float> value2,
            Ref<float> value3
        );

        [NativeName("alGetSource3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        static abstract void GetSource3(
            uint source,
            int param1,
            int* value1,
            int* value2,
            int* value3
        );

        [NativeName("alGetSource3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        static abstract void GetSource3(
            uint source,
            Constant<int, ALEnum, SourceInteger3> param1,
            Ref<int> value1,
            Ref<int> value2,
            Ref<int> value3
        );

        [NativeName("alGetSource3i64DirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3i64DirectSOFT")]
        static abstract void GetSource3DirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            nint* value1,
            nint* value2,
            nint* value3
        );

        [NativeName("alGetSource3i64DirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3i64DirectSOFT")]
        static abstract void GetSource3DirectSOFT(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger3> param2,
            Ref<nint> value1,
            Ref<nint> value2,
            Ref<nint> value3
        );

        [NativeName("alGetSource3i64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
        static abstract void GetSource3SOFT(
            uint source,
            int param1,
            nint* value1,
            nint* value2,
            nint* value3
        );

        [NativeName("alGetSource3i64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
        static abstract void GetSource3SOFT(
            uint source,
            Constant<int, ALEnum, SourceInteger3> param1,
            Ref<nint> value1,
            Ref<nint> value2,
            Ref<nint> value3
        );

        [NativeName("alGetSource3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
        static abstract void GetSource3Direct(
            ContextHandle context,
            uint source,
            int param2,
            int* value1,
            int* value2,
            int* value3
        );

        [NativeName("alGetSource3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
        static abstract void GetSource3Direct(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger3> param2,
            Ref<int> value1,
            Ref<int> value2,
            Ref<int> value3
        );

        [NativeName("alGetSourcedDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcedDirectSOFT")]
        static abstract void GetSourceDirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            double* value
        );

        [NativeName("alGetSourcedDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcedDirectSOFT")]
        static abstract void GetSourceDirectSOFT(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceDouble> param2,
            Ref<double> value
        );

        [NativeName("alGetSourcedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
        static abstract void GetSourceSOFT(uint source, int param1, double* value);

        [NativeName("alGetSourcedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
        static abstract void GetSourceSOFT(
            uint source,
            Constant<int, ALEnum, SourceDouble> param1,
            Ref<double> value
        );

        [NativeName("alGetSourcedvDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcedvDirectSOFT")]
        static abstract void GetSourcedvDirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            double* values
        );

        [NativeName("alGetSourcedvDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcedvDirectSOFT")]
        static abstract void GetSourcedvDirectSOFT(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceDouble> param2,
            Ref<double> values
        );

        [NativeName("alGetSourcedvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
        static abstract void GetSourcedvSOFT(uint source, int param1, double* values);

        [NativeName("alGetSourcedvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
        static abstract void GetSourcedvSOFT(
            uint source,
            Constant<int, ALEnum, SourceDouble> param1,
            Ref<double> values
        );

        [NativeName("alGetSourcef")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        static abstract void GetSourcef(uint source, int param1, float* value);

        [NativeName("alGetSourcef")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        static abstract void GetSourcef(
            uint source,
            Constant<int, ALEnum, SourceFloat> param1,
            Ref<float> value
        );

        [NativeName("alGetSourcefDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
        static abstract void GetSourcefDirect(
            ContextHandle context,
            uint source,
            int param2,
            float* value
        );

        [NativeName("alGetSourcefDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
        static abstract void GetSourcefDirect(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceFloat> param2,
            Ref<float> value
        );

        [NativeName("alGetSourcefv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        static abstract void GetSourcefv(uint source, int param1, float* values);

        [NativeName("alGetSourcefv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        static abstract void GetSourcefv(
            uint source,
            Constant<int, ALEnum, SourceFloat> param1,
            Ref<float> values
        );

        [NativeName("alGetSourcefvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
        static abstract void GetSourcefvDirect(
            ContextHandle context,
            uint source,
            int param2,
            float* values
        );

        [NativeName("alGetSourcefvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
        static abstract void GetSourcefvDirect(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceFloat> param2,
            Ref<float> values
        );

        [NativeName("alGetSourcei")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        static abstract void GetSourcei(uint source, int param1, int* value);

        [NativeName("alGetSourcei")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        static abstract void GetSourcei(
            uint source,
            Constant<int, ALEnum, SourceInteger> param1,
            Ref<int> value
        );

        [NativeName("alGetSourcei64DirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64DirectSOFT")]
        static abstract void GetSourcei64DirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            nint* value
        );

        [NativeName("alGetSourcei64DirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64DirectSOFT")]
        static abstract void GetSourcei64DirectSOFT(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger> param2,
            Ref<nint> value
        );

        [NativeName("alGetSourcei64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
        static abstract void GetSourcei64SOFT(uint source, int param1, nint* value);

        [NativeName("alGetSourcei64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
        static abstract void GetSourcei64SOFT(
            uint source,
            Constant<int, ALEnum, SourceInteger> param1,
            Ref<nint> value
        );

        [NativeName("alGetSourcei64vDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64vDirectSOFT")]
        static abstract void GetSourcei64vDirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            nint* values
        );

        [NativeName("alGetSourcei64vDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64vDirectSOFT")]
        static abstract void GetSourcei64vDirectSOFT(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger> param2,
            Ref<nint> values
        );

        [NativeName("alGetSourcei64vSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
        static abstract void GetSourcei64vSOFT(uint source, int param1, nint* values);

        [NativeName("alGetSourcei64vSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
        static abstract void GetSourcei64vSOFT(
            uint source,
            Constant<int, ALEnum, SourceInteger> param1,
            Ref<nint> values
        );

        [NativeName("alGetSourceiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
        static abstract void GetSourceiDirect(
            ContextHandle context,
            uint source,
            int param2,
            int* value
        );

        [NativeName("alGetSourceiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
        static abstract void GetSourceiDirect(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger> param2,
            Ref<int> value
        );

        [NativeName("alGetSourceiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        static abstract void GetSourceiv(uint source, int param1, int* values);

        [NativeName("alGetSourceiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        static abstract void GetSourceiv(
            uint source,
            Constant<int, ALEnum, SourceInteger> param1,
            Ref<int> values
        );

        [NativeName("alGetSourceivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
        static abstract void GetSourceivDirect(
            ContextHandle context,
            uint source,
            int param2,
            int* values
        );

        [NativeName("alGetSourceivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
        static abstract void GetSourceivDirect(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger> param2,
            Ref<int> values
        );

        [NativeName("alGetString")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        static abstract sbyte* GetString(int param0);

        [NativeName("alGetString")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        static abstract Ptr<sbyte> GetString(Constant<int, ALEnum, StringPName> param0);

        [NativeName("alGetStringDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
        static abstract sbyte* GetStringDirect(ContextHandle context, int param1);

        [NativeName("alGetStringDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
        static abstract Ptr<sbyte> GetStringDirect(
            ContextHandle context,
            Constant<int, ALEnum, StringPName> param1
        );

        [NativeName("alGetStringiDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_resampler"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_resampler"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetStringiDirectSOFT")]
        static abstract sbyte* GetStringDirectSOFT(ContextHandle context, int pname, int index);

        [NativeName("alGetStringiDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_resampler"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_resampler"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alGetStringiDirectSOFT")]
        static abstract Ptr<sbyte> GetStringDirectSOFT(
            ContextHandle context,
            Constant<int, ALEnum, StringPName> pname,
            int index
        );

        [NativeName("alGetStringiSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
        [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
        static abstract sbyte* GetStringSOFT(int pname, int index);

        [NativeName("alGetStringiSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
        [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
        static abstract Ptr<sbyte> GetStringSOFT(
            Constant<int, ALEnum, StringPName> pname,
            int index
        );

        [NativeName("alIsAuxiliaryEffectSlot")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
        static abstract MaybeBool<sbyte> IsAuxiliaryEffectSlot(uint effectslot);

        [NativeName("alIsAuxiliaryEffectSlotDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
        static abstract MaybeBool<sbyte> IsAuxiliaryEffectSlotDirect(
            ContextHandle context,
            uint effectslot
        );

        [NativeName("alIsAuxiliaryEffectSlotDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
        static abstract sbyte IsAuxiliaryEffectSlotDirectRawDirect(
            ContextHandle context,
            uint effectslot
        );

        [NativeName("alIsAuxiliaryEffectSlot")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
        static abstract sbyte IsAuxiliaryEffectSlotRaw(uint effectslot);

        [NativeName("alIsBuffer")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        static abstract MaybeBool<sbyte> IsBuffer(uint buffer);

        [NativeName("alIsBufferDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
        static abstract MaybeBool<sbyte> IsBufferDirect(ContextHandle context, uint buffer);

        [NativeName("alIsBufferDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
        static abstract sbyte IsBufferDirectRawDirect(ContextHandle context, uint buffer);

        [NativeName("alIsBufferFormatSupportedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
        static abstract MaybeBool<sbyte> IsBufferFormatSupportedSOFT(int format);

        [NativeName("alIsBufferFormatSupportedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
        static abstract sbyte IsBufferFormatSupportedSOFTRawSOFT(int format);

        [NativeName("alIsBuffer")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        static abstract sbyte IsBufferRaw(uint buffer);

        [NativeName("alIsEffect")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsEffect")]
        static abstract MaybeBool<sbyte> IsEffect(uint effect);

        [NativeName("alIsEffectDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
        static abstract MaybeBool<sbyte> IsEffectDirect(ContextHandle context, uint effect);

        [NativeName("alIsEffectDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
        static abstract sbyte IsEffectDirectRawDirect(ContextHandle context, uint effect);

        [NativeName("alIsEffect")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsEffect")]
        static abstract sbyte IsEffectRaw(uint effect);

        [NativeName("alIsEnabled")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        static abstract sbyte IsEnabled(int capability);

        [NativeName("alIsEnabled")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        static abstract MaybeBool<sbyte> IsEnabled(Constant<int, ALEnum, EnableCap> capability);

        [NativeName("alIsEnabledDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
        static abstract sbyte IsEnabledDirect(ContextHandle context, int capability);

        [NativeName("alIsEnabledDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
        static abstract MaybeBool<sbyte> IsEnabledDirect(
            ContextHandle context,
            Constant<int, ALEnum, EnableCap> capability
        );

        [NativeName("alIsExtensionPresent")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        static abstract sbyte IsExtensionPresent(sbyte* extname);

        [NativeName("alIsExtensionPresent")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        static abstract MaybeBool<sbyte> IsExtensionPresent(Ref<sbyte> extname);

        [NativeName("alIsExtensionPresentDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
        static abstract sbyte IsExtensionPresentDirect(ContextHandle context, sbyte* extname);

        [NativeName("alIsExtensionPresentDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
        static abstract MaybeBool<sbyte> IsExtensionPresentDirect(
            ContextHandle context,
            Ref<sbyte> extname
        );

        [NativeName("alIsFilter")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsFilter")]
        static abstract MaybeBool<sbyte> IsFilter(uint filter);

        [NativeName("alIsFilterDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
        static abstract MaybeBool<sbyte> IsFilterDirect(ContextHandle context, uint filter);

        [NativeName("alIsFilterDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
        static abstract sbyte IsFilterDirectRawDirect(ContextHandle context, uint filter);

        [NativeName("alIsFilter")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsFilter")]
        static abstract sbyte IsFilterRaw(uint filter);

        [NativeName("alIsSource")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        static abstract MaybeBool<sbyte> IsSource(uint source);

        [NativeName("alIsSourceDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
        static abstract MaybeBool<sbyte> IsSourceDirect(ContextHandle context, uint source);

        [NativeName("alIsSourceDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
        static abstract sbyte IsSourceDirectRawDirect(ContextHandle context, uint source);

        [NativeName("alIsSource")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        static abstract sbyte IsSourceRaw(uint source);

        [NativeName("alListener3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3f")]
        static abstract void Listener3(int param0, float value1, float value2, float value3);

        [NativeName("alListener3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3f")]
        static abstract void Listener3(
            Constant<int, ALEnum, ListenerFloat3> param0,
            float value1,
            float value2,
            float value3
        );

        [NativeName("alListener3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
        static abstract void Listener3Direct(
            ContextHandle context,
            int param1,
            float value1,
            float value2,
            float value3
        );

        [NativeName("alListener3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
        static abstract void Listener3Direct(
            ContextHandle context,
            Constant<int, ALEnum, ListenerFloat3> param1,
            float value1,
            float value2,
            float value3
        );

        [NativeName("alListener3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3i")]
        static abstract void Listener3(int param0, int value1, int value2, int value3);

        [NativeName("alListener3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3i")]
        static abstract void Listener3(
            Constant<int, ALEnum, ListenerInteger3> param0,
            int value1,
            int value2,
            int value3
        );

        [NativeName("alListener3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
        static abstract void Listener3Direct(
            ContextHandle context,
            int param1,
            int value1,
            int value2,
            int value3
        );

        [NativeName("alListener3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
        static abstract void Listener3Direct(
            ContextHandle context,
            Constant<int, ALEnum, ListenerInteger3> param1,
            int value1,
            int value2,
            int value3
        );

        [NativeName("alListenerf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerf")]
        static abstract void Listener(int param0, float value);

        [NativeName("alListenerf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerf")]
        static abstract void Listener(Constant<int, ALEnum, ListenerFloat> param0, float value);

        [NativeName("alListenerfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
        static abstract void ListenerDirect(ContextHandle context, int param1, float value);

        [NativeName("alListenerfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
        static abstract void ListenerDirect(
            ContextHandle context,
            Constant<int, ALEnum, ListenerFloat> param1,
            float value
        );

        [NativeName("alListenerfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        static abstract void Listener(int param0, float* values);

        [NativeName("alListenerfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        static abstract void Listener(
            Constant<int, ALEnum, ListenerFloat> param0,
            Ref<float> values
        );

        [NativeName("alListenerfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
        static abstract void ListenerDirect(ContextHandle context, int param1, float* values);

        [NativeName("alListenerfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
        static abstract void ListenerDirect(
            ContextHandle context,
            Constant<int, ALEnum, ListenerFloat> param1,
            Ref<float> values
        );

        [NativeName("alListeneri")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneri")]
        static abstract void Listener(int param0, int value);

        [NativeName("alListeneriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListeneriDirect")]
        static abstract void ListenerDirect(ContextHandle context, int param1, int value);

        [NativeName("alListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        static abstract void Listener(int param0, int* values);

        [NativeName("alListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        static abstract void Listener(int param0, Ref<int> values);

        [NativeName("alListenerivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
        static abstract void ListenerDirect(ContextHandle context, int param1, int* values);

        [NativeName("alListenerivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
        static abstract void ListenerDirect(ContextHandle context, int param1, Ref<int> values);

        [NativeName("alObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
        static abstract void ObjectLabelDirectEXT(
            ContextHandle context,
            int identifier,
            uint name,
            int length,
            sbyte* label
        );

        [NativeName("alObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
        static abstract void ObjectLabelDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, ObjectIdentifier> identifier,
            uint name,
            int length,
            Ref<sbyte> label
        );

        [NativeName("alObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
        static abstract void ObjectLabelDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, ObjectIdentifier> identifier,
            uint name,
            sbyte label
        );

        [NativeName("alObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
        static abstract void ObjectLabelEXT(int identifier, uint name, int length, sbyte* label);

        [NativeName("alObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
        static abstract void ObjectLabelEXT(
            Constant<int, ALEnum, ObjectIdentifier> identifier,
            uint name,
            int length,
            Ref<sbyte> label
        );

        [NativeName("alObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
        static abstract void ObjectLabelEXT(
            Constant<int, ALEnum, ObjectIdentifier> identifier,
            uint name,
            sbyte label
        );

        [NativeName("alPopDebugGroupDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alPopDebugGroupDirectEXT")]
        static abstract void PopDebugGroupDirectEXT(ContextHandle context);

        [NativeName("alPopDebugGroupEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alPopDebugGroupEXT")]
        static abstract void PopDebugGroupEXT();

        [NativeName("alProcessUpdatesDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_deferred_updates"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_deferred_updates"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alProcessUpdatesDirectSOFT")]
        static abstract void ProcessUpdatesDirectSOFT(ContextHandle context);

        [NativeName("alProcessUpdatesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
        [NativeFunction("openal", EntryPoint = "alProcessUpdatesSOFT")]
        static abstract void ProcessUpdatesSOFT();

        [NativeName("alPushDebugGroupDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
        static abstract void PushDebugGroupDirectEXT(
            ContextHandle context,
            int source,
            uint id,
            int length,
            sbyte* message
        );

        [NativeName("alPushDebugGroupDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
        static abstract void PushDebugGroupDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, DebugSourceEXT> source,
            uint id,
            int length,
            Ref<sbyte> message
        );

        [NativeName("alPushDebugGroupDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
        static abstract void PushDebugGroupDirectEXT(
            ContextHandle context,
            Constant<int, ALEnum, DebugSourceEXT> source,
            uint id,
            sbyte message
        );

        [NativeName("alPushDebugGroupEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
        static abstract void PushDebugGroupEXT(int source, uint id, int length, sbyte* message);

        [NativeName("alPushDebugGroupEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
        static abstract void PushDebugGroupEXT(
            Constant<int, ALEnum, DebugSourceEXT> source,
            uint id,
            int length,
            Ref<sbyte> message
        );

        [NativeName("alPushDebugGroupEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
        static abstract void PushDebugGroupEXT(
            Constant<int, ALEnum, DebugSourceEXT> source,
            uint id,
            sbyte message
        );

        [NativeName("alRequestFoldbackStart")]
        [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
        static abstract void RequestFoldbackStart(
            int mode,
            int count,
            int length,
            float* mem,
            FoldbackCallback callback
        );

        [NativeName("alRequestFoldbackStart")]
        [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
        static abstract void RequestFoldbackStart(
            int mode,
            int count,
            int length,
            Ref<float> mem,
            FoldbackCallback callback
        );

        [NativeName("alRequestFoldbackStartDirect")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStartDirect")]
        static abstract void RequestFoldbackStartDirect(
            ContextHandle context,
            int mode,
            int count,
            int length,
            float* mem,
            FoldbackCallback callback
        );

        [NativeName("alRequestFoldbackStartDirect")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStartDirect")]
        static abstract void RequestFoldbackStartDirect(
            ContextHandle context,
            int mode,
            int count,
            int length,
            Ref<float> mem,
            FoldbackCallback callback
        );

        [NativeName("alRequestFoldbackStop")]
        [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStop")]
        static abstract void RequestFoldbackStop();

        [NativeName("alRequestFoldbackStopDirect")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStopDirect")]
        static abstract void RequestFoldbackStopDirect(ContextHandle context);

        [NativeName("alSource3dDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSource3dDirectSOFT")]
        static abstract void Source3DirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            double value1,
            double value2,
            double value3
        );

        [NativeName("alSource3dSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSource3dSOFT")]
        static abstract void Source3SOFT(
            uint source,
            int param1,
            double value1,
            double value2,
            double value3
        );

        [NativeName("alSource3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3f")]
        static abstract void Source3(
            uint source,
            int param1,
            float value1,
            float value2,
            float value3
        );

        [NativeName("alSource3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3f")]
        static abstract void Source3(
            uint source,
            Constant<int, ALEnum, SourceFloat3> param1,
            float value1,
            float value2,
            float value3
        );

        [NativeName("alSource3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
        static abstract void Source3Direct(
            ContextHandle context,
            uint source,
            int param2,
            float value1,
            float value2,
            float value3
        );

        [NativeName("alSource3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
        static abstract void Source3Direct(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceFloat3> param2,
            float value1,
            float value2,
            float value3
        );

        [NativeName("alSource3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3i")]
        static abstract void Source3(uint source, int param1, int value1, int value2, int value3);

        [NativeName("alSource3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3i")]
        static abstract void Source3(
            uint source,
            Constant<int, ALEnum, SourceInteger3> param1,
            int value1,
            int value2,
            int value3
        );

        [NativeName("alSource3i64DirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSource3i64DirectSOFT")]
        static abstract void Source3DirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            nint value1,
            nint value2,
            nint value3
        );

        [NativeName("alSource3i64DirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSource3i64DirectSOFT")]
        static abstract void Source3DirectSOFT(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger3> param2,
            nint value1,
            nint value2,
            nint value3
        );

        [NativeName("alSource3i64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
        static abstract void Source3SOFT(
            uint source,
            int param1,
            nint value1,
            nint value2,
            nint value3
        );

        [NativeName("alSource3i64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
        static abstract void Source3SOFT(
            uint source,
            Constant<int, ALEnum, SourceInteger3> param1,
            nint value1,
            nint value2,
            nint value3
        );

        [NativeName("alSource3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
        static abstract void Source3Direct(
            ContextHandle context,
            uint source,
            int param2,
            int value1,
            int value2,
            int value3
        );

        [NativeName("alSource3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
        static abstract void Source3Direct(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger3> param2,
            int value1,
            int value2,
            int value3
        );

        [NativeName("alSourcedDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcedDirectSOFT")]
        static abstract void SourceDirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            double value
        );

        [NativeName("alSourcedDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcedDirectSOFT")]
        static abstract void SourceDirectSOFT(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceDouble> param2,
            double value
        );

        [NativeName("alSourcedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
        static abstract void SourceSOFT(uint source, int param1, double value);

        [NativeName("alSourcedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
        static abstract void SourceSOFT(
            uint source,
            Constant<int, ALEnum, SourceDouble> param1,
            double value
        );

        [NativeName("alSourcedvDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcedvDirectSOFT")]
        static abstract void SourceDirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            double* values
        );

        [NativeName("alSourcedvDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcedvDirectSOFT")]
        static abstract void SourceDirectSOFT(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceDouble> param2,
            Ref<double> values
        );

        [NativeName("alSourcedvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
        static abstract void SourceSOFT(uint source, int param1, double* values);

        [NativeName("alSourcedvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
        static abstract void SourceSOFT(
            uint source,
            Constant<int, ALEnum, SourceDouble> param1,
            Ref<double> values
        );

        [NativeName("alSourcef")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcef")]
        static abstract void Source(uint source, int param1, float value);

        [NativeName("alSourcef")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcef")]
        static abstract void Source(
            uint source,
            Constant<int, ALEnum, SourceFloat> param1,
            float value
        );

        [NativeName("alSourcefDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            uint source,
            int param2,
            float value
        );

        [NativeName("alSourcefDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceFloat> param2,
            float value
        );

        [NativeName("alSourcefv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        static abstract void Source(uint source, int param1, float* values);

        [NativeName("alSourcefv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        static abstract void Source(
            uint source,
            Constant<int, ALEnum, SourceFloat> param1,
            Ref<float> values
        );

        [NativeName("alSourcefvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            uint source,
            int param2,
            float* values
        );

        [NativeName("alSourcefvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceFloat> param2,
            Ref<float> values
        );

        [NativeName("alSourcei")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcei")]
        static abstract void Source(uint source, int param1, int value);

        [NativeName("alSourcei")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcei")]
        static abstract void Source(
            uint source,
            Constant<int, ALEnum, SourceInteger> param1,
            int value
        );

        [NativeName("alSourcei64DirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcei64DirectSOFT")]
        static abstract void SourceDirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            nint value
        );

        [NativeName("alSourcei64DirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcei64DirectSOFT")]
        static abstract void SourceDirectSOFT(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger> param2,
            nint value
        );

        [NativeName("alSourcei64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
        static abstract void SourceSOFT(uint source, int param1, nint value);

        [NativeName("alSourcei64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
        static abstract void SourceSOFT(
            uint source,
            Constant<int, ALEnum, SourceInteger> param1,
            nint value
        );

        [NativeName("alSourcei64vDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcei64vDirectSOFT")]
        static abstract void SourceDirectSOFT(
            ContextHandle context,
            uint source,
            int param2,
            nint* values
        );

        [NativeName("alSourcei64vDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcei64vDirectSOFT")]
        static abstract void SourceDirectSOFT(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger> param2,
            Ref<nint> values
        );

        [NativeName("alSourcei64vSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
        static abstract void SourceSOFT(uint source, int param1, nint* values);

        [NativeName("alSourcei64vSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
        static abstract void SourceSOFT(
            uint source,
            Constant<int, ALEnum, SourceInteger> param1,
            Ref<nint> values
        );

        [NativeName("alSourceiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            uint source,
            int param2,
            int value
        );

        [NativeName("alSourceiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger> param2,
            int value
        );

        [NativeName("alSourceiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        static abstract void Source(uint source, int param1, int* values);

        [NativeName("alSourceiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        static abstract void Source(
            uint source,
            Constant<int, ALEnum, SourceInteger> param1,
            Ref<int> values
        );

        [NativeName("alSourceivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            uint source,
            int param2,
            int* values
        );

        [NativeName("alSourceivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            uint source,
            Constant<int, ALEnum, SourceInteger> param2,
            Ref<int> values
        );

        [NativeName("alSourcePause")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePause")]
        static abstract void SourcePause(uint source);

        [NativeName("alSourcePauseDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePauseDirect")]
        static abstract void SourcePauseDirect(ContextHandle context, uint source);

        [NativeName("alSourcePausev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        static abstract void SourcePausev(int n, uint* sources);

        [NativeName("alSourcePausev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        static abstract void SourcePausev(int n, Ref<uint> sources);

        [NativeName("alSourcePausev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        static abstract void SourcePausev(uint sources);

        [NativeName("alSourcePausevDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
        static abstract void SourcePausevDirect(ContextHandle context, int n, uint* sources);

        [NativeName("alSourcePausevDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
        static abstract void SourcePausevDirect(ContextHandle context, int n, Ref<uint> sources);

        [NativeName("alSourcePausevDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
        static abstract void SourcePausevDirect(ContextHandle context, uint sources);

        [NativeName("alSourcePlay")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlay")]
        static abstract void SourcePlay(uint source);

        [NativeName("alSourcePlayAtTimeDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimeDirectSOFT")]
        static abstract void SourcePlayAtTimeDirectSOFT(
            ContextHandle context,
            uint source,
            nint start_time
        );

        [NativeName("alSourcePlayAtTimeSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimeSOFT")]
        static abstract void SourcePlayAtTimeSOFT(uint source, nint start_time);

        [NativeName("alSourcePlayAtTimevDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevDirectSOFT")]
        static abstract void SourcePlayAtTimevDirectSOFT(
            ContextHandle context,
            int n,
            uint* sources,
            nint start_time
        );

        [NativeName("alSourcePlayAtTimevDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevDirectSOFT")]
        static abstract void SourcePlayAtTimevDirectSOFT(
            ContextHandle context,
            int n,
            Ref<uint> sources,
            nint start_time
        );

        [NativeName("alSourcePlayAtTimevDirectSOFT")]
        [
            SupportedApiProfile(
                "al",
                ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
                RequireAll = true
            ),
            SupportedApiProfile(
                "alc",
                ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
                RequireAll = true
            )
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevDirectSOFT")]
        static abstract void SourcePlayAtTimevDirectSOFT(
            ContextHandle context,
            uint sources,
            nint start_time
        );

        [NativeName("alSourcePlayAtTimevSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
        static abstract void SourcePlayAtTimevSOFT(int n, uint* sources, nint start_time);

        [NativeName("alSourcePlayAtTimevSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
        static abstract void SourcePlayAtTimevSOFT(int n, Ref<uint> sources, nint start_time);

        [NativeName("alSourcePlayAtTimevSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
        static abstract void SourcePlayAtTimevSOFT(uint sources, nint start_time);

        [NativeName("alSourcePlayDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayDirect")]
        static abstract void SourcePlayDirect(ContextHandle context, uint source);

        [NativeName("alSourcePlayv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        static abstract void SourcePlayv(int n, uint* sources);

        [NativeName("alSourcePlayv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        static abstract void SourcePlayv(int n, Ref<uint> sources);

        [NativeName("alSourcePlayv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        static abstract void SourcePlayv(uint sources);

        [NativeName("alSourcePlayvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
        static abstract void SourcePlayvDirect(ContextHandle context, int n, uint* sources);

        [NativeName("alSourcePlayvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
        static abstract void SourcePlayvDirect(ContextHandle context, int n, Ref<uint> sources);

        [NativeName("alSourcePlayvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
        static abstract void SourcePlayvDirect(ContextHandle context, uint sources);

        [NativeName("alSourceQueueBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        static abstract void SourceQueueBuffers(uint source, int nb, uint* buffers);

        [NativeName("alSourceQueueBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        static abstract void SourceQueueBuffers(uint source, int nb, Ref<uint> buffers);

        [NativeName("alSourceQueueBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
        static abstract void SourceQueueBuffersDirect(
            ContextHandle context,
            uint source,
            int nb,
            uint* buffers
        );

        [NativeName("alSourceQueueBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
        static abstract void SourceQueueBuffersDirect(
            ContextHandle context,
            uint source,
            int nb,
            Ref<uint> buffers
        );

        [NativeName("alSourceRewind")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewind")]
        static abstract void SourceRewind(uint source);

        [NativeName("alSourceRewindDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceRewindDirect")]
        static abstract void SourceRewindDirect(ContextHandle context, uint source);

        [NativeName("alSourceRewindv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewindv(int n, uint* sources);

        [NativeName("alSourceRewindv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewindv(int n, Ref<uint> sources);

        [NativeName("alSourceRewindv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewindv(uint sources);

        [NativeName("alSourceRewindvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
        static abstract void SourceRewindvDirect(ContextHandle context, int n, uint* sources);

        [NativeName("alSourceRewindvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
        static abstract void SourceRewindvDirect(ContextHandle context, int n, Ref<uint> sources);

        [NativeName("alSourceRewindvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
        static abstract void SourceRewindvDirect(ContextHandle context, uint sources);

        [NativeName("alSourceStop")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStop")]
        static abstract void SourceStop(uint source);

        [NativeName("alSourceStopDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceStopDirect")]
        static abstract void SourceStopDirect(ContextHandle context, uint source);

        [NativeName("alSourceStopv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        static abstract void SourceStopv(int n, uint* sources);

        [NativeName("alSourceStopv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        static abstract void SourceStopv(int n, Ref<uint> sources);

        [NativeName("alSourceStopv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        static abstract void SourceStopv(uint sources);

        [NativeName("alSourceStopvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
        static abstract void SourceStopvDirect(ContextHandle context, int n, uint* sources);

        [NativeName("alSourceStopvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
        static abstract void SourceStopvDirect(ContextHandle context, int n, Ref<uint> sources);

        [NativeName("alSourceStopvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
        static abstract void SourceStopvDirect(ContextHandle context, uint sources);

        [NativeName("alSourceUnqueueBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        static abstract void SourceUnqueueBuffers(uint source, int nb, uint* buffers);

        [NativeName("alSourceUnqueueBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        static abstract void SourceUnqueueBuffers(uint source, int nb, Ref<uint> buffers);

        [NativeName("alSourceUnqueueBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
        static abstract void SourceUnqueueBuffersDirect(
            ContextHandle context,
            uint source,
            int nb,
            uint* buffers
        );

        [NativeName("alSourceUnqueueBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
        static abstract void SourceUnqueueBuffersDirect(
            ContextHandle context,
            uint source,
            int nb,
            Ref<uint> buffers
        );

        [NativeName("alSpeedOfSound")]
        [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
        static abstract void SpeedOfSound(float value);

        [NativeName("alSpeedOfSoundDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSpeedOfSoundDirect")]
        static abstract void SpeedOfSoundDirect(ContextHandle context, float value);

        [NativeName("EAXGetBufferModeDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
        static abstract int EAXGetBufferModeDirect(
            ContextHandle context,
            uint buffer,
            int* pReserved
        );

        [NativeName("EAXGetBufferModeDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
        static abstract int EAXGetBufferModeDirect(
            ContextHandle context,
            uint buffer,
            Ref<int> pReserved
        );

        [NativeName("EAXGetDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
        static abstract int EAXGetDirect(
            ContextHandle context,
            System.Guid* property_set_id,
            uint property_id,
            uint source_id,
            void* value,
            uint value_size
        );

        [NativeName("EAXGetDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
        static abstract int EAXGetDirect(
            ContextHandle context,
            Ref<System.Guid> property_set_id,
            uint property_id,
            uint source_id,
            Ref value,
            uint value_size
        );

        [NativeName("EAXSetBufferModeDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
        static abstract sbyte EAXSetBufferModeDirect(
            ContextHandle context,
            int n,
            uint* buffers,
            int value
        );

        [NativeName("EAXSetBufferModeDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
        static abstract MaybeBool<sbyte> EAXSetBufferModeDirect(
            ContextHandle context,
            int n,
            Ref<uint> buffers,
            int value
        );

        [NativeName("EAXSetDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
        static abstract int EAXSetDirect(
            ContextHandle context,
            System.Guid* property_set_id,
            uint property_id,
            uint source_id,
            void* value,
            uint value_size
        );

        [NativeName("EAXSetDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
        static abstract int EAXSetDirect(
            ContextHandle context,
            Ref<System.Guid> property_set_id,
            uint property_id,
            uint source_id,
            Ref value,
            uint value_size
        );
    }

    [NativeName("alAuxiliaryEffectSlotf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
    void AuxiliaryEffectSlot(uint effectslot, int param1, float flValue);

    [NativeName("alAuxiliaryEffectSlotf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
    void AuxiliaryEffectSlot(
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param1,
        float flValue
    );

    [NativeName("alAuxiliaryEffectSlotfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        uint effectslot,
        int param2,
        float flValue
    );

    [NativeName("alAuxiliaryEffectSlotfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param2,
        float flValue
    );

    [NativeName("alAuxiliaryEffectSlotfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
    void AuxiliaryEffectSlot(uint effectslot, int param1, float* pflValues);

    [NativeName("alAuxiliaryEffectSlotfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
    void AuxiliaryEffectSlot(
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param1,
        Ref<float> pflValues
    );

    [NativeName("alAuxiliaryEffectSlotfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        uint effectslot,
        int param2,
        float* pflValues
    );

    [NativeName("alAuxiliaryEffectSlotfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param2,
        Ref<float> pflValues
    );

    [NativeName("alAuxiliaryEffectSloti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
    void AuxiliaryEffectSlot(uint effectslot, int param1, int iValue);

    [NativeName("alAuxiliaryEffectSloti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
    void AuxiliaryEffectSlot(
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param1,
        int iValue
    );

    [NativeName("alAuxiliaryEffectSlotiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
    void AuxiliaryEffectSlotDirect(ContextHandle context, uint effectslot, int param2, int iValue);

    [NativeName("alAuxiliaryEffectSlotiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param2,
        int iValue
    );

    [NativeName("alAuxiliaryEffectSlotiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
    void AuxiliaryEffectSlot(uint effectslot, int param1, int* piValues);

    [NativeName("alAuxiliaryEffectSlotiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
    void AuxiliaryEffectSlot(
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param1,
        Ref<int> piValues
    );

    [NativeName("alAuxiliaryEffectSlotivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        uint effectslot,
        int param2,
        int* piValues
    );

    [NativeName("alAuxiliaryEffectSlotivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param2,
        Ref<int> piValues
    );

    [NativeName("alBuffer3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBuffer3f")]
    void Buffer3(uint buffer, int param1, float value1, float value2, float value3);

    [NativeName("alBuffer3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBuffer3fDirect")]
    void Buffer3Direct(
        ContextHandle context,
        uint buffer,
        int param2,
        float value1,
        float value2,
        float value3
    );

    [NativeName("alBuffer3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBuffer3i")]
    void Buffer3(uint buffer, int param1, int value1, int value2, int value3);

    [NativeName("alBuffer3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBuffer3iDirect")]
    void Buffer3Direct(
        ContextHandle context,
        uint buffer,
        int param2,
        int value1,
        int value2,
        int value3
    );

    [NativeName("alBufferCallbackDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alBufferCallbackDirectSOFT")]
    void BufferCallbackDirectSOFT(
        ContextHandle context,
        uint buffer,
        int format,
        int freq,
        BufferCallbackSOFT callback,
        void* userptr
    );

    [NativeName("alBufferCallbackDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alBufferCallbackDirectSOFT")]
    void BufferCallbackDirectSOFT(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, Format> format,
        int freq,
        BufferCallbackSOFT callback,
        Ref userptr
    );

    [NativeName("alBufferCallbackSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
    void BufferCallbackSOFT(
        uint buffer,
        int format,
        int freq,
        BufferCallbackSOFT callback,
        void* userptr
    );

    [NativeName("alBufferCallbackSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
    void BufferCallbackSOFT(
        uint buffer,
        Constant<int, ALEnum, Format> format,
        int freq,
        BufferCallbackSOFT callback,
        Ref userptr
    );

    [NativeName("alBufferData")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferData")]
    void BufferData(uint buffer, int format, void* data, int size, int samplerate);

    [NativeName("alBufferData")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferData")]
    void BufferData(
        uint buffer,
        Constant<int, ALEnum, Format> format,
        Ref data,
        int size,
        int samplerate
    );

    [NativeName("alBufferDataDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
    void BufferDataDirect(
        ContextHandle context,
        uint buffer,
        int format,
        void* data,
        int size,
        int samplerate
    );

    [NativeName("alBufferDataDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
    void BufferDataDirect(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, Format> format,
        Ref data,
        int size,
        int samplerate
    );

    [NativeName("alBufferDataStatic")]
    [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
    [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
    void BufferDataStatic(uint buffer, int format, void* data, int size, int freq);

    [NativeName("alBufferDataStatic")]
    [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
    [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
    void BufferDataStatic(
        uint buffer,
        Constant<int, ALEnum, Format> format,
        Ref data,
        int size,
        int freq
    );

    [NativeName("alBufferDataStaticDirect")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_EXT_STATIC_BUFFER"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_EXT_STATIC_BUFFER"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alBufferDataStaticDirect")]
    void BufferDataStaticDirect(
        ContextHandle context,
        uint buffer,
        int format,
        void* data,
        int size,
        int freq
    );

    [NativeName("alBufferDataStaticDirect")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_EXT_STATIC_BUFFER"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_EXT_STATIC_BUFFER"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alBufferDataStaticDirect")]
    void BufferDataStaticDirect(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, Format> format,
        Ref data,
        int size,
        int freq
    );

    [NativeName("alBufferf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferf")]
    void Buffer(uint buffer, int param1, float value);

    [NativeName("alBufferf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferf")]
    void Buffer(uint buffer, Constant<int, ALEnum, BufferFloat> param1, float value);

    [NativeName("alBufferfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
    void BufferDirect(ContextHandle context, uint buffer, int param2, float value);

    [NativeName("alBufferfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
    void BufferDirect(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, BufferFloat> param2,
        float value
    );

    [NativeName("alBufferfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    void Buffer(uint buffer, int param1, float* values);

    [NativeName("alBufferfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    void Buffer(uint buffer, Constant<int, ALEnum, BufferFloat> param1, Ref<float> values);

    [NativeName("alBufferfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
    void BufferDirect(ContextHandle context, uint buffer, int param2, float* values);

    [NativeName("alBufferfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
    void BufferDirect(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, BufferFloat> param2,
        Ref<float> values
    );

    [NativeName("alBufferi")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferi")]
    void Buffer(uint buffer, int param1, int value);

    [NativeName("alBufferi")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferi")]
    void Buffer(uint buffer, Constant<int, ALEnum, BufferInteger> param1, int value);

    [NativeName("alBufferiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
    void BufferDirect(ContextHandle context, uint buffer, int param2, int value);

    [NativeName("alBufferiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
    void BufferDirect(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, BufferInteger> param2,
        int value
    );

    [NativeName("alBufferiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    void Buffer(uint buffer, int param1, int* values);

    [NativeName("alBufferiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    void Buffer(uint buffer, Constant<int, ALEnum, BufferInteger> param1, Ref<int> values);

    [NativeName("alBufferivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
    void BufferDirect(ContextHandle context, uint buffer, int param2, int* values);

    [NativeName("alBufferivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
    void BufferDirect(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, BufferInteger> param2,
        Ref<int> values
    );

    [NativeName("alBufferSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
    void BufferSamplesSOFT(
        uint buffer,
        uint samplerate,
        int internalformat,
        int samples,
        int channels,
        int type,
        void* data
    );

    [NativeName("alBufferSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
    void BufferSamplesSOFT(
        uint buffer,
        uint samplerate,
        int internalformat,
        int samples,
        Constant<int, ALEnum, BufferChannelsSOFT> channels,
        Constant<int, ALEnum, SampleTypeSOFT> type,
        Ref data
    );

    [NativeName("alBufferSubDataDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_buffer_sub_data"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_buffer_sub_data"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alBufferSubDataDirectSOFT")]
    void BufferSubDataDirectSOFT(
        ContextHandle context,
        uint buffer,
        int format,
        void* data,
        int offset,
        int length
    );

    [NativeName("alBufferSubDataDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_buffer_sub_data"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_buffer_sub_data"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alBufferSubDataDirectSOFT")]
    void BufferSubDataDirectSOFT(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, Format> format,
        Ref data,
        int offset,
        int length
    );

    [NativeName("alBufferSubDataSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
    [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
    void BufferSubDataSOFT(uint buffer, int format, void* data, int offset, int length);

    [NativeName("alBufferSubDataSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
    [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
    void BufferSubDataSOFT(
        uint buffer,
        Constant<int, ALEnum, Format> format,
        Ref data,
        int offset,
        int length
    );

    [NativeName("alBufferSubSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
    void BufferSubSamplesSOFT(
        uint buffer,
        int offset,
        int samples,
        int channels,
        int type,
        void* data
    );

    [NativeName("alBufferSubSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
    void BufferSubSamplesSOFT(
        uint buffer,
        int offset,
        int samples,
        Constant<int, ALEnum, BufferChannelsSOFT> channels,
        Constant<int, ALEnum, SampleTypeSOFT> type,
        Ref data
    );

    [NativeName("alDebugMessageCallbackDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
    void DebugMessageCallbackDirectEXT(
        ContextHandle context,
        DebugProcEXT callback,
        void* userParam
    );

    [NativeName("alDebugMessageCallbackDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
    void DebugMessageCallbackDirectEXT(ContextHandle context, DebugProcEXT callback, Ref userParam);

    [NativeName("alDebugMessageCallbackEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
    void DebugMessageCallbackEXT(DebugProcEXT callback, void* userParam);

    [NativeName("alDebugMessageCallbackEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
    void DebugMessageCallbackEXT(DebugProcEXT callback, Ref userParam);

    [NativeName("alDebugMessageControlDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
    void DebugMessageControlDirectEXT(
        ContextHandle context,
        int source,
        int type,
        int severity,
        int count,
        uint* ids,
        sbyte enable
    );

    [NativeName("alDebugMessageControlDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
    void DebugMessageControlDirectEXT(
        ContextHandle context,
        Constant<int, ALEnum, DebugSourceEXT> source,
        Constant<int, ALEnum, DebugTypeEXT> type,
        Constant<int, ALEnum, DebugSeverityEXT> severity,
        int count,
        Ref<uint> ids,
        MaybeBool<sbyte> enable
    );

    [NativeName("alDebugMessageControlDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
    void DebugMessageControlDirectEXT(
        ContextHandle context,
        Constant<int, ALEnum, DebugSourceEXT> source,
        Constant<int, ALEnum, DebugTypeEXT> type,
        Constant<int, ALEnum, DebugSeverityEXT> severity,
        uint ids,
        MaybeBool<sbyte> enable
    );

    [NativeName("alDebugMessageControlEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
    void DebugMessageControlEXT(
        int source,
        int type,
        int severity,
        int count,
        uint* ids,
        sbyte enable
    );

    [NativeName("alDebugMessageControlEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
    void DebugMessageControlEXT(
        Constant<int, ALEnum, DebugSourceEXT> source,
        Constant<int, ALEnum, DebugTypeEXT> type,
        Constant<int, ALEnum, DebugSeverityEXT> severity,
        int count,
        Ref<uint> ids,
        MaybeBool<sbyte> enable
    );

    [NativeName("alDebugMessageControlEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
    void DebugMessageControlEXT(
        Constant<int, ALEnum, DebugSourceEXT> source,
        Constant<int, ALEnum, DebugTypeEXT> type,
        Constant<int, ALEnum, DebugSeverityEXT> severity,
        uint ids,
        MaybeBool<sbyte> enable
    );

    [NativeName("alDebugMessageInsertDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
    void DebugMessageInsertDirectEXT(
        ContextHandle context,
        int source,
        int type,
        uint id,
        int severity,
        int length,
        sbyte* message
    );

    [NativeName("alDebugMessageInsertDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
    void DebugMessageInsertDirectEXT(
        ContextHandle context,
        Constant<int, ALEnum, DebugSourceEXT> source,
        Constant<int, ALEnum, DebugTypeEXT> type,
        uint id,
        Constant<int, ALEnum, DebugSeverityEXT> severity,
        int length,
        Ref<sbyte> message
    );

    [NativeName("alDebugMessageInsertDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
    void DebugMessageInsertDirectEXT(
        ContextHandle context,
        Constant<int, ALEnum, DebugSourceEXT> source,
        Constant<int, ALEnum, DebugTypeEXT> type,
        uint id,
        Constant<int, ALEnum, DebugSeverityEXT> severity,
        sbyte message
    );

    [NativeName("alDebugMessageInsertEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
    void DebugMessageInsertEXT(
        int source,
        int type,
        uint id,
        int severity,
        int length,
        sbyte* message
    );

    [NativeName("alDebugMessageInsertEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
    void DebugMessageInsertEXT(
        Constant<int, ALEnum, DebugSourceEXT> source,
        Constant<int, ALEnum, DebugTypeEXT> type,
        uint id,
        Constant<int, ALEnum, DebugSeverityEXT> severity,
        int length,
        Ref<sbyte> message
    );

    [NativeName("alDebugMessageInsertEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
    void DebugMessageInsertEXT(
        Constant<int, ALEnum, DebugSourceEXT> source,
        Constant<int, ALEnum, DebugTypeEXT> type,
        uint id,
        Constant<int, ALEnum, DebugSeverityEXT> severity,
        sbyte message
    );

    [NativeName("alDeferUpdatesDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_deferred_updates"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_deferred_updates"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alDeferUpdatesDirectSOFT")]
    void DeferUpdatesDirectSOFT(ContextHandle context);

    [NativeName("alDeferUpdatesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
    [NativeFunction("openal", EntryPoint = "alDeferUpdatesSOFT")]
    void DeferUpdatesSOFT();

    [NativeName("alDeleteAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
    void DeleteAuxiliaryEffectSlot(uint effectslots);

    [NativeName("alDeleteAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
    void DeleteAuxiliaryEffectSlots(int n, uint* effectslots);

    [NativeName("alDeleteAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
    void DeleteAuxiliaryEffectSlots(int n, Ref<uint> effectslots);

    [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
    void DeleteAuxiliaryEffectSlotsDirect(ContextHandle context, int n, uint* effectslots);

    [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
    void DeleteAuxiliaryEffectSlotsDirect(ContextHandle context, int n, Ref<uint> effectslots);

    [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
    void DeleteAuxiliaryEffectSlotsDirect(ContextHandle context, uint effectslots);

    [NativeName("alDeleteBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffer(uint buffers);

    [NativeName("alDeleteBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffers(int n, uint* buffers);

    [NativeName("alDeleteBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffers(int n, Ref<uint> buffers);

    [NativeName("alDeleteBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
    void DeleteBuffersDirect(ContextHandle context, int n, uint* buffers);

    [NativeName("alDeleteBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
    void DeleteBuffersDirect(ContextHandle context, int n, Ref<uint> buffers);

    [NativeName("alDeleteEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
    void DeleteEffect(uint effects);

    [NativeName("alDeleteEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
    void DeleteEffects(int n, uint* effects);

    [NativeName("alDeleteEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
    void DeleteEffects(int n, Ref<uint> effects);

    [NativeName("alDeleteEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
    void DeleteEffectsDirect(ContextHandle context, int n, uint* effects);

    [NativeName("alDeleteEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
    void DeleteEffectsDirect(ContextHandle context, int n, Ref<uint> effects);

    [NativeName("alDeleteEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
    void DeleteEffectsDirect(ContextHandle context, uint effects);

    [NativeName("alDeleteFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
    void DeleteFilter(uint filters);

    [NativeName("alDeleteFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
    void DeleteFilters(int n, uint* filters);

    [NativeName("alDeleteFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
    void DeleteFilters(int n, Ref<uint> filters);

    [NativeName("alDeleteFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
    void DeleteFiltersDirect(ContextHandle context, int n, uint* filters);

    [NativeName("alDeleteFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
    void DeleteFiltersDirect(ContextHandle context, int n, Ref<uint> filters);

    [NativeName("alDeleteFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
    void DeleteFiltersDirect(ContextHandle context, uint filters);

    [NativeName("alDeleteSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSource(uint sources);

    [NativeName("alDeleteSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSources(int n, uint* sources);

    [NativeName("alDeleteSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSources(int n, Ref<uint> sources);

    [NativeName("alDeleteSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
    void DeleteSourcesDirect(ContextHandle context, int n, uint* sources);

    [NativeName("alDeleteSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
    void DeleteSourcesDirect(ContextHandle context, int n, Ref<uint> sources);

    [NativeName("alDeleteSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
    void DeleteSourcesDirect(ContextHandle context, uint sources);

    [NativeName("alDisable")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDisable")]
    void Disable(int capability);

    [NativeName("alDisable")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDisable")]
    void Disable(Constant<int, ALEnum, EnableCap> capability);

    [NativeName("alDisableDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDisableDirect")]
    void DisableDirect(ContextHandle context, int capability);

    [NativeName("alDisableDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDisableDirect")]
    void DisableDirect(ContextHandle context, Constant<int, ALEnum, EnableCap> capability);

    [NativeName("alDistanceModel")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    void DistanceModel(int distanceModel);

    [NativeName("alDistanceModel")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    void DistanceModel(Constant<int, ALEnum, DistanceModel> distanceModel);

    [NativeName("alDistanceModelDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
    void DistanceModelDirect(ContextHandle context, int distanceModel);

    [NativeName("alDistanceModelDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
    void DistanceModelDirect(
        ContextHandle context,
        Constant<int, ALEnum, DistanceModel> distanceModel
    );

    [NativeName("alDopplerFactor")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
    void DopplerFactor(float value);

    [NativeName("alDopplerFactorDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDopplerFactorDirect")]
    void DopplerFactorDirect(ContextHandle context, float value);

    [NativeName("alDopplerVelocity")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
    void DopplerVelocity(float value);

    [NativeName("alEffectf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectf")]
    void Effect(uint effect, int param1, float flValue);

    [NativeName("alEffectf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectf")]
    void Effect(uint effect, Constant<int, ALEnum, EffectFloat> param1, float flValue);

    [NativeName("alEffectfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
    void EffectDirect(ContextHandle context, uint effect, int param2, float flValue);

    [NativeName("alEffectfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
    void EffectDirect(
        ContextHandle context,
        uint effect,
        Constant<int, ALEnum, EffectFloat> param2,
        float flValue
    );

    [NativeName("alEffectfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectfv")]
    void Effect(uint effect, int param1, float* pflValues);

    [NativeName("alEffectfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectfv")]
    void Effect(uint effect, Constant<int, ALEnum, EffectFloat> param1, Ref<float> pflValues);

    [NativeName("alEffectfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
    void EffectDirect(ContextHandle context, uint effect, int param2, float* pflValues);

    [NativeName("alEffectfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
    void EffectDirect(
        ContextHandle context,
        uint effect,
        Constant<int, ALEnum, EffectFloat> param2,
        Ref<float> pflValues
    );

    [NativeName("alEffecti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffecti")]
    void Effect(uint effect, int param1, int iValue);

    [NativeName("alEffecti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffecti")]
    void Effect(uint effect, Constant<int, ALEnum, EffectInteger> param1, int iValue);

    [NativeName("alEffectiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
    void EffectDirect(ContextHandle context, uint effect, int param2, int iValue);

    [NativeName("alEffectiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
    void EffectDirect(
        ContextHandle context,
        uint effect,
        Constant<int, ALEnum, EffectInteger> param2,
        int iValue
    );

    [NativeName("alEffectiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectiv")]
    void Effect(uint effect, int param1, int* piValues);

    [NativeName("alEffectiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectiv")]
    void Effect(uint effect, Constant<int, ALEnum, EffectInteger> param1, Ref<int> piValues);

    [NativeName("alEffectivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
    void EffectDirect(ContextHandle context, uint effect, int param2, int* piValues);

    [NativeName("alEffectivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
    void EffectDirect(
        ContextHandle context,
        uint effect,
        Constant<int, ALEnum, EffectInteger> param2,
        Ref<int> piValues
    );

    [NativeName("alEnable")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alEnable")]
    void Enable(int capability);

    [NativeName("alEnable")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alEnable")]
    void Enable(Constant<int, ALEnum, EnableCap> capability);

    [NativeName("alEnableDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alEnableDirect")]
    void EnableDirect(ContextHandle context, int capability);

    [NativeName("alEnableDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alEnableDirect")]
    void EnableDirect(ContextHandle context, Constant<int, ALEnum, EnableCap> capability);

    [NativeName("alEventCallbackDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventCallbackDirectSOFT")]
    void EventCallbackDirectSOFT(ContextHandle context, EventProcSOFT callback, void* userParam);

    [NativeName("alEventCallbackDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventCallbackDirectSOFT")]
    void EventCallbackDirectSOFT(ContextHandle context, EventProcSOFT callback, Ref userParam);

    [NativeName("alEventCallbackSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
    void EventCallbackSOFT(EventProcSOFT callback, void* userParam);

    [NativeName("alEventCallbackSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
    void EventCallbackSOFT(EventProcSOFT callback, Ref userParam);

    [NativeName("alEventControlDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
    void EventControlDirectSOFT(ContextHandle context, int count, int* types, sbyte enable);

    [NativeName("alEventControlDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
    void EventControlDirectSOFT(
        ContextHandle context,
        int count,
        Ref<int> types,
        MaybeBool<sbyte> enable
    );

    [NativeName("alEventControlDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
    void EventControlDirectSOFT(ContextHandle context, int types, MaybeBool<sbyte> enable);

    [NativeName("alEventControlSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
    void EventControlSOFT(int count, int* types, sbyte enable);

    [NativeName("alEventControlSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
    void EventControlSOFT(int count, Ref<int> types, MaybeBool<sbyte> enable);

    [NativeName("alEventControlSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
    void EventControlSOFT(int types, MaybeBool<sbyte> enable);

    [NativeName("alFilterf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilterf")]
    void Filter(uint filter, int param1, float flValue);

    [NativeName("alFilterf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilterf")]
    void Filter(uint filter, Constant<int, ALEnum, FilterFloat> param1, float flValue);

    [NativeName("alFilterfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
    void FilterDirect(ContextHandle context, uint filter, int param2, float flValue);

    [NativeName("alFilterfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
    void FilterDirect(
        ContextHandle context,
        uint filter,
        Constant<int, ALEnum, FilterFloat> param2,
        float flValue
    );

    [NativeName("alFilterfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilterfv")]
    void Filter(uint filter, int param1, float* pflValues);

    [NativeName("alFilterfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilterfv")]
    void Filter(uint filter, Constant<int, ALEnum, FilterFloat> param1, Ref<float> pflValues);

    [NativeName("alFilterfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
    void FilterDirect(ContextHandle context, uint filter, int param2, float* pflValues);

    [NativeName("alFilterfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
    void FilterDirect(
        ContextHandle context,
        uint filter,
        Constant<int, ALEnum, FilterFloat> param2,
        Ref<float> pflValues
    );

    [NativeName("alFilteri")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilteri")]
    void Filter(uint filter, int param1, int iValue);

    [NativeName("alFilteri")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilteri")]
    void Filter(uint filter, Constant<int, ALEnum, FilterInteger> param1, int iValue);

    [NativeName("alFilteriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
    void FilterDirect(ContextHandle context, uint filter, int param2, int iValue);

    [NativeName("alFilteriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
    void FilterDirect(
        ContextHandle context,
        uint filter,
        Constant<int, ALEnum, FilterInteger> param2,
        int iValue
    );

    [NativeName("alFilteriv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilteriv")]
    void Filter(uint filter, int param1, int* piValues);

    [NativeName("alFilteriv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilteriv")]
    void Filter(uint filter, Constant<int, ALEnum, FilterInteger> param1, Ref<int> piValues);

    [NativeName("alFilterivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
    void FilterDirect(ContextHandle context, uint filter, int param2, int* piValues);

    [NativeName("alFilterivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
    void FilterDirect(
        ContextHandle context,
        uint filter,
        Constant<int, ALEnum, FilterInteger> param2,
        Ref<int> piValues
    );

    [NativeName("alGenAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
    uint GenAuxiliaryEffectSlot();

    [NativeName("alGenAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
    void GenAuxiliaryEffectSlots(int n, uint* effectslots);

    [NativeName("alGenAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
    void GenAuxiliaryEffectSlots(int n, Ref<uint> effectslots);

    [NativeName("alGenAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
    void GenAuxiliaryEffectSlotsDirect(ContextHandle context, int n, uint* effectslots);

    [NativeName("alGenAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
    void GenAuxiliaryEffectSlotsDirect(ContextHandle context, int n, Ref<uint> effectslots);

    [NativeName("alGenAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
    uint GenAuxiliaryEffectSlotsDirect(ContextHandle context);

    [NativeName("alGenBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    uint GenBuffer();

    [NativeName("alGenBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    void GenBuffers(int n, uint* buffers);

    [NativeName("alGenBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    void GenBuffers(int n, Ref<uint> buffers);

    [NativeName("alGenBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
    void GenBuffersDirect(ContextHandle context, int n, uint* buffers);

    [NativeName("alGenBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
    void GenBuffersDirect(ContextHandle context, int n, Ref<uint> buffers);

    [NativeName("alGenEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenEffects")]
    uint GenEffect();

    [NativeName("alGenEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenEffects")]
    void GenEffects(int n, uint* effects);

    [NativeName("alGenEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenEffects")]
    void GenEffects(int n, Ref<uint> effects);

    [NativeName("alGenEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
    void GenEffectsDirect(ContextHandle context, int n, uint* effects);

    [NativeName("alGenEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
    void GenEffectsDirect(ContextHandle context, int n, Ref<uint> effects);

    [NativeName("alGenEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
    uint GenEffectsDirect(ContextHandle context);

    [NativeName("alGenFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenFilters")]
    uint GenFilter();

    [NativeName("alGenFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenFilters")]
    void GenFilters(int n, uint* filters);

    [NativeName("alGenFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenFilters")]
    void GenFilters(int n, Ref<uint> filters);

    [NativeName("alGenFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
    void GenFiltersDirect(ContextHandle context, int n, uint* filters);

    [NativeName("alGenFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
    void GenFiltersDirect(ContextHandle context, int n, Ref<uint> filters);

    [NativeName("alGenFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
    uint GenFiltersDirect(ContextHandle context);

    [NativeName("alGenSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    uint GenSource();

    [NativeName("alGenSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    void GenSources(int n, uint* sources);

    [NativeName("alGenSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    void GenSources(int n, Ref<uint> sources);

    [NativeName("alGenSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
    void GenSourcesDirect(ContextHandle context, int n, uint* sources);

    [NativeName("alGenSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
    void GenSourcesDirect(ContextHandle context, int n, Ref<uint> sources);

    [NativeName("alGenSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
    uint GenSourcesDirect(ContextHandle context);

    [NativeName("alGetAuxiliaryEffectSlotf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
    void GetAuxiliaryEffectSlotf(uint effectslot, int param1, float* flValue);

    [NativeName("alGetAuxiliaryEffectSlotf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
    void GetAuxiliaryEffectSlotf(
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param1,
        Ref<float> flValue
    );

    [NativeName("alGetAuxiliaryEffectSlotfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
    void GetAuxiliaryEffectSlotfDirect(
        ContextHandle context,
        uint effectslot,
        int param2,
        float* pflValue
    );

    [NativeName("alGetAuxiliaryEffectSlotfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
    void GetAuxiliaryEffectSlotfDirect(
        ContextHandle context,
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param2,
        Ref<float> pflValue
    );

    [NativeName("alGetAuxiliaryEffectSlotfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
    void GetAuxiliaryEffectSlotfv(uint effectslot, int param1, float* pflValues);

    [NativeName("alGetAuxiliaryEffectSlotfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
    void GetAuxiliaryEffectSlotfv(
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param1,
        Ref<float> pflValues
    );

    [NativeName("alGetAuxiliaryEffectSlotfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
    void GetAuxiliaryEffectSlotfvDirect(
        ContextHandle context,
        uint effectslot,
        int param2,
        float* pflValues
    );

    [NativeName("alGetAuxiliaryEffectSlotfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
    void GetAuxiliaryEffectSlotfvDirect(
        ContextHandle context,
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotFloat> param2,
        Ref<float> pflValues
    );

    [NativeName("alGetAuxiliaryEffectSloti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
    void GetAuxiliaryEffectSloti(uint effectslot, int param1, int* iValue);

    [NativeName("alGetAuxiliaryEffectSloti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
    void GetAuxiliaryEffectSloti(
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param1,
        Ref<int> iValue
    );

    [NativeName("alGetAuxiliaryEffectSlotiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
    void GetAuxiliaryEffectSlotiDirect(
        ContextHandle context,
        uint effectslot,
        int param2,
        int* piValue
    );

    [NativeName("alGetAuxiliaryEffectSlotiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
    void GetAuxiliaryEffectSlotiDirect(
        ContextHandle context,
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param2,
        Ref<int> piValue
    );

    [NativeName("alGetAuxiliaryEffectSlotiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
    void GetAuxiliaryEffectSlotiv(uint effectslot, int param1, int* piValues);

    [NativeName("alGetAuxiliaryEffectSlotiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
    void GetAuxiliaryEffectSlotiv(
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param1,
        Ref<int> piValues
    );

    [NativeName("alGetAuxiliaryEffectSlotivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
    void GetAuxiliaryEffectSlotivDirect(
        ContextHandle context,
        uint effectslot,
        int param2,
        int* piValues
    );

    [NativeName("alGetAuxiliaryEffectSlotivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
    void GetAuxiliaryEffectSlotivDirect(
        ContextHandle context,
        uint effectslot,
        Constant<int, ALEnum, AuxiliaryEffectSlotInteger> param2,
        Ref<int> piValues
    );

    [NativeName("alGetBoolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    sbyte GetBoolean(int param0);

    [NativeName("alGetBoolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    MaybeBool<sbyte> GetBoolean(Constant<int, ALEnum, BooleanPName> param0);

    [NativeName("alGetBooleanDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
    sbyte GetBooleanDirect(ContextHandle context, int param1);

    [NativeName("alGetBooleanDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
    MaybeBool<sbyte> GetBooleanDirect(
        ContextHandle context,
        Constant<int, ALEnum, BooleanPName> param1
    );

    [NativeName("alGetBooleanv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    void GetBoolean(int param0, sbyte* values);

    [NativeName("alGetBooleanv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    void GetBoolean(Constant<int, ALEnum, BooleanPName> param0, Ref<sbyte> values);

    [NativeName("alGetBooleanvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
    void GetBooleanDirect(ContextHandle context, int param1, sbyte* values);

    [NativeName("alGetBooleanvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
    void GetBooleanDirect(
        ContextHandle context,
        Constant<int, ALEnum, BooleanPName> param1,
        Ref<sbyte> values
    );

    [NativeName("alGetBuffer3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    void GetBuffer3(uint buffer, int param1, float* value1, float* value2, float* value3);

    [NativeName("alGetBuffer3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    void GetBuffer3(
        uint buffer,
        int param1,
        Ref<float> value1,
        Ref<float> value2,
        Ref<float> value3
    );

    [NativeName("alGetBuffer3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
    void GetBuffer3Direct(
        ContextHandle context,
        uint buffer,
        int param2,
        float* value1,
        float* value2,
        float* value3
    );

    [NativeName("alGetBuffer3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
    void GetBuffer3Direct(
        ContextHandle context,
        uint buffer,
        int param2,
        Ref<float> value1,
        Ref<float> value2,
        Ref<float> value3
    );

    [NativeName("alGetBuffer3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    void GetBuffer3(uint buffer, int param1, int* value1, int* value2, int* value3);

    [NativeName("alGetBuffer3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    void GetBuffer3(uint buffer, int param1, Ref<int> value1, Ref<int> value2, Ref<int> value3);

    [NativeName("alGetBuffer3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
    void GetBuffer3Direct(
        ContextHandle context,
        uint buffer,
        int param2,
        int* value1,
        int* value2,
        int* value3
    );

    [NativeName("alGetBuffer3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
    void GetBuffer3Direct(
        ContextHandle context,
        uint buffer,
        int param2,
        Ref<int> value1,
        Ref<int> value2,
        Ref<int> value3
    );

    [NativeName("alGetBuffer3PtrDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrDirectSOFT")]
    void GetBuffer3PtrDirectSOFT(
        ContextHandle context,
        uint buffer,
        int param2,
        void** ptr0,
        void** ptr1,
        void** ptr2
    );

    [NativeName("alGetBuffer3PtrDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrDirectSOFT")]
    void GetBuffer3PtrDirectSOFT(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, BufferPointerSOFT> param2,
        Ref2D ptr0,
        Ref2D ptr1,
        Ref2D ptr2
    );

    [NativeName("alGetBuffer3PtrSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
    void GetBuffer3PtrSOFT(uint buffer, int param1, void** ptr0, void** ptr1, void** ptr2);

    [NativeName("alGetBuffer3PtrSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
    void GetBuffer3PtrSOFT(
        uint buffer,
        Constant<int, ALEnum, BufferPointerSOFT> param1,
        Ref2D ptr0,
        Ref2D ptr1,
        Ref2D ptr2
    );

    [NativeName("alGetBufferf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferf")]
    void GetBufferf(uint buffer, int param1, float* value);

    [NativeName("alGetBufferf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferf")]
    void GetBufferf(uint buffer, Constant<int, ALEnum, BufferFloat> param1, Ref<float> value);

    [NativeName("alGetBufferfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
    void GetBufferfDirect(ContextHandle context, uint buffer, int param2, float* value);

    [NativeName("alGetBufferfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
    void GetBufferfDirect(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, BufferFloat> param2,
        Ref<float> value
    );

    [NativeName("alGetBufferfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
    void GetBufferfv(uint buffer, int param1, float* values);

    [NativeName("alGetBufferfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
    void GetBufferfv(uint buffer, Constant<int, ALEnum, BufferFloat> param1, Ref<float> values);

    [NativeName("alGetBufferfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
    void GetBufferfvDirect(ContextHandle context, uint buffer, int param2, float* values);

    [NativeName("alGetBufferfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
    void GetBufferfvDirect(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, BufferFloat> param2,
        Ref<float> values
    );

    [NativeName("alGetBufferi")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferi")]
    void GetBufferi(uint buffer, int param1, int* value);

    [NativeName("alGetBufferi")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferi")]
    void GetBufferi(uint buffer, Constant<int, ALEnum, BufferInteger> param1, Ref<int> value);

    [NativeName("alGetBufferiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
    void GetBufferiDirect(ContextHandle context, uint buffer, int param2, int* value);

    [NativeName("alGetBufferiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
    void GetBufferiDirect(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, BufferInteger> param2,
        Ref<int> value
    );

    [NativeName("alGetBufferiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
    void GetBufferiv(uint buffer, int param1, int* values);

    [NativeName("alGetBufferiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
    void GetBufferiv(uint buffer, Constant<int, ALEnum, BufferInteger> param1, Ref<int> values);

    [NativeName("alGetBufferivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
    void GetBufferivDirect(ContextHandle context, uint buffer, int param2, int* values);

    [NativeName("alGetBufferivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
    void GetBufferivDirect(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, BufferInteger> param2,
        Ref<int> values
    );

    [NativeName("alGetBufferPtrDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrDirectSOFT")]
    void GetBufferPtrDirectSOFT(ContextHandle context, uint buffer, int param2, void** ptr);

    [NativeName("alGetBufferPtrDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrDirectSOFT")]
    void GetBufferPtrDirectSOFT(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, BufferPointerSOFT> param2,
        Ref2D ptr
    );

    [NativeName("alGetBufferPtrSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
    void GetBufferPtrSOFT(uint buffer, int param1, void** ptr);

    [NativeName("alGetBufferPtrSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
    void GetBufferPtrSOFT(uint buffer, Constant<int, ALEnum, BufferPointerSOFT> param1, Ref2D ptr);

    [NativeName("alGetBufferPtrvDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrvDirectSOFT")]
    void GetBufferPtrvDirectSOFT(ContextHandle context, uint buffer, int param2, void** ptr);

    [NativeName("alGetBufferPtrvDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_callback_buffer"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrvDirectSOFT")]
    void GetBufferPtrvDirectSOFT(
        ContextHandle context,
        uint buffer,
        Constant<int, ALEnum, BufferPointerSOFT> param2,
        Ref2D ptr
    );

    [NativeName("alGetBufferPtrvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
    void GetBufferPtrvSOFT(uint buffer, int param1, void** ptr);

    [NativeName("alGetBufferPtrvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
    void GetBufferPtrvSOFT(uint buffer, Constant<int, ALEnum, BufferPointerSOFT> param1, Ref2D ptr);

    [NativeName("alGetBufferSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
    void GetBufferSamplesSOFT(
        uint buffer,
        int offset,
        int samples,
        int channels,
        int type,
        void* data
    );

    [NativeName("alGetBufferSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
    void GetBufferSamplesSOFT(
        uint buffer,
        int offset,
        int samples,
        Constant<int, ALEnum, BufferChannelsSOFT> channels,
        Constant<int, ALEnum, SampleTypeSOFT> type,
        Ref data
    );

    [NativeName("alGetDebugMessageLogDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectEXT(
        ContextHandle context,
        uint count,
        int logBufSize,
        int* sources,
        int* types,
        uint* ids,
        int* severities,
        int* lengths,
        sbyte* logBuf
    );

    [NativeName("alGetDebugMessageLogDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectEXT(
        ContextHandle context,
        uint count,
        int logBufSize,
        Ref<int> sources,
        Ref<int> types,
        Ref<uint> ids,
        Ref<int> severities,
        Ref<int> lengths,
        Ref<sbyte> logBuf
    );

    [NativeName("alGetDebugMessageLogDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectEXT(
        ContextHandle context,
        uint count,
        int logBufSize,
        Ref<ALEnum> sources,
        Ref<ALEnum> types,
        Ref<uint> ids,
        Ref<ALEnum> severities,
        Ref<int> lengths,
        Ref<sbyte> logBuf
    );

    [NativeName("alGetDebugMessageLogDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectEXT(
        ContextHandle context,
        uint count,
        int logBufSize,
        Ref<DebugSourceEXT> sources,
        Ref<DebugTypeEXT> types,
        Ref<uint> ids,
        Ref<DebugSeverityEXT> severities,
        Ref<int> lengths,
        Ref<sbyte> logBuf
    );

    [NativeName("alGetDebugMessageLogEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogEXT(
        uint count,
        int logBufSize,
        int* sources,
        int* types,
        uint* ids,
        int* severities,
        int* lengths,
        sbyte* logBuf
    );

    [NativeName("alGetDebugMessageLogEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogEXT(
        uint count,
        int logBufSize,
        Ref<int> sources,
        Ref<int> types,
        Ref<uint> ids,
        Ref<int> severities,
        Ref<int> lengths,
        Ref<sbyte> logBuf
    );

    [NativeName("alGetDebugMessageLogEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogEXT(
        uint count,
        int logBufSize,
        Ref<ALEnum> sources,
        Ref<ALEnum> types,
        Ref<uint> ids,
        Ref<ALEnum> severities,
        Ref<int> lengths,
        Ref<sbyte> logBuf
    );

    [NativeName("alGetDebugMessageLogEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogEXT(
        uint count,
        int logBufSize,
        Ref<DebugSourceEXT> sources,
        Ref<DebugTypeEXT> types,
        Ref<uint> ids,
        Ref<DebugSeverityEXT> severities,
        Ref<int> lengths,
        Ref<sbyte> logBuf
    );

    [NativeName("alGetDouble")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDouble")]
    double GetDouble(int param0);

    [NativeName("alGetDouble")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDouble")]
    double GetDouble(Constant<int, ALEnum, GetPName> param0);

    [NativeName("alGetDoubleDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
    double GetDoubleDirect(ContextHandle context, int param1);

    [NativeName("alGetDoubleDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
    double GetDoubleDirect(ContextHandle context, Constant<int, ALEnum, GetPName> param1);

    [NativeName("alGetDoublev")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    void GetDouble(int param0, double* values);

    [NativeName("alGetDoublev")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    void GetDouble(Constant<int, ALEnum, GetPName> param0, Ref<double> values);

    [NativeName("alGetDoublevDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
    void GetDoubleDirect(ContextHandle context, int param1, double* values);

    [NativeName("alGetDoublevDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
    void GetDoubleDirect(
        ContextHandle context,
        Constant<int, ALEnum, GetPName> param1,
        Ref<double> values
    );

    [NativeName("alGetEffectf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectf")]
    void GetEffectf(uint effect, int param1, float* flValue);

    [NativeName("alGetEffectf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectf")]
    void GetEffectf(uint effect, Constant<int, ALEnum, EffectFloat> param1, Ref<float> flValue);

    [NativeName("alGetEffectfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
    void GetEffectfDirect(ContextHandle context, uint effect, int param2, float* pflValue);

    [NativeName("alGetEffectfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
    void GetEffectfDirect(
        ContextHandle context,
        uint effect,
        Constant<int, ALEnum, EffectFloat> param2,
        Ref<float> pflValue
    );

    [NativeName("alGetEffectfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
    void GetEffectfv(uint effect, int param1, float* pflValues);

    [NativeName("alGetEffectfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
    void GetEffectfv(uint effect, Constant<int, ALEnum, EffectFloat> param1, Ref<float> pflValues);

    [NativeName("alGetEffectfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
    void GetEffectfvDirect(ContextHandle context, uint effect, int param2, float* pflValues);

    [NativeName("alGetEffectfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
    void GetEffectfvDirect(
        ContextHandle context,
        uint effect,
        Constant<int, ALEnum, EffectFloat> param2,
        Ref<float> pflValues
    );

    [NativeName("alGetEffecti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffecti")]
    void GetEffecti(uint effect, int param1, int* iValue);

    [NativeName("alGetEffecti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffecti")]
    void GetEffecti(uint effect, Constant<int, ALEnum, EffectInteger> param1, Ref<int> iValue);

    [NativeName("alGetEffectiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
    void GetEffectiDirect(ContextHandle context, uint effect, int param2, int* piValue);

    [NativeName("alGetEffectiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
    void GetEffectiDirect(
        ContextHandle context,
        uint effect,
        Constant<int, ALEnum, EffectInteger> param2,
        Ref<int> piValue
    );

    [NativeName("alGetEffectiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
    void GetEffectiv(uint effect, int param1, int* piValues);

    [NativeName("alGetEffectiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
    void GetEffectiv(uint effect, Constant<int, ALEnum, EffectInteger> param1, Ref<int> piValues);

    [NativeName("alGetEffectivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
    void GetEffectivDirect(ContextHandle context, uint effect, int param2, int* piValues);

    [NativeName("alGetEffectivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
    void GetEffectivDirect(
        ContextHandle context,
        uint effect,
        Constant<int, ALEnum, EffectInteger> param2,
        Ref<int> piValues
    );

    [NativeName("alGetEnumValue")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
    int GetEnumValue(sbyte* ename);

    [NativeName("alGetEnumValue")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
    int GetEnumValue(Ref<sbyte> ename);

    [NativeName("alGetEnumValueDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
    int GetEnumValueDirect(ContextHandle context, sbyte* ename);

    [NativeName("alGetEnumValueDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
    int GetEnumValueDirect(ContextHandle context, Ref<sbyte> ename);

    [NativeName("alGetError")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    Constant<int, ErrorCode> GetError();

    [NativeName("alGetErrorDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
    Constant<int, ErrorCode> GetErrorDirect(ContextHandle context);

    [NativeName("alGetErrorDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
    int GetErrorDirectRawDirect(ContextHandle context);

    [NativeName("alGetError")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    int GetErrorRaw();

    [NativeName("alGetFilterf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilterf")]
    void GetFilterf(uint filter, int param1, float* flValue);

    [NativeName("alGetFilterf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilterf")]
    void GetFilterf(uint filter, Constant<int, ALEnum, FilterFloat> param1, Ref<float> flValue);

    [NativeName("alGetFilterfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
    void GetFilterfDirect(ContextHandle context, uint filter, int param2, float* pflValue);

    [NativeName("alGetFilterfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
    void GetFilterfDirect(
        ContextHandle context,
        uint filter,
        Constant<int, ALEnum, FilterFloat> param2,
        Ref<float> pflValue
    );

    [NativeName("alGetFilterfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
    void GetFilterfv(uint filter, int param1, float* pflValues);

    [NativeName("alGetFilterfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
    void GetFilterfv(uint filter, Constant<int, ALEnum, FilterFloat> param1, Ref<float> pflValues);

    [NativeName("alGetFilterfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
    void GetFilterfvDirect(ContextHandle context, uint filter, int param2, float* pflValues);

    [NativeName("alGetFilterfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
    void GetFilterfvDirect(
        ContextHandle context,
        uint filter,
        Constant<int, ALEnum, FilterFloat> param2,
        Ref<float> pflValues
    );

    [NativeName("alGetFilteri")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilteri")]
    void GetFilteri(uint filter, int param1, int* iValue);

    [NativeName("alGetFilteri")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilteri")]
    void GetFilteri(uint filter, Constant<int, ALEnum, FilterInteger> param1, Ref<int> iValue);

    [NativeName("alGetFilteriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
    void GetFilteriDirect(ContextHandle context, uint filter, int param2, int* piValue);

    [NativeName("alGetFilteriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
    void GetFilteriDirect(
        ContextHandle context,
        uint filter,
        Constant<int, ALEnum, FilterInteger> param2,
        Ref<int> piValue
    );

    [NativeName("alGetFilteriv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
    void GetFilteriv(uint filter, int param1, int* piValues);

    [NativeName("alGetFilteriv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
    void GetFilteriv(uint filter, Constant<int, ALEnum, FilterInteger> param1, Ref<int> piValues);

    [NativeName("alGetFilterivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
    void GetFilterivDirect(ContextHandle context, uint filter, int param2, int* piValues);

    [NativeName("alGetFilterivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
    void GetFilterivDirect(
        ContextHandle context,
        uint filter,
        Constant<int, ALEnum, FilterInteger> param2,
        Ref<int> piValues
    );

    [NativeName("alGetFloat")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloat")]
    float GetFloat(int param0);

    [NativeName("alGetFloat")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloat")]
    float GetFloat(Constant<int, ALEnum, FloatPName> param0);

    [NativeName("alGetFloatDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
    float GetFloatDirect(ContextHandle context, int param1);

    [NativeName("alGetFloatDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
    float GetFloatDirect(ContextHandle context, Constant<int, ALEnum, FloatPName> param1);

    [NativeName("alGetFloatv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    void GetFloat(int param0, float* values);

    [NativeName("alGetFloatv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    void GetFloat(Constant<int, ALEnum, GetPName> param0, Ref<float> values);

    [NativeName("alGetFloatvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
    void GetFloatDirect(ContextHandle context, int param1, float* values);

    [NativeName("alGetFloatvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
    void GetFloatDirect(
        ContextHandle context,
        Constant<int, ALEnum, GetPName> param1,
        Ref<float> values
    );

    [NativeName("alGetInteger")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetInteger")]
    int GetInteger(int param0);

    [NativeName("alGetInteger")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetInteger")]
    int GetInteger(Constant<int, ALEnum, IntegerPName> param0);

    [NativeName("alGetIntegerDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
    int GetIntegerDirect(ContextHandle context, int param1);

    [NativeName("alGetIntegerDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
    int GetIntegerDirect(ContextHandle context, Constant<int, ALEnum, IntegerPName> param1);

    [NativeName("alGetIntegerv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    void GetInteger(int param0, int* values);

    [NativeName("alGetIntegerv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    void GetInteger(Constant<int, ALEnum, IntegerPName> param0, Ref<int> values);

    [NativeName("alGetIntegervDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
    void GetIntegerDirect(ContextHandle context, int param1, int* values);

    [NativeName("alGetIntegervDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
    void GetIntegerDirect(
        ContextHandle context,
        Constant<int, ALEnum, IntegerPName> param1,
        Ref<int> values
    );

    [NativeName("alGetListener3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    void GetListener3(int param0, float* value1, float* value2, float* value3);

    [NativeName("alGetListener3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    void GetListener3(
        Constant<int, ALEnum, ListenerFloat3> param0,
        Ref<float> value1,
        Ref<float> value2,
        Ref<float> value3
    );

    [NativeName("alGetListener3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
    void GetListener3Direct(
        ContextHandle context,
        int param1,
        float* value1,
        float* value2,
        float* value3
    );

    [NativeName("alGetListener3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
    void GetListener3Direct(
        ContextHandle context,
        Constant<int, ALEnum, ListenerFloat3> param1,
        Ref<float> value1,
        Ref<float> value2,
        Ref<float> value3
    );

    [NativeName("alGetListener3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    void GetListener3(int param0, int* value1, int* value2, int* value3);

    [NativeName("alGetListener3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    void GetListener3(
        Constant<int, ALEnum, ListenerInteger3> param0,
        Ref<int> value1,
        Ref<int> value2,
        Ref<int> value3
    );

    [NativeName("alGetListener3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
    void GetListener3Direct(
        ContextHandle context,
        int param1,
        int* value1,
        int* value2,
        int* value3
    );

    [NativeName("alGetListener3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
    void GetListener3Direct(
        ContextHandle context,
        Constant<int, ALEnum, ListenerInteger3> param1,
        Ref<int> value1,
        Ref<int> value2,
        Ref<int> value3
    );

    [NativeName("alGetListenerf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    void GetListenerf(int param0, float* value);

    [NativeName("alGetListenerf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    void GetListenerf(Constant<int, ALEnum, ListenerFloat> param0, Ref<float> value);

    [NativeName("alGetListenerfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
    void GetListenerfDirect(ContextHandle context, int param1, float* value);

    [NativeName("alGetListenerfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
    void GetListenerfDirect(
        ContextHandle context,
        Constant<int, ALEnum, ListenerFloat> param1,
        Ref<float> value
    );

    [NativeName("alGetListenerfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    void GetListenerfv(int param0, float* values);

    [NativeName("alGetListenerfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    void GetListenerfv(Constant<int, ALEnum, ListenerFloat> param0, Ref<float> values);

    [NativeName("alGetListenerfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
    void GetListenerfvDirect(ContextHandle context, int param1, float* values);

    [NativeName("alGetListenerfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
    void GetListenerfvDirect(
        ContextHandle context,
        Constant<int, ALEnum, ListenerFloat> param1,
        Ref<float> values
    );

    [NativeName("alGetListeneri")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    void GetListeneri(int param0, int* value);

    [NativeName("alGetListeneri")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    void GetListeneri(int param0, Ref<int> value);

    [NativeName("alGetListeneri")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    int GetListeneri();

    [NativeName("alGetListeneriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
    void GetListeneriDirect(ContextHandle context, int param1, int* value);

    [NativeName("alGetListeneriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
    void GetListeneriDirect(ContextHandle context, int param1, Ref<int> value);

    [NativeName("alGetListeneriv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    void GetListeneriv(int param0, int* values);

    [NativeName("alGetListeneriv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    void GetListeneriv(int param0, Ref<int> values);

    [NativeName("alGetListeneriv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    int GetListeneriv();

    [NativeName("alGetListenerivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
    void GetListenerivDirect(ContextHandle context, int param1, int* values);

    [NativeName("alGetListenerivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
    void GetListenerivDirect(ContextHandle context, int param1, Ref<int> values);

    [NativeName("alGetObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
    void GetObjectLabelDirectEXT(
        ContextHandle context,
        int identifier,
        uint name,
        int bufSize,
        int* length,
        sbyte* label
    );

    [NativeName("alGetObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
    void GetObjectLabelDirectEXT(
        ContextHandle context,
        Constant<int, ALEnum, ObjectIdentifier> identifier,
        uint name,
        int bufSize,
        Ref<int> length,
        Ref<sbyte> label
    );

    [NativeName("alGetObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
    sbyte GetObjectLabelDirectEXT(
        ContextHandle context,
        Constant<int, ALEnum, ObjectIdentifier> identifier,
        uint name,
        Ref<int> length
    );

    [NativeName("alGetObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
    void GetObjectLabelEXT(int identifier, uint name, int bufSize, int* length, sbyte* label);

    [NativeName("alGetObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
    void GetObjectLabelEXT(
        Constant<int, ALEnum, ObjectIdentifier> identifier,
        uint name,
        int bufSize,
        Ref<int> length,
        Ref<sbyte> label
    );

    [NativeName("alGetObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
    sbyte GetObjectLabelEXT(
        Constant<int, ALEnum, ObjectIdentifier> identifier,
        uint name,
        Ref<int> length
    );

    [NativeName("alGetPointerDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
    void* GetPointerDirectEXT(ContextHandle context, int pname);

    [NativeName("alGetPointerDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
    Ptr GetPointerDirectEXT(ContextHandle context, Constant<int, ALEnum, PointerPName> pname);

    [NativeName("alGetPointerDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectSOFT")]
    void* GetPointerDirectSOFT(ContextHandle context, int pname);

    [NativeName("alGetPointerDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectSOFT")]
    Ptr GetPointerDirectSOFT(ContextHandle context, Constant<int, ALEnum, PointerPName> pname);

    [NativeName("alGetPointerEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
    void* GetPointerEXT(int pname);

    [NativeName("alGetPointerEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
    Ptr GetPointerEXT(Constant<int, ALEnum, PointerPName> pname);

    [NativeName("alGetPointerSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
    void* GetPointerSOFT(int pname);

    [NativeName("alGetPointerSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
    Ptr GetPointerSOFT(Constant<int, ALEnum, PointerPName> pname);

    [NativeName("alGetPointervDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
    void GetPointerDirectEXT(ContextHandle context, int pname, void** values);

    [NativeName("alGetPointervDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
    void GetPointerDirectEXT(
        ContextHandle context,
        Constant<int, ALEnum, PointerPName> pname,
        Ref2D values
    );

    [NativeName("alGetPointervDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectSOFT")]
    void GetPointerDirectSOFT(ContextHandle context, int pname, void** values);

    [NativeName("alGetPointervDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectSOFT")]
    void GetPointerDirectSOFT(
        ContextHandle context,
        Constant<int, ALEnum, PointerPName> pname,
        Ref2D values
    );

    [NativeName("alGetPointervEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
    void GetPointerEXT(int pname, void** values);

    [NativeName("alGetPointervEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
    void GetPointerEXT(Constant<int, ALEnum, PointerPName> pname, Ref2D values);

    [NativeName("alGetPointervSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
    void GetPointerSOFT(int pname, void** values);

    [NativeName("alGetPointervSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
    void GetPointerSOFT(Constant<int, ALEnum, PointerPName> pname, Ref2D values);

    [NativeName("alGetProcAddress")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    void* GetProcAddress(sbyte* fname);

    [NativeName("alGetProcAddress")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    Ptr GetProcAddress(Ref<sbyte> fname);

    [NativeName("alGetProcAddressDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
    void* GetProcAddressDirect(ContextHandle context, sbyte* fname);

    [NativeName("alGetProcAddressDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
    Ptr GetProcAddressDirect(ContextHandle context, Ref<sbyte> fname);

    [NativeName("alGetSource3dDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3dDirectSOFT")]
    void GetSource3DirectSOFT(
        ContextHandle context,
        uint source,
        int param2,
        double* value1,
        double* value2,
        double* value3
    );

    [NativeName("alGetSource3dDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3dDirectSOFT")]
    void GetSource3DirectSOFT(
        ContextHandle context,
        uint source,
        int param2,
        Ref<double> value1,
        Ref<double> value2,
        Ref<double> value3
    );

    [NativeName("alGetSource3dSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
    void GetSource3SOFT(uint source, int param1, double* value1, double* value2, double* value3);

    [NativeName("alGetSource3dSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
    void GetSource3SOFT(
        uint source,
        int param1,
        Ref<double> value1,
        Ref<double> value2,
        Ref<double> value3
    );

    [NativeName("alGetSource3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    void GetSource3(uint source, int param1, float* value1, float* value2, float* value3);

    [NativeName("alGetSource3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    void GetSource3(
        uint source,
        Constant<int, ALEnum, SourceFloat3> param1,
        Ref<float> value1,
        Ref<float> value2,
        Ref<float> value3
    );

    [NativeName("alGetSource3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
    void GetSource3Direct(
        ContextHandle context,
        uint source,
        int param2,
        float* value1,
        float* value2,
        float* value3
    );

    [NativeName("alGetSource3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
    void GetSource3Direct(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceFloat3> param2,
        Ref<float> value1,
        Ref<float> value2,
        Ref<float> value3
    );

    [NativeName("alGetSource3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    void GetSource3(uint source, int param1, int* value1, int* value2, int* value3);

    [NativeName("alGetSource3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    void GetSource3(
        uint source,
        Constant<int, ALEnum, SourceInteger3> param1,
        Ref<int> value1,
        Ref<int> value2,
        Ref<int> value3
    );

    [NativeName("alGetSource3i64DirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3i64DirectSOFT")]
    void GetSource3DirectSOFT(
        ContextHandle context,
        uint source,
        int param2,
        nint* value1,
        nint* value2,
        nint* value3
    );

    [NativeName("alGetSource3i64DirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3i64DirectSOFT")]
    void GetSource3DirectSOFT(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger3> param2,
        Ref<nint> value1,
        Ref<nint> value2,
        Ref<nint> value3
    );

    [NativeName("alGetSource3i64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
    void GetSource3SOFT(uint source, int param1, nint* value1, nint* value2, nint* value3);

    [NativeName("alGetSource3i64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
    void GetSource3SOFT(
        uint source,
        Constant<int, ALEnum, SourceInteger3> param1,
        Ref<nint> value1,
        Ref<nint> value2,
        Ref<nint> value3
    );

    [NativeName("alGetSource3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
    void GetSource3Direct(
        ContextHandle context,
        uint source,
        int param2,
        int* value1,
        int* value2,
        int* value3
    );

    [NativeName("alGetSource3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
    void GetSource3Direct(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger3> param2,
        Ref<int> value1,
        Ref<int> value2,
        Ref<int> value3
    );

    [NativeName("alGetSourcedDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcedDirectSOFT")]
    void GetSourceDirectSOFT(ContextHandle context, uint source, int param2, double* value);

    [NativeName("alGetSourcedDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcedDirectSOFT")]
    void GetSourceDirectSOFT(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceDouble> param2,
        Ref<double> value
    );

    [NativeName("alGetSourcedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
    void GetSourceSOFT(uint source, int param1, double* value);

    [NativeName("alGetSourcedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
    void GetSourceSOFT(uint source, Constant<int, ALEnum, SourceDouble> param1, Ref<double> value);

    [NativeName("alGetSourcedvDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcedvDirectSOFT")]
    void GetSourcedvDirectSOFT(ContextHandle context, uint source, int param2, double* values);

    [NativeName("alGetSourcedvDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcedvDirectSOFT")]
    void GetSourcedvDirectSOFT(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceDouble> param2,
        Ref<double> values
    );

    [NativeName("alGetSourcedvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
    void GetSourcedvSOFT(uint source, int param1, double* values);

    [NativeName("alGetSourcedvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
    void GetSourcedvSOFT(
        uint source,
        Constant<int, ALEnum, SourceDouble> param1,
        Ref<double> values
    );

    [NativeName("alGetSourcef")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcef")]
    void GetSourcef(uint source, int param1, float* value);

    [NativeName("alGetSourcef")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcef")]
    void GetSourcef(uint source, Constant<int, ALEnum, SourceFloat> param1, Ref<float> value);

    [NativeName("alGetSourcefDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
    void GetSourcefDirect(ContextHandle context, uint source, int param2, float* value);

    [NativeName("alGetSourcefDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
    void GetSourcefDirect(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceFloat> param2,
        Ref<float> value
    );

    [NativeName("alGetSourcefv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
    void GetSourcefv(uint source, int param1, float* values);

    [NativeName("alGetSourcefv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
    void GetSourcefv(uint source, Constant<int, ALEnum, SourceFloat> param1, Ref<float> values);

    [NativeName("alGetSourcefvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
    void GetSourcefvDirect(ContextHandle context, uint source, int param2, float* values);

    [NativeName("alGetSourcefvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
    void GetSourcefvDirect(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceFloat> param2,
        Ref<float> values
    );

    [NativeName("alGetSourcei")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcei")]
    void GetSourcei(uint source, int param1, int* value);

    [NativeName("alGetSourcei")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcei")]
    void GetSourcei(uint source, Constant<int, ALEnum, SourceInteger> param1, Ref<int> value);

    [NativeName("alGetSourcei64DirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64DirectSOFT")]
    void GetSourcei64DirectSOFT(ContextHandle context, uint source, int param2, nint* value);

    [NativeName("alGetSourcei64DirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64DirectSOFT")]
    void GetSourcei64DirectSOFT(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger> param2,
        Ref<nint> value
    );

    [NativeName("alGetSourcei64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
    void GetSourcei64SOFT(uint source, int param1, nint* value);

    [NativeName("alGetSourcei64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
    void GetSourcei64SOFT(
        uint source,
        Constant<int, ALEnum, SourceInteger> param1,
        Ref<nint> value
    );

    [NativeName("alGetSourcei64vDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64vDirectSOFT")]
    void GetSourcei64vDirectSOFT(ContextHandle context, uint source, int param2, nint* values);

    [NativeName("alGetSourcei64vDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64vDirectSOFT")]
    void GetSourcei64vDirectSOFT(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger> param2,
        Ref<nint> values
    );

    [NativeName("alGetSourcei64vSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
    void GetSourcei64vSOFT(uint source, int param1, nint* values);

    [NativeName("alGetSourcei64vSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
    void GetSourcei64vSOFT(
        uint source,
        Constant<int, ALEnum, SourceInteger> param1,
        Ref<nint> values
    );

    [NativeName("alGetSourceiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
    void GetSourceiDirect(ContextHandle context, uint source, int param2, int* value);

    [NativeName("alGetSourceiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
    void GetSourceiDirect(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger> param2,
        Ref<int> value
    );

    [NativeName("alGetSourceiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
    void GetSourceiv(uint source, int param1, int* values);

    [NativeName("alGetSourceiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
    void GetSourceiv(uint source, Constant<int, ALEnum, SourceInteger> param1, Ref<int> values);

    [NativeName("alGetSourceivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
    void GetSourceivDirect(ContextHandle context, uint source, int param2, int* values);

    [NativeName("alGetSourceivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
    void GetSourceivDirect(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger> param2,
        Ref<int> values
    );

    [NativeName("alGetString")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    sbyte* GetString(int param0);

    [NativeName("alGetString")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    Ptr<sbyte> GetString(Constant<int, ALEnum, StringPName> param0);

    [NativeName("alGetStringDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
    sbyte* GetStringDirect(ContextHandle context, int param1);

    [NativeName("alGetStringDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
    Ptr<sbyte> GetStringDirect(ContextHandle context, Constant<int, ALEnum, StringPName> param1);

    [NativeName("alGetStringiDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_resampler"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_resampler"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetStringiDirectSOFT")]
    sbyte* GetStringDirectSOFT(ContextHandle context, int pname, int index);

    [NativeName("alGetStringiDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_resampler"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_resampler"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alGetStringiDirectSOFT")]
    Ptr<sbyte> GetStringDirectSOFT(
        ContextHandle context,
        Constant<int, ALEnum, StringPName> pname,
        int index
    );

    [NativeName("alGetStringiSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
    [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
    sbyte* GetStringSOFT(int pname, int index);

    [NativeName("alGetStringiSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
    [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
    Ptr<sbyte> GetStringSOFT(Constant<int, ALEnum, StringPName> pname, int index);

    [NativeName("alIsAuxiliaryEffectSlot")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
    MaybeBool<sbyte> IsAuxiliaryEffectSlot(uint effectslot);

    [NativeName("alIsAuxiliaryEffectSlotDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
    MaybeBool<sbyte> IsAuxiliaryEffectSlotDirect(ContextHandle context, uint effectslot);

    [NativeName("alIsAuxiliaryEffectSlotDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
    sbyte IsAuxiliaryEffectSlotDirectRawDirect(ContextHandle context, uint effectslot);

    [NativeName("alIsAuxiliaryEffectSlot")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
    sbyte IsAuxiliaryEffectSlotRaw(uint effectslot);

    [NativeName("alIsBuffer")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    MaybeBool<sbyte> IsBuffer(uint buffer);

    [NativeName("alIsBufferDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
    MaybeBool<sbyte> IsBufferDirect(ContextHandle context, uint buffer);

    [NativeName("alIsBufferDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
    sbyte IsBufferDirectRawDirect(ContextHandle context, uint buffer);

    [NativeName("alIsBufferFormatSupportedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
    MaybeBool<sbyte> IsBufferFormatSupportedSOFT(int format);

    [NativeName("alIsBufferFormatSupportedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
    sbyte IsBufferFormatSupportedSOFTRawSOFT(int format);

    [NativeName("alIsBuffer")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    sbyte IsBufferRaw(uint buffer);

    [NativeName("alIsEffect")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsEffect")]
    MaybeBool<sbyte> IsEffect(uint effect);

    [NativeName("alIsEffectDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
    MaybeBool<sbyte> IsEffectDirect(ContextHandle context, uint effect);

    [NativeName("alIsEffectDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
    sbyte IsEffectDirectRawDirect(ContextHandle context, uint effect);

    [NativeName("alIsEffect")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsEffect")]
    sbyte IsEffectRaw(uint effect);

    [NativeName("alIsEnabled")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    sbyte IsEnabled(int capability);

    [NativeName("alIsEnabled")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    MaybeBool<sbyte> IsEnabled(Constant<int, ALEnum, EnableCap> capability);

    [NativeName("alIsEnabledDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
    sbyte IsEnabledDirect(ContextHandle context, int capability);

    [NativeName("alIsEnabledDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
    MaybeBool<sbyte> IsEnabledDirect(
        ContextHandle context,
        Constant<int, ALEnum, EnableCap> capability
    );

    [NativeName("alIsExtensionPresent")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
    sbyte IsExtensionPresent(sbyte* extname);

    [NativeName("alIsExtensionPresent")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
    MaybeBool<sbyte> IsExtensionPresent(Ref<sbyte> extname);

    [NativeName("alIsExtensionPresentDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
    sbyte IsExtensionPresentDirect(ContextHandle context, sbyte* extname);

    [NativeName("alIsExtensionPresentDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
    MaybeBool<sbyte> IsExtensionPresentDirect(ContextHandle context, Ref<sbyte> extname);

    [NativeName("alIsFilter")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsFilter")]
    MaybeBool<sbyte> IsFilter(uint filter);

    [NativeName("alIsFilterDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
    MaybeBool<sbyte> IsFilterDirect(ContextHandle context, uint filter);

    [NativeName("alIsFilterDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
    sbyte IsFilterDirectRawDirect(ContextHandle context, uint filter);

    [NativeName("alIsFilter")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsFilter")]
    sbyte IsFilterRaw(uint filter);

    [NativeName("alIsSource")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    MaybeBool<sbyte> IsSource(uint source);

    [NativeName("alIsSourceDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
    MaybeBool<sbyte> IsSourceDirect(ContextHandle context, uint source);

    [NativeName("alIsSourceDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
    sbyte IsSourceDirectRawDirect(ContextHandle context, uint source);

    [NativeName("alIsSource")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    sbyte IsSourceRaw(uint source);

    [NativeName("alListener3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3f")]
    void Listener3(int param0, float value1, float value2, float value3);

    [NativeName("alListener3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3f")]
    void Listener3(
        Constant<int, ALEnum, ListenerFloat3> param0,
        float value1,
        float value2,
        float value3
    );

    [NativeName("alListener3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
    void Listener3Direct(
        ContextHandle context,
        int param1,
        float value1,
        float value2,
        float value3
    );

    [NativeName("alListener3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
    void Listener3Direct(
        ContextHandle context,
        Constant<int, ALEnum, ListenerFloat3> param1,
        float value1,
        float value2,
        float value3
    );

    [NativeName("alListener3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3i")]
    void Listener3(int param0, int value1, int value2, int value3);

    [NativeName("alListener3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3i")]
    void Listener3(
        Constant<int, ALEnum, ListenerInteger3> param0,
        int value1,
        int value2,
        int value3
    );

    [NativeName("alListener3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
    void Listener3Direct(ContextHandle context, int param1, int value1, int value2, int value3);

    [NativeName("alListener3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
    void Listener3Direct(
        ContextHandle context,
        Constant<int, ALEnum, ListenerInteger3> param1,
        int value1,
        int value2,
        int value3
    );

    [NativeName("alListenerf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerf")]
    void Listener(int param0, float value);

    [NativeName("alListenerf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerf")]
    void Listener(Constant<int, ALEnum, ListenerFloat> param0, float value);

    [NativeName("alListenerfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
    void ListenerDirect(ContextHandle context, int param1, float value);

    [NativeName("alListenerfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
    void ListenerDirect(
        ContextHandle context,
        Constant<int, ALEnum, ListenerFloat> param1,
        float value
    );

    [NativeName("alListenerfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    void Listener(int param0, float* values);

    [NativeName("alListenerfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    void Listener(Constant<int, ALEnum, ListenerFloat> param0, Ref<float> values);

    [NativeName("alListenerfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
    void ListenerDirect(ContextHandle context, int param1, float* values);

    [NativeName("alListenerfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
    void ListenerDirect(
        ContextHandle context,
        Constant<int, ALEnum, ListenerFloat> param1,
        Ref<float> values
    );

    [NativeName("alListeneri")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListeneri")]
    void Listener(int param0, int value);

    [NativeName("alListeneriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListeneriDirect")]
    void ListenerDirect(ContextHandle context, int param1, int value);

    [NativeName("alListeneriv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    void Listener(int param0, int* values);

    [NativeName("alListeneriv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    void Listener(int param0, Ref<int> values);

    [NativeName("alListenerivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
    void ListenerDirect(ContextHandle context, int param1, int* values);

    [NativeName("alListenerivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
    void ListenerDirect(ContextHandle context, int param1, Ref<int> values);

    [NativeName("alObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
    void ObjectLabelDirectEXT(
        ContextHandle context,
        int identifier,
        uint name,
        int length,
        sbyte* label
    );

    [NativeName("alObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
    void ObjectLabelDirectEXT(
        ContextHandle context,
        Constant<int, ALEnum, ObjectIdentifier> identifier,
        uint name,
        int length,
        Ref<sbyte> label
    );

    [NativeName("alObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
    void ObjectLabelDirectEXT(
        ContextHandle context,
        Constant<int, ALEnum, ObjectIdentifier> identifier,
        uint name,
        sbyte label
    );

    [NativeName("alObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
    void ObjectLabelEXT(int identifier, uint name, int length, sbyte* label);

    [NativeName("alObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
    void ObjectLabelEXT(
        Constant<int, ALEnum, ObjectIdentifier> identifier,
        uint name,
        int length,
        Ref<sbyte> label
    );

    [NativeName("alObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
    void ObjectLabelEXT(Constant<int, ALEnum, ObjectIdentifier> identifier, uint name, sbyte label);

    [NativeName("alPopDebugGroupDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alPopDebugGroupDirectEXT")]
    void PopDebugGroupDirectEXT(ContextHandle context);

    [NativeName("alPopDebugGroupEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alPopDebugGroupEXT")]
    void PopDebugGroupEXT();

    [NativeName("alProcessUpdatesDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_deferred_updates"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_deferred_updates"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alProcessUpdatesDirectSOFT")]
    void ProcessUpdatesDirectSOFT(ContextHandle context);

    [NativeName("alProcessUpdatesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
    [NativeFunction("openal", EntryPoint = "alProcessUpdatesSOFT")]
    void ProcessUpdatesSOFT();

    [NativeName("alPushDebugGroupDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
    void PushDebugGroupDirectEXT(
        ContextHandle context,
        int source,
        uint id,
        int length,
        sbyte* message
    );

    [NativeName("alPushDebugGroupDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
    void PushDebugGroupDirectEXT(
        ContextHandle context,
        Constant<int, ALEnum, DebugSourceEXT> source,
        uint id,
        int length,
        Ref<sbyte> message
    );

    [NativeName("alPushDebugGroupDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
    void PushDebugGroupDirectEXT(
        ContextHandle context,
        Constant<int, ALEnum, DebugSourceEXT> source,
        uint id,
        sbyte message
    );

    [NativeName("alPushDebugGroupEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
    void PushDebugGroupEXT(int source, uint id, int length, sbyte* message);

    [NativeName("alPushDebugGroupEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
    void PushDebugGroupEXT(
        Constant<int, ALEnum, DebugSourceEXT> source,
        uint id,
        int length,
        Ref<sbyte> message
    );

    [NativeName("alPushDebugGroupEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
    void PushDebugGroupEXT(Constant<int, ALEnum, DebugSourceEXT> source, uint id, sbyte message);

    [NativeName("alRequestFoldbackStart")]
    [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
    void RequestFoldbackStart(
        int mode,
        int count,
        int length,
        float* mem,
        FoldbackCallback callback
    );

    [NativeName("alRequestFoldbackStart")]
    [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
    void RequestFoldbackStart(
        int mode,
        int count,
        int length,
        Ref<float> mem,
        FoldbackCallback callback
    );

    [NativeName("alRequestFoldbackStartDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStartDirect")]
    void RequestFoldbackStartDirect(
        ContextHandle context,
        int mode,
        int count,
        int length,
        float* mem,
        FoldbackCallback callback
    );

    [NativeName("alRequestFoldbackStartDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStartDirect")]
    void RequestFoldbackStartDirect(
        ContextHandle context,
        int mode,
        int count,
        int length,
        Ref<float> mem,
        FoldbackCallback callback
    );

    [NativeName("alRequestFoldbackStop")]
    [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStop")]
    void RequestFoldbackStop();

    [NativeName("alRequestFoldbackStopDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStopDirect")]
    void RequestFoldbackStopDirect(ContextHandle context);

    [NativeName("alSource3dDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSource3dDirectSOFT")]
    void Source3DirectSOFT(
        ContextHandle context,
        uint source,
        int param2,
        double value1,
        double value2,
        double value3
    );

    [NativeName("alSource3dSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSource3dSOFT")]
    void Source3SOFT(uint source, int param1, double value1, double value2, double value3);

    [NativeName("alSource3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3f")]
    void Source3(uint source, int param1, float value1, float value2, float value3);

    [NativeName("alSource3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3f")]
    void Source3(
        uint source,
        Constant<int, ALEnum, SourceFloat3> param1,
        float value1,
        float value2,
        float value3
    );

    [NativeName("alSource3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
    void Source3Direct(
        ContextHandle context,
        uint source,
        int param2,
        float value1,
        float value2,
        float value3
    );

    [NativeName("alSource3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
    void Source3Direct(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceFloat3> param2,
        float value1,
        float value2,
        float value3
    );

    [NativeName("alSource3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3i")]
    void Source3(uint source, int param1, int value1, int value2, int value3);

    [NativeName("alSource3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3i")]
    void Source3(
        uint source,
        Constant<int, ALEnum, SourceInteger3> param1,
        int value1,
        int value2,
        int value3
    );

    [NativeName("alSource3i64DirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSource3i64DirectSOFT")]
    void Source3DirectSOFT(
        ContextHandle context,
        uint source,
        int param2,
        nint value1,
        nint value2,
        nint value3
    );

    [NativeName("alSource3i64DirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSource3i64DirectSOFT")]
    void Source3DirectSOFT(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger3> param2,
        nint value1,
        nint value2,
        nint value3
    );

    [NativeName("alSource3i64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
    void Source3SOFT(uint source, int param1, nint value1, nint value2, nint value3);

    [NativeName("alSource3i64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
    void Source3SOFT(
        uint source,
        Constant<int, ALEnum, SourceInteger3> param1,
        nint value1,
        nint value2,
        nint value3
    );

    [NativeName("alSource3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
    void Source3Direct(
        ContextHandle context,
        uint source,
        int param2,
        int value1,
        int value2,
        int value3
    );

    [NativeName("alSource3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
    void Source3Direct(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger3> param2,
        int value1,
        int value2,
        int value3
    );

    [NativeName("alSourcedDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcedDirectSOFT")]
    void SourceDirectSOFT(ContextHandle context, uint source, int param2, double value);

    [NativeName("alSourcedDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcedDirectSOFT")]
    void SourceDirectSOFT(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceDouble> param2,
        double value
    );

    [NativeName("alSourcedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
    void SourceSOFT(uint source, int param1, double value);

    [NativeName("alSourcedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
    void SourceSOFT(uint source, Constant<int, ALEnum, SourceDouble> param1, double value);

    [NativeName("alSourcedvDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcedvDirectSOFT")]
    void SourceDirectSOFT(ContextHandle context, uint source, int param2, double* values);

    [NativeName("alSourcedvDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcedvDirectSOFT")]
    void SourceDirectSOFT(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceDouble> param2,
        Ref<double> values
    );

    [NativeName("alSourcedvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
    void SourceSOFT(uint source, int param1, double* values);

    [NativeName("alSourcedvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
    void SourceSOFT(uint source, Constant<int, ALEnum, SourceDouble> param1, Ref<double> values);

    [NativeName("alSourcef")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcef")]
    void Source(uint source, int param1, float value);

    [NativeName("alSourcef")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcef")]
    void Source(uint source, Constant<int, ALEnum, SourceFloat> param1, float value);

    [NativeName("alSourcefDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
    void SourceDirect(ContextHandle context, uint source, int param2, float value);

    [NativeName("alSourcefDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
    void SourceDirect(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceFloat> param2,
        float value
    );

    [NativeName("alSourcefv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    void Source(uint source, int param1, float* values);

    [NativeName("alSourcefv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    void Source(uint source, Constant<int, ALEnum, SourceFloat> param1, Ref<float> values);

    [NativeName("alSourcefvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
    void SourceDirect(ContextHandle context, uint source, int param2, float* values);

    [NativeName("alSourcefvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
    void SourceDirect(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceFloat> param2,
        Ref<float> values
    );

    [NativeName("alSourcei")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcei")]
    void Source(uint source, int param1, int value);

    [NativeName("alSourcei")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcei")]
    void Source(uint source, Constant<int, ALEnum, SourceInteger> param1, int value);

    [NativeName("alSourcei64DirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcei64DirectSOFT")]
    void SourceDirectSOFT(ContextHandle context, uint source, int param2, nint value);

    [NativeName("alSourcei64DirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcei64DirectSOFT")]
    void SourceDirectSOFT(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger> param2,
        nint value
    );

    [NativeName("alSourcei64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
    void SourceSOFT(uint source, int param1, nint value);

    [NativeName("alSourcei64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
    void SourceSOFT(uint source, Constant<int, ALEnum, SourceInteger> param1, nint value);

    [NativeName("alSourcei64vDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcei64vDirectSOFT")]
    void SourceDirectSOFT(ContextHandle context, uint source, int param2, nint* values);

    [NativeName("alSourcei64vDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_latency"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcei64vDirectSOFT")]
    void SourceDirectSOFT(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger> param2,
        Ref<nint> values
    );

    [NativeName("alSourcei64vSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
    void SourceSOFT(uint source, int param1, nint* values);

    [NativeName("alSourcei64vSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
    void SourceSOFT(uint source, Constant<int, ALEnum, SourceInteger> param1, Ref<nint> values);

    [NativeName("alSourceiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
    void SourceDirect(ContextHandle context, uint source, int param2, int value);

    [NativeName("alSourceiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
    void SourceDirect(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger> param2,
        int value
    );

    [NativeName("alSourceiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    void Source(uint source, int param1, int* values);

    [NativeName("alSourceiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    void Source(uint source, Constant<int, ALEnum, SourceInteger> param1, Ref<int> values);

    [NativeName("alSourceivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
    void SourceDirect(ContextHandle context, uint source, int param2, int* values);

    [NativeName("alSourceivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
    void SourceDirect(
        ContextHandle context,
        uint source,
        Constant<int, ALEnum, SourceInteger> param2,
        Ref<int> values
    );

    [NativeName("alSourcePause")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePause")]
    void SourcePause(uint source);

    [NativeName("alSourcePauseDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePauseDirect")]
    void SourcePauseDirect(ContextHandle context, uint source);

    [NativeName("alSourcePausev")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    void SourcePausev(int n, uint* sources);

    [NativeName("alSourcePausev")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    void SourcePausev(int n, Ref<uint> sources);

    [NativeName("alSourcePausev")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    void SourcePausev(uint sources);

    [NativeName("alSourcePausevDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
    void SourcePausevDirect(ContextHandle context, int n, uint* sources);

    [NativeName("alSourcePausevDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
    void SourcePausevDirect(ContextHandle context, int n, Ref<uint> sources);

    [NativeName("alSourcePausevDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
    void SourcePausevDirect(ContextHandle context, uint sources);

    [NativeName("alSourcePlay")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePlay")]
    void SourcePlay(uint source);

    [NativeName("alSourcePlayAtTimeDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimeDirectSOFT")]
    void SourcePlayAtTimeDirectSOFT(ContextHandle context, uint source, nint start_time);

    [NativeName("alSourcePlayAtTimeSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimeSOFT")]
    void SourcePlayAtTimeSOFT(uint source, nint start_time);

    [NativeName("alSourcePlayAtTimevDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevDirectSOFT")]
    void SourcePlayAtTimevDirectSOFT(ContextHandle context, int n, uint* sources, nint start_time);

    [NativeName("alSourcePlayAtTimevDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevDirectSOFT")]
    void SourcePlayAtTimevDirectSOFT(
        ContextHandle context,
        int n,
        Ref<uint> sources,
        nint start_time
    );

    [NativeName("alSourcePlayAtTimevDirectSOFT")]
    [
        SupportedApiProfile(
            "al",
            ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
            RequireAll = true
        ),
        SupportedApiProfile(
            "alc",
            ["AL_EXT_direct_context", "AL_SOFT_source_start_delay"],
            RequireAll = true
        )
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevDirectSOFT")]
    void SourcePlayAtTimevDirectSOFT(ContextHandle context, uint sources, nint start_time);

    [NativeName("alSourcePlayAtTimevSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
    void SourcePlayAtTimevSOFT(int n, uint* sources, nint start_time);

    [NativeName("alSourcePlayAtTimevSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
    void SourcePlayAtTimevSOFT(int n, Ref<uint> sources, nint start_time);

    [NativeName("alSourcePlayAtTimevSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
    void SourcePlayAtTimevSOFT(uint sources, nint start_time);

    [NativeName("alSourcePlayDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayDirect")]
    void SourcePlayDirect(ContextHandle context, uint source);

    [NativeName("alSourcePlayv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    void SourcePlayv(int n, uint* sources);

    [NativeName("alSourcePlayv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    void SourcePlayv(int n, Ref<uint> sources);

    [NativeName("alSourcePlayv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    void SourcePlayv(uint sources);

    [NativeName("alSourcePlayvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
    void SourcePlayvDirect(ContextHandle context, int n, uint* sources);

    [NativeName("alSourcePlayvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
    void SourcePlayvDirect(ContextHandle context, int n, Ref<uint> sources);

    [NativeName("alSourcePlayvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
    void SourcePlayvDirect(ContextHandle context, uint sources);

    [NativeName("alSourceQueueBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
    void SourceQueueBuffers(uint source, int nb, uint* buffers);

    [NativeName("alSourceQueueBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
    void SourceQueueBuffers(uint source, int nb, Ref<uint> buffers);

    [NativeName("alSourceQueueBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
    void SourceQueueBuffersDirect(ContextHandle context, uint source, int nb, uint* buffers);

    [NativeName("alSourceQueueBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
    void SourceQueueBuffersDirect(ContextHandle context, uint source, int nb, Ref<uint> buffers);

    [NativeName("alSourceRewind")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewind")]
    void SourceRewind(uint source);

    [NativeName("alSourceRewindDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceRewindDirect")]
    void SourceRewindDirect(ContextHandle context, uint source);

    [NativeName("alSourceRewindv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewindv(int n, uint* sources);

    [NativeName("alSourceRewindv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewindv(int n, Ref<uint> sources);

    [NativeName("alSourceRewindv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewindv(uint sources);

    [NativeName("alSourceRewindvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
    void SourceRewindvDirect(ContextHandle context, int n, uint* sources);

    [NativeName("alSourceRewindvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
    void SourceRewindvDirect(ContextHandle context, int n, Ref<uint> sources);

    [NativeName("alSourceRewindvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
    void SourceRewindvDirect(ContextHandle context, uint sources);

    [NativeName("alSourceStop")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceStop")]
    void SourceStop(uint source);

    [NativeName("alSourceStopDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceStopDirect")]
    void SourceStopDirect(ContextHandle context, uint source);

    [NativeName("alSourceStopv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    void SourceStopv(int n, uint* sources);

    [NativeName("alSourceStopv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    void SourceStopv(int n, Ref<uint> sources);

    [NativeName("alSourceStopv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    void SourceStopv(uint sources);

    [NativeName("alSourceStopvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
    void SourceStopvDirect(ContextHandle context, int n, uint* sources);

    [NativeName("alSourceStopvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
    void SourceStopvDirect(ContextHandle context, int n, Ref<uint> sources);

    [NativeName("alSourceStopvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
    void SourceStopvDirect(ContextHandle context, uint sources);

    [NativeName("alSourceUnqueueBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
    void SourceUnqueueBuffers(uint source, int nb, uint* buffers);

    [NativeName("alSourceUnqueueBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
    void SourceUnqueueBuffers(uint source, int nb, Ref<uint> buffers);

    [NativeName("alSourceUnqueueBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
    void SourceUnqueueBuffersDirect(ContextHandle context, uint source, int nb, uint* buffers);

    [NativeName("alSourceUnqueueBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
    void SourceUnqueueBuffersDirect(ContextHandle context, uint source, int nb, Ref<uint> buffers);

    [NativeName("alSpeedOfSound")]
    [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
    void SpeedOfSound(float value);

    [NativeName("alSpeedOfSoundDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSpeedOfSoundDirect")]
    void SpeedOfSoundDirect(ContextHandle context, float value);

    [NativeName("EAXGetBufferModeDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
    int EAXGetBufferModeDirect(ContextHandle context, uint buffer, int* pReserved);

    [NativeName("EAXGetBufferModeDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
    int EAXGetBufferModeDirect(ContextHandle context, uint buffer, Ref<int> pReserved);

    [NativeName("EAXGetDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
    int EAXGetDirect(
        ContextHandle context,
        System.Guid* property_set_id,
        uint property_id,
        uint source_id,
        void* value,
        uint value_size
    );

    [NativeName("EAXGetDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
    int EAXGetDirect(
        ContextHandle context,
        Ref<System.Guid> property_set_id,
        uint property_id,
        uint source_id,
        Ref value,
        uint value_size
    );

    [NativeName("EAXSetBufferModeDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
    sbyte EAXSetBufferModeDirect(ContextHandle context, int n, uint* buffers, int value);

    [NativeName("EAXSetBufferModeDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
    MaybeBool<sbyte> EAXSetBufferModeDirect(
        ContextHandle context,
        int n,
        Ref<uint> buffers,
        int value
    );

    [NativeName("EAXSetDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
    int EAXSetDirect(
        ContextHandle context,
        System.Guid* property_set_id,
        uint property_id,
        uint source_id,
        void* value,
        uint value_size
    );

    [NativeName("EAXSetDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
    int EAXSetDirect(
        ContextHandle context,
        Ref<System.Guid> property_set_id,
        uint property_id,
        uint source_id,
        Ref value,
        uint value_size
    );
}
