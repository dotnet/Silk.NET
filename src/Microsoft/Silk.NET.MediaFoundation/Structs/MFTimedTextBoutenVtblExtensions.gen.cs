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

namespace Silk.NET.MediaFoundation;

public unsafe static class MFTimedTextBoutenVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBouten> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBouten> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBouten> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBouten> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFTimedTextBouten> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFTimedTextBouten> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBoutenType(this ComPtr<IMFTimedTextBouten> thisVtbl, TimedTextBoutenType* value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, TimedTextBoutenType*, int>)@this->LpVtbl[3])(@this, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBoutenType(this ComPtr<IMFTimedTextBouten> thisVtbl, ref TimedTextBoutenType value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextBoutenType* valuePtr = &value)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, TimedTextBoutenType*, int>)@this->LpVtbl[3])(@this, valuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBoutenColor(this ComPtr<IMFTimedTextBouten> thisVtbl, _MFARGB* value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, _MFARGB*, int>)@this->LpVtbl[4])(@this, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBoutenColor(this ComPtr<IMFTimedTextBouten> thisVtbl, ref _MFARGB value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* valuePtr = &value)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, _MFARGB*, int>)@this->LpVtbl[4])(@this, valuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBoutenPosition(this ComPtr<IMFTimedTextBouten> thisVtbl, TimedTextBoutenPosition* value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, TimedTextBoutenPosition*, int>)@this->LpVtbl[5])(@this, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBoutenPosition(this ComPtr<IMFTimedTextBouten> thisVtbl, ref TimedTextBoutenPosition value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextBoutenPosition* valuePtr = &value)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextBouten*, TimedTextBoutenPosition*, int>)@this->LpVtbl[5])(@this, valuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFTimedTextBouten> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBouten> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextBouten> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetBoutenType(this ComPtr<IMFTimedTextBouten> thisVtbl, Span<TimedTextBoutenType> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBoutenType(ref value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBoutenColor(this ComPtr<IMFTimedTextBouten> thisVtbl, Span<_MFARGB> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBoutenColor(ref value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBoutenPosition(this ComPtr<IMFTimedTextBouten> thisVtbl, Span<TimedTextBoutenPosition> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBoutenPosition(ref value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFTimedTextBouten> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
