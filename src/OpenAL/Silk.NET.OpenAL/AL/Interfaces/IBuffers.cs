//
// IBuffers.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using System.Numerics;

// ReSharper disable ExplicitCallerInfoArgument
namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the buffer-related functions of OpenAL 1.1.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IBuffers
    {
        /// <summary>
        /// Creates one or more buffer objects.
        /// </summary>
        /// <param name="count">The number of objects to generate.</param>
        /// <param name="buffers">A pointer to the first element of the array where the handles will be stored.</param>
        /// <seealso cref="DeleteBuffers"/>
        /// <seealso cref="IsBuffer"/>
        unsafe void GenBuffers(int count, uint* buffers);

        /// <summary>
        /// Deletes one or more buffer objects, freeing their resources.
        /// </summary>
        /// <param name="count">The number of objects to delete.</param>
        /// <param name="buffers">A pointer to the first element of the array where the handles are stored.</param>
        /// <seealso cref="GenBuffers"/>
        /// <seealso cref="IsBuffer"/>
        unsafe void DeleteBuffers(int count, uint* buffers);

        /// <summary>
        /// Determines whether or not a given handle is an buffer handle.
        /// </summary>
        /// <param name="buffer">The handle.</param>
        /// <returns>true if the handle is an buffer handle; otherwise, false.</returns>
        /// <seealso cref="GenBuffers"/>
        /// <seealso cref="DeleteBuffers"/>
        bool IsBuffer(uint buffer);

        /// <summary>
        /// Fills a buffer with audio data.
        /// </summary>
        /// <param name="buffer">The buffer to fill.</param>
        /// <param name="format">The format of the buffer.</param>
        /// <param name="data">The data to fill the buffer with.</param>
        /// <param name="size">The size of the data in bytes.</param>
        /// <param name="frequency">The frequency of the data.</param>
        unsafe void BufferData(uint buffer, BufferFormat format, void* data, int size, int frequency);

        /// <summary>
        /// Sets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Bufferf")]
        void SetBufferProperty(uint buffer, BufferFloat param, float value);

        /// <summary>
        /// Sets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        [NativeSymbol("Buffer3f")]
        void SetBufferProperty(uint buffer, BufferVector3 param, float value1, float value2, float value3);

        /// <summary>
        /// Sets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Bufferfv")]
        void SetBufferProperty(uint buffer, BufferVector3 param, in Vector3 value);

        /// <summary>
        /// Sets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Bufferfv")]
        unsafe void SetBufferProperty(uint buffer, BufferVector3 param, float* value);

        /// <summary>
        /// Sets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Bufferi")]
        void SetBufferProperty(uint buffer, BufferInteger param, int value);

        /// <summary>
        /// Sets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        [NativeSymbol("Buffer3i")]
        void SetBufferProperty(uint buffer, BufferInteger param, int value1, int value2, int value3);

        /// <summary>
        /// Sets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Bufferiv")]
        unsafe void SetBufferProperty(uint buffer, BufferInteger param, int* value);

        /// <summary>
        /// Gets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetBufferf")]
        void GetBufferProperty(uint buffer, BufferFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value of the property.</param>
        /// <param name="value2">The second value of the property.</param>
        /// <param name="value3">The third value of the property.</param>
        [NativeSymbol("GetBuffer3f")]
        void GetBufferProperty(uint buffer, BufferVector3 param, out float value1, out float value2, out float value3);

        /// <summary>
        /// Gets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetBufferfv")]
        void GetBufferProperty(uint buffer, BufferVector3 param, out Vector3 value);

        /// <summary>
        /// Gets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetBufferfv")]
        unsafe void GetBufferProperty(uint buffer, BufferFloat param, float* value);

        /// <summary>
        /// Gets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetBufferi")]
        void GetBufferProperty(uint buffer, GetBufferInteger param, out int value);

        /// <summary>
        /// Sets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value of the property.</param>
        /// <param name="value2">The second value of the property.</param>
        /// <param name="value3">The third value of the property.</param>
        [NativeSymbol("Buffer3i")]
        void GetBufferProperty(uint buffer, GetBufferInteger param, out int value1, out int value2, out int value3);

        /// <summary>
        /// Gets the value of a named property on the given buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetBufferiv")]
        unsafe void GetBufferProperty(uint buffer, GetBufferInteger param, int* value);
    }
}
