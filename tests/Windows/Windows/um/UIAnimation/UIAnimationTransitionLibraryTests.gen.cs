// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "UIAnimationTransitionLibrary"/> struct.</summary>
public static unsafe partial class UIAnimationTransitionLibraryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "UIAnimationTransitionLibrary"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(UIAnimationTransitionLibrary).GUID, Is.EqualTo(CLSID_UIAnimationTransitionLibrary));
    }

    /// <summary>Validates that the <see cref = "UIAnimationTransitionLibrary"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<UIAnimationTransitionLibrary>(), Is.EqualTo(sizeof(UIAnimationTransitionLibrary)));
    }

    /// <summary>Validates that the <see cref = "UIAnimationTransitionLibrary"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UIAnimationTransitionLibrary).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "UIAnimationTransitionLibrary"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(UIAnimationTransitionLibrary), Is.EqualTo(1));
    }
}