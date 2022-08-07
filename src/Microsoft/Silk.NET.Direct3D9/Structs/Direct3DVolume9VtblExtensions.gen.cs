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

namespace Silk.NET.Direct3D9;

public unsafe static class Direct3DVolume9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, IDirect3DDevice9** ppDevice) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref IDirect3DDevice9* ppDevice) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, uint SizeOfData, uint Flags) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, uint SizeOfData, uint Flags) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, ref uint pSizeOfData) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pSizeOfDataPtr = &pSizeOfData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, ref uint pSizeOfData) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FreePrivateData<TThis>(this TThis thisVtbl, Guid* refguid) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, int>)@this->LpVtbl[6])(@this, refguid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FreePrivateData<TThis>(this TThis thisVtbl, ref Guid refguid) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, int>)@this->LpVtbl[6])(@this, refguidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainer<TThis>(this TThis thisVtbl, Guid* riid, void** ppContainer) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppContainer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainer<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppContainer) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppContainerPtr = &ppContainer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppContainerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainer<TThis>(this TThis thisVtbl, ref Guid riid, void** ppContainer) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppContainer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainer<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppContainer) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppContainerPtr = &ppContainer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppContainerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, VolumeDesc* pDesc) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, VolumeDesc*, int>)@this->LpVtbl[8])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref VolumeDesc pDesc) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VolumeDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, VolumeDesc*, int>)@this->LpVtbl[8])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockBox<TThis>(this TThis thisVtbl, LockedBox* pLockedVolume, Box* pBox, uint Flags) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)@this->LpVtbl[9])(@this, pLockedVolume, pBox, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockBox<TThis>(this TThis thisVtbl, LockedBox* pLockedVolume, ref Box pBox, uint Flags) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Box* pBoxPtr = &pBox)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)@this->LpVtbl[9])(@this, pLockedVolume, pBoxPtr, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockBox<TThis>(this TThis thisVtbl, ref LockedBox pLockedVolume, Box* pBox, uint Flags) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)@this->LpVtbl[9])(@this, pLockedVolumePtr, pBox, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LockBox<TThis>(this TThis thisVtbl, ref LockedBox pLockedVolume, ref Box pBox, uint Flags) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
        {
            fixed (Box* pBoxPtr = &pBox)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)@this->LpVtbl[9])(@this, pLockedVolumePtr, pBoxPtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnlockBox<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolume9>
    {
        var @this = (IDirect3DVolume9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, int>)@this->LpVtbl[10])(@this);
        return ret;
    }

}
