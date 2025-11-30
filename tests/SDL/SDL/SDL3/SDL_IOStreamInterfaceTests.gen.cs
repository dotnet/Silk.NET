// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.SDL.UnitTests;

/// <summary>Provides validation of the <see cref = "IoStreamInterface"/> struct.</summary>
public static unsafe partial class SDL_IOStreamInterfaceTests
{
    /// <summary>Validates that the <see cref = "IoStreamInterface"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IoStreamInterface>(), Is.EqualTo(sizeof(IoStreamInterface)));
    }

    /// <summary>Validates that the <see cref = "IoStreamInterface"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IoStreamInterface).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IoStreamInterface"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IoStreamInterface), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(IoStreamInterface), Is.EqualTo(28));
        }
    }
}
