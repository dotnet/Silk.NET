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

namespace Silk.NET.Direct3D9;

public unsafe static class Direct3DIndexBuffer9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3DIndexBuffer9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DIndexBuffer9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, IDirect3DDevice9** ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref IDirect3DDevice9* ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint SizeOfData, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref Guid refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint SizeOfData, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref Guid refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* refguid, void* pData, uint* pSizeOfData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* refguid, void* pData, ref uint pSizeOfData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pSizeOfDataPtr = &pSizeOfData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref Guid refguid, void* pData, uint* pSizeOfData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref Guid refguid, void* pData, ref uint pSizeOfData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FreePrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* refguid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, int>)@this->LpVtbl[6])(@this, refguid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FreePrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref Guid refguid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Guid*, int>)@this->LpVtbl[6])(@this, refguidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint SetPriority(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, uint PriorityNew)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, uint, uint>)@this->LpVtbl[7])(@this, PriorityNew);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPriority(this ComPtr<IDirect3DIndexBuffer9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, uint>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PreLoad(this ComPtr<IDirect3DIndexBuffer9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, void>)@this->LpVtbl[9])(@this);
    }

    /// <summary>To be documented.</summary>
    public static Resourcetype GetType(this ComPtr<IDirect3DIndexBuffer9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Resourcetype ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, Resourcetype>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Lock(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, uint OffsetToLock, uint SizeToLock, void** ppbData, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, uint, uint, void**, uint, int>)@this->LpVtbl[11])(@this, OffsetToLock, SizeToLock, ppbData, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Lock(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, uint OffsetToLock, uint SizeToLock, ref void* ppbData, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppbDataPtr = &ppbData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, uint, uint, void**, uint, int>)@this->LpVtbl[11])(@this, OffsetToLock, SizeToLock, ppbDataPtr, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Unlock(this ComPtr<IDirect3DIndexBuffer9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, int>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, IndexbufferDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, IndexbufferDesc*, int>)@this->LpVtbl[13])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref IndexbufferDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IndexbufferDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DIndexBuffer9*, IndexbufferDesc*, int>)@this->LpVtbl[13])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDevice((IDirect3DDevice9**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint SizeOfData, uint Flags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(refguid, in pData.GetPinnableReference(), SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Span<Guid> refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint SizeOfData, uint Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref refguid.GetPinnableReference(), pData, SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Span<Guid> refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint SizeOfData, uint Flags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref refguid.GetPinnableReference(), in pData.GetPinnableReference(), SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* refguid, void* pData, Span<uint> pSizeOfData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(refguid, pData, ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* refguid, Span<T0> pData, uint* pSizeOfData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(refguid, ref pData.GetPinnableReference(), pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Guid* refguid, Span<T0> pData, Span<uint> pSizeOfData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(refguid, ref pData.GetPinnableReference(), ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Span<Guid> refguid, void* pData, uint* pSizeOfData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), pData, pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Span<Guid> refguid, void* pData, Span<uint> pSizeOfData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), pData, ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Span<Guid> refguid, Span<T0> pData, uint* pSizeOfData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), ref pData.GetPinnableReference(), pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Span<Guid> refguid, Span<T0> pData, Span<uint> pSizeOfData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), ref pData.GetPinnableReference(), ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FreePrivateData(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Span<Guid> refguid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FreePrivateData(ref refguid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<IDirect3DIndexBuffer9> thisVtbl, Span<IndexbufferDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDirect3DIndexBuffer9> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
