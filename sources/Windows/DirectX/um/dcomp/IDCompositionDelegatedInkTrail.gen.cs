// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDCompositionDelegatedInkTrail.xml' path='doc/member[@name="IDCompositionDelegatedInkTrail"]/*'/>
[Guid("C2448E9B-547D-4057-8CF5-8144EDE1C2DA")]
[NativeTypeName("struct IDCompositionDelegatedInkTrail : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionDelegatedInkTrail : IDCompositionDelegatedInkTrail.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDelegatedInkTrail));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, uint> )(lpVtbl[1]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, uint> )(lpVtbl[2]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionDelegatedInkTrail.xml' path='doc/member[@name="IDCompositionDelegatedInkTrail.AddTrailPoints"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddTrailPoints([NativeTypeName("const DCompositionInkTrailPoint *")] DCompositionInkTrailPoint* inkPoints, uint inkPointsCount, uint* generationId)
    {
        return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, DCompositionInkTrailPoint*, uint, uint*, int> )(lpVtbl[3]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this), inkPoints, inkPointsCount, generationId);
    }

    /// <include file='IDCompositionDelegatedInkTrail.xml' path='doc/member[@name="IDCompositionDelegatedInkTrail.AddTrailPointsWithPrediction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddTrailPointsWithPrediction([NativeTypeName("const DCompositionInkTrailPoint *")] DCompositionInkTrailPoint* inkPoints, uint inkPointsCount, [NativeTypeName("const DCompositionInkTrailPoint *")] DCompositionInkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
    {
        return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, DCompositionInkTrailPoint*, uint, DCompositionInkTrailPoint*, uint, uint*, int> )(lpVtbl[4]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this), inkPoints, inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationId);
    }

    /// <include file='IDCompositionDelegatedInkTrail.xml' path='doc/member[@name="IDCompositionDelegatedInkTrail.RemoveTrailPoints"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemoveTrailPoints(uint generationId)
    {
        return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, uint, int> )(lpVtbl[5]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this), generationId);
    }

    /// <include file='IDCompositionDelegatedInkTrail.xml' path='doc/member[@name="IDCompositionDelegatedInkTrail.StartNewTrail"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StartNewTrail([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color)
    {
        return ((delegate* unmanaged<IDCompositionDelegatedInkTrail*, DXGI_RGBA*, int> )(lpVtbl[6]))((IDCompositionDelegatedInkTrail*)Unsafe.AsPointer(ref this), color);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddTrailPoints([NativeTypeName("const DCompositionInkTrailPoint *")] DCompositionInkTrailPoint* inkPoints, uint inkPointsCount, uint* generationId);
        [VtblIndex(4)]
        HRESULT AddTrailPointsWithPrediction([NativeTypeName("const DCompositionInkTrailPoint *")] DCompositionInkTrailPoint* inkPoints, uint inkPointsCount, [NativeTypeName("const DCompositionInkTrailPoint *")] DCompositionInkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, uint* generationId);
        [VtblIndex(5)]
        HRESULT RemoveTrailPoints(uint generationId);
        [VtblIndex(6)]
        HRESULT StartNewTrail([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color);
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
        [NativeTypeName("HRESULT (const DCompositionInkTrailPoint *, UINT, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DCompositionInkTrailPoint*, uint, uint*, int> AddTrailPoints;
        [NativeTypeName("HRESULT (const DCompositionInkTrailPoint *, UINT, const DCompositionInkTrailPoint *, UINT, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DCompositionInkTrailPoint*, uint, DCompositionInkTrailPoint*, uint, uint*, int> AddTrailPointsWithPrediction;
        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveTrailPoints;
        [NativeTypeName("HRESULT (const D2D1_COLOR_F &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, int> StartNewTrail;
    }
}