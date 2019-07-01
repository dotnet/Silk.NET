//
// IXRam.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using AdvancedDLSupport;
using OpenToolkit.OpenAL.Interfaces;

namespace OpenToolkit.OpenAL.Extensions.Creative.XRam
{
    /// <summary>
    /// Defines the public interface of the X-RAM extension.
    /// </summary>
    [NativeSymbols(Prefix = "EAX")]
    internal interface IXRam : IExtensions
    {
        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by the X-RAM
        /// extension.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        int GetInteger(int param);

        /// <summary>
        /// Sets the storage mode of an array of OpenAL buffers.
        /// </summary>
        /// <param name="count">The number of buffers pointed to by <paramref name="buffers"/>.</param>
        /// <param name="buffers">An array of OpenAL buffer handles.</param>
        /// <param name="mode">The storage mode that should be used for all the given buffers.</param>
        /// <returns>
        /// true if all buffers were successfully set to the requested storage mode; otherwise, false.
        /// </returns>
        /// <seealso cref="GetBufferMode"/>
        bool SetBufferMode(int count, in uint[] buffers, int mode);

        /// <summary>
        /// Retrieves the storage mode of a particular OpenAL buffer.
        /// </summary>
        /// <param name="buffer">The handle of an OpenAL buffer.</param>
        /// <param name="reserved">Should be set to null.</param>
        /// <returns>The storage mode.</returns>
        /// <seealso cref="SetBufferMode"/>
        int GetBufferMode(uint buffer, IntPtr reserved);
    }
}
