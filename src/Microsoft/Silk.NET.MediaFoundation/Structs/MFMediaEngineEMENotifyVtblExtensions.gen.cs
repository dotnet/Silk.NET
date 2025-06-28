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

public unsafe static class MFMediaEngineEMENotifyVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineEMENotify> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineEMENotify> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb, char* bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitData, cb, bstrInitDataType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb, ref char bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        fixed (char* bstrInitDataTypePtr = &bstrInitDataType)
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitData, cb, bstrInitDataTypePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        var bstrInitDataTypePtr = (byte*) SilkMarshal.StringToPtr(bstrInitDataType, NativeStringEncoding.BStr);
        ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, byte*, void>)@this->LpVtbl[3])(@this, pbInitData, cb, bstrInitDataTypePtr);
        SilkMarshal.Free((nint)bstrInitDataTypePtr);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb, char* bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pbInitDataPtr = &pbInitData)
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataType);
        }
    }

    /// <summary>To be documented.</summary>
    public static void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb, ref char bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pbInitDataPtr = &pbInitData)
        {
            fixed (char* bstrInitDataTypePtr = &bstrInitDataType)
            {
                ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataTypePtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        fixed (byte* pbInitDataPtr = &pbInitData)
        {
        var bstrInitDataTypePtr = (byte*) SilkMarshal.StringToPtr(bstrInitDataType, NativeStringEncoding.BStr);
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, byte*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataTypePtr);
        SilkMarshal.Free((nint)bstrInitDataTypePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb, char* bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
        ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataType);
        SilkMarshal.Free((nint)pbInitDataPtr);
    }

    /// <summary>To be documented.</summary>
    public static void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb, ref char bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
        fixed (char* bstrInitDataTypePtr = &bstrInitDataType)
        {
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataTypePtr);
        }
        SilkMarshal.Free((nint)pbInitDataPtr);
    }

    /// <summary>To be documented.</summary>
    public static void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
        var bstrInitDataTypePtr = (byte*) SilkMarshal.StringToPtr(bstrInitDataType, NativeStringEncoding.BStr);
        ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, byte*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataTypePtr);
        SilkMarshal.Free((nint)bstrInitDataTypePtr);
        SilkMarshal.Free((nint)pbInitDataPtr);
    }

    /// <summary>To be documented.</summary>
    public static void WaitingForKey(this ComPtr<IMFMediaEngineEMENotify> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, void>)@this->LpVtbl[4])(@this);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb, Span<char> bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Encrypted(pbInitData, cb, ref bstrInitDataType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pbInitData, uint cb, char* bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Encrypted(in pbInitData.GetPinnableReference(), cb, bstrInitDataType);
    }

    /// <summary>To be documented.</summary>
    public static void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pbInitData, uint cb, Span<char> bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Encrypted(in pbInitData.GetPinnableReference(), cb, ref bstrInitDataType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pbInitData, uint cb, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Encrypted(in pbInitData.GetPinnableReference(), cb, bstrInitDataType);
    }

    /// <summary>To be documented.</summary>
    public static void Encrypted(this ComPtr<IMFMediaEngineEMENotify> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb, Span<char> bstrInitDataType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->Encrypted(pbInitData, cb, ref bstrInitDataType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineEMENotify> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
