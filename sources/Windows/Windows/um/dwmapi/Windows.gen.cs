// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [NativeTypeName("const UINT")]
    public const uint c_DwmMaxQueuedBuffers = 8;

    [NativeTypeName("const UINT")]
    public const uint c_DwmMaxMonitors = 16;

    [NativeTypeName("const UINT")]
    public const uint c_DwmMaxAdapters = 16;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmDefWindowProc"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern BOOL DwmDefWindowProc(HWND hWnd, uint msg, WPARAM wParam, LPARAM lParam, LRESULT* plResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmEnableBlurBehindWindow"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmEnableBlurBehindWindow(HWND hWnd, [NativeTypeName("const DWM_BLURBEHIND *")] DWM_BLURBEHIND* pBlurBehind);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmEnableComposition"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmEnableComposition(uint uCompositionAction);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmEnableMMCSS"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmEnableMMCSS(BOOL fEnableMMCSS);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmExtendFrameIntoClientArea"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmExtendFrameIntoClientArea(HWND hWnd, [NativeTypeName("const MARGINS *")] MARGINS* pMarInset);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmGetColorizationColor"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetColorizationColor([NativeTypeName("DWORD *")] uint* pcrColorization, BOOL* pfOpaqueBlend);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmGetCompositionTimingInfo"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetCompositionTimingInfo(HWND hwnd, DWM_TIMING_INFO* pTimingInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmGetWindowAttribute"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetWindowAttribute(HWND hwnd, [NativeTypeName("DWORD")] uint dwAttribute, [NativeTypeName("PVOID")] void* pvAttribute, [NativeTypeName("DWORD")] uint cbAttribute);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmIsCompositionEnabled"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmIsCompositionEnabled(BOOL* pfEnabled);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmModifyPreviousDxFrameDuration"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmModifyPreviousDxFrameDuration(HWND hwnd, int cRefreshes, BOOL fRelative);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmQueryThumbnailSourceSize"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmQueryThumbnailSourceSize(HTHUMBNAIL hThumbnail, [NativeTypeName("PSIZE")] SIZE* pSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmRegisterThumbnail"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmRegisterThumbnail(HWND hwndDestination, HWND hwndSource, [NativeTypeName("PHTHUMBNAIL")] HTHUMBNAIL* phThumbnailId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmSetDxFrameDuration"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmSetDxFrameDuration(HWND hwnd, int cRefreshes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmSetPresentParameters"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmSetPresentParameters(HWND hwnd, DWM_PRESENT_PARAMETERS* pPresentParams);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmSetWindowAttribute"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmSetWindowAttribute(HWND hwnd, [NativeTypeName("DWORD")] uint dwAttribute, [NativeTypeName("LPCVOID")] void* pvAttribute, [NativeTypeName("DWORD")] uint cbAttribute);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmUnregisterThumbnail"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmUnregisterThumbnail(HTHUMBNAIL hThumbnailId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmUpdateThumbnailProperties"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmUpdateThumbnailProperties(HTHUMBNAIL hThumbnailId, [NativeTypeName("const DWM_THUMBNAIL_PROPERTIES *")] DWM_THUMBNAIL_PROPERTIES* ptnProperties);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmSetIconicThumbnail"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmSetIconicThumbnail(HWND hwnd, HBITMAP hbmp, [NativeTypeName("DWORD")] uint dwSITFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmSetIconicLivePreviewBitmap"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmSetIconicLivePreviewBitmap(HWND hwnd, HBITMAP hbmp, POINT* pptClient, [NativeTypeName("DWORD")] uint dwSITFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmInvalidateIconicBitmaps"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmInvalidateIconicBitmaps(HWND hwnd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmAttachMilContent"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmAttachMilContent(HWND hwnd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmDetachMilContent"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmDetachMilContent(HWND hwnd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmFlush"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmFlush();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmGetGraphicsStreamTransformHint"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetGraphicsStreamTransformHint(uint uIndex, MilMatrix3x2D* pTransform);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmGetGraphicsStreamClient"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetGraphicsStreamClient(uint uIndex, [NativeTypeName("UUID *")] Guid* pClientUuid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmGetTransportAttributes"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetTransportAttributes(BOOL* pfIsRemoting, BOOL* pfIsConnected, [NativeTypeName("DWORD *")] uint* pDwGeneration);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmTransitionOwnedWindow"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DwmTransitionOwnedWindow(HWND hwnd, [NativeTypeName("enum DWMTRANSITION_OWNEDWINDOW_TARGET")] DWMTRANSITION_OWNEDWINDOW_TARGET target);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmRenderGesture"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DwmRenderGesture([NativeTypeName("enum GESTURE_TYPE")] GESTURE_TYPE gt, uint cContacts, [NativeTypeName("const DWORD *")] uint* pdwPointerID, [NativeTypeName("const POINT *")] POINT* pPoints);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmTetherContact"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DwmTetherContact([NativeTypeName("DWORD")] uint dwPointerID, BOOL fEnable, POINT ptTether);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmShowContact"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DwmShowContact([NativeTypeName("DWORD")] uint dwPointerID, [NativeTypeName("enum DWM_SHOWCONTACT")] DWM_SHOWCONTACT eShowContact);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DwmGetUnmetTabRequirements"]/*' />
    [DllImport("dwmapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern HRESULT DwmGetUnmetTabRequirements(HWND appWindow, [NativeTypeName("enum DWM_TAB_WINDOW_REQUIREMENTS *")] DWM_TAB_WINDOW_REQUIREMENTS* value);

    [NativeTypeName("#define DWMWA_COLOR_DEFAULT 0xFFFFFFFF")]
    public const uint DWMWA_COLOR_DEFAULT = 0xFFFFFFFF;

    [NativeTypeName("#define DWMWA_COLOR_NONE 0xFFFFFFFE")]
    public const uint DWMWA_COLOR_NONE = 0xFFFFFFFE;
}
