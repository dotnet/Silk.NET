// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "ViewConfigurationView"/> struct.</summary>
public static unsafe partial class XrViewConfigurationViewTests
{
    /// <summary>Validates that the <see cref = "ViewConfigurationView"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ViewConfigurationView>(),
            Is.EqualTo(sizeof(ViewConfigurationView))
        );
    }

    /// <summary>Validates that the <see cref = "ViewConfigurationView"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ViewConfigurationView).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ViewConfigurationView"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ViewConfigurationView), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(ViewConfigurationView), Is.EqualTo(32));
        }
    }
}
