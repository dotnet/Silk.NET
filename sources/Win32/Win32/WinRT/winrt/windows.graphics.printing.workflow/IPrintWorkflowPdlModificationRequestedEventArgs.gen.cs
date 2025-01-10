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

[Guid("1A339A61-2E13-5EDD-A707-CEEC61D7333B")]
[NativeTypeName("struct IPrintWorkflowPdlModificationRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPdlModificationRequestedEventArgs
    : IPrintWorkflowPdlModificationRequestedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IPrintWorkflowPdlModificationRequestedEventArgs)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPdlModificationRequestedEventArgs,
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
            (delegate* unmanaged<IPrintWorkflowPdlModificationRequestedEventArgs, uint>)(
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
            (delegate* unmanaged<IPrintWorkflowPdlModificationRequestedEventArgs, uint>)(
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
                IPrintWorkflowPdlModificationRequestedEventArgs,
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
            (delegate* unmanaged<IPrintWorkflowPdlModificationRequestedEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPdlModificationRequestedEventArgs,
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
                IPrintWorkflowPdlModificationRequestedEventArgs,
                IPrintWorkflowConfiguration*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PrinterJob(
        [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **")]
            IPrintWorkflowPrinterJob* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPdlModificationRequestedEventArgs,
                IPrintWorkflowPrinterJob*,
                int>)((*lpVtbl)[7])
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
                IPrintWorkflowPdlModificationRequestedEventArgs,
                IPrintWorkflowPdlSourceContent*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UILauncher(
        [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **")]
            IPrintWorkflowUILauncher* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPdlModificationRequestedEventArgs,
                IPrintWorkflowUILauncher*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateJobOnPrinter(
        HSTRING targetContentType,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **"
        )]
            IPrintWorkflowPdlTargetStream* result
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPdlModificationRequestedEventArgs,
                HSTRING,
                IPrintWorkflowPdlTargetStream*,
                int>)((*lpVtbl)[10])
        )(this, targetContentType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateJobOnPrinterWithAttributes(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
        )]
            IIterable<IntPtr>* jobAttributes,
        HSTRING targetContentType,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **"
        )]
            IPrintWorkflowPdlTargetStream* result
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPdlModificationRequestedEventArgs,
                IIterable<IntPtr>*,
                HSTRING,
                IPrintWorkflowPdlTargetStream*,
                int>)((*lpVtbl)[11])
        )(this, jobAttributes, targetContentType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateJobOnPrinterWithAttributesBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer jobAttributesBuffer,
        HSTRING targetContentType,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **"
        )]
            IPrintWorkflowPdlTargetStream* result
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPdlModificationRequestedEventArgs,
                IBuffer,
                HSTRING,
                IPrintWorkflowPdlTargetStream*,
                int>)((*lpVtbl)[12])
        )(this, jobAttributesBuffer, targetContentType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
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
                IPrintWorkflowPdlModificationRequestedEventArgs,
                PrintWorkflowPdlConversionType,
                IPrintWorkflowPdlConverter*,
                int>)((*lpVtbl)[13])
        )(this, conversionType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* result
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPdlModificationRequestedEventArgs, IDeferral*, int>)(
                (*lpVtbl)[14]
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
        HRESULT get_PrinterJob(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **"
            )]
                IPrintWorkflowPrinterJob* value
        );

        [VtblIndex(8)]
        HRESULT get_SourceContent(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **"
            )]
                IPrintWorkflowPdlSourceContent* value
        );

        [VtblIndex(9)]
        HRESULT get_UILauncher(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **"
            )]
                IPrintWorkflowUILauncher* value
        );

        [VtblIndex(10)]
        HRESULT CreateJobOnPrinter(
            HSTRING targetContentType,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **"
            )]
                IPrintWorkflowPdlTargetStream* result
        );

        [VtblIndex(11)]
        HRESULT CreateJobOnPrinterWithAttributes(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
            )]
                IIterable<IntPtr>* jobAttributes,
            HSTRING targetContentType,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **"
            )]
                IPrintWorkflowPdlTargetStream* result
        );

        [VtblIndex(12)]
        HRESULT CreateJobOnPrinterWithAttributesBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")]
                IBuffer jobAttributesBuffer,
            HSTRING targetContentType,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **"
            )]
                IPrintWorkflowPdlTargetStream* result
        );

        [VtblIndex(13)]
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

        [VtblIndex(14)]
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
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowPrinterJob*, int> get_PrinterJob;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowPdlSourceContent*, int> get_SourceContent;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowUILauncher*, int> get_UILauncher;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IPrintWorkflowPdlTargetStream*,
            int> CreateJobOnPrinter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, HSTRING, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            HSTRING,
            IPrintWorkflowPdlTargetStream*,
            int> CreateJobOnPrinterWithAttributes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, HSTRING, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            HSTRING,
            IPrintWorkflowPdlTargetStream*,
            int> CreateJobOnPrinterWithAttributesBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPdlConversionType, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlConverter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PrintWorkflowPdlConversionType,
            IPrintWorkflowPdlConverter*,
            int> GetPdlConverter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintWorkflowPdlModificationRequestedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowPdlModificationRequestedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPrintWorkflowPdlModificationRequestedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPrintWorkflowPdlModificationRequestedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowPdlModificationRequestedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPrintWorkflowPdlModificationRequestedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPrintWorkflowPdlModificationRequestedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
