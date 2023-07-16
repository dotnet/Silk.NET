// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SecPkgContext_KeyingMaterial"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class SecPkgContext_KeyingMaterialTests
{
    /// <summary>Validates that the <see cref = "SecPkgContext_KeyingMaterial"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SecPkgContext_KeyingMaterial>(), Is.EqualTo(sizeof(SecPkgContext_KeyingMaterial)));
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_KeyingMaterial"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SecPkgContext_KeyingMaterial).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_KeyingMaterial"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SecPkgContext_KeyingMaterial), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SecPkgContext_KeyingMaterial), Is.EqualTo(8));
        }
    }
}