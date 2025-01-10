// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "XSAVE_AREA_HEADER"/> struct.</summary>
public static unsafe partial class XSAVE_AREA_HEADERTests
{
    /// <summary>Validates that the <see cref = "XSAVE_AREA_HEADER"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XSAVE_AREA_HEADER>(), Is.EqualTo(sizeof(XSAVE_AREA_HEADER)));
    }

    /// <summary>Validates that the <see cref = "XSAVE_AREA_HEADER"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XSAVE_AREA_HEADER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "XSAVE_AREA_HEADER"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(XSAVE_AREA_HEADER), Is.EqualTo(64));
    }
}
