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
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
        static abstract void AuxiliaryEffectSlot(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float flValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
        static abstract void AuxiliaryEffectSlot(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
            [NativeTypeName("ALfloat")] float flValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat")] float flValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
            [NativeTypeName("ALfloat")] float flValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
        static abstract void AuxiliaryEffectSlot(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
        static abstract void AuxiliaryEffectSlot(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
            [NativeTypeName("const ALfloat *")] Ref<float> pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALfloat *")] float* pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
            [NativeTypeName("const ALfloat *")] Ref<float> pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
        static abstract void AuxiliaryEffectSlot(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int iValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
        static abstract void AuxiliaryEffectSlot(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
            [NativeTypeName("ALint")] int iValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint")] int iValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
            [NativeTypeName("ALint")] int iValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
        static abstract void AuxiliaryEffectSlot(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* piValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
        static abstract void AuxiliaryEffectSlot(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
            [NativeTypeName("const ALint *")] Ref<int> piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALint *")] int* piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
        static abstract void AuxiliaryEffectSlotDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
            [NativeTypeName("const ALint *")] Ref<int> piValues
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBuffer3f")]
        static abstract void Buffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBuffer3fDirect")]
        static abstract void Buffer3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBuffer3i")]
        static abstract void Buffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBuffer3iDirect")]
        static abstract void Buffer3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

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
        static abstract void BufferCallbackDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("ALsizei")] int freq,
            [NativeTypeName("ALBUFFERCALLBACKTYPESOFT")] BufferCallbackSoft callback,
            [NativeTypeName("ALvoid *")] void* userptr
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferCallbackDirectSOFT")]
        static abstract void BufferCallbackDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
            [NativeTypeName("ALsizei")] int freq,
            [NativeTypeName("ALBUFFERCALLBACKTYPESOFT")] BufferCallbackSoft callback,
            [NativeTypeName("ALvoid *")] Ref userptr
        );

        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
        static abstract void BufferCallbackSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("ALsizei")] int freq,
            [NativeTypeName("ALBUFFERCALLBACKTYPESOFT")] BufferCallbackSoft callback,
            [NativeTypeName("ALvoid *")] void* userptr
        );

        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
        static abstract void BufferCallbackSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
            [NativeTypeName("ALsizei")] int freq,
            [NativeTypeName("ALBUFFERCALLBACKTYPESOFT")] BufferCallbackSoft callback,
            [NativeTypeName("ALvoid *")] Ref userptr
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        static abstract void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] void* data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        static abstract void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
        static abstract void BufferDataDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] void* data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
        static abstract void BufferDataDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        );

        [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
        [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
        static abstract void BufferDataStatic(
            [NativeTypeName("const ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("ALvoid *")] void* data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int freq
        );

        [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
        static abstract void BufferDataStatic(
            [NativeTypeName("const ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
            [NativeTypeName("ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int freq
        );

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
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("ALvoid *")] void* data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int freq
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferDataStaticDirect")]
        static abstract void BufferDataStaticDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
            [NativeTypeName("ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int freq
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferf")]
        static abstract void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferf")]
        static abstract void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param1,
            [NativeTypeName("ALfloat")] float value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat")] float value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param2,
            [NativeTypeName("ALfloat")] float value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        static abstract void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        static abstract void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param2,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferi")]
        static abstract void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferi")]
        static abstract void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param1,
            [NativeTypeName("ALint")] int value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint")] int value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param2,
            [NativeTypeName("ALint")] int value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        static abstract void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        static abstract void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALint *")] int* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
        static abstract void BufferDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param2,
            [NativeTypeName("const ALint *")] Ref<int> values
        );

        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
        static abstract void BufferSamplesSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALuint")] uint samplerate,
            [NativeTypeName("ALenum")] int internalformat,
            [NativeTypeName("ALsizei")] int samples,
            [NativeTypeName("ALenum")] int channels,
            [NativeTypeName("ALenum")] int type,
            [NativeTypeName("const ALvoid *")] void* data
        );

        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
        static abstract void BufferSamplesSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALuint")] uint samplerate,
            [NativeTypeName("ALenum")] int internalformat,
            [NativeTypeName("ALsizei")] int samples,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SampleTypeSOFT> type,
            [NativeTypeName("const ALvoid *")] Ref data
        );

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
        static abstract void BufferSubDataDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] void* data,
            [NativeTypeName("ALsizei")] int offset,
            [NativeTypeName("ALsizei")] int length
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferSubDataDirectSOFT")]
        static abstract void BufferSubDataDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int offset,
            [NativeTypeName("ALsizei")] int length
        );

        [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
        [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
        static abstract void BufferSubDataSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] void* data,
            [NativeTypeName("ALsizei")] int offset,
            [NativeTypeName("ALsizei")] int length
        );

        [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
        static abstract void BufferSubDataSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int offset,
            [NativeTypeName("ALsizei")] int length
        );

        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
        static abstract void BufferSubSamplesSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALsizei")] int offset,
            [NativeTypeName("ALsizei")] int samples,
            [NativeTypeName("ALenum")] int channels,
            [NativeTypeName("ALenum")] int type,
            [NativeTypeName("const ALvoid *")] void* data
        );

        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
        static abstract void BufferSubSamplesSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALsizei")] int offset,
            [NativeTypeName("ALsizei")] int samples,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SampleTypeSOFT> type,
            [NativeTypeName("const ALvoid *")] Ref data
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
        static abstract void DebugMessageCallbackDirectExt(
            ContextHandle context,
            [NativeTypeName("ALDEBUGPROCEXT")] DebugProcExt callback,
            void* userParam
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
        static abstract void DebugMessageCallbackDirectExt(
            ContextHandle context,
            [NativeTypeName("ALDEBUGPROCEXT")] DebugProcExt callback,
            Ref userParam
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
        static abstract void DebugMessageCallbackExt(
            [NativeTypeName("ALDEBUGPROCEXT")] DebugProcExt callback,
            void* userParam
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
        static abstract void DebugMessageCallbackExt(
            [NativeTypeName("ALDEBUGPROCEXT")] DebugProcExt callback,
            Ref userParam
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
        static abstract void DebugMessageControlDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] int source,
            [NativeTypeName("ALenum")] int type,
            [NativeTypeName("ALenum")] int severity,
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("const ALuint *")] uint* ids,
            [NativeTypeName("ALboolean")] sbyte enable
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
        static abstract void DebugMessageControlDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("const ALuint *")] Ref<uint> ids,
            [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
        static abstract void DebugMessageControlDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeTypeName("const ALuint *")] uint ids,
            [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
        static abstract void DebugMessageControlExt(
            [NativeTypeName("ALenum")] int source,
            [NativeTypeName("ALenum")] int type,
            [NativeTypeName("ALenum")] int severity,
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("const ALuint *")] uint* ids,
            [NativeTypeName("ALboolean")] sbyte enable
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
        static abstract void DebugMessageControlExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("const ALuint *")] Ref<uint> ids,
            [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
        static abstract void DebugMessageControlExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeTypeName("const ALuint *")] uint ids,
            [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
        static abstract void DebugMessageInsertDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] int source,
            [NativeTypeName("ALenum")] int type,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("ALenum")] int severity,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] sbyte* message
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
        static abstract void DebugMessageInsertDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] Ref<sbyte> message
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
        static abstract void DebugMessageInsertDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeTypeName("const ALchar *")] sbyte message
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
        static abstract void DebugMessageInsertExt(
            [NativeTypeName("ALenum")] int source,
            [NativeTypeName("ALenum")] int type,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("ALenum")] int severity,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] sbyte* message
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
        static abstract void DebugMessageInsertExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] Ref<sbyte> message
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
        static abstract void DebugMessageInsertExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
            [NativeTypeName("const ALchar *")] sbyte message
        );

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
        static abstract void DeferUpdatesDirectSoft(ContextHandle context);

        [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
        [NativeFunction("openal", EntryPoint = "alDeferUpdatesSOFT")]
        static abstract void DeferUpdatesSoft();

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
        static abstract void DeleteAuxiliaryEffectSlot(
            [NativeTypeName("const ALuint *")] uint effectslots
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
        static abstract void DeleteAuxiliaryEffectSlots(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* effectslots
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
        static abstract void DeleteAuxiliaryEffectSlots(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> effectslots
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
        static abstract void DeleteAuxiliaryEffectSlotsDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* effectslots
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
        static abstract void DeleteAuxiliaryEffectSlotsDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> effectslots
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
        static abstract void DeleteAuxiliaryEffectSlotsDirect(
            ContextHandle context,
            [NativeTypeName("const ALuint *")] uint effectslots
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* buffers
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
        static abstract void DeleteBuffersDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* buffers
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
        static abstract void DeleteBuffersDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
        static abstract void DeleteEffect([NativeTypeName("const ALuint *")] uint effects);

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
        static abstract void DeleteEffects(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* effects
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
        static abstract void DeleteEffects(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> effects
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
        static abstract void DeleteEffectsDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* effects
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
        static abstract void DeleteEffectsDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> effects
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
        static abstract void DeleteEffectsDirect(
            ContextHandle context,
            [NativeTypeName("const ALuint *")] uint effects
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
        static abstract void DeleteFilter([NativeTypeName("const ALuint *")] uint filters);

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
        static abstract void DeleteFilters(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* filters
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
        static abstract void DeleteFilters(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> filters
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
        static abstract void DeleteFiltersDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* filters
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
        static abstract void DeleteFiltersDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> filters
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
        static abstract void DeleteFiltersDirect(
            ContextHandle context,
            [NativeTypeName("const ALuint *")] uint filters
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSource([NativeTypeName("const ALuint *")] uint sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
        static abstract void DeleteSourcesDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
        static abstract void DeleteSourcesDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
        static abstract void DeleteSourcesDirect(
            ContextHandle context,
            [NativeTypeName("const ALuint *")] uint sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        static abstract void Disable([NativeTypeName("ALenum")] int capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        static abstract void Disable(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDisableDirect")]
        static abstract void DisableDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int capability
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDisableDirect")]
        static abstract void DisableDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        static abstract void DistanceModel([NativeTypeName("ALenum")] int distanceModel);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        static abstract void DistanceModel(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DistanceModel> distanceModel
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
        static abstract void DistanceModelDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int distanceModel
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
        static abstract void DistanceModelDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DistanceModel> distanceModel
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
        static abstract void DopplerFactor([NativeTypeName("ALfloat")] float value);

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alDopplerFactorDirect")]
        static abstract void DopplerFactorDirect(
            ContextHandle context,
            [NativeTypeName("ALfloat")] float value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
        static abstract void DopplerVelocity([NativeTypeName("ALfloat")] float value);

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectf")]
        static abstract void Effect(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float flValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEffectf")]
        static abstract void Effect(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param1,
            [NativeTypeName("ALfloat")] float flValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat")] float flValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param2,
            [NativeTypeName("ALfloat")] float flValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectfv")]
        static abstract void Effect(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEffectfv")]
        static abstract void Effect(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param1,
            [NativeTypeName("const ALfloat *")] Ref<float> pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALfloat *")] float* pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param2,
            [NativeTypeName("const ALfloat *")] Ref<float> pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffecti")]
        static abstract void Effect(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int iValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEffecti")]
        static abstract void Effect(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param1,
            [NativeTypeName("ALint")] int iValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint")] int iValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param2,
            [NativeTypeName("ALint")] int iValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alEffectiv")]
        static abstract void Effect(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* piValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEffectiv")]
        static abstract void Effect(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param1,
            [NativeTypeName("const ALint *")] Ref<int> piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALint *")] int* piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
        static abstract void EffectDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param2,
            [NativeTypeName("const ALint *")] Ref<int> piValues
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        static abstract void Enable([NativeTypeName("ALenum")] int capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        static abstract void Enable(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alEnableDirect")]
        static abstract void EnableDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int capability
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEnableDirect")]
        static abstract void EnableDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability
        );

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
        static abstract void EventCallbackDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALEVENTPROCSOFT")] EventProcSoft callback,
            void* userParam
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEventCallbackDirectSOFT")]
        static abstract void EventCallbackDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALEVENTPROCSOFT")] EventProcSoft callback,
            Ref userParam
        );

        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
        static abstract void EventCallbackSoft(
            [NativeTypeName("ALEVENTPROCSOFT")] EventProcSoft callback,
            void* userParam
        );

        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
        static abstract void EventCallbackSoft(
            [NativeTypeName("ALEVENTPROCSOFT")] EventProcSoft callback,
            Ref userParam
        );

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
        static abstract void EventControlDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("const ALenum *")] int* types,
            [NativeTypeName("ALboolean")] sbyte enable
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
        static abstract void EventControlDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("const ALenum *")] Ref<int> types,
            [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
        static abstract void EventControlDirectSoft(
            ContextHandle context,
            [NativeTypeName("const ALenum *")] int types,
            [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
        );

        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
        static abstract void EventControlSoft(
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("const ALenum *")] int* types,
            [NativeTypeName("ALboolean")] sbyte enable
        );

        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
        static abstract void EventControlSoft(
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("const ALenum *")] Ref<int> types,
            [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
        );

        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
        static abstract void EventControlSoft(
            [NativeTypeName("const ALenum *")] int types,
            [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilterf")]
        static abstract void Filter(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float flValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alFilterf")]
        static abstract void Filter(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param1,
            [NativeTypeName("ALfloat")] float flValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat")] float flValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param2,
            [NativeTypeName("ALfloat")] float flValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilterfv")]
        static abstract void Filter(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alFilterfv")]
        static abstract void Filter(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param1,
            [NativeTypeName("const ALfloat *")] Ref<float> pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALfloat *")] float* pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param2,
            [NativeTypeName("const ALfloat *")] Ref<float> pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilteri")]
        static abstract void Filter(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int iValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alFilteri")]
        static abstract void Filter(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param1,
            [NativeTypeName("ALint")] int iValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint")] int iValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param2,
            [NativeTypeName("ALint")] int iValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alFilteriv")]
        static abstract void Filter(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* piValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alFilteriv")]
        static abstract void Filter(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param1,
            [NativeTypeName("const ALint *")] Ref<int> piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALint *")] int* piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
        static abstract void FilterDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param2,
            [NativeTypeName("const ALint *")] Ref<int> piValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
        static abstract uint GenAuxiliaryEffectSlot();

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
        static abstract void GenAuxiliaryEffectSlots(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* effectslots
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
        static abstract void GenAuxiliaryEffectSlots(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> effectslots
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
        static abstract void GenAuxiliaryEffectSlotsDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* effectslots
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
        static abstract void GenAuxiliaryEffectSlotsDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> effectslots
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
        static abstract uint GenAuxiliaryEffectSlotsDirect(ContextHandle context);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract uint GenBuffer();

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* buffers
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
        static abstract void GenBuffersDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* buffers
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
        static abstract void GenBuffersDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenEffects")]
        static abstract uint GenEffect();

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenEffects")]
        static abstract void GenEffects(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* effects
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenEffects")]
        static abstract void GenEffects(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> effects
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
        static abstract void GenEffectsDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* effects
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
        static abstract void GenEffectsDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> effects
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
        static abstract uint GenEffectsDirect(ContextHandle context);

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenFilters")]
        static abstract uint GenFilter();

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGenFilters")]
        static abstract void GenFilters(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* filters
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenFilters")]
        static abstract void GenFilters(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> filters
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
        static abstract void GenFiltersDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* filters
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
        static abstract void GenFiltersDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> filters
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
        static abstract uint GenFiltersDirect(ContextHandle context);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract uint GenSource();

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
        static abstract void GenSourcesDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
        static abstract void GenSourcesDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
        static abstract uint GenSourcesDirect(ContextHandle context);

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
        static abstract void GetAuxiliaryEffectSlotf(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* flValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
        static abstract void GetAuxiliaryEffectSlotf(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> flValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
        static abstract void GetAuxiliaryEffectSlotfDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* pflValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
        static abstract void GetAuxiliaryEffectSlotfDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
            [NativeTypeName("ALfloat *")] Ref<float> pflValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
        static abstract void GetAuxiliaryEffectSlotfv(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
        static abstract void GetAuxiliaryEffectSlotfv(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
        static abstract void GetAuxiliaryEffectSlotfvDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
        static abstract void GetAuxiliaryEffectSlotfvDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
            [NativeTypeName("ALfloat *")] Ref<float> pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
        static abstract void GetAuxiliaryEffectSloti(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* iValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
        static abstract void GetAuxiliaryEffectSloti(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
            [NativeTypeName("ALint *")] Ref<int> iValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
        static abstract void GetAuxiliaryEffectSlotiDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* piValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
        static abstract void GetAuxiliaryEffectSlotiDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
            [NativeTypeName("ALint *")] Ref<int> piValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
        static abstract void GetAuxiliaryEffectSlotiv(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* piValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
        static abstract void GetAuxiliaryEffectSlotiv(
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
            [NativeTypeName("ALint *")] Ref<int> piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
        static abstract void GetAuxiliaryEffectSlotivDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
        static abstract void GetAuxiliaryEffectSlotivDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
            [NativeTypeName("ALint *")] Ref<int> piValues
        );

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        static abstract sbyte GetBoolean([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        static abstract MaybeBool<sbyte> GetBoolean(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BooleanPName> param0
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
        static abstract sbyte GetBooleanDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
        static abstract MaybeBool<sbyte> GetBooleanDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BooleanPName> param1
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        static abstract void GetBoolean(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] sbyte* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        static abstract void GetBoolean(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BooleanPName> param0,
            [NativeTypeName("ALboolean *")] Ref<sbyte> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
        static abstract void GetBooleanDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALboolean *")] sbyte* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
        static abstract void GetBooleanDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BooleanPName> param1,
            [NativeTypeName("ALboolean *")] Ref<sbyte> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        static abstract void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        static abstract void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
        static abstract void GetBuffer3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
        static abstract void GetBuffer3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        static abstract void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        static abstract void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
        static abstract void GetBuffer3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
        static abstract void GetBuffer3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        );

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
        static abstract void GetBuffer3PtrDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALvoid **")] void** ptr0,
            [NativeTypeName("ALvoid **")] void** ptr1,
            [NativeTypeName("ALvoid **")] void** ptr2
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrDirectSOFT")]
        static abstract void GetBuffer3PtrDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param2,
            [NativeTypeName("ALvoid **")] Ref2D ptr0,
            [NativeTypeName("ALvoid **")] Ref2D ptr1,
            [NativeTypeName("ALvoid **")] Ref2D ptr2
        );

        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
        static abstract void GetBuffer3PtrSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALvoid **")] void** ptr0,
            [NativeTypeName("ALvoid **")] void** ptr1,
            [NativeTypeName("ALvoid **")] void** ptr2
        );

        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
        static abstract void GetBuffer3PtrSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param1,
            [NativeTypeName("ALvoid **")] Ref2D ptr0,
            [NativeTypeName("ALvoid **")] Ref2D ptr1,
            [NativeTypeName("ALvoid **")] Ref2D ptr2
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        static abstract void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        static abstract void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
        static abstract void GetBufferfDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
        static abstract void GetBufferfDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param2,
            [NativeTypeName("ALfloat *")] Ref<float> value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        static abstract void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        static abstract void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
        static abstract void GetBufferfvDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
        static abstract void GetBufferfvDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param2,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        static abstract void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        static abstract void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param1,
            [NativeTypeName("ALint *")] Ref<int> value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
        static abstract void GetBufferiDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
        static abstract void GetBufferiDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param2,
            [NativeTypeName("ALint *")] Ref<int> value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        static abstract void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        static abstract void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param1,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
        static abstract void GetBufferivDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
        static abstract void GetBufferivDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param2,
            [NativeTypeName("ALint *")] Ref<int> values
        );

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
        static abstract void GetBufferPtrDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALvoid **")] void** ptr
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrDirectSOFT")]
        static abstract void GetBufferPtrDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param2,
            [NativeTypeName("ALvoid **")] Ref2D ptr
        );

        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
        static abstract void GetBufferPtrSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALvoid **")] void** ptr
        );

        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
        static abstract void GetBufferPtrSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param1,
            [NativeTypeName("ALvoid **")] Ref2D ptr
        );

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
        static abstract void GetBufferPtrvDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALvoid **")] void** ptr
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrvDirectSOFT")]
        static abstract void GetBufferPtrvDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param2,
            [NativeTypeName("ALvoid **")] Ref2D ptr
        );

        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
        static abstract void GetBufferPtrvSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALvoid **")] void** ptr
        );

        [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
        static abstract void GetBufferPtrvSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param1,
            [NativeTypeName("ALvoid **")] Ref2D ptr
        );

        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
        static abstract void GetBufferSamplesSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALsizei")] int offset,
            [NativeTypeName("ALsizei")] int samples,
            [NativeTypeName("ALenum")] int channels,
            [NativeTypeName("ALenum")] int type,
            [NativeTypeName("ALvoid *")] void* data
        );

        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
        static abstract void GetBufferSamplesSoft(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALsizei")] int offset,
            [NativeTypeName("ALsizei")] int samples,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SampleTypeSOFT> type,
            [NativeTypeName("ALvoid *")] Ref data
        );

        [return: NativeTypeName("ALuint")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectExt(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint count,
            [NativeTypeName("ALsizei")] int logBufSize,
            [NativeTypeName("ALenum *")] int* sources,
            [NativeTypeName("ALenum *")] int* types,
            [NativeTypeName("ALuint *")] uint* ids,
            [NativeTypeName("ALenum *")] int* severities,
            [NativeTypeName("ALsizei *")] int* lengths,
            [NativeTypeName("ALchar *")] sbyte* logBuf
        );

        [return: NativeTypeName("ALuint")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectExt(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint count,
            [NativeTypeName("ALsizei")] int logBufSize,
            [NativeTypeName("ALenum *")] Ref<int> sources,
            [NativeTypeName("ALenum *")] Ref<int> types,
            [NativeTypeName("ALuint *")] Ref<uint> ids,
            [NativeTypeName("ALenum *")] Ref<int> severities,
            [NativeTypeName("ALsizei *")] Ref<int> lengths,
            [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
        );

        [return: NativeTypeName("ALuint")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectExt(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint count,
            [NativeTypeName("ALsizei")] int logBufSize,
            [NativeTypeName("ALenum *")] Ref<AlEnum> sources,
            [NativeTypeName("ALenum *")] Ref<AlEnum> types,
            [NativeTypeName("ALuint *")] Ref<uint> ids,
            [NativeTypeName("ALenum *")] Ref<AlEnum> severities,
            [NativeTypeName("ALsizei *")] Ref<int> lengths,
            [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
        );

        [return: NativeTypeName("ALuint")]
        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
        static abstract uint GetDebugMessageLogDirectExt(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint count,
            [NativeTypeName("ALsizei")] int logBufSize,
            [NativeTypeName("ALenum *")] Ref<DebugSourceEXT> sources,
            [NativeTypeName("ALenum *")] Ref<DebugTypeEXT> types,
            [NativeTypeName("ALuint *")] Ref<uint> ids,
            [NativeTypeName("ALenum *")] Ref<DebugSeverityEXT> severities,
            [NativeTypeName("ALsizei *")] Ref<int> lengths,
            [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
        );

        [return: NativeTypeName("ALuint")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogExt(
            [NativeTypeName("ALuint")] uint count,
            [NativeTypeName("ALsizei")] int logBufSize,
            [NativeTypeName("ALenum *")] int* sources,
            [NativeTypeName("ALenum *")] int* types,
            [NativeTypeName("ALuint *")] uint* ids,
            [NativeTypeName("ALenum *")] int* severities,
            [NativeTypeName("ALsizei *")] int* lengths,
            [NativeTypeName("ALchar *")] sbyte* logBuf
        );

        [return: NativeTypeName("ALuint")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogExt(
            [NativeTypeName("ALuint")] uint count,
            [NativeTypeName("ALsizei")] int logBufSize,
            [NativeTypeName("ALenum *")] Ref<int> sources,
            [NativeTypeName("ALenum *")] Ref<int> types,
            [NativeTypeName("ALuint *")] Ref<uint> ids,
            [NativeTypeName("ALenum *")] Ref<int> severities,
            [NativeTypeName("ALsizei *")] Ref<int> lengths,
            [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
        );

        [return: NativeTypeName("ALuint")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogExt(
            [NativeTypeName("ALuint")] uint count,
            [NativeTypeName("ALsizei")] int logBufSize,
            [NativeTypeName("ALenum *")] Ref<AlEnum> sources,
            [NativeTypeName("ALenum *")] Ref<AlEnum> types,
            [NativeTypeName("ALuint *")] Ref<uint> ids,
            [NativeTypeName("ALenum *")] Ref<AlEnum> severities,
            [NativeTypeName("ALsizei *")] Ref<int> lengths,
            [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
        );

        [return: NativeTypeName("ALuint")]
        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
        static abstract uint GetDebugMessageLogExt(
            [NativeTypeName("ALuint")] uint count,
            [NativeTypeName("ALsizei")] int logBufSize,
            [NativeTypeName("ALenum *")] Ref<DebugSourceEXT> sources,
            [NativeTypeName("ALenum *")] Ref<DebugTypeEXT> types,
            [NativeTypeName("ALuint *")] Ref<uint> ids,
            [NativeTypeName("ALenum *")] Ref<DebugSeverityEXT> severities,
            [NativeTypeName("ALsizei *")] Ref<int> lengths,
            [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
        );

        [return: NativeTypeName("ALdouble")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        static abstract double GetDouble([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("ALdouble")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        static abstract double GetDouble(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param0
        );

        [return: NativeTypeName("ALdouble")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
        static abstract double GetDoubleDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1
        );

        [return: NativeTypeName("ALdouble")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
        static abstract double GetDoubleDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param1
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        static abstract void GetDouble(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] double* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        static abstract void GetDouble(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param0,
            [NativeTypeName("ALdouble *")] Ref<double> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
        static abstract void GetDoubleDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALdouble *")] double* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
        static abstract void GetDoubleDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param1,
            [NativeTypeName("ALdouble *")] Ref<double> values
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectf")]
        static abstract void GetEffectf(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* flValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEffectf")]
        static abstract void GetEffectf(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> flValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
        static abstract void GetEffectfDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* pflValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
        static abstract void GetEffectfDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param2,
            [NativeTypeName("ALfloat *")] Ref<float> pflValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
        static abstract void GetEffectfv(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
        static abstract void GetEffectfv(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
        static abstract void GetEffectfvDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
        static abstract void GetEffectfvDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param2,
            [NativeTypeName("ALfloat *")] Ref<float> pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffecti")]
        static abstract void GetEffecti(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* iValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEffecti")]
        static abstract void GetEffecti(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param1,
            [NativeTypeName("ALint *")] Ref<int> iValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
        static abstract void GetEffectiDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* piValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
        static abstract void GetEffectiDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param2,
            [NativeTypeName("ALint *")] Ref<int> piValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
        static abstract void GetEffectiv(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* piValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
        static abstract void GetEffectiv(
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param1,
            [NativeTypeName("ALint *")] Ref<int> piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
        static abstract void GetEffectivDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
        static abstract void GetEffectivDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param2,
            [NativeTypeName("ALint *")] Ref<int> piValues
        );

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        static abstract int GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename);

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        static abstract int GetEnumValue([NativeTypeName("const ALchar *")] Ref<sbyte> ename);

        [return: NativeTypeName("ALenum")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
        static abstract int GetEnumValueDirect(
            ContextHandle context,
            [NativeTypeName("const ALchar *")] sbyte* ename
        );

        [return: NativeTypeName("ALenum")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
        static abstract int GetEnumValueDirect(
            ContextHandle context,
            [NativeTypeName("const ALchar *")] Ref<sbyte> ename
        );

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        static abstract Constant<int, ErrorCode> GetError();

        [return: NativeTypeName("ALenum")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
        static abstract Constant<int, ErrorCode> GetErrorDirect(ContextHandle context);

        [return: NativeTypeName("ALenum")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
        static abstract int GetErrorDirectRaw(ContextHandle context);

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        static abstract int GetErrorRaw();

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilterf")]
        static abstract void GetFilterf(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* flValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFilterf")]
        static abstract void GetFilterf(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> flValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
        static abstract void GetFilterfDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* pflValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
        static abstract void GetFilterfDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param2,
            [NativeTypeName("ALfloat *")] Ref<float> pflValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
        static abstract void GetFilterfv(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
        static abstract void GetFilterfv(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
        static abstract void GetFilterfvDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* pflValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
        static abstract void GetFilterfvDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param2,
            [NativeTypeName("ALfloat *")] Ref<float> pflValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilteri")]
        static abstract void GetFilteri(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* iValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFilteri")]
        static abstract void GetFilteri(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param1,
            [NativeTypeName("ALint *")] Ref<int> iValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
        static abstract void GetFilteriDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* piValue
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
        static abstract void GetFilteriDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param2,
            [NativeTypeName("ALint *")] Ref<int> piValue
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
        static abstract void GetFilteriv(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* piValues
        );

        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
        static abstract void GetFilteriv(
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param1,
            [NativeTypeName("ALint *")] Ref<int> piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
        static abstract void GetFilterivDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* piValues
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
        static abstract void GetFilterivDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param2,
            [NativeTypeName("ALint *")] Ref<int> piValues
        );

        [return: NativeTypeName("ALfloat")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        static abstract float GetFloat([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("ALfloat")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        static abstract float GetFloat(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FloatPName> param0
        );

        [return: NativeTypeName("ALfloat")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
        static abstract float GetFloatDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1
        );

        [return: NativeTypeName("ALfloat")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
        static abstract float GetFloatDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, FloatPName> param1
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        static abstract void GetFloat(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        static abstract void GetFloat(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
        static abstract void GetFloatDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
        static abstract void GetFloatDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [return: NativeTypeName("ALint")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        static abstract int GetInteger([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("ALint")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        static abstract int GetInteger(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, IntegerPName> param0
        );

        [return: NativeTypeName("ALint")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
        static abstract int GetIntegerDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1
        );

        [return: NativeTypeName("ALint")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
        static abstract int GetIntegerDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, IntegerPName> param1
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        static abstract void GetInteger(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        static abstract void GetInteger(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, IntegerPName> param0,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
        static abstract void GetIntegerDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
        static abstract void GetIntegerDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, IntegerPName> param1,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        static abstract void GetListener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        static abstract void GetListener3(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat3> param0,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
        static abstract void GetListener3Direct(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
        static abstract void GetListener3Direct(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat3> param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        static abstract void GetListener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        static abstract void GetListener3(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerInteger3> param0,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
        static abstract void GetListener3Direct(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
        static abstract void GetListener3Direct(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerInteger3> param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        static abstract void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        static abstract void GetListenerf(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param0,
            [NativeTypeName("ALfloat *")] Ref<float> value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
        static abstract void GetListenerfDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
        static abstract void GetListenerfDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        static abstract void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        static abstract void GetListenerfv(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
        static abstract void GetListenerfvDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
        static abstract void GetListenerfvDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract int GetListeneri();

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
        static abstract void GetListeneriDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
        static abstract void GetListeneriDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract int GetListeneriv();

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
        static abstract void GetListenerivDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
        static abstract void GetListenerivDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
        static abstract void GetObjectLabelDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] int identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("ALsizei")] int bufSize,
            [NativeTypeName("ALsizei *")] int* length,
            [NativeTypeName("ALchar *")] sbyte* label
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
        static abstract void GetObjectLabelDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("ALsizei")] int bufSize,
            [NativeTypeName("ALsizei *")] Ref<int> length,
            [NativeTypeName("ALchar *")] Ref<sbyte> label
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
        static abstract sbyte GetObjectLabelDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("ALsizei *")] Ref<int> length
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
        static abstract void GetObjectLabelExt(
            [NativeTypeName("ALenum")] int identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("ALsizei")] int bufSize,
            [NativeTypeName("ALsizei *")] int* length,
            [NativeTypeName("ALchar *")] sbyte* label
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
        static abstract void GetObjectLabelExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("ALsizei")] int bufSize,
            [NativeTypeName("ALsizei *")] Ref<int> length,
            [NativeTypeName("ALchar *")] Ref<sbyte> label
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
        static abstract sbyte GetObjectLabelExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("ALsizei *")] Ref<int> length
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
        static abstract void* GetPointerDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] int pname
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
        static abstract Ptr GetPointerDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname
        );

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
        static abstract void* GetPointerDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALenum")] int pname
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetPointerDirectSOFT")]
        static abstract Ptr GetPointerDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
        static abstract void* GetPointerExt([NativeTypeName("ALenum")] int pname);

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
        static abstract Ptr GetPointerExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname
        );

        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
        static abstract void* GetPointerSoft([NativeTypeName("ALenum")] int pname);

        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
        static abstract Ptr GetPointerSoft(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
        static abstract void GetPointerDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] int pname,
            void** values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
        static abstract void GetPointerDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname,
            Ref2D values
        );

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
        static abstract void GetPointerDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALenum")] int pname,
            void** values
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetPointervDirectSOFT")]
        static abstract void GetPointerDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname,
            Ref2D values
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
        static abstract void GetPointerExt([NativeTypeName("ALenum")] int pname, void** values);

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
        static abstract void GetPointerExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname,
            Ref2D values
        );

        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
        static abstract void GetPointerSoft([NativeTypeName("ALenum")] int pname, void** values);

        [SupportedApiProfile("al", ["AL_SOFT_events"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
        static abstract void GetPointerSoft(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname,
            Ref2D values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        static abstract void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        static abstract Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname);

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
        static abstract void* GetProcAddressDirect(
            ContextHandle context,
            [NativeTypeName("const ALchar *")] sbyte* fname
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
        static abstract Ptr GetProcAddressDirect(
            ContextHandle context,
            [NativeTypeName("const ALchar *")] Ref<sbyte> fname
        );

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
        static abstract void GetSource3DirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALdouble *")] double* value1,
            [NativeTypeName("ALdouble *")] double* value2,
            [NativeTypeName("ALdouble *")] double* value3
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3dDirectSOFT")]
        static abstract void GetSource3DirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALdouble *")] Ref<double> value1,
            [NativeTypeName("ALdouble *")] Ref<double> value2,
            [NativeTypeName("ALdouble *")] Ref<double> value3
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
        static abstract void GetSource3Soft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALdouble *")] double* value1,
            [NativeTypeName("ALdouble *")] double* value2,
            [NativeTypeName("ALdouble *")] double* value3
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
        static abstract void GetSource3Soft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALdouble *")] Ref<double> value1,
            [NativeTypeName("ALdouble *")] Ref<double> value2,
            [NativeTypeName("ALdouble *")] Ref<double> value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        static abstract void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        static abstract void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat3> param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
        static abstract void GetSource3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
        static abstract void GetSource3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat3> param2,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        static abstract void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        static abstract void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        );

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
        static abstract void GetSource3DirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint64SOFT *")] nint* value1,
            [NativeTypeName("ALint64SOFT *")] nint* value2,
            [NativeTypeName("ALint64SOFT *")] nint* value3
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3i64DirectSOFT")]
        static abstract void GetSource3DirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param2,
            [NativeTypeName("ALint64SOFT *")] Ref<nint> value1,
            [NativeTypeName("ALint64SOFT *")] Ref<nint> value2,
            [NativeTypeName("ALint64SOFT *")] Ref<nint> value3
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
        static abstract void GetSource3Soft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint64SOFT *")] nint* value1,
            [NativeTypeName("ALint64SOFT *")] nint* value2,
            [NativeTypeName("ALint64SOFT *")] nint* value3
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
        static abstract void GetSource3Soft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param1,
            [NativeTypeName("ALint64SOFT *")] Ref<nint> value1,
            [NativeTypeName("ALint64SOFT *")] Ref<nint> value2,
            [NativeTypeName("ALint64SOFT *")] Ref<nint> value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
        static abstract void GetSource3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
        static abstract void GetSource3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param2,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        );

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
        static abstract void GetSourceDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALdouble *")] double* value
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcedDirectSOFT")]
        static abstract void GetSourceDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param2,
            [NativeTypeName("ALdouble *")] Ref<double> value
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
        static abstract void GetSourceSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALdouble *")] double* value
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
        static abstract void GetSourceSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param1,
            [NativeTypeName("ALdouble *")] Ref<double> value
        );

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
        static abstract void GetSourcedvDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALdouble *")] double* values
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcedvDirectSOFT")]
        static abstract void GetSourcedvDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param2,
            [NativeTypeName("ALdouble *")] Ref<double> values
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
        static abstract void GetSourcedvSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALdouble *")] double* values
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
        static abstract void GetSourcedvSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param1,
            [NativeTypeName("ALdouble *")] Ref<double> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        static abstract void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        static abstract void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
        static abstract void GetSourcefDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
        static abstract void GetSourcefDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param2,
            [NativeTypeName("ALfloat *")] Ref<float> value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        static abstract void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        static abstract void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
        static abstract void GetSourcefvDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat *")] float* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
        static abstract void GetSourcefvDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param2,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        static abstract void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        static abstract void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeTypeName("ALint *")] Ref<int> value
        );

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
        static abstract void GetSourcei64DirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint64SOFT *")] nint* value
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64DirectSOFT")]
        static abstract void GetSourcei64DirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeTypeName("ALint64SOFT *")] Ref<nint> value
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
        static abstract void GetSourcei64Soft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint64SOFT *")] nint* value
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
        static abstract void GetSourcei64Soft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeTypeName("ALint64SOFT *")] Ref<nint> value
        );

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
        static abstract void GetSourcei64VDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint64SOFT *")] nint* values
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64vDirectSOFT")]
        static abstract void GetSourcei64VDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeTypeName("ALint64SOFT *")] Ref<nint> values
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
        static abstract void GetSourcei64VSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint64SOFT *")] nint* values
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
        static abstract void GetSourcei64VSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeTypeName("ALint64SOFT *")] Ref<nint> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
        static abstract void GetSourceiDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
        static abstract void GetSourceiDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeTypeName("ALint *")] Ref<int> value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        static abstract void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        static abstract void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
        static abstract void GetSourceivDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint *")] int* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
        static abstract void GetSourceivDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [return: NativeTypeName("const ALchar *")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        static abstract sbyte* GetString([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("const ALchar *")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        static abstract Ptr<sbyte> GetString(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, StringPName> param0
        );

        [return: NativeTypeName("const ALchar *")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
        static abstract sbyte* GetStringDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1
        );

        [return: NativeTypeName("const ALchar *")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
        static abstract Ptr<sbyte> GetStringDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, StringPName> param1
        );

        [return: NativeTypeName("const ALchar *")]
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
        static abstract sbyte* GetStringDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALenum")] int pname,
            [NativeTypeName("ALsizei")] int index
        );

        [return: NativeTypeName("const ALchar *")]
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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetStringiDirectSOFT")]
        static abstract Ptr<sbyte> GetStringDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, StringPName> pname,
            [NativeTypeName("ALsizei")] int index
        );

        [return: NativeTypeName("const ALchar *")]
        [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
        [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
        static abstract sbyte* GetStringSoft(
            [NativeTypeName("ALenum")] int pname,
            [NativeTypeName("ALsizei")] int index
        );

        [return: NativeTypeName("const ALchar *")]
        [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
        static abstract Ptr<sbyte> GetStringSoft(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, StringPName> pname,
            [NativeTypeName("ALsizei")] int index
        );

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
        static abstract MaybeBool<sbyte> IsAuxiliaryEffectSlot(
            [NativeTypeName("ALuint")] uint effectslot
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
        static abstract MaybeBool<sbyte> IsAuxiliaryEffectSlotDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
        static abstract sbyte IsAuxiliaryEffectSlotDirectRaw(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effectslot
        );

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
        static abstract sbyte IsAuxiliaryEffectSlotRaw([NativeTypeName("ALuint")] uint effectslot);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        static abstract MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer);

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
        static abstract MaybeBool<sbyte> IsBufferDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
        static abstract sbyte IsBufferDirectRaw(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer
        );

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
        static abstract MaybeBool<sbyte> IsBufferFormatSupportedSoft(
            [NativeTypeName("ALenum")] int format
        );

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
        [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
        static abstract sbyte IsBufferFormatSupportedSoftRaw([NativeTypeName("ALenum")] int format);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        static abstract sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEffect")]
        static abstract MaybeBool<sbyte> IsEffect([NativeTypeName("ALuint")] uint effect);

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
        static abstract MaybeBool<sbyte> IsEffectDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
        static abstract sbyte IsEffectDirectRaw(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint effect
        );

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsEffect")]
        static abstract sbyte IsEffectRaw([NativeTypeName("ALuint")] uint effect);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        static abstract sbyte IsEnabled([NativeTypeName("ALenum")] int capability);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        static abstract MaybeBool<sbyte> IsEnabled(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
        static abstract sbyte IsEnabledDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int capability
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
        static abstract MaybeBool<sbyte> IsEnabledDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability
        );

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        static abstract sbyte IsExtensionPresent([NativeTypeName("const ALchar *")] sbyte* extname);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        static abstract MaybeBool<sbyte> IsExtensionPresent(
            [NativeTypeName("const ALchar *")] Ref<sbyte> extname
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
        static abstract sbyte IsExtensionPresentDirect(
            ContextHandle context,
            [NativeTypeName("const ALchar *")] sbyte* extname
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
        static abstract MaybeBool<sbyte> IsExtensionPresentDirect(
            ContextHandle context,
            [NativeTypeName("const ALchar *")] Ref<sbyte> extname
        );

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsFilter")]
        static abstract MaybeBool<sbyte> IsFilter([NativeTypeName("ALuint")] uint filter);

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
        static abstract MaybeBool<sbyte> IsFilterDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
        static abstract sbyte IsFilterDirectRaw(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint filter
        );

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
        [NativeFunction("openal", EntryPoint = "alIsFilter")]
        static abstract sbyte IsFilterRaw([NativeTypeName("ALuint")] uint filter);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        static abstract MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source);

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
        static abstract MaybeBool<sbyte> IsSourceDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
        static abstract sbyte IsSourceDirectRaw(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source
        );

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        static abstract sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3f")]
        static abstract void Listener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListener3f")]
        static abstract void Listener3(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat3> param0,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
        static abstract void Listener3Direct(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
        static abstract void Listener3Direct(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat3> param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3i")]
        static abstract void Listener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListener3i")]
        static abstract void Listener3(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerInteger3> param0,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
        static abstract void Listener3Direct(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
        static abstract void Listener3Direct(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerInteger3> param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerf")]
        static abstract void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerf")]
        static abstract void Listener(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param0,
            [NativeTypeName("ALfloat")] float value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
        static abstract void ListenerDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
        static abstract void ListenerDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param1,
            [NativeTypeName("ALfloat")] float value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        static abstract void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        static abstract void Listener(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param0,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
        static abstract void ListenerDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
        static abstract void ListenerDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneri")]
        static abstract void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListeneriDirect")]
        static abstract void ListenerDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        static abstract void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        static abstract void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] Ref<int> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
        static abstract void ListenerDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
        static abstract void ListenerDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
        static abstract void ObjectLabelDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] int identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] sbyte* label
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
        static abstract void ObjectLabelDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] Ref<sbyte> label
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
        static abstract void ObjectLabelDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("const ALchar *")] sbyte label
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
        static abstract void ObjectLabelExt(
            [NativeTypeName("ALenum")] int identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] sbyte* label
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
        static abstract void ObjectLabelExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] Ref<sbyte> label
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
        static abstract void ObjectLabelExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
            [NativeTypeName("ALuint")] uint name,
            [NativeTypeName("const ALchar *")] sbyte label
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alPopDebugGroupDirectEXT")]
        static abstract void PopDebugGroupDirectExt(ContextHandle context);

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alPopDebugGroupEXT")]
        static abstract void PopDebugGroupExt();

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
        static abstract void ProcessUpdatesDirectSoft(ContextHandle context);

        [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
        [NativeFunction("openal", EntryPoint = "alProcessUpdatesSOFT")]
        static abstract void ProcessUpdatesSoft();

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
        static abstract void PushDebugGroupDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] int source,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] sbyte* message
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
        static abstract void PushDebugGroupDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] Ref<sbyte> message
        );

        [
            SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
            SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
        static abstract void PushDebugGroupDirectExt(
            ContextHandle context,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("const ALchar *")] sbyte message
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
        static abstract void PushDebugGroupExt(
            [NativeTypeName("ALenum")] int source,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] sbyte* message
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
        static abstract void PushDebugGroupExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("const ALchar *")] Ref<sbyte> message
        );

        [SupportedApiProfile("al", ["AL_EXT_debug"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
        static abstract void PushDebugGroupExt(
            [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
            [NativeTypeName("ALuint")] uint id,
            [NativeTypeName("const ALchar *")] sbyte message
        );

        [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
        static abstract void RequestFoldbackStart(
            [NativeTypeName("ALenum")] int mode,
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("ALfloat *")] float* mem,
            [NativeTypeName("LPALFOLDBACKCALLBACK")] FoldbackCallback callback
        );

        [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
        static abstract void RequestFoldbackStart(
            [NativeTypeName("ALenum")] int mode,
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("ALfloat *")] Ref<float> mem,
            [NativeTypeName("LPALFOLDBACKCALLBACK")] FoldbackCallback callback
        );

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
            [NativeTypeName("ALenum")] int mode,
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("ALfloat *")] float* mem,
            [NativeTypeName("LPALFOLDBACKCALLBACK")] FoldbackCallback callback
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStartDirect")]
        static abstract void RequestFoldbackStartDirect(
            ContextHandle context,
            [NativeTypeName("ALenum")] int mode,
            [NativeTypeName("ALsizei")] int count,
            [NativeTypeName("ALsizei")] int length,
            [NativeTypeName("ALfloat *")] Ref<float> mem,
            [NativeTypeName("LPALFOLDBACKCALLBACK")] FoldbackCallback callback
        );

        [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
        [NativeFunction("openal", EntryPoint = "alRequestFoldbackStop")]
        static abstract void RequestFoldbackStop();

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
        static abstract void Source3DirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALdouble")] double value1,
            [NativeTypeName("ALdouble")] double value2,
            [NativeTypeName("ALdouble")] double value3
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSource3dSOFT")]
        static abstract void Source3Soft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALdouble")] double value1,
            [NativeTypeName("ALdouble")] double value2,
            [NativeTypeName("ALdouble")] double value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3f")]
        static abstract void Source3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSource3f")]
        static abstract void Source3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat3> param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
        static abstract void Source3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
        static abstract void Source3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat3> param2,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3i")]
        static abstract void Source3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSource3i")]
        static abstract void Source3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

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
        static abstract void Source3DirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint64SOFT")] nint value1,
            [NativeTypeName("ALint64SOFT")] nint value2,
            [NativeTypeName("ALint64SOFT")] nint value3
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSource3i64DirectSOFT")]
        static abstract void Source3DirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param2,
            [NativeTypeName("ALint64SOFT")] nint value1,
            [NativeTypeName("ALint64SOFT")] nint value2,
            [NativeTypeName("ALint64SOFT")] nint value3
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
        static abstract void Source3Soft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint64SOFT")] nint value1,
            [NativeTypeName("ALint64SOFT")] nint value2,
            [NativeTypeName("ALint64SOFT")] nint value3
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
        static abstract void Source3Soft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param1,
            [NativeTypeName("ALint64SOFT")] nint value1,
            [NativeTypeName("ALint64SOFT")] nint value2,
            [NativeTypeName("ALint64SOFT")] nint value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
        static abstract void Source3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
        static abstract void Source3Direct(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param2,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

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
        static abstract void SourceDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALdouble")] double value
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcedDirectSOFT")]
        static abstract void SourceDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param2,
            [NativeTypeName("ALdouble")] double value
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
        static abstract void SourceSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALdouble")] double value
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
        static abstract void SourceSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param1,
            [NativeTypeName("ALdouble")] double value
        );

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
        static abstract void SourceDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALdouble *")] double* values
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcedvDirectSOFT")]
        static abstract void SourceDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param2,
            [NativeTypeName("const ALdouble *")] Ref<double> values
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
        static abstract void SourceSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALdouble *")] double* values
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
        static abstract void SourceSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param1,
            [NativeTypeName("const ALdouble *")] Ref<double> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcef")]
        static abstract void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcef")]
        static abstract void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param1,
            [NativeTypeName("ALfloat")] float value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALfloat")] float value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param2,
            [NativeTypeName("ALfloat")] float value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        static abstract void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        static abstract void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param2,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcei")]
        static abstract void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcei")]
        static abstract void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeTypeName("ALint")] int value
        );

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
        static abstract void SourceDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint64SOFT")] nint value
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcei64DirectSOFT")]
        static abstract void SourceDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeTypeName("ALint64SOFT")] nint value
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
        static abstract void SourceSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint64SOFT")] nint value
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
        static abstract void SourceSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeTypeName("ALint64SOFT")] nint value
        );

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
        static abstract void SourceDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALint64SOFT *")] nint* values
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcei64vDirectSOFT")]
        static abstract void SourceDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeTypeName("const ALint64SOFT *")] Ref<nint> values
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
        static abstract void SourceSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint64SOFT *")] nint* values
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
        static abstract void SourceSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeTypeName("const ALint64SOFT *")] Ref<nint> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("ALint")] int value
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeTypeName("ALint")] int value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        static abstract void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        static abstract void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param2,
            [NativeTypeName("const ALint *")] int* values
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
        static abstract void SourceDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
            [NativeTypeName("const ALint *")] Ref<int> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePause")]
        static abstract void SourcePause([NativeTypeName("ALuint")] uint source);

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePauseDirect")]
        static abstract void SourcePauseDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        static abstract void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        static abstract void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        static abstract void SourcePausev([NativeTypeName("const ALuint *")] uint sources);

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
        static abstract void SourcePausevDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
        static abstract void SourcePausevDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
        static abstract void SourcePausevDirect(
            ContextHandle context,
            [NativeTypeName("const ALuint *")] uint sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlay")]
        static abstract void SourcePlay([NativeTypeName("ALuint")] uint source);

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
        static abstract void SourcePlayAtTimeDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALint64SOFT")] nint start_time
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimeSOFT")]
        static abstract void SourcePlayAtTimeSoft(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALint64SOFT")] nint start_time
        );

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
        static abstract void SourcePlayAtTimevDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources,
            [NativeTypeName("ALint64SOFT")] nint start_time
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevDirectSOFT")]
        static abstract void SourcePlayAtTimevDirectSoft(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources,
            [NativeTypeName("ALint64SOFT")] nint start_time
        );

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
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevDirectSOFT")]
        static abstract void SourcePlayAtTimevDirectSoft(
            ContextHandle context,
            [NativeTypeName("const ALuint *")] uint sources,
            [NativeTypeName("ALint64SOFT")] nint start_time
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
        static abstract void SourcePlayAtTimevSoft(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources,
            [NativeTypeName("ALint64SOFT")] nint start_time
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
        static abstract void SourcePlayAtTimevSoft(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources,
            [NativeTypeName("ALint64SOFT")] nint start_time
        );

        [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
        static abstract void SourcePlayAtTimevSoft(
            [NativeTypeName("const ALuint *")] uint sources,
            [NativeTypeName("ALint64SOFT")] nint start_time
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayDirect")]
        static abstract void SourcePlayDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        static abstract void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        static abstract void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        static abstract void SourcePlayv([NativeTypeName("const ALuint *")] uint sources);

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
        static abstract void SourcePlayvDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
        static abstract void SourcePlayvDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
        static abstract void SourcePlayvDirect(
            ContextHandle context,
            [NativeTypeName("const ALuint *")] uint sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        static abstract void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] uint* buffers
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        static abstract void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
        static abstract void SourceQueueBuffersDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] uint* buffers
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
        static abstract void SourceQueueBuffersDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewind")]
        static abstract void SourceRewind([NativeTypeName("ALuint")] uint source);

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceRewindDirect")]
        static abstract void SourceRewindDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewin(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewin(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewin([NativeTypeName("const ALuint *")] uint sources);

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
        static abstract void SourceRewinDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
        static abstract void SourceRewinDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
        static abstract void SourceRewinDirect(
            ContextHandle context,
            [NativeTypeName("const ALuint *")] uint sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStop")]
        static abstract void SourceStop([NativeTypeName("ALuint")] uint source);

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceStopDirect")]
        static abstract void SourceStopDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        static abstract void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        static abstract void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        static abstract void SourceStopv([NativeTypeName("const ALuint *")] uint sources);

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
        static abstract void SourceStopvDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
        static abstract void SourceStopvDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
        static abstract void SourceStopvDirect(
            ContextHandle context,
            [NativeTypeName("const ALuint *")] uint sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        static abstract void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] uint* buffers
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        static abstract void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
        static abstract void SourceUnqueueBuffersDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] uint* buffers
        );

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
        static abstract void SourceUnqueueBuffersDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
        static abstract void SpeedOfSound([NativeTypeName("ALfloat")] float value);

        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "alSpeedOfSoundDirect")]
        static abstract void SpeedOfSoundDirect(
            ContextHandle context,
            [NativeTypeName("ALfloat")] float value
        );

        [return: NativeTypeName("ALenum")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
        static abstract int EaxGetBufferModeDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALint *")] int* pReserved
        );

        [return: NativeTypeName("ALenum")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
        static abstract int EaxGetBufferModeDirect(
            ContextHandle context,
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALint *")] Ref<int> pReserved
        );

        [return: NativeTypeName("ALenum")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
        static abstract int EaxGetDirect(
            ContextHandle context,
            [NativeTypeName("const struct _GUID *")] System.Guid* property_set_id,
            [NativeTypeName("ALuint")] uint property_id,
            [NativeTypeName("ALuint")] uint source_id,
            [NativeTypeName("ALvoid *")] void* value,
            [NativeTypeName("ALuint")] uint value_size
        );

        [return: NativeTypeName("ALenum")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
        static abstract int EaxGetDirect(
            ContextHandle context,
            [NativeTypeName("const struct _GUID *")] Ref<System.Guid> property_set_id,
            [NativeTypeName("ALuint")] uint property_id,
            [NativeTypeName("ALuint")] uint source_id,
            [NativeTypeName("ALvoid *")] Ref value,
            [NativeTypeName("ALuint")] uint value_size
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
        static abstract sbyte EaxSetBufferModeDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* buffers,
            [NativeTypeName("ALint")] int value
        );

        [return: NativeTypeName("ALboolean")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
        static abstract MaybeBool<sbyte> EaxSetBufferModeDirect(
            ContextHandle context,
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers,
            [NativeTypeName("ALint")] int value
        );

        [return: NativeTypeName("ALenum")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
        static abstract int EaxSetDirect(
            ContextHandle context,
            [NativeTypeName("const struct _GUID *")] System.Guid* property_set_id,
            [NativeTypeName("ALuint")] uint property_id,
            [NativeTypeName("ALuint")] uint source_id,
            [NativeTypeName("ALvoid *")] void* value,
            [NativeTypeName("ALuint")] uint value_size
        );

        [return: NativeTypeName("ALenum")]
        [
            SupportedApiProfile("al", ["AL_EXT_direct_context"]),
            SupportedApiProfile("alc", ["AL_EXT_direct_context"])
        ]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
        static abstract int EaxSetDirect(
            ContextHandle context,
            [NativeTypeName("const struct _GUID *")] Ref<System.Guid> property_set_id,
            [NativeTypeName("ALuint")] uint property_id,
            [NativeTypeName("ALuint")] uint source_id,
            [NativeTypeName("ALvoid *")] Ref value,
            [NativeTypeName("ALuint")] uint value_size
        );
    }

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
    void AuxiliaryEffectSlot(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float flValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotf")]
    void AuxiliaryEffectSlot(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
        [NativeTypeName("ALfloat")] float flValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat")] float flValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
        [NativeTypeName("ALfloat")] float flValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
    void AuxiliaryEffectSlot(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfv")]
    void AuxiliaryEffectSlot(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
        [NativeTypeName("const ALfloat *")] Ref<float> pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALfloat *")] float* pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotfvDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
        [NativeTypeName("const ALfloat *")] Ref<float> pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
    void AuxiliaryEffectSlot(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int iValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSloti")]
    void AuxiliaryEffectSlot(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
        [NativeTypeName("ALint")] int iValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint")] int iValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
        [NativeTypeName("ALint")] int iValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
    void AuxiliaryEffectSlot(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* piValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotiv")]
    void AuxiliaryEffectSlot(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
        [NativeTypeName("const ALint *")] Ref<int> piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALint *")] int* piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alAuxiliaryEffectSlotivDirect")]
    void AuxiliaryEffectSlotDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
        [NativeTypeName("const ALint *")] Ref<int> piValues
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBuffer3f")]
    void Buffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBuffer3fDirect")]
    void Buffer3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBuffer3i")]
    void Buffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBuffer3iDirect")]
    void Buffer3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

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
    void BufferCallbackDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("ALsizei")] int freq,
        [NativeTypeName("ALBUFFERCALLBACKTYPESOFT")] BufferCallbackSoft callback,
        [NativeTypeName("ALvoid *")] void* userptr
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferCallbackDirectSOFT")]
    void BufferCallbackDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
        [NativeTypeName("ALsizei")] int freq,
        [NativeTypeName("ALBUFFERCALLBACKTYPESOFT")] BufferCallbackSoft callback,
        [NativeTypeName("ALvoid *")] Ref userptr
    );

    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
    void BufferCallbackSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("ALsizei")] int freq,
        [NativeTypeName("ALBUFFERCALLBACKTYPESOFT")] BufferCallbackSoft callback,
        [NativeTypeName("ALvoid *")] void* userptr
    );

    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferCallbackSOFT")]
    void BufferCallbackSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
        [NativeTypeName("ALsizei")] int freq,
        [NativeTypeName("ALBUFFERCALLBACKTYPESOFT")] BufferCallbackSoft callback,
        [NativeTypeName("ALvoid *")] Ref userptr
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferData")]
    void BufferData(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("const ALvoid *")] void* data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferData")]
    void BufferData(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
        [NativeTypeName("const ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
    void BufferDataDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("const ALvoid *")] void* data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferDataDirect")]
    void BufferDataDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
        [NativeTypeName("const ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    );

    [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
    [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
    void BufferDataStatic(
        [NativeTypeName("const ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("ALvoid *")] void* data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int freq
    );

    [SupportedApiProfile("al", ["AL_EXT_STATIC_BUFFER"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferDataStatic")]
    void BufferDataStatic(
        [NativeTypeName("const ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
        [NativeTypeName("ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int freq
    );

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
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("ALvoid *")] void* data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int freq
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferDataStaticDirect")]
    void BufferDataStaticDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
        [NativeTypeName("ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int freq
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferf")]
    void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferf")]
    void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param1,
        [NativeTypeName("ALfloat")] float value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
    void BufferDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat")] float value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferfDirect")]
    void BufferDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param2,
        [NativeTypeName("ALfloat")] float value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
    void BufferDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALfloat *")] float* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferfvDirect")]
    void BufferDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param2,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferi")]
    void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferi")]
    void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param1,
        [NativeTypeName("ALint")] int value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
    void BufferDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint")] int value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferiDirect")]
    void BufferDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param2,
        [NativeTypeName("ALint")] int value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
    void BufferDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALint *")] int* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferivDirect")]
    void BufferDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param2,
        [NativeTypeName("const ALint *")] Ref<int> values
    );

    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
    void BufferSamplesSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALuint")] uint samplerate,
        [NativeTypeName("ALenum")] int internalformat,
        [NativeTypeName("ALsizei")] int samples,
        [NativeTypeName("ALenum")] int channels,
        [NativeTypeName("ALenum")] int type,
        [NativeTypeName("const ALvoid *")] void* data
    );

    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferSamplesSOFT")]
    void BufferSamplesSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALuint")] uint samplerate,
        [NativeTypeName("ALenum")] int internalformat,
        [NativeTypeName("ALsizei")] int samples,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SampleTypeSOFT> type,
        [NativeTypeName("const ALvoid *")] Ref data
    );

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
    void BufferSubDataDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("const ALvoid *")] void* data,
        [NativeTypeName("ALsizei")] int offset,
        [NativeTypeName("ALsizei")] int length
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferSubDataDirectSOFT")]
    void BufferSubDataDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
        [NativeTypeName("const ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int offset,
        [NativeTypeName("ALsizei")] int length
    );

    [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
    [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
    void BufferSubDataSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("const ALvoid *")] void* data,
        [NativeTypeName("ALsizei")] int offset,
        [NativeTypeName("ALsizei")] int length
    );

    [SupportedApiProfile("al", ["AL_SOFT_buffer_sub_data"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferSubDataSOFT")]
    void BufferSubDataSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, Format> format,
        [NativeTypeName("const ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int offset,
        [NativeTypeName("ALsizei")] int length
    );

    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
    void BufferSubSamplesSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALsizei")] int offset,
        [NativeTypeName("ALsizei")] int samples,
        [NativeTypeName("ALenum")] int channels,
        [NativeTypeName("ALenum")] int type,
        [NativeTypeName("const ALvoid *")] void* data
    );

    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferSubSamplesSOFT")]
    void BufferSubSamplesSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALsizei")] int offset,
        [NativeTypeName("ALsizei")] int samples,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SampleTypeSOFT> type,
        [NativeTypeName("const ALvoid *")] Ref data
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
    void DebugMessageCallbackDirectExt(
        ContextHandle context,
        [NativeTypeName("ALDEBUGPROCEXT")] DebugProcExt callback,
        void* userParam
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackDirectEXT")]
    void DebugMessageCallbackDirectExt(
        ContextHandle context,
        [NativeTypeName("ALDEBUGPROCEXT")] DebugProcExt callback,
        Ref userParam
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
    void DebugMessageCallbackExt(
        [NativeTypeName("ALDEBUGPROCEXT")] DebugProcExt callback,
        void* userParam
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDebugMessageCallbackEXT")]
    void DebugMessageCallbackExt(
        [NativeTypeName("ALDEBUGPROCEXT")] DebugProcExt callback,
        Ref userParam
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
    void DebugMessageControlDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] int source,
        [NativeTypeName("ALenum")] int type,
        [NativeTypeName("ALenum")] int severity,
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("const ALuint *")] uint* ids,
        [NativeTypeName("ALboolean")] sbyte enable
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
    void DebugMessageControlDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("const ALuint *")] Ref<uint> ids,
        [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlDirectEXT")]
    void DebugMessageControlDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeTypeName("const ALuint *")] uint ids,
        [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
    void DebugMessageControlExt(
        [NativeTypeName("ALenum")] int source,
        [NativeTypeName("ALenum")] int type,
        [NativeTypeName("ALenum")] int severity,
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("const ALuint *")] uint* ids,
        [NativeTypeName("ALboolean")] sbyte enable
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
    void DebugMessageControlExt(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("const ALuint *")] Ref<uint> ids,
        [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDebugMessageControlEXT")]
    void DebugMessageControlExt(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeTypeName("const ALuint *")] uint ids,
        [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
    void DebugMessageInsertDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] int source,
        [NativeTypeName("ALenum")] int type,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("ALenum")] int severity,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] sbyte* message
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
    void DebugMessageInsertDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] Ref<sbyte> message
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertDirectEXT")]
    void DebugMessageInsertDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeTypeName("const ALchar *")] sbyte message
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
    void DebugMessageInsertExt(
        [NativeTypeName("ALenum")] int source,
        [NativeTypeName("ALenum")] int type,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("ALenum")] int severity,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] sbyte* message
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
    void DebugMessageInsertExt(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] Ref<sbyte> message
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDebugMessageInsertEXT")]
    void DebugMessageInsertExt(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugTypeEXT> type,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSeverityEXT> severity,
        [NativeTypeName("const ALchar *")] sbyte message
    );

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
    void DeferUpdatesDirectSoft(ContextHandle context);

    [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
    [NativeFunction("openal", EntryPoint = "alDeferUpdatesSOFT")]
    void DeferUpdatesSoft();

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
    void DeleteAuxiliaryEffectSlot([NativeTypeName("const ALuint *")] uint effectslots);

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
    void DeleteAuxiliaryEffectSlots(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* effectslots
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlots")]
    void DeleteAuxiliaryEffectSlots(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> effectslots
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
    void DeleteAuxiliaryEffectSlotsDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* effectslots
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
    void DeleteAuxiliaryEffectSlotsDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> effectslots
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteAuxiliaryEffectSlotsDirect")]
    void DeleteAuxiliaryEffectSlotsDirect(
        ContextHandle context,
        [NativeTypeName("const ALuint *")] uint effectslots
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* buffers
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
    void DeleteBuffersDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* buffers
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffersDirect")]
    void DeleteBuffersDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
    void DeleteEffect([NativeTypeName("const ALuint *")] uint effects);

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
    void DeleteEffects(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* effects
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteEffects")]
    void DeleteEffects(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> effects
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
    void DeleteEffectsDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* effects
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
    void DeleteEffectsDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> effects
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteEffectsDirect")]
    void DeleteEffectsDirect(
        ContextHandle context,
        [NativeTypeName("const ALuint *")] uint effects
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
    void DeleteFilter([NativeTypeName("const ALuint *")] uint filters);

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
    void DeleteFilters(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* filters
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteFilters")]
    void DeleteFilters(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> filters
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
    void DeleteFiltersDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* filters
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
    void DeleteFiltersDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> filters
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteFiltersDirect")]
    void DeleteFiltersDirect(
        ContextHandle context,
        [NativeTypeName("const ALuint *")] uint filters
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSource([NativeTypeName("const ALuint *")] uint sources);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
    void DeleteSourcesDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
    void DeleteSourcesDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteSourcesDirect")]
    void DeleteSourcesDirect(
        ContextHandle context,
        [NativeTypeName("const ALuint *")] uint sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDisable")]
    void Disable([NativeTypeName("ALenum")] int capability);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDisable")]
    void Disable([NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDisableDirect")]
    void DisableDirect(ContextHandle context, [NativeTypeName("ALenum")] int capability);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDisableDirect")]
    void DisableDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    void DistanceModel([NativeTypeName("ALenum")] int distanceModel);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    void DistanceModel(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DistanceModel> distanceModel
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
    void DistanceModelDirect(ContextHandle context, [NativeTypeName("ALenum")] int distanceModel);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDistanceModelDirect")]
    void DistanceModelDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DistanceModel> distanceModel
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
    void DopplerFactor([NativeTypeName("ALfloat")] float value);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alDopplerFactorDirect")]
    void DopplerFactorDirect(ContextHandle context, [NativeTypeName("ALfloat")] float value);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
    void DopplerVelocity([NativeTypeName("ALfloat")] float value);

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectf")]
    void Effect(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float flValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEffectf")]
    void Effect(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param1,
        [NativeTypeName("ALfloat")] float flValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
    void EffectDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat")] float flValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEffectfDirect")]
    void EffectDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param2,
        [NativeTypeName("ALfloat")] float flValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectfv")]
    void Effect(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEffectfv")]
    void Effect(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param1,
        [NativeTypeName("const ALfloat *")] Ref<float> pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
    void EffectDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALfloat *")] float* pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEffectfvDirect")]
    void EffectDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param2,
        [NativeTypeName("const ALfloat *")] Ref<float> pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffecti")]
    void Effect(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int iValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEffecti")]
    void Effect(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param1,
        [NativeTypeName("ALint")] int iValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
    void EffectDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint")] int iValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEffectiDirect")]
    void EffectDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param2,
        [NativeTypeName("ALint")] int iValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alEffectiv")]
    void Effect(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* piValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEffectiv")]
    void Effect(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param1,
        [NativeTypeName("const ALint *")] Ref<int> piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
    void EffectDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALint *")] int* piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEffectivDirect")]
    void EffectDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param2,
        [NativeTypeName("const ALint *")] Ref<int> piValues
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alEnable")]
    void Enable([NativeTypeName("ALenum")] int capability);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEnable")]
    void Enable([NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alEnableDirect")]
    void EnableDirect(ContextHandle context, [NativeTypeName("ALenum")] int capability);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEnableDirect")]
    void EnableDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventCallbackDirectSOFT")]
    void EventCallbackDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALEVENTPROCSOFT")] EventProcSoft callback,
        void* userParam
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEventCallbackDirectSOFT")]
    void EventCallbackDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALEVENTPROCSOFT")] EventProcSoft callback,
        Ref userParam
    );

    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
    void EventCallbackSoft(
        [NativeTypeName("ALEVENTPROCSOFT")] EventProcSoft callback,
        void* userParam
    );

    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEventCallbackSOFT")]
    void EventCallbackSoft(
        [NativeTypeName("ALEVENTPROCSOFT")] EventProcSoft callback,
        Ref userParam
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
    void EventControlDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("const ALenum *")] int* types,
        [NativeTypeName("ALboolean")] sbyte enable
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
    void EventControlDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("const ALenum *")] Ref<int> types,
        [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEventControlDirectSOFT")]
    void EventControlDirectSoft(
        ContextHandle context,
        [NativeTypeName("const ALenum *")] int types,
        [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
    );

    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
    void EventControlSoft(
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("const ALenum *")] int* types,
        [NativeTypeName("ALboolean")] sbyte enable
    );

    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
    void EventControlSoft(
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("const ALenum *")] Ref<int> types,
        [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
    );

    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEventControlSOFT")]
    void EventControlSoft(
        [NativeTypeName("const ALenum *")] int types,
        [NativeTypeName("ALboolean")] MaybeBool<sbyte> enable
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilterf")]
    void Filter(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float flValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alFilterf")]
    void Filter(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param1,
        [NativeTypeName("ALfloat")] float flValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
    void FilterDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat")] float flValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alFilterfDirect")]
    void FilterDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param2,
        [NativeTypeName("ALfloat")] float flValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilterfv")]
    void Filter(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alFilterfv")]
    void Filter(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param1,
        [NativeTypeName("const ALfloat *")] Ref<float> pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
    void FilterDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALfloat *")] float* pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alFilterfvDirect")]
    void FilterDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param2,
        [NativeTypeName("const ALfloat *")] Ref<float> pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilteri")]
    void Filter(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int iValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alFilteri")]
    void Filter(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param1,
        [NativeTypeName("ALint")] int iValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
    void FilterDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint")] int iValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alFilteriDirect")]
    void FilterDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param2,
        [NativeTypeName("ALint")] int iValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alFilteriv")]
    void Filter(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* piValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alFilteriv")]
    void Filter(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param1,
        [NativeTypeName("const ALint *")] Ref<int> piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
    void FilterDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALint *")] int* piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alFilterivDirect")]
    void FilterDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param2,
        [NativeTypeName("const ALint *")] Ref<int> piValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
    uint GenAuxiliaryEffectSlot();

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
    void GenAuxiliaryEffectSlots(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] uint* effectslots
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlots")]
    void GenAuxiliaryEffectSlots(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> effectslots
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
    void GenAuxiliaryEffectSlotsDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] uint* effectslots
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
    void GenAuxiliaryEffectSlotsDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> effectslots
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenAuxiliaryEffectSlotsDirect")]
    uint GenAuxiliaryEffectSlotsDirect(ContextHandle context);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    uint GenBuffer();

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    void GenBuffers([NativeTypeName("ALsizei")] int n, [NativeTypeName("ALuint *")] uint* buffers);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    void GenBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> buffers
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
    void GenBuffersDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] uint* buffers
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenBuffersDirect")]
    void GenBuffersDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> buffers
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenEffects")]
    uint GenEffect();

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenEffects")]
    void GenEffects([NativeTypeName("ALsizei")] int n, [NativeTypeName("ALuint *")] uint* effects);

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenEffects")]
    void GenEffects(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> effects
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
    void GenEffectsDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] uint* effects
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
    void GenEffectsDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> effects
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenEffectsDirect")]
    uint GenEffectsDirect(ContextHandle context);

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenFilters")]
    uint GenFilter();

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGenFilters")]
    void GenFilters([NativeTypeName("ALsizei")] int n, [NativeTypeName("ALuint *")] uint* filters);

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenFilters")]
    void GenFilters(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> filters
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
    void GenFiltersDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] uint* filters
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
    void GenFiltersDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> filters
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenFiltersDirect")]
    uint GenFiltersDirect(ContextHandle context);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    uint GenSource();

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    void GenSources([NativeTypeName("ALsizei")] int n, [NativeTypeName("ALuint *")] uint* sources);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    void GenSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
    void GenSourcesDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] uint* sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
    void GenSourcesDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenSourcesDirect")]
    uint GenSourcesDirect(ContextHandle context);

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
    void GetAuxiliaryEffectSlotf(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* flValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotf")]
    void GetAuxiliaryEffectSlotf(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> flValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
    void GetAuxiliaryEffectSlotfDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* pflValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfDirect")]
    void GetAuxiliaryEffectSlotfDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
        [NativeTypeName("ALfloat *")] Ref<float> pflValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
    void GetAuxiliaryEffectSlotfv(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfv")]
    void GetAuxiliaryEffectSlotfv(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
    void GetAuxiliaryEffectSlotfvDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotfvDirect")]
    void GetAuxiliaryEffectSlotfvDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotFloat> param2,
        [NativeTypeName("ALfloat *")] Ref<float> pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
    void GetAuxiliaryEffectSloti(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* iValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSloti")]
    void GetAuxiliaryEffectSloti(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
        [NativeTypeName("ALint *")] Ref<int> iValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
    void GetAuxiliaryEffectSlotiDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* piValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiDirect")]
    void GetAuxiliaryEffectSlotiDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
        [NativeTypeName("ALint *")] Ref<int> piValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
    void GetAuxiliaryEffectSlotiv(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* piValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotiv")]
    void GetAuxiliaryEffectSlotiv(
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param1,
        [NativeTypeName("ALint *")] Ref<int> piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
    void GetAuxiliaryEffectSlotivDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetAuxiliaryEffectSlotivDirect")]
    void GetAuxiliaryEffectSlotivDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, AuxiliaryEffectSlotInteger> param2,
        [NativeTypeName("ALint *")] Ref<int> piValues
    );

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    sbyte GetBoolean([NativeTypeName("ALenum")] int param0);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    MaybeBool<sbyte> GetBoolean(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BooleanPName> param0
    );

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
    sbyte GetBooleanDirect(ContextHandle context, [NativeTypeName("ALenum")] int param1);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBooleanDirect")]
    MaybeBool<sbyte> GetBooleanDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BooleanPName> param1
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    void GetBoolean(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALboolean *")] sbyte* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    void GetBoolean(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BooleanPName> param0,
        [NativeTypeName("ALboolean *")] Ref<sbyte> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
    void GetBooleanDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALboolean *")] sbyte* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBooleanvDirect")]
    void GetBooleanDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BooleanPName> param1,
        [NativeTypeName("ALboolean *")] Ref<sbyte> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    void GetBuffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    void GetBuffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
    void GetBuffer3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3fDirect")]
    void GetBuffer3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    void GetBuffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    void GetBuffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
    void GetBuffer3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3iDirect")]
    void GetBuffer3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    );

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
    void GetBuffer3PtrDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALvoid **")] void** ptr0,
        [NativeTypeName("ALvoid **")] void** ptr1,
        [NativeTypeName("ALvoid **")] void** ptr2
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrDirectSOFT")]
    void GetBuffer3PtrDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param2,
        [NativeTypeName("ALvoid **")] Ref2D ptr0,
        [NativeTypeName("ALvoid **")] Ref2D ptr1,
        [NativeTypeName("ALvoid **")] Ref2D ptr2
    );

    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
    void GetBuffer3PtrSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALvoid **")] void** ptr0,
        [NativeTypeName("ALvoid **")] void** ptr1,
        [NativeTypeName("ALvoid **")] void** ptr2
    );

    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3PtrSOFT")]
    void GetBuffer3PtrSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param1,
        [NativeTypeName("ALvoid **")] Ref2D ptr0,
        [NativeTypeName("ALvoid **")] Ref2D ptr1,
        [NativeTypeName("ALvoid **")] Ref2D ptr2
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferf")]
    void GetBufferf(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferf")]
    void GetBufferf(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
    void GetBufferfDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferfDirect")]
    void GetBufferfDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param2,
        [NativeTypeName("ALfloat *")] Ref<float> value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
    void GetBufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
    void GetBufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
    void GetBufferfvDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferfvDirect")]
    void GetBufferfvDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferFloat> param2,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferi")]
    void GetBufferi(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferi")]
    void GetBufferi(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param1,
        [NativeTypeName("ALint *")] Ref<int> value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
    void GetBufferiDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferiDirect")]
    void GetBufferiDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param2,
        [NativeTypeName("ALint *")] Ref<int> value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
    void GetBufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
    void GetBufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param1,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
    void GetBufferivDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferivDirect")]
    void GetBufferivDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferInteger> param2,
        [NativeTypeName("ALint *")] Ref<int> values
    );

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
    void GetBufferPtrDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALvoid **")] void** ptr
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrDirectSOFT")]
    void GetBufferPtrDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param2,
        [NativeTypeName("ALvoid **")] Ref2D ptr
    );

    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
    void GetBufferPtrSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALvoid **")] void** ptr
    );

    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrSOFT")]
    void GetBufferPtrSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param1,
        [NativeTypeName("ALvoid **")] Ref2D ptr
    );

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
    void GetBufferPtrvDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALvoid **")] void** ptr
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrvDirectSOFT")]
    void GetBufferPtrvDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param2,
        [NativeTypeName("ALvoid **")] Ref2D ptr
    );

    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
    void GetBufferPtrvSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALvoid **")] void** ptr
    );

    [SupportedApiProfile("al", ["AL_SOFT_callback_buffer"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferPtrvSOFT")]
    void GetBufferPtrvSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferPointerSOFT> param1,
        [NativeTypeName("ALvoid **")] Ref2D ptr
    );

    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
    void GetBufferSamplesSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALsizei")] int offset,
        [NativeTypeName("ALsizei")] int samples,
        [NativeTypeName("ALenum")] int channels,
        [NativeTypeName("ALenum")] int type,
        [NativeTypeName("ALvoid *")] void* data
    );

    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferSamplesSOFT")]
    void GetBufferSamplesSoft(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALsizei")] int offset,
        [NativeTypeName("ALsizei")] int samples,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, BufferChannelsSOFT> channels,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SampleTypeSOFT> type,
        [NativeTypeName("ALvoid *")] Ref data
    );

    [return: NativeTypeName("ALuint")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectExt(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint count,
        [NativeTypeName("ALsizei")] int logBufSize,
        [NativeTypeName("ALenum *")] int* sources,
        [NativeTypeName("ALenum *")] int* types,
        [NativeTypeName("ALuint *")] uint* ids,
        [NativeTypeName("ALenum *")] int* severities,
        [NativeTypeName("ALsizei *")] int* lengths,
        [NativeTypeName("ALchar *")] sbyte* logBuf
    );

    [return: NativeTypeName("ALuint")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectExt(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint count,
        [NativeTypeName("ALsizei")] int logBufSize,
        [NativeTypeName("ALenum *")] Ref<int> sources,
        [NativeTypeName("ALenum *")] Ref<int> types,
        [NativeTypeName("ALuint *")] Ref<uint> ids,
        [NativeTypeName("ALenum *")] Ref<int> severities,
        [NativeTypeName("ALsizei *")] Ref<int> lengths,
        [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
    );

    [return: NativeTypeName("ALuint")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectExt(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint count,
        [NativeTypeName("ALsizei")] int logBufSize,
        [NativeTypeName("ALenum *")] Ref<AlEnum> sources,
        [NativeTypeName("ALenum *")] Ref<AlEnum> types,
        [NativeTypeName("ALuint *")] Ref<uint> ids,
        [NativeTypeName("ALenum *")] Ref<AlEnum> severities,
        [NativeTypeName("ALsizei *")] Ref<int> lengths,
        [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
    );

    [return: NativeTypeName("ALuint")]
    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogDirectEXT")]
    uint GetDebugMessageLogDirectExt(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint count,
        [NativeTypeName("ALsizei")] int logBufSize,
        [NativeTypeName("ALenum *")] Ref<DebugSourceEXT> sources,
        [NativeTypeName("ALenum *")] Ref<DebugTypeEXT> types,
        [NativeTypeName("ALuint *")] Ref<uint> ids,
        [NativeTypeName("ALenum *")] Ref<DebugSeverityEXT> severities,
        [NativeTypeName("ALsizei *")] Ref<int> lengths,
        [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
    );

    [return: NativeTypeName("ALuint")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogExt(
        [NativeTypeName("ALuint")] uint count,
        [NativeTypeName("ALsizei")] int logBufSize,
        [NativeTypeName("ALenum *")] int* sources,
        [NativeTypeName("ALenum *")] int* types,
        [NativeTypeName("ALuint *")] uint* ids,
        [NativeTypeName("ALenum *")] int* severities,
        [NativeTypeName("ALsizei *")] int* lengths,
        [NativeTypeName("ALchar *")] sbyte* logBuf
    );

    [return: NativeTypeName("ALuint")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogExt(
        [NativeTypeName("ALuint")] uint count,
        [NativeTypeName("ALsizei")] int logBufSize,
        [NativeTypeName("ALenum *")] Ref<int> sources,
        [NativeTypeName("ALenum *")] Ref<int> types,
        [NativeTypeName("ALuint *")] Ref<uint> ids,
        [NativeTypeName("ALenum *")] Ref<int> severities,
        [NativeTypeName("ALsizei *")] Ref<int> lengths,
        [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
    );

    [return: NativeTypeName("ALuint")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogExt(
        [NativeTypeName("ALuint")] uint count,
        [NativeTypeName("ALsizei")] int logBufSize,
        [NativeTypeName("ALenum *")] Ref<AlEnum> sources,
        [NativeTypeName("ALenum *")] Ref<AlEnum> types,
        [NativeTypeName("ALuint *")] Ref<uint> ids,
        [NativeTypeName("ALenum *")] Ref<AlEnum> severities,
        [NativeTypeName("ALsizei *")] Ref<int> lengths,
        [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
    );

    [return: NativeTypeName("ALuint")]
    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDebugMessageLogEXT")]
    uint GetDebugMessageLogExt(
        [NativeTypeName("ALuint")] uint count,
        [NativeTypeName("ALsizei")] int logBufSize,
        [NativeTypeName("ALenum *")] Ref<DebugSourceEXT> sources,
        [NativeTypeName("ALenum *")] Ref<DebugTypeEXT> types,
        [NativeTypeName("ALuint *")] Ref<uint> ids,
        [NativeTypeName("ALenum *")] Ref<DebugSeverityEXT> severities,
        [NativeTypeName("ALsizei *")] Ref<int> lengths,
        [NativeTypeName("ALchar *")] Ref<sbyte> logBuf
    );

    [return: NativeTypeName("ALdouble")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDouble")]
    double GetDouble([NativeTypeName("ALenum")] int param0);

    [return: NativeTypeName("ALdouble")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDouble")]
    double GetDouble([NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param0);

    [return: NativeTypeName("ALdouble")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
    double GetDoubleDirect(ContextHandle context, [NativeTypeName("ALenum")] int param1);

    [return: NativeTypeName("ALdouble")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDoubleDirect")]
    double GetDoubleDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param1
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    void GetDouble(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALdouble *")] double* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    void GetDouble(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param0,
        [NativeTypeName("ALdouble *")] Ref<double> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
    void GetDoubleDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALdouble *")] double* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDoublevDirect")]
    void GetDoubleDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param1,
        [NativeTypeName("ALdouble *")] Ref<double> values
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectf")]
    void GetEffectf(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* flValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEffectf")]
    void GetEffectf(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> flValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
    void GetEffectfDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* pflValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEffectfDirect")]
    void GetEffectfDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param2,
        [NativeTypeName("ALfloat *")] Ref<float> pflValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
    void GetEffectfv(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEffectfv")]
    void GetEffectfv(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
    void GetEffectfvDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEffectfvDirect")]
    void GetEffectfvDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectFloat> param2,
        [NativeTypeName("ALfloat *")] Ref<float> pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffecti")]
    void GetEffecti(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* iValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEffecti")]
    void GetEffecti(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param1,
        [NativeTypeName("ALint *")] Ref<int> iValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
    void GetEffectiDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* piValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEffectiDirect")]
    void GetEffectiDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param2,
        [NativeTypeName("ALint *")] Ref<int> piValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
    void GetEffectiv(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* piValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEffectiv")]
    void GetEffectiv(
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param1,
        [NativeTypeName("ALint *")] Ref<int> piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
    void GetEffectivDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEffectivDirect")]
    void GetEffectivDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effect,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EffectInteger> param2,
        [NativeTypeName("ALint *")] Ref<int> piValues
    );

    [return: NativeTypeName("ALenum")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
    int GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename);

    [return: NativeTypeName("ALenum")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
    int GetEnumValue([NativeTypeName("const ALchar *")] Ref<sbyte> ename);

    [return: NativeTypeName("ALenum")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
    int GetEnumValueDirect(ContextHandle context, [NativeTypeName("const ALchar *")] sbyte* ename);

    [return: NativeTypeName("ALenum")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEnumValueDirect")]
    int GetEnumValueDirect(
        ContextHandle context,
        [NativeTypeName("const ALchar *")] Ref<sbyte> ename
    );

    [return: NativeTypeName("ALenum")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    Constant<int, ErrorCode> GetError();

    [return: NativeTypeName("ALenum")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
    Constant<int, ErrorCode> GetErrorDirect(ContextHandle context);

    [return: NativeTypeName("ALenum")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetErrorDirect")]
    int GetErrorDirectRaw(ContextHandle context);

    [return: NativeTypeName("ALenum")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    int GetErrorRaw();

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilterf")]
    void GetFilterf(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* flValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFilterf")]
    void GetFilterf(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> flValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
    void GetFilterfDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* pflValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFilterfDirect")]
    void GetFilterfDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param2,
        [NativeTypeName("ALfloat *")] Ref<float> pflValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
    void GetFilterfv(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFilterfv")]
    void GetFilterfv(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
    void GetFilterfvDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* pflValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFilterfvDirect")]
    void GetFilterfvDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterFloat> param2,
        [NativeTypeName("ALfloat *")] Ref<float> pflValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilteri")]
    void GetFilteri(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* iValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFilteri")]
    void GetFilteri(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param1,
        [NativeTypeName("ALint *")] Ref<int> iValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
    void GetFilteriDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* piValue
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFilteriDirect")]
    void GetFilteriDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param2,
        [NativeTypeName("ALint *")] Ref<int> piValue
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
    void GetFilteriv(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* piValues
    );

    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFilteriv")]
    void GetFilteriv(
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param1,
        [NativeTypeName("ALint *")] Ref<int> piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
    void GetFilterivDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* piValues
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFilterivDirect")]
    void GetFilterivDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint filter,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FilterInteger> param2,
        [NativeTypeName("ALint *")] Ref<int> piValues
    );

    [return: NativeTypeName("ALfloat")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloat")]
    float GetFloat([NativeTypeName("ALenum")] int param0);

    [return: NativeTypeName("ALfloat")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFloat")]
    float GetFloat([NativeTypeName("ALenum")] Constant<int, AlEnum, FloatPName> param0);

    [return: NativeTypeName("ALfloat")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
    float GetFloatDirect(ContextHandle context, [NativeTypeName("ALenum")] int param1);

    [return: NativeTypeName("ALfloat")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFloatDirect")]
    float GetFloatDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, FloatPName> param1
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    void GetFloat(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    void GetFloat(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
    void GetFloatDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFloatvDirect")]
    void GetFloatDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, GetPName> param1,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [return: NativeTypeName("ALint")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetInteger")]
    int GetInteger([NativeTypeName("ALenum")] int param0);

    [return: NativeTypeName("ALint")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetInteger")]
    int GetInteger([NativeTypeName("ALenum")] Constant<int, AlEnum, IntegerPName> param0);

    [return: NativeTypeName("ALint")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
    int GetIntegerDirect(ContextHandle context, [NativeTypeName("ALenum")] int param1);

    [return: NativeTypeName("ALint")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetIntegerDirect")]
    int GetIntegerDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, IntegerPName> param1
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    void GetInteger([NativeTypeName("ALenum")] int param0, [NativeTypeName("ALint *")] int* values);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    void GetInteger(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, IntegerPName> param0,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
    void GetIntegerDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetIntegervDirect")]
    void GetIntegerDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, IntegerPName> param1,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    void GetListener3(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    void GetListener3(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat3> param0,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
    void GetListener3Direct(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListener3fDirect")]
    void GetListener3Direct(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat3> param1,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    void GetListener3(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    void GetListener3(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerInteger3> param0,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
    void GetListener3Direct(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListener3iDirect")]
    void GetListener3Direct(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerInteger3> param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    void GetListenerf(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    void GetListenerf(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param0,
        [NativeTypeName("ALfloat *")] Ref<float> value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
    void GetListenerfDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerfDirect")]
    void GetListenerfDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    void GetListenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    void GetListenerfv(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
    void GetListenerfvDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerfvDirect")]
    void GetListenerfvDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    void GetListeneri(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    void GetListeneri(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    int GetListeneri();

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
    void GetListeneriDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneriDirect")]
    void GetListeneriDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    void GetListeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    void GetListeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    int GetListeneriv();

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
    void GetListenerivDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerivDirect")]
    void GetListenerivDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
    void GetObjectLabelDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] int identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("ALsizei")] int bufSize,
        [NativeTypeName("ALsizei *")] int* length,
        [NativeTypeName("ALchar *")] sbyte* label
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
    void GetObjectLabelDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("ALsizei")] int bufSize,
        [NativeTypeName("ALsizei *")] Ref<int> length,
        [NativeTypeName("ALchar *")] Ref<sbyte> label
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelDirectEXT")]
    sbyte GetObjectLabelDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("ALsizei *")] Ref<int> length
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
    void GetObjectLabelExt(
        [NativeTypeName("ALenum")] int identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("ALsizei")] int bufSize,
        [NativeTypeName("ALsizei *")] int* length,
        [NativeTypeName("ALchar *")] sbyte* label
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
    void GetObjectLabelExt(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("ALsizei")] int bufSize,
        [NativeTypeName("ALsizei *")] Ref<int> length,
        [NativeTypeName("ALchar *")] Ref<sbyte> label
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetObjectLabelEXT")]
    sbyte GetObjectLabelExt(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("ALsizei *")] Ref<int> length
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
    void* GetPointerDirectExt(ContextHandle context, [NativeTypeName("ALenum")] int pname);

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectEXT")]
    Ptr GetPointerDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectSOFT")]
    void* GetPointerDirectSoft(ContextHandle context, [NativeTypeName("ALenum")] int pname);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetPointerDirectSOFT")]
    Ptr GetPointerDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
    void* GetPointerExt([NativeTypeName("ALenum")] int pname);

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetPointerEXT")]
    Ptr GetPointerExt([NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname);

    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
    void* GetPointerSoft([NativeTypeName("ALenum")] int pname);

    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetPointerSOFT")]
    Ptr GetPointerSoft([NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname);

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
    void GetPointerDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] int pname,
        void** values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectEXT")]
    void GetPointerDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname,
        Ref2D values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectSOFT")]
    void GetPointerDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALenum")] int pname,
        void** values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_SOFT_events"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetPointervDirectSOFT")]
    void GetPointerDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname,
        Ref2D values
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
    void GetPointerExt([NativeTypeName("ALenum")] int pname, void** values);

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetPointervEXT")]
    void GetPointerExt(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname,
        Ref2D values
    );

    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
    void GetPointerSoft([NativeTypeName("ALenum")] int pname, void** values);

    [SupportedApiProfile("al", ["AL_SOFT_events"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetPointervSOFT")]
    void GetPointerSoft(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, PointerPName> pname,
        Ref2D values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
    void* GetProcAddressDirect(
        ContextHandle context,
        [NativeTypeName("const ALchar *")] sbyte* fname
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetProcAddressDirect")]
    Ptr GetProcAddressDirect(
        ContextHandle context,
        [NativeTypeName("const ALchar *")] Ref<sbyte> fname
    );

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
    void GetSource3DirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALdouble *")] double* value1,
        [NativeTypeName("ALdouble *")] double* value2,
        [NativeTypeName("ALdouble *")] double* value3
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3dDirectSOFT")]
    void GetSource3DirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALdouble *")] Ref<double> value1,
        [NativeTypeName("ALdouble *")] Ref<double> value2,
        [NativeTypeName("ALdouble *")] Ref<double> value3
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
    void GetSource3Soft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALdouble *")] double* value1,
        [NativeTypeName("ALdouble *")] double* value2,
        [NativeTypeName("ALdouble *")] double* value3
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3dSOFT")]
    void GetSource3Soft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALdouble *")] Ref<double> value1,
        [NativeTypeName("ALdouble *")] Ref<double> value2,
        [NativeTypeName("ALdouble *")] Ref<double> value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    void GetSource3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    void GetSource3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat3> param1,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
    void GetSource3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3fDirect")]
    void GetSource3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat3> param2,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    void GetSource3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    void GetSource3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    );

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
    void GetSource3DirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint64SOFT *")] nint* value1,
        [NativeTypeName("ALint64SOFT *")] nint* value2,
        [NativeTypeName("ALint64SOFT *")] nint* value3
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3i64DirectSOFT")]
    void GetSource3DirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param2,
        [NativeTypeName("ALint64SOFT *")] Ref<nint> value1,
        [NativeTypeName("ALint64SOFT *")] Ref<nint> value2,
        [NativeTypeName("ALint64SOFT *")] Ref<nint> value3
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
    void GetSource3Soft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint64SOFT *")] nint* value1,
        [NativeTypeName("ALint64SOFT *")] nint* value2,
        [NativeTypeName("ALint64SOFT *")] nint* value3
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3i64SOFT")]
    void GetSource3Soft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param1,
        [NativeTypeName("ALint64SOFT *")] Ref<nint> value1,
        [NativeTypeName("ALint64SOFT *")] Ref<nint> value2,
        [NativeTypeName("ALint64SOFT *")] Ref<nint> value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
    void GetSource3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3iDirect")]
    void GetSource3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param2,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    );

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
    void GetSourceDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALdouble *")] double* value
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcedDirectSOFT")]
    void GetSourceDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param2,
        [NativeTypeName("ALdouble *")] Ref<double> value
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
    void GetSourceSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALdouble *")] double* value
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcedSOFT")]
    void GetSourceSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param1,
        [NativeTypeName("ALdouble *")] Ref<double> value
    );

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
    void GetSourcedvDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALdouble *")] double* values
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcedvDirectSOFT")]
    void GetSourcedvDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param2,
        [NativeTypeName("ALdouble *")] Ref<double> values
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
    void GetSourcedvSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALdouble *")] double* values
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcedvSOFT")]
    void GetSourcedvSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param1,
        [NativeTypeName("ALdouble *")] Ref<double> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcef")]
    void GetSourcef(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcef")]
    void GetSourcef(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
    void GetSourcefDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcefDirect")]
    void GetSourcefDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param2,
        [NativeTypeName("ALfloat *")] Ref<float> value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
    void GetSourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
    void GetSourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param1,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
    void GetSourcefvDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat *")] float* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcefvDirect")]
    void GetSourcefvDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param2,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourcei")]
    void GetSourcei(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcei")]
    void GetSourcei(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeTypeName("ALint *")] Ref<int> value
    );

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
    void GetSourcei64DirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint64SOFT *")] nint* value
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64DirectSOFT")]
    void GetSourcei64DirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeTypeName("ALint64SOFT *")] Ref<nint> value
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
    void GetSourcei64Soft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint64SOFT *")] nint* value
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64SOFT")]
    void GetSourcei64Soft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeTypeName("ALint64SOFT *")] Ref<nint> value
    );

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
    void GetSourcei64VDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint64SOFT *")] nint* values
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64vDirectSOFT")]
    void GetSourcei64VDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeTypeName("ALint64SOFT *")] Ref<nint> values
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
    void GetSourcei64VSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint64SOFT *")] nint* values
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcei64vSOFT")]
    void GetSourcei64VSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeTypeName("ALint64SOFT *")] Ref<nint> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
    void GetSourceiDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourceiDirect")]
    void GetSourceiDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeTypeName("ALint *")] Ref<int> value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
    void GetSourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
    void GetSourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
    void GetSourceivDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint *")] int* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourceivDirect")]
    void GetSourceivDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [return: NativeTypeName("const ALchar *")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    sbyte* GetString([NativeTypeName("ALenum")] int param0);

    [return: NativeTypeName("const ALchar *")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    Ptr<sbyte> GetString([NativeTypeName("ALenum")] Constant<int, AlEnum, StringPName> param0);

    [return: NativeTypeName("const ALchar *")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
    sbyte* GetStringDirect(ContextHandle context, [NativeTypeName("ALenum")] int param1);

    [return: NativeTypeName("const ALchar *")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetStringDirect")]
    Ptr<sbyte> GetStringDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, StringPName> param1
    );

    [return: NativeTypeName("const ALchar *")]
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
    sbyte* GetStringDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALenum")] int pname,
        [NativeTypeName("ALsizei")] int index
    );

    [return: NativeTypeName("const ALchar *")]
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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetStringiDirectSOFT")]
    Ptr<sbyte> GetStringDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, StringPName> pname,
        [NativeTypeName("ALsizei")] int index
    );

    [return: NativeTypeName("const ALchar *")]
    [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
    [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
    sbyte* GetStringSoft(
        [NativeTypeName("ALenum")] int pname,
        [NativeTypeName("ALsizei")] int index
    );

    [return: NativeTypeName("const ALchar *")]
    [SupportedApiProfile("al", ["AL_SOFT_source_resampler"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetStringiSOFT")]
    Ptr<sbyte> GetStringSoft(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, StringPName> pname,
        [NativeTypeName("ALsizei")] int index
    );

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
    MaybeBool<sbyte> IsAuxiliaryEffectSlot([NativeTypeName("ALuint")] uint effectslot);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
    MaybeBool<sbyte> IsAuxiliaryEffectSlotDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot
    );

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlotDirect")]
    sbyte IsAuxiliaryEffectSlotDirectRaw(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint effectslot
    );

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsAuxiliaryEffectSlot")]
    sbyte IsAuxiliaryEffectSlotRaw([NativeTypeName("ALuint")] uint effectslot);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
    MaybeBool<sbyte> IsBufferDirect(ContextHandle context, [NativeTypeName("ALuint")] uint buffer);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsBufferDirect")]
    sbyte IsBufferDirectRaw(ContextHandle context, [NativeTypeName("ALuint")] uint buffer);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
    MaybeBool<sbyte> IsBufferFormatSupportedSoft([NativeTypeName("ALenum")] int format);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_SOFT_buffer_samples"])]
    [NativeFunction("openal", EntryPoint = "alIsBufferFormatSupportedSOFT")]
    sbyte IsBufferFormatSupportedSoftRaw([NativeTypeName("ALenum")] int format);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsEffect")]
    MaybeBool<sbyte> IsEffect([NativeTypeName("ALuint")] uint effect);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
    MaybeBool<sbyte> IsEffectDirect(ContextHandle context, [NativeTypeName("ALuint")] uint effect);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsEffectDirect")]
    sbyte IsEffectDirectRaw(ContextHandle context, [NativeTypeName("ALuint")] uint effect);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsEffect")]
    sbyte IsEffectRaw([NativeTypeName("ALuint")] uint effect);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    sbyte IsEnabled([NativeTypeName("ALenum")] int capability);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    MaybeBool<sbyte> IsEnabled(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability
    );

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
    sbyte IsEnabledDirect(ContextHandle context, [NativeTypeName("ALenum")] int capability);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsEnabledDirect")]
    MaybeBool<sbyte> IsEnabledDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, EnableCap> capability
    );

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
    sbyte IsExtensionPresent([NativeTypeName("const ALchar *")] sbyte* extname);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
    MaybeBool<sbyte> IsExtensionPresent([NativeTypeName("const ALchar *")] Ref<sbyte> extname);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
    sbyte IsExtensionPresentDirect(
        ContextHandle context,
        [NativeTypeName("const ALchar *")] sbyte* extname
    );

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresentDirect")]
    MaybeBool<sbyte> IsExtensionPresentDirect(
        ContextHandle context,
        [NativeTypeName("const ALchar *")] Ref<sbyte> extname
    );

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsFilter")]
    MaybeBool<sbyte> IsFilter([NativeTypeName("ALuint")] uint filter);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
    MaybeBool<sbyte> IsFilterDirect(ContextHandle context, [NativeTypeName("ALuint")] uint filter);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "ALC_EXT_EFX"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alIsFilterDirect")]
    sbyte IsFilterDirectRaw(ContextHandle context, [NativeTypeName("ALuint")] uint filter);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["ALC_EXT_EFX"]), SupportedApiProfile("alc", ["ALC_EXT_EFX"])]
    [NativeFunction("openal", EntryPoint = "alIsFilter")]
    sbyte IsFilterRaw([NativeTypeName("ALuint")] uint filter);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
    MaybeBool<sbyte> IsSourceDirect(ContextHandle context, [NativeTypeName("ALuint")] uint source);

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alIsSourceDirect")]
    sbyte IsSourceDirectRaw(ContextHandle context, [NativeTypeName("ALuint")] uint source);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3f")]
    void Listener3(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListener3f")]
    void Listener3(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat3> param0,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
    void Listener3Direct(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListener3fDirect")]
    void Listener3Direct(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat3> param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3i")]
    void Listener3(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListener3i")]
    void Listener3(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerInteger3> param0,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
    void Listener3Direct(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListener3iDirect")]
    void Listener3Direct(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerInteger3> param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerf")]
    void Listener([NativeTypeName("ALenum")] int param0, [NativeTypeName("ALfloat")] float value);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListenerf")]
    void Listener(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param0,
        [NativeTypeName("ALfloat")] float value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
    void ListenerDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListenerfDirect")]
    void ListenerDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param1,
        [NativeTypeName("ALfloat")] float value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    void Listener(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALfloat *")] float* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    void Listener(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param0,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
    void ListenerDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListenerfvDirect")]
    void ListenerDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ListenerFloat> param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListeneri")]
    void Listener([NativeTypeName("ALenum")] int param0, [NativeTypeName("ALint")] int value);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListeneriDirect")]
    void ListenerDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    void Listener(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALint *")] int* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    void Listener(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALint *")] Ref<int> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
    void ListenerDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListenerivDirect")]
    void ListenerDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
    void ObjectLabelDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] int identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] sbyte* label
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
    void ObjectLabelDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] Ref<sbyte> label
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alObjectLabelDirectEXT")]
    void ObjectLabelDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("const ALchar *")] sbyte label
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
    void ObjectLabelExt(
        [NativeTypeName("ALenum")] int identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] sbyte* label
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
    void ObjectLabelExt(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] Ref<sbyte> label
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alObjectLabelEXT")]
    void ObjectLabelExt(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, ObjectIdentifier> identifier,
        [NativeTypeName("ALuint")] uint name,
        [NativeTypeName("const ALchar *")] sbyte label
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alPopDebugGroupDirectEXT")]
    void PopDebugGroupDirectExt(ContextHandle context);

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alPopDebugGroupEXT")]
    void PopDebugGroupExt();

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
    void ProcessUpdatesDirectSoft(ContextHandle context);

    [SupportedApiProfile("al", ["AL_SOFT_deferred_updates"])]
    [NativeFunction("openal", EntryPoint = "alProcessUpdatesSOFT")]
    void ProcessUpdatesSoft();

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
    void PushDebugGroupDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] int source,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] sbyte* message
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
    void PushDebugGroupDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] Ref<sbyte> message
    );

    [
        SupportedApiProfile("al", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_debug", "AL_EXT_direct_context"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupDirectEXT")]
    void PushDebugGroupDirectExt(
        ContextHandle context,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("const ALchar *")] sbyte message
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
    void PushDebugGroupExt(
        [NativeTypeName("ALenum")] int source,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] sbyte* message
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
    void PushDebugGroupExt(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("const ALchar *")] Ref<sbyte> message
    );

    [SupportedApiProfile("al", ["AL_EXT_debug"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alPushDebugGroupEXT")]
    void PushDebugGroupExt(
        [NativeTypeName("ALenum")] Constant<int, AlEnum, DebugSourceEXT> source,
        [NativeTypeName("ALuint")] uint id,
        [NativeTypeName("const ALchar *")] sbyte message
    );

    [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
    void RequestFoldbackStart(
        [NativeTypeName("ALenum")] int mode,
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("ALfloat *")] float* mem,
        [NativeTypeName("LPALFOLDBACKCALLBACK")] FoldbackCallback callback
    );

    [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStart")]
    void RequestFoldbackStart(
        [NativeTypeName("ALenum")] int mode,
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("ALfloat *")] Ref<float> mem,
        [NativeTypeName("LPALFOLDBACKCALLBACK")] FoldbackCallback callback
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStartDirect")]
    void RequestFoldbackStartDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int mode,
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("ALfloat *")] float* mem,
        [NativeTypeName("LPALFOLDBACKCALLBACK")] FoldbackCallback callback
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true)
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStartDirect")]
    void RequestFoldbackStartDirect(
        ContextHandle context,
        [NativeTypeName("ALenum")] int mode,
        [NativeTypeName("ALsizei")] int count,
        [NativeTypeName("ALsizei")] int length,
        [NativeTypeName("ALfloat *")] Ref<float> mem,
        [NativeTypeName("LPALFOLDBACKCALLBACK")] FoldbackCallback callback
    );

    [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStop")]
    void RequestFoldbackStop();

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true),
        SupportedApiProfile("alc", ["AL_EXT_direct_context", "AL_EXT_FOLDBACK"], RequireAll = true)
    ]
    [NativeFunction("openal", EntryPoint = "alRequestFoldbackStopDirect")]
    void RequestFoldbackStopDirect(ContextHandle context);

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
    void Source3DirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALdouble")] double value1,
        [NativeTypeName("ALdouble")] double value2,
        [NativeTypeName("ALdouble")] double value3
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSource3dSOFT")]
    void Source3Soft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALdouble")] double value1,
        [NativeTypeName("ALdouble")] double value2,
        [NativeTypeName("ALdouble")] double value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3f")]
    void Source3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSource3f")]
    void Source3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat3> param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
    void Source3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSource3fDirect")]
    void Source3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat3> param2,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3i")]
    void Source3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSource3i")]
    void Source3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

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
    void Source3DirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint64SOFT")] nint value1,
        [NativeTypeName("ALint64SOFT")] nint value2,
        [NativeTypeName("ALint64SOFT")] nint value3
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSource3i64DirectSOFT")]
    void Source3DirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param2,
        [NativeTypeName("ALint64SOFT")] nint value1,
        [NativeTypeName("ALint64SOFT")] nint value2,
        [NativeTypeName("ALint64SOFT")] nint value3
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
    void Source3Soft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint64SOFT")] nint value1,
        [NativeTypeName("ALint64SOFT")] nint value2,
        [NativeTypeName("ALint64SOFT")] nint value3
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSource3i64SOFT")]
    void Source3Soft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param1,
        [NativeTypeName("ALint64SOFT")] nint value1,
        [NativeTypeName("ALint64SOFT")] nint value2,
        [NativeTypeName("ALint64SOFT")] nint value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
    void Source3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSource3iDirect")]
    void Source3Direct(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger3> param2,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

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
    void SourceDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALdouble")] double value
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcedDirectSOFT")]
    void SourceDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param2,
        [NativeTypeName("ALdouble")] double value
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
    void SourceSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALdouble")] double value
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcedSOFT")]
    void SourceSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param1,
        [NativeTypeName("ALdouble")] double value
    );

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
    void SourceDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALdouble *")] double* values
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcedvDirectSOFT")]
    void SourceDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param2,
        [NativeTypeName("const ALdouble *")] Ref<double> values
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
    void SourceSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALdouble *")] double* values
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcedvSOFT")]
    void SourceSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceDouble> param1,
        [NativeTypeName("const ALdouble *")] Ref<double> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcef")]
    void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcef")]
    void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param1,
        [NativeTypeName("ALfloat")] float value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
    void SourceDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALfloat")] float value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcefDirect")]
    void SourceDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param2,
        [NativeTypeName("ALfloat")] float value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
    void SourceDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALfloat *")] float* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcefvDirect")]
    void SourceDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceFloat> param2,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcei")]
    void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcei")]
    void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeTypeName("ALint")] int value
    );

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
    void SourceDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint64SOFT")] nint value
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcei64DirectSOFT")]
    void SourceDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeTypeName("ALint64SOFT")] nint value
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
    void SourceSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint64SOFT")] nint value
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcei64SOFT")]
    void SourceSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeTypeName("ALint64SOFT")] nint value
    );

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
    void SourceDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALint64SOFT *")] nint* values
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcei64vDirectSOFT")]
    void SourceDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeTypeName("const ALint64SOFT *")] Ref<nint> values
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
    void SourceSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint64SOFT *")] nint* values
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_latency"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcei64vSOFT")]
    void SourceSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeTypeName("const ALint64SOFT *")] Ref<nint> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
    void SourceDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("ALint")] int value
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceiDirect")]
    void SourceDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeTypeName("ALint")] int value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
    void SourceDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param2,
        [NativeTypeName("const ALint *")] int* values
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceivDirect")]
    void SourceDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] Constant<int, AlEnum, SourceInteger> param2,
        [NativeTypeName("const ALint *")] Ref<int> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePause")]
    void SourcePause([NativeTypeName("ALuint")] uint source);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePauseDirect")]
    void SourcePauseDirect(ContextHandle context, [NativeTypeName("ALuint")] uint source);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    void SourcePausev(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    void SourcePausev(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    void SourcePausev([NativeTypeName("const ALuint *")] uint sources);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
    void SourcePausevDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
    void SourcePausevDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePausevDirect")]
    void SourcePausevDirect(ContextHandle context, [NativeTypeName("const ALuint *")] uint sources);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePlay")]
    void SourcePlay([NativeTypeName("ALuint")] uint source);

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
    void SourcePlayAtTimeDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALint64SOFT")] nint start_time
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimeSOFT")]
    void SourcePlayAtTimeSoft(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALint64SOFT")] nint start_time
    );

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
    void SourcePlayAtTimevDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources,
        [NativeTypeName("ALint64SOFT")] nint start_time
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevDirectSOFT")]
    void SourcePlayAtTimevDirectSoft(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources,
        [NativeTypeName("ALint64SOFT")] nint start_time
    );

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
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevDirectSOFT")]
    void SourcePlayAtTimevDirectSoft(
        ContextHandle context,
        [NativeTypeName("const ALuint *")] uint sources,
        [NativeTypeName("ALint64SOFT")] nint start_time
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
    void SourcePlayAtTimevSoft(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources,
        [NativeTypeName("ALint64SOFT")] nint start_time
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
    void SourcePlayAtTimevSoft(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources,
        [NativeTypeName("ALint64SOFT")] nint start_time
    );

    [SupportedApiProfile("al", ["AL_SOFT_source_start_delay"])]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayAtTimevSOFT")]
    void SourcePlayAtTimevSoft(
        [NativeTypeName("const ALuint *")] uint sources,
        [NativeTypeName("ALint64SOFT")] nint start_time
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayDirect")]
    void SourcePlayDirect(ContextHandle context, [NativeTypeName("ALuint")] uint source);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    void SourcePlayv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    void SourcePlayv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    void SourcePlayv([NativeTypeName("const ALuint *")] uint sources);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
    void SourcePlayvDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
    void SourcePlayvDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayvDirect")]
    void SourcePlayvDirect(ContextHandle context, [NativeTypeName("const ALuint *")] uint sources);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
    void SourceQueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("const ALuint *")] uint* buffers
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
    void SourceQueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
    void SourceQueueBuffersDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("const ALuint *")] uint* buffers
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffersDirect")]
    void SourceQueueBuffersDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewind")]
    void SourceRewind([NativeTypeName("ALuint")] uint source);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceRewindDirect")]
    void SourceRewindDirect(ContextHandle context, [NativeTypeName("ALuint")] uint source);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewin(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewin(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewin([NativeTypeName("const ALuint *")] uint sources);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
    void SourceRewinDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
    void SourceRewinDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceRewindvDirect")]
    void SourceRewinDirect(ContextHandle context, [NativeTypeName("const ALuint *")] uint sources);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceStop")]
    void SourceStop([NativeTypeName("ALuint")] uint source);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceStopDirect")]
    void SourceStopDirect(ContextHandle context, [NativeTypeName("ALuint")] uint source);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    void SourceStopv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    void SourceStopv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    void SourceStopv([NativeTypeName("const ALuint *")] uint sources);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
    void SourceStopvDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
    void SourceStopvDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceStopvDirect")]
    void SourceStopvDirect(ContextHandle context, [NativeTypeName("const ALuint *")] uint sources);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
    void SourceUnqueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("ALuint *")] uint* buffers
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
    void SourceUnqueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("ALuint *")] Ref<uint> buffers
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
    void SourceUnqueueBuffersDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("ALuint *")] uint* buffers
    );

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffersDirect")]
    void SourceUnqueueBuffersDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("ALuint *")] Ref<uint> buffers
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
    void SpeedOfSound([NativeTypeName("ALfloat")] float value);

    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "alSpeedOfSoundDirect")]
    void SpeedOfSoundDirect(ContextHandle context, [NativeTypeName("ALfloat")] float value);

    [return: NativeTypeName("ALenum")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
    int EaxGetBufferModeDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALint *")] int* pReserved
    );

    [return: NativeTypeName("ALenum")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "EAXGetBufferModeDirect")]
    int EaxGetBufferModeDirect(
        ContextHandle context,
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALint *")] Ref<int> pReserved
    );

    [return: NativeTypeName("ALenum")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
    int EaxGetDirect(
        ContextHandle context,
        [NativeTypeName("const struct _GUID *")] System.Guid* property_set_id,
        [NativeTypeName("ALuint")] uint property_id,
        [NativeTypeName("ALuint")] uint source_id,
        [NativeTypeName("ALvoid *")] void* value,
        [NativeTypeName("ALuint")] uint value_size
    );

    [return: NativeTypeName("ALenum")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "EAXGetDirect")]
    int EaxGetDirect(
        ContextHandle context,
        [NativeTypeName("const struct _GUID *")] Ref<System.Guid> property_set_id,
        [NativeTypeName("ALuint")] uint property_id,
        [NativeTypeName("ALuint")] uint source_id,
        [NativeTypeName("ALvoid *")] Ref value,
        [NativeTypeName("ALuint")] uint value_size
    );

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
    sbyte EaxSetBufferModeDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* buffers,
        [NativeTypeName("ALint")] int value
    );

    [return: NativeTypeName("ALboolean")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "EAXSetBufferModeDirect")]
    MaybeBool<sbyte> EaxSetBufferModeDirect(
        ContextHandle context,
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers,
        [NativeTypeName("ALint")] int value
    );

    [return: NativeTypeName("ALenum")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
    int EaxSetDirect(
        ContextHandle context,
        [NativeTypeName("const struct _GUID *")] System.Guid* property_set_id,
        [NativeTypeName("ALuint")] uint property_id,
        [NativeTypeName("ALuint")] uint source_id,
        [NativeTypeName("ALvoid *")] void* value,
        [NativeTypeName("ALuint")] uint value_size
    );

    [return: NativeTypeName("ALenum")]
    [
        SupportedApiProfile("al", ["AL_EXT_direct_context"]),
        SupportedApiProfile("alc", ["AL_EXT_direct_context"])
    ]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "EAXSetDirect")]
    int EaxSetDirect(
        ContextHandle context,
        [NativeTypeName("const struct _GUID *")] Ref<System.Guid> property_set_id,
        [NativeTypeName("ALuint")] uint property_id,
        [NativeTypeName("ALuint")] uint source_id,
        [NativeTypeName("ALvoid *")] Ref value,
        [NativeTypeName("ALuint")] uint value_size
    );
}
