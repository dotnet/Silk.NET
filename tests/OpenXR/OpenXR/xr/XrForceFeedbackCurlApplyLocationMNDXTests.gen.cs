// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "ForceFeedbackCurlApplyLocationMNDX"/> struct.</summary>
public static unsafe partial class XrForceFeedbackCurlApplyLocationMNDXTests
{
    /// <summary>Validates that the <see cref = "ForceFeedbackCurlApplyLocationMNDX"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ForceFeedbackCurlApplyLocationMNDX>(),
            Is.EqualTo(sizeof(ForceFeedbackCurlApplyLocationMNDX))
        );
    }

    /// <summary>Validates that the <see cref = "ForceFeedbackCurlApplyLocationMNDX"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ForceFeedbackCurlApplyLocationMNDX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ForceFeedbackCurlApplyLocationMNDX"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ForceFeedbackCurlApplyLocationMNDX), Is.EqualTo(8));
    }
}
