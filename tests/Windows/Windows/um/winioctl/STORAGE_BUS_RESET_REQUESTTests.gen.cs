// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STORAGE_BUS_RESET_REQUEST"/> struct.</summary>
public static unsafe partial class STORAGE_BUS_RESET_REQUESTTests
{
    /// <summary>Validates that the <see cref = "STORAGE_BUS_RESET_REQUEST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_BUS_RESET_REQUEST>(), Is.EqualTo(sizeof(STORAGE_BUS_RESET_REQUEST)));
    }

    /// <summary>Validates that the <see cref = "STORAGE_BUS_RESET_REQUEST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_BUS_RESET_REQUEST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_BUS_RESET_REQUEST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_BUS_RESET_REQUEST), Is.EqualTo(1));
    }
}