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

public unsafe static class DXGIFactory5VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters<TThis>(this TThis thisVtbl, uint Adapter, Silk.NET.DXGI.IDXGIAdapter** ppAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters<TThis>(this TThis thisVtbl, uint Adapter, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MakeWindowAssociation<TThis>(this TThis thisVtbl, nint WindowHandle, uint Flags) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, nint, uint, int>)@this->LpVtbl[8])(@this, WindowHandle, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWindowAssociation<TThis>(this TThis thisVtbl, nint* pWindowHandle) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWindowAssociation<TThis>(this TThis thisVtbl, ref nint pWindowHandle) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nint* pWindowHandlePtr = &pWindowHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc* pDescPtr = &pDesc)
        {
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSoftwareAdapter<TThis>(this TThis thisVtbl, nint Module, Silk.NET.DXGI.IDXGIAdapter** ppAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSoftwareAdapter<TThis>(this TThis thisVtbl, nint Module, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters1<TThis>(this TThis thisVtbl, uint Adapter, IDXGIAdapter1** ppAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, uint, IDXGIAdapter1**, int>)@this->LpVtbl[12])(@this, Adapter, ppAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters1<TThis>(this TThis thisVtbl, uint Adapter, ref IDXGIAdapter1* ppAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIAdapter1** ppAdapterPtr = &ppAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, uint, IDXGIAdapter1**, int>)@this->LpVtbl[12])(@this, Adapter, ppAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsCurrent<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, int>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsWindowedStereoEnabled<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, int>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevice, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDesc, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (SwapChainFullscreenDesc* pFullscreenDescPtr = &pFullscreenDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
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
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, nint, SwapChainDesc1*, SwapChainFullscreenDesc*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[15])(@this, pDevicePtr, hWnd, pDescPtr, pFullscreenDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevice, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindow, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pWindowPtr = &pWindow)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
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
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[16])(@this, pDevicePtr, pWindowPtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid<TThis>(this TThis thisVtbl, void* hResource, Luid* pLuid) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResource, pLuid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid<TThis>(this TThis thisVtbl, void* hResource, ref Luid pLuid) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Luid* pLuidPtr = &pLuid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResource, pLuidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid<T0, TThis>(this TThis thisVtbl, ref T0 hResource, Luid* pLuid) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hResourcePtr = &hResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResourcePtr, pLuid);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSharedResourceAdapterLuid<T0, TThis>(this TThis thisVtbl, ref T0 hResource, ref Luid pLuid) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hResourcePtr = &hResource)
        {
            fixed (Luid* pLuidPtr = &pLuid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, Luid*, int>)@this->LpVtbl[17])(@this, hResourcePtr, pLuidPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusWindow<TThis>(this TThis thisVtbl, nint WindowHandle, uint wMsg, uint* pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, nint, uint, uint*, int>)@this->LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterStereoStatusWindow<TThis>(this TThis thisVtbl, nint WindowHandle, uint wMsg, ref uint pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, nint, uint, uint*, int>)@this->LpVtbl[18])(@this, WindowHandle, wMsg, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, uint* pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, ref uint pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEvent, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEventPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterStereoStatusEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, uint*, int>)@this->LpVtbl[19])(@this, hEventPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterStereoStatus<TThis>(this TThis thisVtbl, uint dwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, uint, void>)@this->LpVtbl[20])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusWindow<TThis>(this TThis thisVtbl, nint WindowHandle, uint wMsg, uint* pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, nint, uint, uint*, int>)@this->LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterOcclusionStatusWindow<TThis>(this TThis thisVtbl, nint WindowHandle, uint wMsg, ref uint pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, nint, uint, uint*, int>)@this->LpVtbl[21])(@this, WindowHandle, wMsg, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, uint* pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, ref uint pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEvent, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEventPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterOcclusionStatusEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, void*, uint*, int>)@this->LpVtbl[22])(@this, hEventPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterOcclusionStatus<TThis>(this TThis thisVtbl, uint dwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, uint, void>)@this->LpVtbl[23])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutput, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevice, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[24])(@this, pDevicePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetCreationFlags<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, uint>)@this->LpVtbl[25])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByLuid<TThis>(this TThis thisVtbl, Luid AdapterLuid, Guid* riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Luid, Guid*, void**, int>)@this->LpVtbl[26])(@this, AdapterLuid, riid, ppvAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByLuid<TThis>(this TThis thisVtbl, Luid AdapterLuid, Guid* riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvAdapterPtr = &ppvAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Luid, Guid*, void**, int>)@this->LpVtbl[26])(@this, AdapterLuid, riid, ppvAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByLuid<TThis>(this TThis thisVtbl, Luid AdapterLuid, ref Guid riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Luid, Guid*, void**, int>)@this->LpVtbl[26])(@this, AdapterLuid, riidPtr, ppvAdapter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByLuid<TThis>(this TThis thisVtbl, Luid AdapterLuid, ref Guid riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvAdapterPtr = &ppvAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Luid, Guid*, void**, int>)@this->LpVtbl[26])(@this, AdapterLuid, riidPtr, ppvAdapterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumWarpAdapter<TThis>(this TThis thisVtbl, Guid* riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[27])(@this, riid, ppvAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumWarpAdapter<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvAdapterPtr = &ppvAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[27])(@this, riid, ppvAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumWarpAdapter<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[27])(@this, riidPtr, ppvAdapter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumWarpAdapter<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvAdapterPtr = &ppvAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Guid*, void**, int>)@this->LpVtbl[27])(@this, riidPtr, ppvAdapterPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport<TThis>(this TThis thisVtbl, Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Feature, void*, uint, int>)@this->LpVtbl[28])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0, TThis>(this TThis thisVtbl, Feature Feature, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory5*, Feature, void*, uint, int>)@this->LpVtbl[28])(@this, Feature, pFeatureSupportDataPtr, FeatureSupportDataSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppParent) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppParent) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static int GetWindowAssociation<TThis>(this TThis thisVtbl, Span<nint> pWindowHandle) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetWindowAssociation(ref pWindowHandle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<SwapChainDesc> pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(pDevice, ref pDesc.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<SwapChainDesc> pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(pDevice, ref pDesc.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), pDesc, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), pDesc, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<SwapChainDesc> pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), ref pDesc.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<SwapChainDesc> pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int EnumAdapters1<TI0, TThis>(this TThis thisVtbl, uint Adapter, ref ComPtr<TI0> ppAdapter) where TI0 : unmanaged, IComVtbl<IDXGIAdapter1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->EnumAdapters1(Adapter, (IDXGIAdapter1**) ppAdapter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, ref pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, ref pFullscreenDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, ref pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, ref pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, ref pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, SwapChainDesc1* pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, pDesc, ref pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc.GetPinnableReference(), pFullscreenDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc, pFullscreenDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc.GetPinnableReference(), pFullscreenDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc.GetPinnableReference(), pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc.GetPinnableReference(), pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc.GetPinnableReference(), ref pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc, ref pFullscreenDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc.GetPinnableReference(), ref pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc.GetPinnableReference(), ref pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc, ref pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(pDevice, hWnd, ref pDesc.GetPinnableReference(), ref pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, SwapChainDesc1* pDesc, SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, SwapChainDesc1* pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, ref pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, ref pFullscreenDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, SwapChainDesc1* pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, ref pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, SwapChainDesc1* pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, ref pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, SwapChainDesc1* pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, pDesc, ref pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, SwapChainDesc1* pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, pDesc, ref pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, ref pDesc.GetPinnableReference(), pFullscreenDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, ref pDesc, pFullscreenDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, SwapChainFullscreenDesc* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, ref pDesc.GetPinnableReference(), pFullscreenDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, ref pDesc.GetPinnableReference(), pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, SwapChainFullscreenDesc* pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, ref pDesc, pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, SwapChainFullscreenDesc* pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, ref pDesc.GetPinnableReference(), pFullscreenDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, ref pDesc.GetPinnableReference(), ref pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, ref pDesc, ref pFullscreenDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, ref pDesc.GetPinnableReference(), ref pFullscreenDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, ref pDesc.GetPinnableReference(), ref pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForHwnd<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, nint hWnd, ref SwapChainDesc1 pDesc, ref SwapChainFullscreenDesc pFullscreenDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice, hWnd, ref pDesc, ref pFullscreenDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForHwnd<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, nint hWnd, Span<SwapChainDesc1> pDesc, Span<SwapChainFullscreenDesc> pFullscreenDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForHwnd(ref pDevice.GetPinnableReference(), hWnd, ref pDesc.GetPinnableReference(), ref pFullscreenDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, ref pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, ref pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, ref pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, ref pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Native.IUnknown* pWindow, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, pWindow, ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow, pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), pDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), ref pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow, ref pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), ref pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow, ref pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(pDevice, ref pWindow.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, pWindow, pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, pDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, pWindow, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, ref pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, pWindow, ref pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, ref pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Native.IUnknown* pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, pWindow, ref pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Native.IUnknown* pWindow, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), pWindow, ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), pDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), ref pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, ref pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), ref pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCoreWindow<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref Silk.NET.Core.Native.IUnknown pWindow, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice, ref pWindow, ref pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCoreWindow<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<Silk.NET.Core.Native.IUnknown> pWindow, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForCoreWindow(ref pDevice.GetPinnableReference(), ref pWindow.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid<TThis>(this TThis thisVtbl, void* hResource, Span<Luid> pLuid) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSharedResourceAdapterLuid(hResource, ref pLuid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedResourceAdapterLuid<T0, TThis>(this TThis thisVtbl, Span<T0> hResource, Luid* pLuid) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSharedResourceAdapterLuid(ref hResource.GetPinnableReference(), pLuid);
    }

    /// <summary>To be documented.</summary>
    public static int GetSharedResourceAdapterLuid<T0, TThis>(this TThis thisVtbl, Span<T0> hResource, Span<Luid> pLuid) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSharedResourceAdapterLuid(ref hResource.GetPinnableReference(), ref pLuid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RegisterStereoStatusWindow<TThis>(this TThis thisVtbl, nint WindowHandle, uint wMsg, Span<uint> pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterStereoStatusWindow(WindowHandle, wMsg, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, Span<uint> pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterStereoStatusEvent(hEvent, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterStereoStatusEvent<T0, TThis>(this TThis thisVtbl, Span<T0> hEvent, uint* pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterStereoStatusEvent(ref hEvent.GetPinnableReference(), pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterStereoStatusEvent<T0, TThis>(this TThis thisVtbl, Span<T0> hEvent, Span<uint> pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterStereoStatusEvent(ref hEvent.GetPinnableReference(), ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int RegisterOcclusionStatusWindow<TThis>(this TThis thisVtbl, nint WindowHandle, uint wMsg, Span<uint> pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterOcclusionStatusWindow(WindowHandle, wMsg, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, Span<uint> pdwCookie) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterOcclusionStatusEvent(hEvent, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterOcclusionStatusEvent<T0, TThis>(this TThis thisVtbl, Span<T0> hEvent, uint* pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterOcclusionStatusEvent(ref hEvent.GetPinnableReference(), pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterOcclusionStatusEvent<T0, TThis>(this TThis thisVtbl, Span<T0> hEvent, Span<uint> pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterOcclusionStatusEvent(ref hEvent.GetPinnableReference(), ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(pDevice, pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(pDevice, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, ref pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(pDevice, ref pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, ref pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(pDevice, ref pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(pDevice, ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(ref pDevice, pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), pDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(ref pDevice, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), ref pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(ref pDevice, ref pDesc, pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), ref pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForComposition<TI0, TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->CreateSwapChainForComposition(ref pDevice, ref pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForComposition<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChainForComposition(ref pDevice.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int EnumAdapterByLuid<TI0, TThis>(this TThis thisVtbl, Luid AdapterLuid, out ComPtr<TI0> ppvAdapter) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvAdapter = default;
        return @this->EnumAdapterByLuid(AdapterLuid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvAdapter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByLuid<TThis>(this TThis thisVtbl, Luid AdapterLuid, Span<Guid> riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EnumAdapterByLuid(AdapterLuid, ref riid.GetPinnableReference(), ppvAdapter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterByLuid<TThis>(this TThis thisVtbl, Luid AdapterLuid, Span<Guid> riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EnumAdapterByLuid(AdapterLuid, ref riid.GetPinnableReference(), ref ppvAdapter);
    }

    /// <summary>To be documented.</summary>
    public static int EnumWarpAdapter<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvAdapter) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvAdapter = default;
        return @this->EnumWarpAdapter(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvAdapter.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumWarpAdapter<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EnumWarpAdapter(ref riid.GetPinnableReference(), ppvAdapter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumWarpAdapter<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvAdapter) where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EnumWarpAdapter(ref riid.GetPinnableReference(), ref ppvAdapter);
    }

    /// <summary>To be documented.</summary>
    public static int CheckFeatureSupport<T0, TThis>(this TThis thisVtbl, Feature Feature, Span<T0> pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory5>
    {
        var @this = (IDXGIFactory5*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckFeatureSupport(Feature, ref pFeatureSupportData.GetPinnableReference(), FeatureSupportDataSize);
    }

}
