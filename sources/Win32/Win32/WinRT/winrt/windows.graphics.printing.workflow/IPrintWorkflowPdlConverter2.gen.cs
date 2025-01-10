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

[Guid("854CEEC1-7837-5B93-B7AF-57A6998C2F71")]
[NativeTypeName("struct IPrintWorkflowPdlConverter2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPdlConverter2
    : IPrintWorkflowPdlConverter2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowPdlConverter2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPdlConverter2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintWorkflowPdlConverter2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintWorkflowPdlConverter2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPdlConverter2, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPrintWorkflowPdlConverter2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPrintWorkflowPdlConverter2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ConvertPdlAsync(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")]
            IWorkflowPrintTicket printTicket,
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream inputStream,
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
            IOutputStream outputStream,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::PdlConversionHostBasedProcessingOperations"
        )]
            PdlConversionHostBasedProcessingOperations hostBasedProcessingOperations,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowPdlConverter2,
                IWorkflowPrintTicket,
                IInputStream,
                IOutputStream,
                PdlConversionHostBasedProcessingOperations,
                IAsyncAction*,
                int>)((*lpVtbl)[6])
        )(this, printTicket, inputStream, outputStream, hostBasedProcessingOperations, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ConvertPdlAsync(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *"
            )]
                IWorkflowPrintTicket printTicket,
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")]
                IInputStream inputStream,
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
                IOutputStream outputStream,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PdlConversionHostBasedProcessingOperations"
            )]
                PdlConversionHostBasedProcessingOperations hostBasedProcessingOperations,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
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
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *, ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Graphics::Printing::Workflow::PdlConversionHostBasedProcessingOperations, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWorkflowPrintTicket,
            IInputStream,
            IOutputStream,
            PdlConversionHostBasedProcessingOperations,
            IAsyncAction*,
            int> ConvertPdlAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintWorkflowPdlConverter2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintWorkflowPdlConverter2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintWorkflowPdlConverter2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowPdlConverter2(Silk.NET.WinRT.IInspectable value)
    {
        return new IPrintWorkflowPdlConverter2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowPdlConverter2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowPdlConverter2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPrintWorkflowPdlConverter2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintWorkflowPdlConverter2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowPdlConverter2(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintWorkflowPdlConverter2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowPdlConverter2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowPdlConverter2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintWorkflowPdlConverter2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
