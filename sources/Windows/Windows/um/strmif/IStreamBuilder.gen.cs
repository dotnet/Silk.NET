// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IStreamBuilder.xml' path='doc/member[@name="IStreamBuilder"]/*' />
[Guid("56A868BF-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IStreamBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStreamBuilder : IStreamBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamBuilder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IStreamBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStreamBuilder*, uint>)(lpVtbl[1]))((IStreamBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamBuilder*, uint>)(lpVtbl[2]))((IStreamBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStreamBuilder.xml' path='doc/member[@name="IStreamBuilder.Render"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Render(IPin* ppinOut, IGraphBuilder* pGraph)
    {
        return ((delegate* unmanaged<IStreamBuilder*, IPin*, IGraphBuilder*, int>)(lpVtbl[3]))((IStreamBuilder*)Unsafe.AsPointer(ref this), ppinOut, pGraph);
    }

    /// <include file='IStreamBuilder.xml' path='doc/member[@name="IStreamBuilder.Backout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Backout(IPin* ppinOut, IGraphBuilder* pGraph)
    {
        return ((delegate* unmanaged<IStreamBuilder*, IPin*, IGraphBuilder*, int>)(lpVtbl[4]))((IStreamBuilder*)Unsafe.AsPointer(ref this), ppinOut, pGraph);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Render(IPin* ppinOut, IGraphBuilder* pGraph);

        [VtblIndex(4)]
        HRESULT Backout(IPin* ppinOut, IGraphBuilder* pGraph);
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

        [NativeTypeName("HRESULT (IPin *, IGraphBuilder *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, IGraphBuilder*, int> Render;

        [NativeTypeName("HRESULT (IPin *, IGraphBuilder *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, IGraphBuilder*, int> Backout;
    }
}
