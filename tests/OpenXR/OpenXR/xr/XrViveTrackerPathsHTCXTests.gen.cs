// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "ViveTrackerPathsHTCX"/> struct.</summary>
public static unsafe partial class XrViveTrackerPathsHTCXTests
{
    /// <summary>Validates that the <see cref = "ViveTrackerPathsHTCX"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ViveTrackerPathsHTCX>(),
            Is.EqualTo(sizeof(ViveTrackerPathsHTCX))
        );
    }

    /// <summary>Validates that the <see cref = "ViveTrackerPathsHTCX"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ViveTrackerPathsHTCX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ViveTrackerPathsHTCX"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ViveTrackerPathsHTCX), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(ViveTrackerPathsHTCX), Is.EqualTo(24));
        }
    }
}
