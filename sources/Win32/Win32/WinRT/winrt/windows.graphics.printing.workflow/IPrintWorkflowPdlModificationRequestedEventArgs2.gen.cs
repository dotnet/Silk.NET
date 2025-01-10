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

[Guid("8D692147-6C62-5E31-A0E7-D49F92C111C0")]
[NativeTypeName("struct IPrintWorkflowPdlModificationRequestedEventArgs2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPdlModificationRequestedEventArgs2
    : IPrintWorkflowPdlModificationRequestedEventArgs2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IPrintWorkflowPdlModificationRequestedEventArgs2)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPdlModificationRequestedEventArgs2,
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
            (delegate* unmanaged<IPrintWorkflowPdlModificationRequestedEventArgs2, uint>)(
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
            (delegate* unmanaged<IPrintWorkflowPdlModificationRequestedEventArgs2, uint>)(
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
                IPrintWorkflowPdlModificationRequestedEventArgs2,
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
            (delegate* unmanaged<IPrintWorkflowPdlModificationRequestedEventArgs2, HSTRING*, int>)(
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
                IPrintWorkflowPdlModificationRequestedEventArgs2,
                TrustLevel*,
                int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateJobOnPrinterWithAttributes(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
        )]
            IIterable<IntPtr>* jobAttributes,
        HSTRING targetContentType,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
        )]
            IIterable<IntPtr>* operationAttributes,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy"
        )]
            PrintWorkflowAttributesMergePolicy jobAttributesMergePolicy,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy"
        )]
            PrintWorkflowAttributesMergePolicy operationAttributesMergePolicy,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **"
        )]
            IPrintWorkflowPdlTargetStream* result
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPdlModificationRequestedEventArgs2,
                IIterable<IntPtr>*,
                HSTRING,
                IIterable<IntPtr>*,
                PrintWorkflowAttributesMergePolicy,
                PrintWorkflowAttributesMergePolicy,
                IPrintWorkflowPdlTargetStream*,
                int>)((*lpVtbl)[6])
        )(
            this,
            jobAttributes,
            targetContentType,
            operationAttributes,
            jobAttributesMergePolicy,
            operationAttributesMergePolicy,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateJobOnPrinterWithAttributesBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer jobAttributesBuffer,
        HSTRING targetContentType,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")]
            IBuffer operationAttributesBuffer,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy"
        )]
            PrintWorkflowAttributesMergePolicy jobAttributesMergePolicy,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy"
        )]
            PrintWorkflowAttributesMergePolicy operationAttributesMergePolicy,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **"
        )]
            IPrintWorkflowPdlTargetStream* result
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPdlModificationRequestedEventArgs2,
                IBuffer,
                HSTRING,
                IBuffer,
                PrintWorkflowAttributesMergePolicy,
                PrintWorkflowAttributesMergePolicy,
                IPrintWorkflowPdlTargetStream*,
                int>)((*lpVtbl)[7])
        )(
            this,
            jobAttributesBuffer,
            targetContentType,
            operationAttributesBuffer,
            jobAttributesMergePolicy,
            operationAttributesMergePolicy,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateJobOnPrinterWithAttributes(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
            )]
                IIterable<IntPtr>* jobAttributes,
            HSTRING targetContentType,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
            )]
                IIterable<IntPtr>* operationAttributes,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy"
            )]
                PrintWorkflowAttributesMergePolicy jobAttributesMergePolicy,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy"
            )]
                PrintWorkflowAttributesMergePolicy operationAttributesMergePolicy,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **"
            )]
                IPrintWorkflowPdlTargetStream* result
        );

        [VtblIndex(7)]
        HRESULT CreateJobOnPrinterWithAttributesBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")]
                IBuffer jobAttributesBuffer,
            HSTRING targetContentType,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")]
                IBuffer operationAttributesBuffer,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy"
            )]
                PrintWorkflowAttributesMergePolicy jobAttributesMergePolicy,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy"
            )]
                PrintWorkflowAttributesMergePolicy operationAttributesMergePolicy,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **"
            )]
                IPrintWorkflowPdlTargetStream* result
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy, ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            HSTRING,
            IIterable<IntPtr>*,
            PrintWorkflowAttributesMergePolicy,
            PrintWorkflowAttributesMergePolicy,
            IPrintWorkflowPdlTargetStream*,
            int> CreateJobOnPrinterWithAttributes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy, ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            HSTRING,
            IBuffer,
            PrintWorkflowAttributesMergePolicy,
            PrintWorkflowAttributesMergePolicy,
            IPrintWorkflowPdlTargetStream*,
            int> CreateJobOnPrinterWithAttributesBuffer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintWorkflowPdlModificationRequestedEventArgs2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowPdlModificationRequestedEventArgs2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPrintWorkflowPdlModificationRequestedEventArgs2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPrintWorkflowPdlModificationRequestedEventArgs2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowPdlModificationRequestedEventArgs2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPrintWorkflowPdlModificationRequestedEventArgs2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowPdlModificationRequestedEventArgs2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPrintWorkflowPdlModificationRequestedEventArgs2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
