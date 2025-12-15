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

public unsafe static class D3D12DSRDeviceFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ID3D12Device* pD3D12Device, uint NodeMask, Guid* riid, void** ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12Device, NodeMask, riid, ppvDSRDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ID3D12Device* pD3D12Device, uint NodeMask, Guid* riid, ref void* ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDSRDevicePtr = &ppvDSRDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12Device, NodeMask, riid, ppvDSRDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ID3D12Device* pD3D12Device, uint NodeMask, ref Guid riid, void** ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12Device, NodeMask, riidPtr, ppvDSRDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ID3D12Device* pD3D12Device, uint NodeMask, ref Guid riid, ref void* ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDSRDevicePtr = &ppvDSRDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12Device, NodeMask, riidPtr, ppvDSRDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ref ID3D12Device pD3D12Device, uint NodeMask, Guid* riid, void** ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Device* pD3D12DevicePtr = &pD3D12Device)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12DevicePtr, NodeMask, riid, ppvDSRDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ref ID3D12Device pD3D12Device, uint NodeMask, Guid* riid, ref void* ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Device* pD3D12DevicePtr = &pD3D12Device)
        {
            fixed (void** ppvDSRDevicePtr = &ppvDSRDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12DevicePtr, NodeMask, riid, ppvDSRDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ref ID3D12Device pD3D12Device, uint NodeMask, ref Guid riid, void** ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Device* pD3D12DevicePtr = &pD3D12Device)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12DevicePtr, NodeMask, riidPtr, ppvDSRDevice);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ref ID3D12Device pD3D12Device, uint NodeMask, ref Guid riid, ref void* ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Device* pD3D12DevicePtr = &pD3D12Device)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDSRDevicePtr = &ppvDSRDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DSRDeviceFactory*, ID3D12Device*, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, pD3D12DevicePtr, NodeMask, riidPtr, ppvDSRDevicePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDSRDevice<TI0, TI1>(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ComPtr<TI0> pD3D12Device, uint NodeMask, out ComPtr<TI1> ppvDSRDevice) where TI0 : unmanaged, IComVtbl<ID3D12Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDSRDevice = default;
        return @this->CreateDSRDevice((ID3D12Device*) pD3D12Device.Handle, NodeMask, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvDSRDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice<TI0>(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ComPtr<TI0> pD3D12Device, uint NodeMask, Guid* riid, ref void* ppvDSRDevice) where TI0 : unmanaged, IComVtbl<ID3D12Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDSRDevice((ID3D12Device*) pD3D12Device.Handle, NodeMask, riid, ref ppvDSRDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ID3D12Device* pD3D12Device, uint NodeMask, Span<Guid> riid, void** ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDSRDevice(pD3D12Device, NodeMask, ref riid.GetPinnableReference(), ppvDSRDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice<TI0>(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ComPtr<TI0> pD3D12Device, uint NodeMask, ref Guid riid, void** ppvDSRDevice) where TI0 : unmanaged, IComVtbl<ID3D12Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDSRDevice((ID3D12Device*) pD3D12Device.Handle, NodeMask, ref riid, ppvDSRDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ID3D12Device* pD3D12Device, uint NodeMask, Span<Guid> riid, ref void* ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDSRDevice(pD3D12Device, NodeMask, ref riid.GetPinnableReference(), ref ppvDSRDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice<TI0>(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ComPtr<TI0> pD3D12Device, uint NodeMask, ref Guid riid, ref void* ppvDSRDevice) where TI0 : unmanaged, IComVtbl<ID3D12Device>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDSRDevice((ID3D12Device*) pD3D12Device.Handle, NodeMask, ref riid, ref ppvDSRDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, Span<ID3D12Device> pD3D12Device, uint NodeMask, Guid* riid, void** ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDSRDevice(ref pD3D12Device.GetPinnableReference(), NodeMask, riid, ppvDSRDevice);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDSRDevice<TI0>(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ref ID3D12Device pD3D12Device, uint NodeMask, out ComPtr<TI0> ppvDSRDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDSRDevice = default;
        return @this->CreateDSRDevice(ref pD3D12Device, NodeMask, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDSRDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, Span<ID3D12Device> pD3D12Device, uint NodeMask, Guid* riid, ref void* ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDSRDevice(ref pD3D12Device.GetPinnableReference(), NodeMask, riid, ref ppvDSRDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, Span<ID3D12Device> pD3D12Device, uint NodeMask, Span<Guid> riid, void** ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDSRDevice(ref pD3D12Device.GetPinnableReference(), NodeMask, ref riid.GetPinnableReference(), ppvDSRDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDSRDevice(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, Span<ID3D12Device> pD3D12Device, uint NodeMask, Span<Guid> riid, ref void* ppvDSRDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDSRDevice(ref pD3D12Device.GetPinnableReference(), NodeMask, ref riid.GetPinnableReference(), ref ppvDSRDevice);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateDSRDevice<TI0, TI1>(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ComPtr<TI0> pD3D12Device, uint NodeMask) where TI0 : unmanaged, IComVtbl<ID3D12Device>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDSRDevice(pD3D12Device, NodeMask, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateDSRDevice<TI0>(this ComPtr<ID3D12DSRDeviceFactory> thisVtbl, ref ID3D12Device pD3D12Device, uint NodeMask) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDSRDevice(ref pD3D12Device, NodeMask, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
