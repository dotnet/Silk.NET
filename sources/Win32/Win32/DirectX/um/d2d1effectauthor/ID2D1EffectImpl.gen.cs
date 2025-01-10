// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("A248FD3F-3E6C-4E63-9F03-7F68ECC91DB9")]
[NativeTypeName("struct ID2D1EffectImpl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1EffectImpl : ID2D1EffectImpl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1EffectImpl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1EffectImpl, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1EffectImpl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1EffectImpl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(ID2D1EffectContext effectContext, ID2D1TransformGraph transformGraph)
    {
        return (
            (delegate* unmanaged<ID2D1EffectImpl, ID2D1EffectContext, ID2D1TransformGraph, int>)(
                (*lpVtbl)[3]
            )
        )(this, effectContext, transformGraph);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PrepareForRender(D2D1_CHANGE_TYPE changeType)
    {
        return ((delegate* unmanaged<ID2D1EffectImpl, D2D1_CHANGE_TYPE, int>)((*lpVtbl)[4]))(
            this,
            changeType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetGraph(ID2D1TransformGraph transformGraph)
    {
        return ((delegate* unmanaged<ID2D1EffectImpl, ID2D1TransformGraph, int>)((*lpVtbl)[5]))(
            this,
            transformGraph
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(ID2D1EffectContext effectContext, ID2D1TransformGraph transformGraph);

        [VtblIndex(4)]
        HRESULT PrepareForRender(D2D1_CHANGE_TYPE changeType);

        [VtblIndex(5)]
        HRESULT SetGraph(ID2D1TransformGraph transformGraph);
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

        [NativeTypeName(
            "HRESULT (ID2D1EffectContext *, ID2D1TransformGraph *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1EffectContext, ID2D1TransformGraph, int> Initialize;

        [NativeTypeName(
            "HRESULT (D2D1_CHANGE_TYPE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_CHANGE_TYPE, int> PrepareForRender;

        [NativeTypeName(
            "HRESULT (ID2D1TransformGraph *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1TransformGraph, int> SetGraph;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1EffectImpl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1EffectImpl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1EffectImpl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1EffectImpl(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1EffectImpl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1EffectImpl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1EffectImpl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1EffectImpl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
