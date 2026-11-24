// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenCL.UnitTests;

/// <summary>Provides validation of the <see cref = "BufferRegion"/> struct.</summary>
public static unsafe partial class _cl_buffer_regionTests
{
    /// <summary>Validates that the <see cref = "BufferRegion"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BufferRegion>(), Is.EqualTo(sizeof(BufferRegion)));
    }

    /// <summary>Validates that the <see cref = "BufferRegion"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BufferRegion).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BufferRegion"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BufferRegion), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(BufferRegion), Is.EqualTo(8));
        }
    }
}
