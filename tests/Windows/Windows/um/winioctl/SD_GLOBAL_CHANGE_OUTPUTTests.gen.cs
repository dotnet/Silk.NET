// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SD_GLOBAL_CHANGE_OUTPUT"/> struct.</summary>
public static unsafe partial class SD_GLOBAL_CHANGE_OUTPUTTests
{
    /// <summary>Validates that the <see cref = "SD_GLOBAL_CHANGE_OUTPUT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SD_GLOBAL_CHANGE_OUTPUT>(), Is.EqualTo(sizeof(SD_GLOBAL_CHANGE_OUTPUT)));
    }

    /// <summary>Validates that the <see cref = "SD_GLOBAL_CHANGE_OUTPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SD_GLOBAL_CHANGE_OUTPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SD_GLOBAL_CHANGE_OUTPUT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SD_GLOBAL_CHANGE_OUTPUT), Is.EqualTo(72));
    }
}