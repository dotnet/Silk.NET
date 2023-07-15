// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "RID_DEVICE_INFO_HID"/> struct.</summary>
public static unsafe partial class RID_DEVICE_INFO_HIDTests
{
    /// <summary>Validates that the <see cref = "RID_DEVICE_INFO_HID"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RID_DEVICE_INFO_HID>(), Is.EqualTo(sizeof(RID_DEVICE_INFO_HID)));
    }

    /// <summary>Validates that the <see cref = "RID_DEVICE_INFO_HID"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RID_DEVICE_INFO_HID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RID_DEVICE_INFO_HID"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RID_DEVICE_INFO_HID), Is.EqualTo(16));
    }
}