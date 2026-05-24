// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Options;

namespace Silk.NET.SilkTouch.UnitTests;

public class DummyOptions<
    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T
> : IOptionsSnapshot<T>
    where T : class
{
    public DummyOptions(T value) => Value = value;

    public T Value { get; }

    public T Get(string? name) => Value;
}
