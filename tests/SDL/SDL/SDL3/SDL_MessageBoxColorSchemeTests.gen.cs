// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.SDL.UnitTests;

/// <summary>Provides validation of the <see cref = "MessageBoxColorScheme"/> struct.</summary>
public static unsafe partial class SDL_MessageBoxColorSchemeTests
{
    /// <summary>Validates that the <see cref = "MessageBoxColorScheme"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MessageBoxColorScheme>(),
            Is.EqualTo(sizeof(MessageBoxColorScheme))
        );
    }

    /// <summary>Validates that the <see cref = "MessageBoxColorScheme"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MessageBoxColorScheme).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MessageBoxColorScheme"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MessageBoxColorScheme), Is.EqualTo(15));
    }
}