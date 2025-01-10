// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D11_RENDER_TARGET_BLEND_DESC1"/> struct.</summary>
public static unsafe partial class D3D11_RENDER_TARGET_BLEND_DESC1Tests
{
    /// <summary>Validates that the <see cref = "D3D11_RENDER_TARGET_BLEND_DESC1"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3D11_RENDER_TARGET_BLEND_DESC1>(),
            Is.EqualTo(sizeof(D3D11_RENDER_TARGET_BLEND_DESC1))
        );
    }

    /// <summary>Validates that the <see cref = "D3D11_RENDER_TARGET_BLEND_DESC1"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D11_RENDER_TARGET_BLEND_DESC1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D11_RENDER_TARGET_BLEND_DESC1"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D11_RENDER_TARGET_BLEND_DESC1), Is.EqualTo(40));
    }
}
