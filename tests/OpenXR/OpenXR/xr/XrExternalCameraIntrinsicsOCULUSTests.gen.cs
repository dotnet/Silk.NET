// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "ExternalCameraIntrinsicsOCULUS"/> struct.</summary>
public static unsafe partial class XrExternalCameraIntrinsicsOCULUSTests
{
    /// <summary>Validates that the <see cref = "ExternalCameraIntrinsicsOCULUS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ExternalCameraIntrinsicsOCULUS>(),
            Is.EqualTo(sizeof(ExternalCameraIntrinsicsOCULUS))
        );
    }

    /// <summary>Validates that the <see cref = "ExternalCameraIntrinsicsOCULUS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ExternalCameraIntrinsicsOCULUS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ExternalCameraIntrinsicsOCULUS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ExternalCameraIntrinsicsOCULUS), Is.EqualTo(40));
    }
}
