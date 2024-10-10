// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.SDL.UnitTests;

/// <summary>Provides validation of the <see cref = "UserEvent"/> struct.</summary>
public static unsafe partial class SDL_UserEventTests
{
    /// <summary>Validates that the <see cref = "UserEvent"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<UserEvent>(), Is.EqualTo(sizeof(UserEvent)));
    }

    /// <summary>Validates that the <see cref = "UserEvent"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UserEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "UserEvent"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(UserEvent), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(UserEvent), Is.EqualTo(32));
        }
    }
}
