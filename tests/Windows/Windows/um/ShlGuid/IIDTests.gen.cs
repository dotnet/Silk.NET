// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_INewShortcutHookA"/> property is correct.</summary>
    [Test]
    public static void IID_INewShortcutHookATest()
    {
        Assert.That(IID_INewShortcutHookA, Is.EqualTo(new Guid(0x000214E1, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellBrowser"/> property is correct.</summary>
    [Test]
    public static void IID_IShellBrowserTest()
    {
        Assert.That(IID_IShellBrowser, Is.EqualTo(new Guid(0x000214E2, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellView"/> property is correct.</summary>
    [Test]
    public static void IID_IShellViewTest()
    {
        Assert.That(IID_IShellView, Is.EqualTo(new Guid(0x000214E3, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IContextMenu"/> property is correct.</summary>
    [Test]
    public static void IID_IContextMenuTest()
    {
        Assert.That(IID_IContextMenu, Is.EqualTo(new Guid(0x000214E4, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellIcon"/> property is correct.</summary>
    [Test]
    public static void IID_IShellIconTest()
    {
        Assert.That(IID_IShellIcon, Is.EqualTo(new Guid(0x000214E5, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellFolder"/> property is correct.</summary>
    [Test]
    public static void IID_IShellFolderTest()
    {
        Assert.That(IID_IShellFolder, Is.EqualTo(new Guid(0x000214E6, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellExtInit"/> property is correct.</summary>
    [Test]
    public static void IID_IShellExtInitTest()
    {
        Assert.That(IID_IShellExtInit, Is.EqualTo(new Guid(0x000214E8, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellPropSheetExt"/> property is correct.</summary>
    [Test]
    public static void IID_IShellPropSheetExtTest()
    {
        Assert.That(IID_IShellPropSheetExt, Is.EqualTo(new Guid(0x000214E9, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IPersistFolder"/> property is correct.</summary>
    [Test]
    public static void IID_IPersistFolderTest()
    {
        Assert.That(IID_IPersistFolder, Is.EqualTo(new Guid(0x000214EA, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IExtractIconA"/> property is correct.</summary>
    [Test]
    public static void IID_IExtractIconATest()
    {
        Assert.That(IID_IExtractIconA, Is.EqualTo(new Guid(0x000214EB, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellDetails"/> property is correct.</summary>
    [Test]
    public static void IID_IShellDetailsTest()
    {
        Assert.That(IID_IShellDetails, Is.EqualTo(new Guid(0x000214EC, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellLinkA"/> property is correct.</summary>
    [Test]
    public static void IID_IShellLinkATest()
    {
        Assert.That(IID_IShellLinkA, Is.EqualTo(new Guid(0x000214EE, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ICopyHookA"/> property is correct.</summary>
    [Test]
    public static void IID_ICopyHookATest()
    {
        Assert.That(IID_ICopyHookA, Is.EqualTo(new Guid(0x000214EF, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IFileViewerA"/> property is correct.</summary>
    [Test]
    public static void IID_IFileViewerATest()
    {
        Assert.That(IID_IFileViewerA, Is.EqualTo(new Guid(0x000214F0, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ICommDlgBrowser"/> property is correct.</summary>
    [Test]
    public static void IID_ICommDlgBrowserTest()
    {
        Assert.That(IID_ICommDlgBrowser, Is.EqualTo(new Guid(0x000214F1, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IEnumIDList"/> property is correct.</summary>
    [Test]
    public static void IID_IEnumIDListTest()
    {
        Assert.That(IID_IEnumIDList, Is.EqualTo(new Guid(0x000214F2, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IFileViewerSite"/> property is correct.</summary>
    [Test]
    public static void IID_IFileViewerSiteTest()
    {
        Assert.That(IID_IFileViewerSite, Is.EqualTo(new Guid(0x000214F3, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IContextMenu2"/> property is correct.</summary>
    [Test]
    public static void IID_IContextMenu2Test()
    {
        Assert.That(IID_IContextMenu2, Is.EqualTo(new Guid(0x000214F4, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellExecuteHookA"/> property is correct.</summary>
    [Test]
    public static void IID_IShellExecuteHookATest()
    {
        Assert.That(IID_IShellExecuteHookA, Is.EqualTo(new Guid(0x000214F5, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IPropSheetPage"/> property is correct.</summary>
    [Test]
    public static void IID_IPropSheetPageTest()
    {
        Assert.That(IID_IPropSheetPage, Is.EqualTo(new Guid(0x000214F6, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_INewShortcutHookW"/> property is correct.</summary>
    [Test]
    public static void IID_INewShortcutHookWTest()
    {
        Assert.That(IID_INewShortcutHookW, Is.EqualTo(new Guid(0x000214F7, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IFileViewerW"/> property is correct.</summary>
    [Test]
    public static void IID_IFileViewerWTest()
    {
        Assert.That(IID_IFileViewerW, Is.EqualTo(new Guid(0x000214F8, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellLinkW"/> property is correct.</summary>
    [Test]
    public static void IID_IShellLinkWTest()
    {
        Assert.That(IID_IShellLinkW, Is.EqualTo(new Guid(0x000214F9, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IExtractIconW"/> property is correct.</summary>
    [Test]
    public static void IID_IExtractIconWTest()
    {
        Assert.That(IID_IExtractIconW, Is.EqualTo(new Guid(0x000214FA, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellExecuteHookW"/> property is correct.</summary>
    [Test]
    public static void IID_IShellExecuteHookWTest()
    {
        Assert.That(IID_IShellExecuteHookW, Is.EqualTo(new Guid(0x000214FB, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ICopyHookW"/> property is correct.</summary>
    [Test]
    public static void IID_ICopyHookWTest()
    {
        Assert.That(IID_ICopyHookW, Is.EqualTo(new Guid(0x000214FC, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IRemoteComputer"/> property is correct.</summary>
    [Test]
    public static void IID_IRemoteComputerTest()
    {
        Assert.That(IID_IRemoteComputer, Is.EqualTo(new Guid(0x000214FE, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IQueryInfo"/> property is correct.</summary>
    [Test]
    public static void IID_IQueryInfoTest()
    {
        Assert.That(IID_IQueryInfo, Is.EqualTo(new Guid(0x00021500, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IBriefcaseStg"/> property is correct.</summary>
    [Test]
    public static void IID_IBriefcaseStgTest()
    {
        Assert.That(IID_IBriefcaseStg, Is.EqualTo(new Guid(0x8BCE1FA1, 0x0921, 0x101B, 0xB1, 0xFF, 0x00, 0xDD, 0x01, 0x0C, 0xCC, 0x48)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellView2"/> property is correct.</summary>
    [Test]
    public static void IID_IShellView2Test()
    {
        Assert.That(IID_IShellView2, Is.EqualTo(new Guid(0x88E39E80, 0x3578, 0x11CF, 0xAE, 0x69, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IURLSearchHook"/> property is correct.</summary>
    [Test]
    public static void IID_IURLSearchHookTest()
    {
        Assert.That(IID_IURLSearchHook, Is.EqualTo(new Guid(0xAC60F6A0, 0x0FD9, 0x11D0, 0x99, 0xCB, 0x00, 0xC0, 0x4F, 0xD6, 0x44, 0x97)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ISearchContext"/> property is correct.</summary>
    [Test]
    public static void IID_ISearchContextTest()
    {
        Assert.That(IID_ISearchContext, Is.EqualTo(new Guid(0x09F656A2, 0x41AF, 0x480C, 0x88, 0xF7, 0x16, 0xCC, 0x0D, 0x16, 0x46, 0x15)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IURLSearchHook2"/> property is correct.</summary>
    [Test]
    public static void IID_IURLSearchHook2Test()
    {
        Assert.That(IID_IURLSearchHook2, Is.EqualTo(new Guid(0x5ee44da4, 0x6d32, 0x46e3, 0x86, 0xbc, 0x07, 0x54, 0x0d, 0xed, 0xd0, 0xe0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDefViewID"/> property is correct.</summary>
    [Test]
    public static void IID_IDefViewIDTest()
    {
        Assert.That(IID_IDefViewID, Is.EqualTo(new Guid(0x985F64F0, 0xD410, 0x4E02, 0xBE, 0x22, 0xDA, 0x07, 0xF2, 0xB5, 0xC5, 0xE1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDockingWindowSite"/> property is correct.</summary>
    [Test]
    public static void IID_IDockingWindowSiteTest()
    {
        Assert.That(IID_IDockingWindowSite, Is.EqualTo(new Guid(0x2a342fc2, 0x7b26, 0x11d0, 0x8c, 0xa9, 0x0, 0xa0, 0xc9, 0x2d, 0xbf, 0xe8)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDockingWindowFrame"/> property is correct.</summary>
    [Test]
    public static void IID_IDockingWindowFrameTest()
    {
        Assert.That(IID_IDockingWindowFrame, Is.EqualTo(new Guid(0x47d2657a, 0x7b27, 0x11d0, 0x8c, 0xa9, 0x0, 0xa0, 0xc9, 0x2d, 0xbf, 0xe8)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellIconOverlay"/> property is correct.</summary>
    [Test]
    public static void IID_IShellIconOverlayTest()
    {
        Assert.That(IID_IShellIconOverlay, Is.EqualTo(new Guid(0x7D688A70, 0xC613, 0x11D0, 0x99, 0x9B, 0x00, 0xC0, 0x4F, 0xD6, 0x55, 0xE1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellIconOverlayIdentifier"/> property is correct.</summary>
    [Test]
    public static void IID_IShellIconOverlayIdentifierTest()
    {
        Assert.That(IID_IShellIconOverlayIdentifier, Is.EqualTo(new Guid(0x0C6C4200, 0xC589, 0x11D0, 0x99, 0x9A, 0x00, 0xC0, 0x4F, 0xD6, 0x55, 0xE1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ICommDlgBrowser2"/> property is correct.</summary>
    [Test]
    public static void IID_ICommDlgBrowser2Test()
    {
        Assert.That(IID_ICommDlgBrowser2, Is.EqualTo(new Guid(0x10339516, 0x2894, 0x11d2, 0x90, 0x39, 0x0, 0xc0, 0x4f, 0x8e, 0xeb, 0x3e)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellFolderViewCB"/> property is correct.</summary>
    [Test]
    public static void IID_IShellFolderViewCBTest()
    {
        Assert.That(IID_IShellFolderViewCB, Is.EqualTo(new Guid(0x2047E320, 0xF2A9, 0x11CE, 0xAE, 0x65, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellIconOverlayManager"/> property is correct.</summary>
    [Test]
    public static void IID_IShellIconOverlayManagerTest()
    {
        Assert.That(IID_IShellIconOverlayManager, Is.EqualTo(new Guid(0xf10b5e34, 0xdd3b, 0x42a7, 0xaa, 0x7d, 0x2f, 0x4e, 0xc5, 0x4b, 0xb0, 0x9b)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IThumbnailCapture"/> property is correct.</summary>
    [Test]
    public static void IID_IThumbnailCaptureTest()
    {
        Assert.That(IID_IThumbnailCapture, Is.EqualTo(new Guid(0x4ea39266, 0x7211, 0x409f, 0xb6, 0x22, 0xf6, 0x3d, 0xbd, 0x16, 0xc5, 0x33)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellImageStore"/> property is correct.</summary>
    [Test]
    public static void IID_IShellImageStoreTest()
    {
        Assert.That(IID_IShellImageStore, Is.EqualTo(new Guid(0x48c8118c, 0xb924, 0x11d1, 0x98, 0xd5, 0x0, 0xc0, 0x4f, 0xb6, 0x87, 0xda)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IContextMenu3"/> property is correct.</summary>
    [Test]
    public static void IID_IContextMenu3Test()
    {
        Assert.That(IID_IContextMenu3, Is.EqualTo(new Guid(0xbcfce0a0, 0xec17, 0x11d0, 0x8d, 0x10, 0x0, 0xa0, 0xc9, 0xf, 0x27, 0x19)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellFolderBand"/> property is correct.</summary>
    [Test]
    public static void IID_IShellFolderBandTest()
    {
        Assert.That(IID_IShellFolderBand, Is.EqualTo(new Guid(0x7fe80cc8, 0xc247, 0x11d0, 0xb9, 0x3a, 0x0, 0xa0, 0xc9, 0x3, 0x12, 0xe1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDefViewFrame"/> property is correct.</summary>
    [Test]
    public static void IID_IDefViewFrameTest()
    {
        Assert.That(IID_IDefViewFrame, Is.EqualTo(new Guid(0x710EB7A0, 0x45ED, 0x11D0, 0x92, 0x4A, 0x00, 0x20, 0xAF, 0xC7, 0xAC, 0x4D)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDiscardableBrowserProperty"/> property is correct.</summary>
    [Test]
    public static void IID_IDiscardableBrowserPropertyTest()
    {
        Assert.That(IID_IDiscardableBrowserProperty, Is.EqualTo(new Guid(0x49c3de7c, 0xd329, 0x11d0, 0xab, 0x73, 0x00, 0xc0, 0x4f, 0xc3, 0x3e, 0x80)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellChangeNotify"/> property is correct.</summary>
    [Test]
    public static void IID_IShellChangeNotifyTest()
    {
        Assert.That(IID_IShellChangeNotify, Is.EqualTo(new Guid(0xD82BE2B1, 0x5764, 0x11D0, 0xA9, 0x6E, 0x00, 0xC0, 0x4F, 0xD7, 0x05, 0xA2)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IObjMgr"/> property is correct.</summary>
    [Test]
    public static void IID_IObjMgrTest()
    {
        Assert.That(IID_IObjMgr, Is.EqualTo(new Guid(0x00BB2761, 0x6A77, 0x11D0, 0xA5, 0x35, 0x00, 0xC0, 0x4F, 0xD7, 0xD0, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IACList"/> property is correct.</summary>
    [Test]
    public static void IID_IACListTest()
    {
        Assert.That(IID_IACList, Is.EqualTo(new Guid(0x77A130B0, 0x94FD, 0x11D0, 0xA5, 0x44, 0x00, 0xC0, 0x4F, 0xD7, 0xd0, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IACList2"/> property is correct.</summary>
    [Test]
    public static void IID_IACList2Test()
    {
        Assert.That(IID_IACList2, Is.EqualTo(new Guid(0x470141a0, 0x5186, 0x11d2, 0xbb, 0xb6, 0x00, 0x60, 0x97, 0x7b, 0x46, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ICurrentWorkingDirectory"/> property is correct.</summary>
    [Test]
    public static void IID_ICurrentWorkingDirectoryTest()
    {
        Assert.That(IID_ICurrentWorkingDirectory, Is.EqualTo(new Guid(0x91956d21, 0x9276, 0x11d1, 0x92, 0x1a, 0x00, 0x60, 0x97, 0xdf, 0x5b, 0xd4)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IProgressDialog"/> property is correct.</summary>
    [Test]
    public static void IID_IProgressDialogTest()
    {
        Assert.That(IID_IProgressDialog, Is.EqualTo(new Guid(0xebbc7c04, 0x315e, 0x11d2, 0xb6, 0x2f, 0x0, 0x60, 0x97, 0xdf, 0x5b, 0xd4)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IActiveDesktop"/> property is correct.</summary>
    [Test]
    public static void IID_IActiveDesktopTest()
    {
        Assert.That(IID_IActiveDesktop, Is.EqualTo(new Guid(0xF490EB00, 0x1240, 0x11D1, 0x98, 0x88, 0x00, 0x60, 0x97, 0xDE, 0xAC, 0xF9)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IActiveDesktopP"/> property is correct.</summary>
    [Test]
    public static void IID_IActiveDesktopPTest()
    {
        Assert.That(IID_IActiveDesktopP, Is.EqualTo(new Guid(0x52502EE0, 0xEC80, 0x11D0, 0x89, 0xAB, 0x00, 0xC0, 0x4F, 0xC2, 0x97, 0x2D)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IADesktopP2"/> property is correct.</summary>
    [Test]
    public static void IID_IADesktopP2Test()
    {
        Assert.That(IID_IADesktopP2, Is.EqualTo(new Guid(0xb22754e2, 0x4574, 0x11d1, 0x98, 0x88, 0x0, 0x60, 0x97, 0xde, 0xac, 0xf9)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ISynchronizedCallBack"/> property is correct.</summary>
    [Test]
    public static void IID_ISynchronizedCallBackTest()
    {
        Assert.That(IID_ISynchronizedCallBack, Is.EqualTo(new Guid(0x74c26041, 0x70d1, 0x11d1, 0xb7, 0x5a, 0x0, 0xa0, 0xc9, 0x5, 0x64, 0xfe)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IQueryAssociations"/> property is correct.</summary>
    [Test]
    public static void IID_IQueryAssociationsTest()
    {
        Assert.That(IID_IQueryAssociations, Is.EqualTo(new Guid(0xc46ca590, 0x3c3f, 0x11d2, 0xbe, 0xe6, 0x00, 0x00, 0xf8, 0x05, 0xca, 0x57)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IColumnProvider"/> property is correct.</summary>
    [Test]
    public static void IID_IColumnProviderTest()
    {
        Assert.That(IID_IColumnProvider, Is.EqualTo(new Guid(0xe8025004, 0x1c42, 0x11d2, 0xbe, 0x2c, 0x0, 0xa0, 0xc9, 0xa8, 0x3d, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_INamedPropertyBag"/> property is correct.</summary>
    [Test]
    public static void IID_INamedPropertyBagTest()
    {
        Assert.That(IID_INamedPropertyBag, Is.EqualTo(new Guid(0xfb700430, 0x952c, 0x11d1, 0x94, 0x6f, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IShellFolder2"/> property is correct.</summary>
    [Test]
    public static void IID_IShellFolder2Test()
    {
        Assert.That(IID_IShellFolder2, Is.EqualTo(new Guid(0x93f2f68c, 0x1d1b, 0x11d3, 0xa3, 0xe, 0x0, 0xc0, 0x4f, 0x79, 0xab, 0xd1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IEnumExtraSearch"/> property is correct.</summary>
    [Test]
    public static void IID_IEnumExtraSearchTest()
    {
        Assert.That(IID_IEnumExtraSearch, Is.EqualTo(new Guid(0xe700be1, 0x9db6, 0x11d1, 0xa1, 0xce, 0x0, 0xc0, 0x4f, 0xd7, 0x5d, 0x13)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IFileSystemBindData"/> property is correct.</summary>
    [Test]
    public static void IID_IFileSystemBindDataTest()
    {
        Assert.That(IID_IFileSystemBindData, Is.EqualTo(new Guid(0x1e18d10, 0x4d8b, 0x11d2, 0x85, 0x5d, 0x0, 0x60, 0x8, 0x5, 0x93, 0x67)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDocViewSite"/> property is correct.</summary>
    [Test]
    public static void IID_IDocViewSiteTest()
    {
        Assert.That(IID_IDocViewSite, Is.EqualTo(new Guid(0x87D605E0, 0xC511, 0x11CF, 0x89, 0xA9, 0x00, 0xA0, 0xC9, 0x05, 0x41, 0x29)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_CDefView"/> property is correct.</summary>
    [Test]
    public static void IID_CDefViewTest()
    {
        Assert.That(IID_CDefView, Is.EqualTo(new Guid(0x4434FF80, 0xEF4C, 0x11CE, 0xAE, 0x65, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IBanneredBar"/> property is correct.</summary>
    [Test]
    public static void IID_IBanneredBarTest()
    {
        Assert.That(IID_IBanneredBar, Is.EqualTo(new Guid(0x596a9a94, 0x13e, 0x11d1, 0x8d, 0x34, 0x0, 0xa0, 0xc9, 0xf, 0x27, 0x19)));
    }
}