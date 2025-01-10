// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D12_TEXTURE_COPY_LOCATION"/> struct.</summary>
public static unsafe partial class D3D12_TEXTURE_COPY_LOCATIONTests
{
    /// <summary>Validates that the <see cref = "D3D12_TEXTURE_COPY_LOCATION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3D12_TEXTURE_COPY_LOCATION>(),
            Is.EqualTo(sizeof(D3D12_TEXTURE_COPY_LOCATION))
        );
    }

    /// <summary>Validates that the <see cref = "D3D12_TEXTURE_COPY_LOCATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_TEXTURE_COPY_LOCATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12_TEXTURE_COPY_LOCATION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12_TEXTURE_COPY_LOCATION), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(D3D12_TEXTURE_COPY_LOCATION), Is.EqualTo(40));
        }
    }
}
