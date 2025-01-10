// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "ID3D12VideoEncodeCommandList1"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19043.0")]
public static unsafe partial class ID3D12VideoEncodeCommandList1Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID3D12VideoEncodeCommandList1"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ID3D12VideoEncodeCommandList1).GUID,
            Is.EqualTo(IID_ID3D12VideoEncodeCommandList1)
        );
    }

    /// <summary>Validates that the <see cref = "ID3D12VideoEncodeCommandList1"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ID3D12VideoEncodeCommandList1>(),
            Is.EqualTo(sizeof(ID3D12VideoEncodeCommandList1))
        );
    }

    /// <summary>Validates that the <see cref = "ID3D12VideoEncodeCommandList1"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D12VideoEncodeCommandList1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3D12VideoEncodeCommandList1"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D12VideoEncodeCommandList1), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D12VideoEncodeCommandList1), Is.EqualTo(4));
        }
    }
}
