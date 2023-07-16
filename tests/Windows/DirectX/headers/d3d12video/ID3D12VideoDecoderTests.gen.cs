// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "ID3D12VideoDecoder"/> struct.</summary>
public static unsafe partial class ID3D12VideoDecoderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID3D12VideoDecoder"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3D12VideoDecoder).GUID, Is.EqualTo(IID_ID3D12VideoDecoder));
    }

    /// <summary>Validates that the <see cref = "ID3D12VideoDecoder"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3D12VideoDecoder>(), Is.EqualTo(sizeof(ID3D12VideoDecoder)));
    }

    /// <summary>Validates that the <see cref = "ID3D12VideoDecoder"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D12VideoDecoder).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3D12VideoDecoder"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D12VideoDecoder), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D12VideoDecoder), Is.EqualTo(4));
        }
    }
}