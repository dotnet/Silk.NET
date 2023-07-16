// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFCaptureEngineOnSampleCallback2"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IMFCaptureEngineOnSampleCallback2Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFCaptureEngineOnSampleCallback2"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFCaptureEngineOnSampleCallback2).GUID, Is.EqualTo(IID_IMFCaptureEngineOnSampleCallback2));
    }

    /// <summary>Validates that the <see cref = "IMFCaptureEngineOnSampleCallback2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFCaptureEngineOnSampleCallback2>(), Is.EqualTo(sizeof(IMFCaptureEngineOnSampleCallback2)));
    }

    /// <summary>Validates that the <see cref = "IMFCaptureEngineOnSampleCallback2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFCaptureEngineOnSampleCallback2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFCaptureEngineOnSampleCallback2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFCaptureEngineOnSampleCallback2), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFCaptureEngineOnSampleCallback2), Is.EqualTo(4));
        }
    }
}