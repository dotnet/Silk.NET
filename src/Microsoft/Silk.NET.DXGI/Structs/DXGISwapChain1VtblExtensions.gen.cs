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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppDevice) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppDevice) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppDevice) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppDevice) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static int Present<TThis>(this TThis thisVtbl, uint SyncInterval, uint Flags) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, int>)@this->LpVtbl[8])(@this, SyncInterval, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, Guid* riid, void** ppSurface) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riid, ppSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, Guid* riid, ref void* ppSurface) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riid, ppSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, ref Guid riid, void** ppSurface) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riidPtr, ppSurface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, ref Guid riid, ref void* ppSurface) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static unsafe int SetFullscreenState<TThis>(this TThis thisVtbl, int Fullscreen, IDXGIOutput* pTarget) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, int, IDXGIOutput*, int>)@this->LpVtbl[10])(@this, Fullscreen, pTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFullscreenState<TThis>(this TThis thisVtbl, int Fullscreen, ref IDXGIOutput pTarget) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pTargetPtr = &pTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, int, IDXGIOutput*, int>)@this->LpVtbl[10])(@this, Fullscreen, pTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, int* pFullscreen, IDXGIOutput** ppTarget) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreen, ppTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, int* pFullscreen, ref IDXGIOutput* ppTarget) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreen, ppTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, ref int pFullscreen, IDXGIOutput** ppTarget) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pFullscreenPtr = &pFullscreen)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreenPtr, ppTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, ref int pFullscreen, ref IDXGIOutput* ppTarget) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, SwapChainDesc* pDesc) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainDesc*, int>)@this->LpVtbl[12])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref SwapChainDesc pDesc) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainDesc*, int>)@this->LpVtbl[12])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResizeBuffers<TThis>(this TThis thisVtbl, uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format NewFormat, uint SwapChainFlags) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)@this->LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResizeTarget<TThis>(this TThis thisVtbl, ModeDesc* pNewTargetParameters) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, ModeDesc*, int>)@this->LpVtbl[14])(@this, pNewTargetParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResizeTarget<TThis>(this TThis thisVtbl, ref ModeDesc pNewTargetParameters) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc* pNewTargetParametersPtr = &pNewTargetParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, ModeDesc*, int>)@this->LpVtbl[14])(@this, pNewTargetParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingOutput<TThis>(this TThis thisVtbl, IDXGIOutput** ppOutput) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, IDXGIOutput**, int>)@this->LpVtbl[15])(@this, ppOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingOutput<TThis>(this TThis thisVtbl, ref IDXGIOutput* ppOutput) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, IDXGIOutput**, int>)@this->LpVtbl[15])(@this, ppOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameStatistics<TThis>(this TThis thisVtbl, FrameStatistics* pStats) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, FrameStatistics*, int>)@this->LpVtbl[16])(@this, pStats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatistics<TThis>(this TThis thisVtbl, ref FrameStatistics pStats) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (FrameStatistics* pStatsPtr = &pStats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, FrameStatistics*, int>)@this->LpVtbl[16])(@this, pStatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastPresentCount<TThis>(this TThis thisVtbl, uint* pLastPresentCount) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint*, int>)@this->LpVtbl[17])(@this, pLastPresentCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLastPresentCount<TThis>(this TThis thisVtbl, ref uint pLastPresentCount) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pLastPresentCountPtr = &pLastPresentCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint*, int>)@this->LpVtbl[17])(@this, pLastPresentCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc1<TThis>(this TThis thisVtbl, SwapChainDesc1* pDesc) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainDesc1*, int>)@this->LpVtbl[18])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1<TThis>(this TThis thisVtbl, ref SwapChainDesc1 pDesc) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainDesc1*, int>)@this->LpVtbl[18])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenDesc<TThis>(this TThis thisVtbl, SwapChainFullscreenDesc* pDesc) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainFullscreenDesc*, int>)@this->LpVtbl[19])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFullscreenDesc<TThis>(this TThis thisVtbl, ref SwapChainFullscreenDesc pDesc) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainFullscreenDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, SwapChainFullscreenDesc*, int>)@this->LpVtbl[19])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHwnd<TThis>(this TThis thisVtbl, nint* pHwnd) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, nint*, int>)@this->LpVtbl[20])(@this, pHwnd);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetHwnd<TThis>(this TThis thisVtbl, ref nint pHwnd) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nint* pHwndPtr = &pHwnd)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, nint*, int>)@this->LpVtbl[20])(@this, pHwndPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, Guid* refiid, void** ppUnk) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiid, ppUnk);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, Guid* refiid, ref void* ppUnk) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppUnkPtr = &ppUnk)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiid, ppUnkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, ref Guid refiid, void** ppUnk) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refiidPtr = &refiid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiidPtr, ppUnk);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, ref Guid refiid, ref void* ppUnk) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
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
    public static unsafe int Present1<TThis>(this TThis thisVtbl, uint SyncInterval, uint PresentFlags, PresentParameters* pPresentParameters) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, PresentParameters*, int>)@this->LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Present1<TThis>(this TThis thisVtbl, uint SyncInterval, uint PresentFlags, ref PresentParameters pPresentParameters) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PresentParameters* pPresentParametersPtr = &pPresentParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, uint, uint, PresentParameters*, int>)@this->LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsTemporaryMonoSupported<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, int>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRestrictToOutput<TThis>(this TThis thisVtbl, IDXGIOutput** ppRestrictToOutput) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, IDXGIOutput**, int>)@this->LpVtbl[24])(@this, ppRestrictToOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRestrictToOutput<TThis>(this TThis thisVtbl, ref IDXGIOutput* ppRestrictToOutput) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput** ppRestrictToOutputPtr = &ppRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, IDXGIOutput**, int>)@this->LpVtbl[24])(@this, ppRestrictToOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundColor<TThis>(this TThis thisVtbl, D3Dcolorvalue* pColor) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, D3Dcolorvalue*, int>)@this->LpVtbl[25])(@this, pColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBackgroundColor<TThis>(this TThis thisVtbl, ref D3Dcolorvalue pColor) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (D3Dcolorvalue* pColorPtr = &pColor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, D3Dcolorvalue*, int>)@this->LpVtbl[25])(@this, pColorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackgroundColor<TThis>(this TThis thisVtbl, D3Dcolorvalue* pColor) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, D3Dcolorvalue*, int>)@this->LpVtbl[26])(@this, pColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBackgroundColor<TThis>(this TThis thisVtbl, ref D3Dcolorvalue pColor) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (D3Dcolorvalue* pColorPtr = &pColor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, D3Dcolorvalue*, int>)@this->LpVtbl[26])(@this, pColorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRotation<TThis>(this TThis thisVtbl, ModeRotation Rotation) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, ModeRotation, int>)@this->LpVtbl[27])(@this, Rotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRotation<TThis>(this TThis thisVtbl, ModeRotation* pRotation) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, ModeRotation*, int>)@this->LpVtbl[28])(@this, pRotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRotation<TThis>(this TThis thisVtbl, ref ModeRotation pRotation) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeRotation* pRotationPtr = &pRotation)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain1*, ModeRotation*, int>)@this->LpVtbl[28])(@this, pRotationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppParent) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppParent) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppDevice) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppDevice) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static int GetBuffer<TI0, TThis>(this TThis thisVtbl, uint Buffer, out ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppSurface = default;
        return @this->GetBuffer(Buffer, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, Span<Guid> riid, void** ppSurface) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBuffer(Buffer, ref riid.GetPinnableReference(), ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, Span<Guid> riid, ref void* ppSurface) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBuffer(Buffer, ref riid.GetPinnableReference(), ref ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static int SetFullscreenState<TThis>(this TThis thisVtbl, int Fullscreen, Span<IDXGIOutput> pTarget) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetFullscreenState(Fullscreen, ref pTarget.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TI0, TThis>(this TThis thisVtbl, int* pFullscreen, ref ComPtr<TI0> ppTarget) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetFullscreenState(pFullscreen, (IDXGIOutput**) ppTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, Span<int> pFullscreen, IDXGIOutput** ppTarget) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFullscreenState(ref pFullscreen.GetPinnableReference(), ppTarget);
    }

    /// <summary>To be documented.</summary>
    public static int GetFullscreenState<TI0, TThis>(this TThis thisVtbl, ref int pFullscreen, ref ComPtr<TI0> ppTarget) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetFullscreenState(ref pFullscreen, (IDXGIOutput**) ppTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, Span<int> pFullscreen, ref IDXGIOutput* ppTarget) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFullscreenState(ref pFullscreen.GetPinnableReference(), ref ppTarget);
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, Span<SwapChainDesc> pDesc) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ResizeTarget<TThis>(this TThis thisVtbl, Span<ModeDesc> pNewTargetParameters) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ResizeTarget(ref pNewTargetParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetContainingOutput<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppOutput) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetContainingOutput((IDXGIOutput**) ppOutput.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatistics<TThis>(this TThis thisVtbl, Span<FrameStatistics> pStats) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFrameStatistics(ref pStats.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLastPresentCount<TThis>(this TThis thisVtbl, Span<uint> pLastPresentCount) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetLastPresentCount(ref pLastPresentCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1<TThis>(this TThis thisVtbl, Span<SwapChainDesc1> pDesc) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDesc1(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFullscreenDesc<TThis>(this TThis thisVtbl, Span<SwapChainFullscreenDesc> pDesc) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFullscreenDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetHwnd<TThis>(this TThis thisVtbl, Span<nint> pHwnd) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetHwnd(ref pHwnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCoreWindow<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppUnk) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppUnk = default;
        return @this->GetCoreWindow(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppUnk.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, Span<Guid> refiid, void** ppUnk) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCoreWindow(ref refiid.GetPinnableReference(), ppUnk);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, Span<Guid> refiid, ref void* ppUnk) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCoreWindow(ref refiid.GetPinnableReference(), ref ppUnk);
    }

    /// <summary>To be documented.</summary>
    public static int Present1<TThis>(this TThis thisVtbl, uint SyncInterval, uint PresentFlags, Span<PresentParameters> pPresentParameters) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present1(SyncInterval, PresentFlags, ref pPresentParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRestrictToOutput<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppRestrictToOutput) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetRestrictToOutput((IDXGIOutput**) ppRestrictToOutput.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetBackgroundColor<TThis>(this TThis thisVtbl, Span<D3Dcolorvalue> pColor) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetBackgroundColor(ref pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBackgroundColor<TThis>(this TThis thisVtbl, Span<D3Dcolorvalue> pColor) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBackgroundColor(ref pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRotation<TThis>(this TThis thisVtbl, Span<ModeRotation> pRotation) where TThis : IComVtbl<IDXGISwapChain1>
    {
        var @this = (IDXGISwapChain1*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetRotation(ref pRotation.GetPinnableReference());
    }

}
