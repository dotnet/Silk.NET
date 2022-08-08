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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterSoftwareDevice<TThis>(this TThis thisVtbl, void* pInitializeFunction) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, void*, int>)@this->LpVtbl[3])(@this, pInitializeFunction);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterSoftwareDevice<T0, TThis>(this TThis thisVtbl, ref T0 pInitializeFunction) where T0 : unmanaged where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pInitializeFunctionPtr = &pInitializeFunction)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, void*, int>)@this->LpVtbl[3])(@this, pInitializeFunctionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetAdapterCount<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAdapterIdentifier<TThis>(this TThis thisVtbl, uint Adapter, uint Flags, AdapterIdentifier9* pIdentifier) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, uint, AdapterIdentifier9*, int>)@this->LpVtbl[5])(@this, Adapter, Flags, pIdentifier);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAdapterIdentifier<TThis>(this TThis thisVtbl, uint Adapter, uint Flags, ref AdapterIdentifier9 pIdentifier) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (AdapterIdentifier9* pIdentifierPtr = &pIdentifier)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, uint, AdapterIdentifier9*, int>)@this->LpVtbl[5])(@this, Adapter, Flags, pIdentifierPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetAdapterModeCount<TThis>(this TThis thisVtbl, uint Adapter, Format Format) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Format, uint>)@this->LpVtbl[6])(@this, Adapter, Format);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumAdapterModes<TThis>(this TThis thisVtbl, uint Adapter, Format Format, uint Mode, Displaymode* pMode) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Format, uint, Displaymode*, int>)@this->LpVtbl[7])(@this, Adapter, Format, Mode, pMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnumAdapterModes<TThis>(this TThis thisVtbl, uint Adapter, Format Format, uint Mode, ref Displaymode pMode) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Displaymode* pModePtr = &pMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Format, uint, Displaymode*, int>)@this->LpVtbl[7])(@this, Adapter, Format, Mode, pModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAdapterDisplayMode<TThis>(this TThis thisVtbl, uint Adapter, Displaymode* pMode) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, Adapter, pMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAdapterDisplayMode<TThis>(this TThis thisVtbl, uint Adapter, ref Displaymode pMode) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Displaymode* pModePtr = &pMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, Adapter, pModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceType<TThis>(this TThis thisVtbl, uint Adapter, Devtype DevType, Format AdapterFormat, Format BackBufferFormat, int bWindowed) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, Format, int, int>)@this->LpVtbl[9])(@this, Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceFormat<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, Format AdapterFormat, uint Usage, Resourcetype RType, Format CheckFormat) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, uint, Resourcetype, Format, int>)@this->LpVtbl[10])(@this, Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckDeviceMultiSampleType<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, Format SurfaceFormat, int Windowed, MultisampleType MultiSampleType, uint* pQualityLevels) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, int, MultisampleType, uint*, int>)@this->LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceMultiSampleType<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, Format SurfaceFormat, int Windowed, MultisampleType MultiSampleType, ref uint pQualityLevels) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pQualityLevelsPtr = &pQualityLevels)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, int, MultisampleType, uint*, int>)@this->LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevelsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDepthStencilMatch<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, Format AdapterFormat, Format RenderTargetFormat, Format DepthStencilFormat) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, Format, Format, int>)@this->LpVtbl[12])(@this, Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceFormatConversion<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, Format SourceFormat, Format TargetFormat) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, Format, int>)@this->LpVtbl[13])(@this, Adapter, DeviceType, SourceFormat, TargetFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceCaps<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, Caps9* pCaps) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Caps9*, int>)@this->LpVtbl[14])(@this, Adapter, DeviceType, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceCaps<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, ref Caps9 pCaps) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Caps9* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Caps9*, int>)@this->LpVtbl[14])(@this, Adapter, DeviceType, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nint GetAdapterMonitor<TThis>(this TThis thisVtbl, uint Adapter) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        nint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, nint>)@this->LpVtbl[15])(@this, Adapter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)@this->LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DDevice9** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)@this->LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)@this->LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterSoftwareDevice<T0, TThis>(this TThis thisVtbl, Span<T0> pInitializeFunction) where T0 : unmanaged where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->RegisterSoftwareDevice(ref pInitializeFunction.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAdapterIdentifier<TThis>(this TThis thisVtbl, uint Adapter, uint Flags, Span<AdapterIdentifier9> pIdentifier) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetAdapterIdentifier(Adapter, Flags, ref pIdentifier.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnumAdapterModes<TThis>(this TThis thisVtbl, uint Adapter, Format Format, uint Mode, Span<Displaymode> pMode) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->EnumAdapterModes(Adapter, Format, Mode, ref pMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAdapterDisplayMode<TThis>(this TThis thisVtbl, uint Adapter, Span<Displaymode> pMode) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetAdapterDisplayMode(Adapter, ref pMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceMultiSampleType<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, Format SurfaceFormat, int Windowed, MultisampleType MultiSampleType, Span<uint> pQualityLevels) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CheckDeviceMultiSampleType(Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, ref pQualityLevels.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceCaps<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, Span<Caps9> pCaps) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDeviceCaps(Adapter, DeviceType, ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, Span<PresentParameters> pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateDevice(Adapter, DeviceType, hFocusWindow, BehaviorFlags, ref pPresentationParameters.GetPinnableReference(), ppReturnedDeviceInterface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDevice<TThis>(this TThis thisVtbl, uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, Span<PresentParameters> pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface) where TThis : IComVtbl<IDirect3D9>
    {
        var @this = (IDirect3D9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateDevice(Adapter, DeviceType, hFocusWindow, BehaviorFlags, ref pPresentationParameters.GetPinnableReference(), ref ppReturnedDeviceInterface);
    }

}
