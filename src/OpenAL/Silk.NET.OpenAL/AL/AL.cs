// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Provides access to the OpenAL 1.1 API.
    /// </summary>
    [NativeApi(Prefix = "al")]
    public partial class AL : NativeAPI
    {
        private bool _soft;
        private SearchPathContainer? _searchPaths;

        /// <inheritdoc cref="NativeLibraryBase" />
        public AL(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        public override unsafe bool IsExtensionPresent(string name)
        {
            if (name.StartsWith("ALC_"))
            {
                // extreme hack for ALC_EXT_EFX which does not have a standard AL variant
                var maxName = SilkMarshal.GetMaxSizeOf(name, NativeStringEncoding.UTF8);
                var nameNative = name.Length > 256 ? new byte[maxName] : stackalloc byte[maxName];
                SilkMarshal.StringIntoSpan(name, nameNative, NativeStringEncoding.UTF8);
                fixed (byte* namePtr = nameNative)
                {
                    var currentContext = ((delegate* unmanaged[Cdecl]<Context*>) Context.GetProcAddress("alcGetCurrentContext"))();
                    var currentDevice = ((delegate* unmanaged[Cdecl]<Context*, Device*>) Context.GetProcAddress("alcGetContextsDevice"))(currentContext);
                    return ((delegate* unmanaged[Cdecl]<Device*, byte*, char>) Context.GetProcAddress("alcIsExtensionPresent"))
                        (currentDevice, namePtr) == 1;
                }
            }

            return CoreIsExtensionPresent(name);
        }

        [NativeApi(EntryPoint = nameof(IsExtensionPresent))]
        private partial bool CoreIsExtensionPresent(string name);

        /// <inheritdoc />
        public SearchPathContainer SearchPaths => _searchPaths ??= new OpenALLibraryNameContainer(_soft);

        /// <inheritdoc />
        public partial nint GetProcAddress(string name);

        /// <inheritdoc />
        public partial int GetEnumValue(string name);

        /// <inheritdoc />
        public unsafe partial void GenBuffers(int count, uint* buffers);

        /// <inheritdoc />
        public unsafe partial void DeleteBuffers(int count, uint* buffers);

        /// <inheritdoc />
        public partial bool IsBuffer(uint buffer);

        /// <inheritdoc />
        public unsafe partial void BufferData(uint buffer, BufferFormat format, void* data, int size, int frequency);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Bufferf")]
        public partial void SetBufferProperty(uint buffer, BufferFloat param, float value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Buffer3f")]
        public partial void SetBufferProperty(uint buffer, BufferVector3 param, float value1, float value2,
            float value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Bufferfv")]
        public partial void SetBufferProperty(uint buffer, BufferVector3 param, in Vector3 value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Bufferfv")]
        public unsafe partial void SetBufferProperty(uint buffer, BufferVector3 param, float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Bufferi")]
        public partial void SetBufferProperty(uint buffer, BufferInteger param, int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Buffer3i")]
        public partial void SetBufferProperty(uint buffer, BufferInteger param, int value1, int value2, int value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Bufferiv")]
        public unsafe partial void SetBufferProperty(uint buffer, BufferInteger param, int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetBufferf")]
        public partial void GetBufferProperty(uint buffer, BufferFloat param, out float value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetBuffer3f")]
        public partial void GetBufferProperty(uint buffer, BufferVector3 param, out float value1, out float value2,
            out float value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetBufferfv")]
        public partial void GetBufferProperty(uint buffer, BufferVector3 param, out Vector3 value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetBufferfv")]
        public unsafe partial void GetBufferProperty(uint buffer, BufferFloat param, float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetBufferi")]
        public partial void GetBufferProperty(uint buffer, GetBufferInteger param, out int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetBuffer3i")]
        public partial void GetBufferProperty(uint buffer, GetBufferInteger param, out int value1, out int value2,
            out int value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetBufferiv")]
        public unsafe partial void GetBufferProperty(uint buffer, GetBufferInteger param, int* value);

        /// <inheritdoc />
        public partial AudioError GetError();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Listenerf")]
        public partial void SetListenerProperty(ListenerFloat param, float value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Listener3f")]
        public partial void SetListenerProperty(ListenerVector3 param, float value1, float value2, float value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Listenerfv")]
        public partial void SetListenerProperty(ListenerVector3 param, in Vector3 value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Listenerfv")]
        public unsafe partial void SetListenerProperty(ListenerFloatArray param, float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Listeneri")]
        public partial void SetListenerProperty(ListenerInteger param, int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Listener3i")]
        public partial void SetListenerProperty(ListenerInteger param, int value1, int value2, int value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Listeneriv")]
        public unsafe partial void SetListenerProperty(ListenerInteger param, int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetListenerf")]
        public partial void GetListenerProperty(ListenerFloat param, out float value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetListener3f")]
        public partial void GetListenerProperty(ListenerVector3 param, out float value1, out float value2,
            out float value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetListenerfv")]
        public partial void GetListenerProperty(ListenerVector3 param, out Vector3 value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetListenerfv")]
        public unsafe partial void GetListenerProperty(ListenerFloatArray param, float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetListeneri")]
        public partial void GetListenerProperty(ListenerInteger param, out int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetListener3i")]
        public partial void GetListenerProperty(ListenerInteger param, out int value1, out int value2, out int value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetListeneriv")]
        public unsafe partial void GetListenerProperty(ListenerInteger param, int* value);

        /// <inheritdoc />
        public unsafe partial void GenSources(int count, uint* sources);

        /// <inheritdoc />
        public unsafe partial void DeleteSources(int count, uint* sources);

        /// <inheritdoc />
        public partial bool IsSource(uint source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Sourcef")]
        public partial void SetSourceProperty(uint source, SourceFloat param, float value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Source3f")]
        public partial void SetSourceProperty(uint source, SourceVector3 param, float value1, float value2,
            float value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Sourcefv")]
        public partial void SetSourceProperty(uint source, SourceVector3 param, in Vector3 value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Sourcefv")]
        public unsafe partial void SetSourceProperty(uint source, SourceVector3 param, float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Sourcei")]
        public partial void SetSourceProperty(uint source, SourceBoolean param, [UnmanagedType(UnmanagedType.I4)] bool value);
        
        /// <inheritdoc />
        [NativeApi(EntryPoint = "Sourcei")]
        public partial void SetSourceProperty(uint source, SourceInteger param, int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Source3i")]
        public partial void SetSourceProperty(uint source, SourceInteger param, int value1, int value2, int value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Sourceiv")]
        public unsafe partial void SetSourceProperty(uint source, SourceInteger param, int* value);
        
        /// <inheritdoc />
        [NativeApi(EntryPoint = "Sourcei")]
        public partial void SetSourceProperty(uint source, SourceInteger param, uint value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Source3i")]
        public partial void SetSourceProperty(uint source, SourceInteger param, uint value1, uint value2, uint value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "Sourceiv")]
        public unsafe partial void SetSourceProperty(uint source, SourceInteger param, uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetSourcef")]
        public partial void GetSourceProperty(uint source, SourceFloat param, out float value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetSourcei")]
        public partial void GetSourceProperty(uint source, SourceBoolean param,
            [UnmanagedType(UnmanagedType.I4)] out bool value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetSource3f")]
        public partial void GetSourceProperty(uint source, SourceVector3 param, out float value1, out float value2,
            out float value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetSourcefv")]
        public partial void GetSourceProperty(uint source, SourceVector3 param, out Vector3 value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetSourcefv")]
        public unsafe partial void GetSourceProperty(uint source, SourceFloat param, float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetSourcei")]
        public partial void GetSourceProperty(uint source, GetSourceInteger param, out int value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetSource3i")]
        public partial void GetSourceProperty(uint source, GetSourceInteger param, out int value1, out int value2,
            out int value3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetSourceiv")]
        public unsafe partial void GetSourceProperty(uint source, GetSourceInteger param, int* value);

        /// <inheritdoc />
        public partial void SourcePlay(uint source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "SourcePlayv")]
        public unsafe partial void SourcePlay(int count, uint* sources);

        /// <inheritdoc />
        public partial void SourcePause(uint source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "SourcePausev")]
        public unsafe partial void SourcePause(int count, uint* sources);

        /// <inheritdoc />
        public partial void SourceStop(uint source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "SourceStopv")]
        public unsafe partial void SourceStop(int count, uint* sources);

        /// <inheritdoc />
        public partial void SourceRewind(uint source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "SourceRewindv")]
        public unsafe partial void SourceRewind(int count, uint* sources);

        /// <inheritdoc />
        public unsafe partial void SourceQueueBuffers(uint source, int count, uint* buffers);

        /// <inheritdoc />
        public unsafe partial void SourceUnqueueBuffers(uint source, int count, uint* buffers);

        /// <inheritdoc />
        public partial void Enable(Capability capability);

        /// <inheritdoc />
        public partial void Disable(Capability capability);

        /// <inheritdoc />
        public partial bool IsEnabled(Capability capability);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetBoolean")]
        public partial bool GetStateProperty(StateBoolean param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetDouble")]
        public partial double GetStateProperty(StateDouble param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetFloat")]
        public partial float GetStateProperty(StateFloat param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetInteger")]
        public partial int GetStateProperty(StateInteger param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetString")]
        public partial string GetStateProperty(StateString param);

        /// <inheritdoc />
        public partial void DistanceModel(DistanceModel distanceModel);

        /// <inheritdoc />
        public partial void DopplerFactor(float value);

        /// <inheritdoc />
        public partial void SpeedOfSound(float value);

        /// <summary>
        /// Gets an instance of the API.
        /// </summary>
        /// <param name="soft">Prefer OpenAL Soft libraries.</param>
        /// <returns>The instance.</returns>
        public static AL GetApi(bool soft = false)
        {
            SearchPathContainer searchPaths = new OpenALLibraryNameContainer(soft);
            
            var ctx = new MultiNativeContext
                (CreateDefaultContext(searchPaths.GetLibraryNames()), null);
            var ret = new AL(ctx);
            ret._soft = soft;
            ret._searchPaths = searchPaths;

            ctx.Contexts[1] = new LamdaNativeContext
                (x => x.EndsWith("GetProcAddress") ? default : ret.GetProcAddress(x));
            return ret;
        }

        /// <summary>
        /// Attempts to load a native OpenAL extension of type <typeparamref name="T" />.
        /// </summary>
        /// <param name="ext">The loaded extension.</param>
        /// <typeparam name="T">Type of <see cref="NativeExtension{T}" /> to load.</typeparam>
        /// <returns><c>true</c> if the extension was loaded, otherwise <c>false</c>.</returns>
#if NET5_0_OR_GREATER
        public bool TryGetExtension<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(out T ext)
#else
        public bool TryGetExtension<T>(out T ext)
#endif
            where T : NativeExtension<AL>
        {
            ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T) Activator.CreateInstance(typeof(T), Context)
                : null;
            return ext is not null;
        }

        /// <summary>
        /// Gets an instance of the API of an extension to the API.
        /// </summary>
        /// <typeparam name="TExtension">The extension type.</typeparam>
        /// <returns>The extension.</returns>
        [Obsolete
        (
            "This method has been deprecated and will be removed in Silk.NET 3.0. " +
            "Please use TryGetExtension instead."
        )]
#if NET5_0_OR_GREATER
        public TExtension GetExtension<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] TExtension>()
#else
        public TExtension GetExtension<TExtension>()
#endif
            where TExtension : NativeExtension<AL>
        {
            return IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(TExtension)).Name)
                ? (TExtension)Activator.CreateInstance(typeof(TExtension), Context)
                : null;
        }

        /// <summary>
        /// Creates one or more buffers.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <returns>The slots.</returns>
        /// <seealso cref="DeleteBuffers(uint[])" />
        /// <seealso cref="IsBuffer" />
        public uint[] GenBuffers(int count)
        {
            var result = new uint[count];
            unsafe
            {
                fixed (uint* ptr = result)
                {
                    GenBuffers(count, ptr);
                }
            }

            return result;
        }

        /// <summary>
        /// Creates an buffer.
        /// </summary>
        /// <returns>The slot.</returns>
        /// <seealso cref="DeleteBuffer" />
        /// <seealso cref="IsBuffer" />
        public uint GenBuffer()
        {
            uint result = 0;
            unsafe
            {
                GenBuffers(1, &result);
            }

            return result;
        }

        /// <summary>
        /// Deletes and frees resources used for a set of buffers.
        /// </summary>
        /// <param name="slots">An array of slots to delete.</param>
        /// <seealso cref="GenBuffers(int)" />
        /// <seealso cref="IsBuffer" />
        public void DeleteBuffers(uint[] slots)
        {
            unsafe
            {
                fixed (uint* ptr = slots)
                {
                    DeleteBuffers(slots.Length, ptr);
                }
            }
        }

        /// <summary>
        /// Deletes and frees resources used an buffer.
        /// </summary>
        /// <param name="slot">The slot to delete.</param>
        /// <seealso cref="GenBuffer" />
        /// <seealso cref="IsBuffer" />
        public void DeleteBuffer(uint slot)
        {
            unsafe
            {
                DeleteBuffers(1, &slot);
            }
        }

        /// <summary>
        /// Fills a buffer with audio data.
        /// </summary>
        /// <typeparam name="TElement">The type of the data.</typeparam>
        /// <param name="buffer">The buffer to fill.</param>
        /// <param name="format">The format of the data.</param>
        /// <param name="data">The data.</param>
        /// <param name="frequency">The frequency of the data.</param>
        public void BufferData<TElement>(uint buffer, BufferFormat format, TElement[] data, int frequency)
            where TElement : unmanaged
        {
            unsafe
            {
                var size = sizeof(TElement) * data.Length;
                fixed (void* ptr = data)
                {
                    BufferData(buffer, format, ptr, size, frequency);
                }
            }
        }

        /// <summary>
        /// Creates one or more sources.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <returns>The slots.</returns>
        /// <seealso cref="DeleteSources(uint[])" />
        /// <seealso cref="IsSource" />
        public uint[] GenSources(int count)
        {
            var result = new uint[count];
            unsafe
            {
                fixed (uint* ptr = result)
                {
                    GenSources(count, ptr);
                }
            }

            return result;
        }

        /// <summary>
        /// Creates an source.
        /// </summary>
        /// <returns>The slot.</returns>
        /// <seealso cref="DeleteSource" />
        /// <seealso cref="IsSource" />
        public uint GenSource()
        {
            uint result = 0;
            unsafe
            {
                GenSources(1, &result);
            }

            return result;
        }

        /// <summary>
        /// Deletes and frees resources used for a set of sources.
        /// </summary>
        /// <param name="slots">An array of slots to delete.</param>
        /// <seealso cref="GenSources(int)" />
        /// <seealso cref="IsSource" />
        public void DeleteSources(uint[] slots)
        {
            unsafe
            {
                fixed (uint* ptr = slots)
                {
                    DeleteSources(slots.Length, ptr);
                }
            }
        }

        /// <summary>
        /// Deletes and frees resources used an source.
        /// </summary>
        /// <param name="slot">The slot to delete.</param>
        /// <seealso cref="GenSource" />
        /// <seealso cref="IsSource" />
        public void DeleteSource(uint slot)
        {
            unsafe
            {
                DeleteSources(1, &slot);
            }
        }

        /// <summary>
        /// Plays a set of sources.
        /// </summary>
        /// <param name="sources">The sources to play.</param>
        public void SourcePlay(uint[] sources)
        {
            unsafe
            {
                fixed (uint* ptr = sources)
                {
                    SourcePlay(sources.Length, ptr);
                }
            }
        }

        /// <summary>
        /// Pauses a set of sources.
        /// </summary>
        /// <param name="sources">The sources to pause.</param>
        public void SourcePause(uint[] sources)
        {
            unsafe
            {
                fixed (uint* ptr = sources)
                {
                    SourcePause(sources.Length, ptr);
                }
            }
        }

        /// <summary>
        /// Stops a set of sources.
        /// </summary>
        /// <param name="sources">The sources to stop.</param>
        public void SourceStop(uint[] sources)
        {
            unsafe
            {
                fixed (uint* ptr = sources)
                {
                    SourceStop(sources.Length, ptr);
                }
            }
        }

        /// <summary>
        /// Rewinds a set of sources.
        /// </summary>
        /// <param name="sources">The sources to rewind.</param>
        public void SourceRewind(uint[] sources)
        {
            unsafe
            {
                fixed (uint* ptr = sources)
                {
                    SourceRewind(sources.Length, ptr);
                }
            }
        }

        /// <summary>
        /// Queues a set of buffers on the source. All buffers attached to a source will be played in sequence, and the
        /// number of processed buffers can be detected using a call to
        /// <see cref="GetSourceProperty(uint, SourceFloat, out float)" />.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="buffers">The buffers.</param>
        public void SourceQueueBuffers(uint source, uint[] buffers)
        {
            unsafe
            {
                fixed (uint* ptr = buffers)
                {
                    SourceQueueBuffers(source, buffers.Length, ptr);
                }
            }
        }

        /// <summary>
        /// Unqueues a set of buffers on the source. The number of processed buffers can be detected using a call to
        /// <see cref="GetSourceProperty(uint, GetSourceInteger, out int)" />, which is the maximum number of
        /// buffers that can be unqueued during this call.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="buffers">The buffers.</param>
        public void SourceUnqueueBuffers(uint source, uint[] buffers)
        {
            unsafe
            {
                fixed (uint* ptr = buffers)
                {
                    SourceUnqueueBuffers(source, buffers.Length, ptr);
                }
            }
        }
    }
}
