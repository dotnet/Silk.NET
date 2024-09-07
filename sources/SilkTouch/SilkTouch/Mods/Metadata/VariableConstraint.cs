// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Mods.Metadata;

/// <summary>
/// Used for constraints with variable applicability.
/// </summary>
public enum VariableConstraint
{
    /// <summary>
    /// The constraint does not apply.
    /// </summary>
    False,

    /// <summary>
    /// The constraint applies.
    /// </summary>
    True,

    /// <summary>
    /// The constraint may apply.
    /// </summary>
    Maybe
}
