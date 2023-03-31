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
    public static unsafe int QueryInterface(this ComPtr<IDirect3D9> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3D9> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3D9> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static int RegisterSoftwareDevice<T0>(this ComPtr<IDirect3D9> thisVtbl, ref T0 pInitializeFunction) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pInitializeFunctionPtr = &pInitializeFunction)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, void*, int>)@this->LpVtbl[3])(@this, pInitializeFunctionPtr);
        }
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
    public static int GetAdapterIdentifier(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, uint Flags, ref AdapterIdentifier9 pIdentifier)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (AdapterIdentifier9* pIdentifierPtr = &pIdentifier)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, uint, AdapterIdentifier9*, int>)@this->LpVtbl[5])(@this, Adapter, Flags, pIdentifierPtr);
        }
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
    public static int EnumAdapterModes(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Format Format, uint Mode, ref Displaymode pMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Displaymode* pModePtr = &pMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Format, uint, Displaymode*, int>)@this->LpVtbl[7])(@this, Adapter, Format, Mode, pModePtr);
        }
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
    public static int GetAdapterDisplayMode(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, ref Displaymode pMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Displaymode* pModePtr = &pMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, Adapter, pModePtr);
        }
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
    public static int CheckDeviceMultiSampleType(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, Format SurfaceFormat, Silk.NET.Core.Bool32 Windowed, MultisampleType MultiSampleType, ref uint pQualityLevels)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pQualityLevelsPtr = &pQualityLevels)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, Silk.NET.Core.Bool32, MultisampleType, uint*, int>)@this->LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevelsPtr);
        }
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
    public static int GetDeviceCaps(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, ref Caps9 pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Caps9* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Caps9*, int>)@this->LpVtbl[14])(@this, Adapter, DeviceType, pCapsPtr);
        }
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

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DDevice9** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)@this->LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)@this->LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            fixed (IDirect3DDevice9** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)@this->LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDirect3D9> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3D9> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3D9> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterSoftwareDevice<T0>(this ComPtr<IDirect3D9> thisVtbl, Span<T0> pInitializeFunction) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterSoftwareDevice(ref pInitializeFunction.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAdapterIdentifier(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, uint Flags, Span<AdapterIdentifier9> pIdentifier)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAdapterIdentifier(Adapter, Flags, ref pIdentifier.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnumAdapterModes(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Format Format, uint Mode, Span<Displaymode> pMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnumAdapterModes(Adapter, Format, Mode, ref pMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAdapterDisplayMode(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Span<Displaymode> pMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAdapterDisplayMode(Adapter, ref pMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceMultiSampleType(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, Format SurfaceFormat, Silk.NET.Core.Bool32 Windowed, MultisampleType MultiSampleType, Span<uint> pQualityLevels)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckDeviceMultiSampleType(Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, ref pQualityLevels.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceCaps(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, Span<Caps9> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceCaps(Adapter, DeviceType, ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TI0>(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, ref ComPtr<TI0> ppReturnedDeviceInterface) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDevice(Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, (IDirect3DDevice9**) ppReturnedDeviceInterface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, Span<PresentParameters> pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(Adapter, DeviceType, hFocusWindow, BehaviorFlags, ref pPresentationParameters.GetPinnableReference(), ppReturnedDeviceInterface);
    }

    /// <summary>To be documented.</summary>
    public static int CreateDevice<TI0>(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, ref ComPtr<TI0> ppReturnedDeviceInterface) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDevice(Adapter, DeviceType, hFocusWindow, BehaviorFlags, ref pPresentationParameters, (IDirect3DDevice9**) ppReturnedDeviceInterface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice(this ComPtr<IDirect3D9> thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, Span<PresentParameters> pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateDevice(Adapter, DeviceType, hFocusWindow, BehaviorFlags, ref pPresentationParameters.GetPinnableReference(), ref ppReturnedDeviceInterface);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDirect3D9> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
