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

public unsafe static class Direct3DCubeTexture9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, IDirect3DDevice9** ppDevice) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref IDirect3DDevice9* ppDevice) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, uint SizeOfData, uint Flags) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, uint SizeOfData, uint Flags) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, ref uint pSizeOfData) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pSizeOfDataPtr = &pSizeOfData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid refguid, void* pData, ref uint pSizeOfData) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            fixed (void* pDataPtr = &pData)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FreePrivateData<TThis>(this TThis thisVtbl, Guid* refguid) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, int>)@this->LpVtbl[6])(@this, refguid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FreePrivateData<TThis>(this TThis thisVtbl, ref Guid refguid) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* refguidPtr = &refguid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, int>)@this->LpVtbl[6])(@this, refguidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint SetPriority<TThis>(this TThis thisVtbl, uint PriorityNew) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, uint>)@this->LpVtbl[7])(@this, PriorityNew);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPriority<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void PreLoad<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, void>)@this->LpVtbl[9])(@this);
    }

    /// <summary>To be documented.</summary>
    public static Resourcetype GetType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        Resourcetype ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Resourcetype>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint SetLOD<TThis>(this TThis thisVtbl, uint LODNew) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, uint>)@this->LpVtbl[11])(@this, LODNew);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLOD<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLevelCount<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAutoGenFilterType<TThis>(this TThis thisVtbl, Texturefiltertype FilterType) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Texturefiltertype, int>)@this->LpVtbl[14])(@this, FilterType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Texturefiltertype GetAutoGenFilterType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        Texturefiltertype ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Texturefiltertype>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void GenerateMipSubLevels<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, void>)@this->LpVtbl[16])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLevelDesc<TThis>(this TThis thisVtbl, uint Level, SurfaceDesc* pDesc) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, SurfaceDesc*, int>)@this->LpVtbl[17])(@this, Level, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLevelDesc<TThis>(this TThis thisVtbl, uint Level, ref SurfaceDesc pDesc) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (SurfaceDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, SurfaceDesc*, int>)@this->LpVtbl[17])(@this, Level, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCubeMapSurface<TThis>(this TThis thisVtbl, CubemapFaces FaceType, uint Level, IDirect3DSurface9** ppCubeMapSurface) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, IDirect3DSurface9**, int>)@this->LpVtbl[18])(@this, FaceType, Level, ppCubeMapSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCubeMapSurface<TThis>(this TThis thisVtbl, CubemapFaces FaceType, uint Level, ref IDirect3DSurface9* ppCubeMapSurface) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppCubeMapSurfacePtr = &ppCubeMapSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, IDirect3DSurface9**, int>)@this->LpVtbl[18])(@this, FaceType, Level, ppCubeMapSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockRect<TThis>(this TThis thisVtbl, CubemapFaces FaceType, uint Level, LockedRect* pLockedRect, Silk.NET.Maths.Rectangle<int>* pRect, uint Flags) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[19])(@this, FaceType, Level, pLockedRect, pRect, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockRect<TThis>(this TThis thisVtbl, CubemapFaces FaceType, uint Level, LockedRect* pLockedRect, ref Silk.NET.Maths.Rectangle<int> pRect, uint Flags) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[19])(@this, FaceType, Level, pLockedRect, pRectPtr, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockRect<TThis>(this TThis thisVtbl, CubemapFaces FaceType, uint Level, ref LockedRect pLockedRect, Silk.NET.Maths.Rectangle<int>* pRect, uint Flags) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (LockedRect* pLockedRectPtr = &pLockedRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[19])(@this, FaceType, Level, pLockedRectPtr, pRect, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LockRect<TThis>(this TThis thisVtbl, CubemapFaces FaceType, uint Level, ref LockedRect pLockedRect, ref Silk.NET.Maths.Rectangle<int> pRect, uint Flags) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (LockedRect* pLockedRectPtr = &pLockedRect)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[19])(@this, FaceType, Level, pLockedRectPtr, pRectPtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnlockRect<TThis>(this TThis thisVtbl, CubemapFaces FaceType, uint Level) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, int>)@this->LpVtbl[20])(@this, FaceType, Level);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDirtyRect<TThis>(this TThis thisVtbl, CubemapFaces FaceType, Silk.NET.Maths.Rectangle<int>* pDirtyRect) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[21])(@this, FaceType, pDirtyRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddDirtyRect<TThis>(this TThis thisVtbl, CubemapFaces FaceType, ref Silk.NET.Maths.Rectangle<int> pDirtyRect) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pDirtyRectPtr = &pDirtyRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[21])(@this, FaceType, pDirtyRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0> where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetDevice((IDirect3DDevice9**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, Span<T0> pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(refguid, ref pData.GetPinnableReference(), SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid, void* pData, uint SizeOfData, uint Flags) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref refguid.GetPinnableReference(), pData, SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> refguid, Span<T0> pData, uint SizeOfData, uint Flags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref refguid.GetPinnableReference(), ref pData.GetPinnableReference(), SizeOfData, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* refguid, void* pData, Span<uint> pSizeOfData) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(refguid, pData, ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, Span<T0> pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(refguid, ref pData.GetPinnableReference(), pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* refguid, Span<T0> pData, Span<uint> pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(refguid, ref pData.GetPinnableReference(), ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid, void* pData, uint* pSizeOfData) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), pData, pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid, void* pData, Span<uint> pSizeOfData) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), pData, ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> refguid, Span<T0> pData, uint* pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), ref pData.GetPinnableReference(), pSizeOfData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> refguid, Span<T0> pData, Span<uint> pSizeOfData) where T0 : unmanaged where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref refguid.GetPinnableReference(), ref pData.GetPinnableReference(), ref pSizeOfData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FreePrivateData<TThis>(this TThis thisVtbl, Span<Guid> refguid) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->FreePrivateData(ref refguid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLevelDesc<TThis>(this TThis thisVtbl, uint Level, Span<SurfaceDesc> pDesc) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetLevelDesc(Level, ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCubeMapSurface<TI0, TThis>(this TThis thisVtbl, CubemapFaces FaceType, uint Level, ref ComPtr<TI0> ppCubeMapSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetCubeMapSurface(FaceType, Level, (IDirect3DSurface9**) ppCubeMapSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockRect<TThis>(this TThis thisVtbl, CubemapFaces FaceType, uint Level, LockedRect* pLockedRect, Span<Silk.NET.Maths.Rectangle<int>> pRect, uint Flags) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LockRect(FaceType, Level, pLockedRect, ref pRect.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockRect<TThis>(this TThis thisVtbl, CubemapFaces FaceType, uint Level, Span<LockedRect> pLockedRect, Silk.NET.Maths.Rectangle<int>* pRect, uint Flags) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LockRect(FaceType, Level, ref pLockedRect.GetPinnableReference(), pRect, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int LockRect<TThis>(this TThis thisVtbl, CubemapFaces FaceType, uint Level, Span<LockedRect> pLockedRect, Span<Silk.NET.Maths.Rectangle<int>> pRect, uint Flags) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->LockRect(FaceType, Level, ref pLockedRect.GetPinnableReference(), ref pRect.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static int AddDirtyRect<TThis>(this TThis thisVtbl, CubemapFaces FaceType, Span<Silk.NET.Maths.Rectangle<int>> pDirtyRect) where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->AddDirtyRect(FaceType, ref pDirtyRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDirect3DCubeTexture9>
    {
        var @this = (IDirect3DCubeTexture9*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
