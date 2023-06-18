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

public unsafe static class DirectXVideoMemoryConfigurationVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirectXVideoMemoryConfiguration> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirectXVideoMemoryConfiguration> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirectXVideoMemoryConfiguration> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableSurfaceTypeByIndex(this ComPtr<IDirectXVideoMemoryConfiguration> thisVtbl, uint dwTypeIndex, MIDLMIDLItfDxva2api000000060001* pdwType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, uint, MIDLMIDLItfDxva2api000000060001*, int>)@this->LpVtbl[3])(@this, dwTypeIndex, pdwType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSurfaceType(this ComPtr<IDirectXVideoMemoryConfiguration> thisVtbl, MIDLMIDLItfDxva2api000000060001 dwType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, MIDLMIDLItfDxva2api000000060001, int>)@this->LpVtbl[4])(@this, dwType);
        return ret;
    }

}
