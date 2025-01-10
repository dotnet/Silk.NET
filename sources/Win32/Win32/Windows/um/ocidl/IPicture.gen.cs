// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7BF80980-BF32-101A-8BBB-00AA00300CAB")]
[NativeTypeName("struct IPicture : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPicture : IPicture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPicture));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPicture, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPicture, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPicture, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_Handle([NativeTypeName("OLE_HANDLE *")] uint* pHandle)
    {
        return ((delegate* unmanaged<IPicture, uint*, int>)((*lpVtbl)[3]))(this, pHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_hPal([NativeTypeName("OLE_HANDLE *")] uint* phPal)
    {
        return ((delegate* unmanaged<IPicture, uint*, int>)((*lpVtbl)[4]))(this, phPal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Type(short* pType)
    {
        return ((delegate* unmanaged<IPicture, short*, int>)((*lpVtbl)[5]))(this, pType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth)
    {
        return ((delegate* unmanaged<IPicture, int*, int>)((*lpVtbl)[6]))(this, pWidth);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight)
    {
        return ((delegate* unmanaged<IPicture, int*, int>)((*lpVtbl)[7]))(this, pHeight);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Render(
        HDC hDC,
        [NativeTypeName("LONG")] int x,
        [NativeTypeName("LONG")] int y,
        [NativeTypeName("LONG")] int cx,
        [NativeTypeName("LONG")] int cy,
        [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc,
        [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc,
        [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc,
        [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc,
        [NativeTypeName("LPCRECT")] RECT* pRcWBounds
    )
    {
        return (
            (delegate* unmanaged<
                IPicture,
                HDC,
                int,
                int,
                int,
                int,
                int,
                int,
                int,
                int,
                RECT*,
                int>)((*lpVtbl)[8])
        )(this, hDC, x, y, cx, cy, xSrc, ySrc, cxSrc, cySrc, pRcWBounds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT set_hPal([NativeTypeName("OLE_HANDLE")] uint hPal)
    {
        return ((delegate* unmanaged<IPicture, uint, int>)((*lpVtbl)[9]))(this, hPal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CurDC(HDC* phDC)
    {
        return ((delegate* unmanaged<IPicture, HDC*, int>)((*lpVtbl)[10]))(this, phDC);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SelectPicture(
        HDC hDCIn,
        HDC* phDCOut,
        [NativeTypeName("OLE_HANDLE *")] uint* phBmpOut
    )
    {
        return ((delegate* unmanaged<IPicture, HDC, HDC*, uint*, int>)((*lpVtbl)[11]))(
            this,
            hDCIn,
            phDCOut,
            phBmpOut
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_KeepOriginalFormat(BOOL* pKeep)
    {
        return ((delegate* unmanaged<IPicture, BOOL*, int>)((*lpVtbl)[12]))(this, pKeep);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_KeepOriginalFormat(BOOL keep)
    {
        return ((delegate* unmanaged<IPicture, BOOL, int>)((*lpVtbl)[13]))(this, keep);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT PictureChanged()
    {
        return ((delegate* unmanaged<IPicture, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SaveAsFile(
        [NativeTypeName("LPSTREAM")] IStream pStream,
        BOOL fSaveMemCopy,
        [NativeTypeName("LONG *")] int* pCbSize
    )
    {
        return ((delegate* unmanaged<IPicture, IStream, BOOL, int*, int>)((*lpVtbl)[15]))(
            this,
            pStream,
            fSaveMemCopy,
            pCbSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Attributes([NativeTypeName("DWORD *")] uint* pDwAttr)
    {
        return ((delegate* unmanaged<IPicture, uint*, int>)((*lpVtbl)[16]))(this, pDwAttr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_Handle([NativeTypeName("OLE_HANDLE *")] uint* pHandle);

        [VtblIndex(4)]
        HRESULT get_hPal([NativeTypeName("OLE_HANDLE *")] uint* phPal);

        [VtblIndex(5)]
        HRESULT get_Type(short* pType);

        [VtblIndex(6)]
        HRESULT get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth);

        [VtblIndex(7)]
        HRESULT get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight);

        [VtblIndex(8)]
        HRESULT Render(
            HDC hDC,
            [NativeTypeName("LONG")] int x,
            [NativeTypeName("LONG")] int y,
            [NativeTypeName("LONG")] int cx,
            [NativeTypeName("LONG")] int cy,
            [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc,
            [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc,
            [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc,
            [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc,
            [NativeTypeName("LPCRECT")] RECT* pRcWBounds
        );

        [VtblIndex(9)]
        HRESULT set_hPal([NativeTypeName("OLE_HANDLE")] uint hPal);

        [VtblIndex(10)]
        HRESULT get_CurDC(HDC* phDC);

        [VtblIndex(11)]
        HRESULT SelectPicture(
            HDC hDCIn,
            HDC* phDCOut,
            [NativeTypeName("OLE_HANDLE *")] uint* phBmpOut
        );

        [VtblIndex(12)]
        HRESULT get_KeepOriginalFormat(BOOL* pKeep);

        [VtblIndex(13)]
        HRESULT put_KeepOriginalFormat(BOOL keep);

        [VtblIndex(14)]
        HRESULT PictureChanged();

        [VtblIndex(15)]
        HRESULT SaveAsFile(
            [NativeTypeName("LPSTREAM")] IStream pStream,
            BOOL fSaveMemCopy,
            [NativeTypeName("LONG *")] int* pCbSize
        );

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

        [NativeTypeName("HRESULT (OLE_HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Handle;

        [NativeTypeName("HRESULT (OLE_HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_hPal;

        [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_Type;

        [NativeTypeName("HRESULT (OLE_XSIZE_HIMETRIC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Width;

        [NativeTypeName("HRESULT (OLE_YSIZE_HIMETRIC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Height;

        [NativeTypeName(
            "HRESULT (HDC, LONG, LONG, LONG, LONG, OLE_XPOS_HIMETRIC, OLE_YPOS_HIMETRIC, OLE_XSIZE_HIMETRIC, OLE_YSIZE_HIMETRIC, LPCRECT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HDC,
            int,
            int,
            int,
            int,
            int,
            int,
            int,
            int,
            RECT*,
            int> Render;

        [NativeTypeName("HRESULT (OLE_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> set_hPal;

        [NativeTypeName("HRESULT (HDC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC*, int> get_CurDC;

        [NativeTypeName("HRESULT (HDC, HDC *, OLE_HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, HDC*, uint*, int> SelectPicture;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_KeepOriginalFormat;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_KeepOriginalFormat;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PictureChanged;

        [NativeTypeName("HRESULT (LPSTREAM, BOOL, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, BOOL, int*, int> SaveAsFile;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Attributes;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPicture"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPicture(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPicture"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPicture(Silk.NET.Windows.IUnknown value)
    {
        return new IPicture(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPicture"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPicture"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPicture value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
