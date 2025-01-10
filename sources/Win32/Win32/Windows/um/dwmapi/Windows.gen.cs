// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [NativeTypeName("const UINT")]
    public const uint c_DwmMaxQueuedBuffers = 8;

    [NativeTypeName("const UINT")]
    public const uint c_DwmMaxMonitors = 16;

    [NativeTypeName("const UINT")]
    public const uint c_DwmMaxAdapters = 16;

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern BOOL DwmDefWindowProc(
        HWND hWnd,
        uint msg,
        WPARAM wParam,
        LPARAM lParam,
        LRESULT* plResult
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmEnableBlurBehindWindow(
        HWND hWnd,
        [NativeTypeName("const DWM_BLURBEHIND *")] DWM_BLURBEHIND* pBlurBehind
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmEnableComposition(uint uCompositionAction);

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmEnableMMCSS(BOOL fEnableMMCSS);

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmExtendFrameIntoClientArea(
        HWND hWnd,
        [NativeTypeName("const MARGINS *")] MARGINS* pMarInset
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetColorizationColor(
        [NativeTypeName("DWORD *")] uint* pcrColorization,
        BOOL* pfOpaqueBlend
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetCompositionTimingInfo(
        HWND hwnd,
        DWM_TIMING_INFO* pTimingInfo
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetWindowAttribute(
        HWND hwnd,
        [NativeTypeName("DWORD")] uint dwAttribute,
        [NativeTypeName("PVOID")] void* pvAttribute,
        [NativeTypeName("DWORD")] uint cbAttribute
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmIsCompositionEnabled(BOOL* pfEnabled);

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmModifyPreviousDxFrameDuration(
        HWND hwnd,
        int cRefreshes,
        BOOL fRelative
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmQueryThumbnailSourceSize(
        HTHUMBNAIL hThumbnail,
        [NativeTypeName("PSIZE")] SIZE* pSize
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmRegisterThumbnail(
        HWND hwndDestination,
        HWND hwndSource,
        [NativeTypeName("PHTHUMBNAIL")] HTHUMBNAIL* phThumbnailId
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmSetDxFrameDuration(HWND hwnd, int cRefreshes);

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmSetPresentParameters(
        HWND hwnd,
        DWM_PRESENT_PARAMETERS* pPresentParams
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmSetWindowAttribute(
        HWND hwnd,
        [NativeTypeName("DWORD")] uint dwAttribute,
        [NativeTypeName("LPCVOID")] void* pvAttribute,
        [NativeTypeName("DWORD")] uint cbAttribute
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmUnregisterThumbnail(HTHUMBNAIL hThumbnailId);

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmUpdateThumbnailProperties(
        HTHUMBNAIL hThumbnailId,
        [NativeTypeName("const DWM_THUMBNAIL_PROPERTIES *")] DWM_THUMBNAIL_PROPERTIES* ptnProperties
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmSetIconicThumbnail(
        HWND hwnd,
        HBITMAP hbmp,
        [NativeTypeName("DWORD")] uint dwSITFlags
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmSetIconicLivePreviewBitmap(
        HWND hwnd,
        HBITMAP hbmp,
        POINT* pptClient,
        [NativeTypeName("DWORD")] uint dwSITFlags
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmInvalidateIconicBitmaps(HWND hwnd);

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmAttachMilContent(HWND hwnd);

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmDetachMilContent(HWND hwnd);

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmFlush();

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetGraphicsStreamTransformHint(
        uint uIndex,
        MilMatrix3x2D* pTransform
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetGraphicsStreamClient(
        uint uIndex,
        [NativeTypeName("UUID *")] Guid* pClientUuid
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    public static extern HRESULT DwmGetTransportAttributes(
        BOOL* pfIsRemoting,
        BOOL* pfIsConnected,
        [NativeTypeName("DWORD *")] uint* pDwGeneration
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DwmTransitionOwnedWindow(
        HWND hwnd,
        [NativeTypeName("enum DWMTRANSITION_OWNEDWINDOW_TARGET")]
            DWMTRANSITION_OWNEDWINDOW_TARGET target
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DwmRenderGesture(
        [NativeTypeName("enum GESTURE_TYPE")] GESTURE_TYPE gt,
        uint cContacts,
        [NativeTypeName("const DWORD *")] uint* pdwPointerID,
        [NativeTypeName("const POINT *")] POINT* pPoints
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DwmTetherContact(
        [NativeTypeName("DWORD")] uint dwPointerID,
        BOOL fEnable,
        POINT ptTether
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DwmShowContact(
        [NativeTypeName("DWORD")] uint dwPointerID,
        [NativeTypeName("enum DWM_SHOWCONTACT")] DWM_SHOWCONTACT eShowContact
    );

    [DllImport("dwmapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern HRESULT DwmGetUnmetTabRequirements(
        HWND appWindow,
        [NativeTypeName("enum DWM_TAB_WINDOW_REQUIREMENTS *")] DWM_TAB_WINDOW_REQUIREMENTS* value
    );

    [NativeTypeName("#define DWMWA_COLOR_DEFAULT 0xFFFFFFFF")]
    public const uint DWMWA_COLOR_DEFAULT = 0xFFFFFFFF;

    [NativeTypeName("#define DWMWA_COLOR_NONE 0xFFFFFFFE")]
    public const uint DWMWA_COLOR_NONE = 0xFFFFFFFE;
}
