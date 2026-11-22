// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "ActionCreateInfo"/> struct.</summary>
public static unsafe partial class XrActionCreateInfoTests
{
    /// <summary>Validates that the <see cref = "ActionCreateInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ActionCreateInfo>(), Is.EqualTo(sizeof(ActionCreateInfo)));
    }

    /// <summary>Validates that the <see cref = "ActionCreateInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ActionCreateInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ActionCreateInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ActionCreateInfo), Is.EqualTo(224));
        }
        else
        {
            Assert.That(sizeof(ActionCreateInfo), Is.EqualTo(212));
        }
    }
}
