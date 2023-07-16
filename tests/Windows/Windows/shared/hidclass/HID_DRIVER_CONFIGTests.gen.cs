// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidclass.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HID_DRIVER_CONFIG"/> struct.</summary>
public static unsafe partial class HID_DRIVER_CONFIGTests
{
    /// <summary>Validates that the <see cref = "HID_DRIVER_CONFIG"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HID_DRIVER_CONFIG>(), Is.EqualTo(sizeof(HID_DRIVER_CONFIG)));
    }

    /// <summary>Validates that the <see cref = "HID_DRIVER_CONFIG"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HID_DRIVER_CONFIG).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HID_DRIVER_CONFIG"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HID_DRIVER_CONFIG), Is.EqualTo(8));
    }
}