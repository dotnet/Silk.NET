// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SecPkgContext_KeyingMaterialInfo"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class SecPkgContext_KeyingMaterialInfoTests
{
    /// <summary>Validates that the <see cref = "SecPkgContext_KeyingMaterialInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SecPkgContext_KeyingMaterialInfo>(),
            Is.EqualTo(sizeof(SecPkgContext_KeyingMaterialInfo))
        );
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_KeyingMaterialInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SecPkgContext_KeyingMaterialInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_KeyingMaterialInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SecPkgContext_KeyingMaterialInfo), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(SecPkgContext_KeyingMaterialInfo), Is.EqualTo(20));
        }
    }
}
