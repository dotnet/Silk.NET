// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "UIAnimationTransitionFactory2"/> struct.</summary>
public static unsafe partial class UIAnimationTransitionFactory2Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "UIAnimationTransitionFactory2"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(UIAnimationTransitionFactory2).GUID, Is.EqualTo(CLSID_UIAnimationTransitionFactory2));
    }

    /// <summary>Validates that the <see cref = "UIAnimationTransitionFactory2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<UIAnimationTransitionFactory2>(), Is.EqualTo(sizeof(UIAnimationTransitionFactory2)));
    }

    /// <summary>Validates that the <see cref = "UIAnimationTransitionFactory2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UIAnimationTransitionFactory2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "UIAnimationTransitionFactory2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(UIAnimationTransitionFactory2), Is.EqualTo(1));
    }
}