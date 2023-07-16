// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STORAGE_DEVICE_NUMBERS"/> struct.</summary>
public static unsafe partial class STORAGE_DEVICE_NUMBERSTests
{
    /// <summary>Validates that the <see cref = "STORAGE_DEVICE_NUMBERS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_DEVICE_NUMBERS>(), Is.EqualTo(sizeof(STORAGE_DEVICE_NUMBERS)));
    }

    /// <summary>Validates that the <see cref = "STORAGE_DEVICE_NUMBERS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_DEVICE_NUMBERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_DEVICE_NUMBERS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_DEVICE_NUMBERS), Is.EqualTo(24));
    }
}