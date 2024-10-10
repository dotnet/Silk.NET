// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.SDL.UnitTests;

/// <summary>Provides validation of the <see cref = "GamepadTouchpadEvent"/> struct.</summary>
public static unsafe partial class SDL_GamepadTouchpadEventTests
{
    /// <summary>Validates that the <see cref = "GamepadTouchpadEvent"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<GamepadTouchpadEvent>(),
            Is.EqualTo(sizeof(GamepadTouchpadEvent))
        );
    }

    /// <summary>Validates that the <see cref = "GamepadTouchpadEvent"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GamepadTouchpadEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GamepadTouchpadEvent"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(GamepadTouchpadEvent), Is.EqualTo(40));
    }
}
