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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class ThumbnailExtractorVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IThumbnailExtractor> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IThumbnailExtractor> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IThumbnailExtractor> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IThumbnailExtractor> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IThumbnailExtractor> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IThumbnailExtractor> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** phOutputBitmapPtr = &phOutputBitmap)
        {
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
        {
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeightPtr, phOutputBitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
        {
            fixed (void** phOutputBitmapPtr = &phOutputBitmap)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeightPtr, phOutputBitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pulOutputLengthPtr = &pulOutputLength)
        {
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeight, phOutputBitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pulOutputLengthPtr = &pulOutputLength)
        {
            fixed (void** phOutputBitmapPtr = &phOutputBitmap)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeight, phOutputBitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pulOutputLengthPtr = &pulOutputLength)
        {
            fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeightPtr, phOutputBitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pulOutputLengthPtr = &pulOutputLength)
        {
            fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
            {
                fixed (void** phOutputBitmapPtr = &phOutputBitmap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeightPtr, phOutputBitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, ref IStorage pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgPtr = &pStg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, ref IStorage pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgPtr = &pStg)
        {
            fixed (void** phOutputBitmapPtr = &phOutputBitmap)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmapPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, ref IStorage pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgPtr = &pStg)
        {
            fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLength, pulOutputHeightPtr, phOutputBitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, ref IStorage pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgPtr = &pStg)
        {
            fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
            {
                fixed (void** phOutputBitmapPtr = &phOutputBitmap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLength, pulOutputHeightPtr, phOutputBitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, ref IStorage pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgPtr = &pStg)
        {
            fixed (uint* pulOutputLengthPtr = &pulOutputLength)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeight, phOutputBitmap);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, ref IStorage pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgPtr = &pStg)
        {
            fixed (uint* pulOutputLengthPtr = &pulOutputLength)
            {
                fixed (void** phOutputBitmapPtr = &phOutputBitmap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeight, phOutputBitmapPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, ref IStorage pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgPtr = &pStg)
        {
            fixed (uint* pulOutputLengthPtr = &pulOutputLength)
            {
                fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeightPtr, phOutputBitmap);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, ref IStorage pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgPtr = &pStg)
        {
            fixed (uint* pulOutputLengthPtr = &pulOutputLength)
            {
                fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
                {
                    fixed (void** phOutputBitmapPtr = &phOutputBitmap)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeightPtr, phOutputBitmapPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OnFileUpdated(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, int>)@this->LpVtbl[4])(@this, pStg);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int OnFileUpdated(this ComPtr<IThumbnailExtractor> thisVtbl, ref IStorage pStg)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IStorage* pStgPtr = &pStg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, int>)@this->LpVtbl[4])(@this, pStgPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IThumbnailExtractor> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IThumbnailExtractor> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IThumbnailExtractor> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail<TI0>(this ComPtr<IThumbnailExtractor> thisVtbl, ComPtr<TI0> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail<TI0>(this ComPtr<IThumbnailExtractor> thisVtbl, ComPtr<TI0> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, pulOutputLength, pulOutputHeight, ref phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, Span<uint> pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(pStg, ulLength, ulHeight, pulOutputLength, ref pulOutputHeight.GetPinnableReference(), phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail<TI0>(this ComPtr<IThumbnailExtractor> thisVtbl, ComPtr<TI0> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, pulOutputLength, ref pulOutputHeight, phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, Span<uint> pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(pStg, ulLength, ulHeight, pulOutputLength, ref pulOutputHeight.GetPinnableReference(), ref phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail<TI0>(this ComPtr<IThumbnailExtractor> thisVtbl, ComPtr<TI0> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, pulOutputLength, ref pulOutputHeight, ref phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, Span<uint> pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(pStg, ulLength, ulHeight, ref pulOutputLength.GetPinnableReference(), pulOutputHeight, phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail<TI0>(this ComPtr<IThumbnailExtractor> thisVtbl, ComPtr<TI0> pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, ref pulOutputLength, pulOutputHeight, phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, Span<uint> pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(pStg, ulLength, ulHeight, ref pulOutputLength.GetPinnableReference(), pulOutputHeight, ref phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail<TI0>(this ComPtr<IThumbnailExtractor> thisVtbl, ComPtr<TI0> pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, ref pulOutputLength, pulOutputHeight, ref phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, Span<uint> pulOutputLength, Span<uint> pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(pStg, ulLength, ulHeight, ref pulOutputLength.GetPinnableReference(), ref pulOutputHeight.GetPinnableReference(), phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail<TI0>(this ComPtr<IThumbnailExtractor> thisVtbl, ComPtr<TI0> pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, ref pulOutputLength, ref pulOutputHeight, phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, IStorage* pStg, uint ulLength, uint ulHeight, Span<uint> pulOutputLength, Span<uint> pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(pStg, ulLength, ulHeight, ref pulOutputLength.GetPinnableReference(), ref pulOutputHeight.GetPinnableReference(), ref phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail<TI0>(this ComPtr<IThumbnailExtractor> thisVtbl, ComPtr<TI0> pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, ref pulOutputLength, ref pulOutputHeight, ref phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, Span<IStorage> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(ref pStg.GetPinnableReference(), ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, Span<IStorage> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(ref pStg.GetPinnableReference(), ulLength, ulHeight, pulOutputLength, pulOutputHeight, ref phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, Span<IStorage> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, Span<uint> pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(ref pStg.GetPinnableReference(), ulLength, ulHeight, pulOutputLength, ref pulOutputHeight.GetPinnableReference(), phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, Span<IStorage> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, Span<uint> pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(ref pStg.GetPinnableReference(), ulLength, ulHeight, pulOutputLength, ref pulOutputHeight.GetPinnableReference(), ref phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, Span<IStorage> pStg, uint ulLength, uint ulHeight, Span<uint> pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(ref pStg.GetPinnableReference(), ulLength, ulHeight, ref pulOutputLength.GetPinnableReference(), pulOutputHeight, phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, Span<IStorage> pStg, uint ulLength, uint ulHeight, Span<uint> pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(ref pStg.GetPinnableReference(), ulLength, ulHeight, ref pulOutputLength.GetPinnableReference(), pulOutputHeight, ref phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, Span<IStorage> pStg, uint ulLength, uint ulHeight, Span<uint> pulOutputLength, Span<uint> pulOutputHeight, void** phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(ref pStg.GetPinnableReference(), ulLength, ulHeight, ref pulOutputLength.GetPinnableReference(), ref pulOutputHeight.GetPinnableReference(), phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ExtractThumbnail(this ComPtr<IThumbnailExtractor> thisVtbl, Span<IStorage> pStg, uint ulLength, uint ulHeight, Span<uint> pulOutputLength, Span<uint> pulOutputHeight, ref void* phOutputBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ExtractThumbnail(ref pStg.GetPinnableReference(), ulLength, ulHeight, ref pulOutputLength.GetPinnableReference(), ref pulOutputHeight.GetPinnableReference(), ref phOutputBitmap);
    }

    /// <summary>To be documented.</summary>
    public static int OnFileUpdated<TI0>(this ComPtr<IThumbnailExtractor> thisVtbl, ComPtr<TI0> pStg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->OnFileUpdated((IStorage*) pStg.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int OnFileUpdated(this ComPtr<IThumbnailExtractor> thisVtbl, Span<IStorage> pStg)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->OnFileUpdated(ref pStg.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IThumbnailExtractor> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
