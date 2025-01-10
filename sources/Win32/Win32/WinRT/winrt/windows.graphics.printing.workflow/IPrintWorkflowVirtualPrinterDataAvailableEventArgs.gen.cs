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

[Guid("6B7D5003-14A8-5D52-A428-07330FBAB11F")]
[NativeTypeName("struct IPrintWorkflowVirtualPrinterDataAvailableEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowVirtualPrinterDataAvailableEventArgs
    : IPrintWorkflowVirtualPrinterDataAvailableEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IPrintWorkflowVirtualPrinterDataAvailableEventArgs)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterDataAvailableEventArgs,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IPrintWorkflowVirtualPrinterDataAvailableEventArgs, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IPrintWorkflowVirtualPrinterDataAvailableEventArgs, uint>)(
                (*lpVtbl)[2]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterDataAvailableEventArgs,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterDataAvailableEventArgs,
                HSTRING*,
                int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterDataAvailableEventArgs,
                TrustLevel*,
                int>)((*lpVtbl)[5])
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
                IPrintWorkflowVirtualPrinterDataAvailableEventArgs,
                IPrintWorkflowConfiguration*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SourceContent(
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **"
        )]
            IPrintWorkflowPdlSourceContent* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterDataAvailableEventArgs,
                IPrintWorkflowPdlSourceContent*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UILauncher(
        [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **")]
            IPrintWorkflowUILauncher* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterDataAvailableEventArgs,
                IPrintWorkflowUILauncher*,
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
                IPrintWorkflowVirtualPrinterDataAvailableEventArgs,
                IWorkflowPrintTicket*,
                int>)((*lpVtbl)[9])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPdlConverter(
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPdlConversionType"
        )]
            PrintWorkflowPdlConversionType conversionType,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlConverter **"
        )]
            IPrintWorkflowPdlConverter* result
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterDataAvailableEventArgs,
                PrintWorkflowPdlConversionType,
                IPrintWorkflowPdlConverter*,
                int>)((*lpVtbl)[10])
        )(this, conversionType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetTargetFileAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterDataAvailableEventArgs,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CompleteJob(
        [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus")]
            PrintWorkflowSubmittedStatus status
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowVirtualPrinterDataAvailableEventArgs,
                PrintWorkflowSubmittedStatus,
                int>)((*lpVtbl)[12])
        )(this, status);
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
        HRESULT get_SourceContent(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **"
            )]
                IPrintWorkflowPdlSourceContent* value
        );

        [VtblIndex(8)]
        HRESULT get_UILauncher(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **"
            )]
                IPrintWorkflowUILauncher* value
        );

        [VtblIndex(9)]
        HRESULT GetJobPrintTicket(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **"
            )]
                IWorkflowPrintTicket* result
        );

        [VtblIndex(10)]
        HRESULT GetPdlConverter(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPdlConversionType"
            )]
                PrintWorkflowPdlConversionType conversionType,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlConverter **"
            )]
                IPrintWorkflowPdlConverter* result
        );

        [VtblIndex(11)]
        HRESULT GetTargetFileAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(12)]
        HRESULT CompleteJob(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus"
            )]
                PrintWorkflowSubmittedStatus status
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
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowPdlSourceContent*, int> get_SourceContent;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowUILauncher*, int> get_UILauncher;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWorkflowPrintTicket*, int> GetJobPrintTicket;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPdlConversionType, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlConverter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PrintWorkflowPdlConversionType,
            IPrintWorkflowPdlConverter*,
            int> GetPdlConverter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetTargetFileAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PrintWorkflowSubmittedStatus, int> CompleteJob;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintWorkflowVirtualPrinterDataAvailableEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowVirtualPrinterDataAvailableEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPrintWorkflowVirtualPrinterDataAvailableEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPrintWorkflowVirtualPrinterDataAvailableEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowVirtualPrinterDataAvailableEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPrintWorkflowVirtualPrinterDataAvailableEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowVirtualPrinterDataAvailableEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPrintWorkflowVirtualPrinterDataAvailableEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
