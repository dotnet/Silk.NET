// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NMS_VBXADPCMWAVEFORMAT"/> struct.</summary>
public static unsafe partial class NMS_VBXADPCMWAVEFORMATTests
{
    /// <summary>Validates that the <see cref = "NMS_VBXADPCMWAVEFORMAT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMS_VBXADPCMWAVEFORMAT>(), Is.EqualTo(sizeof(NMS_VBXADPCMWAVEFORMAT)));
    }

    /// <summary>Validates that the <see cref = "NMS_VBXADPCMWAVEFORMAT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMS_VBXADPCMWAVEFORMAT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NMS_VBXADPCMWAVEFORMAT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(NMS_VBXADPCMWAVEFORMAT), Is.EqualTo(20));
    }
}