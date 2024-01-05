// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D12_TEX1D_ARRAY_UAV"/> struct.</summary>
public static unsafe partial class D3D12_TEX1D_ARRAY_UAVTests
{
    /// <summary>Validates that the <see cref = "D3D12_TEX1D_ARRAY_UAV"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3D12_TEX1D_ARRAY_UAV>(),
            Is.EqualTo(sizeof(D3D12_TEX1D_ARRAY_UAV))
        );
    }

    /// <summary>Validates that the <see cref = "D3D12_TEX1D_ARRAY_UAV"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_TEX1D_ARRAY_UAV).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12_TEX1D_ARRAY_UAV"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D12_TEX1D_ARRAY_UAV), Is.EqualTo(12));
    }
}
