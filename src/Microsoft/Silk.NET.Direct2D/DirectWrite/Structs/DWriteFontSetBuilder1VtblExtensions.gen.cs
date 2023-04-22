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

public unsafe static class DWriteFontSetBuilder1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontSetBuilder1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontSetBuilder1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFontFaceReference(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, IDWriteFontFaceReference* fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontFaceReference*, int>)@this->LpVtbl[4])(@this, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFaceReference(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, ref IDWriteFontFaceReference fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontFaceReference*, int>)@this->LpVtbl[4])(@this, fontFaceReferencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFontSet(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, IDWriteFontSet* fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontSet*, int>)@this->LpVtbl[5])(@this, fontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddFontSet(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, ref IDWriteFontSet fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet* fontSetPtr = &fontSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontSet*, int>)@this->LpVtbl[5])(@this, fontSetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontSet(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, IDWriteFontSet** fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontSet**, int>)@this->LpVtbl[6])(@this, fontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontSet(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, ref IDWriteFontSet* fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet** fontSetPtr = &fontSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontSet**, int>)@this->LpVtbl[6])(@this, fontSetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFontFile(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontFile*, int>)@this->LpVtbl[7])(@this, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFile(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, ref IDWriteFontFile fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile* fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontFile*, int>)@this->LpVtbl[7])(@this, fontFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFaceReference<TI0>(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFaceReference(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, Span<IDWriteFontFaceReference> fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFontFaceReference(ref fontFaceReference.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddFontSet<TI0>(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, ComPtr<TI0> fontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFontSet((IDWriteFontSet*) fontSet.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddFontSet(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, Span<IDWriteFontSet> fontSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFontSet(ref fontSet.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontSet<TI0>(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, ref ComPtr<TI0> fontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontSet((IDWriteFontSet**) fontSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFile<TI0>(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFontFile((IDWriteFontFile*) fontFile.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFile(this ComPtr<IDWriteFontSetBuilder1> thisVtbl, Span<IDWriteFontFile> fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFontFile(ref fontFile.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontSetBuilder1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
