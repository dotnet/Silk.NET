// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1SourceTransform.xml' path='doc/member[@name="ID2D1SourceTransform"]/*'/>
[Guid("DB1800DD-0C34-4CF9-BE90-31CC0A5653E1")]
[NativeTypeName("struct ID2D1SourceTransform : ID2D1Transform")]
[NativeInheritance("ID2D1Transform")]
public unsafe partial struct ID2D1SourceTransform : ID2D1SourceTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SourceTransform));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SourceTransform*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1SourceTransform*, uint> )(lpVtbl[1]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SourceTransform*, uint> )(lpVtbl[2]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1TransformNode.GetInputCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<ID2D1SourceTransform*, uint> )(lpVtbl[3]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Transform.MapOutputRectToInputRects"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MapOutputRectToInputRects([NativeTypeName("const D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("UINT32")] uint inputRectsCount)
    {
        return ((delegate* unmanaged<ID2D1SourceTransform*, RECT*, RECT*, uint, int> )(lpVtbl[4]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
    }

    /// <inheritdoc cref = "ID2D1Transform.MapInputRectsToOutputRect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MapInputRectsToOutputRect([NativeTypeName("const D2D1_RECT_L *")] RECT* inputRects, [NativeTypeName("const D2D1_RECT_L *")] RECT* inputOpaqueSubRects, [NativeTypeName("UINT32")] uint inputRectCount, [NativeTypeName("D2D1_RECT_L *")] RECT* outputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* outputOpaqueSubRect)
    {
        return ((delegate* unmanaged<ID2D1SourceTransform*, RECT*, RECT*, uint, RECT*, RECT*, int> )(lpVtbl[5]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
    }

    /// <inheritdoc cref = "ID2D1Transform.MapInvalidRect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT MapInvalidRect([NativeTypeName("UINT32")] uint inputIndex, [NativeTypeName("D2D1_RECT_L")] RECT invalidInputRect, [NativeTypeName("D2D1_RECT_L *")] RECT* invalidOutputRect)
    {
        return ((delegate* unmanaged<ID2D1SourceTransform*, uint, RECT, RECT*, int> )(lpVtbl[6]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
    }

    /// <include file='ID2D1SourceTransform.xml' path='doc/member[@name="ID2D1SourceTransform.SetRenderInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRenderInfo(ID2D1RenderInfo* renderInfo)
    {
        return ((delegate* unmanaged<ID2D1SourceTransform*, ID2D1RenderInfo*, int> )(lpVtbl[7]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), renderInfo);
    }

    /// <include file='ID2D1SourceTransform.xml' path='doc/member[@name="ID2D1SourceTransform.Draw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Draw(ID2D1Bitmap1* target, [NativeTypeName("const D2D1_RECT_L *")] RECT* drawRect, [NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U targetOrigin)
    {
        return ((delegate* unmanaged<ID2D1SourceTransform*, ID2D1Bitmap1*, RECT*, D2D_POINT_2U, int> )(lpVtbl[8]))((ID2D1SourceTransform*)Unsafe.AsPointer(ref this), target, drawRect, targetOrigin);
    }

    public interface Interface : ID2D1Transform.Interface
    {
        [VtblIndex(7)]
        HRESULT SetRenderInfo(ID2D1RenderInfo* renderInfo);
        [VtblIndex(8)]
        HRESULT Draw(ID2D1Bitmap1* target, [NativeTypeName("const D2D1_RECT_L *")] RECT* drawRect, [NativeTypeName("D2D1_POINT_2U")] D2D_POINT_2U targetOrigin);
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
        [NativeTypeName("HRESULT (ID2D1RenderInfo *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1RenderInfo*, int> SetRenderInfo;
        [NativeTypeName("HRESULT (ID2D1Bitmap1 *, const D2D1_RECT_L *, D2D1_POINT_2U) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Bitmap1*, RECT*, D2D_POINT_2U, int> Draw;
    }
}