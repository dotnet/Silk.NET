// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "D3D12_FEATURE_DATA_SERIALIZATION"/> struct.</summary>
public static unsafe partial class D3D12_FEATURE_DATA_SERIALIZATIONTests
{
    /// <summary>Validates that the <see cref = "D3D12_FEATURE_DATA_SERIALIZATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12_FEATURE_DATA_SERIALIZATION>(), Is.EqualTo(sizeof(D3D12_FEATURE_DATA_SERIALIZATION)));
    }

    /// <summary>Validates that the <see cref = "D3D12_FEATURE_DATA_SERIALIZATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_FEATURE_DATA_SERIALIZATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12_FEATURE_DATA_SERIALIZATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D12_FEATURE_DATA_SERIALIZATION), Is.EqualTo(8));
    }
}