// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFCaptureEngineOnEventCallback"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IMFCaptureEngineOnEventCallbackTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFCaptureEngineOnEventCallback"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFCaptureEngineOnEventCallback).GUID, Is.EqualTo(IID_IMFCaptureEngineOnEventCallback));
    }

    /// <summary>Validates that the <see cref = "IMFCaptureEngineOnEventCallback"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFCaptureEngineOnEventCallback>(), Is.EqualTo(sizeof(IMFCaptureEngineOnEventCallback)));
    }

    /// <summary>Validates that the <see cref = "IMFCaptureEngineOnEventCallback"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFCaptureEngineOnEventCallback).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFCaptureEngineOnEventCallback"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFCaptureEngineOnEventCallback), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFCaptureEngineOnEventCallback), Is.EqualTo(4));
        }
    }
}