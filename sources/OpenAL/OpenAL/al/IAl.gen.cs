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

public unsafe partial interface IAl
{
    public partial interface Static
    {
        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alAuxiliaryEffectSlotf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
        static abstract void AuxiliaryEffectSlot(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] int param1,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alAuxiliaryEffectSlotf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
        static abstract void AuxiliaryEffectSlot(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alAuxiliaryEffectSlotfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] int param2,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alAuxiliaryEffectSlotfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alAuxiliaryEffectSlotfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
        static abstract void AuxiliaryEffectSlot(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] int param1,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alAuxiliaryEffectSlotfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
        static abstract void AuxiliaryEffectSlot(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alAuxiliaryEffectSlotfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] int param2,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alAuxiliaryEffectSlotfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alAuxiliaryEffectSloti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
        static abstract void AuxiliaryEffectSlot(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] int param1,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alAuxiliaryEffectSloti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
        static abstract void AuxiliaryEffectSlot(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alAuxiliaryEffectSlotiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] int param2,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alAuxiliaryEffectSlotiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alAuxiliaryEffectSlotiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
        static abstract void AuxiliaryEffectSlot(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] int param1,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alAuxiliaryEffectSlotiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
        static abstract void AuxiliaryEffectSlot(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alAuxiliaryEffectSlotivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] int param2,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alAuxiliaryEffectSlotivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alBuffer3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBuffer3f")]
        static abstract void Buffer3(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("value1")] float value1,
            [NativeName("value2")] float value2,
            [NativeName("value3")] float value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBuffer3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBuffer3fDirect")]
        static abstract void Buffer3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("value1")] float value1,
            [NativeName("value2")] float value2,
            [NativeName("value3")] float value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alBuffer3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBuffer3i")]
        static abstract void Buffer3(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("value1")] int value1,
            [NativeName("value2")] int value2,
            [NativeName("value3")] int value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBuffer3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBuffer3iDirect")]
        static abstract void Buffer3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("value1")] int value1,
            [NativeName("value2")] int value2,
            [NativeName("value3")] int value3
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] int format,
            [NativeName("freq")] int freq,
            [NativeName("callback")] BufferCallbackSoft callback,
            [NativeName("userptr")] void* userptr
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("freq")] int freq,
            [NativeName("callback")] BufferCallbackSoft callback,
            [NativeName("userptr")] Ref userptr
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alBufferCallbackSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
        static abstract void BufferCallbackSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] int format,
            [NativeName("freq")] int freq,
            [NativeName("callback")] BufferCallbackSoft callback,
            [NativeName("userptr")] void* userptr
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alBufferCallbackSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
        static abstract void BufferCallbackSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("freq")] int freq,
            [NativeName("callback")] BufferCallbackSoft callback,
            [NativeName("userptr")] Ref userptr
        );

        [NativeName("alBufferData")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        static abstract void BufferData(
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] int format,
            [NativeName("data")] void* data,
            [NativeName("size")] int size,
            [NativeName("samplerate")] int samplerate
        );

        [NativeName("alBufferData")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        static abstract void BufferData(
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("data")] Ref data,
            [NativeName("size")] int size,
            [NativeName("samplerate")] int samplerate
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBufferDataDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
        static abstract void BufferDataDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] int format,
            [NativeName("data")] void* data,
            [NativeName("size")] int size,
            [NativeName("samplerate")] int samplerate
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBufferDataDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
        static abstract void BufferDataDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("data")] Ref data,
            [NativeName("size")] int size,
            [NativeName("samplerate")] int samplerate
        );

        [NativeName("alBufferDataStatic")]
        [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
        [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
        static abstract void BufferDataStatic(
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] int format,
            [NativeName("data")] void* data,
            [NativeName("size")] int size,
            [NativeName("freq")] int freq
        );

        [NativeName("alBufferDataStatic")]
        [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
        [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
        static abstract void BufferDataStatic(
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("data")] Ref data,
            [NativeName("size")] int size,
            [NativeName("freq")] int freq
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] int format,
            [NativeName("data")] void* data,
            [NativeName("size")] int size,
            [NativeName("freq")] int freq
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("data")] Ref data,
            [NativeName("size")] int size,
            [NativeName("freq")] int freq
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alBufferf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferf")]
        static abstract void Buffer(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alBufferf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferf")]
        static abstract void Buffer(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] Constant<int, AlEnum, BufferFloat> param1,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBufferfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
        static abstract void BufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBufferfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
        static abstract void BufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] Constant<int, AlEnum, BufferFloat> param2,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alBufferfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        static abstract void Buffer(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alBufferfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        static abstract void Buffer(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] Constant<int, AlEnum, BufferFloat> param1,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBufferfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
        static abstract void BufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBufferfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
        static abstract void BufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] Constant<int, AlEnum, BufferFloat> param2,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alBufferi")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferi")]
        static abstract void Buffer(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alBufferi")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferi")]
        static abstract void Buffer(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] Constant<int, AlEnum, BufferInteger> param1,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBufferiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
        static abstract void BufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBufferiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
        static abstract void BufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] Constant<int, AlEnum, BufferInteger> param2,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alBufferiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        static abstract void Buffer(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alBufferiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        static abstract void Buffer(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] Constant<int, AlEnum, BufferInteger> param1,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBufferivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
        static abstract void BufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alBufferivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
        static abstract void BufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] Constant<int, AlEnum, BufferInteger> param2,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alBufferSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
        static abstract void BufferSamplesSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("samplerate")] uint samplerate,
            [NativeName("internalformat")] int internalformat,
            [NativeName("samples")] int samples,
            [NativeName("channels")] int channels,
            [NativeName("type")] int type,
            [NativeName("data")] void* data
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alBufferSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
        static abstract void BufferSamplesSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("samplerate")] uint samplerate,
            [NativeName("internalformat")] int internalformat,
            [NativeName("samples")] int samples,
            [NativeName("channels")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
            [NativeName("type")] Constant<int, AlEnum, SampleTypeSOFT> type,
            [NativeName("data")] Ref data
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] int format,
            [NativeName("data")] void* data,
            [NativeName("offset")] int offset,
            [NativeName("length")] int length
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("data")] Ref data,
            [NativeName("offset")] int offset,
            [NativeName("length")] int length
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alBufferSubDataSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
        [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
        static abstract void BufferSubDataSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] int format,
            [NativeName("data")] void* data,
            [NativeName("offset")] int offset,
            [NativeName("length")] int length
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alBufferSubDataSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
        [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
        static abstract void BufferSubDataSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("format")] Constant<int, AlEnum, Format> format,
            [NativeName("data")] Ref data,
            [NativeName("offset")] int offset,
            [NativeName("length")] int length
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alBufferSubSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
        static abstract void BufferSubSamplesSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("offset")] int offset,
            [NativeName("samples")] int samples,
            [NativeName("channels")] int channels,
            [NativeName("type")] int type,
            [NativeName("data")] void* data
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alBufferSubSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
        static abstract void BufferSubSamplesSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("offset")] int offset,
            [NativeName("samples")] int samples,
            [NativeName("channels")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
            [NativeName("type")] Constant<int, AlEnum, SampleTypeSOFT> type,
            [NativeName("data")] Ref data
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageCallbackDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
        static abstract void DebugMessageCallbackDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("callback")] DebugProcExt callback,
            [NativeName("userParam")] void* userParam
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageCallbackDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
        static abstract void DebugMessageCallbackDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("callback")] DebugProcExt callback,
            [NativeName("userParam")] Ref userParam
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageCallbackEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
        static abstract void DebugMessageCallbackEXT(
            [NativeName("callback")] DebugProcExt callback,
            [NativeName("userParam")] void* userParam
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageCallbackEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
        static abstract void DebugMessageCallbackEXT(
            [NativeName("callback")] DebugProcExt callback,
            [NativeName("userParam")] Ref userParam
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageControlDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
        static abstract void DebugMessageControlDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] int source,
            [NativeName("type")] int type,
            [NativeName("severity")] int severity,
            [NativeName("count")] int count,
            [NativeName("ids")] uint* ids,
            [NativeName("enable")] sbyte enable
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageControlDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
        static abstract void DebugMessageControlDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeName("count")] int count,
            [NativeName("ids")] Ref<uint> ids,
            [NativeName("enable")] MaybeBool<sbyte> enable
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageControlDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
        static abstract void DebugMessageControlDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeName("ids")] uint ids,
            [NativeName("enable")] MaybeBool<sbyte> enable
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageControlEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
        static abstract void DebugMessageControlEXT(
            [NativeName("source")] int source,
            [NativeName("type")] int type,
            [NativeName("severity")] int severity,
            [NativeName("count")] int count,
            [NativeName("ids")] uint* ids,
            [NativeName("enable")] sbyte enable
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageControlEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
        static abstract void DebugMessageControlEXT(
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeName("count")] int count,
            [NativeName("ids")] Ref<uint> ids,
            [NativeName("enable")] MaybeBool<sbyte> enable
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageControlEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
        static abstract void DebugMessageControlEXT(
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeName("ids")] uint ids,
            [NativeName("enable")] MaybeBool<sbyte> enable
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageInsertDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
        static abstract void DebugMessageInsertDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] int source,
            [NativeName("type")] int type,
            [NativeName("id")] uint id,
            [NativeName("severity")] int severity,
            [NativeName("length")] int length,
            [NativeName("message")] sbyte* message
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageInsertDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
        static abstract void DebugMessageInsertDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeName("id")] uint id,
            [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeName("length")] int length,
            [NativeName("message")] Ref<sbyte> message
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageInsertDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
        static abstract void DebugMessageInsertDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeName("id")] uint id,
            [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeName("message")] sbyte message
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageInsertEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
        static abstract void DebugMessageInsertEXT(
            [NativeName("source")] int source,
            [NativeName("type")] int type,
            [NativeName("id")] uint id,
            [NativeName("severity")] int severity,
            [NativeName("length")] int length,
            [NativeName("message")] sbyte* message
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageInsertEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
        static abstract void DebugMessageInsertEXT(
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeName("id")] uint id,
            [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeName("length")] int length,
            [NativeName("message")] Ref<sbyte> message
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alDebugMessageInsertEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
        static abstract void DebugMessageInsertEXT(
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeName("id")] uint id,
            [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeName("message")] sbyte message
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void DeferUpdatesDirectSOFT([NativeName("context")] ContextHandle context);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alDeferUpdatesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
        [NativeFunction("openal", EntryPoint = "alDeferUpdatesSOFT")]
        static abstract void DeferUpdatesSOFT();

        [NativeName("alDeleteAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
        static abstract void DeleteAuxiliaryEffectSlot(
            [NativeName("effectslots")] uint effectslots
        );

        [NativeName("alDeleteAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
        static abstract void DeleteAuxiliaryEffectSlots(
            [NativeName("n")] int n,
            [NativeName("effectslots")] uint* effectslots
        );

        [NativeName("alDeleteAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
        static abstract void DeleteAuxiliaryEffectSlots(
            [NativeName("n")] int n,
            [NativeName("effectslots")] Ref<uint> effectslots
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
        static abstract void DeleteAuxiliaryEffectSlotsDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("effectslots")] uint* effectslots
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
        static abstract void DeleteAuxiliaryEffectSlotsDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("effectslots")] Ref<uint> effectslots
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
        static abstract void DeleteAuxiliaryEffectSlotsDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslots")] uint effectslots
        );

        [NativeName("alDeleteBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffer([NativeName("buffers")] uint buffers);

        [NativeName("alDeleteBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffers(
            [NativeName("n")] int n,
            [NativeName("buffers")] uint* buffers
        );

        [NativeName("alDeleteBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffers(
            [NativeName("n")] int n,
            [NativeName("buffers")] Ref<uint> buffers
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
        static abstract void DeleteBuffersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("buffers")] uint* buffers
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
        static abstract void DeleteBuffersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("buffers")] Ref<uint> buffers
        );

        [NativeName("alDeleteEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
        static abstract void DeleteEffect([NativeName("effects")] uint effects);

        [NativeName("alDeleteEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
        static abstract void DeleteEffects(
            [NativeName("n")] int n,
            [NativeName("effects")] uint* effects
        );

        [NativeName("alDeleteEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
        static abstract void DeleteEffects(
            [NativeName("n")] int n,
            [NativeName("effects")] Ref<uint> effects
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
        static abstract void DeleteEffectsDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("effects")] uint* effects
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
        static abstract void DeleteEffectsDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("effects")] Ref<uint> effects
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
        static abstract void DeleteEffectsDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effects")] uint effects
        );

        [NativeName("alDeleteFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
        static abstract void DeleteFilter([NativeName("filters")] uint filters);

        [NativeName("alDeleteFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
        static abstract void DeleteFilters(
            [NativeName("n")] int n,
            [NativeName("filters")] uint* filters
        );

        [NativeName("alDeleteFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
        static abstract void DeleteFilters(
            [NativeName("n")] int n,
            [NativeName("filters")] Ref<uint> filters
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
        static abstract void DeleteFiltersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("filters")] uint* filters
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
        static abstract void DeleteFiltersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("filters")] Ref<uint> filters
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
        static abstract void DeleteFiltersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filters")] uint filters
        );

        [NativeName("alDeleteSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSource([NativeName("sources")] uint sources);

        [NativeName("alDeleteSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSources(
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NativeName("alDeleteSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSources(
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
        static abstract void DeleteSourcesDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
        static abstract void DeleteSourcesDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDeleteSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
        static abstract void DeleteSourcesDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("sources")] uint sources
        );

        [NativeName("alDisable")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        static abstract void Disable([NativeName("capability")] int capability);

        [NativeName("alDisable")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        static abstract void Disable(
            [NativeName("capability")] Constant<int, AlEnum, EnableCap> capability
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDisableDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDisableDirect")]
        static abstract void DisableDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("capability")] int capability
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDisableDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDisableDirect")]
        static abstract void DisableDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("capability")] Constant<int, AlEnum, EnableCap> capability
        );

        [NativeName("alDistanceModel")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        static abstract void DistanceModel([NativeName("distanceModel")] int distanceModel);

        [NativeName("alDistanceModel")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        static abstract void DistanceModel(
            [NativeName("distanceModel")] Constant<int, AlEnum, DistanceModel> distanceModel
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDistanceModelDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
        static abstract void DistanceModelDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("distanceModel")] int distanceModel
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDistanceModelDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
        static abstract void DistanceModelDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("distanceModel")] Constant<int, AlEnum, DistanceModel> distanceModel
        );

        [NativeName("alDopplerFactor")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
        static abstract void DopplerFactor([NativeName("value")] float value);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alDopplerFactorDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDopplerFactorDirect")]
        static abstract void DopplerFactorDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("value")] float value
        );

        [NativeName("alDopplerVelocity")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
        static abstract void DopplerVelocity([NativeName("value")] float value);

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alEffectf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectf")]
        static abstract void Effect(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] int param1,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alEffectf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectf")]
        static abstract void Effect(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] Constant<int, AlEnum, EffectFloat> param1,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alEffectfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
        static abstract void EffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] int param2,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alEffectfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
        static abstract void EffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] Constant<int, AlEnum, EffectFloat> param2,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alEffectfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectfv")]
        static abstract void Effect(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] int param1,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alEffectfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectfv")]
        static abstract void Effect(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] Constant<int, AlEnum, EffectFloat> param1,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alEffectfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
        static abstract void EffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] int param2,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alEffectfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
        static abstract void EffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] Constant<int, AlEnum, EffectFloat> param2,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alEffecti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffecti")]
        static abstract void Effect(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] int param1,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alEffecti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffecti")]
        static abstract void Effect(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] Constant<int, AlEnum, EffectInteger> param1,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alEffectiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
        static abstract void EffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] int param2,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alEffectiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
        static abstract void EffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] Constant<int, AlEnum, EffectInteger> param2,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alEffectiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectiv")]
        static abstract void Effect(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] int param1,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alEffectiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectiv")]
        static abstract void Effect(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] Constant<int, AlEnum, EffectInteger> param1,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alEffectivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
        static abstract void EffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] int param2,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alEffectivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
        static abstract void EffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] Constant<int, AlEnum, EffectInteger> param2,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NativeName("alEnable")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        static abstract void Enable([NativeName("capability")] int capability);

        [NativeName("alEnable")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        static abstract void Enable(
            [NativeName("capability")] Constant<int, AlEnum, EnableCap> capability
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alEnableDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alEnableDirect")]
        static abstract void EnableDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("capability")] int capability
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alEnableDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alEnableDirect")]
        static abstract void EnableDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("capability")] Constant<int, AlEnum, EnableCap> capability
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("callback")] EventProcSoft callback,
            [NativeName("userParam")] void* userParam
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("callback")] EventProcSoft callback,
            [NativeName("userParam")] Ref userParam
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alEventCallbackSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
        static abstract void EventCallbackSOFT(
            [NativeName("callback")] EventProcSoft callback,
            [NativeName("userParam")] void* userParam
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alEventCallbackSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
        static abstract void EventCallbackSOFT(
            [NativeName("callback")] EventProcSoft callback,
            [NativeName("userParam")] Ref userParam
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("count")] int count,
            [NativeName("types")] int* types,
            [NativeName("enable")] sbyte enable
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("count")] int count,
            [NativeName("types")] Ref<int> types,
            [NativeName("enable")] MaybeBool<sbyte> enable
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("types")] int types,
            [NativeName("enable")] MaybeBool<sbyte> enable
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alEventControlSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
        static abstract void EventControlSOFT(
            [NativeName("count")] int count,
            [NativeName("types")] int* types,
            [NativeName("enable")] sbyte enable
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alEventControlSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
        static abstract void EventControlSOFT(
            [NativeName("count")] int count,
            [NativeName("types")] Ref<int> types,
            [NativeName("enable")] MaybeBool<sbyte> enable
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alEventControlSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
        static abstract void EventControlSOFT(
            [NativeName("types")] int types,
            [NativeName("enable")] MaybeBool<sbyte> enable
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alFilterf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilterf")]
        static abstract void Filter(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] int param1,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alFilterf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilterf")]
        static abstract void Filter(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] Constant<int, AlEnum, FilterFloat> param1,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alFilterfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
        static abstract void FilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] int param2,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alFilterfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
        static abstract void FilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] Constant<int, AlEnum, FilterFloat> param2,
            [NativeName("flValue")] float flValue
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alFilterfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilterfv")]
        static abstract void Filter(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] int param1,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alFilterfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilterfv")]
        static abstract void Filter(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] Constant<int, AlEnum, FilterFloat> param1,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alFilterfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
        static abstract void FilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] int param2,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alFilterfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
        static abstract void FilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] Constant<int, AlEnum, FilterFloat> param2,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alFilteri")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilteri")]
        static abstract void Filter(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] int param1,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alFilteri")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilteri")]
        static abstract void Filter(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] Constant<int, AlEnum, FilterInteger> param1,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alFilteriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
        static abstract void FilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] int param2,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alFilteriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
        static abstract void FilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] Constant<int, AlEnum, FilterInteger> param2,
            [NativeName("iValue")] int iValue
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alFilteriv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilteriv")]
        static abstract void Filter(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] int param1,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alFilteriv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilteriv")]
        static abstract void Filter(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] Constant<int, AlEnum, FilterInteger> param1,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alFilterivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
        static abstract void FilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] int param2,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alFilterivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
        static abstract void FilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] Constant<int, AlEnum, FilterInteger> param2,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NativeName("alGenAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
        static abstract uint GenAuxiliaryEffectSlot();

        [NativeName("alGenAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
        static abstract void GenAuxiliaryEffectSlots(
            [NativeName("n")] int n,
            [NativeName("effectslots")] uint* effectslots
        );

        [NativeName("alGenAuxiliaryEffectSlots")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
        static abstract void GenAuxiliaryEffectSlots(
            [NativeName("n")] int n,
            [NativeName("effectslots")] Ref<uint> effectslots
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
        static abstract void GenAuxiliaryEffectSlotsDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("effectslots")] uint* effectslots
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
        static abstract void GenAuxiliaryEffectSlotsDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("effectslots")] Ref<uint> effectslots
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenAuxiliaryEffectSlotsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
        static abstract uint GenAuxiliaryEffectSlotsDirect(
            [NativeName("context")] ContextHandle context
        );

        [NativeName("alGenBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract uint GenBuffer();

        [NativeName("alGenBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract void GenBuffers(
            [NativeName("n")] int n,
            [NativeName("buffers")] uint* buffers
        );

        [NativeName("alGenBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract void GenBuffers(
            [NativeName("n")] int n,
            [NativeName("buffers")] Ref<uint> buffers
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
        static abstract void GenBuffersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("buffers")] uint* buffers
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
        static abstract void GenBuffersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("buffers")] Ref<uint> buffers
        );

        [NativeName("alGenEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenEffects")]
        static abstract uint GenEffect();

        [NativeName("alGenEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenEffects")]
        static abstract void GenEffects(
            [NativeName("n")] int n,
            [NativeName("effects")] uint* effects
        );

        [NativeName("alGenEffects")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenEffects")]
        static abstract void GenEffects(
            [NativeName("n")] int n,
            [NativeName("effects")] Ref<uint> effects
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
        static abstract void GenEffectsDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("effects")] uint* effects
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
        static abstract void GenEffectsDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("effects")] Ref<uint> effects
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenEffectsDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
        static abstract uint GenEffectsDirect([NativeName("context")] ContextHandle context);

        [NativeName("alGenFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenFilters")]
        static abstract uint GenFilter();

        [NativeName("alGenFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenFilters")]
        static abstract void GenFilters(
            [NativeName("n")] int n,
            [NativeName("filters")] uint* filters
        );

        [NativeName("alGenFilters")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenFilters")]
        static abstract void GenFilters(
            [NativeName("n")] int n,
            [NativeName("filters")] Ref<uint> filters
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
        static abstract void GenFiltersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("filters")] uint* filters
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
        static abstract void GenFiltersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("filters")] Ref<uint> filters
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenFiltersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
        static abstract uint GenFiltersDirect([NativeName("context")] ContextHandle context);

        [NativeName("alGenSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract uint GenSource();

        [NativeName("alGenSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract void GenSources(
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NativeName("alGenSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract void GenSources(
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
        static abstract void GenSourcesDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
        static abstract void GenSourcesDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGenSourcesDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
        static abstract uint GenSourcesDirect([NativeName("context")] ContextHandle context);

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetAuxiliaryEffectSlotf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
        static abstract void AlGetAuxiliaryEffectSlotf(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] int param1,
            [NativeName("flValue")] float* flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetAuxiliaryEffectSlotf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
        static abstract void AlGetAuxiliaryEffectSlotf(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
            [NativeName("flValue")] Ref<float> flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetAuxiliaryEffectSlotfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
        static abstract void AlGetAuxiliaryEffectSlotfDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] int param2,
            [NativeName("pflValue")] float* pflValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetAuxiliaryEffectSlotfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
        static abstract void AlGetAuxiliaryEffectSlotfDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
            [NativeName("pflValue")] Ref<float> pflValue
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetAuxiliaryEffectSlotfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
        static abstract void AlGetAuxiliaryEffectSlotfv(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] int param1,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetAuxiliaryEffectSlotfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
        static abstract void AlGetAuxiliaryEffectSlotfv(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetAuxiliaryEffectSlotfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
        static abstract void AlGetAuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] int param2,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetAuxiliaryEffectSlotfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
        static abstract void AlGetAuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetAuxiliaryEffectSloti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
        static abstract void AlGetAuxiliaryEffectSloti(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] int param1,
            [NativeName("iValue")] int* iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetAuxiliaryEffectSloti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
        static abstract void AlGetAuxiliaryEffectSloti(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
            [NativeName("iValue")] Ref<int> iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetAuxiliaryEffectSlotiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
        static abstract void AlGetAuxiliaryEffectSlotiDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] int param2,
            [NativeName("piValue")] int* piValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetAuxiliaryEffectSlotiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
        static abstract void AlGetAuxiliaryEffectSlotiDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
            [NativeName("piValue")] Ref<int> piValue
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetAuxiliaryEffectSlotiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
        static abstract void AlGetAuxiliaryEffectSlotiv(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] int param1,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetAuxiliaryEffectSlotiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
        static abstract void AlGetAuxiliaryEffectSlotiv(
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetAuxiliaryEffectSlotivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
        static abstract void AlGetAuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] int param2,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetAuxiliaryEffectSlotivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
        static abstract void AlGetAuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot,
            [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NativeName("alGetBoolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        static abstract sbyte GetBoolean([NativeName("param0")] int param0);

        [NativeName("alGetBoolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        static abstract MaybeBool<sbyte> GetBoolean(
            [NativeName("param0")] Constant<int, AlEnum, BooleanPName> param0
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBooleanDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
        static abstract sbyte GetBooleanDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBooleanDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
        static abstract MaybeBool<sbyte> GetBooleanDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, BooleanPName> param1
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alGetBooleanv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        static abstract void GetBoolean(
            [NativeName("param0")] int param0,
            [NativeName("values")] sbyte* values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alGetBooleanv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        static abstract void GetBoolean(
            [NativeName("param0")] Constant<int, AlEnum, BooleanPName> param0,
            [NativeName("values")] Ref<sbyte> values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBooleanvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
        static abstract void GetBooleanDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("values")] sbyte* values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBooleanvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
        static abstract void GetBooleanDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, BooleanPName> param1,
            [NativeName("values")] Ref<sbyte> values
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetBuffer3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        static abstract void GetBuffer3(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("value1")] float* value1,
            [NativeName("value2")] float* value2,
            [NativeName("value3")] float* value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetBuffer3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        static abstract void GetBuffer3(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("value1")] Ref<float> value1,
            [NativeName("value2")] Ref<float> value2,
            [NativeName("value3")] Ref<float> value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBuffer3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
        static abstract void GetBuffer3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("value1")] float* value1,
            [NativeName("value2")] float* value2,
            [NativeName("value3")] float* value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBuffer3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
        static abstract void GetBuffer3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("value1")] Ref<float> value1,
            [NativeName("value2")] Ref<float> value2,
            [NativeName("value3")] Ref<float> value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetBuffer3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        static abstract void GetBuffer3(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("value1")] int* value1,
            [NativeName("value2")] int* value2,
            [NativeName("value3")] int* value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetBuffer3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        static abstract void GetBuffer3(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("value1")] Ref<int> value1,
            [NativeName("value2")] Ref<int> value2,
            [NativeName("value3")] Ref<int> value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBuffer3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
        static abstract void GetBuffer3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("value1")] int* value1,
            [NativeName("value2")] int* value2,
            [NativeName("value3")] int* value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBuffer3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
        static abstract void GetBuffer3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("value1")] Ref<int> value1,
            [NativeName("value2")] Ref<int> value2,
            [NativeName("value3")] Ref<int> value3
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("ptr0")] void** ptr0,
            [NativeName("ptr1")] void** ptr1,
            [NativeName("ptr2")] void** ptr2
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] Constant<int, AlEnum, BufferPointerSOFT> param2,
            [NativeName("ptr0")] Ref2D ptr0,
            [NativeName("ptr1")] Ref2D ptr1,
            [NativeName("ptr2")] Ref2D ptr2
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetBuffer3PtrSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
        static abstract void GetBuffer3PtrSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("ptr0")] void** ptr0,
            [NativeName("ptr1")] void** ptr1,
            [NativeName("ptr2")] void** ptr2
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetBuffer3PtrSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
        static abstract void GetBuffer3PtrSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] Constant<int, AlEnum, BufferPointerSOFT> param1,
            [NativeName("ptr0")] Ref2D ptr0,
            [NativeName("ptr1")] Ref2D ptr1,
            [NativeName("ptr2")] Ref2D ptr2
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetBufferf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        static abstract void AlGetBufferf(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("value")] float* value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetBufferf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        static abstract void AlGetBufferf(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] Constant<int, AlEnum, BufferFloat> param1,
            [NativeName("value")] Ref<float> value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBufferfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
        static abstract void AlGetBufferfDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("value")] float* value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBufferfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
        static abstract void AlGetBufferfDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] Constant<int, AlEnum, BufferFloat> param2,
            [NativeName("value")] Ref<float> value
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetBufferfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        static abstract void AlGetBufferfv(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetBufferfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        static abstract void AlGetBufferfv(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] Constant<int, AlEnum, BufferFloat> param1,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBufferfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
        static abstract void AlGetBufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBufferfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
        static abstract void AlGetBufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] Constant<int, AlEnum, BufferFloat> param2,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetBufferi")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        static abstract void AlGetBufferi(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("value")] int* value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetBufferi")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        static abstract void AlGetBufferi(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] Constant<int, AlEnum, BufferInteger> param1,
            [NativeName("value")] Ref<int> value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBufferiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
        static abstract void AlGetBufferiDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("value")] int* value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBufferiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
        static abstract void AlGetBufferiDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] Constant<int, AlEnum, BufferInteger> param2,
            [NativeName("value")] Ref<int> value
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetBufferiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        static abstract void AlGetBufferiv(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetBufferiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        static abstract void AlGetBufferiv(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] Constant<int, AlEnum, BufferInteger> param1,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBufferivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
        static abstract void AlGetBufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetBufferivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
        static abstract void AlGetBufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] Constant<int, AlEnum, BufferInteger> param2,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("ptr")] void** ptr
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] Constant<int, AlEnum, BufferPointerSOFT> param2,
            [NativeName("ptr")] Ref2D ptr
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetBufferPtrSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
        static abstract void GetBufferPtrSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("ptr")] void** ptr
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetBufferPtrSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
        static abstract void GetBufferPtrSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] Constant<int, AlEnum, BufferPointerSOFT> param1,
            [NativeName("ptr")] Ref2D ptr
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void AlGetBufferPtr(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] int param2,
            [NativeName("ptr")] void** ptr
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void AlGetBufferPtr(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("param2")] Constant<int, AlEnum, BufferPointerSOFT> param2,
            [NativeName("ptr")] Ref2D ptr
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetBufferPtrvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
        static abstract void AlGetBufferPtr(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] int param1,
            [NativeName("ptr")] void** ptr
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetBufferPtrvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
        static abstract void AlGetBufferPtr(
            [NativeName("buffer")] uint buffer,
            [NativeName("param1")] Constant<int, AlEnum, BufferPointerSOFT> param1,
            [NativeName("ptr")] Ref2D ptr
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetBufferSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
        static abstract void GetBufferSamplesSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("offset")] int offset,
            [NativeName("samples")] int samples,
            [NativeName("channels")] int channels,
            [NativeName("type")] int type,
            [NativeName("data")] void* data
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetBufferSamplesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
        static abstract void GetBufferSamplesSOFT(
            [NativeName("buffer")] uint buffer,
            [NativeName("offset")] int offset,
            [NativeName("samples")] int samples,
            [NativeName("channels")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
            [NativeName("type")] Constant<int, AlEnum, SampleTypeSOFT> type,
            [NativeName("data")] Ref data
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetDebugMessageLogDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("count")] uint count,
            [NativeName("logBufSize")] int logBufSize,
            [NativeName("sources")] int* sources,
            [NativeName("types")] int* types,
            [NativeName("ids")] uint* ids,
            [NativeName("severities")] int* severities,
            [NativeName("lengths")] int* lengths,
            [NativeName("logBuf")] sbyte* logBuf
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetDebugMessageLogDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("count")] uint count,
            [NativeName("logBufSize")] int logBufSize,
            [NativeName("sources")] Ref<int> sources,
            [NativeName("types")] Ref<int> types,
            [NativeName("ids")] Ref<uint> ids,
            [NativeName("severities")] Ref<int> severities,
            [NativeName("lengths")] Ref<int> lengths,
            [NativeName("logBuf")] Ref<sbyte> logBuf
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetDebugMessageLogDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("count")] uint count,
            [NativeName("logBufSize")] int logBufSize,
            [NativeName("sources")] Ref<AlEnum> sources,
            [NativeName("types")] Ref<AlEnum> types,
            [NativeName("ids")] Ref<uint> ids,
            [NativeName("severities")] Ref<AlEnum> severities,
            [NativeName("lengths")] Ref<int> lengths,
            [NativeName("logBuf")] Ref<sbyte> logBuf
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetDebugMessageLogDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("count")] uint count,
            [NativeName("logBufSize")] int logBufSize,
            [NativeName("sources")] Ref<DebugSourceEXT> sources,
            [NativeName("types")] Ref<DebugTypeEXT> types,
            [NativeName("ids")] Ref<uint> ids,
            [NativeName("severities")] Ref<DebugSeverityEXT> severities,
            [NativeName("lengths")] Ref<int> lengths,
            [NativeName("logBuf")] Ref<sbyte> logBuf
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetDebugMessageLogEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogEXT(
            [NativeName("count")] uint count,
            [NativeName("logBufSize")] int logBufSize,
            [NativeName("sources")] int* sources,
            [NativeName("types")] int* types,
            [NativeName("ids")] uint* ids,
            [NativeName("severities")] int* severities,
            [NativeName("lengths")] int* lengths,
            [NativeName("logBuf")] sbyte* logBuf
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetDebugMessageLogEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogEXT(
            [NativeName("count")] uint count,
            [NativeName("logBufSize")] int logBufSize,
            [NativeName("sources")] Ref<int> sources,
            [NativeName("types")] Ref<int> types,
            [NativeName("ids")] Ref<uint> ids,
            [NativeName("severities")] Ref<int> severities,
            [NativeName("lengths")] Ref<int> lengths,
            [NativeName("logBuf")] Ref<sbyte> logBuf
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetDebugMessageLogEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogEXT(
            [NativeName("count")] uint count,
            [NativeName("logBufSize")] int logBufSize,
            [NativeName("sources")] Ref<AlEnum> sources,
            [NativeName("types")] Ref<AlEnum> types,
            [NativeName("ids")] Ref<uint> ids,
            [NativeName("severities")] Ref<AlEnum> severities,
            [NativeName("lengths")] Ref<int> lengths,
            [NativeName("logBuf")] Ref<sbyte> logBuf
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetDebugMessageLogEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogEXT(
            [NativeName("count")] uint count,
            [NativeName("logBufSize")] int logBufSize,
            [NativeName("sources")] Ref<DebugSourceEXT> sources,
            [NativeName("types")] Ref<DebugTypeEXT> types,
            [NativeName("ids")] Ref<uint> ids,
            [NativeName("severities")] Ref<DebugSeverityEXT> severities,
            [NativeName("lengths")] Ref<int> lengths,
            [NativeName("logBuf")] Ref<sbyte> logBuf
        );

        [NativeName("alGetDouble")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        static abstract double GetDouble([NativeName("param0")] int param0);

        [NativeName("alGetDouble")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        static abstract double GetDouble(
            [NativeName("param0")] Constant<int, AlEnum, GetPName> param0
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetDoubleDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
        static abstract double GetDoubleDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetDoubleDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
        static abstract double GetDoubleDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, GetPName> param1
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alGetDoublev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        static abstract void GetDouble(
            [NativeName("param0")] int param0,
            [NativeName("values")] double* values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alGetDoublev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        static abstract void GetDouble(
            [NativeName("param0")] Constant<int, AlEnum, GetPName> param0,
            [NativeName("values")] Ref<double> values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetDoublevDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
        static abstract void GetDoubleDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("values")] double* values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetDoublevDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
        static abstract void GetDoubleDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, GetPName> param1,
            [NativeName("values")] Ref<double> values
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetEffectf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectf")]
        static abstract void AlGetEffectf(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] int param1,
            [NativeName("flValue")] float* flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetEffectf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectf")]
        static abstract void AlGetEffectf(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] Constant<int, AlEnum, EffectFloat> param1,
            [NativeName("flValue")] Ref<float> flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetEffectfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
        static abstract void AlGetEffectfDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] int param2,
            [NativeName("pflValue")] float* pflValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetEffectfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
        static abstract void AlGetEffectfDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] Constant<int, AlEnum, EffectFloat> param2,
            [NativeName("pflValue")] Ref<float> pflValue
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetEffectfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
        static abstract void AlGetEffectfv(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] int param1,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetEffectfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
        static abstract void AlGetEffectfv(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] Constant<int, AlEnum, EffectFloat> param1,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetEffectfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
        static abstract void AlGetEffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] int param2,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetEffectfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
        static abstract void AlGetEffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] Constant<int, AlEnum, EffectFloat> param2,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetEffecti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffecti")]
        static abstract void AlGetEffecti(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] int param1,
            [NativeName("iValue")] int* iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetEffecti")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffecti")]
        static abstract void AlGetEffecti(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] Constant<int, AlEnum, EffectInteger> param1,
            [NativeName("iValue")] Ref<int> iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetEffectiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
        static abstract void AlGetEffectiDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] int param2,
            [NativeName("piValue")] int* piValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetEffectiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
        static abstract void AlGetEffectiDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] Constant<int, AlEnum, EffectInteger> param2,
            [NativeName("piValue")] Ref<int> piValue
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetEffectiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
        static abstract void AlGetEffectiv(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] int param1,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetEffectiv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
        static abstract void AlGetEffectiv(
            [NativeName("effect")] uint effect,
            [NativeName("param1")] Constant<int, AlEnum, EffectInteger> param1,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetEffectivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
        static abstract void AlGetEffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] int param2,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetEffectivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
        static abstract void AlGetEffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect,
            [NativeName("param2")] Constant<int, AlEnum, EffectInteger> param2,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NativeName("alGetEnumValue")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        static abstract int GetEnumValue([NativeName("ename")] sbyte* ename);

        [NativeName("alGetEnumValue")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        static abstract int GetEnumValue([NativeName("ename")] Ref<sbyte> ename);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetEnumValueDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
        static abstract int GetEnumValueDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("ename")] sbyte* ename
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetEnumValueDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
        static abstract int GetEnumValueDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("ename")] Ref<sbyte> ename
        );

        [NativeName("alGetError")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        static abstract Constant<int, ErrorCode> GetError();

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetErrorDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
        static abstract Constant<int, ErrorCode> GetErrorDirect(
            [NativeName("context")] ContextHandle context
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetErrorDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
        static abstract int GetErrorDirectRawDirect([NativeName("context")] ContextHandle context);

        [NativeName("alGetError")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        static abstract int GetErrorRaw();

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetFilterf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilterf")]
        static abstract void AlGetFilterf(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] int param1,
            [NativeName("flValue")] float* flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetFilterf")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilterf")]
        static abstract void AlGetFilterf(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] Constant<int, AlEnum, FilterFloat> param1,
            [NativeName("flValue")] Ref<float> flValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFilterfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
        static abstract void AlGetFilterfDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] int param2,
            [NativeName("pflValue")] float* pflValue
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFilterfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
        static abstract void AlGetFilterfDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] Constant<int, AlEnum, FilterFloat> param2,
            [NativeName("pflValue")] Ref<float> pflValue
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetFilterfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
        static abstract void AlGetFilterfv(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] int param1,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetFilterfv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
        static abstract void AlGetFilterfv(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] Constant<int, AlEnum, FilterFloat> param1,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFilterfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
        static abstract void AlGetFilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] int param2,
            [NativeName("pflValues")] float* pflValues
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFilterfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
        static abstract void AlGetFilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] Constant<int, AlEnum, FilterFloat> param2,
            [NativeName("pflValues")] Ref<float> pflValues
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetFilteri")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilteri")]
        static abstract void AlGetFilteri(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] int param1,
            [NativeName("iValue")] int* iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetFilteri")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilteri")]
        static abstract void AlGetFilteri(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] Constant<int, AlEnum, FilterInteger> param1,
            [NativeName("iValue")] Ref<int> iValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFilteriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
        static abstract void AlGetFilteriDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] int param2,
            [NativeName("piValue")] int* piValue
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFilteriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
        static abstract void AlGetFilteriDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] Constant<int, AlEnum, FilterInteger> param2,
            [NativeName("piValue")] Ref<int> piValue
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetFilteriv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
        static abstract void AlGetFilteriv(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] int param1,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetFilteriv")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
        static abstract void AlGetFilteriv(
            [NativeName("filter")] uint filter,
            [NativeName("param1")] Constant<int, AlEnum, FilterInteger> param1,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFilterivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
        static abstract void AlGetFilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] int param2,
            [NativeName("piValues")] int* piValues
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFilterivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
        static abstract void AlGetFilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter,
            [NativeName("param2")] Constant<int, AlEnum, FilterInteger> param2,
            [NativeName("piValues")] Ref<int> piValues
        );

        [NativeName("alGetFloat")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        static abstract float GetFloat([NativeName("param0")] int param0);

        [NativeName("alGetFloat")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        static abstract float GetFloat(
            [NativeName("param0")] Constant<int, AlEnum, FloatPName> param0
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFloatDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
        static abstract float GetFloatDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFloatDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
        static abstract float GetFloatDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, FloatPName> param1
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alGetFloatv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        static abstract void GetFloat(
            [NativeName("param0")] int param0,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alGetFloatv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        static abstract void GetFloat(
            [NativeName("param0")] Constant<int, AlEnum, GetPName> param0,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFloatvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
        static abstract void GetFloatDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetFloatvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
        static abstract void GetFloatDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, GetPName> param1,
            [NativeName("values")] Ref<float> values
        );

        [NativeName("alGetInteger")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        static abstract int GetInteger([NativeName("param0")] int param0);

        [NativeName("alGetInteger")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        static abstract int GetInteger(
            [NativeName("param0")] Constant<int, AlEnum, IntegerPName> param0
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetIntegerDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
        static abstract int GetIntegerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetIntegerDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
        static abstract int GetIntegerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, IntegerPName> param1
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alGetIntegerv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        static abstract void GetInteger(
            [NativeName("param0")] int param0,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alGetIntegerv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        static abstract void GetInteger(
            [NativeName("param0")] Constant<int, AlEnum, IntegerPName> param0,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetIntegervDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
        static abstract void GetIntegerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetIntegervDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
        static abstract void GetIntegerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, IntegerPName> param1,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetListener3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        static abstract void GetListener3(
            [NativeName("param0")] int param0,
            [NativeName("value1")] float* value1,
            [NativeName("value2")] float* value2,
            [NativeName("value3")] float* value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetListener3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        static abstract void GetListener3(
            [NativeName("param0")] Constant<int, AlEnum, ListenerFloat3> param0,
            [NativeName("value1")] Ref<float> value1,
            [NativeName("value2")] Ref<float> value2,
            [NativeName("value3")] Ref<float> value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListener3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
        static abstract void GetListener3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("value1")] float* value1,
            [NativeName("value2")] float* value2,
            [NativeName("value3")] float* value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListener3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
        static abstract void GetListener3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, ListenerFloat3> param1,
            [NativeName("value1")] Ref<float> value1,
            [NativeName("value2")] Ref<float> value2,
            [NativeName("value3")] Ref<float> value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetListener3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        static abstract void GetListener3(
            [NativeName("param0")] int param0,
            [NativeName("value1")] int* value1,
            [NativeName("value2")] int* value2,
            [NativeName("value3")] int* value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetListener3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        static abstract void GetListener3(
            [NativeName("param0")] Constant<int, AlEnum, ListenerInteger3> param0,
            [NativeName("value1")] Ref<int> value1,
            [NativeName("value2")] Ref<int> value2,
            [NativeName("value3")] Ref<int> value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListener3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
        static abstract void GetListener3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("value1")] int* value1,
            [NativeName("value2")] int* value2,
            [NativeName("value3")] int* value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListener3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
        static abstract void GetListener3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, ListenerInteger3> param1,
            [NativeName("value1")] Ref<int> value1,
            [NativeName("value2")] Ref<int> value2,
            [NativeName("value3")] Ref<int> value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetListenerf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        static abstract void AlGetListenerf(
            [NativeName("param0")] int param0,
            [NativeName("value")] float* value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetListenerf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        static abstract void AlGetListenerf(
            [NativeName("param0")] Constant<int, AlEnum, ListenerFloat> param0,
            [NativeName("value")] Ref<float> value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListenerfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
        static abstract void AlGetListenerfDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("value")] float* value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListenerfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
        static abstract void AlGetListenerfDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, ListenerFloat> param1,
            [NativeName("value")] Ref<float> value
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetListenerfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        static abstract void AlGetListenerfv(
            [NativeName("param0")] int param0,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetListenerfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        static abstract void AlGetListenerfv(
            [NativeName("param0")] Constant<int, AlEnum, ListenerFloat> param0,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListenerfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
        static abstract void AlGetListenerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListenerfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
        static abstract void AlGetListenerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, ListenerFloat> param1,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetListeneri")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract void AlGetListeneri(
            [NativeName("param0")] int param0,
            [NativeName("value")] int* value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetListeneri")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract void AlGetListeneri(
            [NativeName("param0")] int param0,
            [NativeName("value")] Ref<int> value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetListeneri")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract int AlGetListeneri();

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListeneriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
        static abstract void AlGetListeneriDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("value")] int* value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListeneriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
        static abstract void AlGetListeneriDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("value")] Ref<int> value
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract void AlGetListeneriv(
            [NativeName("param0")] int param0,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract void AlGetListeneriv(
            [NativeName("param0")] int param0,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract int AlGetListeneriv();

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListenerivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
        static abstract void AlGetListenerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetListenerivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
        static abstract void AlGetListenerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
        static abstract void GetObjectLabelDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("identifier")] int identifier,
            [NativeName("name")] uint name,
            [NativeName("bufSize")] int bufSize,
            [NativeName("length")] int* length,
            [NativeName("label")] sbyte* label
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
        static abstract void GetObjectLabelDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeName("name")] uint name,
            [NativeName("bufSize")] int bufSize,
            [NativeName("length")] Ref<int> length,
            [NativeName("label")] Ref<sbyte> label
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
        static abstract sbyte GetObjectLabelDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeName("name")] uint name,
            [NativeName("length")] Ref<int> length
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
        static abstract void GetObjectLabelEXT(
            [NativeName("identifier")] int identifier,
            [NativeName("name")] uint name,
            [NativeName("bufSize")] int bufSize,
            [NativeName("length")] int* length,
            [NativeName("label")] sbyte* label
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
        static abstract void GetObjectLabelEXT(
            [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeName("name")] uint name,
            [NativeName("bufSize")] int bufSize,
            [NativeName("length")] Ref<int> length,
            [NativeName("label")] Ref<sbyte> label
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
        static abstract sbyte GetObjectLabelEXT(
            [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeName("name")] uint name,
            [NativeName("length")] Ref<int> length
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetPointerDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
        static abstract void* GetPointerDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("pname")] int pname
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetPointerDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
        static abstract Ptr GetPointerDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void* GetPointerDirectSOFT(
            [NativeName("context")] ContextHandle context,
            [NativeName("pname")] int pname
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetPointerEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
        static abstract void* GetPointerEXT([NativeName("pname")] int pname);

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetPointerEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
        static abstract Ptr GetPointerEXT(
            [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetPointerSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
        static abstract void* GetPointerSOFT([NativeName("pname")] int pname);

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetPointerSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
        static abstract Ptr GetPointerSOFT(
            [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetPointervDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
        static abstract void GetPointerDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("pname")] int pname,
            [NativeName("values")] void** values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetPointervDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
        static abstract void GetPointerDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname,
            [NativeName("values")] Ref2D values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("pname")] int pname,
            [NativeName("values")] void** values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname,
            [NativeName("values")] Ref2D values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetPointervEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
        static abstract void GetPointerEXT(
            [NativeName("pname")] int pname,
            [NativeName("values")] void** values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alGetPointervEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
        static abstract void GetPointerEXT(
            [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname,
            [NativeName("values")] Ref2D values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetPointervSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
        static abstract void GetPointerSOFT(
            [NativeName("pname")] int pname,
            [NativeName("values")] void** values
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetPointervSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
        static abstract void GetPointerSOFT(
            [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname,
            [NativeName("values")] Ref2D values
        );

        [NativeName("alGetProcAddress")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        static abstract void* GetProcAddress([NativeName("fname")] sbyte* fname);

        [NativeName("alGetProcAddress")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        static abstract Ptr GetProcAddress([NativeName("fname")] Ref<sbyte> fname);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetProcAddressDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
        static abstract void* GetProcAddressDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("fname")] sbyte* fname
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetProcAddressDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
        static abstract Ptr GetProcAddressDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("fname")] Ref<sbyte> fname
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value1")] double* value1,
            [NativeName("value2")] double* value2,
            [NativeName("value3")] double* value3
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value1")] Ref<double> value1,
            [NativeName("value2")] Ref<double> value2,
            [NativeName("value3")] Ref<double> value3
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSource3dSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
        static abstract void GetSource3SOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value1")] double* value1,
            [NativeName("value2")] double* value2,
            [NativeName("value3")] double* value3
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSource3dSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
        static abstract void GetSource3SOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value1")] Ref<double> value1,
            [NativeName("value2")] Ref<double> value2,
            [NativeName("value3")] Ref<double> value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetSource3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        static abstract void GetSource3(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value1")] float* value1,
            [NativeName("value2")] float* value2,
            [NativeName("value3")] float* value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetSource3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        static abstract void GetSource3(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceFloat3> param1,
            [NativeName("value1")] Ref<float> value1,
            [NativeName("value2")] Ref<float> value2,
            [NativeName("value3")] Ref<float> value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSource3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
        static abstract void GetSource3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value1")] float* value1,
            [NativeName("value2")] float* value2,
            [NativeName("value3")] float* value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSource3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
        static abstract void GetSource3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceFloat3> param2,
            [NativeName("value1")] Ref<float> value1,
            [NativeName("value2")] Ref<float> value2,
            [NativeName("value3")] Ref<float> value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetSource3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        static abstract void GetSource3(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value1")] int* value1,
            [NativeName("value2")] int* value2,
            [NativeName("value3")] int* value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetSource3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        static abstract void GetSource3(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger3> param1,
            [NativeName("value1")] Ref<int> value1,
            [NativeName("value2")] Ref<int> value2,
            [NativeName("value3")] Ref<int> value3
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value1")] nint* value1,
            [NativeName("value2")] nint* value2,
            [NativeName("value3")] nint* value3
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger3> param2,
            [NativeName("value1")] Ref<nint> value1,
            [NativeName("value2")] Ref<nint> value2,
            [NativeName("value3")] Ref<nint> value3
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSource3i64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
        static abstract void GetSource3SOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value1")] nint* value1,
            [NativeName("value2")] nint* value2,
            [NativeName("value3")] nint* value3
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSource3i64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
        static abstract void GetSource3SOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger3> param1,
            [NativeName("value1")] Ref<nint> value1,
            [NativeName("value2")] Ref<nint> value2,
            [NativeName("value3")] Ref<nint> value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSource3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
        static abstract void GetSource3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value1")] int* value1,
            [NativeName("value2")] int* value2,
            [NativeName("value3")] int* value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSource3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
        static abstract void GetSource3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger3> param2,
            [NativeName("value1")] Ref<int> value1,
            [NativeName("value2")] Ref<int> value2,
            [NativeName("value3")] Ref<int> value3
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value")] double* value
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceDouble> param2,
            [NativeName("value")] Ref<double> value
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSourcedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
        static abstract void GetSourceSOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value")] double* value
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSourcedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
        static abstract void GetSourceSOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceDouble> param1,
            [NativeName("value")] Ref<double> value
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void AlGetSourcedvDirectSoft(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("values")] double* values
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void AlGetSourcedvDirectSoft(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceDouble> param2,
            [NativeName("values")] Ref<double> values
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSourcedvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
        static abstract void AlGetSourcedvSoft(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("values")] double* values
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSourcedvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
        static abstract void AlGetSourcedvSoft(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceDouble> param1,
            [NativeName("values")] Ref<double> values
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetSourcef")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        static abstract void AlGetSourcef(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value")] float* value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alGetSourcef")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        static abstract void AlGetSourcef(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceFloat> param1,
            [NativeName("value")] Ref<float> value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSourcefDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
        static abstract void AlGetSourcefDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value")] float* value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSourcefDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
        static abstract void AlGetSourcefDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceFloat> param2,
            [NativeName("value")] Ref<float> value
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetSourcefv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        static abstract void AlGetSourcefv(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alGetSourcefv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        static abstract void AlGetSourcefv(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceFloat> param1,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSourcefvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
        static abstract void AlGetSourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSourcefvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
        static abstract void AlGetSourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceFloat> param2,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetSourcei")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        static abstract void AlGetSourcei(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value")] int* value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alGetSourcei")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        static abstract void AlGetSourcei(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeName("value")] Ref<int> value
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void AlGetSourcei64DirectSoft(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value")] nint* value
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void AlGetSourcei64DirectSoft(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeName("value")] Ref<nint> value
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSourcei64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
        static abstract void AlGetSourcei64Soft(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value")] nint* value
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSourcei64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
        static abstract void AlGetSourcei64Soft(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeName("value")] Ref<nint> value
        );

        [NameAffix("Suffix", "i64v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void AlGetSourcei64VDirectSoft(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("values")] nint* values
        );

        [NameAffix("Suffix", "i64v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void AlGetSourcei64VDirectSoft(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeName("values")] Ref<nint> values
        );

        [NameAffix("Suffix", "i64v", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSourcei64vSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
        static abstract void AlGetSourcei64VSoft(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("values")] nint* values
        );

        [NameAffix("Suffix", "i64v", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetSourcei64vSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
        static abstract void AlGetSourcei64VSoft(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeName("values")] Ref<nint> values
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSourceiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
        static abstract void AlGetSourceiDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value")] int* value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSourceiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
        static abstract void AlGetSourceiDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeName("value")] Ref<int> value
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetSourceiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        static abstract void AlGetSourceiv(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alGetSourceiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        static abstract void AlGetSourceiv(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSourceivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
        static abstract void AlGetSourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetSourceivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
        static abstract void AlGetSourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeName("values")] Ref<int> values
        );

        [NativeName("alGetString")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        static abstract sbyte* GetString([NativeName("param0")] int param0);

        [NativeName("alGetString")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        static abstract Ptr<sbyte> GetString(
            [NativeName("param0")] Constant<int, AlEnum, StringPName> param0
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetStringDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
        static abstract sbyte* GetStringDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alGetStringDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
        static abstract Ptr<sbyte> GetStringDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, StringPName> param1
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract sbyte* GetStringDirectSOFT(
            [NativeName("context")] ContextHandle context,
            [NativeName("pname")] int pname,
            [NativeName("index")] int index
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("pname")] Constant<int, AlEnum, StringPName> pname,
            [NativeName("index")] int index
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetStringiSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
        [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
        static abstract sbyte* GetStringSOFT(
            [NativeName("pname")] int pname,
            [NativeName("index")] int index
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alGetStringiSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
        [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
        static abstract Ptr<sbyte> GetStringSOFT(
            [NativeName("pname")] Constant<int, AlEnum, StringPName> pname,
            [NativeName("index")] int index
        );

        [NativeName("alIsAuxiliaryEffectSlot")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
        static abstract MaybeBool<sbyte> IsAuxiliaryEffectSlot(
            [NativeName("effectslot")] uint effectslot
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsAuxiliaryEffectSlotDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
        static abstract MaybeBool<sbyte> IsAuxiliaryEffectSlotDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsAuxiliaryEffectSlotDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
        static abstract sbyte IsAuxiliaryEffectSlotDirectRawDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effectslot")] uint effectslot
        );

        [NativeName("alIsAuxiliaryEffectSlot")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
        static abstract sbyte IsAuxiliaryEffectSlotRaw([NativeName("effectslot")] uint effectslot);

        [NativeName("alIsBuffer")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        static abstract MaybeBool<sbyte> IsBuffer([NativeName("buffer")] uint buffer);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsBufferDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
        static abstract MaybeBool<sbyte> IsBufferDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsBufferDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
        static abstract sbyte IsBufferDirectRawDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alIsBufferFormatSupportedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
        static abstract MaybeBool<sbyte> IsBufferFormatSupportedSOFT(
            [NativeName("format")] int format
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alIsBufferFormatSupportedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
        static abstract sbyte IsBufferFormatSupportedSoftRawSOFT([NativeName("format")] int format);

        [NativeName("alIsBuffer")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        static abstract sbyte IsBufferRaw([NativeName("buffer")] uint buffer);

        [NativeName("alIsEffect")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsEffect")]
        static abstract MaybeBool<sbyte> IsEffect([NativeName("effect")] uint effect);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsEffectDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
        static abstract MaybeBool<sbyte> IsEffectDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsEffectDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
        static abstract sbyte IsEffectDirectRawDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("effect")] uint effect
        );

        [NativeName("alIsEffect")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsEffect")]
        static abstract sbyte IsEffectRaw([NativeName("effect")] uint effect);

        [NativeName("alIsEnabled")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        static abstract sbyte IsEnabled([NativeName("capability")] int capability);

        [NativeName("alIsEnabled")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        static abstract MaybeBool<sbyte> IsEnabled(
            [NativeName("capability")] Constant<int, AlEnum, EnableCap> capability
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsEnabledDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
        static abstract sbyte IsEnabledDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("capability")] int capability
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsEnabledDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
        static abstract MaybeBool<sbyte> IsEnabledDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("capability")] Constant<int, AlEnum, EnableCap> capability
        );

        [NativeName("alIsExtensionPresent")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        static abstract sbyte IsExtensionPresent([NativeName("extname")] sbyte* extname);

        [NativeName("alIsExtensionPresent")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        static abstract MaybeBool<sbyte> IsExtensionPresent(
            [NativeName("extname")] Ref<sbyte> extname
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsExtensionPresentDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
        static abstract sbyte IsExtensionPresentDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("extname")] sbyte* extname
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsExtensionPresentDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
        static abstract MaybeBool<sbyte> IsExtensionPresentDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("extname")] Ref<sbyte> extname
        );

        [NativeName("alIsFilter")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsFilter")]
        static abstract MaybeBool<sbyte> IsFilter([NativeName("filter")] uint filter);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsFilterDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
        static abstract MaybeBool<sbyte> IsFilterDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsFilterDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
        static abstract sbyte IsFilterDirectRawDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("filter")] uint filter
        );

        [NativeName("alIsFilter")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsFilter")]
        static abstract sbyte IsFilterRaw([NativeName("filter")] uint filter);

        [NativeName("alIsSource")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        static abstract MaybeBool<sbyte> IsSource([NativeName("source")] uint source);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsSourceDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
        static abstract MaybeBool<sbyte> IsSourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alIsSourceDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
        static abstract sbyte IsSourceDirectRawDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source
        );

        [NativeName("alIsSource")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        static abstract sbyte IsSourceRaw([NativeName("source")] uint source);

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alListener3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3f")]
        static abstract void Listener3(
            [NativeName("param0")] int param0,
            [NativeName("value1")] float value1,
            [NativeName("value2")] float value2,
            [NativeName("value3")] float value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alListener3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3f")]
        static abstract void Listener3(
            [NativeName("param0")] Constant<int, AlEnum, ListenerFloat3> param0,
            [NativeName("value1")] float value1,
            [NativeName("value2")] float value2,
            [NativeName("value3")] float value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alListener3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
        static abstract void Listener3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("value1")] float value1,
            [NativeName("value2")] float value2,
            [NativeName("value3")] float value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alListener3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
        static abstract void Listener3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, ListenerFloat3> param1,
            [NativeName("value1")] float value1,
            [NativeName("value2")] float value2,
            [NativeName("value3")] float value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alListener3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3i")]
        static abstract void Listener3(
            [NativeName("param0")] int param0,
            [NativeName("value1")] int value1,
            [NativeName("value2")] int value2,
            [NativeName("value3")] int value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alListener3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3i")]
        static abstract void Listener3(
            [NativeName("param0")] Constant<int, AlEnum, ListenerInteger3> param0,
            [NativeName("value1")] int value1,
            [NativeName("value2")] int value2,
            [NativeName("value3")] int value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alListener3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
        static abstract void Listener3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("value1")] int value1,
            [NativeName("value2")] int value2,
            [NativeName("value3")] int value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alListener3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
        static abstract void Listener3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, ListenerInteger3> param1,
            [NativeName("value1")] int value1,
            [NativeName("value2")] int value2,
            [NativeName("value3")] int value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alListenerf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerf")]
        static abstract void Listener(
            [NativeName("param0")] int param0,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alListenerf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerf")]
        static abstract void Listener(
            [NativeName("param0")] Constant<int, AlEnum, ListenerFloat> param0,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alListenerfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
        static abstract void ListenerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alListenerfDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
        static abstract void ListenerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, ListenerFloat> param1,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alListenerfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        static abstract void Listener(
            [NativeName("param0")] int param0,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alListenerfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        static abstract void Listener(
            [NativeName("param0")] Constant<int, AlEnum, ListenerFloat> param0,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alListenerfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
        static abstract void ListenerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alListenerfvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
        static abstract void ListenerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] Constant<int, AlEnum, ListenerFloat> param1,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alListeneri")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneri")]
        static abstract void Listener(
            [NativeName("param0")] int param0,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alListeneriDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListeneriDirect")]
        static abstract void ListenerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        static abstract void Listener(
            [NativeName("param0")] int param0,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        static abstract void Listener(
            [NativeName("param0")] int param0,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alListenerivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
        static abstract void ListenerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alListenerivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
        static abstract void ListenerDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("param1")] int param1,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
        static abstract void ObjectLabelDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("identifier")] int identifier,
            [NativeName("name")] uint name,
            [NativeName("length")] int length,
            [NativeName("label")] sbyte* label
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
        static abstract void ObjectLabelDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeName("name")] uint name,
            [NativeName("length")] int length,
            [NativeName("label")] Ref<sbyte> label
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alObjectLabelDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
        static abstract void ObjectLabelDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeName("name")] uint name,
            [NativeName("label")] sbyte label
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
        static abstract void ObjectLabelEXT(
            [NativeName("identifier")] int identifier,
            [NativeName("name")] uint name,
            [NativeName("length")] int length,
            [NativeName("label")] sbyte* label
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
        static abstract void ObjectLabelEXT(
            [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeName("name")] uint name,
            [NativeName("length")] int length,
            [NativeName("label")] Ref<sbyte> label
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alObjectLabelEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
        static abstract void ObjectLabelEXT(
            [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeName("name")] uint name,
            [NativeName("label")] sbyte label
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alPopDebugGroupDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alPopDebugGroupDirectEXT")]
        static abstract void PopDebugGroupDirectEXT([NativeName("context")] ContextHandle context);

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alPopDebugGroupEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alPopDebugGroupEXT")]
        static abstract void PopDebugGroupEXT();

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void ProcessUpdatesDirectSOFT(
            [NativeName("context")] ContextHandle context
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alProcessUpdatesSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
        [NativeFunction("openal", EntryPoint = "alProcessUpdatesSOFT")]
        static abstract void ProcessUpdatesSOFT();

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alPushDebugGroupDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
        static abstract void PushDebugGroupDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] int source,
            [NativeName("id")] uint id,
            [NativeName("length")] int length,
            [NativeName("message")] sbyte* message
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alPushDebugGroupDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
        static abstract void PushDebugGroupDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("id")] uint id,
            [NativeName("length")] int length,
            [NativeName("message")] Ref<sbyte> message
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alPushDebugGroupDirectEXT")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
        static abstract void PushDebugGroupDirectEXT(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("id")] uint id,
            [NativeName("message")] sbyte message
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alPushDebugGroupEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
        static abstract void PushDebugGroupEXT(
            [NativeName("source")] int source,
            [NativeName("id")] uint id,
            [NativeName("length")] int length,
            [NativeName("message")] sbyte* message
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alPushDebugGroupEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
        static abstract void PushDebugGroupEXT(
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("id")] uint id,
            [NativeName("length")] int length,
            [NativeName("message")] Ref<sbyte> message
        );

        [NameAffix("Suffix", "EXT", 0, -1)]
        [NativeName("alPushDebugGroupEXT")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
        static abstract void PushDebugGroupEXT(
            [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeName("id")] uint id,
            [NativeName("message")] sbyte message
        );

        [NativeName("alRequestFoldbackStart")]
        [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
        static abstract void RequestFoldbackStart(
            [NativeName("mode")] int mode,
            [NativeName("count")] int count,
            [NativeName("length")] int length,
            [NativeName("mem")] float* mem,
            [NativeName("callback")] FoldbackCallback callback
        );

        [NativeName("alRequestFoldbackStart")]
        [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
        static abstract void RequestFoldbackStart(
            [NativeName("mode")] int mode,
            [NativeName("count")] int count,
            [NativeName("length")] int length,
            [NativeName("mem")] Ref<float> mem,
            [NativeName("callback")] FoldbackCallback callback
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("mode")] int mode,
            [NativeName("count")] int count,
            [NativeName("length")] int length,
            [NativeName("mem")] float* mem,
            [NativeName("callback")] FoldbackCallback callback
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("mode")] int mode,
            [NativeName("count")] int count,
            [NativeName("length")] int length,
            [NativeName("mem")] Ref<float> mem,
            [NativeName("callback")] FoldbackCallback callback
        );

        [NativeName("alRequestFoldbackStop")]
        [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStop")]
        static abstract void RequestFoldbackStop();

        [NameAffix("Suffix", "Direct", 0, -1)]
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
        static abstract void RequestFoldbackStopDirect(
            [NativeName("context")] ContextHandle context
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value1")] double value1,
            [NativeName("value2")] double value2,
            [NativeName("value3")] double value3
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSource3dSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSource3dSOFT")]
        static abstract void Source3SOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value1")] double value1,
            [NativeName("value2")] double value2,
            [NativeName("value3")] double value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alSource3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3f")]
        static abstract void Source3(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value1")] float value1,
            [NativeName("value2")] float value2,
            [NativeName("value3")] float value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alSource3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3f")]
        static abstract void Source3(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceFloat3> param1,
            [NativeName("value1")] float value1,
            [NativeName("value2")] float value2,
            [NativeName("value3")] float value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSource3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
        static abstract void Source3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value1")] float value1,
            [NativeName("value2")] float value2,
            [NativeName("value3")] float value3
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSource3fDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
        static abstract void Source3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceFloat3> param2,
            [NativeName("value1")] float value1,
            [NativeName("value2")] float value2,
            [NativeName("value3")] float value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alSource3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3i")]
        static abstract void Source3(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value1")] int value1,
            [NativeName("value2")] int value2,
            [NativeName("value3")] int value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alSource3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3i")]
        static abstract void Source3(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger3> param1,
            [NativeName("value1")] int value1,
            [NativeName("value2")] int value2,
            [NativeName("value3")] int value3
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value1")] nint value1,
            [NativeName("value2")] nint value2,
            [NativeName("value3")] nint value3
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger3> param2,
            [NativeName("value1")] nint value1,
            [NativeName("value2")] nint value2,
            [NativeName("value3")] nint value3
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSource3i64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
        static abstract void Source3SOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value1")] nint value1,
            [NativeName("value2")] nint value2,
            [NativeName("value3")] nint value3
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSource3i64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
        static abstract void Source3SOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger3> param1,
            [NativeName("value1")] nint value1,
            [NativeName("value2")] nint value2,
            [NativeName("value3")] nint value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSource3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
        static abstract void Source3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value1")] int value1,
            [NativeName("value2")] int value2,
            [NativeName("value3")] int value3
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSource3iDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
        static abstract void Source3Direct(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger3> param2,
            [NativeName("value1")] int value1,
            [NativeName("value2")] int value2,
            [NativeName("value3")] int value3
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value")] double value
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceDouble> param2,
            [NativeName("value")] double value
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
        static abstract void SourceSOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value")] double value
        );

        [NameAffix("Suffix", "d", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcedSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
        static abstract void SourceSOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceDouble> param1,
            [NativeName("value")] double value
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("values")] double* values
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceDouble> param2,
            [NativeName("values")] Ref<double> values
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcedvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
        static abstract void SourceSOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("values")] double* values
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcedvSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
        static abstract void SourceSOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceDouble> param1,
            [NativeName("values")] Ref<double> values
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alSourcef")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcef")]
        static abstract void Source(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NativeName("alSourcef")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcef")]
        static abstract void Source(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceFloat> param1,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcefDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
        static abstract void SourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "f", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcefDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
        static abstract void SourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceFloat> param2,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alSourcefv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        static abstract void Source(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NativeName("alSourcefv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        static abstract void Source(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceFloat> param1,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcefvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
        static abstract void SourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("values")] float* values
        );

        [NameAffix("Suffix", "fv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcefvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
        static abstract void SourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceFloat> param2,
            [NativeName("values")] Ref<float> values
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alSourcei")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcei")]
        static abstract void Source(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NativeName("alSourcei")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcei")]
        static abstract void Source(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value")] nint value
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeName("value")] nint value
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcei64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
        static abstract void SourceSOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("value")] nint value
        );

        [NameAffix("Suffix", "i64", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcei64SOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
        static abstract void SourceSOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeName("value")] nint value
        );

        [NameAffix("Suffix", "i64v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("values")] nint* values
        );

        [NameAffix("Suffix", "i64v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeName("values")] Ref<nint> values
        );

        [NameAffix("Suffix", "i64v", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcei64vSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
        static abstract void SourceSOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("values")] nint* values
        );

        [NameAffix("Suffix", "i64v", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcei64vSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
        static abstract void SourceSOFT(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeName("values")] Ref<nint> values
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
        static abstract void SourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "i", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceiDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
        static abstract void SourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alSourceiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        static abstract void Source(
            [NativeName("source")] uint source,
            [NativeName("param1")] int param1,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NativeName("alSourceiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        static abstract void Source(
            [NativeName("source")] uint source,
            [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeName("values")] Ref<int> values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
        static abstract void SourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] int param2,
            [NativeName("values")] int* values
        );

        [NameAffix("Suffix", "iv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceivDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
        static abstract void SourceDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeName("values")] Ref<int> values
        );

        [NativeName("alSourcePause")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePause")]
        static abstract void SourcePause([NativeName("source")] uint source);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcePauseDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePauseDirect")]
        static abstract void SourcePauseDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alSourcePausev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        static abstract void AlSourcePause(
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alSourcePausev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        static abstract void AlSourcePause(
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alSourcePausev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        static abstract void AlSourcePause([NativeName("sources")] uint sources);

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcePausevDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
        static abstract void AlSourcePause(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcePausevDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
        static abstract void AlSourcePause(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcePausevDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
        static abstract void AlSourcePause(
            [NativeName("context")] ContextHandle context,
            [NativeName("sources")] uint sources
        );

        [NativeName("alSourcePlay")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlay")]
        static abstract void SourcePlay([NativeName("source")] uint source);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("start_time")] nint start_time
        );

        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcePlayAtTimeSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimeSOFT")]
        static abstract void SourcePlayAtTimeSOFT(
            [NativeName("source")] uint source,
            [NativeName("start_time")] nint start_time
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void AlSourcePlayAtTime(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources,
            [NativeName("start_time")] nint start_time
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void AlSourcePlayAtTime(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources,
            [NativeName("start_time")] nint start_time
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
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
        static abstract void AlSourcePlayAtTime(
            [NativeName("context")] ContextHandle context,
            [NativeName("sources")] uint sources,
            [NativeName("start_time")] nint start_time
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcePlayAtTimevSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
        static abstract void AlSourcePlayAtTime(
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources,
            [NativeName("start_time")] nint start_time
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcePlayAtTimevSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
        static abstract void AlSourcePlayAtTime(
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources,
            [NativeName("start_time")] nint start_time
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "SOFT", 0, -1)]
        [NativeName("alSourcePlayAtTimevSOFT")]
        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
        static abstract void AlSourcePlayAtTime(
            [NativeName("sources")] uint sources,
            [NativeName("start_time")] nint start_time
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcePlayDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayDirect")]
        static abstract void SourcePlayDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alSourcePlayv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        static abstract void AlSourcePlay(
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alSourcePlayv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        static abstract void AlSourcePlay(
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alSourcePlayv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        static abstract void AlSourcePlay([NativeName("sources")] uint sources);

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcePlayvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
        static abstract void AlSourcePlay(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcePlayvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
        static abstract void AlSourcePlay(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourcePlayvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
        static abstract void AlSourcePlay(
            [NativeName("context")] ContextHandle context,
            [NativeName("sources")] uint sources
        );

        [NativeName("alSourceQueueBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        static abstract void SourceQueueBuffers(
            [NativeName("source")] uint source,
            [NativeName("nb")] int nb,
            [NativeName("buffers")] uint* buffers
        );

        [NativeName("alSourceQueueBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        static abstract void SourceQueueBuffers(
            [NativeName("source")] uint source,
            [NativeName("nb")] int nb,
            [NativeName("buffers")] Ref<uint> buffers
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceQueueBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
        static abstract void SourceQueueBuffersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("nb")] int nb,
            [NativeName("buffers")] uint* buffers
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceQueueBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
        static abstract void SourceQueueBuffersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("nb")] int nb,
            [NativeName("buffers")] Ref<uint> buffers
        );

        [NativeName("alSourceRewind")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewind")]
        static abstract void SourceRewind([NativeName("source")] uint source);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceRewindDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceRewindDirect")]
        static abstract void SourceRewindDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NativeName("alSourceRewindv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewin(
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NativeName("alSourceRewindv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewin(
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NativeName("alSourceRewindv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewin([NativeName("sources")] uint sources);

        [NameAffix("Suffix", "dv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceRewindvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
        static abstract void SourceRewinDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceRewindvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
        static abstract void SourceRewinDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "dv", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceRewindvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
        static abstract void SourceRewinDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("sources")] uint sources
        );

        [NativeName("alSourceStop")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStop")]
        static abstract void SourceStop([NativeName("source")] uint source);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceStopDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceStopDirect")]
        static abstract void SourceStopDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alSourceStopv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        static abstract void AlSourceStop(
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alSourceStopv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        static abstract void AlSourceStop(
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NativeName("alSourceStopv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        static abstract void AlSourceStop([NativeName("sources")] uint sources);

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceStopvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
        static abstract void AlSourceStop(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] uint* sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceStopvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
        static abstract void AlSourceStop(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("sources")] Ref<uint> sources
        );

        [NameAffix("Suffix", "v", -1, -1)]
        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceStopvDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
        static abstract void AlSourceStop(
            [NativeName("context")] ContextHandle context,
            [NativeName("sources")] uint sources
        );

        [NativeName("alSourceUnqueueBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        static abstract void SourceUnqueueBuffers(
            [NativeName("source")] uint source,
            [NativeName("nb")] int nb,
            [NativeName("buffers")] uint* buffers
        );

        [NativeName("alSourceUnqueueBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        static abstract void SourceUnqueueBuffers(
            [NativeName("source")] uint source,
            [NativeName("nb")] int nb,
            [NativeName("buffers")] Ref<uint> buffers
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceUnqueueBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
        static abstract void SourceUnqueueBuffersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("nb")] int nb,
            [NativeName("buffers")] uint* buffers
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSourceUnqueueBuffersDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
        static abstract void SourceUnqueueBuffersDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("source")] uint source,
            [NativeName("nb")] int nb,
            [NativeName("buffers")] Ref<uint> buffers
        );

        [NativeName("alSpeedOfSound")]
        [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
        static abstract void SpeedOfSound([NativeName("value")] float value);

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("alSpeedOfSoundDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSpeedOfSoundDirect")]
        static abstract void SpeedOfSoundDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("value")] float value
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("EAXGetBufferModeDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
        static abstract int EaxGetBufferModeDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("pReserved")] int* pReserved
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("EAXGetBufferModeDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
        static abstract int EaxGetBufferModeDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("buffer")] uint buffer,
            [NativeName("pReserved")] Ref<int> pReserved
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("EAXGetDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
        static abstract int EaxGetDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("property_set_id")] System.Guid* property_set_id,
            [NativeName("property_id")] uint property_id,
            [NativeName("source_id")] uint source_id,
            [NativeName("value")] void* value,
            [NativeName("value_size")] uint value_size
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("EAXGetDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
        static abstract int EaxGetDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("property_set_id")] Ref<System.Guid> property_set_id,
            [NativeName("property_id")] uint property_id,
            [NativeName("source_id")] uint source_id,
            [NativeName("value")] Ref value,
            [NativeName("value_size")] uint value_size
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("EAXSetBufferModeDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
        static abstract sbyte EaxSetBufferModeDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("buffers")] uint* buffers,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("EAXSetBufferModeDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
        static abstract MaybeBool<sbyte> EaxSetBufferModeDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("n")] int n,
            [NativeName("buffers")] Ref<uint> buffers,
            [NativeName("value")] int value
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("EAXSetDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
        static abstract int EaxSetDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("property_set_id")] System.Guid* property_set_id,
            [NativeName("property_id")] uint property_id,
            [NativeName("source_id")] uint source_id,
            [NativeName("value")] void* value,
            [NativeName("value_size")] uint value_size
        );

        [NameAffix("Suffix", "Direct", 0, -1)]
        [NativeName("EAXSetDirect")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
        static abstract int EaxSetDirect(
            [NativeName("context")] ContextHandle context,
            [NativeName("property_set_id")] Ref<System.Guid> property_set_id,
            [NativeName("property_id")] uint property_id,
            [NativeName("source_id")] uint source_id,
            [NativeName("value")] Ref value,
            [NativeName("value_size")] uint value_size
        );
    }

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alAuxiliaryEffectSlotf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
    void AuxiliaryEffectSlot(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] int param1,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alAuxiliaryEffectSlotf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
    void AuxiliaryEffectSlot(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alAuxiliaryEffectSlotfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
    void AuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] int param2,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alAuxiliaryEffectSlotfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
    void AuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alAuxiliaryEffectSlotfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
    void AuxiliaryEffectSlot(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] int param1,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alAuxiliaryEffectSlotfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
    void AuxiliaryEffectSlot(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alAuxiliaryEffectSlotfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
    void AuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] int param2,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alAuxiliaryEffectSlotfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
    void AuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alAuxiliaryEffectSloti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
    void AuxiliaryEffectSlot(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] int param1,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alAuxiliaryEffectSloti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
    void AuxiliaryEffectSlot(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alAuxiliaryEffectSlotiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
    void AuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] int param2,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alAuxiliaryEffectSlotiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
    void AuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alAuxiliaryEffectSlotiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
    void AuxiliaryEffectSlot(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] int param1,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alAuxiliaryEffectSlotiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
    void AuxiliaryEffectSlot(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alAuxiliaryEffectSlotivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
    void AuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] int param2,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alAuxiliaryEffectSlotivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
    void AuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alBuffer3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBuffer3f")]
    void Buffer3(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("value1")] float value1,
        [NativeName("value2")] float value2,
        [NativeName("value3")] float value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBuffer3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBuffer3fDirect")]
    void Buffer3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("value1")] float value1,
        [NativeName("value2")] float value2,
        [NativeName("value3")] float value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alBuffer3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBuffer3i")]
    void Buffer3(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("value1")] int value1,
        [NativeName("value2")] int value2,
        [NativeName("value3")] int value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBuffer3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBuffer3iDirect")]
    void Buffer3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("value1")] int value1,
        [NativeName("value2")] int value2,
        [NativeName("value3")] int value3
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] int format,
        [NativeName("freq")] int freq,
        [NativeName("callback")] BufferCallbackSoft callback,
        [NativeName("userptr")] void* userptr
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] Constant<int, AlEnum, Format> format,
        [NativeName("freq")] int freq,
        [NativeName("callback")] BufferCallbackSoft callback,
        [NativeName("userptr")] Ref userptr
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alBufferCallbackSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
    void BufferCallbackSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] int format,
        [NativeName("freq")] int freq,
        [NativeName("callback")] BufferCallbackSoft callback,
        [NativeName("userptr")] void* userptr
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alBufferCallbackSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
    void BufferCallbackSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] Constant<int, AlEnum, Format> format,
        [NativeName("freq")] int freq,
        [NativeName("callback")] BufferCallbackSoft callback,
        [NativeName("userptr")] Ref userptr
    );

    [NativeName("alBufferData")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferData")]
    void BufferData(
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] int format,
        [NativeName("data")] void* data,
        [NativeName("size")] int size,
        [NativeName("samplerate")] int samplerate
    );

    [NativeName("alBufferData")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferData")]
    void BufferData(
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] Constant<int, AlEnum, Format> format,
        [NativeName("data")] Ref data,
        [NativeName("size")] int size,
        [NativeName("samplerate")] int samplerate
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBufferDataDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
    void BufferDataDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] int format,
        [NativeName("data")] void* data,
        [NativeName("size")] int size,
        [NativeName("samplerate")] int samplerate
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBufferDataDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
    void BufferDataDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] Constant<int, AlEnum, Format> format,
        [NativeName("data")] Ref data,
        [NativeName("size")] int size,
        [NativeName("samplerate")] int samplerate
    );

    [NativeName("alBufferDataStatic")]
    [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
    [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
    void BufferDataStatic(
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] int format,
        [NativeName("data")] void* data,
        [NativeName("size")] int size,
        [NativeName("freq")] int freq
    );

    [NativeName("alBufferDataStatic")]
    [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
    [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
    void BufferDataStatic(
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] Constant<int, AlEnum, Format> format,
        [NativeName("data")] Ref data,
        [NativeName("size")] int size,
        [NativeName("freq")] int freq
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] int format,
        [NativeName("data")] void* data,
        [NativeName("size")] int size,
        [NativeName("freq")] int freq
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] Constant<int, AlEnum, Format> format,
        [NativeName("data")] Ref data,
        [NativeName("size")] int size,
        [NativeName("freq")] int freq
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alBufferf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferf")]
    void Buffer(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alBufferf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferf")]
    void Buffer(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] Constant<int, AlEnum, BufferFloat> param1,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBufferfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
    void BufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBufferfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
    void BufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] Constant<int, AlEnum, BufferFloat> param2,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alBufferfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    void Buffer(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("values")] float* values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alBufferfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    void Buffer(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] Constant<int, AlEnum, BufferFloat> param1,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBufferfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
    void BufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("values")] float* values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBufferfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
    void BufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] Constant<int, AlEnum, BufferFloat> param2,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alBufferi")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferi")]
    void Buffer(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("value")] int value
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alBufferi")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferi")]
    void Buffer(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] Constant<int, AlEnum, BufferInteger> param1,
        [NativeName("value")] int value
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBufferiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
    void BufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("value")] int value
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBufferiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
    void BufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] Constant<int, AlEnum, BufferInteger> param2,
        [NativeName("value")] int value
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alBufferiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    void Buffer(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("values")] int* values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alBufferiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    void Buffer(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] Constant<int, AlEnum, BufferInteger> param1,
        [NativeName("values")] Ref<int> values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBufferivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
    void BufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("values")] int* values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alBufferivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
    void BufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] Constant<int, AlEnum, BufferInteger> param2,
        [NativeName("values")] Ref<int> values
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alBufferSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
    void BufferSamplesSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("samplerate")] uint samplerate,
        [NativeName("internalformat")] int internalformat,
        [NativeName("samples")] int samples,
        [NativeName("channels")] int channels,
        [NativeName("type")] int type,
        [NativeName("data")] void* data
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alBufferSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
    void BufferSamplesSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("samplerate")] uint samplerate,
        [NativeName("internalformat")] int internalformat,
        [NativeName("samples")] int samples,
        [NativeName("channels")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
        [NativeName("type")] Constant<int, AlEnum, SampleTypeSOFT> type,
        [NativeName("data")] Ref data
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] int format,
        [NativeName("data")] void* data,
        [NativeName("offset")] int offset,
        [NativeName("length")] int length
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] Constant<int, AlEnum, Format> format,
        [NativeName("data")] Ref data,
        [NativeName("offset")] int offset,
        [NativeName("length")] int length
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alBufferSubDataSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
    [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
    void BufferSubDataSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] int format,
        [NativeName("data")] void* data,
        [NativeName("offset")] int offset,
        [NativeName("length")] int length
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alBufferSubDataSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
    [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
    void BufferSubDataSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("format")] Constant<int, AlEnum, Format> format,
        [NativeName("data")] Ref data,
        [NativeName("offset")] int offset,
        [NativeName("length")] int length
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alBufferSubSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
    void BufferSubSamplesSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("offset")] int offset,
        [NativeName("samples")] int samples,
        [NativeName("channels")] int channels,
        [NativeName("type")] int type,
        [NativeName("data")] void* data
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alBufferSubSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
    void BufferSubSamplesSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("offset")] int offset,
        [NativeName("samples")] int samples,
        [NativeName("channels")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
        [NativeName("type")] Constant<int, AlEnum, SampleTypeSOFT> type,
        [NativeName("data")] Ref data
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageCallbackDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
    void DebugMessageCallbackDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("callback")] DebugProcExt callback,
        [NativeName("userParam")] void* userParam
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageCallbackDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
    void DebugMessageCallbackDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("callback")] DebugProcExt callback,
        [NativeName("userParam")] Ref userParam
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageCallbackEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
    void DebugMessageCallbackEXT(
        [NativeName("callback")] DebugProcExt callback,
        [NativeName("userParam")] void* userParam
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageCallbackEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
    void DebugMessageCallbackEXT(
        [NativeName("callback")] DebugProcExt callback,
        [NativeName("userParam")] Ref userParam
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageControlDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
    void DebugMessageControlDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] int source,
        [NativeName("type")] int type,
        [NativeName("severity")] int severity,
        [NativeName("count")] int count,
        [NativeName("ids")] uint* ids,
        [NativeName("enable")] sbyte enable
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageControlDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
    void DebugMessageControlDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeName("count")] int count,
        [NativeName("ids")] Ref<uint> ids,
        [NativeName("enable")] MaybeBool<sbyte> enable
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageControlDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
    void DebugMessageControlDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeName("ids")] uint ids,
        [NativeName("enable")] MaybeBool<sbyte> enable
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageControlEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
    void DebugMessageControlEXT(
        [NativeName("source")] int source,
        [NativeName("type")] int type,
        [NativeName("severity")] int severity,
        [NativeName("count")] int count,
        [NativeName("ids")] uint* ids,
        [NativeName("enable")] sbyte enable
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageControlEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
    void DebugMessageControlEXT(
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeName("count")] int count,
        [NativeName("ids")] Ref<uint> ids,
        [NativeName("enable")] MaybeBool<sbyte> enable
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageControlEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
    void DebugMessageControlEXT(
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeName("ids")] uint ids,
        [NativeName("enable")] MaybeBool<sbyte> enable
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageInsertDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
    void DebugMessageInsertDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] int source,
        [NativeName("type")] int type,
        [NativeName("id")] uint id,
        [NativeName("severity")] int severity,
        [NativeName("length")] int length,
        [NativeName("message")] sbyte* message
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageInsertDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
    void DebugMessageInsertDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeName("id")] uint id,
        [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeName("length")] int length,
        [NativeName("message")] Ref<sbyte> message
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageInsertDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
    void DebugMessageInsertDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeName("id")] uint id,
        [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeName("message")] sbyte message
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageInsertEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
    void DebugMessageInsertEXT(
        [NativeName("source")] int source,
        [NativeName("type")] int type,
        [NativeName("id")] uint id,
        [NativeName("severity")] int severity,
        [NativeName("length")] int length,
        [NativeName("message")] sbyte* message
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageInsertEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
    void DebugMessageInsertEXT(
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeName("id")] uint id,
        [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeName("length")] int length,
        [NativeName("message")] Ref<sbyte> message
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alDebugMessageInsertEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
    void DebugMessageInsertEXT(
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("type")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeName("id")] uint id,
        [NativeName("severity")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeName("message")] sbyte message
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void DeferUpdatesDirectSOFT([NativeName("context")] ContextHandle context);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alDeferUpdatesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
    [NativeFunction("openal", EntryPoint = "alDeferUpdatesSOFT")]
    void DeferUpdatesSOFT();

    [NativeName("alDeleteAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
    void DeleteAuxiliaryEffectSlot([NativeName("effectslots")] uint effectslots);

    [NativeName("alDeleteAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
    void DeleteAuxiliaryEffectSlots(
        [NativeName("n")] int n,
        [NativeName("effectslots")] uint* effectslots
    );

    [NativeName("alDeleteAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
    void DeleteAuxiliaryEffectSlots(
        [NativeName("n")] int n,
        [NativeName("effectslots")] Ref<uint> effectslots
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
    void DeleteAuxiliaryEffectSlotsDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("effectslots")] uint* effectslots
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
    void DeleteAuxiliaryEffectSlotsDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("effectslots")] Ref<uint> effectslots
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
    void DeleteAuxiliaryEffectSlotsDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslots")] uint effectslots
    );

    [NativeName("alDeleteBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffer([NativeName("buffers")] uint buffers);

    [NativeName("alDeleteBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffers([NativeName("n")] int n, [NativeName("buffers")] uint* buffers);

    [NativeName("alDeleteBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffers([NativeName("n")] int n, [NativeName("buffers")] Ref<uint> buffers);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
    void DeleteBuffersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("buffers")] uint* buffers
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
    void DeleteBuffersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("buffers")] Ref<uint> buffers
    );

    [NativeName("alDeleteEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
    void DeleteEffect([NativeName("effects")] uint effects);

    [NativeName("alDeleteEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
    void DeleteEffects([NativeName("n")] int n, [NativeName("effects")] uint* effects);

    [NativeName("alDeleteEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
    void DeleteEffects([NativeName("n")] int n, [NativeName("effects")] Ref<uint> effects);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
    void DeleteEffectsDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("effects")] uint* effects
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
    void DeleteEffectsDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("effects")] Ref<uint> effects
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
    void DeleteEffectsDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effects")] uint effects
    );

    [NativeName("alDeleteFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
    void DeleteFilter([NativeName("filters")] uint filters);

    [NativeName("alDeleteFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
    void DeleteFilters([NativeName("n")] int n, [NativeName("filters")] uint* filters);

    [NativeName("alDeleteFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
    void DeleteFilters([NativeName("n")] int n, [NativeName("filters")] Ref<uint> filters);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
    void DeleteFiltersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("filters")] uint* filters
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
    void DeleteFiltersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("filters")] Ref<uint> filters
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
    void DeleteFiltersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filters")] uint filters
    );

    [NativeName("alDeleteSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSource([NativeName("sources")] uint sources);

    [NativeName("alDeleteSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSources([NativeName("n")] int n, [NativeName("sources")] uint* sources);

    [NativeName("alDeleteSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSources([NativeName("n")] int n, [NativeName("sources")] Ref<uint> sources);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
    void DeleteSourcesDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] uint* sources
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
    void DeleteSourcesDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] Ref<uint> sources
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDeleteSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
    void DeleteSourcesDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("sources")] uint sources
    );

    [NativeName("alDisable")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDisable")]
    void Disable([NativeName("capability")] int capability);

    [NativeName("alDisable")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDisable")]
    void Disable([NativeName("capability")] Constant<int, AlEnum, EnableCap> capability);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDisableDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDisableDirect")]
    void DisableDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("capability")] int capability
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDisableDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDisableDirect")]
    void DisableDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("capability")] Constant<int, AlEnum, EnableCap> capability
    );

    [NativeName("alDistanceModel")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    void DistanceModel([NativeName("distanceModel")] int distanceModel);

    [NativeName("alDistanceModel")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    void DistanceModel(
        [NativeName("distanceModel")] Constant<int, AlEnum, DistanceModel> distanceModel
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDistanceModelDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
    void DistanceModelDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("distanceModel")] int distanceModel
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDistanceModelDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
    void DistanceModelDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("distanceModel")] Constant<int, AlEnum, DistanceModel> distanceModel
    );

    [NativeName("alDopplerFactor")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
    void DopplerFactor([NativeName("value")] float value);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alDopplerFactorDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDopplerFactorDirect")]
    void DopplerFactorDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("value")] float value
    );

    [NativeName("alDopplerVelocity")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
    void DopplerVelocity([NativeName("value")] float value);

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alEffectf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectf")]
    void Effect(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] int param1,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alEffectf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectf")]
    void Effect(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] Constant<int, AlEnum, EffectFloat> param1,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alEffectfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
    void EffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] int param2,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alEffectfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
    void EffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] Constant<int, AlEnum, EffectFloat> param2,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alEffectfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectfv")]
    void Effect(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] int param1,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alEffectfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectfv")]
    void Effect(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] Constant<int, AlEnum, EffectFloat> param1,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alEffectfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
    void EffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] int param2,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alEffectfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
    void EffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] Constant<int, AlEnum, EffectFloat> param2,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alEffecti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffecti")]
    void Effect(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] int param1,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alEffecti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffecti")]
    void Effect(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] Constant<int, AlEnum, EffectInteger> param1,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alEffectiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
    void EffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] int param2,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alEffectiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
    void EffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] Constant<int, AlEnum, EffectInteger> param2,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alEffectiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectiv")]
    void Effect(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] int param1,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alEffectiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectiv")]
    void Effect(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] Constant<int, AlEnum, EffectInteger> param1,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alEffectivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
    void EffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] int param2,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alEffectivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
    void EffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] Constant<int, AlEnum, EffectInteger> param2,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NativeName("alEnable")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alEnable")]
    void Enable([NativeName("capability")] int capability);

    [NativeName("alEnable")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alEnable")]
    void Enable([NativeName("capability")] Constant<int, AlEnum, EnableCap> capability);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alEnableDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alEnableDirect")]
    void EnableDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("capability")] int capability
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alEnableDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alEnableDirect")]
    void EnableDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("capability")] Constant<int, AlEnum, EnableCap> capability
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alEventCallbackDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventCallbackDirectSOFT")]
    void EventCallbackDirectSOFT(
        [NativeName("context")] ContextHandle context,
        [NativeName("callback")] EventProcSoft callback,
        [NativeName("userParam")] void* userParam
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alEventCallbackDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventCallbackDirectSOFT")]
    void EventCallbackDirectSOFT(
        [NativeName("context")] ContextHandle context,
        [NativeName("callback")] EventProcSoft callback,
        [NativeName("userParam")] Ref userParam
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alEventCallbackSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
    void EventCallbackSOFT(
        [NativeName("callback")] EventProcSoft callback,
        [NativeName("userParam")] void* userParam
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alEventCallbackSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
    void EventCallbackSOFT(
        [NativeName("callback")] EventProcSoft callback,
        [NativeName("userParam")] Ref userParam
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alEventControlDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
    void EventControlDirectSOFT(
        [NativeName("context")] ContextHandle context,
        [NativeName("count")] int count,
        [NativeName("types")] int* types,
        [NativeName("enable")] sbyte enable
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alEventControlDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
    void EventControlDirectSOFT(
        [NativeName("context")] ContextHandle context,
        [NativeName("count")] int count,
        [NativeName("types")] Ref<int> types,
        [NativeName("enable")] MaybeBool<sbyte> enable
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alEventControlDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
    void EventControlDirectSOFT(
        [NativeName("context")] ContextHandle context,
        [NativeName("types")] int types,
        [NativeName("enable")] MaybeBool<sbyte> enable
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alEventControlSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
    void EventControlSOFT(
        [NativeName("count")] int count,
        [NativeName("types")] int* types,
        [NativeName("enable")] sbyte enable
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alEventControlSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
    void EventControlSOFT(
        [NativeName("count")] int count,
        [NativeName("types")] Ref<int> types,
        [NativeName("enable")] MaybeBool<sbyte> enable
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alEventControlSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
    void EventControlSOFT(
        [NativeName("types")] int types,
        [NativeName("enable")] MaybeBool<sbyte> enable
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alFilterf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilterf")]
    void Filter(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] int param1,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alFilterf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilterf")]
    void Filter(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] Constant<int, AlEnum, FilterFloat> param1,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alFilterfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
    void FilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] int param2,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alFilterfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
    void FilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] Constant<int, AlEnum, FilterFloat> param2,
        [NativeName("flValue")] float flValue
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alFilterfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilterfv")]
    void Filter(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] int param1,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alFilterfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilterfv")]
    void Filter(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] Constant<int, AlEnum, FilterFloat> param1,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alFilterfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
    void FilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] int param2,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alFilterfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
    void FilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] Constant<int, AlEnum, FilterFloat> param2,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alFilteri")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilteri")]
    void Filter(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] int param1,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alFilteri")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilteri")]
    void Filter(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] Constant<int, AlEnum, FilterInteger> param1,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alFilteriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
    void FilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] int param2,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alFilteriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
    void FilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] Constant<int, AlEnum, FilterInteger> param2,
        [NativeName("iValue")] int iValue
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alFilteriv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilteriv")]
    void Filter(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] int param1,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alFilteriv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilteriv")]
    void Filter(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] Constant<int, AlEnum, FilterInteger> param1,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alFilterivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
    void FilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] int param2,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alFilterivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
    void FilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] Constant<int, AlEnum, FilterInteger> param2,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NativeName("alGenAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
    uint GenAuxiliaryEffectSlot();

    [NativeName("alGenAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
    void GenAuxiliaryEffectSlots(
        [NativeName("n")] int n,
        [NativeName("effectslots")] uint* effectslots
    );

    [NativeName("alGenAuxiliaryEffectSlots")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
    void GenAuxiliaryEffectSlots(
        [NativeName("n")] int n,
        [NativeName("effectslots")] Ref<uint> effectslots
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
    void GenAuxiliaryEffectSlotsDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("effectslots")] uint* effectslots
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
    void GenAuxiliaryEffectSlotsDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("effectslots")] Ref<uint> effectslots
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenAuxiliaryEffectSlotsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
    uint GenAuxiliaryEffectSlotsDirect([NativeName("context")] ContextHandle context);

    [NativeName("alGenBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    uint GenBuffer();

    [NativeName("alGenBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    void GenBuffers([NativeName("n")] int n, [NativeName("buffers")] uint* buffers);

    [NativeName("alGenBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    void GenBuffers([NativeName("n")] int n, [NativeName("buffers")] Ref<uint> buffers);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
    void GenBuffersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("buffers")] uint* buffers
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
    void GenBuffersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("buffers")] Ref<uint> buffers
    );

    [NativeName("alGenEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenEffects")]
    uint GenEffect();

    [NativeName("alGenEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenEffects")]
    void GenEffects([NativeName("n")] int n, [NativeName("effects")] uint* effects);

    [NativeName("alGenEffects")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenEffects")]
    void GenEffects([NativeName("n")] int n, [NativeName("effects")] Ref<uint> effects);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
    void GenEffectsDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("effects")] uint* effects
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
    void GenEffectsDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("effects")] Ref<uint> effects
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenEffectsDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
    uint GenEffectsDirect([NativeName("context")] ContextHandle context);

    [NativeName("alGenFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenFilters")]
    uint GenFilter();

    [NativeName("alGenFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenFilters")]
    void GenFilters([NativeName("n")] int n, [NativeName("filters")] uint* filters);

    [NativeName("alGenFilters")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenFilters")]
    void GenFilters([NativeName("n")] int n, [NativeName("filters")] Ref<uint> filters);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
    void GenFiltersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("filters")] uint* filters
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
    void GenFiltersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("filters")] Ref<uint> filters
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenFiltersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
    uint GenFiltersDirect([NativeName("context")] ContextHandle context);

    [NativeName("alGenSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    uint GenSource();

    [NativeName("alGenSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    void GenSources([NativeName("n")] int n, [NativeName("sources")] uint* sources);

    [NativeName("alGenSources")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    void GenSources([NativeName("n")] int n, [NativeName("sources")] Ref<uint> sources);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
    void GenSourcesDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] uint* sources
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
    void GenSourcesDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] Ref<uint> sources
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGenSourcesDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
    uint GenSourcesDirect([NativeName("context")] ContextHandle context);

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetAuxiliaryEffectSlotf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
    void AlGetAuxiliaryEffectSlotf(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] int param1,
        [NativeName("flValue")] float* flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetAuxiliaryEffectSlotf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
    void AlGetAuxiliaryEffectSlotf(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
        [NativeName("flValue")] Ref<float> flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetAuxiliaryEffectSlotfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
    void AlGetAuxiliaryEffectSlotfDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] int param2,
        [NativeName("pflValue")] float* pflValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetAuxiliaryEffectSlotfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
    void AlGetAuxiliaryEffectSlotfDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
        [NativeName("pflValue")] Ref<float> pflValue
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetAuxiliaryEffectSlotfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
    void AlGetAuxiliaryEffectSlotfv(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] int param1,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetAuxiliaryEffectSlotfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
    void AlGetAuxiliaryEffectSlotfv(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetAuxiliaryEffectSlotfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
    void AlGetAuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] int param2,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetAuxiliaryEffectSlotfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
    void AlGetAuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetAuxiliaryEffectSloti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
    void AlGetAuxiliaryEffectSloti(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] int param1,
        [NativeName("iValue")] int* iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetAuxiliaryEffectSloti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
    void AlGetAuxiliaryEffectSloti(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
        [NativeName("iValue")] Ref<int> iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetAuxiliaryEffectSlotiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
    void AlGetAuxiliaryEffectSlotiDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] int param2,
        [NativeName("piValue")] int* piValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetAuxiliaryEffectSlotiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
    void AlGetAuxiliaryEffectSlotiDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
        [NativeName("piValue")] Ref<int> piValue
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetAuxiliaryEffectSlotiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
    void AlGetAuxiliaryEffectSlotiv(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] int param1,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetAuxiliaryEffectSlotiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
    void AlGetAuxiliaryEffectSlotiv(
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param1")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetAuxiliaryEffectSlotivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
    void AlGetAuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] int param2,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetAuxiliaryEffectSlotivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
    void AlGetAuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot,
        [NativeName("param2")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NativeName("alGetBoolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    sbyte GetBoolean([NativeName("param0")] int param0);

    [NativeName("alGetBoolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    MaybeBool<sbyte> GetBoolean([NativeName("param0")] Constant<int, AlEnum, BooleanPName> param0);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBooleanDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
    sbyte GetBooleanDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBooleanDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
    MaybeBool<sbyte> GetBooleanDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, BooleanPName> param1
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alGetBooleanv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    void GetBoolean([NativeName("param0")] int param0, [NativeName("values")] sbyte* values);

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alGetBooleanv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    void GetBoolean(
        [NativeName("param0")] Constant<int, AlEnum, BooleanPName> param0,
        [NativeName("values")] Ref<sbyte> values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBooleanvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
    void GetBooleanDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("values")] sbyte* values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBooleanvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
    void GetBooleanDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, BooleanPName> param1,
        [NativeName("values")] Ref<sbyte> values
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetBuffer3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    void GetBuffer3(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("value1")] float* value1,
        [NativeName("value2")] float* value2,
        [NativeName("value3")] float* value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetBuffer3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    void GetBuffer3(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("value1")] Ref<float> value1,
        [NativeName("value2")] Ref<float> value2,
        [NativeName("value3")] Ref<float> value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBuffer3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
    void GetBuffer3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("value1")] float* value1,
        [NativeName("value2")] float* value2,
        [NativeName("value3")] float* value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBuffer3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
    void GetBuffer3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("value1")] Ref<float> value1,
        [NativeName("value2")] Ref<float> value2,
        [NativeName("value3")] Ref<float> value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetBuffer3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    void GetBuffer3(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("value1")] int* value1,
        [NativeName("value2")] int* value2,
        [NativeName("value3")] int* value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetBuffer3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    void GetBuffer3(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("value1")] Ref<int> value1,
        [NativeName("value2")] Ref<int> value2,
        [NativeName("value3")] Ref<int> value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBuffer3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
    void GetBuffer3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("value1")] int* value1,
        [NativeName("value2")] int* value2,
        [NativeName("value3")] int* value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBuffer3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
    void GetBuffer3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("value1")] Ref<int> value1,
        [NativeName("value2")] Ref<int> value2,
        [NativeName("value3")] Ref<int> value3
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("ptr0")] void** ptr0,
        [NativeName("ptr1")] void** ptr1,
        [NativeName("ptr2")] void** ptr2
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] Constant<int, AlEnum, BufferPointerSOFT> param2,
        [NativeName("ptr0")] Ref2D ptr0,
        [NativeName("ptr1")] Ref2D ptr1,
        [NativeName("ptr2")] Ref2D ptr2
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetBuffer3PtrSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
    void GetBuffer3PtrSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("ptr0")] void** ptr0,
        [NativeName("ptr1")] void** ptr1,
        [NativeName("ptr2")] void** ptr2
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetBuffer3PtrSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
    void GetBuffer3PtrSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] Constant<int, AlEnum, BufferPointerSOFT> param1,
        [NativeName("ptr0")] Ref2D ptr0,
        [NativeName("ptr1")] Ref2D ptr1,
        [NativeName("ptr2")] Ref2D ptr2
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetBufferf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferf")]
    void AlGetBufferf(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("value")] float* value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetBufferf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferf")]
    void AlGetBufferf(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] Constant<int, AlEnum, BufferFloat> param1,
        [NativeName("value")] Ref<float> value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBufferfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
    void AlGetBufferfDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("value")] float* value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBufferfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
    void AlGetBufferfDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] Constant<int, AlEnum, BufferFloat> param2,
        [NativeName("value")] Ref<float> value
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetBufferfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
    void AlGetBufferfv(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("values")] float* values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetBufferfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
    void AlGetBufferfv(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] Constant<int, AlEnum, BufferFloat> param1,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBufferfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
    void AlGetBufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("values")] float* values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBufferfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
    void AlGetBufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] Constant<int, AlEnum, BufferFloat> param2,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetBufferi")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferi")]
    void AlGetBufferi(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("value")] int* value
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetBufferi")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferi")]
    void AlGetBufferi(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] Constant<int, AlEnum, BufferInteger> param1,
        [NativeName("value")] Ref<int> value
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBufferiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
    void AlGetBufferiDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("value")] int* value
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBufferiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
    void AlGetBufferiDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] Constant<int, AlEnum, BufferInteger> param2,
        [NativeName("value")] Ref<int> value
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetBufferiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
    void AlGetBufferiv(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("values")] int* values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetBufferiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
    void AlGetBufferiv(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] Constant<int, AlEnum, BufferInteger> param1,
        [NativeName("values")] Ref<int> values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBufferivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
    void AlGetBufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("values")] int* values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetBufferivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
    void AlGetBufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] Constant<int, AlEnum, BufferInteger> param2,
        [NativeName("values")] Ref<int> values
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("ptr")] void** ptr
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] Constant<int, AlEnum, BufferPointerSOFT> param2,
        [NativeName("ptr")] Ref2D ptr
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetBufferPtrSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
    void GetBufferPtrSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("ptr")] void** ptr
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetBufferPtrSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
    void GetBufferPtrSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] Constant<int, AlEnum, BufferPointerSOFT> param1,
        [NativeName("ptr")] Ref2D ptr
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void AlGetBufferPtr(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] int param2,
        [NativeName("ptr")] void** ptr
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void AlGetBufferPtr(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("param2")] Constant<int, AlEnum, BufferPointerSOFT> param2,
        [NativeName("ptr")] Ref2D ptr
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetBufferPtrvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
    void AlGetBufferPtr(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] int param1,
        [NativeName("ptr")] void** ptr
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetBufferPtrvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
    void AlGetBufferPtr(
        [NativeName("buffer")] uint buffer,
        [NativeName("param1")] Constant<int, AlEnum, BufferPointerSOFT> param1,
        [NativeName("ptr")] Ref2D ptr
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetBufferSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
    void GetBufferSamplesSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("offset")] int offset,
        [NativeName("samples")] int samples,
        [NativeName("channels")] int channels,
        [NativeName("type")] int type,
        [NativeName("data")] void* data
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetBufferSamplesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
    void GetBufferSamplesSOFT(
        [NativeName("buffer")] uint buffer,
        [NativeName("offset")] int offset,
        [NativeName("samples")] int samples,
        [NativeName("channels")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
        [NativeName("type")] Constant<int, AlEnum, SampleTypeSOFT> type,
        [NativeName("data")] Ref data
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetDebugMessageLogDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("count")] uint count,
        [NativeName("logBufSize")] int logBufSize,
        [NativeName("sources")] int* sources,
        [NativeName("types")] int* types,
        [NativeName("ids")] uint* ids,
        [NativeName("severities")] int* severities,
        [NativeName("lengths")] int* lengths,
        [NativeName("logBuf")] sbyte* logBuf
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetDebugMessageLogDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("count")] uint count,
        [NativeName("logBufSize")] int logBufSize,
        [NativeName("sources")] Ref<int> sources,
        [NativeName("types")] Ref<int> types,
        [NativeName("ids")] Ref<uint> ids,
        [NativeName("severities")] Ref<int> severities,
        [NativeName("lengths")] Ref<int> lengths,
        [NativeName("logBuf")] Ref<sbyte> logBuf
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetDebugMessageLogDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("count")] uint count,
        [NativeName("logBufSize")] int logBufSize,
        [NativeName("sources")] Ref<AlEnum> sources,
        [NativeName("types")] Ref<AlEnum> types,
        [NativeName("ids")] Ref<uint> ids,
        [NativeName("severities")] Ref<AlEnum> severities,
        [NativeName("lengths")] Ref<int> lengths,
        [NativeName("logBuf")] Ref<sbyte> logBuf
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetDebugMessageLogDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("count")] uint count,
        [NativeName("logBufSize")] int logBufSize,
        [NativeName("sources")] Ref<DebugSourceEXT> sources,
        [NativeName("types")] Ref<DebugTypeEXT> types,
        [NativeName("ids")] Ref<uint> ids,
        [NativeName("severities")] Ref<DebugSeverityEXT> severities,
        [NativeName("lengths")] Ref<int> lengths,
        [NativeName("logBuf")] Ref<sbyte> logBuf
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetDebugMessageLogEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogEXT(
        [NativeName("count")] uint count,
        [NativeName("logBufSize")] int logBufSize,
        [NativeName("sources")] int* sources,
        [NativeName("types")] int* types,
        [NativeName("ids")] uint* ids,
        [NativeName("severities")] int* severities,
        [NativeName("lengths")] int* lengths,
        [NativeName("logBuf")] sbyte* logBuf
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetDebugMessageLogEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogEXT(
        [NativeName("count")] uint count,
        [NativeName("logBufSize")] int logBufSize,
        [NativeName("sources")] Ref<int> sources,
        [NativeName("types")] Ref<int> types,
        [NativeName("ids")] Ref<uint> ids,
        [NativeName("severities")] Ref<int> severities,
        [NativeName("lengths")] Ref<int> lengths,
        [NativeName("logBuf")] Ref<sbyte> logBuf
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetDebugMessageLogEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogEXT(
        [NativeName("count")] uint count,
        [NativeName("logBufSize")] int logBufSize,
        [NativeName("sources")] Ref<AlEnum> sources,
        [NativeName("types")] Ref<AlEnum> types,
        [NativeName("ids")] Ref<uint> ids,
        [NativeName("severities")] Ref<AlEnum> severities,
        [NativeName("lengths")] Ref<int> lengths,
        [NativeName("logBuf")] Ref<sbyte> logBuf
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetDebugMessageLogEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogEXT(
        [NativeName("count")] uint count,
        [NativeName("logBufSize")] int logBufSize,
        [NativeName("sources")] Ref<DebugSourceEXT> sources,
        [NativeName("types")] Ref<DebugTypeEXT> types,
        [NativeName("ids")] Ref<uint> ids,
        [NativeName("severities")] Ref<DebugSeverityEXT> severities,
        [NativeName("lengths")] Ref<int> lengths,
        [NativeName("logBuf")] Ref<sbyte> logBuf
    );

    [NativeName("alGetDouble")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDouble")]
    double GetDouble([NativeName("param0")] int param0);

    [NativeName("alGetDouble")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDouble")]
    double GetDouble([NativeName("param0")] Constant<int, AlEnum, GetPName> param0);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetDoubleDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
    double GetDoubleDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetDoubleDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
    double GetDoubleDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, GetPName> param1
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alGetDoublev")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    void GetDouble([NativeName("param0")] int param0, [NativeName("values")] double* values);

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alGetDoublev")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    void GetDouble(
        [NativeName("param0")] Constant<int, AlEnum, GetPName> param0,
        [NativeName("values")] Ref<double> values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetDoublevDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
    void GetDoubleDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("values")] double* values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetDoublevDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
    void GetDoubleDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, GetPName> param1,
        [NativeName("values")] Ref<double> values
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetEffectf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectf")]
    void AlGetEffectf(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] int param1,
        [NativeName("flValue")] float* flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetEffectf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectf")]
    void AlGetEffectf(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] Constant<int, AlEnum, EffectFloat> param1,
        [NativeName("flValue")] Ref<float> flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetEffectfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
    void AlGetEffectfDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] int param2,
        [NativeName("pflValue")] float* pflValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetEffectfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
    void AlGetEffectfDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] Constant<int, AlEnum, EffectFloat> param2,
        [NativeName("pflValue")] Ref<float> pflValue
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetEffectfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
    void AlGetEffectfv(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] int param1,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetEffectfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
    void AlGetEffectfv(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] Constant<int, AlEnum, EffectFloat> param1,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetEffectfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
    void AlGetEffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] int param2,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetEffectfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
    void AlGetEffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] Constant<int, AlEnum, EffectFloat> param2,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetEffecti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffecti")]
    void AlGetEffecti(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] int param1,
        [NativeName("iValue")] int* iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetEffecti")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffecti")]
    void AlGetEffecti(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] Constant<int, AlEnum, EffectInteger> param1,
        [NativeName("iValue")] Ref<int> iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetEffectiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
    void AlGetEffectiDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] int param2,
        [NativeName("piValue")] int* piValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetEffectiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
    void AlGetEffectiDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] Constant<int, AlEnum, EffectInteger> param2,
        [NativeName("piValue")] Ref<int> piValue
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetEffectiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
    void AlGetEffectiv(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] int param1,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetEffectiv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
    void AlGetEffectiv(
        [NativeName("effect")] uint effect,
        [NativeName("param1")] Constant<int, AlEnum, EffectInteger> param1,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetEffectivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
    void AlGetEffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] int param2,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetEffectivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
    void AlGetEffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect,
        [NativeName("param2")] Constant<int, AlEnum, EffectInteger> param2,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NativeName("alGetEnumValue")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
    int GetEnumValue([NativeName("ename")] sbyte* ename);

    [NativeName("alGetEnumValue")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
    int GetEnumValue([NativeName("ename")] Ref<sbyte> ename);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetEnumValueDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
    int GetEnumValueDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("ename")] sbyte* ename
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetEnumValueDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
    int GetEnumValueDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("ename")] Ref<sbyte> ename
    );

    [NativeName("alGetError")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    Constant<int, ErrorCode> GetError();

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetErrorDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
    Constant<int, ErrorCode> GetErrorDirect([NativeName("context")] ContextHandle context);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetErrorDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
    int GetErrorDirectRawDirect([NativeName("context")] ContextHandle context);

    [NativeName("alGetError")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    int GetErrorRaw();

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetFilterf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilterf")]
    void AlGetFilterf(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] int param1,
        [NativeName("flValue")] float* flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetFilterf")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilterf")]
    void AlGetFilterf(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] Constant<int, AlEnum, FilterFloat> param1,
        [NativeName("flValue")] Ref<float> flValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFilterfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
    void AlGetFilterfDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] int param2,
        [NativeName("pflValue")] float* pflValue
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFilterfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
    void AlGetFilterfDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] Constant<int, AlEnum, FilterFloat> param2,
        [NativeName("pflValue")] Ref<float> pflValue
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetFilterfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
    void AlGetFilterfv(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] int param1,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetFilterfv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
    void AlGetFilterfv(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] Constant<int, AlEnum, FilterFloat> param1,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFilterfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
    void AlGetFilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] int param2,
        [NativeName("pflValues")] float* pflValues
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFilterfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
    void AlGetFilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] Constant<int, AlEnum, FilterFloat> param2,
        [NativeName("pflValues")] Ref<float> pflValues
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetFilteri")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilteri")]
    void AlGetFilteri(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] int param1,
        [NativeName("iValue")] int* iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetFilteri")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilteri")]
    void AlGetFilteri(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] Constant<int, AlEnum, FilterInteger> param1,
        [NativeName("iValue")] Ref<int> iValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFilteriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
    void AlGetFilteriDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] int param2,
        [NativeName("piValue")] int* piValue
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFilteriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
    void AlGetFilteriDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] Constant<int, AlEnum, FilterInteger> param2,
        [NativeName("piValue")] Ref<int> piValue
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetFilteriv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
    void AlGetFilteriv(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] int param1,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetFilteriv")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
    void AlGetFilteriv(
        [NativeName("filter")] uint filter,
        [NativeName("param1")] Constant<int, AlEnum, FilterInteger> param1,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFilterivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
    void AlGetFilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] int param2,
        [NativeName("piValues")] int* piValues
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFilterivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
    void AlGetFilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter,
        [NativeName("param2")] Constant<int, AlEnum, FilterInteger> param2,
        [NativeName("piValues")] Ref<int> piValues
    );

    [NativeName("alGetFloat")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloat")]
    float GetFloat([NativeName("param0")] int param0);

    [NativeName("alGetFloat")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloat")]
    float GetFloat([NativeName("param0")] Constant<int, AlEnum, FloatPName> param0);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFloatDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
    float GetFloatDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFloatDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
    float GetFloatDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, FloatPName> param1
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alGetFloatv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    void GetFloat([NativeName("param0")] int param0, [NativeName("values")] float* values);

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alGetFloatv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    void GetFloat(
        [NativeName("param0")] Constant<int, AlEnum, GetPName> param0,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFloatvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
    void GetFloatDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("values")] float* values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetFloatvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
    void GetFloatDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, GetPName> param1,
        [NativeName("values")] Ref<float> values
    );

    [NativeName("alGetInteger")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetInteger")]
    int GetInteger([NativeName("param0")] int param0);

    [NativeName("alGetInteger")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetInteger")]
    int GetInteger([NativeName("param0")] Constant<int, AlEnum, IntegerPName> param0);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetIntegerDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
    int GetIntegerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetIntegerDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
    int GetIntegerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, IntegerPName> param1
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alGetIntegerv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    void GetInteger([NativeName("param0")] int param0, [NativeName("values")] int* values);

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alGetIntegerv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    void GetInteger(
        [NativeName("param0")] Constant<int, AlEnum, IntegerPName> param0,
        [NativeName("values")] Ref<int> values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetIntegervDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
    void GetIntegerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("values")] int* values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetIntegervDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
    void GetIntegerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, IntegerPName> param1,
        [NativeName("values")] Ref<int> values
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetListener3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    void GetListener3(
        [NativeName("param0")] int param0,
        [NativeName("value1")] float* value1,
        [NativeName("value2")] float* value2,
        [NativeName("value3")] float* value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetListener3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    void GetListener3(
        [NativeName("param0")] Constant<int, AlEnum, ListenerFloat3> param0,
        [NativeName("value1")] Ref<float> value1,
        [NativeName("value2")] Ref<float> value2,
        [NativeName("value3")] Ref<float> value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListener3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
    void GetListener3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("value1")] float* value1,
        [NativeName("value2")] float* value2,
        [NativeName("value3")] float* value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListener3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
    void GetListener3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, ListenerFloat3> param1,
        [NativeName("value1")] Ref<float> value1,
        [NativeName("value2")] Ref<float> value2,
        [NativeName("value3")] Ref<float> value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetListener3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    void GetListener3(
        [NativeName("param0")] int param0,
        [NativeName("value1")] int* value1,
        [NativeName("value2")] int* value2,
        [NativeName("value3")] int* value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetListener3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    void GetListener3(
        [NativeName("param0")] Constant<int, AlEnum, ListenerInteger3> param0,
        [NativeName("value1")] Ref<int> value1,
        [NativeName("value2")] Ref<int> value2,
        [NativeName("value3")] Ref<int> value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListener3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
    void GetListener3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("value1")] int* value1,
        [NativeName("value2")] int* value2,
        [NativeName("value3")] int* value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListener3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
    void GetListener3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, ListenerInteger3> param1,
        [NativeName("value1")] Ref<int> value1,
        [NativeName("value2")] Ref<int> value2,
        [NativeName("value3")] Ref<int> value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetListenerf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    void AlGetListenerf([NativeName("param0")] int param0, [NativeName("value")] float* value);

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetListenerf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    void AlGetListenerf(
        [NativeName("param0")] Constant<int, AlEnum, ListenerFloat> param0,
        [NativeName("value")] Ref<float> value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListenerfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
    void AlGetListenerfDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("value")] float* value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListenerfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
    void AlGetListenerfDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, ListenerFloat> param1,
        [NativeName("value")] Ref<float> value
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetListenerfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    void AlGetListenerfv([NativeName("param0")] int param0, [NativeName("values")] float* values);

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetListenerfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    void AlGetListenerfv(
        [NativeName("param0")] Constant<int, AlEnum, ListenerFloat> param0,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListenerfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
    void AlGetListenerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("values")] float* values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListenerfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
    void AlGetListenerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, ListenerFloat> param1,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetListeneri")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    void AlGetListeneri([NativeName("param0")] int param0, [NativeName("value")] int* value);

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetListeneri")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    void AlGetListeneri([NativeName("param0")] int param0, [NativeName("value")] Ref<int> value);

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetListeneri")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    int AlGetListeneri();

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListeneriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
    void AlGetListeneriDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("value")] int* value
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListeneriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
    void AlGetListeneriDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("value")] Ref<int> value
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetListeneriv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    void AlGetListeneriv([NativeName("param0")] int param0, [NativeName("values")] int* values);

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetListeneriv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    void AlGetListeneriv([NativeName("param0")] int param0, [NativeName("values")] Ref<int> values);

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetListeneriv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    int AlGetListeneriv();

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListenerivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
    void AlGetListenerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("values")] int* values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetListenerivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
    void AlGetListenerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("values")] Ref<int> values
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
    void GetObjectLabelDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("identifier")] int identifier,
        [NativeName("name")] uint name,
        [NativeName("bufSize")] int bufSize,
        [NativeName("length")] int* length,
        [NativeName("label")] sbyte* label
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
    void GetObjectLabelDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeName("name")] uint name,
        [NativeName("bufSize")] int bufSize,
        [NativeName("length")] Ref<int> length,
        [NativeName("label")] Ref<sbyte> label
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
    sbyte GetObjectLabelDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeName("name")] uint name,
        [NativeName("length")] Ref<int> length
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
    void GetObjectLabelEXT(
        [NativeName("identifier")] int identifier,
        [NativeName("name")] uint name,
        [NativeName("bufSize")] int bufSize,
        [NativeName("length")] int* length,
        [NativeName("label")] sbyte* label
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
    void GetObjectLabelEXT(
        [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeName("name")] uint name,
        [NativeName("bufSize")] int bufSize,
        [NativeName("length")] Ref<int> length,
        [NativeName("label")] Ref<sbyte> label
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
    sbyte GetObjectLabelEXT(
        [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeName("name")] uint name,
        [NativeName("length")] Ref<int> length
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetPointerDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
    void* GetPointerDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("pname")] int pname
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetPointerDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
    Ptr GetPointerDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetPointerDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectSOFT")]
    void* GetPointerDirectSOFT(
        [NativeName("context")] ContextHandle context,
        [NativeName("pname")] int pname
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetPointerDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectSOFT")]
    Ptr GetPointerDirectSOFT(
        [NativeName("context")] ContextHandle context,
        [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetPointerEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
    void* GetPointerEXT([NativeName("pname")] int pname);

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetPointerEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
    Ptr GetPointerEXT([NativeName("pname")] Constant<int, AlEnum, PointerPName> pname);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetPointerSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
    void* GetPointerSOFT([NativeName("pname")] int pname);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetPointerSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
    Ptr GetPointerSOFT([NativeName("pname")] Constant<int, AlEnum, PointerPName> pname);

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetPointervDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
    void GetPointerDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("pname")] int pname,
        [NativeName("values")] void** values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetPointervDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
    void GetPointerDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname,
        [NativeName("values")] Ref2D values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetPointervDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectSOFT")]
    void GetPointerDirectSOFT(
        [NativeName("context")] ContextHandle context,
        [NativeName("pname")] int pname,
        [NativeName("values")] void** values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetPointervDirectSOFT")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectSOFT")]
    void GetPointerDirectSOFT(
        [NativeName("context")] ContextHandle context,
        [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname,
        [NativeName("values")] Ref2D values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetPointervEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
    void GetPointerEXT([NativeName("pname")] int pname, [NativeName("values")] void** values);

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alGetPointervEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
    void GetPointerEXT(
        [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname,
        [NativeName("values")] Ref2D values
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetPointervSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
    void GetPointerSOFT([NativeName("pname")] int pname, [NativeName("values")] void** values);

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetPointervSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
    void GetPointerSOFT(
        [NativeName("pname")] Constant<int, AlEnum, PointerPName> pname,
        [NativeName("values")] Ref2D values
    );

    [NativeName("alGetProcAddress")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    void* GetProcAddress([NativeName("fname")] sbyte* fname);

    [NativeName("alGetProcAddress")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    Ptr GetProcAddress([NativeName("fname")] Ref<sbyte> fname);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetProcAddressDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
    void* GetProcAddressDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("fname")] sbyte* fname
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetProcAddressDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
    Ptr GetProcAddressDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("fname")] Ref<sbyte> fname
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value1")] double* value1,
        [NativeName("value2")] double* value2,
        [NativeName("value3")] double* value3
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value1")] Ref<double> value1,
        [NativeName("value2")] Ref<double> value2,
        [NativeName("value3")] Ref<double> value3
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSource3dSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
    void GetSource3SOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value1")] double* value1,
        [NativeName("value2")] double* value2,
        [NativeName("value3")] double* value3
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSource3dSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
    void GetSource3SOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value1")] Ref<double> value1,
        [NativeName("value2")] Ref<double> value2,
        [NativeName("value3")] Ref<double> value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetSource3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    void GetSource3(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value1")] float* value1,
        [NativeName("value2")] float* value2,
        [NativeName("value3")] float* value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetSource3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    void GetSource3(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceFloat3> param1,
        [NativeName("value1")] Ref<float> value1,
        [NativeName("value2")] Ref<float> value2,
        [NativeName("value3")] Ref<float> value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSource3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
    void GetSource3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value1")] float* value1,
        [NativeName("value2")] float* value2,
        [NativeName("value3")] float* value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSource3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
    void GetSource3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceFloat3> param2,
        [NativeName("value1")] Ref<float> value1,
        [NativeName("value2")] Ref<float> value2,
        [NativeName("value3")] Ref<float> value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetSource3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    void GetSource3(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value1")] int* value1,
        [NativeName("value2")] int* value2,
        [NativeName("value3")] int* value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetSource3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    void GetSource3(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger3> param1,
        [NativeName("value1")] Ref<int> value1,
        [NativeName("value2")] Ref<int> value2,
        [NativeName("value3")] Ref<int> value3
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value1")] nint* value1,
        [NativeName("value2")] nint* value2,
        [NativeName("value3")] nint* value3
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger3> param2,
        [NativeName("value1")] Ref<nint> value1,
        [NativeName("value2")] Ref<nint> value2,
        [NativeName("value3")] Ref<nint> value3
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSource3i64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
    void GetSource3SOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value1")] nint* value1,
        [NativeName("value2")] nint* value2,
        [NativeName("value3")] nint* value3
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSource3i64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
    void GetSource3SOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger3> param1,
        [NativeName("value1")] Ref<nint> value1,
        [NativeName("value2")] Ref<nint> value2,
        [NativeName("value3")] Ref<nint> value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSource3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
    void GetSource3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value1")] int* value1,
        [NativeName("value2")] int* value2,
        [NativeName("value3")] int* value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSource3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
    void GetSource3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger3> param2,
        [NativeName("value1")] Ref<int> value1,
        [NativeName("value2")] Ref<int> value2,
        [NativeName("value3")] Ref<int> value3
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value")] double* value
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceDouble> param2,
        [NativeName("value")] Ref<double> value
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSourcedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
    void GetSourceSOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value")] double* value
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSourcedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
    void GetSourceSOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceDouble> param1,
        [NativeName("value")] Ref<double> value
    );

    [NameAffix("Suffix", "dv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void AlGetSourcedvDirectSoft(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("values")] double* values
    );

    [NameAffix("Suffix", "dv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void AlGetSourcedvDirectSoft(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceDouble> param2,
        [NativeName("values")] Ref<double> values
    );

    [NameAffix("Suffix", "dv", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSourcedvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
    void AlGetSourcedvSoft(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("values")] double* values
    );

    [NameAffix("Suffix", "dv", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSourcedvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
    void AlGetSourcedvSoft(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceDouble> param1,
        [NativeName("values")] Ref<double> values
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetSourcef")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcef")]
    void AlGetSourcef(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value")] float* value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alGetSourcef")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcef")]
    void AlGetSourcef(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceFloat> param1,
        [NativeName("value")] Ref<float> value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSourcefDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
    void AlGetSourcefDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value")] float* value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSourcefDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
    void AlGetSourcefDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceFloat> param2,
        [NativeName("value")] Ref<float> value
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetSourcefv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
    void AlGetSourcefv(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("values")] float* values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alGetSourcefv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
    void AlGetSourcefv(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceFloat> param1,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSourcefvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
    void AlGetSourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("values")] float* values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSourcefvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
    void AlGetSourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceFloat> param2,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetSourcei")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcei")]
    void AlGetSourcei(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value")] int* value
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alGetSourcei")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcei")]
    void AlGetSourcei(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeName("value")] Ref<int> value
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void AlGetSourcei64DirectSoft(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value")] nint* value
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void AlGetSourcei64DirectSoft(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeName("value")] Ref<nint> value
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSourcei64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
    void AlGetSourcei64Soft(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value")] nint* value
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSourcei64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
    void AlGetSourcei64Soft(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeName("value")] Ref<nint> value
    );

    [NameAffix("Suffix", "i64v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void AlGetSourcei64VDirectSoft(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("values")] nint* values
    );

    [NameAffix("Suffix", "i64v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void AlGetSourcei64VDirectSoft(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeName("values")] Ref<nint> values
    );

    [NameAffix("Suffix", "i64v", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSourcei64vSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
    void AlGetSourcei64VSoft(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("values")] nint* values
    );

    [NameAffix("Suffix", "i64v", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetSourcei64vSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
    void AlGetSourcei64VSoft(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeName("values")] Ref<nint> values
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSourceiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
    void AlGetSourceiDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value")] int* value
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSourceiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
    void AlGetSourceiDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeName("value")] Ref<int> value
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetSourceiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
    void AlGetSourceiv(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("values")] int* values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alGetSourceiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
    void AlGetSourceiv(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeName("values")] Ref<int> values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSourceivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
    void AlGetSourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("values")] int* values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetSourceivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
    void AlGetSourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeName("values")] Ref<int> values
    );

    [NativeName("alGetString")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    sbyte* GetString([NativeName("param0")] int param0);

    [NativeName("alGetString")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    Ptr<sbyte> GetString([NativeName("param0")] Constant<int, AlEnum, StringPName> param0);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetStringDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
    sbyte* GetStringDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alGetStringDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
    Ptr<sbyte> GetStringDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, StringPName> param1
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    sbyte* GetStringDirectSOFT(
        [NativeName("context")] ContextHandle context,
        [NativeName("pname")] int pname,
        [NativeName("index")] int index
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("pname")] Constant<int, AlEnum, StringPName> pname,
        [NativeName("index")] int index
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetStringiSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
    [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
    sbyte* GetStringSOFT([NativeName("pname")] int pname, [NativeName("index")] int index);

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alGetStringiSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
    [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
    Ptr<sbyte> GetStringSOFT(
        [NativeName("pname")] Constant<int, AlEnum, StringPName> pname,
        [NativeName("index")] int index
    );

    [NativeName("alIsAuxiliaryEffectSlot")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
    MaybeBool<sbyte> IsAuxiliaryEffectSlot([NativeName("effectslot")] uint effectslot);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsAuxiliaryEffectSlotDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
    MaybeBool<sbyte> IsAuxiliaryEffectSlotDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsAuxiliaryEffectSlotDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
    sbyte IsAuxiliaryEffectSlotDirectRawDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effectslot")] uint effectslot
    );

    [NativeName("alIsAuxiliaryEffectSlot")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
    sbyte IsAuxiliaryEffectSlotRaw([NativeName("effectslot")] uint effectslot);

    [NativeName("alIsBuffer")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    MaybeBool<sbyte> IsBuffer([NativeName("buffer")] uint buffer);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsBufferDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
    MaybeBool<sbyte> IsBufferDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsBufferDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
    sbyte IsBufferDirectRawDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alIsBufferFormatSupportedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
    MaybeBool<sbyte> IsBufferFormatSupportedSOFT([NativeName("format")] int format);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alIsBufferFormatSupportedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
    sbyte IsBufferFormatSupportedSoftRawSOFT([NativeName("format")] int format);

    [NativeName("alIsBuffer")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    sbyte IsBufferRaw([NativeName("buffer")] uint buffer);

    [NativeName("alIsEffect")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsEffect")]
    MaybeBool<sbyte> IsEffect([NativeName("effect")] uint effect);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsEffectDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
    MaybeBool<sbyte> IsEffectDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsEffectDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
    sbyte IsEffectDirectRawDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("effect")] uint effect
    );

    [NativeName("alIsEffect")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsEffect")]
    sbyte IsEffectRaw([NativeName("effect")] uint effect);

    [NativeName("alIsEnabled")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    sbyte IsEnabled([NativeName("capability")] int capability);

    [NativeName("alIsEnabled")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    MaybeBool<sbyte> IsEnabled(
        [NativeName("capability")] Constant<int, AlEnum, EnableCap> capability
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsEnabledDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
    sbyte IsEnabledDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("capability")] int capability
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsEnabledDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
    MaybeBool<sbyte> IsEnabledDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("capability")] Constant<int, AlEnum, EnableCap> capability
    );

    [NativeName("alIsExtensionPresent")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
    sbyte IsExtensionPresent([NativeName("extname")] sbyte* extname);

    [NativeName("alIsExtensionPresent")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
    MaybeBool<sbyte> IsExtensionPresent([NativeName("extname")] Ref<sbyte> extname);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsExtensionPresentDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
    sbyte IsExtensionPresentDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("extname")] sbyte* extname
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsExtensionPresentDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
    MaybeBool<sbyte> IsExtensionPresentDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("extname")] Ref<sbyte> extname
    );

    [NativeName("alIsFilter")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsFilter")]
    MaybeBool<sbyte> IsFilter([NativeName("filter")] uint filter);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsFilterDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
    MaybeBool<sbyte> IsFilterDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsFilterDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
    sbyte IsFilterDirectRawDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("filter")] uint filter
    );

    [NativeName("alIsFilter")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsFilter")]
    sbyte IsFilterRaw([NativeName("filter")] uint filter);

    [NativeName("alIsSource")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    MaybeBool<sbyte> IsSource([NativeName("source")] uint source);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsSourceDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
    MaybeBool<sbyte> IsSourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alIsSourceDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
    sbyte IsSourceDirectRawDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source
    );

    [NativeName("alIsSource")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    sbyte IsSourceRaw([NativeName("source")] uint source);

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alListener3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3f")]
    void Listener3(
        [NativeName("param0")] int param0,
        [NativeName("value1")] float value1,
        [NativeName("value2")] float value2,
        [NativeName("value3")] float value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alListener3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3f")]
    void Listener3(
        [NativeName("param0")] Constant<int, AlEnum, ListenerFloat3> param0,
        [NativeName("value1")] float value1,
        [NativeName("value2")] float value2,
        [NativeName("value3")] float value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alListener3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
    void Listener3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("value1")] float value1,
        [NativeName("value2")] float value2,
        [NativeName("value3")] float value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alListener3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
    void Listener3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, ListenerFloat3> param1,
        [NativeName("value1")] float value1,
        [NativeName("value2")] float value2,
        [NativeName("value3")] float value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alListener3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3i")]
    void Listener3(
        [NativeName("param0")] int param0,
        [NativeName("value1")] int value1,
        [NativeName("value2")] int value2,
        [NativeName("value3")] int value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alListener3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3i")]
    void Listener3(
        [NativeName("param0")] Constant<int, AlEnum, ListenerInteger3> param0,
        [NativeName("value1")] int value1,
        [NativeName("value2")] int value2,
        [NativeName("value3")] int value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alListener3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
    void Listener3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("value1")] int value1,
        [NativeName("value2")] int value2,
        [NativeName("value3")] int value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alListener3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
    void Listener3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, ListenerInteger3> param1,
        [NativeName("value1")] int value1,
        [NativeName("value2")] int value2,
        [NativeName("value3")] int value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alListenerf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerf")]
    void Listener([NativeName("param0")] int param0, [NativeName("value")] float value);

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alListenerf")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerf")]
    void Listener(
        [NativeName("param0")] Constant<int, AlEnum, ListenerFloat> param0,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alListenerfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
    void ListenerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alListenerfDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
    void ListenerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, ListenerFloat> param1,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alListenerfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    void Listener([NativeName("param0")] int param0, [NativeName("values")] float* values);

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alListenerfv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    void Listener(
        [NativeName("param0")] Constant<int, AlEnum, ListenerFloat> param0,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alListenerfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
    void ListenerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("values")] float* values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alListenerfvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
    void ListenerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] Constant<int, AlEnum, ListenerFloat> param1,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alListeneri")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListeneri")]
    void Listener([NativeName("param0")] int param0, [NativeName("value")] int value);

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alListeneriDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListeneriDirect")]
    void ListenerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("value")] int value
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alListeneriv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    void Listener([NativeName("param0")] int param0, [NativeName("values")] int* values);

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alListeneriv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    void Listener([NativeName("param0")] int param0, [NativeName("values")] Ref<int> values);

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alListenerivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
    void ListenerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("values")] int* values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alListenerivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
    void ListenerDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("param1")] int param1,
        [NativeName("values")] Ref<int> values
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
    void ObjectLabelDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("identifier")] int identifier,
        [NativeName("name")] uint name,
        [NativeName("length")] int length,
        [NativeName("label")] sbyte* label
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
    void ObjectLabelDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeName("name")] uint name,
        [NativeName("length")] int length,
        [NativeName("label")] Ref<sbyte> label
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alObjectLabelDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
    void ObjectLabelDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeName("name")] uint name,
        [NativeName("label")] sbyte label
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
    void ObjectLabelEXT(
        [NativeName("identifier")] int identifier,
        [NativeName("name")] uint name,
        [NativeName("length")] int length,
        [NativeName("label")] sbyte* label
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
    void ObjectLabelEXT(
        [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeName("name")] uint name,
        [NativeName("length")] int length,
        [NativeName("label")] Ref<sbyte> label
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alObjectLabelEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
    void ObjectLabelEXT(
        [NativeName("identifier")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeName("name")] uint name,
        [NativeName("label")] sbyte label
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alPopDebugGroupDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alPopDebugGroupDirectEXT")]
    void PopDebugGroupDirectEXT([NativeName("context")] ContextHandle context);

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alPopDebugGroupEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alPopDebugGroupEXT")]
    void PopDebugGroupEXT();

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void ProcessUpdatesDirectSOFT([NativeName("context")] ContextHandle context);

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alProcessUpdatesSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
    [NativeFunction("openal", EntryPoint = "alProcessUpdatesSOFT")]
    void ProcessUpdatesSOFT();

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alPushDebugGroupDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
    void PushDebugGroupDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] int source,
        [NativeName("id")] uint id,
        [NativeName("length")] int length,
        [NativeName("message")] sbyte* message
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alPushDebugGroupDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
    void PushDebugGroupDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("id")] uint id,
        [NativeName("length")] int length,
        [NativeName("message")] Ref<sbyte> message
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alPushDebugGroupDirectEXT")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
    void PushDebugGroupDirectEXT(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("id")] uint id,
        [NativeName("message")] sbyte message
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alPushDebugGroupEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
    void PushDebugGroupEXT(
        [NativeName("source")] int source,
        [NativeName("id")] uint id,
        [NativeName("length")] int length,
        [NativeName("message")] sbyte* message
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alPushDebugGroupEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
    void PushDebugGroupEXT(
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("id")] uint id,
        [NativeName("length")] int length,
        [NativeName("message")] Ref<sbyte> message
    );

    [NameAffix("Suffix", "EXT", 0, -1)]
    [NativeName("alPushDebugGroupEXT")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
    void PushDebugGroupEXT(
        [NativeName("source")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeName("id")] uint id,
        [NativeName("message")] sbyte message
    );

    [NativeName("alRequestFoldbackStart")]
    [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
    void RequestFoldbackStart(
        [NativeName("mode")] int mode,
        [NativeName("count")] int count,
        [NativeName("length")] int length,
        [NativeName("mem")] float* mem,
        [NativeName("callback")] FoldbackCallback callback
    );

    [NativeName("alRequestFoldbackStart")]
    [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
    void RequestFoldbackStart(
        [NativeName("mode")] int mode,
        [NativeName("count")] int count,
        [NativeName("length")] int length,
        [NativeName("mem")] Ref<float> mem,
        [NativeName("callback")] FoldbackCallback callback
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alRequestFoldbackStartDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStartDirect")]
    void RequestFoldbackStartDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("mode")] int mode,
        [NativeName("count")] int count,
        [NativeName("length")] int length,
        [NativeName("mem")] float* mem,
        [NativeName("callback")] FoldbackCallback callback
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alRequestFoldbackStartDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStartDirect")]
    void RequestFoldbackStartDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("mode")] int mode,
        [NativeName("count")] int count,
        [NativeName("length")] int length,
        [NativeName("mem")] Ref<float> mem,
        [NativeName("callback")] FoldbackCallback callback
    );

    [NativeName("alRequestFoldbackStop")]
    [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStop")]
    void RequestFoldbackStop();

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alRequestFoldbackStopDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStopDirect")]
    void RequestFoldbackStopDirect([NativeName("context")] ContextHandle context);

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value1")] double value1,
        [NativeName("value2")] double value2,
        [NativeName("value3")] double value3
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSource3dSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSource3dSOFT")]
    void Source3SOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value1")] double value1,
        [NativeName("value2")] double value2,
        [NativeName("value3")] double value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alSource3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3f")]
    void Source3(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value1")] float value1,
        [NativeName("value2")] float value2,
        [NativeName("value3")] float value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alSource3f")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3f")]
    void Source3(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceFloat3> param1,
        [NativeName("value1")] float value1,
        [NativeName("value2")] float value2,
        [NativeName("value3")] float value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSource3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
    void Source3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value1")] float value1,
        [NativeName("value2")] float value2,
        [NativeName("value3")] float value3
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSource3fDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
    void Source3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceFloat3> param2,
        [NativeName("value1")] float value1,
        [NativeName("value2")] float value2,
        [NativeName("value3")] float value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alSource3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3i")]
    void Source3(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value1")] int value1,
        [NativeName("value2")] int value2,
        [NativeName("value3")] int value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alSource3i")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3i")]
    void Source3(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger3> param1,
        [NativeName("value1")] int value1,
        [NativeName("value2")] int value2,
        [NativeName("value3")] int value3
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value1")] nint value1,
        [NativeName("value2")] nint value2,
        [NativeName("value3")] nint value3
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger3> param2,
        [NativeName("value1")] nint value1,
        [NativeName("value2")] nint value2,
        [NativeName("value3")] nint value3
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSource3i64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
    void Source3SOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value1")] nint value1,
        [NativeName("value2")] nint value2,
        [NativeName("value3")] nint value3
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSource3i64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
    void Source3SOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger3> param1,
        [NativeName("value1")] nint value1,
        [NativeName("value2")] nint value2,
        [NativeName("value3")] nint value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSource3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
    void Source3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value1")] int value1,
        [NativeName("value2")] int value2,
        [NativeName("value3")] int value3
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSource3iDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
    void Source3Direct(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger3> param2,
        [NativeName("value1")] int value1,
        [NativeName("value2")] int value2,
        [NativeName("value3")] int value3
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value")] double value
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceDouble> param2,
        [NativeName("value")] double value
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
    void SourceSOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value")] double value
    );

    [NameAffix("Suffix", "d", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcedSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
    void SourceSOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceDouble> param1,
        [NativeName("value")] double value
    );

    [NameAffix("Suffix", "dv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("values")] double* values
    );

    [NameAffix("Suffix", "dv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceDouble> param2,
        [NativeName("values")] Ref<double> values
    );

    [NameAffix("Suffix", "dv", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcedvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
    void SourceSOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("values")] double* values
    );

    [NameAffix("Suffix", "dv", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcedvSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
    void SourceSOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceDouble> param1,
        [NativeName("values")] Ref<double> values
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alSourcef")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcef")]
    void Source(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NativeName("alSourcef")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcef")]
    void Source(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceFloat> param1,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcefDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
    void SourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "f", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcefDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
    void SourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceFloat> param2,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alSourcefv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    void Source(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("values")] float* values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NativeName("alSourcefv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    void Source(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceFloat> param1,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcefvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
    void SourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("values")] float* values
    );

    [NameAffix("Suffix", "fv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcefvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
    void SourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceFloat> param2,
        [NativeName("values")] Ref<float> values
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alSourcei")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcei")]
    void Source(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value")] int value
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NativeName("alSourcei")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcei")]
    void Source(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeName("value")] int value
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value")] nint value
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeName("value")] nint value
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcei64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
    void SourceSOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("value")] nint value
    );

    [NameAffix("Suffix", "i64", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcei64SOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
    void SourceSOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeName("value")] nint value
    );

    [NameAffix("Suffix", "i64v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("values")] nint* values
    );

    [NameAffix("Suffix", "i64v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeName("values")] Ref<nint> values
    );

    [NameAffix("Suffix", "i64v", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcei64vSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
    void SourceSOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("values")] nint* values
    );

    [NameAffix("Suffix", "i64v", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcei64vSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
    void SourceSOFT(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeName("values")] Ref<nint> values
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
    void SourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("value")] int value
    );

    [NameAffix("Suffix", "i", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceiDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
    void SourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeName("value")] int value
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alSourceiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    void Source(
        [NativeName("source")] uint source,
        [NativeName("param1")] int param1,
        [NativeName("values")] int* values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NativeName("alSourceiv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    void Source(
        [NativeName("source")] uint source,
        [NativeName("param1")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeName("values")] Ref<int> values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
    void SourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] int param2,
        [NativeName("values")] int* values
    );

    [NameAffix("Suffix", "iv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceivDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
    void SourceDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("param2")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeName("values")] Ref<int> values
    );

    [NativeName("alSourcePause")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePause")]
    void SourcePause([NativeName("source")] uint source);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcePauseDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePauseDirect")]
    void SourcePauseDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alSourcePausev")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    void AlSourcePause([NativeName("n")] int n, [NativeName("sources")] uint* sources);

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alSourcePausev")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    void AlSourcePause([NativeName("n")] int n, [NativeName("sources")] Ref<uint> sources);

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alSourcePausev")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    void AlSourcePause([NativeName("sources")] uint sources);

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcePausevDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
    void AlSourcePause(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] uint* sources
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcePausevDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
    void AlSourcePause(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] Ref<uint> sources
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcePausevDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
    void AlSourcePause(
        [NativeName("context")] ContextHandle context,
        [NativeName("sources")] uint sources
    );

    [NativeName("alSourcePlay")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePlay")]
    void SourcePlay([NativeName("source")] uint source);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void SourcePlayAtTimeDirectSOFT(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("start_time")] nint start_time
    );

    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcePlayAtTimeSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimeSOFT")]
    void SourcePlayAtTimeSOFT(
        [NativeName("source")] uint source,
        [NativeName("start_time")] nint start_time
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void AlSourcePlayAtTime(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] uint* sources,
        [NativeName("start_time")] nint start_time
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void AlSourcePlayAtTime(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] Ref<uint> sources,
        [NativeName("start_time")] nint start_time
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
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
    void AlSourcePlayAtTime(
        [NativeName("context")] ContextHandle context,
        [NativeName("sources")] uint sources,
        [NativeName("start_time")] nint start_time
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcePlayAtTimevSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
    void AlSourcePlayAtTime(
        [NativeName("n")] int n,
        [NativeName("sources")] uint* sources,
        [NativeName("start_time")] nint start_time
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcePlayAtTimevSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
    void AlSourcePlayAtTime(
        [NativeName("n")] int n,
        [NativeName("sources")] Ref<uint> sources,
        [NativeName("start_time")] nint start_time
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "SOFT", 0, -1)]
    [NativeName("alSourcePlayAtTimevSOFT")]
    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
    void AlSourcePlayAtTime(
        [NativeName("sources")] uint sources,
        [NativeName("start_time")] nint start_time
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcePlayDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayDirect")]
    void SourcePlayDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alSourcePlayv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    void AlSourcePlay([NativeName("n")] int n, [NativeName("sources")] uint* sources);

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alSourcePlayv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    void AlSourcePlay([NativeName("n")] int n, [NativeName("sources")] Ref<uint> sources);

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alSourcePlayv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    void AlSourcePlay([NativeName("sources")] uint sources);

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcePlayvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
    void AlSourcePlay(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] uint* sources
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcePlayvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
    void AlSourcePlay(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] Ref<uint> sources
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourcePlayvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
    void AlSourcePlay(
        [NativeName("context")] ContextHandle context,
        [NativeName("sources")] uint sources
    );

    [NativeName("alSourceQueueBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
    void SourceQueueBuffers(
        [NativeName("source")] uint source,
        [NativeName("nb")] int nb,
        [NativeName("buffers")] uint* buffers
    );

    [NativeName("alSourceQueueBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
    void SourceQueueBuffers(
        [NativeName("source")] uint source,
        [NativeName("nb")] int nb,
        [NativeName("buffers")] Ref<uint> buffers
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceQueueBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
    void SourceQueueBuffersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("nb")] int nb,
        [NativeName("buffers")] uint* buffers
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceQueueBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
    void SourceQueueBuffersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("nb")] int nb,
        [NativeName("buffers")] Ref<uint> buffers
    );

    [NativeName("alSourceRewind")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewind")]
    void SourceRewind([NativeName("source")] uint source);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceRewindDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceRewindDirect")]
    void SourceRewindDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source
    );

    [NameAffix("Suffix", "dv", -1, -1)]
    [NativeName("alSourceRewindv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewin([NativeName("n")] int n, [NativeName("sources")] uint* sources);

    [NameAffix("Suffix", "dv", -1, -1)]
    [NativeName("alSourceRewindv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewin([NativeName("n")] int n, [NativeName("sources")] Ref<uint> sources);

    [NameAffix("Suffix", "dv", -1, -1)]
    [NativeName("alSourceRewindv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewin([NativeName("sources")] uint sources);

    [NameAffix("Suffix", "dv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceRewindvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
    void SourceRewinDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] uint* sources
    );

    [NameAffix("Suffix", "dv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceRewindvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
    void SourceRewinDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] Ref<uint> sources
    );

    [NameAffix("Suffix", "dv", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceRewindvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
    void SourceRewinDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("sources")] uint sources
    );

    [NativeName("alSourceStop")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceStop")]
    void SourceStop([NativeName("source")] uint source);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceStopDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceStopDirect")]
    void SourceStopDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alSourceStopv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    void AlSourceStop([NativeName("n")] int n, [NativeName("sources")] uint* sources);

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alSourceStopv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    void AlSourceStop([NativeName("n")] int n, [NativeName("sources")] Ref<uint> sources);

    [NameAffix("Suffix", "v", -1, -1)]
    [NativeName("alSourceStopv")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    void AlSourceStop([NativeName("sources")] uint sources);

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceStopvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
    void AlSourceStop(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] uint* sources
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceStopvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
    void AlSourceStop(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("sources")] Ref<uint> sources
    );

    [NameAffix("Suffix", "v", -1, -1)]
    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceStopvDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
    void AlSourceStop(
        [NativeName("context")] ContextHandle context,
        [NativeName("sources")] uint sources
    );

    [NativeName("alSourceUnqueueBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
    void SourceUnqueueBuffers(
        [NativeName("source")] uint source,
        [NativeName("nb")] int nb,
        [NativeName("buffers")] uint* buffers
    );

    [NativeName("alSourceUnqueueBuffers")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
    void SourceUnqueueBuffers(
        [NativeName("source")] uint source,
        [NativeName("nb")] int nb,
        [NativeName("buffers")] Ref<uint> buffers
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceUnqueueBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
    void SourceUnqueueBuffersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("nb")] int nb,
        [NativeName("buffers")] uint* buffers
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSourceUnqueueBuffersDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
    void SourceUnqueueBuffersDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("source")] uint source,
        [NativeName("nb")] int nb,
        [NativeName("buffers")] Ref<uint> buffers
    );

    [NativeName("alSpeedOfSound")]
    [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
    void SpeedOfSound([NativeName("value")] float value);

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("alSpeedOfSoundDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSpeedOfSoundDirect")]
    void SpeedOfSoundDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("value")] float value
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("EAXGetBufferModeDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
    int EaxGetBufferModeDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("pReserved")] int* pReserved
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("EAXGetBufferModeDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
    int EaxGetBufferModeDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("buffer")] uint buffer,
        [NativeName("pReserved")] Ref<int> pReserved
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("EAXGetDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
    int EaxGetDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("property_set_id")] System.Guid* property_set_id,
        [NativeName("property_id")] uint property_id,
        [NativeName("source_id")] uint source_id,
        [NativeName("value")] void* value,
        [NativeName("value_size")] uint value_size
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("EAXGetDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
    int EaxGetDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("property_set_id")] Ref<System.Guid> property_set_id,
        [NativeName("property_id")] uint property_id,
        [NativeName("source_id")] uint source_id,
        [NativeName("value")] Ref value,
        [NativeName("value_size")] uint value_size
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("EAXSetBufferModeDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
    sbyte EaxSetBufferModeDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("buffers")] uint* buffers,
        [NativeName("value")] int value
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("EAXSetBufferModeDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
    MaybeBool<sbyte> EaxSetBufferModeDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("n")] int n,
        [NativeName("buffers")] Ref<uint> buffers,
        [NativeName("value")] int value
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("EAXSetDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
    int EaxSetDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("property_set_id")] System.Guid* property_set_id,
        [NativeName("property_id")] uint property_id,
        [NativeName("source_id")] uint source_id,
        [NativeName("value")] void* value,
        [NativeName("value_size")] uint value_size
    );

    [NameAffix("Suffix", "Direct", 0, -1)]
    [NativeName("EAXSetDirect")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
    int EaxSetDirect(
        [NativeName("context")] ContextHandle context,
        [NativeName("property_set_id")] Ref<System.Guid> property_set_id,
        [NativeName("property_id")] uint property_id,
        [NativeName("source_id")] uint source_id,
        [NativeName("value")] Ref value,
        [NativeName("value_size")] uint value_size
    );
}
