// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "HandGestureQCOM"/> struct.</summary>
public static unsafe partial class XrHandGestureQCOMTests
{
    /// <summary>Validates that the <see cref = "HandGestureQCOM"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HandGestureQCOM>(), Is.EqualTo(sizeof(HandGestureQCOM)));
    }

    /// <summary>Validates that the <see cref = "HandGestureQCOM"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HandGestureQCOM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HandGestureQCOM"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HandGestureQCOM), Is.EqualTo(12));
    }
}
