// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.SDL.UnitTests;

/// <summary>Provides validation of the <see cref = "Vertex"/> struct.</summary>
public static unsafe partial class SDL_VertexTests
{
    /// <summary>Validates that the <see cref = "Vertex"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Vertex>(), Is.EqualTo(sizeof(Vertex)));
    }

    /// <summary>Validates that the <see cref = "Vertex"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Vertex).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "Vertex"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Vertex), Is.EqualTo(32));
    }
}
