// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8C48247E-E869-59FB-BC6D-DAEA0614F93E")]
[NativeTypeName("struct IIppPrintDevice4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppPrintDevice4 : IIppPrintDevice4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppPrintDevice4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIppPrintDevice4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIppPrintDevice4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIppPrintDevice4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IIppPrintDevice4, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IIppPrintDevice4, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IIppPrintDevice4, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceKind(
        [NativeTypeName("ABI::Windows::Devices::Printers::IppPrintDeviceKind *")]
            IppPrintDeviceKind* value
    )
    {
        return ((delegate* unmanaged<IIppPrintDevice4, IppPrintDeviceKind*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CanModifyUserDefaultPrintTicket([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IIppPrintDevice4, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UserDefaultPrintTicket(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")]
            IWorkflowPrintTicket* value
    )
    {
        return ((delegate* unmanaged<IIppPrintDevice4, IWorkflowPrintTicket*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_UserDefaultPrintTicket(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")]
            IWorkflowPrintTicket value
    )
    {
        return ((delegate* unmanaged<IIppPrintDevice4, IWorkflowPrintTicket, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RefreshPrintDeviceCapabilities()
    {
        return ((delegate* unmanaged<IIppPrintDevice4, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMaxSupportedPdlVersion(HSTRING pdlContentType, HSTRING* result)
    {
        return ((delegate* unmanaged<IIppPrintDevice4, HSTRING, HSTRING*, int>)((*lpVtbl)[11]))(
            this,
            pdlContentType,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceKind(
            [NativeTypeName("ABI::Windows::Devices::Printers::IppPrintDeviceKind *")]
                IppPrintDeviceKind* value
        );

        [VtblIndex(7)]
        HRESULT get_CanModifyUserDefaultPrintTicket([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_UserDefaultPrintTicket(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **"
            )]
                IWorkflowPrintTicket* value
        );

        [VtblIndex(9)]
        HRESULT put_UserDefaultPrintTicket(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *"
            )]
                IWorkflowPrintTicket value
        );

        [VtblIndex(10)]
        HRESULT RefreshPrintDeviceCapabilities();

        [VtblIndex(11)]
        HRESULT GetMaxSupportedPdlVersion(HSTRING pdlContentType, HSTRING* result);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Printers::IppPrintDeviceKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IppPrintDeviceKind*, int> get_DeviceKind;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanModifyUserDefaultPrintTicket;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWorkflowPrintTicket*, int> get_UserDefaultPrintTicket;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWorkflowPrintTicket, int> put_UserDefaultPrintTicket;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RefreshPrintDeviceCapabilities;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING*, int> GetMaxSupportedPdlVersion;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIppPrintDevice4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIppPrintDevice4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IIppPrintDevice4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IIppPrintDevice4(Silk.NET.WinRT.IInspectable value)
    {
        return new IIppPrintDevice4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppPrintDevice4"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IIppPrintDevice4"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IIppPrintDevice4 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIppPrintDevice4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIppPrintDevice4(Silk.NET.Windows.IUnknown value)
    {
        return new IIppPrintDevice4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppPrintDevice4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIppPrintDevice4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIppPrintDevice4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
