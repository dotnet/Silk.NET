// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.FidelityFX.UnitTests;

/// <summary>Provides validation of the <see cref = "ConfigureDescUpscaleKeyValue"/> struct.</summary>
public static unsafe partial class ffxConfigureDescUpscaleKeyValueTests
{
    /// <summary>Validates that the <see cref = "ConfigureDescUpscaleKeyValue"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ConfigureDescUpscaleKeyValue>(),
            Is.EqualTo(sizeof(ConfigureDescUpscaleKeyValue))
        );
    }

    /// <summary>Validates that the <see cref = "ConfigureDescUpscaleKeyValue"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ConfigureDescUpscaleKeyValue).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ConfigureDescUpscaleKeyValue"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ConfigureDescUpscaleKeyValue), Is.EqualTo(40));
    }
}
