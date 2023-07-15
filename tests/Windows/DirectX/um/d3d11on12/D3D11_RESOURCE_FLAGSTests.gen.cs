// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "D3D11_RESOURCE_FLAGS"/> struct.</summary>
public static unsafe partial class D3D11_RESOURCE_FLAGSTests
{
    /// <summary>Validates that the <see cref = "D3D11_RESOURCE_FLAGS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D11_RESOURCE_FLAGS>(), Is.EqualTo(sizeof(D3D11_RESOURCE_FLAGS)));
    }

    /// <summary>Validates that the <see cref = "D3D11_RESOURCE_FLAGS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D11_RESOURCE_FLAGS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D11_RESOURCE_FLAGS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D11_RESOURCE_FLAGS), Is.EqualTo(16));
    }
}