// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "OCSP_SIGNED_REQUEST_INFO"/> struct.</summary>
public static unsafe partial class OCSP_SIGNED_REQUEST_INFOTests
{
    /// <summary>Validates that the <see cref = "OCSP_SIGNED_REQUEST_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<OCSP_SIGNED_REQUEST_INFO>(),
            Is.EqualTo(sizeof(OCSP_SIGNED_REQUEST_INFO))
        );
    }

    /// <summary>Validates that the <see cref = "OCSP_SIGNED_REQUEST_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OCSP_SIGNED_REQUEST_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "OCSP_SIGNED_REQUEST_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OCSP_SIGNED_REQUEST_INFO), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(OCSP_SIGNED_REQUEST_INFO), Is.EqualTo(12));
        }
    }
}
