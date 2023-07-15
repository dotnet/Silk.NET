// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPV6_ADDRESS_EX"/> struct.</summary>
public static unsafe partial class IPV6_ADDRESS_EXTests
{
    /// <summary>Validates that the <see cref = "IPV6_ADDRESS_EX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPV6_ADDRESS_EX>(), Is.EqualTo(sizeof(IPV6_ADDRESS_EX)));
    }

    /// <summary>Validates that the <see cref = "IPV6_ADDRESS_EX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPV6_ADDRESS_EX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPV6_ADDRESS_EX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IPV6_ADDRESS_EX), Is.EqualTo(26));
    }
}