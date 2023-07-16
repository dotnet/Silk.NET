// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDecoderHeap"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDecoderHeapTest()
    {
        Assert.That(IID_ID3D12VideoDecoderHeap, Is.EqualTo(new Guid(0x0946B7C9, 0xEBF6, 0x4047, 0xBB, 0x73, 0x86, 0x83, 0xE2, 0x7D, 0xBB, 0x1F)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDevice"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDeviceTest()
    {
        Assert.That(IID_ID3D12VideoDevice, Is.EqualTo(new Guid(0x1F052807, 0x0B46, 0x4ACC, 0x8A, 0x89, 0x36, 0x4F, 0x79, 0x37, 0x18, 0xA4)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDecoder"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDecoderTest()
    {
        Assert.That(IID_ID3D12VideoDecoder, Is.EqualTo(new Guid(0xC59B6BDC, 0x7720, 0x4074, 0xA1, 0x36, 0x17, 0xA1, 0x56, 0x03, 0x74, 0x70)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoProcessor"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoProcessorTest()
    {
        Assert.That(IID_ID3D12VideoProcessor, Is.EqualTo(new Guid(0x304FDB32, 0xBEDE, 0x410A, 0x85, 0x45, 0x94, 0x3A, 0xC6, 0xA4, 0x61, 0x38)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDecodeCommandList"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDecodeCommandListTest()
    {
        Assert.That(IID_ID3D12VideoDecodeCommandList, Is.EqualTo(new Guid(0x3B60536E, 0xAD29, 0x4E64, 0xA2, 0x69, 0xF8, 0x53, 0x83, 0x7E, 0x5E, 0x53)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoProcessCommandList"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoProcessCommandListTest()
    {
        Assert.That(IID_ID3D12VideoProcessCommandList, Is.EqualTo(new Guid(0xAEB2543A, 0x167F, 0x4682, 0xAC, 0xC8, 0xD1, 0x59, 0xED, 0x4A, 0x62, 0x09)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDecodeCommandList1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDecodeCommandList1Test()
    {
        Assert.That(IID_ID3D12VideoDecodeCommandList1, Is.EqualTo(new Guid(0xD52F011B, 0xB56E, 0x453C, 0xA0, 0x5A, 0xA7, 0xF3, 0x11, 0xC8, 0xF4, 0x72)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoProcessCommandList1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoProcessCommandList1Test()
    {
        Assert.That(IID_ID3D12VideoProcessCommandList1, Is.EqualTo(new Guid(0x542C5C4D, 0x7596, 0x434F, 0x8C, 0x93, 0x4E, 0xFA, 0x67, 0x66, 0xF2, 0x67)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoMotionEstimator"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoMotionEstimatorTest()
    {
        Assert.That(IID_ID3D12VideoMotionEstimator, Is.EqualTo(new Guid(0x33FDAE0E, 0x098B, 0x428F, 0x87, 0xBB, 0x34, 0xB6, 0x95, 0xDE, 0x08, 0xF8)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoMotionVectorHeap"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoMotionVectorHeapTest()
    {
        Assert.That(IID_ID3D12VideoMotionVectorHeap, Is.EqualTo(new Guid(0x5BE17987, 0x743A, 0x4061, 0x83, 0x4B, 0x23, 0xD2, 0x2D, 0xAE, 0xA5, 0x05)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDevice1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDevice1Test()
    {
        Assert.That(IID_ID3D12VideoDevice1, Is.EqualTo(new Guid(0x981611AD, 0xA144, 0x4C83, 0x98, 0x90, 0xF3, 0x0E, 0x26, 0xD6, 0x58, 0xAB)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoEncodeCommandList"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoEncodeCommandListTest()
    {
        Assert.That(IID_ID3D12VideoEncodeCommandList, Is.EqualTo(new Guid(0x8455293A, 0x0CBD, 0x4831, 0x9B, 0x39, 0xFB, 0xDB, 0xAB, 0x72, 0x47, 0x23)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDecoder1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDecoder1Test()
    {
        Assert.That(IID_ID3D12VideoDecoder1, Is.EqualTo(new Guid(0x79A2E5FB, 0xCCD2, 0x469A, 0x9F, 0xDE, 0x19, 0x5D, 0x10, 0x95, 0x1F, 0x7E)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDecoderHeap1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDecoderHeap1Test()
    {
        Assert.That(IID_ID3D12VideoDecoderHeap1, Is.EqualTo(new Guid(0xDA1D98C5, 0x539F, 0x41B2, 0xBF, 0x6B, 0x11, 0x98, 0xA0, 0x3B, 0x6D, 0x26)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoProcessor1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoProcessor1Test()
    {
        Assert.That(IID_ID3D12VideoProcessor1, Is.EqualTo(new Guid(0xF3CFE615, 0x553F, 0x425C, 0x86, 0xD8, 0xEE, 0x8C, 0x1B, 0x1F, 0xB0, 0x1C)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoExtensionCommand"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoExtensionCommandTest()
    {
        Assert.That(IID_ID3D12VideoExtensionCommand, Is.EqualTo(new Guid(0x554E41E8, 0xAE8E, 0x4A8C, 0xB7, 0xD2, 0x5B, 0x4F, 0x27, 0x4A, 0x30, 0xE4)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDevice2"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDevice2Test()
    {
        Assert.That(IID_ID3D12VideoDevice2, Is.EqualTo(new Guid(0xF019AC49, 0xF838, 0x4A95, 0x9B, 0x17, 0x57, 0x94, 0x37, 0xC8, 0xF5, 0x13)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDecodeCommandList2"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDecodeCommandList2Test()
    {
        Assert.That(IID_ID3D12VideoDecodeCommandList2, Is.EqualTo(new Guid(0x6e120880, 0xc114, 0x4153, 0x80, 0x36, 0xd2, 0x47, 0x05, 0x1e, 0x17, 0x29)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDecodeCommandList3"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDecodeCommandList3Test()
    {
        Assert.That(IID_ID3D12VideoDecodeCommandList3, Is.EqualTo(new Guid(0x2aee8c37, 0x9562, 0x42da, 0x8a, 0xbf, 0x61, 0xef, 0xeb, 0x2e, 0x45, 0x13)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoProcessCommandList2"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoProcessCommandList2Test()
    {
        Assert.That(IID_ID3D12VideoProcessCommandList2, Is.EqualTo(new Guid(0xdb525ae4, 0x6ad6, 0x473c, 0xba, 0xa7, 0x59, 0xb2, 0xe3, 0x70, 0x82, 0xe4)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoProcessCommandList3"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoProcessCommandList3Test()
    {
        Assert.That(IID_ID3D12VideoProcessCommandList3, Is.EqualTo(new Guid(0x1a0a4ca4, 0x9f08, 0x40ce, 0x95, 0x58, 0xb4, 0x11, 0xfd, 0x26, 0x66, 0xff)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoEncodeCommandList1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoEncodeCommandList1Test()
    {
        Assert.That(IID_ID3D12VideoEncodeCommandList1, Is.EqualTo(new Guid(0x94971eca, 0x2bdb, 0x4769, 0x88, 0xcf, 0x36, 0x75, 0xea, 0x75, 0x7e, 0xbc)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoEncoder"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoEncoderTest()
    {
        Assert.That(IID_ID3D12VideoEncoder, Is.EqualTo(new Guid(0x2E0D212D, 0x8DF9, 0x44A6, 0xA7, 0x70, 0xBB, 0x28, 0x9B, 0x18, 0x27, 0x37)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoEncoderHeap"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoEncoderHeapTest()
    {
        Assert.That(IID_ID3D12VideoEncoderHeap, Is.EqualTo(new Guid(0x22B35D96, 0x876A, 0x44C0, 0xB2, 0x5E, 0xFB, 0x8C, 0x9C, 0x7F, 0x1C, 0x4A)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoDevice3"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoDevice3Test()
    {
        Assert.That(IID_ID3D12VideoDevice3, Is.EqualTo(new Guid(0x4243ADB4, 0x3A32, 0x4666, 0x97, 0x3C, 0x0C, 0xCC, 0x56, 0x25, 0xDC, 0x44)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoEncodeCommandList2"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoEncodeCommandList2Test()
    {
        Assert.That(IID_ID3D12VideoEncodeCommandList2, Is.EqualTo(new Guid(0x895491e2, 0xe701, 0x46a9, 0x9a, 0x1f, 0x8d, 0x34, 0x80, 0xed, 0x86, 0x7a)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VideoEncodeCommandList3"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12VideoEncodeCommandList3Test()
    {
        Assert.That(IID_ID3D12VideoEncodeCommandList3, Is.EqualTo(new Guid(0x7f027b22, 0x1515, 0x4e85, 0xaa, 0x0d, 0x02, 0x64, 0x86, 0x58, 0x05, 0x76)));
    }
}