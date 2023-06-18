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

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteLocalizedStringsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteLocalizedStrings> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteLocalizedStrings> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteLocalizedStrings> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetCount(this ComPtr<IDWriteLocalizedStrings> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint* index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, char*, uint*, int*, int>)@this->LpVtbl[4])(@this, localeName, index, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleNameLength(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, uint* length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, uint*, int>)@this->LpVtbl[5])(@this, index, length);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, char* localeName, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, char*, uint, int>)@this->LpVtbl[6])(@this, index, localeName, size);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStringLength(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, uint* length)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, uint*, int>)@this->LpVtbl[7])(@this, index, length);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetString(this ComPtr<IDWriteLocalizedStrings> thisVtbl, uint index, char* stringBuffer, uint size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalizedStrings*, uint, char*, uint, int>)@this->LpVtbl[8])(@this, index, stringBuffer, size);
        return ret;
    }

}
