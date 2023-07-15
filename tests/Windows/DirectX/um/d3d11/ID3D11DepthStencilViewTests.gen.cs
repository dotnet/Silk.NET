// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "ID3D11DepthStencilView"/> struct.</summary>
public static unsafe partial class ID3D11DepthStencilViewTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID3D11DepthStencilView"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3D11DepthStencilView).GUID, Is.EqualTo(IID_ID3D11DepthStencilView));
    }

    /// <summary>Validates that the <see cref = "ID3D11DepthStencilView"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3D11DepthStencilView>(), Is.EqualTo(sizeof(ID3D11DepthStencilView)));
    }

    /// <summary>Validates that the <see cref = "ID3D11DepthStencilView"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D11DepthStencilView).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3D11DepthStencilView"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D11DepthStencilView), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D11DepthStencilView), Is.EqualTo(4));
        }
    }
}