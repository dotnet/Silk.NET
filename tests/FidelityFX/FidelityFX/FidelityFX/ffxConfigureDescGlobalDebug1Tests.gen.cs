// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.FidelityFX.UnitTests;

/// <summary>Provides validation of the <see cref = "ConfigureDescGlobalDebug1"/> struct.</summary>
public static unsafe partial class ffxConfigureDescGlobalDebug1Tests
{
    /// <summary>Validates that the <see cref = "ConfigureDescGlobalDebug1"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ConfigureDescGlobalDebug1>(),
            Is.EqualTo(sizeof(ConfigureDescGlobalDebug1))
        );
    }

    /// <summary>Validates that the <see cref = "ConfigureDescGlobalDebug1"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ConfigureDescGlobalDebug1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ConfigureDescGlobalDebug1"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ConfigureDescGlobalDebug1), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(ConfigureDescGlobalDebug1), Is.EqualTo(24));
        }
    }
}
