// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "D3D12_VIDEO_EXTENSION_COMMAND_DESC"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class D3D12_VIDEO_EXTENSION_COMMAND_DESCTests
{
    /// <summary>Validates that the <see cref = "D3D12_VIDEO_EXTENSION_COMMAND_DESC"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12_VIDEO_EXTENSION_COMMAND_DESC>(), Is.EqualTo(sizeof(D3D12_VIDEO_EXTENSION_COMMAND_DESC)));
    }

    /// <summary>Validates that the <see cref = "D3D12_VIDEO_EXTENSION_COMMAND_DESC"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_VIDEO_EXTENSION_COMMAND_DESC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12_VIDEO_EXTENSION_COMMAND_DESC"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D12_VIDEO_EXTENSION_COMMAND_DESC), Is.EqualTo(20));
    }
}