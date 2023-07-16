// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D11On12On7.h in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "ID3D11On12On7Device"/> struct.</summary>
public static unsafe partial class ID3D11On12On7DeviceTests
{
    /// <summary>Validates that the <see cref = "ID3D11On12On7Device"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3D11On12On7Device>(), Is.EqualTo(sizeof(ID3D11On12On7Device)));
    }

    /// <summary>Validates that the <see cref = "ID3D11On12On7Device"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D11On12On7Device).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3D11On12On7Device"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D11On12On7Device), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D11On12On7Device), Is.EqualTo(4));
        }
    }
}