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

public unsafe static class DXGIAdapter4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumOutputs<TThis>(this TThis thisVtbl, uint Output, IDXGIOutput** ppOutput) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, IDXGIOutput**, int>)@this->LpVtbl[7])(@this, Output, ppOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumOutputs<TThis>(this TThis thisVtbl, uint Output, ref IDXGIOutput* ppOutput) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, IDXGIOutput**, int>)@this->LpVtbl[7])(@this, Output, ppOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, AdapterDesc* pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc*, int>)@this->LpVtbl[8])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref AdapterDesc pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (AdapterDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc*, int>)@this->LpVtbl[8])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport<TThis>(this TThis thisVtbl, Guid* InterfaceName, long* pUMDVersion) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceName, pUMDVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport<TThis>(this TThis thisVtbl, Guid* InterfaceName, ref long pUMDVersion) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (long* pUMDVersionPtr = &pUMDVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceName, pUMDVersionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport<TThis>(this TThis thisVtbl, ref Guid InterfaceName, long* pUMDVersion) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* InterfaceNamePtr = &InterfaceName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceNamePtr, pUMDVersion);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckInterfaceSupport<TThis>(this TThis thisVtbl, ref Guid InterfaceName, ref long pUMDVersion) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* InterfaceNamePtr = &InterfaceName)
        {
            fixed (long* pUMDVersionPtr = &pUMDVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceNamePtr, pUMDVersionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc1<TThis>(this TThis thisVtbl, AdapterDesc1* pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc1*, int>)@this->LpVtbl[10])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1<TThis>(this TThis thisVtbl, ref AdapterDesc1 pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (AdapterDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc1*, int>)@this->LpVtbl[10])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc2<TThis>(this TThis thisVtbl, AdapterDesc2* pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc2*, int>)@this->LpVtbl[11])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc2<TThis>(this TThis thisVtbl, ref AdapterDesc2 pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (AdapterDesc2* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc2*, int>)@this->LpVtbl[11])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterHardwareContentProtectionTeardownStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, uint* pdwCookie) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[12])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterHardwareContentProtectionTeardownStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, ref uint pdwCookie) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[12])(@this, hEvent, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterHardwareContentProtectionTeardownStatusEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[12])(@this, hEventPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterHardwareContentProtectionTeardownStatusEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[12])(@this, hEventPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterHardwareContentProtectionTeardownStatus<TThis>(this TThis thisVtbl, uint dwCookie) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, void>)@this->LpVtbl[13])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryVideoMemoryInfo<TThis>(this TThis thisVtbl, uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, QueryVideoMemoryInfo* pVideoMemoryInfo) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, MemorySegmentGroup, QueryVideoMemoryInfo*, int>)@this->LpVtbl[14])(@this, NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryVideoMemoryInfo<TThis>(this TThis thisVtbl, uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, ref QueryVideoMemoryInfo pVideoMemoryInfo) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (QueryVideoMemoryInfo* pVideoMemoryInfoPtr = &pVideoMemoryInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, MemorySegmentGroup, QueryVideoMemoryInfo*, int>)@this->LpVtbl[14])(@this, NodeIndex, MemorySegmentGroup, pVideoMemoryInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVideoMemoryReservation<TThis>(this TThis thisVtbl, uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, ulong Reservation) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, MemorySegmentGroup, ulong, int>)@this->LpVtbl[15])(@this, NodeIndex, MemorySegmentGroup, Reservation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent<TThis>(this TThis thisVtbl, void* hEvent, uint* pdwCookie) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[16])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent<TThis>(this TThis thisVtbl, void* hEvent, ref uint pdwCookie) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[16])(@this, hEvent, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[16])(@this, hEventPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterVideoMemoryBudgetChangeNotificationEvent<T0, TThis>(this TThis thisVtbl, ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[16])(@this, hEventPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterVideoMemoryBudgetChangeNotification<TThis>(this TThis thisVtbl, uint dwCookie) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, void>)@this->LpVtbl[17])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc3<TThis>(this TThis thisVtbl, AdapterDesc3* pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc3*, int>)@this->LpVtbl[18])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc3<TThis>(this TThis thisVtbl, ref AdapterDesc3 pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (AdapterDesc3* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc3*, int>)@this->LpVtbl[18])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> Name, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppParent) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppParent) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static int EnumOutputs<TI0, TThis>(this TThis thisVtbl, uint Output, ref ComPtr<TI0> ppOutput) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0> where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->EnumOutputs(Output, (IDXGIOutput**) ppOutput.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, Span<AdapterDesc> pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport<TThis>(this TThis thisVtbl, Guid* InterfaceName, Span<long> pUMDVersion) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckInterfaceSupport(InterfaceName, ref pUMDVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport<TThis>(this TThis thisVtbl, Span<Guid> InterfaceName, long* pUMDVersion) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckInterfaceSupport(ref InterfaceName.GetPinnableReference(), pUMDVersion);
    }

    /// <summary>To be documented.</summary>
    public static int CheckInterfaceSupport<TThis>(this TThis thisVtbl, Span<Guid> InterfaceName, Span<long> pUMDVersion) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckInterfaceSupport(ref InterfaceName.GetPinnableReference(), ref pUMDVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1<TThis>(this TThis thisVtbl, Span<AdapterDesc1> pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDesc1(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc2<TThis>(this TThis thisVtbl, Span<AdapterDesc2> pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDesc2(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterHardwareContentProtectionTeardownStatusEvent<TThis>(this TThis thisVtbl, void* hEvent, Span<uint> pdwCookie) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterHardwareContentProtectionTeardownStatusEvent(hEvent, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterHardwareContentProtectionTeardownStatusEvent<T0, TThis>(this TThis thisVtbl, Span<T0> hEvent, uint* pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterHardwareContentProtectionTeardownStatusEvent(ref hEvent.GetPinnableReference(), pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterHardwareContentProtectionTeardownStatusEvent<T0, TThis>(this TThis thisVtbl, Span<T0> hEvent, Span<uint> pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterHardwareContentProtectionTeardownStatusEvent(ref hEvent.GetPinnableReference(), ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int QueryVideoMemoryInfo<TThis>(this TThis thisVtbl, uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, Span<QueryVideoMemoryInfo> pVideoMemoryInfo) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryVideoMemoryInfo(NodeIndex, MemorySegmentGroup, ref pVideoMemoryInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent<TThis>(this TThis thisVtbl, void* hEvent, Span<uint> pdwCookie) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterVideoMemoryBudgetChangeNotificationEvent(hEvent, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent<T0, TThis>(this TThis thisVtbl, Span<T0> hEvent, uint* pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterVideoMemoryBudgetChangeNotificationEvent(ref hEvent.GetPinnableReference(), pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterVideoMemoryBudgetChangeNotificationEvent<T0, TThis>(this TThis thisVtbl, Span<T0> hEvent, Span<uint> pdwCookie) where T0 : unmanaged where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterVideoMemoryBudgetChangeNotificationEvent(ref hEvent.GetPinnableReference(), ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc3<TThis>(this TThis thisVtbl, Span<AdapterDesc3> pDesc) where TThis : IComVtbl<IDXGIAdapter4>
    {
        var @this = (IDXGIAdapter4*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDesc3(ref pDesc.GetPinnableReference());
    }

}
