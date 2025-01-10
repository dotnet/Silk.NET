// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("82BC481C-6B9B-4030-AEDB-7EE3D1DF1E63")]
[NativeTypeName("struct ID3D12DeviceRemovedExtendedDataSettings : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.18362.0")]
public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings
    : ID3D12DeviceRemovedExtendedDataSettings.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceRemovedExtendedDataSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement)
    {
        (
            (delegate* unmanaged<
                ID3D12DeviceRemovedExtendedDataSettings,
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
                ID3D12DeviceRemovedExtendedDataSettings,
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
                ID3D12DeviceRemovedExtendedDataSettings,
                D3D12_DRED_ENABLEMENT,
                void>)((*lpVtbl)[5])
        )(this, Enablement);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement);

        [VtblIndex(4)]
        void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement);

        [VtblIndex(5)]
        void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DeviceRemovedExtendedDataSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12DeviceRemovedExtendedDataSettings(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ID3D12DeviceRemovedExtendedDataSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DeviceRemovedExtendedDataSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ID3D12DeviceRemovedExtendedDataSettings value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
