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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class ChannelHookVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IChannelHook> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IChannelHook> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IChannelHook> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtent, riid, pDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riid, pDataSize, pDataBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClientNotify(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtent, riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerNotify(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtent, riid, cbDataSize, pDataBuffer, lDataRep);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerGetSize(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, int hrFault, uint* pDataSize)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtent, riid, hrFault, pDataSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ServerFillBuffer(this ComPtr<IChannelHook> thisVtbl, Guid* uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer, int hrFault)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riid, pDataSize, pDataBuffer, hrFault);
    }

}
