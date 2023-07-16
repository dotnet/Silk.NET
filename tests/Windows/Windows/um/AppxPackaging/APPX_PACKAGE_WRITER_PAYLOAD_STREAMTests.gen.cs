// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "APPX_PACKAGE_WRITER_PAYLOAD_STREAM"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class APPX_PACKAGE_WRITER_PAYLOAD_STREAMTests
{
    /// <summary>Validates that the <see cref = "APPX_PACKAGE_WRITER_PAYLOAD_STREAM"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<APPX_PACKAGE_WRITER_PAYLOAD_STREAM>(), Is.EqualTo(sizeof(APPX_PACKAGE_WRITER_PAYLOAD_STREAM)));
    }

    /// <summary>Validates that the <see cref = "APPX_PACKAGE_WRITER_PAYLOAD_STREAM"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(APPX_PACKAGE_WRITER_PAYLOAD_STREAM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "APPX_PACKAGE_WRITER_PAYLOAD_STREAM"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(APPX_PACKAGE_WRITER_PAYLOAD_STREAM), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(APPX_PACKAGE_WRITER_PAYLOAD_STREAM), Is.EqualTo(16));
        }
    }
}