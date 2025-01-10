// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "AM_COPY_MACROVISION"/> struct.</summary>
public static unsafe partial class AM_COPY_MACROVISIONTests
{
    /// <summary>Validates that the <see cref = "AM_COPY_MACROVISION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AM_COPY_MACROVISION>(), Is.EqualTo(sizeof(AM_COPY_MACROVISION)));
    }

    /// <summary>Validates that the <see cref = "AM_COPY_MACROVISION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AM_COPY_MACROVISION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AM_COPY_MACROVISION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AM_COPY_MACROVISION), Is.EqualTo(4));
    }
}
