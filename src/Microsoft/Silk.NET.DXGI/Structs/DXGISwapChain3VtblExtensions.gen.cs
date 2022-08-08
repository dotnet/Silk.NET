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

public unsafe static class DXGISwapChain3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppDevice) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppDevice) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppDevice) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppDevice) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Present<TThis>(this TThis thisVtbl, uint SyncInterval, uint Flags) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, int>)@this->LpVtbl[8])(@this, SyncInterval, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, Guid* riid, void** ppSurface) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riid, ppSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, Guid* riid, ref void* ppSurface) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riid, ppSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, ref Guid riid, void** ppSurface) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riidPtr, ppSurface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, ref Guid riid, ref void* ppSurface) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riidPtr, ppSurfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFullscreenState<TThis>(this TThis thisVtbl, int Fullscreen, IDXGIOutput* pTarget) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, int, IDXGIOutput*, int>)@this->LpVtbl[10])(@this, Fullscreen, pTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFullscreenState<TThis>(this TThis thisVtbl, int Fullscreen, ref IDXGIOutput pTarget) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput* pTargetPtr = &pTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, int, IDXGIOutput*, int>)@this->LpVtbl[10])(@this, Fullscreen, pTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, int* pFullscreen, IDXGIOutput** ppTarget) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreen, ppTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, int* pFullscreen, ref IDXGIOutput* ppTarget) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreen, ppTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, ref int pFullscreen, IDXGIOutput** ppTarget) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pFullscreenPtr = &pFullscreen)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreenPtr, ppTarget);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, ref int pFullscreen, ref IDXGIOutput* ppTarget) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pFullscreenPtr = &pFullscreen)
        {
            fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreenPtr, ppTargetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, SwapChainDesc* pDesc) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, SwapChainDesc*, int>)@this->LpVtbl[12])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref SwapChainDesc pDesc) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, SwapChainDesc*, int>)@this->LpVtbl[12])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResizeBuffers<TThis>(this TThis thisVtbl, uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format NewFormat, uint SwapChainFlags) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)@this->LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResizeTarget<TThis>(this TThis thisVtbl, ModeDesc* pNewTargetParameters) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, ModeDesc*, int>)@this->LpVtbl[14])(@this, pNewTargetParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResizeTarget<TThis>(this TThis thisVtbl, ref ModeDesc pNewTargetParameters) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc* pNewTargetParametersPtr = &pNewTargetParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, ModeDesc*, int>)@this->LpVtbl[14])(@this, pNewTargetParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingOutput<TThis>(this TThis thisVtbl, IDXGIOutput** ppOutput) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, IDXGIOutput**, int>)@this->LpVtbl[15])(@this, ppOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainingOutput<TThis>(this TThis thisVtbl, ref IDXGIOutput* ppOutput) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, IDXGIOutput**, int>)@this->LpVtbl[15])(@this, ppOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameStatistics<TThis>(this TThis thisVtbl, FrameStatistics* pStats) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, FrameStatistics*, int>)@this->LpVtbl[16])(@this, pStats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatistics<TThis>(this TThis thisVtbl, ref FrameStatistics pStats) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (FrameStatistics* pStatsPtr = &pStats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, FrameStatistics*, int>)@this->LpVtbl[16])(@this, pStatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastPresentCount<TThis>(this TThis thisVtbl, uint* pLastPresentCount) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint*, int>)@this->LpVtbl[17])(@this, pLastPresentCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLastPresentCount<TThis>(this TThis thisVtbl, ref uint pLastPresentCount) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pLastPresentCountPtr = &pLastPresentCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint*, int>)@this->LpVtbl[17])(@this, pLastPresentCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc1<TThis>(this TThis thisVtbl, SwapChainDesc1* pDesc) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, SwapChainDesc1*, int>)@this->LpVtbl[18])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1<TThis>(this TThis thisVtbl, ref SwapChainDesc1 pDesc) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, SwapChainDesc1*, int>)@this->LpVtbl[18])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenDesc<TThis>(this TThis thisVtbl, SwapChainFullscreenDesc* pDesc) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, SwapChainFullscreenDesc*, int>)@this->LpVtbl[19])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFullscreenDesc<TThis>(this TThis thisVtbl, ref SwapChainFullscreenDesc pDesc) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SwapChainFullscreenDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, SwapChainFullscreenDesc*, int>)@this->LpVtbl[19])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetHwnd<TThis>(this TThis thisVtbl, nint* pHwnd) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, nint*, int>)@this->LpVtbl[20])(@this, pHwnd);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetHwnd<TThis>(this TThis thisVtbl, ref nint pHwnd) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nint* pHwndPtr = &pHwnd)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, nint*, int>)@this->LpVtbl[20])(@this, pHwndPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, Guid* refiid, void** ppUnk) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiid, ppUnk);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, Guid* refiid, ref void* ppUnk) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppUnkPtr = &ppUnk)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiid, ppUnkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, ref Guid refiid, void** ppUnk) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refiidPtr = &refiid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiidPtr, ppUnk);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, ref Guid refiid, ref void* ppUnk) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refiidPtr = &refiid)
        {
            fixed (void** ppUnkPtr = &ppUnk)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiidPtr, ppUnkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present1<TThis>(this TThis thisVtbl, uint SyncInterval, uint PresentFlags, PresentParameters* pPresentParameters) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, PresentParameters*, int>)@this->LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Present1<TThis>(this TThis thisVtbl, uint SyncInterval, uint PresentFlags, ref PresentParameters pPresentParameters) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PresentParameters* pPresentParametersPtr = &pPresentParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, PresentParameters*, int>)@this->LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsTemporaryMonoSupported<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, int>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRestrictToOutput<TThis>(this TThis thisVtbl, IDXGIOutput** ppRestrictToOutput) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, IDXGIOutput**, int>)@this->LpVtbl[24])(@this, ppRestrictToOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRestrictToOutput<TThis>(this TThis thisVtbl, ref IDXGIOutput* ppRestrictToOutput) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput** ppRestrictToOutputPtr = &ppRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, IDXGIOutput**, int>)@this->LpVtbl[24])(@this, ppRestrictToOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundColor<TThis>(this TThis thisVtbl, D3Dcolorvalue* pColor) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, D3Dcolorvalue*, int>)@this->LpVtbl[25])(@this, pColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBackgroundColor<TThis>(this TThis thisVtbl, ref D3Dcolorvalue pColor) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (D3Dcolorvalue* pColorPtr = &pColor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, D3Dcolorvalue*, int>)@this->LpVtbl[25])(@this, pColorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackgroundColor<TThis>(this TThis thisVtbl, D3Dcolorvalue* pColor) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, D3Dcolorvalue*, int>)@this->LpVtbl[26])(@this, pColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBackgroundColor<TThis>(this TThis thisVtbl, ref D3Dcolorvalue pColor) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (D3Dcolorvalue* pColorPtr = &pColor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, D3Dcolorvalue*, int>)@this->LpVtbl[26])(@this, pColorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRotation<TThis>(this TThis thisVtbl, ModeRotation Rotation) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, ModeRotation, int>)@this->LpVtbl[27])(@this, Rotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRotation<TThis>(this TThis thisVtbl, ModeRotation* pRotation) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, ModeRotation*, int>)@this->LpVtbl[28])(@this, pRotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRotation<TThis>(this TThis thisVtbl, ref ModeRotation pRotation) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeRotation* pRotationPtr = &pRotation)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, ModeRotation*, int>)@this->LpVtbl[28])(@this, pRotationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceSize<TThis>(this TThis thisVtbl, uint Width, uint Height) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, int>)@this->LpVtbl[29])(@this, Width, Height);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceSize<TThis>(this TThis thisVtbl, uint* pWidth, uint* pHeight) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint*, uint*, int>)@this->LpVtbl[30])(@this, pWidth, pHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceSize<TThis>(this TThis thisVtbl, uint* pWidth, ref uint pHeight) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pHeightPtr = &pHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint*, uint*, int>)@this->LpVtbl[30])(@this, pWidth, pHeightPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceSize<TThis>(this TThis thisVtbl, ref uint pWidth, uint* pHeight) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pWidthPtr = &pWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint*, uint*, int>)@this->LpVtbl[30])(@this, pWidthPtr, pHeight);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceSize<TThis>(this TThis thisVtbl, ref uint pWidth, ref uint pHeight) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pWidthPtr = &pWidth)
        {
            fixed (uint* pHeightPtr = &pHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint*, uint*, int>)@this->LpVtbl[30])(@this, pWidthPtr, pHeightPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaximumFrameLatency<TThis>(this TThis thisVtbl, uint MaxLatency) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, int>)@this->LpVtbl[31])(@this, MaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumFrameLatency<TThis>(this TThis thisVtbl, uint* pMaxLatency) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint*, int>)@this->LpVtbl[32])(@this, pMaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumFrameLatency<TThis>(this TThis thisVtbl, ref uint pMaxLatency) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pMaxLatencyPtr = &pMaxLatency)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint*, int>)@this->LpVtbl[32])(@this, pMaxLatencyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetFrameLatencyWaitableObject<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, void*>)@this->LpVtbl[33])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetMatrixTransform<TThis>(this TThis thisVtbl, Matrix3X2F* pMatrix) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Matrix3X2F*, int>)@this->LpVtbl[34])(@this, pMatrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMatrixTransform<TThis>(this TThis thisVtbl, ref Matrix3X2F pMatrix) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Matrix3X2F* pMatrixPtr = &pMatrix)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Matrix3X2F*, int>)@this->LpVtbl[34])(@this, pMatrixPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatrixTransform<TThis>(this TThis thisVtbl, Matrix3X2F* pMatrix) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Matrix3X2F*, int>)@this->LpVtbl[35])(@this, pMatrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMatrixTransform<TThis>(this TThis thisVtbl, ref Matrix3X2F pMatrix) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Matrix3X2F* pMatrixPtr = &pMatrix)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, Matrix3X2F*, int>)@this->LpVtbl[35])(@this, pMatrixPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetCurrentBackBufferIndex<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint>)@this->LpVtbl[36])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckColorSpaceSupport<TThis>(this TThis thisVtbl, ColorSpaceType ColorSpace, uint* pColorSpaceSupport) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, ColorSpaceType, uint*, int>)@this->LpVtbl[37])(@this, ColorSpace, pColorSpaceSupport);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckColorSpaceSupport<TThis>(this TThis thisVtbl, ColorSpaceType ColorSpace, ref uint pColorSpaceSupport) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pColorSpaceSupportPtr = &pColorSpaceSupport)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, ColorSpaceType, uint*, int>)@this->LpVtbl[37])(@this, ColorSpace, pColorSpaceSupportPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetColorSpace1<TThis>(this TThis thisVtbl, ColorSpaceType ColorSpace) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, ColorSpaceType, int>)@this->LpVtbl[38])(@this, ColorSpace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResizeBuffers1<TThis>(this TThis thisVtbl, uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format Format, uint SwapChainFlags, uint* pCreationNodeMask, Silk.NET.Core.Native.IUnknown** ppPresentQueue) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, uint, Silk.NET.DXGI.Format, uint, uint*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[39])(@this, BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMask, ppPresentQueue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResizeBuffers1<TThis>(this TThis thisVtbl, uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format Format, uint SwapChainFlags, uint* pCreationNodeMask, ref Silk.NET.Core.Native.IUnknown* ppPresentQueue) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** ppPresentQueuePtr = &ppPresentQueue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, uint, Silk.NET.DXGI.Format, uint, uint*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[39])(@this, BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMask, ppPresentQueuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResizeBuffers1<TThis>(this TThis thisVtbl, uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format Format, uint SwapChainFlags, ref uint pCreationNodeMask, Silk.NET.Core.Native.IUnknown** ppPresentQueue) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCreationNodeMaskPtr = &pCreationNodeMask)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, uint, Silk.NET.DXGI.Format, uint, uint*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[39])(@this, BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMaskPtr, ppPresentQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResizeBuffers1<TThis>(this TThis thisVtbl, uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format Format, uint SwapChainFlags, ref uint pCreationNodeMask, ref Silk.NET.Core.Native.IUnknown* ppPresentQueue) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCreationNodeMaskPtr = &pCreationNodeMask)
        {
            fixed (Silk.NET.Core.Native.IUnknown** ppPresentQueuePtr = &ppPresentQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain3*, uint, uint, uint, Silk.NET.DXGI.Format, uint, uint*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[39])(@this, BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMaskPtr, ppPresentQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppParent) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppParent) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppDevice) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppDevice) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, Span<Guid> riid, void** ppSurface) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBuffer(Buffer, ref riid.GetPinnableReference(), ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBuffer<TThis>(this TThis thisVtbl, uint Buffer, Span<Guid> riid, ref void* ppSurface) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBuffer(Buffer, ref riid.GetPinnableReference(), ref ppSurface);
    }

    /// <summary>To be documented.</summary>
    public static int SetFullscreenState<TThis>(this TThis thisVtbl, int Fullscreen, Span<IDXGIOutput> pTarget) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetFullscreenState(Fullscreen, ref pTarget.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, Span<int> pFullscreen, IDXGIOutput** ppTarget) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFullscreenState(ref pFullscreen.GetPinnableReference(), ppTarget);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFullscreenState<TThis>(this TThis thisVtbl, Span<int> pFullscreen, ref IDXGIOutput* ppTarget) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFullscreenState(ref pFullscreen.GetPinnableReference(), ref ppTarget);
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, Span<SwapChainDesc> pDesc) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ResizeTarget<TThis>(this TThis thisVtbl, Span<ModeDesc> pNewTargetParameters) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ResizeTarget(ref pNewTargetParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatistics<TThis>(this TThis thisVtbl, Span<FrameStatistics> pStats) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFrameStatistics(ref pStats.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLastPresentCount<TThis>(this TThis thisVtbl, Span<uint> pLastPresentCount) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetLastPresentCount(ref pLastPresentCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1<TThis>(this TThis thisVtbl, Span<SwapChainDesc1> pDesc) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDesc1(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFullscreenDesc<TThis>(this TThis thisVtbl, Span<SwapChainFullscreenDesc> pDesc) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFullscreenDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetHwnd<TThis>(this TThis thisVtbl, Span<nint> pHwnd) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetHwnd(ref pHwnd.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, Span<Guid> refiid, void** ppUnk) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCoreWindow(ref refiid.GetPinnableReference(), ppUnk);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCoreWindow<TThis>(this TThis thisVtbl, Span<Guid> refiid, ref void* ppUnk) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCoreWindow(ref refiid.GetPinnableReference(), ref ppUnk);
    }

    /// <summary>To be documented.</summary>
    public static int Present1<TThis>(this TThis thisVtbl, uint SyncInterval, uint PresentFlags, Span<PresentParameters> pPresentParameters) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present1(SyncInterval, PresentFlags, ref pPresentParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetBackgroundColor<TThis>(this TThis thisVtbl, Span<D3Dcolorvalue> pColor) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetBackgroundColor(ref pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBackgroundColor<TThis>(this TThis thisVtbl, Span<D3Dcolorvalue> pColor) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetBackgroundColor(ref pColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRotation<TThis>(this TThis thisVtbl, Span<ModeRotation> pRotation) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetRotation(ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceSize<TThis>(this TThis thisVtbl, uint* pWidth, Span<uint> pHeight) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSourceSize(pWidth, ref pHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceSize<TThis>(this TThis thisVtbl, Span<uint> pWidth, uint* pHeight) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSourceSize(ref pWidth.GetPinnableReference(), pHeight);
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceSize<TThis>(this TThis thisVtbl, Span<uint> pWidth, Span<uint> pHeight) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSourceSize(ref pWidth.GetPinnableReference(), ref pHeight.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumFrameLatency<TThis>(this TThis thisVtbl, Span<uint> pMaxLatency) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetMaximumFrameLatency(ref pMaxLatency.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetMatrixTransform<TThis>(this TThis thisVtbl, Span<Matrix3X2F> pMatrix) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetMatrixTransform(ref pMatrix.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMatrixTransform<TThis>(this TThis thisVtbl, Span<Matrix3X2F> pMatrix) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetMatrixTransform(ref pMatrix.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CheckColorSpaceSupport<TThis>(this TThis thisVtbl, ColorSpaceType ColorSpace, Span<uint> pColorSpaceSupport) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckColorSpaceSupport(ColorSpace, ref pColorSpaceSupport.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResizeBuffers1<TThis>(this TThis thisVtbl, uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format Format, uint SwapChainFlags, Span<uint> pCreationNodeMask, Silk.NET.Core.Native.IUnknown** ppPresentQueue) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ResizeBuffers1(BufferCount, Width, Height, Format, SwapChainFlags, ref pCreationNodeMask.GetPinnableReference(), ppPresentQueue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResizeBuffers1<TThis>(this TThis thisVtbl, uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format Format, uint SwapChainFlags, Span<uint> pCreationNodeMask, ref Silk.NET.Core.Native.IUnknown* ppPresentQueue) where TThis : IComVtbl<IDXGISwapChain3>
    {
        var @this = (IDXGISwapChain3*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ResizeBuffers1(BufferCount, Width, Height, Format, SwapChainFlags, ref pCreationNodeMask.GetPinnableReference(), ref ppPresentQueue);
    }

}
