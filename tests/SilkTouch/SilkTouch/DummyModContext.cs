// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests;

public class DummyModContext : IModContext
{
    public ValueTask DisposeAsync() => ValueTask.CompletedTask;

    public string JobKey { get; set; } = "Test";
    public string WorkingDirectory { get; set; } = "";
    public Project? SourceProject { get; set; }
    public Project? TestProject { get; set; }
    public bool ContinueGeneration { get; set; } = true;

    public Task OutputBindingsAsync() => Task.CompletedTask;
}
