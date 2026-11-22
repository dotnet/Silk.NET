// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "EventDataSpaceShareCompleteFB"/> struct.</summary>
public static unsafe partial class XrEventDataSpaceShareCompleteFBTests
{
    /// <summary>Validates that the <see cref = "EventDataSpaceShareCompleteFB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<EventDataSpaceShareCompleteFB>(),
            Is.EqualTo(sizeof(EventDataSpaceShareCompleteFB))
        );
    }

    /// <summary>Validates that the <see cref = "EventDataSpaceShareCompleteFB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EventDataSpaceShareCompleteFB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EventDataSpaceShareCompleteFB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(EventDataSpaceShareCompleteFB), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(EventDataSpaceShareCompleteFB), Is.EqualTo(24));
        }
    }
}
