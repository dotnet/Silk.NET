// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.SDL.UnitTests;

/// <summary>Provides validation of the <see cref = "StorageInterface"/> struct.</summary>
public static unsafe partial class SDL_StorageInterfaceTests
{
    /// <summary>Validates that the <see cref = "StorageInterface"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<StorageInterface>(), Is.EqualTo(sizeof(StorageInterface)));
    }

    /// <summary>Validates that the <see cref = "StorageInterface"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(StorageInterface).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "StorageInterface"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(StorageInterface), Is.EqualTo(96));
        }
        else
        {
            Assert.That(sizeof(StorageInterface), Is.EqualTo(48));
        }
    }
}
