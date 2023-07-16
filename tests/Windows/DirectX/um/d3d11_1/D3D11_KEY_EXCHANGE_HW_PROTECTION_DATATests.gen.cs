// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class D3D11_KEY_EXCHANGE_HW_PROTECTION_DATATests
{
    /// <summary>Validates that the <see cref = "D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA>(), Is.EqualTo(sizeof(D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA)));
    }

    /// <summary>Validates that the <see cref = "D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA), Is.EqualTo(16));
        }
    }
}