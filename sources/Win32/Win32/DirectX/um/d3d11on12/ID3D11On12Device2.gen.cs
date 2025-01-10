// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("DC90F331-4740-43FA-866E-67F12CB58223")]
[NativeTypeName("struct ID3D11On12Device2 : ID3D11On12Device1")]
[NativeInheritance("ID3D11On12Device1")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct ID3D11On12Device2 : ID3D11On12Device2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11On12Device2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11On12Device2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D11On12Device2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11On12Device2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateWrappedResource(
        IUnknown pResource12,
        [NativeTypeName("const D3D11_RESOURCE_FLAGS *")] D3D11_RESOURCE_FLAGS* pFlags11,
        D3D12_RESOURCE_STATES InState,
        D3D12_RESOURCE_STATES OutState,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppResource11
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11On12Device2,
                IUnknown,
                D3D11_RESOURCE_FLAGS*,
                D3D12_RESOURCE_STATES,
                D3D12_RESOURCE_STATES,
                Guid*,
                void**,
                int>)((*lpVtbl)[3])
        )(this, pResource12, pFlags11, InState, OutState, riid, ppResource11);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ReleaseWrappedResources(
        [NativeTypeName("ID3D11Resource *const *")] ID3D11Resource* ppResources,
        uint NumResources
    )
    {
        ((delegate* unmanaged<ID3D11On12Device2, ID3D11Resource*, uint, void>)((*lpVtbl)[4]))(
            this,
            ppResources,
            NumResources
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void AcquireWrappedResources(
        [NativeTypeName("ID3D11Resource *const *")] ID3D11Resource* ppResources,
        uint NumResources
    )
    {
        ((delegate* unmanaged<ID3D11On12Device2, ID3D11Resource*, uint, void>)((*lpVtbl)[5]))(
            this,
            ppResources,
            NumResources
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetD3D12Device([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D11On12Device2, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppvDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnwrapUnderlyingResource(
        ID3D11Resource pResource11,
        ID3D12CommandQueue pCommandQueue,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvResource12
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11On12Device2,
                ID3D11Resource,
                ID3D12CommandQueue,
                Guid*,
                void**,
                int>)((*lpVtbl)[7])
        )(this, pResource11, pCommandQueue, riid, ppvResource12);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReturnUnderlyingResource(
        ID3D11Resource pResource11,
        uint NumSync,
        [NativeTypeName("UINT64 *")] ulong* pSignalValues,
        ID3D12Fence* ppFences
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11On12Device2,
                ID3D11Resource,
                uint,
                ulong*,
                ID3D12Fence*,
                int>)((*lpVtbl)[8])
        )(this, pResource11, NumSync, pSignalValues, ppFences);
    }

    public interface Interface : ID3D11On12Device1.Interface
    {
        [VtblIndex(7)]
        HRESULT UnwrapUnderlyingResource(
            ID3D11Resource pResource11,
            ID3D12CommandQueue pCommandQueue,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvResource12
        );

        [VtblIndex(8)]
        HRESULT ReturnUnderlyingResource(
            ID3D11Resource pResource11,
            uint NumSync,
            [NativeTypeName("UINT64 *")] ulong* pSignalValues,
            ID3D12Fence* ppFences
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

        [NativeTypeName(
            "HRESULT (IUnknown *, const D3D11_RESOURCE_FLAGS *, D3D12_RESOURCE_STATES, D3D12_RESOURCE_STATES, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            D3D11_RESOURCE_FLAGS*,
            D3D12_RESOURCE_STATES,
            D3D12_RESOURCE_STATES,
            Guid*,
            void**,
            int> CreateWrappedResource;

        [NativeTypeName("void (ID3D11Resource *const *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource*, uint, void> ReleaseWrappedResources;

        [NativeTypeName("void (ID3D11Resource *const *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource*, uint, void> AcquireWrappedResources;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetD3D12Device;

        [NativeTypeName(
            "HRESULT (ID3D11Resource *, ID3D12CommandQueue *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            ID3D12CommandQueue,
            Guid*,
            void**,
            int> UnwrapUnderlyingResource;

        [NativeTypeName(
            "HRESULT (ID3D11Resource *, UINT, UINT64 *, ID3D12Fence **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            uint,
            ulong*,
            ID3D12Fence*,
            int> ReturnUnderlyingResource;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11On12Device2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11On12Device2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11On12Device1"/> to <see cref = "ID3D11On12Device2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11On12Device1"/> instance to be converted </param>
    public static explicit operator ID3D11On12Device2(Silk.NET.DirectX.ID3D11On12Device1 value)
    {
        return new ID3D11On12Device2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11On12Device2"/> to <see cref = "Silk.NET.DirectX.ID3D11On12Device1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11On12Device2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11On12Device1(ID3D11On12Device2 value)
    {
        return new Silk.NET.DirectX.ID3D11On12Device1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11On12Device"/> to <see cref = "ID3D11On12Device2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11On12Device"/> instance to be converted </param>
    public static explicit operator ID3D11On12Device2(Silk.NET.DirectX.ID3D11On12Device value)
    {
        return new ID3D11On12Device2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11On12Device2"/> to <see cref = "Silk.NET.DirectX.ID3D11On12Device"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11On12Device2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11On12Device(ID3D11On12Device2 value)
    {
        return new Silk.NET.DirectX.ID3D11On12Device(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11On12Device2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11On12Device2(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11On12Device2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11On12Device2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11On12Device2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11On12Device2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
