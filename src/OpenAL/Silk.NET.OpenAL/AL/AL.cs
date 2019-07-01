//
// AL.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using AdvancedDLSupport;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.OpenAL.Interfaces;
using System.Numerics;

namespace Silk.NET.OpenAL
{
    /// <summary>
    /// Provides access to the OpenAL 1.1 API.
    /// </summary>
    public abstract class AL : NativeAPI, IAL
    {
        /// <summary>
        /// Gets an instance of the API.
        /// </summary>
        /// <returns>The instance.</returns>
        public static AL GetAPI()
        {
            return LibraryLoader.Load<AL>(new OpenALLibraryNameContainer());
        }

        /// <inheritdoc cref="NativeLibraryBase"/>
        protected AL(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <summary>
        /// Gets an instance of the API of an extension to the API.
        /// </summary>
        /// <typeparam name="TExtension">The extension type.</typeparam>
        /// <returns>The extension.</returns>
        public TExtension GetExtension<TExtension>()
            where TExtension : NativeExtension<AL>
        {
            return LibraryLoader.Load<TExtension>(new OpenALLibraryNameContainer());
        }

        /// <inheritdoc />
        public abstract unsafe void GenBuffers(int count, uint* buffers);

        /// <summary>
        /// Creates one or more buffers.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <returns>The slots.</returns>
        /// <seealso cref="DeleteBuffers(uint[])"/>
        /// <seealso cref="IsBuffer"/>
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
        /// <seealso cref="DeleteBuffer"/>
        /// <seealso cref="IsBuffer"/>
        public uint GenBuffer()
        {
            uint result = 0;
            unsafe
            {
                GenBuffers(1, &result);
            }

            return result;
        }

        /// <inheritdoc />
        public abstract unsafe void DeleteBuffers(int count, uint* buffers);

        /// <summary>
        /// Deletes and frees resources used for a set of buffers.
        /// </summary>
        /// <param name="slots">An array of slots to delete.</param>
        /// <seealso cref="GenBuffers(int)"/>
        /// <seealso cref="IsBuffer"/>
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
        /// <seealso cref="GenBuffer"/>
        /// <seealso cref="IsBuffer"/>
        public void DeleteBuffer(uint slot)
        {
            unsafe
            {
                DeleteBuffers(1, &slot);
            }
        }

        /// <inheritdoc />
        public abstract bool IsBuffer(uint buffer);

        /// <inheritdoc />
        public abstract unsafe void BufferData(uint buffer, BufferFormat format, void* data, int size, int frequency);

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

        /// <inheritdoc />
        public abstract void SetBufferProperty(uint buffer, BufferFloat param, float value);

        /// <inheritdoc />
        public abstract void SetBufferProperty(uint buffer, BufferVector3 param, float value1, float value2, float value3);

        /// <inheritdoc />
        public abstract void SetBufferProperty(uint buffer, BufferVector3 param, in Vector3 value);

        /// <inheritdoc />
        public abstract unsafe void SetBufferProperty(uint buffer, BufferVector3 param, float* value);

        /// <inheritdoc />
        public abstract void SetBufferProperty(uint buffer, BufferInteger param, int value);

        /// <inheritdoc />
        public abstract void SetBufferProperty(uint buffer, BufferInteger param, int value1, int value2, int value3);

        /// <inheritdoc />
        public abstract unsafe void SetBufferProperty(uint buffer, BufferInteger param, int* value);

        /// <inheritdoc />
        public abstract void GetBufferProperty(uint buffer, BufferFloat param, out float value);

        /// <inheritdoc />
        public abstract void GetBufferProperty(uint buffer, BufferVector3 param, out float value1, out float value2, out float value3);

        /// <inheritdoc />
        public abstract void GetBufferProperty(uint buffer, BufferVector3 param, out Vector3 value);

        /// <inheritdoc />
        public abstract unsafe void GetBufferProperty(uint buffer, BufferFloat param, float* value);

        /// <inheritdoc />
        public abstract void GetBufferProperty(uint buffer, GetBufferInteger param, out int value);

        /// <inheritdoc />
        public abstract void GetBufferProperty(uint buffer, GetBufferInteger param, out int value1, out int value2, out int value3);

        /// <inheritdoc />
        public abstract unsafe void GetBufferProperty(uint buffer, GetBufferInteger param, int* value);

        /// <inheritdoc />
        public abstract AudioError GetError();

        /// <inheritdoc />
        public SearchPathContainer NameContainer { get; } = new OpenALLibraryNameContainer();

        /// <inheritdoc />
        public abstract IntPtr GetProcAddress(string name);

        /// <inheritdoc />
        public abstract int GetEnumValue(string name);

        /// <inheritdoc />
        public abstract void SetListenerProperty(ListenerFloat param, float value);

        /// <inheritdoc />
        public abstract void SetListenerProperty(ListenerVector3 param, float value1, float value2, float value3);

        /// <inheritdoc />
        public abstract void SetListenerProperty(ListenerVector3 param, in Vector3 value);

        /// <inheritdoc />
        public abstract unsafe void SetListenerProperty(ListenerFloatArray param, float* value);

        /// <inheritdoc />
        public abstract void SetListenerProperty(ListenerInteger param, int value);

        /// <inheritdoc />
        public abstract void SetListenerProperty(ListenerInteger param, int value1, int value2, int value3);

        /// <inheritdoc />
        public abstract unsafe void SetListenerProperty(ListenerInteger param, int* value);

        /// <inheritdoc />
        public abstract void GetListenerProperty(ListenerFloat param, out float value);

        /// <inheritdoc />
        public abstract void GetListenerProperty(ListenerVector3 param, out float value1, out float value2, out float value3);

        /// <inheritdoc />
        public abstract void GetListenerProperty(ListenerVector3 param, out Vector3 value);

        /// <inheritdoc />
        public abstract unsafe void GetListenerProperty(ListenerFloatArray param, float* value);

        /// <inheritdoc />
        public abstract void GetListenerProperty(ListenerInteger param, out int value);

        /// <inheritdoc />
        public abstract void GetListenerProperty(ListenerInteger param, out int value1, out int value2, out int value3);

        /// <inheritdoc />
        public abstract unsafe void GetListenerProperty(ListenerInteger param, int* value);

        /// <inheritdoc />
        public abstract unsafe void GenSources(int count, uint* sources);

        /// <summary>
        /// Creates one or more sources.
        /// </summary>
        /// <param name="count">The number of slots to create.</param>
        /// <returns>The slots.</returns>
        /// <seealso cref="DeleteSources(uint[])"/>
        /// <seealso cref="IsSource"/>
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
        /// <seealso cref="DeleteSource"/>
        /// <seealso cref="IsSource"/>
        public uint GenSource()
        {
            uint result = 0;
            unsafe
            {
                GenSources(1, &result);
            }

            return result;
        }

        /// <inheritdoc />
        public abstract unsafe void DeleteSources(int count, uint* sources);

        /// <summary>
        /// Deletes and frees resources used for a set of sources.
        /// </summary>
        /// <param name="slots">An array of slots to delete.</param>
        /// <seealso cref="GenSources(int)"/>
        /// <seealso cref="IsSource"/>
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
        /// <seealso cref="GenSource"/>
        /// <seealso cref="IsSource"/>
        public void DeleteSource(uint slot)
        {
            unsafe
            {
                DeleteSources(1, &slot);
            }
        }

        /// <inheritdoc />
        public abstract bool IsSource(uint source);

        /// <inheritdoc />
        public abstract void SetSourceProperty(uint source, SourceFloat param, float value);

        /// <inheritdoc />
        public abstract void SetSourceProperty(uint source, SourceVector3 param, float value1, float value2, float value3);

        /// <inheritdoc />
        public abstract void SetSourceProperty(uint source, SourceVector3 param, in Vector3 value);

        /// <inheritdoc />
        public abstract unsafe void SetSourceProperty(uint source, SourceVector3 param, float* value);

        /// <inheritdoc />
        public abstract void SetSourceProperty(uint source, SourceInteger param, int value);

        /// <inheritdoc />
        public abstract void SetSourceProperty(uint source, SourceInteger param, int value1, int value2, int value3);

        /// <inheritdoc />
        public abstract unsafe void SetSourceProperty(uint source, SourceInteger param, int* value);

        /// <inheritdoc />
        public abstract void GetSourceProperty(uint source, SourceFloat param, out float value);

        /// <inheritdoc />
        public abstract void GetSourceProperty(uint source, SourceVector3 param, out float value1, out float value2, out float value3);

        /// <inheritdoc />
        public abstract void GetSourceProperty(uint source, SourceVector3 param, out Vector3 value);

        /// <inheritdoc />
        public abstract unsafe void GetSourceProperty(uint source, SourceFloat param, float* value);

        /// <inheritdoc />
        public abstract void GetSourceProperty(uint source, GetSourceInteger param, out int value);

        /// <inheritdoc />
        public abstract void GetSourceProperty(uint source, GetSourceInteger param, out int value1, out int value2, out int value3);

        /// <inheritdoc />
        public abstract unsafe void GetSourceProperty(uint source, GetSourceInteger param, int* value);

        /// <inheritdoc />
        public abstract void SourcePlay(uint source);

        /// <inheritdoc />
        public abstract unsafe void SourcePlay(int count, uint* sources);

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

        /// <inheritdoc />
        public abstract void SourcePause(uint source);

        /// <inheritdoc />
        public abstract unsafe void SourcePause(int count, uint* sources);

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

        /// <inheritdoc />
        public abstract void SourceStop(uint source);

        /// <inheritdoc />
        public abstract unsafe void SourceStop(int count, uint* sources);

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

        /// <inheritdoc />
        public abstract void SourceRewind(uint source);

        /// <inheritdoc />
        public abstract unsafe void SourceRewind(int count, uint* sources);

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

        /// <inheritdoc />
        public abstract unsafe void SourceQueueBuffers(uint source, int count, uint* buffers);

        /// <summary>
        /// Queues a set of buffers on the source. All buffers attached to a source will be played in sequence, and the
        /// number of processed buffers can be detected using a call to
        /// <see cref="GetSourceProperty(uint, SourceFloat, out float)"/>.
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

        /// <inheritdoc />
        public abstract unsafe void SourceUnqueueBuffers(uint source, int count, uint* buffers);

        /// <summary>
        /// Unqueues a set of buffers on the source. The number of processed buffers can be detected using a call to
        /// <see cref="GetSourceProperty(uint, GetSourceInteger, out int)"/>, which is the maximum number of
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

        /// <inheritdoc />
        public abstract void Enable(Capability capability);

        /// <inheritdoc />
        public abstract void Disable(Capability capability);

        /// <inheritdoc />
        public abstract bool IsEnabled(Capability capability);

        /// <inheritdoc />
        public abstract bool GetStateProperty(StateBoolean param);

        /// <inheritdoc />
        public abstract double GetStateProperty(StateDouble param);

        /// <inheritdoc />
        public abstract float GetStateProperty(StateFloat param);

        /// <inheritdoc />
        public abstract int GetStateProperty(StateInteger param);

        /// <inheritdoc />
        public abstract string GetStateProperty(StateString param);

        /// <inheritdoc />
        public abstract void DistanceModel(DistanceModel distanceModel);

        /// <inheritdoc />
        public abstract void DopplerFactor(float value);

        /// <inheritdoc />
        public abstract void SpeedOfSound(float value);
    }
}
