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

public unsafe static class MFMediaKeySession2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaKeySession2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaKeySession2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaKeySession2> thisVtbl, ushort* code, uint* systemCode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, code, systemCode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaKeySession2> thisVtbl, ushort* code, ref uint systemCode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* systemCodePtr = &systemCode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, code, systemCodePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaKeySession2> thisVtbl, ref ushort code, uint* systemCode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* codePtr = &code)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, codePtr, systemCode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetError(this ComPtr<IMFMediaKeySession2> thisVtbl, ref ushort code, ref uint systemCode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* codePtr = &code)
        {
            fixed (uint* systemCodePtr = &systemCode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, codePtr, systemCodePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeySystem(this ComPtr<IMFMediaKeySession2> thisVtbl, char** keySystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char**, int>)@this->LpVtbl[4])(@this, keySystem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeySystem(this ComPtr<IMFMediaKeySession2> thisVtbl, ref char* keySystem)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** keySystemPtr = &keySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char**, int>)@this->LpVtbl[4])(@this, keySystemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSessionId(this ComPtr<IMFMediaKeySession2> thisVtbl, char** sessionId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char**, int>)@this->LpVtbl[5])(@this, sessionId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSessionId(this ComPtr<IMFMediaKeySession2> thisVtbl, ref char* sessionId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** sessionIdPtr = &sessionId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char**, int>)@this->LpVtbl[5])(@this, sessionIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Update(this ComPtr<IMFMediaKeySession2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, uint, int>)@this->LpVtbl[6])(@this, key, cb);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Update(this ComPtr<IMFMediaKeySession2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* keyPtr = &key)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, uint, int>)@this->LpVtbl[6])(@this, keyPtr, cb);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Update(this ComPtr<IMFMediaKeySession2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, uint, int>)@this->LpVtbl[6])(@this, keyPtr, cb);
        SilkMarshal.Free((nint)keyPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<IMFMediaKeySession2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, int>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeyStatuses(this ComPtr<IMFMediaKeySession2> thisVtbl, MFMediaKeyStatus** pKeyStatusesArray, uint* puSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, MFMediaKeyStatus**, uint*, int>)@this->LpVtbl[8])(@this, pKeyStatusesArray, puSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeyStatuses(this ComPtr<IMFMediaKeySession2> thisVtbl, MFMediaKeyStatus** pKeyStatusesArray, ref uint puSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* puSizePtr = &puSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, MFMediaKeyStatus**, uint*, int>)@this->LpVtbl[8])(@this, pKeyStatusesArray, puSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeyStatuses(this ComPtr<IMFMediaKeySession2> thisVtbl, ref MFMediaKeyStatus* pKeyStatusesArray, uint* puSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MFMediaKeyStatus** pKeyStatusesArrayPtr = &pKeyStatusesArray)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, MFMediaKeyStatus**, uint*, int>)@this->LpVtbl[8])(@this, pKeyStatusesArrayPtr, puSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeyStatuses(this ComPtr<IMFMediaKeySession2> thisVtbl, ref MFMediaKeyStatus* pKeyStatusesArray, ref uint puSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MFMediaKeyStatus** pKeyStatusesArrayPtr = &pKeyStatusesArray)
        {
            fixed (uint* puSizePtr = &puSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, MFMediaKeyStatus**, uint*, int>)@this->LpVtbl[8])(@this, pKeyStatusesArrayPtr, puSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IMFMediaKeySession2> thisVtbl, char* bstrSessionId, int* pfLoaded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionId, pfLoaded);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IMFMediaKeySession2> thisVtbl, char* bstrSessionId, ref int pfLoaded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfLoadedPtr = &pfLoaded)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionId, pfLoadedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IMFMediaKeySession2> thisVtbl, ref char bstrSessionId, int* pfLoaded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrSessionIdPtr = &bstrSessionId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionIdPtr, pfLoaded);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IMFMediaKeySession2> thisVtbl, ref char bstrSessionId, ref int pfLoaded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* bstrSessionIdPtr = &bstrSessionId)
        {
            fixed (int* pfLoadedPtr = &pfLoaded)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionIdPtr, pfLoadedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IMFMediaKeySession2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrSessionId, int* pfLoaded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrSessionIdPtr = (byte*) SilkMarshal.StringToPtr(bstrSessionId, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionIdPtr, pfLoaded);
        SilkMarshal.Free((nint)bstrSessionIdPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IMFMediaKeySession2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrSessionId, ref int pfLoaded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var bstrSessionIdPtr = (byte*) SilkMarshal.StringToPtr(bstrSessionId, NativeStringEncoding.BStr);
        fixed (int* pfLoadedPtr = &pfLoaded)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionIdPtr, pfLoadedPtr);
        }
        SilkMarshal.Free((nint)bstrSessionIdPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, char* initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataType, pbInitData, cb);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, char* initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbInitDataPtr = &pbInitData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataType, pbInitDataPtr, cb);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, char* initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataType, pbInitDataPtr, cb);
        SilkMarshal.Free((nint)pbInitDataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, ref char initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* initDataTypePtr = &initDataType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitData, cb);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, ref char initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* initDataTypePtr = &initDataType)
        {
            fixed (byte* pbInitDataPtr = &pbInitData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitDataPtr, cb);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, ref char initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* initDataTypePtr = &initDataType)
        {
        var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitDataPtr, cb);
        SilkMarshal.Free((nint)pbInitDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataTypePtr = (byte*) SilkMarshal.StringToPtr(initDataType, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitData, cb);
        SilkMarshal.Free((nint)initDataTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataTypePtr = (byte*) SilkMarshal.StringToPtr(initDataType, NativeStringEncoding.BStr);
        fixed (byte* pbInitDataPtr = &pbInitData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitDataPtr, cb);
        }
        SilkMarshal.Free((nint)initDataTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var initDataTypePtr = (byte*) SilkMarshal.StringToPtr(initDataType, NativeStringEncoding.BStr);
        var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitDataPtr, cb);
        SilkMarshal.Free((nint)pbInitDataPtr);
        SilkMarshal.Free((nint)initDataTypePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExpiration(this ComPtr<IMFMediaKeySession2> thisVtbl, double* dblExpiration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, double*, int>)@this->LpVtbl[11])(@this, dblExpiration);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetExpiration(this ComPtr<IMFMediaKeySession2> thisVtbl, ref double dblExpiration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* dblExpirationPtr = &dblExpiration)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, double*, int>)@this->LpVtbl[11])(@this, dblExpirationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Remove(this ComPtr<IMFMediaKeySession2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, int>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Shutdown(this ComPtr<IMFMediaKeySession2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, int>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaKeySession2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaKeySession2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaKeySession2> thisVtbl, ushort* code, Span<uint> systemCode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetError(code, ref systemCode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetError(this ComPtr<IMFMediaKeySession2> thisVtbl, Span<ushort> code, uint* systemCode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetError(ref code.GetPinnableReference(), systemCode);
    }

    /// <summary>To be documented.</summary>
    public static int GetError(this ComPtr<IMFMediaKeySession2> thisVtbl, Span<ushort> code, Span<uint> systemCode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetError(ref code.GetPinnableReference(), ref systemCode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetKeySystem(this ComPtr<IMFMediaKeySession2> thisVtbl, string[] keySystemSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var keySystem = (char**) SilkMarshal.StringArrayToPtr(keySystemSa);
        var ret = @this->GetKeySystem(keySystem);
        SilkMarshal.CopyPtrToStringArray((nint) keySystem, keySystemSa);
        SilkMarshal.Free((nint) keySystem);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSessionId(this ComPtr<IMFMediaKeySession2> thisVtbl, string[] sessionIdSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var sessionId = (char**) SilkMarshal.StringArrayToPtr(sessionIdSa);
        var ret = @this->GetSessionId(sessionId);
        SilkMarshal.CopyPtrToStringArray((nint) sessionId, sessionIdSa);
        SilkMarshal.Free((nint) sessionId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Update(this ComPtr<IMFMediaKeySession2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Update(in key.GetPinnableReference(), cb);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeyStatuses(this ComPtr<IMFMediaKeySession2> thisVtbl, MFMediaKeyStatus** pKeyStatusesArray, Span<uint> puSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKeyStatuses(pKeyStatusesArray, ref puSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKeyStatuses(this ComPtr<IMFMediaKeySession2> thisVtbl, ref MFMediaKeyStatus* pKeyStatusesArray, Span<uint> puSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKeyStatuses(ref pKeyStatusesArray, ref puSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IMFMediaKeySession2> thisVtbl, char* bstrSessionId, Span<int> pfLoaded)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(bstrSessionId, ref pfLoaded.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IMFMediaKeySession2> thisVtbl, Span<char> bstrSessionId, int* pfLoaded)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(ref bstrSessionId.GetPinnableReference(), pfLoaded);
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IMFMediaKeySession2> thisVtbl, Span<char> bstrSessionId, Span<int> pfLoaded)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(ref bstrSessionId.GetPinnableReference(), ref pfLoaded.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IMFMediaKeySession2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrSessionId, Span<int> pfLoaded)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(bstrSessionId, ref pfLoaded.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, char* initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GenerateRequest(initDataType, in pbInitData.GetPinnableReference(), cb);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, Span<char> initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GenerateRequest(ref initDataType.GetPinnableReference(), pbInitData, cb);
    }

    /// <summary>To be documented.</summary>
    public static int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, Span<char> initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GenerateRequest(ref initDataType.GetPinnableReference(), in pbInitData.GetPinnableReference(), cb);
    }

    /// <summary>To be documented.</summary>
    public static int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, Span<char> initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GenerateRequest(ref initDataType.GetPinnableReference(), pbInitData, cb);
    }

    /// <summary>To be documented.</summary>
    public static int GenerateRequest(this ComPtr<IMFMediaKeySession2> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pbInitData, uint cb)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GenerateRequest(initDataType, in pbInitData.GetPinnableReference(), cb);
    }

    /// <summary>To be documented.</summary>
    public static int GetExpiration(this ComPtr<IMFMediaKeySession2> thisVtbl, Span<double> dblExpiration)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetExpiration(ref dblExpiration.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaKeySession2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
