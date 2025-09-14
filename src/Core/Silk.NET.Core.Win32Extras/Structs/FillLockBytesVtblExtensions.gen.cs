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

public unsafe static class FillLockBytesVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IFillLockBytes> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IFillLockBytes> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IFillLockBytes> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IFillLockBytes> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IFillLockBytes> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IFillLockBytes> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillAppend(this ComPtr<IFillLockBytes> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, uint* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pv, cb, pcbWritten);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillAppend(this ComPtr<IFillLockBytes> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, ref uint pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbWrittenPtr = &pcbWritten)
        {
            ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pv, cb, pcbWrittenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillAppend<T0>(this ComPtr<IFillLockBytes> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pv, uint cb, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pvPtr, cb, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FillAppend<T0>(this ComPtr<IFillLockBytes> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pv, uint cb, ref uint pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pvPtr, cb, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillAt(this ComPtr<IFillLockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, uint* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, ulOffset, pv, cb, pcbWritten);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillAt(this ComPtr<IFillLockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, ref uint pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbWrittenPtr = &pcbWritten)
        {
            ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, ulOffset, pv, cb, pcbWrittenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillAt<T0>(this ComPtr<IFillLockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pv, uint cb, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, ulOffset, pvPtr, cb, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FillAt<T0>(this ComPtr<IFillLockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pv, uint cb, ref uint pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, ulOffset, pvPtr, cb, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFillSize(this ComPtr<IFillLockBytes> thisVtbl, ulong ulSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, ulong, int>)@this->LpVtbl[5])(@this, ulSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Terminate(this ComPtr<IFillLockBytes> thisVtbl, Silk.NET.Core.Bool32 bCanceled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IFillLockBytes*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, bCanceled);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IFillLockBytes> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IFillLockBytes> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IFillLockBytes> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillAppend(this ComPtr<IFillLockBytes> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, Span<uint> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillAppend(pv, cb, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillAppend<T0>(this ComPtr<IFillLockBytes> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillAppend(in pv.GetPinnableReference(), cb, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static int FillAppend<T0>(this ComPtr<IFillLockBytes> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, Span<uint> pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillAppend(in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillAt(this ComPtr<IFillLockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, Span<uint> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillAt(ulOffset, pv, cb, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillAt<T0>(this ComPtr<IFillLockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillAt(ulOffset, in pv.GetPinnableReference(), cb, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static int FillAt<T0>(this ComPtr<IFillLockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, Span<uint> pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FillAt(ulOffset, in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IFillLockBytes> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
