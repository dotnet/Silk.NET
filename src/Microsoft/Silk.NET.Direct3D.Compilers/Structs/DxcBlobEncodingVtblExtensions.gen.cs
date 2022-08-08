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

namespace Silk.NET.Direct3D.Compilers;

public unsafe static class DxcBlobEncodingVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetBufferPointer<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, void*>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nuint GetBufferSize<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        nuint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, nuint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncoding<TThis>(this TThis thisVtbl, int* pKnown, uint* pCodePage) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, int*, uint*, int>)@this->LpVtbl[5])(@this, pKnown, pCodePage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncoding<TThis>(this TThis thisVtbl, int* pKnown, ref uint pCodePage) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCodePagePtr = &pCodePage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, int*, uint*, int>)@this->LpVtbl[5])(@this, pKnown, pCodePagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncoding<TThis>(this TThis thisVtbl, ref int pKnown, uint* pCodePage) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pKnownPtr = &pKnown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, int*, uint*, int>)@this->LpVtbl[5])(@this, pKnownPtr, pCodePage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEncoding<TThis>(this TThis thisVtbl, ref int pKnown, ref uint pCodePage) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pKnownPtr = &pKnown)
        {
            fixed (uint* pCodePagePtr = &pCodePage)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcBlobEncoding*, int*, uint*, int>)@this->LpVtbl[5])(@this, pKnownPtr, pCodePagePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncoding<TThis>(this TThis thisVtbl, int* pKnown, Span<uint> pCodePage) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetEncoding(pKnown, ref pCodePage.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEncoding<TThis>(this TThis thisVtbl, Span<int> pKnown, uint* pCodePage) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetEncoding(ref pKnown.GetPinnableReference(), pCodePage);
    }

    /// <summary>To be documented.</summary>
    public static int GetEncoding<TThis>(this TThis thisVtbl, Span<int> pKnown, Span<uint> pCodePage) where TThis : IComVtbl<IDxcBlobEncoding>
    {
        var @this = (IDxcBlobEncoding*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetEncoding(ref pKnown.GetPinnableReference(), ref pCodePage.GetPinnableReference());
    }

}
