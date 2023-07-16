// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFMediaEngineEMENotify"/> struct.</summary>
public static unsafe partial class IMFMediaEngineEMENotifyTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFMediaEngineEMENotify"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFMediaEngineEMENotify).GUID, Is.EqualTo(IID_IMFMediaEngineEMENotify));
    }

    /// <summary>Validates that the <see cref = "IMFMediaEngineEMENotify"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFMediaEngineEMENotify>(), Is.EqualTo(sizeof(IMFMediaEngineEMENotify)));
    }

    /// <summary>Validates that the <see cref = "IMFMediaEngineEMENotify"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFMediaEngineEMENotify).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFMediaEngineEMENotify"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFMediaEngineEMENotify), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFMediaEngineEMENotify), Is.EqualTo(4));
        }
    }
}