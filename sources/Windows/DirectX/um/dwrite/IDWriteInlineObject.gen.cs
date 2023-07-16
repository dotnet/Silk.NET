// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteInlineObject.xml' path='doc/member[@name="IDWriteInlineObject"]/*'/>
[Guid("8339FDE3-106F-47AB-8373-1C6295EB10B3")]
[NativeTypeName("struct IDWriteInlineObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteInlineObject : IDWriteInlineObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteInlineObject));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteInlineObject*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteInlineObject*, uint> )(lpVtbl[1]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteInlineObject*, uint> )(lpVtbl[2]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteInlineObject.xml' path='doc/member[@name="IDWriteInlineObject.Draw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, BOOL isSideways, BOOL isRightToLeft, IUnknown* clientDrawingEffect)
    {
        return ((delegate* unmanaged<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, BOOL, BOOL, IUnknown*, int> )(lpVtbl[3]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
    }

    /// <include file='IDWriteInlineObject.xml' path='doc/member[@name="IDWriteInlineObject.GetMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMetrics(DWRITE_INLINE_OBJECT_METRICS* metrics)
    {
        return ((delegate* unmanaged<IDWriteInlineObject*, DWRITE_INLINE_OBJECT_METRICS*, int> )(lpVtbl[4]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), metrics);
    }

    /// <include file='IDWriteInlineObject.xml' path='doc/member[@name="IDWriteInlineObject.GetOverhangMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs)
    {
        return ((delegate* unmanaged<IDWriteInlineObject*, DWRITE_OVERHANG_METRICS*, int> )(lpVtbl[5]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), overhangs);
    }

    /// <include file='IDWriteInlineObject.xml' path='doc/member[@name="IDWriteInlineObject.GetBreakConditions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetBreakConditions(DWRITE_BREAK_CONDITION* breakConditionBefore, DWRITE_BREAK_CONDITION* breakConditionAfter)
    {
        return ((delegate* unmanaged<IDWriteInlineObject*, DWRITE_BREAK_CONDITION*, DWRITE_BREAK_CONDITION*, int> )(lpVtbl[6]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), breakConditionBefore, breakConditionAfter);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, BOOL isSideways, BOOL isRightToLeft, IUnknown* clientDrawingEffect);
        [VtblIndex(4)]
        HRESULT GetMetrics(DWRITE_INLINE_OBJECT_METRICS* metrics);
        [VtblIndex(5)]
        HRESULT GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs);
        [VtblIndex(6)]
        HRESULT GetBreakConditions(DWRITE_BREAK_CONDITION* breakConditionBefore, DWRITE_BREAK_CONDITION* breakConditionAfter);
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
        [NativeTypeName("HRESULT (void *, IDWriteTextRenderer *, FLOAT, FLOAT, BOOL, BOOL, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, IDWriteTextRenderer*, float, float, BOOL, BOOL, IUnknown*, int> Draw;
        [NativeTypeName("HRESULT (DWRITE_INLINE_OBJECT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_INLINE_OBJECT_METRICS*, int> GetMetrics;
        [NativeTypeName("HRESULT (DWRITE_OVERHANG_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_OVERHANG_METRICS*, int> GetOverhangMetrics;
        [NativeTypeName("HRESULT (DWRITE_BREAK_CONDITION *, DWRITE_BREAK_CONDITION *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_BREAK_CONDITION*, DWRITE_BREAK_CONDITION*, int> GetBreakConditions;
    }
}