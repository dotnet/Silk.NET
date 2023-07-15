// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFMediaEngineEME"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IMFMediaEngineEMETests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFMediaEngineEME"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFMediaEngineEME).GUID, Is.EqualTo(IID_IMFMediaEngineEME));
    }

    /// <summary>Validates that the <see cref = "IMFMediaEngineEME"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFMediaEngineEME>(), Is.EqualTo(sizeof(IMFMediaEngineEME)));
    }

    /// <summary>Validates that the <see cref = "IMFMediaEngineEME"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFMediaEngineEME).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFMediaEngineEME"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFMediaEngineEME), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFMediaEngineEME), Is.EqualTo(4));
        }
    }
}