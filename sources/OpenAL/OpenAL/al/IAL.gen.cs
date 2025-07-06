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
        [NativeFunction("openal", EntryPoint = "alBuffer3f")]
        static abstract void Buffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [NativeFunction("openal", EntryPoint = "alBuffer3i")]
        static abstract void Buffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [NativeFunction("openal", EntryPoint = "alBufferData")]
        static abstract void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] void* data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        static abstract void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        );

        [NativeFunction("openal", EntryPoint = "alBufferf")]
        static abstract void Bufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        );

        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        static abstract void Bufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        static abstract void Bufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        );

        [NativeFunction("openal", EntryPoint = "alBufferi")]
        static abstract void Bufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        );

        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        static abstract void Bufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        static abstract void Bufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers);

        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* buffers
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        static abstract void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSource([NativeTypeName("const ALuint *")] uint sources);

        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        static abstract void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [NativeFunction("openal", EntryPoint = "alDisable")]
        static abstract void Disable([NativeTypeName("ALenum")] int capability);

        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        static abstract void DistanceModel([NativeTypeName("ALenum")] int distanceModel);

        [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
        static abstract void DopplerFactor([NativeTypeName("ALfloat")] float value);

        [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
        static abstract void DopplerVelocity([NativeTypeName("ALfloat")] float value);

        [NativeFunction("openal", EntryPoint = "alEnable")]
        static abstract void Enable([NativeTypeName("ALenum")] int capability);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract uint GenBuffer();

        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* buffers
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        static abstract void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract uint GenSource();

        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        static abstract void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> sources
        );

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        static abstract MaybeBool<sbyte> GetBoolean([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        static abstract sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0);

        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        static abstract void GetBooleanv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] sbyte* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        static abstract void GetBooleanv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] Ref<sbyte> values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        static abstract sbyte GetBooleanv();

        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        static abstract void GetBuffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        static abstract void GetBuffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        );

        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        static abstract void GetBuffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        static abstract void GetBuffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        );

        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        static abstract void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        static abstract void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value
        );

        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        static abstract void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        static abstract void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        static abstract void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        static abstract void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value
        );

        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        static abstract void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        static abstract void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [return: NativeTypeName("ALdouble")]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        static abstract double GetDouble([NativeTypeName("ALenum")] int param0);

        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        static abstract void GetDoublev(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] double* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        static abstract void GetDoublev(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] Ref<double> values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        static abstract double GetDoublev();

        [return: NativeTypeName("ALenum")]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        static abstract int GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename);

        [return: NativeTypeName("ALenum")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        static abstract int GetEnumValue([NativeTypeName("const ALchar *")] Ref<sbyte> ename);

        [return: NativeTypeName("ALenum")]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        static abstract int GetError();

        [return: NativeTypeName("ALfloat")]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        static abstract float GetFloat([NativeTypeName("ALenum")] int param0);

        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        static abstract void GetFloatv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        static abstract void GetFloatv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        static abstract float GetFloatv();

        [return: NativeTypeName("ALint")]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        static abstract int GetInteger([NativeTypeName("ALenum")] int param0);

        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        static abstract void GetIntegerv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        static abstract void GetIntegerv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        static abstract int GetIntegerv();

        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        static abstract void GetListener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        static abstract void GetListener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        );

        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        static abstract void GetListener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        static abstract void GetListener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        );

        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        static abstract void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        static abstract void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        static abstract float GetListenerf();

        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        static abstract void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        static abstract void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        static abstract float GetListenerfv();

        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        static abstract int GetListeneri();

        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        static abstract int GetListeneriv();

        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        static abstract void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        static abstract Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname);

        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        static abstract void GetSource3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        static abstract void GetSource3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        );

        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        static abstract void GetSource3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        static abstract void GetSource3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        );

        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        static abstract void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        static abstract void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value
        );

        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        static abstract void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        static abstract void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        );

        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        static abstract void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        static abstract void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value
        );

        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        static abstract void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        static abstract void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> values
        );

        [return: NativeTypeName("const ALchar *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        static abstract Ptr<sbyte> GetString([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("const ALchar *")]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        static abstract sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        static abstract MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        static abstract sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        static abstract MaybeBool<sbyte> IsEnabled([NativeTypeName("ALenum")] int capability);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        static abstract sbyte IsEnabledRaw([NativeTypeName("ALenum")] int capability);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        static abstract sbyte IsExtensionPresent([NativeTypeName("const ALchar *")] sbyte* extname);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        static abstract MaybeBool<sbyte> IsExtensionPresent(
            [NativeTypeName("const ALchar *")] Ref<sbyte> extname
        );

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        static abstract MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        static abstract sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source);

        [NativeFunction("openal", EntryPoint = "alListener3f")]
        static abstract void Listener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [NativeFunction("openal", EntryPoint = "alListener3i")]
        static abstract void Listener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [NativeFunction("openal", EntryPoint = "alListenerf")]
        static abstract void Listenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value
        );

        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        static abstract void Listenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        static abstract void Listenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        );

        [NativeFunction("openal", EntryPoint = "alListeneri")]
        static abstract void Listeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value
        );

        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        static abstract void Listeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        static abstract void Listeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] Ref<int> values
        );

        [NativeFunction("openal", EntryPoint = "alSource3f")]
        static abstract void Source3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [NativeFunction("openal", EntryPoint = "alSource3i")]
        static abstract void Source3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [NativeFunction("openal", EntryPoint = "alSourcef")]
        static abstract void Sourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        );

        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        static abstract void Sourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        static abstract void Sourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        );

        [NativeFunction("openal", EntryPoint = "alSourcei")]
        static abstract void Sourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        );

        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        static abstract void Sourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        static abstract void Sourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        );

        [NativeFunction("openal", EntryPoint = "alSourcePause")]
        static abstract void SourcePause([NativeTypeName("ALuint")] uint source);

        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        static abstract void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        static abstract void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [NativeFunction("openal", EntryPoint = "alSourcePlay")]
        static abstract void SourcePlay([NativeTypeName("ALuint")] uint source);

        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        static abstract void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        static abstract void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        static abstract void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] uint* buffers
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        static abstract void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        );

        [NativeFunction("openal", EntryPoint = "alSourceRewind")]
        static abstract void SourceRewind([NativeTypeName("ALuint")] uint source);

        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        static abstract void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [NativeFunction("openal", EntryPoint = "alSourceStop")]
        static abstract void SourceStop([NativeTypeName("ALuint")] uint source);

        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        static abstract void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        static abstract void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        );

        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        static abstract void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] uint* buffers
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        static abstract void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        );

        [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
        static abstract void SpeedOfSound([NativeTypeName("ALfloat")] float value);
    }

    [NativeFunction("openal", EntryPoint = "alBuffer3f")]
    void Buffer3F(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [NativeFunction("openal", EntryPoint = "alBuffer3i")]
    void Buffer3I(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [NativeFunction("openal", EntryPoint = "alBufferData")]
    void BufferData(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("const ALvoid *")] void* data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferData")]
    void BufferData(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("const ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    );

    [NativeFunction("openal", EntryPoint = "alBufferf")]
    void Bufferf(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value
    );

    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    void Bufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    void Bufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    );

    [NativeFunction("openal", EntryPoint = "alBufferi")]
    void Bufferi(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value
    );

    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    void Bufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    void Bufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers);

    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* buffers
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    void DeleteBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSource([NativeTypeName("const ALuint *")] uint sources);

    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    void DeleteSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [NativeFunction("openal", EntryPoint = "alDisable")]
    void Disable([NativeTypeName("ALenum")] int capability);

    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    void DistanceModel([NativeTypeName("ALenum")] int distanceModel);

    [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
    void DopplerFactor([NativeTypeName("ALfloat")] float value);

    [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
    void DopplerVelocity([NativeTypeName("ALfloat")] float value);

    [NativeFunction("openal", EntryPoint = "alEnable")]
    void Enable([NativeTypeName("ALenum")] int capability);

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    uint GenBuffer();

    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    void GenBuffers([NativeTypeName("ALsizei")] int n, [NativeTypeName("ALuint *")] uint* buffers);

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    void GenBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> buffers
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    uint GenSource();

    [NativeFunction("openal", EntryPoint = "alGenSources")]
    void GenSources([NativeTypeName("ALsizei")] int n, [NativeTypeName("ALuint *")] uint* sources);

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    void GenSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> sources
    );

    [return: NativeTypeName("ALboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    MaybeBool<sbyte> GetBoolean([NativeTypeName("ALenum")] int param0);

    [return: NativeTypeName("ALboolean")]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0);

    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    void GetBooleanv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALboolean *")] sbyte* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    void GetBooleanv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALboolean *")] Ref<sbyte> values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    sbyte GetBooleanv();

    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    void GetBuffer3F(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    void GetBuffer3F(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    );

    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    void GetBuffer3I(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    void GetBuffer3I(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    );

    [NativeFunction("openal", EntryPoint = "alGetBufferf")]
    void GetBufferf(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferf")]
    void GetBufferf(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value
    );

    [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
    void GetBufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
    void GetBufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [NativeFunction("openal", EntryPoint = "alGetBufferi")]
    void GetBufferi(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferi")]
    void GetBufferi(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value
    );

    [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
    void GetBufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
    void GetBufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [return: NativeTypeName("ALdouble")]
    [NativeFunction("openal", EntryPoint = "alGetDouble")]
    double GetDouble([NativeTypeName("ALenum")] int param0);

    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    void GetDoublev(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALdouble *")] double* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    void GetDoublev(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALdouble *")] Ref<double> values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    double GetDoublev();

    [return: NativeTypeName("ALenum")]
    [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
    int GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename);

    [return: NativeTypeName("ALenum")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
    int GetEnumValue([NativeTypeName("const ALchar *")] Ref<sbyte> ename);

    [return: NativeTypeName("ALenum")]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    int GetError();

    [return: NativeTypeName("ALfloat")]
    [NativeFunction("openal", EntryPoint = "alGetFloat")]
    float GetFloat([NativeTypeName("ALenum")] int param0);

    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    void GetFloatv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    void GetFloatv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    float GetFloatv();

    [return: NativeTypeName("ALint")]
    [NativeFunction("openal", EntryPoint = "alGetInteger")]
    int GetInteger([NativeTypeName("ALenum")] int param0);

    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    void GetIntegerv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    void GetIntegerv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    int GetIntegerv();

    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    void GetListener3F(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    void GetListener3F(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    );

    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    void GetListener3I(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    void GetListener3I(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    );

    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    void GetListenerf(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* value
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    void GetListenerf(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> value
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    float GetListenerf();

    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    void GetListenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    void GetListenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    float GetListenerfv();

    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    void GetListeneri(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* value
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    void GetListeneri(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> value
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    int GetListeneri();

    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    void GetListeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    void GetListeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    int GetListeneriv();

    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname);

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname);

    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    void GetSource3F(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    void GetSource3F(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    );

    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    void GetSource3I(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    void GetSource3I(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    );

    [NativeFunction("openal", EntryPoint = "alGetSourcef")]
    void GetSourcef(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcef")]
    void GetSourcef(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value
    );

    [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
    void GetSourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
    void GetSourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> values
    );

    [NativeFunction("openal", EntryPoint = "alGetSourcei")]
    void GetSourcei(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcei")]
    void GetSourcei(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value
    );

    [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
    void GetSourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
    void GetSourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> values
    );

    [return: NativeTypeName("const ALchar *")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    Ptr<sbyte> GetString([NativeTypeName("ALenum")] int param0);

    [return: NativeTypeName("const ALchar *")]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0);

    [return: NativeTypeName("ALboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer);

    [return: NativeTypeName("ALboolean")]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer);

    [return: NativeTypeName("ALboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    MaybeBool<sbyte> IsEnabled([NativeTypeName("ALenum")] int capability);

    [return: NativeTypeName("ALboolean")]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    sbyte IsEnabledRaw([NativeTypeName("ALenum")] int capability);

    [return: NativeTypeName("ALboolean")]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
    sbyte IsExtensionPresent([NativeTypeName("const ALchar *")] sbyte* extname);

    [return: NativeTypeName("ALboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
    MaybeBool<sbyte> IsExtensionPresent([NativeTypeName("const ALchar *")] Ref<sbyte> extname);

    [return: NativeTypeName("ALboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source);

    [return: NativeTypeName("ALboolean")]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source);

    [NativeFunction("openal", EntryPoint = "alListener3f")]
    void Listener3F(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [NativeFunction("openal", EntryPoint = "alListener3i")]
    void Listener3I(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [NativeFunction("openal", EntryPoint = "alListenerf")]
    void Listenerf([NativeTypeName("ALenum")] int param0, [NativeTypeName("ALfloat")] float value);

    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    void Listenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALfloat *")] float* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    void Listenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    );

    [NativeFunction("openal", EntryPoint = "alListeneri")]
    void Listeneri([NativeTypeName("ALenum")] int param0, [NativeTypeName("ALint")] int value);

    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    void Listeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALint *")] int* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    void Listeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALint *")] Ref<int> values
    );

    [NativeFunction("openal", EntryPoint = "alSource3f")]
    void Source3F(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    );

    [NativeFunction("openal", EntryPoint = "alSource3i")]
    void Source3I(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    );

    [NativeFunction("openal", EntryPoint = "alSourcef")]
    void Sourcef(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value
    );

    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    void Sourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    void Sourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    );

    [NativeFunction("openal", EntryPoint = "alSourcei")]
    void Sourcei(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value
    );

    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    void Sourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    void Sourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    );

    [NativeFunction("openal", EntryPoint = "alSourcePause")]
    void SourcePause([NativeTypeName("ALuint")] uint source);

    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    void SourcePausev(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    void SourcePausev(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [NativeFunction("openal", EntryPoint = "alSourcePlay")]
    void SourcePlay([NativeTypeName("ALuint")] uint source);

    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    void SourcePlayv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    void SourcePlayv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
    void SourceQueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("const ALuint *")] uint* buffers
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
    void SourceQueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers
    );

    [NativeFunction("openal", EntryPoint = "alSourceRewind")]
    void SourceRewind([NativeTypeName("ALuint")] uint source);

    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewindv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    void SourceRewindv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [NativeFunction("openal", EntryPoint = "alSourceStop")]
    void SourceStop([NativeTypeName("ALuint")] uint source);

    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    void SourceStopv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    void SourceStopv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    );

    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
    void SourceUnqueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("ALuint *")] uint* buffers
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
    void SourceUnqueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("ALuint *")] Ref<uint> buffers
    );

    [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
    void SpeedOfSound([NativeTypeName("ALfloat")] float value);
}
