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

public unsafe static class DWriteFontFileVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFile> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFile> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFile> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFile> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFile> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFile> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReferenceKey(this ComPtr<IDWriteFontFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fontFileReferenceKey, uint* fontFileReferenceKeySize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, void**, uint*, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReferenceKey(this ComPtr<IDWriteFontFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fontFileReferenceKey, ref uint fontFileReferenceKeySize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* fontFileReferenceKeySizePtr = &fontFileReferenceKeySize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, void**, uint*, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReferenceKey(this ComPtr<IDWriteFontFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* fontFileReferenceKey, uint* fontFileReferenceKeySize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, void**, uint*, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReferenceKey(this ComPtr<IDWriteFontFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* fontFileReferenceKey, ref uint fontFileReferenceKeySize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            fixed (uint* fontFileReferenceKeySizePtr = &fontFileReferenceKeySize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, void**, uint*, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLoader(this ComPtr<IDWriteFontFile> thisVtbl, IDWriteFontFileLoader** fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, IDWriteFontFileLoader**, int>)@this->LpVtbl[4])(@this, fontFileLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLoader(this ComPtr<IDWriteFontFile> thisVtbl, ref IDWriteFontFileLoader* fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFileLoader** fontFileLoaderPtr = &fontFileLoader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, IDWriteFontFileLoader**, int>)@this->LpVtbl[4])(@this, fontFileLoaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileType, fontFaceType, numberOfFaces);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, ref uint numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* numberOfFacesPtr = &numberOfFaces)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileType, fontFaceType, numberOfFacesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, FontFileType* fontFileType, ref FontFaceType fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileType, fontFaceTypePtr, numberOfFaces);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, FontFileType* fontFileType, ref FontFaceType fontFaceType, ref uint numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
        {
            fixed (uint* numberOfFacesPtr = &numberOfFaces)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileType, fontFaceTypePtr, numberOfFacesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, ref FontFileType fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontFileType* fontFileTypePtr = &fontFileType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileTypePtr, fontFaceType, numberOfFaces);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, ref FontFileType fontFileType, FontFaceType* fontFaceType, ref uint numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontFileType* fontFileTypePtr = &fontFileType)
        {
            fixed (uint* numberOfFacesPtr = &numberOfFaces)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileTypePtr, fontFaceType, numberOfFacesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, ref FontFileType fontFileType, ref FontFaceType fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontFileType* fontFileTypePtr = &fontFileType)
        {
            fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileTypePtr, fontFaceTypePtr, numberOfFaces);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, ref FontFileType fontFileType, ref FontFaceType fontFaceType, ref uint numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontFileType* fontFileTypePtr = &fontFileType)
        {
            fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
            {
                fixed (uint* numberOfFacesPtr = &numberOfFaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileTypePtr, fontFaceTypePtr, numberOfFacesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, ref int isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileType, fontFaceType, numberOfFaces);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, ref int isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, ref uint numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
        {
            fixed (uint* numberOfFacesPtr = &numberOfFaces)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileType, fontFaceType, numberOfFacesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, ref int isSupportedFontType, FontFileType* fontFileType, ref FontFaceType fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
        {
            fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileType, fontFaceTypePtr, numberOfFaces);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, ref int isSupportedFontType, FontFileType* fontFileType, ref FontFaceType fontFaceType, ref uint numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
        {
            fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
            {
                fixed (uint* numberOfFacesPtr = &numberOfFaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileType, fontFaceTypePtr, numberOfFacesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, ref int isSupportedFontType, ref FontFileType fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
        {
            fixed (FontFileType* fontFileTypePtr = &fontFileType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileTypePtr, fontFaceType, numberOfFaces);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, ref int isSupportedFontType, ref FontFileType fontFileType, FontFaceType* fontFaceType, ref uint numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
        {
            fixed (FontFileType* fontFileTypePtr = &fontFileType)
            {
                fixed (uint* numberOfFacesPtr = &numberOfFaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileTypePtr, fontFaceType, numberOfFacesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, ref int isSupportedFontType, ref FontFileType fontFileType, ref FontFaceType fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
        {
            fixed (FontFileType* fontFileTypePtr = &fontFileType)
            {
                fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileTypePtr, fontFaceTypePtr, numberOfFaces);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, ref int isSupportedFontType, ref FontFileType fontFileType, ref FontFaceType fontFaceType, ref uint numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
        {
            fixed (FontFileType* fontFileTypePtr = &fontFileType)
            {
                fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
                {
                    fixed (uint* numberOfFacesPtr = &numberOfFaces)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileTypePtr, fontFaceTypePtr, numberOfFacesPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontFile> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFile> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFile> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReferenceKey(this ComPtr<IDWriteFontFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fontFileReferenceKey, Span<uint> fontFileReferenceKeySize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetReferenceKey(fontFileReferenceKey, ref fontFileReferenceKeySize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetReferenceKey(this ComPtr<IDWriteFontFile> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* fontFileReferenceKey, Span<uint> fontFileReferenceKeySize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetReferenceKey(in fontFileReferenceKey, ref fontFileReferenceKeySize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLoader<TI0>(this ComPtr<IDWriteFontFile> thisVtbl, ref ComPtr<TI0> fontFileLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetLoader((IDWriteFontFileLoader**) fontFileLoader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, Span<uint> numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(isSupportedFontType, fontFileType, fontFaceType, ref numberOfFaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, FontFileType* fontFileType, Span<FontFaceType> fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(isSupportedFontType, fontFileType, ref fontFaceType.GetPinnableReference(), numberOfFaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, FontFileType* fontFileType, Span<FontFaceType> fontFaceType, Span<uint> numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(isSupportedFontType, fontFileType, ref fontFaceType.GetPinnableReference(), ref numberOfFaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, Span<FontFileType> fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(isSupportedFontType, ref fontFileType.GetPinnableReference(), fontFaceType, numberOfFaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, Span<FontFileType> fontFileType, FontFaceType* fontFaceType, Span<uint> numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(isSupportedFontType, ref fontFileType.GetPinnableReference(), fontFaceType, ref numberOfFaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, Span<FontFileType> fontFileType, Span<FontFaceType> fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(isSupportedFontType, ref fontFileType.GetPinnableReference(), ref fontFaceType.GetPinnableReference(), numberOfFaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, int* isSupportedFontType, Span<FontFileType> fontFileType, Span<FontFaceType> fontFaceType, Span<uint> numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(isSupportedFontType, ref fontFileType.GetPinnableReference(), ref fontFaceType.GetPinnableReference(), ref numberOfFaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, Span<int> isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(ref isSupportedFontType.GetPinnableReference(), fontFileType, fontFaceType, numberOfFaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, Span<int> isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, Span<uint> numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(ref isSupportedFontType.GetPinnableReference(), fontFileType, fontFaceType, ref numberOfFaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, Span<int> isSupportedFontType, FontFileType* fontFileType, Span<FontFaceType> fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(ref isSupportedFontType.GetPinnableReference(), fontFileType, ref fontFaceType.GetPinnableReference(), numberOfFaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, Span<int> isSupportedFontType, FontFileType* fontFileType, Span<FontFaceType> fontFaceType, Span<uint> numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(ref isSupportedFontType.GetPinnableReference(), fontFileType, ref fontFaceType.GetPinnableReference(), ref numberOfFaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, Span<int> isSupportedFontType, Span<FontFileType> fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(ref isSupportedFontType.GetPinnableReference(), ref fontFileType.GetPinnableReference(), fontFaceType, numberOfFaces);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, Span<int> isSupportedFontType, Span<FontFileType> fontFileType, FontFaceType* fontFaceType, Span<uint> numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(ref isSupportedFontType.GetPinnableReference(), ref fontFileType.GetPinnableReference(), fontFaceType, ref numberOfFaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, Span<int> isSupportedFontType, Span<FontFileType> fontFileType, Span<FontFaceType> fontFaceType, uint* numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(ref isSupportedFontType.GetPinnableReference(), ref fontFileType.GetPinnableReference(), ref fontFaceType.GetPinnableReference(), numberOfFaces);
    }

    /// <summary>To be documented.</summary>
    public static int Analyze(this ComPtr<IDWriteFontFile> thisVtbl, Span<int> isSupportedFontType, Span<FontFileType> fontFileType, Span<FontFaceType> fontFaceType, Span<uint> numberOfFaces)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Analyze(ref isSupportedFontType.GetPinnableReference(), ref fontFileType.GetPinnableReference(), ref fontFaceType.GetPinnableReference(), ref numberOfFaces.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontFile> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
