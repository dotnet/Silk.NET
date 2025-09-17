// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Win32.UnitTests;

/// <summary>Provides validation of the <see cref = "SignerSignEx2Params"/> struct.</summary>
public static unsafe partial class SIGNER_SIGN_EX2_PARAMSTests
{
    /// <summary>Validates that the <see cref = "SignerSignEx2Params"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SignerSignEx2Params>(), Is.EqualTo(sizeof(SignerSignEx2Params)));
    }

    /// <summary>Validates that the <see cref = "SignerSignEx2Params"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SignerSignEx2Params).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SignerSignEx2Params"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SignerSignEx2Params), Is.EqualTo(104));
        }
        else
        {
            Assert.That(sizeof(SignerSignEx2Params), Is.EqualTo(52));
        }
    }
}
