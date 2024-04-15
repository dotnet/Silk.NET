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

public unsafe static class DWriteColorGlyphRunEnumerator1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MoveNext(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, int* hasRun)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, int*, int>)@this->LpVtbl[3])(@this, hasRun);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MoveNext(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, ref int hasRun)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* hasRunPtr = &hasRun)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, int*, int>)@this->LpVtbl[3])(@this, hasRunPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentRun(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorGlyphRun** colorGlyphRun)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, ColorGlyphRun**, int>)@this->LpVtbl[4])(@this, colorGlyphRun);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentRun(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ColorGlyphRun* colorGlyphRun)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ColorGlyphRun** colorGlyphRunPtr = &colorGlyphRun)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, ColorGlyphRun**, int>)@this->LpVtbl[4])(@this, colorGlyphRunPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int MoveNext(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl, Span<int> hasRun)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MoveNext(ref hasRun.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteColorGlyphRunEnumerator1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
