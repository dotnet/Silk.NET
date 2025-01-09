// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.FidelityFX.UnitTests;

/// <summary>Provides validation of the <see cref = "ConfigureDescFrameGenerationRegisterDistortionFieldResource"/> struct.</summary>
public static unsafe partial class ffxConfigureDescFrameGenerationRegisterDistortionFieldResourceTests
{
    /// <summary>Validates that the <see cref = "ConfigureDescFrameGenerationRegisterDistortionFieldResource"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ConfigureDescFrameGenerationRegisterDistortionFieldResource>(),
            Is.EqualTo(sizeof(ConfigureDescFrameGenerationRegisterDistortionFieldResource))
        );
    }

    /// <summary>Validates that the <see cref = "ConfigureDescFrameGenerationRegisterDistortionFieldResource"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(ConfigureDescFrameGenerationRegisterDistortionFieldResource).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "ConfigureDescFrameGenerationRegisterDistortionFieldResource"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(
                sizeof(ConfigureDescFrameGenerationRegisterDistortionFieldResource),
                Is.EqualTo(64)
            );
        }
        else
        {
            Assert.That(
                sizeof(ConfigureDescFrameGenerationRegisterDistortionFieldResource),
                Is.EqualTo(56)
            );
        }
    }
}
