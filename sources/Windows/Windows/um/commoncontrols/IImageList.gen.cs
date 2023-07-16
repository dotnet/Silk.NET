// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IImageList.xml' path='doc/member[@name="IImageList"]/*'/>
[Guid("46EB5926-582E-4017-9FDF-E8998DAA0950")]
[NativeTypeName("struct IImageList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IImageList : IImageList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IImageList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IImageList*, Guid*, void**, int> )(lpVtbl[0]))((IImageList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IImageList*, uint> )(lpVtbl[1]))((IImageList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IImageList*, uint> )(lpVtbl[2]))((IImageList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.Add"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Add(HBITMAP hbmImage, HBITMAP hbmMask, int* pi)
    {
        return ((delegate* unmanaged<IImageList*, HBITMAP, HBITMAP, int*, int> )(lpVtbl[3]))((IImageList*)Unsafe.AsPointer(ref this), hbmImage, hbmMask, pi);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.ReplaceIcon"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReplaceIcon(int i, HICON hicon, int* pi)
    {
        return ((delegate* unmanaged<IImageList*, int, HICON, int*, int> )(lpVtbl[4]))((IImageList*)Unsafe.AsPointer(ref this), i, hicon, pi);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.SetOverlayImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOverlayImage(int iImage, int iOverlay)
    {
        return ((delegate* unmanaged<IImageList*, int, int, int> )(lpVtbl[5]))((IImageList*)Unsafe.AsPointer(ref this), iImage, iOverlay);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.Replace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Replace(int i, HBITMAP hbmImage, HBITMAP hbmMask)
    {
        return ((delegate* unmanaged<IImageList*, int, HBITMAP, HBITMAP, int> )(lpVtbl[6]))((IImageList*)Unsafe.AsPointer(ref this), i, hbmImage, hbmMask);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.AddMasked"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddMasked(HBITMAP hbmImage, COLORREF crMask, int* pi)
    {
        return ((delegate* unmanaged<IImageList*, HBITMAP, COLORREF, int*, int> )(lpVtbl[7]))((IImageList*)Unsafe.AsPointer(ref this), hbmImage, crMask, pi);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.Draw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Draw(IMAGELISTDRAWPARAMS* pimldp)
    {
        return ((delegate* unmanaged<IImageList*, IMAGELISTDRAWPARAMS*, int> )(lpVtbl[8]))((IImageList*)Unsafe.AsPointer(ref this), pimldp);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.Remove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Remove(int i)
    {
        return ((delegate* unmanaged<IImageList*, int, int> )(lpVtbl[9]))((IImageList*)Unsafe.AsPointer(ref this), i);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.GetIcon"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetIcon(int i, uint flags, HICON* picon)
    {
        return ((delegate* unmanaged<IImageList*, int, uint, HICON*, int> )(lpVtbl[10]))((IImageList*)Unsafe.AsPointer(ref this), i, flags, picon);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.GetImageInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetImageInfo(int i, IMAGEINFO* pImageInfo)
    {
        return ((delegate* unmanaged<IImageList*, int, IMAGEINFO*, int> )(lpVtbl[11]))((IImageList*)Unsafe.AsPointer(ref this), i, pImageInfo);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.Copy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Copy(int iDst, IUnknown* punkSrc, int iSrc, uint uFlags)
    {
        return ((delegate* unmanaged<IImageList*, int, IUnknown*, int, uint, int> )(lpVtbl[12]))((IImageList*)Unsafe.AsPointer(ref this), iDst, punkSrc, iSrc, uFlags);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.Merge"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Merge(int i1, IUnknown* punk2, int i2, int dx, int dy, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IImageList*, int, IUnknown*, int, int, int, Guid*, void**, int> )(lpVtbl[13]))((IImageList*)Unsafe.AsPointer(ref this), i1, punk2, i2, dx, dy, riid, ppv);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Clone([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IImageList*, Guid*, void**, int> )(lpVtbl[14]))((IImageList*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.GetImageRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetImageRect(int i, RECT* prc)
    {
        return ((delegate* unmanaged<IImageList*, int, RECT*, int> )(lpVtbl[15]))((IImageList*)Unsafe.AsPointer(ref this), i, prc);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.GetIconSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetIconSize(int* cx, int* cy)
    {
        return ((delegate* unmanaged<IImageList*, int*, int*, int> )(lpVtbl[16]))((IImageList*)Unsafe.AsPointer(ref this), cx, cy);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.SetIconSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetIconSize(int cx, int cy)
    {
        return ((delegate* unmanaged<IImageList*, int, int, int> )(lpVtbl[17]))((IImageList*)Unsafe.AsPointer(ref this), cx, cy);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.GetImageCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetImageCount(int* pi)
    {
        return ((delegate* unmanaged<IImageList*, int*, int> )(lpVtbl[18]))((IImageList*)Unsafe.AsPointer(ref this), pi);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.SetImageCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetImageCount(uint uNewCount)
    {
        return ((delegate* unmanaged<IImageList*, uint, int> )(lpVtbl[19]))((IImageList*)Unsafe.AsPointer(ref this), uNewCount);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.SetBkColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetBkColor(COLORREF clrBk, COLORREF* pclr)
    {
        return ((delegate* unmanaged<IImageList*, COLORREF, COLORREF*, int> )(lpVtbl[20]))((IImageList*)Unsafe.AsPointer(ref this), clrBk, pclr);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.GetBkColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetBkColor(COLORREF* pclr)
    {
        return ((delegate* unmanaged<IImageList*, COLORREF*, int> )(lpVtbl[21]))((IImageList*)Unsafe.AsPointer(ref this), pclr);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.BeginDrag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT BeginDrag(int iTrack, int dxHotspot, int dyHotspot)
    {
        return ((delegate* unmanaged<IImageList*, int, int, int, int> )(lpVtbl[22]))((IImageList*)Unsafe.AsPointer(ref this), iTrack, dxHotspot, dyHotspot);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.EndDrag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT EndDrag()
    {
        return ((delegate* unmanaged<IImageList*, int> )(lpVtbl[23]))((IImageList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.DragEnter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT DragEnter(HWND hwndLock, int x, int y)
    {
        return ((delegate* unmanaged<IImageList*, HWND, int, int, int> )(lpVtbl[24]))((IImageList*)Unsafe.AsPointer(ref this), hwndLock, x, y);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.DragLeave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT DragLeave(HWND hwndLock)
    {
        return ((delegate* unmanaged<IImageList*, HWND, int> )(lpVtbl[25]))((IImageList*)Unsafe.AsPointer(ref this), hwndLock);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.DragMove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT DragMove(int x, int y)
    {
        return ((delegate* unmanaged<IImageList*, int, int, int> )(lpVtbl[26]))((IImageList*)Unsafe.AsPointer(ref this), x, y);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.SetDragCursorImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetDragCursorImage(IUnknown* punk, int iDrag, int dxHotspot, int dyHotspot)
    {
        return ((delegate* unmanaged<IImageList*, IUnknown*, int, int, int, int> )(lpVtbl[27]))((IImageList*)Unsafe.AsPointer(ref this), punk, iDrag, dxHotspot, dyHotspot);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.DragShowNolock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT DragShowNolock(BOOL fShow)
    {
        return ((delegate* unmanaged<IImageList*, BOOL, int> )(lpVtbl[28]))((IImageList*)Unsafe.AsPointer(ref this), fShow);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.GetDragImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetDragImage(POINT* ppt, POINT* pptHotspot, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IImageList*, POINT*, POINT*, Guid*, void**, int> )(lpVtbl[29]))((IImageList*)Unsafe.AsPointer(ref this), ppt, pptHotspot, riid, ppv);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.GetItemFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetItemFlags(int i, [NativeTypeName("DWORD *")] uint* dwFlags)
    {
        return ((delegate* unmanaged<IImageList*, int, uint*, int> )(lpVtbl[30]))((IImageList*)Unsafe.AsPointer(ref this), i, dwFlags);
    }

    /// <include file='IImageList.xml' path='doc/member[@name="IImageList.GetOverlayImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetOverlayImage(int iOverlay, int* piIndex)
    {
        return ((delegate* unmanaged<IImageList*, int, int*, int> )(lpVtbl[31]))((IImageList*)Unsafe.AsPointer(ref this), iOverlay, piIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Add(HBITMAP hbmImage, HBITMAP hbmMask, int* pi);
        [VtblIndex(4)]
        HRESULT ReplaceIcon(int i, HICON hicon, int* pi);
        [VtblIndex(5)]
        HRESULT SetOverlayImage(int iImage, int iOverlay);
        [VtblIndex(6)]
        HRESULT Replace(int i, HBITMAP hbmImage, HBITMAP hbmMask);
        [VtblIndex(7)]
        HRESULT AddMasked(HBITMAP hbmImage, COLORREF crMask, int* pi);
        [VtblIndex(8)]
        HRESULT Draw(IMAGELISTDRAWPARAMS* pimldp);
        [VtblIndex(9)]
        HRESULT Remove(int i);
        [VtblIndex(10)]
        HRESULT GetIcon(int i, uint flags, HICON* picon);
        [VtblIndex(11)]
        HRESULT GetImageInfo(int i, IMAGEINFO* pImageInfo);
        [VtblIndex(12)]
        HRESULT Copy(int iDst, IUnknown* punkSrc, int iSrc, uint uFlags);
        [VtblIndex(13)]
        HRESULT Merge(int i1, IUnknown* punk2, int i2, int dx, int dy, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(14)]
        HRESULT Clone([NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(15)]
        HRESULT GetImageRect(int i, RECT* prc);
        [VtblIndex(16)]
        HRESULT GetIconSize(int* cx, int* cy);
        [VtblIndex(17)]
        HRESULT SetIconSize(int cx, int cy);
        [VtblIndex(18)]
        HRESULT GetImageCount(int* pi);
        [VtblIndex(19)]
        HRESULT SetImageCount(uint uNewCount);
        [VtblIndex(20)]
        HRESULT SetBkColor(COLORREF clrBk, COLORREF* pclr);
        [VtblIndex(21)]
        HRESULT GetBkColor(COLORREF* pclr);
        [VtblIndex(22)]
        HRESULT BeginDrag(int iTrack, int dxHotspot, int dyHotspot);
        [VtblIndex(23)]
        HRESULT EndDrag();
        [VtblIndex(24)]
        HRESULT DragEnter(HWND hwndLock, int x, int y);
        [VtblIndex(25)]
        HRESULT DragLeave(HWND hwndLock);
        [VtblIndex(26)]
        HRESULT DragMove(int x, int y);
        [VtblIndex(27)]
        HRESULT SetDragCursorImage(IUnknown* punk, int iDrag, int dxHotspot, int dyHotspot);
        [VtblIndex(28)]
        HRESULT DragShowNolock(BOOL fShow);
        [VtblIndex(29)]
        HRESULT GetDragImage(POINT* ppt, POINT* pptHotspot, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(30)]
        HRESULT GetItemFlags(int i, [NativeTypeName("DWORD *")] uint* dwFlags);
        [VtblIndex(31)]
        HRESULT GetOverlayImage(int iOverlay, int* piIndex);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (HBITMAP, HBITMAP, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HBITMAP, HBITMAP, int*, int> Add;
        [NativeTypeName("HRESULT (int, HICON, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HICON, int*, int> ReplaceIcon;
        [NativeTypeName("HRESULT (int, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetOverlayImage;
        [NativeTypeName("HRESULT (int, HBITMAP, HBITMAP) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HBITMAP, HBITMAP, int> Replace;
        [NativeTypeName("HRESULT (HBITMAP, COLORREF, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HBITMAP, COLORREF, int*, int> AddMasked;
        [NativeTypeName("HRESULT (IMAGELISTDRAWPARAMS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMAGELISTDRAWPARAMS*, int> Draw;
        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> Remove;
        [NativeTypeName("HRESULT (int, UINT, HICON *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, HICON*, int> GetIcon;
        [NativeTypeName("HRESULT (int, IMAGEINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IMAGEINFO*, int> GetImageInfo;
        [NativeTypeName("HRESULT (int, IUnknown *, int, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IUnknown*, int, uint, int> Copy;
        [NativeTypeName("HRESULT (int, IUnknown *, int, int, int, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IUnknown*, int, int, int, Guid*, void**, int> Merge;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> Clone;
        [NativeTypeName("HRESULT (int, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, RECT*, int> GetImageRect;
        [NativeTypeName("HRESULT (int *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetIconSize;
        [NativeTypeName("HRESULT (int, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetIconSize;
        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetImageCount;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetImageCount;
        [NativeTypeName("HRESULT (COLORREF, COLORREF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF, COLORREF*, int> SetBkColor;
        [NativeTypeName("HRESULT (COLORREF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF*, int> GetBkColor;
        [NativeTypeName("HRESULT (int, int, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int> BeginDrag;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndDrag;
        [NativeTypeName("HRESULT (HWND, int, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int, int, int> DragEnter;
        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> DragLeave;
        [NativeTypeName("HRESULT (int, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> DragMove;
        [NativeTypeName("HRESULT (IUnknown *, int, int, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int, int, int, int> SetDragCursorImage;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> DragShowNolock;
        [NativeTypeName("HRESULT (POINT *, POINT *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, POINT*, Guid*, void**, int> GetDragImage;
        [NativeTypeName("HRESULT (int, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint*, int> GetItemFlags;
        [NativeTypeName("HRESULT (int, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetOverlayImage;
    }
}