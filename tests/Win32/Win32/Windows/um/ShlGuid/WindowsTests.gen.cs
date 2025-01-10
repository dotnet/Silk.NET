// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "CGID_Explorer"/> property is correct.</summary>

    [Test]
    public static void CGID_ExplorerTest()
    {
        Assert.That(
            CGID_Explorer,
            Is.EqualTo(new Guid(0x000214D0, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46))
        );
    }

    /// <summary>Validates that the value of the <see cref = "CGID_ShellDocView"/> property is correct.</summary>

    [Test]
    public static void CGID_ShellDocViewTest()
    {
        Assert.That(
            CGID_ShellDocView,
            Is.EqualTo(new Guid(0x000214D1, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46))
        );
    }

    /// <summary>Validates that the value of the <see cref = "CGID_ShellServiceObject"/> property is correct.</summary>

    [Test]
    public static void CGID_ShellServiceObjectTest()
    {
        Assert.That(
            CGID_ShellServiceObject,
            Is.EqualTo(new Guid(0x000214D2, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46))
        );
    }

    /// <summary>Validates that the value of the <see cref = "CGID_ExplorerBarDoc"/> property is correct.</summary>

    [Test]
    public static void CGID_ExplorerBarDocTest()
    {
        Assert.That(
            CGID_ExplorerBarDoc,
            Is.EqualTo(new Guid(0x000214D3, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46))
        );
    }

    /// <summary>Validates that the value of the <see cref = "CGID_DefView"/> property is correct.</summary>

    [Test]
    public static void CGID_DefViewTest()
    {
        Assert.That(
            CGID_DefView,
            Is.EqualTo(
                new Guid(0x4af07f10, 0xd231, 0x11d0, 0xb9, 0x42, 0x0, 0xa0, 0xc9, 0x3, 0x12, 0xe1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "VID_LargeIcons"/> property is correct.</summary>

    [Test]
    public static void VID_LargeIconsTest()
    {
        Assert.That(
            VID_LargeIcons,
            Is.EqualTo(
                new Guid(0x0057D0E0, 0x3573, 0x11CF, 0xAE, 0x69, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "VID_SmallIcons"/> property is correct.</summary>

    [Test]
    public static void VID_SmallIconsTest()
    {
        Assert.That(
            VID_SmallIcons,
            Is.EqualTo(
                new Guid(0x089000C0, 0x3573, 0x11CF, 0xAE, 0x69, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "VID_List"/> property is correct.</summary>

    [Test]
    public static void VID_ListTest()
    {
        Assert.That(
            VID_List,
            Is.EqualTo(
                new Guid(0x0E1FA5E0, 0x3573, 0x11CF, 0xAE, 0x69, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "VID_Details"/> property is correct.</summary>

    [Test]
    public static void VID_DetailsTest()
    {
        Assert.That(
            VID_Details,
            Is.EqualTo(
                new Guid(0x137E7700, 0x3573, 0x11CF, 0xAE, 0x69, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "VID_Tile"/> property is correct.</summary>

    [Test]
    public static void VID_TileTest()
    {
        Assert.That(
            VID_Tile,
            Is.EqualTo(
                new Guid(0x65f125e5, 0x7be1, 0x4810, 0xba, 0x9d, 0xd2, 0x71, 0xc8, 0x43, 0x2c, 0xe3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "VID_Content"/> property is correct.</summary>

    [Test]
    public static void VID_ContentTest()
    {
        Assert.That(
            VID_Content,
            Is.EqualTo(
                new Guid(0x30c2c434, 0x0889, 0x4c8d, 0x98, 0x5d, 0xa9, 0xf7, 0x18, 0x30, 0xb0, 0xa9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "VID_Thumbnails"/> property is correct.</summary>

    [Test]
    public static void VID_ThumbnailsTest()
    {
        Assert.That(
            VID_Thumbnails,
            Is.EqualTo(
                new Guid(0x8bebb290, 0x52d0, 0x11d0, 0xb7, 0xf4, 0x0, 0xc0, 0x4f, 0xd7, 0x6, 0xec)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "VID_ThumbStrip"/> property is correct.</summary>

    [Test]
    public static void VID_ThumbStripTest()
    {
        Assert.That(
            VID_ThumbStrip,
            Is.EqualTo(
                new Guid(0x8EEFA624, 0xD1E9, 0x445B, 0x94, 0xB7, 0x74, 0xFB, 0xCE, 0x2E, 0xA1, 0x1A)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CGID_ShortCut"/> property is correct.</summary>

    [Test]
    public static void CGID_ShortCutTest()
    {
        Assert.That(
            CGID_ShortCut,
            Is.EqualTo(
                new Guid(0x93a68750, 0x951a, 0x11d1, 0x94, 0x6f, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CGID_MENUDESKBAR"/> property is correct.</summary>

    [Test]
    public static void CGID_MENUDESKBARTest()
    {
        Assert.That(
            CGID_MENUDESKBAR,
            Is.EqualTo(
                new Guid(0x5c9f0a12, 0x959e, 0x11d0, 0xa3, 0xa4, 0x0, 0xa0, 0xc9, 0x8, 0x26, 0x36)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CPFG_LOGON_USERNAME"/> property is correct.</summary>

    [Test]
    public static void CPFG_LOGON_USERNAMETest()
    {
        Assert.That(
            CPFG_LOGON_USERNAME,
            Is.EqualTo(
                new Guid(0xda15bbe8, 0x954d, 0x4fd3, 0xb0, 0xf4, 0x1f, 0xb5, 0xb9, 0x0b, 0x17, 0x4b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CPFG_LOGON_PASSWORD"/> property is correct.</summary>

    [Test]
    public static void CPFG_LOGON_PASSWORDTest()
    {
        Assert.That(
            CPFG_LOGON_PASSWORD,
            Is.EqualTo(
                new Guid(0x60624cfa, 0xa477, 0x47b1, 0x8a, 0x8e, 0x3a, 0x4a, 0x19, 0x98, 0x18, 0x27)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CPFG_SMARTCARD_USERNAME"/> property is correct.</summary>

    [Test]
    public static void CPFG_SMARTCARD_USERNAMETest()
    {
        Assert.That(
            CPFG_SMARTCARD_USERNAME,
            Is.EqualTo(
                new Guid(0x3e1ecf69, 0x568c, 0x4d96, 0x9d, 0x59, 0x46, 0x44, 0x41, 0x74, 0xe2, 0xd6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CPFG_SMARTCARD_PIN"/> property is correct.</summary>

    [Test]
    public static void CPFG_SMARTCARD_PINTest()
    {
        Assert.That(
            CPFG_SMARTCARD_PIN,
            Is.EqualTo(
                new Guid(0x4fe5263b, 0x9181, 0x46c1, 0xb0, 0xa4, 0x9d, 0xed, 0xd4, 0xdb, 0x7d, 0xea)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CPFG_CREDENTIAL_PROVIDER_LOGO"/> property is correct.</summary>

    [Test]
    public static void CPFG_CREDENTIAL_PROVIDER_LOGOTest()
    {
        Assert.That(
            CPFG_CREDENTIAL_PROVIDER_LOGO,
            Is.EqualTo(
                new Guid(0x2d837775, 0xf6cd, 0x464e, 0xa7, 0x45, 0x48, 0x2f, 0xd0, 0xb4, 0x74, 0x93)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CPFG_CREDENTIAL_PROVIDER_LABEL"/> property is correct.</summary>

    [Test]
    public static void CPFG_CREDENTIAL_PROVIDER_LABELTest()
    {
        Assert.That(
            CPFG_CREDENTIAL_PROVIDER_LABEL,
            Is.EqualTo(
                new Guid(0x286bbff3, 0xbad4, 0x438f, 0xb0, 0x7, 0x79, 0xb7, 0x26, 0x7c, 0x3d, 0x48)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CPFG_STANDALONE_SUBMIT_BUTTON"/> property is correct.</summary>

    [Test]
    public static void CPFG_STANDALONE_SUBMIT_BUTTONTest()
    {
        Assert.That(
            CPFG_STANDALONE_SUBMIT_BUTTON,
            Is.EqualTo(
                new Guid(0x0b7b0ad8, 0xcc36, 0x4d59, 0x80, 0x2b, 0x82, 0xf7, 0x14, 0xfa, 0x70, 0x22)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CPFG_STYLE_LINK_AS_BUTTON"/> property is correct.</summary>

    [Test]
    public static void CPFG_STYLE_LINK_AS_BUTTONTest()
    {
        Assert.That(
            CPFG_STYLE_LINK_AS_BUTTON,
            Is.EqualTo(
                new Guid(0x088fa508, 0x94a6, 0x4430, 0xa4, 0xcb, 0x6f, 0xc6, 0xe3, 0xc0, 0xb9, 0xe2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "ItemCount_Property_GUID"/> property is correct.</summary>

    [Test]
    public static void ItemCount_Property_GUIDTest()
    {
        Assert.That(
            ItemCount_Property_GUID,
            Is.EqualTo(
                new Guid(0xabbf5c45, 0x5ccc, 0x47b7, 0xbb, 0x4e, 0x87, 0xcb, 0x87, 0xbb, 0xd1, 0x62)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "SelectedItemCount_Property_GUID"/> property is correct.</summary>

    [Test]
    public static void SelectedItemCount_Property_GUIDTest()
    {
        Assert.That(
            SelectedItemCount_Property_GUID,
            Is.EqualTo(
                new Guid(0x8fe316d2, 0xe52, 0x460a, 0x9c, 0x1e, 0x48, 0xf2, 0x73, 0xd4, 0x70, 0xa3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "ItemIndex_Property_GUID"/> property is correct.</summary>

    [Test]
    public static void ItemIndex_Property_GUIDTest()
    {
        Assert.That(
            ItemIndex_Property_GUID,
            Is.EqualTo(
                new Guid(0x92a053da, 0x2969, 0x4021, 0xbf, 0x27, 0x51, 0x4c, 0xfc, 0x2e, 0x4a, 0x69)
            )
        );
    }
}
