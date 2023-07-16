// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SecPkgContext_RemoteCredentialInfo"/> struct.</summary>
public static unsafe partial class SecPkgContext_RemoteCredentialInfoTests
{
    /// <summary>Validates that the <see cref = "SecPkgContext_RemoteCredentialInfo"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SecPkgContext_RemoteCredentialInfo>(), Is.EqualTo(sizeof(SecPkgContext_RemoteCredentialInfo)));
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_RemoteCredentialInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SecPkgContext_RemoteCredentialInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_RemoteCredentialInfo"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SecPkgContext_RemoteCredentialInfo), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SecPkgContext_RemoteCredentialInfo), Is.EqualTo(20));
        }
    }
}