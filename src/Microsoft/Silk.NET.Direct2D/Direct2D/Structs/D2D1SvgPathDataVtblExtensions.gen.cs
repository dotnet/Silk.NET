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
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPathData> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPathData> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPathData> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgPathData> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetElement(this ComPtr<ID2D1SvgPathData> thisVtbl, ID2D1SvgElement** element)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, element);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetElement(this ComPtr<ID2D1SvgPathData> thisVtbl, ref ID2D1SvgElement* element)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1SvgElement** elementPtr = &element)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, elementPtr);
        }
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
    public static unsafe int Clone(this ComPtr<ID2D1SvgPathData> thisVtbl, ref ID2D1SvgAttribute* attribute)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1SvgAttribute** attributePtr = &attribute)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attributePtr);
        }
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
    public static int UpdateSegmentData(this ComPtr<ID2D1SvgPathData> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float data, uint dataCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)@this->LpVtbl[7])(@this, dataPtr, dataCount, startIndex);
        }
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
    public static int GetSegmentData(this ComPtr<ID2D1SvgPathData> thisVtbl, ref float data, uint dataCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)@this->LpVtbl[8])(@this, dataPtr, dataCount, startIndex);
        }
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
    public static int UpdateCommands(this ComPtr<ID2D1SvgPathData> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SvgPathCommand commands, uint commandsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SvgPathCommand* commandsPtr = &commands)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)@this->LpVtbl[11])(@this, commandsPtr, commandsCount, startIndex);
        }
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
    public static int GetCommands(this ComPtr<ID2D1SvgPathData> thisVtbl, ref SvgPathCommand commands, uint commandsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (SvgPathCommand* commandsPtr = &commands)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)@this->LpVtbl[12])(@this, commandsPtr, commandsCount, startIndex);
        }
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

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePathGeometry(this ComPtr<ID2D1SvgPathData> thisVtbl, FillMode fillMode, ref ID2D1PathGeometry1* pathGeometry)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1PathGeometry1** pathGeometryPtr = &pathGeometry)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, FillMode, ID2D1PathGeometry1**, int>)@this->LpVtbl[14])(@this, fillMode, pathGeometryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1SvgPathData> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPathData> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPathData> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1SvgPathData> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetElement<TI0>(this ComPtr<ID2D1SvgPathData> thisVtbl, ref ComPtr<TI0> element) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetElement((ID2D1SvgElement**) element.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int Clone<TI0>(this ComPtr<ID2D1SvgPathData> thisVtbl, ref ComPtr<TI0> attribute) where TI0 : unmanaged, IComVtbl<ID2D1SvgAttribute>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Clone((ID2D1SvgAttribute**) attribute.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int UpdateSegmentData(this ComPtr<ID2D1SvgPathData> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> data, uint dataCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSegmentData(in data.GetPinnableReference(), dataCount, startIndex);
    }

    /// <summary>To be documented.</summary>
    public static int GetSegmentData(this ComPtr<ID2D1SvgPathData> thisVtbl, Span<float> data, uint dataCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSegmentData(ref data.GetPinnableReference(), dataCount, startIndex);
    }

    /// <summary>To be documented.</summary>
    public static int UpdateCommands(this ComPtr<ID2D1SvgPathData> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SvgPathCommand> commands, uint commandsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateCommands(in commands.GetPinnableReference(), commandsCount, startIndex);
    }

    /// <summary>To be documented.</summary>
    public static int GetCommands(this ComPtr<ID2D1SvgPathData> thisVtbl, Span<SvgPathCommand> commands, uint commandsCount, uint startIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCommands(ref commands.GetPinnableReference(), commandsCount, startIndex);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePathGeometry<TI0>(this ComPtr<ID2D1SvgPathData> thisVtbl, FillMode fillMode, ref ComPtr<TI0> pathGeometry) where TI0 : unmanaged, IComVtbl<ID2D1PathGeometry1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePathGeometry(fillMode, (ID2D1PathGeometry1**) pathGeometry.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1SvgPathData> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
