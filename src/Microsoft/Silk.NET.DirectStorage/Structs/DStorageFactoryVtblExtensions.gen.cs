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

namespace Silk.NET.DirectStorage;

public unsafe static class DStorageFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDStorageFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDStorageFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDStorageFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue(this ComPtr<IDStorageFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueueDesc* desc, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, desc, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile(this ComPtr<IDStorageFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* path, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, path, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray(this ComPtr<IDStorageFactory> thisVtbl, uint capacity, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, name, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetDebugFlags(this ComPtr<IDStorageFactory> thisVtbl, uint flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, void>)@this->LpVtbl[6])(@this, flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetStagingBufferSize(this ComPtr<IDStorageFactory> thisVtbl, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, int>)@this->LpVtbl[7])(@this, size);
        return ret;
    }

}
