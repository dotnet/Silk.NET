// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Sources;

/// <summary>
/// A job input source i.e. a thing that can resolve a raw path to its canonical path.
/// </summary>
public interface IInputSource : IInputResolver
{
    /// <summary>
    /// The scheme used by this source.
    /// </summary>
    public string Scheme { get; }
}
