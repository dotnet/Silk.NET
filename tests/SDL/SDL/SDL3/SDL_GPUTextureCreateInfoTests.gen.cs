// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.SDL.UnitTests;

/// <summary>Provides validation of the <see cref = "GPUTextureCreateInfo"/> struct.</summary>
public static unsafe partial class SDL_GPUTextureCreateInfoTests
{
    /// <summary>Validates that the <see cref = "GPUTextureCreateInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<GPUTextureCreateInfo>(),
            Is.EqualTo(sizeof(GPUTextureCreateInfo))
        );
    }

    /// <summary>Validates that the <see cref = "GPUTextureCreateInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GPUTextureCreateInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GPUTextureCreateInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(GPUTextureCreateInfo), Is.EqualTo(36));
    }
}
