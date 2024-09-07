// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12DeviceRemovedExtendedData2.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData2"]/*'/>
[Guid("67FC5816-E4CA-4915-BF18-42541272DA54")]
[NativeTypeName("struct ID3D12DeviceRemovedExtendedData2 : ID3D12DeviceRemovedExtendedData1")]
[NativeInheritance("ID3D12DeviceRemovedExtendedData1")]
public unsafe partial struct ID3D12DeviceRemovedExtendedData2
    : ID3D12DeviceRemovedExtendedData2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceRemovedExtendedData2));
    public void** lpVtbl;

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, Guid*, void**, int>)(lpVtbl[0])
        )((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, uint>)(lpVtbl[1]))(
            (ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, uint>)(lpVtbl[2]))(
            (ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12DeviceRemovedExtendedData.GetAutoBreadcrumbsOutput"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAutoBreadcrumbsOutput(D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT* pOutput)
    {
        return (
            (delegate* unmanaged<
                ID3D12DeviceRemovedExtendedData2*,
                D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT*,
                int>)(lpVtbl[3])
        )((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
    }

    /// <inheritdoc cref = "ID3D12DeviceRemovedExtendedData.GetPageFaultAllocationOutput"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPageFaultAllocationOutput(D3D12_DRED_PAGE_FAULT_OUTPUT* pOutput)
    {
        return (
            (delegate* unmanaged<
                ID3D12DeviceRemovedExtendedData2*,
                D3D12_DRED_PAGE_FAULT_OUTPUT*,
                int>)(lpVtbl[4])
        )((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
    }

    /// <inheritdoc cref = "ID3D12DeviceRemovedExtendedData1.GetAutoBreadcrumbsOutput1"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAutoBreadcrumbsOutput1(D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1* pOutput)
    {
        return (
            (delegate* unmanaged<
                ID3D12DeviceRemovedExtendedData2*,
                D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1*,
                int>)(lpVtbl[5])
        )((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
    }

    /// <inheritdoc cref = "ID3D12DeviceRemovedExtendedData1.GetPageFaultAllocationOutput1"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPageFaultAllocationOutput1(D3D12_DRED_PAGE_FAULT_OUTPUT1* pOutput)
    {
        return (
            (delegate* unmanaged<
                ID3D12DeviceRemovedExtendedData2*,
                D3D12_DRED_PAGE_FAULT_OUTPUT1*,
                int>)(lpVtbl[6])
        )((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
    }

    /// <include file='ID3D12DeviceRemovedExtendedData2.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData2.GetPageFaultAllocationOutput2"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPageFaultAllocationOutput2(D3D12_DRED_PAGE_FAULT_OUTPUT2* pOutput)
    {
        return (
            (delegate* unmanaged<
                ID3D12DeviceRemovedExtendedData2*,
                D3D12_DRED_PAGE_FAULT_OUTPUT2*,
                int>)(lpVtbl[7])
        )((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this), pOutput);
    }

    /// <include file='ID3D12DeviceRemovedExtendedData2.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData2.GetDeviceState"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public D3D12_DRED_DEVICE_STATE GetDeviceState()
    {
        return (
            (delegate* unmanaged<ID3D12DeviceRemovedExtendedData2*, D3D12_DRED_DEVICE_STATE>)(
                lpVtbl[8]
            )
        )((ID3D12DeviceRemovedExtendedData2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID3D12DeviceRemovedExtendedData1.Interface
    {
        [VtblIndex(7)]
        HRESULT GetPageFaultAllocationOutput2(D3D12_DRED_PAGE_FAULT_OUTPUT2* pOutput);

        [VtblIndex(8)]
        D3D12_DRED_DEVICE_STATE GetDeviceState();
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

        [NativeTypeName("HRESULT (D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT*,
            int> GetAutoBreadcrumbsOutput;

        [NativeTypeName("HRESULT (D3D12_DRED_PAGE_FAULT_OUTPUT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DRED_PAGE_FAULT_OUTPUT*,
            int> GetPageFaultAllocationOutput;

        [NativeTypeName("HRESULT (D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1*,
            int> GetAutoBreadcrumbsOutput1;

        [NativeTypeName("HRESULT (D3D12_DRED_PAGE_FAULT_OUTPUT1 *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DRED_PAGE_FAULT_OUTPUT1*,
            int> GetPageFaultAllocationOutput1;

        [NativeTypeName("HRESULT (D3D12_DRED_PAGE_FAULT_OUTPUT2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DRED_PAGE_FAULT_OUTPUT2*,
            int> GetPageFaultAllocationOutput2;

        [NativeTypeName("D3D12_DRED_DEVICE_STATE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DRED_DEVICE_STATE> GetDeviceState;
    }
}
