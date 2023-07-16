// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D11On12On7.h in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "ID3D11On12On7"/> struct.</summary>
public static unsafe partial class ID3D11On12On7Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID3D11On12On7"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3D11On12On7).GUID, Is.EqualTo(IID_ID3D11On12On7));
    }

    /// <summary>Validates that the <see cref = "ID3D11On12On7"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3D11On12On7>(), Is.EqualTo(sizeof(ID3D11On12On7)));
    }

    /// <summary>Validates that the <see cref = "ID3D11On12On7"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D11On12On7).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3D11On12On7"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D11On12On7), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D11On12On7), Is.EqualTo(4));
        }
    }
}