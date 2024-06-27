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

public unsafe static class LockBytesVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILockBytes> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILockBytes> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILockBytes> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILockBytes> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ILockBytes> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ILockBytes> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadAt(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, void* pv, uint cb, uint* pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, ulOffset, pv, cb, pcbRead);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadAt(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, void* pv, uint cb, ref uint pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbReadPtr = &pcbRead)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, ulOffset, pv, cb, pcbReadPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadAt<T0>(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, ref T0 pv, uint cb, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, ulOffset, pvPtr, cb, pcbRead);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReadAt<T0>(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, ref T0 pv, uint cb, ref uint pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, ulOffset, pvPtr, cb, pcbReadPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteAt(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, uint* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, ulOffset, pv, cb, pcbWritten);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteAt(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, ref uint pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbWrittenPtr = &pcbWritten)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, ulOffset, pv, cb, pcbWrittenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteAt<T0>(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pv, uint cb, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, ulOffset, pvPtr, cb, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WriteAt<T0>(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pv, uint cb, ref uint pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, ulong, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, ulOffset, pvPtr, cb, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Flush(this ComPtr<ILockBytes> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSize(this ComPtr<ILockBytes> thisVtbl, ulong cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, ulong, int>)@this->LpVtbl[6])(@this, cb);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LockRegion(this ComPtr<ILockBytes> thisVtbl, ulong libOffset, ulong cb, uint dwLockType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, ulong, ulong, uint, int>)@this->LpVtbl[7])(@this, libOffset, cb, dwLockType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnlockRegion(this ComPtr<ILockBytes> thisVtbl, ulong libOffset, ulong cb, uint dwLockType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, ulong, ulong, uint, int>)@this->LpVtbl[8])(@this, libOffset, cb, dwLockType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Stat(this ComPtr<ILockBytes> thisVtbl, STATSTG* pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, STATSTG*, uint, int>)@this->LpVtbl[9])(@this, pstatstg, grfStatFlag);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Stat(this ComPtr<ILockBytes> thisVtbl, ref STATSTG pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (STATSTG* pstatstgPtr = &pstatstg)
        {
            ret = ((delegate* unmanaged[Cdecl]<ILockBytes*, STATSTG*, uint, int>)@this->LpVtbl[9])(@this, pstatstgPtr, grfStatFlag);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ILockBytes> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILockBytes> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ILockBytes> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadAt(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, void* pv, uint cb, Span<uint> pcbRead)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReadAt(ulOffset, pv, cb, ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReadAt<T0>(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, Span<T0> pv, uint cb, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReadAt(ulOffset, ref pv.GetPinnableReference(), cb, pcbRead);
    }

    /// <summary>To be documented.</summary>
    public static int ReadAt<T0>(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, Span<T0> pv, uint cb, Span<uint> pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReadAt(ulOffset, ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteAt(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, Span<uint> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteAt(ulOffset, pv, cb, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteAt<T0>(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteAt(ulOffset, in pv.GetPinnableReference(), cb, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static int WriteAt<T0>(this ComPtr<ILockBytes> thisVtbl, ulong ulOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, Span<uint> pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteAt(ulOffset, in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Stat(this ComPtr<ILockBytes> thisVtbl, Span<STATSTG> pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Stat(ref pstatstg.GetPinnableReference(), grfStatFlag);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ILockBytes> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
