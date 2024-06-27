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

public unsafe static class DXGIOutput4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutput4> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutput4> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGIOutput4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGIOutput4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutput4> thisVtbl, Guid* riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutput4> thisVtbl, Guid* riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<IDXGIOutput4> thisVtbl, OutputDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, OutputDesc*, int>)@this->LpVtbl[7])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<IDXGIOutput4> thisVtbl, ref OutputDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (OutputDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, OutputDesc*, int>)@this->LpVtbl[7])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pNumModesPtr = &pNumModes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeList(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pNumModesPtr = &pNumModes)
        {
            fixed (ModeDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WaitForVBlank(this ComPtr<IDXGIOutput4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, int>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TakeOwnership(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, Silk.NET.Core.Bool32 Exclusive)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[11])(@this, pDevice, Exclusive);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TakeOwnership(this ComPtr<IDXGIOutput4> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, Silk.NET.Core.Bool32 Exclusive)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[11])(@this, pDevicePtr, Exclusive);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseOwnership(this ComPtr<IDXGIOutput4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, void>)@this->LpVtbl[12])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGammaControlCapabilities(this ComPtr<IDXGIOutput4> thisVtbl, GammaControlCapabilities* pGammaCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControlCapabilities*, int>)@this->LpVtbl[13])(@this, pGammaCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGammaControlCapabilities(this ComPtr<IDXGIOutput4> thisVtbl, ref GammaControlCapabilities pGammaCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GammaControlCapabilities* pGammaCapsPtr = &pGammaCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControlCapabilities*, int>)@this->LpVtbl[13])(@this, pGammaCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetGammaControl(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GammaControl* pArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControl*, int>)@this->LpVtbl[14])(@this, pArray);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGammaControl(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GammaControl pArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GammaControl* pArrayPtr = &pArray)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControl*, int>)@this->LpVtbl[14])(@this, pArrayPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGammaControl(this ComPtr<IDXGIOutput4> thisVtbl, GammaControl* pArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControl*, int>)@this->LpVtbl[15])(@this, pArray);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGammaControl(this ComPtr<IDXGIOutput4> thisVtbl, ref GammaControl pArray)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GammaControl* pArrayPtr = &pArray)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControl*, int>)@this->LpVtbl[15])(@this, pArrayPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDisplaySurface(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.IDXGISurface* pScanoutSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[16])(@this, pScanoutSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDisplaySurface(this ComPtr<IDXGIOutput4> thisVtbl, ref Silk.NET.DXGI.IDXGISurface pScanoutSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* pScanoutSurfacePtr = &pScanoutSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[16])(@this, pScanoutSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplaySurfaceData(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.IDXGISurface* pDestination)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[17])(@this, pDestination);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplaySurfaceData(this ComPtr<IDXGIOutput4> thisVtbl, ref Silk.NET.DXGI.IDXGISurface pDestination)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface* pDestinationPtr = &pDestination)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.IDXGISurface*, int>)@this->LpVtbl[17])(@this, pDestinationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameStatistics(this ComPtr<IDXGIOutput4> thisVtbl, FrameStatistics* pStats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, FrameStatistics*, int>)@this->LpVtbl[18])(@this, pStats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatistics(this ComPtr<IDXGIOutput4> thisVtbl, ref FrameStatistics pStats)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FrameStatistics* pStatsPtr = &pStats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, FrameStatistics*, int>)@this->LpVtbl[18])(@this, pStatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList1(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc1* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList1(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc1 pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList1(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc1* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pNumModesPtr = &pNumModes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeList1(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc1 pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pNumModesPtr = &pNumModes)
        {
            fixed (ModeDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplaySurfaceData1(this ComPtr<IDXGIOutput4> thisVtbl, IDXGIResource* pDestination)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, IDXGIResource*, int>)@this->LpVtbl[21])(@this, pDestination);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplaySurfaceData1(this ComPtr<IDXGIOutput4> thisVtbl, ref IDXGIResource pDestination)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIResource* pDestinationPtr = &pDestination)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, IDXGIResource*, int>)@this->LpVtbl[21])(@this, pDestinationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevice, ppOutputDuplication);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref IDXGIOutputDuplication* ppOutputDuplication)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevice, ppOutputDuplicationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput(this ComPtr<IDXGIOutput4> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, IDXGIOutputDuplication** ppOutputDuplication)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevicePtr, ppOutputDuplication);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput(this ComPtr<IDXGIOutput4> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref IDXGIOutputDuplication* ppOutputDuplication)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevicePtr, ppOutputDuplicationPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 SupportsOverlays(this ComPtr<IDXGIOutput4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Bool32>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlaySupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlaySupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, ref uint pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pFlagsPtr = &pFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlaySupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckOverlaySupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, ref uint pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlagsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlayColorSpaceSupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, Silk.NET.Core.Native.IUnknown* pConcernedDevice, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlayColorSpaceSupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, Silk.NET.Core.Native.IUnknown* pConcernedDevice, ref uint pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pFlagsPtr = &pFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlayColorSpaceSupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckOverlayColorSpaceSupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, ref uint pFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlagsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIOutput4> thisVtbl, Span<Guid> riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<IDXGIOutput4> thisVtbl, Span<OutputDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, Span<ModeDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeList(EnumFormat, Flags, pNumModes, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, Span<uint> pNumModes, ModeDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeList(EnumFormat, Flags, ref pNumModes.GetPinnableReference(), pDesc);
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeList(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, Span<uint> pNumModes, Span<ModeDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeList(EnumFormat, Flags, ref pNumModes.GetPinnableReference(), ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindClosestMatchingMode(pModeToMatch, pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode(pModeToMatch, pClosestMatch, ref pConcernedDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, Span<ModeDesc> pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode(pModeToMatch, ref pClosestMatch.GetPinnableReference(), pConcernedDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindClosestMatchingMode(pModeToMatch, ref pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pModeToMatch, Span<ModeDesc> pClosestMatch, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode(pModeToMatch, ref pClosestMatch.GetPinnableReference(), ref pConcernedDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ModeDesc> pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode(in pModeToMatch.GetPinnableReference(), pClosestMatch, pConcernedDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ModeDesc* pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindClosestMatchingMode(in pModeToMatch, pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ModeDesc> pModeToMatch, ModeDesc* pClosestMatch, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode(in pModeToMatch.GetPinnableReference(), pClosestMatch, ref pConcernedDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ModeDesc> pModeToMatch, Span<ModeDesc> pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode(in pModeToMatch.GetPinnableReference(), ref pClosestMatch.GetPinnableReference(), pConcernedDevice);
    }

    /// <summary>To be documented.</summary>
    public static int FindClosestMatchingMode<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindClosestMatchingMode(in pModeToMatch, ref pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int FindClosestMatchingMode(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ModeDesc> pModeToMatch, Span<ModeDesc> pClosestMatch, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode(in pModeToMatch.GetPinnableReference(), ref pClosestMatch.GetPinnableReference(), ref pConcernedDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int TakeOwnership<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, ComPtr<TI0> pDevice, Silk.NET.Core.Bool32 Exclusive) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TakeOwnership((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, Exclusive);
    }

    /// <summary>To be documented.</summary>
    public static int TakeOwnership(this ComPtr<IDXGIOutput4> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, Silk.NET.Core.Bool32 Exclusive)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TakeOwnership(ref pDevice.GetPinnableReference(), Exclusive);
    }

    /// <summary>To be documented.</summary>
    public static int GetGammaControlCapabilities(this ComPtr<IDXGIOutput4> thisVtbl, Span<GammaControlCapabilities> pGammaCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGammaControlCapabilities(ref pGammaCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetGammaControl(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GammaControl> pArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetGammaControl(in pArray.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetGammaControl(this ComPtr<IDXGIOutput4> thisVtbl, Span<GammaControl> pArray)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGammaControl(ref pArray.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetDisplaySurface<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, ComPtr<TI0> pScanoutSurface) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetDisplaySurface((Silk.NET.DXGI.IDXGISurface*) pScanoutSurface.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetDisplaySurface(this ComPtr<IDXGIOutput4> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> pScanoutSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetDisplaySurface(ref pScanoutSurface.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplaySurfaceData<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, ComPtr<TI0> pDestination) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDisplaySurfaceData((Silk.NET.DXGI.IDXGISurface*) pDestination.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplaySurfaceData(this ComPtr<IDXGIOutput4> thisVtbl, Span<Silk.NET.DXGI.IDXGISurface> pDestination)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplaySurfaceData(ref pDestination.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatistics(this ComPtr<IDXGIOutput4> thisVtbl, Span<FrameStatistics> pStats)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameStatistics(ref pStats.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList1(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, Span<ModeDesc1> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeList1(EnumFormat, Flags, pNumModes, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList1(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, Span<uint> pNumModes, ModeDesc1* pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeList1(EnumFormat, Flags, ref pNumModes.GetPinnableReference(), pDesc);
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeList1(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, Span<uint> pNumModes, Span<ModeDesc1> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeList1(EnumFormat, Flags, ref pNumModes.GetPinnableReference(), ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindClosestMatchingMode1(pModeToMatch, pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode1(pModeToMatch, pClosestMatch, ref pConcernedDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, Span<ModeDesc1> pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode1(pModeToMatch, ref pClosestMatch.GetPinnableReference(), pConcernedDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindClosestMatchingMode1(pModeToMatch, ref pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc1* pModeToMatch, Span<ModeDesc1> pClosestMatch, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode1(pModeToMatch, ref pClosestMatch.GetPinnableReference(), ref pConcernedDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ModeDesc1> pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode1(in pModeToMatch.GetPinnableReference(), pClosestMatch, pConcernedDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindClosestMatchingMode1(in pModeToMatch, pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ModeDesc1> pModeToMatch, ModeDesc1* pClosestMatch, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode1(in pModeToMatch.GetPinnableReference(), pClosestMatch, ref pConcernedDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ModeDesc1> pModeToMatch, Span<ModeDesc1> pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode1(in pModeToMatch.GetPinnableReference(), ref pClosestMatch.GetPinnableReference(), pConcernedDevice);
    }

    /// <summary>To be documented.</summary>
    public static int FindClosestMatchingMode1<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, ComPtr<TI0> pConcernedDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindClosestMatchingMode1(in pModeToMatch, ref pClosestMatch, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int FindClosestMatchingMode1(this ComPtr<IDXGIOutput4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ModeDesc1> pModeToMatch, Span<ModeDesc1> pClosestMatch, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindClosestMatchingMode1(in pModeToMatch.GetPinnableReference(), ref pClosestMatch.GetPinnableReference(), ref pConcernedDevice.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplaySurfaceData1<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, ComPtr<TI0> pDestination) where TI0 : unmanaged, IComVtbl<IDXGIResource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDisplaySurfaceData1((IDXGIResource*) pDestination.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplaySurfaceData1(this ComPtr<IDXGIOutput4> thisVtbl, Span<IDXGIResource> pDestination)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplaySurfaceData1(ref pDestination.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DuplicateOutput<TI0, TI1>(this ComPtr<IDXGIOutput4> thisVtbl, ComPtr<TI0> pDevice, ref ComPtr<TI1> ppOutputDuplication) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDXGIOutputDuplication>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DuplicateOutput((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, (IDXGIOutputDuplication**) ppOutputDuplication.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, ComPtr<TI0> pDevice, ref IDXGIOutputDuplication* ppOutputDuplication) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DuplicateOutput((Silk.NET.Core.Native.IUnknown*) pDevice.Handle, ref ppOutputDuplication);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput(this ComPtr<IDXGIOutput4> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, IDXGIOutputDuplication** ppOutputDuplication)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DuplicateOutput(ref pDevice.GetPinnableReference(), ppOutputDuplication);
    }

    /// <summary>To be documented.</summary>
    public static int DuplicateOutput<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref ComPtr<TI0> ppOutputDuplication) where TI0 : unmanaged, IComVtbl<IDXGIOutputDuplication>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DuplicateOutput(ref pDevice, (IDXGIOutputDuplication**) ppOutputDuplication.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput(this ComPtr<IDXGIOutput4> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pDevice, ref IDXGIOutputDuplication* ppOutputDuplication)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DuplicateOutput(ref pDevice.GetPinnableReference(), ref ppOutputDuplication);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlaySupport<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, ComPtr<TI0> pConcernedDevice, uint* pFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CheckOverlaySupport(EnumFormat, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle, pFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlaySupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, Span<uint> pFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckOverlaySupport(EnumFormat, pConcernedDevice, ref pFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CheckOverlaySupport<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, ComPtr<TI0> pConcernedDevice, ref uint pFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CheckOverlaySupport(EnumFormat, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle, ref pFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlaySupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckOverlaySupport(EnumFormat, ref pConcernedDevice.GetPinnableReference(), pFlags);
    }

    /// <summary>To be documented.</summary>
    public static int CheckOverlaySupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format EnumFormat, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice, Span<uint> pFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckOverlaySupport(EnumFormat, ref pConcernedDevice.GetPinnableReference(), ref pFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlayColorSpaceSupport<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, ComPtr<TI0> pConcernedDevice, uint* pFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CheckOverlayColorSpaceSupport(Format, ColorSpace, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle, pFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlayColorSpaceSupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, Silk.NET.Core.Native.IUnknown* pConcernedDevice, Span<uint> pFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckOverlayColorSpaceSupport(Format, ColorSpace, pConcernedDevice, ref pFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CheckOverlayColorSpaceSupport<TI0>(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, ComPtr<TI0> pConcernedDevice, ref uint pFlags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CheckOverlayColorSpaceSupport(Format, ColorSpace, (Silk.NET.Core.Native.IUnknown*) pConcernedDevice.Handle, ref pFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlayColorSpaceSupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice, uint* pFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckOverlayColorSpaceSupport(Format, ColorSpace, ref pConcernedDevice.GetPinnableReference(), pFlags);
    }

    /// <summary>To be documented.</summary>
    public static int CheckOverlayColorSpaceSupport(this ComPtr<IDXGIOutput4> thisVtbl, Silk.NET.DXGI.Format Format, Silk.NET.DXGI.ColorSpaceType ColorSpace, Span<Silk.NET.Core.Native.IUnknown> pConcernedDevice, Span<uint> pFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckOverlayColorSpaceSupport(Format, ColorSpace, ref pConcernedDevice.GetPinnableReference(), ref pFlags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDXGIOutput4> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetParent<TI0>(this ComPtr<IDXGIOutput4> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
