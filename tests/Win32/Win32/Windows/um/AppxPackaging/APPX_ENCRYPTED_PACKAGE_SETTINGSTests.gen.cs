// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "APPX_ENCRYPTED_PACKAGE_SETTINGS"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class APPX_ENCRYPTED_PACKAGE_SETTINGSTests
{
    /// <summary>Validates that the <see cref = "APPX_ENCRYPTED_PACKAGE_SETTINGS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<APPX_ENCRYPTED_PACKAGE_SETTINGS>(),
            Is.EqualTo(sizeof(APPX_ENCRYPTED_PACKAGE_SETTINGS))
        );
    }

    /// <summary>Validates that the <see cref = "APPX_ENCRYPTED_PACKAGE_SETTINGS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(APPX_ENCRYPTED_PACKAGE_SETTINGS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "APPX_ENCRYPTED_PACKAGE_SETTINGS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(APPX_ENCRYPTED_PACKAGE_SETTINGS), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(APPX_ENCRYPTED_PACKAGE_SETTINGS), Is.EqualTo(16));
        }
    }
}
