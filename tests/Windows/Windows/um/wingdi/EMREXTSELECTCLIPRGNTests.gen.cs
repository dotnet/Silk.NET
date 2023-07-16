// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EMREXTSELECTCLIPRGN"/> struct.</summary>
public static unsafe partial class EMREXTSELECTCLIPRGNTests
{
    /// <summary>Validates that the <see cref = "EMREXTSELECTCLIPRGN"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EMREXTSELECTCLIPRGN>(), Is.EqualTo(sizeof(EMREXTSELECTCLIPRGN)));
    }

    /// <summary>Validates that the <see cref = "EMREXTSELECTCLIPRGN"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EMREXTSELECTCLIPRGN).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EMREXTSELECTCLIPRGN"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EMREXTSELECTCLIPRGN), Is.EqualTo(20));
    }
}