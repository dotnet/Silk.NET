// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Configuration;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that customises the binding of its configuration.
/// </summary>
public interface IModConfigBinder : IMod
{
    /// <summary>
    /// Used to configure the Used to configure the <see cref="BinderOptions"/>.
    /// </summary>
    /// <param name="options">The options to configure.</param>
    static abstract void Configure(BinderOptions options);
}
