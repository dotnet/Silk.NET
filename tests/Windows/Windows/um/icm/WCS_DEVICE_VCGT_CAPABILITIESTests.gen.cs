// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WCS_DEVICE_VCGT_CAPABILITIES"/> struct.</summary>
public static unsafe partial class WCS_DEVICE_VCGT_CAPABILITIESTests
{
    /// <summary>Validates that the <see cref = "WCS_DEVICE_VCGT_CAPABILITIES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WCS_DEVICE_VCGT_CAPABILITIES>(), Is.EqualTo(sizeof(WCS_DEVICE_VCGT_CAPABILITIES)));
    }

    /// <summary>Validates that the <see cref = "WCS_DEVICE_VCGT_CAPABILITIES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WCS_DEVICE_VCGT_CAPABILITIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WCS_DEVICE_VCGT_CAPABILITIES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WCS_DEVICE_VCGT_CAPABILITIES), Is.EqualTo(8));
    }
}