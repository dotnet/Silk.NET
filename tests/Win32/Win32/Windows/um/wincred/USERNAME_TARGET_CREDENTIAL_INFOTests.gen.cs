// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "USERNAME_TARGET_CREDENTIAL_INFO"/> struct.</summary>
public static unsafe partial class USERNAME_TARGET_CREDENTIAL_INFOTests
{
    /// <summary>Validates that the <see cref = "USERNAME_TARGET_CREDENTIAL_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<USERNAME_TARGET_CREDENTIAL_INFO>(),
            Is.EqualTo(sizeof(USERNAME_TARGET_CREDENTIAL_INFO))
        );
    }

    /// <summary>Validates that the <see cref = "USERNAME_TARGET_CREDENTIAL_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(USERNAME_TARGET_CREDENTIAL_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "USERNAME_TARGET_CREDENTIAL_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(USERNAME_TARGET_CREDENTIAL_INFO), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(USERNAME_TARGET_CREDENTIAL_INFO), Is.EqualTo(4));
        }
    }
}
