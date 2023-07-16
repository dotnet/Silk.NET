// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.BP_BUFFERFORMAT;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BeginPanningFeedback"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern BOOL BeginPanningFeedback(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UpdatePanningFeedback"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern BOOL UpdatePanningFeedback(HWND hwnd, [NativeTypeName("LONG")] int lTotalOverpanOffsetX, [NativeTypeName("LONG")] int lTotalOverpanOffsetY, BOOL fInInertia);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndPanningFeedback"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern BOOL EndPanningFeedback(HWND hwnd, BOOL fAnimateBack);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeAnimationProperty"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetThemeAnimationProperty(HTHEME hTheme, int iStoryboardId, int iTargetId, TA_PROPERTY eProperty, void* pvProperty, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbSizeOut);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeAnimationTransform"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetThemeAnimationTransform(HTHEME hTheme, int iStoryboardId, int iTargetId, [NativeTypeName("DWORD")] uint dwTransformIndex, TA_TRANSFORM* pTransform, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbSizeOut);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeTimingFunction"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetThemeTimingFunction(HTHEME hTheme, int iTimingFunctionId, TA_TIMINGFUNCTION* pTimingFunction, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbSizeOut);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenThemeData"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HTHEME OpenThemeData(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszClassList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenThemeDataForDpi"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern HTHEME OpenThemeDataForDpi(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszClassList, uint dpi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenThemeDataEx"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HTHEME OpenThemeDataEx(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszClassList, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseThemeData"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT CloseThemeData(HTHEME hTheme);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawThemeBackground"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT DrawThemeBackground(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("LPCRECT")] RECT* pClipRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawThemeBackgroundEx"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT DrawThemeBackgroundEx(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, [NativeTypeName("const DTBGOPTS *")] DTBGOPTS* pOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawThemeText"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT DrawThemeText(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCWSTR")] ushort* pszText, int cchText, [NativeTypeName("DWORD")] uint dwTextFlags, [NativeTypeName("DWORD")] uint dwTextFlags2, [NativeTypeName("LPCRECT")] RECT* pRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeBackgroundContentRect"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeBackgroundContentRect(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pBoundingRect, [NativeTypeName("LPRECT")] RECT* pContentRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeBackgroundExtent"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeBackgroundExtent(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pContentRect, [NativeTypeName("LPRECT")] RECT* pExtentRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeBackgroundRegion"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeBackgroundRegion(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, HRGN* pRegion);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemePartSize"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemePartSize(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* prc, [NativeTypeName("enum THEMESIZE")] THEMESIZE eSize, SIZE* psz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeTextExtent"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeTextExtent(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCWSTR")] ushort* pszText, int cchCharCount, [NativeTypeName("DWORD")] uint dwTextFlags, [NativeTypeName("LPCRECT")] RECT* pBoundingRect, [NativeTypeName("LPRECT")] RECT* pExtentRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeTextMetrics"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeTextMetrics(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, TEXTMETRICW* ptm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HitTestThemeBackground"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT HitTestThemeBackground(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCRECT")] RECT* pRect, HRGN hrgn, POINT ptTest, [NativeTypeName("WORD *")] ushort* pwHitTestCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawThemeEdge"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT DrawThemeEdge(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pDestRect, uint uEdge, uint uFlags, [NativeTypeName("LPRECT")] RECT* pContentRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawThemeIcon"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT DrawThemeIcon(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCRECT")] RECT* pRect, HIMAGELIST himl, int iImageIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsThemePartDefined"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern BOOL IsThemePartDefined(HTHEME hTheme, int iPartId, int iStateId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsThemeBackgroundPartiallyTransparent"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern BOOL IsThemeBackgroundPartiallyTransparent(HTHEME hTheme, int iPartId, int iStateId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeColor"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeColor(HTHEME hTheme, int iPartId, int iStateId, int iPropId, COLORREF* pColor);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeMetric"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeMetric(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, int iPropId, int* piVal);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeString"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeString(HTHEME hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPWSTR")] ushort* pszBuff, int cchMaxBuffChars);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeBool"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeBool(HTHEME hTheme, int iPartId, int iStateId, int iPropId, BOOL* pfVal);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeInt"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeInt(HTHEME hTheme, int iPartId, int iStateId, int iPropId, int* piVal);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeEnumValue"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeEnumValue(HTHEME hTheme, int iPartId, int iStateId, int iPropId, int* piVal);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemePosition"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemePosition(HTHEME hTheme, int iPartId, int iStateId, int iPropId, POINT* pPoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeFont"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeFont(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, int iPropId, LOGFONTW* pFont);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeRect"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeRect(HTHEME hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPRECT")] RECT* pRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeMargins"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeMargins(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPCRECT")] RECT* prc, MARGINS* pMargins);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeIntList"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeIntList(HTHEME hTheme, int iPartId, int iStateId, int iPropId, INTLIST* pIntList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemePropertyOrigin"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemePropertyOrigin(HTHEME hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("enum PROPERTYORIGIN *")] PROPERTYORIGIN* pOrigin);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowTheme"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT SetWindowTheme(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszSubAppName, [NativeTypeName("LPCWSTR")] ushort* pszSubIdList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeFilename"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeFilename(HTHEME hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("LPWSTR")] ushort* pszThemeFileName, int cchMaxBuffChars);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeSysColor"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern COLORREF GetThemeSysColor(HTHEME hTheme, int iColorId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeSysColorBrush"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HBRUSH GetThemeSysColorBrush(HTHEME hTheme, int iColorId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeSysBool"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern BOOL GetThemeSysBool(HTHEME hTheme, int iBoolId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeSysSize"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern int GetThemeSysSize(HTHEME hTheme, int iSizeId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeSysFont"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeSysFont(HTHEME hTheme, int iFontId, LOGFONTW* plf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeSysString"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeSysString(HTHEME hTheme, int iStringId, [NativeTypeName("LPWSTR")] ushort* pszStringBuff, int cchMaxStringChars);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeSysInt"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeSysInt(HTHEME hTheme, int iIntId, int* piValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsThemeActive"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern BOOL IsThemeActive();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsAppThemed"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern BOOL IsAppThemed();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowTheme"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HTHEME GetWindowTheme(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnableThemeDialogTexture"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT EnableThemeDialogTexture(HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsThemeDialogTextureEnabled"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern BOOL IsThemeDialogTextureEnabled(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeAppProperties"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetThemeAppProperties();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThemeAppProperties"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern void SetThemeAppProperties([NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentThemeName"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetCurrentThemeName([NativeTypeName("LPWSTR")] ushort* pszThemeFileName, int cchMaxNameChars, [NativeTypeName("LPWSTR")] ushort* pszColorBuff, int cchMaxColorChars, [NativeTypeName("LPWSTR")] ushort* pszSizeBuff, int cchMaxSizeChars);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeDocumentationProperty"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeDocumentationProperty([NativeTypeName("LPCWSTR")] ushort* pszThemeName, [NativeTypeName("LPCWSTR")] ushort* pszPropertyName, [NativeTypeName("LPWSTR")] ushort* pszValueBuff, int cchMaxValChars);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawThemeParentBackground"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT DrawThemeParentBackground(HWND hwnd, HDC hdc, [NativeTypeName("const RECT *")] RECT* prc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnableTheming"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT EnableTheming(BOOL fEnable);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawThemeParentBackgroundEx"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT DrawThemeParentBackgroundEx(HWND hwnd, HDC hdc, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const RECT *")] RECT* prc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowThemeAttribute"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT SetWindowThemeAttribute(HWND hwnd, [NativeTypeName("enum WINDOWTHEMEATTRIBUTETYPE")] WINDOWTHEMEATTRIBUTETYPE eAttribute, [NativeTypeName("PVOID")] void* pvAttribute, [NativeTypeName("DWORD")] uint cbAttribute);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawThemeTextEx"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT DrawThemeTextEx(HTHEME hTheme, HDC hdc, int iPartId, int iStateId, [NativeTypeName("LPCWSTR")] ushort* pszText, int cchText, [NativeTypeName("DWORD")] uint dwTextFlags, [NativeTypeName("LPRECT")] RECT* pRect, [NativeTypeName("const DTTOPTS *")] DTTOPTS* pOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeBitmap"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeBitmap(HTHEME hTheme, int iPartId, int iStateId, int iPropId, [NativeTypeName("ULONG")] uint dwFlags, HBITMAP* phBitmap);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeStream"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeStream(HTHEME hTheme, int iPartId, int iStateId, int iPropId, void** ppvStream, [NativeTypeName("DWORD *")] uint* pcbStream, HINSTANCE hInst);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BufferedPaintInit"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT BufferedPaintInit();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BufferedPaintUnInit"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT BufferedPaintUnInit();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BeginBufferedPaint"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HPAINTBUFFER BeginBufferedPaint(HDC hdcTarget, [NativeTypeName("const RECT *")] RECT* prcTarget, BP_BUFFERFORMAT dwFormat, BP_PAINTPARAMS* pPaintParams, HDC* phdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndBufferedPaint"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT EndBufferedPaint(HPAINTBUFFER hBufferedPaint, BOOL fUpdateTarget);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBufferedPaintTargetRect"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetBufferedPaintTargetRect(HPAINTBUFFER hBufferedPaint, RECT* prc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBufferedPaintTargetDC"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HDC GetBufferedPaintTargetDC(HPAINTBUFFER hBufferedPaint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBufferedPaintDC"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HDC GetBufferedPaintDC(HPAINTBUFFER hBufferedPaint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBufferedPaintBits"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetBufferedPaintBits(HPAINTBUFFER hBufferedPaint, RGBQUAD** ppbBuffer, int* pcxRow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BufferedPaintClear"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT BufferedPaintClear(HPAINTBUFFER hBufferedPaint, [NativeTypeName("const RECT *")] RECT* prc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BufferedPaintSetAlpha"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT BufferedPaintSetAlpha(HPAINTBUFFER hBufferedPaint, [NativeTypeName("const RECT *")] RECT* prc, byte alpha);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BufferedPaintStopAllAnimations"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT BufferedPaintStopAllAnimations(HWND hwnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BeginBufferedAnimation"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HANIMATIONBUFFER BeginBufferedAnimation(HWND hwnd, HDC hdcTarget, [NativeTypeName("const RECT *")] RECT* prcTarget, BP_BUFFERFORMAT dwFormat, BP_PAINTPARAMS* pPaintParams, BP_ANIMATIONPARAMS* pAnimationParams, HDC* phdcFrom, HDC* phdcTo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndBufferedAnimation"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT EndBufferedAnimation(HANIMATIONBUFFER hbpAnimation, BOOL fUpdateTarget);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BufferedPaintRenderAnimation"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern BOOL BufferedPaintRenderAnimation(HWND hwnd, HDC hdcTarget);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCompositionActive"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern BOOL IsCompositionActive();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThemeTransitionDuration"]/*'/>
    [DllImport("uxtheme", ExactSpelling = true)]
    public static extern HRESULT GetThemeTransitionDuration(HTHEME hTheme, int iPartId, int iStateIdFrom, int iStateIdTo, int iPropId, [NativeTypeName("DWORD *")] uint* pdwDuration);
    [NativeTypeName("#define OTD_FORCE_RECT_SIZING 0x00000001")]
    public const int OTD_FORCE_RECT_SIZING = 0x00000001;
    [NativeTypeName("#define OTD_NONCLIENT 0x00000002")]
    public const int OTD_NONCLIENT = 0x00000002;
    [NativeTypeName("#define OTD_VALIDBITS (OTD_FORCE_RECT_SIZING | \\\r\n                                 OTD_NONCLIENT)")]
    public const int OTD_VALIDBITS = (0x00000001 | 0x00000002);
    [NativeTypeName("#define DTBG_CLIPRECT 0x00000001")]
    public const int DTBG_CLIPRECT = 0x00000001;
    [NativeTypeName("#define DTBG_DRAWSOLID 0x00000002")]
    public const int DTBG_DRAWSOLID = 0x00000002;
    [NativeTypeName("#define DTBG_OMITBORDER 0x00000004")]
    public const int DTBG_OMITBORDER = 0x00000004;
    [NativeTypeName("#define DTBG_OMITCONTENT 0x00000008")]
    public const int DTBG_OMITCONTENT = 0x00000008;
    [NativeTypeName("#define DTBG_COMPUTINGREGION 0x00000010")]
    public const int DTBG_COMPUTINGREGION = 0x00000010;
    [NativeTypeName("#define DTBG_MIRRORDC 0x00000020")]
    public const int DTBG_MIRRORDC = 0x00000020;
    [NativeTypeName("#define DTBG_NOMIRROR 0x00000040")]
    public const int DTBG_NOMIRROR = 0x00000040;
    [NativeTypeName("#define DTBG_VALIDBITS (DTBG_CLIPRECT | \\\r\n                                 DTBG_DRAWSOLID | \\\r\n                                 DTBG_OMITBORDER | \\\r\n                                 DTBG_OMITCONTENT | \\\r\n                                 DTBG_COMPUTINGREGION | \\\r\n                                 DTBG_MIRRORDC | \\\r\n                                 DTBG_NOMIRROR)")]
    public const int DTBG_VALIDBITS = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040);
    [NativeTypeName("#define ETDT_DISABLE 0x00000001")]
    public const int ETDT_DISABLE = 0x00000001;
    [NativeTypeName("#define ETDT_ENABLE 0x00000002")]
    public const int ETDT_ENABLE = 0x00000002;
    [NativeTypeName("#define ETDT_USETABTEXTURE 0x00000004")]
    public const int ETDT_USETABTEXTURE = 0x00000004;
    [NativeTypeName("#define ETDT_ENABLETAB (ETDT_ENABLE | \\\r\n                                     ETDT_USETABTEXTURE)")]
    public const int ETDT_ENABLETAB = (0x00000002 | 0x00000004);
    [NativeTypeName("#define ETDT_USEAEROWIZARDTABTEXTURE 0x00000008")]
    public const int ETDT_USEAEROWIZARDTABTEXTURE = 0x00000008;
    [NativeTypeName("#define ETDT_ENABLEAEROWIZARDTAB (ETDT_ENABLE | \\\r\n                                     ETDT_USEAEROWIZARDTABTEXTURE)")]
    public const int ETDT_ENABLEAEROWIZARDTAB = (0x00000002 | 0x00000008);
    [NativeTypeName("#define ETDT_VALIDBITS (ETDT_DISABLE | \\\r\n                                     ETDT_ENABLE | \\\r\n                                     ETDT_USETABTEXTURE | \\\r\n                                     ETDT_USEAEROWIZARDTABTEXTURE)")]
    public const int ETDT_VALIDBITS = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008);
    [NativeTypeName("#define STAP_ALLOW_NONCLIENT (1UL << 0)")]
    public const uint STAP_ALLOW_NONCLIENT = (1U << 0);
    [NativeTypeName("#define STAP_ALLOW_CONTROLS (1UL << 1)")]
    public const uint STAP_ALLOW_CONTROLS = (1U << 1);
    [NativeTypeName("#define STAP_ALLOW_WEBCONTENT (1UL << 2)")]
    public const uint STAP_ALLOW_WEBCONTENT = (1U << 2);
    [NativeTypeName("#define STAP_VALIDBITS (STAP_ALLOW_NONCLIENT | \\\r\n                                 STAP_ALLOW_CONTROLS | \\\r\n                                 STAP_ALLOW_WEBCONTENT)")]
    public const uint STAP_VALIDBITS = ((1U << 0) | (1U << 1) | (1U << 2));
    [NativeTypeName("#define GBF_DIRECT 0x00000001")]
    public const int GBF_DIRECT = 0x00000001;
    [NativeTypeName("#define GBF_COPY 0x00000002")]
    public const int GBF_COPY = 0x00000002;
    [NativeTypeName("#define GBF_VALIDBITS (GBF_DIRECT | \\\r\n                         GBF_COPY)")]
    public const int GBF_VALIDBITS = (0x00000001 | 0x00000002);
    [NativeTypeName("#define DTPB_WINDOWDC 0x00000001")]
    public const int DTPB_WINDOWDC = 0x00000001;
    [NativeTypeName("#define DTPB_USECTLCOLORSTATIC 0x00000002")]
    public const int DTPB_USECTLCOLORSTATIC = 0x00000002;
    [NativeTypeName("#define DTPB_USEERASEBKGND 0x00000004")]
    public const int DTPB_USEERASEBKGND = 0x00000004;
    [NativeTypeName("#define WTNCA_NODRAWCAPTION 0x00000001")]
    public const int WTNCA_NODRAWCAPTION = 0x00000001;
    [NativeTypeName("#define WTNCA_NODRAWICON 0x00000002")]
    public const int WTNCA_NODRAWICON = 0x00000002;
    [NativeTypeName("#define WTNCA_NOSYSMENU 0x00000004")]
    public const int WTNCA_NOSYSMENU = 0x00000004;
    [NativeTypeName("#define WTNCA_NOMIRRORHELP 0x00000008")]
    public const int WTNCA_NOMIRRORHELP = 0x00000008;
    [NativeTypeName("#define WTNCA_VALIDBITS (WTNCA_NODRAWCAPTION | \\\r\n                                   WTNCA_NODRAWICON | \\\r\n                                   WTNCA_NOSYSMENU | \\\r\n                                   WTNCA_NOMIRRORHELP)")]
    public const int WTNCA_VALIDBITS = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008);
    [NativeTypeName("#define BPBF_COMPOSITED BPBF_TOPDOWNDIB")]
    public const BP_BUFFERFORMAT BPBF_COMPOSITED = BPBF_TOPDOWNDIB;
}