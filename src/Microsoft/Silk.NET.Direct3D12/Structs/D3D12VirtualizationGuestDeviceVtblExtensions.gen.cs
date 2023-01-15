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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12VirtualizationGuestDeviceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ShareWithHost(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ID3D12DeviceChild* pObject, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12DeviceChild*, void**, int>)@this->LpVtbl[3])(@this, pObject, pHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ShareWithHost(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ID3D12DeviceChild* pObject, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pHandlePtr = &pHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12DeviceChild*, void**, int>)@this->LpVtbl[3])(@this, pObject, pHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ShareWithHost(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ref ID3D12DeviceChild pObject, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12DeviceChild*, void**, int>)@this->LpVtbl[3])(@this, pObjectPtr, pHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ShareWithHost(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ref ID3D12DeviceChild pObject, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
        {
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12DeviceChild*, void**, int>)@this->LpVtbl[3])(@this, pObjectPtr, pHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFenceFd(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ID3D12Fence* pFence, ulong FenceValue, int* pFenceFd)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12Fence*, ulong, int*, int>)@this->LpVtbl[4])(@this, pFence, FenceValue, pFenceFd);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFenceFd(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ID3D12Fence* pFence, ulong FenceValue, ref int pFenceFd)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pFenceFdPtr = &pFenceFd)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12Fence*, ulong, int*, int>)@this->LpVtbl[4])(@this, pFence, FenceValue, pFenceFdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFenceFd(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ref ID3D12Fence pFence, ulong FenceValue, int* pFenceFd)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Fence* pFencePtr = &pFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12Fence*, ulong, int*, int>)@this->LpVtbl[4])(@this, pFencePtr, FenceValue, pFenceFd);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CreateFenceFd(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ref ID3D12Fence pFence, ulong FenceValue, ref int pFenceFd)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Fence* pFencePtr = &pFence)
        {
            fixed (int* pFenceFdPtr = &pFenceFd)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VirtualizationGuestDevice*, ID3D12Fence*, ulong, int*, int>)@this->LpVtbl[4])(@this, pFencePtr, FenceValue, pFenceFdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ShareWithHost<TI0>(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ComPtr<TI0> pObject, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ShareWithHost((ID3D12DeviceChild*) pObject.Handle, pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ShareWithHost<TI0>(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ComPtr<TI0> pObject, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ShareWithHost((ID3D12DeviceChild*) pObject.Handle, ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ShareWithHost(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, Span<ID3D12DeviceChild> pObject, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ShareWithHost(ref pObject.GetPinnableReference(), pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ShareWithHost(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, Span<ID3D12DeviceChild> pObject, ref void* pHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ShareWithHost(ref pObject.GetPinnableReference(), ref pHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFenceFd<TI0>(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ComPtr<TI0> pFence, ulong FenceValue, int* pFenceFd) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFenceFd((ID3D12Fence*) pFence.Handle, FenceValue, pFenceFd);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFenceFd(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ID3D12Fence* pFence, ulong FenceValue, Span<int> pFenceFd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFenceFd(pFence, FenceValue, ref pFenceFd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFenceFd<TI0>(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, ComPtr<TI0> pFence, ulong FenceValue, ref int pFenceFd) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFenceFd((ID3D12Fence*) pFence.Handle, FenceValue, ref pFenceFd);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFenceFd(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, Span<ID3D12Fence> pFence, ulong FenceValue, int* pFenceFd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFenceFd(ref pFence.GetPinnableReference(), FenceValue, pFenceFd);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFenceFd(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl, Span<ID3D12Fence> pFence, ulong FenceValue, Span<int> pFenceFd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFenceFd(ref pFence.GetPinnableReference(), FenceValue, ref pFenceFd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12VirtualizationGuestDevice> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
