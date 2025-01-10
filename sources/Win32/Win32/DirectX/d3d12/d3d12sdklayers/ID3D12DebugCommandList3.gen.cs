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

[Guid("197D5E15-4D37-4D34-AF78-724CD70FDB1F")]
[NativeTypeName("struct ID3D12DebugCommandList3 : ID3D12DebugCommandList2")]
[NativeInheritance("ID3D12DebugCommandList2")]
public unsafe partial struct ID3D12DebugCommandList3
    : ID3D12DebugCommandList3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandList3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12DebugCommandList3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12DebugCommandList3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12DebugCommandList3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL AssertResourceState(ID3D12Resource pResource, uint Subresource, uint State)
    {
        return (
            (delegate* unmanaged<ID3D12DebugCommandList3, ID3D12Resource, uint, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pResource, Subresource, State);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFeatureMask(D3D12_DEBUG_FEATURE Mask)
    {
        return (
            (delegate* unmanaged<ID3D12DebugCommandList3, D3D12_DEBUG_FEATURE, int>)((*lpVtbl)[4])
        )(this, Mask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public D3D12_DEBUG_FEATURE GetFeatureMask()
    {
        return ((delegate* unmanaged<ID3D12DebugCommandList3, D3D12_DEBUG_FEATURE>)((*lpVtbl)[5]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetDebugParameter(
        D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type,
        [NativeTypeName("const void *")] void* pData,
        uint DataSize
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12DebugCommandList3,
                D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE,
                void*,
                uint,
                int>)((*lpVtbl)[6])
        )(this, Type, pData, DataSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDebugParameter(
        D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type,
        void* pData,
        uint DataSize
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12DebugCommandList3,
                D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE,
                void*,
                uint,
                int>)((*lpVtbl)[7])
        )(this, Type, pData, DataSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void AssertResourceAccess(
        ID3D12Resource pResource,
        uint Subresource,
        D3D12_BARRIER_ACCESS Access
    )
    {
        (
            (delegate* unmanaged<
                ID3D12DebugCommandList3,
                ID3D12Resource,
                uint,
                D3D12_BARRIER_ACCESS,
                void>)((*lpVtbl)[8])
        )(this, pResource, Subresource, Access);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void AssertTextureLayout(
        ID3D12Resource pResource,
        uint Subresource,
        D3D12_BARRIER_LAYOUT Layout
    )
    {
        (
            (delegate* unmanaged<
                ID3D12DebugCommandList3,
                ID3D12Resource,
                uint,
                D3D12_BARRIER_LAYOUT,
                void>)((*lpVtbl)[9])
        )(this, pResource, Subresource, Layout);
    }

    public interface Interface : ID3D12DebugCommandList2.Interface
    {
        [VtblIndex(8)]
        void AssertResourceAccess(
            ID3D12Resource pResource,
            uint Subresource,
            D3D12_BARRIER_ACCESS Access
        );

        [VtblIndex(9)]
        void AssertTextureLayout(
            ID3D12Resource pResource,
            uint Subresource,
            D3D12_BARRIER_LAYOUT Layout
        );
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

        [NativeTypeName("HRESULT (D3D12_DEBUG_FEATURE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DEBUG_FEATURE, int> SetFeatureMask;

        [NativeTypeName("D3D12_DEBUG_FEATURE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DEBUG_FEATURE> GetFeatureMask;

        [NativeTypeName(
            "HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, const void *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE,
            void*,
            uint,
            int> SetDebugParameter;

        [NativeTypeName(
            "HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE,
            void*,
            uint,
            int> GetDebugParameter;

        [NativeTypeName(
            "void (ID3D12Resource *, UINT, D3D12_BARRIER_ACCESS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            uint,
            D3D12_BARRIER_ACCESS,
            void> AssertResourceAccess;

        [NativeTypeName(
            "void (ID3D12Resource *, UINT, D3D12_BARRIER_LAYOUT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            uint,
            D3D12_BARRIER_LAYOUT,
            void> AssertTextureLayout;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugCommandList3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugCommandList3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DebugCommandList2"/> to <see cref = "ID3D12DebugCommandList3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DebugCommandList2"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandList3(
        Silk.NET.DirectX.ID3D12DebugCommandList2 value
    )
    {
        return new ID3D12DebugCommandList3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12DebugCommandList3"/> to <see cref = "Silk.NET.DirectX.ID3D12DebugCommandList2"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DebugCommandList2(
        ID3D12DebugCommandList3 value
    )
    {
        return new Silk.NET.DirectX.ID3D12DebugCommandList2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DebugCommandList"/> to <see cref = "ID3D12DebugCommandList3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DebugCommandList"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandList3(
        Silk.NET.DirectX.ID3D12DebugCommandList value
    )
    {
        return new ID3D12DebugCommandList3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12DebugCommandList3"/> to <see cref = "Silk.NET.DirectX.ID3D12DebugCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DebugCommandList(
        ID3D12DebugCommandList3 value
    )
    {
        return new Silk.NET.DirectX.ID3D12DebugCommandList(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12DebugCommandList3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12DebugCommandList3(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12DebugCommandList3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12DebugCommandList3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugCommandList3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12DebugCommandList3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
