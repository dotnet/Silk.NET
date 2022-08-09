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

public unsafe static class DXGIFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters<TThis>(this TThis thisVtbl, uint Adapter, Silk.NET.DXGI.IDXGIAdapter** ppAdapter) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapters<TThis>(this TThis thisVtbl, uint Adapter, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, uint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[7])(@this, Adapter, ppAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MakeWindowAssociation<TThis>(this TThis thisVtbl, nint WindowHandle, uint Flags) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, nint, uint, int>)@this->LpVtbl[8])(@this, WindowHandle, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWindowAssociation<TThis>(this TThis thisVtbl, nint* pWindowHandle) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWindowAssociation<TThis>(this TThis thisVtbl, ref nint pWindowHandle) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nint* pWindowHandlePtr = &pWindowHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, nint*, int>)@this->LpVtbl[9])(@this, pWindowHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDesc, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc* pDescPtr = &pDesc)
        {
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevice, pDescPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDesc, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref SwapChainDesc pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, Silk.NET.Core.Native.IUnknown*, SwapChainDesc*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[10])(@this, pDevicePtr, pDescPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSoftwareAdapter<TThis>(this TThis thisVtbl, nint Module, Silk.NET.DXGI.IDXGIAdapter** ppAdapter) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSoftwareAdapter<TThis>(this TThis thisVtbl, nint Module, ref Silk.NET.DXGI.IDXGIAdapter* ppAdapter) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGIAdapter** ppAdapterPtr = &ppAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactory*, nint, Silk.NET.DXGI.IDXGIAdapter**, int>)@this->LpVtbl[11])(@this, Module, ppAdapterPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppParent) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppParent) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static int GetWindowAssociation<TThis>(this TThis thisVtbl, Span<nint> pWindowHandle) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetWindowAssociation(ref pWindowHandle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<SwapChainDesc> pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(pDevice, ref pDesc.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<SwapChainDesc> pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(pDevice, ref pDesc.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, SwapChainDesc* pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), pDesc, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, SwapChainDesc* pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), pDesc, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<SwapChainDesc> pDesc, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), ref pDesc.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChain<TThis>(this TThis thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<SwapChainDesc> pDesc, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<IDXGIFactory>
    {
        var @this = (IDXGIFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateSwapChain(ref pDevice.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref ppSwapChain);
    }

}
