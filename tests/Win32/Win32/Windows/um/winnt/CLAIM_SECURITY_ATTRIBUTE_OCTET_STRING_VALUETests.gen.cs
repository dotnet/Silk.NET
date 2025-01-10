// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUETests
{
    /// <summary>Validates that the <see cref = "CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE>(),
            Is.EqualTo(sizeof(CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE))
        );
    }

    /// <summary>Validates that the <see cref = "CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE), Is.EqualTo(8));
        }
    }
}
