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

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICStreamVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStream> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStream> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStream> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStream> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IWICStream> thisVtbl, void* pv, uint cb, uint* pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pv, cb, pcbRead);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IWICStream> thisVtbl, void* pv, uint cb, ref uint pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbReadPtr = &pcbRead)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pv, cb, pcbReadPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<T0>(this ComPtr<IWICStream> thisVtbl, ref T0 pv, uint cb, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pvPtr, cb, pcbRead);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Read<T0>(this ComPtr<IWICStream> thisVtbl, ref T0 pv, uint cb, ref uint pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStream*, void*, uint, uint*, int>)@this->LpVtbl[3])(@this, pvPtr, cb, pcbReadPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IWICStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, uint* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pv, cb, pcbWritten);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IWICStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, ref uint pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbWrittenPtr = &pcbWritten)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pv, cb, pcbWrittenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write<T0>(this ComPtr<IWICStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pv, uint cb, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pvPtr, cb, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Write<T0>(this ComPtr<IWICStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pv, uint cb, ref uint pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStream*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, pvPtr, cb, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Seek(this ComPtr<IWICStream> thisVtbl, long dlibMove, uint dwOrigin, ulong* plibNewPosition)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, long, uint, ulong*, int>)@this->LpVtbl[5])(@this, dlibMove, dwOrigin, plibNewPosition);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Seek(this ComPtr<IWICStream> thisVtbl, long dlibMove, uint dwOrigin, ref ulong plibNewPosition)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* plibNewPositionPtr = &plibNewPosition)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, long, uint, ulong*, int>)@this->LpVtbl[5])(@this, dlibMove, dwOrigin, plibNewPositionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSize(this ComPtr<IWICStream> thisVtbl, ulong libNewSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, ulong, int>)@this->LpVtbl[6])(@this, libNewSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstm, cb, pcbRead, pcbWritten);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ref ulong pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pcbWrittenPtr = &pcbWritten)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstm, cb, pcbRead, pcbWrittenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ref ulong pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pcbReadPtr = &pcbRead)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstm, cb, pcbReadPtr, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ref ulong pcbRead, ref ulong pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pcbReadPtr = &pcbRead)
        {
            fixed (ulong* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstm, cb, pcbReadPtr, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstmPtr, cb, pcbRead, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ulong* pcbRead, ref ulong pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
        {
            fixed (ulong* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstmPtr, cb, pcbRead, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ref ulong pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
        {
            fixed (ulong* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstmPtr, cb, pcbReadPtr, pcbWritten);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyTo(this ComPtr<IWICStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ref ulong pcbRead, ref ulong pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
        {
            fixed (ulong* pcbReadPtr = &pcbRead)
            {
                fixed (ulong* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)@this->LpVtbl[7])(@this, pstmPtr, cb, pcbReadPtr, pcbWrittenPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Commit(this ComPtr<IWICStream> thisVtbl, uint grfCommitFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, uint, int>)@this->LpVtbl[8])(@this, grfCommitFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Revert(this ComPtr<IWICStream> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, int>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LockRegion(this ComPtr<IWICStream> thisVtbl, ulong libOffset, ulong cb, uint dwLockType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, ulong, ulong, uint, int>)@this->LpVtbl[10])(@this, libOffset, cb, dwLockType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnlockRegion(this ComPtr<IWICStream> thisVtbl, ulong libOffset, ulong cb, uint dwLockType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, ulong, ulong, uint, int>)@this->LpVtbl[11])(@this, libOffset, cb, dwLockType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Stat(this ComPtr<IWICStream> thisVtbl, Silk.NET.Core.Win32Extras.STATSTG* pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.STATSTG*, uint, int>)@this->LpVtbl[12])(@this, pstatstg, grfStatFlag);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Stat(this ComPtr<IWICStream> thisVtbl, ref Silk.NET.Core.Win32Extras.STATSTG pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.STATSTG* pstatstgPtr = &pstatstg)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.STATSTG*, uint, int>)@this->LpVtbl[12])(@this, pstatstgPtr, grfStatFlag);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IWICStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream** ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[13])(@this, ppstm);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IWICStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream* ppstm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream**, int>)@this->LpVtbl[13])(@this, ppstmPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InitializeFromIStream(this ComPtr<IWICStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[14])(@this, pIStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromIStream(this ComPtr<IWICStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[14])(@this, pIStreamPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InitializeFromFilename(this ComPtr<IWICStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFileName, uint dwDesiredAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, char*, uint, int>)@this->LpVtbl[15])(@this, wzFileName, dwDesiredAccess);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromFilename(this ComPtr<IWICStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFileName, uint dwDesiredAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFileNamePtr = &wzFileName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, char*, uint, int>)@this->LpVtbl[15])(@this, wzFileNamePtr, dwDesiredAccess);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromFilename(this ComPtr<IWICStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFileName, uint dwDesiredAccess)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFileNamePtr = (byte*) SilkMarshal.StringToPtr(wzFileName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, byte*, uint, int>)@this->LpVtbl[15])(@this, wzFileNamePtr, dwDesiredAccess);
        SilkMarshal.Free((nint)wzFileNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InitializeFromMemory(this ComPtr<IWICStream> thisVtbl, byte* pbBuffer, uint cbBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, byte*, uint, int>)@this->LpVtbl[16])(@this, pbBuffer, cbBufferSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromMemory(this ComPtr<IWICStream> thisVtbl, ref byte pbBuffer, uint cbBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, byte*, uint, int>)@this->LpVtbl[16])(@this, pbBufferPtr, cbBufferSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromMemory(this ComPtr<IWICStream> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, uint cbBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, byte*, uint, int>)@this->LpVtbl[16])(@this, pbBufferPtr, cbBufferSize);
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InitializeFromIStreamRegion(this ComPtr<IWICStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pIStream, ulong ulOffset, ulong ulMaxSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong, int>)@this->LpVtbl[17])(@this, pIStream, ulOffset, ulMaxSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromIStreamRegion(this ComPtr<IWICStream> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pIStream, ulong ulOffset, ulong ulMaxSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong, int>)@this->LpVtbl[17])(@this, pIStreamPtr, ulOffset, ulMaxSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICStream> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStream> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICStream> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IWICStream> thisVtbl, void* pv, uint cb, Span<uint> pcbRead)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(pv, cb, ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<T0>(this ComPtr<IWICStream> thisVtbl, Span<T0> pv, uint cb, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(ref pv.GetPinnableReference(), cb, pcbRead);
    }

    /// <summary>To be documented.</summary>
    public static int Read<T0>(this ComPtr<IWICStream> thisVtbl, Span<T0> pv, uint cb, Span<uint> pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IWICStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pv, uint cb, Span<uint> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(pv, cb, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write<T0>(this ComPtr<IWICStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(in pv.GetPinnableReference(), cb, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static int Write<T0>(this ComPtr<IWICStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, Span<uint> pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Seek(this ComPtr<IWICStream> thisVtbl, long dlibMove, uint dwOrigin, Span<ulong> plibNewPosition)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Seek(dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo<TI0>(this ComPtr<IWICStream> thisVtbl, ComPtr<TI0> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo((Silk.NET.Core.Win32Extras.IStream*) pstm.Handle, cb, pcbRead, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo<TI0>(this ComPtr<IWICStream> thisVtbl, ComPtr<TI0> pstm, ulong cb, ulong* pcbRead, ref ulong pcbWritten) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo((Silk.NET.Core.Win32Extras.IStream*) pstm.Handle, cb, pcbRead, ref pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo<TI0>(this ComPtr<IWICStream> thisVtbl, ComPtr<TI0> pstm, ulong cb, ref ulong pcbRead, ulong* pcbWritten) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo((Silk.NET.Core.Win32Extras.IStream*) pstm.Handle, cb, ref pcbRead, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyTo<TI0>(this ComPtr<IWICStream> thisVtbl, ComPtr<TI0> pstm, ulong cb, ref ulong pcbRead, ref ulong pcbWritten) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyTo((Silk.NET.Core.Win32Extras.IStream*) pstm.Handle, cb, ref pcbRead, ref pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyTo(this ComPtr<IWICStream> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static int CopyTo(this ComPtr<IWICStream> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyTo(ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Stat(this ComPtr<IWICStream> thisVtbl, Span<Silk.NET.Core.Win32Extras.STATSTG> pstatstg, uint grfStatFlag)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Stat(ref pstatstg.GetPinnableReference(), grfStatFlag);
    }

    /// <summary>To be documented.</summary>
    public static int Clone<TI0>(this ComPtr<IWICStream> thisVtbl, ref ComPtr<TI0> ppstm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Clone((Silk.NET.Core.Win32Extras.IStream**) ppstm.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromIStream<TI0>(this ComPtr<IWICStream> thisVtbl, ComPtr<TI0> pIStream) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InitializeFromIStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromIStream(this ComPtr<IWICStream> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pIStream)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InitializeFromIStream(ref pIStream.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromFilename(this ComPtr<IWICStream> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzFileName, uint dwDesiredAccess)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InitializeFromFilename(in wzFileName.GetPinnableReference(), dwDesiredAccess);
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromMemory(this ComPtr<IWICStream> thisVtbl, Span<byte> pbBuffer, uint cbBufferSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InitializeFromMemory(ref pbBuffer.GetPinnableReference(), cbBufferSize);
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromIStreamRegion<TI0>(this ComPtr<IWICStream> thisVtbl, ComPtr<TI0> pIStream, ulong ulOffset, ulong ulMaxSize) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->InitializeFromIStreamRegion((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ulOffset, ulMaxSize);
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromIStreamRegion(this ComPtr<IWICStream> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pIStream, ulong ulOffset, ulong ulMaxSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InitializeFromIStreamRegion(ref pIStream.GetPinnableReference(), ulOffset, ulMaxSize);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICStream> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
