// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.BHID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BHID"/> class.</summary>
public static partial class BHIDTests
{
    /// <summary>Validates that the value of the <see cref = "BHID_SFObject"/> property is correct.</summary>
    [Test]
    public static void BHID_SFObjectTest()
    {
        Assert.That(BHID_SFObject, Is.EqualTo(new Guid(0x3981e224, 0xf559, 0x11d3, 0x8e, 0x3a, 0x00, 0xc0, 0x4f, 0x68, 0x37, 0xd5)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_SFUIObject"/> property is correct.</summary>
    [Test]
    public static void BHID_SFUIObjectTest()
    {
        Assert.That(BHID_SFUIObject, Is.EqualTo(new Guid(0x3981e225, 0xf559, 0x11d3, 0x8e, 0x3a, 0x00, 0xc0, 0x4f, 0x68, 0x37, 0xd5)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_SFViewObject"/> property is correct.</summary>
    [Test]
    public static void BHID_SFViewObjectTest()
    {
        Assert.That(BHID_SFViewObject, Is.EqualTo(new Guid(0x3981e226, 0xf559, 0x11d3, 0x8e, 0x3a, 0x00, 0xc0, 0x4f, 0x68, 0x37, 0xd5)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_Storage"/> property is correct.</summary>
    [Test]
    public static void BHID_StorageTest()
    {
        Assert.That(BHID_Storage, Is.EqualTo(new Guid(0x3981e227, 0xf559, 0x11d3, 0x8e, 0x3a, 0x00, 0xc0, 0x4f, 0x68, 0x37, 0xd5)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_Stream"/> property is correct.</summary>
    [Test]
    public static void BHID_StreamTest()
    {
        Assert.That(BHID_Stream, Is.EqualTo(new Guid(0x1cebb3ab, 0x7c10, 0x499a, 0xa4, 0x17, 0x92, 0xca, 0x16, 0xc4, 0xcb, 0x83)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_RandomAccessStream"/> property is correct.</summary>
    [Test]
    public static void BHID_RandomAccessStreamTest()
    {
        Assert.That(BHID_RandomAccessStream, Is.EqualTo(new Guid(0xf16fc93b, 0x77ae, 0x4cfe, 0xbd, 0xa7, 0xa8, 0x66, 0xee, 0xa6, 0x87, 0x8d)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_LinkTargetItem"/> property is correct.</summary>
    [Test]
    public static void BHID_LinkTargetItemTest()
    {
        Assert.That(BHID_LinkTargetItem, Is.EqualTo(new Guid(0x3981e228, 0xf559, 0x11d3, 0x8e, 0x3a, 0x00, 0xc0, 0x4f, 0x68, 0x37, 0xd5)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_StorageEnum"/> property is correct.</summary>
    [Test]
    public static void BHID_StorageEnumTest()
    {
        Assert.That(BHID_StorageEnum, Is.EqualTo(new Guid(0x4621a4e3, 0xf0d6, 0x4773, 0x8a, 0x9c, 0x46, 0xe7, 0x7b, 0x17, 0x48, 0x40)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_Transfer"/> property is correct.</summary>
    [Test]
    public static void BHID_TransferTest()
    {
        Assert.That(BHID_Transfer, Is.EqualTo(new Guid(0xd5e346a1, 0xf753, 0x4932, 0xb4, 0x3, 0x45, 0x74, 0x80, 0xe, 0x24, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_PropertyStore"/> property is correct.</summary>
    [Test]
    public static void BHID_PropertyStoreTest()
    {
        Assert.That(BHID_PropertyStore, Is.EqualTo(new Guid(0x0384e1a4, 0x1523, 0x439c, 0xa4, 0xc8, 0xab, 0x91, 0x10, 0x52, 0xf5, 0x86)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_ThumbnailHandler"/> property is correct.</summary>
    [Test]
    public static void BHID_ThumbnailHandlerTest()
    {
        Assert.That(BHID_ThumbnailHandler, Is.EqualTo(new Guid(0x7b2e650a, 0x8e20, 0x4f4a, 0xb0, 0x9e, 0x65, 0x97, 0xaf, 0xc7, 0x2f, 0xb0)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_EnumItems"/> property is correct.</summary>
    [Test]
    public static void BHID_EnumItemsTest()
    {
        Assert.That(BHID_EnumItems, Is.EqualTo(new Guid(0x94f60519, 0x2850, 0x4924, 0xaa, 0x5a, 0xd1, 0x5e, 0x84, 0x86, 0x80, 0x39)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_DataObject"/> property is correct.</summary>
    [Test]
    public static void BHID_DataObjectTest()
    {
        Assert.That(BHID_DataObject, Is.EqualTo(new Guid(0xb8c0bd9f, 0xed24, 0x455c, 0x83, 0xe6, 0xd5, 0x39, 0xc, 0x4f, 0xe8, 0xc4)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_AssociationArray"/> property is correct.</summary>
    [Test]
    public static void BHID_AssociationArrayTest()
    {
        Assert.That(BHID_AssociationArray, Is.EqualTo(new Guid(0xbea9ef17, 0x82f1, 0x4f60, 0x92, 0x84, 0x4f, 0x8d, 0xb7, 0x5c, 0x3b, 0xe9)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_Filter"/> property is correct.</summary>
    [Test]
    public static void BHID_FilterTest()
    {
        Assert.That(BHID_Filter, Is.EqualTo(new Guid(0x38d08778, 0xf557, 0x4690, 0x9e, 0xbf, 0xba, 0x54, 0x70, 0x6a, 0xd8, 0xf7)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_EnumAssocHandlers"/> property is correct.</summary>
    [Test]
    public static void BHID_EnumAssocHandlersTest()
    {
        Assert.That(BHID_EnumAssocHandlers, Is.EqualTo(new Guid(0xb8ab0b9c, 0xc2ec, 0x4f7a, 0x91, 0x8d, 0x31, 0x49, 0x00, 0xe6, 0x28, 0x0a)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_StorageItem"/> property is correct.</summary>
    [Test]
    public static void BHID_StorageItemTest()
    {
        Assert.That(BHID_StorageItem, Is.EqualTo(new Guid(0x404e2109, 0x77d2, 0x4699, 0xa5, 0xa0, 0x4f, 0xdf, 0x10, 0xdb, 0x98, 0x37)));
    }

    /// <summary>Validates that the value of the <see cref = "BHID_FilePlaceholder"/> property is correct.</summary>
    [Test]
    public static void BHID_FilePlaceholderTest()
    {
        Assert.That(BHID_FilePlaceholder, Is.EqualTo(new Guid(0x8677dceb, 0xaae0, 0x4005, 0x8d, 0x3d, 0x54, 0x7f, 0xa8, 0x52, 0xf8, 0x25)));
    }
}