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

public unsafe static class D2D1SvgPathDataVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPathData> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1SvgPathData> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1SvgPathData> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgPathData> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetElement(this ComPtr<ID2D1SvgPathData> thisVtbl, ID2D1SvgElement** element)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, element);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<ID2D1SvgPathData> thisVtbl, ID2D1SvgAttribute** attribute)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attribute);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveSegmentDataAtEnd(this ComPtr<ID2D1SvgPathData> thisVtbl, uint dataCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint, int>)@this->LpVtbl[6])(@this, dataCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSegmentData(this ComPtr<ID2D1SvgPathData> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* data, uint dataCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)@this->LpVtbl[7])(@this, data, dataCount, startIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSegmentData(this ComPtr<ID2D1SvgPathData> thisVtbl, float* data, uint dataCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)@this->LpVtbl[8])(@this, data, dataCount, startIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetSegmentDataCount(this ComPtr<ID2D1SvgPathData> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveCommandsAtEnd(this ComPtr<ID2D1SvgPathData> thisVtbl, uint commandsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint, int>)@this->LpVtbl[10])(@this, commandsCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateCommands(this ComPtr<ID2D1SvgPathData> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgPathCommand* commands, uint commandsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)@this->LpVtbl[11])(@this, commands, commandsCount, startIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCommands(this ComPtr<ID2D1SvgPathData> thisVtbl, SvgPathCommand* commands, uint commandsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)@this->LpVtbl[12])(@this, commands, commandsCount, startIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetCommandsCount(this ComPtr<ID2D1SvgPathData> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathGeometry(this ComPtr<ID2D1SvgPathData> thisVtbl, FillMode fillMode, ID2D1PathGeometry1** pathGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, FillMode, ID2D1PathGeometry1**, int>)@this->LpVtbl[14])(@this, fillMode, pathGeometry);
        return ret;
    }

}
