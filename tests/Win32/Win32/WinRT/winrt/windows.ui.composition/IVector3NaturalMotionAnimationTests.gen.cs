// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IVector3NaturalMotionAnimation"/> struct.</summary>
public static unsafe partial class IVector3NaturalMotionAnimationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IVector3NaturalMotionAnimation"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IVector3NaturalMotionAnimation).GUID,
            Is.EqualTo(IID_IVector3NaturalMotionAnimation)
        );
    }

    /// <summary>Validates that the <see cref = "IVector3NaturalMotionAnimation"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IVector3NaturalMotionAnimation>(),
            Is.EqualTo(sizeof(IVector3NaturalMotionAnimation))
        );
    }

    /// <summary>Validates that the <see cref = "IVector3NaturalMotionAnimation"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IVector3NaturalMotionAnimation).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IVector3NaturalMotionAnimation"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IVector3NaturalMotionAnimation), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IVector3NaturalMotionAnimation), Is.EqualTo(4));
        }
    }
}
