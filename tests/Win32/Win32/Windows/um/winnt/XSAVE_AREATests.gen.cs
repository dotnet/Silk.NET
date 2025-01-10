// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "XSAVE_AREA"/> struct.</summary>
public static unsafe partial class XSAVE_AREATests
{
    /// <summary>Validates that the <see cref = "XSAVE_AREA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XSAVE_AREA>(), Is.EqualTo(sizeof(XSAVE_AREA)));
    }

    /// <summary>Validates that the <see cref = "XSAVE_AREA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XSAVE_AREA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "XSAVE_AREA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(XSAVE_AREA), Is.EqualTo(576));
    }
}
