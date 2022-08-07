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

public unsafe static class DXGISurface2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, void* pData) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, void* pData) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, void* pData) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, void** ppParent) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParent) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParent) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParent) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppDevice) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppDevice) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppDevice) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppDevice) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, SurfaceDesc* pDesc) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, SurfaceDesc*, int>)@this->LpVtbl[8])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref SurfaceDesc pDesc) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, SurfaceDesc*, int>)@this->LpVtbl[8])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map<TThis>(this TThis thisVtbl, MappedRect* pLockedRect, uint MapFlags) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, MappedRect*, uint, int>)@this->LpVtbl[9])(@this, pLockedRect, MapFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Map<TThis>(this TThis thisVtbl, ref MappedRect pLockedRect, uint MapFlags) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (MappedRect* pLockedRectPtr = &pLockedRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, MappedRect*, uint, int>)@this->LpVtbl[9])(@this, pLockedRectPtr, MapFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Unmap<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, int>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDC<TThis>(this TThis thisVtbl, int Discard, nint* phdc) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, int, nint*, int>)@this->LpVtbl[11])(@this, Discard, phdc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDC<TThis>(this TThis thisVtbl, int Discard, ref nint phdc) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (nint* phdcPtr = &phdc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, int, nint*, int>)@this->LpVtbl[11])(@this, Discard, phdcPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseDC<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pDirtyRect) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[12])(@this, pDirtyRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseDC<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pDirtyRect) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pDirtyRectPtr = &pDirtyRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[12])(@this, pDirtyRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResource<TThis>(this TThis thisVtbl, Guid* riid, void** ppParentResource, uint* pSubresourceIndex) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, uint*, int>)@this->LpVtbl[13])(@this, riid, ppParentResource, pSubresourceIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResource<TThis>(this TThis thisVtbl, Guid* riid, void** ppParentResource, ref uint pSubresourceIndex) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pSubresourceIndexPtr = &pSubresourceIndex)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, uint*, int>)@this->LpVtbl[13])(@this, riid, ppParentResource, pSubresourceIndexPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResource<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParentResource, uint* pSubresourceIndex) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentResourcePtr = &ppParentResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, uint*, int>)@this->LpVtbl[13])(@this, riid, ppParentResourcePtr, pSubresourceIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResource<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppParentResource, ref uint pSubresourceIndex) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppParentResourcePtr = &ppParentResource)
        {
            fixed (uint* pSubresourceIndexPtr = &pSubresourceIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, uint*, int>)@this->LpVtbl[13])(@this, riid, ppParentResourcePtr, pSubresourceIndexPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResource<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParentResource, uint* pSubresourceIndex) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, uint*, int>)@this->LpVtbl[13])(@this, riidPtr, ppParentResource, pSubresourceIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResource<TThis>(this TThis thisVtbl, ref Guid riid, void** ppParentResource, ref uint pSubresourceIndex) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (uint* pSubresourceIndexPtr = &pSubresourceIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, uint*, int>)@this->LpVtbl[13])(@this, riidPtr, ppParentResource, pSubresourceIndexPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResource<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParentResource, uint* pSubresourceIndex) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentResourcePtr = &ppParentResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, uint*, int>)@this->LpVtbl[13])(@this, riidPtr, ppParentResourcePtr, pSubresourceIndex);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResource<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppParentResource, ref uint pSubresourceIndex) where TThis : IComVtbl<IDXGISurface2>
    {
        var @this = (IDXGISurface2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentResourcePtr = &ppParentResource)
            {
                fixed (uint* pSubresourceIndexPtr = &pSubresourceIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, uint*, int>)@this->LpVtbl[13])(@this, riidPtr, ppParentResourcePtr, pSubresourceIndexPtr);
                }
            }
        }
        return ret;
    }

}
