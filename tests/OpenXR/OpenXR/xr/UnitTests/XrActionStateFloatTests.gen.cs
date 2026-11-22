// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "ActionStateFloat"/> struct.</summary>
public static unsafe partial class XrActionStateFloatTests
{
    /// <summary>Validates that the <see cref = "ActionStateFloat"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ActionStateFloat>(), Is.EqualTo(sizeof(ActionStateFloat)));
    }

    /// <summary>Validates that the <see cref = "ActionStateFloat"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ActionStateFloat).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ActionStateFloat"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ActionStateFloat), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(ActionStateFloat), Is.EqualTo(32));
        }
    }
}
