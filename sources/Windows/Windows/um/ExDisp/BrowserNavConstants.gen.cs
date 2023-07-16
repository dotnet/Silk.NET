// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants"]/*'/>
public enum BrowserNavConstants
{
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navOpenInNewWindow"]/*'/>
    navOpenInNewWindow = 0x1,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navNoHistory"]/*'/>
    navNoHistory = 0x2,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navNoReadFromCache"]/*'/>
    navNoReadFromCache = 0x4,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navNoWriteToCache"]/*'/>
    navNoWriteToCache = 0x8,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navAllowAutosearch"]/*'/>
    navAllowAutosearch = 0x10,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navBrowserBar"]/*'/>
    navBrowserBar = 0x20,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navHyperlink"]/*'/>
    navHyperlink = 0x40,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navEnforceRestricted"]/*'/>
    navEnforceRestricted = 0x80,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navNewWindowsManaged"]/*'/>
    navNewWindowsManaged = 0x100,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navUntrustedForDownload"]/*'/>
    navUntrustedForDownload = 0x200,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navTrustedForActiveX"]/*'/>
    navTrustedForActiveX = 0x400,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navOpenInNewTab"]/*'/>
    navOpenInNewTab = 0x800,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navOpenInBackgroundTab"]/*'/>
    navOpenInBackgroundTab = 0x1000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navKeepWordWheelText"]/*'/>
    navKeepWordWheelText = 0x2000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navVirtualTab"]/*'/>
    navVirtualTab = 0x4000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navBlockRedirectsXDomain"]/*'/>
    navBlockRedirectsXDomain = 0x8000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navOpenNewForegroundTab"]/*'/>
    navOpenNewForegroundTab = 0x10000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navTravelLogScreenshot"]/*'/>
    navTravelLogScreenshot = 0x20000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navDeferUnload"]/*'/>
    navDeferUnload = 0x40000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navSpeculative"]/*'/>
    navSpeculative = 0x80000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navSuggestNewWindow"]/*'/>
    navSuggestNewWindow = 0x100000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navSuggestNewTab"]/*'/>
    navSuggestNewTab = 0x200000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navReserved1"]/*'/>
    navReserved1 = 0x400000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navHomepageNavigate"]/*'/>
    navHomepageNavigate = 0x800000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navRefresh"]/*'/>
    navRefresh = 0x1000000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navHostNavigation"]/*'/>
    navHostNavigation = 0x2000000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navReserved2"]/*'/>
    navReserved2 = 0x4000000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navReserved3"]/*'/>
    navReserved3 = 0x8000000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navReserved4"]/*'/>
    navReserved4 = 0x10000000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navReserved5"]/*'/>
    navReserved5 = 0x20000000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navReserved6"]/*'/>
    navReserved6 = 0x40000000,
    /// <include file='BrowserNavConstants.xml' path='doc/member[@name="BrowserNavConstants.navReserved7"]/*'/>
    navReserved7 = unchecked((int)(0x80000000)),
}