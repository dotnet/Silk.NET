// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Object"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12ObjectTest()
    {
        Assert.That(
            IID_ID3D12Object,
            Is.EqualTo(
                new Guid(0xc4fec28f, 0x7966, 0x4e95, 0x9f, 0x94, 0xf4, 0x31, 0xcb, 0x56, 0xc3, 0xb8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12DeviceChild"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12DeviceChildTest()
    {
        Assert.That(
            IID_ID3D12DeviceChild,
            Is.EqualTo(
                new Guid(0x905db94b, 0xa00c, 0x4140, 0x9d, 0xf5, 0x2b, 0x64, 0xca, 0x9e, 0xa3, 0x57)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12RootSignature"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12RootSignatureTest()
    {
        Assert.That(
            IID_ID3D12RootSignature,
            Is.EqualTo(
                new Guid(0xc54a6b66, 0x72df, 0x4ee8, 0x8b, 0xe5, 0xa9, 0x46, 0xa1, 0x42, 0x92, 0x14)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12RootSignatureDeserializer"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12RootSignatureDeserializerTest()
    {
        Assert.That(
            IID_ID3D12RootSignatureDeserializer,
            Is.EqualTo(
                new Guid(0x34AB647B, 0x3CC8, 0x46AC, 0x84, 0x1B, 0xC0, 0x96, 0x56, 0x45, 0xC0, 0x46)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VersionedRootSignatureDeserializer"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12VersionedRootSignatureDeserializerTest()
    {
        Assert.That(
            IID_ID3D12VersionedRootSignatureDeserializer,
            Is.EqualTo(
                new Guid(0x7F91CE67, 0x090C, 0x4BB7, 0xB7, 0x8E, 0xED, 0x8F, 0xF2, 0xE3, 0x1D, 0xA0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Pageable"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12PageableTest()
    {
        Assert.That(
            IID_ID3D12Pageable,
            Is.EqualTo(
                new Guid(0x63ee58fb, 0x1268, 0x4835, 0x86, 0xda, 0xf0, 0x08, 0xce, 0x62, 0xf0, 0xd6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Heap"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12HeapTest()
    {
        Assert.That(
            IID_ID3D12Heap,
            Is.EqualTo(
                new Guid(0x6b3b2502, 0x6e51, 0x45b3, 0x90, 0xee, 0x98, 0x84, 0x26, 0x5e, 0x8d, 0xf3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Resource"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12ResourceTest()
    {
        Assert.That(
            IID_ID3D12Resource,
            Is.EqualTo(
                new Guid(0x696442be, 0xa72e, 0x4059, 0xbc, 0x79, 0x5b, 0x5c, 0x98, 0x04, 0x0f, 0xad)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12CommandAllocator"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12CommandAllocatorTest()
    {
        Assert.That(
            IID_ID3D12CommandAllocator,
            Is.EqualTo(
                new Guid(0x6102dee4, 0xaf59, 0x4b09, 0xb9, 0x99, 0xb4, 0x4d, 0x73, 0xf0, 0x9b, 0x24)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Fence"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12FenceTest()
    {
        Assert.That(
            IID_ID3D12Fence,
            Is.EqualTo(
                new Guid(0x0a753dcf, 0xc4d8, 0x4b91, 0xad, 0xf6, 0xbe, 0x5a, 0x60, 0xd9, 0x5a, 0x76)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Fence1"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Fence1Test()
    {
        Assert.That(
            IID_ID3D12Fence1,
            Is.EqualTo(
                new Guid(0x433685fe, 0xe22b, 0x4ca0, 0xa8, 0xdb, 0xb5, 0xb4, 0xf4, 0xdd, 0x0e, 0x4a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12PipelineState"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12PipelineStateTest()
    {
        Assert.That(
            IID_ID3D12PipelineState,
            Is.EqualTo(
                new Guid(0x765a30f3, 0xf624, 0x4c6f, 0xa8, 0x28, 0xac, 0xe9, 0x48, 0x62, 0x24, 0x45)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12DescriptorHeap"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12DescriptorHeapTest()
    {
        Assert.That(
            IID_ID3D12DescriptorHeap,
            Is.EqualTo(
                new Guid(0x8efb471d, 0x616c, 0x4f49, 0x90, 0xf7, 0x12, 0x7b, 0xb7, 0x63, 0xfa, 0x51)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12QueryHeap"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12QueryHeapTest()
    {
        Assert.That(
            IID_ID3D12QueryHeap,
            Is.EqualTo(
                new Guid(0x0d9658ae, 0xed45, 0x469e, 0xa6, 0x1d, 0x97, 0x0e, 0xc5, 0x83, 0xca, 0xb4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12CommandSignature"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12CommandSignatureTest()
    {
        Assert.That(
            IID_ID3D12CommandSignature,
            Is.EqualTo(
                new Guid(0xc36a797c, 0xec80, 0x4f0a, 0x89, 0x85, 0xa7, 0xb2, 0x47, 0x50, 0x82, 0xd1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12CommandList"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12CommandListTest()
    {
        Assert.That(
            IID_ID3D12CommandList,
            Is.EqualTo(
                new Guid(0x7116d91c, 0xe7e4, 0x47ce, 0xb8, 0xc6, 0xec, 0x81, 0x68, 0xf4, 0x37, 0xe5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12GraphicsCommandList"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12GraphicsCommandListTest()
    {
        Assert.That(
            IID_ID3D12GraphicsCommandList,
            Is.EqualTo(
                new Guid(0x5b160d0f, 0xac1b, 0x4185, 0x8b, 0xa8, 0xb3, 0xae, 0x42, 0xa5, 0xa4, 0x55)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12GraphicsCommandList1"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12GraphicsCommandList1Test()
    {
        Assert.That(
            IID_ID3D12GraphicsCommandList1,
            Is.EqualTo(
                new Guid(0x553103fb, 0x1fe7, 0x4557, 0xbb, 0x38, 0x94, 0x6d, 0x7d, 0x0e, 0x7c, 0xa7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12GraphicsCommandList2"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12GraphicsCommandList2Test()
    {
        Assert.That(
            IID_ID3D12GraphicsCommandList2,
            Is.EqualTo(
                new Guid(0x38C3E585, 0xFF17, 0x412C, 0x91, 0x50, 0x4F, 0xC6, 0xF9, 0xD7, 0x2A, 0x28)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12CommandQueue"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12CommandQueueTest()
    {
        Assert.That(
            IID_ID3D12CommandQueue,
            Is.EqualTo(
                new Guid(0x0ec870a6, 0x5d7e, 0x4c22, 0x8c, 0xfc, 0x5b, 0xaa, 0xe0, 0x76, 0x16, 0xed)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12DeviceTest()
    {
        Assert.That(
            IID_ID3D12Device,
            Is.EqualTo(
                new Guid(0x189819f1, 0x1db6, 0x4b57, 0xbe, 0x54, 0x18, 0x21, 0x33, 0x9b, 0x85, 0xf7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12PipelineLibrary"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12PipelineLibraryTest()
    {
        Assert.That(
            IID_ID3D12PipelineLibrary,
            Is.EqualTo(
                new Guid(0xc64226a8, 0x9201, 0x46af, 0xb4, 0xcc, 0x53, 0xfb, 0x9f, 0xf7, 0x41, 0x4f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12PipelineLibrary1"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12PipelineLibrary1Test()
    {
        Assert.That(
            IID_ID3D12PipelineLibrary1,
            Is.EqualTo(
                new Guid(0x80eabf42, 0x2568, 0x4e5e, 0xbd, 0x82, 0xc3, 0x7f, 0x86, 0x96, 0x1d, 0xc3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device1"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Device1Test()
    {
        Assert.That(
            IID_ID3D12Device1,
            Is.EqualTo(
                new Guid(0x77acce80, 0x638e, 0x4e65, 0x88, 0x95, 0xc1, 0xf2, 0x33, 0x86, 0x86, 0x3e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device2"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Device2Test()
    {
        Assert.That(
            IID_ID3D12Device2,
            Is.EqualTo(
                new Guid(0x30baa41e, 0xb15b, 0x475c, 0xa0, 0xbb, 0x1a, 0xf5, 0xc5, 0xb6, 0x43, 0x28)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device3"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Device3Test()
    {
        Assert.That(
            IID_ID3D12Device3,
            Is.EqualTo(
                new Guid(0x81dadc15, 0x2bad, 0x4392, 0x93, 0xc5, 0x10, 0x13, 0x45, 0xc4, 0xaa, 0x98)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12ProtectedSession"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12ProtectedSessionTest()
    {
        Assert.That(
            IID_ID3D12ProtectedSession,
            Is.EqualTo(
                new Guid(0xA1533D18, 0x0AC1, 0x4084, 0x85, 0xB9, 0x89, 0xA9, 0x61, 0x16, 0x80, 0x6B)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12ProtectedResourceSession"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12ProtectedResourceSessionTest()
    {
        Assert.That(
            IID_ID3D12ProtectedResourceSession,
            Is.EqualTo(
                new Guid(0x6CD696F4, 0xF289, 0x40CC, 0x80, 0x91, 0x5A, 0x6C, 0x0A, 0x09, 0x9C, 0x3D)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device4"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Device4Test()
    {
        Assert.That(
            IID_ID3D12Device4,
            Is.EqualTo(
                new Guid(0xe865df17, 0xa9ee, 0x46f9, 0xa4, 0x63, 0x30, 0x98, 0x31, 0x5a, 0xa2, 0xe5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12LifetimeOwner"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12LifetimeOwnerTest()
    {
        Assert.That(
            IID_ID3D12LifetimeOwner,
            Is.EqualTo(
                new Guid(0xe667af9f, 0xcd56, 0x4f46, 0x83, 0xce, 0x03, 0x2e, 0x59, 0x5d, 0x70, 0xa8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12SwapChainAssistant"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12SwapChainAssistantTest()
    {
        Assert.That(
            IID_ID3D12SwapChainAssistant,
            Is.EqualTo(
                new Guid(0xf1df64b6, 0x57fd, 0x49cd, 0x88, 0x07, 0xc0, 0xeb, 0x88, 0xb4, 0x5c, 0x8f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12LifetimeTracker"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12LifetimeTrackerTest()
    {
        Assert.That(
            IID_ID3D12LifetimeTracker,
            Is.EqualTo(
                new Guid(0x3fd03d36, 0x4eb1, 0x424a, 0xa5, 0x82, 0x49, 0x4e, 0xcb, 0x8b, 0xa8, 0x13)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12StateObject"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12StateObjectTest()
    {
        Assert.That(
            IID_ID3D12StateObject,
            Is.EqualTo(
                new Guid(0x47016943, 0xfca8, 0x4594, 0x93, 0xea, 0xaf, 0x25, 0x8b, 0x55, 0x34, 0x6d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12StateObjectProperties"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12StateObjectPropertiesTest()
    {
        Assert.That(
            IID_ID3D12StateObjectProperties,
            Is.EqualTo(
                new Guid(0xde5fa827, 0x9bf9, 0x4f26, 0x89, 0xff, 0xd7, 0xf5, 0x6f, 0xde, 0x38, 0x60)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device5"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Device5Test()
    {
        Assert.That(
            IID_ID3D12Device5,
            Is.EqualTo(
                new Guid(0x8b4f173b, 0x2fea, 0x4b80, 0x8f, 0x58, 0x43, 0x07, 0x19, 0x1a, 0xb9, 0x5d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12DeviceRemovedExtendedDataSettings"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12DeviceRemovedExtendedDataSettingsTest()
    {
        Assert.That(
            IID_ID3D12DeviceRemovedExtendedDataSettings,
            Is.EqualTo(
                new Guid(0x82BC481C, 0x6B9B, 0x4030, 0xAE, 0xDB, 0x7E, 0xE3, 0xD1, 0xDF, 0x1E, 0x63)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12DeviceRemovedExtendedDataSettings1"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12DeviceRemovedExtendedDataSettings1Test()
    {
        Assert.That(
            IID_ID3D12DeviceRemovedExtendedDataSettings1,
            Is.EqualTo(
                new Guid(0xDBD5AE51, 0x3317, 0x4F0A, 0xAD, 0xF9, 0x1D, 0x7C, 0xED, 0xCA, 0xAE, 0x0B)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12DeviceRemovedExtendedDataSettings2"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12DeviceRemovedExtendedDataSettings2Test()
    {
        Assert.That(
            IID_ID3D12DeviceRemovedExtendedDataSettings2,
            Is.EqualTo(
                new Guid(0x61552388, 0x01ab, 0x4008, 0xa4, 0x36, 0x83, 0xdb, 0x18, 0x95, 0x66, 0xea)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12DeviceRemovedExtendedData"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12DeviceRemovedExtendedDataTest()
    {
        Assert.That(
            IID_ID3D12DeviceRemovedExtendedData,
            Is.EqualTo(
                new Guid(0x98931D33, 0x5AE8, 0x4791, 0xAA, 0x3C, 0x1A, 0x73, 0xA2, 0x93, 0x4E, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12DeviceRemovedExtendedData1"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12DeviceRemovedExtendedData1Test()
    {
        Assert.That(
            IID_ID3D12DeviceRemovedExtendedData1,
            Is.EqualTo(
                new Guid(0x9727A022, 0xCF1D, 0x4DDA, 0x9E, 0xBA, 0xEF, 0xFA, 0x65, 0x3F, 0xC5, 0x06)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12DeviceRemovedExtendedData2"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12DeviceRemovedExtendedData2Test()
    {
        Assert.That(
            IID_ID3D12DeviceRemovedExtendedData2,
            Is.EqualTo(
                new Guid(0x67FC5816, 0xE4CA, 0x4915, 0xBF, 0x18, 0x42, 0x54, 0x12, 0x72, 0xDA, 0x54)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device6"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Device6Test()
    {
        Assert.That(
            IID_ID3D12Device6,
            Is.EqualTo(
                new Guid(0xc70b221b, 0x40e4, 0x4a17, 0x89, 0xaf, 0x02, 0x5a, 0x07, 0x27, 0xa6, 0xdc)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12ProtectedResourceSession1"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12ProtectedResourceSession1Test()
    {
        Assert.That(
            IID_ID3D12ProtectedResourceSession1,
            Is.EqualTo(
                new Guid(0xD6F12DD6, 0x76FB, 0x406E, 0x89, 0x61, 0x42, 0x96, 0xEE, 0xFC, 0x04, 0x09)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device7"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Device7Test()
    {
        Assert.That(
            IID_ID3D12Device7,
            Is.EqualTo(
                new Guid(0x5c014b53, 0x68a1, 0x4b9b, 0x8b, 0xd1, 0xdd, 0x60, 0x46, 0xb9, 0x35, 0x8b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device8"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Device8Test()
    {
        Assert.That(
            IID_ID3D12Device8,
            Is.EqualTo(
                new Guid(0x9218E6BB, 0xF944, 0x4F7E, 0xA7, 0x5C, 0xB1, 0xB2, 0xC7, 0xB7, 0x01, 0xF3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Resource1"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Resource1Test()
    {
        Assert.That(
            IID_ID3D12Resource1,
            Is.EqualTo(
                new Guid(0x9D5E227A, 0x4430, 0x4161, 0x88, 0xB3, 0x3E, 0xCA, 0x6B, 0xB1, 0x6E, 0x19)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Resource2"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Resource2Test()
    {
        Assert.That(
            IID_ID3D12Resource2,
            Is.EqualTo(
                new Guid(0xBE36EC3B, 0xEA85, 0x4AEB, 0xA4, 0x5A, 0xE9, 0xD7, 0x64, 0x04, 0xA4, 0x95)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Heap1"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Heap1Test()
    {
        Assert.That(
            IID_ID3D12Heap1,
            Is.EqualTo(
                new Guid(0x572F7389, 0x2168, 0x49E3, 0x96, 0x93, 0xD6, 0xDF, 0x58, 0x71, 0xBF, 0x6D)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12GraphicsCommandList3"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12GraphicsCommandList3Test()
    {
        Assert.That(
            IID_ID3D12GraphicsCommandList3,
            Is.EqualTo(
                new Guid(0x6FDA83A7, 0xB84C, 0x4E38, 0x9A, 0xC8, 0xC7, 0xBD, 0x22, 0x01, 0x6B, 0x3D)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12MetaCommand"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12MetaCommandTest()
    {
        Assert.That(
            IID_ID3D12MetaCommand,
            Is.EqualTo(
                new Guid(0xDBB84C27, 0x36CE, 0x4FC9, 0xB8, 0x01, 0xF0, 0x48, 0xC4, 0x6A, 0xC5, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12GraphicsCommandList4"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12GraphicsCommandList4Test()
    {
        Assert.That(
            IID_ID3D12GraphicsCommandList4,
            Is.EqualTo(
                new Guid(0x8754318e, 0xd3a9, 0x4541, 0x98, 0xcf, 0x64, 0x5b, 0x50, 0xdc, 0x48, 0x74)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12ShaderCacheSession"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12ShaderCacheSessionTest()
    {
        Assert.That(
            IID_ID3D12ShaderCacheSession,
            Is.EqualTo(
                new Guid(0x28e2495d, 0x0f64, 0x4ae4, 0xa6, 0xec, 0x12, 0x92, 0x55, 0xdc, 0x49, 0xa8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device9"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Device9Test()
    {
        Assert.That(
            IID_ID3D12Device9,
            Is.EqualTo(
                new Guid(0x4c80e962, 0xf032, 0x4f60, 0xbc, 0x9e, 0xeb, 0xc2, 0xcf, 0xa1, 0xd8, 0x3c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device10"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Device10Test()
    {
        Assert.That(
            IID_ID3D12Device10,
            Is.EqualTo(
                new Guid(0x517f8718, 0xaa66, 0x49f9, 0xb0, 0x2b, 0xa7, 0xab, 0x89, 0xc0, 0x60, 0x31)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Device11"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12Device11Test()
    {
        Assert.That(
            IID_ID3D12Device11,
            Is.EqualTo(
                new Guid(0x5405c344, 0xd457, 0x444e, 0xb4, 0xdd, 0x23, 0x66, 0xe4, 0x5a, 0xee, 0x39)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12VirtualizationGuestDevice"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12VirtualizationGuestDeviceTest()
    {
        Assert.That(
            IID_ID3D12VirtualizationGuestDevice,
            Is.EqualTo(
                new Guid(0xbc66d368, 0x7373, 0x4943, 0x87, 0x57, 0xfc, 0x87, 0xdc, 0x79, 0xe4, 0x76)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12Tools"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12ToolsTest()
    {
        Assert.That(
            IID_ID3D12Tools,
            Is.EqualTo(
                new Guid(0x7071e1f0, 0xe84b, 0x4b33, 0x97, 0x4f, 0x12, 0xfa, 0x49, 0xde, 0x65, 0xc5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12SDKConfiguration"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12SDKConfigurationTest()
    {
        Assert.That(
            IID_ID3D12SDKConfiguration,
            Is.EqualTo(
                new Guid(0xe9eb5314, 0x33aa, 0x42b2, 0xa7, 0x18, 0xd7, 0x7f, 0x58, 0xb1, 0xf1, 0xc7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12SDKConfiguration1"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12SDKConfiguration1Test()
    {
        Assert.That(
            IID_ID3D12SDKConfiguration1,
            Is.EqualTo(
                new Guid(0x8aaf9303, 0xad25, 0x48b9, 0x9a, 0x57, 0xd9, 0xc3, 0x7e, 0x00, 0x9d, 0x9f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12DeviceFactory"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12DeviceFactoryTest()
    {
        Assert.That(
            IID_ID3D12DeviceFactory,
            Is.EqualTo(
                new Guid(0x61f307d3, 0xd34e, 0x4e7c, 0x83, 0x74, 0x3b, 0xa4, 0xde, 0x23, 0xcc, 0xcb)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12DeviceConfiguration"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12DeviceConfigurationTest()
    {
        Assert.That(
            IID_ID3D12DeviceConfiguration,
            Is.EqualTo(
                new Guid(0x78dbf87b, 0xf766, 0x422b, 0xa6, 0x1c, 0xc8, 0xc4, 0x46, 0xbd, 0xb9, 0xad)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12GraphicsCommandList5"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12GraphicsCommandList5Test()
    {
        Assert.That(
            IID_ID3D12GraphicsCommandList5,
            Is.EqualTo(
                new Guid(0x55050859, 0x4024, 0x474c, 0x87, 0xf5, 0x64, 0x72, 0xea, 0xee, 0x44, 0xea)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12GraphicsCommandList6"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12GraphicsCommandList6Test()
    {
        Assert.That(
            IID_ID3D12GraphicsCommandList6,
            Is.EqualTo(
                new Guid(0xc3827890, 0xe548, 0x4cfa, 0x96, 0xcf, 0x56, 0x89, 0xa9, 0x37, 0x0f, 0x80)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12GraphicsCommandList7"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12GraphicsCommandList7Test()
    {
        Assert.That(
            IID_ID3D12GraphicsCommandList7,
            Is.EqualTo(
                new Guid(0xdd171223, 0x8b61, 0x4769, 0x90, 0xe3, 0x16, 0x0c, 0xcd, 0xe4, 0xe2, 0xc1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12GraphicsCommandList8"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12GraphicsCommandList8Test()
    {
        Assert.That(
            IID_ID3D12GraphicsCommandList8,
            Is.EqualTo(
                new Guid(0xee936ef9, 0x599d, 0x4d28, 0x93, 0x8e, 0x23, 0xc4, 0xad, 0x05, 0xce, 0x51)
            )
        );
    }
}
