// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.BrowserNavConstants;

namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define navUserInitiatedAction navReserved1")]
    public const BrowserNavConstants navUserInitiatedAction = navReserved1;
    [NativeTypeName("#define navDisableDownloadSave navReserved2")]
    public const BrowserNavConstants navDisableDownloadSave = navReserved2;
    [NativeTypeName("#define navServerRedirectedVtabSwitch navReserved3")]
    public const BrowserNavConstants navServerRedirectedVtabSwitch = navReserved3;
    [NativeTypeName("#define navVtabSwitchNotUserInitiatedAction navReserved4")]
    public const BrowserNavConstants navVtabSwitchNotUserInitiatedAction = navReserved4;
    [NativeTypeName("#define navCheckDontShowNeedIE navReserved5")]
    public const BrowserNavConstants navCheckDontShowNeedIE = navReserved5;
    [NativeTypeName("#define navCheckDontShowNeedHVSI navReserved6")]
    public const BrowserNavConstants navCheckDontShowNeedHVSI = navReserved6;
    [NativeTypeName("#define navCheckDontShowHVSINeedHost navReserved7")]
    public const BrowserNavConstants navCheckDontShowHVSINeedHost = navReserved7;
}