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

[Guid("12009F94-0D14-5443-BC09-250311CE570B")]
[NativeTypeName("struct IPrintWorkflowPrinterJob : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPrinterJob
    : IPrintWorkflowPrinterJob.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowPrinterJob));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintWorkflowPrinterJob, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPrintWorkflowPrinterJob, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintWorkflowPrinterJob, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPrintWorkflowPrinterJob, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPrintWorkflowPrinterJob, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPrintWorkflowPrinterJob, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_JobId([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IPrintWorkflowPrinterJob, int*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Printer(
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")]
            IIppPrintDevice* value
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPrinterJob, IIppPrintDevice*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetJobStatus(
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPrinterJobStatus *"
        )]
            PrintWorkflowPrinterJobStatus* result
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPrinterJob, PrintWorkflowPrinterJobStatus*, int>)(
                (*lpVtbl)[8]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetJobPrintTicket(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")]
            IWorkflowPrintTicket* result
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPrinterJob, IWorkflowPrintTicket*, int>)(
                (*lpVtbl)[9]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetJobAttributesAsBuffer(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* attributeNames,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* result
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPrinterJob, IIterable<HSTRING>*, IBuffer*, int>)(
                (*lpVtbl)[10]
            )
        )(this, attributeNames, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetJobAttributes(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* attributeNames,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **"
        )]
            IMap<HSTRING, IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPrinterJob,
                IIterable<HSTRING>*,
                IMap<HSTRING, IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, attributeNames, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetJobAttributesFromBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer jobAttributesBuffer,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")]
            IIppSetAttributesResult* result
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPrinterJob, IBuffer, IIppSetAttributesResult*, int>)(
                (*lpVtbl)[12]
            )
        )(this, jobAttributesBuffer, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetJobAttributes(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
        )]
            IIterable<IntPtr>* jobAttributes,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")]
            IIppSetAttributesResult* result
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPrinterJob,
                IIterable<IntPtr>*,
                IIppSetAttributesResult*,
                int>)((*lpVtbl)[13])
        )(this, jobAttributes, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_JobId([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_Printer(
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppPrintDevice **")]
                IIppPrintDevice* value
        );

        [VtblIndex(8)]
        HRESULT GetJobStatus(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPrinterJobStatus *"
            )]
                PrintWorkflowPrinterJobStatus* result
        );

        [VtblIndex(9)]
        HRESULT GetJobPrintTicket(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **"
            )]
                IWorkflowPrintTicket* result
        );

        [VtblIndex(10)]
        HRESULT GetJobAttributesAsBuffer(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* attributeNames,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* result
        );

        [VtblIndex(11)]
        HRESULT GetJobAttributes(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* attributeNames,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **"
            )]
                IMap<HSTRING, IntPtr>** result
        );

        [VtblIndex(12)]
        HRESULT SetJobAttributesFromBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")]
                IBuffer jobAttributesBuffer,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")]
                IIppSetAttributesResult* result
        );

        [VtblIndex(13)]
        HRESULT SetJobAttributes(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
            )]
                IIterable<IntPtr>* jobAttributes,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppSetAttributesResult **")]
                IIppSetAttributesResult* result
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_JobId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Printers::IIppPrintDevice **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIppPrintDevice*, int> get_Printer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPrinterJobStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PrintWorkflowPrinterJobStatus*, int> GetJobStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWorkflowPrintTicket*, int> GetJobPrintTicket;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IBuffer*,
            int> GetJobAttributesAsBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IMap<HSTRING, IntPtr>**,
            int> GetJobAttributes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::Printers::IIppSetAttributesResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            IIppSetAttributesResult*,
            int> SetJobAttributesFromBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, ABI::Windows::Devices::Printers::IIppSetAttributesResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IIppSetAttributesResult*,
            int> SetJobAttributes;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintWorkflowPrinterJob"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintWorkflowPrinterJob(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintWorkflowPrinterJob"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowPrinterJob(Silk.NET.WinRT.IInspectable value)
    {
        return new IPrintWorkflowPrinterJob(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowPrinterJob"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowPrinterJob"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPrintWorkflowPrinterJob value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintWorkflowPrinterJob"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowPrinterJob(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintWorkflowPrinterJob(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowPrinterJob"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowPrinterJob"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintWorkflowPrinterJob value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
