// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SD_CHANGE_MACHINE_SID_INPUT"/> struct.</summary>
public static unsafe partial class SD_CHANGE_MACHINE_SID_INPUTTests
{
    /// <summary>Validates that the <see cref = "SD_CHANGE_MACHINE_SID_INPUT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SD_CHANGE_MACHINE_SID_INPUT>(), Is.EqualTo(sizeof(SD_CHANGE_MACHINE_SID_INPUT)));
    }

    /// <summary>Validates that the <see cref = "SD_CHANGE_MACHINE_SID_INPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SD_CHANGE_MACHINE_SID_INPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SD_CHANGE_MACHINE_SID_INPUT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SD_CHANGE_MACHINE_SID_INPUT), Is.EqualTo(8));
    }
}