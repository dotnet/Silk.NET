// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1"/> struct.</summary>
public static unsafe partial class D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1Tests
{
    /// <summary>Validates that the <see cref = "D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1>(), Is.EqualTo(sizeof(D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1)));
    }

    /// <summary>Validates that the <see cref = "D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1), Is.EqualTo(40));
        }
    }
}