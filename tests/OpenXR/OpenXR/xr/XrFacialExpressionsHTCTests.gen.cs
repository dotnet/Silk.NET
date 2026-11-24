// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "FacialExpressionsHTC"/> struct.</summary>
public static unsafe partial class XrFacialExpressionsHTCTests
{
    /// <summary>Validates that the <see cref = "FacialExpressionsHTC"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<FacialExpressionsHTC>(),
            Is.EqualTo(sizeof(FacialExpressionsHTC))
        );
    }

    /// <summary>Validates that the <see cref = "FacialExpressionsHTC"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FacialExpressionsHTC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FacialExpressionsHTC"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(FacialExpressionsHTC), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(FacialExpressionsHTC), Is.EqualTo(32));
        }
    }
}
