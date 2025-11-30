// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.SDL.UnitTests;

/// <summary>Provides validation of the <see cref = "GpuBlitInfo"/> struct.</summary>
public static unsafe partial class SDL_GPUBlitInfoTests
{
    /// <summary>Validates that the <see cref = "GpuBlitInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GpuBlitInfo>(), Is.EqualTo(sizeof(GpuBlitInfo)));
    }

    /// <summary>Validates that the <see cref = "GpuBlitInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GpuBlitInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GpuBlitInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(GpuBlitInfo), Is.EqualTo(96));
        }
        else
        {
            Assert.That(sizeof(GpuBlitInfo), Is.EqualTo(88));
        }
    }
}
