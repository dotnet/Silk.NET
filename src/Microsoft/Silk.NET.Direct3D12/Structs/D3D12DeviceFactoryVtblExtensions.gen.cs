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

public unsafe static class D3D12DeviceFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12DeviceFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12DeviceFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromGlobalState(this ComPtr<ID3D12DeviceFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, int>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ApplyToGlobalState(this ComPtr<ID3D12DeviceFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFlags(this ComPtr<ID3D12DeviceFactory> thisVtbl, DeviceFactoryFlags flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, DeviceFactoryFlags, int>)@this->LpVtbl[5])(@this, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static DeviceFactoryFlags GetFlags(this ComPtr<ID3D12DeviceFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        DeviceFactoryFlags ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, DeviceFactoryFlags>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Guid* clsid, Guid* iid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsid, iid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Guid* clsid, Guid* iid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsid, iid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Guid* clsid, ref Guid iid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsid, iidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Guid* clsid, ref Guid iid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsid, iidPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Guid clsid, Guid* iid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsidPtr, iid, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Guid clsid, Guid* iid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsidPtr, iid, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Guid clsid, ref Guid iid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsidPtr, iidPtr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Guid clsid, ref Guid iid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* clsidPtr = &clsid)
        {
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsidPtr, iidPtr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDs, pConfigurationStructs, pConfigurationStructSizes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, void* pConfigurationStructs, ref uint pConfigurationStructSizes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pConfigurationStructSizesPtr = &pConfigurationStructSizes)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDs, pConfigurationStructs, pConfigurationStructSizesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures<T0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, ref T0 pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pConfigurationStructsPtr = &pConfigurationStructs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDs, pConfigurationStructsPtr, pConfigurationStructSizes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures<T0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, ref T0 pConfigurationStructs, ref uint pConfigurationStructSizes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pConfigurationStructsPtr = &pConfigurationStructs)
        {
            fixed (uint* pConfigurationStructSizesPtr = &pConfigurationStructSizes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDs, pConfigurationStructsPtr, pConfigurationStructSizesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pIIDsPtr = &pIIDs)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDsPtr, pConfigurationStructs, pConfigurationStructSizes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, void* pConfigurationStructs, ref uint pConfigurationStructSizes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pIIDsPtr = &pIIDs)
        {
            fixed (uint* pConfigurationStructSizesPtr = &pConfigurationStructSizes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDsPtr, pConfigurationStructs, pConfigurationStructSizesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures<T0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, ref T0 pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pIIDsPtr = &pIIDs)
        {
            fixed (void* pConfigurationStructsPtr = &pConfigurationStructs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDsPtr, pConfigurationStructsPtr, pConfigurationStructSizes);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnableExperimentalFeatures<T0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, ref T0 pConfigurationStructs, ref uint pConfigurationStructSizes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pIIDsPtr = &pIIDs)
        {
            fixed (void* pConfigurationStructsPtr = &pConfigurationStructs)
            {
                fixed (uint* pConfigurationStructSizesPtr = &pConfigurationStructSizes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDsPtr, pConfigurationStructsPtr, pConfigurationStructSizesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapter, FeatureLevel, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapter, FeatureLevel, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapter, FeatureLevel, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapter, FeatureLevel, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* adapterPtr = &adapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapterPtr, FeatureLevel, riid, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* adapterPtr = &adapter)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapterPtr, FeatureLevel, riid, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* adapterPtr = &adapter)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapterPtr, FeatureLevel, riidPtr, ppvDevice);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* adapterPtr = &adapter)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapterPtr, FeatureLevel, riidPtr, ppvDevicePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface<TI0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, Guid* clsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetConfigurationInterface(clsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Guid* clsid, Span<Guid> iid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetConfigurationInterface(clsid, ref iid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Guid* clsid, Span<Guid> iid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetConfigurationInterface(clsid, ref iid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Span<Guid> clsid, Guid* iid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetConfigurationInterface(ref clsid.GetPinnableReference(), iid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static int GetConfigurationInterface<TI0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Guid clsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->GetConfigurationInterface(ref clsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Span<Guid> clsid, Guid* iid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetConfigurationInterface(ref clsid.GetPinnableReference(), iid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Span<Guid> clsid, Span<Guid> iid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetConfigurationInterface(ref clsid.GetPinnableReference(), ref iid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetConfigurationInterface(this ComPtr<ID3D12DeviceFactory> thisVtbl, Span<Guid> clsid, Span<Guid> iid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetConfigurationInterface(ref clsid.GetPinnableReference(), ref iid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, void* pConfigurationStructs, Span<uint> pConfigurationStructSizes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnableExperimentalFeatures(NumFeatures, pIIDs, pConfigurationStructs, ref pConfigurationStructSizes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures<T0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, Span<T0> pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnableExperimentalFeatures(NumFeatures, pIIDs, ref pConfigurationStructs.GetPinnableReference(), pConfigurationStructSizes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures<T0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, Span<T0> pConfigurationStructs, Span<uint> pConfigurationStructSizes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnableExperimentalFeatures(NumFeatures, pIIDs, ref pConfigurationStructs.GetPinnableReference(), ref pConfigurationStructSizes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnableExperimentalFeatures(NumFeatures, in pIIDs.GetPinnableReference(), pConfigurationStructs, pConfigurationStructSizes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pIIDs, void* pConfigurationStructs, Span<uint> pConfigurationStructSizes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnableExperimentalFeatures(NumFeatures, in pIIDs.GetPinnableReference(), pConfigurationStructs, ref pConfigurationStructSizes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableExperimentalFeatures<T0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pIIDs, Span<T0> pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnableExperimentalFeatures(NumFeatures, in pIIDs.GetPinnableReference(), ref pConfigurationStructs.GetPinnableReference(), pConfigurationStructSizes);
    }

    /// <summary>To be documented.</summary>
    public static int EnableExperimentalFeatures<T0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Guid> pIIDs, Span<T0> pConfigurationStructs, Span<uint> pConfigurationStructSizes) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnableExperimentalFeatures(NumFeatures, in pIIDs.GetPinnableReference(), ref pConfigurationStructs.GetPinnableReference(), ref pConfigurationStructSizes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateDevice<TI0, TI1>(this ComPtr<ID3D12DeviceFactory> thisVtbl, ComPtr<TI0> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, out ComPtr<TI1> ppvDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDevice = default;
        return @this->CreateDevice((Silk.NET.Core.Native.IUnknown*) adapter.Handle, FeatureLevel, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TI0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, ComPtr<TI0> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, ref void* ppvDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDevice((Silk.NET.Core.Native.IUnknown*) adapter.Handle, FeatureLevel, riid, ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Span<Guid> riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(adapter, FeatureLevel, ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TI0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, ComPtr<TI0> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, void** ppvDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDevice((Silk.NET.Core.Native.IUnknown*) adapter.Handle, FeatureLevel, ref riid, ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, Silk.NET.Core.Native.IUnknown* adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Span<Guid> riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(adapter, FeatureLevel, ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TI0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, ComPtr<TI0> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, ref void* ppvDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDevice((Silk.NET.Core.Native.IUnknown*) adapter.Handle, FeatureLevel, ref riid, ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(ref adapter.GetPinnableReference(), FeatureLevel, riid, ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDevice<TI0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDevice = default;
        return @this->CreateDevice(ref adapter, FeatureLevel, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(ref adapter.GetPinnableReference(), FeatureLevel, riid, ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Span<Guid> riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(ref adapter.GetPinnableReference(), FeatureLevel, ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<ID3D12DeviceFactory> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Span<Guid> riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(ref adapter.GetPinnableReference(), FeatureLevel, ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12DeviceFactory> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetConfigurationInterface<TI0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, Guid* clsid) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetConfigurationInterface(clsid, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetConfigurationInterface<TI0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Guid clsid) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetConfigurationInterface(ref clsid, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> CreateDevice<TI0, TI1>(this ComPtr<ID3D12DeviceFactory> thisVtbl, ComPtr<TI0> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDevice(adapter, FeatureLevel, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateDevice<TI0>(this ComPtr<ID3D12DeviceFactory> thisVtbl, ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateDevice(ref adapter, FeatureLevel, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
