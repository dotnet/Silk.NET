// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICPaletteVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPalette> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPalette> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPalette> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPalette> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICPalette> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICPalette> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializePredefined(this ComPtr<IWICPalette> thisVtbl, BitmapPaletteType ePaletteType, Silk.NET.Core.Bool32 fAddTransparentColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, BitmapPaletteType, Silk.NET.Core.Bool32, int>)@this->LpVtbl[3])(@this, ePaletteType, fAddTransparentColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InitializeCustom(this ComPtr<IWICPalette> thisVtbl, uint* pColors, uint cCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, uint, int>)@this->LpVtbl[4])(@this, pColors, cCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeCustom(this ComPtr<IWICPalette> thisVtbl, ref uint pColors, uint cCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pColorsPtr = &pColors)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, uint, int>)@this->LpVtbl[4])(@this, pColorsPtr, cCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InitializeFromBitmap(this ComPtr<IWICPalette> thisVtbl, IWICBitmapSource* pISurface, uint cCount, Silk.NET.Core.Bool32 fAddTransparentColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICBitmapSource*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[5])(@this, pISurface, cCount, fAddTransparentColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromBitmap(this ComPtr<IWICPalette> thisVtbl, ref IWICBitmapSource pISurface, uint cCount, Silk.NET.Core.Bool32 fAddTransparentColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource* pISurfacePtr = &pISurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICBitmapSource*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[5])(@this, pISurfacePtr, cCount, fAddTransparentColor);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InitializeFromPalette(this ComPtr<IWICPalette> thisVtbl, IWICPalette* pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromPalette(this ComPtr<IWICPalette> thisVtbl, ref IWICPalette pIPalette)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICPalette* pIPalettePtr = &pIPalette)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetType(this ComPtr<IWICPalette> thisVtbl, BitmapPaletteType* pePaletteType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, BitmapPaletteType*, int>)@this->LpVtbl[7])(@this, pePaletteType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetType(this ComPtr<IWICPalette> thisVtbl, ref BitmapPaletteType pePaletteType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapPaletteType* pePaletteTypePtr = &pePaletteType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, BitmapPaletteType*, int>)@this->LpVtbl[7])(@this, pePaletteTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorCount(this ComPtr<IWICPalette> thisVtbl, uint* pcCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, int>)@this->LpVtbl[8])(@this, pcCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetColorCount(this ComPtr<IWICPalette> thisVtbl, ref uint pcCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcCountPtr = &pcCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, int>)@this->LpVtbl[8])(@this, pcCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColors(this ComPtr<IWICPalette> thisVtbl, uint cCount, uint* pColors, uint* pcActualColors)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint, uint*, uint*, int>)@this->LpVtbl[9])(@this, cCount, pColors, pcActualColors);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColors(this ComPtr<IWICPalette> thisVtbl, uint cCount, uint* pColors, ref uint pcActualColors)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcActualColorsPtr = &pcActualColors)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint, uint*, uint*, int>)@this->LpVtbl[9])(@this, cCount, pColors, pcActualColorsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColors(this ComPtr<IWICPalette> thisVtbl, uint cCount, ref uint pColors, uint* pcActualColors)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pColorsPtr = &pColors)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint, uint*, uint*, int>)@this->LpVtbl[9])(@this, cCount, pColorsPtr, pcActualColors);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetColors(this ComPtr<IWICPalette> thisVtbl, uint cCount, ref uint pColors, ref uint pcActualColors)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pColorsPtr = &pColors)
        {
            fixed (uint* pcActualColorsPtr = &pcActualColors)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint, uint*, uint*, int>)@this->LpVtbl[9])(@this, cCount, pColorsPtr, pcActualColorsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsBlackWhite(this ComPtr<IWICPalette> thisVtbl, int* pfIsBlackWhite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[10])(@this, pfIsBlackWhite);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsBlackWhite(this ComPtr<IWICPalette> thisVtbl, ref int pfIsBlackWhite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfIsBlackWhitePtr = &pfIsBlackWhite)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[10])(@this, pfIsBlackWhitePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsGrayscale(this ComPtr<IWICPalette> thisVtbl, int* pfIsGrayscale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[11])(@this, pfIsGrayscale);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsGrayscale(this ComPtr<IWICPalette> thisVtbl, ref int pfIsGrayscale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfIsGrayscalePtr = &pfIsGrayscale)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[11])(@this, pfIsGrayscalePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HasAlpha(this ComPtr<IWICPalette> thisVtbl, int* pfHasAlpha)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[12])(@this, pfHasAlpha);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int HasAlpha(this ComPtr<IWICPalette> thisVtbl, ref int pfHasAlpha)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfHasAlphaPtr = &pfHasAlpha)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[12])(@this, pfHasAlphaPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICPalette> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPalette> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPalette> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int InitializeCustom(this ComPtr<IWICPalette> thisVtbl, Span<uint> pColors, uint cCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InitializeCustom(ref pColors.GetPinnableReference(), cCount);
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromBitmap<TI0>(this ComPtr<IWICPalette> thisVtbl, ComPtr<TI0> pISurface, uint cCount, Silk.NET.Core.Bool32 fAddTransparentColor) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InitializeFromBitmap((IWICBitmapSource*) pISurface.Handle, cCount, fAddTransparentColor);
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromBitmap(this ComPtr<IWICPalette> thisVtbl, Span<IWICBitmapSource> pISurface, uint cCount, Silk.NET.Core.Bool32 fAddTransparentColor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InitializeFromBitmap(ref pISurface.GetPinnableReference(), cCount, fAddTransparentColor);
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromPalette<TI0>(this ComPtr<IWICPalette> thisVtbl, ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InitializeFromPalette((IWICPalette*) pIPalette.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromPalette(this ComPtr<IWICPalette> thisVtbl, Span<IWICPalette> pIPalette)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InitializeFromPalette(ref pIPalette.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetType(this ComPtr<IWICPalette> thisVtbl, Span<BitmapPaletteType> pePaletteType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetType(ref pePaletteType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetColorCount(this ComPtr<IWICPalette> thisVtbl, Span<uint> pcCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColorCount(ref pcCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColors(this ComPtr<IWICPalette> thisVtbl, uint cCount, uint* pColors, Span<uint> pcActualColors)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColors(cCount, pColors, ref pcActualColors.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColors(this ComPtr<IWICPalette> thisVtbl, uint cCount, Span<uint> pColors, uint* pcActualColors)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColors(cCount, ref pColors.GetPinnableReference(), pcActualColors);
    }

    /// <summary>To be documented.</summary>
    public static int GetColors(this ComPtr<IWICPalette> thisVtbl, uint cCount, Span<uint> pColors, Span<uint> pcActualColors)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColors(cCount, ref pColors.GetPinnableReference(), ref pcActualColors.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsBlackWhite(this ComPtr<IWICPalette> thisVtbl, Span<int> pfIsBlackWhite)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsBlackWhite(ref pfIsBlackWhite.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsGrayscale(this ComPtr<IWICPalette> thisVtbl, Span<int> pfIsGrayscale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsGrayscale(ref pfIsGrayscale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int HasAlpha(this ComPtr<IWICPalette> thisVtbl, Span<int> pfHasAlpha)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HasAlpha(ref pfHasAlpha.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICPalette> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
