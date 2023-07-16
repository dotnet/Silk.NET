// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EMRFRAMERGN"/> struct.</summary>
public static unsafe partial class EMRFRAMERGNTests
{
    /// <summary>Validates that the <see cref = "EMRFRAMERGN"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EMRFRAMERGN>(), Is.EqualTo(sizeof(EMRFRAMERGN)));
    }

    /// <summary>Validates that the <see cref = "EMRFRAMERGN"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EMRFRAMERGN).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EMRFRAMERGN"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EMRFRAMERGN), Is.EqualTo(44));
    }
}