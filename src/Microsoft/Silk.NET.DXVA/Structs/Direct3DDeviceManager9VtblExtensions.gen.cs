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

public unsafe static class Direct3DDeviceManager9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3DDeviceManager9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DDeviceManager9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetDevice(this ComPtr<IDirect3DDeviceManager9> thisVtbl, Silk.NET.Direct3D9.IDirect3DDevice9* pDevice, uint resetToken)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, Silk.NET.Direct3D9.IDirect3DDevice9*, uint, int>)@this->LpVtbl[3])(@this, pDevice, resetToken);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenDeviceHandle(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void** phDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void**, int>)@this->LpVtbl[4])(@this, phDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CloseDeviceHandle(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[5])(@this, hDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TestDevice(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, int>)@this->LpVtbl[6])(@this, hDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LockDevice(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, Silk.NET.Direct3D9.IDirect3DDevice9** ppDevice, Silk.NET.Core.Bool32 fBlock)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Direct3D9.IDirect3DDevice9**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, hDevice, ppDevice, fBlock);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnlockDevice(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, Silk.NET.Core.Bool32 fSaveState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, hDevice, fSaveState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVideoService(this ComPtr<IDirect3DDeviceManager9> thisVtbl, void* hDevice, Guid* riid, void** ppService)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirect3DDeviceManager9*, void*, Guid*, void**, int>)@this->LpVtbl[9])(@this, hDevice, riid, ppService);
        return ret;
    }

}
