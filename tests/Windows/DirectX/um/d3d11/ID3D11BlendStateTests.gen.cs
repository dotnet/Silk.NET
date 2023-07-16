// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "ID3D11BlendState"/> struct.</summary>
public static unsafe partial class ID3D11BlendStateTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID3D11BlendState"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3D11BlendState).GUID, Is.EqualTo(IID_ID3D11BlendState));
    }

    /// <summary>Validates that the <see cref = "ID3D11BlendState"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3D11BlendState>(), Is.EqualTo(sizeof(ID3D11BlendState)));
    }

    /// <summary>Validates that the <see cref = "ID3D11BlendState"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D11BlendState).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3D11BlendState"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D11BlendState), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D11BlendState), Is.EqualTo(4));
        }
    }
}