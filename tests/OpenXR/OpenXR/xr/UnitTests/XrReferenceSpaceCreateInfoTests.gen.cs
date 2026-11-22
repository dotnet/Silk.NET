// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "ReferenceSpaceCreateInfo"/> struct.</summary>
public static unsafe partial class XrReferenceSpaceCreateInfoTests
{
    /// <summary>Validates that the <see cref = "ReferenceSpaceCreateInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ReferenceSpaceCreateInfo>(),
            Is.EqualTo(sizeof(ReferenceSpaceCreateInfo))
        );
    }

    /// <summary>Validates that the <see cref = "ReferenceSpaceCreateInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ReferenceSpaceCreateInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ReferenceSpaceCreateInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ReferenceSpaceCreateInfo), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(ReferenceSpaceCreateInfo), Is.EqualTo(40));
        }
    }
}
