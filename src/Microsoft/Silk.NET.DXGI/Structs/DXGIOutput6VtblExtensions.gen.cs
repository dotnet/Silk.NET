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

public unsafe static class DXGIOutput6VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, OutputDesc* pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDesc*, int>)@this->LpVtbl[7])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref OutputDesc pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (OutputDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDesc*, int>)@this->LpVtbl[7])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc* pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc* pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pNumModesPtr = &pNumModes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeList<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pNumModesPtr = &pNumModes)
        {
            fixed (ModeDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)@this->LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode<TThis>(this TThis thisVtbl, ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode<TThis>(this TThis thisVtbl, ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode<TThis>(this TThis thisVtbl, ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode<TThis>(this TThis thisVtbl, ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode<TThis>(this TThis thisVtbl, ref ModeDesc pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode<TThis>(this TThis thisVtbl, ref ModeDesc pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode<TThis>(this TThis thisVtbl, ref ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindClosestMatchingMode<TThis>(this TThis thisVtbl, ref ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WaitForVBlank<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, int>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TakeOwnership<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, int Exclusive) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, int, int>)@this->LpVtbl[11])(@this, pDevice, Exclusive);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TakeOwnership<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, int Exclusive) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, int, int>)@this->LpVtbl[11])(@this, pDevicePtr, Exclusive);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseOwnership<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, void>)@this->LpVtbl[12])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGammaControlCapabilities<TThis>(this TThis thisVtbl, GammaControlCapabilities* pGammaCaps) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControlCapabilities*, int>)@this->LpVtbl[13])(@this, pGammaCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGammaControlCapabilities<TThis>(this TThis thisVtbl, ref GammaControlCapabilities pGammaCaps) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (GammaControlCapabilities* pGammaCapsPtr = &pGammaCaps)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControlCapabilities*, int>)@this->LpVtbl[13])(@this, pGammaCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetGammaControl<TThis>(this TThis thisVtbl, GammaControl* pArray) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControl*, int>)@this->LpVtbl[14])(@this, pArray);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGammaControl<TThis>(this TThis thisVtbl, ref GammaControl pArray) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (GammaControl* pArrayPtr = &pArray)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControl*, int>)@this->LpVtbl[14])(@this, pArrayPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGammaControl<TThis>(this TThis thisVtbl, GammaControl* pArray) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControl*, int>)@this->LpVtbl[15])(@this, pArray);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGammaControl<TThis>(this TThis thisVtbl, ref GammaControl pArray) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (GammaControl* pArrayPtr = &pArray)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, GammaControl*, int>)@this->LpVtbl[15])(@this, pArrayPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDisplaySurface<TThis>(this TThis thisVtbl, IDXGISurface* pScanoutSurface) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGISurface*, int>)@this->LpVtbl[16])(@this, pScanoutSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDisplaySurface<TThis>(this TThis thisVtbl, ref IDXGISurface pScanoutSurface) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGISurface* pScanoutSurfacePtr = &pScanoutSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGISurface*, int>)@this->LpVtbl[16])(@this, pScanoutSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplaySurfaceData<TThis>(this TThis thisVtbl, IDXGISurface* pDestination) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGISurface*, int>)@this->LpVtbl[17])(@this, pDestination);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplaySurfaceData<TThis>(this TThis thisVtbl, ref IDXGISurface pDestination) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGISurface* pDestinationPtr = &pDestination)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGISurface*, int>)@this->LpVtbl[17])(@this, pDestinationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameStatistics<TThis>(this TThis thisVtbl, FrameStatistics* pStats) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, FrameStatistics*, int>)@this->LpVtbl[18])(@this, pStats);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatistics<TThis>(this TThis thisVtbl, ref FrameStatistics pStats) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (FrameStatistics* pStatsPtr = &pStats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, FrameStatistics*, int>)@this->LpVtbl[18])(@this, pStatsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList1<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc1* pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList1<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc1 pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeList1<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc1* pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pNumModesPtr = &pNumModes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeList1<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc1 pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pNumModesPtr = &pNumModes)
        {
            fixed (ModeDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)@this->LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1<TThis>(this TThis thisVtbl, ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1<TThis>(this TThis thisVtbl, ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1<TThis>(this TThis thisVtbl, ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1<TThis>(this TThis thisVtbl, ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1<TThis>(this TThis thisVtbl, ref ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1<TThis>(this TThis thisVtbl, ref ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindClosestMatchingMode1<TThis>(this TThis thisVtbl, ref ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindClosestMatchingMode1<TThis>(this TThis thisVtbl, ref ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
        {
            fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplaySurfaceData1<TThis>(this TThis thisVtbl, IDXGIResource* pDestination) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGIResource*, int>)@this->LpVtbl[21])(@this, pDestination);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplaySurfaceData1<TThis>(this TThis thisVtbl, ref IDXGIResource pDestination) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIResource* pDestinationPtr = &pDestination)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, IDXGIResource*, int>)@this->LpVtbl[21])(@this, pDestinationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevice, ppOutputDuplication);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, ref IDXGIOutputDuplication* ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevice, ppOutputDuplicationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, IDXGIOutputDuplication** ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevicePtr, ppOutputDuplication);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, ref IDXGIOutputDuplication* ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)@this->LpVtbl[22])(@this, pDevicePtr, ppOutputDuplicationPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SupportsOverlays<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, int>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlaySupport<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, uint* pFlags) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlaySupport<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, ref uint pFlags) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pFlagsPtr = &pFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlaySupport<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, uint* pFlags) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckOverlaySupport<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format EnumFormat, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, ref uint pFlags) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlagsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlayColorSpaceSupport<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format Format, ColorSpaceType ColorSpace, Silk.NET.Core.Native.IUnknown* pConcernedDevice, uint* pFlags) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlayColorSpaceSupport<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format Format, ColorSpaceType ColorSpace, Silk.NET.Core.Native.IUnknown* pConcernedDevice, ref uint pFlags) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pFlagsPtr = &pFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckOverlayColorSpaceSupport<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format Format, ColorSpaceType ColorSpace, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, uint* pFlags) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckOverlayColorSpaceSupport<TThis>(this TThis thisVtbl, Silk.NET.DXGI.Format Format, ColorSpaceType ColorSpace, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, ref uint pFlags) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
        {
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)@this->LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlagsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput1<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, uint SupportedFormatsCount, Silk.NET.DXGI.Format* pSupportedFormats, IDXGIOutputDuplication** ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevice, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplication);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput1<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, uint SupportedFormatsCount, Silk.NET.DXGI.Format* pSupportedFormats, ref IDXGIOutputDuplication* ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevice, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplicationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput1<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, uint SupportedFormatsCount, ref Silk.NET.DXGI.Format pSupportedFormats, IDXGIOutputDuplication** ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Format* pSupportedFormatsPtr = &pSupportedFormats)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevice, Flags, SupportedFormatsCount, pSupportedFormatsPtr, ppOutputDuplication);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput1<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.IUnknown* pDevice, uint Flags, uint SupportedFormatsCount, ref Silk.NET.DXGI.Format pSupportedFormats, ref IDXGIOutputDuplication* ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.Format* pSupportedFormatsPtr = &pSupportedFormats)
        {
            fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevice, Flags, SupportedFormatsCount, pSupportedFormatsPtr, ppOutputDuplicationPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput1<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, uint SupportedFormatsCount, Silk.NET.DXGI.Format* pSupportedFormats, IDXGIOutputDuplication** ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevicePtr, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplication);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput1<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, uint SupportedFormatsCount, Silk.NET.DXGI.Format* pSupportedFormats, ref IDXGIOutputDuplication* ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevicePtr, Flags, SupportedFormatsCount, pSupportedFormats, ppOutputDuplicationPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput1<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, uint SupportedFormatsCount, ref Silk.NET.DXGI.Format pSupportedFormats, IDXGIOutputDuplication** ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.DXGI.Format* pSupportedFormatsPtr = &pSupportedFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevicePtr, Flags, SupportedFormatsCount, pSupportedFormatsPtr, ppOutputDuplication);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DuplicateOutput1<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.IUnknown pDevice, uint Flags, uint SupportedFormatsCount, ref Silk.NET.DXGI.Format pSupportedFormats, ref IDXGIOutputDuplication* ppOutputDuplication) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
        {
            fixed (Silk.NET.DXGI.Format* pSupportedFormatsPtr = &pSupportedFormats)
            {
                fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, Silk.NET.Core.Native.IUnknown*, uint, uint, Silk.NET.DXGI.Format*, IDXGIOutputDuplication**, int>)@this->LpVtbl[26])(@this, pDevicePtr, Flags, SupportedFormatsCount, pSupportedFormatsPtr, ppOutputDuplicationPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc1<TThis>(this TThis thisVtbl, OutputDesc1* pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDesc1*, int>)@this->LpVtbl[27])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1<TThis>(this TThis thisVtbl, ref OutputDesc1 pDesc) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (OutputDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, OutputDesc1*, int>)@this->LpVtbl[27])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckHardwareCompositionSupport<TThis>(this TThis thisVtbl, uint* pFlags) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint*, int>)@this->LpVtbl[28])(@this, pFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckHardwareCompositionSupport<TThis>(this TThis thisVtbl, ref uint pFlags) where TThis : IComVtbl<IDXGIOutput6>
    {
        var @this = (IDXGIOutput6*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pFlagsPtr = &pFlags)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput6*, uint*, int>)@this->LpVtbl[28])(@this, pFlagsPtr);
        }
        return ret;
    }

}
