// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "METAHEADER"/> struct.</summary>
public static unsafe partial class METAHEADERTests
{
    /// <summary>Validates that the <see cref = "METAHEADER"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<METAHEADER>(), Is.EqualTo(sizeof(METAHEADER)));
    }

    /// <summary>Validates that the <see cref = "METAHEADER"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(METAHEADER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "METAHEADER"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(METAHEADER), Is.EqualTo(18));
    }
}
