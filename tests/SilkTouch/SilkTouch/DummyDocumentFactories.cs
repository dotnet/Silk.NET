// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests;

public class DummyDocumentFactories : IDocumentFactories
{
    public DocumentFactory Source { get; } = new();
    public DocumentFactory Test { get; } = new();
}
