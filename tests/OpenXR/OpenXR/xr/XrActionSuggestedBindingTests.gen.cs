// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "ActionSuggestedBinding"/> struct.</summary>
public static unsafe partial class XrActionSuggestedBindingTests
{
    /// <summary>Validates that the <see cref = "ActionSuggestedBinding"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ActionSuggestedBinding>(),
            Is.EqualTo(sizeof(ActionSuggestedBinding))
        );
    }

    /// <summary>Validates that the <see cref = "ActionSuggestedBinding"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ActionSuggestedBinding).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ActionSuggestedBinding"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ActionSuggestedBinding), Is.EqualTo(16));
    }
}
