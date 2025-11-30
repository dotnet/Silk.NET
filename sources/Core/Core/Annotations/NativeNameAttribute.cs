// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// Stores the native name of the identifier that this attribute is placed on.
/// </summary>
[AttributeUsage(
    AttributeTargets.Struct
    | AttributeTargets.Enum
    | AttributeTargets.Property
    | AttributeTargets.Field
    | AttributeTargets.Method
    | AttributeTargets.Parameter
    | AttributeTargets.ReturnValue
    | AttributeTargets.Delegate,
    AllowMultiple = false,
    Inherited = true
)]
public sealed class NativeNameAttribute : Attribute
{
    /// <param name="name">The native name of the identifier.</param>
    public NativeNameAttribute(string name) => Name = name;

    /// <summary>The native name of the identifier.</summary>
    public string Name { get; }
}
