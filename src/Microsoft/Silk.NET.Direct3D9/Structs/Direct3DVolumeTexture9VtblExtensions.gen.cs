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

public unsafe static class Direct3DVolumeTexture9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, IDirect3DDevice9** ppDevice) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref IDirect3DDevice9* ppDevice) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, uint SizeOfData, uint Flags) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, uint SizeOfData, uint Flags) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, ref uint pSizeOfData) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pSizeOfDataPtr = &pSizeOfData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, ref uint pSizeOfData) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FreePrivateData<TThis>(this TThis thisVtbl, Guid* refguid) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, int>)@this->LpVtbl[6])(@this, refguid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FreePrivateData<TThis>(this TThis thisVtbl, ref Guid refguid) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, int>)@this->LpVtbl[6])(@this, refguidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint SetPriority<TThis>(this TThis thisVtbl, uint PriorityNew) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, uint>)@this->LpVtbl[7])(@this, PriorityNew);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPriority<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PreLoad<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, void>)@this->LpVtbl[9])(@this);
    }

    /// <summary>To be documented.</summary>
    public static Resourcetype GetType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        Resourcetype ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Resourcetype>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint SetLOD<TThis>(this TThis thisVtbl, uint LODNew) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, uint>)@this->LpVtbl[11])(@this, LODNew);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLOD<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLevelCount<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAutoGenFilterType<TThis>(this TThis thisVtbl, Texturefiltertype FilterType) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Texturefiltertype, int>)@this->LpVtbl[14])(@this, FilterType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Texturefiltertype GetAutoGenFilterType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        Texturefiltertype ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Texturefiltertype>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void GenerateMipSubLevels<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, void>)@this->LpVtbl[16])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLevelDesc<TThis>(this TThis thisVtbl, uint Level, VolumeDesc* pDesc) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, VolumeDesc*, int>)@this->LpVtbl[17])(@this, Level, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLevelDesc<TThis>(this TThis thisVtbl, uint Level, ref VolumeDesc pDesc) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (VolumeDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, VolumeDesc*, int>)@this->LpVtbl[17])(@this, Level, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVolumeLevel<TThis>(this TThis thisVtbl, uint Level, IDirect3DVolume9** ppVolumeLevel) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, IDirect3DVolume9**, int>)@this->LpVtbl[18])(@this, Level, ppVolumeLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVolumeLevel<TThis>(this TThis thisVtbl, uint Level, ref IDirect3DVolume9* ppVolumeLevel) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVolume9** ppVolumeLevelPtr = &ppVolumeLevel)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, IDirect3DVolume9**, int>)@this->LpVtbl[18])(@this, Level, ppVolumeLevelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockBox<TThis>(this TThis thisVtbl, uint Level, LockedBox* pLockedVolume, Box* pBox, uint Flags) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)@this->LpVtbl[19])(@this, Level, pLockedVolume, pBox, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockBox<TThis>(this TThis thisVtbl, uint Level, LockedBox* pLockedVolume, ref Box pBox, uint Flags) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Box* pBoxPtr = &pBox)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)@this->LpVtbl[19])(@this, Level, pLockedVolume, pBoxPtr, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockBox<TThis>(this TThis thisVtbl, uint Level, ref LockedBox pLockedVolume, Box* pBox, uint Flags) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)@this->LpVtbl[19])(@this, Level, pLockedVolumePtr, pBox, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LockBox<TThis>(this TThis thisVtbl, uint Level, ref LockedBox pLockedVolume, ref Box pBox, uint Flags) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
        {
            fixed (Box* pBoxPtr = &pBox)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)@this->LpVtbl[19])(@this, Level, pLockedVolumePtr, pBoxPtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnlockBox<TThis>(this TThis thisVtbl, uint Level) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, int>)@this->LpVtbl[20])(@this, Level);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDirtyBox<TThis>(this TThis thisVtbl, Box* pDirtyBox) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Box*, int>)@this->LpVtbl[21])(@this, pDirtyBox);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDirtyBox<TThis>(this TThis thisVtbl, ref Box pDirtyBox) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Box* pDirtyBoxPtr = &pDirtyBox)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Box*, int>)@this->LpVtbl[21])(@this, pDirtyBoxPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, Span<T0> pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(refguid, ref pData.GetPinnableReference(), SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid, void* pData, uint SizeOfData, uint Flags) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref refguid.GetPinnableReference(), pData, SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> refguid, Span<T0> pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref refguid.GetPinnableReference(), ref pData.GetPinnableReference(), SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, Span<uint> pSizeOfData) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(refguid, pData, ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, Span<T0> pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(refguid, ref pData.GetPinnableReference(), pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, Span<T0> pData, Span<uint> pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(refguid, ref pData.GetPinnableReference(), ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid, void* pData, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), pData, pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid, void* pData, Span<uint> pSizeOfData) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), pData, ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> refguid, Span<T0> pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), ref pData.GetPinnableReference(), pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> refguid, Span<T0> pData, Span<uint> pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), ref pData.GetPinnableReference(), ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FreePrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->FreePrivateData(ref refguid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLevelDesc<TThis>(this TThis thisVtbl, uint Level, Span<VolumeDesc> pDesc) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetLevelDesc(Level, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockBox<TThis>(this TThis thisVtbl, uint Level, LockedBox* pLockedVolume, Span<Box> pBox, uint Flags) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LockBox(Level, pLockedVolume, ref pBox.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockBox<TThis>(this TThis thisVtbl, uint Level, Span<LockedBox> pLockedVolume, Box* pBox, uint Flags) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LockBox(Level, ref pLockedVolume.GetPinnableReference(), pBox, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int LockBox<TThis>(this TThis thisVtbl, uint Level, Span<LockedBox> pLockedVolume, Span<Box> pBox, uint Flags) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LockBox(Level, ref pLockedVolume.GetPinnableReference(), ref pBox.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static int AddDirtyBox<TThis>(this TThis thisVtbl, Span<Box> pDirtyBox) where TThis : IComVtbl<IDirect3DVolumeTexture9>
    {
        var @this = (IDirect3DVolumeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->AddDirtyBox(ref pDirtyBox.GetPinnableReference());
    }

}
