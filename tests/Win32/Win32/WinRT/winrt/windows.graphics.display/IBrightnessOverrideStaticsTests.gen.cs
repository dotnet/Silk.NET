// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IBrightnessOverrideStatics"/> struct.</summary>
public static unsafe partial class IBrightnessOverrideStaticsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IBrightnessOverrideStatics"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IBrightnessOverrideStatics).GUID,
            Is.EqualTo(IID_IBrightnessOverrideStatics)
        );
    }

    /// <summary>Validates that the <see cref = "IBrightnessOverrideStatics"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IBrightnessOverrideStatics>(),
            Is.EqualTo(sizeof(IBrightnessOverrideStatics))
        );
    }

    /// <summary>Validates that the <see cref = "IBrightnessOverrideStatics"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IBrightnessOverrideStatics).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IBrightnessOverrideStatics"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IBrightnessOverrideStatics), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IBrightnessOverrideStatics), Is.EqualTo(4));
        }
    }
}
