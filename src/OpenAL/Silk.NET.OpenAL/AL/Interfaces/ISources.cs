// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Numerics;
using AdvancedDLSupport;

// ReSharper disable ExplicitCallerInfoArgument
namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the source-related functions of OpenAL 1.1.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface ISources
    {
        /// <summary>
        /// Creates one or more source objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="sources">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteSources" />
        /// <seealso cref="IsSource" />
        unsafe void GenSources(int count, uint* sources);

        /// <summary>
        /// Deletes one or more source objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="sources">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenSources" />
        /// <seealso cref="IsSource" />
        unsafe void DeleteSources(int count, uint* sources);

        /// <summary>
        /// Determines whether or not a given handle is an source handle.
        /// </summary>
        /// <param name="source">The handle.</param>
        /// <returns>true if the handle is an source handle; otherwise, false.</returns>
        /// <seealso cref="GenSources" />
        /// <seealso cref="DeleteSources" />
        bool IsSource(uint source);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourcef")]
        void SetSourceProperty(uint source, SourceFloat param, float value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        [NativeSymbol("Source3f")]
        void SetSourceProperty(uint source, SourceVector3 param, float value1, float value2, float value3);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourcefv")]
        void SetSourceProperty(uint source, SourceVector3 param, in Vector3 value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourcefv")]
        unsafe void SetSourceProperty(uint source, SourceVector3 param, float* value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourcei")]
        void SetSourceProperty(uint source, SourceInteger param, int value);
        
        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourcei")]
        void SetSourceProperty(uint source, SourceBoolean param, int value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        [NativeSymbol("Source3i")]
        void SetSourceProperty(uint source, SourceInteger param, int value1, int value2, int value3);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourceiv")]
        unsafe void SetSourceProperty(uint source, SourceInteger param, int* value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetSourcef")]
        void GetSourceProperty(uint source, SourceFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value of the property.</param>
        /// <param name="value2">The second value of the property.</param>
        /// <param name="value3">The third value of the property.</param>
        [NativeSymbol("GetSource3f")]
        void GetSourceProperty(uint source, SourceVector3 param, out float value1, out float value2, out float value3);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetSourcefv")]
        void GetSourceProperty(uint source, SourceVector3 param, out Vector3 value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetSourcefv")]
        unsafe void GetSourceProperty(uint source, SourceFloat param, float* value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetSourcei")]
        void GetSourceProperty(uint source, GetSourceInteger param, out int value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value of the property.</param>
        /// <param name="value2">The second value of the property.</param>
        /// <param name="value3">The third value of the property.</param>
        [NativeSymbol("Source3i")]
        void GetSourceProperty(uint source, GetSourceInteger param, out int value1, out int value2, out int value3);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetSourceiv")]
        unsafe void GetSourceProperty(uint source, GetSourceInteger param, int* value);

        /// <summary>
        /// Plays a source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <seealso cref="SourcePause(uint)" />
        /// <seealso cref="SourceStop(uint)" />
        /// <seealso cref="SourceRewind(uint)" />
        void SourcePlay(uint source);

        /// <summary>
        /// Plays a set of sources.
        /// </summary>
        /// <param name="count">The number of sources to play.</param>
        /// <param name="sources">A pointer to the first element in an array of handles.</param>
        /// <seealso cref="SourcePause(uint)" />
        /// <seealso cref="SourceStop(uint)" />
        /// <seealso cref="SourceRewind(uint)" />
        [NativeSymbol("SourcePlayv")]
        unsafe void SourcePlay(int count, uint* sources);

        /// <summary>
        /// Pauses a source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <seealso cref="SourcePlay(uint)" />
        /// <seealso cref="SourceStop(uint)" />
        /// <seealso cref="SourceRewind(uint)" />
        void SourcePause(uint source);

        /// <summary>
        /// Pauses a set of sources.
        /// </summary>
        /// <param name="count">The number of sources to pause.</param>
        /// <param name="sources">A pointer to the first element in an array of handles.</param>
        /// <seealso cref="SourcePlay(uint)" />
        /// <seealso cref="SourceStop(uint)" />
        /// <seealso cref="SourceRewind(uint)" />
        [NativeSymbol("SourcePausev")]
        unsafe void SourcePause(int count, uint* sources);

        /// <summary>
        /// Stops a source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <seealso cref="SourcePlay(uint)" />
        /// <seealso cref="SourcePause(uint)" />
        /// <seealso cref="SourceRewind(uint)" />
        void SourceStop(uint source);

        /// <summary>
        /// Stops a set of sources.
        /// </summary>
        /// <param name="count">The number of sources to stop.</param>
        /// <param name="sources">A pointer to the first element in an array of handles.</param>
        /// <seealso cref="SourcePlay(uint)" />
        /// <seealso cref="SourcePause(uint)" />
        /// <seealso cref="SourceRewind(uint)" />
        [NativeSymbol("SourceStopv")]
        unsafe void SourceStop(int count, uint* sources);

        /// <summary>
        /// Rewinds a source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <seealso cref="SourcePlay(uint)" />
        /// <seealso cref="SourcePause(uint)" />
        /// <seealso cref="SourceStop(uint)" />
        void SourceRewind(uint source);

        /// <summary>
        /// Rewinds a set of sources.
        /// </summary>
        /// <param name="count">The number of sources to rewind.</param>
        /// <param name="sources">A pointer to the first element in an array of handles.</param>
        /// <seealso cref="SourcePlay(uint)" />
        /// <seealso cref="SourcePause(uint)" />
        /// <seealso cref="SourceStop(uint)" />
        [NativeSymbol("SourceRewindv")]
        unsafe void SourceRewind(int count, uint* sources);

        /// <summary>
        /// Queues a set of buffers on the source. All buffers attached to a source will be played in sequence, and the
        /// number of processed buffers can be detected using a call to
        /// <see cref="GetSourceProperty(uint, SourceFloat ,out float)" />.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="count">The number of buffers to queue.</param>
        /// <param name="buffers">A pointer to the first element in an array of handles.</param>
        unsafe void SourceQueueBuffers(uint source, int count, uint* buffers);

        /// <summary>
        /// Unqueues a set of buffers on the source. The number of processed buffers can be detected using a call to
        /// <see cref="GetSourceProperty(uint, GetSourceInteger,out int)" />, which is the maximum number of
        /// buffers that can be unqueued during this call.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="count">The number of buffers to queue.</param>
        /// <param name="buffers">A pointer to the first element in an array of handles.</param>
        unsafe void SourceUnqueueBuffers(uint source, int count, uint* buffers);
    }
}