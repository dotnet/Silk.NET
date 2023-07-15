// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STORAGE_LB_PROVISIONING_MAP_RESOURCES"/> struct.</summary>
public static unsafe partial class STORAGE_LB_PROVISIONING_MAP_RESOURCESTests
{
    /// <summary>Validates that the <see cref = "STORAGE_LB_PROVISIONING_MAP_RESOURCES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_LB_PROVISIONING_MAP_RESOURCES>(), Is.EqualTo(sizeof(STORAGE_LB_PROVISIONING_MAP_RESOURCES)));
    }

    /// <summary>Validates that the <see cref = "STORAGE_LB_PROVISIONING_MAP_RESOURCES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_LB_PROVISIONING_MAP_RESOURCES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_LB_PROVISIONING_MAP_RESOURCES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_LB_PROVISIONING_MAP_RESOURCES), Is.EqualTo(32));
    }
}