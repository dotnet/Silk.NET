// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Win32.UnitTests;

/// <summary>Provides validation of the <see cref = "SignerSignatureInfo"/> struct.</summary>
public static unsafe partial class SIGNER_SIGNATURE_INFOTests
{
    /// <summary>Validates that the <see cref = "SignerSignatureInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SignerSignatureInfo>(), Is.EqualTo(sizeof(SignerSignatureInfo)));
    }

    /// <summary>Validates that the <see cref = "SignerSignatureInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SignerSignatureInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SignerSignatureInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SignerSignatureInfo), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(SignerSignatureInfo), Is.EqualTo(24));
        }
    }
}
