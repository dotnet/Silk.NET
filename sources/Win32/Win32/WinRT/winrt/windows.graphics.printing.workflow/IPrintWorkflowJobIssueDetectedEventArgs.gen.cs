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

[Guid("DE58A46E-E41E-550A-A9FB-4B1F93FB9D98")]
[NativeTypeName("struct IPrintWorkflowJobIssueDetectedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowJobIssueDetectedEventArgs
    : IPrintWorkflowJobIssueDetectedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowJobIssueDetectedEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowJobIssueDetectedEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintWorkflowJobIssueDetectedEventArgs, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintWorkflowJobIssueDetectedEventArgs, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IPrintWorkflowJobIssueDetectedEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowJobIssueDetectedEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowJobIssueDetectedEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_JobIssueKind(
        [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowJobIssueKind *")]
            PrintWorkflowJobIssueKind* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowJobIssueDetectedEventArgs,
                PrintWorkflowJobIssueKind*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowJobIssueDetectedEventArgs, HRESULT*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SkipSystemErrorToast([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowJobIssueDetectedEventArgs, byte*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SkipSystemErrorToast([NativeTypeName("boolean")] byte value)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowJobIssueDetectedEventArgs, byte, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PrinterJob(
        [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **")]
            IPrintWorkflowPrinterJob* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowJobIssueDetectedEventArgs,
                IPrintWorkflowPrinterJob*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Configuration(
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **"
        )]
            IPrintWorkflowConfiguration* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowJobIssueDetectedEventArgs,
                IPrintWorkflowConfiguration*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UILauncher(
        [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **")]
            IPrintWorkflowUILauncher* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowJobIssueDetectedEventArgs,
                IPrintWorkflowUILauncher*,
                int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* result
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowJobIssueDetectedEventArgs, IDeferral*, int>)(
                (*lpVtbl)[13]
            )
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_JobIssueKind(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowJobIssueKind *"
            )]
                PrintWorkflowJobIssueKind* value
        );

        [VtblIndex(7)]
        HRESULT get_ExtendedError(HRESULT* value);

        [VtblIndex(8)]
        HRESULT get_SkipSystemErrorToast([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_SkipSystemErrorToast([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_PrinterJob(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **"
            )]
                IPrintWorkflowPrinterJob* value
        );

        [VtblIndex(11)]
        HRESULT get_Configuration(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **"
            )]
                IPrintWorkflowConfiguration* value
        );

        [VtblIndex(12)]
        HRESULT get_UILauncher(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **"
            )]
                IPrintWorkflowUILauncher* value
        );

        [VtblIndex(13)]
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
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowJobIssueKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PrintWorkflowJobIssueKind*, int> get_JobIssueKind;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT*, int> get_ExtendedError;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SkipSystemErrorToast;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_SkipSystemErrorToast;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowPrinterJob*, int> get_PrinterJob;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowConfiguration*, int> get_Configuration;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowUILauncher*, int> get_UILauncher;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintWorkflowJobIssueDetectedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintWorkflowJobIssueDetectedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintWorkflowJobIssueDetectedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowJobIssueDetectedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPrintWorkflowJobIssueDetectedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowJobIssueDetectedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowJobIssueDetectedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPrintWorkflowJobIssueDetectedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintWorkflowJobIssueDetectedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowJobIssueDetectedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPrintWorkflowJobIssueDetectedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowJobIssueDetectedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowJobIssueDetectedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPrintWorkflowJobIssueDetectedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
