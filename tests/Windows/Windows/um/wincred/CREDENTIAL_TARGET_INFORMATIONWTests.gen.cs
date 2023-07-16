// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CREDENTIAL_TARGET_INFORMATIONW"/> struct.</summary>
public static unsafe partial class CREDENTIAL_TARGET_INFORMATIONWTests
{
    /// <summary>Validates that the <see cref = "CREDENTIAL_TARGET_INFORMATIONW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CREDENTIAL_TARGET_INFORMATIONW>(), Is.EqualTo(sizeof(CREDENTIAL_TARGET_INFORMATIONW)));
    }

    /// <summary>Validates that the <see cref = "CREDENTIAL_TARGET_INFORMATIONW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CREDENTIAL_TARGET_INFORMATIONW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CREDENTIAL_TARGET_INFORMATIONW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CREDENTIAL_TARGET_INFORMATIONW), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(CREDENTIAL_TARGET_INFORMATIONW), Is.EqualTo(40));
        }
    }
}