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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1Device1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Device1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1Device1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1Device1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1Device1> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDeviceContext(this ComPtr<ID2D1Device1> thisVtbl, DeviceContextOptions options, ID2D1DeviceContext** deviceContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device1*, DeviceContextOptions, ID2D1DeviceContext**, int>)@this->LpVtbl[4])(@this, options, deviceContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePrintControl(this ComPtr<ID2D1Device1> thisVtbl, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrintControlProperties* printControlProperties, ID2D1PrintControl** printControl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device1*, IWICImagingFactory*, IPrintDocumentPackageTarget*, PrintControlProperties*, ID2D1PrintControl**, int>)@this->LpVtbl[5])(@this, wicFactory, documentTarget, printControlProperties, printControl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetMaximumTextureMemory(this ComPtr<ID2D1Device1> thisVtbl, ulong maximumInBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device1*, ulong, void>)@this->LpVtbl[6])(@this, maximumInBytes);
    }

    /// <summary>To be documented.</summary>
    public static ulong GetMaximumTextureMemory(this ComPtr<ID2D1Device1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device1*, ulong>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearResources(this ComPtr<ID2D1Device1> thisVtbl, uint millisecondsSinceUse)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device1*, uint, void>)@this->LpVtbl[8])(@this, millisecondsSinceUse);
    }

    /// <summary>To be documented.</summary>
    public static RenderingPriority GetRenderingPriority(this ComPtr<ID2D1Device1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        RenderingPriority ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Device1*, RenderingPriority>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetRenderingPriority(this ComPtr<ID2D1Device1> thisVtbl, RenderingPriority renderingPriority)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Device1*, RenderingPriority, void>)@this->LpVtbl[10])(@this, renderingPriority);
    }

}
