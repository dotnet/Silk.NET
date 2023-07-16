// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "UIAnimationManager2"/> struct.</summary>
public static unsafe partial class UIAnimationManager2Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "UIAnimationManager2"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(UIAnimationManager2).GUID, Is.EqualTo(CLSID_UIAnimationManager2));
    }

    /// <summary>Validates that the <see cref = "UIAnimationManager2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<UIAnimationManager2>(), Is.EqualTo(sizeof(UIAnimationManager2)));
    }

    /// <summary>Validates that the <see cref = "UIAnimationManager2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UIAnimationManager2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "UIAnimationManager2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(UIAnimationManager2), Is.EqualTo(1));
    }
}