// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddFontResourceA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int AddFontResourceA([NativeTypeName("LPCSTR")] sbyte* param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddFontResourceW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int AddFontResourceW([NativeTypeName("LPCWSTR")] ushort* param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AnimatePalette"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL AnimatePalette(HPALETTE hPal, uint iStartIndex, uint cEntries, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* ppe);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Arc"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL Arc(HDC hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BitBlt"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BitBlt(HDC hdc, int x, int y, int cx, int cy, HDC hdcSrc, int x1, int y1, [NativeTypeName("DWORD")] uint rop);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CancelDC"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL CancelDC(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Chord"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL Chord(HDC hdc, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChoosePixelFormat"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int ChoosePixelFormat(HDC hdc, [NativeTypeName("const PIXELFORMATDESCRIPTOR *")] PIXELFORMATDESCRIPTOR* ppfd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseMetaFile"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HMETAFILE CloseMetaFile(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CombineRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int CombineRgn(HRGN hrgnDst, HRGN hrgnSrc1, HRGN hrgnSrc2, int iMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyMetaFileA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HMETAFILE CopyMetaFileA(HMETAFILE param0, [NativeTypeName("LPCSTR")] sbyte* param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyMetaFileW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HMETAFILE CopyMetaFileW(HMETAFILE param0, [NativeTypeName("LPCWSTR")] ushort* param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateBitmap"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HBITMAP CreateBitmap(int nWidth, int nHeight, uint nPlanes, uint nBitCount, [NativeTypeName("const void *")] void* lpBits);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateBitmapIndirect"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HBITMAP CreateBitmapIndirect([NativeTypeName("const BITMAP *")] BITMAP* pbm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateBrushIndirect"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HBRUSH CreateBrushIndirect([NativeTypeName("const LOGBRUSH *")] LOGBRUSH* plbrush);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateCompatibleBitmap"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HBITMAP CreateCompatibleBitmap(HDC hdc, int cx, int cy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDiscardableBitmap"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HBITMAP CreateDiscardableBitmap(HDC hdc, int cx, int cy);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateCompatibleDC"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HDC CreateCompatibleDC(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDCA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HDC CreateDCA([NativeTypeName("LPCSTR")] sbyte* pwszDriver, [NativeTypeName("LPCSTR")] sbyte* pwszDevice, [NativeTypeName("LPCSTR")] sbyte* pszPort, [NativeTypeName("const DEVMODEA *")] DEVMODEA* pdm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDCW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HDC CreateDCW([NativeTypeName("LPCWSTR")] ushort* pwszDriver, [NativeTypeName("LPCWSTR")] ushort* pwszDevice, [NativeTypeName("LPCWSTR")] ushort* pszPort, [NativeTypeName("const DEVMODEW *")] DEVMODEW* pdm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDIBitmap"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HBITMAP CreateDIBitmap(HDC hdc, [NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmih, [NativeTypeName("DWORD")] uint flInit, [NativeTypeName("const void *")] void* pjBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* pbmi, uint iUsage);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDIBPatternBrush"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HBRUSH CreateDIBPatternBrush(HGLOBAL h, uint iUsage);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDIBPatternBrushPt"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HBRUSH CreateDIBPatternBrushPt([NativeTypeName("const void *")] void* lpPackedDIB, uint iUsage);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateEllipticRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HRGN CreateEllipticRgn(int x1, int y1, int x2, int y2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateEllipticRgnIndirect"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HRGN CreateEllipticRgnIndirect([NativeTypeName("const RECT *")] RECT* lprect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFontIndirectA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HFONT CreateFontIndirectA([NativeTypeName("const LOGFONTA *")] LOGFONTA* lplf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFontIndirectW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HFONT CreateFontIndirectW([NativeTypeName("const LOGFONTW *")] LOGFONTW* lplf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFontA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HFONT CreateFontA(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, [NativeTypeName("DWORD")] uint bItalic, [NativeTypeName("DWORD")] uint bUnderline, [NativeTypeName("DWORD")] uint bStrikeOut, [NativeTypeName("DWORD")] uint iCharSet, [NativeTypeName("DWORD")] uint iOutPrecision, [NativeTypeName("DWORD")] uint iClipPrecision, [NativeTypeName("DWORD")] uint iQuality, [NativeTypeName("DWORD")] uint iPitchAndFamily, [NativeTypeName("LPCSTR")] sbyte* pszFaceName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFontW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HFONT CreateFontW(int cHeight, int cWidth, int cEscapement, int cOrientation, int cWeight, [NativeTypeName("DWORD")] uint bItalic, [NativeTypeName("DWORD")] uint bUnderline, [NativeTypeName("DWORD")] uint bStrikeOut, [NativeTypeName("DWORD")] uint iCharSet, [NativeTypeName("DWORD")] uint iOutPrecision, [NativeTypeName("DWORD")] uint iClipPrecision, [NativeTypeName("DWORD")] uint iQuality, [NativeTypeName("DWORD")] uint iPitchAndFamily, [NativeTypeName("LPCWSTR")] ushort* pszFaceName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateHatchBrush"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HBRUSH CreateHatchBrush(int iHatch, COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateICA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HDC CreateICA([NativeTypeName("LPCSTR")] sbyte* pszDriver, [NativeTypeName("LPCSTR")] sbyte* pszDevice, [NativeTypeName("LPCSTR")] sbyte* pszPort, [NativeTypeName("const DEVMODEA *")] DEVMODEA* pdm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateICW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HDC CreateICW([NativeTypeName("LPCWSTR")] ushort* pszDriver, [NativeTypeName("LPCWSTR")] ushort* pszDevice, [NativeTypeName("LPCWSTR")] ushort* pszPort, [NativeTypeName("const DEVMODEW *")] DEVMODEW* pdm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMetaFileA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HDC CreateMetaFileA([NativeTypeName("LPCSTR")] sbyte* pszFile);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateMetaFileW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HDC CreateMetaFileW([NativeTypeName("LPCWSTR")] ushort* pszFile);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePalette"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HPALETTE CreatePalette([NativeTypeName("const LOGPALETTE *")] LOGPALETTE* plpal);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePen"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HPEN CreatePen(int iStyle, int cWidth, COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePenIndirect"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HPEN CreatePenIndirect([NativeTypeName("const LOGPEN *")] LOGPEN* plpen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePolyPolygonRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HRGN CreatePolyPolygonRgn([NativeTypeName("const POINT *")] POINT* pptl, [NativeTypeName("const INT *")] int* pc, int cPoly, int iMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePatternBrush"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HBRUSH CreatePatternBrush(HBITMAP hbm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateRectRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HRGN CreateRectRgn(int x1, int y1, int x2, int y2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateRectRgnIndirect"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HRGN CreateRectRgnIndirect([NativeTypeName("const RECT *")] RECT* lprect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateRoundRectRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HRGN CreateRoundRectRgn(int x1, int y1, int x2, int y2, int w, int h);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateScalableFontResourceA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateScalableFontResourceA([NativeTypeName("DWORD")] uint fdwHidden, [NativeTypeName("LPCSTR")] sbyte* lpszFont, [NativeTypeName("LPCSTR")] sbyte* lpszFile, [NativeTypeName("LPCSTR")] sbyte* lpszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateScalableFontResourceW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateScalableFontResourceW([NativeTypeName("DWORD")] uint fdwHidden, [NativeTypeName("LPCWSTR")] ushort* lpszFont, [NativeTypeName("LPCWSTR")] ushort* lpszFile, [NativeTypeName("LPCWSTR")] ushort* lpszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateSolidBrush"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HBRUSH CreateSolidBrush(COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteDC"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL DeleteDC(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteMetaFile"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL DeleteMetaFile(HMETAFILE hmf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteObject"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL DeleteObject(HGDIOBJ ho);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DescribePixelFormat"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int DescribePixelFormat(HDC hdc, int iPixelFormat, uint nBytes, [NativeTypeName("LPPIXELFORMATDESCRIPTOR")] PIXELFORMATDESCRIPTOR* ppfd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DrawEscape"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int DrawEscape(HDC hdc, int iEscape, int cjIn, [NativeTypeName("LPCSTR")] sbyte* lpIn);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Ellipse"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL Ellipse(HDC hdc, int left, int top, int right, int bottom);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumFontFamiliesExA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int EnumFontFamiliesExA(HDC hdc, [NativeTypeName("LPLOGFONTA")] LOGFONTA* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* unmanaged<LOGFONTA*, TEXTMETRICA*, uint, LPARAM, int> lpProc, LPARAM lParam, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumFontFamiliesExW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int EnumFontFamiliesExW(HDC hdc, [NativeTypeName("LPLOGFONTW")] LOGFONTW* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, LPARAM, int> lpProc, LPARAM lParam, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumFontFamiliesA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int EnumFontFamiliesA(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* unmanaged<LOGFONTA*, TEXTMETRICA*, uint, LPARAM, int> lpProc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumFontFamiliesW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int EnumFontFamiliesW(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, LPARAM, int> lpProc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumFontsA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int EnumFontsA(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpLogfont, [NativeTypeName("FONTENUMPROCA")] delegate* unmanaged<LOGFONTA*, TEXTMETRICA*, uint, LPARAM, int> lpProc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumFontsW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int EnumFontsW(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpLogfont, [NativeTypeName("FONTENUMPROCW")] delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, LPARAM, int> lpProc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumObjects"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int EnumObjects(HDC hdc, int nType, [NativeTypeName("GOBJENUMPROC")] delegate* unmanaged<void*, LPARAM, int> lpFunc, LPARAM lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EqualRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL EqualRgn(HRGN hrgn1, HRGN hrgn2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Escape"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int Escape(HDC hdc, int iEscape, int cjIn, [NativeTypeName("LPCSTR")] sbyte* pvIn, [NativeTypeName("LPVOID")] void* pvOut);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtEscape"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int ExtEscape(HDC hdc, int iEscape, int cjInput, [NativeTypeName("LPCSTR")] sbyte* lpInData, int cjOutput, [NativeTypeName("LPSTR")] sbyte* lpOutData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExcludeClipRect"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int ExcludeClipRect(HDC hdc, int left, int top, int right, int bottom);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtCreateRegion"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HRGN ExtCreateRegion([NativeTypeName("const XFORM *")] XFORM* lpx, [NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const RGNDATA *")] RGNDATA* lpData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtFloodFill"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL ExtFloodFill(HDC hdc, int x, int y, COLORREF color, uint type);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FillRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL FillRgn(HDC hdc, HRGN hrgn, HBRUSH hbr);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FloodFill"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL FloodFill(HDC hdc, int x, int y, COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FrameRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL FrameRgn(HDC hdc, HRGN hrgn, HBRUSH hbr, int w, int h);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetROP2"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetROP2(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAspectRatioFilterEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetAspectRatioFilterEx(HDC hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBkColor"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern COLORREF GetBkColor(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDCBrushColor"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern COLORREF GetDCBrushColor(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDCPenColor"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern COLORREF GetDCPenColor(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBkMode"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetBkMode(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBitmapBits"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int GetBitmapBits(HBITMAP hbit, [NativeTypeName("LONG")] int cb, [NativeTypeName("LPVOID")] void* lpvBits);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBitmapDimensionEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetBitmapDimensionEx(HBITMAP hbit, [NativeTypeName("LPSIZE")] SIZE* lpsize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBoundsRect"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetBoundsRect(HDC hdc, [NativeTypeName("LPRECT")] RECT* lprect, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetBrushOrgEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetBrushOrgEx(HDC hdc, [NativeTypeName("LPPOINT")] POINT* lppt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharWidthA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharWidthA(HDC hdc, uint iFirst, uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharWidthW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharWidthW(HDC hdc, uint iFirst, uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharWidth32A"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharWidth32A(HDC hdc, uint iFirst, uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharWidth32W"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharWidth32W(HDC hdc, uint iFirst, uint iLast, [NativeTypeName("LPINT")] int* lpBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharWidthFloatA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharWidthFloatA(HDC hdc, uint iFirst, uint iLast, [NativeTypeName("PFLOAT")] float* lpBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharWidthFloatW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharWidthFloatW(HDC hdc, uint iFirst, uint iLast, [NativeTypeName("PFLOAT")] float* lpBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharABCWidthsA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharABCWidthsA(HDC hdc, uint wFirst, uint wLast, [NativeTypeName("LPABC")] ABC* lpABC);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharABCWidthsW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharABCWidthsW(HDC hdc, uint wFirst, uint wLast, [NativeTypeName("LPABC")] ABC* lpABC);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharABCWidthsFloatA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharABCWidthsFloatA(HDC hdc, uint iFirst, uint iLast, [NativeTypeName("LPABCFLOAT")] ABCFLOAT* lpABC);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharABCWidthsFloatW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharABCWidthsFloatW(HDC hdc, uint iFirst, uint iLast, [NativeTypeName("LPABCFLOAT")] ABCFLOAT* lpABC);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClipBox"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetClipBox(HDC hdc, [NativeTypeName("LPRECT")] RECT* lprect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetClipRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetClipRgn(HDC hdc, HRGN hrgn);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMetaRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetMetaRgn(HDC hdc, HRGN hrgn);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentObject"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HGDIOBJ GetCurrentObject(HDC hdc, uint type);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentPositionEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCurrentPositionEx(HDC hdc, [NativeTypeName("LPPOINT")] POINT* lppt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDeviceCaps"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetDeviceCaps(HDC hdc, int index);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDIBits"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetDIBits(HDC hdc, HBITMAP hbm, uint start, uint cLines, [NativeTypeName("LPVOID")] void* lpvBits, [NativeTypeName("LPBITMAPINFO")] BITMAPINFO* lpbmi, uint usage);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFontData"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFontData(HDC hdc, [NativeTypeName("DWORD")] uint dwTable, [NativeTypeName("DWORD")] uint dwOffset, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("DWORD")] uint cjBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGlyphOutlineA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetGlyphOutlineA(HDC hdc, uint uChar, uint fuFormat, [NativeTypeName("LPGLYPHMETRICS")] GLYPHMETRICS* lpgm, [NativeTypeName("DWORD")] uint cjBuffer, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("const MAT2 *")] MAT2* lpmat2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGlyphOutlineW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetGlyphOutlineW(HDC hdc, uint uChar, uint fuFormat, [NativeTypeName("LPGLYPHMETRICS")] GLYPHMETRICS* lpgm, [NativeTypeName("DWORD")] uint cjBuffer, [NativeTypeName("LPVOID")] void* pvBuffer, [NativeTypeName("const MAT2 *")] MAT2* lpmat2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGraphicsMode"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetGraphicsMode(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMapMode"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetMapMode(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMetaFileBitsEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetMetaFileBitsEx(HMETAFILE hMF, uint cbBuffer, [NativeTypeName("LPVOID")] void* lpData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMetaFileA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HMETAFILE GetMetaFileA([NativeTypeName("LPCSTR")] sbyte* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMetaFileW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HMETAFILE GetMetaFileW([NativeTypeName("LPCWSTR")] ushort* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNearestColor"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern COLORREF GetNearestColor(HDC hdc, COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNearestPaletteIndex"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetNearestPaletteIndex(HPALETTE h, COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetObjectType"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetObjectType(HGDIOBJ h);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetOutlineTextMetricsA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetOutlineTextMetricsA(HDC hdc, uint cjCopy, [NativeTypeName("LPOUTLINETEXTMETRICA")] OUTLINETEXTMETRICA* potm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetOutlineTextMetricsW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetOutlineTextMetricsW(HDC hdc, uint cjCopy, [NativeTypeName("LPOUTLINETEXTMETRICW")] OUTLINETEXTMETRICW* potm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPaletteEntries"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetPaletteEntries(HPALETTE hpal, uint iStart, uint cEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* pPalEntries);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPixel"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern COLORREF GetPixel(HDC hdc, int x, int y);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPixelFormat"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int GetPixelFormat(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPolyFillMode"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetPolyFillMode(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRasterizerCaps"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetRasterizerCaps([NativeTypeName("LPRASTERIZER_STATUS")] RASTERIZER_STATUS* lpraststat, uint cjBytes);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRandomRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetRandomRgn(HDC hdc, HRGN hrgn, int i);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRegionData"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetRegionData(HRGN hrgn, [NativeTypeName("DWORD")] uint nCount, [NativeTypeName("LPRGNDATA")] RGNDATA* lpRgnData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetRgnBox"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetRgnBox(HRGN hrgn, [NativeTypeName("LPRECT")] RECT* lprc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetStockObject"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HGDIOBJ GetStockObject(int i);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetStretchBltMode"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetStretchBltMode(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemPaletteEntries"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetSystemPaletteEntries(HDC hdc, uint iStart, uint cEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* pPalEntries);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemPaletteUse"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetSystemPaletteUse(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextCharacterExtra"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetTextCharacterExtra(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextAlign"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetTextAlign(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextColor"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern COLORREF GetTextColor(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextExtentPointA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetTextExtentPointA(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextExtentPointW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetTextExtentPointW(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextExtentPoint32A"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetTextExtentPoint32A(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* psizl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextExtentPoint32W"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetTextExtentPoint32W(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int c, [NativeTypeName("LPSIZE")] SIZE* psizl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextExtentExPointA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetTextExtentExPointA(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpszString, int cchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextExtentExPointW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetTextExtentExPointW(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpszString, int cchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextCharset"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetTextCharset(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextCharsetInfo"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetTextCharsetInfo(HDC hdc, [NativeTypeName("LPFONTSIGNATURE")] FONTSIGNATURE* lpSig, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TranslateCharsetInfo"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TranslateCharsetInfo([NativeTypeName("DWORD *")] uint* lpSrc, [NativeTypeName("LPCHARSETINFO")] CHARSETINFO* lpCs, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFontLanguageInfo"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFontLanguageInfo(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharacterPlacementA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCharacterPlacementA(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpString, int nCount, int nMexExtent, [NativeTypeName("LPGCP_RESULTSA")] GCP_RESULTSA* lpResults, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharacterPlacementW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCharacterPlacementW(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpString, int nCount, int nMexExtent, [NativeTypeName("LPGCP_RESULTSW")] GCP_RESULTSW* lpResults, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFontUnicodeRanges"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFontUnicodeRanges(HDC hdc, [NativeTypeName("LPGLYPHSET")] GLYPHSET* lpgs);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGlyphIndicesA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetGlyphIndicesA(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpstr, int c, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("DWORD")] uint fl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetGlyphIndicesW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetGlyphIndicesW(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpstr, int c, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("DWORD")] uint fl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextExtentPointI"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetTextExtentPointI(HDC hdc, [NativeTypeName("LPWORD")] ushort* pgiIn, int cgi, [NativeTypeName("LPSIZE")] SIZE* psize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextExtentExPointI"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetTextExtentExPointI(HDC hdc, [NativeTypeName("LPWORD")] ushort* lpwszString, int cwchString, int nMaxExtent, [NativeTypeName("LPINT")] int* lpnFit, [NativeTypeName("LPINT")] int* lpnDx, [NativeTypeName("LPSIZE")] SIZE* lpSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharWidthI"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharWidthI(HDC hdc, uint giFirst, uint cgi, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("LPINT")] int* piWidths);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCharABCWidthsI"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetCharABCWidthsI(HDC hdc, uint giFirst, uint cgi, [NativeTypeName("LPWORD")] ushort* pgi, [NativeTypeName("LPABC")] ABC* pabc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddFontResourceExA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int AddFontResourceExA([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* res);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddFontResourceExW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int AddFontResourceExW([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* res);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveFontResourceExA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL RemoveFontResourceExA([NativeTypeName("LPCSTR")] sbyte* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* pdv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveFontResourceExW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL RemoveFontResourceExW([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("DWORD")] uint fl, [NativeTypeName("PVOID")] void* pdv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddFontMemResourceEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HANDLE AddFontMemResourceEx([NativeTypeName("PVOID")] void* pFileView, [NativeTypeName("DWORD")] uint cjSize, [NativeTypeName("PVOID")] void* pvResrved, [NativeTypeName("DWORD *")] uint* pNumFonts);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveFontMemResourceEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL RemoveFontMemResourceEx(HANDLE h);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFontIndirectExA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HFONT CreateFontIndirectExA([NativeTypeName("const ENUMLOGFONTEXDVA *")] ENUMLOGFONTEXDVA* param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFontIndirectExW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HFONT CreateFontIndirectExW([NativeTypeName("const ENUMLOGFONTEXDVW *")] ENUMLOGFONTEXDVW* param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetViewportExtEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetViewportExtEx(HDC hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetViewportOrgEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetViewportOrgEx(HDC hdc, [NativeTypeName("LPPOINT")] POINT* lppoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowExtEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetWindowExtEx(HDC hdc, [NativeTypeName("LPSIZE")] SIZE* lpsize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWindowOrgEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetWindowOrgEx(HDC hdc, [NativeTypeName("LPPOINT")] POINT* lppoint);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntersectClipRect"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int IntersectClipRect(HDC hdc, int left, int top, int right, int bottom);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InvertRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL InvertRgn(HDC hdc, HRGN hrgn);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LineDDA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL LineDDA(int xStart, int yStart, int xEnd, int yEnd, [NativeTypeName("LINEDDAPROC")] delegate* unmanaged<int, int, LPARAM, void> lpProc, LPARAM data);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LineTo"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL LineTo(HDC hdc, int x, int y);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MaskBlt"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL MaskBlt(HDC hdcDest, int xDest, int yDest, int width, int height, HDC hdcSrc, int xSrc, int ySrc, HBITMAP hbmMask, int xMask, int yMask, [NativeTypeName("DWORD")] uint rop);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PlgBlt"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PlgBlt(HDC hdcDest, [NativeTypeName("const POINT *")] POINT* lpPoint, HDC hdcSrc, int xSrc, int ySrc, int width, int height, HBITMAP hbmMask, int xMask, int yMask);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OffsetClipRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int OffsetClipRgn(HDC hdc, int x, int y);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OffsetRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int OffsetRgn(HRGN hrgn, int x, int y);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PatBlt"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PatBlt(HDC hdc, int x, int y, int w, int h, [NativeTypeName("DWORD")] uint rop);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Pie"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL Pie(HDC hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PlayMetaFile"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PlayMetaFile(HDC hdc, HMETAFILE hmf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PaintRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PaintRgn(HDC hdc, HRGN hrgn);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PolyPolygon"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PolyPolygon(HDC hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const INT *")] int* asz, int csz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtInRegion"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PtInRegion(HRGN hrgn, int x, int y);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtVisible"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PtVisible(HDC hdc, int x, int y);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RectInRegion"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL RectInRegion(HRGN hrgn, [NativeTypeName("const RECT *")] RECT* lprect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RectVisible"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL RectVisible(HDC hdc, [NativeTypeName("const RECT *")] RECT* lprect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Rectangle"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL Rectangle(HDC hdc, int left, int top, int right, int bottom);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RestoreDC"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL RestoreDC(HDC hdc, int nSavedDC);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ResetDCA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HDC ResetDCA(HDC hdc, [NativeTypeName("const DEVMODEA *")] DEVMODEA* lpdm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ResetDCW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HDC ResetDCW(HDC hdc, [NativeTypeName("const DEVMODEW *")] DEVMODEW* lpdm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RealizePalette"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint RealizePalette(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveFontResourceA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL RemoveFontResourceA([NativeTypeName("LPCSTR")] sbyte* lpFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveFontResourceW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL RemoveFontResourceW([NativeTypeName("LPCWSTR")] ushort* lpFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RoundRect"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL RoundRect(HDC hdc, int left, int top, int right, int bottom, int width, int height);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ResizePalette"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL ResizePalette(HPALETTE hpal, uint n);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SaveDC"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SaveDC(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SelectClipRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SelectClipRgn(HDC hdc, HRGN hrgn);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtSelectClipRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int ExtSelectClipRgn(HDC hdc, HRGN hrgn, int mode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMetaRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetMetaRgn(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SelectObject"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HGDIOBJ SelectObject(HDC hdc, HGDIOBJ h);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SelectPalette"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HPALETTE SelectPalette(HDC hdc, HPALETTE hPal, BOOL bForceBkgd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetBkColor"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern COLORREF SetBkColor(HDC hdc, COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDCBrushColor"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern COLORREF SetDCBrushColor(HDC hdc, COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDCPenColor"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern COLORREF SetDCPenColor(HDC hdc, COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetBkMode"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetBkMode(HDC hdc, int mode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetBitmapBits"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int SetBitmapBits(HBITMAP hbm, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const void *")] void* pvBits);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetBoundsRect"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint SetBoundsRect(HDC hdc, [NativeTypeName("const RECT *")] RECT* lprect, uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDIBits"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetDIBits(HDC hdc, HBITMAP hbm, uint start, uint cLines, [NativeTypeName("const void *")] void* lpBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, uint ColorUse);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDIBitsToDevice"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetDIBitsToDevice(HDC hdc, int xDest, int yDest, [NativeTypeName("DWORD")] uint w, [NativeTypeName("DWORD")] uint h, int xSrc, int ySrc, uint StartScan, uint cLines, [NativeTypeName("const void *")] void* lpvBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, uint ColorUse);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMapperFlags"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetMapperFlags(HDC hdc, [NativeTypeName("DWORD")] uint flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetGraphicsMode"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetGraphicsMode(HDC hdc, int iMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMapMode"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetMapMode(HDC hdc, int iMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetLayout"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetLayout(HDC hdc, [NativeTypeName("DWORD")] uint l);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLayout"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLayout(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMetaFileBitsEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HMETAFILE SetMetaFileBitsEx(uint cbBuffer, [NativeTypeName("const BYTE *")] byte* lpData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPaletteEntries"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint SetPaletteEntries(HPALETTE hpal, uint iStart, uint cEntries, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pPalEntries);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPixel"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern COLORREF SetPixel(HDC hdc, int x, int y, COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPixelV"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetPixelV(HDC hdc, int x, int y, COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPixelFormat"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetPixelFormat(HDC hdc, int format, [NativeTypeName("const PIXELFORMATDESCRIPTOR *")] PIXELFORMATDESCRIPTOR* ppfd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetPolyFillMode"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetPolyFillMode(HDC hdc, int mode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StretchBlt"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL StretchBlt(HDC hdcDest, int xDest, int yDest, int wDest, int hDest, HDC hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, [NativeTypeName("DWORD")] uint rop);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetRectRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetRectRgn(HRGN hrgn, int left, int top, int right, int bottom);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StretchDIBits"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int StretchDIBits(HDC hdc, int xDest, int yDest, int DestWidth, int DestHeight, int xSrc, int ySrc, int SrcWidth, int SrcHeight, [NativeTypeName("const void *")] void* lpBits, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* lpbmi, uint iUsage, [NativeTypeName("DWORD")] uint rop);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetROP2"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetROP2(HDC hdc, int rop2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetStretchBltMode"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetStretchBltMode(HDC hdc, int mode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSystemPaletteUse"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint SetSystemPaletteUse(HDC hdc, uint use);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetTextCharacterExtra"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetTextCharacterExtra(HDC hdc, int extra);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetTextColor"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern COLORREF SetTextColor(HDC hdc, COLORREF color);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetTextAlign"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint SetTextAlign(HDC hdc, uint align);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetTextJustification"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetTextJustification(HDC hdc, int extra, int count);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UpdateColors"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL UpdateColors(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AlphaBlend"]/*'/>
    [DllImport("msimg32", ExactSpelling = true)]
    public static extern BOOL AlphaBlend(HDC hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, HDC hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TransparentBlt"]/*'/>
    [DllImport("msimg32", ExactSpelling = true)]
    public static extern BOOL TransparentBlt(HDC hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, HDC hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, uint crTransparent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GradientFill"]/*'/>
    [DllImport("msimg32", ExactSpelling = true)]
    public static extern BOOL GradientFill(HDC hdc, [NativeTypeName("PTRIVERTEX")] TRIVERTEX* pVertex, [NativeTypeName("ULONG")] uint nVertex, [NativeTypeName("PVOID")] void* pMesh, [NativeTypeName("ULONG")] uint nMesh, [NativeTypeName("ULONG")] uint ulMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GdiAlphaBlend"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GdiAlphaBlend(HDC hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, HDC hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GdiTransparentBlt"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GdiTransparentBlt(HDC hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, HDC hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, uint crTransparent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GdiGradientFill"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GdiGradientFill(HDC hdc, [NativeTypeName("PTRIVERTEX")] TRIVERTEX* pVertex, [NativeTypeName("ULONG")] uint nVertex, [NativeTypeName("PVOID")] void* pMesh, [NativeTypeName("ULONG")] uint nCount, [NativeTypeName("ULONG")] uint ulMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PlayMetaFileRecord"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PlayMetaFileRecord(HDC hdc, [NativeTypeName("LPHANDLETABLE")] HANDLETABLE* lpHandleTable, [NativeTypeName("LPMETARECORD")] METARECORD* lpMR, uint noObjs);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumMetaFile"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL EnumMetaFile(HDC hdc, HMETAFILE hmf, [NativeTypeName("MFENUMPROC")] delegate* unmanaged<HDC, HANDLETABLE*, METARECORD*, int, LPARAM, int> proc, LPARAM param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseEnhMetaFile"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HENHMETAFILE CloseEnhMetaFile(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyEnhMetaFileA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HENHMETAFILE CopyEnhMetaFileA(HENHMETAFILE hEnh, [NativeTypeName("LPCSTR")] sbyte* lpFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyEnhMetaFileW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HENHMETAFILE CopyEnhMetaFileW(HENHMETAFILE hEnh, [NativeTypeName("LPCWSTR")] ushort* lpFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateEnhMetaFileA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HDC CreateEnhMetaFileA(HDC hdc, [NativeTypeName("LPCSTR")] sbyte* lpFilename, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("LPCSTR")] sbyte* lpDesc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateEnhMetaFileW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HDC CreateEnhMetaFileW(HDC hdc, [NativeTypeName("LPCWSTR")] ushort* lpFilename, [NativeTypeName("const RECT *")] RECT* lprc, [NativeTypeName("LPCWSTR")] ushort* lpDesc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteEnhMetaFile"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL DeleteEnhMetaFile(HENHMETAFILE hmf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumEnhMetaFile"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL EnumEnhMetaFile(HDC hdc, HENHMETAFILE hmf, [NativeTypeName("ENHMFENUMPROC")] delegate* unmanaged<HDC, HANDLETABLE*, ENHMETARECORD*, int, LPARAM, int> proc, [NativeTypeName("LPVOID")] void* param3, [NativeTypeName("const RECT *")] RECT* lpRect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnhMetaFileA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HENHMETAFILE GetEnhMetaFileA([NativeTypeName("LPCSTR")] sbyte* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnhMetaFileW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HENHMETAFILE GetEnhMetaFileW([NativeTypeName("LPCWSTR")] ushort* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnhMetaFileBits"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetEnhMetaFileBits(HENHMETAFILE hEMF, uint nSize, [NativeTypeName("LPBYTE")] byte* lpData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnhMetaFileDescriptionA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetEnhMetaFileDescriptionA(HENHMETAFILE hemf, uint cchBuffer, [NativeTypeName("LPSTR")] sbyte* lpDescription);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnhMetaFileDescriptionW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetEnhMetaFileDescriptionW(HENHMETAFILE hemf, uint cchBuffer, [NativeTypeName("LPWSTR")] ushort* lpDescription);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnhMetaFileHeader"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetEnhMetaFileHeader(HENHMETAFILE hemf, uint nSize, [NativeTypeName("LPENHMETAHEADER")] ENHMETAHEADER* lpEnhMetaHeader);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnhMetaFilePaletteEntries"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetEnhMetaFilePaletteEntries(HENHMETAFILE hemf, uint nNumEntries, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* lpPaletteEntries);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetEnhMetaFilePixelFormat"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetEnhMetaFilePixelFormat(HENHMETAFILE hemf, uint cbBuffer, PIXELFORMATDESCRIPTOR* ppfd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWinMetaFileBits"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetWinMetaFileBits(HENHMETAFILE hemf, uint cbData16, [NativeTypeName("LPBYTE")] byte* pData16, int iMapMode, HDC hdcRef);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PlayEnhMetaFile"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PlayEnhMetaFile(HDC hdc, HENHMETAFILE hmf, [NativeTypeName("const RECT *")] RECT* lprect);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PlayEnhMetaFileRecord"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PlayEnhMetaFileRecord(HDC hdc, [NativeTypeName("LPHANDLETABLE")] HANDLETABLE* pht, [NativeTypeName("const ENHMETARECORD *")] ENHMETARECORD* pmr, uint cht);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetEnhMetaFileBits"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HENHMETAFILE SetEnhMetaFileBits(uint nSize, [NativeTypeName("const BYTE *")] byte* pb);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWinMetaFileBits"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HENHMETAFILE SetWinMetaFileBits(uint nSize, [NativeTypeName("const BYTE *")] byte* lpMeta16Data, HDC hdcRef, [NativeTypeName("const METAFILEPICT *")] METAFILEPICT* lpMFP);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GdiComment"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GdiComment(HDC hdc, uint nSize, [NativeTypeName("const BYTE *")] byte* lpData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextMetricsA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetTextMetricsA(HDC hdc, [NativeTypeName("LPTEXTMETRICA")] TEXTMETRICA* lptm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextMetricsW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetTextMetricsW(HDC hdc, [NativeTypeName("LPTEXTMETRICW")] TEXTMETRICW* lptm);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AngleArc"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL AngleArc(HDC hdc, int x, int y, [NativeTypeName("DWORD")] uint r, float StartAngle, float SweepAngle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PolyPolyline"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PolyPolyline(HDC hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const DWORD *")] uint* asz, [NativeTypeName("DWORD")] uint csz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetWorldTransform"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetWorldTransform(HDC hdc, [NativeTypeName("LPXFORM")] XFORM* lpxf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWorldTransform"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetWorldTransform(HDC hdc, [NativeTypeName("const XFORM *")] XFORM* lpxf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ModifyWorldTransform"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL ModifyWorldTransform(HDC hdc, [NativeTypeName("const XFORM *")] XFORM* lpxf, [NativeTypeName("DWORD")] uint mode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CombineTransform"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL CombineTransform([NativeTypeName("LPXFORM")] XFORM* lpxfOut, [NativeTypeName("const XFORM *")] XFORM* lpxf1, [NativeTypeName("const XFORM *")] XFORM* lpxf2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDIBSection"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HBITMAP CreateDIBSection(HDC hdc, [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* pbmi, uint usage, void** ppvBits, HANDLE hSection, [NativeTypeName("DWORD")] uint offset);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDIBColorTable"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint GetDIBColorTable(HDC hdc, uint iStart, uint cEntries, RGBQUAD* prgbq);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDIBColorTable"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern uint SetDIBColorTable(HDC hdc, uint iStart, uint cEntries, [NativeTypeName("const RGBQUAD *")] RGBQUAD* prgbq);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetColorAdjustment"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetColorAdjustment(HDC hdc, [NativeTypeName("const COLORADJUSTMENT *")] COLORADJUSTMENT* lpca);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetColorAdjustment"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetColorAdjustment(HDC hdc, [NativeTypeName("LPCOLORADJUSTMENT")] COLORADJUSTMENT* lpca);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateHalftonePalette"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HPALETTE CreateHalftonePalette(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StartDocA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int StartDocA(HDC hdc, [NativeTypeName("const DOCINFOA *")] DOCINFOA* lpdi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StartDocW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int StartDocW(HDC hdc, [NativeTypeName("const DOCINFOW *")] DOCINFOW* lpdi);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndDoc"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int EndDoc(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StartPage"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int StartPage(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndPage"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int EndPage(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AbortDoc"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int AbortDoc(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetAbortProc"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetAbortProc(HDC hdc, [NativeTypeName("ABORTPROC")] delegate* unmanaged<HDC, int, BOOL> proc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AbortPath"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL AbortPath(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ArcTo"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL ArcTo(HDC hdc, int left, int top, int right, int bottom, int xr1, int yr1, int xr2, int yr2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BeginPath"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL BeginPath(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseFigure"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL CloseFigure(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EndPath"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL EndPath(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FillPath"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL FillPath(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlattenPath"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL FlattenPath(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetPath"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetPath(HDC hdc, [NativeTypeName("LPPOINT")] POINT* apt, [NativeTypeName("LPBYTE")] byte* aj, int cpt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathToRegion"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HRGN PathToRegion(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PolyDraw"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PolyDraw(HDC hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("const BYTE *")] byte* aj, int cpt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SelectClipPath"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SelectClipPath(HDC hdc, int mode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetArcDirection"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetArcDirection(HDC hdc, int dir);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetMiterLimit"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetMiterLimit(HDC hdc, float limit, [NativeTypeName("PFLOAT")] float* old);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrokeAndFillPath"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL StrokeAndFillPath(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrokePath"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL StrokePath(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WidenPath"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL WidenPath(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtCreatePen"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HPEN ExtCreatePen([NativeTypeName("DWORD")] uint iPenStyle, [NativeTypeName("DWORD")] uint cWidth, [NativeTypeName("const LOGBRUSH *")] LOGBRUSH* plbrush, [NativeTypeName("DWORD")] uint cStyle, [NativeTypeName("const DWORD *")] uint* pstyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMiterLimit"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetMiterLimit(HDC hdc, [NativeTypeName("PFLOAT")] float* plimit);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetArcDirection"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetArcDirection(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetObjectA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetObjectA(HANDLE h, int c, [NativeTypeName("LPVOID")] void* pv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetObjectW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetObjectW(HANDLE h, int c, [NativeTypeName("LPVOID")] void* pv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MoveToEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL MoveToEx(HDC hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TextOutA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL TextOutA(HDC hdc, int x, int y, [NativeTypeName("LPCSTR")] sbyte* lpString, int c);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.TextOutW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL TextOutW(HDC hdc, int x, int y, [NativeTypeName("LPCWSTR")] ushort* lpString, int c);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtTextOutA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL ExtTextOutA(HDC hdc, int x, int y, uint options, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("LPCSTR")] sbyte* lpString, uint c, [NativeTypeName("const INT *")] int* lpDx);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExtTextOutW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL ExtTextOutW(HDC hdc, int x, int y, uint options, [NativeTypeName("const RECT *")] RECT* lprect, [NativeTypeName("LPCWSTR")] ushort* lpString, uint c, [NativeTypeName("const INT *")] int* lpDx);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PolyTextOutA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PolyTextOutA(HDC hdc, [NativeTypeName("const POLYTEXTA *")] POLYTEXTA* ppt, int nstrings);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PolyTextOutW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PolyTextOutW(HDC hdc, [NativeTypeName("const POLYTEXTW *")] POLYTEXTW* ppt, int nstrings);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePolygonRgn"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HRGN CreatePolygonRgn([NativeTypeName("const POINT *")] POINT* pptl, int cPoint, int iMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DPtoLP"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL DPtoLP(HDC hdc, [NativeTypeName("LPPOINT")] POINT* lppt, int c);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LPtoDP"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL LPtoDP(HDC hdc, [NativeTypeName("LPPOINT")] POINT* lppt, int c);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Polygon"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL Polygon(HDC hdc, [NativeTypeName("const POINT *")] POINT* apt, int cpt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Polyline"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL Polyline(HDC hdc, [NativeTypeName("const POINT *")] POINT* apt, int cpt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PolyBezier"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PolyBezier(HDC hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PolyBezierTo"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PolyBezierTo(HDC hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PolylineTo"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL PolylineTo(HDC hdc, [NativeTypeName("const POINT *")] POINT* apt, [NativeTypeName("DWORD")] uint cpt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetViewportExtEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetViewportExtEx(HDC hdc, int x, int y, [NativeTypeName("LPSIZE")] SIZE* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetViewportOrgEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetViewportOrgEx(HDC hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowExtEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetWindowExtEx(HDC hdc, int x, int y, [NativeTypeName("LPSIZE")] SIZE* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetWindowOrgEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetWindowOrgEx(HDC hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OffsetViewportOrgEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL OffsetViewportOrgEx(HDC hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OffsetWindowOrgEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL OffsetWindowOrgEx(HDC hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ScaleViewportExtEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL ScaleViewportExtEx(HDC hdc, int xn, int dx, int yn, int yd, [NativeTypeName("LPSIZE")] SIZE* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ScaleWindowExtEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL ScaleWindowExtEx(HDC hdc, int xn, int xd, int yn, int yd, [NativeTypeName("LPSIZE")] SIZE* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetBitmapDimensionEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetBitmapDimensionEx(HBITMAP hbm, int w, int h, [NativeTypeName("LPSIZE")] SIZE* lpsz);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetBrushOrgEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetBrushOrgEx(HDC hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* lppt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextFaceA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetTextFaceA(HDC hdc, int c, [NativeTypeName("LPSTR")] sbyte* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTextFaceW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int GetTextFaceW(HDC hdc, int c, [NativeTypeName("LPWSTR")] ushort* lpName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKerningPairsA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetKerningPairsA(HDC hdc, [NativeTypeName("DWORD")] uint nPairs, [NativeTypeName("LPKERNINGPAIR")] KERNINGPAIR* lpKernPair);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetKerningPairsW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetKerningPairsW(HDC hdc, [NativeTypeName("DWORD")] uint nPairs, [NativeTypeName("LPKERNINGPAIR")] KERNINGPAIR* lpKernPair);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDCOrgEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetDCOrgEx(HDC hdc, [NativeTypeName("LPPOINT")] POINT* lppt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FixBrushOrgEx"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL FixBrushOrgEx(HDC hdc, int x, int y, [NativeTypeName("LPPOINT")] POINT* ptl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnrealizeObject"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL UnrealizeObject(HGDIOBJ h);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GdiFlush"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GdiFlush();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GdiSetBatchLimit"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GdiSetBatchLimit([NativeTypeName("DWORD")] uint dw);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GdiGetBatchLimit"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GdiGetBatchLimit();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetICMMode"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int SetICMMode(HDC hdc, int mode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckColorsInGamut"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL CheckColorsInGamut(HDC hdc, [NativeTypeName("LPRGBTRIPLE")] RGBTRIPLE* lpRGBTriple, [NativeTypeName("LPVOID")] void* dlpBuffer, [NativeTypeName("DWORD")] uint nCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetColorSpace"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HCOLORSPACE GetColorSpace(HDC hdc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLogColorSpaceA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetLogColorSpaceA(HCOLORSPACE hColorSpace, [NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* lpBuffer, [NativeTypeName("DWORD")] uint nSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLogColorSpaceW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetLogColorSpaceW(HCOLORSPACE hColorSpace, [NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* lpBuffer, [NativeTypeName("DWORD")] uint nSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateColorSpaceA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HCOLORSPACE CreateColorSpaceA([NativeTypeName("LPLOGCOLORSPACEA")] LOGCOLORSPACEA* lplcs);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateColorSpaceW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HCOLORSPACE CreateColorSpaceW([NativeTypeName("LPLOGCOLORSPACEW")] LOGCOLORSPACEW* lplcs);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetColorSpace"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern HCOLORSPACE SetColorSpace(HDC hdc, HCOLORSPACE hcs);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteColorSpace"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL DeleteColorSpace(HCOLORSPACE hcs);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetICMProfileA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetICMProfileA(HDC hdc, [NativeTypeName("LPDWORD")] uint* pBufSize, [NativeTypeName("LPSTR")] sbyte* pszFilename);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetICMProfileW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetICMProfileW(HDC hdc, [NativeTypeName("LPDWORD")] uint* pBufSize, [NativeTypeName("LPWSTR")] ushort* pszFilename);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetICMProfileA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetICMProfileA(HDC hdc, [NativeTypeName("LPSTR")] sbyte* lpFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetICMProfileW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetICMProfileW(HDC hdc, [NativeTypeName("LPWSTR")] ushort* lpFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDeviceGammaRamp"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL GetDeviceGammaRamp(HDC hdc, [NativeTypeName("LPVOID")] void* lpRamp);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDeviceGammaRamp"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL SetDeviceGammaRamp(HDC hdc, [NativeTypeName("LPVOID")] void* lpRamp);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ColorMatchToTarget"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL ColorMatchToTarget(HDC hdc, HDC hdcTarget, [NativeTypeName("DWORD")] uint action);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumICMProfilesA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int EnumICMProfilesA(HDC hdc, [NativeTypeName("ICMENUMPROCA")] delegate* unmanaged<sbyte*, LPARAM, int> proc, LPARAM param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumICMProfilesW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern int EnumICMProfilesW(HDC hdc, [NativeTypeName("ICMENUMPROCW")] delegate* unmanaged<ushort*, LPARAM, int> proc, LPARAM param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UpdateICMRegKeyA"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL UpdateICMRegKeyA([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPSTR")] sbyte* lpszCMID, [NativeTypeName("LPSTR")] sbyte* lpszFileName, uint command);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UpdateICMRegKeyW"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL UpdateICMRegKeyW([NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPWSTR")] ushort* lpszCMID, [NativeTypeName("LPWSTR")] ushort* lpszFileName, uint command);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ColorCorrectPalette"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    public static extern BOOL ColorCorrectPalette(HDC hdc, HPALETTE hPal, [NativeTypeName("DWORD")] uint deFirst, [NativeTypeName("DWORD")] uint num);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglCopyContext"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL wglCopyContext(HGLRC param0, HGLRC param1, uint param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglCreateContext"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLRC wglCreateContext(HDC param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglCreateLayerContext"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLRC wglCreateLayerContext(HDC param0, int param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglDeleteContext"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL wglDeleteContext(HGLRC param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglGetCurrentContext"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    public static extern HGLRC wglGetCurrentContext();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglGetCurrentDC"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    public static extern HDC wglGetCurrentDC();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglGetProcAddress"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PROC")]
    public static extern IntPtr wglGetProcAddress([NativeTypeName("LPCSTR")] sbyte* param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglMakeCurrent"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL wglMakeCurrent(HDC param0, HGLRC param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglShareLists"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL wglShareLists(HGLRC param0, HGLRC param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglUseFontBitmapsA"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL wglUseFontBitmapsA(HDC param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglUseFontBitmapsW"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL wglUseFontBitmapsW(HDC param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SwapBuffers"]/*'/>
    [DllImport("gdi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SwapBuffers(HDC param0);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglUseFontOutlinesA"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL wglUseFontOutlinesA(HDC param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, float param4, float param5, int param6, [NativeTypeName("LPGLYPHMETRICSFLOAT")] GLYPHMETRICSFLOAT* param7);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglUseFontOutlinesW"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL wglUseFontOutlinesW(HDC param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("DWORD")] uint param3, float param4, float param5, int param6, [NativeTypeName("LPGLYPHMETRICSFLOAT")] GLYPHMETRICSFLOAT* param7);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglDescribeLayerPlane"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    public static extern BOOL wglDescribeLayerPlane(HDC param0, int param1, int param2, uint param3, [NativeTypeName("LPLAYERPLANEDESCRIPTOR")] LAYERPLANEDESCRIPTOR* param4);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglSetLayerPaletteEntries"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int wglSetLayerPaletteEntries(HDC param0, int param1, int param2, int param3, [NativeTypeName("const COLORREF *")] COLORREF* param4);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglGetLayerPaletteEntries"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int wglGetLayerPaletteEntries(HDC param0, int param1, int param2, int param3, COLORREF* param4);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglRealizeLayerPalette"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL wglRealizeLayerPalette(HDC param0, int param1, BOOL param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglSwapLayerBuffers"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL wglSwapLayerBuffers(HDC param0, uint param1);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.wglSwapMultipleBuffers"]/*'/>
    [DllImport("opengl32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint wglSwapMultipleBuffers(uint param0, [NativeTypeName("const WGLSWAP *")] WGLSWAP* param1);
    [NativeTypeName("#define SRCCOPY (DWORD)0x00CC0020")]
    public const uint SRCCOPY = (uint)(0x00CC0020);
    [NativeTypeName("#define SRCPAINT (DWORD)0x00EE0086")]
    public const uint SRCPAINT = (uint)(0x00EE0086);
    [NativeTypeName("#define SRCAND (DWORD)0x008800C6")]
    public const uint SRCAND = (uint)(0x008800C6);
    [NativeTypeName("#define SRCINVERT (DWORD)0x00660046")]
    public const uint SRCINVERT = (uint)(0x00660046);
    [NativeTypeName("#define SRCERASE (DWORD)0x00440328")]
    public const uint SRCERASE = (uint)(0x00440328);
    [NativeTypeName("#define NOTSRCCOPY (DWORD)0x00330008")]
    public const uint NOTSRCCOPY = (uint)(0x00330008);
    [NativeTypeName("#define NOTSRCERASE (DWORD)0x001100A6")]
    public const uint NOTSRCERASE = (uint)(0x001100A6);
    [NativeTypeName("#define MERGECOPY (DWORD)0x00C000CA")]
    public const uint MERGECOPY = (uint)(0x00C000CA);
    [NativeTypeName("#define MERGEPAINT (DWORD)0x00BB0226")]
    public const uint MERGEPAINT = (uint)(0x00BB0226);
    [NativeTypeName("#define PATCOPY (DWORD)0x00F00021")]
    public const uint PATCOPY = (uint)(0x00F00021);
    [NativeTypeName("#define PATPAINT (DWORD)0x00FB0A09")]
    public const uint PATPAINT = (uint)(0x00FB0A09);
    [NativeTypeName("#define PATINVERT (DWORD)0x005A0049")]
    public const uint PATINVERT = (uint)(0x005A0049);
    [NativeTypeName("#define DSTINVERT (DWORD)0x00550009")]
    public const uint DSTINVERT = (uint)(0x00550009);
    [NativeTypeName("#define BLACKNESS (DWORD)0x00000042")]
    public const uint BLACKNESS = (uint)(0x00000042);
    [NativeTypeName("#define WHITENESS (DWORD)0x00FF0062")]
    public const uint WHITENESS = (uint)(0x00FF0062);
    [NativeTypeName("#define NOMIRRORBITMAP (DWORD)0x80000000")]
    public const uint NOMIRRORBITMAP = (uint)(0x80000000);
    [NativeTypeName("#define CAPTUREBLT (DWORD)0x40000000")]
    public const uint CAPTUREBLT = (uint)(0x40000000);
    [NativeTypeName("#define GDI_ERROR (0xFFFFFFFFL)")]
    public const uint GDI_ERROR = (0xFFFFFFFF);
    [NativeTypeName("#define ERROR 0")]
    public const int ERROR = 0;
    [NativeTypeName("#define NULLREGION 1")]
    public const int NULLREGION = 1;
    [NativeTypeName("#define SIMPLEREGION 2")]
    public const int SIMPLEREGION = 2;
    [NativeTypeName("#define COMPLEXREGION 3")]
    public const int COMPLEXREGION = 3;
    [NativeTypeName("#define RGN_ERROR ERROR")]
    public const int RGN_ERROR = 0;
    [NativeTypeName("#define RGN_AND 1")]
    public const int RGN_AND = 1;
    [NativeTypeName("#define RGN_OR 2")]
    public const int RGN_OR = 2;
    [NativeTypeName("#define RGN_XOR 3")]
    public const int RGN_XOR = 3;
    [NativeTypeName("#define RGN_DIFF 4")]
    public const int RGN_DIFF = 4;
    [NativeTypeName("#define RGN_COPY 5")]
    public const int RGN_COPY = 5;
    [NativeTypeName("#define RGN_MIN RGN_AND")]
    public const int RGN_MIN = 1;
    [NativeTypeName("#define RGN_MAX RGN_COPY")]
    public const int RGN_MAX = 5;
    [NativeTypeName("#define BLACKONWHITE 1")]
    public const int BLACKONWHITE = 1;
    [NativeTypeName("#define WHITEONBLACK 2")]
    public const int WHITEONBLACK = 2;
    [NativeTypeName("#define COLORONCOLOR 3")]
    public const int COLORONCOLOR = 3;
    [NativeTypeName("#define HALFTONE 4")]
    public const int HALFTONE = 4;
    [NativeTypeName("#define MAXSTRETCHBLTMODE 4")]
    public const int MAXSTRETCHBLTMODE = 4;
    [NativeTypeName("#define STRETCH_ANDSCANS BLACKONWHITE")]
    public const int STRETCH_ANDSCANS = 1;
    [NativeTypeName("#define STRETCH_ORSCANS WHITEONBLACK")]
    public const int STRETCH_ORSCANS = 2;
    [NativeTypeName("#define STRETCH_DELETESCANS COLORONCOLOR")]
    public const int STRETCH_DELETESCANS = 3;
    [NativeTypeName("#define STRETCH_HALFTONE HALFTONE")]
    public const int STRETCH_HALFTONE = 4;
    [NativeTypeName("#define ALTERNATE 1")]
    public const int ALTERNATE = 1;
    [NativeTypeName("#define WINDING 2")]
    public const int WINDING = 2;
    [NativeTypeName("#define POLYFILL_LAST 2")]
    public const int POLYFILL_LAST = 2;
    [NativeTypeName("#define LAYOUT_RTL 0x00000001")]
    public const int LAYOUT_RTL = 0x00000001;
    [NativeTypeName("#define LAYOUT_BTT 0x00000002")]
    public const int LAYOUT_BTT = 0x00000002;
    [NativeTypeName("#define LAYOUT_VBH 0x00000004")]
    public const int LAYOUT_VBH = 0x00000004;
    [NativeTypeName("#define LAYOUT_ORIENTATIONMASK (LAYOUT_RTL | LAYOUT_BTT | LAYOUT_VBH)")]
    public const int LAYOUT_ORIENTATIONMASK = (0x00000001 | 0x00000002 | 0x00000004);
    [NativeTypeName("#define LAYOUT_BITMAPORIENTATIONPRESERVED 0x00000008")]
    public const int LAYOUT_BITMAPORIENTATIONPRESERVED = 0x00000008;
    [NativeTypeName("#define VTA_BASELINE TA_BASELINE")]
    public const int VTA_BASELINE = 24;
    [NativeTypeName("#define VTA_LEFT TA_BOTTOM")]
    public const int VTA_LEFT = 8;
    [NativeTypeName("#define VTA_RIGHT TA_TOP")]
    public const int VTA_RIGHT = 0;
    [NativeTypeName("#define VTA_CENTER TA_CENTER")]
    public const int VTA_CENTER = 6;
    [NativeTypeName("#define VTA_BOTTOM TA_RIGHT")]
    public const int VTA_BOTTOM = 2;
    [NativeTypeName("#define VTA_TOP TA_LEFT")]
    public const int VTA_TOP = 0;
    [NativeTypeName("#define ETO_OPAQUE 0x0002")]
    public const int ETO_OPAQUE = 0x0002;
    [NativeTypeName("#define ETO_CLIPPED 0x0004")]
    public const int ETO_CLIPPED = 0x0004;
    [NativeTypeName("#define ETO_GLYPH_INDEX 0x0010")]
    public const int ETO_GLYPH_INDEX = 0x0010;
    [NativeTypeName("#define ETO_RTLREADING 0x0080")]
    public const int ETO_RTLREADING = 0x0080;
    [NativeTypeName("#define ETO_NUMERICSLOCAL 0x0400")]
    public const int ETO_NUMERICSLOCAL = 0x0400;
    [NativeTypeName("#define ETO_NUMERICSLATIN 0x0800")]
    public const int ETO_NUMERICSLATIN = 0x0800;
    [NativeTypeName("#define ETO_IGNORELANGUAGE 0x1000")]
    public const int ETO_IGNORELANGUAGE = 0x1000;
    [NativeTypeName("#define ETO_PDY 0x2000")]
    public const int ETO_PDY = 0x2000;
    [NativeTypeName("#define ETO_REVERSE_INDEX_MAP 0x10000")]
    public const int ETO_REVERSE_INDEX_MAP = 0x10000;
    [NativeTypeName("#define ASPECT_FILTERING 0x0001")]
    public const int ASPECT_FILTERING = 0x0001;
    [NativeTypeName("#define DCB_RESET 0x0001")]
    public const int DCB_RESET = 0x0001;
    [NativeTypeName("#define DCB_ACCUMULATE 0x0002")]
    public const int DCB_ACCUMULATE = 0x0002;
    [NativeTypeName("#define DCB_DIRTY DCB_ACCUMULATE")]
    public const int DCB_DIRTY = 0x0002;
    [NativeTypeName("#define DCB_SET (DCB_RESET | DCB_ACCUMULATE)")]
    public const int DCB_SET = (0x0001 | 0x0002);
    [NativeTypeName("#define DCB_ENABLE 0x0004")]
    public const int DCB_ENABLE = 0x0004;
    [NativeTypeName("#define DCB_DISABLE 0x0008")]
    public const int DCB_DISABLE = 0x0008;
    [NativeTypeName("#define NEWFRAME 1")]
    public const int NEWFRAME = 1;
    [NativeTypeName("#define ABORTDOC 2")]
    public const int ABORTDOC = 2;
    [NativeTypeName("#define NEXTBAND 3")]
    public const int NEXTBAND = 3;
    [NativeTypeName("#define SETCOLORTABLE 4")]
    public const int SETCOLORTABLE = 4;
    [NativeTypeName("#define GETCOLORTABLE 5")]
    public const int GETCOLORTABLE = 5;
    [NativeTypeName("#define FLUSHOUTPUT 6")]
    public const int FLUSHOUTPUT = 6;
    [NativeTypeName("#define DRAFTMODE 7")]
    public const int DRAFTMODE = 7;
    [NativeTypeName("#define QUERYESCSUPPORT 8")]
    public const int QUERYESCSUPPORT = 8;
    [NativeTypeName("#define SETABORTPROC 9")]
    public const int SETABORTPROC = 9;
    [NativeTypeName("#define STARTDOC 10")]
    public const int STARTDOC = 10;
    [NativeTypeName("#define ENDDOC 11")]
    public const int ENDDOC = 11;
    [NativeTypeName("#define GETPHYSPAGESIZE 12")]
    public const int GETPHYSPAGESIZE = 12;
    [NativeTypeName("#define GETPRINTINGOFFSET 13")]
    public const int GETPRINTINGOFFSET = 13;
    [NativeTypeName("#define GETSCALINGFACTOR 14")]
    public const int GETSCALINGFACTOR = 14;
    [NativeTypeName("#define MFCOMMENT 15")]
    public const int MFCOMMENT = 15;
    [NativeTypeName("#define GETPENWIDTH 16")]
    public const int GETPENWIDTH = 16;
    [NativeTypeName("#define SETCOPYCOUNT 17")]
    public const int SETCOPYCOUNT = 17;
    [NativeTypeName("#define SELECTPAPERSOURCE 18")]
    public const int SELECTPAPERSOURCE = 18;
    [NativeTypeName("#define DEVICEDATA 19")]
    public const int DEVICEDATA = 19;
    [NativeTypeName("#define PASSTHROUGH 19")]
    public const int PASSTHROUGH = 19;
    [NativeTypeName("#define GETTECHNOLGY 20")]
    public const int GETTECHNOLGY = 20;
    [NativeTypeName("#define GETTECHNOLOGY 20")]
    public const int GETTECHNOLOGY = 20;
    [NativeTypeName("#define SETLINECAP 21")]
    public const int SETLINECAP = 21;
    [NativeTypeName("#define SETLINEJOIN 22")]
    public const int SETLINEJOIN = 22;
    [NativeTypeName("#define SETMITERLIMIT 23")]
    public const int SETMITERLIMIT = 23;
    [NativeTypeName("#define BANDINFO 24")]
    public const int BANDINFO = 24;
    [NativeTypeName("#define DRAWPATTERNRECT 25")]
    public const int DRAWPATTERNRECT = 25;
    [NativeTypeName("#define GETVECTORPENSIZE 26")]
    public const int GETVECTORPENSIZE = 26;
    [NativeTypeName("#define GETVECTORBRUSHSIZE 27")]
    public const int GETVECTORBRUSHSIZE = 27;
    [NativeTypeName("#define ENABLEDUPLEX 28")]
    public const int ENABLEDUPLEX = 28;
    [NativeTypeName("#define GETSETPAPERBINS 29")]
    public const int GETSETPAPERBINS = 29;
    [NativeTypeName("#define GETSETPRINTORIENT 30")]
    public const int GETSETPRINTORIENT = 30;
    [NativeTypeName("#define ENUMPAPERBINS 31")]
    public const int ENUMPAPERBINS = 31;
    [NativeTypeName("#define SETDIBSCALING 32")]
    public const int SETDIBSCALING = 32;
    [NativeTypeName("#define EPSPRINTING 33")]
    public const int EPSPRINTING = 33;
    [NativeTypeName("#define ENUMPAPERMETRICS 34")]
    public const int ENUMPAPERMETRICS = 34;
    [NativeTypeName("#define GETSETPAPERMETRICS 35")]
    public const int GETSETPAPERMETRICS = 35;
    [NativeTypeName("#define POSTSCRIPT_DATA 37")]
    public const int POSTSCRIPT_DATA = 37;
    [NativeTypeName("#define POSTSCRIPT_IGNORE 38")]
    public const int POSTSCRIPT_IGNORE = 38;
    [NativeTypeName("#define MOUSETRAILS 39")]
    public const int MOUSETRAILS = 39;
    [NativeTypeName("#define GETDEVICEUNITS 42")]
    public const int GETDEVICEUNITS = 42;
    [NativeTypeName("#define GETEXTENDEDTEXTMETRICS 256")]
    public const int GETEXTENDEDTEXTMETRICS = 256;
    [NativeTypeName("#define GETEXTENTTABLE 257")]
    public const int GETEXTENTTABLE = 257;
    [NativeTypeName("#define GETPAIRKERNTABLE 258")]
    public const int GETPAIRKERNTABLE = 258;
    [NativeTypeName("#define GETTRACKKERNTABLE 259")]
    public const int GETTRACKKERNTABLE = 259;
    [NativeTypeName("#define EXTTEXTOUT 512")]
    public const int EXTTEXTOUT = 512;
    [NativeTypeName("#define GETFACENAME 513")]
    public const int GETFACENAME = 513;
    [NativeTypeName("#define DOWNLOADFACE 514")]
    public const int DOWNLOADFACE = 514;
    [NativeTypeName("#define ENABLERELATIVEWIDTHS 768")]
    public const int ENABLERELATIVEWIDTHS = 768;
    [NativeTypeName("#define ENABLEPAIRKERNING 769")]
    public const int ENABLEPAIRKERNING = 769;
    [NativeTypeName("#define SETKERNTRACK 770")]
    public const int SETKERNTRACK = 770;
    [NativeTypeName("#define SETALLJUSTVALUES 771")]
    public const int SETALLJUSTVALUES = 771;
    [NativeTypeName("#define SETCHARSET 772")]
    public const int SETCHARSET = 772;
    [NativeTypeName("#define STRETCHBLT 2048")]
    public const int STRETCHBLT = 2048;
    [NativeTypeName("#define METAFILE_DRIVER 2049")]
    public const int METAFILE_DRIVER = 2049;
    [NativeTypeName("#define GETSETSCREENPARAMS 3072")]
    public const int GETSETSCREENPARAMS = 3072;
    [NativeTypeName("#define QUERYDIBSUPPORT 3073")]
    public const int QUERYDIBSUPPORT = 3073;
    [NativeTypeName("#define BEGIN_PATH 4096")]
    public const int BEGIN_PATH = 4096;
    [NativeTypeName("#define CLIP_TO_PATH 4097")]
    public const int CLIP_TO_PATH = 4097;
    [NativeTypeName("#define END_PATH 4098")]
    public const int END_PATH = 4098;
    [NativeTypeName("#define EXT_DEVICE_CAPS 4099")]
    public const int EXT_DEVICE_CAPS = 4099;
    [NativeTypeName("#define RESTORE_CTM 4100")]
    public const int RESTORE_CTM = 4100;
    [NativeTypeName("#define SAVE_CTM 4101")]
    public const int SAVE_CTM = 4101;
    [NativeTypeName("#define TRANSFORM_CTM 4107")]
    public const int TRANSFORM_CTM = 4107;
    [NativeTypeName("#define OPENCHANNEL 4110")]
    public const int OPENCHANNEL = 4110;
    [NativeTypeName("#define DOWNLOADHEADER 4111")]
    public const int DOWNLOADHEADER = 4111;
    [NativeTypeName("#define CLOSECHANNEL 4112")]
    public const int CLOSECHANNEL = 4112;
    [NativeTypeName("#define POSTSCRIPT_PASSTHROUGH 4115")]
    public const int POSTSCRIPT_PASSTHROUGH = 4115;
    [NativeTypeName("#define ENCAPSULATED_POSTSCRIPT 4116")]
    public const int ENCAPSULATED_POSTSCRIPT = 4116;
    [NativeTypeName("#define POSTSCRIPT_IDENTIFY 4117")]
    public const int POSTSCRIPT_IDENTIFY = 4117;
    [NativeTypeName("#define POSTSCRIPT_INJECTION 4118")]
    public const int POSTSCRIPT_INJECTION = 4118;
    [NativeTypeName("#define CHECKJPEGFORMAT 4119")]
    public const int CHECKJPEGFORMAT = 4119;
    [NativeTypeName("#define CHECKPNGFORMAT 4120")]
    public const int CHECKPNGFORMAT = 4120;
    [NativeTypeName("#define GDIPLUS_TS_QUERYVER 4122")]
    public const int GDIPLUS_TS_QUERYVER = 4122;
    [NativeTypeName("#define GDIPLUS_TS_RECORD 4123")]
    public const int GDIPLUS_TS_RECORD = 4123;
    [NativeTypeName("#define MILCORE_TS_QUERYVER_RESULT_FALSE 0x0")]
    public const int MILCORE_TS_QUERYVER_RESULT_FALSE = 0x0;
    [NativeTypeName("#define MILCORE_TS_QUERYVER_RESULT_TRUE 0x7FFFFFFF")]
    public const int MILCORE_TS_QUERYVER_RESULT_TRUE = 0x7FFFFFFF;
    [NativeTypeName("#define SPCLPASSTHROUGH2 4568")]
    public const int SPCLPASSTHROUGH2 = 4568;
    [NativeTypeName("#define PSIDENT_GDICENTRIC 0")]
    public const int PSIDENT_GDICENTRIC = 0;
    [NativeTypeName("#define PSIDENT_PSCENTRIC 1")]
    public const int PSIDENT_PSCENTRIC = 1;
    [NativeTypeName("#define FEATURESETTING_NUP 0")]
    public const int FEATURESETTING_NUP = 0;
    [NativeTypeName("#define FEATURESETTING_OUTPUT 1")]
    public const int FEATURESETTING_OUTPUT = 1;
    [NativeTypeName("#define FEATURESETTING_PSLEVEL 2")]
    public const int FEATURESETTING_PSLEVEL = 2;
    [NativeTypeName("#define FEATURESETTING_CUSTPAPER 3")]
    public const int FEATURESETTING_CUSTPAPER = 3;
    [NativeTypeName("#define FEATURESETTING_MIRROR 4")]
    public const int FEATURESETTING_MIRROR = 4;
    [NativeTypeName("#define FEATURESETTING_NEGATIVE 5")]
    public const int FEATURESETTING_NEGATIVE = 5;
    [NativeTypeName("#define FEATURESETTING_PROTOCOL 6")]
    public const int FEATURESETTING_PROTOCOL = 6;
    [NativeTypeName("#define FEATURESETTING_PRIVATE_BEGIN 0x1000")]
    public const int FEATURESETTING_PRIVATE_BEGIN = 0x1000;
    [NativeTypeName("#define FEATURESETTING_PRIVATE_END 0x1FFF")]
    public const int FEATURESETTING_PRIVATE_END = 0x1FFF;
    [NativeTypeName("#define PSPROTOCOL_ASCII 0")]
    public const int PSPROTOCOL_ASCII = 0;
    [NativeTypeName("#define PSPROTOCOL_BCP 1")]
    public const int PSPROTOCOL_BCP = 1;
    [NativeTypeName("#define PSPROTOCOL_TBCP 2")]
    public const int PSPROTOCOL_TBCP = 2;
    [NativeTypeName("#define PSPROTOCOL_BINARY 3")]
    public const int PSPROTOCOL_BINARY = 3;
    [NativeTypeName("#define QDI_SETDIBITS 1")]
    public const int QDI_SETDIBITS = 1;
    [NativeTypeName("#define QDI_GETDIBITS 2")]
    public const int QDI_GETDIBITS = 2;
    [NativeTypeName("#define QDI_DIBTOSCREEN 4")]
    public const int QDI_DIBTOSCREEN = 4;
    [NativeTypeName("#define QDI_STRETCHDIB 8")]
    public const int QDI_STRETCHDIB = 8;
    [NativeTypeName("#define PR_JOBSTATUS 0x0000")]
    public const int PR_JOBSTATUS = 0x0000;
    [NativeTypeName("#define GDI_OBJ_LAST OBJ_COLORSPACE")]
    public const int GDI_OBJ_LAST = 14;
    [NativeTypeName("#define GDI_MIN_OBJ_TYPE OBJ_PEN")]
    public const int GDI_MIN_OBJ_TYPE = 1;
    [NativeTypeName("#define GDI_MAX_OBJ_TYPE GDI_OBJ_LAST")]
    public const int GDI_MAX_OBJ_TYPE = 14;
    [NativeTypeName("#define MWT_IDENTITY 1")]
    public const int MWT_IDENTITY = 1;
    [NativeTypeName("#define MWT_LEFTMULTIPLY 2")]
    public const int MWT_LEFTMULTIPLY = 2;
    [NativeTypeName("#define MWT_RIGHTMULTIPLY 3")]
    public const int MWT_RIGHTMULTIPLY = 3;
    [NativeTypeName("#define MWT_MIN MWT_IDENTITY")]
    public const int MWT_MIN = 1;
    [NativeTypeName("#define MWT_MAX MWT_RIGHTMULTIPLY")]
    public const int MWT_MAX = 3;
    [NativeTypeName("#define LCS_SIGNATURE 'PSOC'")]
    public const int LCS_SIGNATURE = 0x50534F43;
    [NativeTypeName("#define LCS_sRGB 'sRGB'")]
    public const int LCS_sRGB = 0x73524742;
    [NativeTypeName("#define LCS_WINDOWS_COLOR_SPACE 'Win '")]
    public const int LCS_WINDOWS_COLOR_SPACE = 0x57696E20;
    [NativeTypeName("#define LCS_CALIBRATED_RGB 0x00000000L")]
    public const int LCS_CALIBRATED_RGB = 0x00000000;
    [NativeTypeName("#define LCS_GM_BUSINESS 0x00000001L")]
    public const int LCS_GM_BUSINESS = 0x00000001;
    [NativeTypeName("#define LCS_GM_GRAPHICS 0x00000002L")]
    public const int LCS_GM_GRAPHICS = 0x00000002;
    [NativeTypeName("#define LCS_GM_IMAGES 0x00000004L")]
    public const int LCS_GM_IMAGES = 0x00000004;
    [NativeTypeName("#define LCS_GM_ABS_COLORIMETRIC 0x00000008L")]
    public const int LCS_GM_ABS_COLORIMETRIC = 0x00000008;
    [NativeTypeName("#define PROFILE_LINKED 'LINK'")]
    public const int PROFILE_LINKED = 0x4C494E4B;
    [NativeTypeName("#define PROFILE_EMBEDDED 'MBED'")]
    public const int PROFILE_EMBEDDED = 0x4D424544;
    [NativeTypeName("#define TCI_SRCCHARSET 1")]
    public const int TCI_SRCCHARSET = 1;
    [NativeTypeName("#define TCI_SRCCODEPAGE 2")]
    public const int TCI_SRCCODEPAGE = 2;
    [NativeTypeName("#define TCI_SRCFONTSIG 3")]
    public const int TCI_SRCFONTSIG = 3;
    [NativeTypeName("#define TCI_SRCLOCALE 0x1000")]
    public const int TCI_SRCLOCALE = 0x1000;
    [NativeTypeName("#define TMPF_FIXED_PITCH 0x01")]
    public const int TMPF_FIXED_PITCH = 0x01;
    [NativeTypeName("#define TMPF_VECTOR 0x02")]
    public const int TMPF_VECTOR = 0x02;
    [NativeTypeName("#define TMPF_DEVICE 0x08")]
    public const int TMPF_DEVICE = 0x08;
    [NativeTypeName("#define TMPF_TRUETYPE 0x04")]
    public const int TMPF_TRUETYPE = 0x04;
    [NativeTypeName("#define NTM_REGULAR 0x00000040L")]
    public const int NTM_REGULAR = 0x00000040;
    [NativeTypeName("#define NTM_BOLD 0x00000020L")]
    public const int NTM_BOLD = 0x00000020;
    [NativeTypeName("#define NTM_ITALIC 0x00000001L")]
    public const int NTM_ITALIC = 0x00000001;
    [NativeTypeName("#define NTM_NONNEGATIVE_AC 0x00010000")]
    public const int NTM_NONNEGATIVE_AC = 0x00010000;
    [NativeTypeName("#define NTM_PS_OPENTYPE 0x00020000")]
    public const int NTM_PS_OPENTYPE = 0x00020000;
    [NativeTypeName("#define NTM_TT_OPENTYPE 0x00040000")]
    public const int NTM_TT_OPENTYPE = 0x00040000;
    [NativeTypeName("#define NTM_MULTIPLEMASTER 0x00080000")]
    public const int NTM_MULTIPLEMASTER = 0x00080000;
    [NativeTypeName("#define NTM_TYPE1 0x00100000")]
    public const int NTM_TYPE1 = 0x00100000;
    [NativeTypeName("#define NTM_DSIG 0x00200000")]
    public const int NTM_DSIG = 0x00200000;
    [NativeTypeName("#define LF_FACESIZE 32")]
    public const int LF_FACESIZE = 32;
    [NativeTypeName("#define LF_FULLFACESIZE 64")]
    public const int LF_FULLFACESIZE = 64;
    [NativeTypeName("#define CLIP_DEFAULT_PRECIS 0")]
    public const int CLIP_DEFAULT_PRECIS = 0;
    [NativeTypeName("#define CLIP_CHARACTER_PRECIS 1")]
    public const int CLIP_CHARACTER_PRECIS = 1;
    [NativeTypeName("#define CLIP_STROKE_PRECIS 2")]
    public const int CLIP_STROKE_PRECIS = 2;
    [NativeTypeName("#define CLIP_MASK 0xf")]
    public const int CLIP_MASK = 0xf;
    [NativeTypeName("#define CLIP_LH_ANGLES (1<<4)")]
    public const int CLIP_LH_ANGLES = (1 << 4);
    [NativeTypeName("#define CLIP_TT_ALWAYS (2<<4)")]
    public const int CLIP_TT_ALWAYS = (2 << 4);
    [NativeTypeName("#define CLIP_DFA_DISABLE (4<<4)")]
    public const int CLIP_DFA_DISABLE = (4 << 4);
    [NativeTypeName("#define CLIP_EMBEDDED (8<<4)")]
    public const int CLIP_EMBEDDED = (8 << 4);
    [NativeTypeName("#define DRAFT_QUALITY 1")]
    public const int DRAFT_QUALITY = 1;
    [NativeTypeName("#define PROOF_QUALITY 2")]
    public const int PROOF_QUALITY = 2;
    [NativeTypeName("#define NONANTIALIASED_QUALITY 3")]
    public const int NONANTIALIASED_QUALITY = 3;
    [NativeTypeName("#define ANTIALIASED_QUALITY 4")]
    public const int ANTIALIASED_QUALITY = 4;
    [NativeTypeName("#define CLEARTYPE_QUALITY 5")]
    public const int CLEARTYPE_QUALITY = 5;
    [NativeTypeName("#define CLEARTYPE_NATURAL_QUALITY 6")]
    public const int CLEARTYPE_NATURAL_QUALITY = 6;
    [NativeTypeName("#define FIXED_PITCH 1")]
    public const int FIXED_PITCH = 1;
    [NativeTypeName("#define VARIABLE_PITCH 2")]
    public const int VARIABLE_PITCH = 2;
    [NativeTypeName("#define MONO_FONT 8")]
    public const int MONO_FONT = 8;
    [NativeTypeName("#define ANSI_CHARSET 0")]
    public const int ANSI_CHARSET = 0;
    [NativeTypeName("#define SYMBOL_CHARSET 2")]
    public const int SYMBOL_CHARSET = 2;
    [NativeTypeName("#define SHIFTJIS_CHARSET 128")]
    public const int SHIFTJIS_CHARSET = 128;
    [NativeTypeName("#define HANGEUL_CHARSET 129")]
    public const int HANGEUL_CHARSET = 129;
    [NativeTypeName("#define HANGUL_CHARSET 129")]
    public const int HANGUL_CHARSET = 129;
    [NativeTypeName("#define GB2312_CHARSET 134")]
    public const int GB2312_CHARSET = 134;
    [NativeTypeName("#define CHINESEBIG5_CHARSET 136")]
    public const int CHINESEBIG5_CHARSET = 136;
    [NativeTypeName("#define OEM_CHARSET 255")]
    public const int OEM_CHARSET = 255;
    [NativeTypeName("#define JOHAB_CHARSET 130")]
    public const int JOHAB_CHARSET = 130;
    [NativeTypeName("#define HEBREW_CHARSET 177")]
    public const int HEBREW_CHARSET = 177;
    [NativeTypeName("#define ARABIC_CHARSET 178")]
    public const int ARABIC_CHARSET = 178;
    [NativeTypeName("#define GREEK_CHARSET 161")]
    public const int GREEK_CHARSET = 161;
    [NativeTypeName("#define TURKISH_CHARSET 162")]
    public const int TURKISH_CHARSET = 162;
    [NativeTypeName("#define VIETNAMESE_CHARSET 163")]
    public const int VIETNAMESE_CHARSET = 163;
    [NativeTypeName("#define THAI_CHARSET 222")]
    public const int THAI_CHARSET = 222;
    [NativeTypeName("#define EASTEUROPE_CHARSET 238")]
    public const int EASTEUROPE_CHARSET = 238;
    [NativeTypeName("#define RUSSIAN_CHARSET 204")]
    public const int RUSSIAN_CHARSET = 204;
    [NativeTypeName("#define MAC_CHARSET 77")]
    public const int MAC_CHARSET = 77;
    [NativeTypeName("#define BALTIC_CHARSET 186")]
    public const int BALTIC_CHARSET = 186;
    [NativeTypeName("#define FF_DONTCARE (0<<4)")]
    public const int FF_DONTCARE = (0 << 4);
    [NativeTypeName("#define FF_ROMAN (1<<4)")]
    public const int FF_ROMAN = (1 << 4);
    [NativeTypeName("#define FF_SWISS (2<<4)")]
    public const int FF_SWISS = (2 << 4);
    [NativeTypeName("#define FF_MODERN (3<<4)")]
    public const int FF_MODERN = (3 << 4);
    [NativeTypeName("#define FF_SCRIPT (4<<4)")]
    public const int FF_SCRIPT = (4 << 4);
    [NativeTypeName("#define FF_DECORATIVE (5<<4)")]
    public const int FF_DECORATIVE = (5 << 4);
    [NativeTypeName("#define PANOSE_COUNT 10")]
    public const int PANOSE_COUNT = 10;
    [NativeTypeName("#define ELF_VENDOR_SIZE 4")]
    public const int ELF_VENDOR_SIZE = 4;
    [NativeTypeName("#define ELF_VERSION 0")]
    public const int ELF_VERSION = 0;
    [NativeTypeName("#define ELF_CULTURE_LATIN 0")]
    public const int ELF_CULTURE_LATIN = 0;
    [NativeTypeName("#define RASTER_FONTTYPE 0x0001")]
    public const int RASTER_FONTTYPE = 0x0001;
    [NativeTypeName("#define DEVICE_FONTTYPE 0x0002")]
    public const int DEVICE_FONTTYPE = 0x0002;
    [NativeTypeName("#define TRUETYPE_FONTTYPE 0x0004")]
    public const int TRUETYPE_FONTTYPE = 0x0004;
    [NativeTypeName("#define TRANSPARENT 1")]
    public const int TRANSPARENT = 1;
    [NativeTypeName("#define OPAQUE 2")]
    public const int OPAQUE = 2;
    [NativeTypeName("#define BKMODE_LAST 2")]
    public const int BKMODE_LAST = 2;
    [NativeTypeName("#define GM_COMPATIBLE 1")]
    public const int GM_COMPATIBLE = 1;
    [NativeTypeName("#define GM_ADVANCED 2")]
    public const int GM_ADVANCED = 2;
    [NativeTypeName("#define GM_LAST 2")]
    public const int GM_LAST = 2;
    [NativeTypeName("#define PT_CLOSEFIGURE 0x01")]
    public const int PT_CLOSEFIGURE = 0x01;
    [NativeTypeName("#define PT_LINETO 0x02")]
    public const int PT_LINETO = 0x02;
    [NativeTypeName("#define PT_BEZIERTO 0x04")]
    public const int PT_BEZIERTO = 0x04;
    [NativeTypeName("#define PT_MOVETO 0x06")]
    public const int PT_MOVETO = 0x06;
    [NativeTypeName("#define ABSOLUTE 1")]
    public const int ABSOLUTE = 1;
    [NativeTypeName("#define RELATIVE 2")]
    public const int RELATIVE = 2;
    [NativeTypeName("#define WHITE_BRUSH 0")]
    public const int WHITE_BRUSH = 0;
    [NativeTypeName("#define LTGRAY_BRUSH 1")]
    public const int LTGRAY_BRUSH = 1;
    [NativeTypeName("#define GRAY_BRUSH 2")]
    public const int GRAY_BRUSH = 2;
    [NativeTypeName("#define DKGRAY_BRUSH 3")]
    public const int DKGRAY_BRUSH = 3;
    [NativeTypeName("#define BLACK_BRUSH 4")]
    public const int BLACK_BRUSH = 4;
    [NativeTypeName("#define NULL_BRUSH 5")]
    public const int NULL_BRUSH = 5;
    [NativeTypeName("#define HOLLOW_BRUSH NULL_BRUSH")]
    public const int HOLLOW_BRUSH = 5;
    [NativeTypeName("#define WHITE_PEN 6")]
    public const int WHITE_PEN = 6;
    [NativeTypeName("#define BLACK_PEN 7")]
    public const int BLACK_PEN = 7;
    [NativeTypeName("#define NULL_PEN 8")]
    public const int NULL_PEN = 8;
    [NativeTypeName("#define OEM_FIXED_FONT 10")]
    public const int OEM_FIXED_FONT = 10;
    [NativeTypeName("#define ANSI_FIXED_FONT 11")]
    public const int ANSI_FIXED_FONT = 11;
    [NativeTypeName("#define ANSI_VAR_FONT 12")]
    public const int ANSI_VAR_FONT = 12;
    [NativeTypeName("#define STOCK_LAST 19")]
    public const int STOCK_LAST = 19;
    [NativeTypeName("#define CLR_INVALID 0xFFFFFFFF")]
    public const uint CLR_INVALID = 0xFFFFFFFF;
    [NativeTypeName("#define HS_HORIZONTAL 0")]
    public const int HS_HORIZONTAL = 0;
    [NativeTypeName("#define HS_VERTICAL 1")]
    public const int HS_VERTICAL = 1;
    [NativeTypeName("#define HS_FDIAGONAL 2")]
    public const int HS_FDIAGONAL = 2;
    [NativeTypeName("#define HS_BDIAGONAL 3")]
    public const int HS_BDIAGONAL = 3;
    [NativeTypeName("#define HS_CROSS 4")]
    public const int HS_CROSS = 4;
    [NativeTypeName("#define HS_DIAGCROSS 5")]
    public const int HS_DIAGCROSS = 5;
    [NativeTypeName("#define HS_API_MAX 12")]
    public const int HS_API_MAX = 12;
    [NativeTypeName("#define AD_COUNTERCLOCKWISE 1")]
    public const int AD_COUNTERCLOCKWISE = 1;
    [NativeTypeName("#define AD_CLOCKWISE 2")]
    public const int AD_CLOCKWISE = 2;
    [NativeTypeName("#define DRIVERVERSION 0")]
    public const int DRIVERVERSION = 0;
    [NativeTypeName("#define TECHNOLOGY 2")]
    public const int TECHNOLOGY = 2;
    [NativeTypeName("#define HORZSIZE 4")]
    public const int HORZSIZE = 4;
    [NativeTypeName("#define VERTSIZE 6")]
    public const int VERTSIZE = 6;
    [NativeTypeName("#define HORZRES 8")]
    public const int HORZRES = 8;
    [NativeTypeName("#define VERTRES 10")]
    public const int VERTRES = 10;
    [NativeTypeName("#define BITSPIXEL 12")]
    public const int BITSPIXEL = 12;
    [NativeTypeName("#define PLANES 14")]
    public const int PLANES = 14;
    [NativeTypeName("#define NUMBRUSHES 16")]
    public const int NUMBRUSHES = 16;
    [NativeTypeName("#define NUMPENS 18")]
    public const int NUMPENS = 18;
    [NativeTypeName("#define NUMMARKERS 20")]
    public const int NUMMARKERS = 20;
    [NativeTypeName("#define NUMFONTS 22")]
    public const int NUMFONTS = 22;
    [NativeTypeName("#define NUMCOLORS 24")]
    public const int NUMCOLORS = 24;
    [NativeTypeName("#define PDEVICESIZE 26")]
    public const int PDEVICESIZE = 26;
    [NativeTypeName("#define CURVECAPS 28")]
    public const int CURVECAPS = 28;
    [NativeTypeName("#define LINECAPS 30")]
    public const int LINECAPS = 30;
    [NativeTypeName("#define POLYGONALCAPS 32")]
    public const int POLYGONALCAPS = 32;
    [NativeTypeName("#define TEXTCAPS 34")]
    public const int TEXTCAPS = 34;
    [NativeTypeName("#define CLIPCAPS 36")]
    public const int CLIPCAPS = 36;
    [NativeTypeName("#define RASTERCAPS 38")]
    public const int RASTERCAPS = 38;
    [NativeTypeName("#define ASPECTX 40")]
    public const int ASPECTX = 40;
    [NativeTypeName("#define ASPECTY 42")]
    public const int ASPECTY = 42;
    [NativeTypeName("#define ASPECTXY 44")]
    public const int ASPECTXY = 44;
    [NativeTypeName("#define LOGPIXELSX 88")]
    public const int LOGPIXELSX = 88;
    [NativeTypeName("#define LOGPIXELSY 90")]
    public const int LOGPIXELSY = 90;
    [NativeTypeName("#define SIZEPALETTE 104")]
    public const int SIZEPALETTE = 104;
    [NativeTypeName("#define NUMRESERVED 106")]
    public const int NUMRESERVED = 106;
    [NativeTypeName("#define COLORRES 108")]
    public const int COLORRES = 108;
    [NativeTypeName("#define PHYSICALWIDTH 110")]
    public const int PHYSICALWIDTH = 110;
    [NativeTypeName("#define PHYSICALHEIGHT 111")]
    public const int PHYSICALHEIGHT = 111;
    [NativeTypeName("#define PHYSICALOFFSETX 112")]
    public const int PHYSICALOFFSETX = 112;
    [NativeTypeName("#define PHYSICALOFFSETY 113")]
    public const int PHYSICALOFFSETY = 113;
    [NativeTypeName("#define SCALINGFACTORX 114")]
    public const int SCALINGFACTORX = 114;
    [NativeTypeName("#define SCALINGFACTORY 115")]
    public const int SCALINGFACTORY = 115;
    [NativeTypeName("#define VREFRESH 116")]
    public const int VREFRESH = 116;
    [NativeTypeName("#define DESKTOPVERTRES 117")]
    public const int DESKTOPVERTRES = 117;
    [NativeTypeName("#define DESKTOPHORZRES 118")]
    public const int DESKTOPHORZRES = 118;
    [NativeTypeName("#define BLTALIGNMENT 119")]
    public const int BLTALIGNMENT = 119;
    [NativeTypeName("#define SHADEBLENDCAPS 120")]
    public const int SHADEBLENDCAPS = 120;
    [NativeTypeName("#define COLORMGMTCAPS 121")]
    public const int COLORMGMTCAPS = 121;
    [NativeTypeName("#define LC_NONE 0")]
    public const int LC_NONE = 0;
    [NativeTypeName("#define LC_POLYLINE 2")]
    public const int LC_POLYLINE = 2;
    [NativeTypeName("#define LC_MARKER 4")]
    public const int LC_MARKER = 4;
    [NativeTypeName("#define LC_POLYMARKER 8")]
    public const int LC_POLYMARKER = 8;
    [NativeTypeName("#define LC_WIDE 16")]
    public const int LC_WIDE = 16;
    [NativeTypeName("#define LC_STYLED 32")]
    public const int LC_STYLED = 32;
    [NativeTypeName("#define LC_WIDESTYLED 64")]
    public const int LC_WIDESTYLED = 64;
    [NativeTypeName("#define LC_INTERIORS 128")]
    public const int LC_INTERIORS = 128;
    [NativeTypeName("#define CP_NONE 0")]
    public const int CP_NONE = 0;
    [NativeTypeName("#define CP_RECTANGLE 1")]
    public const int CP_RECTANGLE = 1;
    [NativeTypeName("#define CP_REGION 2")]
    public const int CP_REGION = 2;
    [NativeTypeName("#define DIB_RGB_COLORS 0")]
    public const int DIB_RGB_COLORS = 0;
    [NativeTypeName("#define DIB_PAL_COLORS 1")]
    public const int DIB_PAL_COLORS = 1;
    [NativeTypeName("#define SYSPAL_ERROR 0")]
    public const int SYSPAL_ERROR = 0;
    [NativeTypeName("#define SYSPAL_STATIC 1")]
    public const int SYSPAL_STATIC = 1;
    [NativeTypeName("#define SYSPAL_NOSTATIC 2")]
    public const int SYSPAL_NOSTATIC = 2;
    [NativeTypeName("#define SYSPAL_NOSTATIC256 3")]
    public const int SYSPAL_NOSTATIC256 = 3;
    [NativeTypeName("#define CBM_INIT 0x04L")]
    public const int CBM_INIT = 0x04;
    [NativeTypeName("#define FLOODFILLBORDER 0")]
    public const int FLOODFILLBORDER = 0;
    [NativeTypeName("#define FLOODFILLSURFACE 1")]
    public const int FLOODFILLSURFACE = 1;
    [NativeTypeName("#define CCHDEVICENAME 32")]
    public const int CCHDEVICENAME = 32;
    [NativeTypeName("#define CCHFORMNAME 32")]
    public const int CCHFORMNAME = 32;
    [NativeTypeName("#define DMORIENT_PORTRAIT 1")]
    public const int DMORIENT_PORTRAIT = 1;
    [NativeTypeName("#define DMORIENT_LANDSCAPE 2")]
    public const int DMORIENT_LANDSCAPE = 2;
    [NativeTypeName("#define DMRES_DRAFT (-1)")]
    public const int DMRES_DRAFT = (-1);
    [NativeTypeName("#define DMRES_LOW (-2)")]
    public const int DMRES_LOW = (-2);
    [NativeTypeName("#define DMRES_MEDIUM (-3)")]
    public const int DMRES_MEDIUM = (-3);
    [NativeTypeName("#define DMRES_HIGH (-4)")]
    public const int DMRES_HIGH = (-4);
    [NativeTypeName("#define DMCOLOR_MONOCHROME 1")]
    public const int DMCOLOR_MONOCHROME = 1;
    [NativeTypeName("#define DMCOLOR_COLOR 2")]
    public const int DMCOLOR_COLOR = 2;
    [NativeTypeName("#define DMDUP_SIMPLEX 1")]
    public const int DMDUP_SIMPLEX = 1;
    [NativeTypeName("#define DMDUP_VERTICAL 2")]
    public const int DMDUP_VERTICAL = 2;
    [NativeTypeName("#define DMDUP_HORIZONTAL 3")]
    public const int DMDUP_HORIZONTAL = 3;
    [NativeTypeName("#define DMTT_BITMAP 1")]
    public const int DMTT_BITMAP = 1;
    [NativeTypeName("#define DMTT_DOWNLOAD 2")]
    public const int DMTT_DOWNLOAD = 2;
    [NativeTypeName("#define DMTT_SUBDEV 3")]
    public const int DMTT_SUBDEV = 3;
    [NativeTypeName("#define DMTT_DOWNLOAD_OUTLINE 4")]
    public const int DMTT_DOWNLOAD_OUTLINE = 4;
    [NativeTypeName("#define DMCOLLATE_FALSE 0")]
    public const int DMCOLLATE_FALSE = 0;
    [NativeTypeName("#define DMCOLLATE_TRUE 1")]
    public const int DMCOLLATE_TRUE = 1;
    [NativeTypeName("#define DMDO_DEFAULT 0")]
    public const int DMDO_DEFAULT = 0;
    [NativeTypeName("#define DMDO_90 1")]
    public const int DMDO_90 = 1;
    [NativeTypeName("#define DMDO_180 2")]
    public const int DMDO_180 = 2;
    [NativeTypeName("#define DMDO_270 3")]
    public const int DMDO_270 = 3;
    [NativeTypeName("#define DMDFO_DEFAULT 0")]
    public const int DMDFO_DEFAULT = 0;
    [NativeTypeName("#define DMDFO_STRETCH 1")]
    public const int DMDFO_STRETCH = 1;
    [NativeTypeName("#define DMDFO_CENTER 2")]
    public const int DMDFO_CENTER = 2;
    [NativeTypeName("#define DMDISPLAYFLAGS_TEXTMODE 0x00000004")]
    public const int DMDISPLAYFLAGS_TEXTMODE = 0x00000004;
    [NativeTypeName("#define DMNUP_SYSTEM 1")]
    public const int DMNUP_SYSTEM = 1;
    [NativeTypeName("#define DMNUP_ONEUP 2")]
    public const int DMNUP_ONEUP = 2;
    [NativeTypeName("#define DMICMMETHOD_NONE 1")]
    public const int DMICMMETHOD_NONE = 1;
    [NativeTypeName("#define DMICMMETHOD_SYSTEM 2")]
    public const int DMICMMETHOD_SYSTEM = 2;
    [NativeTypeName("#define DMICMMETHOD_DRIVER 3")]
    public const int DMICMMETHOD_DRIVER = 3;
    [NativeTypeName("#define DMICMMETHOD_DEVICE 4")]
    public const int DMICMMETHOD_DEVICE = 4;
    [NativeTypeName("#define DMICMMETHOD_USER 256")]
    public const int DMICMMETHOD_USER = 256;
    [NativeTypeName("#define DMICM_SATURATE 1")]
    public const int DMICM_SATURATE = 1;
    [NativeTypeName("#define DMICM_CONTRAST 2")]
    public const int DMICM_CONTRAST = 2;
    [NativeTypeName("#define DMICM_COLORIMETRIC 3")]
    public const int DMICM_COLORIMETRIC = 3;
    [NativeTypeName("#define DMICM_ABS_COLORIMETRIC 4")]
    public const int DMICM_ABS_COLORIMETRIC = 4;
    [NativeTypeName("#define DMICM_USER 256")]
    public const int DMICM_USER = 256;
    [NativeTypeName("#define DMMEDIA_STANDARD 1")]
    public const int DMMEDIA_STANDARD = 1;
    [NativeTypeName("#define DMMEDIA_TRANSPARENCY 2")]
    public const int DMMEDIA_TRANSPARENCY = 2;
    [NativeTypeName("#define DMMEDIA_GLOSSY 3")]
    public const int DMMEDIA_GLOSSY = 3;
    [NativeTypeName("#define DMMEDIA_USER 256")]
    public const int DMMEDIA_USER = 256;
    [NativeTypeName("#define QDC_ALL_PATHS 0x00000001")]
    public const int QDC_ALL_PATHS = 0x00000001;
    [NativeTypeName("#define QDC_ONLY_ACTIVE_PATHS 0x00000002")]
    public const int QDC_ONLY_ACTIVE_PATHS = 0x00000002;
    [NativeTypeName("#define QDC_DATABASE_CURRENT 0x00000004")]
    public const int QDC_DATABASE_CURRENT = 0x00000004;
    [NativeTypeName("#define QDC_VIRTUAL_MODE_AWARE 0x00000010")]
    public const int QDC_VIRTUAL_MODE_AWARE = 0x00000010;
    [NativeTypeName("#define QDC_INCLUDE_HMD 0x00000020")]
    public const int QDC_INCLUDE_HMD = 0x00000020;
    [NativeTypeName("#define QDC_VIRTUAL_REFRESH_RATE_AWARE 0x00000040")]
    public const int QDC_VIRTUAL_REFRESH_RATE_AWARE = 0x00000040;
    [NativeTypeName("#define RDH_RECTANGLES 1")]
    public const int RDH_RECTANGLES = 1;
    [NativeTypeName("#define SYSRGN 4")]
    public const int SYSRGN = 4;
    [NativeTypeName("#define GGO_METRICS 0")]
    public const int GGO_METRICS = 0;
    [NativeTypeName("#define GGO_BITMAP 1")]
    public const int GGO_BITMAP = 1;
    [NativeTypeName("#define GGO_NATIVE 2")]
    public const int GGO_NATIVE = 2;
    [NativeTypeName("#define GGO_BEZIER 3")]
    public const int GGO_BEZIER = 3;
    [NativeTypeName("#define GGO_GRAY2_BITMAP 4")]
    public const int GGO_GRAY2_BITMAP = 4;
    [NativeTypeName("#define GGO_GRAY4_BITMAP 5")]
    public const int GGO_GRAY4_BITMAP = 5;
    [NativeTypeName("#define GGO_GRAY8_BITMAP 6")]
    public const int GGO_GRAY8_BITMAP = 6;
    [NativeTypeName("#define GGO_GLYPH_INDEX 0x0080")]
    public const int GGO_GLYPH_INDEX = 0x0080;
    [NativeTypeName("#define GGO_UNHINTED 0x0100")]
    public const int GGO_UNHINTED = 0x0100;
    [NativeTypeName("#define TT_POLYGON_TYPE 24")]
    public const int TT_POLYGON_TYPE = 24;
    [NativeTypeName("#define TT_PRIM_LINE 1")]
    public const int TT_PRIM_LINE = 1;
    [NativeTypeName("#define TT_PRIM_QSPLINE 2")]
    public const int TT_PRIM_QSPLINE = 2;
    [NativeTypeName("#define TT_PRIM_CSPLINE 3")]
    public const int TT_PRIM_CSPLINE = 3;
    [NativeTypeName("#define FLI_MASK 0x103B")]
    public const int FLI_MASK = 0x103B;
    [NativeTypeName("#define FLI_GLYPHS 0x00040000L")]
    public const int FLI_GLYPHS = 0x00040000;
    [NativeTypeName("#define GCPGLYPH_LINKBEFORE 0x8000")]
    public const int GCPGLYPH_LINKBEFORE = 0x8000;
    [NativeTypeName("#define GCPGLYPH_LINKAFTER 0x4000")]
    public const int GCPGLYPH_LINKAFTER = 0x4000;
    [NativeTypeName("#define TT_AVAILABLE 0x0001")]
    public const int TT_AVAILABLE = 0x0001;
    [NativeTypeName("#define TT_ENABLED 0x0002")]
    public const int TT_ENABLED = 0x0002;
    [NativeTypeName("#define AddFontResource AddFontResourceW")]
    public static delegate*<ushort*, int> AddFontResource => &AddFontResourceW;

    [NativeTypeName("#define CopyMetaFile CopyMetaFileW")]
    public static delegate*<HMETAFILE, ushort*, HMETAFILE> CopyMetaFile => &CopyMetaFileW;

    [NativeTypeName("#define CreateDC CreateDCW")]
    public static delegate*<ushort*, ushort*, ushort*, DEVMODEW*, HDC> CreateDC => &CreateDCW;

    [NativeTypeName("#define CreateFontIndirect CreateFontIndirectW")]
    public static delegate*<LOGFONTW*, HFONT> CreateFontIndirect => &CreateFontIndirectW;

    [NativeTypeName("#define CreateFont CreateFontW")]
    public static delegate*<int, int, int, int, int, uint, uint, uint, uint, uint, uint, uint, uint, ushort*, HFONT> CreateFont => &CreateFontW;

    [NativeTypeName("#define CreateIC CreateICW")]
    public static delegate*<ushort*, ushort*, ushort*, DEVMODEW*, HDC> CreateIC => &CreateICW;

    [NativeTypeName("#define CreateMetaFile CreateMetaFileW")]
    public static delegate*<ushort*, HDC> CreateMetaFile => &CreateMetaFileW;

    [NativeTypeName("#define CreateScalableFontResource CreateScalableFontResourceW")]
    public static delegate*<uint, ushort*, ushort*, ushort*, BOOL> CreateScalableFontResource => &CreateScalableFontResourceW;

    [NativeTypeName("#define PRINTRATEUNIT_PPM 1")]
    public const int PRINTRATEUNIT_PPM = 1;
    [NativeTypeName("#define PRINTRATEUNIT_CPS 2")]
    public const int PRINTRATEUNIT_CPS = 2;
    [NativeTypeName("#define PRINTRATEUNIT_LPM 3")]
    public const int PRINTRATEUNIT_LPM = 3;
    [NativeTypeName("#define PRINTRATEUNIT_IPM 4")]
    public const int PRINTRATEUNIT_IPM = 4;
    [NativeTypeName("#define DCTT_BITMAP 0x0000001L")]
    public const int DCTT_BITMAP = 0x0000001;
    [NativeTypeName("#define DCTT_DOWNLOAD 0x0000002L")]
    public const int DCTT_DOWNLOAD = 0x0000002;
    [NativeTypeName("#define DCTT_SUBDEV 0x0000004L")]
    public const int DCTT_SUBDEV = 0x0000004;
    [NativeTypeName("#define DCTT_DOWNLOAD_OUTLINE 0x0000008L")]
    public const int DCTT_DOWNLOAD_OUTLINE = 0x0000008;
    [NativeTypeName("#define DCBA_FACEUPNONE 0x0000")]
    public const int DCBA_FACEUPNONE = 0x0000;
    [NativeTypeName("#define DCBA_FACEUPCENTER 0x0001")]
    public const int DCBA_FACEUPCENTER = 0x0001;
    [NativeTypeName("#define DCBA_FACEUPLEFT 0x0002")]
    public const int DCBA_FACEUPLEFT = 0x0002;
    [NativeTypeName("#define DCBA_FACEUPRIGHT 0x0003")]
    public const int DCBA_FACEUPRIGHT = 0x0003;
    [NativeTypeName("#define DCBA_FACEDOWNNONE 0x0100")]
    public const int DCBA_FACEDOWNNONE = 0x0100;
    [NativeTypeName("#define DCBA_FACEDOWNCENTER 0x0101")]
    public const int DCBA_FACEDOWNCENTER = 0x0101;
    [NativeTypeName("#define DCBA_FACEDOWNLEFT 0x0102")]
    public const int DCBA_FACEDOWNLEFT = 0x0102;
    [NativeTypeName("#define DCBA_FACEDOWNRIGHT 0x0103")]
    public const int DCBA_FACEDOWNRIGHT = 0x0103;
    [NativeTypeName("#define EnumFontFamiliesEx EnumFontFamiliesExW")]
    public static delegate*<HDC, LOGFONTW*, delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, LPARAM, int> , LPARAM, uint, int> EnumFontFamiliesEx => &EnumFontFamiliesExW;

    [NativeTypeName("#define EnumFontFamilies EnumFontFamiliesW")]
    public static delegate*<HDC, ushort*, delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, LPARAM, int> , LPARAM, int> EnumFontFamilies => &EnumFontFamiliesW;

    [NativeTypeName("#define EnumFonts EnumFontsW")]
    public static delegate*<HDC, ushort*, delegate* unmanaged<LOGFONTW*, TEXTMETRICW*, uint, LPARAM, int> , LPARAM, int> EnumFonts => &EnumFontsW;

    [NativeTypeName("#define GetCharWidth GetCharWidthW")]
    public static delegate*<HDC, uint, uint, int*, BOOL> GetCharWidth => &GetCharWidthW;

    [NativeTypeName("#define GetCharWidth32 GetCharWidth32W")]
    public static delegate*<HDC, uint, uint, int*, BOOL> GetCharWidth32 => &GetCharWidth32W;

    [NativeTypeName("#define GetCharWidthFloat GetCharWidthFloatW")]
    public static delegate*<HDC, uint, uint, float*, BOOL> GetCharWidthFloat => &GetCharWidthFloatW;

    [NativeTypeName("#define GetCharABCWidths GetCharABCWidthsW")]
    public static delegate*<HDC, uint, uint, ABC*, BOOL> GetCharABCWidths => &GetCharABCWidthsW;

    [NativeTypeName("#define GetCharABCWidthsFloat GetCharABCWidthsFloatW")]
    public static delegate*<HDC, uint, uint, ABCFLOAT*, BOOL> GetCharABCWidthsFloat => &GetCharABCWidthsFloatW;

    [NativeTypeName("#define GetGlyphOutline GetGlyphOutlineW")]
    public static delegate*<HDC, uint, uint, GLYPHMETRICS*, uint, void*, MAT2*, uint> GetGlyphOutline => &GetGlyphOutlineW;

    [NativeTypeName("#define GetMetaFile GetMetaFileW")]
    public static delegate*<ushort*, HMETAFILE> GetMetaFile => &GetMetaFileW;

    [NativeTypeName("#define GetOutlineTextMetrics GetOutlineTextMetricsW")]
    public static delegate*<HDC, uint, OUTLINETEXTMETRICW*, uint> GetOutlineTextMetrics => &GetOutlineTextMetricsW;

    [NativeTypeName("#define GetTextExtentPoint GetTextExtentPointW")]
    public static delegate*<HDC, ushort*, int, SIZE*, BOOL> GetTextExtentPoint => &GetTextExtentPointW;

    [NativeTypeName("#define GetTextExtentPoint32 GetTextExtentPoint32W")]
    public static delegate*<HDC, ushort*, int, SIZE*, BOOL> GetTextExtentPoint32 => &GetTextExtentPoint32W;

    [NativeTypeName("#define GetTextExtentExPoint GetTextExtentExPointW")]
    public static delegate*<HDC, ushort*, int, int, int*, int*, SIZE*, BOOL> GetTextExtentExPoint => &GetTextExtentExPointW;

    [NativeTypeName("#define GetCharacterPlacement GetCharacterPlacementW")]
    public static delegate*<HDC, ushort*, int, int, GCP_RESULTSW*, uint, uint> GetCharacterPlacement => &GetCharacterPlacementW;

    [NativeTypeName("#define GS_8BIT_INDICES 0x00000001")]
    public const int GS_8BIT_INDICES = 0x00000001;
    [NativeTypeName("#define GGI_MARK_NONEXISTING_GLYPHS 0X0001")]
    public const int GGI_MARK_NONEXISTING_GLYPHS = 0X0001;
    [NativeTypeName("#define GetGlyphIndices GetGlyphIndicesW")]
    public static delegate*<HDC, ushort*, int, ushort*, uint, uint> GetGlyphIndices => &GetGlyphIndicesW;

    [NativeTypeName("#define STAMP_DESIGNVECTOR (0x8000000 + 'd' + ('v' << 8))")]
    public const int STAMP_DESIGNVECTOR = (0x8000000 + 'd' + ('v' << 8));
    [NativeTypeName("#define STAMP_AXESLIST (0x8000000 + 'a' + ('l' << 8))")]
    public const int STAMP_AXESLIST = (0x8000000 + 'a' + ('l' << 8));
    [NativeTypeName("#define STAMP_TRUETYPE_VARIATION (0x8000000 + 't' + ('v' << 8))")]
    public const int STAMP_TRUETYPE_VARIATION = (0x8000000 + 't' + ('v' << 8));
    [NativeTypeName("#define STAMP_CFF2 (0x8000000 + 'c' + ('v' << 8))")]
    public const int STAMP_CFF2 = (0x8000000 + 'c' + ('v' << 8));
    [NativeTypeName("#define AddFontResourceEx AddFontResourceExW")]
    public static delegate*<ushort*, uint, void*, int> AddFontResourceEx => &AddFontResourceExW;

    [NativeTypeName("#define RemoveFontResourceEx RemoveFontResourceExW")]
    public static delegate*<ushort*, uint, void*, BOOL> RemoveFontResourceEx => &RemoveFontResourceExW;

    [NativeTypeName("#define CreateFontIndirectEx CreateFontIndirectExW")]
    public static delegate*<ENUMLOGFONTEXDVW*, HFONT> CreateFontIndirectEx => &CreateFontIndirectExW;

    [NativeTypeName("#define ResetDC ResetDCW")]
    public static delegate*<HDC, DEVMODEW*, HDC> ResetDC => &ResetDCW;

    [NativeTypeName("#define RemoveFontResource RemoveFontResourceW")]
    public static delegate*<ushort*, BOOL> RemoveFontResource => &RemoveFontResourceW;

    [NativeTypeName("#define AC_SRC_OVER 0x00")]
    public const int AC_SRC_OVER = 0x00;
    [NativeTypeName("#define AC_SRC_ALPHA 0x01")]
    public const int AC_SRC_ALPHA = 0x01;
    [NativeTypeName("#define GRADIENT_FILL_RECT_H 0x00000000")]
    public const int GRADIENT_FILL_RECT_H = 0x00000000;
    [NativeTypeName("#define GRADIENT_FILL_RECT_V 0x00000001")]
    public const int GRADIENT_FILL_RECT_V = 0x00000001;
    [NativeTypeName("#define GRADIENT_FILL_TRIANGLE 0x00000002")]
    public const int GRADIENT_FILL_TRIANGLE = 0x00000002;
    [NativeTypeName("#define GRADIENT_FILL_OP_FLAG 0x000000ff")]
    public const int GRADIENT_FILL_OP_FLAG = 0x000000ff;
    [NativeTypeName("#define CopyEnhMetaFile CopyEnhMetaFileW")]
    public static delegate*<HENHMETAFILE, ushort*, HENHMETAFILE> CopyEnhMetaFile => &CopyEnhMetaFileW;

    [NativeTypeName("#define CreateEnhMetaFile CreateEnhMetaFileW")]
    public static delegate*<HDC, ushort*, RECT*, ushort*, HDC> CreateEnhMetaFile => &CreateEnhMetaFileW;

    [NativeTypeName("#define GetEnhMetaFile GetEnhMetaFileW")]
    public static delegate*<ushort*, HENHMETAFILE> GetEnhMetaFile => &GetEnhMetaFileW;

    [NativeTypeName("#define GetEnhMetaFileDescription GetEnhMetaFileDescriptionW")]
    public static delegate*<HENHMETAFILE, uint, ushort*, uint> GetEnhMetaFileDescription => &GetEnhMetaFileDescriptionW;

    [NativeTypeName("#define GetTextMetrics GetTextMetricsW")]
    public static delegate*<HDC, TEXTMETRICW*, BOOL> GetTextMetrics => &GetTextMetricsW;

    [NativeTypeName("#define CA_NEGATIVE 0x0001")]
    public const int CA_NEGATIVE = 0x0001;
    [NativeTypeName("#define CA_LOG_FILTER 0x0002")]
    public const int CA_LOG_FILTER = 0x0002;
    [NativeTypeName("#define RGB_GAMMA_MIN (WORD)02500")]
    public const ushort RGB_GAMMA_MIN = (ushort)(02500);
    [NativeTypeName("#define RGB_GAMMA_MAX (WORD)65000")]
    public const ushort RGB_GAMMA_MAX = (ushort)(65000);
    [NativeTypeName("#define REFERENCE_WHITE_MIN (WORD)6000")]
    public const ushort REFERENCE_WHITE_MIN = (ushort)(6000);
    [NativeTypeName("#define REFERENCE_WHITE_MAX (WORD)10000")]
    public const ushort REFERENCE_WHITE_MAX = (ushort)(10000);
    [NativeTypeName("#define REFERENCE_BLACK_MIN (WORD)0")]
    public const ushort REFERENCE_BLACK_MIN = (ushort)(0);
    [NativeTypeName("#define REFERENCE_BLACK_MAX (WORD)4000")]
    public const ushort REFERENCE_BLACK_MAX = (ushort)(4000);
    [NativeTypeName("#define StartDoc StartDocW")]
    public static delegate*<HDC, DOCINFOW*, int> StartDoc => &StartDocW;

    [NativeTypeName("#define GetObject GetObjectW")]
    public static delegate*<HANDLE, int, void*, int> GetObject => &GetObjectW;

    [NativeTypeName("#define TextOut TextOutW")]
    public static delegate*<HDC, int, int, ushort*, int, BOOL> TextOut => &TextOutW;

    [NativeTypeName("#define ExtTextOut ExtTextOutW")]
    public static delegate*<HDC, int, int, uint, RECT*, ushort*, uint, int*, BOOL> ExtTextOut => &ExtTextOutW;

    [NativeTypeName("#define PolyTextOut PolyTextOutW")]
    public static delegate*<HDC, POLYTEXTW*, int, BOOL> PolyTextOut => &PolyTextOutW;

    [NativeTypeName("#define GetTextFace GetTextFaceW")]
    public static delegate*<HDC, int, ushort*, int> GetTextFace => &GetTextFaceW;

    [NativeTypeName("#define FONTMAPPER_MAX 10")]
    public const int FONTMAPPER_MAX = 10;
    [NativeTypeName("#define GetKerningPairs GetKerningPairsW")]
    public static delegate*<HDC, uint, KERNINGPAIR*, uint> GetKerningPairs => &GetKerningPairsW;

    [NativeTypeName("#define GetLogColorSpace GetLogColorSpaceW")]
    public static delegate*<HCOLORSPACE, LOGCOLORSPACEW*, uint, BOOL> GetLogColorSpace => &GetLogColorSpaceW;

    [NativeTypeName("#define CreateColorSpace CreateColorSpaceW")]
    public static delegate*<LOGCOLORSPACEW*, HCOLORSPACE> CreateColorSpace => &CreateColorSpaceW;

    [NativeTypeName("#define GetICMProfile GetICMProfileW")]
    public static delegate*<HDC, uint*, ushort*, BOOL> GetICMProfile => &GetICMProfileW;

    [NativeTypeName("#define SetICMProfile SetICMProfileW")]
    public static delegate*<HDC, ushort*, BOOL> SetICMProfile => &SetICMProfileW;

    [NativeTypeName("#define EnumICMProfiles EnumICMProfilesW")]
    public static delegate*<HDC, delegate* unmanaged<ushort*, LPARAM, int> , LPARAM, int> EnumICMProfiles => &EnumICMProfilesW;

    [NativeTypeName("#define UpdateICMRegKey UpdateICMRegKeyW")]
    public static delegate*<uint, ushort*, ushort*, uint, BOOL> UpdateICMRegKey => &UpdateICMRegKeyW;

    [NativeTypeName("#define ENHMETA_SIGNATURE 0x464D4520")]
    public const int ENHMETA_SIGNATURE = 0x464D4520;
    [NativeTypeName("#define ENHMETA_STOCK_OBJECT 0x80000000")]
    public const uint ENHMETA_STOCK_OBJECT = 0x80000000;
    [NativeTypeName("#define SETICMPROFILE_EMBEDED 0x00000001")]
    public const int SETICMPROFILE_EMBEDED = 0x00000001;
    [NativeTypeName("#define CREATECOLORSPACE_EMBEDED 0x00000001")]
    public const int CREATECOLORSPACE_EMBEDED = 0x00000001;
    [NativeTypeName("#define COLORMATCHTOTARGET_EMBEDED 0x00000001")]
    public const int COLORMATCHTOTARGET_EMBEDED = 0x00000001;
    [NativeTypeName("#define GDICOMMENT_IDENTIFIER 0x43494447")]
    public const int GDICOMMENT_IDENTIFIER = 0x43494447;
    [NativeTypeName("#define GDICOMMENT_WINDOWS_METAFILE 0x80000001")]
    public const uint GDICOMMENT_WINDOWS_METAFILE = 0x80000001;
    [NativeTypeName("#define GDICOMMENT_BEGINGROUP 0x00000002")]
    public const int GDICOMMENT_BEGINGROUP = 0x00000002;
    [NativeTypeName("#define GDICOMMENT_ENDGROUP 0x00000003")]
    public const int GDICOMMENT_ENDGROUP = 0x00000003;
    [NativeTypeName("#define GDICOMMENT_MULTIFORMATS 0x40000004")]
    public const int GDICOMMENT_MULTIFORMATS = 0x40000004;
    [NativeTypeName("#define EPS_SIGNATURE 0x46535045")]
    public const int EPS_SIGNATURE = 0x46535045;
    [NativeTypeName("#define GDICOMMENT_UNICODE_STRING 0x00000040")]
    public const int GDICOMMENT_UNICODE_STRING = 0x00000040;
    [NativeTypeName("#define GDICOMMENT_UNICODE_END 0x00000080")]
    public const int GDICOMMENT_UNICODE_END = 0x00000080;
    [NativeTypeName("#define wglUseFontBitmaps wglUseFontBitmapsW")]
    public static delegate*<HDC, uint, uint, uint, BOOL> wglUseFontBitmaps => &wglUseFontBitmapsW;

    [NativeTypeName("#define wglUseFontOutlines wglUseFontOutlinesW")]
    public static delegate*<HDC, uint, uint, uint, float, float, int, GLYPHMETRICSFLOAT*, BOOL> wglUseFontOutlines => &wglUseFontOutlinesW;
}