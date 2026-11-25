// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenCL.UnitTests;

/// <summary>Provides validation of the <see cref = "IcdDispatchWindows"/> struct.</summary>
public static unsafe partial class _cl_icd_dispatch_windowsTests
{
    /// <summary>Validates that the <see cref = "IcdDispatchWindows"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IcdDispatchWindows>(), Is.EqualTo(sizeof(IcdDispatchWindows)));
    }

    /// <summary>Validates that the <see cref = "IcdDispatchWindows"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IcdDispatchWindows).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IcdDispatchWindows"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IcdDispatchWindows), Is.EqualTo(1200));
        }
        else
        {
            Assert.That(sizeof(IcdDispatchWindows), Is.EqualTo(600));
        }
    }
}
