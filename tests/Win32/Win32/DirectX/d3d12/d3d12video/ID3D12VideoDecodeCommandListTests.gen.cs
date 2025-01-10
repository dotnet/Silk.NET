// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "ID3D12VideoDecodeCommandList"/> struct.</summary>
public static unsafe partial class ID3D12VideoDecodeCommandListTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID3D12VideoDecodeCommandList"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ID3D12VideoDecodeCommandList).GUID,
            Is.EqualTo(IID_ID3D12VideoDecodeCommandList)
        );
    }

    /// <summary>Validates that the <see cref = "ID3D12VideoDecodeCommandList"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ID3D12VideoDecodeCommandList>(),
            Is.EqualTo(sizeof(ID3D12VideoDecodeCommandList))
        );
    }

    /// <summary>Validates that the <see cref = "ID3D12VideoDecodeCommandList"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D12VideoDecodeCommandList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3D12VideoDecodeCommandList"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D12VideoDecodeCommandList), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D12VideoDecodeCommandList), Is.EqualTo(4));
        }
    }
}
