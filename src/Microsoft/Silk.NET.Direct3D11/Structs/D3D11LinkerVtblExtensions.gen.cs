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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11LinkerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Linker> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11Linker> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11Linker> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Link(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UseLibrary(this ComPtr<ID3D11Linker> thisVtbl, ID3D11ModuleInstance* pLibraryMI)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, int>)@this->LpVtbl[4])(@this, pLibraryMI);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddClipPlaneFromCBuffer(this ComPtr<ID3D11Linker> thisVtbl, uint uCBufferSlot, uint uCBufferEntry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint, uint, int>)@this->LpVtbl[5])(@this, uCBufferSlot, uCBufferEntry);
        return ret;
    }

}
