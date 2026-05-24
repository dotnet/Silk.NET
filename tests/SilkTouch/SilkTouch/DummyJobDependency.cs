// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.UnitTests;

public class DummyJobDependency<T> : IJobDependency<T>
{
    public DummyJobDependency(IEnumerable<T> values) => Values = values;

    public IEnumerable<T> Values { get; }

    public IEnumerable<T> Get(string? jobKey) => Values;
}
