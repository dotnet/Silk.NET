// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "YAMAHA_ADPCMWAVEFORMAT"/> struct.</summary>
public static unsafe partial class YAMAHA_ADPCMWAVEFORMATTests
{
    /// <summary>Validates that the <see cref = "YAMAHA_ADPCMWAVEFORMAT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<YAMAHA_ADPCMWAVEFORMAT>(), Is.EqualTo(sizeof(YAMAHA_ADPCMWAVEFORMAT)));
    }

    /// <summary>Validates that the <see cref = "YAMAHA_ADPCMWAVEFORMAT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(YAMAHA_ADPCMWAVEFORMAT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "YAMAHA_ADPCMWAVEFORMAT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(YAMAHA_ADPCMWAVEFORMAT), Is.EqualTo(18));
    }
}