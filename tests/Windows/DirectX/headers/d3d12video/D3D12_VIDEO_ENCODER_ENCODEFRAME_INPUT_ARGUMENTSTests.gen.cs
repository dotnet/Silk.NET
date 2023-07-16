// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS"/> struct.</summary>
public static unsafe partial class D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTSTests
{
    /// <summary>Validates that the <see cref = "D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS>(), Is.EqualTo(sizeof(D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS)));
    }

    /// <summary>Validates that the <see cref = "D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS), Is.EqualTo(160));
        }
        else
        {
            Assert.That(sizeof(D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS), Is.EqualTo(104));
        }
    }
}