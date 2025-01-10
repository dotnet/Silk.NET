// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CREDENTIAL_TARGET_INFORMATIONA"/> struct.</summary>
public static unsafe partial class CREDENTIAL_TARGET_INFORMATIONATests
{
    /// <summary>Validates that the <see cref = "CREDENTIAL_TARGET_INFORMATIONA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CREDENTIAL_TARGET_INFORMATIONA>(),
            Is.EqualTo(sizeof(CREDENTIAL_TARGET_INFORMATIONA))
        );
    }

    /// <summary>Validates that the <see cref = "CREDENTIAL_TARGET_INFORMATIONA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CREDENTIAL_TARGET_INFORMATIONA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CREDENTIAL_TARGET_INFORMATIONA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CREDENTIAL_TARGET_INFORMATIONA), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(CREDENTIAL_TARGET_INFORMATIONA), Is.EqualTo(40));
        }
    }
}
