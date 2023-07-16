// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPicture2.xml' path='doc/member[@name="IPicture2"]/*'/>
[Guid("F5185DD8-2012-4B0B-AAD9-F052C6BD482B")]
[NativeTypeName("struct IPicture2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPicture2 : IPicture2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPicture2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPicture2*, Guid*, void**, int> )(lpVtbl[0]))((IPicture2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPicture2*, uint> )(lpVtbl[1]))((IPicture2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPicture2*, uint> )(lpVtbl[2]))((IPicture2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.get_Handle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Handle(HHANDLE* pHandle)
    {
        return ((delegate* unmanaged<IPicture2*, HHANDLE*, int> )(lpVtbl[3]))((IPicture2*)Unsafe.AsPointer(ref this), pHandle);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.get_hPal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_hPal(HHANDLE* phPal)
    {
        return ((delegate* unmanaged<IPicture2*, HHANDLE*, int> )(lpVtbl[4]))((IPicture2*)Unsafe.AsPointer(ref this), phPal);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.get_Type"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Type(short* pType)
    {
        return ((delegate* unmanaged<IPicture2*, short*, int> )(lpVtbl[5]))((IPicture2*)Unsafe.AsPointer(ref this), pType);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.get_Width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth)
    {
        return ((delegate* unmanaged<IPicture2*, int*, int> )(lpVtbl[6]))((IPicture2*)Unsafe.AsPointer(ref this), pWidth);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.get_Height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight)
    {
        return ((delegate* unmanaged<IPicture2*, int*, int> )(lpVtbl[7]))((IPicture2*)Unsafe.AsPointer(ref this), pHeight);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.Render"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Render(HDC hDC, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("LONG")] int cx, [NativeTypeName("LONG")] int cy, [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc, [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc, [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc, [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc, [NativeTypeName("LPCRECT")] RECT* pRcWBounds)
    {
        return ((delegate* unmanaged<IPicture2*, HDC, int, int, int, int, int, int, int, int, RECT*, int> )(lpVtbl[8]))((IPicture2*)Unsafe.AsPointer(ref this), hDC, x, y, cx, cy, xSrc, ySrc, cxSrc, cySrc, pRcWBounds);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.set_hPal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT set_hPal(HHANDLE hPal)
    {
        return ((delegate* unmanaged<IPicture2*, HHANDLE, int> )(lpVtbl[9]))((IPicture2*)Unsafe.AsPointer(ref this), hPal);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.get_CurDC"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CurDC(HDC* phDC)
    {
        return ((delegate* unmanaged<IPicture2*, HDC*, int> )(lpVtbl[10]))((IPicture2*)Unsafe.AsPointer(ref this), phDC);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.SelectPicture"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SelectPicture(HDC hDCIn, HDC* phDCOut, HHANDLE* phBmpOut)
    {
        return ((delegate* unmanaged<IPicture2*, HDC, HDC*, HHANDLE*, int> )(lpVtbl[11]))((IPicture2*)Unsafe.AsPointer(ref this), hDCIn, phDCOut, phBmpOut);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.get_KeepOriginalFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_KeepOriginalFormat(BOOL* pKeep)
    {
        return ((delegate* unmanaged<IPicture2*, BOOL*, int> )(lpVtbl[12]))((IPicture2*)Unsafe.AsPointer(ref this), pKeep);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.put_KeepOriginalFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_KeepOriginalFormat(BOOL keep)
    {
        return ((delegate* unmanaged<IPicture2*, BOOL, int> )(lpVtbl[13]))((IPicture2*)Unsafe.AsPointer(ref this), keep);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.PictureChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT PictureChanged()
    {
        return ((delegate* unmanaged<IPicture2*, int> )(lpVtbl[14]))((IPicture2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.SaveAsFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SaveAsFile([NativeTypeName("LPSTREAM")] IStream* pStream, BOOL fSaveMemCopy, [NativeTypeName("LONG *")] int* pCbSize)
    {
        return ((delegate* unmanaged<IPicture2*, IStream*, BOOL, int*, int> )(lpVtbl[15]))((IPicture2*)Unsafe.AsPointer(ref this), pStream, fSaveMemCopy, pCbSize);
    }

    /// <include file='IPicture2.xml' path='doc/member[@name="IPicture2.get_Attributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Attributes([NativeTypeName("DWORD *")] uint* pDwAttr)
    {
        return ((delegate* unmanaged<IPicture2*, uint*, int> )(lpVtbl[16]))((IPicture2*)Unsafe.AsPointer(ref this), pDwAttr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Handle(HHANDLE* pHandle);
        [VtblIndex(4)]
        HRESULT get_hPal(HHANDLE* phPal);
        [VtblIndex(5)]
        HRESULT get_Type(short* pType);
        [VtblIndex(6)]
        HRESULT get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth);
        [VtblIndex(7)]
        HRESULT get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight);
        [VtblIndex(8)]
        HRESULT Render(HDC hDC, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("LONG")] int cx, [NativeTypeName("LONG")] int cy, [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc, [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc, [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc, [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc, [NativeTypeName("LPCRECT")] RECT* pRcWBounds);
        [VtblIndex(9)]
        HRESULT set_hPal(HHANDLE hPal);
        [VtblIndex(10)]
        HRESULT get_CurDC(HDC* phDC);
        [VtblIndex(11)]
        HRESULT SelectPicture(HDC hDCIn, HDC* phDCOut, HHANDLE* phBmpOut);
        [VtblIndex(12)]
        HRESULT get_KeepOriginalFormat(BOOL* pKeep);
        [VtblIndex(13)]
        HRESULT put_KeepOriginalFormat(BOOL keep);
        [VtblIndex(14)]
        HRESULT PictureChanged();
        [VtblIndex(15)]
        HRESULT SaveAsFile([NativeTypeName("LPSTREAM")] IStream* pStream, BOOL fSaveMemCopy, [NativeTypeName("LONG *")] int* pCbSize);
        [VtblIndex(16)]
        HRESULT get_Attributes([NativeTypeName("DWORD *")] uint* pDwAttr);
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
        [NativeTypeName("HRESULT (HHANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HHANDLE*, int> get_Handle;
        [NativeTypeName("HRESULT (HHANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HHANDLE*, int> get_hPal;
        [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_Type;
        [NativeTypeName("HRESULT (OLE_XSIZE_HIMETRIC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Width;
        [NativeTypeName("HRESULT (OLE_YSIZE_HIMETRIC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Height;
        [NativeTypeName("HRESULT (HDC, LONG, LONG, LONG, LONG, OLE_XPOS_HIMETRIC, OLE_YPOS_HIMETRIC, OLE_XSIZE_HIMETRIC, OLE_YSIZE_HIMETRIC, LPCRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, int, int, int, int, int, int, int, int, RECT*, int> Render;
        [NativeTypeName("HRESULT (HHANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HHANDLE, int> set_hPal;
        [NativeTypeName("HRESULT (HDC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC*, int> get_CurDC;
        [NativeTypeName("HRESULT (HDC, HDC *, HHANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, HDC*, HHANDLE*, int> SelectPicture;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_KeepOriginalFormat;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_KeepOriginalFormat;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PictureChanged;
        [NativeTypeName("HRESULT (LPSTREAM, BOOL, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, BOOL, int*, int> SaveAsFile;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Attributes;
    }
}