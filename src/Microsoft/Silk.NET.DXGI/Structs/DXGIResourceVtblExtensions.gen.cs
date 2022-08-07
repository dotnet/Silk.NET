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

public unsafe static class DXGIResourceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppDevice) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppDevice) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppDevice) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppDevice) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedHandle<TThis>(this TThis thisVtbl, void** pSharedHandle) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, void**, int>)@this->LpVtbl[8])(@this, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSharedHandle<TThis>(this TThis thisVtbl, ref void* pSharedHandle) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, void**, int>)@this->LpVtbl[8])(@this, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUsage<TThis>(this TThis thisVtbl, uint* pUsage) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, uint*, int>)@this->LpVtbl[9])(@this, pUsage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetUsage<TThis>(this TThis thisVtbl, ref uint pUsage) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pUsagePtr = &pUsage)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, uint*, int>)@this->LpVtbl[9])(@this, pUsagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetEvictionPriority<TThis>(this TThis thisVtbl, uint EvictionPriority) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, uint, int>)@this->LpVtbl[10])(@this, EvictionPriority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEvictionPriority<TThis>(this TThis thisVtbl, uint* pEvictionPriority) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, uint*, int>)@this->LpVtbl[11])(@this, pEvictionPriority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetEvictionPriority<TThis>(this TThis thisVtbl, ref uint pEvictionPriority) where TThis : IComVtbl<IDXGIResource>
    {
        var @this = (IDXGIResource*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pEvictionPriorityPtr = &pEvictionPriority)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource*, uint*, int>)@this->LpVtbl[11])(@this, pEvictionPriorityPtr);
        }
        return ret;
    }

}
