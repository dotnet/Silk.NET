// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitCommonControls"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void InitCommonControls();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitCommonControlsEx"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL InitCommonControlsEx([NativeTypeName("const INITCOMMONCONTROLSEX *")] INITCOMMONCONTROLSEX* picce);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Create"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_Create(int cx, int cy, uint flags, int cInitial, int cGrow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Destroy"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Destroy(HIMAGELIST himl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetImageCount"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int ImageList_GetImageCount(HIMAGELIST himl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_SetImageCount"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_SetImageCount(HIMAGELIST himl, uint uNewCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Add"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int ImageList_Add(HIMAGELIST himl, HBITMAP hbmImage, HBITMAP hbmMask);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_ReplaceIcon"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int ImageList_ReplaceIcon(HIMAGELIST himl, int i, HICON hicon);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_SetBkColor"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern COLORREF ImageList_SetBkColor(HIMAGELIST himl, COLORREF clrBk);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetBkColor"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern COLORREF ImageList_GetBkColor(HIMAGELIST himl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_SetOverlayImage"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_SetOverlayImage(HIMAGELIST himl, int iImage, int iOverlay);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Draw"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Draw(HIMAGELIST himl, int i, HDC hdcDst, int x, int y, uint fStyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Replace"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Replace(HIMAGELIST himl, int i, HBITMAP hbmImage, HBITMAP hbmMask);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_AddMasked"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int ImageList_AddMasked(HIMAGELIST himl, HBITMAP hbmImage, COLORREF crMask);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DrawEx"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DrawEx(HIMAGELIST himl, int i, HDC hdcDst, int x, int y, int dx, int dy, COLORREF rgbBk, COLORREF rgbFg, uint fStyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DrawIndirect"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DrawIndirect(IMAGELISTDRAWPARAMS* pimldp);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Remove"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Remove(HIMAGELIST himl, int i);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetIcon"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HICON ImageList_GetIcon(HIMAGELIST himl, int i, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_LoadImageA"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_LoadImageA(HINSTANCE hi, [NativeTypeName("LPCSTR")] sbyte* lpbmp, int cx, int cGrow, COLORREF crMask, uint uType, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_LoadImageW"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_LoadImageW(HINSTANCE hi, [NativeTypeName("LPCWSTR")] ushort* lpbmp, int cx, int cGrow, COLORREF crMask, uint uType, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Copy"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Copy(HIMAGELIST himlDst, int iDst, HIMAGELIST himlSrc, int iSrc, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_BeginDrag"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_BeginDrag(HIMAGELIST himlTrack, int iTrack, int dxHotspot, int dyHotspot);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_EndDrag"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void ImageList_EndDrag();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DragEnter"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DragEnter(HWND hwndLock, int x, int y);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DragLeave"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DragLeave(HWND hwndLock);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DragMove"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DragMove(int x, int y);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_SetDragCursorImage"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_SetDragCursorImage(HIMAGELIST himlDrag, int iDrag, int dxHotspot, int dyHotspot);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_DragShowNolock"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_DragShowNolock(BOOL fShow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetDragImage"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_GetDragImage(POINT* ppt, POINT* pptHotspot);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Read"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_Read([NativeTypeName("struct IStream *")] IStream* pstm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Write"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_Write(HIMAGELIST himl, [NativeTypeName("struct IStream *")] IStream* pstm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_ReadEx"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT ImageList_ReadEx([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("struct IStream *")] IStream* pstm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("PVOID *")] void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_WriteEx"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT ImageList_WriteEx(HIMAGELIST himl, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("struct IStream *")] IStream* pstm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetIconSize"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_GetIconSize(HIMAGELIST himl, int* cx, int* cy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_SetIconSize"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_SetIconSize(HIMAGELIST himl, int cx, int cy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_GetImageInfo"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ImageList_GetImageInfo(HIMAGELIST himl, int i, IMAGEINFO* pImageInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Merge"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_Merge(HIMAGELIST himl1, int i1, HIMAGELIST himl2, int i2, int dx, int dy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_Duplicate"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HIMAGELIST ImageList_Duplicate(HIMAGELIST himl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HIMAGELIST_QueryInterface"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT HIMAGELIST_QueryInterface(HIMAGELIST himl, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IImageListToHIMAGELIST"]/*'/>
    public static HIMAGELIST IImageListToHIMAGELIST([NativeTypeName("struct IImageList *")] IImageList* himl)
    {
        return (HIMAGELIST)(himl);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateToolbarEx"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateToolbarEx(HWND hwnd, [NativeTypeName("DWORD")] uint ws, uint wID, int nBitmaps, HINSTANCE hBMInst, [NativeTypeName("UINT_PTR")] nuint wBMID, [NativeTypeName("LPCTBBUTTON")] void* lpButtons, int iNumButtons, int dxButton, int dyButton, int dxBitmap, int dyBitmap, uint uStructSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMappedBitmap"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HBITMAP CreateMappedBitmap(HINSTANCE hInstance, [NativeTypeName("INT_PTR")] nint idBitmap, uint wFlags, [NativeTypeName("LPCOLORMAP")] COLORMAP* lpColorMap, int iNumMaps);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawStatusTextA"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void DrawStatusTextA(HDC hDC, [NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("LPCSTR")] sbyte* pszText, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawStatusTextW"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void DrawStatusTextW(HDC hDC, [NativeTypeName("LPCRECT")] RECT* lprc, [NativeTypeName("LPCWSTR")] ushort* pszText, uint uFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateStatusWindowA"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateStatusWindowA([NativeTypeName("LONG")] int style, [NativeTypeName("LPCSTR")] sbyte* lpszText, HWND hwndParent, uint wID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateStatusWindowW"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HWND CreateStatusWindowW([NativeTypeName("LONG")] int style, [NativeTypeName("LPCWSTR")] ushort* lpszText, HWND hwndParent, uint wID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MenuHelp"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void MenuHelp(uint uMsg, WPARAM wParam, LPARAM lParam, HMENU hMainMenu, HINSTANCE hInst, HWND hwndStatus, uint* lpwIDs);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShowHideMenuCtl"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL ShowHideMenuCtl(HWND hWnd, [NativeTypeName("UINT_PTR")] nuint uFlags, [NativeTypeName("LPINT")] int* lpInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEffectiveClientRect"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void GetEffectiveClientRect(HWND hWnd, [NativeTypeName("LPRECT")] RECT* lprc, [NativeTypeName("const INT *")] int* lpInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MakeDragList"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL MakeDragList(HWND hLB);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawInsert"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void DrawInsert(HWND handParent, HWND hLB, int nItem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LBItemFromPt"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int LBItemFromPt(HWND hLB, POINT pt, BOOL bAutoScroll);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateUpDownControl"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HWND CreateUpDownControl([NativeTypeName("DWORD")] uint dwStyle, int x, int y, int cx, int cy, HWND hParent, int nID, HINSTANCE hInst, HWND hBuddy, int nUpper, int nLower, int nPos);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TaskDialogIndirect"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT TaskDialogIndirect([NativeTypeName("const TASKDIALOGCONFIG *")] TASKDIALOGCONFIG* pTaskConfig, int* pnButton, int* pnRadioButton, BOOL* pfVerificationFlagChecked);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TaskDialog"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT TaskDialog(HWND hwndOwner, HINSTANCE hInstance, [NativeTypeName("PCWSTR")] ushort* pszWindowTitle, [NativeTypeName("PCWSTR")] ushort* pszMainInstruction, [NativeTypeName("PCWSTR")] ushort* pszContent, [NativeTypeName("TASKDIALOG_COMMON_BUTTON_FLAGS")] int dwCommonButtons, [NativeTypeName("PCWSTR")] ushort* pszIcon, int* pnButton);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitMUILanguage"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern void InitMUILanguage([NativeTypeName("LANGID")] ushort uiLang);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMUILanguage"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    [return: NativeTypeName("LANGID")]
    public static extern ushort GetMUILanguage();
    /// <include file='Windows.xml' path='doc/member[@name="Windows._TrackMouseEvent"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL _TrackMouseEvent([NativeTypeName("LPTRACKMOUSEEVENT")] TRACKMOUSEEVENT* lpEventTrack);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_EnableScrollBar"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_EnableScrollBar(HWND param0, int param1, uint param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_ShowScrollBar"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_ShowScrollBar(HWND param0, int code, BOOL param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_GetScrollRange"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_GetScrollRange(HWND param0, int code, [NativeTypeName("LPINT")] int* param2, [NativeTypeName("LPINT")] int* param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_GetScrollInfo"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_GetScrollInfo(HWND param0, int code, [NativeTypeName("LPSCROLLINFO")] SCROLLINFO* param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_GetScrollPos"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int FlatSB_GetScrollPos(HWND param0, int code);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_GetScrollProp"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_GetScrollProp(HWND param0, int propIndex, [NativeTypeName("LPINT")] int* param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_SetScrollPos"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int FlatSB_SetScrollPos(HWND param0, int code, int pos, BOOL fRedraw);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_SetScrollInfo"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int FlatSB_SetScrollInfo(HWND param0, int code, [NativeTypeName("LPSCROLLINFO")] SCROLLINFO* psi, BOOL fRedraw);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_SetScrollRange"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int FlatSB_SetScrollRange(HWND param0, int code, int min, int max, BOOL fRedraw);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlatSB_SetScrollProp"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL FlatSB_SetScrollProp(HWND param0, uint index, [NativeTypeName("INT_PTR")] nint newValue, BOOL param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitializeFlatSB"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL InitializeFlatSB(HWND param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UninitializeFlatSB"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT UninitializeFlatSB(HWND param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowSubclass"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL SetWindowSubclass(HWND hWnd, [NativeTypeName("SUBCLASSPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint, nuint, LRESULT> pfnSubclass, [NativeTypeName("UINT_PTR")] nuint uIdSubclass, [NativeTypeName("DWORD_PTR")] nuint dwRefData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowSubclass"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL GetWindowSubclass(HWND hWnd, [NativeTypeName("SUBCLASSPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint, nuint, LRESULT> pfnSubclass, [NativeTypeName("UINT_PTR")] nuint uIdSubclass, [NativeTypeName("DWORD_PTR *")] nuint* pdwRefData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveWindowSubclass"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern BOOL RemoveWindowSubclass(HWND hWnd, [NativeTypeName("SUBCLASSPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint, nuint, LRESULT> pfnSubclass, [NativeTypeName("UINT_PTR")] nuint uIdSubclass);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefSubclassProc"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern LRESULT DefSubclassProc(HWND hWnd, uint uMsg, WPARAM wParam, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadIconMetric"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT LoadIconMetric(HINSTANCE hinst, [NativeTypeName("PCWSTR")] ushort* pszName, int lims, HICON* phico);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadIconWithScaleDown"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT LoadIconWithScaleDown(HINSTANCE hinst, [NativeTypeName("PCWSTR")] ushort* pszName, int cx, int cy, HICON* phico);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawShadowText"]/*'/>
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern int DrawShadowText(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* pszText, uint cch, RECT* prc, [NativeTypeName("DWORD")] uint dwFlags, COLORREF crText, COLORREF crShadow, int ixOffset, int iyOffset);
    [NativeTypeName("#define ODT_HEADER 100")]
    public const int ODT_HEADER = 100;
    [NativeTypeName("#define ODT_TAB 101")]
    public const int ODT_TAB = 101;
    [NativeTypeName("#define ODT_LISTVIEW 102")]
    public const int ODT_LISTVIEW = 102;
    [NativeTypeName("#define TV_FIRST 0x1100")]
    public const int TV_FIRST = 0x1100;
    [NativeTypeName("#define ECM_FIRST 0x1500")]
    public const int ECM_FIRST = 0x1500;
    [NativeTypeName("#define CBM_FIRST 0x1700")]
    public const int CBM_FIRST = 0x1700;
    [NativeTypeName("#define COMCTL32_VERSION 6")]
    public const int COMCTL32_VERSION = 6;
    [NativeTypeName("#define INFOTIPSIZE 1024")]
    public const int INFOTIPSIZE = 1024;
    [NativeTypeName("#define TCN_FIRST (0U-550U)")]
    public const uint TCN_FIRST = unchecked(0U - 550U);
    [NativeTypeName("#define TCN_LAST (0U-580U)")]
    public const uint TCN_LAST = unchecked(0U - 580U);
    [NativeTypeName("#define UDN_FIRST (0U-721U)")]
    public const uint UDN_FIRST = unchecked(0U - 721U);
    [NativeTypeName("#define UDN_LAST (0U-729U)")]
    public const uint UDN_LAST = unchecked(0U - 729U);
    [NativeTypeName("#define MCN_FIRST (0U-746U)")]
    public const uint MCN_FIRST = unchecked(0U - 746U);
    [NativeTypeName("#define MCN_LAST (0U-752U)")]
    public const uint MCN_LAST = unchecked(0U - 752U);
    [NativeTypeName("#define IPN_FIRST (0U-860U)")]
    public const uint IPN_FIRST = unchecked(0U - 860U);
    [NativeTypeName("#define IPN_LAST (0U-879U)")]
    public const uint IPN_LAST = unchecked(0U - 879U);
    [NativeTypeName("#define SBN_FIRST (0U-880U)")]
    public const uint SBN_FIRST = unchecked(0U - 880U);
    [NativeTypeName("#define SBN_LAST (0U-899U)")]
    public const uint SBN_LAST = unchecked(0U - 899U);
    [NativeTypeName("#define PGN_FIRST (0U-900U)")]
    public const uint PGN_FIRST = unchecked(0U - 900U);
    [NativeTypeName("#define PGN_LAST (0U-950U)")]
    public const uint PGN_LAST = unchecked(0U - 950U);
    [NativeTypeName("#define WMN_FIRST (0U-1000U)")]
    public const uint WMN_FIRST = unchecked(0U - 1000U);
    [NativeTypeName("#define WMN_LAST (0U-1200U)")]
    public const uint WMN_LAST = unchecked(0U - 1200U);
    [NativeTypeName("#define BCN_FIRST (0U-1250U)")]
    public const uint BCN_FIRST = unchecked(0U - 1250U);
    [NativeTypeName("#define BCN_LAST (0U-1350U)")]
    public const uint BCN_LAST = unchecked(0U - 1350U);
    [NativeTypeName("#define TRBN_FIRST (0U-1501U)")]
    public const uint TRBN_FIRST = unchecked(0U - 1501U);
    [NativeTypeName("#define TRBN_LAST (0U-1519U)")]
    public const uint TRBN_LAST = unchecked(0U - 1519U);
    [NativeTypeName("#define CDRF_DODEFAULT 0x00000000")]
    public const int CDRF_DODEFAULT = 0x00000000;
    [NativeTypeName("#define CDRF_NEWFONT 0x00000002")]
    public const int CDRF_NEWFONT = 0x00000002;
    [NativeTypeName("#define CDRF_SKIPDEFAULT 0x00000004")]
    public const int CDRF_SKIPDEFAULT = 0x00000004;
    [NativeTypeName("#define CDRF_DOERASE 0x00000008")]
    public const int CDRF_DOERASE = 0x00000008;
    [NativeTypeName("#define CDRF_SKIPPOSTPAINT 0x00000100")]
    public const int CDRF_SKIPPOSTPAINT = 0x00000100;
    [NativeTypeName("#define CDRF_NOTIFYPOSTPAINT 0x00000010")]
    public const int CDRF_NOTIFYPOSTPAINT = 0x00000010;
    [NativeTypeName("#define CDRF_NOTIFYITEMDRAW 0x00000020")]
    public const int CDRF_NOTIFYITEMDRAW = 0x00000020;
    [NativeTypeName("#define CDRF_NOTIFYSUBITEMDRAW 0x00000020")]
    public const int CDRF_NOTIFYSUBITEMDRAW = 0x00000020;
    [NativeTypeName("#define CDRF_NOTIFYPOSTERASE 0x00000040")]
    public const int CDRF_NOTIFYPOSTERASE = 0x00000040;
    [NativeTypeName("#define CLR_NONE 0xFFFFFFFFL")]
    public const uint CLR_NONE = 0xFFFFFFFF;
    [NativeTypeName("#define CLR_DEFAULT 0xFF000000L")]
    public const uint CLR_DEFAULT = 0xFF000000;
    [NativeTypeName("#define CLR_HILIGHT CLR_DEFAULT")]
    public const uint CLR_HILIGHT = 0xFF000000;
    [NativeTypeName("#define ILS_NORMAL 0x00000000")]
    public const int ILS_NORMAL = 0x00000000;
    [NativeTypeName("#define ILS_GLOW 0x00000001")]
    public const int ILS_GLOW = 0x00000001;
    [NativeTypeName("#define ILS_SHADOW 0x00000002")]
    public const int ILS_SHADOW = 0x00000002;
    [NativeTypeName("#define ILS_SATURATE 0x00000004")]
    public const int ILS_SATURATE = 0x00000004;
    [NativeTypeName("#define ILS_ALPHA 0x00000008")]
    public const int ILS_ALPHA = 0x00000008;
    [NativeTypeName("#define ILGT_NORMAL 0x00000000")]
    public const int ILGT_NORMAL = 0x00000000;
    [NativeTypeName("#define ILGT_ASYNC 0x00000001")]
    public const int ILGT_ASYNC = 0x00000001;
    [NativeTypeName("#define ImageList_LoadImage ImageList_LoadImageW")]
    public static delegate*<HINSTANCE, ushort*, int, int, COLORREF, uint, uint, HIMAGELIST> ImageList_LoadImage => &ImageList_LoadImageW;

    [NativeTypeName("#define ILCF_MOVE (0x00000000)")]
    public const int ILCF_MOVE = (0x00000000);
    [NativeTypeName("#define ILCF_SWAP (0x00000001)")]
    public const int ILCF_SWAP = (0x00000001);
    [NativeTypeName("#define ILP_NORMAL 0")]
    public const int ILP_NORMAL = 0;
    [NativeTypeName("#define ILP_DOWNLEVEL 1")]
    public const int ILP_DOWNLEVEL = 1;
    [NativeTypeName("#define HDFT_ISSTRING 0x0000")]
    public const int HDFT_ISSTRING = 0x0000;
    [NativeTypeName("#define HDFT_ISNUMBER 0x0001")]
    public const int HDFT_ISNUMBER = 0x0001;
    [NativeTypeName("#define HDFT_ISDATE 0x0002")]
    public const int HDFT_ISDATE = 0x0002;
    [NativeTypeName("#define HDFT_HASNOVALUE 0x8000")]
    public const int HDFT_HASNOVALUE = 0x8000;
    [NativeTypeName("#define HDIS_FOCUSED 0x00000001")]
    public const int HDIS_FOCUSED = 0x00000001;
    [NativeTypeName("#define HDSIL_NORMAL 0")]
    public const int HDSIL_NORMAL = 0;
    [NativeTypeName("#define HDSIL_STATE 1")]
    public const int HDSIL_STATE = 1;
    [NativeTypeName("#define TOOLBARCLASSNAMEW L\"ToolbarWindow32\"")]
    public const string TOOLBARCLASSNAMEW = "ToolbarWindow32";
    [NativeTypeName("#define TOOLBARCLASSNAMEA \"ToolbarWindow32\"")]
    public static ReadOnlySpan<byte> TOOLBARCLASSNAMEA => "ToolbarWindow32"u8;

    [NativeTypeName("#define TOOLBARCLASSNAME TOOLBARCLASSNAMEW")]
    public const string TOOLBARCLASSNAME = "ToolbarWindow32";
    [NativeTypeName("#define CMB_MASKED 0x02")]
    public const int CMB_MASKED = 0x02;
    [NativeTypeName("#define TBSTATE_CHECKED 0x01")]
    public const int TBSTATE_CHECKED = 0x01;
    [NativeTypeName("#define TBSTATE_PRESSED 0x02")]
    public const int TBSTATE_PRESSED = 0x02;
    [NativeTypeName("#define TBSTATE_ENABLED 0x04")]
    public const int TBSTATE_ENABLED = 0x04;
    [NativeTypeName("#define TBSTATE_HIDDEN 0x08")]
    public const int TBSTATE_HIDDEN = 0x08;
    [NativeTypeName("#define TBSTATE_INDETERMINATE 0x10")]
    public const int TBSTATE_INDETERMINATE = 0x10;
    [NativeTypeName("#define TBSTATE_WRAP 0x20")]
    public const int TBSTATE_WRAP = 0x20;
    [NativeTypeName("#define TBSTATE_ELLIPSES 0x40")]
    public const int TBSTATE_ELLIPSES = 0x40;
    [NativeTypeName("#define TBSTATE_MARKED 0x80")]
    public const int TBSTATE_MARKED = 0x80;
    [NativeTypeName("#define TBCDRF_NOEDGES 0x00010000")]
    public const int TBCDRF_NOEDGES = 0x00010000;
    [NativeTypeName("#define TBCDRF_HILITEHOTTRACK 0x00020000")]
    public const int TBCDRF_HILITEHOTTRACK = 0x00020000;
    [NativeTypeName("#define TBCDRF_NOOFFSET 0x00040000")]
    public const int TBCDRF_NOOFFSET = 0x00040000;
    [NativeTypeName("#define TBCDRF_NOMARK 0x00080000")]
    public const int TBCDRF_NOMARK = 0x00080000;
    [NativeTypeName("#define TBCDRF_NOETCHEDEFFECT 0x00100000")]
    public const int TBCDRF_NOETCHEDEFFECT = 0x00100000;
    [NativeTypeName("#define TBCDRF_BLENDICON 0x00200000")]
    public const int TBCDRF_BLENDICON = 0x00200000;
    [NativeTypeName("#define TBCDRF_NOBACKGROUND 0x00400000")]
    public const int TBCDRF_NOBACKGROUND = 0x00400000;
    [NativeTypeName("#define TBCDRF_USECDCOLORS 0x00800000")]
    public const int TBCDRF_USECDCOLORS = 0x00800000;
    [NativeTypeName("#define HIST_BACK 0")]
    public const int HIST_BACK = 0;
    [NativeTypeName("#define HIST_FORWARD 1")]
    public const int HIST_FORWARD = 1;
    [NativeTypeName("#define HIST_FAVORITES 2")]
    public const int HIST_FAVORITES = 2;
    [NativeTypeName("#define HIST_ADDTOFAVORITES 3")]
    public const int HIST_ADDTOFAVORITES = 3;
    [NativeTypeName("#define HIST_VIEWTREE 4")]
    public const int HIST_VIEWTREE = 4;
    [NativeTypeName("#define TBIMHT_AFTER 0x00000001")]
    public const int TBIMHT_AFTER = 0x00000001;
    [NativeTypeName("#define TBIMHT_BACKGROUND 0x00000002")]
    public const int TBIMHT_BACKGROUND = 0x00000002;
    [NativeTypeName("#define TBBF_LARGE 0x0001")]
    public const int TBBF_LARGE = 0x0001;
    [NativeTypeName("#define TBMF_PAD 0x00000001")]
    public const int TBMF_PAD = 0x00000001;
    [NativeTypeName("#define TBMF_BARPAD 0x00000002")]
    public const int TBMF_BARPAD = 0x00000002;
    [NativeTypeName("#define TBMF_BUTTONSPACING 0x00000004")]
    public const int TBMF_BUTTONSPACING = 0x00000004;
    [NativeTypeName("#define TBNRF_HIDEHELP 0x00000001")]
    public const int TBNRF_HIDEHELP = 0x00000001;
    [NativeTypeName("#define TBNRF_ENDCUSTOMIZE 0x00000002")]
    public const int TBNRF_ENDCUSTOMIZE = 0x00000002;
    [NativeTypeName("#define TBNF_IMAGE 0x00000001")]
    public const int TBNF_IMAGE = 0x00000001;
    [NativeTypeName("#define TBNF_TEXT 0x00000002")]
    public const int TBNF_TEXT = 0x00000002;
    [NativeTypeName("#define TBNF_DI_SETITEM 0x10000000")]
    public const int TBNF_DI_SETITEM = 0x10000000;
    [NativeTypeName("#define TBDDRET_DEFAULT 0")]
    public const int TBDDRET_DEFAULT = 0;
    [NativeTypeName("#define TBDDRET_NODEFAULT 1")]
    public const int TBDDRET_NODEFAULT = 1;
    [NativeTypeName("#define TBDDRET_TREATPRESSED 2")]
    public const int TBDDRET_TREATPRESSED = 2;
    [NativeTypeName("#define REBARCLASSNAMEW L\"ReBarWindow32\"")]
    public const string REBARCLASSNAMEW = "ReBarWindow32";
    [NativeTypeName("#define REBARCLASSNAMEA \"ReBarWindow32\"")]
    public static ReadOnlySpan<byte> REBARCLASSNAMEA => "ReBarWindow32"u8;

    [NativeTypeName("#define REBARCLASSNAME REBARCLASSNAMEW")]
    public const string REBARCLASSNAME = "ReBarWindow32";
    [NativeTypeName("#define RBIM_IMAGELIST 0x00000001")]
    public const int RBIM_IMAGELIST = 0x00000001;
    [NativeTypeName("#define RBS_TOOLTIPS 0x00000100")]
    public const int RBS_TOOLTIPS = 0x00000100;
    [NativeTypeName("#define RBS_VARHEIGHT 0x00000200")]
    public const int RBS_VARHEIGHT = 0x00000200;
    [NativeTypeName("#define RBS_BANDBORDERS 0x00000400")]
    public const int RBS_BANDBORDERS = 0x00000400;
    [NativeTypeName("#define RBS_FIXEDORDER 0x00000800")]
    public const int RBS_FIXEDORDER = 0x00000800;
    [NativeTypeName("#define RBS_REGISTERDROP 0x00001000")]
    public const int RBS_REGISTERDROP = 0x00001000;
    [NativeTypeName("#define RBS_AUTOSIZE 0x00002000")]
    public const int RBS_AUTOSIZE = 0x00002000;
    [NativeTypeName("#define RBS_VERTICALGRIPPER 0x00004000")]
    public const int RBS_VERTICALGRIPPER = 0x00004000;
    [NativeTypeName("#define RBS_DBLCLKTOGGLE 0x00008000")]
    public const int RBS_DBLCLKTOGGLE = 0x00008000;
    [NativeTypeName("#define RBSTR_CHANGERECT 0x0001")]
    public const int RBSTR_CHANGERECT = 0x0001;
    [NativeTypeName("#define RBNM_ID 0x00000001")]
    public const int RBNM_ID = 0x00000001;
    [NativeTypeName("#define RBNM_STYLE 0x00000002")]
    public const int RBNM_STYLE = 0x00000002;
    [NativeTypeName("#define RBNM_LPARAM 0x00000004")]
    public const int RBNM_LPARAM = 0x00000004;
    [NativeTypeName("#define RBAB_AUTOSIZE 0x0001")]
    public const int RBAB_AUTOSIZE = 0x0001;
    [NativeTypeName("#define RBAB_ADDBAND 0x0002")]
    public const int RBAB_ADDBAND = 0x0002;
    [NativeTypeName("#define RBHT_NOWHERE 0x0001")]
    public const int RBHT_NOWHERE = 0x0001;
    [NativeTypeName("#define RBHT_CAPTION 0x0002")]
    public const int RBHT_CAPTION = 0x0002;
    [NativeTypeName("#define RBHT_CLIENT 0x0003")]
    public const int RBHT_CLIENT = 0x0003;
    [NativeTypeName("#define RBHT_GRABBER 0x0004")]
    public const int RBHT_GRABBER = 0x0004;
    [NativeTypeName("#define RBHT_CHEVRON 0x0008")]
    public const int RBHT_CHEVRON = 0x0008;
    [NativeTypeName("#define RBHT_SPLITTER 0x0010")]
    public const int RBHT_SPLITTER = 0x0010;
    [NativeTypeName("#define TOOLTIPS_CLASSW L\"tooltips_class32\"")]
    public const string TOOLTIPS_CLASSW = "tooltips_class32";
    [NativeTypeName("#define TOOLTIPS_CLASSA \"tooltips_class32\"")]
    public static ReadOnlySpan<byte> TOOLTIPS_CLASSA => "tooltips_class32"u8;

    [NativeTypeName("#define TOOLTIPS_CLASS TOOLTIPS_CLASSW")]
    public const string TOOLTIPS_CLASS = "tooltips_class32";
    [NativeTypeName("#define TTS_ALWAYSTIP 0x01")]
    public const int TTS_ALWAYSTIP = 0x01;
    [NativeTypeName("#define TTS_NOPREFIX 0x02")]
    public const int TTS_NOPREFIX = 0x02;
    [NativeTypeName("#define TTS_NOANIMATE 0x10")]
    public const int TTS_NOANIMATE = 0x10;
    [NativeTypeName("#define TTS_NOFADE 0x20")]
    public const int TTS_NOFADE = 0x20;
    [NativeTypeName("#define TTS_BALLOON 0x40")]
    public const int TTS_BALLOON = 0x40;
    [NativeTypeName("#define TTS_CLOSE 0x80")]
    public const int TTS_CLOSE = 0x80;
    [NativeTypeName("#define TTS_USEVISUALSTYLE 0x100")]
    public const int TTS_USEVISUALSTYLE = 0x100;
    [NativeTypeName("#define TTF_IDISHWND 0x0001")]
    public const int TTF_IDISHWND = 0x0001;
    [NativeTypeName("#define TTF_CENTERTIP 0x0002")]
    public const int TTF_CENTERTIP = 0x0002;
    [NativeTypeName("#define TTF_RTLREADING 0x0004")]
    public const int TTF_RTLREADING = 0x0004;
    [NativeTypeName("#define TTF_SUBCLASS 0x0010")]
    public const int TTF_SUBCLASS = 0x0010;
    [NativeTypeName("#define TTF_TRACK 0x0020")]
    public const int TTF_TRACK = 0x0020;
    [NativeTypeName("#define TTF_ABSOLUTE 0x0080")]
    public const int TTF_ABSOLUTE = 0x0080;
    [NativeTypeName("#define TTF_TRANSPARENT 0x0100")]
    public const int TTF_TRANSPARENT = 0x0100;
    [NativeTypeName("#define TTF_PARSELINKS 0x1000")]
    public const int TTF_PARSELINKS = 0x1000;
    [NativeTypeName("#define TTF_DI_SETITEM 0x8000")]
    public const int TTF_DI_SETITEM = 0x8000;
    [NativeTypeName("#define TTDT_AUTOMATIC 0")]
    public const int TTDT_AUTOMATIC = 0;
    [NativeTypeName("#define TTDT_RESHOW 1")]
    public const int TTDT_RESHOW = 1;
    [NativeTypeName("#define TTDT_AUTOPOP 2")]
    public const int TTDT_AUTOPOP = 2;
    [NativeTypeName("#define TTDT_INITIAL 3")]
    public const int TTDT_INITIAL = 3;
    [NativeTypeName("#define TTI_NONE 0")]
    public const int TTI_NONE = 0;
    [NativeTypeName("#define TTI_INFO 1")]
    public const int TTI_INFO = 1;
    [NativeTypeName("#define TTI_WARNING 2")]
    public const int TTI_WARNING = 2;
    [NativeTypeName("#define TTI_ERROR 3")]
    public const int TTI_ERROR = 3;
    [NativeTypeName("#define TTI_INFO_LARGE 4")]
    public const int TTI_INFO_LARGE = 4;
    [NativeTypeName("#define TTI_WARNING_LARGE 5")]
    public const int TTI_WARNING_LARGE = 5;
    [NativeTypeName("#define TTI_ERROR_LARGE 6")]
    public const int TTI_ERROR_LARGE = 6;
    [NativeTypeName("#define SBARS_SIZEGRIP 0x0100")]
    public const int SBARS_SIZEGRIP = 0x0100;
    [NativeTypeName("#define SBARS_TOOLTIPS 0x0800")]
    public const int SBARS_TOOLTIPS = 0x0800;
    [NativeTypeName("#define SBT_TOOLTIPS 0x0800")]
    public const int SBT_TOOLTIPS = 0x0800;
    [NativeTypeName("#define CreateStatusWindow CreateStatusWindowW")]
    public static delegate*<int, ushort*, HWND, uint, HWND> CreateStatusWindow => &CreateStatusWindowW;

    [NativeTypeName("#define DrawStatusText DrawStatusTextW")]
    public static delegate*<HDC, RECT*, ushort*, uint, void> DrawStatusText => &DrawStatusTextW;

    [NativeTypeName("#define STATUSCLASSNAMEW L\"msctls_statusbar32\"")]
    public const string STATUSCLASSNAMEW = "msctls_statusbar32";
    [NativeTypeName("#define STATUSCLASSNAMEA \"msctls_statusbar32\"")]
    public static ReadOnlySpan<byte> STATUSCLASSNAMEA => "msctls_statusbar32"u8;

    [NativeTypeName("#define STATUSCLASSNAME STATUSCLASSNAMEW")]
    public const string STATUSCLASSNAME = "msctls_statusbar32";
    [NativeTypeName("#define SBT_OWNERDRAW 0x1000")]
    public const int SBT_OWNERDRAW = 0x1000;
    [NativeTypeName("#define SBT_NOBORDERS 0x0100")]
    public const int SBT_NOBORDERS = 0x0100;
    [NativeTypeName("#define SBT_POPOUT 0x0200")]
    public const int SBT_POPOUT = 0x0200;
    [NativeTypeName("#define SBT_RTLREADING 0x0400")]
    public const int SBT_RTLREADING = 0x0400;
    [NativeTypeName("#define SBT_NOTABPARSING 0x0800")]
    public const int SBT_NOTABPARSING = 0x0800;
    [NativeTypeName("#define SBN_SIMPLEMODECHANGE (SBN_FIRST - 0)")]
    public const uint SBN_SIMPLEMODECHANGE = unchecked((0U - 880U) - 0);
    [NativeTypeName("#define MINSYSCOMMAND SC_SIZE")]
    public const int MINSYSCOMMAND = 0xF000;
    [NativeTypeName("#define TRACKBAR_CLASSA \"msctls_trackbar32\"")]
    public static ReadOnlySpan<byte> TRACKBAR_CLASSA => "msctls_trackbar32"u8;

    [NativeTypeName("#define TRACKBAR_CLASSW L\"msctls_trackbar32\"")]
    public const string TRACKBAR_CLASSW = "msctls_trackbar32";
    [NativeTypeName("#define TRACKBAR_CLASS TRACKBAR_CLASSW")]
    public const string TRACKBAR_CLASS = "msctls_trackbar32";
    [NativeTypeName("#define TBTS_TOP 0")]
    public const int TBTS_TOP = 0;
    [NativeTypeName("#define TBTS_LEFT 1")]
    public const int TBTS_LEFT = 1;
    [NativeTypeName("#define TBTS_BOTTOM 2")]
    public const int TBTS_BOTTOM = 2;
    [NativeTypeName("#define TBTS_RIGHT 3")]
    public const int TBTS_RIGHT = 3;
    [NativeTypeName("#define TBCD_TICS 0x0001")]
    public const int TBCD_TICS = 0x0001;
    [NativeTypeName("#define TBCD_THUMB 0x0002")]
    public const int TBCD_THUMB = 0x0002;
    [NativeTypeName("#define TBCD_CHANNEL 0x0003")]
    public const int TBCD_CHANNEL = 0x0003;
    [NativeTypeName("#define TRBN_THUMBPOSCHANGING (TRBN_FIRST-1)")]
    public const uint TRBN_THUMBPOSCHANGING = unchecked((0U - 1501U) - 1);
    [NativeTypeName("#define DL_BEGINDRAG (WM_USER+133)")]
    public const int DL_BEGINDRAG = (0x0400 + 133);
    [NativeTypeName("#define DL_DRAGGING (WM_USER+134)")]
    public const int DL_DRAGGING = (0x0400 + 134);
    [NativeTypeName("#define DL_DROPPED (WM_USER+135)")]
    public const int DL_DROPPED = (0x0400 + 135);
    [NativeTypeName("#define DL_CANCELDRAG (WM_USER+136)")]
    public const int DL_CANCELDRAG = (0x0400 + 136);
    [NativeTypeName("#define DL_CURSORSET 0")]
    public const int DL_CURSORSET = 0;
    [NativeTypeName("#define DL_STOPCURSOR 1")]
    public const int DL_STOPCURSOR = 1;
    [NativeTypeName("#define DL_COPYCURSOR 2")]
    public const int DL_COPYCURSOR = 2;
    [NativeTypeName("#define DL_MOVECURSOR 3")]
    public const int DL_MOVECURSOR = 3;
    [NativeTypeName("#define DRAGLISTMSGSTRING TEXT(\"commctrl_DragListMsg\")")]
    public const string DRAGLISTMSGSTRING = "commctrl_DragListMsg";
    [NativeTypeName("#define UPDOWN_CLASSA \"msctls_updown32\"")]
    public static ReadOnlySpan<byte> UPDOWN_CLASSA => "msctls_updown32"u8;

    [NativeTypeName("#define UPDOWN_CLASSW L\"msctls_updown32\"")]
    public const string UPDOWN_CLASSW = "msctls_updown32";
    [NativeTypeName("#define UPDOWN_CLASS UPDOWN_CLASSW")]
    public const string UPDOWN_CLASS = "msctls_updown32";
    [NativeTypeName("#define UD_MAXVAL 0x7fff")]
    public const int UD_MAXVAL = 0x7fff;
    [NativeTypeName("#define UD_MINVAL (-UD_MAXVAL)")]
    public const int UD_MINVAL = (-0x7fff);
    [NativeTypeName("#define UDS_WRAP 0x0001")]
    public const int UDS_WRAP = 0x0001;
    [NativeTypeName("#define UDS_SETBUDDYINT 0x0002")]
    public const int UDS_SETBUDDYINT = 0x0002;
    [NativeTypeName("#define UDS_ALIGNRIGHT 0x0004")]
    public const int UDS_ALIGNRIGHT = 0x0004;
    [NativeTypeName("#define UDS_ALIGNLEFT 0x0008")]
    public const int UDS_ALIGNLEFT = 0x0008;
    [NativeTypeName("#define UDS_AUTOBUDDY 0x0010")]
    public const int UDS_AUTOBUDDY = 0x0010;
    [NativeTypeName("#define UDS_ARROWKEYS 0x0020")]
    public const int UDS_ARROWKEYS = 0x0020;
    [NativeTypeName("#define UDS_HORZ 0x0040")]
    public const int UDS_HORZ = 0x0040;
    [NativeTypeName("#define UDS_NOTHOUSANDS 0x0080")]
    public const int UDS_NOTHOUSANDS = 0x0080;
    [NativeTypeName("#define UDS_HOTTRACK 0x0100")]
    public const int UDS_HOTTRACK = 0x0100;
    [NativeTypeName("#define UDN_DELTAPOS (UDN_FIRST - 1)")]
    public const uint UDN_DELTAPOS = unchecked((0U - 721U) - 1);
    [NativeTypeName("#define PROGRESS_CLASSA \"msctls_progress32\"")]
    public static ReadOnlySpan<byte> PROGRESS_CLASSA => "msctls_progress32"u8;

    [NativeTypeName("#define PROGRESS_CLASSW L\"msctls_progress32\"")]
    public const string PROGRESS_CLASSW = "msctls_progress32";
    [NativeTypeName("#define PROGRESS_CLASS PROGRESS_CLASSW")]
    public const string PROGRESS_CLASS = "msctls_progress32";
    [NativeTypeName("#define PBS_SMOOTH 0x01")]
    public const int PBS_SMOOTH = 0x01;
    [NativeTypeName("#define PBS_VERTICAL 0x04")]
    public const int PBS_VERTICAL = 0x04;
    [NativeTypeName("#define PBS_MARQUEE 0x08")]
    public const int PBS_MARQUEE = 0x08;
    [NativeTypeName("#define PBS_SMOOTHREVERSE 0x10")]
    public const int PBS_SMOOTHREVERSE = 0x10;
    [NativeTypeName("#define PBST_NORMAL 0x0001")]
    public const int PBST_NORMAL = 0x0001;
    [NativeTypeName("#define PBST_ERROR 0x0002")]
    public const int PBST_ERROR = 0x0002;
    [NativeTypeName("#define PBST_PAUSED 0x0003")]
    public const int PBST_PAUSED = 0x0003;
    [NativeTypeName("#define HOTKEYF_SHIFT 0x01")]
    public const int HOTKEYF_SHIFT = 0x01;
    [NativeTypeName("#define HOTKEYF_CONTROL 0x02")]
    public const int HOTKEYF_CONTROL = 0x02;
    [NativeTypeName("#define HOTKEYF_ALT 0x04")]
    public const int HOTKEYF_ALT = 0x04;
    [NativeTypeName("#define HOTKEYF_EXT 0x08")]
    public const int HOTKEYF_EXT = 0x08;
    [NativeTypeName("#define HKCOMB_NONE 0x0001")]
    public const int HKCOMB_NONE = 0x0001;
    [NativeTypeName("#define HKCOMB_S 0x0002")]
    public const int HKCOMB_S = 0x0002;
    [NativeTypeName("#define HKCOMB_C 0x0004")]
    public const int HKCOMB_C = 0x0004;
    [NativeTypeName("#define HKCOMB_A 0x0008")]
    public const int HKCOMB_A = 0x0008;
    [NativeTypeName("#define HKCOMB_SC 0x0010")]
    public const int HKCOMB_SC = 0x0010;
    [NativeTypeName("#define HKCOMB_SA 0x0020")]
    public const int HKCOMB_SA = 0x0020;
    [NativeTypeName("#define HKCOMB_CA 0x0040")]
    public const int HKCOMB_CA = 0x0040;
    [NativeTypeName("#define HKCOMB_SCA 0x0080")]
    public const int HKCOMB_SCA = 0x0080;
    [NativeTypeName("#define HKM_SETHOTKEY (WM_USER+1)")]
    public const int HKM_SETHOTKEY = (0x0400 + 1);
    [NativeTypeName("#define HKM_GETHOTKEY (WM_USER+2)")]
    public const int HKM_GETHOTKEY = (0x0400 + 2);
    [NativeTypeName("#define HKM_SETRULES (WM_USER+3)")]
    public const int HKM_SETRULES = (0x0400 + 3);
    [NativeTypeName("#define HOTKEY_CLASSA \"msctls_hotkey32\"")]
    public static ReadOnlySpan<byte> HOTKEY_CLASSA => "msctls_hotkey32"u8;

    [NativeTypeName("#define HOTKEY_CLASSW L\"msctls_hotkey32\"")]
    public const string HOTKEY_CLASSW = "msctls_hotkey32";
    [NativeTypeName("#define HOTKEY_CLASS HOTKEY_CLASSW")]
    public const string HOTKEY_CLASS = "msctls_hotkey32";
    [NativeTypeName("#define INVALID_LINK_INDEX (-1)")]
    public const int INVALID_LINK_INDEX = (-1);
    [NativeTypeName("#define L_MAX_URL_LENGTH (2048 + 32 + sizeof(\"://\"))")]
    public const uint L_MAX_URL_LENGTH = (2048 + 32 + 4);
    [NativeTypeName("#define LWS_TRANSPARENT 0x0001")]
    public const int LWS_TRANSPARENT = 0x0001;
    [NativeTypeName("#define LWS_IGNORERETURN 0x0002")]
    public const int LWS_IGNORERETURN = 0x0002;
    [NativeTypeName("#define LWS_NOPREFIX 0x0004")]
    public const int LWS_NOPREFIX = 0x0004;
    [NativeTypeName("#define LWS_USEVISUALSTYLE 0x0008")]
    public const int LWS_USEVISUALSTYLE = 0x0008;
    [NativeTypeName("#define LWS_USECUSTOMTEXT 0x0010")]
    public const int LWS_USECUSTOMTEXT = 0x0010;
    [NativeTypeName("#define LWS_RIGHT 0x0020")]
    public const int LWS_RIGHT = 0x0020;
    [NativeTypeName("#define LIF_ITEMINDEX 0x00000001")]
    public const int LIF_ITEMINDEX = 0x00000001;
    [NativeTypeName("#define LIF_STATE 0x00000002")]
    public const int LIF_STATE = 0x00000002;
    [NativeTypeName("#define LIF_ITEMID 0x00000004")]
    public const int LIF_ITEMID = 0x00000004;
    [NativeTypeName("#define LIF_URL 0x00000008")]
    public const int LIF_URL = 0x00000008;
    [NativeTypeName("#define LIS_FOCUSED 0x00000001")]
    public const int LIS_FOCUSED = 0x00000001;
    [NativeTypeName("#define LIS_ENABLED 0x00000002")]
    public const int LIS_ENABLED = 0x00000002;
    [NativeTypeName("#define LIS_VISITED 0x00000004")]
    public const int LIS_VISITED = 0x00000004;
    [NativeTypeName("#define LIS_HOTTRACK 0x00000008")]
    public const int LIS_HOTTRACK = 0x00000008;
    [NativeTypeName("#define LIS_DEFAULTCOLORS 0x00000010")]
    public const int LIS_DEFAULTCOLORS = 0x00000010;
    [NativeTypeName("#define LM_HITTEST (WM_USER+0x300)")]
    public const int LM_HITTEST = (0x0400 + 0x300);
    [NativeTypeName("#define LM_GETIDEALHEIGHT (WM_USER+0x301)")]
    public const int LM_GETIDEALHEIGHT = (0x0400 + 0x301);
    [NativeTypeName("#define LM_SETITEM (WM_USER+0x302)")]
    public const int LM_SETITEM = (0x0400 + 0x302);
    [NativeTypeName("#define LM_GETITEM (WM_USER+0x303)")]
    public const int LM_GETITEM = (0x0400 + 0x303);
    [NativeTypeName("#define LM_GETIDEALSIZE (LM_GETIDEALHEIGHT)")]
    public const int LM_GETIDEALSIZE = ((0x0400 + 0x301));
    [NativeTypeName("#define LVSIL_NORMAL 0")]
    public const int LVSIL_NORMAL = 0;
    [NativeTypeName("#define LVSIL_SMALL 1")]
    public const int LVSIL_SMALL = 1;
    [NativeTypeName("#define LVSIL_STATE 2")]
    public const int LVSIL_STATE = 2;
    [NativeTypeName("#define LVSIL_GROUPHEADER 3")]
    public const int LVSIL_GROUPHEADER = 3;
    [NativeTypeName("#define LVIS_FOCUSED 0x0001")]
    public const int LVIS_FOCUSED = 0x0001;
    [NativeTypeName("#define LVIS_SELECTED 0x0002")]
    public const int LVIS_SELECTED = 0x0002;
    [NativeTypeName("#define LVIS_CUT 0x0004")]
    public const int LVIS_CUT = 0x0004;
    [NativeTypeName("#define LVIS_DROPHILITED 0x0008")]
    public const int LVIS_DROPHILITED = 0x0008;
    [NativeTypeName("#define LVIS_GLOW 0x0010")]
    public const int LVIS_GLOW = 0x0010;
    [NativeTypeName("#define LVIS_ACTIVATING 0x0020")]
    public const int LVIS_ACTIVATING = 0x0020;
    [NativeTypeName("#define LVIS_OVERLAYMASK 0x0F00")]
    public const int LVIS_OVERLAYMASK = 0x0F00;
    [NativeTypeName("#define LVIS_STATEIMAGEMASK 0xF000")]
    public const int LVIS_STATEIMAGEMASK = 0xF000;
    [NativeTypeName("#define I_INDENTCALLBACK (-1)")]
    public const int I_INDENTCALLBACK = (-1);
    [NativeTypeName("#define I_GROUPIDCALLBACK (-1)")]
    public const int I_GROUPIDCALLBACK = (-1);
    [NativeTypeName("#define I_GROUPIDNONE (-2)")]
    public const int I_GROUPIDNONE = (-2);
    [NativeTypeName("#define LPSTR_TEXTCALLBACKW ((LPWSTR)-1L)")]
    public static ushort* LPSTR_TEXTCALLBACKW => unchecked((ushort*)(-1));

    [NativeTypeName("#define LPSTR_TEXTCALLBACKA ((LPSTR)-1L)")]
    public static sbyte* LPSTR_TEXTCALLBACKA => unchecked((sbyte*)(-1));

    [NativeTypeName("#define LPSTR_TEXTCALLBACK LPSTR_TEXTCALLBACKW")]
    public static ushort* LPSTR_TEXTCALLBACK => unchecked((ushort*)(-1));

    [NativeTypeName("#define I_IMAGECALLBACK (-1)")]
    public const int I_IMAGECALLBACK = (-1);
    [NativeTypeName("#define I_IMAGENONE (-2)")]
    public const int I_IMAGENONE = (-2);
    [NativeTypeName("#define I_COLUMNSCALLBACK ((UINT)-1)")]
    public const uint I_COLUMNSCALLBACK = unchecked((uint)(-1));
    [NativeTypeName("#define LVFI_PARAM 0x0001")]
    public const int LVFI_PARAM = 0x0001;
    [NativeTypeName("#define LVFI_STRING 0x0002")]
    public const int LVFI_STRING = 0x0002;
    [NativeTypeName("#define LVFI_SUBSTRING 0x0004")]
    public const int LVFI_SUBSTRING = 0x0004;
    [NativeTypeName("#define LVFI_PARTIAL 0x0008")]
    public const int LVFI_PARTIAL = 0x0008;
    [NativeTypeName("#define LVFI_WRAP 0x0020")]
    public const int LVFI_WRAP = 0x0020;
    [NativeTypeName("#define LVFI_NEARESTXY 0x0040")]
    public const int LVFI_NEARESTXY = 0x0040;
    [NativeTypeName("#define LVIR_BOUNDS 0")]
    public const int LVIR_BOUNDS = 0;
    [NativeTypeName("#define LVIR_ICON 1")]
    public const int LVIR_ICON = 1;
    [NativeTypeName("#define LVIR_LABEL 2")]
    public const int LVIR_LABEL = 2;
    [NativeTypeName("#define LVIR_SELECTBOUNDS 3")]
    public const int LVIR_SELECTBOUNDS = 3;
    [NativeTypeName("#define LVA_DEFAULT 0x0000")]
    public const int LVA_DEFAULT = 0x0000;
    [NativeTypeName("#define LVA_ALIGNLEFT 0x0001")]
    public const int LVA_ALIGNLEFT = 0x0001;
    [NativeTypeName("#define LVA_ALIGNTOP 0x0002")]
    public const int LVA_ALIGNTOP = 0x0002;
    [NativeTypeName("#define LVA_SNAPTOGRID 0x0005")]
    public const int LVA_SNAPTOGRID = 0x0005;
    [NativeTypeName("#define LVCF_FMT 0x0001")]
    public const int LVCF_FMT = 0x0001;
    [NativeTypeName("#define LVCF_WIDTH 0x0002")]
    public const int LVCF_WIDTH = 0x0002;
    [NativeTypeName("#define LVCF_TEXT 0x0004")]
    public const int LVCF_TEXT = 0x0004;
    [NativeTypeName("#define LVCF_SUBITEM 0x0008")]
    public const int LVCF_SUBITEM = 0x0008;
    [NativeTypeName("#define LVCF_IMAGE 0x0010")]
    public const int LVCF_IMAGE = 0x0010;
    [NativeTypeName("#define LVCF_ORDER 0x0020")]
    public const int LVCF_ORDER = 0x0020;
    [NativeTypeName("#define LVCF_MINWIDTH 0x0040")]
    public const int LVCF_MINWIDTH = 0x0040;
    [NativeTypeName("#define LVCF_DEFAULTWIDTH 0x0080")]
    public const int LVCF_DEFAULTWIDTH = 0x0080;
    [NativeTypeName("#define LVCF_IDEALWIDTH 0x0100")]
    public const int LVCF_IDEALWIDTH = 0x0100;
    [NativeTypeName("#define LVSCW_AUTOSIZE -1")]
    public const int LVSCW_AUTOSIZE = -1;
    [NativeTypeName("#define LVSCW_AUTOSIZE_USEHEADER -2")]
    public const int LVSCW_AUTOSIZE_USEHEADER = -2;
    [NativeTypeName("#define LVSICF_NOINVALIDATEALL 0x00000001")]
    public const int LVSICF_NOINVALIDATEALL = 0x00000001;
    [NativeTypeName("#define LVSICF_NOSCROLL 0x00000002")]
    public const int LVSICF_NOSCROLL = 0x00000002;
    [NativeTypeName("#define LV_MAX_WORKAREAS 16")]
    public const int LV_MAX_WORKAREAS = 16;
    [NativeTypeName("#define LV_VIEW_ICON 0x0000")]
    public const int LV_VIEW_ICON = 0x0000;
    [NativeTypeName("#define LV_VIEW_DETAILS 0x0001")]
    public const int LV_VIEW_DETAILS = 0x0001;
    [NativeTypeName("#define LV_VIEW_SMALLICON 0x0002")]
    public const int LV_VIEW_SMALLICON = 0x0002;
    [NativeTypeName("#define LV_VIEW_LIST 0x0003")]
    public const int LV_VIEW_LIST = 0x0003;
    [NativeTypeName("#define LV_VIEW_TILE 0x0004")]
    public const int LV_VIEW_TILE = 0x0004;
    [NativeTypeName("#define LV_VIEW_MAX 0x0004")]
    public const int LV_VIEW_MAX = 0x0004;
    [NativeTypeName("#define LVGS_NORMAL 0x00000000")]
    public const int LVGS_NORMAL = 0x00000000;
    [NativeTypeName("#define LVGS_COLLAPSED 0x00000001")]
    public const int LVGS_COLLAPSED = 0x00000001;
    [NativeTypeName("#define LVGS_HIDDEN 0x00000002")]
    public const int LVGS_HIDDEN = 0x00000002;
    [NativeTypeName("#define LVGS_NOHEADER 0x00000004")]
    public const int LVGS_NOHEADER = 0x00000004;
    [NativeTypeName("#define LVGS_COLLAPSIBLE 0x00000008")]
    public const int LVGS_COLLAPSIBLE = 0x00000008;
    [NativeTypeName("#define LVGS_FOCUSED 0x00000010")]
    public const int LVGS_FOCUSED = 0x00000010;
    [NativeTypeName("#define LVGS_SELECTED 0x00000020")]
    public const int LVGS_SELECTED = 0x00000020;
    [NativeTypeName("#define LVGS_SUBSETED 0x00000040")]
    public const int LVGS_SUBSETED = 0x00000040;
    [NativeTypeName("#define LVGS_SUBSETLINKFOCUSED 0x00000080")]
    public const int LVGS_SUBSETLINKFOCUSED = 0x00000080;
    [NativeTypeName("#define LVGA_HEADER_LEFT 0x00000001")]
    public const int LVGA_HEADER_LEFT = 0x00000001;
    [NativeTypeName("#define LVGA_HEADER_CENTER 0x00000002")]
    public const int LVGA_HEADER_CENTER = 0x00000002;
    [NativeTypeName("#define LVGA_HEADER_RIGHT 0x00000004")]
    public const int LVGA_HEADER_RIGHT = 0x00000004;
    [NativeTypeName("#define LVGA_FOOTER_LEFT 0x00000008")]
    public const int LVGA_FOOTER_LEFT = 0x00000008;
    [NativeTypeName("#define LVGA_FOOTER_CENTER 0x00000010")]
    public const int LVGA_FOOTER_CENTER = 0x00000010;
    [NativeTypeName("#define LVGA_FOOTER_RIGHT 0x00000020")]
    public const int LVGA_FOOTER_RIGHT = 0x00000020;
    [NativeTypeName("#define LVGGR_GROUP 0")]
    public const int LVGGR_GROUP = 0;
    [NativeTypeName("#define LVGGR_HEADER 1")]
    public const int LVGGR_HEADER = 1;
    [NativeTypeName("#define LVGGR_LABEL 2")]
    public const int LVGGR_LABEL = 2;
    [NativeTypeName("#define LVGGR_SUBSETLINK 3")]
    public const int LVGGR_SUBSETLINK = 3;
    [NativeTypeName("#define LVGMF_NONE 0x00000000")]
    public const int LVGMF_NONE = 0x00000000;
    [NativeTypeName("#define LVGMF_BORDERSIZE 0x00000001")]
    public const int LVGMF_BORDERSIZE = 0x00000001;
    [NativeTypeName("#define LVGMF_BORDERCOLOR 0x00000002")]
    public const int LVGMF_BORDERCOLOR = 0x00000002;
    [NativeTypeName("#define LVGMF_TEXTCOLOR 0x00000004")]
    public const int LVGMF_TEXTCOLOR = 0x00000004;
    [NativeTypeName("#define LVTVIF_AUTOSIZE 0x00000000")]
    public const int LVTVIF_AUTOSIZE = 0x00000000;
    [NativeTypeName("#define LVTVIF_FIXEDWIDTH 0x00000001")]
    public const int LVTVIF_FIXEDWIDTH = 0x00000001;
    [NativeTypeName("#define LVTVIF_FIXEDHEIGHT 0x00000002")]
    public const int LVTVIF_FIXEDHEIGHT = 0x00000002;
    [NativeTypeName("#define LVTVIF_FIXEDSIZE 0x00000003")]
    public const int LVTVIF_FIXEDSIZE = 0x00000003;
    [NativeTypeName("#define LVTVIF_EXTENDED 0x00000004")]
    public const int LVTVIF_EXTENDED = 0x00000004;
    [NativeTypeName("#define LVTVIM_TILESIZE 0x00000001")]
    public const int LVTVIM_TILESIZE = 0x00000001;
    [NativeTypeName("#define LVTVIM_COLUMNS 0x00000002")]
    public const int LVTVIM_COLUMNS = 0x00000002;
    [NativeTypeName("#define LVTVIM_LABELMARGIN 0x00000004")]
    public const int LVTVIM_LABELMARGIN = 0x00000004;
    [NativeTypeName("#define LVIM_AFTER 0x00000001")]
    public const int LVIM_AFTER = 0x00000001;
    [NativeTypeName("#define LVFF_ITEMCOUNT 0x00000001")]
    public const int LVFF_ITEMCOUNT = 0x00000001;
    [NativeTypeName("#define LVFIF_TEXT 0x00000001")]
    public const int LVFIF_TEXT = 0x00000001;
    [NativeTypeName("#define LVFIF_STATE 0x00000002")]
    public const int LVFIF_STATE = 0x00000002;
    [NativeTypeName("#define LVFIS_FOCUSED 0x0001")]
    public const int LVFIS_FOCUSED = 0x0001;
    [NativeTypeName("#define LVKF_ALT 0x0001")]
    public const int LVKF_ALT = 0x0001;
    [NativeTypeName("#define LVKF_CONTROL 0x0002")]
    public const int LVKF_CONTROL = 0x0002;
    [NativeTypeName("#define LVKF_SHIFT 0x0004")]
    public const int LVKF_SHIFT = 0x0004;
    [NativeTypeName("#define LVCDI_ITEM 0x00000000")]
    public const int LVCDI_ITEM = 0x00000000;
    [NativeTypeName("#define LVCDI_GROUP 0x00000001")]
    public const int LVCDI_GROUP = 0x00000001;
    [NativeTypeName("#define LVCDI_ITEMSLIST 0x00000002")]
    public const int LVCDI_ITEMSLIST = 0x00000002;
    [NativeTypeName("#define LVCDRF_NOSELECT 0x00010000")]
    public const int LVCDRF_NOSELECT = 0x00010000;
    [NativeTypeName("#define LVCDRF_NOGROUPFRAME 0x00020000")]
    public const int LVCDRF_NOGROUPFRAME = 0x00020000;
    [NativeTypeName("#define LVGIT_UNFOLDED 0x0001")]
    public const int LVGIT_UNFOLDED = 0x0001;
    [NativeTypeName("#define LVNSCH_DEFAULT -1")]
    public const int LVNSCH_DEFAULT = -1;
    [NativeTypeName("#define LVNSCH_ERROR -2")]
    public const int LVNSCH_ERROR = -2;
    [NativeTypeName("#define LVNSCH_IGNORE -3")]
    public const int LVNSCH_IGNORE = -3;
    [NativeTypeName("#define EMF_CENTERED 0x00000001")]
    public const int EMF_CENTERED = 0x00000001;
    [NativeTypeName("#define I_CHILDRENCALLBACK (-1)")]
    public const int I_CHILDRENCALLBACK = (-1);
    [NativeTypeName("#define I_CHILDRENAUTO (-2)")]
    public const int I_CHILDRENAUTO = (-2);
    [NativeTypeName("#define TVE_COLLAPSE 0x0001")]
    public const int TVE_COLLAPSE = 0x0001;
    [NativeTypeName("#define TVE_EXPAND 0x0002")]
    public const int TVE_EXPAND = 0x0002;
    [NativeTypeName("#define TVE_TOGGLE 0x0003")]
    public const int TVE_TOGGLE = 0x0003;
    [NativeTypeName("#define TVE_EXPANDPARTIAL 0x4000")]
    public const int TVE_EXPANDPARTIAL = 0x4000;
    [NativeTypeName("#define TVE_COLLAPSERESET 0x8000")]
    public const int TVE_COLLAPSERESET = 0x8000;
    [NativeTypeName("#define TVSIL_NORMAL 0")]
    public const int TVSIL_NORMAL = 0;
    [NativeTypeName("#define TVSIL_STATE 2")]
    public const int TVSIL_STATE = 2;
    [NativeTypeName("#define TVSI_NOSINGLEEXPAND 0x8000")]
    public const int TVSI_NOSINGLEEXPAND = 0x8000;
    [NativeTypeName("#define TVSBF_XBORDER 0x00000001")]
    public const int TVSBF_XBORDER = 0x00000001;
    [NativeTypeName("#define TVSBF_YBORDER 0x00000002")]
    public const int TVSBF_YBORDER = 0x00000002;
    [NativeTypeName("#define TVC_UNKNOWN 0x0000")]
    public const int TVC_UNKNOWN = 0x0000;
    [NativeTypeName("#define TVC_BYMOUSE 0x0001")]
    public const int TVC_BYMOUSE = 0x0001;
    [NativeTypeName("#define TVC_BYKEYBOARD 0x0002")]
    public const int TVC_BYKEYBOARD = 0x0002;
    [NativeTypeName("#define TVNRET_DEFAULT 0")]
    public const int TVNRET_DEFAULT = 0;
    [NativeTypeName("#define TVNRET_SKIPOLD 1")]
    public const int TVNRET_SKIPOLD = 1;
    [NativeTypeName("#define TVNRET_SKIPNEW 2")]
    public const int TVNRET_SKIPNEW = 2;
    [NativeTypeName("#define TVCDRF_NOIMAGES 0x00010000")]
    public const int TVCDRF_NOIMAGES = 0x00010000;
    [NativeTypeName("#define CBEIF_TEXT 0x00000001")]
    public const int CBEIF_TEXT = 0x00000001;
    [NativeTypeName("#define CBEIF_IMAGE 0x00000002")]
    public const int CBEIF_IMAGE = 0x00000002;
    [NativeTypeName("#define CBEIF_SELECTEDIMAGE 0x00000004")]
    public const int CBEIF_SELECTEDIMAGE = 0x00000004;
    [NativeTypeName("#define CBEIF_OVERLAY 0x00000008")]
    public const int CBEIF_OVERLAY = 0x00000008;
    [NativeTypeName("#define CBEIF_INDENT 0x00000010")]
    public const int CBEIF_INDENT = 0x00000010;
    [NativeTypeName("#define CBEIF_LPARAM 0x00000020")]
    public const int CBEIF_LPARAM = 0x00000020;
    [NativeTypeName("#define CBEIF_DI_SETITEM 0x10000000")]
    public const int CBEIF_DI_SETITEM = 0x10000000;
    [NativeTypeName("#define CBES_EX_NOEDITIMAGE 0x00000001")]
    public const int CBES_EX_NOEDITIMAGE = 0x00000001;
    [NativeTypeName("#define CBES_EX_NOEDITIMAGEINDENT 0x00000002")]
    public const int CBES_EX_NOEDITIMAGEINDENT = 0x00000002;
    [NativeTypeName("#define CBES_EX_PATHWORDBREAKPROC 0x00000004")]
    public const int CBES_EX_PATHWORDBREAKPROC = 0x00000004;
    [NativeTypeName("#define CBES_EX_NOSIZELIMIT 0x00000008")]
    public const int CBES_EX_NOSIZELIMIT = 0x00000008;
    [NativeTypeName("#define CBES_EX_CASESENSITIVE 0x00000010")]
    public const int CBES_EX_CASESENSITIVE = 0x00000010;
    [NativeTypeName("#define CBES_EX_TEXTENDELLIPSIS 0x00000020")]
    public const int CBES_EX_TEXTENDELLIPSIS = 0x00000020;
    [NativeTypeName("#define CBENF_KILLFOCUS 1")]
    public const int CBENF_KILLFOCUS = 1;
    [NativeTypeName("#define CBENF_RETURN 2")]
    public const int CBENF_RETURN = 2;
    [NativeTypeName("#define CBENF_ESCAPE 3")]
    public const int CBENF_ESCAPE = 3;
    [NativeTypeName("#define CBENF_DROPDOWN 4")]
    public const int CBENF_DROPDOWN = 4;
    [NativeTypeName("#define CBEMAXSTRLEN 260")]
    public const int CBEMAXSTRLEN = 260;
    [NativeTypeName("#define TCIF_TEXT 0x0001")]
    public const int TCIF_TEXT = 0x0001;
    [NativeTypeName("#define TCIF_IMAGE 0x0002")]
    public const int TCIF_IMAGE = 0x0002;
    [NativeTypeName("#define TCIF_RTLREADING 0x0004")]
    public const int TCIF_RTLREADING = 0x0004;
    [NativeTypeName("#define TCIF_PARAM 0x0008")]
    public const int TCIF_PARAM = 0x0008;
    [NativeTypeName("#define TCIF_STATE 0x0010")]
    public const int TCIF_STATE = 0x0010;
    [NativeTypeName("#define TCIS_BUTTONPRESSED 0x0001")]
    public const int TCIS_BUTTONPRESSED = 0x0001;
    [NativeTypeName("#define TCIS_HIGHLIGHTED 0x0002")]
    public const int TCIS_HIGHLIGHTED = 0x0002;
    [NativeTypeName("#define TCHT_NOWHERE 0x0001")]
    public const int TCHT_NOWHERE = 0x0001;
    [NativeTypeName("#define TCHT_ONITEMICON 0x0002")]
    public const int TCHT_ONITEMICON = 0x0002;
    [NativeTypeName("#define TCHT_ONITEMLABEL 0x0004")]
    public const int TCHT_ONITEMLABEL = 0x0004;
    [NativeTypeName("#define TCHT_ONITEM (TCHT_ONITEMICON | TCHT_ONITEMLABEL)")]
    public const int TCHT_ONITEM = (0x0002 | 0x0004);
    [NativeTypeName("#define TCN_KEYDOWN (TCN_FIRST - 0)")]
    public const uint TCN_KEYDOWN = unchecked((0U - 550U) - 0);
    [NativeTypeName("#define TCN_SELCHANGE (TCN_FIRST - 1)")]
    public const uint TCN_SELCHANGE = unchecked((0U - 550U) - 1);
    [NativeTypeName("#define TCN_SELCHANGING (TCN_FIRST - 2)")]
    public const uint TCN_SELCHANGING = unchecked((0U - 550U) - 2);
    [NativeTypeName("#define TCN_GETOBJECT (TCN_FIRST - 3)")]
    public const uint TCN_GETOBJECT = unchecked((0U - 550U) - 3);
    [NativeTypeName("#define TCN_FOCUSCHANGE (TCN_FIRST - 4)")]
    public const uint TCN_FOCUSCHANGE = unchecked((0U - 550U) - 4);
    [NativeTypeName("#define ANIMATE_CLASSW L\"SysAnimate32\"")]
    public const string ANIMATE_CLASSW = "SysAnimate32";
    [NativeTypeName("#define ANIMATE_CLASSA \"SysAnimate32\"")]
    public static ReadOnlySpan<byte> ANIMATE_CLASSA => "SysAnimate32"u8;

    [NativeTypeName("#define ANIMATE_CLASS ANIMATE_CLASSW")]
    public const string ANIMATE_CLASS = "SysAnimate32";
    [NativeTypeName("#define ACS_CENTER 0x0001")]
    public const int ACS_CENTER = 0x0001;
    [NativeTypeName("#define ACS_TRANSPARENT 0x0002")]
    public const int ACS_TRANSPARENT = 0x0002;
    [NativeTypeName("#define ACS_AUTOPLAY 0x0004")]
    public const int ACS_AUTOPLAY = 0x0004;
    [NativeTypeName("#define ACS_TIMER 0x0008")]
    public const int ACS_TIMER = 0x0008;
    [NativeTypeName("#define ACN_START 1")]
    public const int ACN_START = 1;
    [NativeTypeName("#define ACN_STOP 2")]
    public const int ACN_STOP = 2;
    [NativeTypeName("#define MONTHCAL_CLASSW L\"SysMonthCal32\"")]
    public const string MONTHCAL_CLASSW = "SysMonthCal32";
    [NativeTypeName("#define MONTHCAL_CLASSA \"SysMonthCal32\"")]
    public static ReadOnlySpan<byte> MONTHCAL_CLASSA => "SysMonthCal32"u8;

    [NativeTypeName("#define MONTHCAL_CLASS MONTHCAL_CLASSW")]
    public const string MONTHCAL_CLASS = "SysMonthCal32";
    [NativeTypeName("#define MCSC_BACKGROUND 0")]
    public const int MCSC_BACKGROUND = 0;
    [NativeTypeName("#define MCSC_TEXT 1")]
    public const int MCSC_TEXT = 1;
    [NativeTypeName("#define MCSC_TITLEBK 2")]
    public const int MCSC_TITLEBK = 2;
    [NativeTypeName("#define MCSC_TITLETEXT 3")]
    public const int MCSC_TITLETEXT = 3;
    [NativeTypeName("#define MCSC_MONTHBK 4")]
    public const int MCSC_MONTHBK = 4;
    [NativeTypeName("#define MCSC_TRAILINGTEXT 5")]
    public const int MCSC_TRAILINGTEXT = 5;
    [NativeTypeName("#define MCMV_MONTH 0")]
    public const int MCMV_MONTH = 0;
    [NativeTypeName("#define MCMV_YEAR 1")]
    public const int MCMV_YEAR = 1;
    [NativeTypeName("#define MCMV_DECADE 2")]
    public const int MCMV_DECADE = 2;
    [NativeTypeName("#define MCMV_CENTURY 3")]
    public const int MCMV_CENTURY = 3;
    [NativeTypeName("#define MCMV_MAX MCMV_CENTURY")]
    public const int MCMV_MAX = 3;
    [NativeTypeName("#define MCGIP_CALENDARCONTROL 0")]
    public const int MCGIP_CALENDARCONTROL = 0;
    [NativeTypeName("#define MCGIP_NEXT 1")]
    public const int MCGIP_NEXT = 1;
    [NativeTypeName("#define MCGIP_PREV 2")]
    public const int MCGIP_PREV = 2;
    [NativeTypeName("#define MCGIP_FOOTER 3")]
    public const int MCGIP_FOOTER = 3;
    [NativeTypeName("#define MCGIP_CALENDAR 4")]
    public const int MCGIP_CALENDAR = 4;
    [NativeTypeName("#define MCGIP_CALENDARHEADER 5")]
    public const int MCGIP_CALENDARHEADER = 5;
    [NativeTypeName("#define MCGIP_CALENDARBODY 6")]
    public const int MCGIP_CALENDARBODY = 6;
    [NativeTypeName("#define MCGIP_CALENDARROW 7")]
    public const int MCGIP_CALENDARROW = 7;
    [NativeTypeName("#define MCGIP_CALENDARCELL 8")]
    public const int MCGIP_CALENDARCELL = 8;
    [NativeTypeName("#define MCGIF_DATE 0x00000001")]
    public const int MCGIF_DATE = 0x00000001;
    [NativeTypeName("#define MCGIF_RECT 0x00000002")]
    public const int MCGIF_RECT = 0x00000002;
    [NativeTypeName("#define MCGIF_NAME 0x00000004")]
    public const int MCGIF_NAME = 0x00000004;
    [NativeTypeName("#define MCN_SELCHANGE (MCN_FIRST - 3)")]
    public const uint MCN_SELCHANGE = unchecked((0U - 746U) - 3);
    [NativeTypeName("#define MCN_GETDAYSTATE (MCN_FIRST - 1)")]
    public const uint MCN_GETDAYSTATE = unchecked((0U - 746U) - 1);
    [NativeTypeName("#define MCN_SELECT (MCN_FIRST)")]
    public const uint MCN_SELECT = unchecked((0U - 746U));
    [NativeTypeName("#define MCN_VIEWCHANGE (MCN_FIRST - 4)")]
    public const uint MCN_VIEWCHANGE = unchecked((0U - 746U) - 4);
    [NativeTypeName("#define MCS_DAYSTATE 0x0001")]
    public const int MCS_DAYSTATE = 0x0001;
    [NativeTypeName("#define MCS_MULTISELECT 0x0002")]
    public const int MCS_MULTISELECT = 0x0002;
    [NativeTypeName("#define MCS_WEEKNUMBERS 0x0004")]
    public const int MCS_WEEKNUMBERS = 0x0004;
    [NativeTypeName("#define MCS_NOTODAYCIRCLE 0x0008")]
    public const int MCS_NOTODAYCIRCLE = 0x0008;
    [NativeTypeName("#define MCS_NOTODAY 0x0010")]
    public const int MCS_NOTODAY = 0x0010;
    [NativeTypeName("#define MCS_NOTRAILINGDATES 0x0040")]
    public const int MCS_NOTRAILINGDATES = 0x0040;
    [NativeTypeName("#define MCS_SHORTDAYSOFWEEK 0x0080")]
    public const int MCS_SHORTDAYSOFWEEK = 0x0080;
    [NativeTypeName("#define MCS_NOSELCHANGEONNAV 0x0100")]
    public const int MCS_NOSELCHANGEONNAV = 0x0100;
    [NativeTypeName("#define GMR_VISIBLE 0")]
    public const int GMR_VISIBLE = 0;
    [NativeTypeName("#define GMR_DAYSTATE 1")]
    public const int GMR_DAYSTATE = 1;
    [NativeTypeName("#define DATETIMEPICK_CLASSW L\"SysDateTimePick32\"")]
    public const string DATETIMEPICK_CLASSW = "SysDateTimePick32";
    [NativeTypeName("#define DATETIMEPICK_CLASSA \"SysDateTimePick32\"")]
    public static ReadOnlySpan<byte> DATETIMEPICK_CLASSA => "SysDateTimePick32"u8;

    [NativeTypeName("#define DATETIMEPICK_CLASS DATETIMEPICK_CLASSW")]
    public const string DATETIMEPICK_CLASS = "SysDateTimePick32";
    [NativeTypeName("#define DTS_UPDOWN 0x0001")]
    public const int DTS_UPDOWN = 0x0001;
    [NativeTypeName("#define DTS_SHOWNONE 0x0002")]
    public const int DTS_SHOWNONE = 0x0002;
    [NativeTypeName("#define DTS_SHORTDATEFORMAT 0x0000")]
    public const int DTS_SHORTDATEFORMAT = 0x0000;
    [NativeTypeName("#define DTS_LONGDATEFORMAT 0x0004")]
    public const int DTS_LONGDATEFORMAT = 0x0004;
    [NativeTypeName("#define DTS_SHORTDATECENTURYFORMAT 0x000C")]
    public const int DTS_SHORTDATECENTURYFORMAT = 0x000C;
    [NativeTypeName("#define DTS_TIMEFORMAT 0x0009")]
    public const int DTS_TIMEFORMAT = 0x0009;
    [NativeTypeName("#define DTS_APPCANPARSE 0x0010")]
    public const int DTS_APPCANPARSE = 0x0010;
    [NativeTypeName("#define DTS_RIGHTALIGN 0x0020")]
    public const int DTS_RIGHTALIGN = 0x0020;
    [NativeTypeName("#define GDTR_MIN 0x0001")]
    public const int GDTR_MIN = 0x0001;
    [NativeTypeName("#define GDTR_MAX 0x0002")]
    public const int GDTR_MAX = 0x0002;
    [NativeTypeName("#define GDT_ERROR -1")]
    public const int GDT_ERROR = -1;
    [NativeTypeName("#define GDT_VALID 0")]
    public const int GDT_VALID = 0;
    [NativeTypeName("#define GDT_NONE 1")]
    public const int GDT_NONE = 1;
    [NativeTypeName("#define IPM_CLEARADDRESS (WM_USER+100)")]
    public const int IPM_CLEARADDRESS = (0x0400 + 100);
    [NativeTypeName("#define IPM_SETADDRESS (WM_USER+101)")]
    public const int IPM_SETADDRESS = (0x0400 + 101);
    [NativeTypeName("#define IPM_GETADDRESS (WM_USER+102)")]
    public const int IPM_GETADDRESS = (0x0400 + 102);
    [NativeTypeName("#define IPM_SETRANGE (WM_USER+103)")]
    public const int IPM_SETRANGE = (0x0400 + 103);
    [NativeTypeName("#define IPM_SETFOCUS (WM_USER+104)")]
    public const int IPM_SETFOCUS = (0x0400 + 104);
    [NativeTypeName("#define IPM_ISBLANK (WM_USER+105)")]
    public const int IPM_ISBLANK = (0x0400 + 105);
    [NativeTypeName("#define IPN_FIELDCHANGED (IPN_FIRST - 0)")]
    public const uint IPN_FIELDCHANGED = unchecked((0U - 860U) - 0);
    [NativeTypeName("#define PGS_VERT 0x00000000")]
    public const int PGS_VERT = 0x00000000;
    [NativeTypeName("#define PGS_HORZ 0x00000001")]
    public const int PGS_HORZ = 0x00000001;
    [NativeTypeName("#define PGS_AUTOSCROLL 0x00000002")]
    public const int PGS_AUTOSCROLL = 0x00000002;
    [NativeTypeName("#define PGS_DRAGNDROP 0x00000004")]
    public const int PGS_DRAGNDROP = 0x00000004;
    [NativeTypeName("#define PGB_TOPORLEFT 0")]
    public const int PGB_TOPORLEFT = 0;
    [NativeTypeName("#define PGB_BOTTOMORRIGHT 1")]
    public const int PGB_BOTTOMORRIGHT = 1;
    [NativeTypeName("#define PGN_SCROLL (PGN_FIRST-1)")]
    public const uint PGN_SCROLL = unchecked((0U - 900U) - 1);
    [NativeTypeName("#define PGK_SHIFT 1")]
    public const int PGK_SHIFT = 1;
    [NativeTypeName("#define PGK_CONTROL 2")]
    public const int PGK_CONTROL = 2;
    [NativeTypeName("#define PGK_MENU 4")]
    public const int PGK_MENU = 4;
    [NativeTypeName("#define PGN_CALCSIZE (PGN_FIRST-2)")]
    public const uint PGN_CALCSIZE = unchecked((0U - 900U) - 2);
    [NativeTypeName("#define PGN_HOTITEMCHANGE (PGN_FIRST-3)")]
    public const uint PGN_HOTITEMCHANGE = unchecked((0U - 900U) - 3);
    [NativeTypeName("#define NFS_EDIT 0x0001")]
    public const int NFS_EDIT = 0x0001;
    [NativeTypeName("#define NFS_STATIC 0x0002")]
    public const int NFS_STATIC = 0x0002;
    [NativeTypeName("#define NFS_LISTCOMBO 0x0004")]
    public const int NFS_LISTCOMBO = 0x0004;
    [NativeTypeName("#define NFS_BUTTON 0x0008")]
    public const int NFS_BUTTON = 0x0008;
    [NativeTypeName("#define NFS_ALL 0x0010")]
    public const int NFS_ALL = 0x0010;
    [NativeTypeName("#define NFS_USEFONTASSOC 0x0020")]
    public const int NFS_USEFONTASSOC = 0x0020;
    [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_LEFT 0")]
    public const int BUTTON_IMAGELIST_ALIGN_LEFT = 0;
    [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_RIGHT 1")]
    public const int BUTTON_IMAGELIST_ALIGN_RIGHT = 1;
    [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_TOP 2")]
    public const int BUTTON_IMAGELIST_ALIGN_TOP = 2;
    [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_BOTTOM 3")]
    public const int BUTTON_IMAGELIST_ALIGN_BOTTOM = 3;
    [NativeTypeName("#define BUTTON_IMAGELIST_ALIGN_CENTER 4")]
    public const int BUTTON_IMAGELIST_ALIGN_CENTER = 4;
    [NativeTypeName("#define BCN_HOTITEMCHANGE (BCN_FIRST + 0x0001)")]
    public const uint BCN_HOTITEMCHANGE = unchecked((0U - 1250U) + 0x0001);
    [NativeTypeName("#define BST_HOT 0x0200")]
    public const int BST_HOT = 0x0200;
    [NativeTypeName("#define BST_DROPDOWNPUSHED 0x0400")]
    public const int BST_DROPDOWNPUSHED = 0x0400;
    [NativeTypeName("#define BCSIF_GLYPH 0x0001")]
    public const int BCSIF_GLYPH = 0x0001;
    [NativeTypeName("#define BCSIF_IMAGE 0x0002")]
    public const int BCSIF_IMAGE = 0x0002;
    [NativeTypeName("#define BCSIF_STYLE 0x0004")]
    public const int BCSIF_STYLE = 0x0004;
    [NativeTypeName("#define BCSIF_SIZE 0x0008")]
    public const int BCSIF_SIZE = 0x0008;
    [NativeTypeName("#define BCSS_NOSPLIT 0x0001")]
    public const int BCSS_NOSPLIT = 0x0001;
    [NativeTypeName("#define BCSS_STRETCH 0x0002")]
    public const int BCSS_STRETCH = 0x0002;
    [NativeTypeName("#define BCSS_ALIGNLEFT 0x0004")]
    public const int BCSS_ALIGNLEFT = 0x0004;
    [NativeTypeName("#define BCSS_IMAGE 0x0008")]
    public const int BCSS_IMAGE = 0x0008;
    [NativeTypeName("#define BCN_DROPDOWN (BCN_FIRST + 0x0002)")]
    public const uint BCN_DROPDOWN = unchecked((0U - 1250U) + 0x0002);
    [NativeTypeName("#define FSB_FLAT_MODE 2")]
    public const int FSB_FLAT_MODE = 2;
    [NativeTypeName("#define FSB_ENCARTA_MODE 1")]
    public const int FSB_ENCARTA_MODE = 1;
    [NativeTypeName("#define FSB_REGULAR_MODE 0")]
    public const int FSB_REGULAR_MODE = 0;
    [NativeTypeName("#define FlatSB_SetScrollPropPtr FlatSB_SetScrollProp")]
    public static delegate*<HWND, uint, nint, BOOL, BOOL> FlatSB_SetScrollPropPtr => &FlatSB_SetScrollProp;
}