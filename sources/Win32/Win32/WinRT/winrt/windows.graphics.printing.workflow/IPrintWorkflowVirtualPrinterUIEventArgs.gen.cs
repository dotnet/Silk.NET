// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("334DBBCA-BF10-585F-B7E0-58C4AA43A03F")]
[NativeTypeName("struct IPrintWorkflowVirtualPrinterUIEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowVirtualPrinterUIEventArgs
    : IPrintWorkflowVirtualPrinterUIEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowVirtualPrinterUIEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowVirtualPrinterUIEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintWorkflowVirtualPrinterUIEventArgs, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintWorkflowVirtualPrinterUIEventArgs, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowVirtualPrinterUIEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowVirtualPrinterUIEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowVirtualPrinterUIEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Configuration(
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **"
        )]
            IPrintWorkflowConfiguration* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterUIEventArgs,
                IPrintWorkflowConfiguration*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Printer(
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")]
            IIppPrintDevice* value
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowVirtualPrinterUIEventArgs, IIppPrintDevice*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourceContent(
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **"
        )]
            IPrintWorkflowPdlSourceContent* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterUIEventArgs,
                IPrintWorkflowPdlSourceContent*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetJobPrintTicket(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")]
            IWorkflowPrintTicket* result
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterUIEventArgs,
                IWorkflowPrintTicket*,
                int>)((*lpVtbl)[9])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* result
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowVirtualPrinterUIEventArgs, IDeferral*, int>)(
                (*lpVtbl)[10]
            )
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Configuration(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **"
            )]
                IPrintWorkflowConfiguration* value
        );

        [VtblIndex(7)]
        HRESULT get_Printer(
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")]
                IIppPrintDevice* value
        );

        [VtblIndex(8)]
        HRESULT get_SourceContent(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **"
            )]
                IPrintWorkflowPdlSourceContent* value
        );

        [VtblIndex(9)]
        HRESULT GetJobPrintTicket(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **"
            )]
                IWorkflowPrintTicket* result
        );

        [VtblIndex(10)]
        HRESULT GetDeferral(
            [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* result
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowConfiguration*, int> get_Configuration;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Printers::IIppPrintDevice **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIppPrintDevice*, int> get_Printer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowPdlSourceContent*, int> get_SourceContent;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWorkflowPrintTicket*, int> GetJobPrintTicket;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintWorkflowVirtualPrinterUIEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintWorkflowVirtualPrinterUIEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintWorkflowVirtualPrinterUIEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowVirtualPrinterUIEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPrintWorkflowVirtualPrinterUIEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowVirtualPrinterUIEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowVirtualPrinterUIEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPrintWorkflowVirtualPrinterUIEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintWorkflowVirtualPrinterUIEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowVirtualPrinterUIEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPrintWorkflowVirtualPrinterUIEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowVirtualPrinterUIEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowVirtualPrinterUIEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPrintWorkflowVirtualPrinterUIEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
