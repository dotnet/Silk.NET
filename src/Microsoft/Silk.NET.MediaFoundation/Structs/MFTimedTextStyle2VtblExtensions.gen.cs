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

public unsafe static class MFTimedTextStyle2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFTimedTextStyle2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFTimedTextStyle2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRuby(this ComPtr<IMFTimedTextStyle2> thisVtbl, IMFTimedTextRuby** ruby)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, IMFTimedTextRuby**, int>)@this->LpVtbl[3])(@this, ruby);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRuby(this ComPtr<IMFTimedTextStyle2> thisVtbl, ref IMFTimedTextRuby* ruby)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextRuby** rubyPtr = &ruby)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, IMFTimedTextRuby**, int>)@this->LpVtbl[3])(@this, rubyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBouten(this ComPtr<IMFTimedTextStyle2> thisVtbl, IMFTimedTextBouten** bouten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, IMFTimedTextBouten**, int>)@this->LpVtbl[4])(@this, bouten);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBouten(this ComPtr<IMFTimedTextStyle2> thisVtbl, ref IMFTimedTextBouten* bouten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextBouten** boutenPtr = &bouten)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, IMFTimedTextBouten**, int>)@this->LpVtbl[4])(@this, boutenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTextCombined(this ComPtr<IMFTimedTextStyle2> thisVtbl, int* value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, int*, int>)@this->LpVtbl[5])(@this, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsTextCombined(this ComPtr<IMFTimedTextStyle2> thisVtbl, ref int value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* valuePtr = &value)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, int*, int>)@this->LpVtbl[5])(@this, valuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontAngleInDegrees(this ComPtr<IMFTimedTextStyle2> thisVtbl, double* value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, double*, int>)@this->LpVtbl[6])(@this, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFontAngleInDegrees(this ComPtr<IMFTimedTextStyle2> thisVtbl, ref double value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* valuePtr = &value)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, double*, int>)@this->LpVtbl[6])(@this, valuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFTimedTextStyle2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetRuby<TI0>(this ComPtr<IMFTimedTextStyle2> thisVtbl, ref ComPtr<TI0> ruby) where TI0 : unmanaged, IComVtbl<IMFTimedTextRuby>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRuby((IMFTimedTextRuby**) ruby.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetBouten<TI0>(this ComPtr<IMFTimedTextStyle2> thisVtbl, ref ComPtr<TI0> bouten) where TI0 : unmanaged, IComVtbl<IMFTimedTextBouten>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBouten((IMFTimedTextBouten**) bouten.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int IsTextCombined(this ComPtr<IMFTimedTextStyle2> thisVtbl, Span<int> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTextCombined(ref value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFontAngleInDegrees(this ComPtr<IMFTimedTextStyle2> thisVtbl, Span<double> value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontAngleInDegrees(ref value.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFTimedTextStyle2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
