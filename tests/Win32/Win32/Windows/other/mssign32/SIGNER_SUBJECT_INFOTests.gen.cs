// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Win32.UnitTests;

/// <summary>Provides validation of the <see cref = "SignerSubjectInfo"/> struct.</summary>
public static unsafe partial class SIGNER_SUBJECT_INFOTests
{
    /// <summary>Validates that the <see cref = "SignerSubjectInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SignerSubjectInfo>(), Is.EqualTo(sizeof(SignerSubjectInfo)));
    }

    /// <summary>Validates that the <see cref = "SignerSubjectInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SignerSubjectInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SignerSubjectInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SignerSubjectInfo), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SignerSubjectInfo), Is.EqualTo(16));
        }
    }
}
