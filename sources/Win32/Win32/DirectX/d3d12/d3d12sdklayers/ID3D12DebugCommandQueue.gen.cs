// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("09E0BF36-54AC-484F-8847-4BAEEAB6053A")]
[NativeTypeName("struct ID3D12DebugCommandQueue : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DebugCommandQueue
    : ID3D12DebugCommandQueue.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandQueue));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12DebugCommandQueue, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12DebugCommandQueue, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12DebugCommandQueue, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State)
    {
        return (
            (delegate* unmanaged<ID3D12DebugCommandQueue, ID3D12Resource, uint, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pResource, Subresource, State);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        BOOL AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State);
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

        [NativeTypeName("BOOL (ID3D12Resource *, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource, uint, uint, int> AssertResourceState;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugCommandQueue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugCommandQueue(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12DebugCommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandQueue(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12DebugCommandQueue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12DebugCommandQueue"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandQueue"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12DebugCommandQueue value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
