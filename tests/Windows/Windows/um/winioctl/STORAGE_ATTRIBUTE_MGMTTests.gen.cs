// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STORAGE_ATTRIBUTE_MGMT"/> struct.</summary>
public static unsafe partial class STORAGE_ATTRIBUTE_MGMTTests
{
    /// <summary>Validates that the <see cref = "STORAGE_ATTRIBUTE_MGMT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_ATTRIBUTE_MGMT>(), Is.EqualTo(sizeof(STORAGE_ATTRIBUTE_MGMT)));
    }

    /// <summary>Validates that the <see cref = "STORAGE_ATTRIBUTE_MGMT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_ATTRIBUTE_MGMT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_ATTRIBUTE_MGMT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_ATTRIBUTE_MGMT), Is.EqualTo(16));
    }
}