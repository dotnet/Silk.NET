// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// The document factories for the source and test projects.
/// </summary>
public interface IDocumentFactories
{
    /// <summary>
    /// The document factory used for the source project.
    /// </summary>
    public DocumentFactory Source { get; }

    /// <summary>
    /// The document factory used for the test project.
    /// </summary>
    public DocumentFactory Test { get; }
}
