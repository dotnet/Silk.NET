// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Windowing.Hosting;

namespace Silk.NET.Windowing;

/// <summary>
/// An interface implemented on structures that contain configuration data that can be applied to a
/// <see cref="ISurfaceHost"/> surface or surface request.
/// </summary>
public interface IConfigureHost
{
    /// <summary>
    /// Copies the configuration contained in this structure to the surface/request with the given handle on
    /// <typeparamref name="THost"/>.
    /// </summary>
    /// <param name="handle">The handle.</param>
    /// <typeparam name="THandle">The handle type.</typeparam>
    /// <typeparam name="THost">The surface host.</typeparam>
    void ConfigureHost<THandle, THost>(THandle handle)
        where THandle : ISurfaceOrRequestHandle
        where THost : ISurfaceHost;

    /// <summary>
    /// Chains the two configurations together.
    /// </summary>
    /// <param name="First">The first configuration.</param>
    /// <param name="Second">The second configuration.</param>
    /// <typeparam name="TFirst">The type of the first configuration.</typeparam>
    /// <typeparam name="TSecond">The type of the second configuration.</typeparam>
    public readonly record struct Chain<TFirst, TSecond>(TFirst First, TSecond Second)
        : IConfigureHost
        where TFirst : IConfigureHost
        where TSecond : IConfigureHost
    {
        /// <inheritdoc />
        public void ConfigureHost<THandle, THost>(THandle handle)
            where THandle : ISurfaceOrRequestHandle
            where THost : ISurfaceHost
        {
            First.ConfigureHost<THandle, THost>(handle);
            Second.ConfigureHost<THandle, THost>(handle);
        }
    }

    /// <summary>
    /// An implementation of <see cref="IConfigureHost"/> that does nothing.
    /// </summary>
    public readonly record struct Null : IConfigureHost
    {
        /// <inheritdoc />
        public void ConfigureHost<THandle, THost>(THandle handle)
            where THandle : ISurfaceOrRequestHandle
            where THost : ISurfaceHost { }
    }
}
