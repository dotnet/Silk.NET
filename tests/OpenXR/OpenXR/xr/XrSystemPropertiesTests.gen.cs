// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "SystemProperties"/> struct.</summary>
public static unsafe partial class XrSystemPropertiesTests
{
    /// <summary>Validates that the <see cref = "SystemProperties"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SystemProperties>(), Is.EqualTo(sizeof(SystemProperties)));
    }

    /// <summary>Validates that the <see cref = "SystemProperties"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SystemProperties).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SystemProperties"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SystemProperties), Is.EqualTo(304));
        }
        else
        {
            Assert.That(sizeof(SystemProperties), Is.EqualTo(296));
        }
    }
}
