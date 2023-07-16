// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFARGB"/> struct.</summary>
public static unsafe partial class MFARGBTests
{
    /// <summary>Validates that the <see cref = "MFARGB"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFARGB>(), Is.EqualTo(sizeof(MFARGB)));
    }

    /// <summary>Validates that the <see cref = "MFARGB"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFARGB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFARGB"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFARGB), Is.EqualTo(4));
    }
}