// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "EventDataSpaceSetStatusCompleteFB"/> struct.</summary>
public static unsafe partial class XrEventDataSpaceSetStatusCompleteFBTests
{
    /// <summary>Validates that the <see cref = "EventDataSpaceSetStatusCompleteFB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<EventDataSpaceSetStatusCompleteFB>(),
            Is.EqualTo(sizeof(EventDataSpaceSetStatusCompleteFB))
        );
    }

    /// <summary>Validates that the <see cref = "EventDataSpaceSetStatusCompleteFB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EventDataSpaceSetStatusCompleteFB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EventDataSpaceSetStatusCompleteFB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(EventDataSpaceSetStatusCompleteFB), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(EventDataSpaceSetStatusCompleteFB), Is.EqualTo(48));
        }
    }
}
