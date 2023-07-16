// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID2D1ComputeTransform.xml' path='doc/member[@name="ID2D1ComputeTransform"]/*'/>
[Guid("0D85573C-01E3-4F7D-BFD9-0D60608BF3C3")]
[NativeTypeName("struct ID2D1ComputeTransform : ID2D1Transform")]
[NativeInheritance("ID2D1Transform")]
public unsafe partial struct ID2D1ComputeTransform : ID2D1ComputeTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ComputeTransform));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform*, uint> )(lpVtbl[1]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform*, uint> )(lpVtbl[2]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1TransformNode.GetInputCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform*, uint> )(lpVtbl[3]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Transform.MapOutputRectToInputRects"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MapOutputRectToInputRects([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("UINT32")] uint inputRectsCount)
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform*, RECT*, RECT*, uint, int> )(lpVtbl[4]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
    }

    /// <inheritdoc cref = "ID2D1Transform.MapInputRectsToOutputRect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MapInputRectsToOutputRect([NativeTypeName("const D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("const D2D1_RECT_L *")] RECT* inputOpaqueSubRects, [NativeTypeName("UINT32")] uint inputRectCount, [NativeTypeName("D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* outputOpaqueSubRect)
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform*, RECT*, RECT*, uint, RECT*, RECT*, int> )(lpVtbl[5]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
    }

    /// <inheritdoc cref = "ID2D1Transform.MapInvalidRect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT MapInvalidRect([NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* invalidOutputRect)
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform*, uint, RECT, RECT*, int> )(lpVtbl[6]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
    }

    /// <include file='ID2D1ComputeTransform.xml' path='doc/member[@name="ID2D1ComputeTransform.SetComputeInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetComputeInfo(ID2D1ComputeInfo* computeInfo)
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform*, ID2D1ComputeInfo*, int> )(lpVtbl[7]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), computeInfo);
    }

    /// <include file='ID2D1ComputeTransform.xml' path='doc/member[@name="ID2D1ComputeTransform.CalculateThreadgroups"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CalculateThreadgroups([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("UINT32 *")] uint* dimensionX, [NativeTypeName("UINT32 *")] uint* dimensionY, [NativeTypeName("UINT32 *")] uint* dimensionZ)
    {
        return ((delegate* unmanaged<ID2D1ComputeTransform*, RECT*, uint*, uint*, uint*, int> )(lpVtbl[8]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), outputRect, dimensionX, dimensionY, dimensionZ);
    }

    public interface Interface : ID2D1Transform.Interface
    {
        [VtblIndex(7)]
        HRESULT SetComputeInfo(ID2D1ComputeInfo* computeInfo);
        [VtblIndex(8)]
        HRESULT CalculateThreadgroups([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("UINT32 *")] uint* dimensionX, [NativeTypeName("UINT32 *")] uint* dimensionY, [NativeTypeName("UINT32 *")] uint* dimensionZ);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetInputCount;
        [NativeTypeName("HRESULT (const D2D1_RECT_L *, D2D1_RECT_L *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, uint, int> MapOutputRectToInputRects;
        [NativeTypeName("HRESULT (const D2D1_RECT_L *, const D2D1_RECT_L *, UINT32, D2D1_RECT_L *, D2D1_RECT_L *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, uint, RECT*, RECT*, int> MapInputRectsToOutputRect;
        [NativeTypeName("HRESULT (UINT32, D2D1_RECT_L, D2D1_RECT_L *) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECT, RECT*, int> MapInvalidRect;
        [NativeTypeName("HRESULT (ID2D1ComputeInfo *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1ComputeInfo*, int> SetComputeInfo;
        [NativeTypeName("HRESULT (const D2D1_RECT_L *, UINT32 *, UINT32 *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, uint*, uint*, uint*, int> CalculateThreadgroups;
    }
}