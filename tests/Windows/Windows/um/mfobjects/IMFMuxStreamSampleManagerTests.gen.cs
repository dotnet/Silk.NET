// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFMuxStreamSampleManager"/> struct.</summary>
[SupportedOSPlatform("windows10.0.15063.0")]
public static unsafe partial class IMFMuxStreamSampleManagerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFMuxStreamSampleManager"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFMuxStreamSampleManager).GUID, Is.EqualTo(IID_IMFMuxStreamSampleManager));
    }

    /// <summary>Validates that the <see cref = "IMFMuxStreamSampleManager"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFMuxStreamSampleManager>(), Is.EqualTo(sizeof(IMFMuxStreamSampleManager)));
    }

    /// <summary>Validates that the <see cref = "IMFMuxStreamSampleManager"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFMuxStreamSampleManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFMuxStreamSampleManager"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFMuxStreamSampleManager), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFMuxStreamSampleManager), Is.EqualTo(4));
        }
    }
}