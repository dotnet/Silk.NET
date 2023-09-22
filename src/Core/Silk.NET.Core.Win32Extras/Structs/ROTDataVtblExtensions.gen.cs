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

public unsafe static class ROTDataVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IROTData> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IROTData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IROTData> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IROTData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IROTData> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IROTData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IROTData> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IROTData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IROTData> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IROTData*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IROTData> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IROTData*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComparisonData(this ComPtr<IROTData> thisVtbl, byte* pbData, uint cbMax, uint* pcbData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbData, cbMax, pcbData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComparisonData(this ComPtr<IROTData> thisVtbl, byte* pbData, uint cbMax, ref uint pcbData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbDataPtr = &pcbData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbData, cbMax, pcbDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComparisonData(this ComPtr<IROTData> thisVtbl, ref byte pbData, uint cbMax, uint* pcbData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbDataPtr = &pbData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbDataPtr, cbMax, pcbData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetComparisonData(this ComPtr<IROTData> thisVtbl, ref byte pbData, uint cbMax, ref uint pcbData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbDataPtr = &pbData)
        {
            fixed (uint* pcbDataPtr = &pcbData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbDataPtr, cbMax, pcbDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComparisonData(this ComPtr<IROTData> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbData, uint cbMax, uint* pcbData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbDataPtr = (byte*) SilkMarshal.StringToPtr(pbData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbDataPtr, cbMax, pcbData);
        SilkMarshal.Free((nint)pbDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetComparisonData(this ComPtr<IROTData> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbData, uint cbMax, ref uint pcbData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbDataPtr = (byte*) SilkMarshal.StringToPtr(pbData, NativeStringEncoding.UTF8);
        fixed (uint* pcbDataPtr = &pcbData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbDataPtr, cbMax, pcbDataPtr);
        }
        SilkMarshal.Free((nint)pbDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IROTData> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IROTData> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IROTData> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComparisonData(this ComPtr<IROTData> thisVtbl, byte* pbData, uint cbMax, Span<uint> pcbData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetComparisonData(pbData, cbMax, ref pcbData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetComparisonData(this ComPtr<IROTData> thisVtbl, Span<byte> pbData, uint cbMax, uint* pcbData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetComparisonData(ref pbData.GetPinnableReference(), cbMax, pcbData);
    }

    /// <summary>To be documented.</summary>
    public static int GetComparisonData(this ComPtr<IROTData> thisVtbl, Span<byte> pbData, uint cbMax, Span<uint> pcbData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetComparisonData(ref pbData.GetPinnableReference(), cbMax, ref pcbData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetComparisonData(this ComPtr<IROTData> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbData, uint cbMax, Span<uint> pcbData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetComparisonData(pbData, cbMax, ref pcbData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IROTData> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
