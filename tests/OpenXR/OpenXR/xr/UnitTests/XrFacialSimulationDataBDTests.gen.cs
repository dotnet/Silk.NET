// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "FacialSimulationDataBD"/> struct.</summary>
public static unsafe partial class XrFacialSimulationDataBDTests
{
    /// <summary>Validates that the <see cref = "FacialSimulationDataBD"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<FacialSimulationDataBD>(),
            Is.EqualTo(sizeof(FacialSimulationDataBD))
        );
    }

    /// <summary>Validates that the <see cref = "FacialSimulationDataBD"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FacialSimulationDataBD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FacialSimulationDataBD"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(FacialSimulationDataBD), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(FacialSimulationDataBD), Is.EqualTo(32));
        }
    }
}
