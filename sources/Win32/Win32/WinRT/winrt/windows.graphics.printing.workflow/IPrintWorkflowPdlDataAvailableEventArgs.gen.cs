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

[Guid("D4AD6B50-1547-5991-A0EF-E2EE20211518")]
[NativeTypeName("struct IPrintWorkflowPdlDataAvailableEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPdlDataAvailableEventArgs
    : IPrintWorkflowPdlDataAvailableEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowPdlDataAvailableEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPdlDataAvailableEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintWorkflowPdlDataAvailableEventArgs, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintWorkflowPdlDataAvailableEventArgs, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IPrintWorkflowPdlDataAvailableEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPdlDataAvailableEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPdlDataAvailableEventArgs, TrustLevel*, int>)(
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
                IPrintWorkflowPdlDataAvailableEventArgs,
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
                IPrintWorkflowPdlDataAvailableEventArgs,
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
                IPrintWorkflowPdlDataAvailableEventArgs,
                IPrintWorkflowPdlSourceContent*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* result
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowPdlDataAvailableEventArgs, IDeferral*, int>)(
                (*lpVtbl)[9]
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
            "HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintWorkflowPdlDataAvailableEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintWorkflowPdlDataAvailableEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintWorkflowPdlDataAvailableEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowPdlDataAvailableEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPrintWorkflowPdlDataAvailableEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowPdlDataAvailableEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowPdlDataAvailableEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPrintWorkflowPdlDataAvailableEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintWorkflowPdlDataAvailableEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowPdlDataAvailableEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPrintWorkflowPdlDataAvailableEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowPdlDataAvailableEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowPdlDataAvailableEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPrintWorkflowPdlDataAvailableEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
