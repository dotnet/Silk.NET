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

public unsafe static class D2D1EffectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Effect> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1Effect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1Effect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPropertyCount(this ComPtr<ID2D1Effect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyName(this ComPtr<ID2D1Effect> thisVtbl, uint index, char* name, uint nameCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, char*, uint, int>)@this->LpVtbl[4])(@this, index, name, nameCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPropertyNameLength(this ComPtr<ID2D1Effect> thisVtbl, uint index)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, uint>)@this->LpVtbl[5])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static PropertyType GetType(this ComPtr<ID2D1Effect> thisVtbl, uint index)
    {
        var @this = thisVtbl.Handle;
        PropertyType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType>)@this->LpVtbl[6])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint GetPropertyIndex(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, uint>)@this->LpVtbl[7])(@this, name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[8])(@this, name, type, data, dataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue(this ComPtr<ID2D1Effect> thisVtbl, uint index, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)@this->LpVtbl[9])(@this, index, type, data, dataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByName(this ComPtr<ID2D1Effect> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[10])(@this, name, type, data, dataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<ID2D1Effect> thisVtbl, uint index, PropertyType type, byte* data, uint dataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)@this->LpVtbl[11])(@this, index, type, data, dataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetValueSize(this ComPtr<ID2D1Effect> thisVtbl, uint index)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, uint>)@this->LpVtbl[12])(@this, index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubProperties(this ComPtr<ID2D1Effect> thisVtbl, uint index, ID2D1Properties** subProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Properties**, int>)@this->LpVtbl[13])(@this, index, subProperties);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetInput(this ComPtr<ID2D1Effect> thisVtbl, uint index, ID2D1Image* input, Silk.NET.Core.Bool32 invalidate)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[14])(@this, index, input, invalidate);
    }

    /// <summary>To be documented.</summary>
    public static int SetInputCount(this ComPtr<ID2D1Effect> thisVtbl, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, int>)@this->LpVtbl[15])(@this, inputCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetInput(this ComPtr<ID2D1Effect> thisVtbl, uint index, ID2D1Image** input)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image**, void>)@this->LpVtbl[16])(@this, index, input);
    }

    /// <summary>To be documented.</summary>
    public static uint GetInputCount(this ComPtr<ID2D1Effect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)@this->LpVtbl[17])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetOutput(this ComPtr<ID2D1Effect> thisVtbl, ID2D1Image** outputImage)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Effect*, ID2D1Image**, void>)@this->LpVtbl[18])(@this, outputImage);
    }

}
