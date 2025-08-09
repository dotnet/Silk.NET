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

public unsafe static class MFSourceBufferVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFSourceBuffer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFSourceBuffer> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFSourceBuffer> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFSourceBuffer> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFSourceBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFSourceBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetUpdating(this ComPtr<IMFSourceBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, Silk.NET.Core.Bool32>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffered(this ComPtr<IMFSourceBuffer> thisVtbl, IMFMediaTimeRange** ppBuffered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppBuffered);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffered(this ComPtr<IMFSourceBuffer> thisVtbl, ref IMFMediaTimeRange* ppBuffered)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFMediaTimeRange** ppBufferedPtr = &ppBuffered)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppBufferedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetTimeStampOffset(this ComPtr<IMFSourceBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTimeStampOffset(this ComPtr<IMFSourceBuffer> thisVtbl, double offset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double, int>)@this->LpVtbl[6])(@this, offset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetAppendWindowStart(this ComPtr<IMFSourceBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAppendWindowStart(this ComPtr<IMFSourceBuffer> thisVtbl, double time)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double, int>)@this->LpVtbl[8])(@this, time);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetAppendWindowEnd(this ComPtr<IMFSourceBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAppendWindowEnd(this ComPtr<IMFSourceBuffer> thisVtbl, double time)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double, int>)@this->LpVtbl[10])(@this, time);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Append(this ComPtr<IMFSourceBuffer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pData, uint len)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, byte*, uint, int>)@this->LpVtbl[11])(@this, pData, len);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Append(this ComPtr<IMFSourceBuffer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pData, uint len)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, byte*, uint, int>)@this->LpVtbl[11])(@this, pDataPtr, len);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Append(this ComPtr<IMFSourceBuffer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pData, uint len)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pDataPtr = (byte*) SilkMarshal.StringToPtr(pData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, byte*, uint, int>)@this->LpVtbl[11])(@this, pDataPtr, len);
        SilkMarshal.Free((nint)pDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AppendByteStream(this ComPtr<IMFSourceBuffer> thisVtbl, IMFByteStream* pStream, ulong* pMaxLen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFByteStream*, ulong*, int>)@this->LpVtbl[12])(@this, pStream, pMaxLen);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AppendByteStream(this ComPtr<IMFSourceBuffer> thisVtbl, IMFByteStream* pStream, ref ulong pMaxLen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pMaxLenPtr = &pMaxLen)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFByteStream*, ulong*, int>)@this->LpVtbl[12])(@this, pStream, pMaxLenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AppendByteStream(this ComPtr<IMFSourceBuffer> thisVtbl, ref IMFByteStream pStream, ulong* pMaxLen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pStreamPtr = &pStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFByteStream*, ulong*, int>)@this->LpVtbl[12])(@this, pStreamPtr, pMaxLen);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AppendByteStream(this ComPtr<IMFSourceBuffer> thisVtbl, ref IMFByteStream pStream, ref ulong pMaxLen)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFByteStream* pStreamPtr = &pStream)
        {
            fixed (ulong* pMaxLenPtr = &pMaxLen)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFByteStream*, ulong*, int>)@this->LpVtbl[12])(@this, pStreamPtr, pMaxLenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Abort(this ComPtr<IMFSourceBuffer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, int>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Remove(this ComPtr<IMFSourceBuffer> thisVtbl, double start, double end)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double, double, int>)@this->LpVtbl[14])(@this, start, end);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFSourceBuffer> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFSourceBuffer> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFSourceBuffer> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetBuffered<TI0>(this ComPtr<IMFSourceBuffer> thisVtbl, ref ComPtr<TI0> ppBuffered) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBuffered((IMFMediaTimeRange**) ppBuffered.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int Append(this ComPtr<IMFSourceBuffer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pData, uint len)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Append(in pData.GetPinnableReference(), len);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AppendByteStream(this ComPtr<IMFSourceBuffer> thisVtbl, IMFByteStream* pStream, Span<ulong> pMaxLen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AppendByteStream(pStream, ref pMaxLen.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AppendByteStream(this ComPtr<IMFSourceBuffer> thisVtbl, Span<IMFByteStream> pStream, ulong* pMaxLen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AppendByteStream(ref pStream.GetPinnableReference(), pMaxLen);
    }

    /// <summary>To be documented.</summary>
    public static int AppendByteStream(this ComPtr<IMFSourceBuffer> thisVtbl, Span<IMFByteStream> pStream, Span<ulong> pMaxLen)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AppendByteStream(ref pStream.GetPinnableReference(), ref pMaxLen.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFSourceBuffer> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
