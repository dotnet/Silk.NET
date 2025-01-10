// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("61552388-01AB-4008-A436-83DB189566EA")]
[NativeTypeName(
    "struct ID3D12DeviceRemovedExtendedDataSettings2 : ID3D12DeviceRemovedExtendedDataSettings1"
)]
[NativeInheritance("ID3D12DeviceRemovedExtendedDataSettings1")]
public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings2
    : ID3D12DeviceRemovedExtendedDataSettings2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceRemovedExtendedDataSettings2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings2, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings2, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement)
    {
        (
            (delegate* unmanaged<
                ID3D12DeviceRemovedExtendedDataSettings2,
                D3D12_DRED_ENABLEMENT,
                void>)((*lpVtbl)[3])
        )(this, Enablement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement)
    {
        (
            (delegate* unmanaged<
                ID3D12DeviceRemovedExtendedDataSettings2,
                D3D12_DRED_ENABLEMENT,
                void>)((*lpVtbl)[4])
        )(this, Enablement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement)
    {
        (
            (delegate* unmanaged<
                ID3D12DeviceRemovedExtendedDataSettings2,
                D3D12_DRED_ENABLEMENT,
                void>)((*lpVtbl)[5])
        )(this, Enablement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetBreadcrumbContextEnablement(D3D12_DRED_ENABLEMENT Enablement)
    {
        (
            (delegate* unmanaged<
                ID3D12DeviceRemovedExtendedDataSettings2,
                D3D12_DRED_ENABLEMENT,
                void>)((*lpVtbl)[6])
        )(this, Enablement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void UseMarkersOnlyAutoBreadcrumbs(BOOL MarkersOnly)
    {
        ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings2, BOOL, void>)((*lpVtbl)[7]))(
            this,
            MarkersOnly
        );
    }

    public interface Interface : ID3D12DeviceRemovedExtendedDataSettings1.Interface
    {
        [VtblIndex(7)]
        void UseMarkersOnlyAutoBreadcrumbs(BOOL MarkersOnly);
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

        [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DRED_ENABLEMENT,
            void> SetAutoBreadcrumbsEnablement;

        [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DRED_ENABLEMENT, void> SetPageFaultEnablement;

        [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DRED_ENABLEMENT, void> SetWatsonDumpEnablement;

        [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DRED_ENABLEMENT,
            void> SetBreadcrumbContextEnablement;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> UseMarkersOnlyAutoBreadcrumbs;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceRemovedExtendedDataSettings2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceRemovedExtendedDataSettings2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings1"/> to <see cref = "ID3D12DeviceRemovedExtendedDataSettings2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings1"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedDataSettings2(
        Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings1 value
    )
    {
        return new ID3D12DeviceRemovedExtendedDataSettings2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12DeviceRemovedExtendedDataSettings2"/> to <see cref = "Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedDataSettings2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings1(
        ID3D12DeviceRemovedExtendedDataSettings2 value
    )
    {
        return new Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings"/> to <see cref = "ID3D12DeviceRemovedExtendedDataSettings2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedDataSettings2(
        Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings value
    )
    {
        return new ID3D12DeviceRemovedExtendedDataSettings2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12DeviceRemovedExtendedDataSettings2"/> to <see cref = "Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedDataSettings2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings(
        ID3D12DeviceRemovedExtendedDataSettings2 value
    )
    {
        return new Silk.NET.DirectX.ID3D12DeviceRemovedExtendedDataSettings(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12DeviceRemovedExtendedDataSettings2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedDataSettings2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ID3D12DeviceRemovedExtendedDataSettings2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12DeviceRemovedExtendedDataSettings2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedDataSettings2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ID3D12DeviceRemovedExtendedDataSettings2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
