// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000040-A8F2-4877-BA0A-FD2B6645FB94")]
[NativeTypeName("struct IWICPalette : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICPalette : IWICPalette.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPalette));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICPalette, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICPalette, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICPalette, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializePredefined(
        WICBitmapPaletteType ePaletteType,
        BOOL fAddTransparentColor
    )
    {
        return ((delegate* unmanaged<IWICPalette, WICBitmapPaletteType, BOOL, int>)((*lpVtbl)[3]))(
            this,
            ePaletteType,
            fAddTransparentColor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitializeCustom([NativeTypeName("WICColor *")] uint* pColors, uint cCount)
    {
        return ((delegate* unmanaged<IWICPalette, uint*, uint, int>)((*lpVtbl)[4]))(
            this,
            pColors,
            cCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InitializeFromBitmap(
        IWICBitmapSource pISurface,
        uint cCount,
        BOOL fAddTransparentColor
    )
    {
        return (
            (delegate* unmanaged<IWICPalette, IWICBitmapSource, uint, BOOL, int>)((*lpVtbl)[5])
        )(this, pISurface, cCount, fAddTransparentColor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InitializeFromPalette(IWICPalette pIPalette)
    {
        return ((delegate* unmanaged<IWICPalette, IWICPalette, int>)((*lpVtbl)[6]))(
            this,
            pIPalette
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetType(WICBitmapPaletteType* pePaletteType)
    {
        return ((delegate* unmanaged<IWICPalette, WICBitmapPaletteType*, int>)((*lpVtbl)[7]))(
            this,
            pePaletteType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetColorCount(uint* pcCount)
    {
        return ((delegate* unmanaged<IWICPalette, uint*, int>)((*lpVtbl)[8]))(this, pcCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetColors(
        uint cCount,
        [NativeTypeName("WICColor *")] uint* pColors,
        uint* pcActualColors
    )
    {
        return ((delegate* unmanaged<IWICPalette, uint, uint*, uint*, int>)((*lpVtbl)[9]))(
            this,
            cCount,
            pColors,
            pcActualColors
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsBlackWhite(BOOL* pfIsBlackWhite)
    {
        return ((delegate* unmanaged<IWICPalette, BOOL*, int>)((*lpVtbl)[10]))(
            this,
            pfIsBlackWhite
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsGrayscale(BOOL* pfIsGrayscale)
    {
        return ((delegate* unmanaged<IWICPalette, BOOL*, int>)((*lpVtbl)[11]))(this, pfIsGrayscale);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT HasAlpha(BOOL* pfHasAlpha)
    {
        return ((delegate* unmanaged<IWICPalette, BOOL*, int>)((*lpVtbl)[12]))(this, pfHasAlpha);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializePredefined(WICBitmapPaletteType ePaletteType, BOOL fAddTransparentColor);

        [VtblIndex(4)]
        HRESULT InitializeCustom([NativeTypeName("WICColor *")] uint* pColors, uint cCount);

        [VtblIndex(5)]
        HRESULT InitializeFromBitmap(
            IWICBitmapSource pISurface,
            uint cCount,
            BOOL fAddTransparentColor
        );

        [VtblIndex(6)]
        HRESULT InitializeFromPalette(IWICPalette pIPalette);

        [VtblIndex(7)]
        HRESULT GetType(WICBitmapPaletteType* pePaletteType);

        [VtblIndex(8)]
        HRESULT GetColorCount(uint* pcCount);

        [VtblIndex(9)]
        HRESULT GetColors(
            uint cCount,
            [NativeTypeName("WICColor *")] uint* pColors,
            uint* pcActualColors
        );

        [VtblIndex(10)]
        HRESULT IsBlackWhite(BOOL* pfIsBlackWhite);

        [VtblIndex(11)]
        HRESULT IsGrayscale(BOOL* pfIsGrayscale);

        [VtblIndex(12)]
        HRESULT HasAlpha(BOOL* pfHasAlpha);
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

        [NativeTypeName("HRESULT (WICBitmapPaletteType, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICBitmapPaletteType, BOOL, int> InitializePredefined;

        [NativeTypeName("HRESULT (WICColor *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint, int> InitializeCustom;

        [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource, uint, BOOL, int> InitializeFromBitmap;

        [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICPalette, int> InitializeFromPalette;

        [NativeTypeName("HRESULT (WICBitmapPaletteType *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, WICBitmapPaletteType*, int> GetType;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetColorCount;

        [NativeTypeName("HRESULT (UINT, WICColor *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, int> GetColors;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsBlackWhite;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsGrayscale;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> HasAlpha;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICPalette"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICPalette(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICPalette"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICPalette(Silk.NET.Windows.IUnknown value)
    {
        return new IWICPalette(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICPalette"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICPalette"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICPalette value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
