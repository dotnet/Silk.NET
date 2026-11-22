// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "AttenuationCurvePointBD"/> struct.</summary>
public static unsafe partial class XrAttenuationCurvePointBDTests
{
    /// <summary>Validates that the <see cref = "AttenuationCurvePointBD"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<AttenuationCurvePointBD>(),
            Is.EqualTo(sizeof(AttenuationCurvePointBD))
        );
    }

    /// <summary>Validates that the <see cref = "AttenuationCurvePointBD"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AttenuationCurvePointBD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AttenuationCurvePointBD"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AttenuationCurvePointBD), Is.EqualTo(8));
    }
}
