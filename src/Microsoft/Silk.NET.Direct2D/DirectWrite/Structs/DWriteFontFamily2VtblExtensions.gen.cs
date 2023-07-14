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

public unsafe static class DWriteFontFamily2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFamily2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFamily2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontCollection(this ComPtr<IDWriteFontFamily2> thisVtbl, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, IDWriteFontCollection**, int>)@this->LpVtbl[3])(@this, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontCollection(this ComPtr<IDWriteFontFamily2> thisVtbl, ref IDWriteFontCollection* fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, IDWriteFontCollection**, int>)@this->LpVtbl[3])(@this, fontCollectionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontCount(this ComPtr<IDWriteFontFamily2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFont(this ComPtr<IDWriteFontFamily2> thisVtbl, uint index, IDWriteFont** font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, uint, IDWriteFont**, int>)@this->LpVtbl[5])(@this, index, font);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFont(this ComPtr<IDWriteFontFamily2> thisVtbl, uint index, ref IDWriteFont* font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont** fontPtr = &font)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, uint, IDWriteFont**, int>)@this->LpVtbl[5])(@this, index, fontPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFamilyNames(this ComPtr<IDWriteFontFamily2> thisVtbl, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[6])(@this, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFamilyNames(this ComPtr<IDWriteFontFamily2> thisVtbl, ref IDWriteLocalizedStrings* names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** namesPtr = &names)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[6])(@this, namesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFirstMatchingFont(this ComPtr<IDWriteFontFamily2> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, IDWriteFont** matchingFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, FontWeight, FontStretch, FontStyle, IDWriteFont**, int>)@this->LpVtbl[7])(@this, weight, stretch, style, matchingFont);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFirstMatchingFont(this ComPtr<IDWriteFontFamily2> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, ref IDWriteFont* matchingFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont** matchingFontPtr = &matchingFont)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, FontWeight, FontStretch, FontStyle, IDWriteFont**, int>)@this->LpVtbl[7])(@this, weight, stretch, style, matchingFontPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontFamily2> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, IDWriteFontList** matchingFonts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, FontWeight, FontStretch, FontStyle, IDWriteFontList**, int>)@this->LpVtbl[8])(@this, weight, stretch, style, matchingFonts);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontFamily2> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, ref IDWriteFontList* matchingFonts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontList** matchingFontsPtr = &matchingFonts)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, FontWeight, FontStretch, FontStyle, IDWriteFontList**, int>)@this->LpVtbl[8])(@this, weight, stretch, style, matchingFontsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Locality GetFontLocality(this ComPtr<IDWriteFontFamily2> thisVtbl, uint listIndex)
    {
        var @this = thisVtbl.Handle;
        Locality ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, uint, Locality>)@this->LpVtbl[9])(@this, listIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFaceReference(this ComPtr<IDWriteFontFamily2> thisVtbl, uint listIndex, IDWriteFontFaceReference** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[11])(@this, listIndex, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFaceReference(this ComPtr<IDWriteFontFamily2> thisVtbl, uint listIndex, ref IDWriteFontFaceReference* fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[11])(@this, listIndex, fontFaceReferencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSet(this ComPtr<IDWriteFontFamily2> thisVtbl, IDWriteFontSet1** fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, IDWriteFontSet1**, int>)@this->LpVtbl[13])(@this, fontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSet(this ComPtr<IDWriteFontFamily2> thisVtbl, ref IDWriteFontSet1* fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet1** fontSetPtr = &fontSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily2*, IDWriteFontSet1**, int>)@this->LpVtbl[13])(@this, fontSetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontFamily2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontCollection<TI0>(this ComPtr<IDWriteFontFamily2> thisVtbl, ref ComPtr<TI0> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontCollection((IDWriteFontCollection**) fontCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFont<TI0>(this ComPtr<IDWriteFontFamily2> thisVtbl, uint index, ref ComPtr<TI0> font) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFont(index, (IDWriteFont**) font.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFamilyNames<TI0>(this ComPtr<IDWriteFontFamily2> thisVtbl, ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFamilyNames((IDWriteLocalizedStrings**) names.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFirstMatchingFont<TI0>(this ComPtr<IDWriteFontFamily2> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, ref ComPtr<TI0> matchingFont) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFirstMatchingFont(weight, stretch, style, (IDWriteFont**) matchingFont.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetMatchingFonts<TI0>(this ComPtr<IDWriteFontFamily2> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, ref ComPtr<TI0> matchingFonts) where TI0 : unmanaged, IComVtbl<IDWriteFontList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFonts(weight, stretch, style, (IDWriteFontList**) matchingFonts.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFaceReference<TI0>(this ComPtr<IDWriteFontFamily2> thisVtbl, uint listIndex, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontFaceReference(listIndex, (IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFontSet<TI0>(this ComPtr<IDWriteFontFamily2> thisVtbl, ref ComPtr<TI0> fontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontSet((IDWriteFontSet1**) fontSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontFamily2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
