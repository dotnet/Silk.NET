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

[Guid("2E4E6216-3BE1-5F0F-5C81-A5A2BD4EAB0E")]
[NativeTypeName("struct IPrintWorkflowSubmittedOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowSubmittedOperation
    : IPrintWorkflowSubmittedOperation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowSubmittedOperation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowSubmittedOperation, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintWorkflowSubmittedOperation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintWorkflowSubmittedOperation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowSubmittedOperation, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowSubmittedOperation, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowSubmittedOperation, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Complete(
        [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus")]
            PrintWorkflowSubmittedStatus status
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowSubmittedOperation,
                PrintWorkflowSubmittedStatus,
                int>)((*lpVtbl)[6])
        )(this, status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Configuration(
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **"
        )]
            IPrintWorkflowConfiguration* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowSubmittedOperation,
                IPrintWorkflowConfiguration*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_XpsContent(
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSourceContent **"
        )]
            IPrintWorkflowSourceContent* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowSubmittedOperation,
                IPrintWorkflowSourceContent*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Complete(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus"
            )]
                PrintWorkflowSubmittedStatus status
        );

        [VtblIndex(7)]
        HRESULT get_Configuration(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **"
            )]
                IPrintWorkflowConfiguration* value
        );

        [VtblIndex(8)]
        HRESULT get_XpsContent(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSourceContent **"
            )]
                IPrintWorkflowSourceContent* value
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
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PrintWorkflowSubmittedStatus, int> Complete;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowConfiguration*, int> get_Configuration;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSourceContent **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintWorkflowSourceContent*, int> get_XpsContent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintWorkflowSubmittedOperation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintWorkflowSubmittedOperation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintWorkflowSubmittedOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowSubmittedOperation(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPrintWorkflowSubmittedOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowSubmittedOperation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowSubmittedOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPrintWorkflowSubmittedOperation value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintWorkflowSubmittedOperation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowSubmittedOperation(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPrintWorkflowSubmittedOperation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowSubmittedOperation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowSubmittedOperation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPrintWorkflowSubmittedOperation value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
