// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "EventDataInteractionRenderModelsChangedEXT"/> struct.</summary>
public static unsafe partial class XrEventDataInteractionRenderModelsChangedEXTTests
{
    /// <summary>Validates that the <see cref = "EventDataInteractionRenderModelsChangedEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<EventDataInteractionRenderModelsChangedEXT>(),
            Is.EqualTo(sizeof(EventDataInteractionRenderModelsChangedEXT))
        );
    }

    /// <summary>Validates that the <see cref = "EventDataInteractionRenderModelsChangedEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EventDataInteractionRenderModelsChangedEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EventDataInteractionRenderModelsChangedEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(EventDataInteractionRenderModelsChangedEXT), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(EventDataInteractionRenderModelsChangedEXT), Is.EqualTo(8));
        }
    }
}
