// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DiaSourceAlt"/> struct.</summary>
public static unsafe partial class DiaSourceAltTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DiaSourceAlt"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DiaSourceAlt).GUID, Is.EqualTo(CLSID_DiaSourceAlt));
    }

    /// <summary>Validates that the <see cref = "DiaSourceAlt"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DiaSourceAlt>(), Is.EqualTo(sizeof(DiaSourceAlt)));
    }

    /// <summary>Validates that the <see cref = "DiaSourceAlt"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DiaSourceAlt).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DiaSourceAlt"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DiaSourceAlt), Is.EqualTo(1));
    }
}
