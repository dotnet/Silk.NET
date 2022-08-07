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

public unsafe static class DXGIFactory7VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters<TThis>(this TThis thisVtbl, uint Adapter, Silk.NET.DXGI.IDXGIAdapter** ppAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters<TThis>(this TThis thisVtbl, uint Adapter, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MakeWindowAssociation<TThis>(this TThis thisVtbl, nint WindowHandle, uint Flags) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint, uint, int>)@this->LpVtbl[8])(@this, WindowHandle, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWindowAssociation<TThis>(this TThis thisVtbl, nint* pWindowHandle) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWindowAssociation<TThis>(this TThis thisVtbl, ref nint pWindowHandle) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nint* pWindowHandlePtr = &pWindowHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc* pDescPtr = &pDesc)
        {
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSoftwareAdapter<TThis>(this TThis thisVtbl, nint Module, Silk.NET.DXGI.IDXGIAdapter** ppAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSoftwareAdapter<TThis>(this TThis thisVtbl, nint Module, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters1<TThis>(this TThis thisVtbl, uint Adapter, IDXGIAdapter1** ppAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, IDXGIAdapter1**, int>)@this->LpVtbl[12])(@this, Adapter, ppAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters1<TThis>(this TThis thisVtbl, uint Adapter, ref IDXGIAdapter1* ppAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIAdapter1** ppAdapterPtr = &ppAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, IDXGIAdapter1**, int>)@this->LpVtbl[12])(@this, Adapter, ppAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsCurrent<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, int>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsWindowedStereoEnabled<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, int>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
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
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
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
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid<TThis>(this TThis thisVtbl, void* hResource, Luid* pLuid) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResource, pLuid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid<TThis>(this TThis thisVtbl, void* hResource, ref Luid pLuid) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Luid* pLuidPtr = &pLuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResource, pLuidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid<T0, TThis>(this TThis thisVtbl, ref T0 hResource, Luid* pLuid) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hResourcePtr = &hResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResourcePtr, pLuid);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSharedResourceAdapterLuid<T0, TThis>(this TThis thisVtbl, ref T0 hResource, ref Luid pLuid) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hResourcePtr = &hResource)
        {
            fixed (Luid* pLuidPtr = &pLuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResourcePtr, pLuidPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusWindow<TThis>(this TThis thisVtbl, nint WindowHandle, uint wMsg, uint* pdwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint, uint, uint*, int>)@this->LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterStereoStatusWindow<TThis>(this TThis thisVtbl, nint WindowHandle, uint wMsg, ref uint pdwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint, uint, uint*, int>)@this->LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, uint* pdwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, ref uint pdwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEvent, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEventPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterStereoStatusEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEventPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterStereoStatus<TThis>(this TThis thisVtbl, uint dwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, void>)@this->LpVtbl[20])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusWindow<TThis>(this TThis thisVtbl, nint WindowHandle, uint wMsg, uint* pdwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint, uint, uint*, int>)@this->LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterOcclusionStatusWindow<TThis>(this TThis thisVtbl, nint WindowHandle, uint wMsg, ref uint pdwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, nint, uint, uint*, int>)@this->LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, uint* pdwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, ref uint pdwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEvent, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEventPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterOcclusionStatusEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEventPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterOcclusionStatus<TThis>(this TThis thisVtbl, uint dwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, void>)@this->LpVtbl[23])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetCreationFlags<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint>)@this->LpVtbl[25])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByLuid<TThis>(this TThis thisVtbl, Luid AdapterLuid, Guid* riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Luid, Guid*, void**, int>)@this->LpVtbl[26])(@this, AdapterLuid, riid, ppvAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByLuid<TThis>(this TThis thisVtbl, Luid AdapterLuid, Guid* riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvAdapterPtr = &ppvAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Luid, Guid*, void**, int>)@this->LpVtbl[26])(@this, AdapterLuid, riid, ppvAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByLuid<TThis>(this TThis thisVtbl, Luid AdapterLuid, ref Guid riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Luid, Guid*, void**, int>)@this->LpVtbl[26])(@this, AdapterLuid, riidPtr, ppvAdapter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByLuid<TThis>(this TThis thisVtbl, Luid AdapterLuid, ref Guid riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvAdapterPtr = &ppvAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Luid, Guid*, void**, int>)@this->LpVtbl[26])(@this, AdapterLuid, riidPtr, ppvAdapterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumWarpAdapter<TThis>(this TThis thisVtbl, Guid* riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[27])(@this, riid, ppvAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumWarpAdapter<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvAdapterPtr = &ppvAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[27])(@this, riid, ppvAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumWarpAdapter<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[27])(@this, riidPtr, ppvAdapter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumWarpAdapter<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvAdapterPtr = &ppvAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Guid*, void**, int>)@this->LpVtbl[27])(@this, riidPtr, ppvAdapterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport<TThis>(this TThis thisVtbl, Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Feature, void*, uint, int>)@this->LpVtbl[28])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0, TThis>(this TThis thisVtbl, Feature Feature, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, Feature, void*, uint, int>)@this->LpVtbl[28])(@this, Feature, pFeatureSupportDataPtr, FeatureSupportDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByGpuPreference<TThis>(this TThis thisVtbl, uint Adapter, GpuPreference GpuPreference, Guid* riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, GpuPreference, Guid*, void**, int>)@this->LpVtbl[29])(@this, Adapter, GpuPreference, riid, ppvAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByGpuPreference<TThis>(this TThis thisVtbl, uint Adapter, GpuPreference GpuPreference, Guid* riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvAdapterPtr = &ppvAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, GpuPreference, Guid*, void**, int>)@this->LpVtbl[29])(@this, Adapter, GpuPreference, riid, ppvAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByGpuPreference<TThis>(this TThis thisVtbl, uint Adapter, GpuPreference GpuPreference, ref Guid riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, GpuPreference, Guid*, void**, int>)@this->LpVtbl[29])(@this, Adapter, GpuPreference, riidPtr, ppvAdapter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByGpuPreference<TThis>(this TThis thisVtbl, uint Adapter, GpuPreference GpuPreference, ref Guid riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvAdapterPtr = &ppvAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, GpuPreference, Guid*, void**, int>)@this->LpVtbl[29])(@this, Adapter, GpuPreference, riidPtr, ppvAdapterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterAdaptersChangedEvent<TThis>(this TThis thisVtbl, void* hEvent, uint* pdwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[30])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterAdaptersChangedEvent<TThis>(this TThis thisVtbl, void* hEvent, ref uint pdwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[30])(@this, hEvent, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterAdaptersChangedEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[30])(@this, hEventPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterAdaptersChangedEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, void*, uint*, int>)@this->LpVtbl[30])(@this, hEventPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterAdaptersChangedEvent<TThis>(this TThis thisVtbl, uint dwCookie) where TThis : IComVtbl<IDXGIFactory7>
    {
        var @this = (IDXGIFactory7*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory7*, uint, int>)@this->LpVtbl[31])(@this, dwCookie);
        return ret;
    }

}
