// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "UIAnimationTransitionFactory"/> struct.</summary>
public static unsafe partial class UIAnimationTransitionFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "UIAnimationTransitionFactory"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(UIAnimationTransitionFactory).GUID, Is.EqualTo(CLSID_UIAnimationTransitionFactory));
    }

    /// <summary>Validates that the <see cref = "UIAnimationTransitionFactory"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<UIAnimationTransitionFactory>(), Is.EqualTo(sizeof(UIAnimationTransitionFactory)));
    }

    /// <summary>Validates that the <see cref = "UIAnimationTransitionFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UIAnimationTransitionFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "UIAnimationTransitionFactory"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(UIAnimationTransitionFactory), Is.EqualTo(1));
    }
}