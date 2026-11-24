// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "MarkerSpaceCreateInfoVARJO"/> struct.</summary>
public static unsafe partial class XrMarkerSpaceCreateInfoVARJOTests
{
    /// <summary>Validates that the <see cref = "MarkerSpaceCreateInfoVARJO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MarkerSpaceCreateInfoVARJO>(),
            Is.EqualTo(sizeof(MarkerSpaceCreateInfoVARJO))
        );
    }

    /// <summary>Validates that the <see cref = "MarkerSpaceCreateInfoVARJO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MarkerSpaceCreateInfoVARJO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MarkerSpaceCreateInfoVARJO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MarkerSpaceCreateInfoVARJO), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(MarkerSpaceCreateInfoVARJO), Is.EqualTo(48));
        }
    }
}
