// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings"]/*' />
[Guid("82BC481C-6B9B-4030-AEDB-7EE3D1DF1E63")]
[NativeTypeName("struct ID3D12DeviceRemovedExtendedDataSettings : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.18362.0")]
public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings : ID3D12DeviceRemovedExtendedDataSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceRemovedExtendedDataSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, uint>)(lpVtbl[1]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, uint>)(lpVtbl[2]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings.SetAutoBreadcrumbsEnablement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetAutoBreadcrumbsEnablement(D3D12_DRED_ENABLEMENT Enablement)
    {
        ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[3]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
    }

    /// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings.SetPageFaultEnablement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetPageFaultEnablement(D3D12_DRED_ENABLEMENT Enablement)
    {
        ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[4]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
    }

    /// <include file='ID3D12DeviceRemovedExtendedDataSettings.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedDataSettings.SetWatsonDumpEnablement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetWatsonDumpEnablement(D3D12_DRED_ENABLEMENT Enablement)
    {
        ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings*, D3D12_DRED_ENABLEMENT, void>)(lpVtbl[5]))((ID3D12DeviceRemovedExtendedDataSettings*)Unsafe.AsPointer(ref this), Enablement);
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
        public delegate* unmanaged<TSelf*, D3D12_DRED_ENABLEMENT, void> SetAutoBreadcrumbsEnablement;

        [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DRED_ENABLEMENT, void> SetPageFaultEnablement;

        [NativeTypeName("void (D3D12_DRED_ENABLEMENT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DRED_ENABLEMENT, void> SetWatsonDumpEnablement;
    }
}
