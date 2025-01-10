// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "ID3D12Device"/> struct.</summary>
public static unsafe partial class ID3D12DeviceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID3D12Device"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3D12Device).GUID, Is.EqualTo(IID_ID3D12Device));
    }

    /// <summary>Validates that the <see cref = "ID3D12Device"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3D12Device>(), Is.EqualTo(sizeof(ID3D12Device)));
    }

    /// <summary>Validates that the <see cref = "ID3D12Device"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D12Device).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3D12Device"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D12Device), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D12Device), Is.EqualTo(4));
        }
    }
}
