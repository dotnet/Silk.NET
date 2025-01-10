// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DiaAddressMapEntry"/> struct.</summary>
public static unsafe partial class DiaAddressMapEntryTests
{
    /// <summary>Validates that the <see cref = "DiaAddressMapEntry"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DiaAddressMapEntry>(), Is.EqualTo(sizeof(DiaAddressMapEntry)));
    }

    /// <summary>Validates that the <see cref = "DiaAddressMapEntry"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DiaAddressMapEntry).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DiaAddressMapEntry"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DiaAddressMapEntry), Is.EqualTo(8));
    }
}
