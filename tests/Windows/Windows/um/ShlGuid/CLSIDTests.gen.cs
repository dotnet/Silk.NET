// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_NetworkDomain"/> property is correct.</summary>
    [Test]
    public static void CLSID_NetworkDomainTest()
    {
        Assert.That(CLSID_NetworkDomain, Is.EqualTo(new Guid(0x46e06680, 0x4bf0, 0x11d1, 0x83, 0xee, 0x00, 0xa0, 0xc9, 0x0d, 0xc8, 0x49)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_NetworkServer"/> property is correct.</summary>
    [Test]
    public static void CLSID_NetworkServerTest()
    {
        Assert.That(CLSID_NetworkServer, Is.EqualTo(new Guid(0xc0542a90, 0x4bf0, 0x11d1, 0x83, 0xee, 0x00, 0xa0, 0xc9, 0x0d, 0xc8, 0x49)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_NetworkShare"/> property is correct.</summary>
    [Test]
    public static void CLSID_NetworkShareTest()
    {
        Assert.That(CLSID_NetworkShare, Is.EqualTo(new Guid(0x54a754c0, 0x4bf0, 0x11d1, 0x83, 0xee, 0x00, 0xa0, 0xc9, 0x0d, 0xc8, 0x49)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MyComputer"/> property is correct.</summary>
    [Test]
    public static void CLSID_MyComputerTest()
    {
        Assert.That(CLSID_MyComputer, Is.EqualTo(new Guid(0x20D04FE0, 0x3AEA, 0x1069, 0xA2, 0xD8, 0x08, 0x00, 0x2B, 0x30, 0x30, 0x9D)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_Internet"/> property is correct.</summary>
    [Test]
    public static void CLSID_InternetTest()
    {
        Assert.That(CLSID_Internet, Is.EqualTo(new Guid(0x871C5380, 0x42A0, 0x1069, 0xA2, 0xEA, 0x08, 0x00, 0x2B, 0x30, 0x30, 0x9D)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_RecycleBin"/> property is correct.</summary>
    [Test]
    public static void CLSID_RecycleBinTest()
    {
        Assert.That(CLSID_RecycleBin, Is.EqualTo(new Guid(0x645FF040, 0x5081, 0x101B, 0x9F, 0x08, 0x00, 0xAA, 0x00, 0x2F, 0x95, 0x4E)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ControlPanel"/> property is correct.</summary>
    [Test]
    public static void CLSID_ControlPanelTest()
    {
        Assert.That(CLSID_ControlPanel, Is.EqualTo(new Guid(0x21EC2020, 0x3AEA, 0x1069, 0xA2, 0xDD, 0x08, 0x00, 0x2B, 0x30, 0x30, 0x9D)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_Printers"/> property is correct.</summary>
    [Test]
    public static void CLSID_PrintersTest()
    {
        Assert.That(CLSID_Printers, Is.EqualTo(new Guid(0x2227A280, 0x3AEA, 0x1069, 0xA2, 0xDE, 0x08, 0x00, 0x2B, 0x30, 0x30, 0x9D)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MyDocuments"/> property is correct.</summary>
    [Test]
    public static void CLSID_MyDocumentsTest()
    {
        Assert.That(CLSID_MyDocuments, Is.EqualTo(new Guid(0x450d8fba, 0xad25, 0x11d0, 0x98, 0xa8, 0x08, 0x00, 0x36, 0x1b, 0x11, 0x03)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FolderShortcut"/> property is correct.</summary>
    [Test]
    public static void CLSID_FolderShortcutTest()
    {
        Assert.That(CLSID_FolderShortcut, Is.EqualTo(new Guid(0x0AFACED1, 0xE828, 0x11D1, 0x91, 0x87, 0xB5, 0x32, 0xF1, 0xE9, 0x57, 0x5D)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CFSIconOverlayManager"/> property is correct.</summary>
    [Test]
    public static void CLSID_CFSIconOverlayManagerTest()
    {
        Assert.That(CLSID_CFSIconOverlayManager, Is.EqualTo(new Guid(0x63B51F81, 0xC868, 0x11D0, 0x99, 0x9C, 0x00, 0xC0, 0x4F, 0xD6, 0x55, 0xE1)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MenuBand"/> property is correct.</summary>
    [Test]
    public static void CLSID_MenuBandTest()
    {
        Assert.That(CLSID_MenuBand, Is.EqualTo(new Guid(0x5b4dae26, 0xb807, 0x11d0, 0x98, 0x15, 0x0, 0xc0, 0x4f, 0xd9, 0x19, 0x72)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CUrlHistory"/> property is correct.</summary>
    [Test]
    public static void CLSID_CUrlHistoryTest()
    {
        Assert.That(CLSID_CUrlHistory, Is.EqualTo(new Guid(0x3C374A40, 0xBAE4, 0x11CF, 0xBF, 0x7D, 0x00, 0xAA, 0x00, 0x69, 0x46, 0xEE)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CURLSearchHook"/> property is correct.</summary>
    [Test]
    public static void CLSID_CURLSearchHookTest()
    {
        Assert.That(CLSID_CURLSearchHook, Is.EqualTo(new Guid(0xCFBFAE00, 0x17A6, 0x11D0, 0x99, 0xCB, 0x00, 0xC0, 0x4F, 0xD6, 0x44, 0x97)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AutoComplete"/> property is correct.</summary>
    [Test]
    public static void CLSID_AutoCompleteTest()
    {
        Assert.That(CLSID_AutoComplete, Is.EqualTo(new Guid(0x00BB2763, 0x6A77, 0x11D0, 0xA5, 0x35, 0x00, 0xC0, 0x4F, 0xD7, 0xD0, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ACLHistory"/> property is correct.</summary>
    [Test]
    public static void CLSID_ACLHistoryTest()
    {
        Assert.That(CLSID_ACLHistory, Is.EqualTo(new Guid(0x00BB2764, 0x6A77, 0x11D0, 0xA5, 0x35, 0x00, 0xC0, 0x4F, 0xD7, 0xD0, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ACListISF"/> property is correct.</summary>
    [Test]
    public static void CLSID_ACListISFTest()
    {
        Assert.That(CLSID_ACListISF, Is.EqualTo(new Guid(0x03C036F1, 0xA186, 0x11D0, 0x82, 0x4A, 0x00, 0xAA, 0x00, 0x5B, 0x43, 0x83)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ACLMRU"/> property is correct.</summary>
    [Test]
    public static void CLSID_ACLMRUTest()
    {
        Assert.That(CLSID_ACLMRU, Is.EqualTo(new Guid(0x6756a641, 0xde71, 0x11d0, 0x83, 0x1b, 0x0, 0xaa, 0x0, 0x5b, 0x43, 0x83)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ACLMulti"/> property is correct.</summary>
    [Test]
    public static void CLSID_ACLMultiTest()
    {
        Assert.That(CLSID_ACLMulti, Is.EqualTo(new Guid(0x00BB2765, 0x6A77, 0x11D0, 0xA5, 0x35, 0x00, 0xC0, 0x4F, 0xD7, 0xD0, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ACLCustomMRU"/> property is correct.</summary>
    [Test]
    public static void CLSID_ACLCustomMRUTest()
    {
        Assert.That(CLSID_ACLCustomMRU, Is.EqualTo(new Guid(0x6935db93, 0x21e8, 0x4ccc, 0xbe, 0xb9, 0x9f, 0xe3, 0xc7, 0x7a, 0x29, 0x7a)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ProgressDialog"/> property is correct.</summary>
    [Test]
    public static void CLSID_ProgressDialogTest()
    {
        Assert.That(CLSID_ProgressDialog, Is.EqualTo(new Guid(0xf8383852, 0xfcd3, 0x11d1, 0xa6, 0xb9, 0x0, 0x60, 0x97, 0xdf, 0x5b, 0xd4)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FileTypes"/> property is correct.</summary>
    [Test]
    public static void CLSID_FileTypesTest()
    {
        Assert.That(CLSID_FileTypes, Is.EqualTo(new Guid(0xB091E540, 0x83E3, 0x11CF, 0xA7, 0x13, 0x00, 0x20, 0xAF, 0xD7, 0x97, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ActiveDesktop"/> property is correct.</summary>
    [Test]
    public static void CLSID_ActiveDesktopTest()
    {
        Assert.That(CLSID_ActiveDesktop, Is.EqualTo(new Guid(0x75048700, 0xEF1F, 0x11D0, 0x98, 0x88, 0x00, 0x60, 0x97, 0xDE, 0xAC, 0xF9)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_QueryAssociations"/> property is correct.</summary>
    [Test]
    public static void CLSID_QueryAssociationsTest()
    {
        Assert.That(CLSID_QueryAssociations, Is.EqualTo(new Guid(0xa07034fd, 0x6caa, 0x4954, 0xac, 0x3f, 0x97, 0xa2, 0x72, 0x16, 0xf9, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_LinkColumnProvider"/> property is correct.</summary>
    [Test]
    public static void CLSID_LinkColumnProviderTest()
    {
        Assert.That(CLSID_LinkColumnProvider, Is.EqualTo(new Guid(0x24f14f02, 0x7b1c, 0x11d1, 0x83, 0x8f, 0x0, 0x0, 0xf8, 0x4, 0x61, 0xcf)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_InternetButtons"/> property is correct.</summary>
    [Test]
    public static void CLSID_InternetButtonsTest()
    {
        Assert.That(CLSID_InternetButtons, Is.EqualTo(new Guid(0x1E796980, 0x9CC5, 0x11D1, 0xA8, 0x3F, 0x00, 0xC0, 0x4F, 0xC9, 0x9D, 0x61)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MSOButtons"/> property is correct.</summary>
    [Test]
    public static void CLSID_MSOButtonsTest()
    {
        Assert.That(CLSID_MSOButtons, Is.EqualTo(new Guid(0x178f34b8, 0xa282, 0x11d2, 0x86, 0xc5, 0x0, 0xc0, 0x4f, 0x8e, 0xea, 0x99)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ToolbarExtButtons"/> property is correct.</summary>
    [Test]
    public static void CLSID_ToolbarExtButtonsTest()
    {
        Assert.That(CLSID_ToolbarExtButtons, Is.EqualTo(new Guid(0x2ce4b5d8, 0xa28f, 0x11d2, 0x86, 0xc5, 0x0, 0xc0, 0x4f, 0x8e, 0xea, 0x99)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DarwinAppPublisher"/> property is correct.</summary>
    [Test]
    public static void CLSID_DarwinAppPublisherTest()
    {
        Assert.That(CLSID_DarwinAppPublisher, Is.EqualTo(new Guid(0xCFCCC7A0, 0xA282, 0x11D1, 0x90, 0x82, 0x00, 0x60, 0x08, 0x05, 0x93, 0x82)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DocHostUIHandler"/> property is correct.</summary>
    [Test]
    public static void CLSID_DocHostUIHandlerTest()
    {
        Assert.That(CLSID_DocHostUIHandler, Is.EqualTo(new Guid(0x7057e952, 0xbd1b, 0x11d1, 0x89, 0x19, 0x0, 0xc0, 0x4f, 0xc2, 0xc8, 0x36)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_HWShellExecute"/> property is correct.</summary>
    [Test]
    public static void CLSID_HWShellExecuteTest()
    {
        Assert.That(CLSID_HWShellExecute, Is.EqualTo(new Guid(0xffb8655f, 0x81b9, 0x4fce, 0xb8, 0x9c, 0x9a, 0x6b, 0xa7, 0x6d, 0x13, 0xe7)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DragDropHelper"/> property is correct.</summary>
    [Test]
    public static void CLSID_DragDropHelperTest()
    {
        Assert.That(CLSID_DragDropHelper, Is.EqualTo(new Guid(0x4657278a, 0x411b, 0x11d2, 0x83, 0x9a, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0xd0)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CAnchorBrowsePropertyPage"/> property is correct.</summary>
    [Test]
    public static void CLSID_CAnchorBrowsePropertyPageTest()
    {
        Assert.That(CLSID_CAnchorBrowsePropertyPage, Is.EqualTo(new Guid(0x3050f3BB, 0x98b5, 0x11cf, 0xbb, 0x82, 0x00, 0xaa, 0x00, 0xbd, 0xce, 0x0b)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CImageBrowsePropertyPage"/> property is correct.</summary>
    [Test]
    public static void CLSID_CImageBrowsePropertyPageTest()
    {
        Assert.That(CLSID_CImageBrowsePropertyPage, Is.EqualTo(new Guid(0x3050f3B3, 0x98b5, 0x11cf, 0xbb, 0x82, 0x00, 0xaa, 0x00, 0xbd, 0xce, 0x0b)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CDocBrowsePropertyPage"/> property is correct.</summary>
    [Test]
    public static void CLSID_CDocBrowsePropertyPageTest()
    {
        Assert.That(CLSID_CDocBrowsePropertyPage, Is.EqualTo(new Guid(0x3050f3B4, 0x98b5, 0x11cf, 0xbb, 0x82, 0x00, 0xaa, 0x00, 0xbd, 0xce, 0x0b)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FolderItem"/> property is correct.</summary>
    [Test]
    public static void CLSID_FolderItemTest()
    {
        Assert.That(CLSID_FolderItem, Is.EqualTo(new Guid(0xfef10fa2, 0x355e, 0x4e06, 0x93, 0x81, 0x9b, 0x24, 0xd7, 0xf7, 0xcc, 0x88)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FolderItemsMultiLevel"/> property is correct.</summary>
    [Test]
    public static void CLSID_FolderItemsMultiLevelTest()
    {
        Assert.That(CLSID_FolderItemsMultiLevel, Is.EqualTo(new Guid(0x53c74826, 0xab99, 0x4d33, 0xac, 0xa4, 0x31, 0x17, 0xf5, 0x1d, 0x37, 0x88)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_NewMenu"/> property is correct.</summary>
    [Test]
    public static void CLSID_NewMenuTest()
    {
        Assert.That(CLSID_NewMenu, Is.EqualTo(new Guid(0xd969a300, 0xe7ff, 0x11d0, 0xa9, 0x3b, 0x0, 0xa0, 0xc9, 0xf, 0x27, 0x19)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_QuickLinks"/> property is correct.</summary>
    [Test]
    public static void CLSID_QuickLinksTest()
    {
        Assert.That(CLSID_QuickLinks, Is.EqualTo(new Guid(0xe5cbf21, 0xd15f, 0x11d0, 0x83, 0x1, 0x0, 0xaa, 0x0, 0x5b, 0x43, 0x83)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ISFBand"/> property is correct.</summary>
    [Test]
    public static void CLSID_ISFBandTest()
    {
        Assert.That(CLSID_ISFBand, Is.EqualTo(new Guid(0xD82BE2B0, 0x5764, 0x11D0, 0xA9, 0x6E, 0x00, 0xC0, 0x4F, 0xD7, 0x05, 0xA2)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ShellFldSetExt"/> property is correct.</summary>
    [Test]
    public static void CLSID_ShellFldSetExtTest()
    {
        Assert.That(CLSID_ShellFldSetExt, Is.EqualTo(new Guid(0x6D5313C0, 0x8C62, 0x11D1, 0xB2, 0xCD, 0x00, 0x60, 0x97, 0xDF, 0x8C, 0x11)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MenuToolbarBase"/> property is correct.</summary>
    [Test]
    public static void CLSID_MenuToolbarBaseTest()
    {
        Assert.That(CLSID_MenuToolbarBase, Is.EqualTo(new Guid(0x40b96610, 0xb522, 0x11d1, 0xb3, 0xb4, 0x0, 0xaa, 0x0, 0x6e, 0xfd, 0xe7)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MenuBandSite"/> property is correct.</summary>
    [Test]
    public static void CLSID_MenuBandSiteTest()
    {
        Assert.That(CLSID_MenuBandSite, Is.EqualTo(new Guid(0xe13ef4e4, 0xd2f2, 0x11d0, 0x98, 0x16, 0x0, 0xc0, 0x4f, 0xd9, 0x19, 0x72)));
    }
}