// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SecPkgContext_LocalCredentialInfo"/> struct.</summary>
public static unsafe partial class SecPkgContext_LocalCredentialInfoTests
{
    /// <summary>Validates that the <see cref = "SecPkgContext_LocalCredentialInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SecPkgContext_LocalCredentialInfo>(),
            Is.EqualTo(sizeof(SecPkgContext_LocalCredentialInfo))
        );
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_LocalCredentialInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SecPkgContext_LocalCredentialInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_LocalCredentialInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SecPkgContext_LocalCredentialInfo), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SecPkgContext_LocalCredentialInfo), Is.EqualTo(20));
        }
    }
}
