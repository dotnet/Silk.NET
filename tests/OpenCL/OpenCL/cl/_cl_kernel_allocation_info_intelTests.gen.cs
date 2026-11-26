// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenCL.UnitTests;

/// <summary>Provides validation of the <see cref = "KernelAllocationInfoINTEL"/> struct.</summary>
public static unsafe partial class _cl_kernel_allocation_info_intelTests
{
    /// <summary>Validates that the <see cref = "KernelAllocationInfoINTEL"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<KernelAllocationInfoINTEL>(),
            Is.EqualTo(sizeof(KernelAllocationInfoINTEL))
        );
    }

    /// <summary>Validates that the <see cref = "KernelAllocationInfoINTEL"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KernelAllocationInfoINTEL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "KernelAllocationInfoINTEL"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(KernelAllocationInfoINTEL), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(KernelAllocationInfoINTEL), Is.EqualTo(16));
        }
    }
}
