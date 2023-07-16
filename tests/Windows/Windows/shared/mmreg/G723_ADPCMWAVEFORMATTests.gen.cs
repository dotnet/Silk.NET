// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "G723_ADPCMWAVEFORMAT"/> struct.</summary>
public static unsafe partial class G723_ADPCMWAVEFORMATTests
{
    /// <summary>Validates that the <see cref = "G723_ADPCMWAVEFORMAT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<G723_ADPCMWAVEFORMAT>(), Is.EqualTo(sizeof(G723_ADPCMWAVEFORMAT)));
    }

    /// <summary>Validates that the <see cref = "G723_ADPCMWAVEFORMAT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(G723_ADPCMWAVEFORMAT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "G723_ADPCMWAVEFORMAT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(G723_ADPCMWAVEFORMAT), Is.EqualTo(22));
    }
}