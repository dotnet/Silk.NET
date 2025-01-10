// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CRYPT_VERIFY_CERT_SIGN_WEAK_HASH_INFO"/> struct.</summary>
public static unsafe partial class CRYPT_VERIFY_CERT_SIGN_WEAK_HASH_INFOTests
{
    /// <summary>Validates that the <see cref = "CRYPT_VERIFY_CERT_SIGN_WEAK_HASH_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CRYPT_VERIFY_CERT_SIGN_WEAK_HASH_INFO>(),
            Is.EqualTo(sizeof(CRYPT_VERIFY_CERT_SIGN_WEAK_HASH_INFO))
        );
    }

    /// <summary>Validates that the <see cref = "CRYPT_VERIFY_CERT_SIGN_WEAK_HASH_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRYPT_VERIFY_CERT_SIGN_WEAK_HASH_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CRYPT_VERIFY_CERT_SIGN_WEAK_HASH_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CRYPT_VERIFY_CERT_SIGN_WEAK_HASH_INFO), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(CRYPT_VERIFY_CERT_SIGN_WEAK_HASH_INFO), Is.EqualTo(12));
        }
    }
}
