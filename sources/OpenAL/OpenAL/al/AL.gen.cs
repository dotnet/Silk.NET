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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Buffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBuffer3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Buffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBufferData")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int format,
            [NativeTypeName("const ALvoid *")] void* data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, ALEnum, Format> format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        )
        {
            fixed (void* __dsl_data = data)
            {
                BufferData(buffer, (int)format, __dsl_data, size, samplerate);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBufferf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBufferfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Buffer(buffer, param1, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBufferi")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alBufferiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Buffer(buffer, param1, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        public static void DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers) =>
            DeleteBuffers(1, (uint*)&buffers);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alDeleteBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* buffers
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        public static void DeleteSource([NativeTypeName("const ALuint *")] uint sources) =>
            DeleteSources(1, (uint*)&sources);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alDeleteSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Disable([NativeTypeName("ALenum")] int capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        public static void Disable(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
        ) => Disable((int)capability);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alDistanceModel")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void DistanceModel([NativeTypeName("ALenum")] int distanceModel);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        public static void DistanceModel(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, DistanceModel> distanceModel
        ) => DistanceModel((int)distanceModel);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alDopplerFactor")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void DopplerFactor([NativeTypeName("ALfloat")] float value);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alDopplerVelocity")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void DopplerVelocity([NativeTypeName("ALfloat")] float value);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alEnable")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Enable([NativeTypeName("ALenum")] int capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        public static void Enable(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
        ) => Enable((int)capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        public static uint GenBuffer()
        {
            uint buffers = default;
            GenBuffers(1, (uint*)&buffers);
            return buffers;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGenBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* buffers
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        public static uint GenSource()
        {
            uint sources = default;
            GenSources(1, (uint*)&sources);
            return sources;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGenSources")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        public static MaybeBool<sbyte> GetBoolean([NativeTypeName("ALenum")] int param0) =>
            (MaybeBool<sbyte>)(sbyte)GetBooleanRaw(param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBoolean")]
        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBooleanv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetBoolean(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] sbyte* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBoolean(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] Ref<sbyte> values
        )
        {
            fixed (sbyte* __dsl_values = values)
            {
                GetBoolean(param0, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        public static sbyte GetBoolean()
        {
            sbyte values = default;
            GetBoolean(1, (sbyte*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBuffer3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3(
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
                GetBuffer3(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBuffer3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3(
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
                GetBuffer3(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetBufferf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern double GetDouble([NativeTypeName("ALenum")] int param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetDoublev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetDouble(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] double* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetDouble(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] Ref<double> values
        )
        {
            fixed (double* __dsl_values = values)
            {
                GetDouble(param0, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        public static double GetDouble()
        {
            double values = default;
            GetDouble(1, (double*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetEnumValue")]
        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern int GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename);

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        public static Constant<int, ErrorCode> GetError() =>
            (Constant<int, ErrorCode>)(int)GetErrorRaw();

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetError")]
        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern int GetErrorRaw();

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetFloat")]
        [return: NativeTypeName("ALfloat")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern float GetFloat([NativeTypeName("ALenum")] int param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetFloatv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetFloat(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetFloat(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                GetFloat(param0, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        public static float GetFloat()
        {
            float values = default;
            GetFloat(1, (float*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetInteger")]
        [return: NativeTypeName("ALint")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern int GetInteger([NativeTypeName("ALenum")] int param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetIntegerv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetInteger(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetInteger(param0, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        public static int GetInteger()
        {
            int values = default;
            GetInteger(1, (int*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListener3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetListener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3(
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
                GetListener3(param0, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListener3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetListener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3(
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
                GetListener3(param0, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListenerf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        public static float GetListenerf()
        {
            float value = default;
            GetListenerf(1, (float*)&value);
            return value;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListenerfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        public static float GetListenerfv()
        {
            float values = default;
            GetListenerfv(1, (float*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListeneri")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        public static int GetListeneri()
        {
            int value = default;
            GetListeneri(1, (int*)&value);
            return value;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        public static int GetListeneriv()
        {
            int values = default;
            GetListeneriv(1, (int*)&values);
            return values;
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetProcAddress")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3(
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
                GetSource3(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetSource3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3(
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
                GetSource3(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetSourcef")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetString([NativeTypeName("ALenum")] int param0) =>
            (sbyte*)GetStringRaw(param0);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alGetString")]
        [return: NativeTypeName("const ALchar *")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        public static MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer) =>
            (MaybeBool<sbyte>)(sbyte)IsBufferRaw(buffer);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alIsBuffer")]
        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alIsEnabled")]
        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte IsEnabled([NativeTypeName("ALenum")] int capability);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        public static MaybeBool<sbyte> IsEnabled(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
        ) => (MaybeBool<sbyte>)(sbyte)IsEnabled((int)capability);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alIsExtensionPresent")]
        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte IsExtensionPresent(
            [NativeTypeName("const ALchar *")] sbyte* extname
        );

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        public static MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source) =>
            (MaybeBool<sbyte>)(sbyte)IsSourceRaw(source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alIsSource")]
        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListener3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Listener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListener3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Listener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListenerf")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListenerfv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Listener(param0, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListeneri")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alListeneriv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Listener(param0, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSource3f")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Source3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSource3i")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Source3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcef")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcefv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Source(source, param1, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcei")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        );

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceiv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Source(source, param1, __dsl_values);
            }
        }

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcePause")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SourcePause([NativeTypeName("ALuint")] uint source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcePausev")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        public static void SourcePausev([NativeTypeName("const ALuint *")] uint sources) =>
            SourcePausev(1, (uint*)&sources);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcePlay")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SourcePlay([NativeTypeName("ALuint")] uint source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourcePlayv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        public static void SourcePlayv([NativeTypeName("const ALuint *")] uint sources) =>
            SourcePlayv(1, (uint*)&sources);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceQueueBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] uint* buffers
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SourceRewin([NativeTypeName("ALuint")] uint source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceRewindv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        public static void SourceRewindv([NativeTypeName("const ALuint *")] uint sources) =>
            SourceRewindv(1, (uint*)&sources);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceStop")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SourceStop([NativeTypeName("ALuint")] uint source);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceStopv")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        public static void SourceStopv([NativeTypeName("const ALuint *")] uint sources) =>
            SourceStopv(1, (uint*)&sources);

        [DllImport("openal", ExactSpelling = true, EntryPoint = "alSourceUnqueueBuffers")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        public static extern void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] uint* buffers
        );

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
        public static extern void SpeedOfSound([NativeTypeName("ALfloat")] float value);
    }

    public partial class StaticWrapper<T> : IAL
        where T : IAL.Static
    {
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Buffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => T.Buffer3(buffer, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Buffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => T.Buffer3(buffer, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, ALEnum, Format> format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        ) => T.BufferData(buffer, format, data, size, samplerate);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        ) => T.Buffer(buffer, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        ) => T.Buffer(buffer, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        ) => T.Buffer(buffer, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferi")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        ) => T.Buffer(buffer, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        ) => T.Buffer(buffer, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        ) => T.Buffer(buffer, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers) =>
            T.DeleteBuffer(buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* buffers
        ) => T.DeleteBuffers(n, buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> buffers
        ) => T.DeleteBuffers(n, buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteSource([NativeTypeName("const ALuint *")] uint sources) =>
            T.DeleteSource(sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => T.DeleteSources(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        ) => T.DeleteSources(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Disable([NativeTypeName("ALenum")] int capability) => T.Disable(capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Disable(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
        ) => T.Disable(capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DistanceModel([NativeTypeName("ALenum")] int distanceModel) =>
            T.DistanceModel(distanceModel);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DistanceModel(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, DistanceModel> distanceModel
        ) => T.DistanceModel(distanceModel);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DopplerFactor([NativeTypeName("ALfloat")] float value) =>
            T.DopplerFactor(value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void DopplerVelocity([NativeTypeName("ALfloat")] float value) =>
            T.DopplerVelocity(value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Enable([NativeTypeName("ALenum")] int capability) => T.Enable(capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Enable(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
        ) => T.Enable(capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint GenBuffer() => T.GenBuffer();

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* buffers
        ) => T.GenBuffers(n, buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] Ref<uint> buffers
        ) => T.GenBuffers(n, buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint GenSource() => T.GenSource();

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* sources
        ) => T.GenSources(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> GetBoolean([NativeTypeName("ALenum")] int param0) =>
            T.GetBoolean(param0);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0) =>
            T.GetBooleanRaw(param0);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBoolean(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] sbyte* values
        ) => T.GetBoolean(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBoolean(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] Ref<sbyte> values
        ) => T.GetBoolean(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte GetBoolean() => T.GetBoolean();

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => T.GetBuffer3(buffer, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        ) => T.GetBuffer3(buffer, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => T.GetBuffer3(buffer, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        ) => T.GetBuffer3(buffer, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        ) => T.GetBufferf(buffer, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        ) => T.GetBufferfv(buffer, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        ) => T.GetBufferi(buffer, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        ) => T.GetBufferiv(buffer, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public double GetDouble([NativeTypeName("ALenum")] int param0) => T.GetDouble(param0);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetDouble(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] double* values
        ) => T.GetDouble(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetDouble(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] Ref<double> values
        ) => T.GetDouble(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public double GetDouble() => T.GetDouble();

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename) =>
            T.GetEnumValue(ename);

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetEnumValue([NativeTypeName("const ALchar *")] Ref<sbyte> ename) =>
            T.GetEnumValue(ename);

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Constant<int, ErrorCode> GetError() => T.GetError();

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetErrorRaw() => T.GetErrorRaw();

        [return: NativeTypeName("ALfloat")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public float GetFloat([NativeTypeName("ALenum")] int param0) => T.GetFloat(param0);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetFloat(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        ) => T.GetFloat(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetFloat(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        ) => T.GetFloat(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public float GetFloat() => T.GetFloat();

        [return: NativeTypeName("ALint")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetInteger([NativeTypeName("ALenum")] int param0) => T.GetInteger(param0);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetInteger(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        ) => T.GetInteger(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetInteger(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        ) => T.GetInteger(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetInteger() => T.GetInteger();

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => T.GetListener3(param0, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        ) => T.GetListener3(param0, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => T.GetListener3(param0, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        ) => T.GetListener3(param0, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value
        ) => T.GetListenerf(param0, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> value
        ) => T.GetListenerf(param0, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public float GetListenerf() => T.GetListenerf();

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        ) => T.GetListenerfv(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        ) => T.GetListenerfv(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public float GetListenerfv() => T.GetListenerfv();

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value
        ) => T.GetListeneri(param0, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> value
        ) => T.GetListeneri(param0, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetListeneri() => T.GetListeneri();

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        ) => T.GetListeneriv(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        ) => T.GetListeneriv(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public int GetListeneriv() => T.GetListeneriv();

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname) =>
            T.GetProcAddress(fname);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname) =>
            T.GetProcAddress(fname);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => T.GetSource3(source, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] Ref<float> value1,
            [NativeTypeName("ALfloat *")] Ref<float> value2,
            [NativeTypeName("ALfloat *")] Ref<float> value3
        ) => T.GetSource3(source, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => T.GetSource3(source, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] Ref<int> value1,
            [NativeTypeName("ALint *")] Ref<int> value2,
            [NativeTypeName("ALint *")] Ref<int> value3
        ) => T.GetSource3(source, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        ) => T.GetSourcef(source, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        ) => T.GetSourcefv(source, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        ) => T.GetSourcei(source, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        ) => T.GetSourceiv(source, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr<sbyte> GetString([NativeTypeName("ALenum")] int param0) => T.GetString(param0);

        [return: NativeTypeName("const ALchar *")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0) => T.GetStringRaw(param0);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer) =>
            T.IsBuffer(buffer);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer) => T.IsBufferRaw(buffer);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsEnabled([NativeTypeName("ALenum")] int capability) =>
            T.IsEnabled(capability);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsEnabled(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
        ) => T.IsEnabled(capability);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsExtensionPresent([NativeTypeName("const ALchar *")] sbyte* extname) =>
            T.IsExtensionPresent(extname);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsExtensionPresent(
            [NativeTypeName("const ALchar *")] Ref<sbyte> extname
        ) => T.IsExtensionPresent(extname);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source) =>
            T.IsSource(source);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source) => T.IsSourceRaw(source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => T.Listener3(param0, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => T.Listener3(param0, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value
        ) => T.Listener(param0, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] float* values
        ) => T.Listener(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        ) => T.Listener(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value
        ) => T.Listener(param0, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] int* values
        ) => T.Listener(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] Ref<int> values
        ) => T.Listener(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Source3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => T.Source3(source, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Source3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => T.Source3(source, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcef")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        ) => T.Source(source, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        ) => T.Source(source, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        ) => T.Source(source, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcei")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        ) => T.Source(source, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        ) => T.Source(source, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        ) => T.Source(source, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePause")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePause([NativeTypeName("ALuint")] uint source) => T.SourcePause(source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => T.SourcePausev(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        ) => T.SourcePausev(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePausev([NativeTypeName("const ALuint *")] uint sources) =>
            T.SourcePausev(sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlay")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePlay([NativeTypeName("ALuint")] uint source) => T.SourcePlay(source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => T.SourcePlayv(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        ) => T.SourcePlayv(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourcePlayv([NativeTypeName("const ALuint *")] uint sources) =>
            T.SourcePlayv(sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] uint* buffers
        ) => T.SourceQueueBuffers(source, nb, buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewind")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceRewin([NativeTypeName("ALuint")] uint source) => T.SourceRewin(source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => T.SourceRewindv(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        ) => T.SourceRewindv(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceRewindv([NativeTypeName("const ALuint *")] uint sources) =>
            T.SourceRewindv(sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceStop([NativeTypeName("ALuint")] uint source) => T.SourceStop(source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => T.SourceStopv(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] Ref<uint> sources
        ) => T.SourceStopv(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceStopv([NativeTypeName("const ALuint *")] uint sources) =>
            T.SourceStopv(sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] uint* buffers
        ) => T.SourceUnqueueBuffers(source, nb, buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
        [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public void SpeedOfSound([NativeTypeName("ALfloat")] float value) => T.SpeedOfSound(value);
    }

    public partial class ThisThread
    {
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => Underlying.Value!.Buffer3(buffer, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => Underlying.Value!.Buffer3(buffer, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferData")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void BufferData(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] Constant<int, ALEnum, Format> format,
            [NativeTypeName("const ALvoid *")] Ref data,
            [NativeTypeName("ALsizei")] int size,
            [NativeTypeName("ALsizei")] int samplerate
        )
        {
            fixed (void* __dsl_data = data)
            {
                BufferData(buffer, (int)format, __dsl_data, size, samplerate);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        ) => Underlying.Value!.Buffer(buffer, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        ) => Underlying.Value!.Buffer(buffer, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Buffer(buffer, param1, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferi")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        ) => Underlying.Value!.Buffer(buffer, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        ) => Underlying.Value!.Buffer(buffer, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Buffer(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Buffer(buffer, param1, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers) =>
            Underlying.Value!.DeleteBuffer(buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* buffers
        ) => Underlying.Value!.DeleteBuffers(n, buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteSource([NativeTypeName("const ALuint *")] uint sources) =>
            Underlying.Value!.DeleteSource(sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDeleteSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DeleteSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => Underlying.Value!.DeleteSources(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Disable([NativeTypeName("ALenum")] int capability) =>
            Underlying.Value!.Disable(capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDisable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Disable(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
        ) => Underlying.Value!.Disable(capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DistanceModel([NativeTypeName("ALenum")] int distanceModel) =>
            Underlying.Value!.DistanceModel(distanceModel);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alDistanceModel")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DistanceModel(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, DistanceModel> distanceModel
        ) => Underlying.Value!.DistanceModel(distanceModel);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerFactor")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DopplerFactor([NativeTypeName("ALfloat")] float value) =>
            Underlying.Value!.DopplerFactor(value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alDopplerVelocity")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void DopplerVelocity([NativeTypeName("ALfloat")] float value) =>
            Underlying.Value!.DopplerVelocity(value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Enable([NativeTypeName("ALenum")] int capability) =>
            Underlying.Value!.Enable(capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alEnable")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Enable(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
        ) => Underlying.Value!.Enable(capability);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GenBuffers(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* buffers
        ) => Underlying.Value!.GenBuffers(n, buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGenSources")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GenSources(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("ALuint *")] uint* sources
        ) => Underlying.Value!.GenSources(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> GetBoolean([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetBoolean(param0);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBoolean")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetBooleanRaw(param0);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBoolean(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] sbyte* values
        ) => Underlying.Value!.GetBoolean(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBoolean(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALboolean *")] Ref<sbyte> values
        )
        {
            fixed (sbyte* __dsl_values = values)
            {
                GetBoolean(param0, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte GetBoolean()
        {
            sbyte values = default;
            GetBoolean(1, (sbyte*)&values);
            return values;
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => Underlying.Value!.GetBuffer3(buffer, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3(
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
                GetBuffer3(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => Underlying.Value!.GetBuffer3(buffer, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBuffer3(
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
                GetBuffer3(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferf(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        ) => Underlying.Value!.GetBufferf(buffer, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferfv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        ) => Underlying.Value!.GetBufferfv(buffer, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferi")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferi(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        ) => Underlying.Value!.GetBufferi(buffer, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetBufferiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetBufferiv(
            [NativeTypeName("ALuint")] uint buffer,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        ) => Underlying.Value!.GetBufferiv(buffer, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDouble")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static double GetDouble([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetDouble(param0);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetDouble(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] double* values
        ) => Underlying.Value!.GetDouble(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetDouble(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALdouble *")] Ref<double> values
        )
        {
            fixed (double* __dsl_values = values)
            {
                GetDouble(param0, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetDoublev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static double GetDouble()
        {
            double values = default;
            GetDouble(1, (double*)&values);
            return values;
        }

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetEnumValue([NativeTypeName("const ALchar *")] sbyte* ename) =>
            Underlying.Value!.GetEnumValue(ename);

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Constant<int, ErrorCode> GetError() => Underlying.Value!.GetError();

        [return: NativeTypeName("ALenum")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetError")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetErrorRaw() => Underlying.Value!.GetErrorRaw();

        [return: NativeTypeName("ALfloat")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloat")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static float GetFloat([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetFloat(param0);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetFloat(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        ) => Underlying.Value!.GetFloat(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetFloat(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                GetFloat(param0, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetFloatv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static float GetFloat()
        {
            float values = default;
            GetFloat(1, (float*)&values);
            return values;
        }

        [return: NativeTypeName("ALint")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetInteger")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetInteger([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetInteger(param0);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        ) => Underlying.Value!.GetInteger(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetInteger(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                GetInteger(param0, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static int GetInteger()
        {
            int values = default;
            GetInteger(1, (int*)&values);
            return values;
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => Underlying.Value!.GetListener3(param0, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3(
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
                GetListener3(param0, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => Underlying.Value!.GetListener3(param0, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListener3(
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
                GetListener3(param0, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListenerf(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* value
        ) => Underlying.Value!.GetListenerf(param0, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListenerfv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat *")] float* values
        ) => Underlying.Value!.GetListenerfv(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListeneri(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* value
        ) => Underlying.Value!.GetListeneri(param0, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetListeneriv(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint *")] int* values
        ) => Underlying.Value!.GetListeneriv(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void* GetProcAddress([NativeTypeName("const ALchar *")] sbyte* fname) =>
            Underlying.Value!.GetProcAddress(fname);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value1,
            [NativeTypeName("ALfloat *")] float* value2,
            [NativeTypeName("ALfloat *")] float* value3
        ) => Underlying.Value!.GetSource3(source, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3(
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
                GetSource3(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value1,
            [NativeTypeName("ALint *")] int* value2,
            [NativeTypeName("ALint *")] int* value3
        ) => Underlying.Value!.GetSource3(source, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSource3(
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
                GetSource3(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcef")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcef(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* value
        ) => Underlying.Value!.GetSourcef(source, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcefv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat *")] float* values
        ) => Underlying.Value!.GetSourcefv(source, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourcei")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourcei(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* value
        ) => Underlying.Value!.GetSourcei(source, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void GetSourceiv(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint *")] int* values
        ) => Underlying.Value!.GetSourceiv(source, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static Ptr<sbyte> GetString([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetString(param0);

        [return: NativeTypeName("const ALchar *")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alGetString")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0) =>
            Underlying.Value!.GetStringRaw(param0);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsBuffer([NativeTypeName("ALuint")] uint buffer) =>
            Underlying.Value!.IsBuffer(buffer);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsBuffer")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer) =>
            Underlying.Value!.IsBufferRaw(buffer);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsEnabled([NativeTypeName("ALenum")] int capability) =>
            Underlying.Value!.IsEnabled(capability);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsEnabled")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsEnabled(
            [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
        ) => Underlying.Value!.IsEnabled(capability);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsExtensionPresent")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsExtensionPresent([NativeTypeName("const ALchar *")] sbyte* extname) =>
            Underlying.Value!.IsExtensionPresent(extname);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static MaybeBool<sbyte> IsSource([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.IsSource(source);

        [return: NativeTypeName("ALboolean")]
        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alIsSource")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.IsSourceRaw(source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => Underlying.Value!.Listener3(param0, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListener3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener3(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => Underlying.Value!.Listener3(param0, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerf")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALfloat")] float value
        ) => Underlying.Value!.Listener(param0, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] float* values
        ) => Underlying.Value!.Listener(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListenerfv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Listener(param0, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneri")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("ALint")] int value
        ) => Underlying.Value!.Listener(param0, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] int* values
        ) => Underlying.Value!.Listener(param0, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alListeneriv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Listener(
            [NativeTypeName("ALenum")] int param0,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Listener(param0, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3f")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value1,
            [NativeTypeName("ALfloat")] float value2,
            [NativeTypeName("ALfloat")] float value3
        ) => Underlying.Value!.Source3(source, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSource3i")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source3(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value1,
            [NativeTypeName("ALint")] int value2,
            [NativeTypeName("ALint")] int value3
        ) => Underlying.Value!.Source3(source, param1, value1, value2, value3);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcef")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALfloat")] float value
        ) => Underlying.Value!.Source(source, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] float* values
        ) => Underlying.Value!.Source(source, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcefv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALfloat *")] Ref<float> values
        )
        {
            fixed (float* __dsl_values = values)
            {
                Source(source, param1, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcei")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("ALint")] int value
        ) => Underlying.Value!.Source(source, param1, value);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] int* values
        ) => Underlying.Value!.Source(source, param1, values);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceiv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void Source(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALenum")] int param1,
            [NativeTypeName("const ALint *")] Ref<int> values
        )
        {
            fixed (int* __dsl_values = values)
            {
                Source(source, param1, __dsl_values);
            }
        }

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePause")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePause([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.SourcePause(source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePausev(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => Underlying.Value!.SourcePausev(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePausev")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePausev([NativeTypeName("const ALuint *")] uint sources) =>
            Underlying.Value!.SourcePausev(sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlay")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePlay([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.SourcePlay(source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePlayv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => Underlying.Value!.SourcePlayv(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourcePlayv([NativeTypeName("const ALuint *")] uint sources) =>
            Underlying.Value!.SourcePlayv(sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceQueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("const ALuint *")] uint* buffers
        ) => Underlying.Value!.SourceQueueBuffers(source, nb, buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewind")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceRewin([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.SourceRewin(source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceRewindv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => Underlying.Value!.SourceRewindv(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceRewindv([NativeTypeName("const ALuint *")] uint sources) =>
            Underlying.Value!.SourceRewindv(sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStop")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceStop([NativeTypeName("ALuint")] uint source) =>
            Underlying.Value!.SourceStop(source);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceStopv(
            [NativeTypeName("ALsizei")] int n,
            [NativeTypeName("const ALuint *")] uint* sources
        ) => Underlying.Value!.SourceStopv(n, sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alSourceStopv")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceStopv([NativeTypeName("const ALuint *")] uint sources) =>
            Underlying.Value!.SourceStopv(sources);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
        [NativeFunction("openal", EntryPoint = "alSourceUnqueueBuffers")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static void SourceUnqueueBuffers(
            [NativeTypeName("ALuint")] uint source,
            [NativeTypeName("ALsizei")] int nb,
            [NativeTypeName("ALuint *")] uint* buffers
        ) => Underlying.Value!.SourceUnqueueBuffers(source, nb, buffers);

        [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

        [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    public const int Invalid = (-1);

    [NativeTypeName("#define AL_ILLEGAL_ENUM AL_INVALID_ENUM")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    public const int IllegalEnum = 0xA002;

    [NativeTypeName("#define AL_ILLEGAL_COMMAND AL_INVALID_OPERATION")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    public const int IllegalCommand = 0xA004;

    [NativeTypeName("#define AL_EXT_FOLDBACK_NAME \"AL_EXT_FOLDBACK\"")]
    [SupportedApiProfile("al", ["AL_EXT_FOLDBACK"])]
    public static ReadOnlySpan<byte> ExtFoldbackName => "AL_EXT_FOLDBACK"u8;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Buffer3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBuffer3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Buffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    ) => ThisThread.Buffer3(buffer, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Buffer3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBuffer3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Buffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    ) => ThisThread.Buffer3(buffer, param1, value1, value2, value3);

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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
        [NativeTypeName("ALenum")] Constant<int, ALEnum, Format> format,
        [NativeTypeName("const ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    )
    {
        fixed (void* __dsl_data = data)
        {
            ((IAL)this).BufferData(buffer, (int)format, __dsl_data, size, samplerate);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferData")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void BufferData(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] Constant<int, ALEnum, Format> format,
        [NativeTypeName("const ALvoid *")] Ref data,
        [NativeTypeName("ALsizei")] int size,
        [NativeTypeName("ALsizei")] int samplerate
    ) => ThisThread.BufferData(buffer, format, data, size, samplerate);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Buffer(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferf")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value
    ) => ThisThread.Buffer(buffer, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Buffer(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* values
    ) => ThisThread.Buffer(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    )
    {
        fixed (float* __dsl_values = values)
        {
            ((IAL)this).Buffer(buffer, param1, __dsl_values);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    ) => ThisThread.Buffer(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Buffer(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferi")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value
    ) => ThisThread.Buffer(buffer, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Buffer(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* values
    ) => ThisThread.Buffer(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAL)this).Buffer(buffer, param1, __dsl_values);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alBufferiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Buffer(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    ) => ThisThread.Buffer(buffer, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DeleteBuffer([NativeTypeName("const ALuint *")] uint buffers) =>
        ((IAL)this).DeleteBuffers(1, (uint*)&buffers);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDisable")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Disable([NativeTypeName("ALenum")] int capability) =>
        ThisThread.Disable(capability);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Disable([NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability) =>
        ((IAL)this).Disable((int)capability);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDisable")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Disable(
        [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
    ) => ThisThread.Disable(capability);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DistanceModel([NativeTypeName("ALenum")] int distanceModel) =>
        (
            (delegate* unmanaged<int, void>)(
                _slots[10] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[10] = nativeContext.LoadFunction("alDistanceModel", "openal")
            )
        )(distanceModel);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DistanceModel([NativeTypeName("ALenum")] int distanceModel) =>
        ThisThread.DistanceModel(distanceModel);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DistanceModel(
        [NativeTypeName("ALenum")] Constant<int, ALEnum, DistanceModel> distanceModel
    ) => ((IAL)this).DistanceModel((int)distanceModel);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alDistanceModel")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void DistanceModel(
        [NativeTypeName("ALenum")] Constant<int, ALEnum, DistanceModel> distanceModel
    ) => ThisThread.DistanceModel(distanceModel);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.DopplerFactor([NativeTypeName("ALfloat")] float value) =>
        (
            (delegate* unmanaged<float, void>)(
                _slots[11] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[11] = nativeContext.LoadFunction("alDopplerFactor", "openal")
            )
        )(value);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alEnable")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Enable([NativeTypeName("ALenum")] int capability) =>
        ThisThread.Enable(capability);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Enable([NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability) =>
        ((IAL)this).Enable((int)capability);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alEnable")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Enable(
        [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
    ) => ThisThread.Enable(capability);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IAL.GenBuffer()
    {
        uint buffers = default;
        ((IAL)this).GenBuffers(1, (uint*)&buffers);
        return buffers;
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBoolean")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte GetBooleanRaw([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetBooleanRaw(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBoolean(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBoolean(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALboolean *")] sbyte* values
    ) => ThisThread.GetBoolean(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBoolean(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALboolean *")] Ref<sbyte> values
    )
    {
        fixed (sbyte* __dsl_values = values)
        {
            ((IAL)this).GetBoolean(param0, __dsl_values);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBoolean(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALboolean *")] Ref<sbyte> values
    ) => ThisThread.GetBoolean(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAL.GetBoolean()
    {
        sbyte values = default;
        ((IAL)this).GetBoolean(1, (sbyte*)&values);
        return values;
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBooleanv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte GetBoolean() => ThisThread.GetBoolean();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBuffer3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBuffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    ) => ThisThread.GetBuffer3(buffer, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBuffer3(
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
            ((IAL)this).GetBuffer3(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBuffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    ) => ThisThread.GetBuffer3(buffer, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBuffer3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBuffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    ) => ThisThread.GetBuffer3(buffer, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetBuffer3(
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
            ((IAL)this).GetBuffer3(buffer, param1, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetBuffer3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetBuffer3(
        [NativeTypeName("ALuint")] uint buffer,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    ) => ThisThread.GetBuffer3(buffer, param1, value1, value2, value3);

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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDouble")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double GetDouble([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetDouble(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetDouble(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetDouble(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALdouble *")] double* values
    ) => ThisThread.GetDouble(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetDouble(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALdouble *")] Ref<double> values
    )
    {
        fixed (double* __dsl_values = values)
        {
            ((IAL)this).GetDouble(param0, __dsl_values);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetDouble(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALdouble *")] Ref<double> values
    ) => ThisThread.GetDouble(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    double IAL.GetDouble()
    {
        double values = default;
        ((IAL)this).GetDouble(1, (double*)&values);
        return values;
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetDoublev")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static double GetDouble() => ThisThread.GetDouble();

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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetEnumValue")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetEnumValue([NativeTypeName("const ALchar *")] Ref<sbyte> ename) =>
        ThisThread.GetEnumValue(ename);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    Constant<int, ErrorCode> IAL.GetError() =>
        (Constant<int, ErrorCode>)(int)((IAL)this).GetErrorRaw();

    [return: NativeTypeName("ALenum")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Constant<int, ErrorCode> GetError() => ThisThread.GetError();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAL.GetErrorRaw() =>
        (
            (delegate* unmanaged<int>)(
                _slots[27] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[27] = nativeContext.LoadFunction("alGetError", "openal")
            )
        )();

    [return: NativeTypeName("ALenum")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetError")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetErrorRaw() => ThisThread.GetErrorRaw();

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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloat")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float GetFloat([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetFloat(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetFloat(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetFloat(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* values
    ) => ThisThread.GetFloat(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetFloat(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    )
    {
        fixed (float* __dsl_values = values)
        {
            ((IAL)this).GetFloat(param0, __dsl_values);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetFloat(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> values
    ) => ThisThread.GetFloat(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    float IAL.GetFloat()
    {
        float values = default;
        ((IAL)this).GetFloat(1, (float*)&values);
        return values;
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetFloatv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float GetFloat() => ThisThread.GetFloat();

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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetInteger")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetInteger([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetInteger(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetInteger(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* values
    ) => ThisThread.GetInteger(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetInteger(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAL)this).GetInteger(param0, __dsl_values);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetInteger(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> values
    ) => ThisThread.GetInteger(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    int IAL.GetInteger()
    {
        int values = default;
        ((IAL)this).GetInteger(1, (int*)&values);
        return values;
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetIntegerv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int GetInteger() => ThisThread.GetInteger();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListener3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListener3(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    ) => ThisThread.GetListener3(param0, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListener3(
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
            ((IAL)this).GetListener3(param0, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListener3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListener3(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    ) => ThisThread.GetListener3(param0, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListener3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListener3(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    ) => ThisThread.GetListener3(param0, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetListener3(
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
            ((IAL)this).GetListener3(param0, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetListener3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetListener3(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    ) => ThisThread.GetListener3(param0, value1, value2, value3);

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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetProcAddress")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr GetProcAddress([NativeTypeName("const ALchar *")] Ref<sbyte> fname) =>
        ThisThread.GetProcAddress(fname);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSource3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSource3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] float* value1,
        [NativeTypeName("ALfloat *")] float* value2,
        [NativeTypeName("ALfloat *")] float* value3
    ) => ThisThread.GetSource3(source, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSource3(
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
            ((IAL)this).GetSource3(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSource3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat *")] Ref<float> value1,
        [NativeTypeName("ALfloat *")] Ref<float> value2,
        [NativeTypeName("ALfloat *")] Ref<float> value3
    ) => ThisThread.GetSource3(source, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSource3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSource3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] int* value1,
        [NativeTypeName("ALint *")] int* value2,
        [NativeTypeName("ALint *")] int* value3
    ) => ThisThread.GetSource3(source, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.GetSource3(
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
            ((IAL)this).GetSource3(source, param1, __dsl_value1, __dsl_value2, __dsl_value3);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alGetSource3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetSource3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint *")] Ref<int> value1,
        [NativeTypeName("ALint *")] Ref<int> value2,
        [NativeTypeName("ALint *")] Ref<int> value3
    ) => ThisThread.GetSource3(source, param1, value1, value2, value3);

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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alGetString")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte* GetStringRaw([NativeTypeName("ALenum")] int param0) =>
        ThisThread.GetStringRaw(param0);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAL.IsBuffer([NativeTypeName("ALuint")] uint buffer) =>
        (MaybeBool<sbyte>)(sbyte)((IAL)this).IsBufferRaw(buffer);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsBuffer")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsBufferRaw([NativeTypeName("ALuint")] uint buffer) =>
        ThisThread.IsBufferRaw(buffer);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    sbyte IAL.IsEnabled([NativeTypeName("ALenum")] int capability) =>
        (
            (delegate* unmanaged<int, sbyte>)(
                _slots[47] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[47] = nativeContext.LoadFunction("alIsEnabled", "openal")
            )
        )(capability);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsEnabled([NativeTypeName("ALenum")] int capability) =>
        ThisThread.IsEnabled(capability);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    MaybeBool<sbyte> IAL.IsEnabled(
        [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
    ) => (MaybeBool<sbyte>)(sbyte)((IAL)this).IsEnabled((int)capability);

    [return: NativeTypeName("ALboolean")]
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alIsEnabled")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<sbyte> IsEnabled(
        [NativeTypeName("ALenum")] Constant<int, ALEnum, EnableCap> capability
    ) => ThisThread.IsEnabled(capability);

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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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
    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alIsSource")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static sbyte IsSourceRaw([NativeTypeName("ALuint")] uint source) =>
        ThisThread.IsSourceRaw(source);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listener3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listener3(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    ) => ThisThread.Listener3(param0, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listener3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListener3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listener3(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    ) => ThisThread.Listener3(param0, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listener(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerf")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listener(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALfloat")] float value
    ) => ThisThread.Listener(param0, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listener(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listener(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALfloat *")] float* values
    ) => ThisThread.Listener(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listener(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    )
    {
        fixed (float* __dsl_values = values)
        {
            ((IAL)this).Listener(param0, __dsl_values);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListenerfv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listener(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    ) => ThisThread.Listener(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listener([NativeTypeName("ALenum")] int param0, [NativeTypeName("ALint")] int value) =>
        (
            (delegate* unmanaged<int, int, void>)(
                _slots[54] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[54] = nativeContext.LoadFunction("alListeneri", "openal")
            )
        )(param0, value);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListeneri")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listener(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("ALint")] int value
    ) => ThisThread.Listener(param0, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listener(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listener(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALint *")] int* values
    ) => ThisThread.Listener(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Listener(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAL)this).Listener(param0, __dsl_values);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alListeneriv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Listener(
        [NativeTypeName("ALenum")] int param0,
        [NativeTypeName("const ALint *")] Ref<int> values
    ) => ThisThread.Listener(param0, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Source3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3f")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Source3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value1,
        [NativeTypeName("ALfloat")] float value2,
        [NativeTypeName("ALfloat")] float value3
    ) => ThisThread.Source3(source, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Source3(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSource3i")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Source3(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value1,
        [NativeTypeName("ALint")] int value2,
        [NativeTypeName("ALint")] int value3
    ) => ThisThread.Source3(source, param1, value1, value2, value3);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Source(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcef")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALfloat")] float value
    ) => ThisThread.Source(source, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Source(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] float* values
    ) => ThisThread.Source(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    )
    {
        fixed (float* __dsl_values = values)
        {
            ((IAL)this).Source(source, param1, __dsl_values);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcefv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALfloat *")] Ref<float> values
    ) => ThisThread.Source(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Source(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourcei")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("ALint")] int value
    ) => ThisThread.Source(source, param1, value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Source(
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] int* values
    ) => ThisThread.Source(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    )
    {
        fixed (int* __dsl_values = values)
        {
            ((IAL)this).Source(source, param1, __dsl_values);
        }
    }

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceiv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Source(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALenum")] int param1,
        [NativeTypeName("const ALint *")] Ref<int> values
    ) => ThisThread.Source(source, param1, values);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourcePause([NativeTypeName("ALuint")] uint source) =>
        (
            (delegate* unmanaged<uint, void>)(
                _slots[62] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[62] = nativeContext.LoadFunction("alSourcePause", "openal")
            )
        )(source);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourcePausev(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    ) => ThisThread.SourcePausev(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourcePausev([NativeTypeName("const ALuint *")] uint sources) =>
        ((IAL)this).SourcePausev(1, (uint*)&sources);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePausev")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourcePausev([NativeTypeName("const ALuint *")] uint sources) =>
        ThisThread.SourcePausev(sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourcePlay([NativeTypeName("ALuint")] uint source) =>
        (
            (delegate* unmanaged<uint, void>)(
                _slots[64] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[64] = nativeContext.LoadFunction("alSourcePlay", "openal")
            )
        )(source);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourcePlayv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    ) => ThisThread.SourcePlayv(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourcePlayv([NativeTypeName("const ALuint *")] uint sources) =>
        ((IAL)this).SourcePlayv(1, (uint*)&sources);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourcePlayv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourcePlayv([NativeTypeName("const ALuint *")] uint sources) =>
        ThisThread.SourcePlayv(sources);

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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceQueueBuffers")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceQueueBuffers(
        [NativeTypeName("ALuint")] uint source,
        [NativeTypeName("ALsizei")] int nb,
        [NativeTypeName("const ALuint *")] Ref<uint> buffers
    ) => ThisThread.SourceQueueBuffers(source, nb, buffers);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceRewin([NativeTypeName("ALuint")] uint source) =>
        (
            (delegate* unmanaged<uint, void>)(
                _slots[67] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[67] = nativeContext.LoadFunction("alSourceRewind", "openal")
            )
        )(source);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [NativeFunction("openal", EntryPoint = "alSourceRewind")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceRewin([NativeTypeName("ALuint")] uint source) =>
        ThisThread.SourceRewin(source);

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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceRewindv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    ) => ThisThread.SourceRewindv(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceRewindv([NativeTypeName("const ALuint *")] uint sources) =>
        ((IAL)this).SourceRewindv(1, (uint*)&sources);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceRewindv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceRewindv([NativeTypeName("const ALuint *")] uint sources) =>
        ThisThread.SourceRewindv(sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceStop([NativeTypeName("ALuint")] uint source) =>
        (
            (delegate* unmanaged<uint, void>)(
                _slots[69] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[69] = nativeContext.LoadFunction("alSourceStop", "openal")
            )
        )(source);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceStopv(
        [NativeTypeName("ALsizei")] int n,
        [NativeTypeName("const ALuint *")] Ref<uint> sources
    ) => ThisThread.SourceStopv(n, sources);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    void IAL.SourceStopv([NativeTypeName("const ALuint *")] uint sources) =>
        ((IAL)this).SourceStopv(1, (uint*)&sources);

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alSourceStopv")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SourceStopv([NativeTypeName("const ALuint *")] uint sources) =>
        ThisThread.SourceStopv(sources);

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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_0", "AL_VERSION_1_1"], MinVersion = "1.0")]
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

    [SupportedApiProfile("al", ["AL_VERSION_1_1"], MinVersion = "1.1")]
    [NativeFunction("openal", EntryPoint = "alSpeedOfSound")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void SpeedOfSound([NativeTypeName("ALfloat")] float value) =>
        ThisThread.SpeedOfSound(value);
}
