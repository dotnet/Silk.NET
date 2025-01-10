// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IMFCaptureEngineOnSampleCallback"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IMFCaptureEngineOnSampleCallbackTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFCaptureEngineOnSampleCallback"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IMFCaptureEngineOnSampleCallback).GUID,
            Is.EqualTo(IID_IMFCaptureEngineOnSampleCallback)
        );
    }

    /// <summary>Validates that the <see cref = "IMFCaptureEngineOnSampleCallback"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IMFCaptureEngineOnSampleCallback>(),
            Is.EqualTo(sizeof(IMFCaptureEngineOnSampleCallback))
        );
    }

    /// <summary>Validates that the <see cref = "IMFCaptureEngineOnSampleCallback"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFCaptureEngineOnSampleCallback).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFCaptureEngineOnSampleCallback"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFCaptureEngineOnSampleCallback), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFCaptureEngineOnSampleCallback), Is.EqualTo(4));
        }
    }
}
