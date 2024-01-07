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

public unsafe static class DXGIFactoryMediaVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactoryMedia> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactoryMedia> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGIFactoryMedia> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGIFactoryMedia> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutput, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SwapChainDesc1* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevice, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurface, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
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
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurface, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDesc, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGISwapChain1** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, SwapChainDesc1*, IDXGIOutput*, IDXGISwapChain1**, int>)@this->LpVtbl[3])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
        {
            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
        {
            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
        {
            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hSurfacePtr = &hSurface)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevice, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurface, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDesc, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChainPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, IDXGIResource* pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffers, pRestrictToOutputPtr, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChain);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutput, ppSwapChainPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChain);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (void* hSurfacePtr = &hSurface)
            {
                fixed (DecodeSwapChainDesc* pDescPtr = &pDesc)
                {
                    fixed (IDXGIResource* pYuvDecodeBuffersPtr = &pYuvDecodeBuffers)
                    {
                        fixed (IDXGIOutput* pRestrictToOutputPtr = &pRestrictToOutput)
                        {
                            fixed (IDXGIDecodeSwapChain** ppSwapChainPtr = &ppSwapChain)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDXGIFactoryMedia*, Silk.NET.Core.Native.IUnknown*, void*, DecodeSwapChainDesc*, IDXGIResource*, IDXGIOutput*, IDXGIDecodeSwapChain**, int>)@this->LpVtbl[4])(@this, pDevicePtr, hSurfacePtr, pDescPtr, pYuvDecodeBuffersPtr, pRestrictToOutputPtr, ppSwapChainPtr);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, hSurface, pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, hSurface, pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, hSurface, in pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, hSurface, in pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, hSurface, in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, hSurface, in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, in pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), in pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), in pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI1> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, in pDesc, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, in pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, in pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDesc1* pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), in pDesc.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, IDXGIOutput* pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), in pDesc.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ComPtr<TI0> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, in pDesc, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, IDXGISwapChain1** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapChainDesc1 pDesc, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGISwapChain1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, in pDesc, ref pRestrictToOutput, (IDXGISwapChain1**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapChainDesc1> pDesc, Span<IDXGIOutput> pRestrictToOutput, ref IDXGISwapChain1* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), in pDesc.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2, TI3>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI1> pYuvDecodeBuffers, ComPtr<TI2> pRestrictToOutput, ref ComPtr<TI3> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI3>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI1> pYuvDecodeBuffers, ComPtr<TI2> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, pDesc, pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI1> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, pDesc, pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI1> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2, TI3>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI1> pYuvDecodeBuffers, ComPtr<TI2> pRestrictToOutput, ref ComPtr<TI3> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI3>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI1> pYuvDecodeBuffers, ComPtr<TI2> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI1> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI1> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, ref pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, ref pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, ref pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, hSurface, ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, hSurface, ref pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2, TI3>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI1> pYuvDecodeBuffers, ComPtr<TI2> pRestrictToOutput, ref ComPtr<TI3> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI3>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, pYuvDecodeBuffers, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI1> pYuvDecodeBuffers, ComPtr<TI2> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI1> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI1> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2, TI3>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI1> pYuvDecodeBuffers, ComPtr<TI2> pRestrictToOutput, ref ComPtr<TI3> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI3>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI1> pYuvDecodeBuffers, ComPtr<TI2> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI1> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI1> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, ref pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, ref pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, ref pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(pDevice, ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ComPtr<TI0> pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref hSurface, ref pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI0> pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, pYuvDecodeBuffers, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI0> pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI0> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI0> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI0> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI0> pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI0> pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI0> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI0> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, ref pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI0> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, ref pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, void* hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, hSurface, ref pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, void* hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), hSurface, ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI0> pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, pYuvDecodeBuffers, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI0> pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI0> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ComPtr<TI0> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI0> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, DecodeSwapChainDesc* pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, DecodeSwapChainDesc* pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), pDesc, ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1, TI2>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI0> pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref ComPtr<TI2> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI0> pYuvDecodeBuffers, ComPtr<TI1> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI0> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, IDXGIResource* pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), pYuvDecodeBuffers, ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ComPtr<TI0> pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, ref pDesc, (IDXGIResource*) pYuvDecodeBuffers.Handle, ref pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0, TI1>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI0> pRestrictToOutput, ref ComPtr<TI1> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, ref pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, IDXGIOutput* pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), pRestrictToOutput, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ComPtr<TI0> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, ref pDesc, ref pYuvDecodeBuffers, (IDXGIOutput*) pRestrictToOutput.Handle, ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, IDXGIDecodeSwapChain** ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDecodeSwapChainForCompositionSurfaceHandle<T0, TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref T0 hSurface, ref DecodeSwapChainDesc pDesc, ref IDXGIResource pYuvDecodeBuffers, ref IDXGIOutput pRestrictToOutput, ref ComPtr<TI0> ppSwapChain) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDXGIDecodeSwapChain>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice, ref hSurface, ref pDesc, ref pYuvDecodeBuffers, ref pRestrictToOutput, (IDXGIDecodeSwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDecodeSwapChainForCompositionSurfaceHandle<T0>(this ComPtr<IDXGIFactoryMedia> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Span<T0> hSurface, Span<DecodeSwapChainDesc> pDesc, Span<IDXGIResource> pYuvDecodeBuffers, Span<IDXGIOutput> pRestrictToOutput, ref IDXGIDecodeSwapChain* ppSwapChain) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDecodeSwapChainForCompositionSurfaceHandle(ref pDevice.GetPinnableReference(), ref hSurface.GetPinnableReference(), ref pDesc.GetPinnableReference(), ref pYuvDecodeBuffers.GetPinnableReference(), ref pRestrictToOutput.GetPinnableReference(), ref ppSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDXGIFactoryMedia> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
