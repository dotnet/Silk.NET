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

public unsafe static class StreamVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStream> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStream> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStream> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStream> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IStream> thisVtbl, void* pv, uint cb, uint* pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pv, cb, pcbRead);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IStream> thisVtbl, void* pv, uint cb, ref uint pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbReadPtr = &pcbRead)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pv, cb, pcbReadPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<T0>(this ComPtr<IStream> thisVtbl, ref T0 pv, uint cb, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pvPtr, cb, pcbRead);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Read<T0>(this ComPtr<IStream> thisVtbl, ref T0 pv, uint cb, ref uint pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pvPtr, cb, pcbReadPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, uint* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pv, cb, pcbWritten);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, ref uint pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbWrittenPtr = &pcbWritten)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pv, cb, pcbWrittenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write<T0>(this ComPtr<IStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pv, uint cb, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pvPtr, cb, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Write<T0>(this ComPtr<IStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pv, uint cb, ref uint pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pvPtr, cb, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Seek(this ComPtr<IStream> thisVtbl, long dlibMove, uint dwOrigin, ulong* plibNewPosition)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, long, uint, ulong*, int>)@this->LpVtbl[5])(@this, dlibMove, dwOrigin, plibNewPosition);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Seek(this ComPtr<IStream> thisVtbl, long dlibMove, uint dwOrigin, ref ulong plibNewPosition)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* plibNewPositionPtr = &plibNewPosition)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, long, uint, ulong*, int>)@this->LpVtbl[5])(@this, dlibMove, dwOrigin, plibNewPositionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSize(this ComPtr<IStream> thisVtbl, ulong libNewSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, ulong, int>)@this->LpVtbl[6])(@this, libNewSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstm, cb, pcbRead, pcbWritten);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ref ulong pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pcbWrittenPtr = &pcbWritten)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstm, cb, pcbRead, pcbWrittenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ref ulong pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pcbReadPtr = &pcbRead)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstm, cb, pcbReadPtr, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ref ulong pcbRead, ref ulong pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pcbReadPtr = &pcbRead)
        {
            fixed (ulong* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstm, cb, pcbReadPtr, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstmPtr, cb, pcbRead, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ulong* pcbRead, ref ulong pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
        {
            fixed (ulong* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstmPtr, cb, pcbRead, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ref ulong pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
        {
            fixed (ulong* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Cdecl]<IStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstmPtr, cb, pcbReadPtr, pcbWritten);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyTo(this ComPtr<IStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ref ulong pcbRead, ref ulong pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
        {
            fixed (ulong* pcbReadPtr = &pcbRead)
            {
                fixed (ulong* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstmPtr, cb, pcbReadPtr, pcbWrittenPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Commit(this ComPtr<IStream> thisVtbl, uint grfCommitFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, uint, int>)@this->LpVtbl[8])(@this, grfCommitFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Revert(this ComPtr<IStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, int>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LockRegion(this ComPtr<IStream> thisVtbl, ulong libOffset, ulong cb, uint dwLockType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, ulong, ulong, uint, int>)@this->LpVtbl[10])(@this, libOffset, cb, dwLockType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnlockRegion(this ComPtr<IStream> thisVtbl, ulong libOffset, ulong cb, uint dwLockType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, ulong, ulong, uint, int>)@this->LpVtbl[11])(@this, libOffset, cb, dwLockType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Stat(this ComPtr<IStream> thisVtbl, STATSTG* pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, STATSTG*, uint, int>)@this->LpVtbl[12])(@this, pstatstg, grfStatFlag);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Stat(this ComPtr<IStream> thisVtbl, ref STATSTG pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (STATSTG* pstatstgPtr = &pstatstg)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, STATSTG*, uint, int>)@this->LpVtbl[12])(@this, pstatstgPtr, grfStatFlag);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream** ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IStream*, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[13])(@this, ppstm);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream* ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IStream*, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[13])(@this, ppstmPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IStream> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStream> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IStream> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IStream> thisVtbl, void* pv, uint cb, Span<uint> pcbRead)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(pv, cb, ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<T0>(this ComPtr<IStream> thisVtbl, Span<T0> pv, uint cb, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(ref pv.GetPinnableReference(), cb, pcbRead);
    }

    /// <summary>To be documented.</summary>
    public static int Read<T0>(this ComPtr<IStream> thisVtbl, Span<T0> pv, uint cb, Span<uint> pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, Span<uint> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(pv, cb, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write<T0>(this ComPtr<IStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(in pv.GetPinnableReference(), cb, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static int Write<T0>(this ComPtr<IStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, Span<uint> pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Seek(this ComPtr<IStream> thisVtbl, long dlibMove, uint dwOrigin, Span<ulong> plibNewPosition)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Seek(dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo<TI0>(this ComPtr<IStream> thisVtbl, ComPtr<TI0> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo((Silk.NET.Core.Win32Extras.IStream*) pstm.Handle, cb, pcbRead, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo<TI0>(this ComPtr<IStream> thisVtbl, ComPtr<TI0> pstm, ulong cb, ulong* pcbRead, ref ulong pcbWritten) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo((Silk.NET.Core.Win32Extras.IStream*) pstm.Handle, cb, pcbRead, ref pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo<TI0>(this ComPtr<IStream> thisVtbl, ComPtr<TI0> pstm, ulong cb, ref ulong pcbRead, ulong* pcbWritten) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo((Silk.NET.Core.Win32Extras.IStream*) pstm.Handle, cb, ref pcbRead, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyTo<TI0>(this ComPtr<IStream> thisVtbl, ComPtr<TI0> pstm, ulong cb, ref ulong pcbRead, ref ulong pcbWritten) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo((Silk.NET.Core.Win32Extras.IStream*) pstm.Handle, cb, ref pcbRead, ref pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IStream> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static int CopyTo(this ComPtr<IStream> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Stat(this ComPtr<IStream> thisVtbl, Span<STATSTG> pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Stat(ref pstatstg.GetPinnableReference(), grfStatFlag);
    }

    /// <summary>To be documented.</summary>
    public static int Clone<TI0>(this ComPtr<IStream> thisVtbl, ref ComPtr<TI0> ppstm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Clone((Silk.NET.Core.Win32Extras.IStream**) ppstm.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IStream> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
