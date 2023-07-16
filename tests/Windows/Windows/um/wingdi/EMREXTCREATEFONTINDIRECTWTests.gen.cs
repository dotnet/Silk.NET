// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EMREXTCREATEFONTINDIRECTW"/> struct.</summary>
public static unsafe partial class EMREXTCREATEFONTINDIRECTWTests
{
    /// <summary>Validates that the <see cref = "EMREXTCREATEFONTINDIRECTW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EMREXTCREATEFONTINDIRECTW>(), Is.EqualTo(sizeof(EMREXTCREATEFONTINDIRECTW)));
    }

    /// <summary>Validates that the <see cref = "EMREXTCREATEFONTINDIRECTW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EMREXTCREATEFONTINDIRECTW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EMREXTCREATEFONTINDIRECTW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EMREXTCREATEFONTINDIRECTW), Is.EqualTo(332));
    }
}