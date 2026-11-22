// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "EventDataLocalizationChangedML"/> struct.</summary>
public static unsafe partial class XrEventDataLocalizationChangedMLTests
{
    /// <summary>Validates that the <see cref = "EventDataLocalizationChangedML"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<EventDataLocalizationChangedML>(),
            Is.EqualTo(sizeof(EventDataLocalizationChangedML))
        );
    }

    /// <summary>Validates that the <see cref = "EventDataLocalizationChangedML"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EventDataLocalizationChangedML).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EventDataLocalizationChangedML"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(EventDataLocalizationChangedML), Is.EqualTo(152));
        }
        else
        {
            Assert.That(sizeof(EventDataLocalizationChangedML), Is.EqualTo(120));
        }
    }
}
