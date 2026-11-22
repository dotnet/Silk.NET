// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "EventDataSpaceQueryCompleteFB"/> struct.</summary>
public static unsafe partial class XrEventDataSpaceQueryCompleteFBTests
{
    /// <summary>Validates that the <see cref = "EventDataSpaceQueryCompleteFB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<EventDataSpaceQueryCompleteFB>(),
            Is.EqualTo(sizeof(EventDataSpaceQueryCompleteFB))
        );
    }

    /// <summary>Validates that the <see cref = "EventDataSpaceQueryCompleteFB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EventDataSpaceQueryCompleteFB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EventDataSpaceQueryCompleteFB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(EventDataSpaceQueryCompleteFB), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(EventDataSpaceQueryCompleteFB), Is.EqualTo(24));
        }
    }
}
