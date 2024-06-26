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

namespace Silk.NET.DXGI;

public unsafe static class DXGIFactory3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactory3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactory3> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGIFactory3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGIFactory3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIFactory3> thisVtbl, Guid* riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIFactory3> thisVtbl, Guid* riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters(this ComPtr<IDXGIFactory3> thisVtbl, uint Adapter, Silk.NET.DXGI.IDXGIAdapter** ppAdapter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters(this ComPtr<IDXGIFactory3> thisVtbl, uint Adapter, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MakeWindowAssociation(this ComPtr<IDXGIFactory3> thisVtbl, nint WindowHandle, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, nint, uint, int>)@this->LpVtbl[8])(@this, WindowHandle, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWindowAssociation(this ComPtr<IDXGIFactory3> thisVtbl, nint* pWindowHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWindowAssociation(this ComPtr<IDXGIFactory3> thisVtbl, ref nint pWindowHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nint* pWindowHandlePtr = &pWindowHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc* pDescPtr = &pDesc)
        {
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSoftwareAdapter(this ComPtr<IDXGIFactory3> thisVtbl, nint Module, Silk.NET.DXGI.IDXGIAdapter** ppAdapter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSoftwareAdapter(this ComPtr<IDXGIFactory3> thisVtbl, nint Module, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters1(this ComPtr<IDXGIFactory3> thisVtbl, uint Adapter, IDXGIAdapter1** ppAdapter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, uint, IDXGIAdapter1**, int>)@this->LpVtbl[12])(@this, Adapter, ppAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters1(this ComPtr<IDXGIFactory3> thisVtbl, uint Adapter, ref IDXGIAdapter1* ppAdapter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIAdapter1** ppAdapterPtr = &ppAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, uint, IDXGIAdapter1**, int>)@this->LpVtbl[12])(@this, Adapter, ppAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsCurrent(this ComPtr<IDXGIFactory3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Bool32>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsWindowedStereoEnabled(this ComPtr<IDXGIFactory3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Bool32>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid(this ComPtr<IDXGIFactory3> thisVtbl, void* hResource, Luid* pLuid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResource, pLuid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid(this ComPtr<IDXGIFactory3> thisVtbl, void* hResource, ref Luid pLuid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Luid* pLuidPtr = &pLuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResource, pLuidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid<T0>(this ComPtr<IDXGIFactory3> thisVtbl, ref T0 hResource, Luid* pLuid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hResourcePtr = &hResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResourcePtr, pLuid);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSharedResourceAdapterLuid<T0>(this ComPtr<IDXGIFactory3> thisVtbl, ref T0 hResource, ref Luid pLuid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hResourcePtr = &hResource)
        {
            fixed (Luid* pLuidPtr = &pLuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResourcePtr, pLuidPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusWindow(this ComPtr<IDXGIFactory3> thisVtbl, nint WindowHandle, uint wMsg, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, nint, uint, uint*, int>)@this->LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterStereoStatusWindow(this ComPtr<IDXGIFactory3> thisVtbl, nint WindowHandle, uint wMsg, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, nint, uint, uint*, int>)@this->LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent(this ComPtr<IDXGIFactory3> thisVtbl, void* hEvent, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent(this ComPtr<IDXGIFactory3> thisVtbl, void* hEvent, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEvent, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent<T0>(this ComPtr<IDXGIFactory3> thisVtbl, ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEventPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterStereoStatusEvent<T0>(this ComPtr<IDXGIFactory3> thisVtbl, ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEventPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterStereoStatus(this ComPtr<IDXGIFactory3> thisVtbl, uint dwCookie)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, uint, void>)@this->LpVtbl[20])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusWindow(this ComPtr<IDXGIFactory3> thisVtbl, nint WindowHandle, uint wMsg, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, nint, uint, uint*, int>)@this->LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterOcclusionStatusWindow(this ComPtr<IDXGIFactory3> thisVtbl, nint WindowHandle, uint wMsg, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, nint, uint, uint*, int>)@this->LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent(this ComPtr<IDXGIFactory3> thisVtbl, void* hEvent, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent(this ComPtr<IDXGIFactory3> thisVtbl, void* hEvent, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEvent, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent<T0>(this ComPtr<IDXGIFactory3> thisVtbl, ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEventPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterOcclusionStatusEvent<T0>(this ComPtr<IDXGIFactory3> thisVtbl, ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEventPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterOcclusionStatus(this ComPtr<IDXGIFactory3> thisVtbl, uint dwCookie)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, uint, void>)@this->LpVtbl[23])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetCreationFlags(this ComPtr<IDXGIFactory3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory3*, uint>)@this->LpVtbl[25])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIFactory3> thisVtbl, Span<Guid> riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static int EnumAdapters<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, uint Adapter, ref ComPtr<TI0> ppAdapter) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumAdapters(Adapter, (Silk.NET.DXGI.IDXGIAdapter**) ppAdapter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetWindowAssociation(this ComPtr<IDXGIFactory3> thisVtbl, Span<nint> pWindowHandle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWindowAssociation(ref pWindowHandle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, SwapChainDesc* pDesc, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<SwapChainDesc> pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChain(pDevice, ref pDesc.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChain<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ref SwapChainDesc pDesc, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<SwapChainDesc> pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChain(pDevice, ref pDesc.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChain((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pDesc, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), pDesc, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChain(ref pDevice, pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), pDesc, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<SwapChainDesc> pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), ref pDesc.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChain<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChain(ref pDevice, ref pDesc, (Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<SwapChainDesc> pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSoftwareAdapter<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, nint Module, ref ComPtr<TI0> ppAdapter) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGIAdapter>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSoftwareAdapter(Module, (Silk.NET.DXGI.IDXGIAdapter**) ppAdapter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int EnumAdapters1<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, uint Adapter, ref ComPtr<TI0> ppAdapter) where TI0 : unmanaged, IComVtbl<IDXGIAdapter1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumAdapters1(Adapter, (IDXGIAdapter1**) ppAdapter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, in pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, in pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, in pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, in pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, in pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, pDesc, in pFullscreenDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, in pDesc.GetPinnableReference(), pFullscreenDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, in pDesc.GetPinnableReference(), pFullscreenDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, in pDesc.GetPinnableReference(), pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, in pDesc.GetPinnableReference(), pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, pFullscreenDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, in pDesc.GetPinnableReference(), in pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForHwnd<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, in pDesc.GetPinnableReference(), in pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, in pDesc.GetPinnableReference(), in pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, in pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, in pDesc.GetPinnableReference(), in pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hWnd, in pDesc, in pFullscreenDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, in pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, in pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, in pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, in pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, in pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, in pDesc.GetPinnableReference(), pFullscreenDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, in pDesc.GetPinnableReference(), pFullscreenDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, in pDesc.GetPinnableReference(), pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, in pDesc.GetPinnableReference(), pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, in pDesc.GetPinnableReference(), in pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForHwnd<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, in pDesc.GetPinnableReference(), in pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, in pFullscreenDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, in pDesc.GetPinnableReference(), in pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForHwnd<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, in pDesc, in pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, in pDesc.GetPinnableReference(), in pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2, TI3>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI2> pRestrictToOutput, ref ComPtr<TI3> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI3>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI2> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, in pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCoreWindow<TI0, TI1, TI2, TI3>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI2> pRestrictToOutput, ref ComPtr<TI3> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI3>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, in pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI2> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ComPtr<TI1> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), pDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), in pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), in pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref pWindow, in pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, pDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, in pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCoreWindow<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, in pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ComPtr<TI0> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, (Silk.NET.Core.Native.IUnknown*) pWindow.Handle, in pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), pDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), in pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCoreWindow<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), in pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCoreWindow<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid(this ComPtr<IDXGIFactory3> thisVtbl, void* hResource, Span<Luid> pLuid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSharedResourceAdapterLuid(hResource, ref pLuid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Span<T0> hResource, Luid* pLuid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSharedResourceAdapterLuid(ref hResource.GetPinnableReference(), pLuid);
    }

    /// <summary>To be documented.</summary>
    public static int GetSharedResourceAdapterLuid<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Span<T0> hResource, Span<Luid> pLuid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSharedResourceAdapterLuid(ref hResource.GetPinnableReference(), ref pLuid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RegisterStereoStatusWindow(this ComPtr<IDXGIFactory3> thisVtbl, nint WindowHandle, uint wMsg, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterStereoStatusWindow(WindowHandle, wMsg, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent(this ComPtr<IDXGIFactory3> thisVtbl, void* hEvent, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterStereoStatusEvent(hEvent, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Span<T0> hEvent, uint* pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterStereoStatusEvent(ref hEvent.GetPinnableReference(), pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterStereoStatusEvent<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Span<T0> hEvent, Span<uint> pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterStereoStatusEvent(ref hEvent.GetPinnableReference(), ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RegisterOcclusionStatusWindow(this ComPtr<IDXGIFactory3> thisVtbl, nint WindowHandle, uint wMsg, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterOcclusionStatusWindow(WindowHandle, wMsg, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent(this ComPtr<IDXGIFactory3> thisVtbl, void* hEvent, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterOcclusionStatusEvent(hEvent, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Span<T0> hEvent, uint* pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterOcclusionStatusEvent(ref hEvent.GetPinnableReference(), pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterOcclusionStatusEvent<T0>(this ComPtr<IDXGIFactory3> thisVtbl, Span<T0> hEvent, Span<uint> pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterOcclusionStatusEvent(ref hEvent.GetPinnableReference(), ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, in pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForComposition<TI0, TI1, TI2>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, in pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForComposition<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ComPtr<TI0> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, in pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(ref pDevice, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), pDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(ref pDevice, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(ref pDevice, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), in pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForComposition<TI0, TI1>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(ref pDevice, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), in pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(ref pDevice, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForComposition<TI0>(this ComPtr<IDXGIFactory3> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(ref pDevice, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition(this ComPtr<IDXGIFactory3> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDXGIFactory3> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetParent<TI0>(this ComPtr<IDXGIFactory3> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
