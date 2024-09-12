// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Describes the modes in which a mod can access artifacts.
/// </summary>
[Flags]
public enum ModArtifactAccess
{
    /// <summary>
    /// Borrows the artifacts from the pipeline. This allows the mod to read the artifacts without removing them from
    /// the pipeline. However, because they are borrowed, they cannot be used by the next mod until this mod has
    /// completed execution.
    /// </summary>
    Exclusive = 1 << 0,

    /// <summary>
    /// Takes the artifacts from the pipeline. No further mods will have access to these artifacts unless the mod
    /// explicitly reintroduces them into the pipeline.
    /// </summary>
    Take = 1 << 1,

    /// <summary>
    /// Reads the artifacts from the pipeline without removing them. This option, unlike <see cref="Exclusive"/>, allows
    /// subsequent mods to execute immediately.
    /// </summary>
    Shared = 1 << 2
}
