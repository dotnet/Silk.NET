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

public unsafe static class Direct3DDevice9VideoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Video> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3DDevice9Video> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DDevice9Video> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContentProtectionCaps(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, Contentprotectioncaps* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAuthenticatedChannel(this ComPtr<IDirect3DDevice9Video> thisVtbl, Authenticatedchanneltype ChannelType, IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, void** pChannelHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)@this->LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCryptoSession(this ComPtr<IDirect3DDevice9Video> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
        return ret;
    }

}
