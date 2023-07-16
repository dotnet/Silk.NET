// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DXCoreHardwareIDParts"/> struct.</summary>
public static unsafe partial class DXCoreHardwareIDPartsTests
{
    /// <summary>Validates that the <see cref = "DXCoreHardwareIDParts"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXCoreHardwareIDParts>(), Is.EqualTo(sizeof(DXCoreHardwareIDParts)));
    }

    /// <summary>Validates that the <see cref = "DXCoreHardwareIDParts"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXCoreHardwareIDParts).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXCoreHardwareIDParts"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXCoreHardwareIDParts), Is.EqualTo(20));
    }
}