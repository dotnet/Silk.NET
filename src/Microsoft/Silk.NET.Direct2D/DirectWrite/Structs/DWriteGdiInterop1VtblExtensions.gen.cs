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

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteGdiInterop1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGdiInterop1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGdiInterop1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGdiInterop1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGdiInterop1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteGdiInterop1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteGdiInterop1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFromLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, IDWriteFont** font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFont**, int>)@this->LpVtbl[3])(@this, logFont, font);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFromLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, ref IDWriteFont* font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont** fontPtr = &font)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFont**, int>)@this->LpVtbl[3])(@this, logFont, fontPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFromLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, IDWriteFont** font) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* logFontPtr = &logFont)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFont**, int>)@this->LpVtbl[3])(@this, logFontPtr, font);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFromLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, ref IDWriteFont* font) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* logFontPtr = &logFont)
        {
            fixed (IDWriteFont** fontPtr = &font)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFont**, int>)@this->LpVtbl[3])(@this, logFontPtr, fontPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, void* logFont, int* isSystemFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, font, logFont, isSystemFont);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, void* logFont, ref int isSystemFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isSystemFontPtr = &isSystemFont)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, font, logFont, isSystemFontPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, ref T0 logFont, int* isSystemFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* logFontPtr = &logFont)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, font, logFontPtr, isSystemFont);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, ref T0 logFont, ref int isSystemFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* logFontPtr = &logFont)
        {
            fixed (int* isSystemFontPtr = &isSystemFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, font, logFontPtr, isSystemFontPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, ref IDWriteFont font, void* logFont, int* isSystemFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont* fontPtr = &font)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, fontPtr, logFont, isSystemFont);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, ref IDWriteFont font, void* logFont, ref int isSystemFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont* fontPtr = &font)
        {
            fixed (int* isSystemFontPtr = &isSystemFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, fontPtr, logFont, isSystemFontPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ref IDWriteFont font, ref T0 logFont, int* isSystemFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont* fontPtr = &font)
        {
            fixed (void* logFontPtr = &logFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, fontPtr, logFontPtr, isSystemFont);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ConvertFontToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ref IDWriteFont font, ref T0 logFont, ref int isSystemFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont* fontPtr = &font)
        {
            fixed (void* logFontPtr = &logFont)
            {
                fixed (int* isSystemFontPtr = &isSystemFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, fontPtr, logFontPtr, isSystemFontPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontFaceToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFontFace* font, void* logFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFontFace*, void*, int>)@this->LpVtbl[5])(@this, font, logFont);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontFaceToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFontFace* font, ref T0 logFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* logFontPtr = &logFont)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFontFace*, void*, int>)@this->LpVtbl[5])(@this, font, logFontPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontFaceToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, ref IDWriteFontFace font, void* logFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace* fontPtr = &font)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFontFace*, void*, int>)@this->LpVtbl[5])(@this, fontPtr, logFont);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ConvertFontFaceToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ref IDWriteFontFace font, ref T0 logFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace* fontPtr = &font)
        {
            fixed (void* logFontPtr = &logFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFontFace*, void*, int>)@this->LpVtbl[5])(@this, fontPtr, logFontPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceFromHdc(this ComPtr<IDWriteGdiInterop1> thisVtbl, nint hdc, IDWriteFontFace** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, nint, IDWriteFontFace**, int>)@this->LpVtbl[6])(@this, hdc, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceFromHdc(this ComPtr<IDWriteGdiInterop1> thisVtbl, nint hdc, ref IDWriteFontFace* fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace** fontFacePtr = &fontFace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, nint, IDWriteFontFace**, int>)@this->LpVtbl[6])(@this, hdc, fontFacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapRenderTarget(this ComPtr<IDWriteGdiInterop1> thisVtbl, nint hdc, uint width, uint height, IDWriteBitmapRenderTarget** renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, nint, uint, uint, IDWriteBitmapRenderTarget**, int>)@this->LpVtbl[7])(@this, hdc, width, height, renderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapRenderTarget(this ComPtr<IDWriteGdiInterop1> thisVtbl, nint hdc, uint width, uint height, ref IDWriteBitmapRenderTarget* renderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteBitmapRenderTarget** renderTargetPtr = &renderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, nint, uint, uint, IDWriteBitmapRenderTarget**, int>)@this->LpVtbl[7])(@this, hdc, width, height, renderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSignature(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, void* fontSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int>)@this->LpVtbl[10])(@this, font, fontSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSignature<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, ref T0 fontSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontSignaturePtr = &fontSignature)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int>)@this->LpVtbl[10])(@this, font, fontSignaturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSignature(this ComPtr<IDWriteGdiInterop1> thisVtbl, ref IDWriteFont font, void* fontSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont* fontPtr = &font)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int>)@this->LpVtbl[10])(@this, fontPtr, fontSignature);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFontSignature<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ref IDWriteFont font, ref T0 fontSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont* fontPtr = &font)
        {
            fixed (void* fontSignaturePtr = &fontSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, IDWriteFont*, void*, int>)@this->LpVtbl[10])(@this, fontPtr, fontSignaturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFontSet*, IDWriteFontSet**, int>)@this->LpVtbl[11])(@this, logFont, fontSet, filteredSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, IDWriteFontSet* fontSet, ref IDWriteFontSet* filteredSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet** filteredSetPtr = &filteredSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFontSet*, IDWriteFontSet**, int>)@this->LpVtbl[11])(@this, logFont, fontSet, filteredSetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, ref IDWriteFontSet fontSet, IDWriteFontSet** filteredSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet* fontSetPtr = &fontSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFontSet*, IDWriteFontSet**, int>)@this->LpVtbl[11])(@this, logFont, fontSetPtr, filteredSet);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, ref IDWriteFontSet fontSet, ref IDWriteFontSet* filteredSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet* fontSetPtr = &fontSet)
        {
            fixed (IDWriteFontSet** filteredSetPtr = &filteredSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFontSet*, IDWriteFontSet**, int>)@this->LpVtbl[11])(@this, logFont, fontSetPtr, filteredSetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* logFontPtr = &logFont)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFontSet*, IDWriteFontSet**, int>)@this->LpVtbl[11])(@this, logFontPtr, fontSet, filteredSet);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, IDWriteFontSet* fontSet, ref IDWriteFontSet* filteredSet) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* logFontPtr = &logFont)
        {
            fixed (IDWriteFontSet** filteredSetPtr = &filteredSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFontSet*, IDWriteFontSet**, int>)@this->LpVtbl[11])(@this, logFontPtr, fontSet, filteredSetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, ref IDWriteFontSet fontSet, IDWriteFontSet** filteredSet) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* logFontPtr = &logFont)
        {
            fixed (IDWriteFontSet* fontSetPtr = &fontSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFontSet*, IDWriteFontSet**, int>)@this->LpVtbl[11])(@this, logFontPtr, fontSetPtr, filteredSet);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, ref IDWriteFontSet fontSet, ref IDWriteFontSet* filteredSet) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* logFontPtr = &logFont)
        {
            fixed (IDWriteFontSet* fontSetPtr = &fontSet)
            {
                fixed (IDWriteFontSet** filteredSetPtr = &filteredSet)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop1*, void*, IDWriteFontSet*, IDWriteFontSet**, int>)@this->LpVtbl[11])(@this, logFontPtr, fontSetPtr, filteredSetPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGdiInterop1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteGdiInterop1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFromLOGFONT<TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, ref ComPtr<TI0> font) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFromLOGFONT(logFont, (IDWriteFont**) font.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFromLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> logFont, IDWriteFont** font) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFromLOGFONT(in logFont.GetPinnableReference(), font);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFromLOGFONT<T0, TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, ref ComPtr<TI0> font) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFromLOGFONT(in logFont, (IDWriteFont**) font.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFromLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> logFont, ref IDWriteFont* font) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFromLOGFONT(in logFont.GetPinnableReference(), ref font);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT<TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ComPtr<TI0> font, void* logFont, int* isSystemFont) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ConvertFontToLOGFONT((IDWriteFont*) font.Handle, logFont, isSystemFont);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, void* logFont, Span<int> isSystemFont)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConvertFontToLOGFONT(font, logFont, ref isSystemFont.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT<TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ComPtr<TI0> font, void* logFont, ref int isSystemFont) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ConvertFontToLOGFONT((IDWriteFont*) font.Handle, logFont, ref isSystemFont);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, Span<T0> logFont, int* isSystemFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConvertFontToLOGFONT(font, ref logFont.GetPinnableReference(), isSystemFont);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT<T0, TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ComPtr<TI0> font, ref T0 logFont, int* isSystemFont) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ConvertFontToLOGFONT((IDWriteFont*) font.Handle, ref logFont, isSystemFont);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, Span<T0> logFont, Span<int> isSystemFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConvertFontToLOGFONT(font, ref logFont.GetPinnableReference(), ref isSystemFont.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ConvertFontToLOGFONT<T0, TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ComPtr<TI0> font, ref T0 logFont, ref int isSystemFont) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ConvertFontToLOGFONT((IDWriteFont*) font.Handle, ref logFont, ref isSystemFont);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, Span<IDWriteFont> font, void* logFont, int* isSystemFont)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConvertFontToLOGFONT(ref font.GetPinnableReference(), logFont, isSystemFont);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, Span<IDWriteFont> font, void* logFont, Span<int> isSystemFont)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConvertFontToLOGFONT(ref font.GetPinnableReference(), logFont, ref isSystemFont.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, Span<IDWriteFont> font, Span<T0> logFont, int* isSystemFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConvertFontToLOGFONT(ref font.GetPinnableReference(), ref logFont.GetPinnableReference(), isSystemFont);
    }

    /// <summary>To be documented.</summary>
    public static int ConvertFontToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, Span<IDWriteFont> font, Span<T0> logFont, Span<int> isSystemFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConvertFontToLOGFONT(ref font.GetPinnableReference(), ref logFont.GetPinnableReference(), ref isSystemFont.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontFaceToLOGFONT<TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ComPtr<TI0> font, void* logFont) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ConvertFontFaceToLOGFONT((IDWriteFontFace*) font.Handle, logFont);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontFaceToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFontFace* font, Span<T0> logFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConvertFontFaceToLOGFONT(font, ref logFont.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ConvertFontFaceToLOGFONT<T0, TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ComPtr<TI0> font, ref T0 logFont) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ConvertFontFaceToLOGFONT((IDWriteFontFace*) font.Handle, ref logFont);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ConvertFontFaceToLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, Span<IDWriteFontFace> font, void* logFont)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConvertFontFaceToLOGFONT(ref font.GetPinnableReference(), logFont);
    }

    /// <summary>To be documented.</summary>
    public static int ConvertFontFaceToLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, Span<IDWriteFontFace> font, Span<T0> logFont) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ConvertFontFaceToLOGFONT(ref font.GetPinnableReference(), ref logFont.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFaceFromHdc<TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, nint hdc, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFaceFromHdc(hdc, (IDWriteFontFace**) fontFace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateBitmapRenderTarget<TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, nint hdc, uint width, uint height, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<IDWriteBitmapRenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateBitmapRenderTarget(hdc, width, height, (IDWriteBitmapRenderTarget**) renderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSignature<TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ComPtr<TI0> font, void* fontSignature) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontSignature((IDWriteFont*) font.Handle, fontSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSignature<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, IDWriteFont* font, Span<T0> fontSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontSignature(font, ref fontSignature.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFontSignature<T0, TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, ComPtr<TI0> font, ref T0 fontSignature) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontSignature((IDWriteFont*) font.Handle, ref fontSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSignature(this ComPtr<IDWriteGdiInterop1> thisVtbl, Span<IDWriteFont> font, void* fontSignature)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontSignature(ref font.GetPinnableReference(), fontSignature);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontSignature<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, Span<IDWriteFont> font, Span<T0> fontSignature) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontSignature(ref font.GetPinnableReference(), ref fontSignature.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<TI0, TI1>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, ComPtr<TI0> fontSet, ref ComPtr<TI1> filteredSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFontsByLOGFONT(logFont, (IDWriteFontSet*) fontSet.Handle, (IDWriteFontSet**) filteredSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, ComPtr<TI0> fontSet, ref IDWriteFontSet* filteredSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFontsByLOGFONT(logFont, (IDWriteFontSet*) fontSet.Handle, ref filteredSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, Span<IDWriteFontSet> fontSet, IDWriteFontSet** filteredSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFontsByLOGFONT(logFont, ref fontSet.GetPinnableReference(), filteredSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, ref IDWriteFontSet fontSet, ref ComPtr<TI0> filteredSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFontsByLOGFONT(logFont, ref fontSet, (IDWriteFontSet**) filteredSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, Span<IDWriteFontSet> fontSet, ref IDWriteFontSet* filteredSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFontsByLOGFONT(logFont, ref fontSet.GetPinnableReference(), ref filteredSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFontsByLOGFONT(in logFont.GetPinnableReference(), fontSet, filteredSet);
    }

    /// <summary>To be documented.</summary>
    public static int GetMatchingFontsByLOGFONT<T0, TI0, TI1>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, ComPtr<TI0> fontSet, ref ComPtr<TI1> filteredSet) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFontsByLOGFONT(in logFont, (IDWriteFontSet*) fontSet.Handle, (IDWriteFontSet**) filteredSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> logFont, IDWriteFontSet* fontSet, ref IDWriteFontSet* filteredSet) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFontsByLOGFONT(in logFont.GetPinnableReference(), fontSet, ref filteredSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<T0, TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, ComPtr<TI0> fontSet, ref IDWriteFontSet* filteredSet) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFontsByLOGFONT(in logFont, (IDWriteFontSet*) fontSet.Handle, ref filteredSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> logFont, Span<IDWriteFontSet> fontSet, IDWriteFontSet** filteredSet) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFontsByLOGFONT(in logFont.GetPinnableReference(), ref fontSet.GetPinnableReference(), filteredSet);
    }

    /// <summary>To be documented.</summary>
    public static int GetMatchingFontsByLOGFONT<T0, TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, ref IDWriteFontSet fontSet, ref ComPtr<TI0> filteredSet) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFontsByLOGFONT(in logFont, ref fontSet, (IDWriteFontSet**) filteredSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFontsByLOGFONT<T0>(this ComPtr<IDWriteGdiInterop1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> logFont, Span<IDWriteFontSet> fontSet, ref IDWriteFontSet* filteredSet) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFontsByLOGFONT(in logFont.GetPinnableReference(), ref fontSet.GetPinnableReference(), ref filteredSet);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteGdiInterop1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
