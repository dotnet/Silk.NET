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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBuffer3f")]
        static abstract void Buffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] Constant<int, ALEnum, Format> format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferf")]
        static abstract void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        static abstract void Disable([NativeTypeName("ALenum")] int capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        static abstract void Disable(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        static abstract void DistanceModel([NativeTypeName("ALenum")] int distanceModel);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        static abstract void DistanceModel(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, DistanceModel> distanceModel
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
        static abstract void DopplerFactor([NativeTypeName("ALfloat")] float value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
        static abstract void DopplerVelocity([NativeTypeName("ALfloat")] float value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        static abstract void Enable([NativeTypeName("ALenum")] int capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        static abstract void Enable(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
        );

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

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        static abstract MaybeBool<sbyte> GetBoolean([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        static abstract sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0);

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
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] Ref<sbyte> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        static abstract sbyte GetBoolean();

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
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [return: NativeTypeName("ALdouble")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        static abstract double GetDouble([NativeTypeName("ALenum")] int param0);

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
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] Ref<double> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        static abstract double GetDouble();

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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        static abstract Constant<int, ErrorCode> GetError();

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        static abstract int GetErrorRaw();

        [return: NativeTypeName("ALfloat")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        static abstract float GetFloat([NativeTypeName("ALenum")] int param0);

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
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        static abstract float GetFloat();

        [return: NativeTypeName("ALint")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        static abstract int GetInteger([NativeTypeName("ALenum")] int param0);

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
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        static abstract int GetInteger();

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
            [NativeTypeName("ALenum")] int param0,
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
            [NativeTypeName("ALenum")] int param0,
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
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        static abstract float GetListenerf();

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
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        static abstract float GetListenerfv();

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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        static abstract void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        static abstract Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname);

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
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
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
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [return: NativeTypeName("const ALchar *")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        static abstract Ptr<sbyte> GetString([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("const ALchar *")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        static abstract sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        static abstract MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        static abstract sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        static abstract sbyte IsEnabled([NativeTypeName("ALenum")] int capability);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        static abstract MaybeBool<sbyte> IsEnabled(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        static abstract MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source);

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
        [NativeFunction("openal", EntryPoint = "alListener3i")]
        static abstract void Listener3(
            [NativeTypeName("ALenum")] int param0,
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
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        static abstract void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        static abstract void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneri")]
        static abstract void Listener(
            [NativeTypeName("ALenum")] int param0,
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
        [NativeFunction("openal", EntryPoint = "alSource3i")]
        static abstract void Source3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcef")]
        static abstract void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] int param1,
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
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePause")]
        static abstract void SourcePause([NativeTypeName("ALuint")] uint source);

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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlay")]
        static abstract void SourcePlay([NativeTypeName("ALuint")] uint source);

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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewind")]
        static abstract void SourceRewin([NativeTypeName("ALuint")] uint source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewindv([NativeTypeName("const ALuint *")] uint sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStop")]
        static abstract void SourceStop([NativeTypeName("ALuint")] uint source);

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

        [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
        static abstract void SpeedOfSound([NativeTypeName("ALfloat")] float value);
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBuffer3f")]
    void Buffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] Constant<int, ALEnum, Format> format,
        [NativeTypeName("const ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferf")]
    void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDisable")]
    void Disable([NativeTypeName("ALenum")] int capability);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDisable")]
    void Disable([NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    void DistanceModel([NativeTypeName("ALenum")] int distanceModel);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    void DistanceModel(
        [NativeTypeName("ALenum")] Constant<int, ALEnum, DistanceModel> distanceModel
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
    void DopplerFactor([NativeTypeName("ALfloat")] float value);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
    void DopplerVelocity([NativeTypeName("ALfloat")] float value);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alEnable")]
    void Enable([NativeTypeName("ALenum")] int capability);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEnable")]
    void Enable([NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability);

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

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    MaybeBool<sbyte> GetBoolean([NativeTypeName("ALenum")] int param0);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0);

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
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALboolean *")] Ref<sbyte> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    sbyte GetBoolean();

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
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [return: NativeTypeName("ALdouble")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDouble")]
    double GetDouble([NativeTypeName("ALenum")] int param0);

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
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALdouble *")] Ref<double> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    double GetDouble();

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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    Constant<int, ErrorCode> GetError();

    [return: NativeTypeName("ALenum")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    int GetErrorRaw();

    [return: NativeTypeName("ALfloat")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloat")]
    float GetFloat([NativeTypeName("ALenum")] int param0);

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
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    float GetFloat();

    [return: NativeTypeName("ALint")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetInteger")]
    int GetInteger([NativeTypeName("ALenum")] int param0);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    void GetInteger([NativeTypeName("ALenum")] int param0, [NativeTypeName("ALint *")] int* values);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    void GetInteger(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    int GetInteger();

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
        [NativeTypeName("ALenum")] int param0,
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
        [NativeTypeName("ALenum")] int param0,
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
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> value
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    float GetListenerf();

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
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    float GetListenerfv();

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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname);

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
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
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
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [return: NativeTypeName("const ALchar *")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    Ptr<sbyte> GetString([NativeTypeName("ALenum")] int param0);

    [return: NativeTypeName("const ALchar *")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    sbyte IsEnabled([NativeTypeName("ALenum")] int capability);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    MaybeBool<sbyte> IsEnabled(
        [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source);

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
    [NativeFunction("openal", EntryPoint = "alListener3i")]
    void Listener3(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerf")]
    void Listener([NativeTypeName("ALenum")] int param0, [NativeTypeName("ALfloat")] float value);

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
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListeneri")]
    void Listener([NativeTypeName("ALenum")] int param0, [NativeTypeName("ALint")] int value);

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
    [NativeFunction("openal", EntryPoint = "alSource3i")]
    void Source3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcef")]
    void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] int param1,
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
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePause")]
    void SourcePause([NativeTypeName("ALuint")] uint source);

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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcePlay")]
    void SourcePlay([NativeTypeName("ALuint")] uint source);

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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewind")]
    void SourceRewin([NativeTypeName("ALuint")] uint source);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewindv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewindv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewindv([NativeTypeName("const ALuint *")] uint sources);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceStop")]
    void SourceStop([NativeTypeName("ALuint")] uint source);

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

    [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
    void SpeedOfSound([NativeTypeName("ALfloat")] float value);
}
