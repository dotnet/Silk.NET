// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SystemTrackingProperties"/> struct.</summary>
public static unsafe partial class XrSystemTrackingPropertiesTests
{
    /// <summary>Validates that the <see cref = "SystemTrackingProperties"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SystemTrackingProperties>(),
            Is.EqualTo(sizeof(SystemTrackingProperties))
        );
    }

    /// <summary>Validates that the <see cref = "SystemTrackingProperties"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SystemTrackingProperties).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SystemTrackingProperties"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SystemTrackingProperties), Is.EqualTo(8));
    }
}
