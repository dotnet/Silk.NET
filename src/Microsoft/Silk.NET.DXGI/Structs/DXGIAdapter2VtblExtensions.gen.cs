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

public unsafe static class DXGIAdapter2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumOutputs<TThis>(this TThis thisVtbl, uint Output, IDXGIOutput** ppOutput) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, uint, IDXGIOutput**, int>)@this->LpVtbl[7])(@this, Output, ppOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumOutputs<TThis>(this TThis thisVtbl, uint Output, ref IDXGIOutput* ppOutput) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, uint, IDXGIOutput**, int>)@this->LpVtbl[7])(@this, Output, ppOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, AdapterDesc* pDesc) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, AdapterDesc*, int>)@this->LpVtbl[8])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref AdapterDesc pDesc) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (AdapterDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, AdapterDesc*, int>)@this->LpVtbl[8])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport<TThis>(this TThis thisVtbl, Guid* InterfaceName, long* pUMDVersion) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceName, pUMDVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport<TThis>(this TThis thisVtbl, Guid* InterfaceName, ref long pUMDVersion) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (long* pUMDVersionPtr = &pUMDVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceName, pUMDVersionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport<TThis>(this TThis thisVtbl, ref Guid InterfaceName, long* pUMDVersion) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* InterfaceNamePtr = &InterfaceName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceNamePtr, pUMDVersion);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckInterfaceSupport<TThis>(this TThis thisVtbl, ref Guid InterfaceName, ref long pUMDVersion) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* InterfaceNamePtr = &InterfaceName)
        {
            fixed (long* pUMDVersionPtr = &pUMDVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceNamePtr, pUMDVersionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc1<TThis>(this TThis thisVtbl, AdapterDesc1* pDesc) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, AdapterDesc1*, int>)@this->LpVtbl[10])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1<TThis>(this TThis thisVtbl, ref AdapterDesc1 pDesc) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (AdapterDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, AdapterDesc1*, int>)@this->LpVtbl[10])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc2<TThis>(this TThis thisVtbl, AdapterDesc2* pDesc) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, AdapterDesc2*, int>)@this->LpVtbl[11])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc2<TThis>(this TThis thisVtbl, ref AdapterDesc2 pDesc) where TThis : IComVtbl<IDXGIAdapter2>
    {
        var @this = (IDXGIAdapter2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (AdapterDesc2* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter2*, AdapterDesc2*, int>)@this->LpVtbl[11])(@this, pDescPtr);
        }
        return ret;
    }

}
