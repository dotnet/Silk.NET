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

public unsafe partial class AL : IAL, IAL.Static
{
    public partial class DllImport : IAL.Static
    {
        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBuffer3f")]
        public static extern void Buffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBuffer3i")]
        public static extern void Buffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBufferData")]
        public static extern void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] void* data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        )
        {
            fixed (void* __dsl_data = data)
            {
                BufferData(buffer, format, __dsl_data, size, samplerate);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBufferf")]
        public static extern void Bufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBufferfv")]
        public static extern void Bufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Bufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Bufferfv(buffer, param1, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBufferi")]
        public static extern void Bufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBufferiv")]
        public static extern void Bufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Bufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Bufferiv(buffer, param1, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        public static void DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers) =>
            DeleteBuffers(1, (uint*)&buffers);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alDeleteBuffers")]
        public static extern void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* buffers
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        )
        {
            fixed (uint* __dsl_buffers = buffers)
            {
                DeleteBuffers(n, __dsl_buffers);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        public static void DeleteSource([NativeTypeName("const ALuint *")] uint sources) =>
            DeleteSources(1, (uint*)&sources);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alDeleteSources")]
        public static extern void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                DeleteSources(n, __dsl_sources);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alDisable")]
        public static extern void Disable([NativeTypeName("ALenum")] int capability);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alDistanceModel")]
        public static extern void DistanceModel([NativeTypeName("ALenum")] int distanceModel);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alDopplerFactor")]
        public static extern void DopplerFactor([NativeTypeName("ALfloat")] float value);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alDopplerVelocity")]
        public static extern void DopplerVelocity([NativeTypeName("ALfloat")] float value);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alEnable")]
        public static extern void Enable([NativeTypeName("ALenum")] int capability);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        public static uint GenBuffer()
        {
            uint buffers = default;
            GenBuffers(1, (uint*)&buffers);
            return buffers;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGenBuffers")]
        public static extern void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* buffers
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        )
        {
            fixed (uint* __dsl_buffers = buffers)
            {
                GenBuffers(n, __dsl_buffers);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        public static uint GenSource()
        {
            uint sources = default;
            GenSources(1, (uint*)&sources);
            return sources;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGenSources")]
        public static extern void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                GenSources(n, __dsl_sources);
            }
        }

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        public static MaybeBool<sbyte> GetBoolean([NativeTypeName("ALenum")] int param0) =>
            (MaybeBool<sbyte>)(sbyte)GetBooleanRaw(param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBoolean")]
        [return: NativeTypeName("ALboolean")]
        public static extern sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBooleanv")]
        public static extern void GetBooleanv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] sbyte* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBooleanv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] Ref<sbyte> values
        )
        {
            fixed (sbyte* __dsl_values = values)
            {
                GetBooleanv(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        public static sbyte GetBooleanv()
        {
            sbyte values = default;
            GetBooleanv(1, (sbyte*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBuffer3f")]
        public static extern void GetBuffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        )
        {
            fixed (float* __dsl_value3 = value3)
            fixed (float* __dsl_value2 = value2)
            fixed (float* __dsl_value1 = value1)
            {
                GetBuffer3F(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBuffer3i")]
        public static extern void GetBuffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        )
        {
            fixed (int* __dsl_value3 = value3)
            fixed (int* __dsl_value2 = value2)
            fixed (int* __dsl_value1 = value1)
            {
                GetBuffer3I(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBufferf")]
        public static extern void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value
        )
        {
            fixed (float* __dsl_value = value)
            {
                GetBufferf(buffer, param1, __dsl_value);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBufferfv")]
        public static extern void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                GetBufferfv(buffer, param1, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBufferi")]
        public static extern void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value
        )
        {
            fixed (int* __dsl_value = value)
            {
                GetBufferi(buffer, param1, __dsl_value);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBufferiv")]
        public static extern void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetBufferiv(buffer, param1, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetDouble")]
        [return: NativeTypeName("ALdouble")]
        public static extern double GetDouble([NativeTypeName("ALenum")] int param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetDoublev")]
        public static extern void GetDoublev(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] double* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetDoublev(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] Ref<double> values
        )
        {
            fixed (double* __dsl_values = values)
            {
                GetDoublev(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        public static double GetDoublev()
        {
            double values = default;
            GetDoublev(1, (double*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetEnumValue")]
        [return: NativeTypeName("ALenum")]
        public static extern int GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename);

        [return: NativeTypeName("ALenum")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue([NativeTypeName("const ALchar *")] Ref<sbyte> ename)
        {
            fixed (sbyte* __dsl_ename = ename)
            {
                return (int)GetEnumValue(__dsl_ename);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetError")]
        [return: NativeTypeName("ALenum")]
        public static extern int GetError();

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetFloat")]
        [return: NativeTypeName("ALfloat")]
        public static extern float GetFloat([NativeTypeName("ALenum")] int param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetFloatv")]
        public static extern void GetFloatv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetFloatv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                GetFloatv(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        public static float GetFloatv()
        {
            float values = default;
            GetFloatv(1, (float*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetInteger")]
        [return: NativeTypeName("ALint")]
        public static extern int GetInteger([NativeTypeName("ALenum")] int param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetIntegerv")]
        public static extern void GetIntegerv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetIntegerv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetIntegerv(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        public static int GetIntegerv()
        {
            int values = default;
            GetIntegerv(1, (int*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListener3f")]
        public static extern void GetListener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        )
        {
            fixed (float* __dsl_value3 = value3)
            fixed (float* __dsl_value2 = value2)
            fixed (float* __dsl_value1 = value1)
            {
                GetListener3F(param0, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListener3i")]
        public static extern void GetListener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        )
        {
            fixed (int* __dsl_value3 = value3)
            fixed (int* __dsl_value2 = value2)
            fixed (int* __dsl_value1 = value1)
            {
                GetListener3I(param0, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListenerf")]
        public static extern void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> value
        )
        {
            fixed (float* __dsl_value = value)
            {
                GetListenerf(param0, __dsl_value);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        public static float GetListenerf()
        {
            float value = default;
            GetListenerf(1, (float*)&value);
            return value;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListenerfv")]
        public static extern void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                GetListenerfv(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        public static float GetListenerfv()
        {
            float values = default;
            GetListenerfv(1, (float*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListeneri")]
        public static extern void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> value
        )
        {
            fixed (int* __dsl_value = value)
            {
                GetListeneri(param0, __dsl_value);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        public static int GetListeneri()
        {
            int value = default;
            GetListeneri(1, (int*)&value);
            return value;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListeneriv")]
        public static extern void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetListeneriv(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        public static int GetListeneriv()
        {
            int values = default;
            GetListeneriv(1, (int*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetProcAddress")]
        public static extern void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname)
        {
            fixed (sbyte* __dsl_fname = fname)
            {
                return (void*)GetProcAddress(__dsl_fname);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetSource3f")]
        public static extern void GetSource3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        )
        {
            fixed (float* __dsl_value3 = value3)
            fixed (float* __dsl_value2 = value2)
            fixed (float* __dsl_value1 = value1)
            {
                GetSource3F(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetSource3i")]
        public static extern void GetSource3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        )
        {
            fixed (int* __dsl_value3 = value3)
            fixed (int* __dsl_value2 = value2)
            fixed (int* __dsl_value1 = value1)
            {
                GetSource3I(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetSourcef")]
        public static extern void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value
        )
        {
            fixed (float* __dsl_value = value)
            {
                GetSourcef(source, param1, __dsl_value);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetSourcefv")]
        public static extern void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                GetSourcefv(source, param1, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetSourcei")]
        public static extern void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value
        )
        {
            fixed (int* __dsl_value = value)
            {
                GetSourcei(source, param1, __dsl_value);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetSourceiv")]
        public static extern void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetSourceiv(source, param1, __dsl_values);
            }
        }

        [return: NativeTypeName("const ALchar *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetString([NativeTypeName("ALenum")] int param0) =>
            (sbyte*)GetStringRaw(param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetString")]
        [return: NativeTypeName("const ALchar *")]
        public static extern sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        public static MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer) =>
            (MaybeBool<sbyte>)(sbyte)IsBufferRaw(buffer);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alIsBuffer")]
        [return: NativeTypeName("ALboolean")]
        public static extern sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        public static MaybeBool<sbyte> IsEnabled([NativeTypeName("ALenum")] int capability) =>
            (MaybeBool<sbyte>)(sbyte)IsEnabledRaw(capability);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alIsEnabled")]
        [return: NativeTypeName("ALboolean")]
        public static extern sbyte IsEnabledRaw([NativeTypeName("ALenum")] int capability);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alIsExtensionPresent")]
        [return: NativeTypeName("ALboolean")]
        public static extern sbyte IsExtensionPresent(
            [NativeTypeName("const ALchar *")] sbyte* extname
        );

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsExtensionPresent(
            [NativeTypeName("const ALchar *")] Ref<sbyte> extname
        )
        {
            fixed (sbyte* __dsl_extname = extname)
            {
                return (MaybeBool<sbyte>)(sbyte)IsExtensionPresent(__dsl_extname);
            }
        }

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        public static MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source) =>
            (MaybeBool<sbyte>)(sbyte)IsSourceRaw(source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alIsSource")]
        [return: NativeTypeName("ALboolean")]
        public static extern sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListener3f")]
        public static extern void Listener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListener3i")]
        public static extern void Listener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListenerf")]
        public static extern void Listenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListenerfv")]
        public static extern void Listenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Listenerfv(param0, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListeneri")]
        public static extern void Listeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListeneriv")]
        public static extern void Listeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Listeneriv(param0, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSource3f")]
        public static extern void Source3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSource3i")]
        public static extern void Source3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcef")]
        public static extern void Sourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcefv")]
        public static extern void Sourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Sourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Sourcefv(source, param1, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcei")]
        public static extern void Sourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceiv")]
        public static extern void Sourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Sourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Sourceiv(source, param1, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcePause")]
        public static extern void SourcePause([NativeTypeName("ALuint")] uint source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcePausev")]
        public static extern void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                SourcePausev(n, __dsl_sources);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcePlay")]
        public static extern void SourcePlay([NativeTypeName("ALuint")] uint source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcePlayv")]
        public static extern void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                SourcePlayv(n, __dsl_sources);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceQueueBuffers")]
        public static extern void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] uint* buffers
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        )
        {
            fixed (uint* __dsl_buffers = buffers)
            {
                SourceQueueBuffers(source, nb, __dsl_buffers);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceRewind")]
        public static extern void SourceRewind([NativeTypeName("ALuint")] uint source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceRewindv")]
        public static extern void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                SourceRewindv(n, __dsl_sources);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceStop")]
        public static extern void SourceStop([NativeTypeName("ALuint")] uint source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceStopv")]
        public static extern void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                SourceStopv(n, __dsl_sources);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceUnqueueBuffers")]
        public static extern void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] uint* buffers
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        )
        {
            fixed (uint* __dsl_buffers = buffers)
            {
                SourceUnqueueBuffers(source, nb, __dsl_buffers);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSpeedOfSound")]
        public static extern void SpeedOfSound([NativeTypeName("ALfloat")] float value);
    }

    public partial class StaticWrapper<T> : IAL
        where T : IAL.Static
    {
        [NativeFunction("openal", EntryPoint = "alBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Buffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => T.Buffer3F(buffer, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Buffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => T.Buffer3I(buffer, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alBufferData")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] void* data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        ) => T.BufferData(buffer, format, data, size, samplerate);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        ) => T.BufferData(buffer, format, data, size, samplerate);

        [NativeFunction("openal", EntryPoint = "alBufferf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Bufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        ) => T.Bufferf(buffer, param1, value);

        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Bufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        ) => T.Bufferfv(buffer, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Bufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        ) => T.Bufferfv(buffer, param1, values);

        [NativeFunction("openal", EntryPoint = "alBufferi")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Bufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        ) => T.Bufferi(buffer, param1, value);

        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Bufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        ) => T.Bufferiv(buffer, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Bufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        ) => T.Bufferiv(buffer, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers) =>
            T.DeleteBuffer(buffers);

        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* buffers
        ) => T.DeleteBuffers(n, buffers);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        ) => T.DeleteBuffers(n, buffers);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteSource([NativeTypeName("const ALuint *")] uint sources) =>
            T.DeleteSource(sources);

        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => T.DeleteSources(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        ) => T.DeleteSources(n, sources);

        [NativeFunction("openal", EntryPoint = "alDisable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Disable([NativeTypeName("ALenum")] int capability) => T.Disable(capability);

        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DistanceModel([NativeTypeName("ALenum")] int distanceModel) =>
            T.DistanceModel(distanceModel);

        [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DopplerFactor([NativeTypeName("ALfloat")] float value) =>
            T.DopplerFactor(value);

        [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DopplerVelocity([NativeTypeName("ALfloat")] float value) =>
            T.DopplerVelocity(value);

        [NativeFunction("openal", EntryPoint = "alEnable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Enable([NativeTypeName("ALenum")] int capability) => T.Enable(capability);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint GenBuffer() => T.GenBuffer();

        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* buffers
        ) => T.GenBuffers(n, buffers);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        ) => T.GenBuffers(n, buffers);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint GenSource() => T.GenSource();

        [NativeFunction("openal", EntryPoint = "alGenSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* sources
        ) => T.GenSources(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> sources
        ) => T.GenSources(n, sources);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> GetBoolean([NativeTypeName("ALenum")] int param0) =>
            T.GetBoolean(param0);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0) =>
            T.GetBooleanRaw(param0);

        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBooleanv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] sbyte* values
        ) => T.GetBooleanv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBooleanv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] Ref<sbyte> values
        ) => T.GetBooleanv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte GetBooleanv() => T.GetBooleanv();

        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBuffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => T.GetBuffer3F(buffer, param1, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBuffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        ) => T.GetBuffer3F(buffer, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBuffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => T.GetBuffer3I(buffer, param1, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBuffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        ) => T.GetBuffer3I(buffer, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        ) => T.GetBufferf(buffer, param1, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value
        ) => T.GetBufferf(buffer, param1, value);

        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        ) => T.GetBufferfv(buffer, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        ) => T.GetBufferfv(buffer, param1, values);

        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        ) => T.GetBufferi(buffer, param1, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value
        ) => T.GetBufferi(buffer, param1, value);

        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        ) => T.GetBufferiv(buffer, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> values
        ) => T.GetBufferiv(buffer, param1, values);

        [return: NativeTypeName("ALdouble")]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public double GetDouble([NativeTypeName("ALenum")] int param0) => T.GetDouble(param0);

        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetDoublev(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] double* values
        ) => T.GetDoublev(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetDoublev(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] Ref<double> values
        ) => T.GetDoublev(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public double GetDoublev() => T.GetDoublev();

        [return: NativeTypeName("ALenum")]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename) =>
            T.GetEnumValue(ename);

        [return: NativeTypeName("ALenum")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetEnumValue([NativeTypeName("const ALchar *")] Ref<sbyte> ename) =>
            T.GetEnumValue(ename);

        [return: NativeTypeName("ALenum")]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetError() => T.GetError();

        [return: NativeTypeName("ALfloat")]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public float GetFloat([NativeTypeName("ALenum")] int param0) => T.GetFloat(param0);

        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetFloatv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        ) => T.GetFloatv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetFloatv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        ) => T.GetFloatv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public float GetFloatv() => T.GetFloatv();

        [return: NativeTypeName("ALint")]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetInteger([NativeTypeName("ALenum")] int param0) => T.GetInteger(param0);

        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetIntegerv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        ) => T.GetIntegerv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetIntegerv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        ) => T.GetIntegerv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetIntegerv() => T.GetIntegerv();

        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => T.GetListener3F(param0, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        ) => T.GetListener3F(param0, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => T.GetListener3I(param0, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        ) => T.GetListener3I(param0, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value
        ) => T.GetListenerf(param0, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> value
        ) => T.GetListenerf(param0, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public float GetListenerf() => T.GetListenerf();

        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        ) => T.GetListenerfv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        ) => T.GetListenerfv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public float GetListenerfv() => T.GetListenerfv();

        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value
        ) => T.GetListeneri(param0, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> value
        ) => T.GetListeneri(param0, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetListeneri() => T.GetListeneri();

        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        ) => T.GetListeneriv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        ) => T.GetListeneriv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetListeneriv() => T.GetListeneriv();

        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname) =>
            T.GetProcAddress(fname);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname) =>
            T.GetProcAddress(fname);

        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSource3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => T.GetSource3F(source, param1, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSource3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        ) => T.GetSource3F(source, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSource3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => T.GetSource3I(source, param1, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSource3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        ) => T.GetSource3I(source, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        ) => T.GetSourcef(source, param1, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value
        ) => T.GetSourcef(source, param1, value);

        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        ) => T.GetSourcefv(source, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        ) => T.GetSourcefv(source, param1, values);

        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        ) => T.GetSourcei(source, param1, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value
        ) => T.GetSourcei(source, param1, value);

        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        ) => T.GetSourceiv(source, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> values
        ) => T.GetSourceiv(source, param1, values);

        [return: NativeTypeName("const ALchar *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<sbyte> GetString([NativeTypeName("ALenum")] int param0) => T.GetString(param0);

        [return: NativeTypeName("const ALchar *")]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0) => T.GetStringRaw(param0);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer) =>
            T.IsBuffer(buffer);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer) => T.IsBufferRaw(buffer);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsEnabled([NativeTypeName("ALenum")] int capability) =>
            T.IsEnabled(capability);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsEnabledRaw([NativeTypeName("ALenum")] int capability) =>
            T.IsEnabledRaw(capability);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsExtensionPresent([NativeTypeName("const ALchar *")] sbyte* extname) =>
            T.IsExtensionPresent(extname);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsExtensionPresent(
            [NativeTypeName("const ALchar *")] Ref<sbyte> extname
        ) => T.IsExtensionPresent(extname);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source) =>
            T.IsSource(source);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source) => T.IsSourceRaw(source);

        [NativeFunction("openal", EntryPoint = "alListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => T.Listener3F(param0, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => T.Listener3I(param0, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value
        ) => T.Listenerf(param0, value);

        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] float* values
        ) => T.Listenerfv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        ) => T.Listenerfv(param0, values);

        [NativeFunction("openal", EntryPoint = "alListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value
        ) => T.Listeneri(param0, value);

        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] int* values
        ) => T.Listeneriv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] Ref<int> values
        ) => T.Listeneriv(param0, values);

        [NativeFunction("openal", EntryPoint = "alSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Source3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => T.Source3F(source, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Source3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => T.Source3I(source, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alSourcef")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Sourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        ) => T.Sourcef(source, param1, value);

        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Sourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        ) => T.Sourcefv(source, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Sourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        ) => T.Sourcefv(source, param1, values);

        [NativeFunction("openal", EntryPoint = "alSourcei")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Sourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        ) => T.Sourcei(source, param1, value);

        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Sourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        ) => T.Sourceiv(source, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Sourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        ) => T.Sourceiv(source, param1, values);

        [NativeFunction("openal", EntryPoint = "alSourcePause")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePause([NativeTypeName("ALuint")] uint source) => T.SourcePause(source);

        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => T.SourcePausev(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        ) => T.SourcePausev(n, sources);

        [NativeFunction("openal", EntryPoint = "alSourcePlay")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePlay([NativeTypeName("ALuint")] uint source) => T.SourcePlay(source);

        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => T.SourcePlayv(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        ) => T.SourcePlayv(n, sources);

        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] uint* buffers
        ) => T.SourceQueueBuffers(source, nb, buffers);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        ) => T.SourceQueueBuffers(source, nb, buffers);

        [NativeFunction("openal", EntryPoint = "alSourceRewind")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceRewind([NativeTypeName("ALuint")] uint source) => T.SourceRewind(source);

        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => T.SourceRewindv(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        ) => T.SourceRewindv(n, sources);

        [NativeFunction("openal", EntryPoint = "alSourceStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceStop([NativeTypeName("ALuint")] uint source) => T.SourceStop(source);

        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => T.SourceStopv(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        ) => T.SourceStopv(n, sources);

        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] uint* buffers
        ) => T.SourceUnqueueBuffers(source, nb, buffers);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        ) => T.SourceUnqueueBuffers(source, nb, buffers);

        [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SpeedOfSound([NativeTypeName("ALfloat")] float value) => T.SpeedOfSound(value);
    }

    public partial class ThisThread
    {
        [NativeFunction("openal", EntryPoint = "alBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => Underlying.Value!.Buffer3F(buffer, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => Underlying.Value!.Buffer3I(buffer, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alBufferData")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] void* data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        ) => Underlying.Value!.BufferData(buffer, format, data, size, samplerate);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        )
        {
            fixed (void* __dsl_data = data)
            {
                BufferData(buffer, format, __dsl_data, size, samplerate);
            }
        }

        [NativeFunction("openal", EntryPoint = "alBufferf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Bufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        ) => Underlying.Value!.Bufferf(buffer, param1, value);

        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Bufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        ) => Underlying.Value!.Bufferfv(buffer, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Bufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Bufferfv(buffer, param1, __dsl_values);
            }
        }

        [NativeFunction("openal", EntryPoint = "alBufferi")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Bufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        ) => Underlying.Value!.Bufferi(buffer, param1, value);

        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Bufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        ) => Underlying.Value!.Bufferiv(buffer, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Bufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Bufferiv(buffer, param1, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers) =>
            Underlying.Value!.DeleteBuffer(buffers);

        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* buffers
        ) => Underlying.Value!.DeleteBuffers(n, buffers);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        )
        {
            fixed (uint* __dsl_buffers = buffers)
            {
                DeleteBuffers(n, __dsl_buffers);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteSource([NativeTypeName("const ALuint *")] uint sources) =>
            Underlying.Value!.DeleteSource(sources);

        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => Underlying.Value!.DeleteSources(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                DeleteSources(n, __dsl_sources);
            }
        }

        [NativeFunction("openal", EntryPoint = "alDisable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Disable([NativeTypeName("ALenum")] int capability) =>
            Underlying.Value!.Disable(capability);

        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DistanceModel([NativeTypeName("ALenum")] int distanceModel) =>
            Underlying.Value!.DistanceModel(distanceModel);

        [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DopplerFactor([NativeTypeName("ALfloat")] float value) =>
            Underlying.Value!.DopplerFactor(value);

        [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DopplerVelocity([NativeTypeName("ALfloat")] float value) =>
            Underlying.Value!.DopplerVelocity(value);

        [NativeFunction("openal", EntryPoint = "alEnable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Enable([NativeTypeName("ALenum")] int capability) =>
            Underlying.Value!.Enable(capability);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint GenBuffer()
        {
            uint buffers = default;
            GenBuffers(1, (uint*)&buffers);
            return buffers;
        }

        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* buffers
        ) => Underlying.Value!.GenBuffers(n, buffers);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        )
        {
            fixed (uint* __dsl_buffers = buffers)
            {
                GenBuffers(n, __dsl_buffers);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint GenSource()
        {
            uint sources = default;
            GenSources(1, (uint*)&sources);
            return sources;
        }

        [NativeFunction("openal", EntryPoint = "alGenSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* sources
        ) => Underlying.Value!.GenSources(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                GenSources(n, __dsl_sources);
            }
        }

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> GetBoolean([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetBoolean(param0);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetBooleanRaw(param0);

        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBooleanv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] sbyte* values
        ) => Underlying.Value!.GetBooleanv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBooleanv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] Ref<sbyte> values
        )
        {
            fixed (sbyte* __dsl_values = values)
            {
                GetBooleanv(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte GetBooleanv()
        {
            sbyte values = default;
            GetBooleanv(1, (sbyte*)&values);
            return values;
        }

        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => Underlying.Value!.GetBuffer3F(buffer, param1, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3F(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        )
        {
            fixed (float* __dsl_value3 = value3)
            fixed (float* __dsl_value2 = value2)
            fixed (float* __dsl_value1 = value1)
            {
                GetBuffer3F(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => Underlying.Value!.GetBuffer3I(buffer, param1, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3I(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        )
        {
            fixed (int* __dsl_value3 = value3)
            fixed (int* __dsl_value2 = value2)
            fixed (int* __dsl_value1 = value1)
            {
                GetBuffer3I(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        ) => Underlying.Value!.GetBufferf(buffer, param1, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value
        )
        {
            fixed (float* __dsl_value = value)
            {
                GetBufferf(buffer, param1, __dsl_value);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        ) => Underlying.Value!.GetBufferfv(buffer, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                GetBufferfv(buffer, param1, __dsl_values);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        ) => Underlying.Value!.GetBufferi(buffer, param1, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value
        )
        {
            fixed (int* __dsl_value = value)
            {
                GetBufferi(buffer, param1, __dsl_value);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        ) => Underlying.Value!.GetBufferiv(buffer, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetBufferiv(buffer, param1, __dsl_values);
            }
        }

        [return: NativeTypeName("ALdouble")]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static double GetDouble([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetDouble(param0);

        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetDoublev(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] double* values
        ) => Underlying.Value!.GetDoublev(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetDoublev(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] Ref<double> values
        )
        {
            fixed (double* __dsl_values = values)
            {
                GetDoublev(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static double GetDoublev()
        {
            double values = default;
            GetDoublev(1, (double*)&values);
            return values;
        }

        [return: NativeTypeName("ALenum")]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename) =>
            Underlying.Value!.GetEnumValue(ename);

        [return: NativeTypeName("ALenum")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue([NativeTypeName("const ALchar *")] Ref<sbyte> ename)
        {
            fixed (sbyte* __dsl_ename = ename)
            {
                return (int)GetEnumValue(__dsl_ename);
            }
        }

        [return: NativeTypeName("ALenum")]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetError() => Underlying.Value!.GetError();

        [return: NativeTypeName("ALfloat")]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static float GetFloat([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetFloat(param0);

        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetFloatv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        ) => Underlying.Value!.GetFloatv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetFloatv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                GetFloatv(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static float GetFloatv()
        {
            float values = default;
            GetFloatv(1, (float*)&values);
            return values;
        }

        [return: NativeTypeName("ALint")]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetInteger([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetInteger(param0);

        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetIntegerv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        ) => Underlying.Value!.GetIntegerv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetIntegerv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetIntegerv(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetIntegerv()
        {
            int values = default;
            GetIntegerv(1, (int*)&values);
            return values;
        }

        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => Underlying.Value!.GetListener3F(param0, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        )
        {
            fixed (float* __dsl_value3 = value3)
            fixed (float* __dsl_value2 = value2)
            fixed (float* __dsl_value1 = value1)
            {
                GetListener3F(param0, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => Underlying.Value!.GetListener3I(param0, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        )
        {
            fixed (int* __dsl_value3 = value3)
            fixed (int* __dsl_value2 = value2)
            fixed (int* __dsl_value1 = value1)
            {
                GetListener3I(param0, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value
        ) => Underlying.Value!.GetListenerf(param0, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> value
        )
        {
            fixed (float* __dsl_value = value)
            {
                GetListenerf(param0, __dsl_value);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static float GetListenerf()
        {
            float value = default;
            GetListenerf(1, (float*)&value);
            return value;
        }

        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        ) => Underlying.Value!.GetListenerfv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                GetListenerfv(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static float GetListenerfv()
        {
            float values = default;
            GetListenerfv(1, (float*)&values);
            return values;
        }

        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value
        ) => Underlying.Value!.GetListeneri(param0, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> value
        )
        {
            fixed (int* __dsl_value = value)
            {
                GetListeneri(param0, __dsl_value);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetListeneri()
        {
            int value = default;
            GetListeneri(1, (int*)&value);
            return value;
        }

        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        ) => Underlying.Value!.GetListeneriv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetListeneriv(param0, __dsl_values);
            }
        }

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetListeneriv()
        {
            int values = default;
            GetListeneriv(1, (int*)&values);
            return values;
        }

        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname) =>
            Underlying.Value!.GetProcAddress(fname);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname)
        {
            fixed (sbyte* __dsl_fname = fname)
            {
                return (void*)GetProcAddress(__dsl_fname);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => Underlying.Value!.GetSource3F(source, param1, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        )
        {
            fixed (float* __dsl_value3 = value3)
            fixed (float* __dsl_value2 = value2)
            fixed (float* __dsl_value1 = value1)
            {
                GetSource3F(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => Underlying.Value!.GetSource3I(source, param1, value1, value2, value3);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        )
        {
            fixed (int* __dsl_value3 = value3)
            fixed (int* __dsl_value2 = value2)
            fixed (int* __dsl_value1 = value1)
            {
                GetSource3I(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        ) => Underlying.Value!.GetSourcef(source, param1, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value
        )
        {
            fixed (float* __dsl_value = value)
            {
                GetSourcef(source, param1, __dsl_value);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        ) => Underlying.Value!.GetSourcefv(source, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                GetSourcefv(source, param1, __dsl_values);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        ) => Underlying.Value!.GetSourcei(source, param1, value);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value
        )
        {
            fixed (int* __dsl_value = value)
            {
                GetSourcei(source, param1, __dsl_value);
            }
        }

        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        ) => Underlying.Value!.GetSourceiv(source, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetSourceiv(source, param1, __dsl_values);
            }
        }

        [return: NativeTypeName("const ALchar *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetString([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetString(param0);

        [return: NativeTypeName("const ALchar *")]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetStringRaw(param0);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer) =>
            Underlying.Value!.IsBuffer(buffer);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer) =>
            Underlying.Value!.IsBufferRaw(buffer);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsEnabled([NativeTypeName("ALenum")] int capability) =>
            Underlying.Value!.IsEnabled(capability);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsEnabledRaw([NativeTypeName("ALenum")] int capability) =>
            Underlying.Value!.IsEnabledRaw(capability);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsExtensionPresent([NativeTypeName("const ALchar *")] sbyte* extname) =>
            Underlying.Value!.IsExtensionPresent(extname);

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsExtensionPresent(
            [NativeTypeName("const ALchar *")] Ref<sbyte> extname
        )
        {
            fixed (sbyte* __dsl_extname = extname)
            {
                return (MaybeBool<sbyte>)(sbyte)IsExtensionPresent(__dsl_extname);
            }
        }

        [return: NativeTypeName("ALboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.IsSource(source);

        [return: NativeTypeName("ALboolean")]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.IsSourceRaw(source);

        [NativeFunction("openal", EntryPoint = "alListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener3F(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => Underlying.Value!.Listener3F(param0, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener3I(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => Underlying.Value!.Listener3I(param0, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value
        ) => Underlying.Value!.Listenerf(param0, value);

        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] float* values
        ) => Underlying.Value!.Listenerfv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Listenerfv(param0, __dsl_values);
            }
        }

        [NativeFunction("openal", EntryPoint = "alListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value
        ) => Underlying.Value!.Listeneri(param0, value);

        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] int* values
        ) => Underlying.Value!.Listeneriv(param0, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Listeneriv(param0, __dsl_values);
            }
        }

        [NativeFunction("openal", EntryPoint = "alSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source3F(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => Underlying.Value!.Source3F(source, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source3I(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => Underlying.Value!.Source3I(source, param1, value1, value2, value3);

        [NativeFunction("openal", EntryPoint = "alSourcef")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Sourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        ) => Underlying.Value!.Sourcef(source, param1, value);

        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Sourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        ) => Underlying.Value!.Sourcefv(source, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Sourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Sourcefv(source, param1, __dsl_values);
            }
        }

        [NativeFunction("openal", EntryPoint = "alSourcei")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Sourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        ) => Underlying.Value!.Sourcei(source, param1, value);

        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Sourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        ) => Underlying.Value!.Sourceiv(source, param1, values);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Sourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Sourceiv(source, param1, __dsl_values);
            }
        }

        [NativeFunction("openal", EntryPoint = "alSourcePause")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePause([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.SourcePause(source);

        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => Underlying.Value!.SourcePausev(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                SourcePausev(n, __dsl_sources);
            }
        }

        [NativeFunction("openal", EntryPoint = "alSourcePlay")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePlay([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.SourcePlay(source);

        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => Underlying.Value!.SourcePlayv(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                SourcePlayv(n, __dsl_sources);
            }
        }

        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] uint* buffers
        ) => Underlying.Value!.SourceQueueBuffers(source, nb, buffers);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        )
        {
            fixed (uint* __dsl_buffers = buffers)
            {
                SourceQueueBuffers(source, nb, __dsl_buffers);
            }
        }

        [NativeFunction("openal", EntryPoint = "alSourceRewind")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceRewind([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.SourceRewind(source);

        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => Underlying.Value!.SourceRewindv(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                SourceRewindv(n, __dsl_sources);
            }
        }

        [NativeFunction("openal", EntryPoint = "alSourceStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceStop([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.SourceStop(source);

        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => Underlying.Value!.SourceStopv(n, sources);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        )
        {
            fixed (uint* __dsl_sources = sources)
            {
                SourceStopv(n, __dsl_sources);
            }
        }

        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] uint* buffers
        ) => Underlying.Value!.SourceUnqueueBuffers(source, nb, buffers);

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        )
        {
            fixed (uint* __dsl_buffers = buffers)
            {
                SourceUnqueueBuffers(source, nb, __dsl_buffers);
            }
        }

        [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SpeedOfSound([NativeTypeName("ALfloat")] float value) =>
            Underlying.Value!.SpeedOfSound(value);
    }

    [NativeTypeName("#define AL_CPLUSPLUS __cplusplus")]
    public const nint Cplusplus = 201703;

    [NativeTypeName("#define AL_INVALID (-1)")]
    public const int Invalid = (-1);

    [NativeTypeName("#define AL_ILLEGAL_ENUM AL_INVALID_ENUM")]
    public const int IllegalEnum = 0xA002;

    [NativeTypeName("#define AL_ILLEGAL_COMMAND AL_INVALID_OPERATION")]
    public const int IllegalCommand = 0xA004;

    [NativeTypeName("#define AL_NONE 0")]
    public const int None = 0;

    [NativeTypeName("#define AL_FALSE 0")]
    public const int False = 0;

    [NativeTypeName("#define AL_TRUE 1")]
    public const int True = 1;

    [NativeTypeName("#define AL_SOURCE_RELATIVE 0x202")]
    public const int SourceRelative = 0x202;

    [NativeTypeName("#define AL_CONE_INNER_ANGLE 0x1001")]
    public const int ConeInnerAngle = 0x1001;

    [NativeTypeName("#define AL_CONE_OUTER_ANGLE 0x1002")]
    public const int ConeOuterAngle = 0x1002;

    [NativeTypeName("#define AL_PITCH 0x1003")]
    public const int Pitch = 0x1003;

    [NativeTypeName("#define AL_POSITION 0x1004")]
    public const int Position = 0x1004;

    [NativeTypeName("#define AL_DIRECTION 0x1005")]
    public const int Direction = 0x1005;

    [NativeTypeName("#define AL_VELOCITY 0x1006")]
    public const int Velocity = 0x1006;

    [NativeTypeName("#define AL_LOOPING 0x1007")]
    public const int Looping = 0x1007;

    [NativeTypeName("#define AL_BUFFER 0x1009")]
    public const int Buffer = 0x1009;

    [NativeTypeName("#define AL_GAIN 0x100A")]
    public const int Gain = 0x100A;

    [NativeTypeName("#define AL_MIN_GAIN 0x100D")]
    public const int MinGain = 0x100D;

    [NativeTypeName("#define AL_MAX_GAIN 0x100E")]
    public const int MaxGain = 0x100E;

    [NativeTypeName("#define AL_ORIENTATION 0x100F")]
    public const int Orientation = 0x100F;

    [NativeTypeName("#define AL_SOURCE_STATE 0x1010")]
    public const int SourceState = 0x1010;

    [NativeTypeName("#define AL_INITIAL 0x1011")]
    public const int Initial = 0x1011;

    [NativeTypeName("#define AL_PLAYING 0x1012")]
    public const int Playing = 0x1012;

    [NativeTypeName("#define AL_PAUSED 0x1013")]
    public const int Paused = 0x1013;

    [NativeTypeName("#define AL_STOPPED 0x1014")]
    public const int Stopped = 0x1014;

    [NativeTypeName("#define AL_BUFFERS_QUEUED 0x1015")]
    public const int BuffersQueued = 0x1015;

    [NativeTypeName("#define AL_BUFFERS_PROCESSED 0x1016")]
    public const int BuffersProcessed = 0x1016;

    [NativeTypeName("#define AL_REFERENCE_DISTANCE 0x1020")]
    public const int ReferenceDistance = 0x1020;

    [NativeTypeName("#define AL_ROLLOFF_FACTOR 0x1021")]
    public const int RolloffFactor = 0x1021;

    [NativeTypeName("#define AL_CONE_OUTER_GAIN 0x1022")]
    public const int ConeOuterGain = 0x1022;

    [NativeTypeName("#define AL_MAX_DISTANCE 0x1023")]
    public const int MaxDistance = 0x1023;

    [NativeTypeName("#define AL_SEC_OFFSET 0x1024")]
    public const int SecOffset = 0x1024;

    [NativeTypeName("#define AL_SAMPLE_OFFSET 0x1025")]
    public const int SampleOffset = 0x1025;

    [NativeTypeName("#define AL_BYTE_OFFSET 0x1026")]
    public const int ByteOffset = 0x1026;

    [NativeTypeName("#define AL_SOURCE_TYPE 0x1027")]
    public const int SourceType = 0x1027;

    [NativeTypeName("#define AL_STATIC 0x1028")]
    public const int Static = 0x1028;

    [NativeTypeName("#define AL_STREAMING 0x1029")]
    public const int Streaming = 0x1029;

    [NativeTypeName("#define AL_UNDETERMINED 0x1030")]
    public const int Undetermined = 0x1030;

    [NativeTypeName("#define AL_FORMAT_MONO8 0x1100")]
    public const int FormatMono8 = 0x1100;

    [NativeTypeName("#define AL_FORMAT_MONO16 0x1101")]
    public const int FormatMono16 = 0x1101;

    [NativeTypeName("#define AL_FORMAT_STEREO8 0x1102")]
    public const int FormatStereo8 = 0x1102;

    [NativeTypeName("#define AL_FORMAT_STEREO16 0x1103")]
    public const int FormatStereo16 = 0x1103;

    [NativeTypeName("#define AL_FREQUENCY 0x2001")]
    public const int Frequency = 0x2001;

    [NativeTypeName("#define AL_BITS 0x2002")]
    public const int Bits = 0x2002;

    [NativeTypeName("#define AL_CHANNELS 0x2003")]
    public const int Channels = 0x2003;

    [NativeTypeName("#define AL_SIZE 0x2004")]
    public const int Size = 0x2004;

    [NativeTypeName("#define AL_UNUSED 0x2010")]
    public const int Unused = 0x2010;

    [NativeTypeName("#define AL_PENDING 0x2011")]
    public const int Pending = 0x2011;

    [NativeTypeName("#define AL_PROCESSED 0x2012")]
    public const int Processed = 0x2012;

    [NativeTypeName("#define AL_NO_ERROR 0")]
    public const int NoError = 0;

    [NativeTypeName("#define AL_INVALID_NAME 0xA001")]
    public const int InvalidName = 0xA001;

    [NativeTypeName("#define AL_INVALID_ENUM 0xA002")]
    public const int InvalidEnum = 0xA002;

    [NativeTypeName("#define AL_INVALID_VALUE 0xA003")]
    public const int InvalidValue = 0xA003;

    [NativeTypeName("#define AL_INVALID_OPERATION 0xA004")]
    public const int InvalidOperation = 0xA004;

    [NativeTypeName("#define AL_OUT_OF_MEMORY 0xA005")]
    public const int OutOfMemory = 0xA005;

    [NativeTypeName("#define AL_VENDOR 0xB001")]
    public const int Vendor = 0xB001;

    [NativeTypeName("#define AL_VERSION 0xB002")]
    public const int Version = 0xB002;

    [NativeTypeName("#define AL_RENDERER 0xB003")]
    public const int Renderer = 0xB003;

    [NativeTypeName("#define AL_EXTENSIONS 0xB004")]
    public const int Extensions = 0xB004;

    [NativeTypeName("#define AL_DOPPLER_FACTOR 0xC000")]
    public const int DopplerFactorValue = 0xC000;

    [NativeTypeName("#define AL_DOPPLER_VELOCITY 0xC001")]
    public const int DopplerVelocityValue = 0xC001;

    [NativeTypeName("#define AL_SPEED_OF_SOUND 0xC003")]
    public const int SpeedOfSoundValue = 0xC003;

    [NativeTypeName("#define AL_DISTANCE_MODEL 0xD000")]
    public const int DistanceModelValue = 0xD000;

    [NativeTypeName("#define AL_INVERSE_DISTANCE 0xD001")]
    public const int InverseDistance = 0xD001;

    [NativeTypeName("#define AL_INVERSE_DISTANCE_CLAMPED 0xD002")]
    public const int InverseDistanceClamped = 0xD002;

    [NativeTypeName("#define AL_LINEAR_DISTANCE 0xD003")]
    public const int LinearDistance = 0xD003;

    [NativeTypeName("#define AL_LINEAR_DISTANCE_CLAMPED 0xD004")]
    public const int LinearDistanceClamped = 0xD004;

    [NativeTypeName("#define AL_EXPONENT_DISTANCE 0xD005")]
    public const int ExponentDistance = 0xD005;

    [NativeTypeName("#define AL_EXPONENT_DISTANCE_CLAMPED 0xD006")]
    public const int ExponentDistanceClamped = 0xD006;

    [NativeTypeName("#define AL_LOKI_IMA_ADPCM_format 1")]
    public const int LOKIIMAAdpcmFormat = 1;

    [NativeTypeName("#define AL_FORMAT_IMA_ADPCM_MONO16_EXT 0x10000")]
    public const int FormatImaAdpcmMono16Ext = 0x10000;

    [NativeTypeName("#define AL_FORMAT_IMA_ADPCM_STEREO16_EXT 0x10001")]
    public const int FormatImaAdpcmStereo16Ext = 0x10001;

    [NativeTypeName("#define AL_LOKI_WAVE_format 1")]
    public const int LOKIWAVEFormat = 1;

    [NativeTypeName("#define AL_FORMAT_WAVE_EXT 0x10002")]
    public const int FormatWaveExt = 0x10002;

    [NativeTypeName("#define AL_EXT_vorbis 1")]
    public const int EXTVorbis = 1;

    [NativeTypeName("#define AL_FORMAT_VORBIS_EXT 0x10003")]
    public const int FormatVorbisExt = 0x10003;

    [NativeTypeName("#define AL_LOKI_quadriphonic 1")]
    public const int LOKIQuadriphonic = 1;

    [NativeTypeName("#define AL_FORMAT_QUAD8_LOKI 0x10004")]
    public const int FormatQuad8Loki = 0x10004;

    [NativeTypeName("#define AL_FORMAT_QUAD16_LOKI 0x10005")]
    public const int FormatQuad16Loki = 0x10005;

    [NativeTypeName("#define AL_EXT_float32 1")]
    public const int EXTFloat32 = 1;

    [NativeTypeName("#define AL_FORMAT_MONO_FLOAT32 0x10010")]
    public const int FormatMonoFloat32 = 0x10010;

    [NativeTypeName("#define AL_FORMAT_STEREO_FLOAT32 0x10011")]
    public const int FormatStereoFloat32 = 0x10011;

    [NativeTypeName("#define AL_EXT_double 1")]
    public const int EXTDouble = 1;

    [NativeTypeName("#define AL_FORMAT_MONO_DOUBLE_EXT 0x10012")]
    public const int FormatMonoDoubleExt = 0x10012;

    [NativeTypeName("#define AL_FORMAT_STEREO_DOUBLE_EXT 0x10013")]
    public const int FormatStereoDoubleExt = 0x10013;

    [NativeTypeName("#define AL_EXT_MULAW 1")]
    public const int ExtMulaw = 1;

    [NativeTypeName("#define AL_FORMAT_MONO_MULAW_EXT 0x10014")]
    public const int FormatMonoMulawExt = 0x10014;

    [NativeTypeName("#define AL_FORMAT_STEREO_MULAW_EXT 0x10015")]
    public const int FormatStereoMulawExt = 0x10015;

    [NativeTypeName("#define AL_EXT_ALAW 1")]
    public const int ExtAlaw = 1;

    [NativeTypeName("#define AL_FORMAT_MONO_ALAW_EXT 0x10016")]
    public const int FormatMonoAlawExt = 0x10016;

    [NativeTypeName("#define AL_FORMAT_STEREO_ALAW_EXT 0x10017")]
    public const int FormatStereoAlawExt = 0x10017;

    [NativeTypeName("#define AL_EXT_MCFORMATS 1")]
    public const int ExtMcformats = 1;

    [NativeTypeName("#define AL_FORMAT_QUAD8 0x1204")]
    public const int FormatQuad8 = 0x1204;

    [NativeTypeName("#define AL_FORMAT_QUAD16 0x1205")]
    public const int FormatQuad16 = 0x1205;

    [NativeTypeName("#define AL_FORMAT_QUAD32 0x1206")]
    public const int FormatQuad32 = 0x1206;

    [NativeTypeName("#define AL_FORMAT_REAR8 0x1207")]
    public const int FormatRear8 = 0x1207;

    [NativeTypeName("#define AL_FORMAT_REAR16 0x1208")]
    public const int FormatRear16 = 0x1208;

    [NativeTypeName("#define AL_FORMAT_REAR32 0x1209")]
    public const int FormatRear32 = 0x1209;

    [NativeTypeName("#define AL_FORMAT_51CHN8 0x120A")]
    public const int Format51Chn8 = 0x120A;

    [NativeTypeName("#define AL_FORMAT_51CHN16 0x120B")]
    public const int Format51Chn16 = 0x120B;

    [NativeTypeName("#define AL_FORMAT_51CHN32 0x120C")]
    public const int Format51Chn32 = 0x120C;

    [NativeTypeName("#define AL_FORMAT_61CHN8 0x120D")]
    public const int Format61Chn8 = 0x120D;

    [NativeTypeName("#define AL_FORMAT_61CHN16 0x120E")]
    public const int Format61Chn16 = 0x120E;

    [NativeTypeName("#define AL_FORMAT_61CHN32 0x120F")]
    public const int Format61Chn32 = 0x120F;

    [NativeTypeName("#define AL_FORMAT_71CHN8 0x1210")]
    public const int Format71Chn8 = 0x1210;

    [NativeTypeName("#define AL_FORMAT_71CHN16 0x1211")]
    public const int Format71Chn16 = 0x1211;

    [NativeTypeName("#define AL_FORMAT_71CHN32 0x1212")]
    public const int Format71Chn32 = 0x1212;

    [NativeTypeName("#define AL_EXT_MULAW_MCFORMATS 1")]
    public const int ExtMulawMcformats = 1;

    [NativeTypeName("#define AL_FORMAT_MONO_MULAW 0x10014")]
    public const int FormatMonoMulaw = 0x10014;

    [NativeTypeName("#define AL_FORMAT_STEREO_MULAW 0x10015")]
    public const int FormatStereoMulaw = 0x10015;

    [NativeTypeName("#define AL_FORMAT_QUAD_MULAW 0x10021")]
    public const int FormatQuadMulaw = 0x10021;

    [NativeTypeName("#define AL_FORMAT_REAR_MULAW 0x10022")]
    public const int FormatRearMulaw = 0x10022;

    [NativeTypeName("#define AL_FORMAT_51CHN_MULAW 0x10023")]
    public const int Format51ChnMulaw = 0x10023;

    [NativeTypeName("#define AL_FORMAT_61CHN_MULAW 0x10024")]
    public const int Format61ChnMulaw = 0x10024;

    [NativeTypeName("#define AL_FORMAT_71CHN_MULAW 0x10025")]
    public const int Format71ChnMulaw = 0x10025;

    [NativeTypeName("#define AL_EXT_IMA4 1")]
    public const int ExtIma4 = 1;

    [NativeTypeName("#define AL_FORMAT_MONO_IMA4 0x1300")]
    public const int FormatMonoIma4 = 0x1300;

    [NativeTypeName("#define AL_FORMAT_STEREO_IMA4 0x1301")]
    public const int FormatStereoIma4 = 0x1301;

    [NativeTypeName("#define AL_EXT_STATIC_BUFFER 1")]
    public const int ExtStaticBuffer = 1;

    [NativeTypeName("#define AL_METERS_PER_UNIT 0x20004")]
    public const int MetersPerUnit = 0x20004;

    [NativeTypeName("#define AL_DIRECT_FILTER 0x20005")]
    public const int DirectFilter = 0x20005;

    [NativeTypeName("#define AL_AUXILIARY_SEND_FILTER 0x20006")]
    public const int AuxiliarySendFilter = 0x20006;

    [NativeTypeName("#define AL_AIR_ABSORPTION_FACTOR 0x20007")]
    public const int AirAbsorptionFactor = 0x20007;

    [NativeTypeName("#define AL_ROOM_ROLLOFF_FACTOR 0x20008")]
    public const int RoomRolloffFactor = 0x20008;

    [NativeTypeName("#define AL_CONE_OUTER_GAINHF 0x20009")]
    public const int ConeOuterGainhf = 0x20009;

    [NativeTypeName("#define AL_DIRECT_FILTER_GAINHF_AUTO 0x2000A")]
    public const int DirectFilterGainhfAuto = 0x2000A;

    [NativeTypeName("#define AL_AUXILIARY_SEND_FILTER_GAIN_AUTO 0x2000B")]
    public const int AuxiliarySendFilterGainAuto = 0x2000B;

    [NativeTypeName("#define AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO 0x2000C")]
    public const int AuxiliarySendFilterGainhfAuto = 0x2000C;

    [NativeTypeName("#define AL_REVERB_DENSITY 0x0001")]
    public const int ReverbDensity = 0x0001;

    [NativeTypeName("#define AL_REVERB_DIFFUSION 0x0002")]
    public const int ReverbDiffusion = 0x0002;

    [NativeTypeName("#define AL_REVERB_GAIN 0x0003")]
    public const int ReverbGain = 0x0003;

    [NativeTypeName("#define AL_REVERB_GAINHF 0x0004")]
    public const int ReverbGainhf = 0x0004;

    [NativeTypeName("#define AL_REVERB_DECAY_TIME 0x0005")]
    public const int ReverbDecayTime = 0x0005;

    [NativeTypeName("#define AL_REVERB_DECAY_HFRATIO 0x0006")]
    public const int ReverbDecayHfratio = 0x0006;

    [NativeTypeName("#define AL_REVERB_REFLECTIONS_GAIN 0x0007")]
    public const int ReverbReflectionsGain = 0x0007;

    [NativeTypeName("#define AL_REVERB_REFLECTIONS_DELAY 0x0008")]
    public const int ReverbReflectionsDelay = 0x0008;

    [NativeTypeName("#define AL_REVERB_LATE_REVERB_GAIN 0x0009")]
    public const int ReverbLateReverbGain = 0x0009;

    [NativeTypeName("#define AL_REVERB_LATE_REVERB_DELAY 0x000A")]
    public const int ReverbLateReverbDelay = 0x000A;

    [NativeTypeName("#define AL_REVERB_AIR_ABSORPTION_GAINHF 0x000B")]
    public const int ReverbAirAbsorptionGainhf = 0x000B;

    [NativeTypeName("#define AL_REVERB_ROOM_ROLLOFF_FACTOR 0x000C")]
    public const int ReverbRoomRolloffFactor = 0x000C;

    [NativeTypeName("#define AL_REVERB_DECAY_HFLIMIT 0x000D")]
    public const int ReverbDecayHflimit = 0x000D;

    [NativeTypeName("#define AL_EAXREVERB_DENSITY 0x0001")]
    public const int EaxreverbDensity = 0x0001;

    [NativeTypeName("#define AL_EAXREVERB_DIFFUSION 0x0002")]
    public const int EaxreverbDiffusion = 0x0002;

    [NativeTypeName("#define AL_EAXREVERB_GAIN 0x0003")]
    public const int EaxreverbGain = 0x0003;

    [NativeTypeName("#define AL_EAXREVERB_GAINHF 0x0004")]
    public const int EaxreverbGainhf = 0x0004;

    [NativeTypeName("#define AL_EAXREVERB_GAINLF 0x0005")]
    public const int EaxreverbGainlf = 0x0005;

    [NativeTypeName("#define AL_EAXREVERB_DECAY_TIME 0x0006")]
    public const int EaxreverbDecayTime = 0x0006;

    [NativeTypeName("#define AL_EAXREVERB_DECAY_HFRATIO 0x0007")]
    public const int EaxreverbDecayHfratio = 0x0007;

    [NativeTypeName("#define AL_EAXREVERB_DECAY_LFRATIO 0x0008")]
    public const int EaxreverbDecayLfratio = 0x0008;

    [NativeTypeName("#define AL_EAXREVERB_REFLECTIONS_GAIN 0x0009")]
    public const int EaxreverbReflectionsGain = 0x0009;

    [NativeTypeName("#define AL_EAXREVERB_REFLECTIONS_DELAY 0x000A")]
    public const int EaxreverbReflectionsDelay = 0x000A;

    [NativeTypeName("#define AL_EAXREVERB_REFLECTIONS_PAN 0x000B")]
    public const int EaxreverbReflectionsPan = 0x000B;

    [NativeTypeName("#define AL_EAXREVERB_LATE_REVERB_GAIN 0x000C")]
    public const int EaxreverbLateReverbGain = 0x000C;

    [NativeTypeName("#define AL_EAXREVERB_LATE_REVERB_DELAY 0x000D")]
    public const int EaxreverbLateReverbDelay = 0x000D;

    [NativeTypeName("#define AL_EAXREVERB_LATE_REVERB_PAN 0x000E")]
    public const int EaxreverbLateReverbPan = 0x000E;

    [NativeTypeName("#define AL_EAXREVERB_ECHO_TIME 0x000F")]
    public const int EaxreverbEchoTime = 0x000F;

    [NativeTypeName("#define AL_EAXREVERB_ECHO_DEPTH 0x0010")]
    public const int EaxreverbEchoDepth = 0x0010;

    [NativeTypeName("#define AL_EAXREVERB_MODULATION_TIME 0x0011")]
    public const int EaxreverbModulationTime = 0x0011;

    [NativeTypeName("#define AL_EAXREVERB_MODULATION_DEPTH 0x0012")]
    public const int EaxreverbModulationDepth = 0x0012;

    [NativeTypeName("#define AL_EAXREVERB_AIR_ABSORPTION_GAINHF 0x0013")]
    public const int EaxreverbAirAbsorptionGainhf = 0x0013;

    [NativeTypeName("#define AL_EAXREVERB_HFREFERENCE 0x0014")]
    public const int EaxreverbHfreference = 0x0014;

    [NativeTypeName("#define AL_EAXREVERB_LFREFERENCE 0x0015")]
    public const int EaxreverbLfreference = 0x0015;

    [NativeTypeName("#define AL_EAXREVERB_ROOM_ROLLOFF_FACTOR 0x0016")]
    public const int EaxreverbRoomRolloffFactor = 0x0016;

    [NativeTypeName("#define AL_EAXREVERB_DECAY_HFLIMIT 0x0017")]
    public const int EaxreverbDecayHflimit = 0x0017;

    [NativeTypeName("#define AL_CHORUS_WAVEFORM 0x0001")]
    public const int ChorusWaveform = 0x0001;

    [NativeTypeName("#define AL_CHORUS_PHASE 0x0002")]
    public const int ChorusPhase = 0x0002;

    [NativeTypeName("#define AL_CHORUS_RATE 0x0003")]
    public const int ChorusRate = 0x0003;

    [NativeTypeName("#define AL_CHORUS_DEPTH 0x0004")]
    public const int ChorusDepth = 0x0004;

    [NativeTypeName("#define AL_CHORUS_FEEDBACK 0x0005")]
    public const int ChorusFeedback = 0x0005;

    [NativeTypeName("#define AL_CHORUS_DELAY 0x0006")]
    public const int ChorusDelay = 0x0006;

    [NativeTypeName("#define AL_DISTORTION_EDGE 0x0001")]
    public const int DistortionEdge = 0x0001;

    [NativeTypeName("#define AL_DISTORTION_GAIN 0x0002")]
    public const int DistortionGain = 0x0002;

    [NativeTypeName("#define AL_DISTORTION_LOWPASS_CUTOFF 0x0003")]
    public const int DistortionLowpassCutoff = 0x0003;

    [NativeTypeName("#define AL_DISTORTION_EQCENTER 0x0004")]
    public const int DistortionEqcenter = 0x0004;

    [NativeTypeName("#define AL_DISTORTION_EQBANDWIDTH 0x0005")]
    public const int DistortionEqbandwidth = 0x0005;

    [NativeTypeName("#define AL_ECHO_DELAY 0x0001")]
    public const int EchoDelay = 0x0001;

    [NativeTypeName("#define AL_ECHO_LRDELAY 0x0002")]
    public const int EchoLrdelay = 0x0002;

    [NativeTypeName("#define AL_ECHO_DAMPING 0x0003")]
    public const int EchoDamping = 0x0003;

    [NativeTypeName("#define AL_ECHO_FEEDBACK 0x0004")]
    public const int EchoFeedback = 0x0004;

    [NativeTypeName("#define AL_ECHO_SPREAD 0x0005")]
    public const int EchoSpread = 0x0005;

    [NativeTypeName("#define AL_FLANGER_WAVEFORM 0x0001")]
    public const int FlangerWaveform = 0x0001;

    [NativeTypeName("#define AL_FLANGER_PHASE 0x0002")]
    public const int FlangerPhase = 0x0002;

    [NativeTypeName("#define AL_FLANGER_RATE 0x0003")]
    public const int FlangerRate = 0x0003;

    [NativeTypeName("#define AL_FLANGER_DEPTH 0x0004")]
    public const int FlangerDepth = 0x0004;

    [NativeTypeName("#define AL_FLANGER_FEEDBACK 0x0005")]
    public const int FlangerFeedback = 0x0005;

    [NativeTypeName("#define AL_FLANGER_DELAY 0x0006")]
    public const int FlangerDelay = 0x0006;

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_FREQUENCY 0x0001")]
    public const int FrequencyShifterFrequency = 0x0001;

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_LEFT_DIRECTION 0x0002")]
    public const int FrequencyShifterLeftDirection = 0x0002;

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_RIGHT_DIRECTION 0x0003")]
    public const int FrequencyShifterRightDirection = 0x0003;

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEMEA 0x0001")]
    public const int VocalMorpherPhonemea = 0x0001;

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEMEA_COARSE_TUNING 0x0002")]
    public const int VocalMorpherPhonemeaCoarseTuning = 0x0002;

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEMEB 0x0003")]
    public const int VocalMorpherPhonemeb = 0x0003;

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEMEB_COARSE_TUNING 0x0004")]
    public const int VocalMorpherPhonemebCoarseTuning = 0x0004;

    [NativeTypeName("#define AL_VOCAL_MORPHER_WAVEFORM 0x0005")]
    public const int VocalMorpherWaveform = 0x0005;

    [NativeTypeName("#define AL_VOCAL_MORPHER_RATE 0x0006")]
    public const int VocalMorpherRate = 0x0006;

    [NativeTypeName("#define AL_PITCH_SHIFTER_COARSE_TUNE 0x0001")]
    public const int PitchShifterCoarseTune = 0x0001;

    [NativeTypeName("#define AL_PITCH_SHIFTER_FINE_TUNE 0x0002")]
    public const int PitchShifterFineTune = 0x0002;

    [NativeTypeName("#define AL_RING_MODULATOR_FREQUENCY 0x0001")]
    public const int RingModulatorFrequency = 0x0001;

    [NativeTypeName("#define AL_RING_MODULATOR_HIGHPASS_CUTOFF 0x0002")]
    public const int RingModulatorHighpassCutoff = 0x0002;

    [NativeTypeName("#define AL_RING_MODULATOR_WAVEFORM 0x0003")]
    public const int RingModulatorWaveform = 0x0003;

    [NativeTypeName("#define AL_AUTOWAH_ATTACK_TIME 0x0001")]
    public const int AutowahAttackTime = 0x0001;

    [NativeTypeName("#define AL_AUTOWAH_RELEASE_TIME 0x0002")]
    public const int AutowahReleaseTime = 0x0002;

    [NativeTypeName("#define AL_AUTOWAH_RESONANCE 0x0003")]
    public const int AutowahResonance = 0x0003;

    [NativeTypeName("#define AL_AUTOWAH_PEAK_GAIN 0x0004")]
    public const int AutowahPeakGain = 0x0004;

    [NativeTypeName("#define AL_COMPRESSOR_ONOFF 0x0001")]
    public const int CompressorOnoff = 0x0001;

    [NativeTypeName("#define AL_EQUALIZER_LOW_GAIN 0x0001")]
    public const int EqualizerLowGain = 0x0001;

    [NativeTypeName("#define AL_EQUALIZER_LOW_CUTOFF 0x0002")]
    public const int EqualizerLowCutoff = 0x0002;

    [NativeTypeName("#define AL_EQUALIZER_MID1_GAIN 0x0003")]
    public const int EqualizerMid1Gain = 0x0003;

    [NativeTypeName("#define AL_EQUALIZER_MID1_CENTER 0x0004")]
    public const int EqualizerMid1Center = 0x0004;

    [NativeTypeName("#define AL_EQUALIZER_MID1_WIDTH 0x0005")]
    public const int EqualizerMid1Width = 0x0005;

    [NativeTypeName("#define AL_EQUALIZER_MID2_GAIN 0x0006")]
    public const int EqualizerMid2Gain = 0x0006;

    [NativeTypeName("#define AL_EQUALIZER_MID2_CENTER 0x0007")]
    public const int EqualizerMid2Center = 0x0007;

    [NativeTypeName("#define AL_EQUALIZER_MID2_WIDTH 0x0008")]
    public const int EqualizerMid2Width = 0x0008;

    [NativeTypeName("#define AL_EQUALIZER_HIGH_GAIN 0x0009")]
    public const int EqualizerHighGain = 0x0009;

    [NativeTypeName("#define AL_EQUALIZER_HIGH_CUTOFF 0x000A")]
    public const int EqualizerHighCutoff = 0x000A;

    [NativeTypeName("#define AL_EFFECT_FIRST_PARAMETER 0x0000")]
    public const int EffectFirstParameter = 0x0000;

    [NativeTypeName("#define AL_EFFECT_LAST_PARAMETER 0x8000")]
    public const int EffectLastParameter = 0x8000;

    [NativeTypeName("#define AL_EFFECT_TYPE 0x8001")]
    public const int EffectType = 0x8001;

    [NativeTypeName("#define AL_EFFECT_NULL 0x0000")]
    public const int EffectNull = 0x0000;

    [NativeTypeName("#define AL_EFFECT_REVERB 0x0001")]
    public const int EffectReverb = 0x0001;

    [NativeTypeName("#define AL_EFFECT_CHORUS 0x0002")]
    public const int EffectChorus = 0x0002;

    [NativeTypeName("#define AL_EFFECT_DISTORTION 0x0003")]
    public const int EffectDistortion = 0x0003;

    [NativeTypeName("#define AL_EFFECT_ECHO 0x0004")]
    public const int EffectEcho = 0x0004;

    [NativeTypeName("#define AL_EFFECT_FLANGER 0x0005")]
    public const int EffectFlanger = 0x0005;

    [NativeTypeName("#define AL_EFFECT_FREQUENCY_SHIFTER 0x0006")]
    public const int EffectFrequencyShifter = 0x0006;

    [NativeTypeName("#define AL_EFFECT_VOCAL_MORPHER 0x0007")]
    public const int EffectVocalMorpher = 0x0007;

    [NativeTypeName("#define AL_EFFECT_PITCH_SHIFTER 0x0008")]
    public const int EffectPitchShifter = 0x0008;

    [NativeTypeName("#define AL_EFFECT_RING_MODULATOR 0x0009")]
    public const int EffectRingModulator = 0x0009;

    [NativeTypeName("#define AL_EFFECT_AUTOWAH 0x000A")]
    public const int EffectAutowah = 0x000A;

    [NativeTypeName("#define AL_EFFECT_COMPRESSOR 0x000B")]
    public const int EffectCompressor = 0x000B;

    [NativeTypeName("#define AL_EFFECT_EQUALIZER 0x000C")]
    public const int EffectEqualizer = 0x000C;

    [NativeTypeName("#define AL_EFFECT_EAXREVERB 0x8000")]
    public const int EffectEaxreverb = 0x8000;

    [NativeTypeName("#define AL_EFFECTSLOT_EFFECT 0x0001")]
    public const int EffectslotEffect = 0x0001;

    [NativeTypeName("#define AL_EFFECTSLOT_GAIN 0x0002")]
    public const int EffectslotGain = 0x0002;

    [NativeTypeName("#define AL_EFFECTSLOT_AUXILIARY_SEND_AUTO 0x0003")]
    public const int EffectslotAuxiliarySendAuto = 0x0003;

    [NativeTypeName("#define AL_EFFECTSLOT_NULL 0x0000")]
    public const int EffectslotNull = 0x0000;

    [NativeTypeName("#define AL_LOWPASS_GAIN 0x0001")]
    public const int LowpassGain = 0x0001;

    [NativeTypeName("#define AL_LOWPASS_GAINHF 0x0002")]
    public const int LowpassGainhf = 0x0002;

    [NativeTypeName("#define AL_HIGHPASS_GAIN 0x0001")]
    public const int HighpassGain = 0x0001;

    [NativeTypeName("#define AL_HIGHPASS_GAINLF 0x0002")]
    public const int HighpassGainlf = 0x0002;

    [NativeTypeName("#define AL_BANDPASS_GAIN 0x0001")]
    public const int BandpassGain = 0x0001;

    [NativeTypeName("#define AL_BANDPASS_GAINLF 0x0002")]
    public const int BandpassGainlf = 0x0002;

    [NativeTypeName("#define AL_BANDPASS_GAINHF 0x0003")]
    public const int BandpassGainhf = 0x0003;

    [NativeTypeName("#define AL_FILTER_FIRST_PARAMETER 0x0000")]
    public const int FilterFirstParameter = 0x0000;

    [NativeTypeName("#define AL_FILTER_LAST_PARAMETER 0x8000")]
    public const int FilterLastParameter = 0x8000;

    [NativeTypeName("#define AL_FILTER_TYPE 0x8001")]
    public const int FilterType = 0x8001;

    [NativeTypeName("#define AL_FILTER_NULL 0x0000")]
    public const int FilterNull = 0x0000;

    [NativeTypeName("#define AL_FILTER_LOWPASS 0x0001")]
    public const int FilterLowpass = 0x0001;

    [NativeTypeName("#define AL_FILTER_HIGHPASS 0x0002")]
    public const int FilterHighpass = 0x0002;

    [NativeTypeName("#define AL_FILTER_BANDPASS 0x0003")]
    public const int FilterBandpass = 0x0003;

    [NativeTypeName("#define AL_LOWPASS_MIN_GAIN (0.0f)")]
    public const float LowpassMinGain = (0.0f);

    [NativeTypeName("#define AL_LOWPASS_MAX_GAIN (1.0f)")]
    public const float LowpassMaxGain = (1.0f);

    [NativeTypeName("#define AL_LOWPASS_DEFAULT_GAIN (1.0f)")]
    public const float LowpassDefaultGain = (1.0f);

    [NativeTypeName("#define AL_LOWPASS_MIN_GAINHF (0.0f)")]
    public const float LowpassMinGainhf = (0.0f);

    [NativeTypeName("#define AL_LOWPASS_MAX_GAINHF (1.0f)")]
    public const float LowpassMaxGainhf = (1.0f);

    [NativeTypeName("#define AL_LOWPASS_DEFAULT_GAINHF (1.0f)")]
    public const float LowpassDefaultGainhf = (1.0f);

    [NativeTypeName("#define AL_HIGHPASS_MIN_GAIN (0.0f)")]
    public const float HighpassMinGain = (0.0f);

    [NativeTypeName("#define AL_HIGHPASS_MAX_GAIN (1.0f)")]
    public const float HighpassMaxGain = (1.0f);

    [NativeTypeName("#define AL_HIGHPASS_DEFAULT_GAIN (1.0f)")]
    public const float HighpassDefaultGain = (1.0f);

    [NativeTypeName("#define AL_HIGHPASS_MIN_GAINLF (0.0f)")]
    public const float HighpassMinGainlf = (0.0f);

    [NativeTypeName("#define AL_HIGHPASS_MAX_GAINLF (1.0f)")]
    public const float HighpassMaxGainlf = (1.0f);

    [NativeTypeName("#define AL_HIGHPASS_DEFAULT_GAINLF (1.0f)")]
    public const float HighpassDefaultGainlf = (1.0f);

    [NativeTypeName("#define AL_BANDPASS_MIN_GAIN (0.0f)")]
    public const float BandpassMinGain = (0.0f);

    [NativeTypeName("#define AL_BANDPASS_MAX_GAIN (1.0f)")]
    public const float BandpassMaxGain = (1.0f);

    [NativeTypeName("#define AL_BANDPASS_DEFAULT_GAIN (1.0f)")]
    public const float BandpassDefaultGain = (1.0f);

    [NativeTypeName("#define AL_BANDPASS_MIN_GAINHF (0.0f)")]
    public const float BandpassMinGainhf = (0.0f);

    [NativeTypeName("#define AL_BANDPASS_MAX_GAINHF (1.0f)")]
    public const float BandpassMaxGainhf = (1.0f);

    [NativeTypeName("#define AL_BANDPASS_DEFAULT_GAINHF (1.0f)")]
    public const float BandpassDefaultGainhf = (1.0f);

    [NativeTypeName("#define AL_BANDPASS_MIN_GAINLF (0.0f)")]
    public const float BandpassMinGainlf = (0.0f);

    [NativeTypeName("#define AL_BANDPASS_MAX_GAINLF (1.0f)")]
    public const float BandpassMaxGainlf = (1.0f);

    [NativeTypeName("#define AL_BANDPASS_DEFAULT_GAINLF (1.0f)")]
    public const float BandpassDefaultGainlf = (1.0f);

    [NativeTypeName("#define AL_REVERB_MIN_DENSITY (0.0f)")]
    public const float ReverbMinDensity = (0.0f);

    [NativeTypeName("#define AL_REVERB_MAX_DENSITY (1.0f)")]
    public const float ReverbMaxDensity = (1.0f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_DENSITY (1.0f)")]
    public const float ReverbDefaultDensity = (1.0f);

    [NativeTypeName("#define AL_REVERB_MIN_DIFFUSION (0.0f)")]
    public const float ReverbMinDiffusion = (0.0f);

    [NativeTypeName("#define AL_REVERB_MAX_DIFFUSION (1.0f)")]
    public const float ReverbMaxDiffusion = (1.0f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_DIFFUSION (1.0f)")]
    public const float ReverbDefaultDiffusion = (1.0f);

    [NativeTypeName("#define AL_REVERB_MIN_GAIN (0.0f)")]
    public const float ReverbMinGain = (0.0f);

    [NativeTypeName("#define AL_REVERB_MAX_GAIN (1.0f)")]
    public const float ReverbMaxGain = (1.0f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_GAIN (0.32f)")]
    public const float ReverbDefaultGain = (0.32f);

    [NativeTypeName("#define AL_REVERB_MIN_GAINHF (0.0f)")]
    public const float ReverbMinGainhf = (0.0f);

    [NativeTypeName("#define AL_REVERB_MAX_GAINHF (1.0f)")]
    public const float ReverbMaxGainhf = (1.0f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_GAINHF (0.89f)")]
    public const float ReverbDefaultGainhf = (0.89f);

    [NativeTypeName("#define AL_REVERB_MIN_DECAY_TIME (0.1f)")]
    public const float ReverbMinDecayTime = (0.1f);

    [NativeTypeName("#define AL_REVERB_MAX_DECAY_TIME (20.0f)")]
    public const float ReverbMaxDecayTime = (20.0f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_DECAY_TIME (1.49f)")]
    public const float ReverbDefaultDecayTime = (1.49f);

    [NativeTypeName("#define AL_REVERB_MIN_DECAY_HFRATIO (0.1f)")]
    public const float ReverbMinDecayHfratio = (0.1f);

    [NativeTypeName("#define AL_REVERB_MAX_DECAY_HFRATIO (2.0f)")]
    public const float ReverbMaxDecayHfratio = (2.0f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_DECAY_HFRATIO (0.83f)")]
    public const float ReverbDefaultDecayHfratio = (0.83f);

    [NativeTypeName("#define AL_REVERB_MIN_REFLECTIONS_GAIN (0.0f)")]
    public const float ReverbMinReflectionsGain = (0.0f);

    [NativeTypeName("#define AL_REVERB_MAX_REFLECTIONS_GAIN (3.16f)")]
    public const float ReverbMaxReflectionsGain = (3.16f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_REFLECTIONS_GAIN (0.05f)")]
    public const float ReverbDefaultReflectionsGain = (0.05f);

    [NativeTypeName("#define AL_REVERB_MIN_REFLECTIONS_DELAY (0.0f)")]
    public const float ReverbMinReflectionsDelay = (0.0f);

    [NativeTypeName("#define AL_REVERB_MAX_REFLECTIONS_DELAY (0.3f)")]
    public const float ReverbMaxReflectionsDelay = (0.3f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_REFLECTIONS_DELAY (0.007f)")]
    public const float ReverbDefaultReflectionsDelay = (0.007f);

    [NativeTypeName("#define AL_REVERB_MIN_LATE_REVERB_GAIN (0.0f)")]
    public const float ReverbMinLateReverbGain = (0.0f);

    [NativeTypeName("#define AL_REVERB_MAX_LATE_REVERB_GAIN (10.0f)")]
    public const float ReverbMaxLateReverbGain = (10.0f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_LATE_REVERB_GAIN (1.26f)")]
    public const float ReverbDefaultLateReverbGain = (1.26f);

    [NativeTypeName("#define AL_REVERB_MIN_LATE_REVERB_DELAY (0.0f)")]
    public const float ReverbMinLateReverbDelay = (0.0f);

    [NativeTypeName("#define AL_REVERB_MAX_LATE_REVERB_DELAY (0.1f)")]
    public const float ReverbMaxLateReverbDelay = (0.1f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_LATE_REVERB_DELAY (0.011f)")]
    public const float ReverbDefaultLateReverbDelay = (0.011f);

    [NativeTypeName("#define AL_REVERB_MIN_AIR_ABSORPTION_GAINHF (0.892f)")]
    public const float ReverbMinAirAbsorptionGainhf = (0.892f);

    [NativeTypeName("#define AL_REVERB_MAX_AIR_ABSORPTION_GAINHF (1.0f)")]
    public const float ReverbMaxAirAbsorptionGainhf = (1.0f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_AIR_ABSORPTION_GAINHF (0.994f)")]
    public const float ReverbDefaultAirAbsorptionGainhf = (0.994f);

    [NativeTypeName("#define AL_REVERB_MIN_ROOM_ROLLOFF_FACTOR (0.0f)")]
    public const float ReverbMinRoomRolloffFactor = (0.0f);

    [NativeTypeName("#define AL_REVERB_MAX_ROOM_ROLLOFF_FACTOR (10.0f)")]
    public const float ReverbMaxRoomRolloffFactor = (10.0f);

    [NativeTypeName("#define AL_REVERB_DEFAULT_ROOM_ROLLOFF_FACTOR (0.0f)")]
    public const float ReverbDefaultRoomRolloffFactor = (0.0f);

    [NativeTypeName("#define AL_REVERB_MIN_DECAY_HFLIMIT AL_FALSE")]
    public const int ReverbMinDecayHflimit = 0;

    [NativeTypeName("#define AL_REVERB_MAX_DECAY_HFLIMIT AL_TRUE")]
    public const int ReverbMaxDecayHflimit = 1;

    [NativeTypeName("#define AL_REVERB_DEFAULT_DECAY_HFLIMIT AL_TRUE")]
    public const int ReverbDefaultDecayHflimit = 1;

    [NativeTypeName("#define AL_EAXREVERB_MIN_DENSITY (0.0f)")]
    public const float EaxreverbMinDensity = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_DENSITY (1.0f)")]
    public const float EaxreverbMaxDensity = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_DENSITY (1.0f)")]
    public const float EaxreverbDefaultDensity = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_DIFFUSION (0.0f)")]
    public const float EaxreverbMinDiffusion = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_DIFFUSION (1.0f)")]
    public const float EaxreverbMaxDiffusion = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_DIFFUSION (1.0f)")]
    public const float EaxreverbDefaultDiffusion = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_GAIN (0.0f)")]
    public const float EaxreverbMinGain = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_GAIN (1.0f)")]
    public const float EaxreverbMaxGain = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_GAIN (0.32f)")]
    public const float EaxreverbDefaultGain = (0.32f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_GAINHF (0.0f)")]
    public const float EaxreverbMinGainhf = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_GAINHF (1.0f)")]
    public const float EaxreverbMaxGainhf = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_GAINHF (0.89f)")]
    public const float EaxreverbDefaultGainhf = (0.89f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_GAINLF (0.0f)")]
    public const float EaxreverbMinGainlf = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_GAINLF (1.0f)")]
    public const float EaxreverbMaxGainlf = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_GAINLF (1.0f)")]
    public const float EaxreverbDefaultGainlf = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_DECAY_TIME (0.1f)")]
    public const float EaxreverbMinDecayTime = (0.1f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_DECAY_TIME (20.0f)")]
    public const float EaxreverbMaxDecayTime = (20.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_DECAY_TIME (1.49f)")]
    public const float EaxreverbDefaultDecayTime = (1.49f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_DECAY_HFRATIO (0.1f)")]
    public const float EaxreverbMinDecayHfratio = (0.1f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_DECAY_HFRATIO (2.0f)")]
    public const float EaxreverbMaxDecayHfratio = (2.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_DECAY_HFRATIO (0.83f)")]
    public const float EaxreverbDefaultDecayHfratio = (0.83f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_DECAY_LFRATIO (0.1f)")]
    public const float EaxreverbMinDecayLfratio = (0.1f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_DECAY_LFRATIO (2.0f)")]
    public const float EaxreverbMaxDecayLfratio = (2.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_DECAY_LFRATIO (1.0f)")]
    public const float EaxreverbDefaultDecayLfratio = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_REFLECTIONS_GAIN (0.0f)")]
    public const float EaxreverbMinReflectionsGain = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_REFLECTIONS_GAIN (3.16f)")]
    public const float EaxreverbMaxReflectionsGain = (3.16f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_REFLECTIONS_GAIN (0.05f)")]
    public const float EaxreverbDefaultReflectionsGain = (0.05f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_REFLECTIONS_DELAY (0.0f)")]
    public const float EaxreverbMinReflectionsDelay = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_REFLECTIONS_DELAY (0.3f)")]
    public const float EaxreverbMaxReflectionsDelay = (0.3f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_REFLECTIONS_DELAY (0.007f)")]
    public const float EaxreverbDefaultReflectionsDelay = (0.007f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_REFLECTIONS_PAN_XYZ (0.0f)")]
    public const float EaxreverbDefaultReflectionsPanXyz = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_LATE_REVERB_GAIN (0.0f)")]
    public const float EaxreverbMinLateReverbGain = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_LATE_REVERB_GAIN (10.0f)")]
    public const float EaxreverbMaxLateReverbGain = (10.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_LATE_REVERB_GAIN (1.26f)")]
    public const float EaxreverbDefaultLateReverbGain = (1.26f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_LATE_REVERB_DELAY (0.0f)")]
    public const float EaxreverbMinLateReverbDelay = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_LATE_REVERB_DELAY (0.1f)")]
    public const float EaxreverbMaxLateReverbDelay = (0.1f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_LATE_REVERB_DELAY (0.011f)")]
    public const float EaxreverbDefaultLateReverbDelay = (0.011f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_LATE_REVERB_PAN_XYZ (0.0f)")]
    public const float EaxreverbDefaultLateReverbPanXyz = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_ECHO_TIME (0.075f)")]
    public const float EaxreverbMinEchoTime = (0.075f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_ECHO_TIME (0.25f)")]
    public const float EaxreverbMaxEchoTime = (0.25f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_ECHO_TIME (0.25f)")]
    public const float EaxreverbDefaultEchoTime = (0.25f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_ECHO_DEPTH (0.0f)")]
    public const float EaxreverbMinEchoDepth = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_ECHO_DEPTH (1.0f)")]
    public const float EaxreverbMaxEchoDepth = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_ECHO_DEPTH (0.0f)")]
    public const float EaxreverbDefaultEchoDepth = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_MODULATION_TIME (0.04f)")]
    public const float EaxreverbMinModulationTime = (0.04f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_MODULATION_TIME (4.0f)")]
    public const float EaxreverbMaxModulationTime = (4.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_MODULATION_TIME (0.25f)")]
    public const float EaxreverbDefaultModulationTime = (0.25f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_MODULATION_DEPTH (0.0f)")]
    public const float EaxreverbMinModulationDepth = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_MODULATION_DEPTH (1.0f)")]
    public const float EaxreverbMaxModulationDepth = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_MODULATION_DEPTH (0.0f)")]
    public const float EaxreverbDefaultModulationDepth = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_AIR_ABSORPTION_GAINHF (0.892f)")]
    public const float EaxreverbMinAirAbsorptionGainhf = (0.892f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_AIR_ABSORPTION_GAINHF (1.0f)")]
    public const float EaxreverbMaxAirAbsorptionGainhf = (1.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_AIR_ABSORPTION_GAINHF (0.994f)")]
    public const float EaxreverbDefaultAirAbsorptionGainhf = (0.994f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_HFREFERENCE (1000.0f)")]
    public const float EaxreverbMinHfreference = (1000.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_HFREFERENCE (20000.0f)")]
    public const float EaxreverbMaxHfreference = (20000.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_HFREFERENCE (5000.0f)")]
    public const float EaxreverbDefaultHfreference = (5000.0f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_LFREFERENCE (20.0f)")]
    public const float EaxreverbMinLfreference = (20.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_LFREFERENCE (1000.0f)")]
    public const float EaxreverbMaxLfreference = (1000.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_LFREFERENCE (250.0f)")]
    public const float EaxreverbDefaultLfreference = (250.0f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_ROOM_ROLLOFF_FACTOR (0.0f)")]
    public const float EaxreverbMinRoomRolloffFactor = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MAX_ROOM_ROLLOFF_FACTOR (10.0f)")]
    public const float EaxreverbMaxRoomRolloffFactor = (10.0f);

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_ROOM_ROLLOFF_FACTOR (0.0f)")]
    public const float EaxreverbDefaultRoomRolloffFactor = (0.0f);

    [NativeTypeName("#define AL_EAXREVERB_MIN_DECAY_HFLIMIT AL_FALSE")]
    public const int EaxreverbMinDecayHflimit = 0;

    [NativeTypeName("#define AL_EAXREVERB_MAX_DECAY_HFLIMIT AL_TRUE")]
    public const int EaxreverbMaxDecayHflimit = 1;

    [NativeTypeName("#define AL_EAXREVERB_DEFAULT_DECAY_HFLIMIT AL_TRUE")]
    public const int EaxreverbDefaultDecayHflimit = 1;

    [NativeTypeName("#define AL_CHORUS_WAVEFORM_SINUSOID (0)")]
    public const int ChorusWaveformSinusoid = (0);

    [NativeTypeName("#define AL_CHORUS_WAVEFORM_TRIANGLE (1)")]
    public const int ChorusWaveformTriangle = (1);

    [NativeTypeName("#define AL_CHORUS_MIN_WAVEFORM (0)")]
    public const int ChorusMinWaveform = (0);

    [NativeTypeName("#define AL_CHORUS_MAX_WAVEFORM (1)")]
    public const int ChorusMaxWaveform = (1);

    [NativeTypeName("#define AL_CHORUS_DEFAULT_WAVEFORM (1)")]
    public const int ChorusDefaultWaveform = (1);

    [NativeTypeName("#define AL_CHORUS_MIN_PHASE (-180)")]
    public const int ChorusMinPhase = (-180);

    [NativeTypeName("#define AL_CHORUS_MAX_PHASE (180)")]
    public const int ChorusMaxPhase = (180);

    [NativeTypeName("#define AL_CHORUS_DEFAULT_PHASE (90)")]
    public const int ChorusDefaultPhase = (90);

    [NativeTypeName("#define AL_CHORUS_MIN_RATE (0.0f)")]
    public const float ChorusMinRate = (0.0f);

    [NativeTypeName("#define AL_CHORUS_MAX_RATE (10.0f)")]
    public const float ChorusMaxRate = (10.0f);

    [NativeTypeName("#define AL_CHORUS_DEFAULT_RATE (1.1f)")]
    public const float ChorusDefaultRate = (1.1f);

    [NativeTypeName("#define AL_CHORUS_MIN_DEPTH (0.0f)")]
    public const float ChorusMinDepth = (0.0f);

    [NativeTypeName("#define AL_CHORUS_MAX_DEPTH (1.0f)")]
    public const float ChorusMaxDepth = (1.0f);

    [NativeTypeName("#define AL_CHORUS_DEFAULT_DEPTH (0.1f)")]
    public const float ChorusDefaultDepth = (0.1f);

    [NativeTypeName("#define AL_CHORUS_MIN_FEEDBACK (-1.0f)")]
    public const float ChorusMinFeedback = (-1.0f);

    [NativeTypeName("#define AL_CHORUS_MAX_FEEDBACK (1.0f)")]
    public const float ChorusMaxFeedback = (1.0f);

    [NativeTypeName("#define AL_CHORUS_DEFAULT_FEEDBACK (0.25f)")]
    public const float ChorusDefaultFeedback = (0.25f);

    [NativeTypeName("#define AL_CHORUS_MIN_DELAY (0.0f)")]
    public const float ChorusMinDelay = (0.0f);

    [NativeTypeName("#define AL_CHORUS_MAX_DELAY (0.016f)")]
    public const float ChorusMaxDelay = (0.016f);

    [NativeTypeName("#define AL_CHORUS_DEFAULT_DELAY (0.016f)")]
    public const float ChorusDefaultDelay = (0.016f);

    [NativeTypeName("#define AL_DISTORTION_MIN_EDGE (0.0f)")]
    public const float DistortionMinEdge = (0.0f);

    [NativeTypeName("#define AL_DISTORTION_MAX_EDGE (1.0f)")]
    public const float DistortionMaxEdge = (1.0f);

    [NativeTypeName("#define AL_DISTORTION_DEFAULT_EDGE (0.2f)")]
    public const float DistortionDefaultEdge = (0.2f);

    [NativeTypeName("#define AL_DISTORTION_MIN_GAIN (0.01f)")]
    public const float DistortionMinGain = (0.01f);

    [NativeTypeName("#define AL_DISTORTION_MAX_GAIN (1.0f)")]
    public const float DistortionMaxGain = (1.0f);

    [NativeTypeName("#define AL_DISTORTION_DEFAULT_GAIN (0.05f)")]
    public const float DistortionDefaultGain = (0.05f);

    [NativeTypeName("#define AL_DISTORTION_MIN_LOWPASS_CUTOFF (80.0f)")]
    public const float DistortionMinLowpassCutoff = (80.0f);

    [NativeTypeName("#define AL_DISTORTION_MAX_LOWPASS_CUTOFF (24000.0f)")]
    public const float DistortionMaxLowpassCutoff = (24000.0f);

    [NativeTypeName("#define AL_DISTORTION_DEFAULT_LOWPASS_CUTOFF (8000.0f)")]
    public const float DistortionDefaultLowpassCutoff = (8000.0f);

    [NativeTypeName("#define AL_DISTORTION_MIN_EQCENTER (80.0f)")]
    public const float DistortionMinEqcenter = (80.0f);

    [NativeTypeName("#define AL_DISTORTION_MAX_EQCENTER (24000.0f)")]
    public const float DistortionMaxEqcenter = (24000.0f);

    [NativeTypeName("#define AL_DISTORTION_DEFAULT_EQCENTER (3600.0f)")]
    public const float DistortionDefaultEqcenter = (3600.0f);

    [NativeTypeName("#define AL_DISTORTION_MIN_EQBANDWIDTH (80.0f)")]
    public const float DistortionMinEqbandwidth = (80.0f);

    [NativeTypeName("#define AL_DISTORTION_MAX_EQBANDWIDTH (24000.0f)")]
    public const float DistortionMaxEqbandwidth = (24000.0f);

    [NativeTypeName("#define AL_DISTORTION_DEFAULT_EQBANDWIDTH (3600.0f)")]
    public const float DistortionDefaultEqbandwidth = (3600.0f);

    [NativeTypeName("#define AL_ECHO_MIN_DELAY (0.0f)")]
    public const float EchoMinDelay = (0.0f);

    [NativeTypeName("#define AL_ECHO_MAX_DELAY (0.207f)")]
    public const float EchoMaxDelay = (0.207f);

    [NativeTypeName("#define AL_ECHO_DEFAULT_DELAY (0.1f)")]
    public const float EchoDefaultDelay = (0.1f);

    [NativeTypeName("#define AL_ECHO_MIN_LRDELAY (0.0f)")]
    public const float EchoMinLrdelay = (0.0f);

    [NativeTypeName("#define AL_ECHO_MAX_LRDELAY (0.404f)")]
    public const float EchoMaxLrdelay = (0.404f);

    [NativeTypeName("#define AL_ECHO_DEFAULT_LRDELAY (0.1f)")]
    public const float EchoDefaultLrdelay = (0.1f);

    [NativeTypeName("#define AL_ECHO_MIN_DAMPING (0.0f)")]
    public const float EchoMinDamping = (0.0f);

    [NativeTypeName("#define AL_ECHO_MAX_DAMPING (0.99f)")]
    public const float EchoMaxDamping = (0.99f);

    [NativeTypeName("#define AL_ECHO_DEFAULT_DAMPING (0.5f)")]
    public const float EchoDefaultDamping = (0.5f);

    [NativeTypeName("#define AL_ECHO_MIN_FEEDBACK (0.0f)")]
    public const float EchoMinFeedback = (0.0f);

    [NativeTypeName("#define AL_ECHO_MAX_FEEDBACK (1.0f)")]
    public const float EchoMaxFeedback = (1.0f);

    [NativeTypeName("#define AL_ECHO_DEFAULT_FEEDBACK (0.5f)")]
    public const float EchoDefaultFeedback = (0.5f);

    [NativeTypeName("#define AL_ECHO_MIN_SPREAD (-1.0f)")]
    public const float EchoMinSpread = (-1.0f);

    [NativeTypeName("#define AL_ECHO_MAX_SPREAD (1.0f)")]
    public const float EchoMaxSpread = (1.0f);

    [NativeTypeName("#define AL_ECHO_DEFAULT_SPREAD (-1.0f)")]
    public const float EchoDefaultSpread = (-1.0f);

    [NativeTypeName("#define AL_FLANGER_WAVEFORM_SINUSOID (0)")]
    public const int FlangerWaveformSinusoid = (0);

    [NativeTypeName("#define AL_FLANGER_WAVEFORM_TRIANGLE (1)")]
    public const int FlangerWaveformTriangle = (1);

    [NativeTypeName("#define AL_FLANGER_MIN_WAVEFORM (0)")]
    public const int FlangerMinWaveform = (0);

    [NativeTypeName("#define AL_FLANGER_MAX_WAVEFORM (1)")]
    public const int FlangerMaxWaveform = (1);

    [NativeTypeName("#define AL_FLANGER_DEFAULT_WAVEFORM (1)")]
    public const int FlangerDefaultWaveform = (1);

    [NativeTypeName("#define AL_FLANGER_MIN_PHASE (-180)")]
    public const int FlangerMinPhase = (-180);

    [NativeTypeName("#define AL_FLANGER_MAX_PHASE (180)")]
    public const int FlangerMaxPhase = (180);

    [NativeTypeName("#define AL_FLANGER_DEFAULT_PHASE (0)")]
    public const int FlangerDefaultPhase = (0);

    [NativeTypeName("#define AL_FLANGER_MIN_RATE (0.0f)")]
    public const float FlangerMinRate = (0.0f);

    [NativeTypeName("#define AL_FLANGER_MAX_RATE (10.0f)")]
    public const float FlangerMaxRate = (10.0f);

    [NativeTypeName("#define AL_FLANGER_DEFAULT_RATE (0.27f)")]
    public const float FlangerDefaultRate = (0.27f);

    [NativeTypeName("#define AL_FLANGER_MIN_DEPTH (0.0f)")]
    public const float FlangerMinDepth = (0.0f);

    [NativeTypeName("#define AL_FLANGER_MAX_DEPTH (1.0f)")]
    public const float FlangerMaxDepth = (1.0f);

    [NativeTypeName("#define AL_FLANGER_DEFAULT_DEPTH (1.0f)")]
    public const float FlangerDefaultDepth = (1.0f);

    [NativeTypeName("#define AL_FLANGER_MIN_FEEDBACK (-1.0f)")]
    public const float FlangerMinFeedback = (-1.0f);

    [NativeTypeName("#define AL_FLANGER_MAX_FEEDBACK (1.0f)")]
    public const float FlangerMaxFeedback = (1.0f);

    [NativeTypeName("#define AL_FLANGER_DEFAULT_FEEDBACK (-0.5f)")]
    public const float FlangerDefaultFeedback = (-0.5f);

    [NativeTypeName("#define AL_FLANGER_MIN_DELAY (0.0f)")]
    public const float FlangerMinDelay = (0.0f);

    [NativeTypeName("#define AL_FLANGER_MAX_DELAY (0.004f)")]
    public const float FlangerMaxDelay = (0.004f);

    [NativeTypeName("#define AL_FLANGER_DEFAULT_DELAY (0.002f)")]
    public const float FlangerDefaultDelay = (0.002f);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_MIN_FREQUENCY (0.0f)")]
    public const float FrequencyShifterMinFrequency = (0.0f);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_MAX_FREQUENCY (24000.0f)")]
    public const float FrequencyShifterMaxFrequency = (24000.0f);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_DEFAULT_FREQUENCY (0.0f)")]
    public const float FrequencyShifterDefaultFrequency = (0.0f);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_MIN_LEFT_DIRECTION (0)")]
    public const int FrequencyShifterMinLeftDirection = (0);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_MAX_LEFT_DIRECTION (2)")]
    public const int FrequencyShifterMaxLeftDirection = (2);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_DEFAULT_LEFT_DIRECTION (0)")]
    public const int FrequencyShifterDefaultLeftDirection = (0);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_DIRECTION_DOWN (0)")]
    public const int FrequencyShifterDirectionDown = (0);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_DIRECTION_UP (1)")]
    public const int FrequencyShifterDirectionUp = (1);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_DIRECTION_OFF (2)")]
    public const int FrequencyShifterDirectionOff = (2);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_MIN_RIGHT_DIRECTION (0)")]
    public const int FrequencyShifterMinRightDirection = (0);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_MAX_RIGHT_DIRECTION (2)")]
    public const int FrequencyShifterMaxRightDirection = (2);

    [NativeTypeName("#define AL_FREQUENCY_SHIFTER_DEFAULT_RIGHT_DIRECTION (0)")]
    public const int FrequencyShifterDefaultRightDirection = (0);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MIN_PHONEMEA (0)")]
    public const int VocalMorpherMinPhonemea = (0);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MAX_PHONEMEA (29)")]
    public const int VocalMorpherMaxPhonemea = (29);

    [NativeTypeName("#define AL_VOCAL_MORPHER_DEFAULT_PHONEMEA (0)")]
    public const int VocalMorpherDefaultPhonemea = (0);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MIN_PHONEMEA_COARSE_TUNING (-24)")]
    public const int VocalMorpherMinPhonemeaCoarseTuning = (-24);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MAX_PHONEMEA_COARSE_TUNING (24)")]
    public const int VocalMorpherMaxPhonemeaCoarseTuning = (24);

    [NativeTypeName("#define AL_VOCAL_MORPHER_DEFAULT_PHONEMEA_COARSE_TUNING (0)")]
    public const int VocalMorpherDefaultPhonemeaCoarseTuning = (0);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MIN_PHONEMEB (0)")]
    public const int VocalMorpherMinPhonemeb = (0);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MAX_PHONEMEB (29)")]
    public const int VocalMorpherMaxPhonemeb = (29);

    [NativeTypeName("#define AL_VOCAL_MORPHER_DEFAULT_PHONEMEB (10)")]
    public const int VocalMorpherDefaultPhonemeb = (10);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MIN_PHONEMEB_COARSE_TUNING (-24)")]
    public const int VocalMorpherMinPhonemebCoarseTuning = (-24);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MAX_PHONEMEB_COARSE_TUNING (24)")]
    public const int VocalMorpherMaxPhonemebCoarseTuning = (24);

    [NativeTypeName("#define AL_VOCAL_MORPHER_DEFAULT_PHONEMEB_COARSE_TUNING (0)")]
    public const int VocalMorpherDefaultPhonemebCoarseTuning = (0);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_A (0)")]
    public const int VocalMorpherPhonemeA = (0);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_E (1)")]
    public const int VocalMorpherPhonemeE = (1);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_I (2)")]
    public const int VocalMorpherPhonemeI = (2);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_O (3)")]
    public const int VocalMorpherPhonemeO = (3);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_U (4)")]
    public const int VocalMorpherPhonemeU = (4);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_AA (5)")]
    public const int VocalMorpherPhonemeAa = (5);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_AE (6)")]
    public const int VocalMorpherPhonemeAe = (6);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_AH (7)")]
    public const int VocalMorpherPhonemeAh = (7);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_AO (8)")]
    public const int VocalMorpherPhonemeAo = (8);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_EH (9)")]
    public const int VocalMorpherPhonemeEh = (9);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_ER (10)")]
    public const int VocalMorpherPhonemeEr = (10);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_IH (11)")]
    public const int VocalMorpherPhonemeIh = (11);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_IY (12)")]
    public const int VocalMorpherPhonemeIy = (12);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_UH (13)")]
    public const int VocalMorpherPhonemeUh = (13);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_UW (14)")]
    public const int VocalMorpherPhonemeUw = (14);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_B (15)")]
    public const int VocalMorpherPhonemeB = (15);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_D (16)")]
    public const int VocalMorpherPhonemeD = (16);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_F (17)")]
    public const int VocalMorpherPhonemeF = (17);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_G (18)")]
    public const int VocalMorpherPhonemeG = (18);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_J (19)")]
    public const int VocalMorpherPhonemeJ = (19);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_K (20)")]
    public const int VocalMorpherPhonemeK = (20);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_L (21)")]
    public const int VocalMorpherPhonemeL = (21);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_M (22)")]
    public const int VocalMorpherPhonemeM = (22);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_N (23)")]
    public const int VocalMorpherPhonemeN = (23);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_P (24)")]
    public const int VocalMorpherPhonemeP = (24);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_R (25)")]
    public const int VocalMorpherPhonemeR = (25);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_S (26)")]
    public const int VocalMorpherPhonemeS = (26);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_T (27)")]
    public const int VocalMorpherPhonemeT = (27);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_V (28)")]
    public const int VocalMorpherPhonemeV = (28);

    [NativeTypeName("#define AL_VOCAL_MORPHER_PHONEME_Z (29)")]
    public const int VocalMorpherPhonemeZ = (29);

    [NativeTypeName("#define AL_VOCAL_MORPHER_WAVEFORM_SINUSOID (0)")]
    public const int VocalMorpherWaveformSinusoid = (0);

    [NativeTypeName("#define AL_VOCAL_MORPHER_WAVEFORM_TRIANGLE (1)")]
    public const int VocalMorpherWaveformTriangle = (1);

    [NativeTypeName("#define AL_VOCAL_MORPHER_WAVEFORM_SAWTOOTH (2)")]
    public const int VocalMorpherWaveformSawtooth = (2);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MIN_WAVEFORM (0)")]
    public const int VocalMorpherMinWaveform = (0);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MAX_WAVEFORM (2)")]
    public const int VocalMorpherMaxWaveform = (2);

    [NativeTypeName("#define AL_VOCAL_MORPHER_DEFAULT_WAVEFORM (0)")]
    public const int VocalMorpherDefaultWaveform = (0);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MIN_RATE (0.0f)")]
    public const float VocalMorpherMinRate = (0.0f);

    [NativeTypeName("#define AL_VOCAL_MORPHER_MAX_RATE (10.0f)")]
    public const float VocalMorpherMaxRate = (10.0f);

    [NativeTypeName("#define AL_VOCAL_MORPHER_DEFAULT_RATE (1.41f)")]
    public const float VocalMorpherDefaultRate = (1.41f);

    [NativeTypeName("#define AL_PITCH_SHIFTER_MIN_COARSE_TUNE (-12)")]
    public const int PitchShifterMinCoarseTune = (-12);

    [NativeTypeName("#define AL_PITCH_SHIFTER_MAX_COARSE_TUNE (12)")]
    public const int PitchShifterMaxCoarseTune = (12);

    [NativeTypeName("#define AL_PITCH_SHIFTER_DEFAULT_COARSE_TUNE (12)")]
    public const int PitchShifterDefaultCoarseTune = (12);

    [NativeTypeName("#define AL_PITCH_SHIFTER_MIN_FINE_TUNE (-50)")]
    public const int PitchShifterMinFineTune = (-50);

    [NativeTypeName("#define AL_PITCH_SHIFTER_MAX_FINE_TUNE (50)")]
    public const int PitchShifterMaxFineTune = (50);

    [NativeTypeName("#define AL_PITCH_SHIFTER_DEFAULT_FINE_TUNE (0)")]
    public const int PitchShifterDefaultFineTune = (0);

    [NativeTypeName("#define AL_RING_MODULATOR_MIN_FREQUENCY (0.0f)")]
    public const float RingModulatorMinFrequency = (0.0f);

    [NativeTypeName("#define AL_RING_MODULATOR_MAX_FREQUENCY (8000.0f)")]
    public const float RingModulatorMaxFrequency = (8000.0f);

    [NativeTypeName("#define AL_RING_MODULATOR_DEFAULT_FREQUENCY (440.0f)")]
    public const float RingModulatorDefaultFrequency = (440.0f);

    [NativeTypeName("#define AL_RING_MODULATOR_MIN_HIGHPASS_CUTOFF (0.0f)")]
    public const float RingModulatorMinHighpassCutoff = (0.0f);

    [NativeTypeName("#define AL_RING_MODULATOR_MAX_HIGHPASS_CUTOFF (24000.0f)")]
    public const float RingModulatorMaxHighpassCutoff = (24000.0f);

    [NativeTypeName("#define AL_RING_MODULATOR_DEFAULT_HIGHPASS_CUTOFF (800.0f)")]
    public const float RingModulatorDefaultHighpassCutoff = (800.0f);

    [NativeTypeName("#define AL_RING_MODULATOR_SINUSOID (0)")]
    public const int RingModulatorSinusoid = (0);

    [NativeTypeName("#define AL_RING_MODULATOR_SAWTOOTH (1)")]
    public const int RingModulatorSawtooth = (1);

    [NativeTypeName("#define AL_RING_MODULATOR_SQUARE (2)")]
    public const int RingModulatorSquare = (2);

    [NativeTypeName("#define AL_RING_MODULATOR_MIN_WAVEFORM (0)")]
    public const int RingModulatorMinWaveform = (0);

    [NativeTypeName("#define AL_RING_MODULATOR_MAX_WAVEFORM (2)")]
    public const int RingModulatorMaxWaveform = (2);

    [NativeTypeName("#define AL_RING_MODULATOR_DEFAULT_WAVEFORM (0)")]
    public const int RingModulatorDefaultWaveform = (0);

    [NativeTypeName("#define AL_AUTOWAH_MIN_ATTACK_TIME (0.0001f)")]
    public const float AutowahMinAttackTime = (0.0001f);

    [NativeTypeName("#define AL_AUTOWAH_MAX_ATTACK_TIME (1.0f)")]
    public const float AutowahMaxAttackTime = (1.0f);

    [NativeTypeName("#define AL_AUTOWAH_DEFAULT_ATTACK_TIME (0.06f)")]
    public const float AutowahDefaultAttackTime = (0.06f);

    [NativeTypeName("#define AL_AUTOWAH_MIN_RELEASE_TIME (0.0001f)")]
    public const float AutowahMinReleaseTime = (0.0001f);

    [NativeTypeName("#define AL_AUTOWAH_MAX_RELEASE_TIME (1.0f)")]
    public const float AutowahMaxReleaseTime = (1.0f);

    [NativeTypeName("#define AL_AUTOWAH_DEFAULT_RELEASE_TIME (0.06f)")]
    public const float AutowahDefaultReleaseTime = (0.06f);

    [NativeTypeName("#define AL_AUTOWAH_MIN_RESONANCE (2.0f)")]
    public const float AutowahMinResonance = (2.0f);

    [NativeTypeName("#define AL_AUTOWAH_MAX_RESONANCE (1000.0f)")]
    public const float AutowahMaxResonance = (1000.0f);

    [NativeTypeName("#define AL_AUTOWAH_DEFAULT_RESONANCE (1000.0f)")]
    public const float AutowahDefaultResonance = (1000.0f);

    [NativeTypeName("#define AL_AUTOWAH_MIN_PEAK_GAIN (0.00003f)")]
    public const float AutowahMinPeakGain = (0.00003f);

    [NativeTypeName("#define AL_AUTOWAH_MAX_PEAK_GAIN (31621.0f)")]
    public const float AutowahMaxPeakGain = (31621.0f);

    [NativeTypeName("#define AL_AUTOWAH_DEFAULT_PEAK_GAIN (11.22f)")]
    public const float AutowahDefaultPeakGain = (11.22f);

    [NativeTypeName("#define AL_COMPRESSOR_MIN_ONOFF (0)")]
    public const int CompressorMinOnoff = (0);

    [NativeTypeName("#define AL_COMPRESSOR_MAX_ONOFF (1)")]
    public const int CompressorMaxOnoff = (1);

    [NativeTypeName("#define AL_COMPRESSOR_DEFAULT_ONOFF (1)")]
    public const int CompressorDefaultOnoff = (1);

    [NativeTypeName("#define AL_EQUALIZER_MIN_LOW_GAIN (0.126f)")]
    public const float EqualizerMinLowGain = (0.126f);

    [NativeTypeName("#define AL_EQUALIZER_MAX_LOW_GAIN (7.943f)")]
    public const float EqualizerMaxLowGain = (7.943f);

    [NativeTypeName("#define AL_EQUALIZER_DEFAULT_LOW_GAIN (1.0f)")]
    public const float EqualizerDefaultLowGain = (1.0f);

    [NativeTypeName("#define AL_EQUALIZER_MIN_LOW_CUTOFF (50.0f)")]
    public const float EqualizerMinLowCutoff = (50.0f);

    [NativeTypeName("#define AL_EQUALIZER_MAX_LOW_CUTOFF (800.0f)")]
    public const float EqualizerMaxLowCutoff = (800.0f);

    [NativeTypeName("#define AL_EQUALIZER_DEFAULT_LOW_CUTOFF (200.0f)")]
    public const float EqualizerDefaultLowCutoff = (200.0f);

    [NativeTypeName("#define AL_EQUALIZER_MIN_MID1_GAIN (0.126f)")]
    public const float EqualizerMinMid1Gain = (0.126f);

    [NativeTypeName("#define AL_EQUALIZER_MAX_MID1_GAIN (7.943f)")]
    public const float EqualizerMaxMid1Gain = (7.943f);

    [NativeTypeName("#define AL_EQUALIZER_DEFAULT_MID1_GAIN (1.0f)")]
    public const float EqualizerDefaultMid1Gain = (1.0f);

    [NativeTypeName("#define AL_EQUALIZER_MIN_MID1_CENTER (200.0f)")]
    public const float EqualizerMinMid1Center = (200.0f);

    [NativeTypeName("#define AL_EQUALIZER_MAX_MID1_CENTER (3000.0f)")]
    public const float EqualizerMaxMid1Center = (3000.0f);

    [NativeTypeName("#define AL_EQUALIZER_DEFAULT_MID1_CENTER (500.0f)")]
    public const float EqualizerDefaultMid1Center = (500.0f);

    [NativeTypeName("#define AL_EQUALIZER_MIN_MID1_WIDTH (0.01f)")]
    public const float EqualizerMinMid1Width = (0.01f);

    [NativeTypeName("#define AL_EQUALIZER_MAX_MID1_WIDTH (1.0f)")]
    public const float EqualizerMaxMid1Width = (1.0f);

    [NativeTypeName("#define AL_EQUALIZER_DEFAULT_MID1_WIDTH (1.0f)")]
    public const float EqualizerDefaultMid1Width = (1.0f);

    [NativeTypeName("#define AL_EQUALIZER_MIN_MID2_GAIN (0.126f)")]
    public const float EqualizerMinMid2Gain = (0.126f);

    [NativeTypeName("#define AL_EQUALIZER_MAX_MID2_GAIN (7.943f)")]
    public const float EqualizerMaxMid2Gain = (7.943f);

    [NativeTypeName("#define AL_EQUALIZER_DEFAULT_MID2_GAIN (1.0f)")]
    public const float EqualizerDefaultMid2Gain = (1.0f);

    [NativeTypeName("#define AL_EQUALIZER_MIN_MID2_CENTER (1000.0f)")]
    public const float EqualizerMinMid2Center = (1000.0f);

    [NativeTypeName("#define AL_EQUALIZER_MAX_MID2_CENTER (8000.0f)")]
    public const float EqualizerMaxMid2Center = (8000.0f);

    [NativeTypeName("#define AL_EQUALIZER_DEFAULT_MID2_CENTER (3000.0f)")]
    public const float EqualizerDefaultMid2Center = (3000.0f);

    [NativeTypeName("#define AL_EQUALIZER_MIN_MID2_WIDTH (0.01f)")]
    public const float EqualizerMinMid2Width = (0.01f);

    [NativeTypeName("#define AL_EQUALIZER_MAX_MID2_WIDTH (1.0f)")]
    public const float EqualizerMaxMid2Width = (1.0f);

    [NativeTypeName("#define AL_EQUALIZER_DEFAULT_MID2_WIDTH (1.0f)")]
    public const float EqualizerDefaultMid2Width = (1.0f);

    [NativeTypeName("#define AL_EQUALIZER_MIN_HIGH_GAIN (0.126f)")]
    public const float EqualizerMinHighGain = (0.126f);

    [NativeTypeName("#define AL_EQUALIZER_MAX_HIGH_GAIN (7.943f)")]
    public const float EqualizerMaxHighGain = (7.943f);

    [NativeTypeName("#define AL_EQUALIZER_DEFAULT_HIGH_GAIN (1.0f)")]
    public const float EqualizerDefaultHighGain = (1.0f);

    [NativeTypeName("#define AL_EQUALIZER_MIN_HIGH_CUTOFF (4000.0f)")]
    public const float EqualizerMinHighCutoff = (4000.0f);

    [NativeTypeName("#define AL_EQUALIZER_MAX_HIGH_CUTOFF (16000.0f)")]
    public const float EqualizerMaxHighCutoff = (16000.0f);

    [NativeTypeName("#define AL_EQUALIZER_DEFAULT_HIGH_CUTOFF (6000.0f)")]
    public const float EqualizerDefaultHighCutoff = (6000.0f);

    [NativeTypeName("#define AL_MIN_AIR_ABSORPTION_FACTOR (0.0f)")]
    public const float MinAirAbsorptionFactor = (0.0f);

    [NativeTypeName("#define AL_MAX_AIR_ABSORPTION_FACTOR (10.0f)")]
    public const float MaxAirAbsorptionFactor = (10.0f);

    [NativeTypeName("#define AL_DEFAULT_AIR_ABSORPTION_FACTOR (0.0f)")]
    public const float DefaultAirAbsorptionFactor = (0.0f);

    [NativeTypeName("#define AL_MIN_ROOM_ROLLOFF_FACTOR (0.0f)")]
    public const float MinRoomRolloffFactor = (0.0f);

    [NativeTypeName("#define AL_MAX_ROOM_ROLLOFF_FACTOR (10.0f)")]
    public const float MaxRoomRolloffFactor = (10.0f);

    [NativeTypeName("#define AL_DEFAULT_ROOM_ROLLOFF_FACTOR (0.0f)")]
    public const float DefaultRoomRolloffFactor = (0.0f);

    [NativeTypeName("#define AL_MIN_CONE_OUTER_GAINHF (0.0f)")]
    public const float MinConeOuterGainhf = (0.0f);

    [NativeTypeName("#define AL_MAX_CONE_OUTER_GAINHF (1.0f)")]
    public const float MaxConeOuterGainhf = (1.0f);

    [NativeTypeName("#define AL_DEFAULT_CONE_OUTER_GAINHF (1.0f)")]
    public const float DefaultConeOuterGainhf = (1.0f);

    [NativeTypeName("#define AL_MIN_DIRECT_FILTER_GAINHF_AUTO AL_FALSE")]
    public const int MinDirectFilterGainhfAuto = 0;

    [NativeTypeName("#define AL_MAX_DIRECT_FILTER_GAINHF_AUTO AL_TRUE")]
    public const int MaxDirectFilterGainhfAuto = 1;

    [NativeTypeName("#define AL_DEFAULT_DIRECT_FILTER_GAINHF_AUTO AL_TRUE")]
    public const int DefaultDirectFilterGainhfAuto = 1;

    [NativeTypeName("#define AL_MIN_AUXILIARY_SEND_FILTER_GAIN_AUTO AL_FALSE")]
    public const int MinAuxiliarySendFilterGainAuto = 0;

    [NativeTypeName("#define AL_MAX_AUXILIARY_SEND_FILTER_GAIN_AUTO AL_TRUE")]
    public const int MaxAuxiliarySendFilterGainAuto = 1;

    [NativeTypeName("#define AL_DEFAULT_AUXILIARY_SEND_FILTER_GAIN_AUTO AL_TRUE")]
    public const int DefaultAuxiliarySendFilterGainAuto = 1;

    [NativeTypeName("#define AL_MIN_AUXILIARY_SEND_FILTER_GAINHF_AUTO AL_FALSE")]
    public const int MinAuxiliarySendFilterGainhfAuto = 0;

    [NativeTypeName("#define AL_MAX_AUXILIARY_SEND_FILTER_GAINHF_AUTO AL_TRUE")]
    public const int MaxAuxiliarySendFilterGainhfAuto = 1;

    [NativeTypeName("#define AL_DEFAULT_AUXILIARY_SEND_FILTER_GAINHF_AUTO AL_TRUE")]
    public const int DefaultAuxiliarySendFilterGainhfAuto = 1;

    [NativeTypeName("#define AL_MIN_METERS_PER_UNIT FLT_MIN")]
    public const float MinMetersPerUnit = 1.17549435e-38F;

    [NativeTypeName("#define AL_MAX_METERS_PER_UNIT FLT_MAX")]
    public const float MaxMetersPerUnit = 3.40282347e+38F;

    [NativeTypeName("#define AL_DEFAULT_METERS_PER_UNIT (1.0f)")]
    public const float DefaultMetersPerUnit = (1.0f);

    [NativeTypeName("#define AL_EXT_source_distance_model 1")]
    public const int EXTSourceDistanceModel = 1;

    [NativeTypeName("#define AL_SOURCE_DISTANCE_MODEL 0x200")]
    public const int SourceDistanceModel = 0x200;

    [NativeTypeName("#define AL_SOFT_buffer_sub_data 1")]
    public const int SOFTBufferSubData = 1;

    [NativeTypeName("#define AL_BYTE_RW_OFFSETS_SOFT 0x1031")]
    public const int ByteRwOffsetsSoft = 0x1031;

    [NativeTypeName("#define AL_SAMPLE_RW_OFFSETS_SOFT 0x1032")]
    public const int SampleRwOffsetsSoft = 0x1032;

    [NativeTypeName("#define AL_SOFT_loop_points 1")]
    public const int SOFTLoopPoints = 1;

    [NativeTypeName("#define AL_LOOP_POINTS_SOFT 0x2015")]
    public const int LoopPointsSoft = 0x2015;

    [NativeTypeName("#define AL_EXT_FOLDBACK 1")]
    public const int ExtFoldback = 1;

    [NativeTypeName("#define AL_EXT_FOLDBACK_NAME \"AL_EXT_FOLDBACK\"")]
    public static ReadOnlySpan<byte> ExtFoldbackName => "AL_EXT_FOLDBACK"u8;

    [NativeTypeName("#define AL_FOLDBACK_EVENT_BLOCK 0x4112")]
    public const int FoldbackEventBlock = 0x4112;

    [NativeTypeName("#define AL_FOLDBACK_EVENT_START 0x4111")]
    public const int FoldbackEventStart = 0x4111;

    [NativeTypeName("#define AL_FOLDBACK_EVENT_STOP 0x4113")]
    public const int FoldbackEventStop = 0x4113;

    [NativeTypeName("#define AL_FOLDBACK_MODE_MONO 0x4101")]
    public const int FoldbackModeMono = 0x4101;

    [NativeTypeName("#define AL_FOLDBACK_MODE_STEREO 0x4102")]
    public const int FoldbackModeStereo = 0x4102;

    [NativeTypeName("#define AL_DEDICATED_GAIN 0x0001")]
    public const int DedicatedGain = 0x0001;

    [NativeTypeName("#define AL_EFFECT_DEDICATED_DIALOGUE 0x9001")]
    public const int EffectDedicatedDialogue = 0x9001;

    [NativeTypeName("#define AL_EFFECT_DEDICATED_LOW_FREQUENCY_EFFECT 0x9000")]
    public const int EffectDedicatedLowFrequencyEffect = 0x9000;

    [NativeTypeName("#define AL_SOFT_buffer_samples 1")]
    public const int SOFTBufferSamples = 1;

    [NativeTypeName("#define AL_MONO_SOFT 0x1500")]
    public const int MonoSoft = 0x1500;

    [NativeTypeName("#define AL_STEREO_SOFT 0x1501")]
    public const int StereoSoft = 0x1501;

    [NativeTypeName("#define AL_REAR_SOFT 0x1502")]
    public const int RearSoft = 0x1502;

    [NativeTypeName("#define AL_QUAD_SOFT 0x1503")]
    public const int QuadSoft = 0x1503;

    [NativeTypeName("#define AL_5POINT1_SOFT 0x1504")]
    public const int X5Point1Soft = 0x1504;

    [NativeTypeName("#define AL_6POINT1_SOFT 0x1505")]
    public const int X6Point1Soft = 0x1505;

    [NativeTypeName("#define AL_7POINT1_SOFT 0x1506")]
    public const int X7Point1Soft = 0x1506;

    [NativeTypeName("#define AL_BYTE_SOFT 0x1400")]
    public const int ByteSoft = 0x1400;

    [NativeTypeName("#define AL_UNSIGNED_BYTE_SOFT 0x1401")]
    public const int UnsignedByteSoft = 0x1401;

    [NativeTypeName("#define AL_SHORT_SOFT 0x1402")]
    public const int ShortSoft = 0x1402;

    [NativeTypeName("#define AL_UNSIGNED_SHORT_SOFT 0x1403")]
    public const int UnsignedShortSoft = 0x1403;

    [NativeTypeName("#define AL_INT_SOFT 0x1404")]
    public const int IntSoft = 0x1404;

    [NativeTypeName("#define AL_UNSIGNED_INT_SOFT 0x1405")]
    public const int UnsignedIntSoft = 0x1405;

    [NativeTypeName("#define AL_FLOAT_SOFT 0x1406")]
    public const int FloatSoft = 0x1406;

    [NativeTypeName("#define AL_DOUBLE_SOFT 0x1407")]
    public const int DoubleSoft = 0x1407;

    [NativeTypeName("#define AL_BYTE3_SOFT 0x1408")]
    public const int Byte3Soft = 0x1408;

    [NativeTypeName("#define AL_UNSIGNED_BYTE3_SOFT 0x1409")]
    public const int UnsignedByte3Soft = 0x1409;

    [NativeTypeName("#define AL_MONO8_SOFT 0x1100")]
    public const int Mono8Soft = 0x1100;

    [NativeTypeName("#define AL_MONO16_SOFT 0x1101")]
    public const int Mono16Soft = 0x1101;

    [NativeTypeName("#define AL_MONO32F_SOFT 0x10010")]
    public const int Mono32FSoft = 0x10010;

    [NativeTypeName("#define AL_STEREO8_SOFT 0x1102")]
    public const int Stereo8Soft = 0x1102;

    [NativeTypeName("#define AL_STEREO16_SOFT 0x1103")]
    public const int Stereo16Soft = 0x1103;

    [NativeTypeName("#define AL_STEREO32F_SOFT 0x10011")]
    public const int Stereo32FSoft = 0x10011;

    [NativeTypeName("#define AL_QUAD8_SOFT 0x1204")]
    public const int Quad8Soft = 0x1204;

    [NativeTypeName("#define AL_QUAD16_SOFT 0x1205")]
    public const int Quad16Soft = 0x1205;

    [NativeTypeName("#define AL_QUAD32F_SOFT 0x1206")]
    public const int Quad32FSoft = 0x1206;

    [NativeTypeName("#define AL_REAR8_SOFT 0x1207")]
    public const int Rear8Soft = 0x1207;

    [NativeTypeName("#define AL_REAR16_SOFT 0x1208")]
    public const int Rear16Soft = 0x1208;

    [NativeTypeName("#define AL_REAR32F_SOFT 0x1209")]
    public const int Rear32FSoft = 0x1209;

    [NativeTypeName("#define AL_5POINT1_8_SOFT 0x120A")]
    public const int X5Point1X8Soft = 0x120A;

    [NativeTypeName("#define AL_5POINT1_16_SOFT 0x120B")]
    public const int X5Point1X16Soft = 0x120B;

    [NativeTypeName("#define AL_5POINT1_32F_SOFT 0x120C")]
    public const int X5Point1X32FSoft = 0x120C;

    [NativeTypeName("#define AL_6POINT1_8_SOFT 0x120D")]
    public const int X6Point1X8Soft = 0x120D;

    [NativeTypeName("#define AL_6POINT1_16_SOFT 0x120E")]
    public const int X6Point1X16Soft = 0x120E;

    [NativeTypeName("#define AL_6POINT1_32F_SOFT 0x120F")]
    public const int X6Point1X32FSoft = 0x120F;

    [NativeTypeName("#define AL_7POINT1_8_SOFT 0x1210")]
    public const int X7Point1X8Soft = 0x1210;

    [NativeTypeName("#define AL_7POINT1_16_SOFT 0x1211")]
    public const int X7Point1X16Soft = 0x1211;

    [NativeTypeName("#define AL_7POINT1_32F_SOFT 0x1212")]
    public const int X7Point1X32FSoft = 0x1212;

    [NativeTypeName("#define AL_INTERNAL_FORMAT_SOFT 0x2008")]
    public const int InternalFormatSoft = 0x2008;

    [NativeTypeName("#define AL_BYTE_LENGTH_SOFT 0x2009")]
    public const int ByteLengthSoft = 0x2009;

    [NativeTypeName("#define AL_SAMPLE_LENGTH_SOFT 0x200A")]
    public const int SampleLengthSoft = 0x200A;

    [NativeTypeName("#define AL_SEC_LENGTH_SOFT 0x200B")]
    public const int SecLengthSoft = 0x200B;

    [NativeTypeName("#define AL_SOFT_direct_channels 1")]
    public const int SOFTDirectChannels = 1;

    [NativeTypeName("#define AL_DIRECT_CHANNELS_SOFT 0x1033")]
    public const int DirectChannelsSoft = 0x1033;

    [NativeTypeName("#define AL_EXT_STEREO_ANGLES 1")]
    public const int ExtStereoAngles = 1;

    [NativeTypeName("#define AL_STEREO_ANGLES 0x1030")]
    public const int StereoAngles = 0x1030;

    [NativeTypeName("#define AL_EXT_SOURCE_RADIUS 1")]
    public const int ExtSourceRadius = 1;

    [NativeTypeName("#define AL_SOURCE_RADIUS 0x1031")]
    public const int SourceRadius = 0x1031;

    [NativeTypeName("#define AL_SOFT_source_latency 1")]
    public const int SOFTSourceLatency = 1;

    [NativeTypeName("#define AL_SAMPLE_OFFSET_LATENCY_SOFT 0x1200")]
    public const int SampleOffsetLatencySoft = 0x1200;

    [NativeTypeName("#define AL_SEC_OFFSET_LATENCY_SOFT 0x1201")]
    public const int SecOffsetLatencySoft = 0x1201;

    [NativeTypeName("#define AL_SOFT_deferred_updates 1")]
    public const int SOFTDeferredUpdates = 1;

    [NativeTypeName("#define AL_DEFERRED_UPDATES_SOFT 0xC002")]
    public const int DeferredUpdatesSoft = 0xC002;

    [NativeTypeName("#define AL_SOFT_block_alignment 1")]
    public const int SOFTBlockAlignment = 1;

    [NativeTypeName("#define AL_UNPACK_BLOCK_ALIGNMENT_SOFT 0x200C")]
    public const int UnpackBlockAlignmentSoft = 0x200C;

    [NativeTypeName("#define AL_PACK_BLOCK_ALIGNMENT_SOFT 0x200D")]
    public const int PackBlockAlignmentSoft = 0x200D;

    [NativeTypeName("#define AL_SOFT_MSADPCM 1")]
    public const int SoftMsadpcm = 1;

    [NativeTypeName("#define AL_FORMAT_MONO_MSADPCM_SOFT 0x1302")]
    public const int FormatMonoMsadpcmSoft = 0x1302;

    [NativeTypeName("#define AL_FORMAT_STEREO_MSADPCM_SOFT 0x1303")]
    public const int FormatStereoMsadpcmSoft = 0x1303;

    [NativeTypeName("#define AL_SOFT_source_length 1")]
    public const int SOFTSourceLength = 1;

    [NativeTypeName("#define AL_SOFT_buffer_length_query 1")]
    public const int SOFTBufferLengthQuery = 1;

    [NativeTypeName("#define AL_EXT_BFORMAT 1")]
    public const int ExtBformat = 1;

    [NativeTypeName("#define AL_FORMAT_BFORMAT2D_8 0x20021")]
    public const int FormatBformat2D8 = 0x20021;

    [NativeTypeName("#define AL_FORMAT_BFORMAT2D_16 0x20022")]
    public const int FormatBformat2D16 = 0x20022;

    [NativeTypeName("#define AL_FORMAT_BFORMAT2D_FLOAT32 0x20023")]
    public const int FormatBformat2DFloat32 = 0x20023;

    [NativeTypeName("#define AL_FORMAT_BFORMAT3D_8 0x20031")]
    public const int FormatBformat3D8 = 0x20031;

    [NativeTypeName("#define AL_FORMAT_BFORMAT3D_16 0x20032")]
    public const int FormatBformat3D16 = 0x20032;

    [NativeTypeName("#define AL_FORMAT_BFORMAT3D_FLOAT32 0x20033")]
    public const int FormatBformat3DFloat32 = 0x20033;

    [NativeTypeName("#define AL_EXT_MULAW_BFORMAT 1")]
    public const int ExtMulawBformat = 1;

    [NativeTypeName("#define AL_FORMAT_BFORMAT2D_MULAW 0x10031")]
    public const int FormatBformat2DMulaw = 0x10031;

    [NativeTypeName("#define AL_FORMAT_BFORMAT3D_MULAW 0x10032")]
    public const int FormatBformat3DMulaw = 0x10032;

    [NativeTypeName("#define AL_SOFT_gain_clamp_ex 1")]
    public const int SOFTGainClampEx = 1;

    [NativeTypeName("#define AL_GAIN_LIMIT_SOFT 0x200E")]
    public const int GainLimitSoft = 0x200E;

    [NativeTypeName("#define AL_NUM_RESAMPLERS_SOFT 0x1210")]
    public const int NumResamplersSoft = 0x1210;

    [NativeTypeName("#define AL_DEFAULT_RESAMPLER_SOFT 0x1211")]
    public const int DefaultResamplerSoft = 0x1211;

    [NativeTypeName("#define AL_SOURCE_RESAMPLER_SOFT 0x1212")]
    public const int SourceResamplerSoft = 0x1212;

    [NativeTypeName("#define AL_RESAMPLER_NAME_SOFT 0x1213")]
    public const int ResamplerNameSoft = 0x1213;

    [NativeTypeName("#define AL_SOURCE_SPATIALIZE_SOFT 0x1214")]
    public const int SourceSpatializeSoft = 0x1214;

    [NativeTypeName("#define AL_AUTO_SOFT 0x0002")]
    public const int AutoSoft = 0x0002;

    [NativeTypeName("#define AL_SAMPLE_OFFSET_CLOCK_SOFT 0x1202")]
    public const int SampleOffsetClockSoft = 0x1202;

    [NativeTypeName("#define AL_SEC_OFFSET_CLOCK_SOFT 0x1203")]
    public const int SecOffsetClockSoft = 0x1203;

    [NativeTypeName("#define AL_SOFT_direct_channels_remix 1")]
    public const int SOFTDirectChannelsRemix = 1;

    [NativeTypeName("#define AL_DROP_UNMATCHED_SOFT 0x0001")]
    public const int DropUnmatchedSoft = 0x0001;

    [NativeTypeName("#define AL_REMIX_UNMATCHED_SOFT 0x0002")]
    public const int RemixUnmatchedSoft = 0x0002;

    [NativeTypeName("#define AL_SOFT_bformat_ex 1")]
    public const int SOFTBformatEx = 1;

    [NativeTypeName("#define AL_AMBISONIC_LAYOUT_SOFT 0x1997")]
    public const int AmbisonicLayoutSoft = 0x1997;

    [NativeTypeName("#define AL_AMBISONIC_SCALING_SOFT 0x1998")]
    public const int AmbisonicScalingSoft = 0x1998;

    [NativeTypeName("#define AL_FUMA_SOFT 0x0000")]
    public const int FumaSoft = 0x0000;

    [NativeTypeName("#define AL_ACN_SOFT 0x0001")]
    public const int AcnSoft = 0x0001;

    [NativeTypeName("#define AL_SN3D_SOFT 0x0001")]
    public const int Sn3DSoft = 0x0001;

    [NativeTypeName("#define AL_N3D_SOFT 0x0002")]
    public const int N3DSoft = 0x0002;

    [NativeTypeName("#define AL_EFFECTSLOT_TARGET_SOFT 0x199C")]
    public const int EffectslotTargetSoft = 0x199C;

    [NativeTypeName("#define AL_SOFT_events 1")]
    public const int SOFTEvents = 1;

    [NativeTypeName("#define AL_EVENT_CALLBACK_FUNCTION_SOFT 0x19A2")]
    public const int EventCallbackFunctionSoft = 0x19A2;

    [NativeTypeName("#define AL_EVENT_CALLBACK_USER_PARAM_SOFT 0x19A3")]
    public const int EventCallbackUserParamSoft = 0x19A3;

    [NativeTypeName("#define AL_EVENT_TYPE_BUFFER_COMPLETED_SOFT 0x19A4")]
    public const int EventTypeBufferCompletedSoft = 0x19A4;

    [NativeTypeName("#define AL_EVENT_TYPE_SOURCE_STATE_CHANGED_SOFT 0x19A5")]
    public const int EventTypeSourceStateChangedSoft = 0x19A5;

    [NativeTypeName("#define AL_EVENT_TYPE_DISCONNECTED_SOFT 0x19A6")]
    public const int EventTypeDisconnectedSoft = 0x19A6;

    [NativeTypeName("#define AL_BUFFER_CALLBACK_FUNCTION_SOFT 0x19A0")]
    public const int BufferCallbackFunctionSoft = 0x19A0;

    [NativeTypeName("#define AL_BUFFER_CALLBACK_USER_PARAM_SOFT 0x19A1")]
    public const int BufferCallbackUserParamSoft = 0x19A1;

    [NativeTypeName("#define AL_FORMAT_UHJ2CHN8_SOFT 0x19A2")]
    public const int FormatUhj2Chn8Soft = 0x19A2;

    [NativeTypeName("#define AL_FORMAT_UHJ2CHN16_SOFT 0x19A3")]
    public const int FormatUhj2Chn16Soft = 0x19A3;

    [NativeTypeName("#define AL_FORMAT_UHJ2CHN_FLOAT32_SOFT 0x19A4")]
    public const int FormatUhj2ChnFloat32Soft = 0x19A4;

    [NativeTypeName("#define AL_FORMAT_UHJ3CHN8_SOFT 0x19A5")]
    public const int FormatUhj3Chn8Soft = 0x19A5;

    [NativeTypeName("#define AL_FORMAT_UHJ3CHN16_SOFT 0x19A6")]
    public const int FormatUhj3Chn16Soft = 0x19A6;

    [NativeTypeName("#define AL_FORMAT_UHJ3CHN_FLOAT32_SOFT 0x19A7")]
    public const int FormatUhj3ChnFloat32Soft = 0x19A7;

    [NativeTypeName("#define AL_FORMAT_UHJ4CHN8_SOFT 0x19A8")]
    public const int FormatUhj4Chn8Soft = 0x19A8;

    [NativeTypeName("#define AL_FORMAT_UHJ4CHN16_SOFT 0x19A9")]
    public const int FormatUhj4Chn16Soft = 0x19A9;

    [NativeTypeName("#define AL_FORMAT_UHJ4CHN_FLOAT32_SOFT 0x19AA")]
    public const int FormatUhj4ChnFloat32Soft = 0x19AA;

    [NativeTypeName("#define AL_STEREO_MODE_SOFT 0x19B0")]
    public const int StereoModeSoft = 0x19B0;

    [NativeTypeName("#define AL_NORMAL_SOFT 0x0000")]
    public const int NormalSoft = 0x0000;

    [NativeTypeName("#define AL_SUPER_STEREO_SOFT 0x0001")]
    public const int SuperStereoSoft = 0x0001;

    [NativeTypeName("#define AL_SUPER_STEREO_WIDTH_SOFT 0x19B1")]
    public const int SuperStereoWidthSoft = 0x19B1;

    [NativeTypeName("#define AL_FORMAT_UHJ2CHN_MULAW_SOFT 0x19B3")]
    public const int FormatUhj2ChnMulawSoft = 0x19B3;

    [NativeTypeName("#define AL_FORMAT_UHJ2CHN_ALAW_SOFT 0x19B4")]
    public const int FormatUhj2ChnAlawSoft = 0x19B4;

    [NativeTypeName("#define AL_FORMAT_UHJ2CHN_IMA4_SOFT 0x19B5")]
    public const int FormatUhj2ChnIma4Soft = 0x19B5;

    [NativeTypeName("#define AL_FORMAT_UHJ2CHN_MSADPCM_SOFT 0x19B6")]
    public const int FormatUhj2ChnMsadpcmSoft = 0x19B6;

    [NativeTypeName("#define AL_FORMAT_UHJ3CHN_MULAW_SOFT 0x19B7")]
    public const int FormatUhj3ChnMulawSoft = 0x19B7;

    [NativeTypeName("#define AL_FORMAT_UHJ3CHN_ALAW_SOFT 0x19B8")]
    public const int FormatUhj3ChnAlawSoft = 0x19B8;

    [NativeTypeName("#define AL_FORMAT_UHJ4CHN_MULAW_SOFT 0x19B9")]
    public const int FormatUhj4ChnMulawSoft = 0x19B9;

    [NativeTypeName("#define AL_FORMAT_UHJ4CHN_ALAW_SOFT 0x19BA")]
    public const int FormatUhj4ChnAlawSoft = 0x19BA;

    [NativeTypeName("#define AL_DONT_CARE_EXT 0x0002")]
    public const int DontCareExt = 0x0002;

    [NativeTypeName("#define AL_DEBUG_OUTPUT_EXT 0x19B2")]
    public const int DebugOutputExt = 0x19B2;

    [NativeTypeName("#define AL_DEBUG_CALLBACK_FUNCTION_EXT 0x19B3")]
    public const int DebugCallbackFunctionExt = 0x19B3;

    [NativeTypeName("#define AL_DEBUG_CALLBACK_USER_PARAM_EXT 0x19B4")]
    public const int DebugCallbackUserParamExt = 0x19B4;

    [NativeTypeName("#define AL_DEBUG_SOURCE_API_EXT 0x19B5")]
    public const int DebugSourceApiExt = 0x19B5;

    [NativeTypeName("#define AL_DEBUG_SOURCE_AUDIO_SYSTEM_EXT 0x19B6")]
    public const int DebugSourceAudioSystemExt = 0x19B6;

    [NativeTypeName("#define AL_DEBUG_SOURCE_THIRD_PARTY_EXT 0x19B7")]
    public const int DebugSourceThirdPartyExt = 0x19B7;

    [NativeTypeName("#define AL_DEBUG_SOURCE_APPLICATION_EXT 0x19B8")]
    public const int DebugSourceApplicationExt = 0x19B8;

    [NativeTypeName("#define AL_DEBUG_SOURCE_OTHER_EXT 0x19B9")]
    public const int DebugSourceOtherExt = 0x19B9;

    [NativeTypeName("#define AL_DEBUG_TYPE_ERROR_EXT 0x19BA")]
    public const int DebugTypeErrorExt = 0x19BA;

    [NativeTypeName("#define AL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_EXT 0x19BB")]
    public const int DebugTypeDeprecatedBehaviorExt = 0x19BB;

    [NativeTypeName("#define AL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_EXT 0x19BC")]
    public const int DebugTypeUndefinedBehaviorExt = 0x19BC;

    [NativeTypeName("#define AL_DEBUG_TYPE_PORTABILITY_EXT 0x19BD")]
    public const int DebugTypePortabilityExt = 0x19BD;

    [NativeTypeName("#define AL_DEBUG_TYPE_PERFORMANCE_EXT 0x19BE")]
    public const int DebugTypePerformanceExt = 0x19BE;

    [NativeTypeName("#define AL_DEBUG_TYPE_MARKER_EXT 0x19BF")]
    public const int DebugTypeMarkerExt = 0x19BF;

    [NativeTypeName("#define AL_DEBUG_TYPE_PUSH_GROUP_EXT 0x19C0")]
    public const int DebugTypePushGroupExt = 0x19C0;

    [NativeTypeName("#define AL_DEBUG_TYPE_POP_GROUP_EXT 0x19C1")]
    public const int DebugTypePopGroupExt = 0x19C1;

    [NativeTypeName("#define AL_DEBUG_TYPE_OTHER_EXT 0x19C2")]
    public const int DebugTypeOtherExt = 0x19C2;

    [NativeTypeName("#define AL_DEBUG_SEVERITY_HIGH_EXT 0x19C3")]
    public const int DebugSeverityHighExt = 0x19C3;

    [NativeTypeName("#define AL_DEBUG_SEVERITY_MEDIUM_EXT 0x19C4")]
    public const int DebugSeverityMediumExt = 0x19C4;

    [NativeTypeName("#define AL_DEBUG_SEVERITY_LOW_EXT 0x19C5")]
    public const int DebugSeverityLowExt = 0x19C5;

    [NativeTypeName("#define AL_DEBUG_SEVERITY_NOTIFICATION_EXT 0x19C6")]
    public const int DebugSeverityNotificationExt = 0x19C6;

    [NativeTypeName("#define AL_DEBUG_LOGGED_MESSAGES_EXT 0x19C7")]
    public const int DebugLoggedMessagesExt = 0x19C7;

    [NativeTypeName("#define AL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_EXT 0x19C8")]
    public const int DebugNextLoggedMessageLengthExt = 0x19C8;

    [NativeTypeName("#define AL_MAX_DEBUG_MESSAGE_LENGTH_EXT 0x19C9")]
    public const int MaxDebugMessageLengthExt = 0x19C9;

    [NativeTypeName("#define AL_MAX_DEBUG_LOGGED_MESSAGES_EXT 0x19CA")]
    public const int MaxDebugLoggedMessagesExt = 0x19CA;

    [NativeTypeName("#define AL_MAX_DEBUG_GROUP_STACK_DEPTH_EXT 0x19CB")]
    public const int MaxDebugGroupStackDepthExt = 0x19CB;

    [NativeTypeName("#define AL_MAX_LABEL_LENGTH_EXT 0x19CC")]
    public const int MaxLabelLengthExt = 0x19CC;

    [NativeTypeName("#define AL_STACK_OVERFLOW_EXT 0x19CD")]
    public const int StackOverflowExt = 0x19CD;

    [NativeTypeName("#define AL_STACK_UNDERFLOW_EXT 0x19CE")]
    public const int StackUnderflowExt = 0x19CE;

    [NativeTypeName("#define AL_CONTEXT_FLAGS_EXT 0x19CF")]
    public const int ContextFlagsExt = 0x19CF;

    [NativeTypeName("#define AL_BUFFER_EXT 0x1009")]
    public const int BufferExt = 0x1009;

    [NativeTypeName("#define AL_SOURCE_EXT 0x19D0")]
    public const int SourceExt = 0x19D0;

    [NativeTypeName("#define AL_FILTER_EXT 0x19D1")]
    public const int FilterExt = 0x19D1;

    [NativeTypeName("#define AL_EFFECT_EXT 0x19D2")]
    public const int EffectExt = 0x19D2;

    [NativeTypeName("#define AL_AUXILIARY_EFFECT_SLOT_EXT 0x19D3")]
    public const int AuxiliaryEffectSlotExt = 0x19D3;

    [NativeTypeName("#define AL_UNPACK_AMBISONIC_ORDER_SOFT 0x199D")]
    public const int UnpackAmbisonicOrderSoft = 0x199D;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Buffer3F(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    ) =>
        (
            (delegate* unmanaged<uint, int, float, float, float, void>)(
                _slots[0] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[0] = nativeContext.LoadFunction("alBuffer3f", "openal")
            )
        )(buffer, param1, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alBuffer3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Buffer3F(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    ) => ThisThread.Buffer3F(buffer, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Buffer3I(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    ) =>
        (
            (delegate* unmanaged<uint, int, int, int, int, void>)(
                _slots[1] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[1] = nativeContext.LoadFunction("alBuffer3i", "openal")
            )
        )(buffer, param1, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alBuffer3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Buffer3I(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    ) => ThisThread.Buffer3I(buffer, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.BufferData(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("const ALvoid *")] void* data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    ) =>
        (
            (delegate* unmanaged<uint, int, void*, int, int, void>)(
                _slots[2] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[2] = nativeContext.LoadFunction("alBufferData", "openal")
            )
        )(buffer, format, data, size, samplerate);

    [NativeFunction("openal", EntryPoint = "alBufferData")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void BufferData(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("const ALvoid *")] void* data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    ) => ThisThread.BufferData(buffer, format, data, size, samplerate);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.BufferData(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("const ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    )
    {
        fixed (void* __dsl_data = data)
        {
            ((IAL)this).BufferData(buffer, format, __dsl_data, size, samplerate);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferData")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void BufferData(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int format,
        [NativeTypeName("const ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    ) => ThisThread.BufferData(buffer, format, data, size, samplerate);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Bufferf(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value
    ) =>
        (
            (delegate* unmanaged<uint, int, float, void>)(
                _slots[3] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[3] = nativeContext.LoadFunction("alBufferf", "openal")
            )
        )(buffer, param1, value);

    [NativeFunction("openal", EntryPoint = "alBufferf")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Bufferf(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value
    ) => ThisThread.Bufferf(buffer, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Bufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* values
    ) =>
        (
            (delegate* unmanaged<uint, int, float*, void>)(
                _slots[4] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[4] = nativeContext.LoadFunction("alBufferfv", "openal")
            )
        )(buffer, param1, values);

    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Bufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* values
    ) => ThisThread.Bufferfv(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Bufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    )
    {
        fixed (float* __dsl_values = values)
        {
            ((IAL)this).Bufferfv(buffer, param1, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Bufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    ) => ThisThread.Bufferfv(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Bufferi(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value
    ) =>
        (
            (delegate* unmanaged<uint, int, int, void>)(
                _slots[5] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[5] = nativeContext.LoadFunction("alBufferi", "openal")
            )
        )(buffer, param1, value);

    [NativeFunction("openal", EntryPoint = "alBufferi")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Bufferi(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value
    ) => ThisThread.Bufferi(buffer, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Bufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* values
    ) =>
        (
            (delegate* unmanaged<uint, int, int*, void>)(
                _slots[6] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[6] = nativeContext.LoadFunction("alBufferiv", "openal")
            )
        )(buffer, param1, values);

    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Bufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* values
    ) => ThisThread.Bufferiv(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Bufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAL)this).Bufferiv(buffer, param1, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Bufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    ) => ThisThread.Bufferiv(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers) =>
        ((IAL)this).DeleteBuffers(1, (uint*)&buffers);

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers) =>
        ThisThread.DeleteBuffer(buffers);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DeleteBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* buffers
    ) =>
        (
            (delegate* unmanaged<int, uint*, void>)(
                _slots[7] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[7] = nativeContext.LoadFunction("alDeleteBuffers", "openal")
            )
        )(n, buffers);

    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DeleteBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* buffers
    ) => ThisThread.DeleteBuffers(n, buffers);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DeleteBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers
    )
    {
        fixed (uint* __dsl_buffers = buffers)
        {
            ((IAL)this).DeleteBuffers(n, __dsl_buffers);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DeleteBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers
    ) => ThisThread.DeleteBuffers(n, buffers);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DeleteSource([NativeTypeName("const ALuint *")] uint sources) =>
        ((IAL)this).DeleteSources(1, (uint*)&sources);

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DeleteSource([NativeTypeName("const ALuint *")] uint sources) =>
        ThisThread.DeleteSource(sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DeleteSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    ) =>
        (
            (delegate* unmanaged<int, uint*, void>)(
                _slots[8] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[8] = nativeContext.LoadFunction("alDeleteSources", "openal")
            )
        )(n, sources);

    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DeleteSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    ) => ThisThread.DeleteSources(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DeleteSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    )
    {
        fixed (uint* __dsl_sources = sources)
        {
            ((IAL)this).DeleteSources(n, __dsl_sources);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDeleteSources")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DeleteSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    ) => ThisThread.DeleteSources(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Disable([NativeTypeName("ALenum")] int capability) =>
        (
            (delegate* unmanaged<int, void>)(
                _slots[9] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[9] = nativeContext.LoadFunction("alDisable", "openal")
            )
        )(capability);

    [NativeFunction("openal", EntryPoint = "alDisable")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Disable([NativeTypeName("ALenum")] int capability) =>
        ThisThread.Disable(capability);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DistanceModel([NativeTypeName("ALenum")] int distanceModel) =>
        (
            (delegate* unmanaged<int, void>)(
                _slots[10] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[10] = nativeContext.LoadFunction("alDistanceModel", "openal")
            )
        )(distanceModel);

    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DistanceModel([NativeTypeName("ALenum")] int distanceModel) =>
        ThisThread.DistanceModel(distanceModel);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DopplerFactor([NativeTypeName("ALfloat")] float value) =>
        (
            (delegate* unmanaged<float, void>)(
                _slots[11] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[11] = nativeContext.LoadFunction("alDopplerFactor", "openal")
            )
        )(value);

    [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DopplerFactor([NativeTypeName("ALfloat")] float value) =>
        ThisThread.DopplerFactor(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DopplerVelocity([NativeTypeName("ALfloat")] float value) =>
        (
            (delegate* unmanaged<float, void>)(
                _slots[12] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[12] = nativeContext.LoadFunction("alDopplerVelocity", "openal")
            )
        )(value);

    [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DopplerVelocity([NativeTypeName("ALfloat")] float value) =>
        ThisThread.DopplerVelocity(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Enable([NativeTypeName("ALenum")] int capability) =>
        (
            (delegate* unmanaged<int, void>)(
                _slots[13] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[13] = nativeContext.LoadFunction("alEnable", "openal")
            )
        )(capability);

    [NativeFunction("openal", EntryPoint = "alEnable")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Enable([NativeTypeName("ALenum")] int capability) =>
        ThisThread.Enable(capability);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IAL.GenBuffer()
    {
        uint buffers = default;
        ((IAL)this).GenBuffers(1, (uint*)&buffers);
        return buffers;
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint GenBuffer() => ThisThread.GenBuffer();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GenBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] uint* buffers
    ) =>
        (
            (delegate* unmanaged<int, uint*, void>)(
                _slots[14] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[14] = nativeContext.LoadFunction("alGenBuffers", "openal")
            )
        )(n, buffers);

    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GenBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] uint* buffers
    ) => ThisThread.GenBuffers(n, buffers);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GenBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> buffers
    )
    {
        fixed (uint* __dsl_buffers = buffers)
        {
            ((IAL)this).GenBuffers(n, __dsl_buffers);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenBuffers")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GenBuffers(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> buffers
    ) => ThisThread.GenBuffers(n, buffers);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IAL.GenSource()
    {
        uint sources = default;
        ((IAL)this).GenSources(1, (uint*)&sources);
        return sources;
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint GenSource() => ThisThread.GenSource();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GenSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] uint* sources
    ) =>
        (
            (delegate* unmanaged<int, uint*, void>)(
                _slots[15] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[15] = nativeContext.LoadFunction("alGenSources", "openal")
            )
        )(n, sources);

    [NativeFunction("openal", EntryPoint = "alGenSources")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GenSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] uint* sources
    ) => ThisThread.GenSources(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GenSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> sources
    )
    {
        fixed (uint* __dsl_sources = sources)
        {
            ((IAL)this).GenSources(n, __dsl_sources);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGenSources")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GenSources(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("ALuint *")] Ref<uint> sources
    ) => ThisThread.GenSources(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAL.GetBoolean([NativeTypeName("ALenum")] int param0) =>
        (MaybeBool<sbyte>)(sbyte)((IAL)this).GetBooleanRaw(param0);

    [return: NativeTypeName("ALboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> GetBoolean([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetBoolean(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAL.GetBooleanRaw([NativeTypeName("ALenum")] int param0) =>
        (
            (delegate* unmanaged<int, sbyte>)(
                _slots[16] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[16] = nativeContext.LoadFunction("alGetBoolean", "openal")
            )
        )(param0);

    [return: NativeTypeName("ALboolean")]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetBooleanRaw(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBooleanv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALboolean *")] sbyte* values
    ) =>
        (
            (delegate* unmanaged<int, sbyte*, void>)(
                _slots[17] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[17] = nativeContext.LoadFunction("alGetBooleanv", "openal")
            )
        )(param0, values);

    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBooleanv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALboolean *")] sbyte* values
    ) => ThisThread.GetBooleanv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBooleanv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALboolean *")] Ref<sbyte> values
    )
    {
        fixed (sbyte* __dsl_values = values)
        {
            ((IAL)this).GetBooleanv(param0, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBooleanv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALboolean *")] Ref<sbyte> values
    ) => ThisThread.GetBooleanv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAL.GetBooleanv()
    {
        sbyte values = default;
        ((IAL)this).GetBooleanv(1, (sbyte*)&values);
        return values;
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte GetBooleanv() => ThisThread.GetBooleanv();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBuffer3F(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    ) =>
        (
            (delegate* unmanaged<uint, int, float*, float*, float*, void>)(
                _slots[18] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[18] = nativeContext.LoadFunction("alGetBuffer3f", "openal")
            )
        )(buffer, param1, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBuffer3F(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    ) => ThisThread.GetBuffer3F(buffer, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBuffer3F(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    )
    {
        fixed (float* __dsl_value3 = value3)
        fixed (float* __dsl_value2 = value2)
        fixed (float* __dsl_value1 = value1)
        {
            ((IAL)this).GetBuffer3F(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBuffer3F(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    ) => ThisThread.GetBuffer3F(buffer, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBuffer3I(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    ) =>
        (
            (delegate* unmanaged<uint, int, int*, int*, int*, void>)(
                _slots[19] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[19] = nativeContext.LoadFunction("alGetBuffer3i", "openal")
            )
        )(buffer, param1, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBuffer3I(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    ) => ThisThread.GetBuffer3I(buffer, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBuffer3I(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    )
    {
        fixed (int* __dsl_value3 = value3)
        fixed (int* __dsl_value2 = value2)
        fixed (int* __dsl_value1 = value1)
        {
            ((IAL)this).GetBuffer3I(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBuffer3I(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    ) => ThisThread.GetBuffer3I(buffer, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBufferf(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value
    ) =>
        (
            (delegate* unmanaged<uint, int, float*, void>)(
                _slots[20] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[20] = nativeContext.LoadFunction("alGetBufferf", "openal")
            )
        )(buffer, param1, value);

    [NativeFunction("openal", EntryPoint = "alGetBufferf")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBufferf(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value
    ) => ThisThread.GetBufferf(buffer, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBufferf(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value
    )
    {
        fixed (float* __dsl_value = value)
        {
            ((IAL)this).GetBufferf(buffer, param1, __dsl_value);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferf")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBufferf(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value
    ) => ThisThread.GetBufferf(buffer, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* values
    ) =>
        (
            (delegate* unmanaged<uint, int, float*, void>)(
                _slots[21] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[21] = nativeContext.LoadFunction("alGetBufferfv", "openal")
            )
        )(buffer, param1, values);

    [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* values
    ) => ThisThread.GetBufferfv(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> values
    )
    {
        fixed (float* __dsl_values = values)
        {
            ((IAL)this).GetBufferfv(buffer, param1, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBufferfv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> values
    ) => ThisThread.GetBufferfv(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBufferi(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value
    ) =>
        (
            (delegate* unmanaged<uint, int, int*, void>)(
                _slots[22] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[22] = nativeContext.LoadFunction("alGetBufferi", "openal")
            )
        )(buffer, param1, value);

    [NativeFunction("openal", EntryPoint = "alGetBufferi")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBufferi(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value
    ) => ThisThread.GetBufferi(buffer, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBufferi(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value
    )
    {
        fixed (int* __dsl_value = value)
        {
            ((IAL)this).GetBufferi(buffer, param1, __dsl_value);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferi")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBufferi(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value
    ) => ThisThread.GetBufferi(buffer, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* values
    ) =>
        (
            (delegate* unmanaged<uint, int, int*, void>)(
                _slots[23] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[23] = nativeContext.LoadFunction("alGetBufferiv", "openal")
            )
        )(buffer, param1, values);

    [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* values
    ) => ThisThread.GetBufferiv(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAL)this).GetBufferiv(buffer, param1, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBufferiv(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> values
    ) => ThisThread.GetBufferiv(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    double IAL.GetDouble([NativeTypeName("ALenum")] int param0) =>
        (
            (delegate* unmanaged<int, double>)(
                _slots[24] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[24] = nativeContext.LoadFunction("alGetDouble", "openal")
            )
        )(param0);

    [return: NativeTypeName("ALdouble")]
    [NativeFunction("openal", EntryPoint = "alGetDouble")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double GetDouble([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetDouble(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetDoublev(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALdouble *")] double* values
    ) =>
        (
            (delegate* unmanaged<int, double*, void>)(
                _slots[25] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[25] = nativeContext.LoadFunction("alGetDoublev", "openal")
            )
        )(param0, values);

    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetDoublev(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALdouble *")] double* values
    ) => ThisThread.GetDoublev(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetDoublev(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALdouble *")] Ref<double> values
    )
    {
        fixed (double* __dsl_values = values)
        {
            ((IAL)this).GetDoublev(param0, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetDoublev(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALdouble *")] Ref<double> values
    ) => ThisThread.GetDoublev(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    double IAL.GetDoublev()
    {
        double values = default;
        ((IAL)this).GetDoublev(1, (double*)&values);
        return values;
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double GetDoublev() => ThisThread.GetDoublev();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAL.GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename) =>
        (
            (delegate* unmanaged<sbyte*, int>)(
                _slots[26] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[26] = nativeContext.LoadFunction("alGetEnumValue", "openal")
            )
        )(ename);

    [return: NativeTypeName("ALenum")]
    [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename) =>
        ThisThread.GetEnumValue(ename);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAL.GetEnumValue([NativeTypeName("const ALchar *")] Ref<sbyte> ename)
    {
        fixed (sbyte* __dsl_ename = ename)
        {
            return (int)((IAL)this).GetEnumValue(__dsl_ename);
        }
    }

    [return: NativeTypeName("ALenum")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetEnumValue([NativeTypeName("const ALchar *")] Ref<sbyte> ename) =>
        ThisThread.GetEnumValue(ename);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAL.GetError() =>
        (
            (delegate* unmanaged<int>)(
                _slots[27] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[27] = nativeContext.LoadFunction("alGetError", "openal")
            )
        )();

    [return: NativeTypeName("ALenum")]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetError() => ThisThread.GetError();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    float IAL.GetFloat([NativeTypeName("ALenum")] int param0) =>
        (
            (delegate* unmanaged<int, float>)(
                _slots[28] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[28] = nativeContext.LoadFunction("alGetFloat", "openal")
            )
        )(param0);

    [return: NativeTypeName("ALfloat")]
    [NativeFunction("openal", EntryPoint = "alGetFloat")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float GetFloat([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetFloat(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetFloatv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* values
    ) =>
        (
            (delegate* unmanaged<int, float*, void>)(
                _slots[29] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[29] = nativeContext.LoadFunction("alGetFloatv", "openal")
            )
        )(param0, values);

    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetFloatv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* values
    ) => ThisThread.GetFloatv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetFloatv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    )
    {
        fixed (float* __dsl_values = values)
        {
            ((IAL)this).GetFloatv(param0, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetFloatv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    ) => ThisThread.GetFloatv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    float IAL.GetFloatv()
    {
        float values = default;
        ((IAL)this).GetFloatv(1, (float*)&values);
        return values;
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float GetFloatv() => ThisThread.GetFloatv();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAL.GetInteger([NativeTypeName("ALenum")] int param0) =>
        (
            (delegate* unmanaged<int, int>)(
                _slots[30] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[30] = nativeContext.LoadFunction("alGetInteger", "openal")
            )
        )(param0);

    [return: NativeTypeName("ALint")]
    [NativeFunction("openal", EntryPoint = "alGetInteger")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetInteger([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetInteger(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetIntegerv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* values
    ) =>
        (
            (delegate* unmanaged<int, int*, void>)(
                _slots[31] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[31] = nativeContext.LoadFunction("alGetIntegerv", "openal")
            )
        )(param0, values);

    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetIntegerv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* values
    ) => ThisThread.GetIntegerv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetIntegerv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAL)this).GetIntegerv(param0, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetIntegerv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> values
    ) => ThisThread.GetIntegerv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAL.GetIntegerv()
    {
        int values = default;
        ((IAL)this).GetIntegerv(1, (int*)&values);
        return values;
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetIntegerv() => ThisThread.GetIntegerv();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListener3F(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    ) =>
        (
            (delegate* unmanaged<int, float*, float*, float*, void>)(
                _slots[32] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[32] = nativeContext.LoadFunction("alGetListener3f", "openal")
            )
        )(param0, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListener3F(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    ) => ThisThread.GetListener3F(param0, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListener3F(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    )
    {
        fixed (float* __dsl_value3 = value3)
        fixed (float* __dsl_value2 = value2)
        fixed (float* __dsl_value1 = value1)
        {
            ((IAL)this).GetListener3F(param0, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListener3F(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    ) => ThisThread.GetListener3F(param0, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListener3I(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    ) =>
        (
            (delegate* unmanaged<int, int*, int*, int*, void>)(
                _slots[33] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[33] = nativeContext.LoadFunction("alGetListener3i", "openal")
            )
        )(param0, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListener3I(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    ) => ThisThread.GetListener3I(param0, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListener3I(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    )
    {
        fixed (int* __dsl_value3 = value3)
        fixed (int* __dsl_value2 = value2)
        fixed (int* __dsl_value1 = value1)
        {
            ((IAL)this).GetListener3I(param0, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListener3I(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    ) => ThisThread.GetListener3I(param0, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListenerf(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* value
    ) =>
        (
            (delegate* unmanaged<int, float*, void>)(
                _slots[34] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[34] = nativeContext.LoadFunction("alGetListenerf", "openal")
            )
        )(param0, value);

    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListenerf(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* value
    ) => ThisThread.GetListenerf(param0, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListenerf(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> value
    )
    {
        fixed (float* __dsl_value = value)
        {
            ((IAL)this).GetListenerf(param0, __dsl_value);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListenerf(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> value
    ) => ThisThread.GetListenerf(param0, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    float IAL.GetListenerf()
    {
        float value = default;
        ((IAL)this).GetListenerf(1, (float*)&value);
        return value;
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerf")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float GetListenerf() => ThisThread.GetListenerf();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* values
    ) =>
        (
            (delegate* unmanaged<int, float*, void>)(
                _slots[35] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[35] = nativeContext.LoadFunction("alGetListenerfv", "openal")
            )
        )(param0, values);

    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* values
    ) => ThisThread.GetListenerfv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    )
    {
        fixed (float* __dsl_values = values)
        {
            ((IAL)this).GetListenerfv(param0, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    ) => ThisThread.GetListenerfv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    float IAL.GetListenerfv()
    {
        float values = default;
        ((IAL)this).GetListenerfv(1, (float*)&values);
        return values;
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float GetListenerfv() => ThisThread.GetListenerfv();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListeneri(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* value
    ) =>
        (
            (delegate* unmanaged<int, int*, void>)(
                _slots[36] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[36] = nativeContext.LoadFunction("alGetListeneri", "openal")
            )
        )(param0, value);

    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListeneri(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* value
    ) => ThisThread.GetListeneri(param0, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListeneri(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> value
    )
    {
        fixed (int* __dsl_value = value)
        {
            ((IAL)this).GetListeneri(param0, __dsl_value);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListeneri(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> value
    ) => ThisThread.GetListeneri(param0, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAL.GetListeneri()
    {
        int value = default;
        ((IAL)this).GetListeneri(1, (int*)&value);
        return value;
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneri")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetListeneri() => ThisThread.GetListeneri();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* values
    ) =>
        (
            (delegate* unmanaged<int, int*, void>)(
                _slots[37] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[37] = nativeContext.LoadFunction("alGetListeneriv", "openal")
            )
        )(param0, values);

    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* values
    ) => ThisThread.GetListeneriv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAL)this).GetListeneriv(param0, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> values
    ) => ThisThread.GetListeneriv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAL.GetListeneriv()
    {
        int values = default;
        ((IAL)this).GetListeneriv(1, (int*)&values);
        return values;
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetListeneriv() => ThisThread.GetListeneriv();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void* IAL.GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname) =>
        (
            (delegate* unmanaged<sbyte*, void*>)(
                _slots[38] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[38] = nativeContext.LoadFunction("alGetProcAddress", "openal")
            )
        )(fname);

    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname) =>
        ThisThread.GetProcAddress(fname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr IAL.GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname)
    {
        fixed (sbyte* __dsl_fname = fname)
        {
            return (void*)((IAL)this).GetProcAddress(__dsl_fname);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname) =>
        ThisThread.GetProcAddress(fname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSource3F(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    ) =>
        (
            (delegate* unmanaged<uint, int, float*, float*, float*, void>)(
                _slots[39] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[39] = nativeContext.LoadFunction("alGetSource3f", "openal")
            )
        )(source, param1, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSource3F(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    ) => ThisThread.GetSource3F(source, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSource3F(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    )
    {
        fixed (float* __dsl_value3 = value3)
        fixed (float* __dsl_value2 = value2)
        fixed (float* __dsl_value1 = value1)
        {
            ((IAL)this).GetSource3F(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSource3F(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    ) => ThisThread.GetSource3F(source, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSource3I(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    ) =>
        (
            (delegate* unmanaged<uint, int, int*, int*, int*, void>)(
                _slots[40] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[40] = nativeContext.LoadFunction("alGetSource3i", "openal")
            )
        )(source, param1, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSource3I(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    ) => ThisThread.GetSource3I(source, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSource3I(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    )
    {
        fixed (int* __dsl_value3 = value3)
        fixed (int* __dsl_value2 = value2)
        fixed (int* __dsl_value1 = value1)
        {
            ((IAL)this).GetSource3I(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSource3I(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    ) => ThisThread.GetSource3I(source, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSourcef(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value
    ) =>
        (
            (delegate* unmanaged<uint, int, float*, void>)(
                _slots[41] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[41] = nativeContext.LoadFunction("alGetSourcef", "openal")
            )
        )(source, param1, value);

    [NativeFunction("openal", EntryPoint = "alGetSourcef")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSourcef(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value
    ) => ThisThread.GetSourcef(source, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSourcef(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value
    )
    {
        fixed (float* __dsl_value = value)
        {
            ((IAL)this).GetSourcef(source, param1, __dsl_value);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcef")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSourcef(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value
    ) => ThisThread.GetSourcef(source, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* values
    ) =>
        (
            (delegate* unmanaged<uint, int, float*, void>)(
                _slots[42] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[42] = nativeContext.LoadFunction("alGetSourcefv", "openal")
            )
        )(source, param1, values);

    [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* values
    ) => ThisThread.GetSourcefv(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> values
    )
    {
        fixed (float* __dsl_values = values)
        {
            ((IAL)this).GetSourcefv(source, param1, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> values
    ) => ThisThread.GetSourcefv(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSourcei(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value
    ) =>
        (
            (delegate* unmanaged<uint, int, int*, void>)(
                _slots[43] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[43] = nativeContext.LoadFunction("alGetSourcei", "openal")
            )
        )(source, param1, value);

    [NativeFunction("openal", EntryPoint = "alGetSourcei")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSourcei(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value
    ) => ThisThread.GetSourcei(source, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSourcei(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value
    )
    {
        fixed (int* __dsl_value = value)
        {
            ((IAL)this).GetSourcei(source, param1, __dsl_value);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourcei")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSourcei(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value
    ) => ThisThread.GetSourcei(source, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* values
    ) =>
        (
            (delegate* unmanaged<uint, int, int*, void>)(
                _slots[44] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[44] = nativeContext.LoadFunction("alGetSourceiv", "openal")
            )
        )(source, param1, values);

    [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* values
    ) => ThisThread.GetSourceiv(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAL)this).GetSourceiv(source, param1, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> values
    ) => ThisThread.GetSourceiv(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Ptr<sbyte> IAL.GetString([NativeTypeName("ALenum")] int param0) =>
        (sbyte*)((IAL)this).GetStringRaw(param0);

    [return: NativeTypeName("const ALchar *")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<sbyte> GetString([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetString(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte* IAL.GetStringRaw([NativeTypeName("ALenum")] int param0) =>
        (
            (delegate* unmanaged<int, sbyte*>)(
                _slots[45] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[45] = nativeContext.LoadFunction("alGetString", "openal")
            )
        )(param0);

    [return: NativeTypeName("const ALchar *")]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetStringRaw(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAL.IsBuffer([NativeTypeName("ALuint")] uint buffer) =>
        (MaybeBool<sbyte>)(sbyte)((IAL)this).IsBufferRaw(buffer);

    [return: NativeTypeName("ALboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer) =>
        ThisThread.IsBuffer(buffer);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAL.IsBufferRaw([NativeTypeName("ALuint")] uint buffer) =>
        (
            (delegate* unmanaged<uint, sbyte>)(
                _slots[46] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[46] = nativeContext.LoadFunction("alIsBuffer", "openal")
            )
        )(buffer);

    [return: NativeTypeName("ALboolean")]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer) =>
        ThisThread.IsBufferRaw(buffer);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAL.IsEnabled([NativeTypeName("ALenum")] int capability) =>
        (MaybeBool<sbyte>)(sbyte)((IAL)this).IsEnabledRaw(capability);

    [return: NativeTypeName("ALboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> IsEnabled([NativeTypeName("ALenum")] int capability) =>
        ThisThread.IsEnabled(capability);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAL.IsEnabledRaw([NativeTypeName("ALenum")] int capability) =>
        (
            (delegate* unmanaged<int, sbyte>)(
                _slots[47] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[47] = nativeContext.LoadFunction("alIsEnabled", "openal")
            )
        )(capability);

    [return: NativeTypeName("ALboolean")]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsEnabledRaw([NativeTypeName("ALenum")] int capability) =>
        ThisThread.IsEnabledRaw(capability);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAL.IsExtensionPresent([NativeTypeName("const ALchar *")] sbyte* extname) =>
        (
            (delegate* unmanaged<sbyte*, sbyte>)(
                _slots[48] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[48] = nativeContext.LoadFunction("alIsExtensionPresent", "openal")
            )
        )(extname);

    [return: NativeTypeName("ALboolean")]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsExtensionPresent([NativeTypeName("const ALchar *")] sbyte* extname) =>
        ThisThread.IsExtensionPresent(extname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAL.IsExtensionPresent([NativeTypeName("const ALchar *")] Ref<sbyte> extname)
    {
        fixed (sbyte* __dsl_extname = extname)
        {
            return (MaybeBool<sbyte>)(sbyte)((IAL)this).IsExtensionPresent(__dsl_extname);
        }
    }

    [return: NativeTypeName("ALboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> IsExtensionPresent(
        [NativeTypeName("const ALchar *")] Ref<sbyte> extname
    ) => ThisThread.IsExtensionPresent(extname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAL.IsSource([NativeTypeName("ALuint")] uint source) =>
        (MaybeBool<sbyte>)(sbyte)((IAL)this).IsSourceRaw(source);

    [return: NativeTypeName("ALboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source) =>
        ThisThread.IsSource(source);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAL.IsSourceRaw([NativeTypeName("ALuint")] uint source) =>
        (
            (delegate* unmanaged<uint, sbyte>)(
                _slots[49] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[49] = nativeContext.LoadFunction("alIsSource", "openal")
            )
        )(source);

    [return: NativeTypeName("ALboolean")]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source) =>
        ThisThread.IsSourceRaw(source);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listener3F(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    ) =>
        (
            (delegate* unmanaged<int, float, float, float, void>)(
                _slots[50] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[50] = nativeContext.LoadFunction("alListener3f", "openal")
            )
        )(param0, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alListener3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listener3F(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    ) => ThisThread.Listener3F(param0, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listener3I(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    ) =>
        (
            (delegate* unmanaged<int, int, int, int, void>)(
                _slots[51] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[51] = nativeContext.LoadFunction("alListener3i", "openal")
            )
        )(param0, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alListener3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listener3I(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    ) => ThisThread.Listener3I(param0, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listenerf(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat")] float value
    ) =>
        (
            (delegate* unmanaged<int, float, void>)(
                _slots[52] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[52] = nativeContext.LoadFunction("alListenerf", "openal")
            )
        )(param0, value);

    [NativeFunction("openal", EntryPoint = "alListenerf")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listenerf(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat")] float value
    ) => ThisThread.Listenerf(param0, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALfloat *")] float* values
    ) =>
        (
            (delegate* unmanaged<int, float*, void>)(
                _slots[53] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[53] = nativeContext.LoadFunction("alListenerfv", "openal")
            )
        )(param0, values);

    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALfloat *")] float* values
    ) => ThisThread.Listenerfv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    )
    {
        fixed (float* __dsl_values = values)
        {
            ((IAL)this).Listenerfv(param0, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listenerfv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    ) => ThisThread.Listenerfv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listeneri(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint")] int value
    ) =>
        (
            (delegate* unmanaged<int, int, void>)(
                _slots[54] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[54] = nativeContext.LoadFunction("alListeneri", "openal")
            )
        )(param0, value);

    [NativeFunction("openal", EntryPoint = "alListeneri")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listeneri(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint")] int value
    ) => ThisThread.Listeneri(param0, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALint *")] int* values
    ) =>
        (
            (delegate* unmanaged<int, int*, void>)(
                _slots[55] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[55] = nativeContext.LoadFunction("alListeneriv", "openal")
            )
        )(param0, values);

    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALint *")] int* values
    ) => ThisThread.Listeneriv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAL)this).Listeneriv(param0, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listeneriv(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALint *")] Ref<int> values
    ) => ThisThread.Listeneriv(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Source3F(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    ) =>
        (
            (delegate* unmanaged<uint, int, float, float, float, void>)(
                _slots[56] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[56] = nativeContext.LoadFunction("alSource3f", "openal")
            )
        )(source, param1, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alSource3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Source3F(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    ) => ThisThread.Source3F(source, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Source3I(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    ) =>
        (
            (delegate* unmanaged<uint, int, int, int, int, void>)(
                _slots[57] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[57] = nativeContext.LoadFunction("alSource3i", "openal")
            )
        )(source, param1, value1, value2, value3);

    [NativeFunction("openal", EntryPoint = "alSource3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Source3I(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    ) => ThisThread.Source3I(source, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Sourcef(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value
    ) =>
        (
            (delegate* unmanaged<uint, int, float, void>)(
                _slots[58] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[58] = nativeContext.LoadFunction("alSourcef", "openal")
            )
        )(source, param1, value);

    [NativeFunction("openal", EntryPoint = "alSourcef")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Sourcef(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value
    ) => ThisThread.Sourcef(source, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Sourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* values
    ) =>
        (
            (delegate* unmanaged<uint, int, float*, void>)(
                _slots[59] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[59] = nativeContext.LoadFunction("alSourcefv", "openal")
            )
        )(source, param1, values);

    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Sourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* values
    ) => ThisThread.Sourcefv(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Sourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    )
    {
        fixed (float* __dsl_values = values)
        {
            ((IAL)this).Sourcefv(source, param1, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Sourcefv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    ) => ThisThread.Sourcefv(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Sourcei(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value
    ) =>
        (
            (delegate* unmanaged<uint, int, int, void>)(
                _slots[60] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[60] = nativeContext.LoadFunction("alSourcei", "openal")
            )
        )(source, param1, value);

    [NativeFunction("openal", EntryPoint = "alSourcei")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Sourcei(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value
    ) => ThisThread.Sourcei(source, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Sourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* values
    ) =>
        (
            (delegate* unmanaged<uint, int, int*, void>)(
                _slots[61] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[61] = nativeContext.LoadFunction("alSourceiv", "openal")
            )
        )(source, param1, values);

    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Sourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* values
    ) => ThisThread.Sourceiv(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Sourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAL)this).Sourceiv(source, param1, __dsl_values);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Sourceiv(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    ) => ThisThread.Sourceiv(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourcePause([NativeTypeName("ALuint")] uint source) =>
        (
            (delegate* unmanaged<uint, void>)(
                _slots[62] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[62] = nativeContext.LoadFunction("alSourcePause", "openal")
            )
        )(source);

    [NativeFunction("openal", EntryPoint = "alSourcePause")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourcePause([NativeTypeName("ALuint")] uint source) =>
        ThisThread.SourcePause(source);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourcePausev(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    ) =>
        (
            (delegate* unmanaged<int, uint*, void>)(
                _slots[63] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[63] = nativeContext.LoadFunction("alSourcePausev", "openal")
            )
        )(n, sources);

    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourcePausev(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    ) => ThisThread.SourcePausev(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourcePausev(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    )
    {
        fixed (uint* __dsl_sources = sources)
        {
            ((IAL)this).SourcePausev(n, __dsl_sources);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourcePausev(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    ) => ThisThread.SourcePausev(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourcePlay([NativeTypeName("ALuint")] uint source) =>
        (
            (delegate* unmanaged<uint, void>)(
                _slots[64] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[64] = nativeContext.LoadFunction("alSourcePlay", "openal")
            )
        )(source);

    [NativeFunction("openal", EntryPoint = "alSourcePlay")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourcePlay([NativeTypeName("ALuint")] uint source) =>
        ThisThread.SourcePlay(source);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourcePlayv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    ) =>
        (
            (delegate* unmanaged<int, uint*, void>)(
                _slots[65] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[65] = nativeContext.LoadFunction("alSourcePlayv", "openal")
            )
        )(n, sources);

    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourcePlayv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    ) => ThisThread.SourcePlayv(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourcePlayv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    )
    {
        fixed (uint* __dsl_sources = sources)
        {
            ((IAL)this).SourcePlayv(n, __dsl_sources);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourcePlayv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    ) => ThisThread.SourcePlayv(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceQueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("const ALuint *")] uint* buffers
    ) =>
        (
            (delegate* unmanaged<uint, int, uint*, void>)(
                _slots[66] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[66] = nativeContext.LoadFunction("alSourceQueueBuffers", "openal")
            )
        )(source, nb, buffers);

    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceQueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("const ALuint *")] uint* buffers
    ) => ThisThread.SourceQueueBuffers(source, nb, buffers);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceQueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers
    )
    {
        fixed (uint* __dsl_buffers = buffers)
        {
            ((IAL)this).SourceQueueBuffers(source, nb, __dsl_buffers);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceQueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers
    ) => ThisThread.SourceQueueBuffers(source, nb, buffers);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceRewind([NativeTypeName("ALuint")] uint source) =>
        (
            (delegate* unmanaged<uint, void>)(
                _slots[67] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[67] = nativeContext.LoadFunction("alSourceRewind", "openal")
            )
        )(source);

    [NativeFunction("openal", EntryPoint = "alSourceRewind")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceRewind([NativeTypeName("ALuint")] uint source) =>
        ThisThread.SourceRewind(source);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceRewindv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    ) =>
        (
            (delegate* unmanaged<int, uint*, void>)(
                _slots[68] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[68] = nativeContext.LoadFunction("alSourceRewindv", "openal")
            )
        )(n, sources);

    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceRewindv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    ) => ThisThread.SourceRewindv(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceRewindv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    )
    {
        fixed (uint* __dsl_sources = sources)
        {
            ((IAL)this).SourceRewindv(n, __dsl_sources);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceRewindv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    ) => ThisThread.SourceRewindv(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceStop([NativeTypeName("ALuint")] uint source) =>
        (
            (delegate* unmanaged<uint, void>)(
                _slots[69] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[69] = nativeContext.LoadFunction("alSourceStop", "openal")
            )
        )(source);

    [NativeFunction("openal", EntryPoint = "alSourceStop")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceStop([NativeTypeName("ALuint")] uint source) =>
        ThisThread.SourceStop(source);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceStopv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    ) =>
        (
            (delegate* unmanaged<int, uint*, void>)(
                _slots[70] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[70] = nativeContext.LoadFunction("alSourceStopv", "openal")
            )
        )(n, sources);

    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceStopv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] uint* sources
    ) => ThisThread.SourceStopv(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceStopv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    )
    {
        fixed (uint* __dsl_sources = sources)
        {
            ((IAL)this).SourceStopv(n, __dsl_sources);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceStopv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    ) => ThisThread.SourceStopv(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceUnqueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("ALuint *")] uint* buffers
    ) =>
        (
            (delegate* unmanaged<uint, int, uint*, void>)(
                _slots[71] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[71] = nativeContext.LoadFunction("alSourceUnqueueBuffers", "openal")
            )
        )(source, nb, buffers);

    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceUnqueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("ALuint *")] uint* buffers
    ) => ThisThread.SourceUnqueueBuffers(source, nb, buffers);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceUnqueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("ALuint *")] Ref<uint> buffers
    )
    {
        fixed (uint* __dsl_buffers = buffers)
        {
            ((IAL)this).SourceUnqueueBuffers(source, nb, __dsl_buffers);
        }
    }

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceUnqueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("ALuint *")] Ref<uint> buffers
    ) => ThisThread.SourceUnqueueBuffers(source, nb, buffers);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SpeedOfSound([NativeTypeName("ALfloat")] float value) =>
        (
            (delegate* unmanaged<float, void>)(
                _slots[72] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[72] = nativeContext.LoadFunction("alSpeedOfSound", "openal")
            )
        )(value);

    [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SpeedOfSound([NativeTypeName("ALfloat")] float value) =>
        ThisThread.SpeedOfSound(value);
}
