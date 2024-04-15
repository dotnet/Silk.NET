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

public unsafe static class DXGISwapChain1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGISwapChain1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGISwapChain1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* riid, void** ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* riid, ref void* ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid riid, void** ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid riid, ref void* ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Present(this ComPtr<IDXGISwapChain1> thisVtbl, uint SyncInterval, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, int>)@this->LpVtbl[8])(@this, SyncInterval, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IDXGISwapChain1> thisVtbl, uint Buffer, Guid* riid, void** ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riid, ppSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IDXGISwapChain1> thisVtbl, uint Buffer, Guid* riid, ref void* ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riid, ppSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IDXGISwapChain1> thisVtbl, uint Buffer, ref Guid riid, void** ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riidPtr, ppSurface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IDXGISwapChain1> thisVtbl, uint Buffer, ref Guid riid, ref void* ppSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riidPtr, ppSurfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFullscreenState(this ComPtr<IDXGISwapChain1> thisVtbl, Silk.NET.Core.Bool32 Fullscreen, IDXGIOutput* pTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Silk.NET.Core.Bool32, IDXGIOutput*, int>)@this->LpVtbl[10])(@this, Fullscreen, pTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFullscreenState(this ComPtr<IDXGISwapChain1> thisVtbl, Silk.NET.Core.Bool32 Fullscreen, ref IDXGIOutput pTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput* pTargetPtr = &pTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Silk.NET.Core.Bool32, IDXGIOutput*, int>)@this->LpVtbl[10])(@this, Fullscreen, pTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState(this ComPtr<IDXGISwapChain1> thisVtbl, int* pFullscreen, IDXGIOutput** ppTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreen, ppTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState(this ComPtr<IDXGISwapChain1> thisVtbl, int* pFullscreen, ref IDXGIOutput* ppTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreen, ppTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState(this ComPtr<IDXGISwapChain1> thisVtbl, ref int pFullscreen, IDXGIOutput** ppTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pFullscreenPtr = &pFullscreen)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreenPtr, ppTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState(this ComPtr<IDXGISwapChain1> thisVtbl, ref int pFullscreen, ref IDXGIOutput* ppTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pFullscreenPtr = &pFullscreen)
        {
            fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreenPtr, ppTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<IDXGISwapChain1> thisVtbl, SwapChainDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainDesc*, int>)@this->LpVtbl[12])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<IDXGISwapChain1> thisVtbl, ref SwapChainDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainDesc*, int>)@this->LpVtbl[12])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResizeBuffers(this ComPtr<IDXGISwapChain1> thisVtbl, uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format NewFormat, uint SwapChainFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)@this->LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResizeTarget(this ComPtr<IDXGISwapChain1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pNewTargetParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, ModeDesc*, int>)@this->LpVtbl[14])(@this, pNewTargetParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResizeTarget(this ComPtr<IDXGISwapChain1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pNewTargetParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc* pNewTargetParametersPtr = &pNewTargetParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, ModeDesc*, int>)@this->LpVtbl[14])(@this, pNewTargetParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingOutput(this ComPtr<IDXGISwapChain1> thisVtbl, IDXGIOutput** ppOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, IDXGIOutput**, int>)@this->LpVtbl[15])(@this, ppOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingOutput(this ComPtr<IDXGISwapChain1> thisVtbl, ref IDXGIOutput* ppOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, IDXGIOutput**, int>)@this->LpVtbl[15])(@this, ppOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameStatistics(this ComPtr<IDXGISwapChain1> thisVtbl, FrameStatistics* pStats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, FrameStatistics*, int>)@this->LpVtbl[16])(@this, pStats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatistics(this ComPtr<IDXGISwapChain1> thisVtbl, ref FrameStatistics pStats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FrameStatistics* pStatsPtr = &pStats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, FrameStatistics*, int>)@this->LpVtbl[16])(@this, pStatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastPresentCount(this ComPtr<IDXGISwapChain1> thisVtbl, uint* pLastPresentCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint*, int>)@this->LpVtbl[17])(@this, pLastPresentCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLastPresentCount(this ComPtr<IDXGISwapChain1> thisVtbl, ref uint pLastPresentCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pLastPresentCountPtr = &pLastPresentCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint*, int>)@this->LpVtbl[17])(@this, pLastPresentCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc1(this ComPtr<IDXGISwapChain1> thisVtbl, SwapChainDesc1* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainDesc1*, int>)@this->LpVtbl[18])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1(this ComPtr<IDXGISwapChain1> thisVtbl, ref SwapChainDesc1 pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainDesc1*, int>)@this->LpVtbl[18])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenDesc(this ComPtr<IDXGISwapChain1> thisVtbl, SwapChainFullscreenDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainFullscreenDesc*, int>)@this->LpVtbl[19])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFullscreenDesc(this ComPtr<IDXGISwapChain1> thisVtbl, ref SwapChainFullscreenDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainFullscreenDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainFullscreenDesc*, int>)@this->LpVtbl[19])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHwnd(this ComPtr<IDXGISwapChain1> thisVtbl, nint* pHwnd)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, nint*, int>)@this->LpVtbl[20])(@this, pHwnd);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetHwnd(this ComPtr<IDXGISwapChain1> thisVtbl, ref nint pHwnd)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nint* pHwndPtr = &pHwnd)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, nint*, int>)@this->LpVtbl[20])(@this, pHwndPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* refiid, void** ppUnk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiid, ppUnk);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* refiid, ref void* ppUnk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppUnkPtr = &ppUnk)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiid, ppUnkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid refiid, void** ppUnk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* refiidPtr = &refiid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiidPtr, ppUnk);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid refiid, ref void* ppUnk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* refiidPtr = &refiid)
        {
            fixed (void** ppUnkPtr = &ppUnk)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiidPtr, ppUnkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present1(this ComPtr<IDXGISwapChain1> thisVtbl, uint SyncInterval, uint PresentFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PresentParameters* pPresentParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, PresentParameters*, int>)@this->LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Present1(this ComPtr<IDXGISwapChain1> thisVtbl, uint SyncInterval, uint PresentFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PresentParameters pPresentParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PresentParameters* pPresentParametersPtr = &pPresentParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, PresentParameters*, int>)@this->LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsTemporaryMonoSupported(this ComPtr<IDXGISwapChain1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Silk.NET.Core.Bool32>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRestrictToOutput(this ComPtr<IDXGISwapChain1> thisVtbl, IDXGIOutput** ppRestrictToOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, IDXGIOutput**, int>)@this->LpVtbl[24])(@this, ppRestrictToOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRestrictToOutput(this ComPtr<IDXGISwapChain1> thisVtbl, ref IDXGIOutput* ppRestrictToOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput** ppRestrictToOutputPtr = &ppRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, IDXGIOutput**, int>)@this->LpVtbl[24])(@this, ppRestrictToOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundColor(this ComPtr<IDXGISwapChain1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] D3Dcolorvalue* pColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, D3Dcolorvalue*, int>)@this->LpVtbl[25])(@this, pColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBackgroundColor(this ComPtr<IDXGISwapChain1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in D3Dcolorvalue pColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3Dcolorvalue* pColorPtr = &pColor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, D3Dcolorvalue*, int>)@this->LpVtbl[25])(@this, pColorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackgroundColor(this ComPtr<IDXGISwapChain1> thisVtbl, D3Dcolorvalue* pColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, D3Dcolorvalue*, int>)@this->LpVtbl[26])(@this, pColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBackgroundColor(this ComPtr<IDXGISwapChain1> thisVtbl, ref D3Dcolorvalue pColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (D3Dcolorvalue* pColorPtr = &pColor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, D3Dcolorvalue*, int>)@this->LpVtbl[26])(@this, pColorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRotation(this ComPtr<IDXGISwapChain1> thisVtbl, ModeRotation Rotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, ModeRotation, int>)@this->LpVtbl[27])(@this, Rotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRotation(this ComPtr<IDXGISwapChain1> thisVtbl, ModeRotation* pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, ModeRotation*, int>)@this->LpVtbl[28])(@this, pRotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRotation(this ComPtr<IDXGISwapChain1> thisVtbl, ref ModeRotation pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeRotation* pRotationPtr = &pRotation)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, ModeRotation*, int>)@this->LpVtbl[28])(@this, pRotationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, out ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> riid, void** ppDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> riid, ref void* ppDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static int GetBuffer<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, uint Buffer, out ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppSurface = default;
        return @this->GetBuffer(Buffer, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IDXGISwapChain1> thisVtbl, uint Buffer, Span<Guid> riid, void** ppSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBuffer(Buffer, ref riid.GetPinnableReference(), ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer(this ComPtr<IDXGISwapChain1> thisVtbl, uint Buffer, Span<Guid> riid, ref void* ppSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBuffer(Buffer, ref riid.GetPinnableReference(), ref ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static int SetFullscreenState<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, Silk.NET.Core.Bool32 Fullscreen, ComPtr<TI0> pTarget) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetFullscreenState(Fullscreen, (IDXGIOutput*) pTarget.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetFullscreenState(this ComPtr<IDXGISwapChain1> thisVtbl, Silk.NET.Core.Bool32 Fullscreen, Span<IDXGIOutput> pTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetFullscreenState(Fullscreen, ref pTarget.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, int* pFullscreen, ref ComPtr<TI0> ppTarget) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFullscreenState(pFullscreen, (IDXGIOutput**) ppTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState(this ComPtr<IDXGISwapChain1> thisVtbl, Span<int> pFullscreen, IDXGIOutput** ppTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFullscreenState(ref pFullscreen.GetPinnableReference(), ppTarget);
    }

    /// <summary>To be documented.</summary>
    public static int GetFullscreenState<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, ref int pFullscreen, ref ComPtr<TI0> ppTarget) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFullscreenState(ref pFullscreen, (IDXGIOutput**) ppTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState(this ComPtr<IDXGISwapChain1> thisVtbl, Span<int> pFullscreen, ref IDXGIOutput* ppTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFullscreenState(ref pFullscreen.GetPinnableReference(), ref ppTarget);
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<IDXGISwapChain1> thisVtbl, Span<SwapChainDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ResizeTarget(this ComPtr<IDXGISwapChain1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ModeDesc> pNewTargetParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ResizeTarget(in pNewTargetParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetContainingOutput<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, ref ComPtr<TI0> ppOutput) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetContainingOutput((IDXGIOutput**) ppOutput.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatistics(this ComPtr<IDXGISwapChain1> thisVtbl, Span<FrameStatistics> pStats)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameStatistics(ref pStats.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLastPresentCount(this ComPtr<IDXGISwapChain1> thisVtbl, Span<uint> pLastPresentCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLastPresentCount(ref pLastPresentCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1(this ComPtr<IDXGISwapChain1> thisVtbl, Span<SwapChainDesc1> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesc1(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFullscreenDesc(this ComPtr<IDXGISwapChain1> thisVtbl, Span<SwapChainFullscreenDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFullscreenDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetHwnd(this ComPtr<IDXGISwapChain1> thisVtbl, Span<nint> pHwnd)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetHwnd(ref pHwnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCoreWindow<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, out ComPtr<TI0> ppUnk) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppUnk = default;
        return @this->GetCoreWindow(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppUnk.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> refiid, void** ppUnk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCoreWindow(ref refiid.GetPinnableReference(), ppUnk);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow(this ComPtr<IDXGISwapChain1> thisVtbl, Span<Guid> refiid, ref void* ppUnk)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCoreWindow(ref refiid.GetPinnableReference(), ref ppUnk);
    }

    /// <summary>To be documented.</summary>
    public static int Present1(this ComPtr<IDXGISwapChain1> thisVtbl, uint SyncInterval, uint PresentFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PresentParameters> pPresentParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present1(SyncInterval, PresentFlags, in pPresentParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRestrictToOutput<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, ref ComPtr<TI0> ppRestrictToOutput) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRestrictToOutput((IDXGIOutput**) ppRestrictToOutput.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetBackgroundColor(this ComPtr<IDXGISwapChain1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<D3Dcolorvalue> pColor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetBackgroundColor(in pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBackgroundColor(this ComPtr<IDXGISwapChain1> thisVtbl, Span<D3Dcolorvalue> pColor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBackgroundColor(ref pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRotation(this ComPtr<IDXGISwapChain1> thisVtbl, Span<ModeRotation> pRotation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRotation(ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetParent<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetDevice<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetBuffer<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl, uint Buffer) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetBuffer(Buffer, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetCoreWindow<TI0>(this ComPtr<IDXGISwapChain1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetCoreWindow(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
