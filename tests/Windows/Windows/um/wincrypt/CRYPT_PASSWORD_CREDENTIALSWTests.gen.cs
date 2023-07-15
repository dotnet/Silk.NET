// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CRYPT_PASSWORD_CREDENTIALSW"/> struct.</summary>
public static unsafe partial class CRYPT_PASSWORD_CREDENTIALSWTests
{
    /// <summary>Validates that the <see cref = "CRYPT_PASSWORD_CREDENTIALSW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRYPT_PASSWORD_CREDENTIALSW>(), Is.EqualTo(sizeof(CRYPT_PASSWORD_CREDENTIALSW)));
    }

    /// <summary>Validates that the <see cref = "CRYPT_PASSWORD_CREDENTIALSW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRYPT_PASSWORD_CREDENTIALSW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CRYPT_PASSWORD_CREDENTIALSW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CRYPT_PASSWORD_CREDENTIALSW), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(CRYPT_PASSWORD_CREDENTIALSW), Is.EqualTo(12));
        }
    }
}