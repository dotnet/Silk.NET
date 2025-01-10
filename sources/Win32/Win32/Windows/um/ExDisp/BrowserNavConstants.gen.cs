// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum BrowserNavConstants
{
    navOpenInNewWindow = 0x1,
    navNoHistory = 0x2,
    navNoReadFromCache = 0x4,
    navNoWriteToCache = 0x8,
    navAllowAutosearch = 0x10,
    navBrowserBar = 0x20,
    navHyperlink = 0x40,
    navEnforceRestricted = 0x80,
    navNewWindowsManaged = 0x100,
    navUntrustedForDownload = 0x200,
    navTrustedForActiveX = 0x400,
    navOpenInNewTab = 0x800,
    navOpenInBackgroundTab = 0x1000,
    navKeepWordWheelText = 0x2000,
    navVirtualTab = 0x4000,
    navBlockRedirectsXDomain = 0x8000,
    navOpenNewForegroundTab = 0x10000,
    navTravelLogScreenshot = 0x20000,
    navDeferUnload = 0x40000,
    navSpeculative = 0x80000,
    navSuggestNewWindow = 0x100000,
    navSuggestNewTab = 0x200000,
    navReserved1 = 0x400000,
    navHomepageNavigate = 0x800000,
    navRefresh = 0x1000000,
    navHostNavigation = 0x2000000,
    navReserved2 = 0x4000000,
    navReserved3 = 0x8000000,
    navReserved4 = 0x10000000,
    navReserved5 = 0x20000000,
    navReserved6 = 0x40000000,
    navReserved7 = unchecked((int)(0x80000000)),
}
