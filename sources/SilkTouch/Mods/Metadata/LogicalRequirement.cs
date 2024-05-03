// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Mods.Metadata;

/// <summary>
/// The circumstances in which a <see cref="LogicalAnnotation{T}"/> applies. The <c>default</c> is
/// <see cref="Success"/>.
/// </summary>
public enum LogicalRequirement
{
    /// <summary>
    /// The annotation only applies if the function call is successful.
    /// </summary>
    Success = 0,

    /// <summary>
    /// The annotation only applies if the function call failed.
    /// </summary>
    Failure,

    /// <summary>
    /// The annotation always applies.
    /// </summary>
    Always,

    /// <summary>
    /// An expression is used to determine when the annotation applies.
    /// </summary>
    Expression
}
