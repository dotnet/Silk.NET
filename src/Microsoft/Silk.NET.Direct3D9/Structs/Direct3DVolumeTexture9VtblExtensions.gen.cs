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
    public static unsafe int QueryInterface(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3DVolumeTexture9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DVolumeTexture9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, IDirect3DDevice9** ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, Guid* refguid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint SizeOfData, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, Guid* refguid, void* pData, uint* pSizeOfData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FreePrivateData(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, Guid* refguid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, int>)@this->LpVtbl[6])(@this, refguid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint SetPriority(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, uint PriorityNew)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, uint>)@this->LpVtbl[7])(@this, PriorityNew);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPriority(this ComPtr<IDirect3DVolumeTexture9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PreLoad(this ComPtr<IDirect3DVolumeTexture9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, void>)@this->LpVtbl[9])(@this);
    }

    /// <summary>To be documented.</summary>
    public static Resourcetype GetType(this ComPtr<IDirect3DVolumeTexture9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Resourcetype ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Resourcetype>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint SetLOD(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, uint LODNew)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, uint>)@this->LpVtbl[11])(@this, LODNew);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLOD(this ComPtr<IDirect3DVolumeTexture9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLevelCount(this ComPtr<IDirect3DVolumeTexture9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAutoGenFilterType(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, Texturefiltertype FilterType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Texturefiltertype, int>)@this->LpVtbl[14])(@this, FilterType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Texturefiltertype GetAutoGenFilterType(this ComPtr<IDirect3DVolumeTexture9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Texturefiltertype ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Texturefiltertype>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void GenerateMipSubLevels(this ComPtr<IDirect3DVolumeTexture9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, void>)@this->LpVtbl[16])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLevelDesc(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, uint Level, VolumeDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, VolumeDesc*, int>)@this->LpVtbl[17])(@this, Level, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVolumeLevel(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, uint Level, IDirect3DVolume9** ppVolumeLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, IDirect3DVolume9**, int>)@this->LpVtbl[18])(@this, Level, ppVolumeLevel);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockBox(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, uint Level, LockedBox* pLockedVolume, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pBox, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)@this->LpVtbl[19])(@this, Level, pLockedVolume, pBox, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnlockBox(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, uint Level)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, int>)@this->LpVtbl[20])(@this, Level);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDirtyBox(this ComPtr<IDirect3DVolumeTexture9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDirtyBox)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Box*, int>)@this->LpVtbl[21])(@this, pDirtyBox);
        return ret;
    }

}
