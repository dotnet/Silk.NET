// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenCL.UnitTests;

/// <summary>Provides validation of the <see cref = "Dx9SurfaceInfoKHR"/> struct.</summary>
public static unsafe partial class _cl_dx9_surface_info_khrTests
{
    /// <summary>Validates that the <see cref = "Dx9SurfaceInfoKHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Dx9SurfaceInfoKHR>(), Is.EqualTo(sizeof(Dx9SurfaceInfoKHR)));
    }

    /// <summary>Validates that the <see cref = "Dx9SurfaceInfoKHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Dx9SurfaceInfoKHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "Dx9SurfaceInfoKHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(Dx9SurfaceInfoKHR), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(Dx9SurfaceInfoKHR), Is.EqualTo(8));
        }
    }
}
