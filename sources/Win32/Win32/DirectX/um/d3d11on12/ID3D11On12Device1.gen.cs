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

[Guid("BDB64DF4-EA2F-4C70-B861-AAAB1258BB5D")]
[NativeTypeName("struct ID3D11On12Device1 : ID3D11On12Device")]
[NativeInheritance("ID3D11On12Device")]
[SupportedOSPlatform("windows10.0.18362.0")]
public unsafe partial struct ID3D11On12Device1 : ID3D11On12Device1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11On12Device1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11On12Device1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D11On12Device1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11On12Device1, uint>)((*lpVtbl)[2]))(this);
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
                ID3D11On12Device1,
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
        ((delegate* unmanaged<ID3D11On12Device1, ID3D11Resource*, uint, void>)((*lpVtbl)[4]))(
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
        ((delegate* unmanaged<ID3D11On12Device1, ID3D11Resource*, uint, void>)((*lpVtbl)[5]))(
            this,
            ppResources,
            NumResources
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetD3D12Device([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D11On12Device1, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppvDevice
        );
    }

    public interface Interface : ID3D11On12Device.Interface
    {
        [VtblIndex(6)]
        HRESULT GetD3D12Device([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11On12Device1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11On12Device1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11On12Device"/> to <see cref = "ID3D11On12Device1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11On12Device"/> instance to be converted </param>
    public static explicit operator ID3D11On12Device1(Silk.NET.DirectX.ID3D11On12Device value)
    {
        return new ID3D11On12Device1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11On12Device1"/> to <see cref = "Silk.NET.DirectX.ID3D11On12Device"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11On12Device1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11On12Device(ID3D11On12Device1 value)
    {
        return new Silk.NET.DirectX.ID3D11On12Device(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11On12Device1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11On12Device1(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11On12Device1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11On12Device1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11On12Device1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11On12Device1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
