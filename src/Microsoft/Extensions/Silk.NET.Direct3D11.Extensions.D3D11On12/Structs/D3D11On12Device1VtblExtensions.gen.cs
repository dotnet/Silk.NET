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

namespace Silk.NET.Direct3D11.Extensions.D3D11On12;

public unsafe static class D3D11On12Device1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11On12Device1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11On12Device1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11On12Device1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11On12Device1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11On12Device1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11On12Device1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11, InState, OutState, riid, ppResource11);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppResource11Ptr = &ppResource11)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11, InState, OutState, riid, ppResource11Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11, InState, OutState, riidPtr, ppResource11);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppResource11Ptr = &ppResource11)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11, InState, OutState, riidPtr, ppResource11Ptr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11Ptr, InState, OutState, riid, ppResource11);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
        {
            fixed (void** ppResource11Ptr = &ppResource11)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11Ptr, InState, OutState, riid, ppResource11Ptr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11Ptr, InState, OutState, riidPtr, ppResource11);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppResource11Ptr = &ppResource11)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11Ptr, InState, OutState, riidPtr, ppResource11Ptr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11, InState, OutState, riid, ppResource11);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
        {
            fixed (void** ppResource11Ptr = &ppResource11)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11, InState, OutState, riid, ppResource11Ptr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11, InState, OutState, riidPtr, ppResource11);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppResource11Ptr = &ppResource11)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11, InState, OutState, riidPtr, ppResource11Ptr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
        {
            fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11Ptr, InState, OutState, riid, ppResource11);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
        {
            fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
            {
                fixed (void** ppResource11Ptr = &ppResource11)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11Ptr, InState, OutState, riid, ppResource11Ptr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
        {
            fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11Ptr, InState, OutState, riidPtr, ppResource11);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
        {
            fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppResource11Ptr = &ppResource11)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11Ptr, InState, OutState, riidPtr, ppResource11Ptr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseWrappedResources(this ComPtr<ID3D11On12Device1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Resource** ppResources, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, ID3D11Resource**, uint, void>)@this->LpVtbl[4])(@this, ppResources, NumResources);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseWrappedResources(this ComPtr<ID3D11On12Device1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Resource* ppResources, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource** ppResourcesPtr = &ppResources)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, ID3D11Resource**, uint, void>)@this->LpVtbl[4])(@this, ppResourcesPtr, NumResources);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AcquireWrappedResources(this ComPtr<ID3D11On12Device1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Resource** ppResources, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, ID3D11Resource**, uint, void>)@this->LpVtbl[5])(@this, ppResources, NumResources);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AcquireWrappedResources(this ComPtr<ID3D11On12Device1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ID3D11Resource* ppResources, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D11Resource** ppResourcesPtr = &ppResources)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, ID3D11Resource**, uint, void>)@this->LpVtbl[5])(@this, ppResourcesPtr, NumResources);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetD3D12Device(this ComPtr<ID3D11On12Device1> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetD3D12Device(this ComPtr<ID3D11On12Device1> thisVtbl, Guid* riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetD3D12Device(this ComPtr<ID3D11On12Device1> thisVtbl, ref Guid riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetD3D12Device(this ComPtr<ID3D11On12Device1> thisVtbl, ref Guid riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource<TI0, TI1>(this ComPtr<ID3D11On12Device1> thisVtbl, ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, out ComPtr<TI1> ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppResource11 = default;
        return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, pFlags11, InState, OutState, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppResource11.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, pFlags11, InState, OutState, riid, ref ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Span<Guid> riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(pResource12, pFlags11, InState, OutState, ref riid.GetPinnableReference(), ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, pFlags11, InState, OutState, ref riid, ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Span<Guid> riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(pResource12, pFlags11, InState, OutState, ref riid.GetPinnableReference(), ref ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, pFlags11, InState, OutState, ref riid, ref ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceFlags> pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(pResource12, in pFlags11.GetPinnableReference(), InState, OutState, riid, ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static int CreateWrappedResource<TI0, TI1>(this ComPtr<ID3D11On12Device1> thisVtbl, ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, out ComPtr<TI1> ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppResource11 = default;
        return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, in pFlags11, InState, OutState, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppResource11.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceFlags> pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(pResource12, in pFlags11.GetPinnableReference(), InState, OutState, riid, ref ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, in pFlags11, InState, OutState, riid, ref ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceFlags> pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Span<Guid> riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(pResource12, in pFlags11.GetPinnableReference(), InState, OutState, ref riid.GetPinnableReference(), ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, in pFlags11, InState, OutState, ref riid, ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceFlags> pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Span<Guid> riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(pResource12, in pFlags11.GetPinnableReference(), InState, OutState, ref riid.GetPinnableReference(), ref ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, in pFlags11, InState, OutState, ref riid, ref ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(ref pResource12.GetPinnableReference(), pFlags11, InState, OutState, riid, ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, out ComPtr<TI0> ppResource11) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppResource11 = default;
        return @this->CreateWrappedResource(ref pResource12, pFlags11, InState, OutState, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppResource11.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(ref pResource12.GetPinnableReference(), pFlags11, InState, OutState, riid, ref ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Span<Guid> riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(ref pResource12.GetPinnableReference(), pFlags11, InState, OutState, ref riid.GetPinnableReference(), ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Span<Guid> riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(ref pResource12.GetPinnableReference(), pFlags11, InState, OutState, ref riid.GetPinnableReference(), ref ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceFlags> pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(ref pResource12.GetPinnableReference(), in pFlags11.GetPinnableReference(), InState, OutState, riid, ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static int CreateWrappedResource<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, out ComPtr<TI0> ppResource11) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppResource11 = default;
        return @this->CreateWrappedResource(ref pResource12, in pFlags11, InState, OutState, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppResource11.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceFlags> pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(ref pResource12.GetPinnableReference(), in pFlags11.GetPinnableReference(), InState, OutState, riid, ref ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceFlags> pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Span<Guid> riid, void** ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(ref pResource12.GetPinnableReference(), in pFlags11.GetPinnableReference(), InState, OutState, ref riid.GetPinnableReference(), ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateWrappedResource(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceFlags> pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Span<Guid> riid, ref void* ppResource11)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateWrappedResource(ref pResource12.GetPinnableReference(), in pFlags11.GetPinnableReference(), InState, OutState, ref riid.GetPinnableReference(), ref ppResource11);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseWrappedResources<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppResources, uint NumResources) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ReleaseWrappedResources((ID3D11Resource**) ppResources.GetAddressOf(), NumResources);
    }

    /// <summary>To be documented.</summary>
    public static void AcquireWrappedResources<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppResources, uint NumResources) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->AcquireWrappedResources((ID3D11Resource**) ppResources.GetAddressOf(), NumResources);
    }

    /// <summary>To be documented.</summary>
    public static int GetD3D12Device<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetD3D12Device(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetD3D12Device(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Guid> riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetD3D12Device(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetD3D12Device(this ComPtr<ID3D11On12Device1> thisVtbl, Span<Guid> riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetD3D12Device(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI1> CreateWrappedResource<TI0, TI1>(this ComPtr<ID3D11On12Device1> thisVtbl, ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateWrappedResource(pResource12, pFlags11, InState, OutState, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateWrappedResource<TI0, TI1>(this ComPtr<ID3D11On12Device1> thisVtbl, ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateWrappedResource(pResource12, in pFlags11, InState, OutState, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateWrappedResource<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateWrappedResource(ref pResource12, pFlags11, InState, OutState, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateWrappedResource<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl, ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateWrappedResource(ref pResource12, in pFlags11, InState, OutState, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetD3D12Device<TI0>(this ComPtr<ID3D11On12Device1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetD3D12Device(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
