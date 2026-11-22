// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "ViewState"/> struct.</summary>
public static unsafe partial class XrViewStateTests
{
    /// <summary>Validates that the <see cref = "ViewState"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ViewState>(), Is.EqualTo(sizeof(ViewState)));
    }

    /// <summary>Validates that the <see cref = "ViewState"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ViewState).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ViewState"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ViewState), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(ViewState), Is.EqualTo(16));
        }
    }
}
