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

public unsafe static class Direct3D9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3D9> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3D9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3D9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterSoftwareDevice(this ComPtr<IDirect3D9> thisVtbl, void* pInitializeFunction)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, void*, int>)@this->LpVtbl[3])(@this, pInitializeFunction);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetAdapterCount(this ComPtr<IDirect3D9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAdapterIdentifier(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, uint Flags, AdapterIdentifier9* pIdentifier)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, uint, AdapterIdentifier9*, int>)@this->LpVtbl[5])(@this, Adapter, Flags, pIdentifier);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetAdapterModeCount(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Format Format)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Format, uint>)@this->LpVtbl[6])(@this, Adapter, Format);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterModes(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Format Format, uint Mode, Displaymode* pMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Format, uint, Displaymode*, int>)@this->LpVtbl[7])(@this, Adapter, Format, Mode, pMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAdapterDisplayMode(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Displaymode* pMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, Adapter, pMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceType(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DevType, Format AdapterFormat, Format BackBufferFormat, Silk.NET.Core.Bool32 bWindowed)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, Format, Silk.NET.Core.Bool32, int>)@this->LpVtbl[9])(@this, Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceFormat(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, Format AdapterFormat, uint Usage, Resourcetype RType, Format CheckFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, uint, Resourcetype, Format, int>)@this->LpVtbl[10])(@this, Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckDeviceMultiSampleType(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, Format SurfaceFormat, Silk.NET.Core.Bool32 Windowed, MultisampleType MultiSampleType, uint* pQualityLevels)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, Silk.NET.Core.Bool32, MultisampleType, uint*, int>)@this->LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDepthStencilMatch(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, Format AdapterFormat, Format RenderTargetFormat, Format DepthStencilFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, Format, Format, int>)@this->LpVtbl[12])(@this, Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceFormatConversion(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, Format SourceFormat, Format TargetFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, Format, int>)@this->LpVtbl[13])(@this, Adapter, DeviceType, SourceFormat, TargetFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceCaps(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, Caps9* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Caps9*, int>)@this->LpVtbl[14])(@this, Adapter, DeviceType, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nint GetAdapterMonitor(this ComPtr<IDirect3D9> thisVtbl, uint Adapter)
    {
        var @this = thisVtbl.Handle;
        nint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, nint>)@this->LpVtbl[15])(@this, Adapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)@this->LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
        return ret;
    }

}
