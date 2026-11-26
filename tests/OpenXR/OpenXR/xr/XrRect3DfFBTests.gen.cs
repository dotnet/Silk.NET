// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "Rect3DfFB"/> struct.</summary>
public static unsafe partial class XrRect3DfFBTests
{
    /// <summary>Validates that the <see cref = "Rect3DfFB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Rect3DfFB>(), Is.EqualTo(sizeof(Rect3DfFB)));
    }

    /// <summary>Validates that the <see cref = "Rect3DfFB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Rect3DfFB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "Rect3DfFB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Rect3DfFB), Is.EqualTo(24));
    }
}
