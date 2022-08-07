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

namespace Silk.NET.DXVA;

public unsafe static class DirectXVideoAccelerationServiceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoAccelerationService>
    {
        var @this = (IDirectXVideoAccelerationService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoAccelerationService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoAccelerationService>
    {
        var @this = (IDirectXVideoAccelerationService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoAccelerationService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoAccelerationService>
    {
        var @this = (IDirectXVideoAccelerationService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoAccelerationService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoAccelerationService>
    {
        var @this = (IDirectXVideoAccelerationService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoAccelerationService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoAccelerationService>
    {
        var @this = (IDirectXVideoAccelerationService*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoAccelerationService*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoAccelerationService>
    {
        var @this = (IDirectXVideoAccelerationService*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoAccelerationService*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirectXVideoAccelerationService>
    {
        var @this = (IDirectXVideoAccelerationService*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoAccelerationService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirectXVideoAccelerationService>
    {
        var @this = (IDirectXVideoAccelerationService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoAccelerationService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirectXVideoAccelerationService>
    {
        var @this = (IDirectXVideoAccelerationService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoAccelerationService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurfacePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirectXVideoAccelerationService>
    {
        var @this = (IDirectXVideoAccelerationService*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoAccelerationService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)@this->LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurfacePtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

}
